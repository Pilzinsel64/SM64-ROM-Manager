using Pilz.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    static class Program
    {
        static Program()
        {
            Pilz.Cryptography.AESStringCrypter.DefaultKey = "iZbNfbTQgBVfg+UoRWBBaTeJa0wvLLtSoLljUHTOtAA=";
            Pilz.Cryptography.AESStringCrypter.DefaultIV = "5meO/fPEWftScQ9+3wKT8Q==";
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetDefaultControlFont();
            Application.Run(new UpdateManagerWindow());
        }

        private static void SetDefaultControlFont()
        {
            var settingsType = typeof(Control);
            var defaultFontField = settingsType.GetField("s_defaultFont", BindingFlags.Static | BindingFlags.NonPublic);
            defaultFontField.SetValue(null, new System.Drawing.Font(RuntimeInformationsEx.OSType == OSType.Windows ? "Microsoft Sans Serif" : "Segoe UI", 8.25F));
        }
    }
}
