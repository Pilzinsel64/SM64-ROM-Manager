using System;
using System.Collections.Generic;
using System.Diagnostics;
using global::System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::Microsoft.WindowsAPICodePack.Dialogs.Controls;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.LevelEditor;
using global::SM64_ROM_Manager.My.Resources;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib;
using global::SM64Lib.Data;
using global::SM64Lib.Geolayout;
using global::SM64Lib.Levels;
using global::SM64Lib.Model.Fast3D.DisplayLists;
using global::SM64Lib.Patching;
using Z.Collections.Extensions;
using Z.Core.Extensions;
using Microsoft.Win32;
using System.Reflection;
using SM64_ROM_Manager.UserRequests.GUI;
using SM64_ROM_Manager.UserRequests;
using System.Drawing;
using TaskDialog = DevComponents.DotNetBar.TaskDialog;

namespace SM64_ROM_Manager
{
    internal static class General
    {

        public delegate void LoadedAreaVisualMapDisplayListsEventHandler(DisplayList[] dls);
        public static event LoadedAreaVisualMapDisplayListsEventHandler LoadedAreaVisualMapDisplayLists;

        private static bool hasLoadedObjectCombos = false;
        private static bool hasLoadedBehaviorInfos = false;
        private static RomManager romManagerUsedForCustomObjectCombos = null;
        private static RomManager romManagerUsedForCustomBehaviorInfos = null;
        private const string p_ObjectCombos = @"Area Editor\Object Combos.json";
        private const string p_ObjectCombosCustom = @"Area Editor\Object Combos Custom.json";
        private const string p_BehaviorInfos = @"Area Editor\Behavior IDs.json";
        private const string p_BehaviorInfosCustom = @"Area Editor\Behavior IDs Custom.json";
        private const string CustomConfig_Key_BehaviorInfo = "ExtraBehaviorInfo";
        private const string CustomConfig_Key_ObjectCombosInfo = "ExtraObjectCombosInfo";
        public static DateTime lastRomChangedDate = DateTime.Now;

        public static FileSystemWatcher RomWatcher { get; set; } = null;
        public static ObjectComboList ObjectCombos { get; private set; } = new ObjectComboList();
        public static BehaviorInfoList BehaviorInfos { get; private set; } = new BehaviorInfoList();
        public static ObjectComboList ObjectCombosCustom { get; private set; } = new ObjectComboList();
        public static BehaviorInfoList BehaviorInfosCustom { get; private set; } = new BehaviorInfoList();
        public static PatchClass PatchClass { get; private set; } = new PatchClass();
        public static bool HasToolkitInit { get; set; } = false;

        public static void AskForCollectingDiagnosticData(IWin32Window owner, bool showOnlyIfMissingValues)
        {
            var nulls = 0;

            Image getBtnImage(bool? valy)
            {
                if (valy.GetValueOrDefault(true))
                    return MyIcons.icons8_checked_checkbox_32px;
                else
                    return MyIcons.icons8_unchecked_checkbox_32px;
            }

            if (!showOnlyIfMissingValues)
            {
                foreach (string key in DiagnosticDataStruc.Keys)
                {
                    if (Settings.DiagnosticData.GetValue(key) == null)
                        nulls += 1;
                }
            }

            if (!showOnlyIfMissingValues || nulls > 0)
            {
                var commands = new List<Command>();
                foreach (string key in DiagnosticDataStruc.Keys)
                {
                    var val = Settings.DiagnosticData.GetValue(key);
                    if (val == null)
                        Settings.DiagnosticData.SetValue(key, true);
                    var btn = new Command
                    {
                        Name = "btn_" + key
                    };
                    btn.Text = val == null ? Form_Main_Resources.MsgBox_AllowCollectingDiagnosticData_BtnNewText : string.Empty;
                    btn.Text += Form_Main_Resources.ResourceManager.GetString("MsgBox_AllowCollectingDiagnosticData_Btn" + key);
                    btn.Image = getBtnImage(val);
                    btn.Executed += (btnx, __) =>
                    {
                        var btnxx = ((ButtonItem)btnx).Command;
                        var keyx = btnxx.Name.Substring(4);
                        var valx = !Settings.DiagnosticData.GetValue(keyx).GetValueOrDefault(true);
                        Settings.DiagnosticData.SetValue(keyx, valx);
                        btnxx.Image = getBtnImage(valx);
                    };
                    commands.Add(btn);
                }

                var info = new TaskDialogInfo()
                {
                    Text = Form_Main_Resources.MsgBox_AllowCollectingDiagnosticData_Text,
                    Title = Form_Main_Resources.MsgBox_AllowCollectingDiagnosticData_Title,
                    Header = Form_Main_Resources.MsgBox_AllowCollectingDiagnosticData_Header,
                    FormCloseEnabled = false,
                    TaskDialogIcon = eTaskDialogIcon.Information2,
                    DialogButtons = eTaskDialogButton.Ok
                };
                info.Buttons = commands.ToArray();
                TaskDialog.Show(owner, info);
            }
        }

