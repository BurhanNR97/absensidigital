using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Emgu.CV;
using Emgu.CV.Structure;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Absensi_Mahasiswa
{
	public partial class FAbsensi : Form
	{
		/*
		private VideoViewerWF _videoViewer;
		private WebCamera _webCamera;
		private DrawingImageProvider _imageProvider;
		private MediaConnector _mediaConnector;
		*/
		MySqlConnection cn = new MySqlConnection("server=localhost; username=root; password= ; database=db_absensi;");
		private Capture capture = null;
		private CascadeClassifier haar = null;

		private Image<Bgr, Byte> frame = null;
		private Image<Gray, Byte> grayFrame = null;
		private Image<Bgr, Byte> currentFace = null;
		private Image<Gray, Byte> currentFaceGray = null;

		private Recognizer recognizer;
        private ReportClass rpt;

        public static FAbsensi Instance
        {
			get;
			private set;
		}

		public FAbsensi()
		{
			InitializeComponent();
			Instance = this;
			haar = new CascadeClassifier(@"haarcascade_frontalface_default.xml");
			/*
			_videoViewer = new VideoViewerWF();
			_imageProvider = new DrawingImageProvider();
			_mediaConnector = new MediaConnector();
			*/
		}

		public void InitializeCapture()
		{
			capture = new Capture();
			recognizer = new Recognizer();
			Application.Idle += ProcessFrame;
		}

		public void StopCapture()
		{
			Application.Idle -= ProcessFrame;
			capture.Dispose();
		}

		private void ProcessFrame(object sender, EventArgs arg)
		{
			frame = capture.QueryFrame().ToImage<Bgr, Byte>();
			grayFrame = frame.Convert<Gray, Byte>();

			Rectangle[] facesDetected = haar.DetectMultiScale(grayFrame, 1.2, 10, new Size(100, 100), Size.Empty);

			for (int i = 0; i < facesDetected.Length; i++)
			{
				facesDetected[i].X += (int)(facesDetected[i].Height * 0.15);
				facesDetected[i].Y += (int)(facesDetected[i].Width * 0.22);
				facesDetected[i].Height -= (int)(facesDetected[i].Height * 0.3);
				facesDetected[i].Width  -= (int)(facesDetected[i].Width * 0.35);

				currentFace = frame.Copy(facesDetected[i]);
				currentFaceGray = grayFrame.Copy(facesDetected[i]).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
				currentFaceGray._EqualizeHist();

				frame.Draw(facesDetected[i], new Bgr(Color.Red), 2);

				if (recognizer.IsTrained)
				{
					var result = recognizer.Recognize(currentFaceGray);
					frame.Draw(result.Name + ":" + (int)result.Distance,
						new Point(facesDetected[i].X - 2, facesDetected[i].Y - 2),
						Emgu.CV.CvEnum.FontFace.HersheyComplex,
						0.5d,
						new Bgr(255, 0, 0)
						);
					string nama = result.Name;
					
					if (nama!="Unknown")
                    {
						cn.Close();
						cn.Open();
						MySqlDataReader reader;
						MySqlCommand comm = new MySqlCommand();
						string sql = "SELECT * FROM mahasiswa WHERE npm='" + nama + "'";
						comm.CommandText = sql;
						comm.Connection = cn;
						reader = comm.ExecuteReader();
						if (reader.Read())
						{
							string npm = reader["npm"].ToString();
							string nm = reader["nm_mahasiswa"].ToString();
							cn.Close();
							cn.Open();
							MySqlDataReader read;
							MySqlCommand co = new MySqlCommand();
							string sq = "SELECT COUNT(npm) as i FROM absensi WHERE npm='"+nama+"' and kd_absensi='"+txt_kode.Text+"'";
							co.CommandText = sq;
							co.Connection = cn;
							read = co.ExecuteReader();
							if (read.Read())
							{
								string a = read["i"].ToString();
								cn.Close();
								cn.Open();
								MySqlDataReader readd2;
								MySqlCommand commm2 = new MySqlCommand();
								string skl2 = "SELECT npm from absensi WHERE kd_absensi = '" + txt_kode.Text + "' and npm='"+npm+"'";
								commm2.CommandText = skl2;
								commm2.Connection = cn;
								readd2 = commm2.ExecuteReader();
								if (readd2.Read())
								{
									
								} else
                                {
									
									int b = Int32.Parse(a);
									if (b == 0)
									{
										cn.Close();
										cn.Open();
										MySqlCommand com = new MySqlCommand();
										string s = "INSERT INTO absensi SET kd_absensi='" + txt_kode.Text + "', kd_jadwal ='"
													+ txt_kodejadwal.Text + "', npm='" + npm + "', nama='" + nm + "', ket='HADIR'";
										com.CommandText = s;
										com.Connection = cn;
										com.ExecuteReader();
										com.Dispose();
										data();
									}
									co.Dispose();
									cn.Close();
									cn.Open();
									MySqlDataReader readd;
									MySqlCommand commm = new MySqlCommand();
									string skl = "SELECT * from jadwal_kuliah WHERE kd_jadwal = '" + txt_kodejadwal.Text + "'";
									commm.CommandText = skl;
									commm.Connection = cn;
									readd = commm.ExecuteReader();
									if (readd.Read())
									{
										string jurusan = readd["jurusan"].ToString();
										string semester = readd["semester"].ToString();
										string kelas = readd["kelas"].ToString();
										string hari = readd["hari"].ToString();
										string prodi = "";
										string thn = DateTime.Now.ToString("yyyy");
										int thun = Int32.Parse(thn) + 1;
										string tahun = thn + "/" + thun;
										if (jurusan == "Teknik Informatika")
											prodi = jurusan + " - S1";
										else
										if (jurusan == "Sistem Komputer")
											prodi = jurusan + " - S1";
										else
										if (jurusan == "Sistem Informasi")
											prodi = jurusan + " - S1";
										else
										if (jurusan == "Manajemen Informatika")
											prodi = jurusan + " - DIII";
										else
										if (jurusan == "Komputerisasi Akuntansi")
											prodi = jurusan + " - DIII";

										cn.Close();
										cn.Open();
										MySqlDataReader read5;
										MySqlCommand cm5 = new MySqlCommand();
										string sk5 = "SELECT *FROM rekap WHERE kd_jadwal='" + txt_kodejadwal.Text
													 + "' and npm='" + npm + "'";
										cm5.CommandText = sk5;
										cm5.Connection = cn;
										read5 = cm5.ExecuteReader();
										if (read5.Read())
                                        {
											cn.Close();
											cn.Open();
											MySqlCommand cm = new MySqlCommand();
											string sk = "UPDATE rekap SET p" + txt_pertemuan.Text + "='H' WHERE kd_jadwal='"
														+ txt_kodejadwal.Text + "' and npm ='" + npm + "'";
											cm.CommandText = sk;
											cm.Connection = cn;
											cm.ExecuteReader();
										} else
                                        {
											cn.Close();
											cn.Open();
											MySqlCommand cm = new MySqlCommand();
											string sk = "INSERT INTO rekap SET kd_jadwal='" + txt_kodejadwal.Text + "', nm_dosen ='" + txt_nmdosen.Text
														 + "', jurusan ='" + jurusan + "', prodi='" + prodi + "', tahun ='" + tahun + "', hari ='"
														 + hari + "', kelas = '" + kelas + "', semester ='" + semester + "', npm ='"
														 + npm + "', nm_mhs='" + nm + "', p" + txt_pertemuan.Text + "='H'";
											cm.CommandText = sk;
											cm.Connection = cn;
											cm.ExecuteReader();
											//arsip();
										}
									}
								}
							}
						}
						comm.Dispose();
					}
				} else
                {
                }
			}
			pictureBox1.Image = frame.ToBitmap();
		}

		private void ReleaseData()
		{
			if (Instance != null)
			{
				Instance = null;
			}
			if (capture != null)
			{
				StopCapture();
			}
		}

		private void pertemuan()
        {
			cn.Close();
			cn.Open();
			MySqlDataReader reader1;
			MySqlCommand comm1 = new MySqlCommand();
			string sql1 = "SELECT * from pertemuan WHERE kd_jadwal='" + txt_kodejadwal.Text + "' ORDER BY pert_ke DESC";
			comm1.CommandText = sql1;
			comm1.Connection = cn;
			string ke;
			int pert;
			reader1 = comm1.ExecuteReader();
			if (reader1.Read())
			{
				ke = reader1["pert_ke"].ToString();
				if (ke == "14")
                {
					MessageBox.Show("Tidak ada lagi pertemuan perkuliahan");
                }
				pert = int.Parse(ke);
				txt_pertemuan.Text = (pert + 1).ToString();
			}
			else
			{
				txt_pertemuan.Text = "1";
			}
		}

		private void pertemuann()
		{
				string tgl = DateTime.Now.ToString("yyyy-mm-dd");
				cn.Close();
				cn.Open();
				MySqlCommand comm1 = new MySqlCommand();
				string sql1 = "INSERT INTO pertemuan SET kd_jadwal='" + txt_kodejadwal.Text + "', pert_ke='"
							  + txt_pertemuan.Text + "', tgl='"+tgl+"'";
				comm1.CommandText = sql1;
				comm1.Connection = cn;
				comm1.ExecuteReader();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

        private void Btn_close_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Kembali helaman utama ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				FUtamaDosen n = new FUtamaDosen();
				n.Show();
				this.Dispose();
			}
		}

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_dosen_Click(object sender, EventArgs e)
        {
			if (txt_materi.Text == "")
            {
				MessageBox.Show("Data tidak boleh kosong");
				txt_materi.Focus();
            } else
			if (CB_metode.SelectedIndex == 0)
            {
				MessageBox.Show("Silahkan pilih metode perkuliahan");
				CB_metode.Focus();
			} else
            {
				Btn_start.Enabled = false;
				Btn_stop.Enabled = true;
				InitializeCapture();
			}
		}
/*
		private void arsip()
        {
			cn.Close();
			cn.Open();
			MySqlCommand comm1 = new MySqlCommand();
			string sql1 = "INSERT INTO arsip_absensi SET kd_absensi = '"+txt_kode.Text+"', nidn='"+txt_nidn.Text
						  +"', kd_jadwal='"+ txt_kodejadwal.Text + "', materi='" + txt_materi.Text
						  + "', metode='"+CB_metode.SelectedItem.ToString()+"'";
			comm1.CommandText = sql1;
			comm1.Connection = cn;
			comm1.ExecuteReader();
		}
*/
        private void Btn_stop_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Hentikan absensi ?", "Confirm Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				StopCapture();
				Btn_stop.Enabled = false;
				Btn_start.Enabled = true;
				pictureBox1.Image = null;
			}
		}


		private void nama_dosen()
        {
			cn.Close();
			cn.Open();
			MySqlDataReader reader;
			MySqlCommand comm = new MySqlCommand();
			string sql = "SELECT * from dosen WHERE nidn='"+ txt_nidn.Text +"'";
			comm.CommandText = sql;
			comm.Connection = cn;
			reader = comm.ExecuteReader();
			if (reader.Read())
			{
				txt_nmdosen.Text = reader["nm_dosen"].ToString();
			}
		}

        private void FAbsensi_Load(object sender, EventArgs e)
        {
			id();
			data();
			txt_hari.Text = DateTime.Now.ToString("dddd");
			txt_tanggal.Text = DateTime.Now.ToString("d MMMM yyyy");
			txt_nidn.Text = Absensi_Mahasiswa.simpan.getNIDN();
			txt_kodejadwal.Text = Absensi_Mahasiswa.simpan.getJadwal();
			nama_dosen();
			pertemuan();
			pertemuann();
			int jam = int.Parse(DateTime.Now.ToString("HH"));

		}

		private void data()
		{
			cn.Close();
			cn.Open();
			MySqlDataAdapter da = new MySqlDataAdapter("SELECT a.npm as npm, b.nm_mahasiswa as nama, a.ket as ket FROM absensi a INNER JOIN mahasiswa b ON a.npm=b.npm WHERE a.kd_absensi='"+txt_kode.Text+"' ORDER BY a.npm ASC", cn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;

			dataGridView1.Columns[0].HeaderText = "NPM";
			dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
			dataGridView1.Columns[2].HeaderText = "Absensi";

			dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

			dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			dataGridView1.Columns[0].Width = 150;
			dataGridView1.Columns[1].Width = 250;
			dataGridView1.Columns[2].Width = 100;


			dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
			dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
			dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);

			dataGridView1.ReadOnly = true;

			dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

			dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
			dt.Dispose();
			da.Dispose();
		}

		private void id()
		{
			cn.Close();
			cn.Open();
			MySqlDataReader reader;
			MySqlCommand comm = new MySqlCommand();
			string sql = "SELECT * from absensi ORDER BY kd_absensi DESC";
			comm.CommandText = sql;
			comm.Connection = cn;
			reader = comm.ExecuteReader();
			if (reader.Read())
			{
				string a = reader["kd_absensi"].ToString().Substring(3);
				int b = int.Parse(a);
				int c = b + 1;
				txt_kode.Text = "AB-" + c;
			}
			else
			{
				txt_kode.Text = "AB-1010001";
			}
			comm.Dispose();
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
			txt_jam.Text = DateTime.Now.ToString("HH:mm:ss");
		}

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
			if (Btn_stop.Enabled)
            {
				MessageBox.Show("Absensi Belum Selesai");
			} else
            {

            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
			Absensi_Mahasiswa.simpan.setJadwal(txt_kodejadwal.Text);
			UI.FRekap n = new UI.FRekap();
			ReportDocument report = new laporanAbsen();
			report.Load("laporanAbsen.rpt");
			
			report.SetParameterValue("kd_jadwal", txt_kodejadwal.Text);
			report.ReadRecords();
			report.Refresh();
			n.Show();
		}
	}
}
