using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpotifyMotto
{
    public partial class Form1 : Form
    {
        private readonly Extension SpotifyMotto;
        bool Working = true;

        public Form1(Extension _extension)
        {
            SpotifyMotto = _extension;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ = StartWork();

            SpotifyMotto.NoMusicMotto = Properties.Settings.Default.OriginalMotto;
            TXTNoMusic.Text = Properties.Settings.Default.OriginalMotto;

        }

        String OldMotto = "";
        public async Task StartWork()
        {

            while (true)
            {
                if (Working)
                {
                    String Motto = SpotifyMotto.GetSpotifyTrack();

                    if (String.Equals(OldMotto, Motto) == false)
                    {
                        SpotifyMotto.SendBadge("Playing:\n" + Motto);


                        SpotifyMotto.ChangeMotto(Motto);
                        OldMotto = Motto;
                    }
                }

                await Task.Delay(5000);

            }
        }

        private void LINKGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/jonnymariani/SpotifyMotto";

            //Open URL 
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void BTNStart_Click(object sender, EventArgs e)
        {

            if (BTNStart.Text == "Stop")
            {
                // Start
                BTNStart.Text = "Start";
                PICMain.Enabled = false;
                Working = false;
                SpotifyMotto.ChangeMotto(Properties.Settings.Default.OriginalMotto);

            }
            else
            {
                //Stop
                BTNStart.Text = "Stop";
                PICMain.Enabled = true;
                Working = true;
                SpotifyMotto.ChangeMotto(OldMotto);
            }


        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OriginalMotto = TXTNoMusic.Text;
            Properties.Settings.Default.Save();
        }
    }
}
