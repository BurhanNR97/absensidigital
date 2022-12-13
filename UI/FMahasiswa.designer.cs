namespace Absensi_Mahasiswa
{
    partial class FMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMahasiswa));
            this.txt_fotopath = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_alamat = new System.Windows.Forms.RichTextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_telp = new Guna.UI2.WinForms.Guna2TextBox();
            this.CB_gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CB_agama = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DTP_tanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tmplahir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_jurusan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_angkatan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_foto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PB_foto = new System.Windows.Forms.PictureBox();
            this.txt_npm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.ToolTip(this.components);
            this.minimize = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_simpan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_batal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_hapus = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_ubah = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_tambah = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_cetak = new Guna.UI2.WinForms.Guna2GradientButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_fotopath
            // 
            this.txt_fotopath.AutoSize = true;
            this.txt_fotopath.Location = new System.Drawing.Point(45, 311);
            this.txt_fotopath.Name = "txt_fotopath";
            this.txt_fotopath.Size = new System.Drawing.Size(0, 13);
            this.txt_fotopath.TabIndex = 46;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // txt_alamat
            // 
            this.txt_alamat.BackColor = System.Drawing.Color.SkyBlue;
            this.txt_alamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_alamat.Enabled = false;
            this.txt_alamat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_alamat.Location = new System.Drawing.Point(706, 60);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(355, 76);
            this.txt_alamat.TabIndex = 34;
            this.txt_alamat.Text = "";
            // 
            // txt_email
            // 
            this.txt_email.BorderRadius = 15;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.Parent = this.txt_email;
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.Enabled = false;
            this.txt_email.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.FocusedState.Parent = this.txt_email;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.HoverState.Parent = this.txt_email;
            this.txt_email.Location = new System.Drawing.Point(706, 186);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.ShadowDecoration.Parent = this.txt_email;
            this.txt_email.Size = new System.Drawing.Size(288, 32);
            this.txt_email.TabIndex = 34;
            // 
            // txt_telp
            // 
            this.txt_telp.BorderRadius = 15;
            this.txt_telp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telp.DefaultText = "";
            this.txt_telp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_telp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_telp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telp.DisabledState.Parent = this.txt_telp;
            this.txt_telp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telp.Enabled = false;
            this.txt_telp.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_telp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telp.FocusedState.Parent = this.txt_telp;
            this.txt_telp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telp.ForeColor = System.Drawing.Color.Black;
            this.txt_telp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telp.HoverState.Parent = this.txt_telp;
            this.txt_telp.Location = new System.Drawing.Point(706, 144);
            this.txt_telp.Margin = new System.Windows.Forms.Padding(5);
            this.txt_telp.Name = "txt_telp";
            this.txt_telp.PasswordChar = '\0';
            this.txt_telp.PlaceholderText = "";
            this.txt_telp.SelectedText = "";
            this.txt_telp.ShadowDecoration.Parent = this.txt_telp;
            this.txt_telp.Size = new System.Drawing.Size(288, 32);
            this.txt_telp.TabIndex = 52;
            // 
            // CB_gender
            // 
            this.CB_gender.BackColor = System.Drawing.Color.Transparent;
            this.CB_gender.BorderRadius = 15;
            this.CB_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_gender.Enabled = false;
            this.CB_gender.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_gender.FocusedState.Parent = this.CB_gender;
            this.CB_gender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CB_gender.ForeColor = System.Drawing.Color.Black;
            this.CB_gender.HoverState.Parent = this.CB_gender;
            this.CB_gender.ItemHeight = 26;
            this.CB_gender.Items.AddRange(new object[] {
            "- Pilih -",
            "L",
            "P"});
            this.CB_gender.ItemsAppearance.Parent = this.CB_gender;
            this.CB_gender.Location = new System.Drawing.Point(283, 142);
            this.CB_gender.Name = "CB_gender";
            this.CB_gender.ShadowDecoration.Parent = this.CB_gender;
            this.CB_gender.Size = new System.Drawing.Size(133, 32);
            this.CB_gender.StartIndex = 0;
            this.CB_gender.TabIndex = 49;
            // 
            // CB_agama
            // 
            this.CB_agama.BackColor = System.Drawing.Color.Transparent;
            this.CB_agama.BorderRadius = 15;
            this.CB_agama.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_agama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_agama.Enabled = false;
            this.CB_agama.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_agama.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_agama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_agama.FocusedState.Parent = this.CB_agama;
            this.CB_agama.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CB_agama.ForeColor = System.Drawing.Color.Black;
            this.CB_agama.HoverState.Parent = this.CB_agama;
            this.CB_agama.ItemHeight = 26;
            this.CB_agama.Items.AddRange(new object[] {
            "- Pilih  -",
            "Islam",
            "Kristen",
            "Khatolik",
            "Buddha",
            "Hindu",
            "Konghuchu"});
            this.CB_agama.ItemsAppearance.Parent = this.CB_agama;
            this.CB_agama.Location = new System.Drawing.Point(706, 22);
            this.CB_agama.Name = "CB_agama";
            this.CB_agama.ShadowDecoration.Parent = this.CB_agama;
            this.CB_agama.Size = new System.Drawing.Size(191, 32);
            this.CB_agama.StartIndex = 0;
            this.CB_agama.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Email";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Enabled = false;
            this.dg.Location = new System.Drawing.Point(65, 362);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1226, 403);
            this.dg.TabIndex = 43;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
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
            this.panel1.TabIndex = 37;
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
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Mahasiswa";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(615, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Telepon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(615, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Alamat";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(615, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Agama";
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
            this.DTP_tanggal.Location = new System.Drawing.Point(426, 101);
            this.DTP_tanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_tanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_tanggal.Name = "DTP_tanggal";
            this.DTP_tanggal.ShadowDecoration.Parent = this.DTP_tanggal;
            this.DTP_tanggal.Size = new System.Drawing.Size(254, 32);
            this.DTP_tanggal.TabIndex = 41;
            this.DTP_tanggal.Value = new System.DateTime(2020, 7, 24, 19, 43, 5, 416);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Jenis Kelamin";
            // 
            // txt_tmplahir
            // 
            this.txt_tmplahir.BorderRadius = 15;
            this.txt_tmplahir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tmplahir.DefaultText = "";
            this.txt_tmplahir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tmplahir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tmplahir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tmplahir.DisabledState.Parent = this.txt_tmplahir;
            this.txt_tmplahir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tmplahir.Enabled = false;
            this.txt_tmplahir.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_tmplahir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tmplahir.FocusedState.Parent = this.txt_tmplahir;
            this.txt_tmplahir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tmplahir.ForeColor = System.Drawing.Color.Black;
            this.txt_tmplahir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tmplahir.HoverState.Parent = this.txt_tmplahir;
            this.txt_tmplahir.Location = new System.Drawing.Point(283, 101);
            this.txt_tmplahir.Margin = new System.Windows.Forms.Padding(6);
            this.txt_tmplahir.Name = "txt_tmplahir";
            this.txt_tmplahir.PasswordChar = '\0';
            this.txt_tmplahir.PlaceholderText = "";
            this.txt_tmplahir.SelectedText = "";
            this.txt_tmplahir.ShadowDecoration.Parent = this.txt_tmplahir;
            this.txt_tmplahir.Size = new System.Drawing.Size(142, 32);
            this.txt_tmplahir.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tempat Lahir";
            // 
            // txt_nama
            // 
            this.txt_nama.BorderRadius = 15;
            this.txt_nama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nama.DefaultText = "";
            this.txt_nama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nama.DisabledState.Parent = this.txt_nama;
            this.txt_nama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nama.Enabled = false;
            this.txt_nama.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_nama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nama.FocusedState.Parent = this.txt_nama;
            this.txt_nama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.ForeColor = System.Drawing.Color.Black;
            this.txt_nama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nama.HoverState.Parent = this.txt_nama;
            this.txt_nama.Location = new System.Drawing.Point(283, 60);
            this.txt_nama.Margin = new System.Windows.Forms.Padding(6);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.PasswordChar = '\0';
            this.txt_nama.PlaceholderText = "";
            this.txt_nama.SelectedText = "";
            this.txt_nama.ShadowDecoration.Parent = this.txt_nama;
            this.txt_nama.Size = new System.Drawing.Size(312, 32);
            this.txt_nama.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nama";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CB_jurusan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CB_angkatan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_alamat);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_telp);
            this.groupBox1.Controls.Add(this.CB_gender);
            this.groupBox1.Controls.Add(this.CB_agama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_foto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.PB_foto);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.DTP_tanggal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_tmplahir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_nama);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_npm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(130, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 235);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // CB_jurusan
            // 
            this.CB_jurusan.BackColor = System.Drawing.Color.Transparent;
            this.CB_jurusan.BorderRadius = 15;
            this.CB_jurusan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_jurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_jurusan.Enabled = false;
            this.CB_jurusan.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_jurusan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_jurusan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_jurusan.FocusedState.Parent = this.CB_jurusan;
            this.CB_jurusan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CB_jurusan.ForeColor = System.Drawing.Color.Black;
            this.CB_jurusan.HoverState.Parent = this.CB_jurusan;
            this.CB_jurusan.ItemHeight = 26;
            this.CB_jurusan.Items.AddRange(new object[] {
            "- Pilih -",
            "TI",
            "SI",
            "SK",
            "MI",
            "KA"});
            this.CB_jurusan.ItemsAppearance.Parent = this.CB_jurusan;
            this.CB_jurusan.Location = new System.Drawing.Point(499, 185);
            this.CB_jurusan.Name = "CB_jurusan";
            this.CB_jurusan.ShadowDecoration.Parent = this.CB_jurusan;
            this.CB_jurusan.Size = new System.Drawing.Size(101, 32);
            this.CB_jurusan.StartIndex = 0;
            this.CB_jurusan.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Jurusan";
            // 
            // CB_angkatan
            // 
            this.CB_angkatan.BackColor = System.Drawing.Color.Transparent;
            this.CB_angkatan.BorderRadius = 15;
            this.CB_angkatan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_angkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_angkatan.Enabled = false;
            this.CB_angkatan.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_angkatan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_angkatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_angkatan.FocusedState.Parent = this.CB_angkatan;
            this.CB_angkatan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CB_angkatan.ForeColor = System.Drawing.Color.Black;
            this.CB_angkatan.HoverState.Parent = this.CB_angkatan;
            this.CB_angkatan.ItemHeight = 26;
            this.CB_angkatan.Items.AddRange(new object[] {
            "- Pilih -",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.CB_angkatan.ItemsAppearance.Parent = this.CB_angkatan;
            this.CB_angkatan.Location = new System.Drawing.Point(283, 186);
            this.CB_angkatan.Name = "CB_angkatan";
            this.CB_angkatan.ShadowDecoration.Parent = this.CB_angkatan;
            this.CB_angkatan.Size = new System.Drawing.Size(116, 32);
            this.CB_angkatan.StartIndex = 0;
            this.CB_angkatan.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Angkatan";
            // 
            // Btn_foto
            // 
            this.Btn_foto.BackColor = System.Drawing.Color.Transparent;
            this.Btn_foto.BorderRadius = 15;
            this.Btn_foto.CheckedState.Parent = this.Btn_foto;
            this.Btn_foto.CustomImages.Parent = this.Btn_foto;
            this.Btn_foto.Enabled = false;
            this.Btn_foto.FillColor = System.Drawing.Color.Cyan;
            this.Btn_foto.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_foto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_foto.ForeColor = System.Drawing.Color.White;
            this.Btn_foto.HoverState.Parent = this.Btn_foto;
            this.Btn_foto.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_add_image_48;
            this.Btn_foto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_foto.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_foto.Location = new System.Drawing.Point(19, 184);
            this.Btn_foto.Name = "Btn_foto";
            this.Btn_foto.ShadowDecoration.Parent = this.Btn_foto;
            this.Btn_foto.Size = new System.Drawing.Size(125, 45);
            this.Btn_foto.TabIndex = 28;
            this.Btn_foto.Text = "Pilih";
            this.Btn_foto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_foto.Click += new System.EventHandler(this.Btn_foto_Click);
            // 
            // PB_foto
            // 
            this.PB_foto.BackColor = System.Drawing.Color.Transparent;
            this.PB_foto.Location = new System.Drawing.Point(6, 22);
            this.PB_foto.Name = "PB_foto";
            this.PB_foto.Size = new System.Drawing.Size(149, 156);
            this.PB_foto.TabIndex = 32;
            this.PB_foto.TabStop = false;
            // 
            // txt_npm
            // 
            this.txt_npm.BorderRadius = 15;
            this.txt_npm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_npm.DefaultText = "";
            this.txt_npm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_npm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_npm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_npm.DisabledState.Parent = this.txt_npm;
            this.txt_npm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_npm.Enabled = false;
            this.txt_npm.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_npm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_npm.FocusedState.Parent = this.txt_npm;
            this.txt_npm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_npm.ForeColor = System.Drawing.Color.Black;
            this.txt_npm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_npm.HoverState.Parent = this.txt_npm;
            this.txt_npm.Location = new System.Drawing.Point(283, 22);
            this.txt_npm.Margin = new System.Windows.Forms.Padding(5);
            this.txt_npm.Name = "txt_npm";
            this.txt_npm.PasswordChar = '\0';
            this.txt_npm.PlaceholderText = "";
            this.txt_npm.SelectedText = "";
            this.txt_npm.ShadowDecoration.Parent = this.txt_npm;
            this.txt_npm.Size = new System.Drawing.Size(202, 32);
            this.txt_npm.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "NPM";
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
            this.Btn_simpan.Location = new System.Drawing.Point(201, 311);
            this.Btn_simpan.Name = "Btn_simpan";
            this.Btn_simpan.ShadowDecoration.Parent = this.Btn_simpan;
            this.Btn_simpan.Size = new System.Drawing.Size(136, 45);
            this.Btn_simpan.TabIndex = 44;
            this.Btn_simpan.Text = "Simpan";
            this.Btn_simpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_simpan.Click += new System.EventHandler(this.Btn_simpan_Click);
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
            this.Btn_batal.Location = new System.Drawing.Point(836, 311);
            this.Btn_batal.Name = "Btn_batal";
            this.Btn_batal.ShadowDecoration.Parent = this.Btn_batal;
            this.Btn_batal.Size = new System.Drawing.Size(136, 45);
            this.Btn_batal.TabIndex = 42;
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
            this.Btn_hapus.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_hapus.Location = new System.Drawing.Point(679, 311);
            this.Btn_hapus.Name = "Btn_hapus";
            this.Btn_hapus.ShadowDecoration.Parent = this.Btn_hapus;
            this.Btn_hapus.Size = new System.Drawing.Size(136, 45);
            this.Btn_hapus.TabIndex = 41;
            this.Btn_hapus.Text = "Hapus";
            this.Btn_hapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_hapus.Click += new System.EventHandler(this.Btn_hapus_Click);
            // 
            // Btn_ubah
            // 
            this.Btn_ubah.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ubah.BorderRadius = 15;
            this.Btn_ubah.CheckedState.Parent = this.Btn_ubah;
            this.Btn_ubah.CustomImages.Parent = this.Btn_ubah;
            this.Btn_ubah.FillColor = System.Drawing.Color.Cyan;
            this.Btn_ubah.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_ubah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ubah.ForeColor = System.Drawing.Color.White;
            this.Btn_ubah.HoverState.Parent = this.Btn_ubah;
            this.Btn_ubah.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ubah.Image")));
            this.Btn_ubah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_ubah.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_ubah.Location = new System.Drawing.Point(521, 311);
            this.Btn_ubah.Name = "Btn_ubah";
            this.Btn_ubah.ShadowDecoration.Parent = this.Btn_ubah;
            this.Btn_ubah.Size = new System.Drawing.Size(136, 45);
            this.Btn_ubah.TabIndex = 40;
            this.Btn_ubah.Text = "Ubah";
            this.Btn_ubah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_ubah.Click += new System.EventHandler(this.Btn_ubah_Click);
            // 
            // Btn_tambah
            // 
            this.Btn_tambah.BackColor = System.Drawing.Color.Transparent;
            this.Btn_tambah.BorderRadius = 15;
            this.Btn_tambah.CheckedState.Parent = this.Btn_tambah;
            this.Btn_tambah.CustomImages.Parent = this.Btn_tambah;
            this.Btn_tambah.FillColor = System.Drawing.Color.Cyan;
            this.Btn_tambah.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_tambah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_tambah.ForeColor = System.Drawing.Color.White;
            this.Btn_tambah.HoverState.Parent = this.Btn_tambah;
            this.Btn_tambah.Image = ((System.Drawing.Image)(resources.GetObject("Btn_tambah.Image")));
            this.Btn_tambah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_tambah.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_tambah.Location = new System.Drawing.Point(362, 311);
            this.Btn_tambah.Name = "Btn_tambah";
            this.Btn_tambah.ShadowDecoration.Parent = this.Btn_tambah;
            this.Btn_tambah.Size = new System.Drawing.Size(136, 45);
            this.Btn_tambah.TabIndex = 39;
            this.Btn_tambah.Text = "Tambah";
            this.Btn_tambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_tambah.Click += new System.EventHandler(this.Btn_tambah_Click);
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
            this.Btn_cetak.Location = new System.Drawing.Point(992, 311);
            this.Btn_cetak.Name = "Btn_cetak";
            this.Btn_cetak.ShadowDecoration.Parent = this.Btn_cetak;
            this.Btn_cetak.Size = new System.Drawing.Size(136, 45);
            this.Btn_cetak.TabIndex = 45;
            this.Btn_cetak.Text = "Cetak";
            this.Btn_cetak.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.txt_fotopath);
            this.Controls.Add(this.Btn_simpan);
            this.Controls.Add(this.Btn_batal);
            this.Controls.Add(this.Btn_hapus);
            this.Controls.Add(this.Btn_ubah);
            this.Controls.Add(this.Btn_tambah);
            this.Controls.Add(this.Btn_cetak);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMahasiswa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_fotopath;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_simpan;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_batal;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_hapus;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_ubah;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_tambah;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_cetak;
        private System.Windows.Forms.RichTextBox txt_alamat;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_telp;
        private Guna.UI2.WinForms.Guna2ComboBox CB_gender;
        private Guna.UI2.WinForms.Guna2ComboBox CB_agama;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_foto;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.ToolTip minimize;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.ToolTip close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_tanggal;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_tmplahir;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_nama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PB_foto;
        private Guna.UI2.WinForms.Guna2TextBox txt_npm;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private Guna.UI2.WinForms.Guna2ComboBox CB_jurusan;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox CB_angkatan;
        private System.Windows.Forms.Label label2;
    }
}