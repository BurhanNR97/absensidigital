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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Increment(10);
            } else
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer1.Dispose();
                this.Hide();
                FAwal n = new FAwal();
                n.Show();
            }
        }
    }
}
