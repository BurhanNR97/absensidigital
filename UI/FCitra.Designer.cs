namespace Absensi_Mahasiswa.UI
{
    partial class FCitra
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRecMulty = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Btn_stop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_start = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(696, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(696, 388);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(100, 23);
            this.btnAddAll.TabIndex = 4;
            this.btnAddAll.Text = "SIMPAN DATA";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRecMulty
            // 
            this.btnRecMulty.Location = new System.Drawing.Point(696, 151);
            this.btnRecMulty.Name = "btnRecMulty";
            this.btnRecMulty.Size = new System.Drawing.Size(100, 23);
            this.btnRecMulty.TabIndex = 8;
            this.btnRecMulty.Text = "PILIH AREA";
            this.btnRecMulty.UseVisualStyleBackColor = true;
            this.btnRecMulty.Click += new System.EventHandler(this.btnRecMulty_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(696, 430);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "RESET";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.FormattingEnabled = true;
            this.textBox1.Items.AddRange(new object[] {
            "- Pilih -"});
            this.textBox1.Location = new System.Drawing.Point(663, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 21);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "- Pilih -";
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
            this.Btn_stop.Location = new System.Drawing.Point(682, 89);
            this.Btn_stop.Name = "Btn_stop";
            this.Btn_stop.ShadowDecoration.Parent = this.Btn_stop;
            this.Btn_stop.Size = new System.Drawing.Size(136, 45);
            this.Btn_stop.TabIndex = 33;
            this.Btn_stop.Text = "      Stop";
            this.Btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
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
            this.Btn_start.Location = new System.Drawing.Point(682, 26);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.ShadowDecoration.Parent = this.Btn_start;
            this.Btn_start.Size = new System.Drawing.Size(136, 45);
            this.Btn_start.TabIndex = 32;
            this.Btn_start.Text = "      Start";
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // FCitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Absensi_Mahasiswa.Properties.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_019;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 507);
            this.Controls.Add(this.Btn_stop);
            this.Controls.Add(this.Btn_start);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btnRecMulty);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FCitra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman Pengambilan Citra";
            this.Load += new System.EventHandler(this.FCitra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRecMulty;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_stop;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_start;
    }
}