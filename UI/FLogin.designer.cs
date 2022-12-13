namespace Absensi_Mahasiswa
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minimize = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.PB_usermati = new System.Windows.Forms.PictureBox();
            this.PB_passmati = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.ToolTip(this.components);
            this.password = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_usermati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_passmati)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minimize
            // 
            this.minimize.Popup += new System.Windows.Forms.PopupEventHandler(this.minimize_Popup);
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
            this.minimize.SetToolTip(this.Btn_minimize, "minimize");
            this.Btn_minimize.UseVisualStyleBackColor = true;
            this.Btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // close
            // 
            this.close.Popup += new System.Windows.Forms.PopupEventHandler(this.close_Popup);
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
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Halaman Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(543, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "ABSENSI MAHASISWA";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(481, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "BERBASIS PENGENALAN WAJAH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(548, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_username.BorderRadius = 15;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.Parent = this.txt_username;
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FillColor = System.Drawing.Color.Aqua;
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.FocusedState.Parent = this.txt_username;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.HoverState.Parent = this.txt_username;
            this.txt_username.Location = new System.Drawing.Point(533, 431);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.SelectedText = "";
            this.txt_username.ShadowDecoration.Parent = this.txt_username;
            this.txt_username.Size = new System.Drawing.Size(291, 31);
            this.txt_username.TabIndex = 22;
            this.username.SetToolTip(this.txt_username, "masukkan username anda");
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_password.BorderRadius = 15;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.Parent = this.txt_password;
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FillColor = System.Drawing.Color.Aqua;
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.FocusedState.Parent = this.txt_password;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.HoverState.Parent = this.txt_password;
            this.txt_password.Location = new System.Drawing.Point(533, 472);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "";
            this.txt_password.SelectedText = "";
            this.txt_password.ShadowDecoration.Parent = this.txt_password;
            this.txt_password.Size = new System.Drawing.Size(291, 31);
            this.txt_password.TabIndex = 23;
            this.password.SetToolTip(this.txt_password, "masukkan password anda");
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // PB_usermati
            // 
            this.PB_usermati.BackColor = System.Drawing.Color.Transparent;
            this.PB_usermati.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_usermati.BackgroundImage")));
            this.PB_usermati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_usermati.Location = new System.Drawing.Point(499, 431);
            this.PB_usermati.Name = "PB_usermati";
            this.PB_usermati.Size = new System.Drawing.Size(30, 31);
            this.PB_usermati.TabIndex = 24;
            this.PB_usermati.TabStop = false;
            this.PB_usermati.Click += new System.EventHandler(this.PB_usermati_Click);
            // 
            // PB_passmati
            // 
            this.PB_passmati.BackColor = System.Drawing.Color.Transparent;
            this.PB_passmati.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_passmati.BackgroundImage")));
            this.PB_passmati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_passmati.Location = new System.Drawing.Point(495, 472);
            this.PB_passmati.Name = "PB_passmati";
            this.PB_passmati.Size = new System.Drawing.Size(30, 31);
            this.PB_passmati.TabIndex = 25;
            this.PB_passmati.TabStop = false;
            this.PB_passmati.Click += new System.EventHandler(this.PB_passmati_Click);
            // 
            // username
            // 
            this.username.Popup += new System.Windows.Forms.PopupEventHandler(this.username_Popup);
            // 
            // password
            // 
            this.password.Popup += new System.Windows.Forms.PopupEventHandler(this.password_Popup);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(562, 505);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 22);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Tampilkan kata sandi";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(581, 556);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 27;
            this.guna2GradientButton1.Text = "LOGIN";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PB_passmati);
            this.Controls.Add(this.PB_usermati);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_usermati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_passmati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private System.Windows.Forms.PictureBox PB_usermati;
        private System.Windows.Forms.PictureBox PB_passmati;
        private System.Windows.Forms.ToolTip username;
        private System.Windows.Forms.ToolTip password;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}