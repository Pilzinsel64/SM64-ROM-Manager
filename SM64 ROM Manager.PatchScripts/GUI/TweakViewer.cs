using System;
using System.Collections.Generic;
using System.Data;
using global::System.Drawing;
using global::System.IO;
using System.Linq;
using System.Threading.Tasks;
using global::System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.Publics;

namespace SM64_ROM_Manager.PatchScripts
{
    public partial class TweakViewer
    {

        // C o n s t r u c t o r

        public TweakViewer(SM64Lib.RomManager rommgr)
        {
            // G u i
            base.Shown += TweakViewer_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();
            Panel1.UpdateAmbientColors();
            Flyout1.BackColor = base.BackColor;
            this.rommgr = rommgr;
        }

        // E v e n t s

        public static event TweakBeforeApplyEventHandler TweakBeforeApply;
        public delegate void TweakBeforeApplyEventHandler();

        public static event TweakAfterApplyEventHandler TweakAfterApply;
        public delegate void TweakAfterApplyEventHandler();

        public static event TweakFailedApplyEventHandler TweakFailedApply;
        public delegate void TweakFailedApplyEventHandler();

        // F i e l d s

        private List<PatchProfile> myPatchs = new List<PatchProfile>();
        private SM64Lib.RomManager rommgr;
        private IEnumerable<TweakDatabaseSyncFile> syncFiles = new TweakDatabaseSyncFile[] { };
        private TweakDatabaseManager dbmgr = new TweakDatabaseManager(TweakDatabasePreferences.Load(Path.Combine(General.MyDataPath, "Other\\Tweak Database Preferences.json")));

        // F e a t u r e s

        private TweakDatabaseManager GetDatabaseManager()
        {
            return dbmgr;
        }

        private async void CheckForTweakUpdates()
        {
            var dbmgr = GetDatabaseManager();
            string localPath = Path.Combine(General.MyTweaksPath, nameof(TweakDatabaseCategories.Reviewed));
            bool hasUpdates = false;

#if !DEBUG
            try
            {
#endif
            syncFiles = await dbmgr.CheckForUpdates(localPath);
#if !DEBUG
            }
            catch (Exception)
            {
            }
#endif

            hasUpdates = syncFiles.Any();

            if (hasUpdates)
            {
                WarningBox_TweakUpdates.Visible = true;
            }
        }

        private async Task<bool> ExecuteUpdate()
        {
            var dbmgr = GetDatabaseManager();
            bool success = false;


#if !DEBUG
            try
            {
#endif
                await dbmgr.Update(syncFiles);
                success = true;
#if !DEBUG
            }
            catch (Exception)
            {
            }
#endif

            return success;
        }

        private void LoadTweaks()
        {
            CircularProgress1.Start();
            string pathTweaks = General.MyTweaksPath;
            var mgr = new PatchingManager();
            myPatchs.Clear();
            foreach (string f in Directory.GetFiles(pathTweaks, "*.xml", SearchOption.AllDirectories))
            {
                var p = mgr.Read(f);
                myPatchs.Add(p);
            }

            myPatchs = myPatchs.OrderBy(n => n.Name).ToList();
            LoadTweakList();
            CircularProgress1.Stop();
        }

        private void LoadTweakList(string Filter = "")
        {
            bool enableFilter = !string.IsNullOrEmpty(Filter.Trim());
            string filterLower = Filter.ToLower();
            ItemListBox1.Items.Clear();
            foreach (PatchProfile patch in myPatchs)
            {
                if (enableFilter && !patch.Name.ToLower().Contains(filterLower) && patch.Scripts.Where(n => n.Name.ToLower().Contains(filterLower)).Count() == 0)
                {
                    continue;
                }

                var btnItem = new ButtonItem();
                btnItem.Text = patch.Name;
                btnItem.Tag = patch;
                btnItem.MouseUp += ItemListBox1_ItemMouseClick;
                ItemListBox1.Items.Add(btnItem);
            }

            if (ItemListBox1.Items.Count > 0)
            {
                ItemListBox1.SelectedItem = ItemListBox1.Items[0];
            }

            ItemListBox1.Refresh();
        }

