using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Absensi_Mahasiswa
{
    public partial class FMataKuliah : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");
        string opsi;
        public FMataKuliah()
        {
            InitializeComponent();
            data();
        }

        private void proses()
        {
            Btn_hapus.Enabled = false;
            Btn_ubah.Enabled = false;
            Btn_tambah.Enabled = false;
        }

        private void data()
        {
            cn.Close();
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM mata_kuliah", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "Kode";
            dg.Columns[1].HeaderText = "Mata Kuliah";
            dg.Columns[2].HeaderText = "SKS";

            dg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].Width = 100;
            dg.Columns[1].Width = 300;
            dg.Columns[2].Width = 50;

            dg.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            dg.ReadOnly = true;

            dg.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;

            dt.Dispose();
            da.Dispose();
        }

        private void reset()
        {
            txt_kode.Text = "";
            txt_matkul.Text = "";
            txt_sks.Text = "";
            Btn_hapus.Enabled = true;
            Btn_simpan.Enabled = false;
            Btn_ubah.Enabled = true;
            Btn_tambah.Enabled = true;
            dg.Enabled = false;
            txt_kode.Enabled = false;
            txt_matkul.Enabled = false;
            txt_sks.Enabled = false;
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kembali ke halaman utama ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FUtamaOperator n = new FUtamaOperator();
                n.Show();
                this.Dispose();
            }
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
            opsi = "tambah";
            proses();
            txt_kode.Enabled = true;
            Btn_simpan.Enabled = true;
            txt_matkul.Enabled = true;
            txt_sks.Enabled = true;
            txt_kode.Focus();
        }

        private void Btn_ubah_Click(object sender, EventArgs e)
        {
            opsi = "ubah";
            Btn_hapus.Enabled = false;
            Btn_tambah.Enabled = false;
            Btn_simpan.Enabled = false;
            Btn_ubah.Enabled = false;
            dg.Enabled = true;
        }

        private void Btn_hapus_Click(object sender, EventArgs e)
        {
            opsi = "hapus";
            dg.Enabled = true;
            Btn_hapus.Enabled = false;
            Btn_tambah.Enabled = false;
            Btn_simpan.Enabled = false;
            Btn_ubah.Enabled = false;
        }

        private void Btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_kode.Text == "")
            {
                MessageBox.Show("Masukkan kode mata kuliah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_kode.Focus();
            } else
            if (txt_matkul.Text == "")
            {
                MessageBox.Show("Masukkan nama mata kuliah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_matkul.Focus();
            } else
            if (txt_sks.Text == "")
            {
                MessageBox.Show("Masukkan SKS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_sks.Focus();
            } else
            {
                if (opsi == "tambah")
                {
                    try
                    {
                        cn.Close();
                        cn.Open();
                        MySqlCommand com = new MySqlCommand();
                        string sqll = "INSERT INTO mata_kuliah SET kd_matkul='" + txt_kode.Text + "', nm_matkul='" + txt_matkul.Text
                                      + "', sks='" + txt_sks.Text + "'";
                        com.CommandText = sqll;
                        com.CommandType = CommandType.Text;
                        com.Connection = cn;
                        var a = com.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil ditambahkan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data();
                        reset();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kode mata kuliah sudah ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_kode.SelectAll();
                        txt_kode.Focus();
                        return;
                    }   
                }
                else
                if (opsi == "ubah")
                {
                    cn.Close();
                    cn.Open();
                    MySqlCommand comm = new MySqlCommand();
                    string sql = "UPDATE mata_kuliah SET nm_matkul='" + txt_matkul.Text + "', sks='" + txt_sks.Text
                                 + "' WHERE kd_matkul='" + txt_kode.Text + "'";
                    comm.CommandText = sql;
                    comm.Connection = cn;
                    comm.ExecuteNonQuery();
                    comm.Dispose();
                    MessageBox.Show("Data berhasil diubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data();
                    reset();
                    comm.Dispose();
                }
                else
                if (opsi == "hapus")
                {
                    cn.Close();
                    cn.Open();
                    MySqlCommand comm = new MySqlCommand();
                    string sql = "DELETE FROM mata_kuliah WHERE kd_matkul='" + txt_matkul.Text + "'";
                    comm.CommandText = sql;
                    comm.Connection = cn;
                    comm.ExecuteNonQuery();
                    comm.Dispose();
                    MessageBox.Show("Data berhasil dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data();
                    reset();
                    comm.Dispose();
                }
            }
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dg.Rows[e.RowIndex];
            txt_kode.Text = r.Cells[0].Value.ToString();
            txt_matkul.Text = r.Cells[1].Value.ToString();
            txt_sks.Text = r.Cells[2].Value.ToString();

            if(opsi == "hapus")
                {
                txt_kode.Enabled = false;
                txt_matkul.Enabled = false;
                txt_sks.Enabled = false;
                Btn_simpan.Enabled = true;
            } else
            if (opsi == "ubah")
            {
                txt_kode.Enabled = false;
                txt_matkul.Enabled = true;
                txt_sks.Enabled = true;
                Btn_simpan.Enabled = true;
            }
        }

        private void FMataKuliah_Load(object sender, EventArgs e)
        {

        }
    }
}
