using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using global::System.IO;
using System.Linq;
using global::System.Net;
using global::System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::Microsoft.WindowsAPICodePack.Dialogs;
using global::Microsoft.WindowsAPICodePack.Dialogs.Controls;
using global::Pilz.Reflection.PluginSystem;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.ModelConverterGUI;
using global::SM64_ROM_Manager.PatchScripts;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64_ROM_Manager.Updating;
using global::SM64_ROM_Manager.Updating.Client.GUI;
using global::SM64_ROM_Manager.UserRequests;
using global::SM64_ROM_Manager.UserRequests.GUI;
using global::SM64Lib;
using global::SM64Lib.Data;
using global::SM64Lib.EventArguments;
using global::SM64Lib.Exceptions;
using global::SM64Lib.Geolayout;
using global::SM64Lib.Levels;
using global::SM64Lib.Levels.Script.Commands;
using global::SM64Lib.Music;
using global::SM64Lib.Objects.ObjectBanks;
using global::SM64Lib.Script;
using SM64Lib.TextValueConverter;
using Z.Core.Extensions;
using SM64_ROM_Manager.My.Resources;
using System.Diagnostics;
using SM64Lib.Objects.ObjectBanks.Data;

namespace SM64_ROM_Manager
{
    public class MainController
    {

        // E v e n t s

        public event Action RomLoading;
        public event Action RomLoaded;
        public event Action RomMusicLoaded;
        public event Action RomLevelsLoaded;

        public event StatusTextChangedEventHandler StatusTextChanged;
        public delegate void StatusTextChangedEventHandler(EventArguments.StatusTextChangedEventArgs e);

        public event OtherStatusInfosChangedEventHandler OtherStatusInfosChanged;
        public delegate void OtherStatusInfosChangedEventHandler(EventArguments.OtherStatusInfosChangedEventArgs e);

        public event Action RecentFilesChanged;
        public event Action RomFileRenamed;
        public event Action RomFileDeleted;
        public event Action RomFileChanged;

        public event RomChangesAvailableEventHandler RomChangesAvailable;
        public delegate void RomChangesAvailableEventHandler(EventArguments.RomChangesAvaiableEventArgs e);

        public event MusicSequenceEventHandler MusicSequenceRemoved;
        public event MusicSequenceEventHandler MusicSequenceAdded;
        public event MusicSequenceEventHandler MusicSequenceChanged;
        public delegate void MusicSequenceEventHandler(EventArguments.MusicSequenceEventArgs e);

        public event RequestIsChangingTabEventHandler RequestIsChangingTab;
        public delegate void RequestIsChangingTabEventHandler(EventArguments.EnabledEventArgs e);

        public event SpecialItemEventHandler LevelSpecialItemAdded;
        public event SpecialItemEventHandler LevelSpecialItemRemoved;
        public event SpecialItemEventHandler LevelSpecialItemChanged;
        public delegate void SpecialItemEventHandler(EventArguments.SpecialItemEventArgs e);

        public event LevelBackgroundModeChangedEventHandler LevelBackgroundModeChanged;
        public delegate void LevelBackgroundModeChangedEventHandler(EventArguments.LevelBackgroundModeChangedEventArgs e);

        public event LevelBackgroundImageChangedEventHandler LevelBackgroundImageChanged;
        public delegate void LevelBackgroundImageChangedEventHandler(EventArguments.LevelBackgroundImageChangedEventArgs e);

        public event LevelAreaBackgroundModeChangedEventHandler LevelAreaBackgroundModeChanged;
        public delegate void LevelAreaBackgroundModeChangedEventHandler(EventArguments.LevelAreaBackgroundModeChangedEventArgs e);

        public event LevelEventHandler LevelAdded;
        public event LevelEventHandler LevelRemoved;
        public event LevelEventHandler LevelIDChanged;
        public event LevelEventHandler LevelCustomNameChanged;
        public event LevelEventHandler LevelCustomObjectsCountChanged;
        public delegate void LevelEventHandler(EventArguments.LevelEventArgs e);

        public event LevelAreaEventHandler LevelAreaAdded;
        public event LevelAreaEventHandler LevelAreaRemoved;
        public event LevelAreaEventHandler LevelAreaScrollingTextureCountChanged;
        public event LevelAreaEventHandler LevelAreaIDChanged;
        public delegate void LevelAreaEventHandler(EventArguments.LevelAreaEventArgs e);

        public event Action ObjectBankDataChanged;
        public event Action ErrorBecauseNoRomLoaded;
        public event Action RomSaved;
        public event Action RomSaving;

        // C o n s t a n t s

        public const string UPDATE_URL = "https://pilzinsel64.com/pilzcloud/index.php/s/sm64rm-allupdatepackages/download?path=%2F&files=CurrentUpdates.json";

        // F i e l d s

        private readonly SM64_ROM_Manager.MainForm mainForm;
        private readonly UpdateClient updateClient;
        private RomManager _RomManager;
        private bool addedTweakViewerEvents = false;
        private TextManagerController tmc = null;

        private string _StatusText = string.Empty;
        private bool loadRecentROM = false;
        private bool loadingROM = false;
        private bool savingRom = false;
        private byte hasRomChanged = 0;
        private FileSystemWatcher _RomWatcher = null;
        private bool isSavingRom = false;
        private bool isExecutingProcess = false;

        private List<BinaryData> openBinaryDatas = new List<BinaryData>();

        // P r o p e r t i e s

        private RomManager RomManager
        {
            get
            {
                return _RomManager;
            }
            set
            {
                if (_RomManager != null)
                {
                    _RomManager.WritingNewProgramVersion -= RomManager_WritingNewRomVersion;
                    _RomManager.BeforeRomSave -= RomManager_BeforeRomSave;
                    _RomManager.AfterRomSave -= RomManager_AfterRomSave;
                    _RomManager.BeginLoadingRom -= RomManager_BeginLoadingRom;
                    _RomManager.AfterLevelsLoaded -= RomManager_AfterLevelsLoaded;
                    _RomManager.BeginLoadingMusic -= RomManager_BeginLoadingMusic;
                    _RomManager.AfterMusicLoaded -= RomManager_AfterMusicLoaded;
                    _RomManager.AfterRomLoaded -= RomManager_AfterRomLoaded;
                }

                _RomManager = value;
                if (_RomManager != null)
                {
                    _RomManager.WritingNewProgramVersion += RomManager_WritingNewRomVersion;
                    _RomManager.BeforeRomSave += RomManager_BeforeRomSave;
                    _RomManager.AfterRomSave += RomManager_AfterRomSave;
                    _RomManager.BeginLoadingRom += RomManager_BeginLoadingRom;
                    _RomManager.AfterLevelsLoaded += RomManager_AfterLevelsLoaded;
                    _RomManager.BeginLoadingMusic += RomManager_BeginLoadingMusic;
                    _RomManager.AfterMusicLoaded += RomManager_AfterMusicLoaded;
                    _RomManager.AfterRomLoaded += RomManager_AfterRomLoaded;
                }
            }
        }

        private FileSystemWatcher RomWatcher
        {
            get
            {
                return _RomWatcher;
            }
            set
            {
                if (_RomWatcher != null)
                {
                    _RomWatcher.Changed -= RomWatcher_Changed;
                    _RomWatcher.Renamed -= RomWatcher_Renamed;
                    _RomWatcher.Deleted -= RomWatcher_Deleted;
                }

                _RomWatcher = value;
                if (_RomWatcher != null)
                {
                    _RomWatcher.Changed += RomWatcher_Changed;
                    _RomWatcher.Renamed += RomWatcher_Renamed;
                    _RomWatcher.Deleted += RomWatcher_Deleted;
                }
            }
        }

        public TextManagerController TextManagerController
        {
            get
            {
                if (tmc is null)
                {
                    tmc = new TextManagerController();
                }
                return tmc;
            }
        }

        public string Romfile
        {
            get
            {
                return RomManager?.RomFile;
            }
        }

        public string StatusText
        {
            get
            {
                return _StatusText;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    value = My.Resources.Form_Main_Resources.Status_Ready;
                _StatusText = value;
                StatusTextChanged?.Invoke(new EventArguments.StatusTextChangedEventArgs(_StatusText));
            }
        }

        public bool HasRomManager
        {
            get
            {
                return RomManager is object;
            }
        }

        public bool EnableMusicHack
        {
            get
            {
                return RomManager.MusicList.EnableMusicHack;
            }

            set
            {
                if (value != RomManager.MusicList.EnableMusicHack)
                {
                    RomManager.MusicList.EnableMusicHack = value;
                    RomManager.MusicList.NeedToSaveMusicHackSettings = true;
                }
            }
        }

        public bool IsLoadingRom
        {
            get
            {
                return loadingROM;
            }
        }

        // C o n s t r u c t o r

        public MainController()
        {
            this.TextManagerController.RequestRomManager += e => e.RomManager = this.RomManager;
            this.TextManagerController.RequestIsChangingTab += e => e.Value = Conversions.ToBoolean(this.IsChangingTab());
            this.TextManagerController.SettingOtherStatusInfo += (text, foreColor) => this.SetOtherStatusInfos(text, foreColor);
            this.TextManagerController.SettingStatusText += text => this.StatusText = text;
            this.TextManagerController.RequestStatusText += e => e.Value = this.StatusText;
            this.TextManagerController.ErrorBecauseNoRomLoaded += () => ErrorBecauseNoRomLoaded?.Invoke();
        }

