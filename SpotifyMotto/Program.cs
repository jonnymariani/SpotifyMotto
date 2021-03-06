using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabbo.GEarth;

namespace SpotifyMotto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create extension
            Extension extension = new Extension(
                GEarthOptions.Default
                    .WithName("SpotifyMotto")
                    .WithVersion("1.1.4") 
                    .WithDescription("Show everyone what you listening!")
                    .WithAuthor("sourcat")
                    .WithArguments(args)
            );

            // Create the main form, passing in the extension
            Form1 form = new Form1(extension);
            SettingsForm settingform = new SettingsForm(extension);

            // Create the extension handler
            GEarthFormHandler handler = new GEarthFormHandler(form, extension);

            // Run the extension
            _ = handler.RunAsync();

            Application.Run();
        }
    }
}
