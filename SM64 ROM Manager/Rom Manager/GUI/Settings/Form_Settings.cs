using System;
using global::System.Globalization;
using global::System.IO;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.SettingsManager;
using SM64_ROM_Manager.Plugins;

namespace SM64_ROM_Manager
{
    public partial class Form_Settings
    {
        public Form_Settings()
        {
            base.Load += Form_Settings_Load;
            base.FormClosing += Form_Settings_FormClosing;
            this.FormClosed += Form_Settings_FormClosed;
            InitializeComponent();
            base.UpdateAmbientColors();

            foreach (var lm in Publics.Publics.GetAllLoaderModules())
            {
                var item = new ComboItem()
                {
                    Text = lm.Name,
                    Tag = lm
                };
                ComboBoxEx_LoaderModule.Items.Add(item);
            }

            foreach (var lm in Publics.Publics.GetAllExporterModules())
            {
                var item = new ComboItem()
                {
                    Text = lm.Name,
                    Tag = lm
                };
                ComboBoxEx_ExporterModule.Items.Add(item);
            }

            foreach (string f in Directory.GetDirectories(Publics.General.MyDataPath + @"\Lang"))
            {
                string name = Path.GetFileName(f);
                var cult = new CultureInfo(name);
                if (cult is object)
                {
                    ComboBoxEx_Language.Items.Add(new ComboItem() { Text = cult.NativeName, Tag = cult });
                }
            }
            // Add english as long as it has no native translation, because it's the default
            var cultEnglish = new CultureInfo("en");
            ComboBoxEx_Language.Items.Add(new ComboItem() { Text = cultEnglish.NativeName, Tag = cultEnglish });
        }

        private bool finishedLoading = false;
        private readonly drsPwEnc.drsPwEnc crypter = new drsPwEnc.drsPwEnc();

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            LoadMySettings();
        }

