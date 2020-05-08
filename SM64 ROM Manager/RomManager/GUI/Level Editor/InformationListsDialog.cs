using System;
using System.Collections;
using System.Collections.Generic;
using global::System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using global::DevComponents.AdvTree;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.TextValueConverter;
using Z.Core.Extensions;

namespace SM64_ROM_Manager.LevelEditor
{
    public partial class InformationListDialog
    {
        private ObjectComboList avaiableCombos = null;
        private BehaviorInfoList avaiableBehaviors = null;
        private EditModes editMode;
        private bool finishedLoading = false;
        private readonly List<BaseItem> objComboListItems = new List<BaseItem>();
        private readonly List<BaseItem> behavListItems = new List<BaseItem>();

        // E N U M S

        public enum EditModes
        {
            Editable = 1,
            EnableObjComboTab = 2,
            EnableBehavTab = 4
        }

        public enum ItemsType
        {
            ObjCombos,
            Behavs
        }

        // C O N S T R U C T O R S

        public InformationListDialog(EditModes editMode) : this(editMode, null, null)
        {
        }

        public InformationListDialog(EditModes editMode, ObjectComboList avaiableCombos, BehaviorInfoList avaiableBehaviors)
        {
            this.avaiableCombos = avaiableCombos;
            this.avaiableBehaviors = avaiableBehaviors;
            InitializeComponent();
            SetUpPropertyGrid();
            this.editMode = editMode;
            General.LoadObjectCombosIfEmpty();
            General.LoadBehaviorInfosIfEmpty();
            SetUI();
            TextBoxX_Search.Select();
            base.UpdateAmbientColors();
        }

        // P R O P E R T I E S

        private bool EnableEdit
        {
            get
            {
                return (editMode & EditModes.Editable) == EditModes.Editable;
            }
        }

        public bool EnableObjCombos
        {
            get
            {
                return (editMode & EditModes.EnableObjComboTab) == EditModes.EnableObjComboTab;
            }
        }

        public bool EnableBehavs
        {
            get
            {
                return (editMode & EditModes.EnableBehavTab) == EditModes.EnableBehavTab;
            }
        }

