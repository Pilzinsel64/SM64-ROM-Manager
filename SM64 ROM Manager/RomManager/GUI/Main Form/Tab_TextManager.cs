using System;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.EventArguments;
using global::SM64_ROM_Manager.My.Resources;
using SM64Lib.TextValueConverter;
using Z.Core.Extensions;
using SM64Lib.Text;
using System.IO;

namespace SM64_ROM_Manager
{
    public partial class Tab_TextManager
    {

        // C o n s t a n t s

        private const string FILTER_EXPORT_TABLES = "Text file (*.txt)|*.txt|Excel file (*.xlsx)|*.xlsx";
        private const string FILTER_IMPORT_TABLES = "Excel file (*.xlsx)|*.xlsx";
        private const string FILTER_TEXT_PROFILE = "JSON (*.json)|*.json";

        // F i e l d s

        private bool TM_LoadingItem = false;
        private int TM_BytesLeft = 0;
        private bool loadingTextProfileList = false;

        private TextManagerController _TMController;

        public TextManagerController TMController
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TMController;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TMController != null)
                {

                    // C o n t r o l l e r   E v e n t s

                    _TMController.RequestReloadTextManagerLists -= Controller_RequestReloadTextManager;
                    _TMController.TextItemChanged -= Controller_TextItemChanged;
                    _TMController.ManyTextItemsChanged -= Controller_ManyTextItemsChanged;
                    _TMController.RequestReloadTextManagerLineColors -= Controller_RequestReloadTextManagerLineColors;
                    _TMController.TextItemAdded -= Controller_TextItemAdded;
                    _TMController.TextItemRemoved -= Controller_TextItemRemoved;
                    _TMController.CurrentTextProfileInfoChanged -= TMController_CurrentTextProfileInfoChanged;
                }