        private void LoadTweak(PatchProfile patch)
        {
            LabelX_PatchName.Text = patch.Name;
            if (!string.IsNullOrEmpty(LabelX_Description.Text))
            {
                LabelX_Description.Text = patch.Description;
                SuperTooltip1.SetSuperTooltip(LabelX_Description, new SuperTooltipInfo("", "", patch.Description, null, null, eTooltipColor.Default, false, false, default));
            }
            else
            {
                LabelX_Description.Text = "(No description available.)";
                SuperTooltip1.SetSuperTooltip(LabelX_Description, null);
            }

            LoadScriptsList(patch);
        }

        private void LoadScriptsList(PatchProfile patch)
        {
            ComboBoxEx_Scripts.Items.Clear();
            LabelX_PatchName.Text = $"Name: {patch.Name}";
            LabelX_Description.Text = string.IsNullOrEmpty(patch.Name) ? "No description available." : patch.Description;
            foreach (PatchScript script in patch.Scripts)
            {
                var item = new ComboItem();
                if (!string.IsNullOrEmpty(script.Name))
                {
                    item.Text = script.Name;
                }
                else
                {
                    item.Text = "Untitled";
                }

                item.Tag = script;
                ComboBoxEx_Scripts.Items.Add(item);
            }

            if (ComboBoxEx_Scripts.Items.Count > 0)
            {
                ComboBoxEx_Scripts.SelectedIndex = 0;
            }

            Panel1.Refresh();
        }

        private void LoadScript(PatchScript script)
        {
            SuperTooltip1.SetSuperTooltip(new ComboItem(), new SuperTooltipInfo(script.Name, "", script.Description, null, null, eTooltipColor.Default, false, false, default));
        }

        private void SaveSinglePatch(PatchProfile patch)
        {
            if (patch is object)
            {
                var profmgr = new PatchingManager();
                profmgr.Save(patch, Path.Combine(General.MyDataPath, "Tweaks"));
            }
        }

        private PatchProfile GetSelectedPatch()
        {
            return (PatchProfile)((ButtonItem)ItemListBox1.SelectedItem)?.Tag;
        }

        private PatchScript GetSelectedScript()
        {
            return (PatchScript)((ComboItem)ComboBoxEx_Scripts.SelectedItem)?.Tag;
        }

        private void AddNewScript(string name, PatchProfile patch)
        {
            var script = new PatchScript();
            script.Name = name;
            patch.Scripts.Add(script);
            var comboItem = new ComboItem();
            comboItem.Text = script.Name;
            comboItem.Tag = script;
            ComboBoxEx_Scripts.Items.Add(comboItem);
            ComboBoxEx_Scripts.SelectedItem = comboItem;
        }

        private void AddNewPatch(string name, string description, string firstScriptName)
        {
            var patch = new PatchProfile()
            {
                Name = name,
                Description = description
            };
            var script = new PatchScript() { Name = firstScriptName };
            patch.Scripts.Add(script);
            var btnItem = GetButtonItemFromPatch(patch);
            ItemListBox1.Items.Add(btnItem);
            SaveSinglePatch(patch);
            ItemListBox1.SelectedItem = btnItem;
            ItemListBox1.Refresh();
            ItemListBox1.EnsureVisible(btnItem);
        }

        private ButtonItem GetButtonItemFromPatch(PatchProfile patch)
        {
            var btnItem = new ButtonItem()
            {
                Text = patch.Name,
                Tag = patch
            };
            btnItem.MouseUp += ItemListBox1_ItemMouseClick;
            return btnItem;
        }

