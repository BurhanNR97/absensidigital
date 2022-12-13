using Absensi_Mahasiswa.UI;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
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
using System.IO;
using System.Drawing.Imaging;
using System.Xml;

namespace Absensi_Mahasiswa
{
    public partial class FUtamaOperator : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");
        private CascadeClassifier haar = null;
        public FUtamaOperator()
        {
            InitializeComponent();
            haar = new CascadeClassifier(@"haarcascade_frontalface_default.xml");
        }
        private void dosen()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT COUNT(*) as indeks FROM dosen";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                txt_dosen.Text = reader["indeks"].ToString();
            }
            comm.Dispose();
        }

        private void mahasiswa()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT COUNT(*) as indeks FROM mahasiswa";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                txt_mahasiswa.Text = reader["indeks"].ToString();
            }
            comm.Dispose();
        }

        private void jadwal_kuliah()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT COUNT(*) as indeks FROM jadwal_kuliah";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                txt_jadwalkuliah.Text = reader["indeks"].ToString();
            }
            comm.Dispose();
        }

        private void matkul()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT COUNT(*) as indeks FROM mata_kuliah";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                txt_matkul.Text = reader["indeks"].ToString();
            }
            comm.Dispose();
        }

        private void FUtamaOperator_Load(object sender, EventArgs e)
        {
            matkul();
            mahasiswa();
            dosen();
            jadwal_kuliah();
            txt_hari.Text = DateTime.Now.ToString("dddd");
            txt_tanggal.Text = DateTime.Now.ToString("d MMMM yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_jam.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menutup aplikasi ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Anda Ingin Logout ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FAwal n = new FAwal();
                n.Show();
                this.Dispose();
            }
        }

        private void Btn_dosen_Click(object sender, EventArgs e)
        {
            FDosen n = new FDosen();
            n.Show();
            this.Dispose();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            FMahasiswa n = new FMahasiswa();
            n.Show();
            this.Dispose();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            FMataKuliah n = new FMataKuliah();
            n.Show();
            this.Dispose();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            FJadwalKuliah n = new FJadwalKuliah();
            n.Show();
            this.Dispose();
        }                                                               

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            FCitra n = new FCitra(haar);
            n.Show();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            FMataKuliah n = new FMataKuliah();
            n.Show();
        }
    }
}
