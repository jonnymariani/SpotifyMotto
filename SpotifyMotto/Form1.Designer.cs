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
            this.label1 = new System.Windows.Forms.Label();
            this.LINKGithub = new System.Windows.Forms.LinkLabel();
            this.PICMain = new System.Windows.Forms.PictureBox();
            this.BTNSave = new System.Windows.Forms.Button();
            this.BTNStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PICMain)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTNoMusic
            // 
            this.TXTNoMusic.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTNoMusic.Location = new System.Drawing.Point(17, 197);
            this.TXTNoMusic.MaxLength = 38;
            this.TXTNoMusic.Name = "TXTNoMusic";
            this.TXTNoMusic.PlaceholderText = "Your motto here :)";
            this.TXTNoMusic.Size = new System.Drawing.Size(387, 26);
            this.TXTNoMusic.TabIndex = 1;
            this.TXTNoMusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 11);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original Motto:";
            // 
            // LINKGithub
            // 
            this.LINKGithub.AutoSize = true;
            this.LINKGithub.Location = new System.Drawing.Point(17, 280);
            this.LINKGithub.Name = "LINKGithub";
            this.LINKGithub.Size = new System.Drawing.Size(42, 15);
            this.LINKGithub.TabIndex = 3;
            this.LINKGithub.TabStop = true;
            this.LINKGithub.Text = "github";
            this.LINKGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINKGithub_LinkClicked);
            // 
            // PICMain
            // 
            this.PICMain.Image = ((System.Drawing.Image)(resources.GetObject("PICMain.Image")));
            this.PICMain.InitialImage = null;
            this.PICMain.Location = new System.Drawing.Point(162, 19);
            this.PICMain.Name = "PICMain";
            this.PICMain.Size = new System.Drawing.Size(146, 146);
            this.PICMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PICMain.TabIndex = 5;
            this.PICMain.TabStop = false;
            // 
            // BTNSave
            // 
            this.BTNSave.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNSave.Location = new System.Drawing.Point(410, 197);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(44, 26);
            this.BTNSave.TabIndex = 2;
            this.BTNSave.Text = "Save";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // BTNStart
            // 
            this.BTNStart.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNStart.Location = new System.Drawing.Point(17, 229);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(436, 38);
            this.BTNStart.TabIndex = 0;
            this.BTNStart.Text = "Stop";
            this.BTNStart.UseVisualStyleBackColor = true;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 304);
            this.Controls.Add(this.BTNStart);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.PICMain);
            this.Controls.Add(this.LINKGithub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTNoMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Spotify Motto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PICMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTNoMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LINKGithub;
        private System.Windows.Forms.PictureBox PICMain;
        private System.Windows.Forms.Button BTNSave;
        private System.Windows.Forms.Button BTNStart;
    }
}
