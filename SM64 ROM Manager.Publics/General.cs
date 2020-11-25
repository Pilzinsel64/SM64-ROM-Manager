using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using global::System.Globalization;
using global::System.IO;
using System.Linq;
using global::System.Net;
using global::System.Reflection;
using System.Runtime.InteropServices;
using global::System.Text.RegularExpressions;
using global::System.Threading;
using global::System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::OfficeOpenXml;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib.Levels;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using Pilz.Runtime;

namespace SM64_ROM_Manager.Publics
{
    public static class General
    {
        private readonly static drsPwEnc.drsPwEnc crypter = new drsPwEnc.drsPwEnc();

        public static Pilz.Reflection.PluginSystem.PluginManager PluginManager { get; private set; } = new Pilz.Reflection.PluginSystem.PluginManager();

        //[DllImport("user32.dll", EntryPoint = "SetProcessDPIAware")]
        //public static extern void SetDPIAware();

        private static string pMyDataPath = string.Empty;
        private static string pMyToolsPath = string.Empty;
        private static string pMyTweaksPath = string.Empty;
        private static string pMyCustomObjectsPath = string.Empty;
        private static string pMyPluginsPath = string.Empty;
        private static string pMyUserRequestsPath = string.Empty;
        private static string pMyImporterPresetsPath = string.Empty;

        private static ExcelPackage _SurfaceData;
        private static ExcelPackage _OtherData;

        static General()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public static string MyDataPath
        {
            get
            {
                if (string.IsNullOrEmpty(pMyDataPath))
                {
                    pMyDataPath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Data");
                }

                return pMyDataPath;
            }
        }

        public static string MyToolsPath
        {
            get
            {
                if (string.IsNullOrEmpty(pMyToolsPath))
                {
                    pMyToolsPath = Path.Combine(MyDataPath, "Tools");
                }

                return pMyToolsPath;
            }
        }

        public static string MyTweaksPath
        {
            get
            {
                if (string.IsNullOrEmpty(pMyTweaksPath))
                {
                    pMyTweaksPath = Path.Combine(MyDataPath, "Tweaks");
                }

                return pMyTweaksPath;
            }
        }

        public static string MyCustomObjectsPath
        {
            get
            {
                if (string.IsNullOrEmpty(pMyCustomObjectsPath))
                {
                    pMyCustomObjectsPath = Path.Combine(MyDataPath, "Custom Objects");
                }

                return pMyCustomObjectsPath;
            }
        }

        public static string MyPluginsPath
        {
            get
            {
                if (string.IsNullOrEmpty(pMyPluginsPath))
                {
                    pMyPluginsPath = Path.Combine(MyDataPath, "Plugins");
                }

                return pMyPluginsPath;
            }
        }

        public static string MyUserRequestsPath
        {
            get
            {
                if (string.IsNullOrEmpty(pMyUserRequestsPath))
                {
                    pMyUserRequestsPath = Path.Combine(MyDataPath, "UserRequests");
                }

                return pMyUserRequestsPath;
            }
        }

        public static string MyImporterPresetsPath
        {
            get
            {
                if (string.IsNullOrEmpty(pMyImporterPresetsPath))
                {
                    pMyImporterPresetsPath = Path.Combine(MyDataPath, "Importer Presets");
                }

                return pMyImporterPresetsPath;
            }
        }

        public static bool IsDebugging
        {
            get
            {
                return Debugger.IsAttached;
            }
        }

        public static bool IsDesigneTime
        {
            get
            {
                return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
            }
        }

        public static ExcelWorkbook SurfaceData
        {
            get
            {
                if(_SurfaceData == null)
                {
                    _SurfaceData = new ExcelPackage(new FileInfo(MyDataPath + @"\Other\Surface Data.xlsx"));
                }
                return _SurfaceData.Workbook;
            }
        }

        public static ExcelWorkbook OtherData
        {
            get
            {
                if (_OtherData == null)
                {
                    _OtherData = new ExcelPackage(new FileInfo(MyDataPath + @"\Other\Other Data.xlsx"));
                }
                return _OtherData.Workbook;
            }
        }

