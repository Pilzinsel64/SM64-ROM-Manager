using System;
using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using System.Windows.Forms;
using global::DevComponents.AdvTree;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::Microsoft.WindowsAPICodePack.Dialogs;
using Z.Collections.Extensions;
using System.Threading.Tasks;
using SM64_ROM_Manager.Updating.Administration.Discord;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class UpdateManagerWindow
    {

        // C o n s t a n t s

        private const string FILTER_UPDATEINFO_CONFIGURATION = "JSON (*.json)|*.json";
        private const string FILTER_UPDATEPROJECT = "Update-Info-Konfiguration (*.udic)|*.udic";
        private const string FILTER_UPDATEPACKAGE = "ZIP-Archiv (*.zip)|*.zip";

        // F i e l d s

        private string curProjectFilePath;
        private UpdateServerManager manager = null;
        private DiscordBot discordBot = null;

        // C o n s t r u c t o r s

        public UpdateManagerWindow()
        {
            this.Shown += UpdateManagerWindow_Shown;
            this.Load += UpdateManagerWindow_Load;
            this.FormClosing += UpdateManagerWindow_FormClosing;
            InitializeComponent();
            UpdateAmbientColors();
            SetEnabledUiControls(false);
        }

        // F e a t u r e s

        private void ProgressControls(bool enabled)
        {
            if (enabled)
                circularProgress1.Start();
            else
                circularProgress1.Stop();
            Enabled = !enabled;
        }

        private void SetEnabledUiControls(bool enabled, bool setProjectOptionsAlwayToTrue = false)
        {
            ribbonBar_Options.Enabled = enabled || setProjectOptionsAlwayToTrue;
            ButtonItem_SaveProject.Enabled = enabled || setProjectOptionsAlwayToTrue;
            ribbonBar_UpdateConfiguration.Enabled = enabled;
            ribbonPanel_Package.Enabled = enabled;
            SuperTabControl1.Enabled = enabled;
        }

        private async Task CreateNewProject(string filePath)
        {
            var oldProject = General.CurProject;
            General.CurProject = new UpdateProject();
            if (My.MyProject.Forms.UpdateServerInfoEditor.ShowDialog(this) == DialogResult.OK)
            {
                curProjectFilePath = filePath;
                SaveProject(curProjectFilePath);
                await LoadManager();
            }
            else
                General.CurProject = oldProject;
        }

        private async Task OpenProject(string filePath)
        {
            curProjectFilePath = filePath;
            General.CurProject = UpdateProject.Load(filePath);
            General.SetProxyConfig();
            await LoadManager();
        }

        private void SaveProject(string filePath)
        {
            General.CurProject.Save(filePath);
        }

        private async Task LoadManager()
        {
            bool hasError;
            ProgressControls(true);

            try
            {
                manager = new UpdateServerManager(General.CurProject.UpdateServerConfig);

                if (await manager.LoadInfoFromServer())
                {
                    await LoadPackageList();
                    LoadUpdateInstallerInfos();

                    hasError = false;
                }
                else
                    hasError = true;
            }
            catch (Exception)
            {
                hasError = true;
            }

            if (hasError)
            {
                MessageBoxEx.Show(this, "Ein Fehler ist aufgetreten beim laden des Servers.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetEnabledUiControls(false, true);
            }
            else
                SetEnabledUiControls(true);

            ProgressControls(false);
        }

        private async Task LoadPackageList()
        {
            ListViewItem firstItem = null;

            ProgressControls(true);
            ListViewEx_Packages.BeginUpdate();
            ListViewEx_Packages.Items.Clear();

            foreach (var pkgVersion in await manager.GetUpdatePackagesList())
            {
                var name = manager.GetPackageDescription(pkgVersion).name;
                var item = new ListViewItem(new string[]
                {
                    string.IsNullOrEmpty(name) ? "<Kein Titel>" : name,
                    pkgVersion.Version.ToString(),
                    pkgVersion.Channel.ToString(),
                    pkgVersion.Build.ToString(),
                    "Ja"
                })
                {
                    Tag = pkgVersion
                };

                ListViewEx_Packages.Items.Add(item);

                if (firstItem == null)
                    firstItem = item;
            }

            ListViewEx_Packages.EndUpdate();
            ProgressControls(false);

            if (firstItem is object)
                firstItem.Selected = true;
        }

        private void LoadUpdateInstallerInfos()
        {
            TextBoxX_UpdateInstallerDownloadUrl.Text = manager.UpdateInfo.UpdateInstallerLink;
        }

        private ApplicationVersion GetSelectedPackageVersion()
        {
            var items = ListViewEx_Packages.SelectedItems;
            if (items.Count > 0)
                return (ApplicationVersion)items[0].Tag;
            else
                return null;
        }

        private async Task<bool> UploadPackage(string filePath)
        {
            var success = false;
            var resVersion = EditApplicationVersion();

            if (!resVersion.canceled)
            {
                ProgressControls(true);
                if (await manager.UploadPackage(filePath, resVersion.newVersion))
                    success = true;
                ProgressControls(false);
            }

            return success;
        }

        private (ApplicationVersion newVersion, bool canceled) EditApplicationVersion()
        {
            return EditApplicationVersion(new ApplicationVersion());
        }

        private (ApplicationVersion newVersion, bool canceled) EditApplicationVersion(ApplicationVersion inputVersion)
        {
            var frm = new ApplicationVersionInput()
            {
                Version = inputVersion.Version,
                Channel = inputVersion.Channel,
                Build = inputVersion.Build
            };

            if (frm.ShowDialog(this) == DialogResult.OK)
                return (new ApplicationVersion(frm.Version, frm.Build, frm.Channel), false);
            else
                return (inputVersion, true);
        }

        private async Task<bool> DeletePackage(ApplicationVersion version)
        {
            ProgressControls(true);
            bool success = await manager.DeletePackage(version);
            ProgressControls(false);
            return success;
        }

        private async Task<bool> SaveInfoToServer()
        {
            ProgressControls(true);
            bool success = await manager.SaveInfoToServer();
            ProgressControls(false);
            return success;
        }

        private async Task<bool> ChangePackageVersion(ApplicationVersion version)
        {
            bool success = false;
            var (newVersion, canceled) = EditApplicationVersion(version);

            if (!canceled)
            {
                ProgressControls(true);
                success = await manager.ChangePackageVersion(version, newVersion);
                ProgressControls(false);
            }
            
            return success;
        }

        // G u i

        private void SuperTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
        }

        private void UpdateManagerWindow_Shown(object sender, EventArgs e)
        {
        }

        private async void UpdateManagerWindow_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                try
                {
                    await OpenProject(args[1]);
                }
                catch (Exception) { }
            }
        }

        private void UpdateManagerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (discordBot is object)
                discordBot.Stop();
        }

        private async void ButtonItem_NewProject_Click(object sender, EventArgs e)
        {
            var sfd_updateadministration_upa = new SaveFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (sfd_updateadministration_upa.ShowDialog(this) == DialogResult.OK)
            {
                await CreateNewProject(sfd_updateadministration_upa.FileName);
            }
        }

        private async void ButtonItem_OpenProject_Click(object sender, EventArgs e)
        {
            var ofd_updateadministration_upa = new OpenFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (ofd_updateadministration_upa.ShowDialog(this) == DialogResult.OK)
            {
                await OpenProject(ofd_updateadministration_upa.FileName);
            }
        }

        private void ButtonItem_SaveProject_Click(object sender, EventArgs e)
        {
            SaveProject(curProjectFilePath);
        }

        private async void ButtonItem_ProjectOptions_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.UpdateServerInfoEditor.ShowDialog(this);
            await LoadManager();
        }

        private async void ButtonItem_UploadUpdateConfiguration_Click(object sender, EventArgs e)
        {
            await SaveInfoToServer();
        }

        private async void ButtonItem_ExportUpdateConfiguration_Click(object sender, EventArgs e)
        {
            var sfd_UpdateAdministration_UpdateConfiguration = new SaveFileDialog()
            {
                Filter = FILTER_UPDATEINFO_CONFIGURATION
            };
            if (sfd_UpdateAdministration_UpdateConfiguration.ShowDialog(this) == DialogResult.OK)
                await manager.SaveInfoToFile(sfd_UpdateAdministration_UpdateConfiguration.FileName);
        }

        private void ButtonItem_OpenPackageCreationDialog_Click(object sender, EventArgs e)
        {
            var frm = new PackageCreationDialog();
            frm.Show();
        }

        private async void ButtonItem_CreateAndUploadPackage_Click(object sender, EventArgs e)
        {
            var frm = new PackageCreationDialog(true);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                if (await UploadPackage(frm.TempPackageFilePath))
                    await LoadPackageList();
            }
        }

        private async void ButtonItem_UploadExistingPackage_Click(object sender, EventArgs e)
        {
            var ofd_UpdateAdministration_UpdatePackage = new OpenFileDialog()
            {
                Filter = FILTER_UPDATEPACKAGE
            };

            if (ofd_UpdateAdministration_UpdatePackage.ShowDialog(this) == DialogResult.OK)
            {
                if(await UploadPackage(ofd_UpdateAdministration_UpdatePackage.FileName))
                    await LoadPackageList();
            }
        }

        private async void ButtonItem_RemovePackage_Click(object sender, EventArgs e)
        {
            var version = GetSelectedPackageVersion();
            if (await DeletePackage(version))
                await LoadPackageList();
        }

        private void TextBoxX_UpdateInstallerDownloadUrl_TextChanged(object sender, EventArgs e)
        {
            manager.UpdateInfo.UpdateInstallerLink = TextBoxX_UpdateInstallerDownloadUrl.Text.Trim();
        }

        private void ListViewEx_Packages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var anySelected = ListViewEx_Packages.SelectedItems.Count > 0;
            ribbonBar_Discord.Enabled = anySelected;
            ribbonBar_PackageManagement.Enabled = anySelected;
        }

        private void ButtonItem_PostMsgInDiscord_Click(object sender, EventArgs e)
        {
            if (discordBot == null)
                LoadDiscordBot();

            if (discordBot is object)
            {
                var version = GetSelectedPackageVersion();
                var pkg = manager.GetUpdatePackageInfo(version);
                var frm = new DiscordPostDialog(discordBot, pkg);
                frm.ShowDialog(this);
            }
            else
                MessageBoxEx.Show(this, "Offenbar ist ein Fehler ist aufgetreten beim Laden des Discord-Bots.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadDiscordBot()
        {
            if (discordBot is object)
                discordBot.Stop();

            discordBot = new DiscordBot(General.CurProject.DiscordBotConfig);

            bool hasLoaded = false;
            bool hasError = false;

            discordBot.GotReady += (sender, e) => hasLoaded = true;
            discordBot.LoggedMsg += (sender, msg, isError) => 
            {
                if (isError)
                    hasError = true;
            };

            discordBot.Start();

            ProgressControls(true);
            while (!hasLoaded && !hasError)
                Application.DoEvents();
            ProgressControls(false);

            if (hasError)
                discordBot = null;
        }

        private async void ButtonItem_ChangeVersion_Click(object sender, EventArgs e)
        {
            var version = GetSelectedPackageVersion();
            if (await ChangePackageVersion(version))
                await LoadPackageList();
        }

        private void ButtonItem_EditDescription_Click(object sender, EventArgs e)
        {
            var version = GetSelectedPackageVersion();
            var desc = manager.GetPackageDescription(version);

            var frm = new PackageDescriptionEditor()
            {
                Titel = desc.name,
                Description = desc.description,
                DescriptionType = desc.descriptionType
            };

            if (frm.ShowDialog(this) == DialogResult.OK)
                manager.SetPackageDescription(version, frm.Titel, frm.Description, frm.DescriptionType);
        }

        private void ButtonItem_BotSettings_Click(object sender, EventArgs e)
        {
            var frm = new DiscordBotSettingsWindow(General.CurProject.DiscordBotConfig);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                if (discordBot is object)
                    LoadDiscordBot();
            }
        }

        private void ButtonItem_ProxyConfig_Click(object sender, EventArgs e)
        {
            var frm = new ProxyConfigEditor(General.CurProject.ProxyConfig);
            if (frm.ShowDialog(this) == DialogResult.OK)
                General.SetProxyConfig();
        }
    }
}