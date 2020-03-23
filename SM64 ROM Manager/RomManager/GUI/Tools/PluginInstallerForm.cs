using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::Microsoft.WindowsAPICodePack.Dialogs;
using global::SM64_ROM_Manager.My.Resources;

namespace SM64_ROM_Manager
{
    public partial class PluginInstallerForm
    {

        // C o n s t r u c t o r s

        public PluginInstallerForm()
        {

            // G U I

            base.Load += PluginInstallerForm_Load;
            this.Shown += PluginInstallerForm_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();
        }

        // M e m b e r s

        private static List<PluginInstaller.PluginInfo> removedPlugins = new List<PluginInstaller.PluginInfo>();

        // F e a t u r e s

        private void LoadAllPlugins()
        {
            ListViewEx_Plugins.SuspendLayout();
            LoadInstalledPlugins();
            LoadRemovedPlugins();
            ListViewEx_Plugins.ResumeLayout();
        }

        private void LoadInstalledPlugins()
        {
            this.LoadPlugins(ListViewEx_Plugins.Groups["Lvg_Installed"], PluginInstaller.GetAllPlugins().Where(n => !removedPlugins.Where(b => b.Plugin == n.Plugin).Any()));
        }

        private void LoadRemovedPlugins()
        {
            LoadPlugins(ListViewEx_Plugins.Groups["Lvg_Removed"], removedPlugins);
        }

        private void LoadPlugins(ListViewGroup lvg, IEnumerable<PluginInstaller.PluginInfo> plugins)
        {
            ListViewEx_Plugins.SuspendLayout();
            var itemsToRemove = new List<ListViewItem>();
            foreach (ListViewItem item in ListViewEx_Plugins.Items)
            {
                if (item.Group == lvg)
                {
                    itemsToRemove.Add(item);
                }
            }

            foreach (ListViewItem item in itemsToRemove)
                ListViewEx_Plugins.Items.Remove(item);
            foreach (PluginInstaller.PluginInfo p in plugins)
                ListViewEx_Plugins.Items.Add(GetListViewItem(p, lvg));
            ListViewEx_Plugins.ResumeLayout();
        }

        private ListViewItem GetListViewItem(PluginInstaller.PluginInfo p, ListViewGroup lvg)
        {
            var lvi = new ListViewItem()
            {
                Tag = p,
                Text = p.Name,
                Group = lvg
            };
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.Version.ToString() });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.Developer });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = p.Location });
            return lvi;
        }

        private IEnumerable<PluginInstaller.PluginInfo> GetSelectedPlugins()
        {
            var items = ListViewEx_Plugins.SelectedItems;
            var plugins = new List<PluginInstaller.PluginInfo>();
            foreach (ListViewItem item in items)
            {
                if (item.Tag is PluginInstaller.PluginInfo)
                {
                    plugins.Add((PluginInstaller.PluginInfo)item.Tag);
                }
            }

            return plugins;
        }

        private void RemoveSelectedItems()
        {
            var plugins = GetSelectedPlugins();
            try
            {
                foreach (PluginInstaller.PluginInfo p in plugins)
                {
                    PluginInstaller.RemovePlugin(p);
                    removedPlugins.Add(p);
                }

                if (plugins.Any())
                {
                    LoadAllPlugins();
                }

                MessageBoxEx.Show(Plugin_Installer_Resources.MsgBox_PluginInstalled, Plugin_Installer_Resources.MsgBox_PluginInstalled_Titel, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBoxEx.Show(ex.Message, Plugin_Installer_Resources.MsgBox_PluginInstalled_Error_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InstallPlugin(string ext, string filterName, bool installDir)
        {
            var ofd = new CommonOpenFileDialog();
            if (installDir)
            {
                ofd.IsFolderPicker = true;
            }
            else
            {
                ofd.Filters.Add(new CommonFileDialogFilter(filterName, $"*.{ext}"));
            }

            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                try
                {
                    // Install Plugin
                    var res = PluginInstaller.InstallPluginFrom(ofd.FileName, installDir);

                    // Load Plugin
                    if (res.isDirectory)
                    {
                        Publics.General.PluginManager.LoadPlugins(res.destinationPath);
                    }
                    else
                    {
                        Publics.General.PluginManager.LoadPlugin(res.destinationPath);
                    }

                    // Reload list
                    LoadInstalledPlugins();
                    MessageBoxEx.Show(Plugin_Installer_Resources.MsgBox_PluginRemoved, Plugin_Installer_Resources.MsgBox_PluginRemoved_Titel, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBoxEx.Show(ex.Message, Plugin_Installer_Resources.MsgBox_PluginRemoved_Error_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PluginInstallerForm_Load(object sender, EventArgs e)
        {
            ListViewEx_Plugins.ResetHeaderHandler();
        }

        private void PluginInstallerForm_Shown(object sender, EventArgs e)
        {
            LoadAllPlugins();
        }

        private void ButtonX_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonX_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveSelectedItems();
            }
            catch (InvalidOperationException ex)
            {
                MessageBoxEx.Show(ex.Message, "Plugin is used", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonItem_SingleFile_Click(object sender, EventArgs e)
        {
            InstallPlugin("dll", string.Empty, false);
        }

        private void ButtonItem_ZipFile_Click(object sender, EventArgs e)
        {
            InstallPlugin("zip", string.Empty, false);
        }

        private void ButtonItem_Directory_Click(object sender, EventArgs e)
        {
            InstallPlugin(string.Empty, string.Empty, true);
        }
    }
}