        public MainController(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;

            // Do some default inits
            Publics.General.DoDefaultInitsAfterApplicationStartup();

            // Watch BinaryWatchers
            BinaryData.AnyBinaryDataOpened += HandlesBinaryDataOpened;
            BinaryData.AnyBinaryDataClosed += HandlesBinaryDataClosed;
            BinaryData.AnyBinaryDataDisposed += ClearUpOpenBinaryDatasAndEnableRomWatcher;

            // Watch processes
            SM64Lib.Patching.PatchClass.StartingExternalTool += PatchClass_StartingExternalTool;
            SM64Lib.Patching.PatchClass.ExitingExternalTool += PatchClass_ExitingExternalTool;

            var appVersion = new ApplicationVersion(new Version(Application.ProductVersion), Conversions.ToInteger(SM64_ROM_Manager.My.Resources.Resources.DevelopmentBuild), (Channels)Conversions.ToInteger(SM64_ROM_Manager.My.Resources.Resources.DevelopmentStage));
            updateClient = new UpdateClient(UPDATE_URL, appVersion, Settings.Network.MinimumUpdateChannel)
            {
                ApplicationName = Application.ProductName,
                AutoCloseHostApplication = true,
                AutoRestartHostApplication = true,
                ForceClosingHostApplication = true,
                InstallAsAdmin = Settings.Network.UseAdminRightsForUpdates,
                UpdateWindowBaseColor = StyleManager.MetroColorGeneratorParameters.BaseColor,
                UpdateWindowCanvasColor = StyleManager.MetroColorGeneratorParameters.CanvasColor
            };

            // Enable Auto-Save for Settings
            Settings.AutoSave = true;
        }

        // P a t c h C l a s s   E v e n t s

        private void PatchClass_ExitingExternalTool(SM64Lib.Patching.PatchClass instance)
        {
            isExecutingProcess = false;
            ClearUpOpenBinaryDatasAndEnableRomWatcher();
        }

        private void PatchClass_StartingExternalTool(SM64Lib.Patching.PatchClass instance)
        {
            General.DisableRomWatcher();
            isExecutingProcess = true;
        }

        // R o m M a n a g e r   E v e n t s

        private void RomManager_WritingNewRomVersion(RomManager sender, RomVersionEventArgs e)
        {
            var v = e.RomVersion;
            v = PatchNewRomVersion(v);
            e.RomVersion = v;
        }

        private void RomManager_AfterRomSave(RomManager sender, EventArgs e)
        {
            isSavingRom = false;
            ClearUpOpenBinaryDatasAndEnableRomWatcher();
        }

        private void RomManager_BeforeRomSave(RomManager sender, System.ComponentModel.CancelEventArgs e)
        {
            General.DisableRomWatcher();
            isSavingRom = true;
        }

        private void RomManager_BeginLoadingRom(RomManager sender, EventArgs e)
        {
            loadingROM = true;
            StatusText = Form_Main_Resources.Status_LoadingRom;
            RomLoading?.Invoke();
        }

        private void RomManager_AfterLevelsLoaded(RomManager sender, EventArgs e)
        {
            RomLevelsLoaded?.Invoke();
        }

        private void RomManager_BeginLoadingMusic(RomManager sender, EventArgs e)
        {
            StatusText = Form_Main_Resources.Status_LoadingMusic;
        }

        private void RomManager_AfterMusicLoaded(RomManager sender, EventArgs e)
        {
            RomMusicLoaded?.Invoke();
        }

        private void RomManager_AfterRomLoaded(RomManager sender, EventArgs e)
        {
            RomLoaded?.Invoke();
            StatusText = string.Empty;
            loadingROM = false;
        }

        // P r i v a t e   F e a u t u r e s

        private void SetRomMgr(RomManager rommgr)
        {
            RomManager = rommgr;
            rommgr.TextInfoProfile = TextManagerController.MyTextProfiles.Manager.DefaultTextProfileInfo;
        }

