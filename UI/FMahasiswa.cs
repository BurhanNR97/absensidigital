using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.Xml;

namespace Absensi_Mahasiswa
{
    public partial class FMahasiswa : Form
    {
        public FMahasiswa()
        {
            InitializeComponent();
            data();
        }

        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");
        string opsi;

        private void aktif()
        {
            if (opsi == "tambah")
            {
                Btn_foto.Enabled = true;
            }
            else
            {
                Btn_foto.Enabled = false;
                Btn_simpan.Enabled = false;
            }
            txt_npm.Enabled = true;
            txt_alamat.Enabled = true;
            txt_email.Enabled = true;
            CB_angkatan.Enabled = true;
            CB_jurusan.Enabled = true;
            txt_nama.Enabled = true;
            txt_telp.Enabled = true;
            txt_tmplahir.Enabled = true;
            DTP_tanggal.Enabled = true;
            CB_agama.Enabled = true;
            CB_gender.Enabled = true;
        }

        private void mati()
        {
            txt_npm.Enabled = false;
            txt_npm.Text = "";
            Btn_foto.Enabled = false;
            txt_alamat.Enabled = false;
            txt_email.Enabled = false;
            txt_nama.Enabled = false;
            txt_telp.Enabled = false;
            txt_tmplahir.Enabled = false;
            DTP_tanggal.Enabled = false;
            CB_agama.Enabled = false;
            CB_angkatan.Enabled = false;
            CB_jurusan.Enabled = false;
            CB_gender.Enabled = false;
            txt_alamat.Text = "";
            txt_email.Text = "";
            txt_nama.Text = "";
            txt_telp.Text = "";
            txt_tmplahir.Text = "";
            DTP_tanggal.Text = DateTime.Now.ToString();
            CB_agama.SelectedIndex = 0;
            CB_gender.SelectedIndex = 0;
            CB_agama.StartIndex = 1;
            CB_gender.StartIndex = 1;
            CB_agama.StartIndex = 0;
            CB_gender.StartIndex = 0;
            PB_foto.Image = null;
        }

        private void simpanproses()
        {
            if (opsi == "tambah")
            {
                tambahdata();
            }
            else
            if (opsi == "ubah")
            {
                ubahdata(); Btn_cetak.Enabled = true;
                Btn_foto.Enabled = false;
                Btn_hapus.Enabled = true;
                Btn_simpan.Enabled = false;
                Btn_tambah.Enabled = true;
                Btn_ubah.Enabled = true;
            }
            else
            if (opsi == "hapus")
            {
                hapusdata();
                Btn_cetak.Enabled = true;
                Btn_foto.Enabled = false;
                Btn_hapus.Enabled = true;
                Btn_simpan.Enabled = false;
                Btn_tambah.Enabled = true;
                Btn_ubah.Enabled = true;
            }
        }

        private void data()
        {
            cn.Close();
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT npm, nm_mahasiswa, tempat_lahir, tgl_lahir, gender,  agama, alamat, telp, email FROM mahasiswa", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "npm";
            dg.Columns[1].HeaderText = "Nama mahasiswa";
            dg.Columns[2].HeaderText = "Tempat Lahir";
            dg.Columns[3].HeaderText = "Tanggal Lahir";
            dg.Columns[4].HeaderText = "L/P";
            dg.Columns[5].HeaderText = "Agama";
            dg.Columns[6].HeaderText = "Alamat";
            dg.Columns[7].HeaderText = "No. Telepon";
            dg.Columns[8].HeaderText = "Email";

            dg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].Width = 100;
            dg.Columns[1].Width = 200;
            dg.Columns[2].Width = 100;
            dg.Columns[3].Width = 110;
            dg.Columns[4].Width = 40;
            dg.Columns[5].Width = 100;
            dg.Columns[6].Width = 230;
            dg.Columns[7].Width = 100;
            dg.Columns[8].Width = 150;


            dg.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[3].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[4].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[5].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[6].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[7].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[8].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            dg.ReadOnly = true;

            dg.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;

            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dt.Dispose();
            da.Dispose();
        }

