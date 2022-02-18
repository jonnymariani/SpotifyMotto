namespace SpotifyMotto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TXTNoMusic = new System.Windows.Forms.TextBox();
            this.LBLOriginalMotto = new System.Windows.Forms.Label();
            this.PICMain = new System.Windows.Forms.PictureBox();
            this.BTNStart = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLGithub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PICMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTNoMusic
            // 
            this.TXTNoMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTNoMusic.Font = new System.Drawing.Font("Volter (Goldfish)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTNoMusic.Location = new System.Drawing.Point(25, 243);
            this.TXTNoMusic.MaxLength = 38;
            this.TXTNoMusic.Name = "TXTNoMusic";
            this.TXTNoMusic.PlaceholderText = "Your motto here :)";
            this.TXTNoMusic.Size = new System.Drawing.Size(432, 18);
            this.TXTNoMusic.TabIndex = 1;
            this.TXTNoMusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTNoMusic.TextChanged += new System.EventHandler(this.TXTNoMusic_TextChanged);
            // 
            // LBLOriginalMotto
            // 
            this.LBLOriginalMotto.AutoSize = true;
            this.LBLOriginalMotto.BackColor = System.Drawing.Color.Transparent;
            this.LBLOriginalMotto.Font = new System.Drawing.Font("Volter (Goldfish)", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLOriginalMotto.Location = new System.Drawing.Point(25, 222);
            this.LBLOriginalMotto.Name = "LBLOriginalMotto";
            this.LBLOriginalMotto.Size = new System.Drawing.Size(90, 12);
            this.LBLOriginalMotto.TabIndex = 2;
            this.LBLOriginalMotto.Text = "Original Motto:";
            // 
            // PICMain
            // 
            this.PICMain.BackColor = System.Drawing.Color.Transparent;
            this.PICMain.Image = ((System.Drawing.Image)(resources.GetObject("PICMain.Image")));
            this.PICMain.InitialImage = null;
            this.PICMain.Location = new System.Drawing.Point(167, 44);
            this.PICMain.Name = "PICMain";
            this.PICMain.Size = new System.Drawing.Size(146, 146);
            this.PICMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PICMain.TabIndex = 5;
            this.PICMain.TabStop = false;
            // 
            // BTNStart
            // 
            this.BTNStart.BackColor = System.Drawing.Color.Transparent;
            this.BTNStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.BTNStart.FlatAppearance.BorderSize = 0;
            this.BTNStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTNStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNStart.Font = new System.Drawing.Font("Volter (Goldfish)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNStart.Image = global::SpotifyMotto.Properties.Resources.startbtn;
            this.BTNStart.Location = new System.Drawing.Point(22, 271);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(437, 43);
            this.BTNStart.TabIndex = 0;
            this.BTNStart.Text = "Stop";
            this.BTNStart.UseVisualStyleBackColor = false;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click);
            this.BTNStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTNStart_MouseDown);
            this.BTNStart.MouseEnter += new System.EventHandler(this.BTNStart_MouseEnter);
            this.BTNStart.MouseLeave += new System.EventHandler(this.BTNStart_MouseLeave);
            this.BTNStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTNStart_MouseUp);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Volter (Goldfish)", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.Image = global::SpotifyMotto.Properties.Resources.settingsbtn;
            this.btnSettings.Location = new System.Drawing.Point(22, 320);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(79, 30);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseDown);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            this.btnSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseUp);
            // 
            // BTNClose
            // 
            this.BTNClose.BackColor = System.Drawing.Color.Transparent;
            this.BTNClose.FlatAppearance.BorderSize = 0;
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNClose.Image = global::SpotifyMotto.Properties.Resources.closebtn;
            this.BTNClose.Location = new System.Drawing.Point(452, 7);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(20, 20);
            this.BTNClose.TabIndex = 8;
            this.BTNClose.UseVisualStyleBackColor = false;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            this.BTNClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTNClose_MouseDown);
            this.BTNClose.MouseEnter += new System.EventHandler(this.BTNClose_MouseEnter);
            this.BTNClose.MouseLeave += new System.EventHandler(this.BTNClose_MouseLeave);
            this.BTNClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTNClose_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Volter-Bold (Goldfish)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Spotify Motto";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SpotifyMotto.Properties.Resources.txtbg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(23, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 25);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LBLGithub
            // 
            this.LBLGithub.AutoSize = true;
            this.LBLGithub.BackColor = System.Drawing.Color.Transparent;
            this.LBLGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLGithub.Font = new System.Drawing.Font("Volter (Goldfish)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLGithub.Location = new System.Drawing.Point(404, 335);
            this.LBLGithub.Name = "LBLGithub";
            this.LBLGithub.Size = new System.Drawing.Size(53, 15);
            this.LBLGithub.TabIndex = 12;
            this.LBLGithub.Text = "github";
            this.LBLGithub.Click += new System.EventHandler(this.LBLGithub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(24)))));
            this.BackgroundImage = global::SpotifyMotto.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(480, 363);
            this.Controls.Add(this.LBLGithub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.BTNStart);
            this.Controls.Add(this.PICMain);
            this.Controls.Add(this.LBLOriginalMotto);
            this.Controls.Add(this.TXTNoMusic);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Spotify Motto";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(24)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PICMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTNoMusic;
        private System.Windows.Forms.Label LBLOriginalMotto;
        private System.Windows.Forms.PictureBox PICMain;
        private System.Windows.Forms.Button BTNStart;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBLGithub;
    }
}