        public ObjectCombo SelectedObjectCombo
        {
            get
            {
                if (CurrentItemsType == ItemsType.ObjCombos)
                {
                    return (ObjectCombo)ItemList.SelectedItem?.Tag;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (CurrentItemsType == ItemsType.ObjCombos)
                {
                    bool hasFound = false;
                    foreach (BaseItem item in objComboListItems)
                    {
                        if (item?.Tag is ObjectCombo && !hasFound && item.Tag == value)
                        {
                            ItemList.SelectedItem = item;
                            ItemList.EnsureVisible(item);
                            ItemList.Refresh();
                            hasFound = true;
                        }
                    }
                }
            }
        }

        public BehaviorInfo SelectedBehavior
        {
            get
            {
                if (CurrentItemsType == ItemsType.Behavs)
                {
                    return (BehaviorInfo)ItemList.SelectedItem?.Tag;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (CurrentItemsType == ItemsType.Behavs)
                {
                    bool hasFound = false;
                    foreach (BaseItem item in behavListItems)
                    {
                        if (item?.Tag is BehaviorInfo && !hasFound && item.Tag == value)
                        {
                            ItemList.SelectedItem = item;
                            ItemList.EnsureVisible(item);
                            ItemList.Refresh();
                            hasFound = true;
                        }
                    }
                }
            }
        }

        public ItemsType CurrentItemsType
        {
            get
            {
                if (TabStrip1.SelectedTab == TabItem_ObjectCombos)
                {
                    return ItemsType.ObjCombos;
                }
                else if (TabStrip1.SelectedTab == TabItem_Behaviors)
                {
                    return ItemsType.Behavs;
                }
                else
                {
                    return default;
                }
            }
        }

        private IEnumerable CurrentObjectList
        {
            get
            {
                var switchExpr = CurrentItemsType;
                switch (switchExpr)
                {
                    case ItemsType.ObjCombos:
                        {
                            return General.ObjectCombos;
                        }

                    case ItemsType.Behavs:
                        {
                            return General.BehaviorInfos;
                        }

                    default:
                        {
                            return null;
                        }
                }
            }
        }

        private IList CurrentCustomObjectList
        {
            get
            {
                var switchExpr = CurrentItemsType;
                switch (switchExpr)
                {
                    case ItemsType.ObjCombos:
                        {
                            return General.ObjectCombosCustom;
                        }

                    case ItemsType.Behavs:
                        {
                            return General.BehaviorInfosCustom;
                        }

                    default:
                        {
                            return null;
                        }
                }
            }
        }

        private List<BaseItem> CurrentItemsList
        {
            get
            {
                var switchExpr = CurrentItemsType;
                switch (switchExpr)
                {
                    case ItemsType.ObjCombos:
                        {
                            return objComboListItems;
                        }

                    case ItemsType.Behavs:
                        {
                            return behavListItems;
                        }

                    default:
                        {
                            return null;
                        }
                }
            }
        }

        // F U N C T I O N S

        private void SetUpPropertyGrid()
        {
            // Make B. Params expandable
            for (int i = 1; i <= 4; i++)
            {
                var propset = new PropertySettings();
                propset.DisplayName = "Param " + Conversions.ToString(i);
                propset.PropertyName = "BParam" + Conversions.ToString(i);
                propset.TypeConverter = new ExpandableObjectConverter();
                AdvPropertyGrid1.PropertySettings.Add(propset);
            }

            // Set Property Display Names
            var dic = new Dictionary<string, string>() { { "BehaviorAddress", "Behavior Address" }, { "ModelAddress", "Model Address" }, { "ObjectCombo.ModelID", "Model ID" } };
            foreach (var kvp in dic)
            {
                var propset = new PropertySettings();
                propset.PropertyName = kvp.Key;
                propset.DisplayName = kvp.Value;
                AdvPropertyGrid1.PropertySettings.Add(propset);
            }

            // Hide "BehaviorAddressText" Property
            if (true)
            {
                var propset = new PropertySettings();
                propset.PropertyName = nameof(BehaviorInfo.BehaviorAddressText);
                propset.Visible = false;
                AdvPropertyGrid1.PropertySettings.Add(propset);
            }

            // Add handler for Node created
            AdvPropertyGrid1.PropertyTree.NodeMouseUp += (_, __) => SetBParamValueText();
            AdvPropertyGrid1.PropertyTree.AfterNodeSelect += (_, __) => SetBParamValueText();
            AdvPropertyGrid1.PropertyTree.AfterNodeInsert += SetNodeValueReadOnly;
        }

        private void SetUI()
        {
            Bar1.Visible = EnableEdit;
            TabItem_Behaviors.Visible = EnableBehavs;
            TabItem_ObjectCombos.Visible = EnableObjCombos;
            TabStrip1.SelectedTab = null;

            switch (true)
            {
                case object _ when EnableObjCombos:
                    {
                        TabStrip1.SelectedTab = TabItem_ObjectCombos;
                        break;
                    }

                case object _ when EnableBehavs:
                    {
                        TabStrip1.SelectedTab = TabItem_Behaviors;
                        break;
                    }
            }
        }

        private void LoadItems()
        {
            if (CurrentItemsList.Any())
            {
                // List Items
                ListItems();
            }
            else
            {
                // Load items
                LoadNewItems();
            }
        }

        private void LoadNewItems()
        {
            var itemsList = CurrentItemsList;

            // Create & Add Items to Item List
            // itemsList.Add(New LabelItem With {.Text = "Default Objects:", .FontBold = True, .ForeColor = Color.FromArgb(&HFF2B5DA8), .BeginGroup = False})
            foreach (object obj in CurrentObjectList)
                itemsList.Add(GetItemFrom(obj));
            // itemsList.Add(New LabelItem With {.Text = "User Defined Objects:", .FontBold = True, .ForeColor = Color.FromArgb(&HFF2B5DA8), .BeginGroup = False})
            foreach (object obj in CurrentCustomObjectList)
                itemsList.Add(GetItemFrom(obj));

            if (!EnableEdit)
            {
                if (EnableObjCombos && avaiableCombos is object)
                {
                    foreach (ObjectCombo combo in avaiableCombos)
                    {
                        if (!General.ObjectCombos.Contains(combo) && !General.ObjectCombosCustom.Contains(combo))
                            itemsList.Add(GetItemFrom(combo));
                    }
                }
                else if (EnableBehavs && avaiableBehaviors is object)
                {
                    foreach (BehaviorInfo behav in avaiableBehaviors)
                    {
                        if (!General.BehaviorInfos.Contains(behav) && !General.BehaviorInfosCustom.Contains(behav))
                            itemsList.Add(GetItemFrom(behav));
                    }
                }
            }

            // List Items
            ListItems();
        }

        private ButtonItem GetItemFrom(object obj)
        {
            if (obj is ObjectCombo)
            {
                return GetItemFromObjCombo((ObjectCombo)obj);
            }
            else if (obj is BehaviorInfo)
            {
                return GetItemFromBehav((BehaviorInfo)obj);
            }
            else
            {
                return null;
            }
        }

        private ButtonItem GetItemFromObjCombo(ObjectCombo obj)
        {
            return new ButtonItem()
            {
                Text = GetItemTextFromObjCombo(obj),
                Tag = obj,
                ForeColor = avaiableCombos?.Contains(obj) == true ? Color.DarkGreen : default
            };
        }

        private ButtonItem GetItemFromBehav(BehaviorInfo obj)
        {
            return new ButtonItem()
            {
                Text = GetItemTextFromBehav(obj),
                Tag = obj
            };
        }

        private string GetItemTextFrom(object obj)
        {
            if (obj is ObjectCombo)
            {
                return GetItemTextFromObjCombo((ObjectCombo)obj);
            }
            else if (obj is BehaviorInfo)
            {
                return GetItemTextFromBehav((BehaviorInfo)obj);
            }
            else
            {
                return string.Empty;
            }
        }

        private string GetItemTextFromObjCombo(ObjectCombo obj)
        {
            return obj.Name;
        }

        private string GetItemTextFromBehav(BehaviorInfo obj)
        {
            return $"{obj.BehaviorAddressText} - {obj.Name}";
        }

        private void ListItems()
        {
            if (ItemList.Tag is null || Conversions.ToBoolean(!Operators.ConditionalCompareObjectEqual(ItemList.Tag, CurrentItemsType, false)))
            {
                ListNewItems();
            }
        }

        private void ListNewItems()
        {
            ListNewItems(string.Empty);
        }

        private void ListNewItems(string filter)
        {
            ItemList.SuspendLayout();
            filter = filter.Trim().ToLower();

            // Clear all items
            ItemList.Items.Clear();

            // Set current items type to list
            ItemList.Tag = CurrentItemsType;

            // List Items
            if (string.IsNullOrEmpty(filter))
            {
                // List all Items
                ItemList.Items.AddRange(CurrentItemsList.ToArray());
            }
            else
            {
                // Get Filter
                string[] filters = (string[])General.GetFiltersFromFilter(filter, ' ');

                // Filter & List Items
                foreach (BaseItem btn in CurrentItemsList)
                {
                    bool allowAdd = false;
                    if (btn is ButtonItem && btn.Tag is object)
                    {
                        // Check if Item equals Filter
                        foreach (string f in filters)
                        {
                            if (!allowAdd && EqualsFilterIn(filter, btn.Tag))
                            {
                                allowAdd = true;
                            }
                        }
                    }
                    else if (btn is LabelItem)
                    {
                        // Label Items that defines the groups are allowed
                        allowAdd = true;
                    }

                    // Add Item
                    if (allowAdd)
                    {
                        ItemList.Items.Add(btn);
                    }
                }
            }

            // Select first Item
            if (ItemList.Items.Count > 0)
                ItemList.SelectedIndex = 0;

            // Reset Modified-Flag for Search Box
            TextBoxX_Search.Modified = false;
            ItemList.ResumeLayout();
            ItemList.Refresh();
            ItemList.RecalcLayout();
        }

        private bool EqualsFilterIn(string filter, object obj)
        {
            if (obj is ObjectCombo)
            {
                return EqualsFilterInObjectCombo(filter, (ObjectCombo)obj);
            }
            else if (obj is BehaviorInfo)
            {
                return EqualsFilterInBehaviorInfo(filter, (BehaviorInfo)obj);
            }
            else
            {
                return false;
            }
        }

        private bool EqualsFilterInObjectCombo(string filter, ObjectCombo obj)
        {
            return obj.Name.ToLower().Contains(filter) || TextValueConverter.TextFromValue(obj.BehaviorAddress).ToLower().Contains(filter) || TextValueConverter.TextFromValue(obj.ModelAddress).ToLower().Contains(filter);
        }

        private bool EqualsFilterInBehaviorInfo(string filter, BehaviorInfo obj)
        {
            return obj.Name.ToLower().Contains(filter) || TextValueConverter.TextFromValue(obj.BehaviorAddress).ToLower().Contains(filter);
        }

        private void AddNewItem()
        {
            // Create Object Combo
            object objCombo = null;
            var switchExpr = CurrentItemsType;
            switch (switchExpr)
            {
                case ItemsType.ObjCombos:
                    {
                        objCombo = new ObjectCombo();
                        break;
                    }

                case ItemsType.Behavs:
                    {
                        objCombo = new BehaviorInfo();
                        break;
                    }
            }

            // Add new Object Combo
            CurrentCustomObjectList.Add(objCombo);

            // Create new Item
            BaseItem item = GetItemFrom(objCombo);

            // Add new Item
            CurrentItemsList.Add(item);
            ItemList.SuspendLayout();
            ItemList.Items.Add(item);
            ItemList.SelectedItem = item;
            ItemList.ResumeLayout();
            ItemList.Refresh();
            ItemList.EnsureVisible(item);
        }

        private void RemoveItem()
        {
            var item = ItemList.SelectedItem;
            object objCombo;
            int index;
            if (item is object)
            {
                objCombo = item.Tag;
                index = ItemList.SelectedIndex;

                // Remove Item
                ItemList.Items.Remove(item);
                ItemList.ResumeLayout();
                ItemList.Refresh();
                CurrentItemsList.Remove(item);

                // Remove Object Combo
                CurrentCustomObjectList.Remove(objCombo);

                // Select other item in list
                SelectItemAt(index);
                ItemList.Refresh();
            }
        }

        private void ShowItemProperties()
        {
            var selItem = ItemList.SelectedItem;
            AdvPropertyGrid1.SelectedObject = selItem?.Tag;
            ButtonItem_Remove.Enabled = selItem?.Tag is object && CurrentCustomObjectList.Contains(selItem.Tag);
        }

        private void UpdateItemText(BaseItem btn)
        {
            btn.Text = GetItemTextFrom(btn.Tag);
            ItemList.Refresh();
        }

        // F O R M   C O N T R O L S

        private void SelectItemAt(int index)
        {
            while (ItemList.Items.Count <= index && index > -1)
                index -= 1;
            if (index > -1)
            {
                ItemList.SelectedItem = ItemList.Items[index];
                ItemList.EnsureVisible(ItemList.SelectedItem);
            }
        }

        private void SetBParamValueText()
        {
            for (int i = 1; i <= 4; i++)
            {
                var n = AdvPropertyGrid1.GetPropertyNode("BParam" + Conversions.ToString(i));
                if (n is object)
                {
                    if (n.Cells.Count >= 2)
                    {
                        n.Cells[1].TextMarkupEnabled = true;
                        n.Cells[1].Text = "<i>(Expand...)</i>";
                    }
                }
            }
        }

        private void SetNodeValueReadOnly(object sender, TreeNodeCollectionEventArgs e)
        {
            if (!EnableEdit)
            {
                setNodes(AdvPropertyGrid1.PropertyTree.Nodes);
                void setNodes(NodeCollection nodes)
                {
                    foreach (Node n in nodes)
                    {
                        if (n is PropertyNode)
                        {
                            PropertyNode prop = (PropertyNode)n;
                            prop.IsReadOnly = true;
                        }
                        setNodes(n.Nodes);
                    }
                }
            }
        }

        private void ItemListBox1_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            if (!EnableEdit)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void ItemList_SelectedItemChanged(object sender, EventArgs e)
        {
            ShowItemProperties();
        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void ButtonItem3_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void TextBoxX_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TextBoxX_Search.Modified)
            {
                ListNewItems(TextBoxX_Search.Text);
            }
        }

        private void ButtonX_CancelSearch_Click(object sender, EventArgs e)
        {
            bool wasEmpty = string.IsNullOrEmpty(TextBoxX_Search.Text.Trim());
            TextBoxX_Search.Text = string.Empty;
            if (!wasEmpty)
                ListNewItems();
        }

        private void TabStrip1_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
        {
            if (e.NewTab != null)
            {
                base.Text = e.NewTab.Text;
                TextBoxX_Search.Text = string.Empty;
                TextBoxX_Search.Modified = false;
                LoadItems();
            }
        }

        private void AdvPropertyGrid1_ConvertPropertyValueToString(object sender, ConvertValueEventArgs e)
        {
            var switchExpr = e.PropertyDescriptor.PropertyType;
            switch (switchExpr)
            {
                case var @case when @case == typeof(byte):
                case var case1 when case1 == typeof(sbyte):
                case var case2 when case2 == typeof(short):
                case var case3 when case3 == typeof(ushort):
                case var case4 when case4 == typeof(int):
                case var case5 when case5 == typeof(uint):
                    {
                        e.StringValue = TextValueConverter.TextFromValue(Conversions.ToLong(e.TypedValue));
                        e.IsConverted = true;
                        break;
                    }
            }
        }

        private void AdvPropertyGrid1_ConvertFromStringToPropertyValue(object sender, ConvertValueEventArgs e)
        {
            var switchExpr = e.PropertyDescriptor.PropertyType;
            switch (switchExpr)
            {
                case var @case when @case == typeof(byte):
                    {
                        e.TypedValue = Conversions.ToByte(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case1 when case1 == typeof(sbyte):
                    {
                        e.TypedValue = Conversions.ToSByte(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case2 when case2 == typeof(short):
                    {
                        e.TypedValue = Conversions.ToShort(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case3 when case3 == typeof(ushort):
                    {
                        e.TypedValue = Conversions.ToUShort(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case4 when case4 == typeof(int):
                    {
                        e.TypedValue = Conversions.ToInteger(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case5 when case5 == typeof(uint):
                    {
                        e.TypedValue = Conversions.ToUInteger(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case6 when case6 == typeof(float):
                    {
                        e.TypedValue = Conversions.ToSingle(e.StringValue.Trim());
                        e.IsConverted = true;
                        break;
                    }

                case var case7 when case7 == typeof(double):
                    {
                        e.TypedValue = Conversions.ToDouble(e.StringValue.Trim());
                        e.IsConverted = true;
                        break;
                    }

                case var case8 when case8 == typeof(decimal):
                    {
                        e.TypedValue = Conversions.ToDecimal(e.StringValue.Trim());
                        e.IsConverted = true;
                        break;
                    }
            }
        }

        private void AdvPropertyGrid1_PropertyValueChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((e.PropertyName ?? "") == "Name")
            {
                var selItem = ItemList.SelectedItem;
                if (selItem is ButtonItem && selItem.Tag is object)
                {
                    UpdateItemText(selItem);
                }
            }
        }

        private void ButtonItem_SaveAll_Click(object sender, EventArgs e)
        {
            General.SaveObjectCombos();
            General.SaveBehaviorInfos();
        }

        private void ButtonItem_ReloadList_Click(object sender, EventArgs e)
        {
            var switchExpr = CurrentItemsType;
            switch (switchExpr)
            {
                case ItemsType.ObjCombos:
                    {
                        General.LoadObjectCombos();
                        LoadNewItems();
                        break;
                    }

                case ItemsType.Behavs:
                    {
                        General.LoadBehaviorInfos();
                        LoadNewItems();
                        break;
                    }
            }
        }

        private void AdvPropertyGrid1_PropertiesLoaded(object sender, EventArgs e)
        {
            SetBParamValueText();
        }
    }
}