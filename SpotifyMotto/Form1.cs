using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpotifyMotto
{
    public partial class Form1 : Form
    {
        public readonly Extension SpotifyMotto;

        
        bool Working = true;

        public Form1(Extension _extension)
        {
            SpotifyMotto = _extension;
            InitializeComponent();
        }

        public Extension GetExtension()
        {
            return SpotifyMotto;
        }
        public void ChangeStringLanguage(string str)
        {
            LBLOriginalMotto.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ = StartWork();
            TXTNoMusic.Text = Properties.Settings.Default.OriginalMotto;

        }

        String OldMotto = "";
        public async Task StartWork()
        {

            while (true)
            {
                if (Working)
                {
                    SpotifyMotto.NoMusicMotto = Properties.Settings.Default.OriginalMotto;
                    String Motto = SpotifyMotto.GetSpotifyTrack();

                    if (SpotifyMotto.RemoveParentheses)
                    {
                        Motto = SpotifyMotto.DoRemoveParentheses(Motto);
                    }

                    if (SpotifyMotto.RemoveBrackets)
                    {
                        Motto = SpotifyMotto.DoRemoveBrackets(Motto);
                    }

                    if (String.Equals(OldMotto, Motto) == false)
                    {

                        String Prefix = "";
                        if (SpotifyMotto.UsePrefix)
                        {
                            if (SpotifyMotto.CustomPrefix != "")
                            {
                                Prefix = SpotifyMotto.CustomPrefix + ": ";
                            }
                            else
                            {
                                Prefix = SpotifyMotto.StandardPrefix;
                            }
                        }                     

                        if (Motto != SpotifyMotto.NoMusicMotto)
                        {
                            SpotifyMotto.SendBadge("Playing:\n" + Motto);                            
                        }               

                        if (SpotifyMotto.SayChat && Motto != SpotifyMotto.NoMusicMotto)
                        {
                            SpotifyMotto.SendChatText(Prefix + Motto);                            
                        }

                        //Time to habbo process the sent chat packages
                        await Task.Delay(2000);


                        if (Motto != SpotifyMotto.NoMusicMotto)
                        {
                            SpotifyMotto.ChangeMotto(Prefix + Motto);
                        }
                        else
                        {
                            SpotifyMotto.ChangeMotto(Motto);
                        }

                        OldMotto = Motto;
                    }
                }

                await Task.Delay(2000);

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


        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SettingsForm>().Count() == 1)
            {
                _ = Application.OpenForms.OfType<SettingsForm>().FirstOrDefault().Focus();

            }
            else
            {
                var SettingsForm1 = new SettingsForm(SpotifyMotto);
                SettingsForm1.Show();
            }            
        }

        private void TXTNoMusic_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OriginalMotto = TXTNoMusic.Text;
            Properties.Settings.Default.Save();
        }

        private void PBGithub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/jonnymariani/SpotifyMotto";

            //Open URL 
            try
            {
                Process.Start(url);
            }
            catch
            {
                // Trick because of this: https://github.com/dotnet/corefx/issues/10361
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
