using System;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::SM64Lib.Text.Profiles;

namespace SM64_ROM_Manager
{
    public partial class TextProfilesManagerDialog
    {

        // C o n s t r u c t o r s

        public TextProfilesManagerDialog()
        {
            this.Shown += TextProfilesManagerDialog_Shown;
            this.FormClosing += TextProfilesManagerDialog_FormClosing;
            InitializeComponent();
            base.UpdateAmbientColors();
        }

        // C o n s t a n t s

        private const string IMPORT_EXPORT_DIALOG_FILTER = "JSON (*.json)|*.json";

        // P r o p e r t i e s

        public MyTextProfileInfoManager MyTextProfiles { get; set; }

        // F e a t u r e s

        private void LoadList()
        {
            BaseItem itemToSelect = null;
            ItemPanel_Profiles.BeginUpdate();
            foreach (TextProfileInfo info in MyTextProfiles.Manager.GetTextProfiles())
            {
                var newItem = AddToItemPanel(info);
                if (itemToSelect is null)
                {
                    itemToSelect = newItem;
                }
            }

            ItemPanel_Profiles.EndUpdate();
            ItemPanel_Profiles.SelectedItem = itemToSelect;
        }

        private void LoadProfile(TextProfileInfo info)
        {
            bool isNull = info is null;
            bool canEdit = !isNull && info != MyTextProfiles.Manager.DefaultTextProfileInfo;
            ButtonX_Delete.Enabled = canEdit;
            ButtonX_Export.Enabled = canEdit;
            ButtonX_Edit.Enabled = canEdit;
            TextBoxX_ProfileName.Enabled = !isNull;
            TextBoxX_ProfileName.ReadOnly = !canEdit;
            TextBoxX_ProfileName.Text = isNull ? string.Empty : info.Name;
        }

        private TextProfileInfo GetSelectedProfile()
        {
            return (TextProfileInfo)ItemPanel_Profiles.SelectedItem?.Tag;
        }

        private void CreateProfile()
        {
            var info = MyTextProfiles.Manager.CreateTextProfile();
            MyTextProfiles.SaveTextProfile(info);
            var item = AddToItemPanel(info);
            ItemPanel_Profiles.Refresh();
            ItemPanel_Profiles.SelectedItem = item;
            ItemPanel_Profiles.EnsureVisible(item);
        }

        private BaseItem AddToItemPanel(TextProfileInfo info)
        {
            var btn = new ButtonItem()
            {
                Tag = info,
                Text = info.Name
            };
            btn.Click += (sender, e) => ItemPanel_Profiles.SelectedItem = (BaseItem)sender;
            ItemPanel_Profiles.Items.Add(btn);
            return btn;
        }

        private void EditProfile(TextProfileInfo info)
        {
            var editor = new TextProfileEditor() { ProfileInfo = info };
            editor.ShowDialog();
            MyTextProfiles.SaveTextProfile(info);
        }

        private void RemoveProfile(TextProfileInfo info)
        {
            MyTextProfiles.RemoveTextProfile(info);
            var items = new BaseItem[ItemPanel_Profiles.Items.Count];
            ItemPanel_Profiles.Items.CopyTo(items, 0);
            ItemPanel_Profiles.BeginUpdate();
            foreach (BaseItem item in items)
            {
                if (item?.Tag == info)
                {
                    ItemPanel_Profiles.Items.Remove(item);
                }
            }

            ItemPanel_Profiles.EndUpdate();
        }

        private void SetProfileName(TextProfileInfo info, string newName)
        {
            if (info is object && !string.IsNullOrEmpty(base.Text))
            {
                info.Name = newName;
                UpdateItems(info);
            }
        }

        private void UpdateItems(TextProfileInfo info)
        {
            ItemPanel_Profiles.BeginUpdate();
            foreach (BaseItem item in ItemPanel_Profiles.Items)
            {
                if (item.Tag == info)
                {
                    item.Text = info.Name;
                }
            }

            ItemPanel_Profiles.EndUpdate();
        }

        private void Import()
        {
            var ofd_ImportTextProfileInfo = new OpenFileDialog() { Filter = IMPORT_EXPORT_DIALOG_FILTER };
            if (ofd_ImportTextProfileInfo.ShowDialog() == DialogResult.OK)
            {
                var info = MyTextProfiles.Import(ofd_ImportTextProfileInfo.FileName);
                var item = AddToItemPanel(info);
                ItemPanel_Profiles.SelectedItem = item;
            }
        }

        private void Export(TextProfileInfo info)
        {
            var sfd_ExportTextProfileInfo = new SaveFileDialog() { Filter = IMPORT_EXPORT_DIALOG_FILTER };
            if (sfd_ExportTextProfileInfo.ShowDialog() == DialogResult.OK)
            {
                MyTextProfiles.Export(info, sfd_ExportTextProfileInfo.FileName);
            }
        }

        // G U I

        private void ButtonX_Create_Click(object sender, EventArgs e)
        {
            CreateProfile();
        }

        private void ButtonX_Edit_Click(object sender, EventArgs e)
        {
            EditProfile(GetSelectedProfile());
        }

        private void ButtonX_Delete_Click(object sender, EventArgs e)
        {
            RemoveProfile(GetSelectedProfile());
        }

        private void TextBoxX_ProfileName_TextChanged(object sender, EventArgs e)
        {
            SetProfileName(GetSelectedProfile(), TextBoxX_ProfileName.Text.Trim());
        }

        private void ButtonX_Import_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void ButtonX_Export_Click(object sender, EventArgs e)
        {
            Export(GetSelectedProfile());
        }

        private void ItemPanel_Profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProfile(GetSelectedProfile());
        }

        private void TextProfilesManagerDialog_Shown(object sender, EventArgs e)
        {
            LoadList();
        }

        private void TextProfilesManagerDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyTextProfiles.SaveAllTextProfile();
        }
    }
}