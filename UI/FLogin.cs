using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.Design.Serialization;
using MySql.Data.MySqlClient;
using Emgu.CV;

namespace Absensi_Mahasiswa
{
    public partial class FLogin : Form
    {
        string usr;
        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");

        public FLogin()
        {
            InitializeComponent();
            
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kembali ke halaman awal ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FAwal n = new FAwal();
                this.Dispose();
                n.Show();
            }
            else { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Sembunyikan kata sandi";
                txt_password.UseSystemPasswordChar = false;
            } else
            {
                checkBox1.Text = "Tampilkan kata sandi";
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            txt_username.Focus();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Equals(""))
            {
                MessageBox.Show("username masih kosong", "WARNING!");
                txt_username.Focus();
            } else
            if (txt_password.Text.Equals(""))
            {
                MessageBox.Show("passoword masih kosong", "WARNING!");
                txt_password.SelectAll();
                txt_password.Focus();
            }
            else
            {
                cn.Close();
                cn.Open();
                MySqlDataReader reader;
                MySqlCommand comm = new MySqlCommand();
                string sql = "SELECT * FROM user WHERE username='"+txt_username.Text+"' and password='"+txt_password.Text+"'";
                comm.CommandText = sql;
                comm.Connection = cn;
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    usr = txt_username.Text;
                    string a = reader["hak_akses"].ToString();
                    FUtamaAdmin admin = new FUtamaAdmin();
                    FUtamaOperator op = new FUtamaOperator();
                    FUtamaDosen dosen = new FUtamaDosen();
                    if (a.Equals("Administrator"))
                    {
                        admin.Show();
                        this.Dispose();
                    } else
                    if (a.Equals("Operator"))
                    {
                        op.Show();
                        this.Dispose();
                    } else
                    if (a.Equals("Dosen"))
                    {
                        Absensi_Mahasiswa.simpan.setUsername(reader["username"].ToString());
                        dosen.Show();
                        this.Dispose();
                    } else
                    {
                        MessageBox.Show("Hak akses akun tidak ditemukan");
                    }
                } else
                {
                    MessageBox.Show("username/password yang anda masukkan salah!");
                    txt_password.Focus();
                    txt_password.SelectAll();
                }
                comm.Dispose();
            }
        }

        private void minimize_Popup(object sender, PopupEventArgs e)
        {

        }

        private void close_Popup(object sender, PopupEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void PB_usermati_Click(object sender, EventArgs e)
        {

        }

        private void PB_passmati_Click(object sender, EventArgs e)
        {

        }

        private void username_Popup(object sender, PopupEventArgs e)
        {

        }

        private void password_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
