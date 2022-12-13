using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Absensi_Mahasiswa
{
    public partial class FDataAkunPengguna : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");
        string opsi;

        public FDataAkunPengguna()
        {
            InitializeComponent();
            data();
        }

        public void proses()
        {
            Btn_hapus.Enabled = false;
            Btn_ubah.Enabled = false;
            Btn_tambah.Enabled = false;
        }

        private void data()
        {
            Btn_simpan.Enabled = true;
            cn.Close();
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM user ORDER BY id_user ASC", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "ID User";
            dg.Columns[1].HeaderText = "Username";
            dg.Columns[2].HeaderText = "Password";
            dg.Columns[3].HeaderText = "Level";

            dg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].Width = 120;
            dg.Columns[1].Width = 250;
            dg.Columns[2].Width = 250;
            dg.Columns[3].Width = 120;

            dg.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[3].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            dg.ReadOnly = true;

            dg.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;

            dt.Dispose();
            da.Dispose();
        }

        private void reset()
        {
            txt_id.Text = "";
            txt_username.Text = "";
            txt_password.Text = "";
            CB_level.SelectedIndex = 0;
            Btn_hapus.Enabled = true;
            Btn_simpan.Enabled = false;
            Btn_ubah.Enabled = true;
            Btn_tambah.Enabled = true;
            dg.Enabled = false;
            txt_username.Enabled = false;
            txt_password.Enabled = false;
            CB_level.Enabled = false;
        }

        private void id()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT * from user ORDER BY id_user DESC";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                string a = reader["id_user"].ToString().Substring(3);
                int b = int.Parse(a);
                int c = b + 1;
                txt_id.Text = "ID-" + c;
            }
            else
            {
                txt_id.Text = "ID-10100001";
            }
            comm.Dispose();
        }

        private void tambahdata()
        {
            try
            {
                cn.Close();
                cn.Open();
                MySqlCommand com = new MySqlCommand();
                string sqll = "INSERT INTO user SET id_user='" + txt_id.Text + "', username='" + txt_username.Text + "', password='"
                             + txt_password.Text + "', hak_akses='" + CB_level.SelectedItem.ToString() + "'";
                com.CommandText = sqll;
                com.Connection = cn;
                com.ExecuteReader();
                MessageBox.Show("Data berhasil ditambahkan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data();
                reset();
            } catch (Exception)
            {
                MessageBox.Show("username sudah digunakan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.SelectAll();
                txt_username.Focus();
                return;
            }
        }

        private void ubahdata()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "UPDATE user SET username='" + txt_username.Text + "', password='"+ txt_password.Text
                         + "', hak_akses='" + CB_level.SelectedItem.ToString() + "' WHERE id_user='" + txt_id.Text + "'";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            comm.Dispose();
        }

        private void hapusdata()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "DELETE FROM user WHERE username='" + txt_username.Text + "'";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();   
            comm.Dispose();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kembali ke halaman utama ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FUtamaAdmin n = new FUtamaAdmin();
                n.Show();
                this.Dispose();
            }
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FDataAkunPengguna_Load(object sender, EventArgs e)
        {
            Btn_simpan.Enabled = false;
        }

        private void Btn_batal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin membatalkan proses ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                reset();
            }
            else { }
        }

        private void Btn_tambah_Click(object sender, EventArgs e)
        {
            if (Btn_tambah.Enabled == true)
            {
                opsi = "tambah";
                proses();
                id();
                Btn_simpan.Enabled = true;
                txt_username.Enabled = true;
                txt_password.Enabled = true;
                CB_level.Enabled = true;
                txt_username.Focus();
            } else { }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg.Enabled == true)
            {
                DataGridViewRow r = dg.Rows[e.RowIndex];
                txt_id.Text = r.Cells[0].Value.ToString();
                txt_username.Text = r.Cells[1].Value.ToString();
                txt_password.Text = r.Cells[2].Value.ToString();
                CB_level.SelectedItem = r.Cells[3].Value.ToString();
                
                if (opsi == "hapus")
                {
                    txt_password.Enabled = false;
                    txt_username.Enabled = false;
                    CB_level.Enabled = false;
                    Btn_simpan.Enabled = true;
                } else
                if (opsi == "ubah")
                {
                    txt_password.Enabled = true;
                    txt_username.Enabled = true;
                    CB_level.Enabled = true;
                    Btn_simpan.Enabled = true;
                }
            }
        }

        private void Btn_ubah_Click(object sender, EventArgs e)
        {
            if (Btn_ubah.Enabled == true)
            {
                opsi = "ubah";
                proses();
                dg.Enabled = true;
                txt_username.Focus();
            }
            else { }
        }

        private void Btn_hapus_Click(object sender, EventArgs e)
        {
            if (Btn_hapus.Enabled == true)
            {
                opsi = "hapus";
                proses();
                dg.Enabled = true;
            }
        }

        private void Btn_simpan_Click(object sender, EventArgs e)
        {
            if (opsi == "tambah")
            {
                if (txt_username.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Focus();
                }
                else
                if (txt_password.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Focus();
                }
                else
                if (CB_level.SelectedIndex == 0)
                {
                    MessageBox.Show("Silahkan pilih level/hak akses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CB_level.Focus();
                }
                else
                {
                    tambahdata();
                }
            }
            else
            if (opsi == "ubah")
            {
                if (txt_username.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Focus();
                }
                else
                if (txt_password.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Focus();
                }
                else
                if (CB_level.SelectedIndex == 0)
                {
                    MessageBox.Show("Silahkan pilih level/hak akses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CB_level.Focus();
                }
                else
                {
                    ubahdata();
                    MessageBox.Show("Data berhasil ditambahkan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data();
                    reset();
                }
            }
            else
            if (opsi == "hapus")
            {
                hapusdata();
                MessageBox.Show("Data berhasil dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data();
                reset();
            }
        }
    }
}
