using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xabbo.Messages;
using Xabbo.Interceptor;
using Xabbo.GEarth;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SpotifyMotto
{
    public class Extension : GEarthExtension
    {
        public Extension(GEarthOptions options) : base(options)
        { 
        }




        //Strings
        public String StandardPrefix = "Listening: ";




        //Settings
        public String Language = Properties.Settings.Default.Language;
        public bool RemoveParentheses = Properties.Settings.Default.RemoveParentheses;
        public bool RemoveBrackets =Properties.Settings.Default.RemoveBrackets;
        public bool SayChat = Properties.Settings.Default.SayChat;
        public bool UsePrefix = Properties.Settings.Default.UsePrefix;
        public String CustomPrefix = Properties.Settings.Default.CustomPrefix;


        //Cool badges to show 
        List<String> Badges = new List<string>()
        {
            "https://images.habbo.com/c_images/album1584/PLZ13.png",
            "https://images.habbo.com/c_images/album1584/ES518.png"
        };

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

        public void SendBadge(String MusicName)
        {

            //Choose random badge
            Random rnd = new Random();
            int r = rnd.Next(Badges.Count);

            Send(In.Notification, "", 3, "display", "BUBBLE", "message", MusicName, "image", Badges[r]);

        }


        public void SendChatText(String Text)
        {
            Send(Out.Shout, Text, 0);
        }


        public String DoRemoveParentheses(String Text)
        {
            Text = Regex.Replace(Text, @"\(.*\)", "");
            Text = Regex.Replace(Text, @"\s+", " ");

            return Text;
        }

        public String DoRemoveBrackets(String Text)
        {
            Text = Regex.Replace(Text, @"\[.*\]", "");
            Text = Regex.Replace(Text, @"\s+", " ");

            return Text;
        }



    }
}
