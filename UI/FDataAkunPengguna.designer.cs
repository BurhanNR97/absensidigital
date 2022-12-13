namespace Absensi_Mahasiswa
{
    partial class FDataAkunPengguna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDataAkunPengguna));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minimize = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.CB_level = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_tambah = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_ubah = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_hapus = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_batal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Btn_simpan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
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
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Akun Pengguna";
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
            this.panel1.TabIndex = 18;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.CB_level);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(251, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 135);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // txt_username
            // 
            this.txt_username.BorderRadius = 15;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.Parent = this.txt_username;
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.Enabled = false;
            this.txt_username.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.FocusedState.Parent = this.txt_username;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.HoverState.Parent = this.txt_username;
            this.txt_username.Location = new System.Drawing.Point(120, 83);
            this.txt_username.Margin = new System.Windows.Forms.Padding(5);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.SelectedText = "";
            this.txt_username.ShadowDecoration.Parent = this.txt_username;
            this.txt_username.Size = new System.Drawing.Size(231, 32);
            this.txt_username.TabIndex = 31;
            // 
            // txt_id
            // 
            this.txt_id.BorderRadius = 15;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.Parent = this.txt_id;
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.Enabled = false;
            this.txt_id.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.FocusedState.Parent = this.txt_id;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.HoverState.Parent = this.txt_id;
            this.txt_id.Location = new System.Drawing.Point(119, 34);
            this.txt_id.Margin = new System.Windows.Forms.Padding(5);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.ShadowDecoration.Parent = this.txt_id;
            this.txt_id.Size = new System.Drawing.Size(231, 32);
            this.txt_id.TabIndex = 30;
            // 
            // txt_password
            // 
            this.txt_password.BorderRadius = 15;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.Parent = this.txt_password;
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.Enabled = false;
            this.txt_password.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.FocusedState.Parent = this.txt_password;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.HoverState.Parent = this.txt_password;
            this.txt_password.Location = new System.Drawing.Point(521, 34);
            this.txt_password.Margin = new System.Windows.Forms.Padding(5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "";
            this.txt_password.SelectedText = "";
            this.txt_password.ShadowDecoration.Parent = this.txt_password;
            this.txt_password.Size = new System.Drawing.Size(231, 32);
            this.txt_password.TabIndex = 29;
            // 
            // CB_level
            // 
            this.CB_level.BackColor = System.Drawing.Color.Transparent;
            this.CB_level.BorderRadius = 15;
            this.CB_level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_level.Enabled = false;
            this.CB_level.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_level.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_level.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_level.FocusedState.Parent = this.CB_level;
            this.CB_level.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_level.ForeColor = System.Drawing.Color.Black;
            this.CB_level.HoverState.Parent = this.CB_level;
            this.CB_level.ItemHeight = 26;
            this.CB_level.Items.AddRange(new object[] {
            "- Pilih Level -",
            "Administrator",
            "Operator",
            "Dosen"});
            this.CB_level.ItemsAppearance.Parent = this.CB_level;
            this.CB_level.Location = new System.Drawing.Point(521, 83);
            this.CB_level.Name = "CB_level";
            this.CB_level.ShadowDecoration.Parent = this.CB_level;
            this.CB_level.Size = new System.Drawing.Size(191, 32);
            this.CB_level.StartIndex = 0;
            this.CB_level.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "id_user";
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
            this.Btn_tambah.Location = new System.Drawing.Point(436, 278);
            this.Btn_tambah.Name = "Btn_tambah";
            this.Btn_tambah.ShadowDecoration.Parent = this.Btn_tambah;
            this.Btn_tambah.Size = new System.Drawing.Size(136, 45);
            this.Btn_tambah.TabIndex = 21;
            this.Btn_tambah.Text = "Tambah";
            this.Btn_tambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_tambah.Click += new System.EventHandler(this.Btn_tambah_Click);
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
            this.Btn_ubah.Location = new System.Drawing.Point(595, 278);
            this.Btn_ubah.Name = "Btn_ubah";
            this.Btn_ubah.ShadowDecoration.Parent = this.Btn_ubah;
            this.Btn_ubah.Size = new System.Drawing.Size(136, 45);
            this.Btn_ubah.TabIndex = 22;
            this.Btn_ubah.Text = "Ubah";
            this.Btn_ubah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_ubah.Click += new System.EventHandler(this.Btn_ubah_Click);
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
            this.Btn_hapus.Location = new System.Drawing.Point(753, 278);
            this.Btn_hapus.Name = "Btn_hapus";
            this.Btn_hapus.ShadowDecoration.Parent = this.Btn_hapus;
            this.Btn_hapus.Size = new System.Drawing.Size(136, 45);
            this.Btn_hapus.TabIndex = 23;
            this.Btn_hapus.Text = "Hapus";
            this.Btn_hapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_hapus.Click += new System.EventHandler(this.Btn_hapus_Click);
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
            this.Btn_batal.Location = new System.Drawing.Point(910, 278);
            this.Btn_batal.Name = "Btn_batal";
            this.Btn_batal.ShadowDecoration.Parent = this.Btn_batal;
            this.Btn_batal.Size = new System.Drawing.Size(136, 45);
            this.Btn_batal.TabIndex = 24;
            this.Btn_batal.Text = "Batal";
            this.Btn_batal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_batal.Click += new System.EventHandler(this.Btn_batal_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Enabled = false;
            this.dg.Location = new System.Drawing.Point(275, 353);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(771, 403);
            this.dg.TabIndex = 25;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
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
            this.Btn_simpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_simpan.ForeColor = System.Drawing.Color.White;
            this.Btn_simpan.HoverState.Parent = this.Btn_simpan;
            this.Btn_simpan.Image = ((System.Drawing.Image)(resources.GetObject("Btn_simpan.Image")));
            this.Btn_simpan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_simpan.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_simpan.Location = new System.Drawing.Point(279, 278);
            this.Btn_simpan.Name = "Btn_simpan";
            this.Btn_simpan.ShadowDecoration.Parent = this.Btn_simpan;
            this.Btn_simpan.Size = new System.Drawing.Size(136, 45);
            this.Btn_simpan.TabIndex = 26;
            this.Btn_simpan.Text = "Simpan";
            this.Btn_simpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_simpan.Click += new System.EventHandler(this.Btn_simpan_Click);
            // 
            // FDataAkunPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Btn_simpan);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.Btn_batal);
            this.Controls.Add(this.Btn_hapus);
            this.Controls.Add(this.Btn_ubah);
            this.Controls.Add(this.Btn_tambah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDataAkunPengguna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDataAkunPengguna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDataAkunPengguna_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip minimize;
        private System.Windows.Forms.ToolTip close;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2ComboBox CB_level;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_tambah;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_ubah;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_hapus;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_batal;
        private System.Windows.Forms.DataGridView dg;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_simpan;
    }
}