        private async Task<bool> CanAccessUpdateServer()
        {
            bool result = true;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(UPDATE_URL);
            request.AllowAutoRedirect = false;
            request.Method = "HEAD";
            try
            {
                var response = await request.GetResponseAsync();
                response.Close();
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        private void HandlesBinaryDataOpened(BinaryData data)
        {
            if (!savingRom && data.BaseStream is FileStream && data.CanWrite)
            {
                openBinaryDatas.Add(data);
                General.DisableRomWatcher();
            }
        }

        private void HandlesBinaryDataClosed(BinaryData data)
        {
            if (!savingRom && openBinaryDatas.Contains(data))
            {
                openBinaryDatas.Remove(data);
                ClearUpOpenBinaryDatasAndEnableRomWatcher();
            }
        }

        private void ClearUpOpenBinaryDatasAndEnableRomWatcher()
        {
            if (!savingRom && !isExecutingProcess)
            {
                foreach (BinaryData d in openBinaryDatas.ToArray())
                {
                    if (!d.CanWrite)
                        openBinaryDatas.Remove(d);
                }

                if (openBinaryDatas.Count == 0)
                    General.EnableRomWatcher();
            }
        }

        private RomVersion GetNewRomVersion()
        {
            var v = new RomVersion();
            v = PatchNewRomVersion(v);
            return v;
        }

        private RomVersion PatchNewRomVersion(RomVersion v)
        {
            v.Version = Assembly.GetEntryAssembly().GetName().Version;
            v.DevelopmentStage = Conversions.ToInteger(Resources.DevelopmentStage);
            v.DevelopmentBuild = Conversions.ToInteger(Resources.DevelopmentBuild);
            return v;
        }

        // M a i n   F e a t u r e s

        public void LoadPlugins()
        {
            string pluginsPath = Path.Combine(Publics.General.MyDataPath, "Plugins");
            if (Directory.Exists(pluginsPath))
            {
                Publics.General.PluginManager.LoadPlugins(pluginsPath);
            }
        }

        public void SetOtherStatusInfos(string text, Color foreColor)
        {
            OtherStatusInfosChanged?.Invoke(new SM64_ROM_Manager.EventArguments.OtherStatusInfosChangedEventArgs(text, foreColor));
        }

        public async Task<bool> SearchForUpdates(bool searchHidden)
        {
            if (await CanAccessUpdateServer())
            {
                var gui = new UpdateClientGUI(updateClient);
                gui.UseHiddenSearch = searchHidden;
                gui.UpdateInteractive(mainForm);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CheckCommandLineArgs()
        {
            string fileToOpen = null;
            foreach (var arg in Environment.GetCommandLineArgs())
            {
                if ((arg ?? "") == (Application.ExecutablePath ?? ""))
                    continue;
                switch (arg)
                {
                    default:
                        {
                            if (fileToOpen is null)
                                fileToOpen = arg;
                            break;
                        }
                }
            }

            if (fileToOpen is object)
            {
                var switchExpr = Path.GetExtension(fileToOpen).ToLower();
                switch (switchExpr)
                {
                    case ".z64":
                        {
                            OpenRom(fileToOpen);
                            break;
                        }
                }
            }
        }

        public Task WaitWhileSavingRom()
        {
            var t = new Task(() => { while (savingRom) { } });
            t.Start();
            return t;
        }

        public void LaunchRom()
        {
            SM64_ROM_Manager.General.LaunchRom(RomManager);
        }

        public bool AllowSavingRom()
        {
            if (TextManagerController.IsTextOverLimit())
            {
                MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_TextsOverLimit, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_TextsOverLimit_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool SaveRom()
        {
            if (AllowSavingRom())
            {
                RomSaving?.Invoke();
                StatusText = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Status_SavingRom;
                savingRom = true;
                General.SaveRom(RomManager);
                savingRom = false;
                StatusText = string.Empty;
                RomSaved?.Invoke();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DoesRomManagerNeedToSave()
        {
            if (RomManager is null)
            {
                return false;
            }
            else
            {
                return RomManager.NeedToSave;
            }
        }

        public bool OpenRom()
        {
            bool ret = false;
            var ofd_SM64RM_LoadROM = new OpenFileDialog() { Filter = "SM64 ROMs (*.z64)|*.z64" };
            var lastFiles = Settings.RecentFiles.RecentROMs;
            if (lastFiles.Count > 0)
            {
                ofd_SM64RM_LoadROM.InitialDirectory = Path.GetDirectoryName(lastFiles[0]);
            }

            if (ofd_SM64RM_LoadROM.ShowDialog() == DialogResult.OK)
            {
                ret = OpenRom(ofd_SM64RM_LoadROM.FileName);
            }

            return ret;
        }

        public bool OpenRom(string Romfile)
        {
            bool success = false;

            if (!loadRecentROM)
            {

#if !DEBUG
                try
                {
#endif

                var romFileInfo = new FileInfo(Romfile);
                var newrommgr = new RomManager(Romfile);
                StatusText = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Status_Checking;
                if (romFileInfo.Length == 8 * 1024 * 1024)
                {
                    if (MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_PrepaireRom, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_PrepaireRom_Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                    {
                        throw new RomCompatiblityException("Rom Length is incompatible!");
                    }
                    else
                        newrommgr.WritingNewProgramVersion += RomManager_WritingNewRomVersion;
                }

                if (!newrommgr.CheckROM())
                {
                    throw new RomCompatiblityException("Rom Check was false!");
                }
                else if (newrommgr.IsSM64EditorMode)
                {
                    throw new RomCompatiblityException(SM64_ROM_Manager.My.Resources.Form_Main_Resources.Exception_RomWasUsedBySM64E);
                }
                
                newrommgr.WritingNewProgramVersion -= RomManager_WritingNewRomVersion;

                loadRecentROM = true;
                Publics.Publics.AddRecentFile(Settings.RecentFiles.RecentROMs, Romfile);
                Publics.Publics.MergeRecentFiles(Settings.RecentFiles.RecentROMs);
                RecentFilesChanged?.Invoke();
                SetRomMgr(newrommgr);
                RomManager.LoadRom();
                CreateRomWatcherForCurrentRom();
                success = true;

#if !DEBUG
                }
                catch (RomCompatiblityException ex)
                {
                    MessageBoxEx.Show(ex.Message, "Loading ROM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ReadOnlyException ex)
                {
                    MessageBoxEx.Show(ex.Message, "Loading ROM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidMD5HashException ex)
                {
                    MessageBoxEx.Show(string.Format(Form_Main_Resources.MsgBox_InvalidRomHash, RomManager.SUPER_MARIO_64_U_MD5HASH), "Loading ROM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBoxEx.Show(Form_Main_Resources.MsgBox_UnknownErrorAtLoadingRom, Form_Main_Resources.MsgBox_UnknownErrorAtLoadingRom_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
#endif
                loadRecentROM = false;
                StatusText = string.Empty;
            }

            return success;
        }

        private void CreateRomWatcherForCurrentRom()
        {
            if (RomManager is object)
            {
                hasRomChanged = 0;
                SM64_ROM_Manager.General.RomWatcher = new FileSystemWatcher(Path.GetDirectoryName(RomManager.RomFile), Path.GetFileName(RomManager.RomFile)) { EnableRaisingEvents = true, SynchronizingObject = mainForm };
            }
            else
            {
                SM64_ROM_Manager.General.RomWatcher = null;
            }

            RomWatcher = SM64_ROM_Manager.General.RomWatcher;
        }

        public void CheckRomChanged()
        {
            if (hasRomChanged == 1)
            {
                var e = new SM64_ROM_Manager.EventArguments.RomChangesAvaiableEventArgs();
                RomChangesAvailable?.Invoke(e);
                if (e.Mute)
                {
                    hasRomChanged = 2;
                }
            }
        }

        public void ReloadRom()
        {
            OpenRom(RomManager.RomFile);
        }

        public void UpdateChecksum()
        {
            if (RomManager is object)
            {
                StatusText = "Calculating checksum ...";
                SM64_ROM_Manager.General.DisableRomWatcher();
                SM64_ROM_Manager.General.PatchClass.UpdateChecksum(RomManager.RomFile);
                SM64_ROM_Manager.General.EnableRomWatcher();
                StatusText = string.Empty;
            }
        }

        public void ConvertM64ToMidi()
        {
            var ofd = new CommonOpenFileDialog();
            CommonSaveFileDialog sfd;
            byte chunks = 2;
            ofd.Filters.Add(new CommonFileDialogFilter("M64 Sequences", "*.m64"));
            ofd.EnsureFileExists = true;
            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                sfd = new CommonSaveFileDialog();
                sfd.Filters.Add(new CommonFileDialogFilter("MIDI File [Experimental]", "*.mid"));
                sfd.Controls.Add(SM64_ROM_Manager.General.GetMidiExportDialogControls());
                if (sfd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    // Get chunks
                    var switchExpr = ((CommonFileDialogComboBox)sfd.Controls["MidiChunksSelector"]).SelectedIndex;
                    switch (switchExpr)
                    {
                        case 0:
                            {
                                chunks = 1;
                                break;
                            }

                        case 1:
                            {
                                chunks = 2;
                                break;
                            }
                    }

                    // Create midi file
                    var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);

                    // Convert .m64 to .midi
                    try
                    {
                        SM64_ROM_Manager.OutputMIDI.ConvertToMIDI(sfd.FileName, fs, chunks, true);
                        MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_ConvertToMidi_Succes, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_ConvertToMidi_Succes_Titel, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_ConvertToMidi_Failed + Constants.vbNewLine + ex.Message, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_ConvertToMidi_Failed_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        fs.Close();
                    }
                }
            }
        }

        public RomManager GetCurrentRomManager()
        {
            return RomManager;
        }

        public void OpenGlobalModelBankManager()
        {
            if (RomManager.GlobalModelBank is null)
            {
                RomManager.CreateNewGlobalModelBank();
            }

            var mgr = new ModelBankManager(RomManager, RomManager.GlobalModelBank);
            mgr.Show();
        }

        public void OpenGlobalBehaviorManager()
        {
            if (RomManager?.GlobalBehaviorBank is object)
            {
                var mgr = new BehaviorBankManager(RomManager.GlobalBehaviorBank, RomManager);
                mgr.Show();
            }
        }

        public void OpenCustomObjectsManager()
        {
            if (RomManager is object)
            {
                var mgr = new CustomObjectsManager(RomManager.CustomObjects, RomManager);
                mgr.Show();
            }
        }

        public void OpenCustomAsmCodes()
        {
            if (RomManager is object)
            {
                var mgr = new CustomAsmCodesManager(RomManager.GlobalCustomAsmBank, RomManager);
                mgr.Show();
            }
        }

        public void OpenPluginManager()
        {
            var frm = new SM64_ROM_Manager.PluginInstallerForm();
            frm.Show();
        }

        public void OpenHUDOptions()
        {
            var frmHUD = new SM64_ROM_Manager.HUDOptionsForm(RomManager);
            frmHUD.ShowDialog();
        }

        public bool IsGlobalBehaviorBankEnabled()
        {
            return RomManager.RomConfig.GlobalBehaviorBank.Enabled;
        }

        public void EnableGlobalBehaviorBank()
        {
            if (RomManager is object)
            {
                RomManager.RomConfig.GlobalBehaviorBank.Enable();
                RomManager.LoadGlobalBehaviorBank();
            }
        }

        public bool HasRomLoaded()
        {
            return RomManager is object;
        }

        public bool IsRomVersionCompatible()
        {
            if (RomManager is object)
                return RomManager.ProgramVersion > GetNewRomVersion();
            return true;
        }

        // T o o l s

        public void OpenTweakViewer()
        {
            if (!addedTweakViewerEvents)
            {
                TweakViewer.TweakBeforeApply += SM64_ROM_Manager.General.DisableRomWatcher;
                TweakViewer.TweakAfterApply += SM64_ROM_Manager.General.EnableRomWatcher;
                TweakViewer.TweakFailedApply += SM64_ROM_Manager.General.EnableRomWatcher;
                addedTweakViewerEvents = true;
            }

            var tweaks = new TweakViewer(RomManager);
            tweaks.Show();
        }

        public void OpenModelImporter()
        {
            var frm = new ModelImporterGUI.ModelImporter();
            frm.RomFile = RomManager?.RomFile;
            frm.Show();
        }

        public void OpenTrajectoryEditor()
        {
            var editor = new SM64_ROM_Manager.TrajectoryEditor(RomManager);
            editor.ShowDialog(mainForm);
        }

        public void OpenRgbEditor()
        {
            var editor = new SM64_ROM_Manager.RGBEditor(RomManager);
            editor.Show();
        }

        public void OpenCoinsEditor()
        {
            var frm = new SM64_ROM_Manager.Form_CoinsSettings(RomManager);
            frm.Show(mainForm);
        }

        public void OpenAbout()
        {
            var frm = new SM64_ROM_Manager.Form_About();
            frm.ShowDialog();
        }

        public void OpenTextConverter()
        {
            var frm = new SM64_ROM_Manager.Form_SM64TextConverter();
            frm.Show();
        }

        public void CallPublicHackingDocuments()
        {
            Process.Start("https://docs.google.com/document/d/1pSYR91UiMVKnP3PyvJiCdwRF5wNS_nZzMe-r2WPQUJk/edit?usp=sharing");
        }

        public async Task OpenTextureEditor()
        {
            // Load main levelscript because the segmented banks
            var lvlScriptMain = LevelEditor.Form_AreaEditor.LoadMainLevelscript(RomManager);
            await LevelEditor.Form_AreaEditor.ParseLevelscriptAndLoadSegmentedBanks(RomManager, lvlScriptMain);

            // Open Texture editor
            var cat = LevelEditor.Form_AreaEditor.GetOtherTexturesCategorie(RomManager);
            var frm = new LevelEditor.TextureEditor(RomManager, new[] { cat });
            frm.Show();
        }

        public void OpenStyleManager()
        {
            SM64_ROM_Manager.My.MyProject.Forms.Form_Stylemanager.Show();
        }

        public void OpenSettings()
        {
            var frm = new SM64_ROM_Manager.Form_Settings();
            frm.ShowDialog();
        }

        public void OpenApplyPPFDialog()
        {
            var patcher = new ApplyPPF.ApplyPPFDialog(RomManager?.RomFile, string.Empty);
            patcher.ShowDialog(mainForm);
        }

        public void OpenItemBoxContentEditor()
        {
            SM64_ROM_Manager.ItemBoxContentEditor ibce = (SM64_ROM_Manager.ItemBoxContentEditor)SM64_ROM_Manager.General.GetFirstOpenForm<ItemBoxContentEditor>();
            if (ibce is null)
            {
                ibce = new SM64_ROM_Manager.ItemBoxContentEditor(RomManager);
            }

            ibce.Show();
        }

        public void OpenStarPositionEditor()
        {
            SM64_ROM_Manager.StarPositionEditor spo = (SM64_ROM_Manager.StarPositionEditor)SM64_ROM_Manager.General.GetFirstOpenForm<StarPositionEditor>();
            if (spo is null)
            {
                spo = new SM64_ROM_Manager.StarPositionEditor(RomManager);
            }

            spo.Show();
        }

        public void OpenObjectBankDataEditor()
        {
            var editor = new ObjectBankDataEditor(RomManager.RomConfig.ObjectBankInfoData);
            var removedObds = new List<SM64Lib.Objects.ObjectBanks.Data.ObjectBankData>();
            var changedObds = new List<SM64Lib.Objects.ObjectBanks.Data.ObjectBankData>();

            // Watch for removed and changed Obds
            editor.RemovedObjectBankData += obd => removedObds.Add(obd);
            editor.ChangedObjectBankDataCommand += obd => { if (!changedObds.Contains(obd)) changedObds.Add(obd); };

            // Show Editor
            editor.ShowDialog();

            // Set removed and changed Obds in Levels to Null
            void setObdsToNull(List<SM64Lib.Objects.ObjectBanks.Data.ObjectBankData> dic, bool remove)
            {
                if (RomManager is object)
                {
                    foreach (Level lvl in RomManager.Levels)
                    {
                        foreach (byte bankID in lvl.LoadedObjectBanks.Keys.ToArray())
                        {
                            foreach (SM64Lib.Objects.ObjectBanks.Data.ObjectBankData obd in dic)
                            {
                                var curObd = lvl.GetObjectBankData(bankID);
                                if (curObd == obd)
                                {
                                    lvl.ChangeObjectBankData(bankID, remove ? null : curObd);
                                }
                            }
                        }
                    }
                }
            };
            setObdsToNull(removedObds, true);
            setObdsToNull(changedObds, false);

            // Raise events
            ObjectBankDataChanged?.Invoke();
        }

        private void OpenScriptDumper<TCmd, eTypes>(BaseCommandCollection<TCmd, eTypes> script) where TCmd : BaseCommand<eTypes>
        {
            var frm = new SM64_ROM_Manager.ScriptDumper<TCmd, eTypes>();
            frm.Script = script;
            frm.Show();
        }

        public void OpenLocalObjectBankManager(int levelIndex)
        {
            Level lvl = GetLevelAndArea(levelIndex).level;

            if (lvl is RMLevel)
            {
                //void objectCountChanged(object sender, EventArgs e) => 
                //    LevelCustomObjectsCountChanged?.Invoke(new EventArguments.LevelEventArgs(levelIndex, lvl.LevelID));

                var mgr = new ModelBankManager(RomManager, lvl.LocalObjectBank);
                //mgr.ObjectAdded += objectCountChanged;
                //mgr.ObjectRemoved += objectCountChanged;
                mgr.Show();
            }
        }

        private LevelInfoDataTabelList.Level OpenLevelSelectDialog()
        {
            var frm = new SM64_ROM_Manager.LevelSelectorDialog(RomManager);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                return frm.SelectedLevel;
            }
            else
            {
                return null;
            }
        }

        private string OpenValueInputDialog(string titel, string input)
        {
            var inputDialog = new SM64_ROM_Manager.ValueInputDialog();
            inputDialog.InfoLabel.Text = titel;
            inputDialog.ValueTextBox.Text = input;
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                return inputDialog.ValueTextBox.Text;
            }
            else
            {
                return null;
            }
        }

        public void OpenFeatureRequestDialog()
        {
            var frm = new UserRequestDialog(UserRequestLayout.LoadFrom(Path.Combine(Publics.General.MyUserRequestsPath, "FeatureRequest.json")));
            frm.Show();
        }

        public void OpenBugReportDialog()
        {
            var frm = new UserRequestDialog(UserRequestLayout.LoadFrom(Path.Combine(Publics.General.MyUserRequestsPath, "BugReport.json")));
            frm.Show();
        }

        public void OpenTranslationSubmition()
        {
            var frm = new UserRequestDialog(UserRequestLayout.LoadFrom(Path.Combine(Publics.General.MyUserRequestsPath, "SubmitTranslation.json")));
            frm.Show();
        }

        public void OpenThankYouPage()
        {
            const string webAddress = "https://pilzinsel64.com/thank-you/";
            Process.Start(webAddress);
        }

        private void RomWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (RomManager is object && (RomManager.RomFile ?? "") == (e.FullPath ?? "") && hasRomChanged != 2)
            {
                hasRomChanged = 1;
                RomFileChanged?.Invoke();
            }
        }

        private void RomWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            if (RomManager is object && (e.OldFullPath ?? "") == (RomManager.RomFile ?? ""))
            {
                RomManager.RomFile = e.FullPath;
                RomFileRenamed?.Invoke();
            }
        }

        private void RomWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if (RomManager is object && (e.FullPath ?? "") == (RomManager.RomFile ?? ""))
            {
                RomFileDeleted?.Invoke();
            }
        }

        // G e n e r a l

        public void SetGameName(string name)
        {
            name = name.Trim();
            RomManager.GameName = name;
        }

        public string GetGameName()
        {
            return RomManager.GameName;
        }

        public double GetRomFileSize()
        {
            return new FileInfo(RomManager.RomFile).Length / (double)1024 / 1024;
        }

        public object IsChangingTab()
        {
            var e = new SM64_ROM_Manager.EventArguments.EnabledEventArgs(false);
            RequestIsChangingTab?.Invoke(e);
            return e.Enabled;
        }

        public void CheckToOpenThankYouPage()
        {
            var myVersion = new Version(Application.ProductVersion);
            if (Settings.General.LastThankYouPageSeen is null || Settings.General.LastThankYouPageSeen < myVersion)
            {
                if (!Debugger.IsAttached)
                    OpenThankYouPage();
                Settings.General.LastThankYouPageSeen = myVersion;
            }
        }

        public (string fileName, bool available) GetRomConfigInfo()
        {
            var fp = RomManager.GetRomConfigFilePath();
            var fn = Path.GetFileName(fp);
            var a = RomManager.IsNewROM || File.Exists(fp);
            return (fn, a);
        }

        public RomSpaceInfo GetRomSpaceInfo()
        {
            return RomManager?.GetRomSpaceInfo();
        }

        // L e v e l   M a n a g e r

        private (Level level, LevelArea area) GetLevelAndArea(int levelIndex, int areaIndex = -1)
        {
            var lvl = RomManager.Levels.ElementAtOrDefault(levelIndex);
            var area = lvl?.Areas?.ElementAtOrDefault(areaIndex);
            return (lvl, area);
        }

        private IEnumerable<SM64_ROM_Manager.LevelEditor.Form_AreaEditor> OpenAreaEditors
        {
            get
            {
                var list = new List<SM64_ROM_Manager.LevelEditor.Form_AreaEditor>();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is SM64_ROM_Manager.LevelEditor.Form_AreaEditor)
                    {
                        list.Add((SM64_ROM_Manager.LevelEditor.Form_AreaEditor)frm);
                    }
                }

                return list;
            }
        }

        private object GetAreaEditor(Level level)
        {
            return OpenAreaEditors.FirstOrDefault(n => n.CLevel == level);
        }

        public void OpenAreaEditor(int levelIndex, int areaIndex)
        {
            if (levelIndex >= 0 && areaIndex >= 0)
            {
                var curLvl = RomManager.Levels[levelIndex];
                LevelEditor.Form_AreaEditor openAreaEditor = (LevelEditor.Form_AreaEditor)GetAreaEditor(curLvl);
                if (openAreaEditor is null)
                {
                    var curArea = curLvl.Areas.ElementAtOrDefault(areaIndex);
                    var frm = new LevelEditor.Form_AreaEditor(RomManager, curLvl, Conversions.ToByte(curLvl.LevelID), curArea == null ? default : curArea.AreaID);
                    frm.Show();
                }
                else
                {
                    openAreaEditor.BringToFront();
                }
            }
        }

        public void SetUpLevelDefaultStartPosition(int levelIndex)
        {
            bool ShowX = false;
            bool ShowY = false;
            bool ShowZ = false;
            int XVal = 0;
            int YVal = 0;
            int ZVal = 0;
            string Title = "";
            var lvl = RomManager.Levels[levelIndex];
            var dsp = lvl.GetDefaultPositionCmd();
            if (dsp is object)
            {
                // Edit all values
                ShowX = true;
                ShowY = true;
                ShowZ = true;

                // Show current values (get from command)
                var curPos = clDefaultPosition.GetPosition(dsp);
                XVal = Conversions.ToInteger(curPos.X);
                YVal = Conversions.ToInteger(curPos.Y);
                ZVal = Conversions.ToInteger(curPos.Z);

                // Set Titel
                Title = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Text_StartPosition;

                // Open Dialog
                var frm = new SM64_ROM_Manager.Form_SetUpPoint(Title, ShowX, ShowY, ShowZ, XVal, YVal, ZVal);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Get new values
                    XVal = TextValueConverter.ValueFromText(Conversions.ToString(frm.IntegerInput_X.Value));
                    YVal = TextValueConverter.ValueFromText(Conversions.ToString(frm.IntegerInput_Y.Value));
                    ZVal = TextValueConverter.ValueFromText(Conversions.ToString(frm.IntegerInput_Z.Value));

                    // Set new values
                    curPos.X = XVal;
                    curPos.Y = YVal;
                    curPos.Z = ZVal;

                    // Set new values to command
                    clDefaultPosition.SetPosition(dsp, curPos);
                    SetLevelscriptNeedToSave(lvl);
                }
            }
        }

        public void AddLevelAreaSpecialItem(int levelIndex, int areaIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            var sb = new SpecialBox();
            void method()
            {
                lvl.area.SpecialBoxes.Add(sb);
                this.SetLevelscriptNeedToSave(lvl.level);
                LevelSpecialItemAdded?.Invoke(new SM64_ROM_Manager.EventArguments.SpecialItemEventArgs(lvl.area.SpecialBoxes.IndexOf(sb), levelIndex, areaIndex));
            };
            AddEditLevelAreaSpecialItem(sb, method);
        }

        public void EditLevelAreaSpecialItem(int levelIndex, int areaIndex, int sbIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            var sb = lvl.area.SpecialBoxes.ElementAt(sbIndex);
            if (lvl.area is object && sb is object)
            {
                void method()
                {
                    this.SetLevelscriptNeedToSave(lvl.level);
                    LevelSpecialItemChanged?.Invoke(new SM64_ROM_Manager.EventArguments.SpecialItemEventArgs(sbIndex, levelIndex, areaIndex));
                };
                AddEditLevelAreaSpecialItem(sb, method);
            }
        }

        private void AddEditLevelAreaSpecialItem(SpecialBox sb, Action finishMethod)
        {
            var frm = new SM64_ROM_Manager.Form_AddSpecialItem(ref sb);

            // Set what happens after the form has close
            frm.FormClosed += (_, __) =>
            {
                var newType = default(global::SM64Lib.Levels.SpecialBoxType);
                if (frm.DialogResult == global::System.Windows.Forms.DialogResult.OK)
                {
                    switch (true)
                    {
                        case object _ when frm.CheckBoxX_Water.Checked:
                            {
                                newType = global::SM64Lib.Levels.SpecialBoxType.Water;
                                break;
                            }

                        case object _ when frm.CheckBoxX_Mist.Checked:
                            {
                                newType = global::SM64Lib.Levels.SpecialBoxType.Mist;
                                break;
                            }

                        case object _ when frm.CheckBoxX_ToxicHaze.Checked:
                            {
                                newType = global::SM64Lib.Levels.SpecialBoxType.ToxicHaze;
                                break;
                            }
                    }

                    // Reorder Positions in BoxData
                    global::SM64_ROM_Manager.General.ReorderBoxDataPositions(sb);

                    // Define new Type for SpecialBox
                    sb.Type = newType;

                    // Invoke finish method
                    finishMethod();
                }
            };

            // Show the Form
            frm.Show();
        }

        public (SpecialBoxType boxType, WaterType waterType, short x1, short z1, short x2, short z2, short y, short scale, byte alpha, bool invisibleWater) GetSpecialBoxInfos(int levelIndex, int areaIndex, int sbIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            var sb = lvl.area.SpecialBoxes[sbIndex];
            return (sb.Type, sb.WaterType, sb.X1, sb.Z1, sb.X2, sb.Z2, sb.Y, sb.Scale, sb.Alpha, sb.InvisibleWater);
        }

        private void LoadLegacyObjectBankData()
        {
            var p = Path.Combine(Publics.General.MyDataPath, @"Other\Object Bank Data.json");
            if (!RomManager.RomConfig.ObjectBankInfoData.Any())
                RomManager?.RomConfig.ObjectBankInfoData.Load(p);
        }

        public ObjectBankDataListCollection GetObjectBankData()
        {
            LoadLegacyObjectBankData();
            return RomManager?.RomConfig.ObjectBankInfoData;
        }

        public int GetLevelsCount()
        {
            return RomManager.Levels.Count;
        }

        public IEnumerable<ushort> GetUsedLevelIDs()
        {
            return RomManager.Levels.Select(n => n.LevelID);
        }

        public string HasLevelCustomName(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex).level;
            return this.HasLevelCustomName(lvl.LevelID);
        }

        public string HasLevelCustomName(ushort levelID)
        {
            return Conversions.ToString(!string.IsNullOrEmpty(RomManager.RomConfig.GetLevelConfig(levelID)?.LevelName));
        }

        public string GetLevelCustomName(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex).level;
            return this.GetLevelCustomName(lvl.LevelID);
        }

        public string GetLevelCustomName(ushort levelID)
        {
            return RomManager.RomConfig.GetLevelConfig(levelID).LevelName;
        }

        public void SetLevelCustomName(ushort levelID, string newName)
        {
            RomManager.RomConfig.GetLevelConfig(levelID).LevelName = newName;
        }

        public string GetLevelName(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex).level;
            return this.GetLevelName(lvl.LevelID);
        }

        public string GetLevelName(ushort levelID)
        {
            return RomManager.LevelInfoData.FirstOrDefault(n => n.ID == levelID).Name;
        }

        public byte[] GetUsedLevelAreaIDs(ushort levelIndex)
        {
            return RomManager.Levels.ElementAtOrDefault(levelIndex)?.Areas?.Select(n => n.AreaID).ToArray();
        }

        public void AddNewLevel()
        {
            var selLvl = OpenLevelSelectDialog();
            if (selLvl is object)
            {
                var lvl = RomManager.AddLevel(Conversions.ToByte(selLvl.ID));
                RomManager.Levels.Last().ActSelector = selLvl.Type == LevelInfoDataTabelList.LevelTypes.Level;
                SetLevelscriptNeedToSave(lvl);
                SetLevelBank0x0ENeedToSave(lvl);
                LevelAdded?.Invoke(new SM64_ROM_Manager.EventArguments.LevelEventArgs(RomManager.Levels.IndexOf(lvl), lvl.LevelID));
            }
        }

        public void AddNewArea(int levelIndex)
        {
            var curLevel = GetLevelAndArea(levelIndex).level;
            var nextid = Publics.General.GetNextAreaID(curLevel);

            // Convert a model
            if (nextid.isAnyFree)
            {
                byte areaID = Conversions.ToByte(nextid.newID ?? 0);
                var res = PublicFunctions.GetModelViaModelConverter(false, false, inputsKey: SM64_ROM_Manager.General.GetKeyForConvertAreaModel(RomManager.GameName, Conversions.ToShort(curLevel.LevelID), areaID));
                if (res is object)
                {
                    // Create new area
                    var tArea = new RMLevelArea(areaID);
                    tArea.AreaModel = res?.mdl;
                    tArea.ScrollingTextures.AddRange(res?.mdl.Fast3DBuffer.ConvertResult.ScrollingCommands.ToArray());
                    RomManager.RomConfig.GetLevelConfig(curLevel.LevelID).GetLevelAreaConfig(areaID).ScrollingNames = res?.mdl.Fast3DBuffer.ConvertResult.ScrollingNames;

                    // Add area to level
                    curLevel.Areas.Add(tArea);
                    this.SetLevelscriptNeedToSave(curLevel);
                    this.SetLevelBank0x0ENeedToSave(curLevel);
                    LevelAreaAdded?.Invoke(new SM64_ROM_Manager.EventArguments.LevelAreaEventArgs(levelIndex, curLevel.Areas.IndexOf(tArea), tArea.AreaID));
                }
            }
            else
            {
                MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_MaxCountAreasReached, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_MaxCountAreasReached_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool ChangeAreaID(int levelIndex, int areaIndex, byte newID)
        {
            var setted = false;
            var lva = GetLevelAndArea(levelIndex, areaIndex);
            var isUsed = false;
            
            foreach (var area in lva.level.Areas)
            {
                if (!isUsed && area.AreaID == newID)
                    isUsed = true;
            }

            if (!isUsed)
            {
                if (lva.area is object)
                    lva.area.AreaID = newID;

                LevelAreaIDChanged?.Invoke(new EventArguments.LevelAreaEventArgs(levelIndex, areaIndex, newID));
                setted = true;
            }

            return setted;
        }

        public byte GetLevelAreaID(int levelIndex, int areaIndex)
        {
            return GetLevelAndArea(levelIndex, areaIndex).area?.AreaID ?? default;
        }

        public byte GetLevelAreasCount(int levelIndex)
        {
            return Conversions.ToByte(GetLevelAndArea(levelIndex, -1).level.Areas.Count);
        }

        public void RemoveLevelArea(int levelIndex, int areaIndex)
        {
            if (levelIndex >= 0 && areaIndex >= 0)
            {
                if (MessageBoxEx.Show("You are going to remove the selected area. Continue?", "Remove Area", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var lvl = GetLevelAndArea(levelIndex, areaIndex);
                    lvl.level.Areas.RemoveAt(areaIndex);
                    this.SetLevelscriptNeedToSave(lvl.level);
                    this.SetLevelBank0x0ENeedToSave(lvl.level);
                    LevelAreaRemoved?.Invoke(new SM64_ROM_Manager.EventArguments.LevelAreaEventArgs(levelIndex, areaIndex, lvl.area.AreaID));
                }
            }
        }

        private long GetLengthOfLevelAreas(Level level, int ExcaptIndex = -1)
        {
            int val = 0;
            int tIndex = 0;
            foreach (LevelArea a in level.Areas)
            {
                if (tIndex != ExcaptIndex)
                {
                    val += a.AreaModel.Length;
                    tIndex += 1;
                }
            }

            return val;
        }

        private void SetLevelscriptNeedToSave(Level lvl)
        {
            lvl.NeedToSaveLevelscript = true;
        }

        private void SetLevelBank0x0ENeedToSave(Level lvl)
        {
            lvl.NeedToSaveBanks0E = true;
        }

        public void SetLevelSettings(int levelIndex, byte defStartPosDestAreaID, short defStartPosDestRotation, bool enableActSelector, bool enableHardcodedCamera, int objBank0x0C, int objBank0x0D, int objBank0x0E, bool enableGlobalObjectBank, bool enableLocalObjectBank, bool enableShowMsg, byte showMsgDialogID)
        {
            var lvl = GetLevelAndArea(levelIndex, -1).level;

            // Default Start Position
            clDefaultPosition.SetAreaID(lvl.GetDefaultPositionCmd(), defStartPosDestAreaID);
            clDefaultPosition.SetRotation(lvl.GetDefaultPositionCmd(), defStartPosDestRotation);

            // Act Selector
            lvl.ActSelector = enableActSelector;

            // Hardcoded Camera
            lvl.HardcodedCameraSettings = enableHardcodedCamera;

            // Object Banks
            lvl.ChangeObjectBankData(0xC, RomManager.RomConfig.ObjectBankInfoData[Conversions.ToByte(0xC)].ElementAtOrDefault(objBank0x0C - 1));
            lvl.ChangeObjectBankData(0xD, RomManager.RomConfig.ObjectBankInfoData[Conversions.ToByte(0xD)].ElementAtOrDefault(objBank0x0D - 1));
            lvl.ChangeObjectBankData(0x9, RomManager.RomConfig.ObjectBankInfoData[Conversions.ToByte(0x9)].ElementAtOrDefault(enableGlobalObjectBank || enableLocalObjectBank ? -1 : objBank0x0E - 1));
            lvl.EnableGlobalObjectBank = enableGlobalObjectBank;
            lvl.EnableLocalObjectBank = enableLocalObjectBank;

            SetLevelscriptNeedToSave(lvl);
        }

        public void SetLevelBackgroundMode(int levelIndex, int mode)
        {
            var lvl = GetLevelAndArea(levelIndex, -1).level;

            switch (mode)
            {
                case 0: // Game Image
                    {
                        lvl.Background.Enabled = true;
                        lvl.Background.IsCustom = false;
                        break;
                    }

                //case 1: // Custom Image
                //    {
                //        lvl.Background.Enabled = true;
                //        lvl.Background.IsCustom = true;
                //        lvl.Background.GetImage();
                //        break;
                //    }

                case 2: // Disable
                    {
                        lvl.Background.Enabled = false;
                        lvl.Background.IsCustom = false;
                        break;
                    }
            }

            this.SetLevelscriptNeedToSave(lvl);
        }

        public void SetLevelBackgroundID(int levelIndex, BackgroundIDs id)
        {
            var lvl = GetLevelAndArea(levelIndex, -1).level;
            lvl.Background.ID = id;
            lvl.Background.Enabled = true;
            lvl.Background.IsCustom = false;
            this.SetLevelscriptNeedToSave(lvl);
        }

        public void SetLevelAreaBackgroundType(int levelIndex, int areaIndex, AreaBGs typ)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            lvl.area.Background.Type = typ;
            this.SetLevelscriptNeedToSave(lvl.level);
            LevelAreaBackgroundModeChanged?.Invoke(new SM64_ROM_Manager.EventArguments.LevelAreaBackgroundModeChangedEventArgs(typ, lvl.area.Background.Color));
        }

        public void SetLevelAreaBackgroundColor(int levelIndex, int areaIndex, Color color)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            lvl.area.Background.Type = AreaBGs.Color;
            lvl.area.Background.Color = color;
            this.SetLevelscriptNeedToSave(lvl.level);
        }

        public (AreaBGs typ, Color color) GetLevelAreaBackgroundInfo(int levelIndex, int areaIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            return (lvl.area.Background.Type, lvl.area.Background.Color);
        }

        public void LoadLevelCustomBackgroundImage(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, -1).level;
            var bg = lvl.Background;
            var ofd = new OpenFileDialog();
            ofd.Filter = "All supported Image files|*.png;*.jpeg;*.jpg;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream sImg = new MemoryStream(File.ReadAllBytes(ofd.FileName));
                var tBGImage = new Bitmap(sImg);
                if (tBGImage.Size != new Size(248, 248) & tBGImage.Size != new Size(256, 256))
                {
                    MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_InvalidBgImageSize, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_InvalidBgImageSize_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bg.SetImage(tBGImage);
                    bg.ID = BackgroundIDs.Desert;
                    bg.IsCustom = true;
                    bg.Enabled = true;
                    this.SetLevelscriptNeedToSave(lvl);
                    LevelBackgroundImageChanged?.Invoke(new SM64_ROM_Manager.EventArguments.LevelBackgroundImageChangedEventArgs(bg.ID, bg.GetImage()));
                }

                sImg.Close();
            }
        }

        public void SaveLevelAreaSettings(int levelIndex, int areaIndex, TerrainTypes terrainTypes, byte musicID, EnvironmentEffects environmentEffects, CameraPresets cameraPrset, bool enable2DCamera, bool enableShowMsg, byte showMsgDialogID, AreaReverbLevel reverbLevel)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            var area = lvl.area;
            area.TerrainType = terrainTypes;
            area.BGMusic = musicID;
            area.Geolayout.EnvironmentEffect = environmentEffects;
            area.Geolayout.CameraPreset = cameraPrset;
            area.Enable2DCamera = enable2DCamera;
            area.ShowMessage.Enabled = enableShowMsg;
            area.ShowMessage.DialogID = showMsgDialogID;
            if (area is RMLevelArea)
                ((RMLevelArea)area).ReverbLevel = reverbLevel;
            this.SetLevelscriptNeedToSave(lvl.level);
        }

