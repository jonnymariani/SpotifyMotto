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
            
        }
    }
}
