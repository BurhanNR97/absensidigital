namespace Absensi_Mahasiswa
{
    partial class FJadwalKuliah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJadwalKuliah));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minimize = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_semester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_kodeMATKUL = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_dosen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_nidn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_namaMATKUL = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_kelas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CB_jam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kode = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_batal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_hapus = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_ubah = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_tambah = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_simpan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_jurusan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CB_hari = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Jurusan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kode Jadwal Kuliah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jadwal Perkuliahan";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Enabled = false;
            this.dg.Location = new System.Drawing.Point(59, 437);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1245, 316);
            this.dg.TabIndex = 41;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CB_hari);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CB_jurusan);
            this.groupBox1.Controls.Add(this.CB_semester);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CB_kodeMATKUL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CB_dosen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CB_nidn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CB_namaMATKUL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CB_kelas);
            this.groupBox1.Controls.Add(this.CB_jam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_kode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(160, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 262);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // CB_semester
            // 
            this.CB_semester.BackColor = System.Drawing.Color.Transparent;
            this.CB_semester.BorderRadius = 15;
            this.CB_semester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_semester.Enabled = false;
            this.CB_semester.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_semester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_semester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_semester.FocusedState.Parent = this.CB_semester;
            this.CB_semester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_semester.ForeColor = System.Drawing.Color.Black;
            this.CB_semester.HoverState.Parent = this.CB_semester;
            this.CB_semester.ItemHeight = 26;
            this.CB_semester.Items.AddRange(new object[] {
            "- Pilih -",
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.CB_semester.ItemsAppearance.Parent = this.CB_semester;
            this.CB_semester.Location = new System.Drawing.Point(647, 121);
            this.CB_semester.Name = "CB_semester";
            this.CB_semester.ShadowDecoration.Parent = this.CB_semester;
            this.CB_semester.Size = new System.Drawing.Size(98, 32);
            this.CB_semester.StartIndex = 0;
            this.CB_semester.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Semester";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // CB_kodeMATKUL
            // 
            this.CB_kodeMATKUL.BackColor = System.Drawing.Color.Transparent;
            this.CB_kodeMATKUL.BorderRadius = 15;
            this.CB_kodeMATKUL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_kodeMATKUL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_kodeMATKUL.Enabled = false;
            this.CB_kodeMATKUL.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_kodeMATKUL.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_kodeMATKUL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_kodeMATKUL.FocusedState.Parent = this.CB_kodeMATKUL;
            this.CB_kodeMATKUL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_kodeMATKUL.ForeColor = System.Drawing.Color.Black;
            this.CB_kodeMATKUL.HoverState.Parent = this.CB_kodeMATKUL;
            this.CB_kodeMATKUL.ItemHeight = 26;
            this.CB_kodeMATKUL.ItemsAppearance.Parent = this.CB_kodeMATKUL;
            this.CB_kodeMATKUL.Location = new System.Drawing.Point(191, 166);
            this.CB_kodeMATKUL.Name = "CB_kodeMATKUL";
            this.CB_kodeMATKUL.ShadowDecoration.Parent = this.CB_kodeMATKUL;
            this.CB_kodeMATKUL.Size = new System.Drawing.Size(279, 32);
            this.CB_kodeMATKUL.TabIndex = 52;
            this.CB_kodeMATKUL.SelectionChangeCommitted += new System.EventHandler(this.CB_kodeMATKUL_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Kode Mata Kuliah";
            // 
            // CB_dosen
            // 
            this.CB_dosen.BackColor = System.Drawing.Color.Transparent;
            this.CB_dosen.BorderRadius = 15;
            this.CB_dosen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_dosen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_dosen.Enabled = false;
            this.CB_dosen.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_dosen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_dosen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_dosen.FocusedState.Parent = this.CB_dosen;
            this.CB_dosen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_dosen.ForeColor = System.Drawing.Color.Black;
            this.CB_dosen.HoverState.Parent = this.CB_dosen;
            this.CB_dosen.ItemHeight = 26;
            this.CB_dosen.ItemsAppearance.Parent = this.CB_dosen;
            this.CB_dosen.Location = new System.Drawing.Point(191, 121);
            this.CB_dosen.Name = "CB_dosen";
            this.CB_dosen.ShadowDecoration.Parent = this.CB_dosen;
            this.CB_dosen.Size = new System.Drawing.Size(279, 32);
            this.CB_dosen.TabIndex = 50;
            this.CB_dosen.SelectionChangeCommitted += new System.EventHandler(this.CB_dosen_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Nama Dosen";
            // 
            // CB_nidn
            // 
            this.CB_nidn.BackColor = System.Drawing.Color.Transparent;
            this.CB_nidn.BorderRadius = 15;
            this.CB_nidn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_nidn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_nidn.Enabled = false;
            this.CB_nidn.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_nidn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_nidn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_nidn.FocusedState.Parent = this.CB_nidn;
            this.CB_nidn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_nidn.ForeColor = System.Drawing.Color.Black;
            this.CB_nidn.HoverState.Parent = this.CB_nidn;
            this.CB_nidn.ItemHeight = 26;
            this.CB_nidn.ItemsAppearance.Parent = this.CB_nidn;
            this.CB_nidn.Location = new System.Drawing.Point(191, 76);
            this.CB_nidn.Name = "CB_nidn";
            this.CB_nidn.ShadowDecoration.Parent = this.CB_nidn;
            this.CB_nidn.Size = new System.Drawing.Size(279, 32);
            this.CB_nidn.TabIndex = 48;
            this.CB_nidn.SelectionChangeCommitted += new System.EventHandler(this.CB_nidn_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "NIDN Dosen";
            // 
            // CB_namaMATKUL
            // 
            this.CB_namaMATKUL.BackColor = System.Drawing.Color.Transparent;
            this.CB_namaMATKUL.BorderRadius = 15;
            this.CB_namaMATKUL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_namaMATKUL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_namaMATKUL.Enabled = false;
            this.CB_namaMATKUL.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_namaMATKUL.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_namaMATKUL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_namaMATKUL.FocusedState.Parent = this.CB_namaMATKUL;
            this.CB_namaMATKUL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_namaMATKUL.ForeColor = System.Drawing.Color.Black;
            this.CB_namaMATKUL.HoverState.Parent = this.CB_namaMATKUL;
            this.CB_namaMATKUL.ItemHeight = 26;
            this.CB_namaMATKUL.ItemsAppearance.Parent = this.CB_namaMATKUL;
            this.CB_namaMATKUL.Location = new System.Drawing.Point(191, 212);
            this.CB_namaMATKUL.Name = "CB_namaMATKUL";
            this.CB_namaMATKUL.ShadowDecoration.Parent = this.CB_namaMATKUL;
            this.CB_namaMATKUL.Size = new System.Drawing.Size(279, 32);
            this.CB_namaMATKUL.TabIndex = 46;
            this.CB_namaMATKUL.SelectionChangeCommitted += new System.EventHandler(this.CB_namaMATKUL_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Nama Mata Kuliah";
            // 
            // CB_kelas
            // 
            this.CB_kelas.BackColor = System.Drawing.Color.Transparent;
            this.CB_kelas.BorderRadius = 15;
            this.CB_kelas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_kelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_kelas.Enabled = false;
            this.CB_kelas.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_kelas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_kelas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_kelas.FocusedState.Parent = this.CB_kelas;
            this.CB_kelas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_kelas.ForeColor = System.Drawing.Color.Black;
            this.CB_kelas.HoverState.Parent = this.CB_kelas;
            this.CB_kelas.ItemHeight = 26;
            this.CB_kelas.Items.AddRange(new object[] {
            "- Pilih Kelas -",
            "A",
            "B",
            "C",
            "D",
            "Malam",
            "Ekstensi",
            "RPL",
            "Web",
            "Multimedia"});
            this.CB_kelas.ItemsAppearance.Parent = this.CB_kelas;
            this.CB_kelas.Location = new System.Drawing.Point(647, 32);
            this.CB_kelas.Name = "CB_kelas";
            this.CB_kelas.ShadowDecoration.Parent = this.CB_kelas;
            this.CB_kelas.Size = new System.Drawing.Size(163, 32);
            this.CB_kelas.StartIndex = 0;
            this.CB_kelas.TabIndex = 44;
            // 
            // CB_jam
            // 
            this.CB_jam.BackColor = System.Drawing.Color.Transparent;
            this.CB_jam.BorderRadius = 15;
            this.CB_jam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_jam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_jam.Enabled = false;
            this.CB_jam.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_jam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_jam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_jam.FocusedState.Parent = this.CB_jam;
            this.CB_jam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_jam.ForeColor = System.Drawing.Color.Black;
            this.CB_jam.HoverState.Parent = this.CB_jam;
            this.CB_jam.ItemHeight = 26;
            this.CB_jam.Items.AddRange(new object[] {
            "- Pilih Waktu -",
            "08.00 ~ 10.00",
            "10.00 ~ 12.00",
            "13.00 ~ 15.00",
            "15.00 ~ 17.00",
            "17.00 ~ 19.00",
            "19.00 ~ 21.00"});
            this.CB_jam.ItemsAppearance.Parent = this.CB_jam;
            this.CB_jam.Location = new System.Drawing.Point(647, 212);
            this.CB_jam.Name = "CB_jam";
            this.CB_jam.ShadowDecoration.Parent = this.CB_jam;
            this.CB_jam.Size = new System.Drawing.Size(269, 32);
            this.CB_jam.StartIndex = 0;
            this.CB_jam.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Jam Mengajar";
            // 
            // txt_kode
            // 
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
            this.txt_kode.Location = new System.Drawing.Point(191, 32);
            this.txt_kode.Margin = new System.Windows.Forms.Padding(5);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.PasswordChar = '\0';
            this.txt_kode.PlaceholderText = "";
            this.txt_kode.SelectedText = "";
            this.txt_kode.ShadowDecoration.Parent = this.txt_kode;
            this.txt_kode.Size = new System.Drawing.Size(250, 32);
            this.txt_kode.TabIndex = 30;
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
            this.Btn_batal.Location = new System.Drawing.Point(894, 376);
            this.Btn_batal.Name = "Btn_batal";
            this.Btn_batal.ShadowDecoration.Parent = this.Btn_batal;
            this.Btn_batal.Size = new System.Drawing.Size(146, 45);
            this.Btn_batal.TabIndex = 40;
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
            this.Btn_hapus.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_delete_bin_100;
            this.Btn_hapus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_hapus.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_hapus.Location = new System.Drawing.Point(737, 376);
            this.Btn_hapus.Name = "Btn_hapus";
            this.Btn_hapus.ShadowDecoration.Parent = this.Btn_hapus;
            this.Btn_hapus.Size = new System.Drawing.Size(146, 45);
            this.Btn_hapus.TabIndex = 39;
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
            this.Btn_ubah.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_create_100;
            this.Btn_ubah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_ubah.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_ubah.Location = new System.Drawing.Point(579, 376);
            this.Btn_ubah.Name = "Btn_ubah";
            this.Btn_ubah.ShadowDecoration.Parent = this.Btn_ubah;
            this.Btn_ubah.Size = new System.Drawing.Size(146, 45);
            this.Btn_ubah.TabIndex = 38;
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
            this.Btn_tambah.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_new_copy_80;
            this.Btn_tambah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_tambah.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_tambah.Location = new System.Drawing.Point(420, 376);
            this.Btn_tambah.Name = "Btn_tambah";
            this.Btn_tambah.ShadowDecoration.Parent = this.Btn_tambah;
            this.Btn_tambah.Size = new System.Drawing.Size(146, 45);
            this.Btn_tambah.TabIndex = 37;
            this.Btn_tambah.Text = "Tambah";
            this.Btn_tambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_tambah.Click += new System.EventHandler(this.Btn_tambah_Click);
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
            this.Btn_simpan.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_save_close_48;
            this.Btn_simpan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_simpan.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_simpan.Location = new System.Drawing.Point(259, 376);
            this.Btn_simpan.Name = "Btn_simpan";
            this.Btn_simpan.ShadowDecoration.Parent = this.Btn_simpan;
            this.Btn_simpan.Size = new System.Drawing.Size(146, 45);
            this.Btn_simpan.TabIndex = 36;
            this.Btn_simpan.Text = "Simpan";
            this.Btn_simpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_simpan.Click += new System.EventHandler(this.Btn_simpan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
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
            this.panel1.TabIndex = 34;
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
            this.CB_jurusan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_jurusan.ForeColor = System.Drawing.Color.Black;
            this.CB_jurusan.HoverState.Parent = this.CB_jurusan;
            this.CB_jurusan.ItemHeight = 26;
            this.CB_jurusan.Items.AddRange(new object[] {
            "- Pilih -",
            "Teknik Informatika",
            "Sistem Komputer",
            "Sistem Informatika",
            "Manajemen Informatika",
            "Komputerisasi Akuntansi"});
            this.CB_jurusan.ItemsAppearance.Parent = this.CB_jurusan;
            this.CB_jurusan.Location = new System.Drawing.Point(647, 76);
            this.CB_jurusan.Name = "CB_jurusan";
            this.CB_jurusan.ShadowDecoration.Parent = this.CB_jurusan;
            this.CB_jurusan.Size = new System.Drawing.Size(269, 32);
            this.CB_jurusan.StartIndex = 0;
            this.CB_jurusan.TabIndex = 55;
            // 
            // CB_hari
            // 
            this.CB_hari.BackColor = System.Drawing.Color.Transparent;
            this.CB_hari.BorderRadius = 15;
            this.CB_hari.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_hari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_hari.Enabled = false;
            this.CB_hari.FillColor = System.Drawing.Color.SkyBlue;
            this.CB_hari.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_hari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_hari.FocusedState.Parent = this.CB_hari;
            this.CB_hari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_hari.ForeColor = System.Drawing.Color.Black;
            this.CB_hari.HoverState.Parent = this.CB_hari;
            this.CB_hari.ItemHeight = 26;
            this.CB_hari.Items.AddRange(new object[] {
            "- Pilih -",
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu",
            "Minggu"});
            this.CB_hari.ItemsAppearance.Parent = this.CB_hari;
            this.CB_hari.Location = new System.Drawing.Point(647, 166);
            this.CB_hari.Name = "CB_hari";
            this.CB_hari.ShadowDecoration.Parent = this.CB_hari;
            this.CB_hari.Size = new System.Drawing.Size(175, 32);
            this.CB_hari.StartIndex = 0;
            this.CB_hari.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Hari";
            // 
            // FJadwalKuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_batal);
            this.Controls.Add(this.Btn_hapus);
            this.Controls.Add(this.Btn_ubah);
            this.Controls.Add(this.Btn_tambah);
            this.Controls.Add(this.Btn_simpan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FJadwalKuliah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FJadwalKuliah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip minimize;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.ToolTip close;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_kode;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_batal;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_hapus;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_ubah;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_tambah;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_simpan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox CB_jam;
        private Guna.UI2.WinForms.Guna2ComboBox CB_kelas;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox CB_kodeMATKUL;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox CB_dosen;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox CB_nidn;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox CB_namaMATKUL;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox CB_semester;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox CB_hari;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox CB_jurusan;
    }
}