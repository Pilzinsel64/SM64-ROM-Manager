using System;
using System.Collections.Generic;
using global::System.ComponentModel;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Configuration;
using global::SM64Lib.Levels;
using global::SM64Lib.Levels.ScrolTex;
using global::SM64Lib.TextValueConverter;
using System.Linq;
using Z.Core.Extensions;

namespace SM64_ROM_Manager
{
    public partial class ScrollTexEditor
    {
        public event EventHandler ScrollTexAdded;
        public event EventHandler ScrollTexRemoved;
        public event EventHandler ScrollTexChanged;

        private bool simplifiedView = true;
        private readonly LevelArea cArea;
        private readonly LevelAreaConfig areaConfig;

        private PropertySettings propSettings_VertexPointer = new PropertySettings(nameof(ScrollTexPropertyClass.VertexPointer)) { Visible = false };
        private PropertySettings propSettings_FacesCount = new PropertySettings(nameof(ScrollTexPropertyClass.FacesCount)) { Visible = false };
        private PropertySettings propSettings_GroupID = new PropertySettings(nameof(ScrollTexPropertyClass.GroupID)) { Visible = false };

        public ScrollTexEditor(LevelArea area, LevelAreaConfig areaConfig)
        {
            base.Load += ScrollTexEditor_Load;

            // Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent();
            base.UpdateAmbientColors();

            // Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            cArea = area;
            this.areaConfig = areaConfig;

            // Add property configs
            AdvPropertyGrid1.PropertySettings.Add(propSettings_VertexPointer);
            AdvPropertyGrid1.PropertySettings.Add(propSettings_FacesCount);
            AdvPropertyGrid1.PropertySettings.Add(propSettings_GroupID);
        }

        private void ScrollTexEditor_Load(object sender, EventArgs e)
        {
            LoadScrollTexts();
        }

