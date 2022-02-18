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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        public readonly Extension SpotifyMotto;
        
        bool Working = true;
        String Client = "Flash";

        public Form1(Extension _extension)
        {
            SpotifyMotto = _extension;
            InitializeComponent();

            Client = SpotifyMotto.ClientIdentifier;     

        }

        public Extension GetExtension()
        {
            return SpotifyMotto;
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

                        if (Motto != SpotifyMotto.NoMusicMotto && Client.StartsWith("Flash"))
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

        //Start button style
        private void BTNStart_MouseEnter(object sender, EventArgs e)
        {
            BTNStart.Image = Properties.Resources.startbtn_hover;
            BTNStart.FlatStyle = FlatStyle.Flat;
            BTNStart.BackColor = Color.Transparent;
            BTNStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTNStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void BTNStart_MouseLeave(object sender, EventArgs e)
        {
            BTNStart.Image = Properties.Resources.startbtn;
            BTNStart.FlatStyle = FlatStyle.Flat;
            BTNStart.BackColor = Color.Transparent;
            BTNStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTNStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void BTNStart_MouseDown(object sender, MouseEventArgs e)
        {
            BTNStart.Image = Properties.Resources.startbtn_click;
            BTNStart.FlatStyle = FlatStyle.Flat;
            BTNStart.BackColor = Color.Transparent;
            BTNStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTNStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void BTNStart_MouseUp(object sender, MouseEventArgs e)
        {
            BTNStart.Image = Properties.Resources.startbtn;
            BTNStart.FlatStyle = FlatStyle.Flat;
            BTNStart.BackColor = Color.Transparent;
            BTNStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTNStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        //Settings button style
        private void btnSettings_MouseDown(object sender, MouseEventArgs e)
        {
            btnSettings.Image = Properties.Resources.settingsbtn_click;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnSettings_MouseUp(object sender, MouseEventArgs e)
        {
            btnSettings.Image = Properties.Resources.settingsbtn;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.Image = Properties.Resources.settingsbtn_hover;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.Image = Properties.Resources.settingsbtn;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void LBLGithub_Click(object sender, EventArgs e)
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
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
