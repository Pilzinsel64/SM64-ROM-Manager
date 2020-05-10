using System;
using System.Drawing;
using global::System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Controls;
using TaskDialog = DevComponents.DotNetBar.TaskDialog;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.EventArguments;
using global::SM64_ROM_Manager.My.Resources;
using global::SM64_ROM_Manager.SettingsManager;
using Z.Collections.Extensions;
using Z.Core.Extensions;
using System.Diagnostics;

namespace SM64_ROM_Manager
{
    public partial class MainForm
    {
        public MainForm()
        {
            Controller = new MainController(this);

            // G u i

            base.Load += Form_Main_Load;
            base.Shown += Form_Main_Shown;
            base.FormClosing += Form_Main_FormClosing;
            this.Activated += MainForm_Activated;
            // CheckForIllegalCrossThreadCalls = False

            // Stop drawing
            SuspendLayout();

            // Init Components
            InitializeComponent();

            // Set instance on Tabs   
            tabGeneral.Controller = Controller;
            tabLevelManager.Controller = Controller;
            tabTextManager.TMController = Controller.TextManagerController;
            tabMusicManager.Controller = Controller;

            // Set my style
            UpdateAmbientColors();
            UpdatedAmbientColors += (_, __)
                => Controller.TextManagerController.SendRequestReloadTextManagerLineColors();

            // Resume drawing
            ResumeLayout(false);
        }

        private MainController _Controller;

        private MainController Controller
        {
            get
            {
                return _Controller;
            }
            set
            {
                if (_Controller != null)
                {

                    // C o n t r o l l e r   E v e n t s

                    _Controller.StatusTextChanged -= Controller_StatusTextChanged;
                    _Controller.OtherStatusInfosChanged -= Controller_OtherStatusInfosChanged;
                    _Controller.RomLoaded -= Controller_RomLoaded;
                    _Controller.RecentFilesChanged -= Controller_RecentFilesChanged;
                    _Controller.RomFileRenamed -= Controller_RomFileRenamed;
                    _Controller.RomFileDeleted -= Controller_RomFileDeleted;
                    _Controller.RomChangesAvailable -= Controller_RomChangesAvaiable;
                    _Controller.RequestIsChangingTab -= Controller_RequestIsChangingTab;
                    _Controller.ErrorBecauseNoRomLoaded -= Controller_ErrorBecauseNoRomLoaded;
                }

                _Controller = value;
                if (_Controller != null)
                {
                    _Controller.StatusTextChanged += Controller_StatusTextChanged;
                    _Controller.OtherStatusInfosChanged += Controller_OtherStatusInfosChanged;
                    _Controller.RomLoaded += Controller_RomLoaded;
                    _Controller.RecentFilesChanged += Controller_RecentFilesChanged;
                    _Controller.RomFileRenamed += Controller_RomFileRenamed;
                    _Controller.RomFileDeleted += Controller_RomFileDeleted;
                    _Controller.RomChangesAvailable += Controller_RomChangesAvaiable;
                    _Controller.RequestIsChangingTab += Controller_RequestIsChangingTab;
                    _Controller.ErrorBecauseNoRomLoaded += Controller_ErrorBecauseNoRomLoaded;
                }
            }
        }

        private WarningBox _WarningBox_RomChanged;

        private WarningBox WarningBox_RomChanged
        {
            get
            {
                return _WarningBox_RomChanged;
            }
            set
            {
                if (_WarningBox_RomChanged != null)
                {
                }

                _WarningBox_RomChanged = value;
                if (_WarningBox_RomChanged != null)
                {
                }
            }
        }

        private bool finishedLoading = false;
        private bool changingTab = false;

        private void Controller_StatusTextChanged(StatusTextChangedEventArgs e)
        {
            LabelItem1.Text = e.NewStatus;
            Bar1.Refresh();
        }

        private void Controller_OtherStatusInfosChanged(OtherStatusInfosChangedEventArgs e)
        {
            LabelItem_OtherInfoText.Text = e.Text;
            LabelItem_OtherInfoText.ForeColor = e.ForeColor;
            Bar1.Refresh();
        }

        private void Controller_RomLoaded()
        {
            TabControl1.Enabled = true;
            ButtonItem_LaunchROM.Enabled = true;
            RefreshAppTitel();
            TabControl_Main_SelectedIndexChanged(TabControl1, null);
        }

        private void Controller_RecentFilesChanged()
        {
            LoadRecentROMs();
        }

        private void Controller_RomFileRenamed()
        {
            RefreshAppTitel();
        }