        private string EnsureFileNameIsNotUsed(string fileName)
        {
            string newFileName = fileName;
            if (File.Exists(fileName))
            {
                bool ende = false;
                int count = 0;
                string dir = Path.GetDirectoryName(fileName);
                string name = Path.GetFileNameWithoutExtension(fileName);
                string ext = Path.GetExtension(fileName);
                while (!ende)
                {
                    newFileName = Path.Combine(dir, name + Conversions.ToString(count) + ext);
                    if (!File.Exists(newFileName))
                        ende = true;
                }
            }

            return newFileName;
        }

        private void EditPatch(PatchProfile patch)
        {
            var editor = new TweakProfileEditor()
            {
                Titel = patch.Name,
                Description = patch.Description
            };
            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                string oldName = patch.Name;
                string oldDescription = patch.Description;
                patch.Name = editor.Titel.Trim();
                patch.Description = editor.Description.Trim();
                if ((oldName ?? "") != (patch.Name ?? ""))
                {
                    // Rename File
                    string newFileName = Path.Combine(Path.GetDirectoryName(patch.FileName), editor.Titel + Path.GetExtension(patch.FileName));
                    newFileName = EnsureFileNameIsNotUsed(newFileName);
                    File.Move(patch.FileName, newFileName);
                    patch.FileName = newFileName;

                    // Update Title in ListBox
                    ItemListBox1.SelectedItem.Text = patch.Name;
                    ItemListBox1.Refresh();
                }
            }
        }

        private void TweakViewer_Shown(object sender, EventArgs e)
        {
            // Check for tweak updates
            CheckForTweakUpdates();

            // Load tweaks
            LoadTweaks();
        }

        private void ItemListBox1_SelectedItemChanged()
        {
            ButtonItem btnItem = (ButtonItem)ItemListBox1.SelectedItem;
            PatchProfile patch = (PatchProfile)btnItem.Tag;
            LoadScriptsList(patch);
        }

        private void ComboBoxEx_Scripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem item = (ComboItem)ComboBoxEx_Scripts.SelectedItem;
            bool isNotNull = item is object;
            ButtonX8.Enabled = isNotNull;
            ButtonX4.Enabled = isNotNull;
            ButtonX6.Enabled = isNotNull;
            if (isNotNull)
            {
                PatchScript script = (PatchScript)item.Tag;
                LoadScript(script);
            }
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            PatchProfile patch = (PatchProfile)((ButtonItem)ItemListBox1.SelectedItem)?.Tag;

            // Close Flyout
            Flyout1.Close();

            // Edit the Patch
            EditPatch(patch);

            // Save Patch
            SaveSinglePatch(patch);

