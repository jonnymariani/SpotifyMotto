namespace SpotifyMotto
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.TXTCustomPrefix = new System.Windows.Forms.TextBox();
            this.CBParentheses = new System.Windows.Forms.CheckBox();
            this.CBBrackets = new System.Windows.Forms.CheckBox();
            this.CBSayChat = new System.Windows.Forms.CheckBox();
            this.CBPrefix = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBAntiafk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTCustomPrefix
            // 
            this.TXTCustomPrefix.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTCustomPrefix.Location = new System.Drawing.Point(31, 231);
            this.TXTCustomPrefix.Name = "TXTCustomPrefix";
            this.TXTCustomPrefix.PlaceholderText = "Custom Prefix";
            this.TXTCustomPrefix.Size = new System.Drawing.Size(138, 26);
            this.TXTCustomPrefix.TabIndex = 1;
            this.TXTCustomPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTCustomPrefix.TextChanged += new System.EventHandler(this.TXTCustomPrefix_TextChanged);
            // 
            // CBParentheses
            // 
            this.CBParentheses.AutoSize = true;
            this.CBParentheses.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBParentheses.Location = new System.Drawing.Point(51, 108);
            this.CBParentheses.Name = "CBParentheses";
            this.CBParentheses.Size = new System.Drawing.Size(98, 20);
            this.CBParentheses.TabIndex = 3;
            this.CBParentheses.Text = "Remove ()";
            this.CBParentheses.UseVisualStyleBackColor = true;
            this.CBParentheses.CheckedChanged += new System.EventHandler(this.CBParentheses_CheckedChanged);
            // 
            // CBBrackets
            // 
            this.CBBrackets.AutoSize = true;
            this.CBBrackets.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBBrackets.Location = new System.Drawing.Point(51, 133);
            this.CBBrackets.Name = "CBBrackets";
            this.CBBrackets.Size = new System.Drawing.Size(98, 20);
            this.CBBrackets.TabIndex = 4;
            this.CBBrackets.Text = "Remove []";
            this.CBBrackets.UseVisualStyleBackColor = true;
            this.CBBrackets.CheckedChanged += new System.EventHandler(this.CBBrackets_CheckedChanged);
            // 
            // CBSayChat
            // 
            this.CBSayChat.AutoSize = true;
            this.CBSayChat.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBSayChat.Location = new System.Drawing.Point(39, 156);
            this.CBSayChat.Name = "CBSayChat";
            this.CBSayChat.Size = new System.Drawing.Size(122, 20);
            this.CBSayChat.TabIndex = 5;
            this.CBSayChat.Text = "Talk in chat";
            this.CBSayChat.UseVisualStyleBackColor = true;
            this.CBSayChat.CheckedChanged += new System.EventHandler(this.CBSayChat_CheckedChanged);
            // 
            // CBPrefix
            // 
            this.CBPrefix.AutoSize = true;
            this.CBPrefix.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBPrefix.Location = new System.Drawing.Point(43, 205);
            this.CBPrefix.Name = "CBPrefix";
            this.CBPrefix.Size = new System.Drawing.Size(106, 20);
            this.CBPrefix.TabIndex = 6;
            this.CBPrefix.Text = "Use prefix";
            this.CBPrefix.UseVisualStyleBackColor = true;
            this.CBPrefix.CheckedChanged += new System.EventHandler(this.CBPrefix_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBAntiafk);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.CBParentheses);
            this.groupBox1.Controls.Add(this.CBPrefix);
            this.groupBox1.Controls.Add(this.TXTCustomPrefix);
            this.groupBox1.Controls.Add(this.CBSayChat);
            this.groupBox1.Controls.Add(this.CBBrackets);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 287);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CBAntiafk
            // 
            this.CBAntiafk.AutoSize = true;
            this.CBAntiafk.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBAntiafk.Location = new System.Drawing.Point(55, 180);
            this.CBAntiafk.Name = "CBAntiafk";
            this.CBAntiafk.Size = new System.Drawing.Size(90, 20);
            this.CBAntiafk.TabIndex = 8;
            this.CBAntiafk.Text = "Anti-afk";
            this.CBAntiafk.UseVisualStyleBackColor = true;
            this.CBAntiafk.CheckedChanged += new System.EventHandler(this.CBAntiafk_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 323);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXTCustomPrefix;
        private System.Windows.Forms.CheckBox CBParentheses;
        private System.Windows.Forms.CheckBox CBBrackets;
        private System.Windows.Forms.CheckBox CBSayChat;
        private System.Windows.Forms.CheckBox CBPrefix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CBAntiafk;
    }
}