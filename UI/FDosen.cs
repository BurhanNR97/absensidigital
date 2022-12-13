using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Absensi_Mahasiswa.UI;
using System.Data.SqlClient;

namespace Absensi_Mahasiswa
{
    public partial class FDosen : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");
        string opsi;
        public FDosen()
        {
            InitializeComponent();
            data();
        }

        private void tambahakundosen()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader r;
            MySqlCommand cm = new MySqlCommand();
            cm.CommandText = "SELECT * FROM user ORDER BY id_user DESC ";
            cm.Connection = cn;
            r = cm.ExecuteReader();
            if (r.Read())
            {
                string i = r["id_user"].ToString().Substring(3);
                int idd = int.Parse(i);
                int iddd = idd + 1;
                string id = "ID-"+iddd.ToString();
                
                    string password = DTP_tanggal.Value.ToString("ddMMyy");
                    cn.Close();
                    cn.Open();
                    cm.Dispose();
                    MySqlCommand comm = new MySqlCommand();
                    comm.CommandText = "INSERT INTO user SET id_user='"+id+"', username = '"+txt_nidn.Text
                                       +"', password='"+password+"', hak_akses='Dosen'";
                    comm.Connection = cn;
                    comm.ExecuteNonQuery();
                    comm.Dispose();
               
            }
            cm.Dispose();
            cn.Close();
        }

        private void ubahakundosen()
        {
            string password = DTP_tanggal.Value.ToString("ddMMyy");
            cn.Close();
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE user SET password='" + password + "', hak_akses='Dosen' WHERE username = '"
                               + txt_nidn.Text + "'";
            comm.Connection = cn;
            comm.ExecuteNonQuery();
            comm.Dispose();
            cn.Close();
        }

        private void hapusakundosen()
        {
            cn.Close();
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM user WHERE username = '"+ txt_nidn.Text + "'";
            comm.Connection = cn;
            comm.ExecuteNonQuery();
            comm.Dispose();
            cn.Close();
        }

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
            txt_alamat.Enabled = true;
            txt_email.Enabled = true;
            txt_nama.Enabled = true;
            txt_jabatan.Enabled = true;
            txt_telp.Enabled = true;
            txt_tmplahir.Enabled = true;
            DTP_tanggal.Enabled = true;
            CB_agama.Enabled = true;
            CB_gender.Enabled = true;
        }

        private void mati()
        {
            txt_nidn.Enabled = false;
            txt_nidn.Text = "";
            Btn_foto.Enabled = false;
            txt_alamat.Enabled = false;
            txt_email.Enabled = false;
            txt_jabatan.Enabled = false;
            txt_nama.Enabled = false;
            txt_telp.Enabled = false;
            txt_tmplahir.Enabled = false;
            DTP_tanggal.Enabled = false;
            CB_agama.Enabled = false;
            CB_gender.Enabled = false;
            txt_alamat.Text = "";
            txt_email.Text = "";
            txt_jabatan.Text = "";
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
                ubahdata();
                Btn_cetak.Enabled = true;
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
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nidn, nm_dosen, tempat_lahir, tgl_lahir, gender, jabatan, agama, alamat, telp, email FROM dosen", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "NIDN";
            dg.Columns[1].HeaderText = "Nama Dosen";
            dg.Columns[2].HeaderText = "Tempat Lahir";
            dg.Columns[3].HeaderText = "Tanggal Lahir";
            dg.Columns[4].HeaderText = "L/P";
            dg.Columns[5].HeaderText = "Jabatan";
            dg.Columns[6].HeaderText = "Agama";
            dg.Columns[7].HeaderText = "Alamat";
            dg.Columns[8].HeaderText = "No. Telepon";
            dg.Columns[9].HeaderText = "Email";

            dg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dg.Columns[0].Width = 100;
                dg.Columns[1].Width = 200;
                dg.Columns[2].Width = 100;
                dg.Columns[3].Width = 110;
                dg.Columns[4].Width = 40;
                dg.Columns[5].Width = 150;
                dg.Columns[6].Width = 100;
                dg.Columns[7].Width = 230;
                dg.Columns[8].Width = 100;
                dg.Columns[9].Width = 150;


            dg.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[3].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[4].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[5].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[6].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[7].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[8].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[9].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

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
            dg.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;

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
                MySqlDataReader reader;
                MySqlCommand comm = new MySqlCommand();
                if (PB_foto.Image == null)
                {
                    string sql = "INSERT INTO dosen SET nidn='" + txt_nidn.Text + "', nm_dosen='" + txt_nama.Text + "', tempat_lahir = '"
                                 + txt_tmplahir.Text + "', tgl_lahir='" + DTP_tanggal.Value.ToString("yyyy-MM-dd") + "', gender = '"+CB_gender.Text+"', jabatan='"
                                 + txt_jabatan.Text + "', agama='" + CB_agama.Text + "', alamat ='"
                                 + txt_alamat.Text + "', telp='" + txt_telp.Text + "', email='" + txt_email.Text + "'";
                    comm.CommandText = sql;
                    comm.Connection = cn;
                    reader = comm.ExecuteReader();
                    comm.Dispose();
                }
                else
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(txt_fotopath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = "INSERT INTO dosen SET nidn='" + txt_nidn.Text + "', nm_dosen='" + txt_nama.Text + "', tempat_lahir = '"
                                 + txt_tmplahir.Text + "', tgl_lahir='" + DTP_tanggal.Value.ToString("yyyy-MM-dd") + "', gender = '" + CB_gender.Text + "', jabatan='"
                                 + txt_jabatan.Text + "', agama='" + CB_agama.Text + "', alamat ='"
                                 + txt_alamat.Text + "', telp='" + txt_telp.Text + "', email='" + txt_email.Text + "', foto=@img";
                    comm.CommandText = sql;
                    comm.Connection = cn;
                    comm.Parameters.Add(new MySqlParameter("@img", img));
                    reader = comm.ExecuteReader();
                    comm.Dispose();
                }
                MessageBox.Show("Data berhasil ditambahkan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tambahakundosen();
                data();
                mati();
                Btn_foto.Enabled = false;
                Btn_simpan.Enabled = false;
                Btn_hapus.Enabled = true;
                Btn_ubah.Enabled = true;
                Btn_tambah.Enabled = true;
            } catch (Exception)
            {
                MessageBox.Show("NIDN sudah digunakan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nidn.SelectAll();
                txt_nidn.Focus();
                return;
            }
        }

        private void ubahdata()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            if (PB_foto.Image == null)
            {
                string sql = "UPDATE dosen SET nm_dosen='" + txt_nama.Text + "', tempat_lahir = '"
                             + txt_tmplahir.Text + "', tgl_lahir='" + DTP_tanggal.Value.ToString("yyyy-MM-dd") + "', gender = 'L', jabatan='"
                             + txt_jabatan.Text + "', agama='" + CB_agama.Text + "', alamat ='"
                             + txt_alamat.Text + "', telp='" + txt_telp.Text + "', email='" + txt_email.Text + "' WHERE nidn='" + txt_nidn.Text + "'";
                comm.CommandText = sql;
                comm.Connection = cn;
                reader = comm.ExecuteReader();
                comm.Dispose();
            }
            else
            {
                byte[] img = null;
                FileStream fs = new FileStream(txt_fotopath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "UPDATE dosen SET nm_dosen='" + txt_nama.Text + "', tempat_lahir = '"
                             + txt_tmplahir.Text + "', tgl_lahir='" + DTP_tanggal.Value.ToString("yyyy-MM-dd") + "', gender = 'L', jabatan='"
                             + txt_jabatan.Text + "', agama='" + CB_agama.Text + "', alamat ='"
                             + txt_alamat.Text + "', telp='" + txt_telp.Text + "', email='" + txt_email.Text + "', foto=@img WHERE nidn='" + txt_nidn.Text + "'";
                comm.CommandText = sql;
                comm.Connection = cn;
                comm.Parameters.Add(new MySqlParameter("@img", img));
                reader = comm.ExecuteReader();
                comm.Dispose();
            }
            MessageBox.Show("Data berhasil diubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ubahakundosen();
            data();
            mati();
            dg.Enabled = false;
        }

        private void hapusdata()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "DELETE FROM dosen WHERE nidn='" + txt_nidn.Text + "'";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            comm.Dispose();
            MessageBox.Show("Data berhasil dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hapusakundosen();
            data();
            dg.Enabled = false;
            mati();
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

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FDosen_Load(object sender, EventArgs e)
        {
            DTP_tanggal.Text = DateTime.Now.ToString("d MMMM yyyy");
        }

        private void Btn_foto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File foto maksimal 2MB", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            OpenFileDialog n = new OpenFileDialog();
            n.Filter = "JPG Files |*.jpg|PNG Files |*.png";
            DialogResult dr = n.ShowDialog();

            if (dr == DialogResult.OK)
            {
                PB_foto.Image = Image.FromFile(n.FileName);
                txt_fotopath.Text = n.FileName.ToString();
                MemoryStream ms = new MemoryStream();
                PB_foto.Image.Save(ms, ImageFormat.Jpeg);
                PB_foto.SizeMode = PictureBoxSizeMode.Zoom;
            } else
            if (dr == DialogResult.Abort)
            {
                return;
            }    
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_tambah_Click(object sender, EventArgs e)
        {
            opsi = "tambah";
            if (Btn_tambah.Enabled == true)
            {
                txt_nidn.Focus();
                Btn_simpan.Enabled = true;
                Btn_tambah.Enabled = false;
                Btn_hapus.Enabled = false;
                Btn_ubah.Enabled = false;
                aktif();
                txt_nidn.Enabled = true;
                txt_nidn.Focus();
            }
        }

        private void Btn_ubah_Click(object sender, EventArgs e)
        {
            opsi = "ubah";
            dg.Enabled = true;
            Btn_foto.Enabled = false;
            Btn_tambah.Enabled = false;
            Btn_hapus.Enabled = false;
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
                Btn_simpan.Enabled = false;
                dg.Enabled = false;
            } else { }
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

        private void Btn_cetak_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ingin mencetak semua data dosen ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                  
            } else { }
        }

        private void Btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_nidn.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nidn.Focus();
            } else
            if (txt_nama.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nama.Focus();
            } else
            if (txt_tmplahir.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tmplahir.Focus();
            } else
            if (DTP_tanggal.Text == DateTime.Now.ToShortDateString())
            {
                MessageBox.Show("Tanggal Lahir tidak benar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP_tanggal.Focus();
            } else
            if (CB_gender.SelectedIndex == 0)
            {
                MessageBox.Show("Pilih jenis kelamin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CB_gender.Focus();
            } else
            if (txt_jabatan.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_jabatan.Focus();
            } else
            if (CB_agama.SelectedIndex == 0)
            {
                MessageBox.Show("Pilih data terlbih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CB_agama.Focus();
            } else
            if (txt_alamat.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_alamat.Focus();
            } else
            if (txt_telp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_telp.Focus();
            } else
            if (txt_email.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
            } else
            {
                simpanproses();
                dg.Enabled = false;
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (opsi == "ubah")
            {
                aktif();
                Btn_foto.Enabled = true;
            }
            else
            if (opsi == "hapus")
            {
                Btn_foto.Enabled = false;
            }
            Btn_simpan.Enabled = true;
            DataGridViewRow r = dg.Rows[e.RowIndex];
            txt_nidn.Text = r.Cells[0].Value.ToString();
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT * from dosen WHERE nidn='" + txt_nidn.Text + "'";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                DTP_tanggal.Value.ToString("dddd, dd MMMM yyyy");
                txt_alamat.Text = reader["alamat"].ToString();
                txt_email.Text = reader["email"].ToString();
                txt_jabatan.Text = reader["jabatan"].ToString();
                txt_nama.Text = reader["nm_dosen"].ToString();
                txt_telp.Text = reader["telp"].ToString();
                txt_tmplahir.Text = reader["tempat_lahir"].ToString();
                CB_agama.SelectedItem = reader["agama"].ToString();
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

                string dtfoto = reader.GetValue(10).ToString();
                if (dtfoto.Equals(""))
                {
                    PB_foto.Image = null;
                }
                else
                {
                    byte[] foto = ((byte[])reader.GetValue(10));
                    MemoryStream img = new MemoryStream(foto);
                    PB_foto.Image = Image.FromStream(img);
                    PB_foto.SizeMode = PictureBoxSizeMode.Zoom;
                    PB_foto.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            else
            { }
            comm.Dispose();
        }
    }
}