        public static void SetSM64LibFilePathConfigs()
        {
            var config = SM64Lib.FilePathsConfiguration.DefaultConfiguration;
            config.SetFilePath("rn64crc.exe", Path.Combine(MyDataPath, @"Tools\rn64crc.exe"));
            config.SetFilePath("ApplyPPF3.exe", Path.Combine(MyDataPath, @"Tools\ApplyPPF3.exe"));
            config.SetFilePath("Level Tabel.json", Path.Combine(MyDataPath, @"Other\Level Tabel.json"));
            config.SetFilePath("Update-Patches.json", Path.Combine(MyDataPath, @"Patchs\Update-Patches\Update-Patches.json"));
            config.SetFilePath("Update Patches Folder", Path.Combine(MyDataPath, @"Patchs\Update-Patches"));
            config.SetFilePath("Text Profiles.json", Path.Combine(MyDataPath, @"Text Manager\Profiles.json"));
            config.SetFilePath("BaseTweak", Path.Combine(MyDataPath, @"Patchs\Base Tweak.json"));
            config.SetFilePath("sm64extend.exe", Path.Combine(MyDataPath, @"Tools\sm64extend.exe"));
            config.SetFilePath("Original Level Pointers.bin", Path.Combine(MyDataPath, @"Other\Original Level Pointers.bin"));
            config.SetFilePath("armips.exe", Path.Combine(MyToolsPath, @"armips.exe"));
            config.SetFilePath("Flips.exe", Path.Combine(MyToolsPath, @"Flips.exe"));
        }

        private static void SetServerCertificateValidationCallback()
        {
            ServicePointManager.ServerCertificateValidationCallback = MyRemoteCertificateValidationCallback;
        }

        private static bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            bool isOk = true;
            // If there are errors in the certificate chain, look at each error to determine the cause.
            if (sslPolicyErrors != SslPolicyErrors.None)
            {
                for (int i = 0; i < chain.ChainStatus.Length; i++)
                {
                    if (chain.ChainStatus[i].Status != X509ChainStatusFlags.RevocationStatusUnknown)
                    {
                        chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
                        chain.ChainPolicy.RevocationMode = X509RevocationMode.Online;
                        chain.ChainPolicy.UrlRetrievalTimeout = new TimeSpan(0, 1, 0);
                        chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags;
                        bool chainIsValid = chain.Build((X509Certificate2)certificate);
                        if (!chainIsValid) isOk = false;
                    }
                }
            }
            return isOk;
        }

        public static void SetDefaultProxyAuthentification()
        {
            if (!string.IsNullOrEmpty(Settings.Network.ProxyUsername) || !string.IsNullOrEmpty(Settings.Network.ProxyPasswordEncrypted))
            {
                WebRequest.DefaultWebProxy.Credentials = new NetworkCredential(Settings.Network.ProxyUsername, string.IsNullOrEmpty(Settings.Network.ProxyPasswordEncrypted) ? string.Empty : crypter.DecryptData(Settings.Network.ProxyPasswordEncrypted));
            }
            else
            {
                WebRequest.DefaultWebProxy.Credentials = null;
            }
        }

        private static void SetDefaultControlFont()
        {
            var settingsType = typeof(Control);
            var defaultFontField = settingsType.GetField("s_defaultFont", BindingFlags.Static | BindingFlags.NonPublic);
            defaultFontField.SetValue(null, new System.Drawing.Font("Microsoft Sans Serif", 8.25F)); //"Segoe UI", 8.25F
        }

        public static void DoDefaultInitsBeforeApplicationStartup()
        {
            // Set default font
            SetDefaultControlFont();

            // Set high Dpi Mode to completly ignore DPI changes and use 100%
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
        }