            // Update Tweak Infos
            ItemListBox1_SelectedItemChanged();
        }

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            Flyout1.Close();
        }

        private void ButtonX5_Click(object sender, EventArgs e)
        {
            ButtonItem btnItem = (ButtonItem)ItemListBox1.SelectedItem;
            PatchProfile patch = (PatchProfile)btnItem?.Tag;
            if (patch is object && MessageBoxEx.Show(this, "Are you sure to remove this tweak? You will not be able to recover it.", "Remove Tweak", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Flyout1.Close();
                ItemListBox1.Items.Remove(btnItem);
                ItemListBox1.Refresh();
                myPatchs.Remove(patch);
                File.Delete(patch.FileName);
            }
        }

        private void ButtonX_AddNew_Click(object sender, EventArgs e)
        {
            var frm = new TweakProfileEditor()
            {
                Titel = "New Profile",
                Description = string.Empty
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                AddNewPatch(frm.Titel, frm.Description, "New Script");
            }
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            var patch = GetSelectedPatch();
            AddNewScript("New Script", patch);
            SaveSinglePatch(patch);
        }

        private void ButtonX4_Click(object sender, EventArgs e)
        {
            var patch = GetSelectedPatch();
            var script = GetSelectedScript();
            if (patch is object && script is object)
            {
                patch.Scripts.Remove(script);
                ComboBoxEx_Scripts.Items.Remove(ComboBoxEx_Scripts.SelectedItem);
                SaveSinglePatch(patch);
            }
        }

        private void ButtonX6_Click(object sender, EventArgs e)
        {
            var script = GetSelectedScript();
            if (script is object)
            {
                var editor = new TweakScriptEditor(script, rommgr);
                Flyout1.Close();
                editor.ShowDialog(this);
                ComboItem ci = (ComboItem)ComboBoxEx_Scripts.SelectedItem;
                if (ci is object)
                {
                    if (!string.IsNullOrEmpty(script.Name))
                    {
                        ci.Text = script.Name;
                    }
                    else
                    {
                        ci.Text = "Untitled";
                    }
                }

                if (editor.WantToSave && editor.NeedToSave)
                {
                    SaveSinglePatch(GetSelectedPatch());
                    ItemListBox1_SelectedItemChanged();
                }
            }
        }

        private void ButtonX8_Click(object sender, EventArgs e)
        {
            var profile = GetSelectedPatch();
            var script = GetSelectedScript();
            if (script is object)
            {
                PatchScript(this, script, profile, rommgr);
            }
        }

        internal static void PatchScript(IWin32Window owner, PatchScript script, PatchProfile profile, SM64Lib.RomManager rommgr)
        {
            try
            {
                TweakBeforeApply?.Invoke();
                var mgr = new PatchingManager();
                mgr.Patch(script, rommgr, owner, new Dictionary<string, object>() { { "romfile", rommgr.RomFile }, { "rommgr", rommgr }, { "profilepath", profile?.FileName } });
                TweakAfterApply?.Invoke();
                MessageBoxEx.Show(owner, "Patched successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                TweakFailedApply?.Invoke();
                MessageBoxEx.Show(owner, "Error while executing the script. It probably contains errors.", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemListBox1_ItemMouseClick(object sender, EventArgs e)
        {
            Flyout1.Show(new Rectangle(new Point((int)(Cursor.Position.X - Flyout1.Content.Width / (double)2), Cursor.Position.Y), Size.Empty), DevComponents.DotNetBar.Controls.ePointerSide.Top, (int)(Flyout1.Content.Width / (double)2), ItemListBox1);
        }

        private void ButtonX7_Click(object sender, EventArgs e)
        {
            LoadTweakList(TextBoxX1.Text);
        }

        private void TextBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonX7.PerformClick();
            }
        }

        private void LabelX_Description_MouseEnter(object sender, EventArgs e)
        {
            SuperTooltip1.SetSuperTooltip((System.ComponentModel.IComponent)sender, new SuperTooltipInfo(string.Empty, string.Empty, Conversions.ToString(((Control)sender).Text), null, null, eTooltipColor.System, false, false, default));
        }

        private void Flyout1_FlyoutShown(object sender, EventArgs e)
        {
            Flyout1.Content?.Focus();
        }

        private void ItemListBox1_Scroll(object sender, ScrollEventArgs e)
        {
            Flyout1.Close();
        }

        private void ButtonX9_Click(object sender, EventArgs e)
        {
            TextBoxX1.Text = "";
            LoadTweakList();
        }

        private async void WarningBox_TweakUpdates_OptionsClick(object sender, EventArgs e)
        {
            WarningBox_TweakUpdates.Visible = false;
            Enabled = false;
            CircularProgress1.Start();
            bool res = await ExecuteUpdate();
            CircularProgress1.Stop();
            Enabled = true;
            if (res)
            {
                LoadTweaks();
                MessageBoxEx.Show(this, "Tweaks updated successfully!", "Tweak Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show(this, "Tweaks not updated (completly). There happened an error!", "Tweak Updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemListBox1_SelectedItemChanged(object sender, EventArgs e) => ItemListBox1_SelectedItemChanged();
    }
}