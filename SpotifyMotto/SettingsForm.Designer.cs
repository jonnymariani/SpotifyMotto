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
            this.CBAntiafk = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTCustomPrefix
            // 
            this.TXTCustomPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTCustomPrefix.Font = new System.Drawing.Font("Volter (Goldfish)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTCustomPrefix.Location = new System.Drawing.Point(51, 273);
            this.TXTCustomPrefix.Name = "TXTCustomPrefix";
            this.TXTCustomPrefix.PlaceholderText = "Custom Prefix";
            this.TXTCustomPrefix.Size = new System.Drawing.Size(138, 15);
            this.TXTCustomPrefix.TabIndex = 1;
            this.TXTCustomPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTCustomPrefix.TextChanged += new System.EventHandler(this.TXTCustomPrefix_TextChanged);
            // 
            // CBParentheses
            // 
            this.CBParentheses.AutoSize = true;
            this.CBParentheses.BackColor = System.Drawing.Color.Transparent;
            this.CBParentheses.Font = new System.Drawing.Font("Volter (Goldfish)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBParentheses.Location = new System.Drawing.Point(63, 141);
            this.CBParentheses.Name = "CBParentheses";
            this.CBParentheses.Size = new System.Drawing.Size(102, 19);
            this.CBParentheses.TabIndex = 3;
            this.CBParentheses.Text = "Remove ()";
            this.CBParentheses.UseVisualStyleBackColor = false;
            this.CBParentheses.CheckedChanged += new System.EventHandler(this.CBParentheses_CheckedChanged);
            // 
            // CBBrackets
            // 
            this.CBBrackets.AutoSize = true;
            this.CBBrackets.BackColor = System.Drawing.Color.Transparent;
            this.CBBrackets.Font = new System.Drawing.Font("Volter (Goldfish)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBBrackets.Location = new System.Drawing.Point(63, 166);
            this.CBBrackets.Name = "CBBrackets";
            this.CBBrackets.Size = new System.Drawing.Size(102, 19);
            this.CBBrackets.TabIndex = 4;
            this.CBBrackets.Text = "Remove []";
            this.CBBrackets.UseVisualStyleBackColor = false;
            this.CBBrackets.CheckedChanged += new System.EventHandler(this.CBBrackets_CheckedChanged);
            // 
            // CBSayChat
            // 
            this.CBSayChat.AutoSize = true;
            this.CBSayChat.BackColor = System.Drawing.Color.Transparent;
            this.CBSayChat.Font = new System.Drawing.Font("Volter (Goldfish)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBSayChat.Location = new System.Drawing.Point(63, 189);
            this.CBSayChat.Name = "CBSayChat";
            this.CBSayChat.Size = new System.Drawing.Size(114, 19);
            this.CBSayChat.TabIndex = 5;
            this.CBSayChat.Text = "Talk in chat";
            this.CBSayChat.UseVisualStyleBackColor = false;
            this.CBSayChat.CheckedChanged += new System.EventHandler(this.CBSayChat_CheckedChanged);
            // 
            // CBPrefix
            // 
            this.CBPrefix.AutoSize = true;
            this.CBPrefix.BackColor = System.Drawing.Color.Transparent;
            this.CBPrefix.Font = new System.Drawing.Font("Volter (Goldfish)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBPrefix.Location = new System.Drawing.Point(63, 238);
            this.CBPrefix.Name = "CBPrefix";
            this.CBPrefix.Size = new System.Drawing.Size(104, 19);
            this.CBPrefix.TabIndex = 6;
            this.CBPrefix.Text = "Use prefix";
            this.CBPrefix.UseVisualStyleBackColor = false;
            this.CBPrefix.CheckedChanged += new System.EventHandler(this.CBPrefix_CheckedChanged);
            // 
            // CBAntiafk
            // 
            this.CBAntiafk.AutoSize = true;
            this.CBAntiafk.BackColor = System.Drawing.Color.Transparent;
            this.CBAntiafk.Font = new System.Drawing.Font("Volter (Goldfish)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBAntiafk.Location = new System.Drawing.Point(63, 213);
            this.CBAntiafk.Name = "CBAntiafk";
            this.CBAntiafk.Size = new System.Drawing.Size(84, 19);
            this.CBAntiafk.TabIndex = 8;
            this.CBAntiafk.Text = "Anti-afk";
            this.CBAntiafk.UseVisualStyleBackColor = false;
            this.CBAntiafk.CheckedChanged += new System.EventHandler(this.CBAntiafk_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Volter-Bold (Goldfish)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Settings";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // BTNClose
            // 
            this.BTNClose.BackColor = System.Drawing.Color.Transparent;
            this.BTNClose.FlatAppearance.BorderSize = 0;
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNClose.Image = global::SpotifyMotto.Properties.Resources.closebtn;
            this.BTNClose.Location = new System.Drawing.Point(213, 5);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(20, 20);
            this.BTNClose.TabIndex = 11;
            this.BTNClose.UseVisualStyleBackColor = false;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            this.BTNClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTNClose_MouseDown);
            this.BTNClose.MouseEnter += new System.EventHandler(this.BTNClose_MouseEnter);
            this.BTNClose.MouseLeave += new System.EventHandler(this.BTNClose_MouseLeave);
            this.BTNClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTNClose_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SpotifyMotto.Properties.Resources.txtbg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(43, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 26);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpotifyMotto.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 323);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBAntiafk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CBParentheses);
            this.Controls.Add(this.CBBrackets);
            this.Controls.Add(this.CBPrefix);
            this.Controls.Add(this.CBSayChat);
            this.Controls.Add(this.TXTCustomPrefix);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(24)))));
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTCustomPrefix;
        private System.Windows.Forms.CheckBox CBParentheses;
        private System.Windows.Forms.CheckBox CBBrackets;
        private System.Windows.Forms.CheckBox CBSayChat;
        private System.Windows.Forms.CheckBox CBPrefix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CBAntiafk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}