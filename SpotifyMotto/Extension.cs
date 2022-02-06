using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xabbo.Messages;
using Xabbo.Interceptor;
using Xabbo.GEarth;
using System.Diagnostics;

namespace SpotifyMotto
{
    public class Extension : GEarthExtension
    {


        public Extension(GEarthOptions options)
            : base(options)
        { }


        public String NoMusicMotto = "";

        public string GetSpotifyTrack()
        {
            var proc = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));

            if (proc == null)
            {
                return NoMusicMotto; // spotify not running
            }

            if (proc.MainWindowTitle.StartsWith("Spotify") || proc.MainWindowTitle.StartsWith("Advertisement"))
            {
                return NoMusicMotto;
            }
            

            return proc.MainWindowTitle;
        }

        public void ChangeMotto(String motto)
        {
            Send(Out.ChangeAvatarMotto, motto);
        }



    }
}
