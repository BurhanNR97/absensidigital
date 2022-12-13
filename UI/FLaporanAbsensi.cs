using Microsoft.SqlServer.Server;
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
    public partial class FLaporanAbsensi : Form
    {
        string opsi;
        MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");
        public FLaporanAbsensi()
        {
            InitializeComponent();
            data();
        }

        private void data()
        {
            cn.Close();
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM absensi", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "Kode Absensi";

            dg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

         //   dg.Columns[0].Width = 120;
         //   dg.Columns[1].Width = 250;
         //   dg.Columns[2].Width = 250;
         //   dg.Columns[3].Width = 120;

            dg.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            dg.ReadOnly = true;

            dg.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            dg.AutoResizeColumns();
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;

            dt.Dispose();
            da.Dispose();
        }

        private void cariteks()
        {
            cn.Close();
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM detail_absensi WHERE kd_absen LIKE '"+txt_cari.Text+ "' OR nidn LIKE '"
                                                       + txt_cari.Text + "' OR nm_dosen LIKE '" + txt_cari.Text + "' OR kelas LIKE '" + txt_cari.Text
                                                       + "' OR nm_matkul LIKE '" + txt_cari.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "Kode Absen";
            dg.Columns[1].HeaderText = "NIDN";
            dg.Columns[2].HeaderText = "Nama Dosen";
            dg.Columns[3].HeaderText = "Kelas";
            dg.Columns[4].HeaderText = "Mata Kuliah";
            dg.Columns[5].HeaderText = "Tanggal";

            dg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //   dg.Columns[0].Width = 120;
            //   dg.Columns[1].Width = 250;
            //   dg.Columns[2].Width = 250;
            //   dg.Columns[3].Width = 120;

            dg.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[3].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[4].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[5].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            dg.ReadOnly = true;

            dg.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            dg.AutoResizeColumns();
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;

            dt.Dispose();
            da.Dispose();
        }

        private void caritgl()
        {
            string tgl = DTP_tanggal.Value.ToString("yyyy-MM-dd");
            cn.Close();
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM detail_absensi WHERE tanggal = '" + tgl + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "Kode Absen";
            dg.Columns[1].HeaderText = "NIDN";
            dg.Columns[2].HeaderText = "Nama Dosen";
            dg.Columns[3].HeaderText = "Kelas";
            dg.Columns[4].HeaderText = "Mata Kuliah";
            dg.Columns[5].HeaderText = "Tanggal";

            dg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //   dg.Columns[0].Width = 120;
            //   dg.Columns[1].Width = 250;
            //   dg.Columns[2].Width = 250;
            //   dg.Columns[3].Width = 120;

            dg.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[3].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[4].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[5].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            dg.ReadOnly = true;
            dg.AutoResizeColumns();
            dg.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;

            dt.Dispose();
            da.Dispose();
        }

        private void cariantartgl()
        {
            string awal = DTP_tglawal.Value.ToString("yyyy-MM-dd");
            string akhir = DTP_tglakhir.Value.ToString("yyyy-MM-dd");
            cn.Close();
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM detail_absensi WHERE tanggal = '" + awal + "' BETWEEN '"
                                                       + akhir + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "Kode Absen";
            dg.Columns[1].HeaderText = "NIDN";
            dg.Columns[2].HeaderText = "Nama Dosen";
            dg.Columns[3].HeaderText = "Kelas";
            dg.Columns[4].HeaderText = "Mata Kuliah";
            dg.Columns[5].HeaderText = "Tanggal";

            dg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //   dg.Columns[0].Width = 120;
            //   dg.Columns[1].Width = 250;
            //   dg.Columns[2].Width = 250;
            //   dg.Columns[3].Width = 120;

            dg.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[3].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[4].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.Columns[5].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

            dg.ReadOnly = true;
            dg.AutoResizeColumns();
            dg.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dg.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;

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
                FUtamaAdmin n = new FUtamaAdmin();
                n.Show();
                this.Dispose();
            }
        }

        private void RB_kode_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_kode.Checked)
            {
                txt_cari.Enabled = true;
                DTP_tanggal.Enabled = false;
                DTP_tglawal.Enabled = false;
                DTP_tglakhir.Enabled = false;
                Btn_cari.Enabled = true;
            } else
            if (RB_tgl.Checked)
            {
                txt_cari.Text = "";
                txt_cari.Enabled = false;
                DTP_tanggal.Enabled = true;
                DTP_tglawal.Enabled = false;
                DTP_tglakhir.Enabled = false;
                Btn_cari.Enabled = true;
            }
            else
            if (RB_tglsampai.Checked)
            {
                txt_cari.Text = "";
                txt_cari.Enabled = false;
                DTP_tanggal.Enabled = false;
                DTP_tglawal.Enabled = true;
                DTP_tglakhir.Enabled = true;
                Btn_cari.Enabled = true;
            } else
            {
                txt_cari.Text = "";
                txt_cari.Enabled = false;
                DTP_tanggal.Enabled = false;
                DTP_tglawal.Enabled = false;
                DTP_tglakhir.Enabled = false;
                Btn_cari.Enabled = false;
            }
        }

        private void RB_tgl_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_kode.Checked)
            {
                txt_cari.Enabled = true;
                DTP_tanggal.Enabled = false;
                DTP_tglawal.Enabled = false;
                DTP_tglakhir.Enabled = false;
                Btn_cari.Enabled = true;
            }
            else
            if (RB_tgl.Checked)
            {
                txt_cari.Text = "";
                txt_cari.Enabled = false;
                DTP_tanggal.Enabled = true;
                DTP_tglawal.Enabled = false;
                DTP_tglakhir.Enabled = false;
                Btn_cari.Enabled = true;
            }
            else
            if (RB_tglsampai.Checked)
            {
                txt_cari.Text = "";
                txt_cari.Enabled = false;
                DTP_tanggal.Enabled = false;
                DTP_tglawal.Enabled = true;
                DTP_tglakhir.Enabled = true;
                Btn_cari.Enabled = true;
            }
            else
            {
                txt_cari.Text = "";
                txt_cari.Enabled = false;
                DTP_tanggal.Enabled = false;
                DTP_tglawal.Enabled = false;
                DTP_tglakhir.Enabled = false;
                Btn_cari.Enabled = false;
            }
        }

        private void RB_tglsampai_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_kode.Checked)
            {
                txt_cari.Enabled = true;
                DTP_tanggal.Enabled = false;
                DTP_tglawal.Enabled = false;
                DTP_tglakhir.Enabled = false;
                Btn_cari.Enabled = true;
            }
            else
            if (RB_tgl.Checked)
            {
                txt_cari.Text = "";
                txt_cari.Enabled = false;
                DTP_tanggal.Enabled = true;
                DTP_tglawal.Enabled = false;
                DTP_tglakhir.Enabled = false;
                Btn_cari.Enabled = true;
            }
            else
            if (RB_tglsampai.Checked)
            {
                txt_cari.Text = "";
                txt_cari.Enabled = false;
                DTP_tanggal.Enabled = false;
                DTP_tglawal.Enabled = true;
                DTP_tglakhir.Enabled = true;
                Btn_cari.Enabled = true;
            }
            else
            {
                txt_cari.Text = "";
                txt_cari.Enabled = false;
                DTP_tanggal.Enabled = false;
                DTP_tglawal.Enabled = false;
                DTP_tglakhir.Enabled = false;
                Btn_cari.Enabled = false;
            }
        }

        private void Btn_hapus_Click(object sender, EventArgs e)
        {
            if (Btn_hapus.Enabled == true)
            {
                opsi = "hapus";
                Btn_hapus.Enabled = false;
                dg.Enabled = true;
                Btn_simpan.Enabled = true;
                Btn_cetak.Enabled = false;
            } else { }
        }

        private void Btn_batal_Click(object sender, EventArgs e)
        {
            RB_kode.Checked = false;
            RB_tgl.Checked = false;
            RB_tglsampai.Checked = false;
            txt_cari.Enabled = false;
            txt_cari.Text = "";
            DTP_tanggal.Enabled = false;
            DTP_tglakhir.Enabled = false;
            DTP_tglawal.Enabled = false;
            Btn_cari.Enabled = false;
            Btn_hapus.Enabled = true;
            Btn_simpan.Enabled = false;
            Btn_cetak.Enabled = true;
            txt_kode.Text = "";
        }

        private void Btn_simpan_Click(object sender, EventArgs e)
        {
            if (opsi == "hapus")
            {
                cn.Close();
                cn.Open();
                MySqlDataReader reader;
                MySqlCommand comm = new MySqlCommand();
                string sql = "DELETE FROM detail_absensi WHERE kd_absen='" + txt_kode.Text + "'";
                comm.CommandText = sql;
                comm.Connection = cn;
                reader = comm.ExecuteReader();
                comm.Dispose();
                MessageBox.Show("Data berhasil dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            if (opsi == "cetak")
            {

            }
            txt_kode.Text = "";
            Btn_simpan.Enabled = false;
            Btn_hapus.Enabled = true;
            Btn_cetak.Enabled = true;
        }

        private void Btn_cetak_Click(object sender, EventArgs e)
        {
            if (Btn_cetak.Enabled == true)
            {
                dg.Enabled = true;
                Btn_hapus.Enabled = false;
                Btn_simpan.Enabled = true;
                Btn_cetak.Enabled = false;
            }
            else { }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dg.Rows[e.RowIndex];
            txt_kode.Text = r.Cells[0].Value.ToString();
        }

        private void Btn_cari_Click(object sender, EventArgs e)
        {
            if (Btn_cari.Enabled == true)
            {
                if (RB_kode.Checked == true)
                {
                    cariteks();
                } else
                if (RB_tgl.Checked == true)
                {
                    caritgl();
                } else
                if (RB_tglsampai.Checked == true)
                {
                    cariantartgl();
                }
            }
            else { }
        }
    }
}
