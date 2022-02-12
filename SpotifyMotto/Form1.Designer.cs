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
            this.PBGithub = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PICMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTNoMusic
            // 
            this.TXTNoMusic.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTNoMusic.Location = new System.Drawing.Point(12, 178);
            this.TXTNoMusic.MaxLength = 38;
            this.TXTNoMusic.Name = "TXTNoMusic";
            this.TXTNoMusic.PlaceholderText = "Your motto here :)";
            this.TXTNoMusic.Size = new System.Drawing.Size(436, 26);
            this.TXTNoMusic.TabIndex = 1;
            this.TXTNoMusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTNoMusic.TextChanged += new System.EventHandler(this.TXTNoMusic_TextChanged);
            // 
            // LBLOriginalMotto
            // 
            this.LBLOriginalMotto.AutoSize = true;
            this.LBLOriginalMotto.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLOriginalMotto.Location = new System.Drawing.Point(12, 164);
            this.LBLOriginalMotto.Name = "LBLOriginalMotto";
            this.LBLOriginalMotto.Size = new System.Drawing.Size(95, 11);
            this.LBLOriginalMotto.TabIndex = 2;
            this.LBLOriginalMotto.Text = "Original Motto:";
            // 
            // PICMain
            // 
            this.PICMain.Image = ((System.Drawing.Image)(resources.GetObject("PICMain.Image")));
            this.PICMain.InitialImage = null;
            this.PICMain.Location = new System.Drawing.Point(157, 7);
            this.PICMain.Name = "PICMain";
            this.PICMain.Size = new System.Drawing.Size(146, 146);
            this.PICMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PICMain.TabIndex = 5;
            this.PICMain.TabStop = false;
            // 
            // BTNStart
            // 
            this.BTNStart.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNStart.Location = new System.Drawing.Point(12, 210);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(436, 38);
            this.BTNStart.TabIndex = 0;
            this.BTNStart.Text = "Stop";
            this.BTNStart.UseVisualStyleBackColor = true;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.Location = new System.Drawing.Point(12, 254);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 25);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // PBGithub
            // 
            this.PBGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBGithub.Image = ((System.Drawing.Image)(resources.GetObject("PBGithub.Image")));
            this.PBGithub.InitialImage = null;
            this.PBGithub.Location = new System.Drawing.Point(423, 254);
            this.PBGithub.Name = "PBGithub";
            this.PBGithub.Size = new System.Drawing.Size(25, 25);
            this.PBGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBGithub.TabIndex = 7;
            this.PBGithub.TabStop = false;
            this.PBGithub.Click += new System.EventHandler(this.PBGithub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 287);
            this.Controls.Add(this.PBGithub);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.BTNStart);
            this.Controls.Add(this.PICMain);
            this.Controls.Add(this.LBLOriginalMotto);
            this.Controls.Add(this.TXTNoMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Spotify Motto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PICMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTNoMusic;
        private System.Windows.Forms.Label LBLOriginalMotto;
        private System.Windows.Forms.PictureBox PICMain;
        private System.Windows.Forms.Button BTNStart;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox PBGithub;
    }
}