        public void ImportLevelAreaModel(int levelIndex, int areaIndex, bool importVisualMap, bool importCollision)
        {
            var levelarea = GetLevelAndArea(levelIndex, areaIndex);
            if (levelarea.level is object && levelarea.area is object && RomManager is object)
            {
                var area = levelarea.area;
                var res = PublicFunctions.GetModelViaModelConverter(loadVisualMapAsDefault: importVisualMap, loadCollisionAsDefault: importCollision, inputsKey: SM64_ROM_Manager.General.GetKeyForConvertAreaModel(RomManager.GameName, Conversions.ToShort(levelarea.level.LevelID), area.AreaID));
                if (res != null)
                {
                    if (res.Value.hasCollision && res.Value.hasVisualMap)
                    {
                        var OldAreaModel = area.AreaModel;
                        area.AreaModel = res?.mdl;
                    }
                    else if (res.Value.hasCollision)
                    {
                        var OldAreaModel = area.AreaModel;
                        area.AreaModel.Collision = res?.mdl.Collision;
                    }
                    else if (res.Value.hasVisualMap)
                    {
                        var OldAreaModel = area.AreaModel;
                        area.AreaModel = res?.mdl;
                        area.AreaModel.Collision = OldAreaModel.Collision;
                    }

                    if (res.Value.hasVisualMap)
                    {
                        area.ScrollingTextures.Clear();
                        area.ScrollingTextures.AddRange(area.AreaModel.Fast3DBuffer.ConvertResult.ScrollingCommands.ToArray());
                        RomManager.RomConfig.GetLevelConfig(levelarea.level.LevelID).GetLevelAreaConfig(area.AreaID).ScrollingNames = res?.mdl.Fast3DBuffer.ConvertResult.ScrollingNames;
                    }

                    area.SetSegmentedBanks(RomManager);
                    this.SetLevelBank0x0ENeedToSave(levelarea.level);
                }
            }
        }

