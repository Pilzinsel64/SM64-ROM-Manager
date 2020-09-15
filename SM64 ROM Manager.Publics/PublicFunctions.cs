using System;
using System.Collections.Generic;
using global::System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using global::System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Metro.ColorTables;
using Microsoft.VisualBasic.CompilerServices;
using global::Microsoft.Win32;
using global::Pilz.Reflection.PluginSystem;
using global::Pilz.S3DFileParser;
using global::RegistryUtils;
using global::SM64_ROM_Manager.SettingsManager;
using System.Drawing;
using System.Diagnostics;
using SM64Lib;
using System.IO;

namespace SM64_ROM_Manager.Publics
{
    public static class Publics
    {
        static Publics()
        {
            regKeyMonitor_WatchWindowsTheme = null;
        }

        private static List<File3DLoaderModule> allLoaderModules = null;
        private static List<File3DLoaderModule> allExporterModules = null;
        private static RegistryMonitor _regKeyMonitor_WatchWindowsTheme;

        private static RegistryMonitor regKeyMonitor_WatchWindowsTheme
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _regKeyMonitor_WatchWindowsTheme;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_regKeyMonitor_WatchWindowsTheme != null)
                {
                    _regKeyMonitor_WatchWindowsTheme.RegChanged -= (_, __) => RegKeyMonitor_WatchWindowsTheme_RegChanged();
                }