        private void Controller_RomFileDeleted()
        {
            if (MessageBoxEx.Show(Form_Main_Resources.MsgBox_RomRemoved, Form_Main_Resources.MsgBox_RomRemoved_Titel, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Close();
            }
        }

        private void Controller_RomChangesAvaiable(RomChangesAvaiableEventArgs e)
        {
            bool argmute = e.Mute;
            NotifyRomChangesAvailable(ref argmute);
            e.Mute = argmute;
        }

        private void Controller_RequestIsChangingTab(EnabledEventArgs e)
        {
            e.Enabled = changingTab;
        }

        private void Controller_ErrorBecauseNoRomLoaded()
        {
            Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
        }

        // R o m   C h a n g e s   N o t i f i c a t i o n

        private void NotifyRomChangesAvailable(ref bool mute)
        {
            var notifyMode = Settings.General.RomChangedNotification;
            bool showWarningBox = notifyMode == NotificationMode.Infobox;

            // Show popup
            if (notifyMode == NotificationMode.Popup && !mute)
            {
                var tdinfo = new TaskDialogInfo()
                {
                    Title = Form_Main_Resources.MsgBox_RomChanged_Title,
                    Header = Form_Main_Resources.MsgBox_RomChanged_Title,
                    TaskDialogIcon = eTaskDialogIcon.Information,
                    Text = Form_Main_Resources.MsgBox_RomChanged,
                    DialogButtons = eTaskDialogButton.Yes | eTaskDialogButton.No
                };
                switch (TaskDialog.Show(tdinfo))
                {
                    case eTaskDialogResult.Yes:
                        Controller.ReloadRom();
                        showWarningBox = false;
                        break;
                    default:
                        showWarningBox = true;
                        mute = true;
                        break;
                }
            }

            // Create WarningBox
            if (showWarningBox && WarningBox_RomChanged is null)
            {
                WarningBox_RomChanged = new WarningBox()
                {
                    Text = Form_Main_Resources.WarningBox_RomChanged_Text,
                    OptionsText = Form_Main_Resources.WarningBox_RomChanged_ReloadRom,
                    Dock = DockStyle.Top,
                    CloseButtonVisible = false
                };
                WarningBox_RomChanged.OptionsClick += WarningBox_RomChanged_OptionsClick;
                WarningBox_RomChanged.CloseClick += WarningBox_RomChanged_CloseClick;
            }

            // Set Warningbox size and add it
            if (WarningBox_RomChanged is object && showWarningBox)
            {
                if (!Panel1.Controls.Contains(WarningBox_RomChanged))
                {
                    Panel1.Controls.Add(WarningBox_RomChanged);
                }

                TabControl1.Top += WarningBox_RomChanged.Height;
                TabControl1.Height -= WarningBox_RomChanged.Height;
                WarningBox_RomChanged.Visible = true;
                WarningBox_RomChanged.BringToFront();
            }
        }

        private void WarningBox_RomChanged_CloseClick(object sender, EventArgs e)
        {
            WarningBox_RomChanged.Visible = false;
            TabControl1.Top -= WarningBox_RomChanged.Height;
            TabControl1.Height += WarningBox_RomChanged.Height;
        }

        private void WarningBox_RomChanged_OptionsClick(object sender, EventArgs e)
        {
            // Reload ROM
            Controller.ReloadRom();

            // Close WarningBox
            WarningBox_RomChanged_CloseClick(sender, e);
        }

        // R e c e n t   R O M s

        private void LoadRecentROMs()
        {
            tabGeneral.ItemPanel_RecentFiles.Items.Clear();
            var di_Open = new ButtonItem() { Text = Form_Main_Resources.Button_OpenRom, Image = MyIcons.icons8_open_folder_16px, ButtonStyle = eButtonStyle.ImageAndText }; // , .SymbolSet = eSymbolSet.Material, .Symbol = "58055", .SymbolColor = Color.FromArgb(215, 172, 106), .SymbolSize = 12
            di_Open.Click += MenuItem_OpenROM_Click;
            tabGeneral.ItemPanel_RecentFiles.Items.Add(di_Open);
            int cindex = 1;
            Publics.Publics.MergeRecentFiles(Settings.RecentFiles.RecentROMs);
            foreach (string r in Settings.RecentFiles.RecentROMs)
            {
                if (File.Exists(r))
                {
                    var bi = new ButtonItem();
                    bi.Text = Path.GetFileName(r);
                    bi.Tooltip = r;
                    bi.Image = Pilz.Win32.Internals.IconExtractor.ExtractIcon(r, true).ToBitmap();
                    bi.ButtonStyle = eButtonStyle.ImageAndText;
                    if (cindex == 1)
                        bi.BeginGroup = true;
                    bi.Click += MenuItem_RecentROMs_Click;
                    tabGeneral.ItemPanel_RecentFiles.Items.Add(bi);
                    cindex += 1;
                }
            }

            tabGeneral.ItemPanel_RecentFiles.Refresh();
        }

        private void MenuItem_OpenROM_Click(object sender, EventArgs e)
        {
            Controller.OpenRom();
        }

        private void MenuItem_RecentROMs_Click(object sender, EventArgs e)
        {
            if (Controller.OpenRom(Settings.RecentFiles.RecentROMs[Conversions.ToInteger(tabGeneral.ItemPanel_RecentFiles.Items.IndexOf((BaseItem)sender) - 1)]))
            {
                tabGeneral.Refresh();
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            RefreshAppTitel();
        }

        private void Form_Main_Shown(object sender, EventArgs e)
        {
            Controller.StatusText = Form_Main_Resources.Status_StartingUp;
            Panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            LoadRecentROMs();
            tabLevelManager.LoadObjectBankListBoxEntries();
            finishedLoading = true;
            Controller.StatusText = string.Empty;
            Controller.CheckCommandLineArgs();
            Controller.LoadPlugins();
            AddMyPluginCommands();
            Controller.CheckToOpenThankYouPage();
            if (Settings.Network.AutoUpdates)
            {
                Task t = Controller.SearchForUpdates(true);
            }
        }

        private void AddMyPluginCommands()
        {
            Pilz.Reflection.PluginSystem.PluginFunction lastFunc = null;
            bool isFirst = true;
            foreach (Pilz.Reflection.PluginSystem.PluginFunction func in Publics.General.PluginManager.GetFunctions("pluginmenu", "pluginmenur"))
            {
                var btn = new ButtonItem();
                if (lastFunc != func)
                {
                    lastFunc = func;
                }

                btn.Text = (string)func.Params[0];
                btn.Tag = func;
                btn.Click += (sender, e) =>
                {
                    Pilz.Reflection.PluginSystem.PluginFunction senderfunc = (Pilz.Reflection.PluginSystem.PluginFunction)((BaseItem)sender).Tag;
                    if (senderfunc.FunctionCode.EndsWith("r"))
                    {
                        senderfunc.Invoke(Controller.GetCurrentRomManager());
                    }
                    else
                    {
                        senderfunc.Invoke();
                    }
                };
                ButtonItem_Bar_Plugins.BeginGroup = isFirst;
                ButtonItem_Bar_Plugins.SubItems.Add(btn);
                isFirst = false;
            }

            Bar2.Refresh();
        }

        private void RefreshAppTitel()
        {
            var appversion = new Version(Application.ProductVersion);
            string romPathExt = !string.IsNullOrEmpty(Controller.Romfile) ? $" - \"{Path.GetFileName(Controller.Romfile)}\"" : "";
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

            base.Text = $"{Application.ProductName} ({versionText}){romPathExt}";
        }

        private void TabControl_Main_SelectedIndexChanged(object osender, TabStripTabChangedEventArgs e)
        {
            var sender = osender as DevComponents.DotNetBar.TabControl;
            changingTab = false;
            if (e is object)
            {
                switch (true)
                {
                    case object _ when e.NewTab == TabItem_TextManager:
                        {
                            Controller.TextManagerController.SendRequestReloadTextManagerLists();
                            break;
                        }

                    default:
                        {
                            if (e.OldTab == TabItem_TextManager)
                            {
                                Controller.SetOtherStatusInfos(string.Empty, default);
                            }

                            break;
                        }
                }
            }
        }

        private void MenuItem11_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private async void MenuItem_LaunchROM_Click(object sender, EventArgs e)
        {
            await Controller.WaitWhileSavingRom();
            Controller.LaunchRom();
        }

        private void ButtonItem12_Click(object sender, EventArgs e)
        {
            Controller.SaveRom();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Controller.DoesRomManagerNeedToSave())
            {
                var switchExpr = MessageBoxEx.Show(Form_Main_Resources.MsgBox_UnsavedChanges, Form_Main_Resources.MsgBox_UnsavedChanges_Title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (switchExpr)
                {
                    case DialogResult.Yes:
                        {
                            if (!Controller.SaveRom())
                            {
                                e.Cancel = true;
                            }

                            break;
                        }

                    case DialogResult.No:
                        {
                            break;
                        }

                    default:
                        {
                            e.Cancel = true;
                            return;
                        }
                }
            }
        }

        private void MenuItem_Settings_Click(object sender, EventArgs e)
        {
            Controller.OpenSettings();
        }

        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            Controller.OpenAbout();
        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            Controller.OpenTextConverter();
        }

        private void ButtonItem5_Click(object sender, EventArgs e)
        {
            Controller.OpenStyleManager();
        }

        private async void ButtonItem29_Click(object sender, EventArgs e)
        {
            if (!await Controller.SearchForUpdates(false))
            {
                Publics.General.ShowToastnotification(this, "Cannot connect to the update server.", eToastGlowColor.Red);
            }
        }

        private void SuperTabControl_Main_SelectedTabChanging(object sender, TabStripTabChangingEventArgs e)
        {
            changingTab = true;
            if (finishedLoading)
            {
                if (!Controller.HasRomManager && e.NewTab != TabItem_General)
                {
                    e.Cancel = true;
                    Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
                }
            }
        }

        private void ButtonItem23_Click(object sender, EventArgs e)
        {
            if (!Controller.HasRomManager)
            {
                Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
            }
            else
            {
                Controller.UpdateChecksum();
            }
        }

        private void ButtonItem_ModelImporter_Click(object sender, EventArgs e)
        {
            Controller.OpenModelImporter();
        }

        private void ButtonItem17_Click(object sender, EventArgs e)
        {
            if (!Controller.HasRomManager)
            {
                Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
            }
            else
            {
                Controller.OpenTweakViewer();
            }
        }

        private void ButtonItem_TrajectoryEditor_Click(object sender, EventArgs e)
        {
            if (!Controller.HasRomManager)
            {
                Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
            }
            else
            {
                Controller.OpenTrajectoryEditor();
            }
        }

        private void MenuItem20_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = TabItem_LevelManager;
        }