        public int GetSpecialBoxesCount(int levelIndex, int areaIndex)
        {
            var area = GetLevelAndArea(levelIndex, areaIndex).area;
            return area.SpecialBoxes.Count;
        }

        public void RemoveLevelSpecialBox(int levelIndex, int areaIndex, int sbIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            lvl.area.SpecialBoxes.RemoveAt(sbIndex);
            this.SetLevelscriptNeedToSave(lvl.level);
            LevelSpecialItemRemoved?.Invoke(new SM64_ROM_Manager.EventArguments.SpecialItemEventArgs(sbIndex, levelIndex, areaIndex));
        }

        public bool DoesCameraPresetProvide2DCamera(CameraPresets preset)
        {
            return (int)preset == 0xE;
        }

        public void CopyLevelLastRomOffset(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex);
            Clipboard.SetText(lvl.level.LastRomOffset.ToString("X8"));
        }

        public void OpenScrollingTextureEditor(int levelIndex, int areaIndex)
        {
            if (levelIndex > -1 && areaIndex > -1)
            {
                var lvl = GetLevelAndArea(levelIndex, areaIndex);
                var areaConf = RomManager.RomConfig.GetLevelConfig(lvl.level.LevelID).GetLevelAreaConfig(lvl.area.AreaID);
                var editor = new SM64_ROM_Manager.ScrollTexEditor(lvl.area, areaConf);
                void scrollTextCountChanged(object sender, EventArgs e) => LevelAreaScrollingTextureCountChanged?.Invoke(new SM64_ROM_Manager.EventArguments.LevelAreaEventArgs(levelIndex, areaIndex, lvl.area.AreaID));
                void setNeedToSave(object sender, EventArgs e) => this.SetLevelscriptNeedToSave(lvl.level);
                editor.ScrollTexAdded += scrollTextCountChanged;
                editor.ScrollTexRemoved += scrollTextCountChanged;
                editor.ScrollTexAdded += setNeedToSave;
                editor.ScrollTexRemoved += setNeedToSave;
                editor.ScrollTexChanged += setNeedToSave;
                editor.Show();
            }
        }