                _regKeyMonitor_WatchWindowsTheme = value;
                if (_regKeyMonitor_WatchWindowsTheme != null)
                {
                    _regKeyMonitor_WatchWindowsTheme.RegChanged += (_, __) => RegKeyMonitor_WatchWindowsTheme_RegChanged();
                }
            }
        }

        public static void SetVisualTheme()
        {
            MetroColorGeneratorParameters? setTheme = default;
            if (Settings.StyleManager.UseSystemTheme)
            {
                var curVers = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", false);
                if (Conversions.ToString(curVers.GetValue("ProductName", "-")).StartsWith("Windows 10"))
                {
                    var keyPersonalize = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", false);
                    int useapptheme = Conversions.ToInteger(keyPersonalize.GetValue("AppsUseLightTheme", 1));
                    switch (useapptheme)
                    {
                        case 0:
                            setTheme = StyleManagerSettingsStruc.VisualThemeDark;
                            break;
                        case 1:
                            setTheme = StyleManagerSettingsStruc.VisualThemeLight;
                            break;
                    }

                    if (regKeyMonitor_WatchWindowsTheme is null)
                    {
                        regKeyMonitor_WatchWindowsTheme = new RegistryMonitor(keyPersonalize);
                        regKeyMonitor_WatchWindowsTheme.Start();
                    }
                }
            }
            else if (regKeyMonitor_WatchWindowsTheme is object)
            {
                regKeyMonitor_WatchWindowsTheme.Stop();
                regKeyMonitor_WatchWindowsTheme = null;
            }

            if (setTheme is null)
                setTheme = Settings.StyleManager.MetroColorParams;
            
            // Set style
            if (StyleManagerSettingsStruc.IsWhiteTheme(setTheme.Value))
                StyleManager.Style = eStyle.Office2016;
            else
                StyleManager.Style = eStyle.VisualStudio2012Light;
            
            // Set metro color generator parameters
            StyleManager.MetroColorGeneratorParameters = (MetroColorGeneratorParameters)setTheme;

            foreach (Form frm in Application.OpenForms)
                frm.UpdateAmbientColors();
        }

        private static void RegKeyMonitor_WatchWindowsTheme_RegChanged()
        {
            SetVisualTheme();
        }

        public static void ExportModel(Object3D model, string modul)
        {
            ExportModel(model, GetExporterModuleFromID(modul));
        }

        public static void ExportModel(Object3D model, File3DLoaderModule modul)
        {
            var sfd = new SaveFileDialog();
            string strFilter = General.GetExtensionFilter(modul);
            sfd.Filter = strFilter.Substring(strFilter.IndexOf("|", strFilter.IndexOf("|") + 1) + 1);

            // If modul <> LoaderModule.SimpleFileParser Then
            // MessageBoxEx.Show("Assimp and Aspose probably crashes at exporting.<br/>Please switch to SimpleFileParser in <b>Settings --> File Parser</b>.<br/>Assimp and Aspose will be working soon.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            // End If

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Await model.ToFileAsync(sfd.FileName, modul)
                modul.Invoke(model, sfd.FileName);
            }
        }

        private static File3DLoaderModule GetFileLoaderModuleFromP(PluginFunction p)
        {
            var dic = new Dictionary<string, string>();
            p.Invoke(dic);
            var convMethod = p.Plugin.GetFunctions("loadermoduleload").FirstOrDefault(n => Operators.ConditionalCompareObjectEqual(n.Params[0], p.Params[0], false));
            return new File3DLoaderModule(Conversions.ToString(p.Params[0]), (File3DLoaderModule.LoaderAction)Delegate.CreateDelegate(typeof(File3DLoaderModule.LoaderAction), convMethod.Method), dic);
        }

        private static File3DLoaderModule GetFileExporterModuleFromP(PluginFunction p)
        {
            var dic = new Dictionary<string, string>();
            p.Invoke(dic);
            var convMethod = p.Plugin.GetFunctions("loadermoduleexport").FirstOrDefault(n => Operators.ConditionalCompareObjectEqual(n.Params[0], p.Params[0], false));
            return new File3DLoaderModule(Conversions.ToString(p.Params[0]), (File3DLoaderModule.ExporterAction)Delegate.CreateDelegate(typeof(File3DLoaderModule.ExporterAction), convMethod.Method), dic);
        }

        public static IEnumerable<File3DLoaderModule> GetAllLoaderModules()
        {
            if (allLoaderModules is null)
            {
                allLoaderModules = new List<File3DLoaderModule>();
                allLoaderModules.AddRange(File3DLoaderModule.LoaderModules);
                foreach (var p in General.PluginManager.GetFunctions("loadermoduleimpformats"))
                    allLoaderModules.Add(GetFileLoaderModuleFromP(p));
            }

            return allLoaderModules;
        }

        public static IEnumerable<File3DLoaderModule> GetAllExporterModules()
        {
            if (allExporterModules is null)
            {
                allExporterModules = new List<File3DLoaderModule>();
                allExporterModules.AddRange(File3DLoaderModule.ExporterModules);
                foreach (var p in General.PluginManager.GetFunctions("loadermoduleexpformats"))
                    allExporterModules.Add(GetFileExporterModuleFromP(p));
            }

            return allExporterModules;
        }

        public static File3DLoaderModule GetLoaderModuleFromID(string moduleID)
        {
            var modules = GetAllLoaderModules();
            return GetFileLoaderModuleFromIDInternal(moduleID, modules, 1);
        }

        public static File3DLoaderModule GetExporterModuleFromID(string moduleID)
        {
            var modules = GetAllExporterModules();
            return GetFileLoaderModuleFromIDInternal(moduleID, modules, 0);
        }

        private static File3DLoaderModule GetFileLoaderModuleFromIDInternal(string moduleID, IEnumerable<File3DLoaderModule> modules, int defaultModule)
        {
            if (moduleID.StartsWith("#"))
            {
                return modules.ElementAtOrDefault(Conversions.ToInteger(moduleID.Substring(1)));
            }
            else
            {
                foreach (var m in modules)
                {
                    if ((m.Name ?? "") == (moduleID ?? ""))
                    {
                        return m;
                    }
                }
            }

            return modules.ElementAtOrDefault(defaultModule);
        }

        public static string GetLoaderIDFromModule(File3DLoaderModule loaderModule)
        {
            var known = File3DLoaderModule.LoaderModules;
            return GetFileLoaderIDFromModule(loaderModule, known);
        }

        public static string GetExporterIDFromModule(File3DLoaderModule loaderModule)
        {
            var known = File3DLoaderModule.ExporterModules;
            return GetFileLoaderIDFromModule(loaderModule, known);
        }

        private static string GetFileLoaderIDFromModule(File3DLoaderModule loaderModule, File3DLoaderModule[] known)
        {
            for (int i = 0, loopTo = known.Count() - 1; i <= loopTo; i++)
            {
                if (known[i] == loaderModule)
                {
                    return "#" + Conversions.ToString(i);
                }
            }

            return loaderModule.Name;
        }

        public static void AddRecentFile(StringCollection collection, string fileName)
        {
            if (collection.Contains(fileName))
            {
                collection.Remove(fileName);
            }

            collection.Insert(0, fileName);
        }

        public static void MergeRecentFiles(StringCollection collection)
        {
            var toRemove = new List<string>();
            foreach (string f in collection)
            {
                if (!System.IO.File.Exists(f))
                {
                    toRemove.Add(f);
                }
            }

            foreach (string f in toRemove)
                collection.Remove(f);
        }

        public static void OpenBrowser(Uri uri, bool maximized = false, Size? windowSize = null)
        {
            if (Settings.General.UseInternalBrowser)
            {
                var frm = new WebViewer(uri);

                if (maximized)
                    frm.WindowState = FormWindowState.Maximized;

                if (windowSize != null)
                    frm.ClientSize = (Size)windowSize;

                frm.Show();
            }
            else
                Process.Start(uri.AbsoluteUri);
        }

        public static void LoadLegacyObjectBankData(RomManager romManager)
        {
            if (!romManager.RomConfig.ObjectBankInfoData.Any())
            {
                var p = Path.Combine(General.MyDataPath, @"Other\Object Bank Data.json");
                romManager?.RomConfig.ObjectBankInfoData.Load(p);
            }
        }
    }
}