        private void tambahdata()
        {
            try
            {
                cn.Close();
                cn.Open();
                MySqlCommand comm = new MySqlCommand();
                if (PB_foto.Image == null)
                {
                    string sql = "INSERT INTO mahasiswa SET npm='" + txt_npm.Text + "', nm_mahasiswa='" + txt_nama.Text + "', tempat_lahir = '"
                                 + txt_tmplahir.Text + "', tgl_lahir='" + DTP_tanggal.Value.ToString("yyyy-MM-dd") + "', gender = '" + CB_gender.Text + "', agama='"
                                 + CB_agama.Text + "', jurusan='" + CB_jurusan.Text + "', angkatan = '" + CB_angkatan.Text + "',  alamat ='"
                                 + txt_alamat.Text + "', telp='" + txt_telp.Text + "', email='" + txt_email.Text + "', foto='null'";
                    comm.CommandText = sql;
                    comm.Connection = cn;
                    comm.ExecuteReader();
                    comm.Dispose();
                }
                else
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(txt_fotopath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = "INSERT INTO mahasiswa SET npm='" + txt_npm.Text + "', nm_mahasiswa='" + txt_nama.Text + "', tempat_lahir = '"
                                 + txt_tmplahir.Text + "', tgl_lahir='" + DTP_tanggal.Value.ToString("yyyy-MM-dd") + "', gender = '" + CB_gender.Text + "', agama='"
                                 + CB_agama.Text + "', jurusan='" + CB_jurusan.Text + "', angkatan = '" + CB_angkatan.Text + "',  alamat ='"
                                 + txt_alamat.Text + "', telp='" + txt_telp.Text + "', email='" + txt_email.Text + "', foto=@img";
                    comm.CommandText = sql;
                    comm.Connection = cn;
                    comm.Parameters.Add(new MySqlParameter("@img", img));
                    comm.ExecuteReader();
                    comm.Dispose();
                    comm.Dispose();
                }
                MessageBox.Show("Data berhasil ditambahkan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data();
                mati();
                Btn_cetak.Enabled = true;
                Btn_foto.Enabled = false;
                Btn_hapus.Enabled = true;
                Btn_simpan.Enabled = false;
                Btn_tambah.Enabled = true;
                Btn_ubah.Enabled = true;
            } catch (Exception)
            {
                MessageBox.Show("NPM sudah digunakan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_npm.SelectAll();
                txt_npm.Focus();
                return;
            }
        }

        private void ubahdata()
        {
            cn.Close();
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            if (PB_foto.Image == null)
            {
                string sql = "UPDATE mahasiswa SET nm_mahasiswa='" + txt_nama.Text + "', tempat_lahir = '"
                             + txt_tmplahir.Text + "', tgl_lahir='" + DTP_tanggal.Value.ToString("yyyy-MM-dd") + "', gender = '" + CB_gender.Text + "', agama='"
                             + CB_agama.Text + "', jurusan='" + CB_jurusan.Text + "', angkatan = '" + CB_angkatan.Text + "', alamat ='"
                             + txt_alamat.Text + "', telp='" + txt_telp.Text + "', email='" + txt_email.Text + "' WHERE npm='" + txt_npm.Text + "'";
                comm.CommandText = sql;
                comm.Connection = cn;
                comm.ExecuteReader();
                comm.Dispose();
            }
            else
            {
                byte[] img = null;
                FileStream fs = new FileStream(txt_fotopath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "UPDATE mahasiswa SET nm_mahasiswa='" + txt_nama.Text + "', tempat_lahir = '"
                             + txt_tmplahir.Text + "', tgl_lahir='" + DTP_tanggal.Value.ToString("yyyy-MM-dd") + "', gender = '" + CB_gender.Text + "', agama='"
                             + CB_agama.Text + "', jurusan='" + CB_jurusan.Text + "', angkatan = '" + CB_angkatan.Text + "', alamat ='"
                             + txt_alamat.Text + "', telp='" + txt_telp.Text + "', email='" + txt_email.Text + "', foto=@img WHERE npm='" + txt_npm.Text + "'";
                comm.CommandText = sql;
                comm.Connection = cn;
                comm.Parameters.Add(new MySqlParameter("@img", img));
                comm.ExecuteReader();
                comm.Dispose();
                comm.Dispose();
            }
            MessageBox.Show("Data berhasil diubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data();
            mati();
        }

        private void hapusdata()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "DELETE FROM mahasiswa WHERE npm='" + txt_npm.Text + "'";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            comm.Dispose();
            MessageBox.Show("Data berhasil dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data();
            mati();
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

        private void FMahasiswa_Load(object sender, EventArgs e)
        {
            DTP_tanggal.Text = DateTime.Now.ToString("d MMMM yyyy");
        }

        private void Btn_tambah_Click(object sender, EventArgs e)
        {
            opsi = "tambah";
            if (Btn_tambah.Enabled == true)
            {
                Btn_simpan.Enabled = true;
                Btn_tambah.Enabled = false;
                Btn_hapus.Enabled = false;
                Btn_ubah.Enabled = false;
                aktif();
                txt_npm.Focus();
            }
        }

        private void Btn_foto_Click(object sender, EventArgs e)
        {
           MessageBox.Show("File foto maksimal 2MB", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            using (OpenFileDialog n = new OpenFileDialog() { Multiselect = false, Filter = "JPG Files |*.jpg|PNG Files |*.png" })
            {
                DialogResult dr = n.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    PB_foto.Image = Image.FromFile(n.FileName);
                    txt_fotopath.Text = n.FileName.ToString();
                    MemoryStream ms = new MemoryStream();
                    PB_foto.Image.Save(ms, ImageFormat.Jpeg);
                    PB_foto.SizeMode = PictureBoxSizeMode.Zoom;
                    Bitmap bitmap = new Bitmap(PB_foto.Image);

                }
                else
                if (dr == DialogResult.Abort)
                {
                    return;
                }
            } 
        }

        private void Btn_ubah_Click(object sender, EventArgs e)
        {
            opsi = "ubah";
            dg.Enabled = true;
            Btn_simpan.Enabled = false;
            Btn_tambah.Enabled = false;
            Btn_hapus.Enabled = false;
            Btn_foto.Enabled = false;
            Btn_ubah.Enabled = false;
        }

        private void Btn_batal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ingin membatalkan proses ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                mati();
                Btn_cetak.Enabled = true;
                Btn_tambah.Enabled = true;
                Btn_ubah.Enabled = true;
                Btn_hapus.Enabled = true;
                Btn_foto.Enabled = false;
                Btn_simpan.Enabled = false;
                dg.Enabled = false;
            }
            else { }
        }

        private void Btn_hapus_Click(object sender, EventArgs e)
        {
            opsi = "hapus";
            dg.Enabled = true;
            mati();
            Btn_foto.Enabled = false;
            Btn_simpan.Enabled = false;
            Btn_tambah.Enabled = false;
            Btn_hapus.Enabled = false;
            Btn_ubah.Enabled = false;
        }

        private void Btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_npm.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_npm.Focus();
            }
            else
            if (txt_nama.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nama.Focus();
            }
            else
            if (txt_tmplahir.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tmplahir.Focus();
            }
            else
            if (DTP_tanggal.Text == DateTime.Now.ToShortDateString())
            {
                MessageBox.Show("Tanggal Lahir tidak benar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP_tanggal.Focus();
            }
            else
            if (CB_gender.SelectedIndex == 0)
            {
                MessageBox.Show("Pilih jenis kelamin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CB_gender.Focus();
            }
            else
            if (CB_agama.SelectedIndex == 0)
            {
                MessageBox.Show("Pilih data terlbih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CB_agama.Focus();
            }
            else
            if (txt_alamat.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_alamat.Focus();
            }
            else
            if (txt_telp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telp.Focus();
            }
            else
            if (txt_email.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
            }
            else
            {
                simpanproses();
                dg.Enabled = false;
            }
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aktif();
            if (opsi == "ubah")
            {
                Btn_foto.Enabled = true;
            }
            else
            if (opsi == "hapus")
            {
                Btn_foto.Enabled = false;
            }
            Btn_simpan.Enabled = true;
            DataGridViewRow r = dg.Rows[e.RowIndex];
            txt_npm.Text = r.Cells[0].Value.ToString();
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT * from mahasiswa WHERE npm='" + txt_npm.Text + "'";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                DTP_tanggal.Value.ToString("dddd, dd MMMM yyyy");
                txt_alamat.Text = reader["alamat"].ToString();
                txt_email.Text = reader["email"].ToString();
                txt_nama.Text = reader["nm_mahasiswa"].ToString();
                txt_telp.Text = reader["telp"].ToString();
                txt_tmplahir.Text = reader["tempat_lahir"].ToString();
                CB_agama.SelectedItem = reader["agama"].ToString();
                CB_angkatan.SelectedItem = reader["angkatan"].ToString();
                CB_jurusan.SelectedItem = reader["jurusan"].ToString();
                DTP_tanggal.Text = reader["tgl_lahir"].ToString(); DTP_tanggal.Value.ToString("dd MMMM yyyy");
                string jk = reader["gender"].ToString();
                if (jk == "L")
                {
                    CB_gender.SelectedIndex = 1;
                }
                else
                if (jk == "P")
                {
                    CB_gender.SelectedIndex = 2;
                }

                    byte[] foto = ((byte[])reader.GetValue(0));
                    MemoryStream img = new MemoryStream(foto);
                    PB_foto.Image = Image.FromStream(img);
                    PB_foto.SizeMode = PictureBoxSizeMode.Zoom;
                    txt_fotopath.Text = PB_foto.ToString();
                    PB_foto.BorderStyle = BorderStyle.FixedSingle;
                    //string dtfoto = reader.GetValue(11).ToString();
                    //string dtfoto = reader["foto"].ToString();
                    /* if (foto != null)
                     {
                         
                     } else
                     {
                         PB_foto.Image = null;
                     } */
            }
            else
            { }
            comm.Dispose();
        }
    }
}
