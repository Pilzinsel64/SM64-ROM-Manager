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
using SM64_ROM_Manager.Updating.Administration.Packaging;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class PackageCreationDialog
    {

        // C o n s t a n t s

        private const string FILTER_PACKAGE_TEMPLATE = "Update-Paket-Vorlagen (*.udpt)|*.udpt";
        private const string FILTER_PACKAGE_ZIP_PACKAGE = "ZIP-Paket (*.zip)|*.zip";
        private const string FILTER_PACKAGE_ADDON = "Anwendungserweiterung (*.dll)|*.dll";

        // F i e l d s

        private readonly bool isUploadingPackage;

        // P r o p e r t i e s

        public string TempPackageFilePath { get; private set; } = string.Empty;

        // C o n s t r u c t o r s

        public PackageCreationDialog() : this(false)
        {
        }

        public PackageCreationDialog(bool isUploadingPackage = false)
        {
            this.isUploadingPackage = isUploadingPackage;
            Shown += EditorWindow_Shown;
            InitializeComponent();
            UpdateAmbientColors();
            ButtonItem_UploadPackage.Visible = isUploadingPackage;
        }

        // G e n e r a l   F e a t u r e s

        private void UpdateView()
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

        private void ProgressControls(bool enabled)
        {
            if (enabled)
                circularProgress1.Start();
            else
                circularProgress1.Stop();
            Enabled = !enabled;
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

        private async Task<bool> ExportUpdatePackage(string filePath)
        {
            bool success = false;
            ProgressControls(true);

            try
            {
                await Task.Run(() => packageManager.ExportPackage(filePath));
                success = true;
            }
            catch (Exception)
            {
                success = false;
            }

            ProgressControls(false);
            return success;
        }

        private async Task<bool> ExportTempUpdatePackage()
        {
            var filePath = Path.GetTempFileName();
            bool res = await ExportUpdatePackage(filePath);
            if (res) TempPackageFilePath = filePath;
            return res;
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

        private async void ButtonItem_Pkg_Export_Click(object sender, EventArgs e)
        {
            var sfd_UpdateAdmin_ExportPkg = new SaveFileDialog() { Filter = FILTER_PACKAGE_ZIP_PACKAGE };

            if (sfd_UpdateAdmin_ExportPkg.ShowDialog() == DialogResult.OK)
            {
                if (await ExportUpdatePackage(sfd_UpdateAdmin_ExportPkg.FileName))
                    MessageBoxEx.Show(this, My.Resources.UpdatingAdministrationLangRes.MsgBox_PkgExportSuccess, My.Resources.UpdatingAdministrationLangRes.MsgBox_PkgExportSuccess_Titel, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void ButtonItem_Pkg_AddExtension_Click(object sender, EventArgs e)
        {
            AddUpdateInstallerExtension();
        }

        private void ButtonItem_Pkg_RemoveExtension_Click(object sender, EventArgs e)
        {
            RemoveUpdateInstallerExtension();
        }

        private async void ButtonItem_UploadPackage_Click(object sender, EventArgs e)
        {
            if (await ExportTempUpdatePackage())
                DialogResult = DialogResult.OK;
            else
                MessageBoxEx.Show(this, My.Resources.UpdatingAdministrationLangRes.MsgBox_PkgExportSuccess, My.Resources.UpdatingAdministrationLangRes.MsgBox_PkgExportSuccess_Titel, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}