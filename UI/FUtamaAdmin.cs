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
    public partial class FUtamaAdmin : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");

        private void jmlAkun()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT COUNT(*) as indeks FROM user";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                txt_jml_akun.Text = reader["indeks"].ToString();
            }
            comm.Dispose();
        }
        
        private void jmlLaporan()
        {
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT COUNT(*) as indeks FROM absensi";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                txt_jml_laporan.Text = reader["indeks"].ToString();
            }
            comm.Dispose();
        }

        public FUtamaAdmin()
        {
            InitializeComponent();
            jmlAkun();
            jmlLaporan();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_jam.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FUtamaAdmin_Load(object sender, EventArgs e)
        {
            txt_hari.Text = DateTime.Now.ToString("dddd");
            txt_tanggal.Text = DateTime.Now.ToString("d MMMM yyyy");
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menutup aplikasi ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            } else { }
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_dataakunpengguna_Click(object sender, EventArgs e)
        {
            FDataAkunPengguna n = new FDataAkunPengguna();
            n.Show();
            this.Dispose();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            FLaporanAbsensi n = new FLaporanAbsensi();
            n.Show();
            this.Dispose();
        }
    }
}