        private void Form_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMySettings();
            PostSaveSettings();
        }

        private void LoadMySettings()
        {
            TextBoxX_EmulatorPatch.Text = Settings.General.EmulatorPath;
            SwitchButton_SearchUpdates.Value = Settings.Network.AutoUpdates;
            ComboBox_DefaultValueType.SelectedIndex = Settings.General.IntegerValueMode;
            ComboBox_AreaEditor_DefaultCameraMode.SelectedIndex = (int)Settings.AreaEditor.DefaultCameraMode;
            TextBoxX_HexEditorCustomPath.Text = Settings.General.HexEditMode.CustomPath;
            SwitchButton_UseLegacyCollisionDescriptions.Value = Settings.ModelConverter.UseLegacyCollisionDescriptions;
            SwitchButton_TMForceUppercase.Value = Settings.TextManager.ForceUpperCaseForActAndLevelNames;
            SwitchButton_AutoDetectStartEndQuotationMarks.Value = Settings.TextManager.AutoDetectStartEndQuotationMarks;
            switchButton_AutoFocusEditorTextBox.Value = Settings.TextManager.AutoFocusEditorTextBox;
            TextBoxX_ProxyUsr.Text = Settings.Network.ProxyUsername;
            TextBoxX_ProxyPwd.Text = string.IsNullOrEmpty(Settings.Network.ProxyPasswordEncrypted) ? string.Empty : crypter.DecryptData(Settings.Network.ProxyPasswordEncrypted);
            comboBoxEx_DefaultObjMoveMode.SelectedIndex = Settings.AreaEditor.EnableSlideMovementByDefaultForObjects ? 1 : 0;
            switchButton_UseInternalBrowser.Value = Settings.General.UseInternalBrowser;
            switchButton_ThankYouPageAfterUpdates.Value = Settings.General.OpenThankYouFormAfterUpdates;

            var curLoaderModule = Publics.Publics.GetLoaderModuleFromID(Settings.FileParser.FileLoaderModule);
            foreach (ComboItem item in ComboBoxEx_LoaderModule.Items)
            {
                if (item.Tag == curLoaderModule)
                    ComboBoxEx_LoaderModule.SelectedItem = item;
            }

            var curExporterModule = Publics.Publics.GetExporterModuleFromID(Settings.FileParser.FileExporterModule);
            foreach (ComboItem item in ComboBoxEx_ExporterModule.Items)
            {
                if (item.Tag == curExporterModule)
                    ComboBoxEx_ExporterModule.SelectedItem = item;
            }

            var switchExpr = Settings.General.ActionIfUpdatePatches;
            switch (switchExpr)
            {
                case DialogResult.None:
                    ComboBoxEx1.SelectedIndex = 0;
                    break;
                case DialogResult.Yes:
                    ComboBoxEx1.SelectedIndex = 1;
                    break;
                case DialogResult.No:
                    ComboBoxEx1.SelectedIndex = 2;
                    break;
            }

            {
                ComboBoxEx_HexEditorMode.Items.Clear();
                ComboBoxEx_HexEditorMode.Items.Add(new ComboItem("None") { Tag = HexEditModes.None });
                ComboBoxEx_HexEditorMode.Items.Add(new ComboItem("Custom Path") { Tag = HexEditModes.CustomHexEditor });

                foreach (var func in Publics.General.PluginManager.GetFunctions(FunctionCodes.GetHexEditorInstallationStatus))
                {
                    var status = (HexEditorStatus)func.InvokeGet();
                    if (status.IsInstalled)
                        ComboBoxEx_HexEditorMode.Items.Add(new ComboItem((string)func.Params[1]) { Tag = func.Params[0] });
                }

                var switchExpr1 = Settings.General.HexEditMode.Mode;
                switch (switchExpr1)
                {
                    case HexEditModes.None:
                        ComboBoxEx_HexEditorMode.SelectedIndex = 0;
                        break;
                    case HexEditModes.CustomHexEditor:
                        ComboBoxEx_HexEditorMode.SelectedIndex = 1;
                        break;
                    case HexEditModes.Plugin:
                        foreach (ComboItem item in ComboBoxEx_HexEditorMode.Items)
                        {
                            if (item.Tag is string && (string)item.Tag == Settings.General.HexEditMode.PluginCode)
                                ComboBoxEx_HexEditorMode.SelectedItem = item;
                        }
                        break;
                }

                if (ComboBoxEx_HexEditorMode.SelectedIndex == -1)
                    ComboBoxEx_HexEditorMode.SelectedIndex = 0;
            }

            foreach (ComboItem item in ComboBoxEx_Language.Items)
            {
                if (item.Tag is null)
                {
                    if (string.IsNullOrEmpty(Settings.General.Language))
                        ComboBoxEx_Language.SelectedIndex = 0;
                }
                else if ((((CultureInfo)item.Tag).Name ?? "") == (Settings.General.Language ?? ""))
                    ComboBoxEx_Language.SelectedItem = item;
            }

            var switchExpr2 = Settings.General.AutoScaleMode;
            switch (switchExpr2)
            {
                case AutoScaleMode.None:
                    ComboBoxEx_AutoScaleMode.SelectedIndex = 0;
                    break;
                case AutoScaleMode.Dpi:
                    ComboBoxEx_AutoScaleMode.SelectedIndex = 1;
                    break;
                case AutoScaleMode.Font:
                    ComboBoxEx_AutoScaleMode.SelectedIndex = 2;
                    break;
            }

            var switchExpr3 = Settings.General.RomChangedNotification;
            switch (switchExpr3)
            {
                case NotificationMode.Off:
                    ComboBoxEx_NotifyOnRomChanges.SelectedIndex = 0;
                    break;
                case NotificationMode.Infobox:
                    ComboBoxEx_NotifyOnRomChanges.SelectedIndex = 1;
                    break;
                case NotificationMode.Popup:
                    ComboBoxEx_NotifyOnRomChanges.SelectedIndex = 2;
                    break;
            }

            var switchExpr4 = Settings.Network.MinimumUpdateChannel;
            switch (switchExpr4)
            {
                case Updating.Channels.Alpha:
                    ComboBoxEx_UpdateLevel.SelectedIndex = 2;
                    break;
                case Updating.Channels.Beta:
                    ComboBoxEx_UpdateLevel.SelectedIndex = 1;
                    break;
                case Updating.Channels.Stable:
                    ComboBoxEx_UpdateLevel.SelectedIndex = 0;
                    break;
            }

            switch (Settings.General.RecalcChecksumBehavior)
            {
                case SM64Lib.RecalcChecksumBehavior.Never:
                    comboBoxEx_RecalcChecksumBehavior.SelectedIndex = 0;
                    break;
                case SM64Lib.RecalcChecksumBehavior.Always:
                    comboBoxEx_RecalcChecksumBehavior.SelectedIndex = 1;
                    break;
                case SM64Lib.RecalcChecksumBehavior.Auto:
                    comboBoxEx_RecalcChecksumBehavior.SelectedIndex = 2;
                    break;
            }

            SwitchButton_EnableOpenWith.Value = General.CheckForOpenWithContextMenuEntry();

            finishedLoading = true;
        }

        private void SaveMySettings()
        {
            Settings.General.EmulatorPath = TextBoxX_EmulatorPatch.Text.Trim();
            Settings.General.IntegerValueMode = ComboBox_DefaultValueType.SelectedIndex;
            Settings.Network.AutoUpdates = SwitchButton_SearchUpdates.Value;
            Settings.AreaEditor.DefaultCameraMode = (Pilz.Drawing.Drawing3D.OpenGLFactory.CameraN.CameraMode)ComboBox_AreaEditor_DefaultCameraMode.SelectedIndex;
            Settings.AreaEditor.EnableSlideMovementByDefaultForObjects = comboBoxEx_DefaultObjMoveMode.SelectedIndex == 1;
            Settings.FileParser.FileLoaderModule = Publics.Publics.GetLoaderIDFromModule((File3DLoaderModule)((ComboItem)ComboBoxEx_LoaderModule.SelectedItem).Tag);
            Settings.FileParser.FileExporterModule = Publics.Publics.GetExporterIDFromModule((File3DLoaderModule)((ComboItem)ComboBoxEx_ExporterModule.SelectedItem).Tag);
            Settings.ModelConverter.UseLegacyCollisionDescriptions = SwitchButton_UseLegacyCollisionDescriptions.Value;
            Settings.TextManager.ForceUpperCaseForActAndLevelNames = SwitchButton_TMForceUppercase.Value;
            Settings.TextManager.AutoDetectStartEndQuotationMarks = SwitchButton_AutoDetectStartEndQuotationMarks.Value;
            Settings.TextManager.AutoFocusEditorTextBox = switchButton_AutoFocusEditorTextBox.Value;
            Settings.Network.ProxyUsername = TextBoxX_ProxyUsr.Text.Trim();
            Settings.Network.ProxyPasswordEncrypted = string.IsNullOrEmpty(TextBoxX_ProxyPwd.Text) ? string.Empty : crypter.EncryptData(TextBoxX_ProxyPwd.Text);
            Settings.General.OpenThankYouFormAfterUpdates = switchButton_ThankYouPageAfterUpdates.Value;

            var switchExpr = ComboBoxEx1.SelectedIndex;
            switch (switchExpr)
            {
                case 0:
                    Settings.General.ActionIfUpdatePatches = DialogResult.None;
                    break;
                case 1:
                    Settings.General.ActionIfUpdatePatches = DialogResult.Yes;
                    break;
                case 2:
                    Settings.General.ActionIfUpdatePatches = DialogResult.No;
                    break;
            }

            {
                var selItem = (ComboItem)ComboBoxEx_HexEditorMode.SelectedItem;
                if (selItem.Tag is HexEditModes)
                {
                    switch ((HexEditModes)selItem.Tag)
                    {
                        case HexEditModes.None:
                            Settings.General.HexEditMode.Mode = HexEditModes.None;
                            Settings.General.HexEditMode.CustomPath = string.Empty;
                            break;
                        case HexEditModes.CustomHexEditor:
                            Settings.General.HexEditMode.Mode = HexEditModes.CustomHexEditor;
                            Settings.General.HexEditMode.CustomPath = TextBoxX_HexEditorCustomPath.Text.Trim();
                            break;
                    }
                    Settings.General.HexEditMode.PluginCode = string.Empty;
                }
                else if (selItem.Tag is string)
                {
                    Settings.General.HexEditMode.Mode = HexEditModes.Plugin;
                    Settings.General.HexEditMode.CustomPath = string.Empty;
                    Settings.General.HexEditMode.PluginCode = (string)selItem.Tag;
                }
            }

            var switchExpr2 = ComboBoxEx_AutoScaleMode.SelectedIndex;
            switch (switchExpr2)
            {
                case 0:
                    Settings.General.AutoScaleMode = AutoScaleMode.None;
                    break;
                case 1:
                    Settings.General.AutoScaleMode = AutoScaleMode.Dpi;
                    break;
                case 2:
                    Settings.General.AutoScaleMode = AutoScaleMode.Font;
                    break;
            }

            var switchExpr3 = ComboBoxEx_NotifyOnRomChanges.SelectedIndex;
            switch (switchExpr3)
            {
                case 0:
                    Settings.General.RomChangedNotification = NotificationMode.Off;
                    break;
                case 1:
                    Settings.General.RomChangedNotification = NotificationMode.Infobox;
                    break;
                case 2:
                    Settings.General.RomChangedNotification = NotificationMode.Popup;
                    break;
            }

            var switchExpr4 = ComboBoxEx_UpdateLevel.SelectedIndex;
            switch (switchExpr4)
            {
                case 0:
                    Settings.Network.MinimumUpdateChannel = Updating.Channels.Stable;
                    break;
                case 1:
                    Settings.Network.MinimumUpdateChannel = Updating.Channels.Beta;
                    break;
                case 2:
                    Settings.Network.MinimumUpdateChannel = Updating.Channels.Alpha;
                    break;
            }

            switch (comboBoxEx_RecalcChecksumBehavior.SelectedIndex)
            {
                case 0:
                    Settings.General.RecalcChecksumBehavior = SM64Lib.RecalcChecksumBehavior.Never;
                    break;
                case 1:
                    Settings.General.RecalcChecksumBehavior = SM64Lib.RecalcChecksumBehavior.Always;
                    break;
                case 2:
                    Settings.General.RecalcChecksumBehavior = SM64Lib.RecalcChecksumBehavior.Auto;
                    break;
            }

            ComboItem selLangItem = (ComboItem)ComboBoxEx_Language.SelectedItem;
            if (selLangItem.Tag is null)
            {
                Settings.General.Language = string.Empty;
            }
            else
            {
                CultureInfo cult = (CultureInfo)selLangItem.Tag;
                Settings.General.Language = cult.Name;
            }

            Publics.General.SetCurrentLanguageCulture(Settings.General.Language);
            foreach (Form from in Application.OpenForms)
                from.SetValue("AutoScaleMode", Settings.General.AutoScaleMode);
        }

        private void PostSaveSettings()
        {
            Publics.General.SetDefaultProxyAuthentification();
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            var frm = new LevelEditorInputManager();
            frm.ShowDialog();
        }

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            TextBoxX_EmulatorPatch.Text = "";
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            OpenExcuteableFile(TextBoxX_EmulatorPatch, "Select Emulator .exe File ...");
        }

        private void ButtonX4_Click(object sender, EventArgs e)
        {
            Settings.ResetSettings();
            LoadMySettings();
        }

        private void Form_Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.SaveSettings();
        }

        private void ComboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxX_HexEditorCustomPath.Enabled = ComboBoxEx_HexEditorMode.SelectedIndex == 1;
        }

        private void ButtonX5_Click(object sender, EventArgs e)
        {
            OpenExcuteableFile(TextBoxX_HexEditorCustomPath, "Select Hex Editor ...");
        }

        private void OpenExcuteableFile(TextBox dest, string titel)
        {
            var ofd = new OpenFileDialog() { Filter = "Executeables (*.exe)|*.exe", Title = titel };
            if (ofd.ShowDialog() == DialogResult.OK)
                dest.Text = ofd.FileName;
        }

        private void ComboBoxEx_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            EanbleRestartWarning();
        }

        private void EanbleRestartWarning()
        {
            if (finishedLoading)
                PictureBox_Warning.Visible = true;
        }

        private void ButtonX6_Click(object sender, EventArgs e)
        {
            ButtonX6.Enabled = false;
        }

        private void SwitchButton_EnableOpenWith_ValueChanged(object sender, EventArgs e)
        {
            if (finishedLoading)
            {
                if (SwitchButton_EnableOpenWith.Value)
                    General.AddOpenWithContextMenuEntry();
                else
                    General.RemoveOpenWithContextMenuEntry();
            }
        }
    }
}