        public static void ExportDiagnosticsProtocol(IWin32Window owner, Exception currentException)
        {
            var sfd_SaveDiagnosticProtocol = new System.Windows.Forms.SaveFileDialog
            {
                Filter = "Error diagnostic file (*.edpf)|*.edpf"
            };
            if (sfd_SaveDiagnosticProtocol.ShowDialog(owner) == DialogResult.OK)
                ExportDiagnosticsProtocol(sfd_SaveDiagnosticProtocol.FileName, currentException);
        }

        public static void ExportDiagnosticsProtocol(string outputPath, Exception currentException)
        {
            var protocol = new DiagnosticProtocol();
            protocol.CollectData(currentException);
            protocol.SaveProtocolFile(outputPath);
        }

        public static void UploadDiagnosticsProtocol(IWin32Window owner, Exception currentException)
        {
            // Get temp for diagnostics file path
            var tempFile = Path.GetTempFileName();
            File.Delete(tempFile);

            // Save temp diagnostics file
            ExportDiagnosticsProtocol(tempFile, currentException);

            // Load and prepair user request
            var request = UserRequestLayout.LoadFrom(Path.Combine(Publics.General.MyUserRequestsPath, "BugReport.json"));
            foreach (UserRequestProperty prop in request.Properties)
            {
                switch (prop.Name)
                {
                    case "Attachments":
                        prop.Value = UserRequestManager.TranslateFilesArrayToString(new string[] { tempFile });
                        break;
                    case "Version":
                        prop.Value = GetApplicationVersionText();
                        break;
                }
            }

            // Let the user fill and send the request
            var frm = new UserRequestDialog(request);
            frm.ShowDialog(owner);

            // Delete the temp diagnostics file
            File.Delete(tempFile);
        }

        public static string GetApplicationVersionText()
        {
            var appversion = new Version(Application.ProductVersion);
            string versionText = $"v{appversion.ToString(appversion.Revision != 0 ? 4 : (appversion.Build != 0 ? 3 : 2))}";

            if (!string.IsNullOrEmpty(Resources.DevelopmentStage))
            {
                bool addDevelopmentalNumber = true;
                var switchExpr = Resources.DevelopmentStage;
                switch (switchExpr)
                {
                    case var @case when @case == Conversions.ToString(3):
                        {
                            versionText += " Alpha";
                            break;
                        }

                    case var case1 when case1 == Conversions.ToString(2):
                        {
                            versionText += " Beta";
                            break;
                        }

                    case var case2 when case2 == Conversions.ToString(1):
                        {
                            versionText += " RC";
                            break;
                        }

                    case var case3 when case3 == Conversions.ToString(0):
                        {
                            addDevelopmentalNumber = false;
                            break;
                        }
                }

                if (addDevelopmentalNumber)
                {
                    versionText += " " + Resources.DevelopmentBuild;
                }
            }

            return versionText;
        }