        public static void DoDefaultInitsAfterApplicationStartup()
        {
            if (RuntimeInformationsEx.OSType != OSType.Windows)
                SetServerCertificateValidationCallback();

            Settings.SettingsConfigFilePath = Path.Combine(MyDataPath, "Settings.json");

            // Set scale per control
            Dpi.RecordScalePerControl = true;

            // Set proxy settings
            SetDefaultProxyAuthentification();

            // Set Style
            Publics.SetVisualTheme();

            // Set language
            SetCurrentLanguageCulture(Settings.General.Language);

            // Set File Path Config
            SetSM64LibFilePathConfigs();

            // Watch Events for PatchScriptManager
            SM64Lib.Patching.PatchingManager.ProcessingInputValue += PatchingManager_ProcessingInputValue;

            // Set paths to Assimp-Libs
            Pilz.S3DFileParser.AssimpModule.AssimpLoader.PathToAssimpLib32 = Path.Combine(MyDataPath, @"Lib\Assimp32.dll");
            Pilz.S3DFileParser.AssimpModule.AssimpLoader.PathToAssimpLib64 = Path.Combine(MyDataPath, @"Lib\Assimp64.dll");

            // Do waiting auto jobs
            JobToDoManager.ExecuteStartupJobsToDo();
            Settings.MySettingsManager.AutoSavingSettings += (_, __) => JobToDoManager.ExecuteExitJobsToDo();
        }

        private static void PatchingManager_ProcessingInputValue(object sender, SM64Lib.Patching.PatchScriptManagerProcessingInputValueEventArgs e)
        {
            var input = new InputDialog(e.ValueType, e.RomManager);
            if (input.ShowDialog(e.Owner) == DialogResult.OK)
            {
                e.ReturnValue = input.ReturnValue;
                e.SettedValue = true;
            }
        }

        public static void SetCurrentLanguageCulture(string cultureName)
        {
            CultureInfo culture;
            if (string.IsNullOrEmpty(cultureName))
            {
                culture = Thread.CurrentThread.CurrentCulture;
                if ((culture.Name ?? "") == (Thread.CurrentThread.CurrentCulture.Name ?? ""))
                {
                    culture = null;
                }
            }
            else
            {
                culture = new CultureInfo(cultureName);
            }

            if (culture is object)
            {
                // Change on current Thread
                // Thread.CurrentThread.CurrentCulture = culture
                Thread.CurrentThread.CurrentUICulture = culture;

                // Change for all new threads
                // CultureInfo.DefaultThreadCurrentCulture = culture
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }
        }

        /// <param name="strmodul"></param>
        /// <param name="mode">0 = Loader; 1 = Exporter</param>
        public static string GetExtensionFilter(string strmodul, byte mode)
        {
            var modul = mode == 0 ? Publics.GetLoaderModuleFromID(strmodul) : Publics.GetExporterModuleFromID(strmodul);
            return GetExtensionFilter(modul);
        }

        public static string GetExtensionFilter(File3DLoaderModule modul)
        {
            string combiFormats = string.Empty;
            string splittedFormats = string.Empty;

            foreach (var kvp in modul.SupportedFormats)
            {
                if (modul.Name != "Assimp" || kvp.Key != "blend")
                {
                    if (!string.IsNullOrEmpty(combiFormats))
                        combiFormats += ";";

                    combiFormats += "*." + kvp.Key;
                    if (!string.IsNullOrEmpty(splittedFormats))
                        splittedFormats += "|";

                    splittedFormats += $"{kvp.Value} (*.{kvp.Key})|*.{kvp.Key}";
                }
            }

            return $"All supported files|{combiFormats}|{splittedFormats}";
        }

        public static short KeepDegreesWithin360(short value)
        {
            if (value < 0)
            {
                return Conversions.ToShort(360 + value % -360);
            }
            else
            {
                return Conversions.ToShort(value % 360);
            }
        }

        public static void DisableAmbientColor(Control c, Type[] types, eAmbientSettings state)
        {
            var abm = new StyleManagerAmbient();
            if (types.Contains(c.GetType()))
            {
                abm.SetEnableAmbientSettings(c, state);
            }

            foreach (Control cc in c.Controls)
                DisableAmbientColor(cc, types, eAmbientSettings.BackColor);
        }

