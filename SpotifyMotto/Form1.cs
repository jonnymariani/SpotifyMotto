using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
            MessageBox.Show(SpotifyMotto.GetSpotifyTrack());
        }


        public async Task StartWork()
        {
            String OldMotto = "";

            while (true)
            {
                
                String Motto =  SpotifyMotto.GetSpotifyTrack();

                if (String.Equals(OldMotto, Motto) == false)
                {
                    SpotifyMotto.ChangeMotto(Motto);
                    OldMotto = Motto;
                }

                await Task.Delay(5000);

            }



        }

    }
}
