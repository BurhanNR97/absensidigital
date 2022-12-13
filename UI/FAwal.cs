using Absensi_Mahasiswa.UI;
using Microsoft.VisualBasic;
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
    public partial class FAwal : Form
    {
        public FAwal()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menutup Aplikasi ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            } else{}
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FAwal_Load(object sender, EventArgs e)
        {
            txt_hari.Text = DateTime.Now.ToString("dddd");
            txt_tanggal.Text = DateTime.Now.ToString("d MMMM yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_jam.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            FLogin n = new FLogin();
            n.Show();
            this.Dispose();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Btn_about_Click(object sender, EventArgs e)
        {
            FAbout n = new FAbout();
            n.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}