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

        public Form1(Extension _extension)
        {
            SpotifyMotto = _extension;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ = StartWork();

            SpotifyMotto.NoMusicMotto = TXTNoMusic.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


        public async Task StartWork()
        {
            String OldMotto = "";

            while (true)
            {
                
                String Motto =  SpotifyMotto.GetSpotifyTrack();

                if (String.Equals(OldMotto, Motto) == false)
                {
                    SpotifyMotto.SendBadge("Playing:\n" + Motto);


                    SpotifyMotto.ChangeMotto(Motto);
                    OldMotto = Motto;
                }

                await Task.Delay(5000);

            }



        }

        private void LINKGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/jonnymariani/SpotifyMotto";

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://discord.com/users/SACR3D#2599";

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
    }
}