        private void MenuItem16_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = TabItem_TextManager;
        }

        private void MenuItem17_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = TabItem_MusicManager;
        }

        private void SuperTabControl_Main_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            e.Cancel = true;
            e.TabItem.Visible = false;
        }

        private void SuperTabControl_Main_ControlAdded(object sender, ControlEventArgs e)
        {
            TabControl1.SelectedTabIndex = TabControl1.Tabs.Count - 1;
        }

        private void ButtonItem15_Click(object sender, EventArgs e)
        {
            if (!Controller.HasRomManager)
            {
                Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
            }
            else
            {
                Controller.OpenRgbEditor();
            }
        }

        private void ButtonItem16_Click(object sender, EventArgs e)
        {
            if (!Controller.HasRomManager)
            {
                Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
            }
            else
            {
                Controller.OpenCoinsEditor();
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Controller.CheckRomChanged();
        }

        private void ButtonItem9_Click(object sender, EventArgs e)
        {
            Controller.OpenApplyPPFDialog();
        }

        private void ButtonItem14_Click(object sender, EventArgs e)
        {
            if (!Controller.HasRomManager)
            {
                Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
            }
            else
            {
                Controller.OpenItemBoxContentEditor();
            }
        }

        private void ButtonItem13_Click(object sender, EventArgs e)
        {
            if (!Controller.HasRomManager)
            {
                Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
            }
            else
            {
                Controller.OpenStarPositionEditor();
            }
        }

        private void ButtonItem_M64ToMidiConverter_Click(object sender, EventArgs e)
        {
            Controller.ConvertM64ToMidi();
        }

        private void ButtonItem19_Click(object sender, EventArgs e)
        {
            Controller.TextManagerController.OpenTextProfileEditor();
        }

        private void ButtonItem18_Click(object sender, EventArgs e)
        {
            if (!Controller.HasRomManager)
            {
                Publics.General.ShowToastnotification(this, Form_Main_Resources.Notify_ShouldLoadRomFirst, eToastGlowColor.Red);
            }
            else
            {
                Controller.OpenGlobalModelBankManager();
            }
        }

        private void ButtonItem_Bar_Plugins_ManagePlugins_Click(object sender, EventArgs e)
        {
            Controller.OpenPluginManager();
        }

        private void ButtonItem4_Click(object sender, EventArgs e)
        {
            Controller.OpenObjectBankDataEditor();
        }

        private void ButtonItem_BugReport_Click(object sender, EventArgs e)
        {
            Controller.OpenBugReportDialog();
        }

        private void ButtonItem_FeatureRequest_Click(object sender, EventArgs e)
        {
            Controller.OpenFeatureRequestDialog();
        }

        private void ButtonItem21_Click(object sender, EventArgs e)
        {
            Controller.OpenTranslationSubmition();
        }

        private void ButtonItem_Supporter_Click(object sender, EventArgs e)
        {
            Controller.OpenThankYouPage();
        }

        private void ButtonItem_HudOptions_Click(object sender, EventArgs e)
        {
            Controller.OpenHUDOptions();
        }

        private void ButtonItem_GlobalBehaviorBank_Click(object sender, EventArgs e)
        {
            Controller.OpenGlobalBehaviorManager();
        }

        private void ButtonItem_CustomObjects_Click(object sender, EventArgs e)
        {
            Controller.OpenCustomObjectsManager();
        }

        private async void ButtonItem_TextureEditor_Click(object sender, EventArgs e)
        {
            await Controller.OpenTextureEditor();
        }

        private void ButtonItem_HackingDocuments_Click(object sender, EventArgs e)
        {
            Controller.CallPublicHackingDocuments();
        }

        private void ButtonItem_GlobalAsmCodes_Click(object sender, EventArgs e)
        {
            Controller.OpenCustomAsmCodes();
        }
    }
}