        public static bool CompareTwoByteArrays(byte[] arr1, byte[] arr2)
        {
            if (arr2.Count() != arr1.Count())
                return false;
            for (int i = 0, loopTo = arr1.Count() - 1; i <= loopTo; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        public static void ShowToastnotification(Control Parent, string Text, eToastGlowColor Color, int Timeout = 5000)
        {
            // ToastNotification.ToastBackColor = Drawing.Color.LightGray
            // ToastNotification.ToastForeColor = Drawing.Color.Black
            ToastNotification.Show(Parent, Text, null, Timeout, Color);
        }

        public static byte GetLevelIndexFromID(byte LevelID)
        {
            switch (LevelID)
            {
                case 0x4:
                    {
                        return 0;
                    }

                case 0x5:
                    {
                        return 1;
                    }

                case 0x6:
                    {
                        return 2;
                    }

                case 0x7:
                    {
                        return 3;
                    }

                case 0x8:
                    {
                        return 4;
                    }

                case 0x9:
                    {
                        return 5;
                    }

                case 0xA:
                    {
                        return 6;
                    }

                case 0xB:
                    {
                        return 7;
                    }

                case 0xC:
                    {
                        return 8;
                    }

                case 0xD:
                    {
                        return 9;
                    }

                case 0xE:
                    {
                        return 10;
                    }

                case 0xF:
                    {
                        return 11;
                    }

                case 0x10:
                    {
                        return 12;
                    }

                case 0x11:
                    {
                        return 13;
                    }

                case 0x12:
                    {
                        return 14;
                    }

                case 0x13:
                    {
                        return 15;
                    }

                case 0x14:
                    {
                        return 16;
                    }

                case 0x15:
                    {
                        return 17;
                    }

                case 0x16:
                    {
                        return 18;
                    }

                case 0x17:
                    {
                        return 19;
                    }

                case 0x18:
                    {
                        return 20;
                    }

                case 0x19:
                    {
                        return 21;
                    }

                case 0x1A:
                    {
                        return 22;
                    }

                case 0x1B:
                    {
                        return 23;
                    }

                case 0x1C:
                    {
                        return 24;
                    }

                case 0x1D:
                    {
                        return 25;
                    }

                case 0x1E:
                    {
                        return 26;
                    }

                case 0x1F:
                    {
                        return 27;
                    }

                case 0x21:
                    {
                        return 28;
                    }

                case 0x22:
                    {
                        return 29;
                    }

                case 0x24:
                    {
                        return 30;
                    }

                default:
                    {
                        return 5;
                    }
            }
        }

        public static byte GetLevelIDFromIndex(byte LevelID)
        {
            switch (LevelID)
            {
                case 0:
                    {
                        return 0x4;
                    }

                case 1:
                    {
                        return 0x5;
                    }

                case 2:
                    {
                        return 0x6;
                    }

                case 3:
                    {
                        return 0x7;
                    }

                case 4:
                    {
                        return 0x8;
                    }

                case 5:
                    {
                        return 0x9;
                    }

                case 6:
                    {
                        return 0xA;
                    }

                case 7:
                    {
                        return 0xB;
                    }

                case 8:
                    {
                        return 0xC;
                    }

                case 9:
                    {
                        return 0xD;
                    }

                case 10:
                    {
                        return 0xE;
                    }

                case 11:
                    {
                        return 0xF;
                    }

                case 12:
                    {
                        return 0x10;
                    }

                case 13:
                    {
                        return 0x11;
                    }

                case 14:
                    {
                        return 0x12;
                    }

                case 15:
                    {
                        return 0x13;
                    }

                case 16:
                    {
                        return 0x14;
                    }

                case 17:
                    {
                        return 0x15;
                    }

                case 18:
                    {
                        return 0x16;
                    }

                case 19:
                    {
                        return 0x17;
                    }

                case 20:
                    {
                        return 0x18;
                    }

                case 21:
                    {
                        return 0x19;
                    }

                case 22:
                    {
                        return 0x1A;
                    }

                case 23:
                    {
                        return 0x1B;
                    }

                case 24:
                    {
                        return 0x1C;
                    }

                case 25:
                    {
                        return 0x1D;
                    }

                case 26:
                    {
                        return 0x1E;
                    }

                case 27:
                    {
                        return 0x1F;
                    }

                case 28:
                    {
                        return 0x21;
                    }

                case 29:
                    {
                        return 0x22;
                    }

                case 30:
                    {
                        return 0x24;
                    }

                default:
                    {
                        return 5;
                    }
            }
        }

        public static string TrimString(string str)
        {
            string str1;
            try
            {
                str1 = new Regex(@"^[ \t]+|[ \t]+$", RegexOptions.IgnoreCase).Replace(str, "");
            }
            catch (Exception exception)
            {
                exception.ToString();
                str1 = str;
            }

            return str1;
        }

        public static int HexRoundUp1(int value)
        {
            do
            {
                if (Conversion.Hex(value).EndsWith("0"))
                    break; // Or Hex(value).EndsWith("8")
                value += 1;
            }
            while (true);
            return value;
        }

        public static void HexRoundUp2(ref int value)
        {
            do
            {
                if (Conversion.Hex(value).EndsWith("0"))
                    break; // Or Hex(value).EndsWith("8")
                value += 1;
            }
            while (true);
        }

        public static (byte? newID, bool isAnyFree) GetNextAreaID(Level lvl)
        {
            byte? newID = null;
            bool isAnyFree = false;

            // Check for left area IDs
            for (int i = 0; i <= byte.MaxValue; i++)
            {
                if (newID == null)
                {
                    byte areaID = (byte)i;
                    if (!lvl.Areas.Where(n => n.AreaID == areaID).Any())
                    {
                        if (areaID != 0) // Yes skip 0, because it might confuse the user if area ID is"...6...7...0...8...9..."
                            newID = areaID;
                        isAnyFree = true;
                    }
                }
            }

            return (newID, isAnyFree);
        }

        public static Stack<byte> GetAllFreeAreaIDs(Level lvl)
        {
            var ids = new Stack<byte>();
            void addAreaIfNotUsed(byte areaID) { if (!lvl.Areas.Where(n => n.AreaID == areaID).Any()) { ids.Push(areaID); } };
            addAreaIfNotUsed(0);
            for (int i = byte.MaxValue; i >= 1; i += -1)
                addAreaIfNotUsed(Conversions.ToByte(i));
            return ids;
        }

        public static string[] GetAdditionalReferencedAssemblied()
        {
            return new string[]
            {
                typeof(DevComponents.DotNetBar.OfficeForm).Assembly.Location
            };
        }

        public class Bits
        {
            public static byte[] ByteToBitArray(byte b)
            {
                var bitarray = new BitArray(new[] { b });
                var temp = new byte[bitarray.Length];
                for (int i = 0, loopTo = bitarray.Length - 1; i <= loopTo; i++)
                    temp[i] = Conversions.ToByte(bitarray[i]);
                int tindex = 0;
                var temp2 = new byte[(temp.Count())];
                for (int i = temp.Length - 1; i >= 0; i += -1)
                {
                    temp2[tindex] = temp[i];
                    tindex += 1;
                }

                return temp2;
            }

            public static bool[] ByteToBoolArray(byte b)
            {
                var bitarray = new BitArray(new[] { b });
                var temp = new bool[bitarray.Length];
                for (int i = 0, loopTo = bitarray.Length - 1; i <= loopTo; i++)
                    temp[i] = Convert.ToBoolean(bitarray[i]);
                int tindex = 0;
                var temp2 = new bool[(temp.Count())];
                for (int i = temp.Length - 1; i >= 0; i += -1)
                {
                    temp2[tindex] = temp[i];
                    tindex += 1;
                }

                return temp2;
            }

            public static byte ArrayToByte(byte[] ba)
            {
                // ODER: BitArray.ToByte()

                byte endval = 0;
                int index = ba.Count() - 1;
                foreach (var bit in ba)
                {
                    endval += (byte)(bit * Math.Pow(2, index));
                    index -= 1;
                }

                return endval;
            }

            public static byte ArrayToByte(bool[] ba)
            {
                // ODER: BitArray.ToByte()

                byte endval = 0;
                int index = ba.Count() - 1;
                foreach (var bit in ba)
                {
                    endval += (byte)((bit ? 1 : 0) * Math.Pow(2, index));
                    index -= 1;
                }

                return endval;
            }

            public static byte SetInByte(byte b, int index, byte value)
            {
                var temp = ByteToBitArray(b);
                temp[index] = value;
                return ArrayToByte(temp);
            }

            public static byte SetInByte(byte b, int index, bool value)
            {
                var temp = ByteToBoolArray(b);
                temp[index] = value;
                return ArrayToByte(temp);
            }

            public static byte GetBitOfByte(byte b, int index)
            {
                return ByteToBitArray(b)[index];
            }

            public static bool GetBoolOfByte(byte b, int index)
            {
                return ByteToBoolArray(b)[index];
            }
        }
    }
}