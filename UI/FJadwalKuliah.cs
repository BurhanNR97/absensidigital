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

    public partial class FJadwalKuliah : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");
        string opsi;
        string awal;
        string akhir;
        public FJadwalKuliah()
        {
            InitializeComponent();
            data();
            kd_matkul();
            dosen();
            nidn();
            nm_matkul();
        }

        private void reset()
        {
            Btn_simpan.Enabled = false;
            Btn_tambah.Enabled = true;
            Btn_ubah.Enabled = true;
            Btn_hapus.Enabled = true;
            txt_kode.Text = "";
            CB_jam.Enabled = false;
            CB_jurusan.Enabled = false;
            CB_kelas.Enabled = false;
            CB_semester.Enabled = false;
            CB_hari.Enabled = false;
            CB_dosen.SelectedIndex = 0;
            CB_jam.SelectedIndex = 0;
            CB_kelas.SelectedIndex = 0;
            CB_kodeMATKUL.SelectedIndex = 0;
            CB_namaMATKUL.SelectedIndex = 0;
            CB_hari.SelectedIndex = 0;
            CB_jurusan.SelectedIndex = 0;
            CB_semester.SelectedIndex = 0;
            CB_nidn.SelectedIndex = 0;
            CB_dosen.Enabled = false;
            CB_nidn.Enabled = false;
            CB_namaMATKUL.Enabled = false;
            CB_kodeMATKUL.Enabled = false;
            CB_kelas.Enabled = false;
            CB_jam.Enabled = false;
            dg.Enabled = false;
        }

        private void kode()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT * from jadwal_kuliah ORDER BY kd_jadwal DESC";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                string a = reader["kd_jadwal"].ToString().Substring(3);
                int b = int.Parse(a);
                int c = b + 1;
                txt_kode.Text = "JK-" + c;
            }
            else
            {
                txt_kode.Text = "JK-1001001";
            }
            comm.Dispose();
        }

        private void aktif()
        {
            CB_kelas.Enabled = true;
            CB_hari.Enabled = true;
            CB_jurusan.Enabled = true;
            CB_semester.Enabled = true;
            CB_jam.Enabled = true;
            CB_nidn.Enabled = true;
            CB_dosen.Enabled = true;
            CB_kodeMATKUL.Enabled = true;
            CB_namaMATKUL.Enabled = true;
        }

        private void proses()
        {
            Btn_hapus.Enabled = false;
            Btn_ubah.Enabled = false;
            Btn_tambah.Enabled = false;
        }

        private void nidn()
        {
            CB_nidn.Items.Clear();
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT nidn FROM dosen ORDER BY nidn ASC";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            CB_nidn.Items.Add("- Pilih -");
            try
            {
                while (reader.Read())
                {
                    CB_nidn.Items.Add(reader[0].ToString().ToString());
                    CB_nidn.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                CB_nidn.Items.Add("- Pilih -");
                CB_nidn.SelectedIndex = 0;
            }
            comm.Dispose();
        }
        private void dosen()
        {
            CB_dosen.Items.Clear();
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT nm_dosen FROM dosen ORDER BY nm_dosen ASC";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            CB_dosen.Items.Add("- Pilih -");
            try
            {
                while (reader.Read())
                {
                    CB_dosen.Items.Add(reader[0].ToString().ToString());
                    CB_dosen.SelectedIndex = 0;
                }
            } catch (Exception)
            {
                CB_dosen.Items.Add("- Pilih -");
                CB_dosen.SelectedIndex = 0;
            }
            comm.Dispose();
        }
        private void kd_matkul()
        {
            CB_kodeMATKUL.Items.Clear();
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT kd_matkul FROM mata_kuliah ORDER BY kd_matkul ASC";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            CB_kodeMATKUL.Items.Add("- Pilih -");
            try
            {
                while (reader.Read())
                {
                    CB_kodeMATKUL.Items.Add(reader["kd_matkul"].ToString());
                    CB_kodeMATKUL.SelectedIndex = 0;
                }
            } catch (Exception)
            {
                CB_kodeMATKUL.Items.Add("- Pilih -");
                CB_kodeMATKUL.SelectedIndex = 0;
            }
            comm.Dispose();
        }
        private void nm_matkul()
        {
            CB_namaMATKUL.Items.Clear();
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT nm_matkul FROM mata_kuliah ORDER BY nm_matkul ASC";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            CB_namaMATKUL.Items.Add("- Pilih -");
            try
            {
                while (reader.Read())
                {
                    CB_namaMATKUL.Items.Add(reader[0].ToString().ToString());
                    CB_namaMATKUL.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                CB_namaMATKUL.Items.Add("- Pilih -");
                CB_namaMATKUL.SelectedIndex = 0;
            }
            comm.Dispose();
        }

        private void data()
        {
            cn.Close();
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT a.kd_jadwal, a.nidn, b.nm_dosen, a.kd_matkul, c.nm_matkul, a.jurusan, a.semester, a.kelas, a.hari, a.jam_awal FROM jadwal_kuliah a INNER JOIN dosen b ON b.nidn=a.nidn INNER JOIN mata_kuliah c ON c.kd_matkul=a.kd_matkul", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "Kode Jadwal";
            dg.Columns[1].HeaderText = "NIDN";
            dg.Columns[2].HeaderText = "Nama Dosen";
            dg.Columns[3].HeaderText = "Kode Matkul";
            dg.Columns[4].HeaderText = "Nama Mata Kuliah";
            dg.Columns[5].HeaderText = "Jurusan";
            dg.Columns[6].HeaderText = "Semester";
            dg.Columns[7].HeaderText = "Kelas";
            dg.Columns[8].HeaderText = "Hari";
            dg.Columns[9].HeaderText = "Jam";

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
            dg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].Width = 100;
            dg.Columns[1].Width = 150;
            dg.Columns[2].Width = 250;
            dg.Columns[3].Width = 100;
            dg.Columns[4].Width = 270;
            dg.Columns[5].Width = 100;
            dg.Columns[6].Width = 100;
            dg.Columns[7].Width = 130;
            dg.Columns[8].Width = 150;
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

        private void Btn_tambah_Click(object sender, EventArgs e)
        {
            opsi = "tambah";
            proses();
            Btn_simpan.Enabled = true;
            aktif();
            kode();
            txt_kode.Focus();
        }

        private void CB_nidn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CB_nidn.SelectedIndex == 0)
            {
                CB_dosen.SelectedIndex = 0;
            } else
            {
                cn.Close();
                cn.Open();
                MySqlDataReader reader;
                MySqlCommand comm = new MySqlCommand();
                string sql = "SELECT nm_dosen FROM dosen WHERE nidn='"+CB_nidn.Text+"'";
                comm.CommandText = sql;
                comm.Connection = cn;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    CB_dosen.SelectedItem = reader[0].ToString();
                }
                comm.Dispose();
            }
        }

        private void CB_dosen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CB_dosen.SelectedIndex == 0)
            {
                CB_nidn.SelectedIndex = 0;
            } else
            {
                cn.Close();
                cn.Open();
                MySqlDataReader reader;
                MySqlCommand comm = new MySqlCommand();
                string sql = "SELECT nidn FROM dosen WHERE nm_dosen='" + CB_dosen.Text + "'";
                comm.CommandText = sql;
                comm.Connection = cn;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    CB_nidn.SelectedItem = reader[0].ToString();
                }
                comm.Dispose();
            }
        }

        private void CB_kodeMATKUL_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CB_kodeMATKUL.SelectedIndex == 0)
            {
                CB_namaMATKUL.SelectedIndex = 0;
            } else
            {
                cn.Close();
                cn.Open();
                MySqlDataReader reader;
                MySqlCommand comm = new MySqlCommand();
                string sql = "SELECT nm_matkul FROM mata_kuliah WHERE kd_matkul='" + CB_kodeMATKUL.Text + "'";
                comm.CommandText = sql;
                comm.Connection = cn;
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    CB_namaMATKUL.SelectedItem = reader[0].ToString();
                }
                comm.Dispose();
            }
        }

        private void CB_namaMATKUL_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CB_namaMATKUL.SelectedIndex == 0)
            {
                CB_kodeMATKUL.SelectedIndex = 0;
            } else
            {
                cn.Close();
                cn.Open();
                MySqlDataReader reader;
                MySqlCommand comm = new MySqlCommand();
                string sql = "SELECT kd_matkul FROM mata_kuliah WHERE nm_matkul='" + CB_namaMATKUL.Text + "'";
                comm.CommandText = sql;
                comm.Connection = cn;
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    CB_kodeMATKUL.SelectedItem = reader[0].ToString();
                }
                comm.Dispose();
            }
        }

        private void Btn_ubah_Click(object sender, EventArgs e)
        {
            opsi = "ubah";
            dg.Enabled = true;
            proses();
        }

        private void Btn_hapus_Click(object sender, EventArgs e)
        {
            opsi = "hapus";
            dg.Enabled = true;
            proses();
        }

        private void Btn_batal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin membatalkan proses ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reset();
                data();
            }
        }

        private void Btn_simpan_Click(object sender, EventArgs e)
        {
            if (CB_kelas.SelectedIndex == 0)
            {
                MessageBox.Show("Silahkan pilih kelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            if (CB_jam.SelectedIndex == 0)
            {
                MessageBox.Show("Silahkan pilih jam mengajar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (CB_nidn.SelectedIndex == 0)
            {
                MessageBox.Show("Silahkan pilih NIDN", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            if (CB_dosen.SelectedIndex == 0)
            {
                MessageBox.Show("Silahkan pilih dosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (CB_kodeMATKUL.SelectedIndex == 0)
            {
                MessageBox.Show("Silahkan pilih kode mata kuliah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (CB_namaMATKUL.SelectedIndex == 0)
            {
                MessageBox.Show("Silahkan pilih mata kuliah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (CB_hari.SelectedIndex == 0)
            {
                MessageBox.Show("Silahkan pilih hari mnegajar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (CB_jurusan.SelectedIndex == 0)
            {
                MessageBox.Show("Silahkan pilih jurusan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (CB_semester.SelectedIndex == 0)
            {
                MessageBox.Show("Silahkan pilih semester", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                jam();
                if (opsi == "tambah")
                {
                    cn.Close();
                    cn.Open();
                    MySqlCommand comm = new MySqlCommand();
                    string sql = "INSERT INTO jadwal_kuliah SET kd_jadwal='" + txt_kode.Text + "', nidn='" + CB_nidn.Text + "', kd_matkul='"
                                 + CB_kodeMATKUL.Text + "', jurusan='" + CB_jurusan.Text + "', semester='" + CB_semester.Text + "', kelas='"
                                 + CB_kelas.Text + "', hari='" + CB_hari.Text + "', jam_awal='" + awal + "', jam_akhir='"+akhir+"'";
                    comm.CommandText = sql;
                    comm.Connection = cn;
                    comm.ExecuteReader();
                    comm.Dispose();
                    MessageBox.Show("Data berhasil ditambahkan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                if (opsi == "ubah")
                {
                    cn.Close();
                    cn.Open();
                    MySqlCommand comm = new MySqlCommand();
                    string sql = "UPDATE jadwal_kuliah SET nidn='" + CB_nidn.Text + "', kd_matkul='"
                                 + CB_kodeMATKUL.Text + "', jurusan='" + CB_jurusan.Text + "', semester='" + CB_semester.Text + "', kelas='"
                                 + CB_kelas.Text + "', hari='" + CB_hari.Text + "', jam_awal='" + awal + "', jam_akhir='" + akhir + "' WHERE kd_jadwal='" + txt_kode.Text + "'";
                    comm.CommandText = sql;
                    comm.Connection = cn;
                    comm.ExecuteReader();
                    comm.Dispose();
                    MessageBox.Show("Data berhasil diubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                if (opsi == "hapus")
                {
                    cn.Close();
                    cn.Open();
                    MySqlCommand comm = new MySqlCommand();
                    string sql = "DELETE FROM jadwal_kuliah WHERE kd_jadwal='" + txt_kode.Text + "'";
                    comm.CommandText = sql;
                    comm.Connection = cn;
                    comm.ExecuteReader();
                    MessageBox.Show("Data berhasil dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comm.Dispose();
                }
                reset();
                data();
            }
        }

        private void FJadwalKuliah_Load(object sender, EventArgs e)
        {
            
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dg.Rows[e.RowIndex];
            txt_kode.Text = r.Cells[0].Value.ToString();

            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT a.nidn, b.nm_dosen, a.kd_matkul, c.nm_matkul, a.jurusan, a.semester, a.kelas, a.hari, a.jam_awal FROM jadwal_kuliah a INNER JOIN dosen b ON b.nidn=a.nidn INNER JOIN mata_kuliah c ON c.kd_matkul=a.kd_matkul WHERE a.kd_jadwal = '" + txt_kode.Text + "'";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                CB_jurusan.SelectedItem = reader[4].ToString();
                CB_semester.SelectedItem = reader[5].ToString();
                CB_kelas.SelectedItem = reader[6].ToString();
                CB_hari.SelectedItem = reader[7].ToString();
                string j = reader[8].ToString();
                if (j=="08:00:00")
                {
                    CB_jam.SelectedIndex = 1;
                } else
                if (j == "10:00:00")
                {
                    CB_jam.SelectedIndex = 2;
                } else
                if (j == "13:00:00")
                {
                    CB_jam.SelectedIndex = 3;
                } else
                if (j == "15:00:00")
                {
                    CB_jam.SelectedIndex = 4;
                } else
                if (j == "17:00:00")
                {
                    CB_jam.SelectedIndex = 5;
                } else
                if (j == "19:00:00")
                {
                    CB_jam.SelectedIndex = 6;
                }
                CB_nidn.SelectedItem = reader[0].ToString();
                CB_dosen.SelectedItem = reader[1].ToString();
                CB_kodeMATKUL.SelectedItem = reader[2].ToString();
                CB_namaMATKUL.SelectedItem = reader[3].ToString();
            }
            comm.Dispose();

            if (opsi == "hapus")
            {
                Btn_simpan.Enabled = true;
            }
            else
            if (opsi == "ubah")
            {
                proses();
                aktif();
                Btn_simpan.Enabled = true;
                CB_hari.Enabled = true;
                CB_jam.Enabled = true;
                CB_jurusan.Enabled = true;
                CB_semester.Enabled = true;
                CB_dosen.Enabled = true;
                CB_nidn.Enabled = true;
                CB_namaMATKUL.Enabled = true;
                CB_kodeMATKUL.Enabled = true;
                CB_kelas.Enabled = true;
                CB_jam.Enabled = true;
            }
        }
            private void jam()
            {
            if (CB_jam.SelectedIndex == 1)
            {
                awal = "08:00:00";
                akhir = "10:00:00";
            }
            else
            if (CB_jam.SelectedIndex == 2)
            {
                awal = "10:00:00";
                akhir = "12:00:00";
            }
            else
            if (CB_jam.SelectedIndex == 3)
            {
                awal = "13:00:00";
                akhir = "15:00:00";
            }
            else
            if (CB_jam.SelectedIndex == 4)
            {
                awal = "15:00:00";
                akhir = "17:00:00";
            }
            else
            if (CB_jam.SelectedIndex == 5)
            {
                awal = "17:00:00";
                akhir = "19:00:00";
            }
            else
            if (CB_jam.SelectedIndex == 1)
            {
                awal = "19:00:00";
                akhir = "21:00:00";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
