using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyMotto
{
    public partial class SettingsForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Extension SpotifyMotto;
        Form1 frm;

        public SettingsForm(Extension _extension)
        {
            SpotifyMotto = _extension;
            InitializeComponent();
        }

         
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            CBParentheses.Checked = Properties.Settings.Default.RemoveParentheses;
            CBBrackets.Checked = Properties.Settings.Default.RemoveBrackets;
            CBSayChat.Checked = Properties.Settings.Default.SayChat;
            CBPrefix.Checked = Properties.Settings.Default.UsePrefix;
            TXTCustomPrefix.Text = Properties.Settings.Default.CustomPrefix;
        }


        private void CBParentheses_CheckedChanged(object sender, EventArgs e)
        {
            SpotifyMotto.RemoveParentheses = CBParentheses.Checked;
            Properties.Settings.Default.RemoveParentheses = CBParentheses.Checked;
            Properties.Settings.Default.Save();
        }

        private void CBBrackets_CheckedChanged(object sender, EventArgs e)
        {
            SpotifyMotto.RemoveBrackets = CBBrackets.Checked;
            Properties.Settings.Default.RemoveBrackets = CBBrackets.Checked;
            Properties.Settings.Default.Save();
        }

        private void CBSayChat_CheckedChanged(object sender, EventArgs e)
        {
            SpotifyMotto.SayChat = CBSayChat.Checked;
            Properties.Settings.Default.SayChat = CBSayChat.Checked;
            Properties.Settings.Default.Save();

        }

        private void CBPrefix_CheckedChanged(object sender, EventArgs e)
        {
            SpotifyMotto.UsePrefix = CBPrefix.Checked;
            Properties.Settings.Default.UsePrefix = CBPrefix.Checked;
            Properties.Settings.Default.Save();
        }

        private void TXTCustomPrefix_TextChanged(object sender, EventArgs e)
        {
            SpotifyMotto.CustomPrefix = TXTCustomPrefix.Text;
            Properties.Settings.Default.CustomPrefix = TXTCustomPrefix.Text;
            Properties.Settings.Default.Save();
        }




        CancellationTokenSource Token = new CancellationTokenSource();
        private void CBAntiafk_CheckedChanged(object sender, EventArgs e)
        {
            if (CBAntiafk.Checked)
            {
                Token = new CancellationTokenSource();
                _ = StartAntiafk(); 
            }
            else
            {
                Token.Cancel();
            }
        }

        public async Task StartAntiafk()
        {

            while (true)
            {
                if (Token.IsCancellationRequested)
                {
                    return;
                }

                SpotifyMotto.AntiAfk();
                await Task.Delay(1000 * 120);
            }

        }


        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Close button style
        private void BTNClose_MouseDown(object sender, MouseEventArgs e)
        {
            BTNClose.Image = Properties.Resources.closebtn_click;
            BTNClose.FlatStyle = FlatStyle.Flat;
            BTNClose.BackColor = Color.Transparent;
            BTNClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTNClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void BTNClose_MouseUp(object sender, MouseEventArgs e)
        {
            BTNClose.Image = Properties.Resources.closebtn;
            BTNClose.FlatStyle = FlatStyle.Flat;
            BTNClose.BackColor = Color.Transparent;
            BTNClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTNClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void BTNClose_MouseEnter(object sender, EventArgs e)
        {
            BTNClose.Image = Properties.Resources.closebtn_hover;
            BTNClose.FlatStyle = FlatStyle.Flat;
            BTNClose.BackColor = Color.Transparent;
            BTNClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTNClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void BTNClose_MouseLeave(object sender, EventArgs e)
        {
            BTNClose.Image = Properties.Resources.closebtn;
            BTNClose.FlatStyle = FlatStyle.Flat;
            BTNClose.BackColor = Color.Transparent;
            BTNClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTNClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