        public static void UpdateChecksum(string Romfile)
        {
            DisableRomWatcher();
            PatchClass.UpdateChecksum(Romfile);
            EnableRomWatcher();
        }

        public static void EnableRomWatcher()
        {
            if (RomWatcher is object)
            {
                RomWatcher.EnableRaisingEvents = true;
            }
        }

        public static void DisableRomWatcher()
        {
            if (RomWatcher is object)
            {
                RomWatcher.EnableRaisingEvents = false;
            }
        }

        public static bool IsRomWatcherEnabled()
        {
            return RomWatcher?.EnableRaisingEvents == true;
        }

        public static Task OpenHexEditorAsync(SM64Lib.Script.ICommand cmd)
        {
            var t = new Task(() => OpenHexEditor(cmd));
            t.Start();
            return t;
        }

        public static void OpenHexEditor(SM64Lib.Script.ICommand cmd)
        {
            BinaryData data = (BinaryData)cmd;

            // Copy content of command to a buffer
            var buffer = new byte[(int)(data.Length - 1) + 1];
            data.Position = 0;
            data.Read(buffer);

            // Let edit the buffer
            OpenHexEditor(ref buffer);

            // Copy content of buffer back to command
            data.SetLength(buffer.Length);
            data.Position = 0;
            data.Write(buffer);
        }

        public static HexEditModes GetCurrentHexEditMode()
        {
            var mode = Settings.General.HexEditMode.Mode;
            if (mode == HexEditModes.CustomHexEditor && !File.Exists(Settings.General.HexEditMode.CustomPath))
            {
                mode = HexEditModes.BuildInHexEditor;
            }

            return mode;
        }

        public static void OpenHexEditor(ref byte[] buffer)
        {
            var mode = GetCurrentHexEditMode();
            switch (mode)
            {
                case HexEditModes.BuildInHexEditor:
                    {
                        var editor = new HexEditor(buffer);
                        editor.ShowDialog();
                        buffer = editor.GetData();
                        break;
                    }

                case HexEditModes.CustomHexEditor:
                    {
                        // Create temp file
                        string tempFile = Path.GetTempFileName();

                        // Write content of command to temp file
                        var fs = new FileStream(tempFile, FileMode.Open, FileAccess.ReadWrite);
                        fs.Write(buffer, 0, buffer.Length);
                        fs.Flush();
                        fs.Close();

                        // Start Hex Editor and wait while running
                        OpenHexEditor(tempFile);

                        // Read content of temp file to command
                        fs = new FileStream(tempFile, FileMode.Open, FileAccess.Read);
                        buffer = new byte[(int)(fs.Length - 1) + 1];
                        fs.Read(buffer, 0, buffer.Length);
                        fs.Close();

                        // Remove temp file
                        File.Delete(tempFile);
                        break;
                    }
            }
        }

        public static void OpenHexEditor(string filePath)
        {
            var p = new Process();
            p.StartInfo.FileName = Settings.General.HexEditMode.CustomPath;
            p.StartInfo.Arguments = $"\"{filePath}\"";
            p.Start();
            p.WaitForExit();
        }

        public static Task OpenHexEditorAsync(string filePath)
        {
            return Task.Run(new Action(() => OpenHexEditor(filePath)));
        }