                _TMController = value;
                if (_TMController != null)
                {
                    _TMController.RequestReloadTextManagerLists += Controller_RequestReloadTextManager;
                    _TMController.TextItemChanged += Controller_TextItemChanged;
                    _TMController.ManyTextItemsChanged += Controller_ManyTextItemsChanged;
                    _TMController.RequestReloadTextManagerLineColors += Controller_RequestReloadTextManagerLineColors;
                    _TMController.TextItemAdded += Controller_TextItemAdded;
                    _TMController.TextItemRemoved += Controller_TextItemRemoved;
                    _TMController.CurrentTextProfileInfoChanged += TMController_CurrentTextProfileInfoChanged;
                }
            }
        }

        // C o n s t r u c t o r

        public Tab_TextManager()
        {
            // Components
            InitializeComponent();
            base.BackColor = Color.Transparent;

            var valuesSoundEffect = Enum.GetValues(typeof(SM64Lib.Text.DialogSoundEffect));
            foreach (var value in valuesSoundEffect)
                ComboBoxEx_SoundEffect.Items.Add(new ComboItem
                {
                    Tag = value,
                    Text = Form_Main_Resources.ResourceManager.GetString($"SoundEffect_{Enum.GetName(typeof(SM64Lib.Text.DialogSoundEffect), value)}")
                });
        }

        // E v e n t   H a n d l e r s

        private void Controller_RequestReloadTextManager()
        {
            LoadTableEntries();
        }

        private void Controller_TextItemChanged(TextItemEventArgs e)
        {
            UpdateListViewItem(e.ItemIndex);
            ShowCurTableBytes();
        }

        private void Controller_ManyTextItemsChanged()
        {
            UpdateAllListViewItems();
            ShowCurTableBytes();
        }

        private void Controller_RequestReloadTextManagerLineColors()
        {
            Line_TM_Green.ForeColor = Color.YellowGreen;
            Line_TM_Warning1.ForeColor = Color.Orange;
            Line_TM_Warning2.ForeColor = Color.Red;
        }

        private void Controller_TextItemAdded(TextItemEventArgs e)
        {
            AddTextListViewItem(e.TableName, e.ItemIndex, Array.Empty<string>());
        }

        private void Controller_TextItemRemoved(TextItemEventArgs e)
        {
            RemoveTextItem(e.ItemIndex);
        }

        private void TMController_CurrentTextProfileInfoChanged()
        {
            InitTextManager();
        }

        // F e a t u r e s

        private void InitTextManager()
        {
            LoadTabStripItems();
            UpdateTextProfileMenu();
        }

        private void RemoveTextItem(int tableIndex)
        {
            ListViewEx_TM_TableEntries.Items.RemoveAt(tableIndex);
        }

        private void LoadTabStripItems()
        {
            string oldSelected = Conversions.ToString(TabStrip_TextTable.SelectedTab?.Tag);
            TabItem tabToSelect = null;
            TabItem firstTab = null;
            var groupNames = TMController.GetTextGroupInfoNames();

            // Clear old ones
            TabStrip_TextTable.SuspendLayout();
            TabStrip_TextTable.SelectedTabIndex = -1;
            TabStrip_TextTable.Tabs.Clear();

            // Create & Add new Tabs
            for (int i = 0, loopTo = TMController.GetTextGroupInfosCount() - 1; i <= loopTo; i++)
            {
                var info = TMController.GetTextGroupInfos(groupNames[i]);
                var tab = new TabItem()
                {
                    Text = info.name,
                    Tag = info.name
                };
                TabStrip_TextTable.Tabs.Add(tab);
                if (firstTab is null)
                {
                    firstTab = tab;
                }

                if (tabToSelect is object && (info.name ?? "") == (oldSelected ?? ""))
                {
                    tabToSelect = tab;
                }
            }

            // Select tab
            if (tabToSelect is null && firstTab is object)
            {
                tabToSelect = firstTab;
            }

            TabStrip_TextTable.ResumeLayout();
            TabStrip_TextTable.SelectedTab = null;
            TabStrip_TextTable.SelectedTab = tabToSelect;
        }

        public void LoadTableEntries()
        {
            string tableName;

            var nameList = Array.Empty<string>();
            var col1 = ListViewEx_TM_TableEntries.Columns[1];
            var col2 = ListViewEx_TM_TableEntries.Columns[2];

            if (TabStrip_TextTable.Tabs.Count == 0) // First Init
                InitTextManager();

            tableName = Conversions.ToString(TabStrip_TextTable.SelectedTab?.Tag);
            TMController.StatusText = Form_Main_Resources.Status_LoadingTexts;
            TMController.LoadTextGroup(tableName);
            TMController.StatusText = Form_Main_Resources.Status_CreatingTextList;

            ListViewEx_TM_TableEntries.SuspendLayout();
            ListViewEx_TM_TableEntries.Items.Clear();

            string infos = TMController.GetTextGroupInfos(tableName).name;
            nameList = TMController.GetTextNameList(tableName);

            for (int i = 0, loopTo = TMController.GetTextGroupEntriesCount(tableName) - 1; i <= loopTo; i++)
                AddTextListViewItem(tableName, i, nameList);

            if (nameList.Any())
            {
                if (col1.Tag is object)
                {
                    col2.Width -= (int)col1.Tag;
                    col1.Width = Conversions.ToInteger(col1.Tag);
                    col1.Tag = null;
                }
            }
            else if (col1.Width > 0)
            {
                col1.Tag = col1.Width;
                col1.Width = 0;
                col2.Width += (int)col1.Tag;
            }

            ListViewEx_TM_TableEntries.ResumeLayout();
            if (ListViewEx_TM_TableEntries.Items.Count > 0)
            {
                var item = ListViewEx_TM_TableEntries.Items[0];
                item.Selected = true;
                item.EnsureVisible();
            }

            TMController.StatusText = Form_Main_Resources.Status_CalculatingTextSpace;
            ShowCurTableBytes();
            TMController.StatusText = string.Empty;
        }

        private void AddTextListViewItem(string tableName, int tableIndex, string[] nameList)
        {
            var itemInfos = TMController.GetTextItemInfos(tableName, tableIndex);
            string nameEntry = null;
            if (nameList.Count() > tableIndex)
                nameEntry = nameList[tableIndex];

            var newItem = new ListViewItem(new string[] { tableIndex.ToString(), string.Empty, string.Empty });
            UpdateListViewItem(newItem, nameEntry, itemInfos.text, false);
            ListViewEx_TM_TableEntries.Items.Add(newItem);
        }

        private void UpdateListViewItem(int index, bool refresh = true)
        {
            var lvi = ListViewEx_TM_TableEntries.Items[index];
            var infos = TMController.GetTextItemInfos(GetSelectedIndicies().tableName, index);
            UpdateListViewItem(lvi, infos.dialogDescription, infos.text, refresh);
        }

        private void UpdateListViewItem(ListViewItem lvi, string dialogDescription, string itemText, bool refresh = true)
        {
            if (string.IsNullOrEmpty(itemText))
                itemText = "-";
            else
            {
                var sr = new StringReader(itemText);
                itemText = sr.ReadLine();
                sr.Dispose();
            }
            lvi.SubItems[2].Text = itemText;
            if (dialogDescription is string)
                lvi.SubItems[1].Text = dialogDescription;
            if (refresh)
                ListViewEx_TM_TableEntries.Refresh();
        }

        private void UpdateAllListViewItems()
        {
            for (int i = 0, loopTo = ListViewEx_TM_TableEntries.Items.Count - 1; i <= loopTo; i++)
                UpdateListViewItem(i, false);
            ListViewEx_TM_TableEntries.Refresh();
        }

        public void SetGuiForTextTable()
        {
            SetGuiForTextTable(GetSelectedIndicies().tableName);
        }

        private void SetGuiForTextTable(string tableName)
        {
            var groupInfo = TMController.GetTextGroupInfos(tableName);
            bool isUpperCase = TMController.ForceUppercaseForActAndLevelNames && new[] { "Acts", "Levels", "File Menu" }.Contains(groupInfo.name);
            bool isPreDefined = new[] { "Acts", "Levels", "File Menu", "Dialogs", "Ending", "Credits" }.Contains(groupInfo.name);
            Line_TM_Green.Visible = groupInfo.isDialogGroup;
            Line_TM_Warning1.Visible = groupInfo.isDialogGroup;
            Line_TM_Warning2.Visible = groupInfo.isDialogGroup;
            GroupPanel_TM_DialogProps.Visible = groupInfo.isDialogGroup;
            TextBoxX_TM_TextEditor.CharacterCasing = isUpperCase ? CharacterCasing.Upper : CharacterCasing.Normal;
            ButtonItem_AddTextItem.Enabled = !isPreDefined;
            ButtonItem_RemoveTextItem.Enabled = !isPreDefined;
            if (IsAnyTextItemSelected())
            {
                LoadTableEntries();
            }
        }

        private (string tableName, int tableIndex) GetSelectedIndicies()
        {
            string tableName = Conversions.ToString(TabStrip_TextTable.SelectedTab?.Tag);
            int tableIndex = 0;
            if (ListViewEx_TM_TableEntries.SelectedIndices.Count > 0)
            {
                tableIndex = ListViewEx_TM_TableEntries.SelectedIndices[0];
            }

            return (tableName, tableIndex);
        }

        private void SaveItemText()
        {
            if (!TM_LoadingItem && !TMController?.IsChangingTab() == true)
            {
                var selIndicies = GetSelectedIndicies();
                string text = TextBoxX_TM_TextEditor.Text;
                TMController.SetTextItemText(selIndicies.tableName, selIndicies.tableIndex, text);
            }
        }

        private void SaveItemDialogData()
        {
            if (!TM_LoadingItem && !TMController.IsChangingTab())
            {
                var selIndicies = GetSelectedIndicies();
                var vPos = (DialogVerticalPosition)GetValueFromComboBox(ComboBoxEx_TM_DialogPosX.Text.Trim(), typeof(DialogVerticalPosition));
                var hPos = (DialogHorizontalPosition)GetValueFromComboBox(ComboBoxEx_TM_DialogPosY.Text.Trim(), typeof(DialogHorizontalPosition));
                var soundEffect = (DialogSoundEffect)((ComboItem)ComboBoxEx_SoundEffect.SelectedItem).Tag;
                int linesPerSite = IntegerInput_TM_DialogSize.Value;
                TMController.SetTextItemDialogData(selIndicies.tableName, selIndicies.tableIndex, vPos, hPos, soundEffect, linesPerSite);
            }
        }

        private short GetValueFromComboBox(string selText, Type posType)
        {
            var names = Enum.GetNames(posType);
            foreach (string n in names)
            {
                if (n.ToLower().Equals(selText.ToLower()))
                {
                    var v = Enum.GetValues(posType);
                    return (short)v.GetValue(Array.IndexOf(names, n));
                }
            }

            return Conversions.ToShort(TextValueConverter.ValueFromText(selText, short.MinValue));
        }

        private void ShowCurTableBytes()
        {
            var selIndicies = GetSelectedIndicies();
            if (!string.IsNullOrEmpty(selIndicies.tableName))
            {
                var res = TMController.CalcTextSpaceBytesCount(selIndicies.tableName, selIndicies.tableIndex);
                TM_BytesLeft = res.left;
                string newText = string.Format(Form_Main_Resources.Text_UsedOfMaxLeft, res.used, res.max, res.left);
                Color newColor;
                if (res.percent > 1)
                {
                    newColor = Color.Red;
                }
                else
                {
                    newColor = Color.Green;
                }

                TMController.SetOtherStatusInfos(newText, newColor);
            }
        }

        private bool IsAnyTextItemSelected()
        {
            return ListViewEx_TM_TableEntries.SelectedIndices.Count > 0;
        }

        private void ShowTextItemData()
        {
            var selectedIndicies = GetSelectedIndicies();
            if (!string.IsNullOrEmpty(selectedIndicies.tableName) && selectedIndicies.tableIndex > -1)
            {
                TM_LoadingItem = true;

                var groupInfo = TMController.GetTextGroupInfos(selectedIndicies.tableName);
                var itemInfo = TMController.GetTextItemInfos(selectedIndicies.tableName, selectedIndicies.tableIndex);

                TextBoxX_TM_TextEditor.Text = itemInfo.text;

                var isDescNull = itemInfo.dialogDescription == null;
                TextBoxX_ItemDescription.ReadOnly = isDescNull || TMController.UsingDefaultTextProfileInfo();
                if (isDescNull)
                    TextBoxX_ItemDescription.Text = TMController.GetTextNameList(selectedIndicies.tableName).ElementAtOrDefault(selectedIndicies.tableIndex);
                else
                    TextBoxX_ItemDescription.Text = itemInfo.dialogDescription;

                if (groupInfo.isDialogGroup)
                {
                    IntegerInput_TM_DialogSize.Value = itemInfo.linesPerSite;

                    int vIndex = Array.IndexOf(Enum.GetValues(typeof(SM64Lib.Text.DialogVerticalPosition)), itemInfo.verticalPosition);
                    if (vIndex >= 0)
                    {
                        ComboBoxEx_TM_DialogPosX.SelectedIndex = -1;
                        ComboBoxEx_TM_DialogPosX.SelectedIndex = vIndex;
                    }
                    else
                        ComboBoxEx_TM_DialogPosX.Text = TextValueConverter.TextFromValue((long)itemInfo.verticalPosition);

                    int hIndex = Array.IndexOf(Enum.GetValues(typeof(SM64Lib.Text.DialogHorizontalPosition)), itemInfo.horizontalPosition);
                    if (hIndex >= 0)
                    {
                        ComboBoxEx_TM_DialogPosY.SelectedIndex = -1;
                        ComboBoxEx_TM_DialogPosY.SelectedIndex = hIndex;
                    }
                    else
                        ComboBoxEx_TM_DialogPosY.Text = TextValueConverter.TextFromValue((long)itemInfo.horizontalPosition);

                    foreach (ComboItem cbitem in ComboBoxEx_SoundEffect.Items)
                    {
                        if ((DialogSoundEffect)cbitem.Tag == itemInfo.soundEffect)
                            ComboBoxEx_SoundEffect.SelectedItem = cbitem;
                    }
                }

                TM_LoadingItem = false;
            }
        }

        private async void ExportTextTables(bool currentOnly)
        {
            var sfd_ExportTextTable = new SaveFileDialog
            {
                Filter = FILTER_EXPORT_TABLES
            };

            if (sfd_ExportTextTable.ShowDialog(this) == DialogResult.OK)
            {
                if (currentOnly)
                    await TMController.ExportTextTable(sfd_ExportTextTable.FileName, GetSelectedIndicies().tableName);
                else
                    await TMController.ExportAllTextTables(sfd_ExportTextTable.FileName);
            }
        }

        private async void ImportTextTables()
        {
            var ofd_ExportTextTable = new OpenFileDialog
            {
                Filter = FILTER_IMPORT_TABLES
            };

            if (ofd_ExportTextTable.ShowDialog(this) == DialogResult.OK)
                await TMController.ImportTextTables(ofd_ExportTextTable.FileName);
        }

        private void UpdateTextProfileMenu()
        {
            var isDefautl = TMController.UsingDefaultTextProfileInfo();
            ButtonItem_CreateProfile.Enabled = isDefautl;
            ButtonItem_ExportProfile.Enabled = !isDefautl;
            ButtonItem_ResetProfile.Enabled = !isDefautl;
            ButtonItem_ManageProfile.Enabled = !isDefautl;
        }

        // G u i

        private void TabStrip1_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
        {
            SetGuiForTextTable();
        }

        private void TM_CheckComboBoxText(object sender, EventArgs e = null)
        {
            SaveItemDialogData();
        }

        private void IntegerInput_TM_DialogSize_ValueChanged(object sender, EventArgs e)
        {
            SaveItemDialogData();
        }

        private void TextBoxX_TM_TextEditor_TextChanged(object sender, EventArgs e)
        {
            SaveItemText();
        }

        private void ListViewEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsAnyTextItemSelected())
            {
                ShowTextItemData();
            }
        }

        private void ButtonItem_AddTextItem_Click(object sender, EventArgs e)
        {
            TMController.AddNewTextTableItem(GetSelectedIndicies().tableName);
        }

        private void ButtonItem_RemoveTextItem_Click(object sender, EventArgs e)
        {
            var index = GetSelectedIndicies();
            TMController.RemoveTextTableItem(index.tableName, index.tableIndex);
        }

        private void ButtonItemAddSpecialChar_Click(object sender, EventArgs e)
        {
            TextBoxX_TM_TextEditor.Paste((string)((ButtonItem)sender).Tag);
        }

        private void TextBoxX_TM_TextEditor_SizeChanged(object sender, EventArgs e)
        {
            int top = TextBoxX_TM_TextEditor.Top;
            int height = TextBoxX_TM_TextEditor.Height;
            Line_TM_Green.Top = top;
            Line_TM_Green.Height = height;
            Line_TM_Warning1.Top = top;
            Line_TM_Warning1.Height = height;
            Line_TM_Warning2.Top = top;
            Line_TM_Warning2.Height = height;
        }

        private void ButtonItem_ClearAllItems_Click(object sender, EventArgs e)
        {
            TMController.ClearTextItems(GetSelectedIndicies().tableName);
        }

        private void TextBoxX_ItemDescription_TextChanged(object sender, EventArgs e)
        {
            if (!TM_LoadingItem)
            {
                var sels = GetSelectedIndicies();
                TMController.SetDialogItemDescription(sels.tableName, sels.tableIndex, TextBoxX_ItemDescription.Text.Trim());
            }
        }

        private void ComboBoxEx_SoundEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveItemDialogData();
        }

        private void ButtonItem_ExportCurTable_Click(object sender, EventArgs e)
        {
            ExportTextTables(true);   
        }

        private void ButtonItem_ExportAllTables_Click(object sender, EventArgs e)
        {
            ExportTextTables(false);
        }

        private void ButtonItem_ImportFrom_Click(object sender, EventArgs e)
        {
            ImportTextTables();
        }

        private void ButtonItem_ResetProfile_Click(object sender, EventArgs e)
        {
            TMController.ResetTextPRofileInfo();
        }

        private void ButtonItem_ManageProfile_Click(object sender, EventArgs e)
        {
            TMController.OpenTextProfileEditor();
            InitTextManager();
        }

        private void ButtonItem_ExportProfile_Click(object sender, EventArgs e)
        {
            var sfd_ExportTextProfileInfo = new SaveFileDialog
            {
                Filter = FILTER_TEXT_PROFILE
            };
            if (sfd_ExportTextProfileInfo.ShowDialog(this) == DialogResult.OK)
                TMController.ExportTextProfile(sfd_ExportTextProfileInfo.FileName);
        }

        private void ButtonItem_ImportProfile_Click(object sender, EventArgs e)
        {
            var ofd_ImportTextProfileInfo = new OpenFileDialog
            {
                Filter = FILTER_TEXT_PROFILE
            };
            if (ofd_ImportTextProfileInfo.ShowDialog(this) == DialogResult.OK)
                TMController.ImportTextProfile(ofd_ImportTextProfileInfo.FileName);
        }

        private void ButtonItem_CreateProfile_Click(object sender, EventArgs e)
        {
            TMController.CreateNewTextProfileInfoIfUsingDefault();
        }
    }
}