namespace Absensi_Mahasiswa
{
    partial class FUtamaDosen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUtamaDosen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_absensi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_logout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_tanggal = new System.Windows.Forms.Label();
            this.txt_hari = new System.Windows.Forms.Label();
            this.txt_jam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.minimize = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txt_dosen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_welcome = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Btn_absensi);
            this.groupBox1.Controls.Add(this.Btn_logout);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(24, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 186);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistem";
            // 
            // Btn_absensi
            // 
            this.Btn_absensi.BorderRadius = 15;
            this.Btn_absensi.CheckedState.Parent = this.Btn_absensi;
            this.Btn_absensi.CustomImages.Parent = this.Btn_absensi;
            this.Btn_absensi.Enabled = false;
            this.Btn_absensi.FillColor = System.Drawing.Color.Cyan;
            this.Btn_absensi.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_absensi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_absensi.ForeColor = System.Drawing.Color.White;
            this.Btn_absensi.HoverState.Parent = this.Btn_absensi;
            this.Btn_absensi.Image = global::Absensi_Mahasiswa.Properties.Resources.icons8_attendance_48;
            this.Btn_absensi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_absensi.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_absensi.Location = new System.Drawing.Point(52, 63);
            this.Btn_absensi.Name = "Btn_absensi";
            this.Btn_absensi.ShadowDecoration.Parent = this.Btn_absensi;
            this.Btn_absensi.Size = new System.Drawing.Size(180, 45);
            this.Btn_absensi.TabIndex = 2;
            this.Btn_absensi.Text = "      Absensi";
            this.Btn_absensi.Click += new System.EventHandler(this.Btn_absensi_Click);
            // 
            // Btn_logout
            // 
            this.Btn_logout.BorderRadius = 15;
            this.Btn_logout.CheckedState.Parent = this.Btn_logout;
            this.Btn_logout.CustomImages.Parent = this.Btn_logout;
            this.Btn_logout.FillColor = System.Drawing.Color.Cyan;
            this.Btn_logout.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.Btn_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_logout.ForeColor = System.Drawing.Color.White;
            this.Btn_logout.HoverState.Parent = this.Btn_logout;
            this.Btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("Btn_logout.Image")));
            this.Btn_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_logout.ImageSize = new System.Drawing.Size(55, 55);
            this.Btn_logout.Location = new System.Drawing.Point(52, 123);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.ShadowDecoration.Parent = this.Btn_logout;
            this.Btn_logout.Size = new System.Drawing.Size(180, 45);
            this.Btn_logout.TabIndex = 2;
            this.Btn_logout.Text = "      Logout";
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // txt_tanggal
            // 
            this.txt_tanggal.AutoSize = true;
            this.txt_tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tanggal.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_tanggal.Location = new System.Drawing.Point(118, 117);
            this.txt_tanggal.Name = "txt_tanggal";
            this.txt_tanggal.Size = new System.Drawing.Size(0, 24);
            this.txt_tanggal.TabIndex = 13;
            // 
            // txt_hari
            // 
            this.txt_hari.AutoSize = true;
            this.txt_hari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hari.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_hari.Location = new System.Drawing.Point(118, 83);
            this.txt_hari.Name = "txt_hari";
            this.txt_hari.Size = new System.Drawing.Size(0, 24);
            this.txt_hari.TabIndex = 12;
            // 
            // txt_jam
            // 
            this.txt_jam.AutoSize = true;
            this.txt_jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jam.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_jam.Location = new System.Drawing.Point(115, 50);
            this.txt_jam.Name = "txt_jam";
            this.txt_jam.Size = new System.Drawing.Size(0, 24);
            this.txt_jam.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(103, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(659, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(465, 31);
            this.label9.TabIndex = 27;
            this.label9.Text = "(STMIK) HANDAYANI MAKASSAR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(464, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(890, 31);
            this.label8.TabIndex = 26;
            this.label8.Text = "SEKOLAH TINGGI MANAJEMEN INFORMATIKA DAN KOMPUTER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(103, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(103, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jam";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 5;
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Controls.Add(this.txt_tanggal);
            this.guna2Panel1.Controls.Add(this.txt_hari);
            this.guna2Panel1.Controls.Add(this.txt_jam);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 52);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(326, 713);
            this.guna2Panel1.TabIndex = 24;
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimize.BackgroundImage")));
            this.Btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_minimize.FlatAppearance.BorderSize = 0;
            this.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimize.Location = new System.Drawing.Point(1312, 2);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.Size = new System.Drawing.Size(24, 24);
            this.Btn_minimize.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(540, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Absensi Mahasiswa Berbasis Pengenalan Wajah - Halaman Dosen";
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
            this.panel1.TabIndex = 23;
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(344, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 97);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(381, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 22);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jadwal Mengajar";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(393, 318);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(794, 378);
            this.dg.TabIndex = 30;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // txt_dosen
            // 
            this.txt_dosen.AutoSize = true;
            this.txt_dosen.BackColor = System.Drawing.Color.Transparent;
            this.txt_dosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dosen.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_dosen.Location = new System.Drawing.Point(509, 220);
            this.txt_dosen.Name = "txt_dosen";
            this.txt_dosen.Size = new System.Drawing.Size(0, 20);
            this.txt_dosen.TabIndex = 31;
            this.txt_dosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 32;
            this.label10.Visible = false;
            // 
            // txt_welcome
            // 
            this.txt_welcome.AutoSize = true;
            this.txt_welcome.BackColor = System.Drawing.Color.Transparent;
            this.txt_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_welcome.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_welcome.Location = new System.Drawing.Point(373, 219);
            this.txt_welcome.Name = "txt_welcome";
            this.txt_welcome.Size = new System.Drawing.Size(139, 20);
            this.txt_welcome.TabIndex = 28;
            this.txt_welcome.Text = "Selamat Datang";
            this.txt_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_welcome.Click += new System.EventHandler(this.txt_welcome_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(39, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Pilih jadwal terlebih dahulu";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FUtamaDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_dosen);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_welcome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUtamaDosen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUtamaDosen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FUtamaDosen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_logout;
        private System.Windows.Forms.Label txt_tanggal;
        private System.Windows.Forms.Label txt_hari;
        private System.Windows.Forms.Label txt_jam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ToolTip minimize;
        private System.Windows.Forms.Button Btn_minimize;
        private System.Windows.Forms.ToolTip close;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_absensi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label txt_dosen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_welcome;
        private System.Windows.Forms.Label label11;
    }
}