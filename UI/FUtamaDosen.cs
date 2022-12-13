using Absensi_Mahasiswa.UI;
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

namespace Absensi_Mahasiswa
{
    public partial class FUtamaDosen : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");
        public FUtamaDosen()
        {
            InitializeComponent();
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

        private void FUtamaDosen_Load(object sender, EventArgs e)
        {
            txt_hari.Text = DateTime.Now.ToString("dddd");
            txt_tanggal.Text = DateTime.Now.ToString("d MMMM yyyy");            
            cn.Close();
            cn.Open();
            MySqlDataReader reader;
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT * FROM dosen WHERE nidn='"+ Absensi_Mahasiswa.simpan.getUsername() +"'";
            comm.CommandText = sql;
            comm.Connection = cn;
            reader = comm.ExecuteReader();
            if (reader.Read())
            {
                txt_welcome.Text = "Selamat Datang ";
                txt_dosen.Text = reader["nm_dosen"].ToString();
                label10.Text = reader["nidn"].ToString();

                cn.Close();
                cn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT kd_jadwal, kd_matkul, hari, jurusan, semester, kelas, jam_awal FROM jadwal_kuliah WHERE nidn = '"
                    + Absensi_Mahasiswa.simpan.getUsername() + "' ORDER BY kd_jadwal ASC", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;

                dg.Columns[0].HeaderText = "Kode Jadwal";
                dg.Columns[1].HeaderText = "Kode Mata Kuliah";
                dg.Columns[2].HeaderText = "Hari";
                dg.Columns[3].HeaderText = "Jurusan";
                dg.Columns[4].HeaderText = "Semester";
                dg.Columns[5].HeaderText = "Kelas";
                dg.Columns[6].HeaderText = "Jam";

                dg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dg.Columns[0].Width = 100;
                dg.Columns[1].Width = 150;
                dg.Columns[2].Width = 100;
                dg.Columns[3].Width = 100;
                dg.Columns[4].Width = 150;
                dg.Columns[5].Width = 150;
                dg.Columns[6].Width = 150;

                dg.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
                dg.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
                dg.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
                dg.Columns[3].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
                dg.Columns[4].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
                dg.Columns[5].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
                dg.Columns[6].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

                dg.ReadOnly = true;

                dg.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dg.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dg.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dg.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dg.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dg.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dg.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

                dg.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
                dg.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
                dt.Dispose();
                da.Dispose();
            }
            comm.Dispose();
        }

        private void Btn_absensi_Click(object sender, EventArgs e)
        {
            Absensi_Mahasiswa.simpan.setNIDN(label10.Text);
            Absensi_Mahasiswa.simpan.setJadwal(label11.Text);
            FAbsensi n = new FAbsensi();
            n.Show();
            this.Dispose();
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

        private void txt_welcome_Click(object sender, EventArgs e)
        {

        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dg.Rows[e.RowIndex];
            label11.Text = r.Cells[0].Value.ToString();
            Btn_absensi.Enabled = true;
        }
    }
}