        public static bool CheckForOpenWithContextMenuEntry()
        {
            try
            {
                var val = Registry.CurrentUser.OpenSubKey($"Software\\Classes\\{GetZ64FileClassesRoot()}\\shell\\SM64ROMManager\\command", false)?.GetValue(string.Empty);
                return val != null && ((string)val).Contains(Publics.General.MyExecuteablePath);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void FixOpenWithContextMenuEntry()
        {
            if (!CheckForOpenWithContextMenuEntry())
                AddOpenWithContextMenuEntry(true);
        }

        public static void AddOpenWithContextMenuEntry()
        {
            AddOpenWithContextMenuEntry(false);
        }

        private static void AddOpenWithContextMenuEntry(bool onlyAddIfExists)
        {
            RegistryKey getSubKey(RegistryKey key, string keyName)
            {
                if (onlyAddIfExists)
                    return key.OpenSubKey(keyName, true);
                else
                    return key.CreateSubKey(keyName, true);
            }

            var key = getSubKey(Registry.CurrentUser, $"Software\\Classes\\{GetZ64FileClassesRoot()}\\shell\\SM64ROMManager");
            if (key is object)
            {
                key.SetValue(string.Empty, Form_Main_Resources.OpenWithContextMenuEntry);
                key.SetValue("icon", $"\"{Publics.General.MyExecuteablePath}\"");
                var commandKey = key.CreateSubKey("command", true);
                commandKey.SetValue(string.Empty, $"\"{Publics.General.MyExecuteablePath}\" \"%1\"");
            }
        }

        public static void RemoveOpenWithContextMenuEntry()
        {
            var key = Registry.CurrentUser.OpenSubKey($"Software\\Classes\\{GetZ64FileClassesRoot()}\\shell", true);
            key?.DeleteSubKeyTree("SM64ROMManager");
        }

        private static string GetZ64FileClassesRoot()
        {
            return (string)Registry.ClassesRoot.OpenSubKey(".z64", false).GetValue(string.Empty);
        }

        public static string GetKeyForConvertAreaModel(string romGameName, short curLevelID, byte curAreaID)
        {
            return $"{romGameName} l{curLevelID.ToString("X2")} a{curAreaID.ToString("X")}";
        }

        public static void LoadBehaviorInfosIfEmpty(RomManager rommgr)
        {
            if (!hasLoadedBehaviorInfos || rommgr != romManagerUsedForCustomBehaviorInfos)
                LoadBehaviorInfos(rommgr, true);
        }

        public static void LoadBehaviorInfos(RomManager rommgr, bool checkIfEmpty = false)
        {
            if (!hasLoadedBehaviorInfos)
            {
                string p_Default = Path.Combine(Publics.General.MyDataPath, p_BehaviorInfos);
                string p_Custom = Path.Combine(Publics.General.MyDataPath, p_BehaviorInfosCustom);

                if ((!hasLoadedBehaviorInfos || !checkIfEmpty) && File.Exists(p_Default))
                    BehaviorInfos.ReadFromFile(p_Default);

                if (rommgr != romManagerUsedForCustomBehaviorInfos || !checkIfEmpty)
                {
                    if (rommgr is object && rommgr.RomConfig.CustomConfigs.ContainsKey(CustomConfig_Key_BehaviorInfo))
                        BehaviorInfosCustom.ReadFromString(rommgr.RomConfig.CustomConfigs[CustomConfig_Key_BehaviorInfo]);
                    else if (File.Exists(p_Custom))
                        BehaviorInfosCustom.ReadFromFile(p_Custom);
                }

                hasLoadedBehaviorInfos = true;
            }
        }

        public static void LoadObjectCombosIfEmpty(RomManager rommgr)
        {
            if (!hasLoadedObjectCombos || rommgr != romManagerUsedForCustomObjectCombos)
                LoadObjectCombos(rommgr, true);
        }

        public static void LoadObjectCombos(RomManager rommgr, bool checkIfEmpty = false)
        {
            string p_Default = Path.Combine(Publics.General.MyDataPath, p_ObjectCombos);
            string p_Custom = Path.Combine(Publics.General.MyDataPath, p_ObjectCombosCustom);

            if ((!hasLoadedObjectCombos || !checkIfEmpty) && File.Exists(p_Default))
                ObjectCombos.ReadFromFile(p_Default);

            if (rommgr != romManagerUsedForCustomObjectCombos || !checkIfEmpty)
            {
                if (rommgr is object && rommgr.RomConfig.CustomConfigs.ContainsKey(CustomConfig_Key_ObjectCombosInfo))
                    ObjectCombosCustom.ReadFromString(rommgr.RomConfig.CustomConfigs[CustomConfig_Key_ObjectCombosInfo]);
                else if (File.Exists(p_Custom))
                    ObjectCombosCustom.ReadFromFile(p_Custom);
            }

            hasLoadedObjectCombos = true;
        }

        public static void SaveBehaviorInfos(RomManager rommgr)
        {
            string p_Default = Path.Combine(Publics.General.MyDataPath, p_BehaviorInfos);
            BehaviorInfos.WriteToFile(p_Default);
            
            if (rommgr is object)
                rommgr.RomConfig.CustomConfigs.AddOrUpdate(CustomConfig_Key_BehaviorInfo, BehaviorInfosCustom.WriteToString());
        }

        public static void SaveObjectCombos(RomManager rommgr)
        {
            string p_Default = Path.Combine(Publics.General.MyDataPath, p_ObjectCombos);
            ObjectCombos.WriteToFile(p_Default);

            if (rommgr is object)
                rommgr.RomConfig.CustomConfigs.AddOrUpdate(CustomConfig_Key_ObjectCombosInfo, ObjectCombosCustom.WriteToString());
        }

        public static object GetFiltersFromFilter(string filter, params char[] splitters)
        {
            var filters = new List<string>();
            foreach (string fef in filter.ToLower().Split(splitters))
            {
                var f = fef.Trim(); ;
                
                if (!string.IsNullOrEmpty(f))
                {
                    filters.Add(f);
                }
            }

            return filters.ToArray();
        }

        public static CommonFileDialogControl GetMidiExportDialogControls()
        {
            var cb = new CommonFileDialogComboBox()
            {
                Name = "MidiChunksSelector",
                IsProminent = true
            };
            cb.Items.Add(new CommonFileDialogComboBoxItem("1 Chunk"));
            cb.Items.Add(new CommonFileDialogComboBoxItem("2 Chunks"));
            cb.SelectedIndex = 1;
            return cb;
        }

        internal static void LaunchRom(RomManager rommgr)
        {
            if (!string.IsNullOrEmpty(rommgr?.RomFile))
            {
                try
                {
                    if (!string.IsNullOrEmpty(Settings.General.EmulatorPath))
                    {
                        Process.Start(Settings.General.EmulatorPath, rommgr.RomFile);
                    }
                    else
                    {
                        Process.Start(rommgr.RomFile);
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(Form_Main_Resources.MsgBox_RomCanNotBestarted, Form_Main_Resources.MsgBox_RomCanNotBestarted_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal static void SaveRom(RomManager rommgr)
        {
            if (rommgr is object)
            {
                bool dontpatchupdates;
                RomWatcher.EnableRaisingEvents = false;
                if (rommgr.AreRomUpdatesAvaiable())
                {
                    var switchExpr = Settings.General.ActionIfUpdatePatches;
                    switch (switchExpr)
                    {
                        case DialogResult.Yes:
                            dontpatchupdates = false;
                            break;
                        case DialogResult.No:
                            dontpatchupdates = true;
                            break;
                        default:
                            var tdi = new TaskDialogInfo(Form_Main_Resources.MsgBox_UpdatePatchesAvaiable_Title, eTaskDialogIcon.ShieldHelp, Form_Main_Resources.MsgBox_UpdatePatchesAvaiable_Title, Form_Main_Resources.MsgBox_UpdatePatchesAvaiable, eTaskDialogButton.Yes | eTaskDialogButton.No | eTaskDialogButton.Cancel);
                            tdi.CheckBoxCommand = new Command() { Text = "Don't show this message again." };

                            var switchExpr1 = TaskDialog.Show(tdi);
                            switch (switchExpr1)
                            {
                                case eTaskDialogResult.Yes:
                                    dontpatchupdates = false;
                                    if (tdi.CheckBoxCommand.Checked)
                                    {
                                        Settings.General.ActionIfUpdatePatches = DialogResult.Yes;
                                    }

                                    break;
                                case eTaskDialogResult.No:
                                    dontpatchupdates = true;
                                    if (tdi.CheckBoxCommand.Checked)
                                    {
                                        Settings.General.ActionIfUpdatePatches = DialogResult.No;
                                    }

                                    break;
                                default:
                                    return;
                            }

                            if (!tdi.CheckBoxCommand.Checked)
                            {
                                Settings.General.ActionIfUpdatePatches = DialogResult.None;
                            }

                            break;
                    }
                }
                else
                {
                    dontpatchupdates = false;
                }

                rommgr.SaveRom(
                    DontPatchUpdates: dontpatchupdates,
                    recalcChecksumBehavior: Settings.General.RecalcChecksumBehavior);
                RomWatcher.EnableRaisingEvents = true;
            }
        }

        internal static Task<Object3D> LoadAreaVisualMapAsObject3DAsync(RomManager rommgr, LevelArea area)
        {
            var t = new Task<Object3D>(() => LoadAreaVisualMapAsObject3D(rommgr, area));
            t.Start();
            return t;
        }

        internal static Object3D LoadAreaVisualMapAsObject3D(RomManager rommgr, LevelArea area)
        {
            var obj = new Object3D();
            var dls = new List<DisplayList>();
            
            foreach (Geopointer geop in area.AreaModel.Fast3DBuffer.DLPointers)
            {
                var dl = new DisplayList();
                dl.FromStream(geop, rommgr, area.AreaID);
                dl.ToObject3D(obj, rommgr, area.AreaID);
                dls.Add(dl);
            }

            LoadedAreaVisualMapDisplayLists?.Invoke(dls.ToArray());

            return obj;
        }

        internal static Object3D LoadVisualMapAsObject3D(RomManager rommgr, SM64Lib.Model.Fast3D.Fast3DBuffer mdl)
        {
            var obj = new Object3D();
            foreach (Geopointer geop in mdl.DLPointers)
            {
                var dl = new DisplayList();
                dl.FromStream(geop, rommgr, default);
                dl.ToObject3D(obj, rommgr, default);
            }

            return obj;
        }

        public static void ReorderBoxDataPositions(SpecialBox SpecialBox)
        {
            short x1, x2, z1, z2;
            x1 = Math.Min(SpecialBox.X1, SpecialBox.X2);
            x2 = Math.Max(SpecialBox.X1, SpecialBox.X2);
            z1 = Math.Min(SpecialBox.Z1, SpecialBox.Z2);
            z2 = Math.Max(SpecialBox.Z1, SpecialBox.Z2);
            SpecialBox.X1 = x1;
            SpecialBox.X2 = x2;
            SpecialBox.Z1 = z1;
            SpecialBox.Z2 = z2;
        }

        public static bool IsFormOpen<FormType>()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FormType)
                {
                    return true;
                }
            }

            return false;
        }

        public static Form GetFirstOpenForm<FormType>()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FormType)
                {
                    return frm;
                }
            }

            return null;
        }

        public static void AwaitOnUI<T>(T task) where T : Task
        {
            while (task.Status == TaskStatus.Running)
                Application.DoEvents();
        }

        public static object AwaitOnUI<T>(Task<T> task)
        {
            while (task.Status == TaskStatus.Running)
                Application.DoEvents();
            return task.Result;
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public static BackgroundPointers GetBackgroundAddressOfID(BackgroundIDs ID, bool EndAddr)
        {
            switch (ID)
            {
                case BackgroundIDs.AboveClouds:
                    {
                        if (EndAddr)
                            return BackgroundPointers.AboveCloudsEnd;
                        return BackgroundPointers.AboveCloudsStart;
                    }

                case BackgroundIDs.BelowClouds:
                    {
                        if (EndAddr)
                            return BackgroundPointers.BelowCloudsEnd;
                        return BackgroundPointers.BelowCloudsStart;
                    }

                case BackgroundIDs.Cavern:
                    {
                        if (EndAddr)
                            return BackgroundPointers.CavernEnd;
                        return BackgroundPointers.CavernStart;
                    }

                case BackgroundIDs.Desert:
                    {
                        if (EndAddr)
                            return BackgroundPointers.DesertEnd;
                        return BackgroundPointers.DesertStart;
                    }

                case BackgroundIDs.FlamingSky:
                    {
                        if (EndAddr)
                            return BackgroundPointers.FlamingSkyEnd;
                        return BackgroundPointers.FlamingSkyStart;
                    }

                case BackgroundIDs.HauntedForest:
                    {
                        if (EndAddr)
                            return BackgroundPointers.HauntedForestEnd;
                        return BackgroundPointers.HauntedForestStart;
                    }

                case BackgroundIDs.Ocean:
                    {
                        if (EndAddr)
                            return BackgroundPointers.OceanEnd;
                        return BackgroundPointers.OceanStart;
                    }

                case BackgroundIDs.PurpleClouds:
                    {
                        if (EndAddr)
                            return BackgroundPointers.PurpleCloudsEnd;
                        return BackgroundPointers.PurpleCloudsStart;
                    }

                case BackgroundIDs.SnowyMountains:
                    {
                        if (EndAddr)
                            return BackgroundPointers.SnowyMountainsEnd;
                        return BackgroundPointers.SnowyMountainsStart;
                    }

                case BackgroundIDs.UnderwaterCity:
                    {
                        if (EndAddr)
                            return BackgroundPointers.UnderwaterCityEnd;
                        return BackgroundPointers.UnderwaterCityStart;
                    }
            }

            return EndAddr ? BackgroundPointers.OceanEnd : BackgroundPointers.OceanStart;
        }

        public static BackgroundIDs GetBackgroundIDOfAddress(int StartAddr)
        {
            switch (StartAddr)
            {
                case (int)BackgroundPointers.AboveCloudsStart:
                    {
                        return BackgroundIDs.AboveClouds;
                    }

                case (int)BackgroundPointers.BelowCloudsStart:
                    {
                        return BackgroundIDs.BelowClouds;
                    }

                case (int)BackgroundPointers.CavernStart:
                    {
                        return BackgroundIDs.Cavern;
                    }

                case (int)BackgroundPointers.DesertStart:
                    {
                        return BackgroundIDs.Desert;
                    }

                case (int)BackgroundPointers.FlamingSkyStart:
                    {
                        return BackgroundIDs.FlamingSky;
                    }

                case (int)BackgroundPointers.HauntedForestStart:
                    {
                        return BackgroundIDs.HauntedForest;
                    }

                case (int)BackgroundPointers.OceanStart:
                    {
                        return BackgroundIDs.Ocean;
                    }

                case (int)BackgroundPointers.PurpleCloudsStart:
                    {
                        return BackgroundIDs.PurpleClouds;
                    }

                case (int)BackgroundPointers.SnowyMountainsStart:
                    {
                        return BackgroundIDs.SnowyMountains;
                    }

                case (int)BackgroundPointers.UnderwaterCityStart:
                    {
                        return BackgroundIDs.UnderwaterCity;
                    }

                default:
                    {
                        return BackgroundIDs.Custom;
                    }
            }
        }

        public static BackgroundIDs GetBackgroundIDOfIndex(int Index)
        {
            switch (Index)
            {
                case 0:
                    {
                        return BackgroundIDs.HauntedForest;
                    }

                case 1:
                    {
                        return BackgroundIDs.SnowyMountains;
                    }

                case 2:
                    {
                        return BackgroundIDs.Desert;
                    }

                case 3:
                    {
                        return BackgroundIDs.Ocean;
                    }

                case 4:
                    {
                        return BackgroundIDs.UnderwaterCity;
                    }

                case 5:
                    {
                        return BackgroundIDs.BelowClouds;
                    }

                case 6:
                    {
                        return BackgroundIDs.AboveClouds;
                    }

                case 7:
                    {
                        return BackgroundIDs.Cavern;
                    }

                case 8:
                    {
                        return BackgroundIDs.FlamingSky;
                    }

                case 9:
                    {
                        return BackgroundIDs.PurpleClouds;
                    }

                case 10:
                    {
                        return BackgroundIDs.Custom;
                    }

                default:
                    {
                        return BackgroundIDs.Ocean;
                    }
            }
        }

        public static int GetBackgroundIndexOfID(BackgroundIDs ID)
        {
            switch (ID)
            {
                case BackgroundIDs.HauntedForest:
                    {
                        return 0;
                    }

                case BackgroundIDs.SnowyMountains:
                    {
                        return 1;
                    }

                case BackgroundIDs.Desert:
                    {
                        return 2;
                    }

                case BackgroundIDs.Ocean:
                    {
                        return 3;
                    }

                case BackgroundIDs.UnderwaterCity:
                    {
                        return 4;
                    }

                case BackgroundIDs.BelowClouds:
                    {
                        return 5;
                    }

                case BackgroundIDs.AboveClouds:
                    {
                        return 6;
                    }

                case BackgroundIDs.Cavern:
                    {
                        return 7;
                    }

                case BackgroundIDs.FlamingSky:
                    {
                        return 8;
                    }

                case BackgroundIDs.PurpleClouds:
                    {
                        return 9;
                    }

                case BackgroundIDs.Custom:
                    {
                        return 10;
                    }

                default:
                    {
                        return (int)BackgroundIDs.Ocean;
                        return 0;
                    }
            }
        }

        public static EnvironmentEffects GetEnvironmentTypeOfIndex(int Index)
        {
            switch (Index)
            {
                case 0:
                    {
                        return EnvironmentEffects.NoEffect;
                    }

                case 1:
                    {
                        return EnvironmentEffects.Snow;
                    }

                case 2:
                    {
                        return EnvironmentEffects.Bllizard;
                    }

                case 3:
                    {
                        return EnvironmentEffects.BetaFlower;
                    }

                case 4:
                    {
                        return EnvironmentEffects.Lava;
                    }

                case 5:
                    {
                        return EnvironmentEffects.WaterRelated1;
                    }

                case 6:
                    {
                        return EnvironmentEffects.WaterRelated2;
                    }

                default:
                    {
                        return EnvironmentEffects.NoEffect;
                    }
            }
        }

        public static int GetEnvironmentIndexOfType(EnvironmentEffects Type)
        {
            switch (Type)
            {
                case EnvironmentEffects.NoEffect:
                    {
                        return 0;
                    }

                case EnvironmentEffects.Snow:
                    {
                        return 1;
                    }

                case EnvironmentEffects.Bllizard:
                    {
                        return 2;
                    }

                case EnvironmentEffects.BetaFlower:
                    {
                        return 3;
                    }

                case EnvironmentEffects.Lava:
                    {
                        return 4;
                    }

                case EnvironmentEffects.WaterRelated1:
                    {
                        return 5;
                    }

                case EnvironmentEffects.WaterRelated2:
                    {
                        return 6;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        public static CameraPresets GetCameraPresetTypeOfIndex(int Index)
        {
            return (CameraPresets)Conversions.ToInteger(Index + 1);
        }

        public static int GetCameraPresetIndexOfType(CameraPresets Type)
        {
            return Conversions.ToInteger(Type) - 1;
        }

        public static int GetAreaBGIndexOfID(AreaBGs ID)
        {
            return Conversions.ToInteger(ID);
        }

        public static AreaBGs GetAreaBGIDOfIndex(int Index)
        {
            return (AreaBGs)Conversions.ToInteger(Index);
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}