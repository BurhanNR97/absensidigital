namespace Absensi_Mahasiswa
{
	partial class FAbsensi
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			ReleaseData();
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAbsensi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_start = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_stop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_kode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nidn = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nmdosen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tanggal = new System.Windows.Forms.Label();
            this.txt_hari = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_materi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_kodejadwal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CB_metode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_jam = new System.Windows.Forms.Label();
            this.kode_jadwal = new System.Windows.Forms.Label();
            this.txt_pertemuan = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.Btn_minimize);
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 28);
            this.panel1.TabIndex = 29;
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimize.BackgroundImage")));
            this.Btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_minimize.FlatAppearance.BorderSize = 0;
            this.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimize.Location = new System.Drawing.Point(1315, 1);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.Size = new System.Drawing.Size(24, 24);
            this.Btn_minimize.TabIndex = 19;
            this.Btn_minimize.UseVisualStyleBackColor = true;
            this.Btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_close.BackgroundImage")));
            this.Btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.Location = new System.Drawing.Point(1340, 2);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(24, 24);
            this.Btn_close.TabIndex = 2;
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Absensi Mahasiswa Berbasis Pengenalan Wajah";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 28);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_start
            // 
            this.Btn_start.BackColor = System.Drawing.Color.Transparent;
            this.Btn_start.BorderRadius = 15;
            this.Btn_start.CheckedState.Parent = this.Btn_start;
            this.Btn_start.CustomImages.Parent = this.Btn_start;
            this.Btn_start.FillColor = System.Drawing.Color.Cyan;
            this.Btn_start.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_start.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_start.ForeColor = System.Drawing.Color.White;
            this.Btn_start.HoverState.Parent = this.Btn_start;
            this.Btn_start.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_circled_play_80;
            this.Btn_start.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_start.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_start.Location = new System.Drawing.Point(185, 205);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.ShadowDecoration.Parent = this.Btn_start;
            this.Btn_start.Size = new System.Drawing.Size(136, 45);
            this.Btn_start.TabIndex = 30;
            this.Btn_start.Text = "      Start";
            this.Btn_start.Click += new System.EventHandler(this.Btn_dosen_Click);
            // 
            // Btn_stop
            // 
            this.Btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.Btn_stop.BorderRadius = 15;
            this.Btn_stop.CheckedState.Parent = this.Btn_stop;
            this.Btn_stop.CustomImages.Parent = this.Btn_stop;
            this.Btn_stop.Enabled = false;
            this.Btn_stop.FillColor = System.Drawing.Color.Cyan;
            this.Btn_stop.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_stop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_stop.ForeColor = System.Drawing.Color.White;
            this.Btn_stop.HoverState.Parent = this.Btn_stop;
            this.Btn_stop.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_stop_64;
            this.Btn_stop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_stop.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_stop.Location = new System.Drawing.Point(341, 205);
            this.Btn_stop.Name = "Btn_stop";
            this.Btn_stop.ShadowDecoration.Parent = this.Btn_stop;
            this.Btn_stop.Size = new System.Drawing.Size(136, 45);
            this.Btn_stop.TabIndex = 31;
            this.Btn_stop.Text = "      Stop";
            this.Btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(677, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 480);
            this.dataGridView1.TabIndex = 32;
            // 
            // txt_kode
            // 
            this.txt_kode.BackColor = System.Drawing.Color.Transparent;
            this.txt_kode.BorderRadius = 15;
            this.txt_kode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kode.DefaultText = "";
            this.txt_kode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_kode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_kode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_kode.DisabledState.Parent = this.txt_kode;
            this.txt_kode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_kode.Enabled = false;
            this.txt_kode.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_kode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_kode.FocusedState.Parent = this.txt_kode;
            this.txt_kode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kode.ForeColor = System.Drawing.Color.Black;
            this.txt_kode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_kode.HoverState.Parent = this.txt_kode;
            this.txt_kode.Location = new System.Drawing.Point(632, 51);
            this.txt_kode.Margin = new System.Windows.Forms.Padding(6);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.PasswordChar = '\0';
            this.txt_kode.PlaceholderText = "";
            this.txt_kode.SelectedText = "";
            this.txt_kode.ShadowDecoration.Parent = this.txt_kode;
            this.txt_kode.Size = new System.Drawing.Size(191, 32);
            this.txt_kode.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(526, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Kode Absensi";
            // 
            // txt_nidn
            // 
            this.txt_nidn.BackColor = System.Drawing.Color.Transparent;
            this.txt_nidn.BorderRadius = 15;
            this.txt_nidn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nidn.DefaultText = "";
            this.txt_nidn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nidn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nidn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nidn.DisabledState.Parent = this.txt_nidn;
            this.txt_nidn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nidn.Enabled = false;
            this.txt_nidn.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_nidn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nidn.FocusedState.Parent = this.txt_nidn;
            this.txt_nidn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nidn.ForeColor = System.Drawing.Color.Black;
            this.txt_nidn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nidn.HoverState.Parent = this.txt_nidn;
            this.txt_nidn.Location = new System.Drawing.Point(632, 95);
            this.txt_nidn.Margin = new System.Windows.Forms.Padding(6);
            this.txt_nidn.Name = "txt_nidn";
            this.txt_nidn.PasswordChar = '\0';
            this.txt_nidn.PlaceholderText = "";
            this.txt_nidn.SelectedText = "";
            this.txt_nidn.ShadowDecoration.Parent = this.txt_nidn;
            this.txt_nidn.Size = new System.Drawing.Size(191, 32);
            this.txt_nidn.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(526, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "NIDN";
            // 
            // txt_nmdosen
            // 
            this.txt_nmdosen.BackColor = System.Drawing.Color.Transparent;
            this.txt_nmdosen.BorderRadius = 15;
            this.txt_nmdosen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nmdosen.DefaultText = "";
            this.txt_nmdosen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nmdosen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nmdosen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nmdosen.DisabledState.Parent = this.txt_nmdosen;
            this.txt_nmdosen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nmdosen.Enabled = false;
            this.txt_nmdosen.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_nmdosen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nmdosen.FocusedState.Parent = this.txt_nmdosen;
            this.txt_nmdosen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nmdosen.ForeColor = System.Drawing.Color.Black;
            this.txt_nmdosen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nmdosen.HoverState.Parent = this.txt_nmdosen;
            this.txt_nmdosen.Location = new System.Drawing.Point(632, 139);
            this.txt_nmdosen.Margin = new System.Windows.Forms.Padding(6);
            this.txt_nmdosen.Name = "txt_nmdosen";
            this.txt_nmdosen.PasswordChar = '\0';
            this.txt_nmdosen.PlaceholderText = "";
            this.txt_nmdosen.SelectedText = "";
            this.txt_nmdosen.ShadowDecoration.Parent = this.txt_nmdosen;
            this.txt_nmdosen.Size = new System.Drawing.Size(292, 32);
            this.txt_nmdosen.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(526, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nama Dosen";
            // 
            // txt_tanggal
            // 
            this.txt_tanggal.AutoSize = true;
            this.txt_tanggal.BackColor = System.Drawing.Color.Transparent;
            this.txt_tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tanggal.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_tanggal.Location = new System.Drawing.Point(158, 126);
            this.txt_tanggal.Name = "txt_tanggal";
            this.txt_tanggal.Size = new System.Drawing.Size(0, 24);
            this.txt_tanggal.TabIndex = 52;
            // 
            // txt_hari
            // 
            this.txt_hari.AutoSize = true;
            this.txt_hari.BackColor = System.Drawing.Color.Transparent;
            this.txt_hari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hari.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_hari.Location = new System.Drawing.Point(158, 92);
            this.txt_hari.Name = "txt_hari";
            this.txt_hari.Size = new System.Drawing.Size(0, 24);
            this.txt_hari.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(143, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(143, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(143, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(59, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tanggal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(60, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Hari";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(60, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "Jam";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(937, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "Metode Perkuliahan";
            // 
            // txt_materi
            // 
            this.txt_materi.BackColor = System.Drawing.Color.Transparent;
            this.txt_materi.BorderRadius = 15;
            this.txt_materi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_materi.DefaultText = "";
            this.txt_materi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_materi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_materi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_materi.DisabledState.Parent = this.txt_materi;
            this.txt_materi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_materi.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_materi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_materi.FocusedState.Parent = this.txt_materi;
            this.txt_materi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_materi.ForeColor = System.Drawing.Color.Black;
            this.txt_materi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_materi.HoverState.Parent = this.txt_materi;
            this.txt_materi.Location = new System.Drawing.Point(1083, 95);
            this.txt_materi.Margin = new System.Windows.Forms.Padding(6);
            this.txt_materi.Name = "txt_materi";
            this.txt_materi.PasswordChar = '\0';
            this.txt_materi.PlaceholderText = "";
            this.txt_materi.SelectedText = "";
            this.txt_materi.ShadowDecoration.Parent = this.txt_materi;
            this.txt_materi.Size = new System.Drawing.Size(256, 32);
            this.txt_materi.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(937, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Materi Perkuliahan";
            // 
            // txt_kodejadwal
            // 
            this.txt_kodejadwal.BackColor = System.Drawing.Color.Transparent;
            this.txt_kodejadwal.BorderRadius = 15;
            this.txt_kodejadwal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kodejadwal.DefaultText = "";
            this.txt_kodejadwal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_kodejadwal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_kodejadwal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_kodejadwal.DisabledState.Parent = this.txt_kodejadwal;
            this.txt_kodejadwal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_kodejadwal.Enabled = false;
            this.txt_kodejadwal.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_kodejadwal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_kodejadwal.FocusedState.Parent = this.txt_kodejadwal;
            this.txt_kodejadwal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kodejadwal.ForeColor = System.Drawing.Color.Black;
            this.txt_kodejadwal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_kodejadwal.HoverState.Parent = this.txt_kodejadwal;
            this.txt_kodejadwal.Location = new System.Drawing.Point(1083, 51);
            this.txt_kodejadwal.Margin = new System.Windows.Forms.Padding(6);
            this.txt_kodejadwal.Name = "txt_kodejadwal";
            this.txt_kodejadwal.PasswordChar = '\0';
            this.txt_kodejadwal.PlaceholderText = "";
            this.txt_kodejadwal.SelectedText = "";
            this.txt_kodejadwal.ShadowDecoration.Parent = this.txt_kodejadwal;
            this.txt_kodejadwal.Size = new System.Drawing.Size(191, 32);
            this.txt_kodejadwal.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(937, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 53;
            this.label13.Text = "Kode Jadwal";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CB_metode
            // 
            this.CB_metode.BackColor = System.Drawing.Color.Transparent;
            this.CB_metode.BorderRadius = 15;
            this.CB_metode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_metode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_metode.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_metode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_metode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_metode.FocusedState.Parent = this.CB_metode;
            this.CB_metode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CB_metode.ForeColor = System.Drawing.Color.Black;
            this.CB_metode.HoverState.Parent = this.CB_metode;
            this.CB_metode.ItemHeight = 26;
            this.CB_metode.Items.AddRange(new object[] {
            "- Pilih -",
            "Daring",
            "Tatap Muka"});
            this.CB_metode.ItemsAppearance.Parent = this.CB_metode;
            this.CB_metode.Location = new System.Drawing.Point(1083, 139);
            this.CB_metode.Name = "CB_metode";
            this.CB_metode.ShadowDecoration.Parent = this.CB_metode;
            this.CB_metode.Size = new System.Drawing.Size(256, 32);
            this.CB_metode.StartIndex = 0;
            this.CB_metode.TabIndex = 58;
            // 
            // txt_jam
            // 
            this.txt_jam.AutoSize = true;
            this.txt_jam.BackColor = System.Drawing.Color.Transparent;
            this.txt_jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jam.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_jam.Location = new System.Drawing.Point(155, 59);
            this.txt_jam.Name = "txt_jam";
            this.txt_jam.Size = new System.Drawing.Size(0, 24);
            this.txt_jam.TabIndex = 50;
            // 
            // kode_jadwal
            // 
            this.kode_jadwal.AutoSize = true;
            this.kode_jadwal.BackColor = System.Drawing.Color.Transparent;
            this.kode_jadwal.Location = new System.Drawing.Point(48, 177);
            this.kode_jadwal.Name = "kode_jadwal";
            this.kode_jadwal.Size = new System.Drawing.Size(0, 13);
            this.kode_jadwal.TabIndex = 60;
            this.kode_jadwal.Visible = false;
            // 
            // txt_pertemuan
            // 
            this.txt_pertemuan.AutoSize = true;
            this.txt_pertemuan.Location = new System.Drawing.Point(63, 198);
            this.txt_pertemuan.Name = "txt_pertemuan";
            this.txt_pertemuan.Size = new System.Drawing.Size(0, 13);
            this.txt_pertemuan.TabIndex = 61;
            this.txt_pertemuan.Visible = false;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Cyan;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_print_80;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientButton1.Location = new System.Drawing.Point(677, 205);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(136, 45);
            this.guna2GradientButton1.TabIndex = 62;
            this.guna2GradientButton1.Text = "      Cetak";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click_1);
            // 
            // FAbsensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Absensi_Mahasiswa.Properties.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_019;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.txt_pertemuan);
            this.Controls.Add(this.kode_jadwal);
            this.Controls.Add(this.CB_metode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_materi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_kodejadwal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_tanggal);
            this.Controls.Add(this.txt_hari);
            this.Controls.Add(this.txt_jam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_nmdosen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nidn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_stop);
            this.Controls.Add(this.Btn_start);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAbsensi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FAbsensi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_start;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_stop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txt_kode;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_nidn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_nmdosen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_tanggal;
        private System.Windows.Forms.Label txt_hari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txt_materi;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txt_kodejadwal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ComboBox CB_metode;
        private System.Windows.Forms.Label txt_jam;
        private System.Windows.Forms.Label kode_jadwal;
        private System.Windows.Forms.Label txt_pertemuan;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}

