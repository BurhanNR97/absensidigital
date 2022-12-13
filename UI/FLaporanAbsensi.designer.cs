namespace Absensi_Mahasiswa
{
    partial class FLaporanAbsensi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLaporanAbsensi));
            this.dg = new System.Windows.Forms.DataGridView();
            this.Btn_batal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_hapus = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_cetak = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_simpan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_cari = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_cari = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.ToolTip(this.components);
            this.minimize = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_tglsampai = new System.Windows.Forms.RadioButton();
            this.RB_tgl = new System.Windows.Forms.RadioButton();
            this.RB_kode = new System.Windows.Forms.RadioButton();
            this.DTP_tglakhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP_tglawal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_tanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_kode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Enabled = false;
            this.dg.Location = new System.Drawing.Point(144, 310);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1030, 448);
            this.dg.TabIndex = 33;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // Btn_batal
            // 
            this.Btn_batal.BackColor = System.Drawing.Color.Transparent;
            this.Btn_batal.BorderRadius = 15;
            this.Btn_batal.CheckedState.Parent = this.Btn_batal;
            this.Btn_batal.CustomImages.Parent = this.Btn_batal;
            this.Btn_batal.FillColor = System.Drawing.Color.Cyan;
            this.Btn_batal.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_batal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_batal.ForeColor = System.Drawing.Color.White;
            this.Btn_batal.HoverState.Parent = this.Btn_batal;
            this.Btn_batal.Image = ((System.Drawing.Image)(resources.GetObject("Btn_batal.Image")));
            this.Btn_batal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_batal.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_batal.Location = new System.Drawing.Point(856, 243);
            this.Btn_batal.Name = "Btn_batal";
            this.Btn_batal.ShadowDecoration.Parent = this.Btn_batal;
            this.Btn_batal.Size = new System.Drawing.Size(136, 45);
            this.Btn_batal.TabIndex = 32;
            this.Btn_batal.Text = "Batal";
            this.Btn_batal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_batal.Click += new System.EventHandler(this.Btn_batal_Click);
            // 
            // Btn_hapus
            // 
            this.Btn_hapus.BackColor = System.Drawing.Color.Transparent;
            this.Btn_hapus.BorderRadius = 15;
            this.Btn_hapus.CheckedState.Parent = this.Btn_hapus;
            this.Btn_hapus.CustomImages.Parent = this.Btn_hapus;
            this.Btn_hapus.FillColor = System.Drawing.Color.Cyan;
            this.Btn_hapus.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_hapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_hapus.ForeColor = System.Drawing.Color.White;
            this.Btn_hapus.HoverState.Parent = this.Btn_hapus;
            this.Btn_hapus.Image = ((System.Drawing.Image)(resources.GetObject("Btn_hapus.Image")));
            this.Btn_hapus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_hapus.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_hapus.Location = new System.Drawing.Point(1025, 178);
            this.Btn_hapus.Name = "Btn_hapus";
            this.Btn_hapus.ShadowDecoration.Parent = this.Btn_hapus;
            this.Btn_hapus.Size = new System.Drawing.Size(136, 45);
            this.Btn_hapus.TabIndex = 31;
            this.Btn_hapus.Text = "Hapus";
            this.Btn_hapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_hapus.Click += new System.EventHandler(this.Btn_hapus_Click);
            // 
            // Btn_cetak
            // 
            this.Btn_cetak.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cetak.BorderRadius = 15;
            this.Btn_cetak.CheckedState.Parent = this.Btn_cetak;
            this.Btn_cetak.CustomImages.Parent = this.Btn_cetak;
            this.Btn_cetak.FillColor = System.Drawing.Color.Cyan;
            this.Btn_cetak.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_cetak.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cetak.ForeColor = System.Drawing.Color.White;
            this.Btn_cetak.HoverState.Parent = this.Btn_cetak;
            this.Btn_cetak.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cetak.Image")));
            this.Btn_cetak.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_cetak.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_cetak.Location = new System.Drawing.Point(1025, 243);
            this.Btn_cetak.Name = "Btn_cetak";
            this.Btn_cetak.ShadowDecoration.Parent = this.Btn_cetak;
            this.Btn_cetak.Size = new System.Drawing.Size(136, 45);
            this.Btn_cetak.TabIndex = 30;
            this.Btn_cetak.Text = "Cetak";
            this.Btn_cetak.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_cetak.Click += new System.EventHandler(this.Btn_cetak_Click);
            // 
            // Btn_simpan
            // 
            this.Btn_simpan.BackColor = System.Drawing.Color.Transparent;
            this.Btn_simpan.BorderRadius = 15;
            this.Btn_simpan.CheckedState.Parent = this.Btn_simpan;
            this.Btn_simpan.CustomImages.Parent = this.Btn_simpan;
            this.Btn_simpan.Enabled = false;
            this.Btn_simpan.FillColor = System.Drawing.Color.Cyan;
            this.Btn_simpan.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_simpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_simpan.ForeColor = System.Drawing.Color.White;
            this.Btn_simpan.HoverState.Parent = this.Btn_simpan;
            this.Btn_simpan.Image = ((System.Drawing.Image)(resources.GetObject("Btn_simpan.Image")));
            this.Btn_simpan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_simpan.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_simpan.Location = new System.Drawing.Point(856, 178);
            this.Btn_simpan.Name = "Btn_simpan";
            this.Btn_simpan.ShadowDecoration.Parent = this.Btn_simpan;
            this.Btn_simpan.Size = new System.Drawing.Size(136, 45);
            this.Btn_simpan.TabIndex = 29;
            this.Btn_simpan.Text = "Simpan";
            this.Btn_simpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_simpan.Click += new System.EventHandler(this.Btn_simpan_Click);
            // 
            // Btn_cari
            // 
            this.Btn_cari.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cari.BorderRadius = 15;
            this.Btn_cari.CheckedState.Parent = this.Btn_cari;
            this.Btn_cari.CustomImages.Parent = this.Btn_cari;
            this.Btn_cari.Enabled = false;
            this.Btn_cari.FillColor = System.Drawing.Color.Cyan;
            this.Btn_cari.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_cari.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cari.ForeColor = System.Drawing.Color.White;
            this.Btn_cari.HoverState.Parent = this.Btn_cari;
            this.Btn_cari.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cari.Image")));
            this.Btn_cari.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_cari.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_cari.Location = new System.Drawing.Point(51, 194);
            this.Btn_cari.Name = "Btn_cari";
            this.Btn_cari.ShadowDecoration.Parent = this.Btn_cari;
            this.Btn_cari.Size = new System.Drawing.Size(136, 45);
            this.Btn_cari.TabIndex = 28;
            this.Btn_cari.Text = "Cari";
            this.Btn_cari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_cari.Click += new System.EventHandler(this.Btn_cari_Click);
            // 
            // txt_cari
            // 
            this.txt_cari.BorderRadius = 15;
            this.txt_cari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cari.DefaultText = "";
            this.txt_cari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cari.DisabledState.Parent = this.txt_cari;
            this.txt_cari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cari.Enabled = false;
            this.txt_cari.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_cari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cari.FocusedState.Parent = this.txt_cari;
            this.txt_cari.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cari.ForeColor = System.Drawing.Color.Black;
            this.txt_cari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cari.HoverState.Parent = this.txt_cari;
            this.txt_cari.Location = new System.Drawing.Point(49, 30);
            this.txt_cari.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.PasswordChar = '\0';
            this.txt_cari.PlaceholderText = "";
            this.txt_cari.SelectedText = "";
            this.txt_cari.ShadowDecoration.Parent = this.txt_cari;
            this.txt_cari.Size = new System.Drawing.Size(259, 32);
            this.txt_cari.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.Btn_minimize);
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 28);
            this.panel1.TabIndex = 26;
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimize.BackgroundImage")));
            this.Btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_minimize.FlatAppearance.BorderSize = 0;
            this.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimize.Location = new System.Drawing.Point(1313, 2);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.Size = new System.Drawing.Size(24, 24);
            this.Btn_minimize.TabIndex = 19;
            this.minimize.SetToolTip(this.Btn_minimize, "minimize");
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
            this.close.SetToolTip(this.Btn_close, "close");
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
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laporan Absensi Perkuliahan";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RB_tglsampai);
            this.groupBox1.Controls.Add(this.RB_tgl);
            this.groupBox1.Controls.Add(this.RB_kode);
            this.groupBox1.Controls.Add(this.DTP_tglakhir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DTP_tglawal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DTP_tanggal);
            this.groupBox1.Controls.Add(this.Btn_cari);
            this.groupBox1.Controls.Add(this.txt_cari);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(224, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 254);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Berdasarkan :";
            // 
            // RB_tglsampai
            // 
            this.RB_tglsampai.AutoSize = true;
            this.RB_tglsampai.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_tglsampai.Location = new System.Drawing.Point(24, 167);
            this.RB_tglsampai.Name = "RB_tglsampai";
            this.RB_tglsampai.Size = new System.Drawing.Size(14, 13);
            this.RB_tglsampai.TabIndex = 43;
            this.RB_tglsampai.TabStop = true;
            this.RB_tglsampai.UseVisualStyleBackColor = true;
            this.RB_tglsampai.CheckedChanged += new System.EventHandler(this.RB_tglsampai_CheckedChanged);
            // 
            // RB_tgl
            // 
            this.RB_tgl.AutoSize = true;
            this.RB_tgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_tgl.Location = new System.Drawing.Point(24, 107);
            this.RB_tgl.Name = "RB_tgl";
            this.RB_tgl.Size = new System.Drawing.Size(14, 13);
            this.RB_tgl.TabIndex = 42;
            this.RB_tgl.TabStop = true;
            this.RB_tgl.UseVisualStyleBackColor = true;
            this.RB_tgl.CheckedChanged += new System.EventHandler(this.RB_tgl_CheckedChanged);
            // 
            // RB_kode
            // 
            this.RB_kode.AutoSize = true;
            this.RB_kode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_kode.Location = new System.Drawing.Point(22, 40);
            this.RB_kode.Name = "RB_kode";
            this.RB_kode.Size = new System.Drawing.Size(14, 13);
            this.RB_kode.TabIndex = 41;
            this.RB_kode.TabStop = true;
            this.RB_kode.UseVisualStyleBackColor = true;
            this.RB_kode.CheckedChanged += new System.EventHandler(this.RB_kode_CheckedChanged);
            // 
            // DTP_tglakhir
            // 
            this.DTP_tglakhir.BorderRadius = 15;
            this.DTP_tglakhir.CheckedState.Parent = this.DTP_tglakhir;
            this.DTP_tglakhir.Enabled = false;
            this.DTP_tglakhir.FillColor = System.Drawing.Color.SkyBlue;
            this.DTP_tglakhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_tglakhir.ForeColor = System.Drawing.Color.Black;
            this.DTP_tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTP_tglakhir.HoverState.Parent = this.DTP_tglakhir;
            this.DTP_tglakhir.Location = new System.Drawing.Point(314, 157);
            this.DTP_tglakhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_tglakhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_tglakhir.Name = "DTP_tglakhir";
            this.DTP_tglakhir.ShadowDecoration.Parent = this.DTP_tglakhir;
            this.DTP_tglakhir.Size = new System.Drawing.Size(259, 32);
            this.DTP_tglakhir.TabIndex = 40;
            this.DTP_tglakhir.Value = new System.DateTime(2020, 7, 24, 19, 43, 5, 416);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Sampai Tanggal :";
            // 
            // DTP_tglawal
            // 
            this.DTP_tglawal.BorderRadius = 15;
            this.DTP_tglawal.CheckedState.Parent = this.DTP_tglawal;
            this.DTP_tglawal.Enabled = false;
            this.DTP_tglawal.FillColor = System.Drawing.Color.SkyBlue;
            this.DTP_tglawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_tglawal.ForeColor = System.Drawing.Color.Black;
            this.DTP_tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTP_tglawal.HoverState.Parent = this.DTP_tglawal;
            this.DTP_tglawal.Location = new System.Drawing.Point(51, 157);
            this.DTP_tglawal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_tglawal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_tglawal.Name = "DTP_tglawal";
            this.DTP_tglawal.ShadowDecoration.Parent = this.DTP_tglawal;
            this.DTP_tglawal.Size = new System.Drawing.Size(259, 32);
            this.DTP_tglawal.TabIndex = 38;
            this.DTP_tglawal.Value = new System.DateTime(2020, 7, 24, 19, 43, 5, 416);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dari Tanggal :";
            // 
            // DTP_tanggal
            // 
            this.DTP_tanggal.BorderRadius = 15;
            this.DTP_tanggal.CheckedState.Parent = this.DTP_tanggal;
            this.DTP_tanggal.Enabled = false;
            this.DTP_tanggal.FillColor = System.Drawing.Color.SkyBlue;
            this.DTP_tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_tanggal.ForeColor = System.Drawing.Color.Black;
            this.DTP_tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTP_tanggal.HoverState.Parent = this.DTP_tanggal;
            this.DTP_tanggal.Location = new System.Drawing.Point(51, 97);
            this.DTP_tanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_tanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_tanggal.Name = "DTP_tanggal";
            this.DTP_tanggal.ShadowDecoration.Parent = this.DTP_tanggal;
            this.DTP_tanggal.Size = new System.Drawing.Size(259, 32);
            this.DTP_tanggal.TabIndex = 36;
            this.DTP_tanggal.Value = new System.DateTime(2020, 7, 24, 19, 43, 5, 416);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // txt_kode
            // 
            this.txt_kode.BackColor = System.Drawing.Color.Transparent;
            this.txt_kode.BorderColor = System.Drawing.Color.Transparent;
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
            this.txt_kode.Location = new System.Drawing.Point(856, 107);
            this.txt_kode.Margin = new System.Windows.Forms.Padding(5);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.PasswordChar = '\0';
            this.txt_kode.PlaceholderText = "";
            this.txt_kode.SelectedText = "";
            this.txt_kode.ShadowDecoration.Parent = this.txt_kode;
            this.txt_kode.Size = new System.Drawing.Size(259, 32);
            this.txt_kode.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(862, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Kode Absensi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tanggal :";
            // 
            // FLaporanAbsensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.Btn_batal);
            this.Controls.Add(this.Btn_hapus);
            this.Controls.Add(this.Btn_cetak);
            this.Controls.Add(this.Btn_simpan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLaporanAbsensi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLaporanAbsensi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_batal;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_hapus;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_cetak;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_simpan;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_cari;
        private Guna.UI2.WinForms.Guna2TextBox txt_cari;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.ToolTip minimize;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.ToolTip close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_tglakhir;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_tglawal;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_tanggal;
        private Guna.UI2.WinForms.Guna2TextBox txt_kode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RB_tglsampai;
        private System.Windows.Forms.RadioButton RB_tgl;
        private System.Windows.Forms.RadioButton RB_kode;
        private System.Windows.Forms.Label label5;
    }
}