using System;
using global::System.ComponentModel;
using System.Windows.Forms;
using global::DevComponents.AdvTree;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.My.Resources;
using global::SM64Lib.Text.Profiles;

namespace SM64_ROM_Manager
{
    public partial class TextProfileEditor
    {

        // C O N S T R U C T O R S

        public TextProfileEditor()
        {
            // G U I
            base.Load += TextProfileEditor_Load;
            InitializeComponent();
            advPropGridMgr = new MinimalAdvPropertyGridManager(AdvPropertyGrid1);
            AdvTree1.Nodes.AddRange(new[] { nTableGroups, nArrayGroups });
            base.UpdateAmbientColors();
        }

        // P R I V A T E   F I E L D S

        private Node nTableGroups = new Node() { Text = TextProfileEditorLangRes.nTableGroups };
        private Node nArrayGroups = new Node() { Text = TextProfileEditorLangRes.nArrayGroups };
        private MinimalAdvPropertyGridManager advPropGridMgr;

        // A U T O M A T I C   P R O P E R T I E S

        public TextProfileInfo ProfileInfo { get; set; }

        // F E A T U R E S

        private void LoadAllGroups()
        {
            AdvTree1.SuspendLayout();
            nTableGroups.Nodes.Clear();
            nArrayGroups.Nodes.Clear();
            foreach (TextGroupInfo tg in ProfileInfo.AllGroups)
                AddTextGroupInfoNode(tg);
            AdvTree1.ExpandAll();
            AdvTree1.ResumeLayout();
        }

        private Node AddTextGroupInfoNode(TextGroupInfo tg)
        {
            var n = new Node()
            {
                Text = tg.Name,
                Tag = tg
            };
            if (tg.IsTextTableGroupInfo())
            {
                nTableGroups.Nodes.Add(n);
            }
            else if (tg.IsTextArrayGroupInfo())
            {
                nArrayGroups.Nodes.Add(n);
            }

            return n;
        }

        private void LoadGroup(TextGroupInfo group)
        {
            LoadPropertiesToEdit(group);
        }

        private void LoadArrayItem(TextArrayItemInfo item)
        {
            LoadPropertiesToEdit(item);
        }

        private void LoadPropertiesToEdit(object obj)
        {
            AdvPropertyGrid1.SelectedObject = null;
            AdvPropertyGrid1.PropertySettings.Clear();
            if (obj is TextGroupInfo)
            {
                var piEncodingString = new PropertySettings(nameof(TextGroupInfo.EncodingString))
                {
                    DisplayName = "Encoding",
                    ValueEditor = new PropertyValueEditors.TextEncodingEditor(new[] { TextGroupInfo.ENCODING_STRING_M64, TextGroupInfo.ENCODING_STRING_ASCII })
                };
                AdvPropertyGrid1.PropertySettings.Add(piEncodingString);
                var piEncoding = new PropertySettings(nameof(TextTableGroupInfo.Encoding)) { Visible = false };
                AdvPropertyGrid1.PropertySettings.Add(piEncoding);
                if (obj is TextTableGroupInfo)
                {
                    var piData = new PropertySettings(nameof(TextTableGroupInfo.Data)) { TypeConverter = new ExpandableObjectConverter() };
                    AdvPropertyGrid1.PropertySettings.Add(piData);
                    var piDialogData = new PropertySettings(nameof(TextTableGroupInfo.DialogData)) { TypeConverter = new ExpandableObjectConverter() };
                    AdvPropertyGrid1.PropertySettings.Add(piDialogData);
                    var piSegmented = new PropertySettings(nameof(TextTableGroupInfo.Segmented)) { TypeConverter = new ExpandableObjectConverter() };
                    AdvPropertyGrid1.PropertySettings.Add(piSegmented);
                    var piTableType = new PropertySettings(nameof(TextTableGroupInfo.TableType)) { Visible = false };
                    AdvPropertyGrid1.PropertySettings.Add(piTableType);
                }
                else if (obj is TextArrayGroupInfo)
                {
                    var piTexts = new PropertySettings(nameof(TextArrayGroupInfo.Texts)) { Visible = false };
                    AdvPropertyGrid1.PropertySettings.Add(piTexts);
                }

                LoadTextArrayItems((TextGroupInfo)obj);
            }

            AdvPropertyGrid1.SelectedObject = obj;
            AdvPropertyGrid1.ExpandAllGridItems();
        }

        private void LoadTextArrayItems(TextGroupInfo table)
        {
            ItemListBox1.SuspendLayout();
            ItemListBox1.Items.Clear();
            if (table is TextArrayGroupInfo)
            {
                foreach (TextArrayItemInfo item in ((TextArrayGroupInfo)table).Texts)
                    AddArrayItemListItem(item);
                AdvPropertyGrid1.Dock = DockStyle.Top;
                Panel3.Visible = true;
            }
            else
            {
                Panel3.Visible = false;
                AdvPropertyGrid1.Dock = DockStyle.Fill;
            }

            ItemListBox1.ResumeLayout();
            ItemListBox1.Refresh();
        }

        private ButtonItem AddArrayItemListItem(TextArrayItemInfo item)
        {
            var btn = new ButtonItem()
            {
                Text = Conversions.ToString(item.RomAddress),
                Tag = item
            };
            ItemListBox1.Items.Add(btn);
            return btn;
        }

        private TextGroupInfo GetSelectedGroupInfo()
        {
            return (TextGroupInfo)AdvTree1.SelectedNode?.Tag;
        }

        private TextArrayItemInfo GetSelectedArrayItemInfo()
        {
            if (ItemListBox1.Visible)
            {
                return (TextArrayItemInfo)ItemListBox1.SelectedItem?.Tag;
            }
            else
            {
                return null;
            }
        }

