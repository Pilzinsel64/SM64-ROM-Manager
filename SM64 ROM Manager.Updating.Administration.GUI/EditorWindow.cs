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

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class EditorWindow
    {

        // C o n s t r u c t o r s

        public EditorWindow()
        {
            this.Shown += EditorWindow_Shown;
            InitializeComponent();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        // C o n s t a n t s

        private const string FILTER_PACKAGE_TEMPLATE = "Update-Paket-Vorlagen (*.udpt)|*.udpt";
        private const string FILTER_PACKAGE_ZIP_PACKAGE = "ZIP-Paket (*.zip)|*.zip";
        private const string FILTER_PACKAGE_ADDON = "Anwendungserweiterung (*.dll)|*.dll";
        private const string FILTER_UPDATEINFO_CONFIGURATION = "Update-Info-Konfiguration (*.udic)|*.udic";

        // G e n e r a l   F e a t u r e s

        public void InitVersionInfoEditor()
        {
            RibbonTabItem_Packaging.Visible = false;
            SuperTabItem_Pkg_Files.Visible = false;
            SuperTabItem_Pkg_Extensions.Visible = false;
            RibbonControl_Main.SelectedRibbonTabItem = RibbonTabItem_UpdateInfo;
        }

        public void InitPackageEditor()
        {
            RibbonTabItem_UpdateInfo.Visible = false;
            SuperTabItem_UI_General.Visible = false;
            SuperTabItem_UI_PackageInfo.Visible = false;
            SuperTabItem_UI_Changelog.Visible = false;
            RibbonControl_Main.SelectedRibbonTabItem = RibbonTabItem_Packaging;
        }

        private void UpdateView()
        {
            var curRibbonTab = RibbonControl_Main.SelectedRibbonTabItem;
            if (curRibbonTab == RibbonTabItem_UpdateInfo)
            {
                var curTab = SuperTabControl1.SelectedTab;
                if (curTab == SuperTabItem_UI_General)
                {
                    RibbonBar_UI_Allgemein.Visible = true;
                    RibbonBar_UI_PackageInfo.Visible = false;
                }
                else if (curTab == SuperTabItem_UI_PackageInfo)
                {
                    RibbonBar_UI_Allgemein.Visible = false;
                    RibbonBar_UI_PackageInfo.Visible = true;
                }
                else
                {
                    RibbonBar_UI_Allgemein.Visible = false;
                    RibbonBar_UI_PackageInfo.Visible = false;
                }
            }
            else if (curRibbonTab == RibbonTabItem_Packaging)
            {
                var curTab = SuperTabControl1.SelectedTab;
                if (curTab == SuperTabItem_Pkg_Files)
                {
                    RibbonBar_Pkg_Dateien.Visible = true;
                    RibbonBar_Pkg_Erweiterungen.Visible = false;
                }
                else if (curTab == SuperTabItem_Pkg_Extensions)
                {
                    RibbonBar_Pkg_Erweiterungen.Visible = true;
                    RibbonBar_Pkg_Dateien.Visible = false;
                }

                RibbonControl_Main.RecalcLayout();
            }
        }

        // G e n e r a l   G u i

        private void SuperTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            UpdateView();
        }

        private void EditorWindow_Shown(object sender, EventArgs e)
        {
            UpdateView();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        // F i e l d s

        private readonly UpdateInfoManager updateInfoManager = new UpdateInfoManager();
        private string curUpdateInfoPath = string.Empty;

        // F e a t u r e s

        private void NewUpdateInfo()
        {
            updateInfoManager.NewInfo();
            curUpdateInfoPath = string.Empty;
            ShowAllUpdateInfoConfig();
        }

        private void OpenUpdateInfo()
        {
            var ofd_UpdateAdmin_LoadUpdateInfo = new OpenFileDialog() { Filter = FILTER_UPDATEINFO_CONFIGURATION };
            if (ofd_UpdateAdmin_LoadUpdateInfo.ShowDialog() == DialogResult.OK)
            {
                updateInfoManager.Load(ofd_UpdateAdmin_LoadUpdateInfo.FileName);
                curUpdateInfoPath = ofd_UpdateAdmin_LoadUpdateInfo.FileName;
                ShowAllUpdateInfoConfig();
            }
        }

        private void SaveUpdateInfo()
        {
            if (string.IsNullOrEmpty(curUpdateInfoPath))
            {
                SaveUpdateInfoAs();
            }
            else
            {
                updateInfoManager.Save(curUpdateInfoPath);
            }
        }

        private void SaveUpdateInfoAs()
        {
            var sfd_UpdateAdmin_SaveUpdateInfo = new SaveFileDialog() { Filter = FILTER_UPDATEINFO_CONFIGURATION };
            if (sfd_UpdateAdmin_SaveUpdateInfo.ShowDialog() == DialogResult.OK)
            {
                updateInfoManager.Save(sfd_UpdateAdmin_SaveUpdateInfo.FileName);
                curUpdateInfoPath = sfd_UpdateAdmin_SaveUpdateInfo.FileName;
            }
        }

        private void ShowAllUpdateInfoConfig()
        {
            LoadUpdatePackagePackageInfoList();
            ShowUpdateInfoConfiguration();
        }

        private void LoadUpdatePackagePackageInfoList()
        {
            ComboBoxItem_UI_PackageInfoList.Items.Clear();
            foreach (UpdatePackageInfo info in updateInfoManager.UpdateInfo.Packages)
            {
                var item = new ComboItem()
                {
                    Text = info.Name ?? info.Version.ToString(),
                    Tag = info
                };
                ComboBoxItem_UI_PackageInfoList.Items.Add(item);
            }

            if (updateInfoManager.UpdateInfo.Packages.Any())
            {
                ComboBoxItem_UI_PackageInfoList.SelectedIndex = 0;
            }
        }

        private void ShowUpdateInfoConfiguration()
        {
            LabelX_UI_UpdateInstallerExeDownloadlink.Text = updateInfoManager.UpdateInfo.UpdateInstallerLink;
        }

        private void ShowAllUpdateInfoPackgeInfo()
        {
            var info = GetCurUpdateInfoPackageInfo();
            if (info is null)
            {
                const string emptyChar = "-";
                LabelX_UI_PackageVersion.Text = emptyChar;
                LabelX_UI_PackageChannel.Text = emptyChar;
                LabelX_UI_PackageBuild.Text = emptyChar;
                LabelX_UI_PackageDownloadlink.Text = emptyChar;
                TextBoxX_UI_PackageChangelog.Text = emptyChar;
            }
            else
            {
                LabelX_UI_PackageVersion.Text = info.Version.Version.ToString();
                LabelX_UI_PackageChannel.Text = info.Version.Channel.ToString();
                LabelX_UI_PackageBuild.Text = Conversions.ToString(info.Version.Build);
                LabelX_UI_PackageDownloadlink.Text = info.Packagelink;
                TextBoxX_UI_PackageChangelog.Text = info.Changelog;
            }
        }

        private UpdatePackageInfo GetCurUpdateInfoPackageInfo()
        {
            return (UpdatePackageInfo)((ComboItem)ComboBoxItem_UI_PackageInfoList.SelectedItem)?.Tag;
        }

        private void UpdateUpdateInfoPackageItems()
        {
            foreach (ComboItem item in ComboBoxItem_UI_PackageInfoList.Items)
            {
                UpdatePackageInfo info = (UpdatePackageInfo)item.Tag;
                item.Text = info.Name;
            }

            ComboBoxItem_UI_PackageInfoList.Refresh();
        }

        private void SetUpdateInfoPackageChangelog(string str)
        {
            var info = GetCurUpdateInfoPackageInfo();
            if (info is object)
            {
                info.Changelog = str.Trim();
            }
        }

        // G u i

        private void ButtonItem_UI_NewPackage_Click(object sender, EventArgs e)
        {
            NewUpdateInfo();
        }

        private void ButtonItem_UI_Open_Click(object sender, EventArgs e)
        {
            OpenUpdateInfo();
        }

        private void ButtonItem_UI_Save_Click(object sender, EventArgs e)
        {
            SaveUpdateInfo();
        }

        private void ButtonItem_UI_SaveAs_Click(object sender, EventArgs e)
        {
            SaveUpdateInfoAs();
        }

        private void ButtonItem_UI_EditConfiguration_Click(object sender, EventArgs e)
        {
        }

        private void ButtonItem_UI_AddPackageInfo_Click(object sender, EventArgs e)
        {
        }

        private void ButtonItem_UI_DeletePackageInfo_Click(object sender, EventArgs e)
        {
        }

        private void ButtonItem_UI_EditDownloadlink_Click(object sender, EventArgs e)
        {
        }

        private void ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllUpdateInfoPackgeInfo();
        }

        private void ButtonItem_UI_EditVersion_Click(object sender, EventArgs e)
        {
            var info = GetCurUpdateInfoPackageInfo();
            if (info is object)
            {
                var editor = new ApplicationVersionInput()
                {
                    Version = info.Version.Version,
                    VersionName = info.Name,
                    Channel = info.Version.Channel,
                    Build = Conversions.ToUInteger(info.Version.Build)
                };
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    info.Version.Version = editor.Version;
                    info.Name = editor.VersionName;
                    info.Version.Channel = editor.Channel;
                    info.Version.Build = Conversions.ToInteger(editor.Build);
                    UpdateUpdateInfoPackageItems();
                    ShowAllUpdateInfoPackgeInfo();
                }
            }
        }

        private void TextBoxX_UI_PackageChangelog_TextChanged(object sender, EventArgs e)
        {
            SetUpdateInfoPackageChangelog(TextBoxX_UI_PackageChangelog.Text);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        // F i e l d s

        private readonly UpdatePackageManager packageManager = new UpdatePackageManager();
        private string curPackageTemplatePath = string.Empty;

        // F e a t u r e s

        private void ShowAllPackageTemplateConfig()
        {
            ShowPackageFiles();
            ShowPackageExtensions();
        }

        private void ShowPackageFiles()
        {
            AdvTree1.BeginUpdate();
            AdvTree1.Nodes.Clear();
            if (!string.IsNullOrEmpty(packageManager.FilesToCopyPath))
            {
                Action<NodeCollection, string> nodeCreation = null;
                nodeCreation = (parentCollection, p) =>
                {
                    bool isDir = (File.GetAttributes(p) & FileAttributes.Directory) == FileAttributes.Directory;
                    var n = new Node()
                    {
                        Tag = p,
                        Text = AdvTree1.Nodes == parentCollection ? p : Path.GetFileName(p),
                        ImageIndex = isDir ? 0 : 1
                    };
                    parentCollection.Add(n);
                    if (isDir)
                    {
                        var dirInfo = new DirectoryInfo(p);
                        dirInfo.EnumerateDirectories().ForEach(di => nodeCreation(n.Nodes, di.FullName));
                        dirInfo.EnumerateFiles().ForEach(fi => nodeCreation(n.Nodes, fi.FullName));
                    }
                };
                nodeCreation(AdvTree1.Nodes, packageManager.FilesToCopyPath);
            }

            AdvTree1.EndUpdate();
        }

        private void ShowPackageExtensions()
        {
            ListViewEx_Files.BeginUpdate();
            ListViewEx_Files.Items.Clear();
            foreach (string fAddOn in packageManager.GetAllUpdateInstallerÁddOn())
            {
                var item = new ListViewItem(new[] { Path.GetFileName(fAddOn), Path.GetDirectoryName(fAddOn) }) { Tag = fAddOn };
                ListViewEx_Files.Items.Add(item);
            }

            ListViewEx_Files.EndUpdate();
        }

        private IEnumerable<string> GetSelectedUpdateInstallAddOns()
        {
            var list = new List<string>();
            foreach (ListViewItem item in ListViewEx_Files.SelectedItems)
                list.Add(Conversions.ToString(item.Tag));
            return list;
        }

        private void NewPackageTemplate()
        {
            packageManager.NewTemplate();
            curPackageTemplatePath = string.Empty;
            ShowAllPackageTemplateConfig();
        }

        private void OpenPackageTemplate()
        {
            var ofd_UpdateAdmin_LoadTemplate = new OpenFileDialog() { Filter = FILTER_PACKAGE_TEMPLATE };
            if (ofd_UpdateAdmin_LoadTemplate.ShowDialog() == DialogResult.OK)
            {
                packageManager.LoadTemplate(ofd_UpdateAdmin_LoadTemplate.FileName);
                curPackageTemplatePath = ofd_UpdateAdmin_LoadTemplate.FileName;
                ShowAllPackageTemplateConfig();
            }
        }

        private void SavePackageTemplate()
        {
            if (string.IsNullOrEmpty(curPackageTemplatePath))
            {
                SavePackageTemplateAs();
            }
            else
            {
                packageManager.SaveTemplate(curPackageTemplatePath);
            }
        }

        private void SavePackageTemplateAs()
        {
            var sfd_UpdateAdmin_SaveTemplate = new SaveFileDialog() { Filter = FILTER_PACKAGE_TEMPLATE };
            if (sfd_UpdateAdmin_SaveTemplate.ShowDialog() == DialogResult.OK)
            {
                packageManager.SaveTemplate(sfd_UpdateAdmin_SaveTemplate.FileName);
                curPackageTemplatePath = sfd_UpdateAdmin_SaveTemplate.FileName;
            }
        }

        private void SelectPackageFileFolder()
        {
            var ofd_UpdateAdmin_PkgFileFolder = new CommonOpenFileDialog() { IsFolderPicker = true };
            if (ofd_UpdateAdmin_PkgFileFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                packageManager.FilesToCopyPath = ofd_UpdateAdmin_PkgFileFolder.FileName;
                ShowPackageFiles();
            }
        }

        private void RemovePackageFileFolder()
        {
            packageManager.FilesToCopyPath = string.Empty;
            ShowPackageFiles();
        }

        private void ExportUpdatePackage()
        {
            var sfd_UpdateAdmin_ExportPkg = new SaveFileDialog() { Filter = FILTER_PACKAGE_ZIP_PACKAGE };
            if (sfd_UpdateAdmin_ExportPkg.ShowDialog() == DialogResult.OK)
            {
                packageManager.ExportPackage(sfd_UpdateAdmin_ExportPkg.FileName);
                MessageBox.Show(My.Resources.UpdatingAdministrationLangRes.MsgBox_PkgExportSuccess, My.Resources.UpdatingAdministrationLangRes.MsgBox_PkgExportSuccess_Titel, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddUpdateInstallerExtension()
        {
            var ofd_UpdateAdmin_AddExtension = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = FILTER_PACKAGE_ADDON
            };
            if (ofd_UpdateAdmin_AddExtension.ShowDialog() == DialogResult.OK)
            {
                foreach (string f in ofd_UpdateAdmin_AddExtension.FileNames)
                {
                    if (!packageManager.AddUpdateInstallerAddOn(f))
                    {
                        MessageBoxEx.Show(My.Resources.UpdatingAdministrationLangRes.MsgBox_ErrorAddingInstallerAddOn, My.Resources.UpdatingAdministrationLangRes.MsgBox_Error_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RemoveUpdateInstallerExtension()
        {
            foreach (string fAddOn in GetSelectedUpdateInstallAddOns())
                packageManager.RemoveUpdateInstallerAddOn(fAddOn);
        }

        // G u i

        private void ButtonItem_Pkg_NewTemplate_Click(object sender, EventArgs e)
        {
            NewPackageTemplate();
        }

        private void ButtonItem_Pkg_OpenTemplate_Click(object sender, EventArgs e)
        {
            OpenPackageTemplate();
        }

        private void ButtonItem_Pkg_SaveTemplate_Click(object sender, EventArgs e)
        {
            SavePackageTemplate();
        }

        private void ButtonItem_Pkg_SaveTemplateAs_Click(object sender, EventArgs e)
        {
            SavePackageTemplateAs();
        }

        private void ButtonItem_Pkg_SelectFileFolder_Click(object sender, EventArgs e)
        {
            SelectPackageFileFolder();
        }

        private void ButtonItem_Pkg_RemoveFileFolder_Click(object sender, EventArgs e)
        {
            RemovePackageFileFolder();
        }

        private void ButtonItem_ButtonItem_Pkg_Export_Click(object sender, EventArgs e)
        {
            ExportUpdatePackage();
        }

        private void ButtonItem_Pkg_AddExtension_Click(object sender, EventArgs e)
        {
            AddUpdateInstallerExtension();
        }

        private void ButtonItem_Pkg_RemoveExtension_Click(object sender, EventArgs e)
        {
            RemoveUpdateInstallerExtension();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}