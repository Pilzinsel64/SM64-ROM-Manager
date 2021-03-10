using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevComponents.AdvTree;
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

        // C o n s t a n t s

        private const string LVG_INSTALLED = "Lvg_Installed";
        private const string LVG_REMOVED = "Lvg_Removed";

        // M e m b e r s

        private static List<PluginInstaller.PluginInfo> removedPlugins = new List<PluginInstaller.PluginInfo>();
        private readonly List<Node> allItems = new List<Node>();

        // F e a t u r e s

        private void LoadAllPlugins()
        {
            advTree1.BeginUpdate();
            LoadInstalledPlugins();
            LoadRemovedPlugins();
            advTree1.EndUpdate();
        }

        private void LoadInstalledPlugins()
        {
            LoadPlugins(advTree1.FindNodeByName(LVG_INSTALLED), PluginInstaller.GetAllPlugins().Where(n => !removedPlugins.Where(b => b.Plugin == n.Plugin).Any()));
        }

        private void LoadRemovedPlugins()
        {
            LoadPlugins(advTree1.FindNodeByName(LVG_REMOVED), removedPlugins);
        }

        private void LoadPlugins(Node lvg, IEnumerable<PluginInstaller.PluginInfo> plugins)
        {
            var itemsToRemove = new List<Node>();
            advTree1.BeginUpdate();

            foreach (Node item in lvg.Nodes)
                itemsToRemove.Add(item);

            foreach (Node item in itemsToRemove)
            {
                item.Remove();
                allItems.Remove(item);
            }

            foreach (PluginInstaller.PluginInfo p in plugins)
                allItems.Add(GetListViewItem(p, lvg));

            advTree1.EndUpdate();
        }

        private Node GetListViewItem(PluginInstaller.PluginInfo p, Node lvg)
        {
            var lvi = new Node
            {
                Tag = p,
                Text = p.Name
            };
            lvi.Cells.Add(new Cell { Text = p.Version.ToString() });
            lvi.Cells.Add(new Cell { Text = p.Developer });
            lvi.Cells.Add(new Cell { Text = p.Location });
            lvg.Nodes.Add(lvi);
            return lvi;
        }

        private IEnumerable<PluginInstaller.PluginInfo> GetSelectedPlugins()
        {
            var items = advTree1.SelectedNodes;
            var plugins = new List<PluginInstaller.PluginInfo>();
            foreach (Node item in items)
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

        private void advTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {

        }
    }
}