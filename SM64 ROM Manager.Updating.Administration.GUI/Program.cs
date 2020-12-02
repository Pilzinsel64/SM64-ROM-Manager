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
        [STAThread]
        static void Main(string[] args)
        {
            SetDefaultControlFont();
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