        private void AdvPropertyGrid1_ConvertFromStringToPropertyValue(object sender, ConvertValueEventArgs e)
        {
            var switchExpr = e.PropertyDescriptor.PropertyType;
            switch (switchExpr)
            {
                case var @case when @case == typeof(bool):
                    {
                        if ((e.StringValue ?? "") == "Yes")
                        {
                            e.TypedValue = true;
                        }
                        else
                        {
                            e.TypedValue = false;
                        }

                        e.IsConverted = true;
                        break;
                    }

                case var case1 when case1 == typeof(byte):
                    {
                        e.TypedValue = Conversions.ToByte(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case2 when case2 == typeof(sbyte):
                    {
                        e.TypedValue = Conversions.ToSByte(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case3 when case3 == typeof(short):
                    {
                        e.TypedValue = Conversions.ToShort(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case4 when case4 == typeof(ushort):
                    {
                        e.TypedValue = Conversions.ToUShort(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case5 when case5 == typeof(int):
                    {
                        e.TypedValue = Conversions.ToInteger(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case6 when case6 == typeof(uint):
                    {
                        e.TypedValue = Conversions.ToUInteger(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case7 when case7 == typeof(float):
                    {
                        e.TypedValue = Conversions.ToSingle(e.StringValue.Trim());
                        e.IsConverted = true;
                        break;
                    }

                case var case8 when case8 == typeof(double):
                    {
                        e.TypedValue = Conversions.ToDouble(e.StringValue.Trim());
                        e.IsConverted = true;
                        break;
                    }

                case var case9 when case9 == typeof(decimal):
                    {
                        e.TypedValue = Conversions.ToDecimal(e.StringValue.Trim());
                        e.IsConverted = true;
                        break;
                    }
            }
        }

        private void AdvPropertyGrid1_ConvertPropertyValueToString(object sender, ConvertValueEventArgs e)
        {
            var switchExpr = e.PropertyDescriptor.PropertyType;
            switch (switchExpr)
            {
                case var @case when @case == typeof(bool):
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(e.TypedValue, true, false)))
                        {
                            e.StringValue = "Yes";
                        }
                        else
                        {
                            e.StringValue = "No";
                        }

                        e.IsConverted = true;
                        break;
                    }

                case var case1 when case1 == typeof(byte):
                case var case2 when case2 == typeof(sbyte):
                case var case3 when case3 == typeof(short):
                case var case4 when case4 == typeof(ushort):
                case var case5 when case5 == typeof(int):
                case var case6 when case6 == typeof(uint):
                    {
                        e.StringValue = TextValueConverter.TextFromValue(Conversions.ToLong(e.TypedValue));
                        e.IsConverted = true;
                        break;
                    }
            }
        }

        private void AdvPropertyGrid1_PropertyValueChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateAllListViewItems();
            AdvPropertyGrid1.RefreshPropertyValues();
            ScrollTexChanged?.Invoke(this, new EventArgs());
        }

        private void LoadScrollTexts()
        {
            ListViewEx_LM_ScrollTexList.BeginUpdate();

            // Remove current items & groups & columns
            ListViewEx_LM_ScrollTexList.Clear();

            // Add columns
            ListViewEx_LM_ScrollTexList.Columns.Add(ColumnHeader_Number);
            if (simplifiedView) ListViewEx_LM_ScrollTexList.Columns.Add(columnHeader_MaterialName);
            ListViewEx_LM_ScrollTexList.Columns.Add(ColumnHeader_Behavior);
            ListViewEx_LM_ScrollTexList.Columns.Add(ColumnHeader_Type);
            ListViewEx_LM_ScrollTexList.Columns.Add(ColumnHeader_Duration);
            ListViewEx_LM_ScrollTexList.Columns.Add(ColumnHeader_Speed);
            if (!simplifiedView) ListViewEx_LM_ScrollTexList.Columns.Add(ColumnHeader_VertexPointer);
            ListViewEx_LM_ScrollTexList.Columns.Add(ColumnHeader_Vertices);

            // Add new items
            if (simplifiedView)
            {
                var dic = new Dictionary<int, List<ManagedScrollingTexture>>();
                foreach (ManagedScrollingTexture scrollTex in cArea.ScrollingTextures.OrderBy(n => n.GroupID))
                {
                    if (dic.ContainsKey(scrollTex.GroupID))
                        dic[scrollTex.GroupID].Add(scrollTex);
                    else
                        dic.Add(scrollTex.GroupID, new List<ManagedScrollingTexture>() { scrollTex });
                }
                foreach (var value in dic.Values)
                    AddListViewItem(value.ToArray());
            }
            else
            {
                foreach (ManagedScrollingTexture scrollTex in cArea.ScrollingTextures.OrderBy(n => n.GroupID))
                    AddListViewItem(scrollTex);
            }

            // Update new items
            UpdateAllListViewItems();

            ListViewEx_LM_ScrollTexList.EndUpdate();

            // Select first item
            if (ListViewEx_LM_ScrollTexList.Items.Count > 0)
                ListViewEx_LM_ScrollTexList.Items[0].Selected = true;
        }

        private void AddListViewItem(ManagedScrollingTexture scrollTex)
            => AddListViewItem(new[] { scrollTex });

        private void AddListViewItem(ManagedScrollingTexture[] scrollTex)
        {
            var lvi = new ListViewItem();
            lvi.Tag = scrollTex.Select(n => new ScrollTexPropertyClass(n)).ToArray();

            for (int i = 1; i <= 7; i++)
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem());

            ListViewEx_LM_ScrollTexList.Items.Add(lvi);
        }

        private void UpdateAllListViewItems()
        {
            int counter = 1;

            ListViewEx_LM_ScrollTexList.BeginUpdate();

            foreach (ListViewItem item in ListViewEx_LM_ScrollTexList.Items)
            {
                var scrollTexes = (ScrollTexPropertyClass[])item.Tag;
                var scrollTex = scrollTexes.First();
                var sii = 0;

                if (!simplifiedView)
                    SetLvGroup(item, scrollTex.GroupID);

                item.SubItems[sii++].Text = Conversions.ToString(counter);

                if (simplifiedView)
                    item.SubItems[sii++].Text = GetMaterialName(scrollTex.GroupID);

                item.SubItems[sii++].Text = scrollTex.Behavior.ToString();
                item.SubItems[sii++].Text = scrollTex.Type.ToString();
                item.SubItems[sii++].Text = Conversions.ToString(scrollTex.CycleDuration);
                item.SubItems[sii++].Text = Conversions.ToString(scrollTex.ScrollingSpeed);

                if (!simplifiedView)
                    item.SubItems[sii++].Text = Conversions.ToString(TextValueConverter.ValueFromText(Conversions.ToString(scrollTex.VertexPointer)));

                item.SubItems[sii++].Text = Conversions.ToString(scrollTexes.Sum(n => n.FacesCount));

                counter += 1;
            }

            ListViewEx_LM_ScrollTexList.EndUpdate();
        }

        private void SetLvGroup(ListViewItem item, short groupID)
        {
            ListViewGroup lvg = null;
            foreach (ListViewGroup lvgg in ListViewEx_LM_ScrollTexList.Groups)
            {
                if (lvg is null && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvgg.Tag, groupID, false)))
                    lvg = lvgg;
            }

            if (lvg is null)
            {
                lvg = new ListViewGroup()
                {
                    Tag = groupID,
                    Header = $"Group {groupID} - {GetMaterialName(groupID)}"
                };
                ListViewEx_LM_ScrollTexList.Groups.Add(lvg);
            }

            item.Group = lvg;
        }

        private string GetMaterialName(short groupID)
        {
            if (!areaConfig.ScrollingNames.TryGetValue(groupID, out string texName))
                texName = "Unknown Material Name";
            return texName;
        }

        private void ListViewEx_LM_ScrollTexList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objs = new List<ScrollTexPropertyClass>();

            foreach (ListViewItem item in ListViewEx_LM_ScrollTexList.SelectedItems)
                objs.AddRange((ScrollTexPropertyClass[])item.Tag);

            AdvPropertyGrid1.SuspendLayout();
            AdvPropertyGrid1.SelectedObjects = objs.ToArray();
            AdvPropertyGrid1.ResumeLayout();
        }

        private void ButtonItem43_Click(object sender, EventArgs e)
        {
            var itemsToRemove = new List<ListViewItem>();

            foreach (ListViewItem item in ListViewEx_LM_ScrollTexList.SelectedItems)
            {
                ScrollTexPropertyClass[] scrollTex = (ScrollTexPropertyClass[])item.Tag;
                scrollTex.ForEach(n => cArea.ScrollingTextures.Remove(n.ScrollingTexture));
                itemsToRemove.Add(item);
            }

            foreach (ListViewItem item in itemsToRemove)
                ListViewEx_LM_ScrollTexList.Items.Remove(item);

            ScrollTexRemoved?.Invoke(this, new EventArgs());
        }

        private void ButtonItem44_Click(object sender, EventArgs e)
        {
            var scrollTex = new ManagedScrollingTexture();
            cArea.ScrollingTextures.Add(scrollTex);
            AddListViewItem(scrollTex);
            UpdateAllListViewItems();
            ScrollTexAdded?.Invoke(this, new EventArgs());
        }

        private void ListViewEx_LM_ScrollTexList_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void AdvPropertyGrid1_Click(object sender, EventArgs e)
        {
        }

        private void CheckBoxItem_ViewMode_Simplified_CheckedChanged(object sender, CheckBoxChangeEventArgs e)
        {
            simplifiedView = CheckBoxItem_ViewMode_Simplified.Checked;
            SetIgnoredProperties();
            LoadScrollTexts();
        }

        private void SetIgnoredProperties()
        {
            propSettings_VertexPointer.Visible = propSettings_FacesCount.Visible = propSettings_GroupID.Visible = !simplifiedView;
        }

        private void AdvPropertyGrid1_PropertiesLoaded(object sender, EventArgs e)
        {
        }
    }
}