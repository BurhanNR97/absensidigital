namespace Absensi_Mahasiswa
{
    partial class FMataKuliah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMataKuliah));
            this.dg = new System.Windows.Forms.DataGridView();
            this.Btn_batal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_hapus = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_ubah = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_tambah = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_simpan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_matkul = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_kode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_sks = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.ToolTip(this.components);
            this.minimize = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.dg.Location = new System.Drawing.Point(275, 359);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(771, 403);
            this.dg.TabIndex = 33;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
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
            this.Btn_batal.Location = new System.Drawing.Point(910, 284);
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
            this.Btn_hapus.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_delete_file_80;
            this.Btn_hapus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_hapus.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_hapus.Location = new System.Drawing.Point(753, 284);
            this.Btn_hapus.Name = "Btn_hapus";
            this.Btn_hapus.ShadowDecoration.Parent = this.Btn_hapus;
            this.Btn_hapus.Size = new System.Drawing.Size(136, 45);
            this.Btn_hapus.TabIndex = 31;
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
            this.Btn_ubah.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_edit_file_80;
            this.Btn_ubah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_ubah.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_ubah.Location = new System.Drawing.Point(595, 284);
            this.Btn_ubah.Name = "Btn_ubah";
            this.Btn_ubah.ShadowDecoration.Parent = this.Btn_ubah;
            this.Btn_ubah.Size = new System.Drawing.Size(136, 45);
            this.Btn_ubah.TabIndex = 30;
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
            this.Btn_tambah.Location = new System.Drawing.Point(436, 284);
            this.Btn_tambah.Name = "Btn_tambah";
            this.Btn_tambah.ShadowDecoration.Parent = this.Btn_tambah;
            this.Btn_tambah.Size = new System.Drawing.Size(136, 45);
            this.Btn_tambah.TabIndex = 29;
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
            this.Btn_simpan.Location = new System.Drawing.Point(275, 284);
            this.Btn_simpan.Name = "Btn_simpan";
            this.Btn_simpan.ShadowDecoration.Parent = this.Btn_simpan;
            this.Btn_simpan.Size = new System.Drawing.Size(136, 45);
            this.Btn_simpan.TabIndex = 28;
            this.Btn_simpan.Text = "Simpan";
            this.Btn_simpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_simpan.Click += new System.EventHandler(this.Btn_simpan_Click);
            // 
            // txt_matkul
            // 
            this.txt_matkul.BorderRadius = 15;
            this.txt_matkul.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkul.DefaultText = "";
            this.txt_matkul.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_matkul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_matkul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkul.DisabledState.Parent = this.txt_matkul;
            this.txt_matkul.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkul.Enabled = false;
            this.txt_matkul.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_matkul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkul.FocusedState.Parent = this.txt_matkul;
            this.txt_matkul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkul.ForeColor = System.Drawing.Color.Black;
            this.txt_matkul.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkul.HoverState.Parent = this.txt_matkul;
            this.txt_matkul.Location = new System.Drawing.Point(181, 81);
            this.txt_matkul.Margin = new System.Windows.Forms.Padding(5);
            this.txt_matkul.Name = "txt_matkul";
            this.txt_matkul.PasswordChar = '\0';
            this.txt_matkul.PlaceholderText = "";
            this.txt_matkul.SelectedText = "";
            this.txt_matkul.ShadowDecoration.Parent = this.txt_matkul;
            this.txt_matkul.Size = new System.Drawing.Size(437, 32);
            this.txt_matkul.TabIndex = 31;
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
            this.txt_kode.Location = new System.Drawing.Point(181, 32);
            this.txt_kode.Margin = new System.Windows.Forms.Padding(5);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.PasswordChar = '\0';
            this.txt_kode.PlaceholderText = "";
            this.txt_kode.SelectedText = "";
            this.txt_kode.ShadowDecoration.Parent = this.txt_kode;
            this.txt_kode.Size = new System.Drawing.Size(202, 32);
            this.txt_kode.TabIndex = 30;
            // 
            // txt_sks
            // 
            this.txt_sks.BorderRadius = 15;
            this.txt_sks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sks.DefaultText = "";
            this.txt_sks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sks.DisabledState.Parent = this.txt_sks;
            this.txt_sks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sks.Enabled = false;
            this.txt_sks.FillColor = System.Drawing.Color.SkyBlue;
            this.txt_sks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sks.FocusedState.Parent = this.txt_sks;
            this.txt_sks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sks.ForeColor = System.Drawing.Color.Black;
            this.txt_sks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sks.HoverState.Parent = this.txt_sks;
            this.txt_sks.Location = new System.Drawing.Point(181, 131);
            this.txt_sks.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sks.Name = "txt_sks";
            this.txt_sks.PasswordChar = '\0';
            this.txt_sks.PlaceholderText = "";
            this.txt_sks.SelectedText = "";
            this.txt_sks.ShadowDecoration.Parent = this.txt_sks;
            this.txt_sks.Size = new System.Drawing.Size(88, 32);
            this.txt_sks.TabIndex = 29;
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
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Mata Kuliah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "SKS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nama Mata Kuliah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kode Mata Kuliah";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_matkul);
            this.groupBox1.Controls.Add(this.txt_kode);
            this.groupBox1.Controls.Add(this.txt_sks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(318, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 188);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // FMataKuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.Btn_batal);
            this.Controls.Add(this.Btn_hapus);
            this.Controls.Add(this.Btn_ubah);
            this.Controls.Add(this.Btn_tambah);
            this.Controls.Add(this.Btn_simpan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMataKuliah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMataKuliah";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_batal;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_hapus;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_ubah;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_tambah;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_simpan;
        private Guna.UI2.WinForms.Guna2TextBox txt_matkul;
        private Guna.UI2.WinForms.Guna2TextBox txt_kode;
        private Guna.UI2.WinForms.Guna2TextBox txt_sks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.ToolTip minimize;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.ToolTip close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
    }
}