        private void AddArrayGroupInfo()
        {
            var tg = new TextArrayGroupInfo() { Name = "New Array Group", EncodingString = TextGroupInfo.ENCODING_STRING_M64 };
            ProfileInfo.TextArrayGroups.Add(tg);
            AddGroupInfo(tg);
        }

        private void AddTableGroupInfo()
        {
            var tg = new TextTableGroupInfo() { Name = "New Table Group", EncodingString = TextGroupInfo.ENCODING_STRING_M64 };
            ProfileInfo.TextTableGroups.Add(tg);
            AddGroupInfo(tg);
        }

        private void AddGroupInfo(TextGroupInfo group)
        {
            var n = AddTextGroupInfoNode(group);
            AdvTree1.SelectedNode = n;
        }

        private void RemoveSelectedGroupInfo()
        {
            var selNode = AdvTree1.SelectedNode;
            TextGroupInfo group = (TextGroupInfo)selNode?.Tag;
            if (group is object)
            {
                if (group is TextTableGroupInfo)
                {
                    nTableGroups.Nodes.Remove(selNode);
                    ProfileInfo.TextTableGroups.Remove((TextTableGroupInfo)group);
                }
                else if (group is TextArrayGroupInfo)
                {
                    nArrayGroups.Nodes.Remove(selNode);
                    ProfileInfo.TextArrayGroups.Remove((TextArrayGroupInfo)group);
                }
            }
        }

        private void AddArrayItemInfo()
        {
            var item = new TextArrayItemInfo();
            TextArrayGroupInfo group = (TextArrayGroupInfo)GetSelectedGroupInfo();
            group.Texts.Add(item);
            var btn = AddArrayItemListItem(item);
            ItemListBox1.Items.Add(btn);
            ItemListBox1.Refresh();
        }

        private void RemoveSelectedArrayItemInfo()
        {
            var item = ItemListBox1.SelectedItem;
            if (item?.Tag is object)
            {
                RemoveArrayItemInfo(item);
                ItemListBox1.Refresh();
            }
        }

        private void RemoveAllArrayItemInfos()
        {
            var items = new BaseItem[ItemListBox1.Items.Count + 1];
            ItemListBox1.Items.CopyTo(items, 0);
            ItemListBox1.SuspendLayout();
            foreach (BaseItem baseItem in items)
            {
                if (baseItem?.Tag is object)
                {
                    RemoveArrayItemInfo(baseItem);
                }
            }

            ItemListBox1.ResumeLayout();
            ItemListBox1.Refresh();
        }

        private void RemoveArrayItemInfoListItem(BaseItem item)
        {
            ItemListBox1.Items.Remove(item);
        }

        private void RemoveArrayItemInfo(BaseItem item)
        {
            TextArrayItemInfo tarrinfo = (TextArrayItemInfo)item.Tag;
            TextArrayGroupInfo group = (TextArrayGroupInfo)GetSelectedGroupInfo();
            if (group is object)
            {
                ItemListBox1.Items.Remove(item);
                group.Texts.Remove(tarrinfo);
            }
        }

        private void UpdateSelectedTextGroupInfoNode()
        {
            var n = AdvTree1.SelectedNode;
            TextGroupInfo gi = (TextGroupInfo)n?.Tag;
            if (gi is object)
            {
                n.Text = gi.Name;
            }
        }

        private void UpdateSelectedArrayItemInfoListItem()
        {
            var baseItem = ItemListBox1.SelectedItem;
            TextArrayItemInfo arrayItem = (TextArrayItemInfo)baseItem?.Tag;
            if (arrayItem is object)
            {
                baseItem.Text = Conversions.ToString(arrayItem.RomAddress);
                ItemListBox1.Refresh();
            }
        }

        private void TextProfileEditor_Load(object sender, EventArgs e)
        {
            LoadAllGroups();
        }

        private void AdvTree1_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            if (e.Node?.Tag is TextGroupInfo)
            {
                LoadGroup((TextGroupInfo)e.Node.Tag);
            }
            else
            {
                AdvPropertyGrid1.SelectedObject = null;
            }
        }

        private void ItemListBox1_SelectedChanged(object sender, EventArgs e)
        {
            ButtonItem item = ItemListBox1.SelectedItem as ButtonItem;
            if (item?.Tag is TextArrayItemInfo)
            {
                LoadArrayItem((TextArrayItemInfo)item.Tag);
            }
        }

        private void ButtonItem_AddTableGroup_Click(object sender, EventArgs e)
        {
            AddTableGroupInfo();
        }

        private void ButtonItem_AddArrayGroup_Click(object sender, EventArgs e)
        {
            AddArrayGroupInfo();
        }

        private void ButtonItem_RemoveGroup_Click(object sender, EventArgs e)
        {
            RemoveSelectedGroupInfo();
        }

        private void ButtonItem_AddArrayItem_Click(object sender, EventArgs e)
        {
            AddArrayItemInfo();
        }

        private void ButtonItem_ClearArrayItems_Click(object sender, EventArgs e)
        {
            RemoveAllArrayItemInfos();
        }

        private void ButtonItem_RemoveArrayItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedArrayItemInfo();
        }

        private void AdvPropertyGrid1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var switchExpr = e.PropertyName;
            switch (switchExpr)
            {
                case nameof(TextGroupInfo.Name):
                    {
                        UpdateSelectedTextGroupInfoNode();
                        break;
                    }

                case nameof(TextArrayItemInfo.RomAddress):
                    {
                        UpdateSelectedArrayItemInfoListItem();
                        break;
                    }
            }
        }
    }
}