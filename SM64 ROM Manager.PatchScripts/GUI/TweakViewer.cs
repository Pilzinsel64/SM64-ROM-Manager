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
using Microsoft.VisualBasic;
using static Microsoft.VisualBasic.CompilerServices.LikeOperator;
using SM64Lib.Patching;
using DevComponents.DotNetBar.Controls;
using SM64_ROM_Manager.PatchScripts.LangRes;

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
            string localPath = Path.Combine(General.MyTweaksPath, dbmgr.Preferences.CategoryPaths[TweakDatabaseCategories.Reviewed]);
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

        private IEnumerable<PatchProfile> GetAllLegacyTweaks()
        {
            return myPatchs.Where(n => n.IsLegacy);
        }

        private void CheckForLegacyTweaks()
        {
            var hasLegacyTweaks = GetAllLegacyTweaks().Any();

            if (hasLegacyTweaks)
                WarningBox_UpgradeLegacyTweaks.Visible = true;
        }

        private void ConvertLegacyTweaks()
        {
            var patches = GetAllLegacyTweaks();
            if (patches.Any())
            {
                var mgr = new PatchingManager();
                foreach (var patch in patches)
                    mgr.Save(patch, Path.GetDirectoryName(patch.FileName));
                General.ShowToastnotification(this, TweaksGUILangRes.Notify_AllTweaksConvertedSuccessfully, eToastGlowColor.Green);
                CheckForLegacyTweaks();
            }
        }

        private void LoadTweaks()
        {
            CircularProgress1.Start();
            string pathTweaks = General.MyTweaksPath;
            var mgr = new PatchingManager();
            myPatchs.Clear();

            var nullVersion = new Version("0.0.0.0");
            var appVersion = new Version(Application.ProductVersion);

            foreach (string f in Directory.GetFiles(pathTweaks, "*.xml", SearchOption.AllDirectories).Concat(Directory.GetFiles(pathTweaks, "*.json", SearchOption.AllDirectories)))
            {
                var p = mgr.Read(f);
                if (p.MinVersion <= appVersion && (p.MaxVersion == nullVersion || p.MaxVersion >= appVersion))
                    myPatchs.Add(p);
            }
            
            myPatchs = myPatchs.OrderBy(n => n.Name).ToList();
            LoadTweakList();
            CircularProgress1.Stop();
        }

        private void LoadTweakList(string Filter = "")
        {
            bool enableFilter = !string.IsNullOrEmpty(Filter.Trim());
            Filter = $"*{Filter}*";
            ItemListBox1.Items.Clear();

            foreach (PatchProfile patch in myPatchs)
            {
                if (!enableFilter || LikeString(patch.Name, Filter, CompareMethod.Text) || patch.Scripts.Where(n => LikeString(n.Name, Filter, CompareMethod.Text)).Any())
                {
                    var btnItem = GetButtonItemFromPatch(patch);
                    ItemListBox1.Items.Add(btnItem);
                }
            }

            if (ItemListBox1.Items.Count > 0)
            {
                ItemListBox1.SelectedItem = ItemListBox1.Items[0];
            }

            ItemListBox1.Refresh();
        }

        private Color GetTweakColor(PatchProfile patch)
        {
            switch (true)
            {
                case object _ when patch.FileName.StartsWith(Path.Combine(General.MyTweaksPath, dbmgr.Preferences.CategoryPaths[TweakDatabaseCategories.Reviewed])):
                    return default;
                case object _ when patch.FileName.StartsWith(Path.Combine(General.MyTweaksPath, dbmgr.Preferences.CategoryPaths[TweakDatabaseCategories.Experimental])):
                    return Color.Orange;
                case object _ when patch.FileName.StartsWith(Path.Combine(General.MyTweaksPath, dbmgr.Preferences.CategoryPaths[TweakDatabaseCategories.Uploads])):
                    return Color.OrangeRed;
                default:
                    return Color.DarkViolet;
            }
        }

        private void LoadTweak(PatchProfile patch)
        {
            LabelX_PatchName.Text = patch.Name;
            labelX_Version.Text = $"Version {patch.Version}";

            if (!string.IsNullOrEmpty(LabelX_Description.Text))
            {
                LabelX_Description.Text = patch.Description;
                SuperTooltip1.SetSuperTooltip(LabelX_Description, new SuperTooltipInfo("", "", patch.Description, null, null, eTooltipColor.Default, false, false, default));
            }
            else
            {
                LabelX_Description.Text = TweaksGUILangRes.Label_NoDescriptionAvailable;
                SuperTooltip1.SetSuperTooltip(LabelX_Description, null);
            }

            LoadScriptsList(patch);
        }

        private void LoadScriptsList(PatchProfile patch)
        {
            ComboBoxEx_Scripts.Items.Clear();

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
            SuperTooltip1.SetSuperTooltip(new ComboItem(), new SuperTooltipInfo(script.Name, string.Empty, script.Description, null, null, eTooltipColor.Default, false, false, default));
            ButtonX_UndoScript.Visible = true; // script.AllowRevert;
            ButtonX_UndoScript.Enabled = PatchingManager.HasUndoPatch(script, rommgr);
        }

        private void SaveSinglePatch(PatchProfile patch)
        {
            if (patch is object)
            {
                var profmgr = new PatchingManager();
                profmgr.Save(patch, Path.Combine(General.MyDataPath, "Tweaks"));

                // Check for legacy tweaks for the case this tweak was the last legacy one.
                CheckForLegacyTweaks();
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
            script.ID.Generate();
            script.Name = name;
            patch.Scripts.Add(script);
            var comboItem = new ComboItem();
            comboItem.Text = script.Name;
            comboItem.Tag = script;
            ComboBoxEx_Scripts.Items.Add(comboItem);
            ComboBoxEx_Scripts.SelectedItem = comboItem;
        }

        private void AddNewPatch(string name, string description, Version version, Version minAppVersion, Version maxAppVersion, string firstScriptName)
        {
            var patch = new PatchProfile()
            {
                Name = name,
                Description = description,
                Version = version,
                MinVersion = minAppVersion,
                MaxVersion = maxAppVersion
            };
            patch.ID.Generate();
            var script = new PatchScript() { Name = firstScriptName };
            script.ID.Generate();
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
                Tag = patch,
                ForeColor = GetTweakColor(patch)
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
                Description = patch.Description,
                Version = patch.Version,
                MinAppVersion = patch.MinVersion,
                MaxAppVersion = patch.MaxVersion
            };
            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                string oldName = patch.Name;
                string oldDescription = patch.Description;

                patch.Name = editor.Titel.Trim();
                patch.Description = editor.Description.Trim();
                patch.Version = editor.Version;
                patch.MinVersion = editor.MinAppVersion;
                patch.MaxVersion = editor.MaxAppVersion;

                if ((oldName ?? "") != (patch.Name ?? ""))
                {
                    //// Rename File
                    //string newFileName = Path.Combine(Path.GetDirectoryName(patch.FileName), editor.Titel + Path.GetExtension(patch.FileName));
                    //newFileName = EnsureFileNameIsNotUsed(newFileName);
                    //File.Move(patch.FileName, newFileName);
                    //patch.FileName = newFileName;

                    // Update Title in ListBox
                    ItemListBox1.SelectedItem.Text = patch.Name;
                    ItemListBox1.Refresh();
                }
            }
        }

        private static void ApplyUndoPatch(PatchScript script, SM64Lib.RomManager rommgr)
        {
            if (script is object)
            {
                TweakBeforeApply?.Invoke();
                PatchingManager.ApplyUndoPatch(script, rommgr);
                TweakAfterApply.Invoke();
            }
        }

        private void TweakViewer_Shown(object sender, EventArgs e)
        {
            // Check for tweak updates
            CheckForTweakUpdates();

            // Load tweaks
            LoadTweaks();

            // Check for legacy tweaks
            CheckForLegacyTweaks();
        }

        private void ItemListBox1_SelectedItemChanged()
        {
            ButtonItem btnItem = (ButtonItem)ItemListBox1.SelectedItem;
            PatchProfile patch = (PatchProfile)btnItem.Tag;
            LoadTweak(patch);
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
            if (patch is object && MessageBoxEx.Show(this, TweaksGUILangRes.MsgBox_RemoveTweak, TweaksGUILangRes.MsgBox_RemoveTweak_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                Titel = TweaksGUILangRes.DefaultTweakName,
                Description = string.Empty,
                Version = new Version("1.0.0.0"),
                MinAppVersion = new Version(Application.ProductVersion)
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                AddNewPatch(frm.Titel, frm.Description, frm.Version, frm.MinAppVersion, frm.MaxAppVersion, TweaksGUILangRes.DefaultScriptName);
            }
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            var patch = GetSelectedPatch();
            AddNewScript(TweaksGUILangRes.DefaultScriptName, patch);
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
            var patch = GetSelectedPatch();

            if (script is object && patch is object)
            {
                var editor = new TweakScriptEditor(script, rommgr, patch.EmbeddedFiles);
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
                        ci.Text = TweaksGUILangRes.UntitledScript;
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

        private static bool IsBackupEnabled(Control owner, PatchScript script, PatchProfile profile)
        {
            var res = false;

            if (script.AllowRevert && MessageBoxEx.Show(owner, TweaksGUILangRes.MsgBox_AskForBackupTweak, TweaksGUILangRes.MsgBox_AskForBackupTweak_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                res = true;

            return res;
        }

        internal static void PatchScript(Control owner, PatchScript script, PatchProfile profile, SM64Lib.RomManager rommgr)
        {
            if (PatchingManager.HasUndoPatch(script, rommgr) &&
                MessageBoxEx.Show(owner, TweaksGUILangRes.MsgBox_RevertScriptBeforePatching, TweaksGUILangRes.MsgBox_RevertScript_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ApplyUndoPatch(script, rommgr);

            try
            {
                TweakBeforeApply?.Invoke();
                var mgr = new PatchingManager();
                var result = mgr.Patch(
                    script,
                    rommgr,
                    owner,
                    new Dictionary<string, object>() {
                        { "romfile", rommgr.RomFile },
                        { "rommgr", rommgr },
                        { "profilepath", profile?.FileName },
                        { "files", profile.EmbeddedFiles },
                        { "owner", owner }
                    },
                    General.GetAdditionalReferencedAssemblied(),
                    IsBackupEnabled(owner, script, profile));
                TweakAfterApply?.Invoke();
                General.ShowToastnotification(owner, TweaksGUILangRes.Notify_PatchedSuccessfully, eToastGlowColor.Green);
            }
            catch (Exception)
            {
                TweakFailedApply?.Invoke();
                MessageBoxEx.Show(owner, TweaksGUILangRes.MsgBox_ErrorWhileExecutingScript, TweaksGUILangRes.MsgBox_ErrorWhileExecutingScript_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemListBox1_ItemMouseClick(object sender, EventArgs e)
        {
            var contentSize = Flyout1.GetFlyoutFormSize();
            var cursorPosition = Cursor.Position;
            var pos = ePointerSide.Top;
            var screen = Screen.FromPoint(cursorPosition);
            var workingArea = screen.Bounds;
            Rectangle rectContent = default;
            var success = false;

            bool checkIfInBounds(Rectangle rectangle)
            {
                if (rectangle.Bottom < workingArea.Bottom &&
                    rectangle.Right < workingArea.Right &&
                    rectangle.Top >= workingArea.Top &&
                    rectangle.Left >= workingArea.Left)
                    return true;
                else
                    return false;
            }

            foreach (var testpost in new[] { ePointerSide.Top, ePointerSide.Bottom })
            {
                if (!success)
                {
                    switch (testpost)
                    {
                        case ePointerSide.Top:
                            rectContent = new Rectangle(new Point((int)(cursorPosition.X - contentSize.Width / 2.0), cursorPosition.Y), contentSize);
                            break;
                        case ePointerSide.Bottom:
                            rectContent = new Rectangle(new Point((int)(cursorPosition.X - contentSize.Width / 2.0), cursorPosition.Y - contentSize.Height), contentSize);
                            break;
                    }

                    if (checkIfInBounds(rectContent))
                    {
                        success = true;
                        pos = testpost;
                    }
                }
            }

            if (success)
            {
                var rectShowBounds = new Rectangle(rectContent.Location, Size.Empty);
                var pointerOffset = (int)(Flyout1.Content.Width / 2.0 - FlyoutForm.PointerSize.Width / 2.0);
                Flyout1.Show(rectShowBounds, pos, pointerOffset, ItemListBox1);
            }
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
                MessageBoxEx.Show(this, TweaksGUILangRes.MsgBox_TweaksUpdatedSuccessfully, TweaksGUILangRes.MsgBox_TweaksUpdates_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show(this, TweaksGUILangRes.MsgBox_TweaksNotUpdated, TweaksGUILangRes.MsgBox_TweaksUpdates_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemListBox1_SelectedItemChanged(object sender, EventArgs e) => ItemListBox1_SelectedItemChanged();

        private void WarningBox_UpgradeLegacyTweaks_OptionsClick(object sender, EventArgs e)
        {
            ConvertLegacyTweaks();
        }

        private void ButtonX_UndoScript_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show(this, TweaksGUILangRes.MsgBox_RevertScript, TweaksGUILangRes.MsgBox_RevertScript_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ApplyUndoPatch(GetSelectedScript(), rommgr);
        }
    }
}