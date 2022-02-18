using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyMotto
{
    public partial class SettingsForm : Form
    {
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





    }
}