        public void OpenScriptDumperWithLevelscript(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex);
            if (lvl.level is object)
            {
                OpenScriptDumper(lvl.level.Levelscript);
            }
        }

        public void OpenScriptDumperWithLevelAreaScript(int levelIndex, int areaIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            if (lvl.area is object)
            {
                OpenScriptDumper(lvl.area.Levelscript);
            }
        }

        public void OpenScriptDumperWithLevelAreaGeolayoutScript(int levelIndex, int areaIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            if (lvl.area is object)
            {
                OpenScriptDumper(lvl.area.Geolayout.Geolayoutscript);
            }
        }

        public bool HasLevelBank0x19(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex);
            return lvl.level?.Bank0x19 is object;
        }        

        public async Task ExportLevelVisualMap(int levelIndex, int areaIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            if (lvl.area is object)
            {
                StatusText = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Status_LoadingModel;
                var mdl = await SM64_ROM_Manager.General.LoadAreaVisualMapAsObject3DAsync(RomManager, lvl.area);
                this.ExportLevelModel(levelIndex, areaIndex, mdl);
            }
        }

        public async Task ExportLevelCollision(int levelIndex, int areaIndex)
        {
            var lvl = GetLevelAndArea(levelIndex, areaIndex);
            if (lvl.area is object)
            {
                StatusText = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Status_LoadingModel;
                var mdl = await lvl.area.AreaModel.Collision.ToObject3DAsync();
                ExportLevelModel(levelIndex, areaIndex, mdl);
            }
        }

        private void ExportLevelModel(int levelIndex, int areaIndex, Object3D mdl)
        {
            StatusText = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Status_ExportingModel;
            Publics.Publics.ExportModel(mdl, Publics.Publics.GetExporterModuleFromID(Settings.FileParser.FileExporterModule));
            StatusText = string.Empty;
        }

        public (byte areaID, TerrainTypes terrainType, byte bgMusic, CameraPresets camPreset, EnvironmentEffects envEffect, bool enable2DCam, AreaBGs bgType, Color bgColor, bool enableShowMsg, byte showMsgDialogID, AreaReverbLevel reverbLevel) GetLevelAreaSettings(int levelIndex, int areaIndex)
        {
            var area = GetLevelAndArea(levelIndex, areaIndex).area;

            // Set Area Segmented Banks
            area.SetSegmentedBanks(RomManager);

            // Get Reverb level
            AreaReverbLevel reverbLevel;
            if (area is RMLevelArea)
                reverbLevel = ((RMLevelArea)area).ReverbLevel;
            else
                reverbLevel = AreaReverbLevel.None;

            // Get Area Settings
            return (area.AreaID, area.TerrainType, area.BGMusic, area.Geolayout.CameraPreset, area.Geolayout.EnvironmentEffect, area.Enable2DCamera, area.Background.Type, area.Background.Color, area.ShowMessage.Enabled, area.ShowMessage.DialogID, reverbLevel);
        }

        public int GetLevelAreaScrollingTexturesCount(int levelIndex, int areaIndex)
        {
            var area = GetLevelAndArea(levelIndex, areaIndex).area;

            // Get Model Infos
            return area.ScrollingTextures.Count;
        }

        public void RemoveLevel(int levelIndex)
        {
            if (MessageBoxEx.Show("You are going to remove the selected level. Continue?", "Remove Area", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var infos = GetLevelAndArea(levelIndex);
                if (infos.level is object)
                {
                    RomManager.RemoveLevel(infos.level);
                    LevelRemoved?.Invoke(new SM64_ROM_Manager.EventArguments.LevelEventArgs(levelIndex, infos.level.LevelID));
                }
            }
        }

        public object GetLevelID(int levelIndex)
        {
            return GetLevelAndArea(levelIndex).level.LevelID;
        }

        public (bool enableActSelector, bool enableHardcodedCamera, bool hasDefStartPos, byte defStartPosAreaID, short defStartPosYRot, int bgMode, Image bgImage, BackgroundIDs bgOriginal, byte areasCount) GetLevelSettings(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex).level;
            var defPosCmd = lvl.GetDefaultPositionCmd();
            byte bgMode;
            Image bgImage = null;
            BackgroundIDs bgOriginal;
            var defPosAreaID = default(byte);
            var defPosYRot = default(short);
            lvl.SetSegmentedBanks(RomManager);
            if (!lvl.Background.Enabled)
            {
                bgMode = 2;
                bgOriginal = lvl.Background.ID;
            }
            else if (lvl.Background.IsCustom)
            {
                bgMode = 1;
                bgImage = lvl.Background.GetImage();
            }
            else
            {
                bgMode = 0;
            }

            bgOriginal = lvl.Background.ID;
            if (defPosCmd is object)
            {
                defPosAreaID = clDefaultPosition.GetAreaID(defPosCmd);
                defPosYRot = clDefaultPosition.GetRotation(defPosCmd);
            }

            return (lvl.ActSelector, lvl.HardcodedCameraSettings, defPosCmd is object, defPosAreaID, defPosYRot, bgMode, bgImage, bgOriginal, (byte)lvl.Areas.Count);
        }

        public (int objBank0x0C, int objBank0x0D, int objBank0x0E, bool enableGlobalObjectBank, bool enableLocalObjectBank) GetLevelObjectBankDataSettings(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex).level;
            return (
                RomManager.RomConfig.ObjectBankInfoData[Conversions.ToByte(0xC)].IndexOf(lvl.GetObjectBankData(0xC)) + 1,
                RomManager.RomConfig.ObjectBankInfoData[Conversions.ToByte(0xD)].IndexOf(lvl.GetObjectBankData(0xD)) + 1,
                RomManager.RomConfig.ObjectBankInfoData[Conversions.ToByte(0x9)].IndexOf(lvl.GetObjectBankData(0x9)) + 1,
                lvl.EnableGlobalObjectBank, lvl.EnableLocalObjectBank);
        }

        public void ChangeLevelID(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex).level;
            if (lvl is object)
            {
                var selLvl = OpenLevelSelectDialog();
                if (selLvl is object)
                {
                    if (RomManager.ChangeLevelID(lvl, selLvl.ID, selLvl.Type == LevelInfoDataTabelList.LevelTypes.Level))
                    {
                        this.SetLevelscriptNeedToSave(lvl);
                    }

                    LevelIDChanged?.Invoke(new SM64_ROM_Manager.EventArguments.LevelEventArgs(levelIndex, lvl.LevelID));
                }
            }
        }

        public void ChangeLevelCustomName(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex).level;
            if (lvl is object)
            {
                string curName;
                if (Conversions.ToBoolean(this.HasLevelCustomName(lvl.LevelID)))
                {
                    curName = this.GetLevelCustomName(lvl.LevelID);
                }
                else
                {
                    curName = string.Empty;
                }

                string newName = OpenValueInputDialog("Levelname", curName);
                if ((newName ?? "") != (curName ?? ""))
                {
                    this.SetLevelCustomName(lvl.LevelID, newName);
                    LevelCustomNameChanged?.Invoke(new SM64_ROM_Manager.EventArguments.LevelEventArgs(levelIndex, lvl.LevelID));
                }
            }
        }

        public void ImportLevel()
        {
            ImportLevelAreaPrivate();
        }

        public void ImportLevelArea(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex).level;
            this.ImportLevelAreaPrivate(lvl);
        }

        private void ImportLevelAreaPrivate(Level destLevel = null)
        {
            bool addAreasOnly = destLevel is object;
            var addedFuncs = new List<PluginFunction>();
            var allFuncs = Publics.General.PluginManager.GetFunctions("levelmanager.importlevels.getilevelmanager");
            var cofd = new CommonOpenFileDialog();
            cofd.Filters.Add(new CommonFileDialogFilter("SM64 ROMs (*.z64)", "*.z64"));
            var cb = new CommonFileDialogComboBox();
            cb.Items.Add(new CommonFileDialogComboBoxItem("SM64 RM/Editor"));
            foreach (PluginFunction pf in allFuncs)
            {
                if (pf.Params.Count() >= 1 && pf.Params[0] is string)
                {
                    addedFuncs.Add(pf);
                    cb.Items.Add(new CommonFileDialogComboBoxItem(Conversions.ToString(pf.Params[0])));
                }
            }

            cofd.Controls.Add(cb);
            cb.SelectedIndex = 0;
            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ILevelManager lvlmgr = null;
                var switchExpr = cb.SelectedIndex;
                switch (switchExpr)
                {
                    case 0:
                        {
                            lvlmgr = new LevelManager();
                            break;
                        }

                    default:
                        {
                            lvlmgr = (ILevelManager)addedFuncs[cb.SelectedIndex - 1].InvokeGet();
                            break;
                        }
                }

                var frm = new SM64_ROM_Manager.ImportLevelDialog(RomManager, destLevel, cofd.FileName, lvlmgr);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (!addAreasOnly)
                    {
                        destLevel = frm.LevelCopy;
                    }

                    SetLevelscriptNeedToSave(destLevel);
                    SetLevelBank0x0ENeedToSave(destLevel);
                    if (addAreasOnly)
                    {
                        foreach (LevelArea area in frm.AreasCopy)
                            LevelAreaAdded?.Invoke(new SM64_ROM_Manager.EventArguments.LevelAreaEventArgs(RomManager.Levels.IndexOf(destLevel), destLevel.Areas.IndexOf(area), area.AreaID));
                    }
                    else
                    {
                        LevelAdded?.Invoke(new SM64_ROM_Manager.EventArguments.LevelEventArgs(RomManager.Levels.IndexOf(destLevel), destLevel.LevelID));
                    }
                }
            }
        }

        public void SetLevelBank0x19Length(int levelIndex)
        {
            var lvl = GetLevelAndArea(levelIndex).level;
            if (lvl is object)
            {
                var frm = new SM64_ROM_Manager.ValueInputDialog();
                frm.InfoLabel.Text = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Text_NewLength + ":";
                frm.ValueTextBox.Text = TextValueConverter.TextFromValue((long)lvl.Bank0x19.Length);
                bool @continue = true;
                uint minSize = RomManagerSettings.DefaultLevelscriptSize;
                while (@continue)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        int newVal = TextValueConverter.ValueFromText(frm.ValueTextBox.Text);
                        if (newVal < minSize)
                        {
                            MessageBoxEx.Show(string.Format(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_InvalidBankSize, minSize.ToString("X")), SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_InvalidBankSize_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            lvl.Bank0x19.Length = newVal;
                            this.SetLevelscriptNeedToSave(lvl);
                            this.SetLevelBank0x0ENeedToSave(lvl);
                            MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_BankSizeChangedSuccess, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_BankSizeChangedSuccess_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            @continue = false;
                        }
                    }
                    else
                    {
                        @continue = false;
                    }
                }
            }
        }

        public void OpenHexEditorForFast3DBuffer(int levelIndex, int areaIndex)
        {
            LevelArea area = GetLevelAndArea(levelIndex, areaIndex).area;
            if (area is object)
            {
                var arg = area.AreaModel.Fast3DBuffer.ToArray();
                General.OpenHexEditor(ref arg);
                area.AreaModel.Fast3DBuffer.SetLength(arg.Length);
                area.AreaModel.Fast3DBuffer.Write(arg, 0, arg.Length);
            }
        }

        // M u s i c   M a n a g e r

        private (string fileName, int filterIndex, bool hasExitedWithOK) OpenFileDialog_SelectMusicSequenceFile()
        {
            var ofd = new OpenFileDialog() { Filter = "M64 Sequence (*.m64)|*.m64" };
            bool isOK = (ofd.ShowDialog() == DialogResult.OK);
            return (ofd.FileName, ofd.FilterIndex, isOK);
        }

        public void ExtractMusicSequence(int index)
        {
            var curMusic = GetMusicSequenceByIndex(index);
            var sfd = new CommonSaveFileDialog();
            sfd.Filters.Add(new CommonFileDialogFilter("M64 Sequence", ".m64"));
            sfd.Filters.Add(new CommonFileDialogFilter("MIDI File", ".mid"));
            sfd.DefaultFileName = curMusic.Name;
            sfd.Controls.Add(SM64_ROM_Manager.General.GetMidiExportDialogControls());
            sfd.FileTypeChanged += (sender, e) =>
            {
                CommonSaveFileDialog dialog = (CommonSaveFileDialog)sender;
                int filterIndex = dialog.SelectedFileTypeIndex;
                var c = dialog.Controls["MidiChunksSelector"];
                c.Visible = filterIndex == 2;
                dialog.DefaultExtension = dialog.Filters[dialog.SelectedFileTypeIndex - 1].Extensions.First();
            };
            if ((int)sfd.ShowDialog() == (int)DialogResult.OK)
            {
                StatusText = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Status_ExportingSequence;
                var switchExpr = sfd.SelectedFileTypeIndex;
                switch (switchExpr)
                {
                    case 1: // .m64
                        try
                        {
                            var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                            fs.Write(curMusic.BinaryData, 0, curMusic.BinaryData.Length);
                            fs.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_ErrorSavingSequence, SM64_ROM_Manager.My.Resources.Global_Resources.Text_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 2: // .midi
                        byte chunks = 2;
                        var switchExpr1 = ((CommonFileDialogComboBox)sfd.Controls["MidiChunksSelector"]).SelectedIndex;
                        switch (switchExpr1)
                        {
                            case 0:
                                chunks = 1;
                                break;
                            case 1:
                                chunks = 2;
                                break;
                        }
                        // Create input stream
                        var ms = new MemoryStream(curMusic.BinaryData);
                        ms.Position = 0;

                        // Convert .m64 to .midi
                        try
                        {
                            SM64_ROM_Manager.OutputMIDI.ConvertToMIDI(sfd.FileName, ms, chunks, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_ExportToMidi_Failed + Constants.vbNewLine + ex.Message, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_ExportToMidi_Failed_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            ms.Close();
                        }

                        break;
                }

                StatusText = "";
            }
        }

        public void ReplaceMusicSequence(int index)
        {
            var res = OpenFileDialog_SelectMusicSequenceFile();
            if (res.hasExitedWithOK)
            {
                StatusText = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Status_ImportingSequence;
                var curMusic = RomManager.MusicList[index];
                ImportMusicFileToSequence(curMusic, res.fileName, res.filterIndex);
                MusicSequenceChanged?.Invoke(new SM64_ROM_Manager.EventArguments.MusicSequenceEventArgs(index, curMusic));
            }

            StatusText = string.Empty;
        }

        public void AddNewMusicSequence()
        {
            var switchExpr = RomManager?.MusicList.Count;
            switch (switchExpr)
            {
                case var @case when @case == 127:
                    {
                        if (MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_LimitSequenceCountReached, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_LimitSequenceCountReached_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }

                        break;
                    }

                case object _ when switchExpr >= 255:
                    {
                        MessageBoxEx.Show(SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_MaxSequenceCountReached, SM64_ROM_Manager.My.Resources.Form_Main_Resources.MsgBox_MaxSequenceCountReached_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
            }

            var res = OpenFileDialog_SelectMusicSequenceFile();
            if (res.hasExitedWithOK)
            {
                MusicSequence curMusic = null;
                StatusText = SM64_ROM_Manager.My.Resources.Form_Main_Resources.Status_CreatingNewSequence;
                curMusic = new MusicSequence();
                RomManager.MusicList.Add(curMusic);
                ImportMusicFileToSequence(curMusic, res.fileName, res.filterIndex);
                MusicSequenceAdded?.Invoke(new SM64_ROM_Manager.EventArguments.MusicSequenceEventArgs(RomManager.MusicList.IndexOf(curMusic), curMusic));
            }

            StatusText = string.Empty;
        }

        private void ImportMusicFileToSequence(MusicSequence sequence, string fileName, int mode)
        {
            switch (mode)
            {
                case 1:
                    {
                        var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        sequence.BinaryData = new byte[(int)(fs.Length - 1) + 1];
                        fs.Read(sequence.BinaryData, 0, Conversions.ToInteger(fs.Length));
                        fs.Close();
                        break;
                    }
            }

            sequence.Name = Path.GetFileNameWithoutExtension(fileName);
            sequence.InstrumentSets.Sets.Clear();
            sequence.InstrumentSets.Sets.Add(37);
            RomManager.MusicList.NeedToSaveSequences = true;
            RomManager.MusicList.NeedToSaveSequenceNames = true;
            RomManager.MusicList.NeedToSaveNInsts = true;
        }

        public void RemoveMusicSequence(int index)
        {
            if (index >= 0)
            {
                var sequence = GetMusicSequenceByIndex(index);

                // Remove sequence
                RomManager.MusicList.RemoveAt(index);

                // Fix Music in Levels
                foreach (Level lvl in RomManager.Levels)
                {
                    foreach (LevelArea a in lvl.Areas)
                    {
                        if (a.BGMusic == index)
                        {
                            while (a.BGMusic >= RomManager.MusicList.Count)
                                a.BGMusic -= 1;
                        }
                        else if (a.BGMusic > index)
                        {
                            a.BGMusic -= 1;
                        }
                    }
                }

                RomManager.MusicList.NeedToSaveSequences = true;
                RomManager.MusicList.NeedToSaveSequenceNames = true;
                RomManager.MusicList.NeedToSaveNInsts = true;
                MusicSequenceRemoved?.Invoke(new SM64_ROM_Manager.EventArguments.MusicSequenceEventArgs(index, sequence));
            }
        }

        public MusicSequence GetMusicSequenceByIndex(int index)
        {
            return RomManager.MusicList.ElementAtOrDefault(index);
        }

        public void EditMusicSequenceInHexEditor(int index)
        {
            var sequence = GetMusicSequenceByIndex(index);
            var argbuffer = sequence.BinaryData;
            General.OpenHexEditor(ref argbuffer);
            sequence.BinaryData = argbuffer;
            RomManager.MusicList.NeedToSaveSequences = true;
            MusicSequenceChanged?.Invoke(new SM64_ROM_Manager.EventArguments.MusicSequenceEventArgs(index, sequence));
        }

        public void SetMusicSequenceName(int index, string name)
        {
            var sequence = GetMusicSequenceByIndex(index);
            name = name.Trim();
            if (!string.IsNullOrEmpty(name) && sequence is object)
            {
                sequence.Name = name;
                RomManager.MusicList.NeedToSaveSequenceNames = true;
                MusicSequenceChanged?.Invoke(new SM64_ROM_Manager.EventArguments.MusicSequenceEventArgs(index, sequence));
            }
        }

        public void SetMusicSequenceInstrumentSet(int index, byte instSet)
        {
            var sequence = GetMusicSequenceByIndex(index);
            if (sequence is object)
            {
                sequence.InstrumentSets.Sets.Clear();
                sequence.InstrumentSets.Sets.Add(instSet);
                RomManager.MusicList.NeedToSaveNInsts = true;
                MusicSequenceChanged?.Invoke(new SM64_ROM_Manager.EventArguments.MusicSequenceEventArgs(index, sequence));
            }
        }

        public int GetMusicSeuenceCount()
        {
            return RomManager.MusicList.Count;
        }

        public (string name, byte instSet, int length) GetMusicSequenceInfos(int index)
        {
            var sequence = GetMusicSequenceByIndex(index);
            return (sequence.Name, sequence.InstrumentSets.Sets[0], sequence.Lenght);
        }
    }
}