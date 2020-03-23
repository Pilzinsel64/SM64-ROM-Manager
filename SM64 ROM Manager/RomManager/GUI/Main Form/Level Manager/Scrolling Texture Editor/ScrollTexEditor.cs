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

namespace SM64_ROM_Manager
{
    public partial class ScrollTexEditor
    {
        public ScrollTexEditor(LevelArea area, LevelAreaConfig areaConfig)
        {
            base.Load += ScrollTexEditor_Load;

            // Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent();
            base.UpdateAmbientColors();

            // Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            cArea = area;
            this.areaConfig = areaConfig;
        }

        public event EventHandler ScrollTexAdded;
        public event EventHandler ScrollTexRemoved;
        public event EventHandler ScrollTexChanged;

        private readonly LevelArea cArea;
        private readonly LevelAreaConfig areaConfig;

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
            foreach (ManagedScrollingTexture scrollTex in cArea.ScrollingTextures)
                AddListViewItem(scrollTex);
            UpdateAllListViewItems();
            if (ListViewEx_LM_ScrollTexList.Items.Count > 0)
            {
                ListViewEx_LM_ScrollTexList.Items[0].Selected = true;
            }
        }

        private void AddListViewItem(ManagedScrollingTexture scrollTex)
        {
            var lvi = new ListViewItem();
            lvi.Tag = new ScrollTexPropertyClass(scrollTex);
            for (int i = 1; i <= 6; i++)
            {
                var lvisub = new ListViewItem.ListViewSubItem();
                lvi.SubItems.Add(lvisub);
            }

            ListViewEx_LM_ScrollTexList.Items.Add(lvi);
        }

        private void UpdateAllListViewItems()
        {
            int counter = 1;
            foreach (ListViewItem item in ListViewEx_LM_ScrollTexList.Items)
            {
                ScrollTexPropertyClass scrollTex = (ScrollTexPropertyClass)item.Tag;
                SetLvGroup(item, scrollTex.GroupID);
                item.SubItems[0].Text = Conversions.ToString(counter);
                item.SubItems[1].Text = scrollTex.Behavior.ToString();
                item.SubItems[2].Text = scrollTex.Type.ToString();
                item.SubItems[3].Text = Conversions.ToString(scrollTex.CycleDuration);
                item.SubItems[4].Text = Conversions.ToString(scrollTex.ScrollingSpeed);
                item.SubItems[5].Text = Conversions.ToString(TextValueConverter.ValueFromText(Conversions.ToString(scrollTex.VertexPointer)));
                item.SubItems[6].Text = Conversions.ToString(scrollTex.FacesCount);
                counter += 1;
            }
        }

        private void SetLvGroup(ListViewItem item, short groupID)
        {
            ListViewGroup lvg = null;
            foreach (ListViewGroup lvgg in ListViewEx_LM_ScrollTexList.Groups)
            {
                if (lvg is null && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvgg.Tag, groupID, false)))
                {
                    lvg = lvgg;
                }
            }

            if (lvg is null)
            {
                string texName = "Unknown Material Name";
                areaConfig.ScrollingNames.TryGetValue(groupID, out texName);
                lvg = new ListViewGroup()
                {
                    Tag = groupID,
                    Header = $"Group {groupID} - {texName}"
                };
                ListViewEx_LM_ScrollTexList.Groups.Add(lvg);
            }

            item.Group = lvg;
        }

        private void ListViewEx_LM_ScrollTexList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objs = new List<ScrollTexPropertyClass>();
            foreach (ListViewItem item in ListViewEx_LM_ScrollTexList.SelectedItems)
                objs.Add((ScrollTexPropertyClass)item.Tag);
            AdvPropertyGrid1.SuspendLayout();
            AdvPropertyGrid1.SelectedObjects = objs.ToArray();
            AdvPropertyGrid1.ResumeLayout();
        }

        private void ButtonItem43_Click(object sender, EventArgs e)
        {
            var itemsToRemove = new List<ListViewItem>();
            foreach (ListViewItem item in ListViewEx_LM_ScrollTexList.SelectedItems)
            {
                ScrollTexPropertyClass scrollTex = (ScrollTexPropertyClass)item.Tag;
                cArea.ScrollingTextures.Remove(scrollTex.ScrollingTexture);
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
            if (e.Button == MouseButtons.Right)
            {
                ButtonItem_CM.Popup(Cursor.Position);
            }
        }
    }
}