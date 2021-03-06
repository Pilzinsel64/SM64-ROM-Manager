﻿using System;
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
using DevComponents.AdvTree;

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
        private readonly List<Node> allNodes = new List<Node>();

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
            advTree_ScrollTexList.BeginUpdate();

            // Remove current items & groups & columns
            allNodes.Clear();
            advTree_ScrollTexList.Nodes.Clear();
            advTree_ScrollTexList.Columns.Clear();

            // Add columns
            advTree_ScrollTexList.Columns.Add(columnHeader_Number);
            if (simplifiedView) advTree_ScrollTexList.Columns.Add(columnHeader_Material);
            advTree_ScrollTexList.Columns.Add(columnHeader_Behavior);
            advTree_ScrollTexList.Columns.Add(columnHeader_Type);
            advTree_ScrollTexList.Columns.Add(columnHeader_Duration);
            advTree_ScrollTexList.Columns.Add(columnHeader_Speed);
            if (!simplifiedView) advTree_ScrollTexList.Columns.Add(columnHeader_VertexPointer);
            advTree_ScrollTexList.Columns.Add(columnHeader_Vertices);

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

            advTree_ScrollTexList.EndUpdate();

            // Select first item
            if (allNodes.Count > 0)
                advTree_ScrollTexList.SelectedNode = allNodes[0];
        }

        private void AddListViewItem(ManagedScrollingTexture scrollTex)
            => AddListViewItem(new[] { scrollTex });

        private void AddListViewItem(ManagedScrollingTexture[] scrollTex)
        {
            var lvi = new Node();
            lvi.Tag = scrollTex.Select(n => new ScrollTexPropertyClass(n)).ToArray();

            for (int i = 1; i <= 7; i++)
                lvi.Cells.Add(new Cell());

            allNodes.Add(lvi);
        }

        private void UpdateAllListViewItems()
        {
            int counter = 1;

            advTree_ScrollTexList.BeginUpdate();

            foreach (Node item in allNodes)
            {
                var scrollTexes = (ScrollTexPropertyClass[])item.Tag;
                var scrollTex = scrollTexes.First();
                var sii = 0;

                if (!simplifiedView)
                    SetLvGroup(item, scrollTex.GroupID);
                else
                    advTree_ScrollTexList.Nodes.Add(item);

                item.Cells[sii++].Text = Conversions.ToString(counter);

                if (simplifiedView)
                    item.Cells[sii++].Text = GetMaterialName(scrollTex.GroupID);

                item.Cells[sii++].Text = scrollTex.Behavior.ToString();
                item.Cells[sii++].Text = scrollTex.Type.ToString();
                item.Cells[sii++].Text = Conversions.ToString(scrollTex.CycleDuration);
                item.Cells[sii++].Text = Conversions.ToString(scrollTex.ScrollingSpeed);

                if (!simplifiedView)
                    item.Cells[sii++].Text = Conversions.ToString(TextValueConverter.ValueFromText(Conversions.ToString(scrollTex.VertexPointer)));

                item.Cells[sii++].Text = Conversions.ToString(scrollTexes.Sum(n => n.FacesCount));

                counter += 1;
            }

            advTree_ScrollTexList.EndUpdate();
        }

        private void SetLvGroup(Node item, short groupID)
        {
            var groupName = "lvg_" + groupID;
            Node lvg = advTree_ScrollTexList.FindNodeByName(groupName);

            if (lvg is null)
            {
                lvg = new Node
                {
                    Name = groupName,
                    Text = $"Group {groupID} - {GetMaterialName(groupID)}",
                    Selectable = false,
                    Expanded = true
                };
                advTree_ScrollTexList.Nodes.Add(lvg);
            }

            lvg.Nodes.Add(item);
        }

        private string GetMaterialName(short groupID)
        {
            if (!areaConfig.ScrollingNames.TryGetValue(groupID, out string texName))
                texName = "Unknown Material Name";
            return texName;
        }

        private void ButtonItem43_Click(object sender, EventArgs e)
        {
            var itemsToRemove = new List<Node>();

            foreach (Node item in advTree_ScrollTexList.SelectedNodes)
            {
                ScrollTexPropertyClass[] scrollTex = (ScrollTexPropertyClass[])item.Tag;
                scrollTex.ForEach(n => cArea.ScrollingTextures.Remove(n.ScrollingTexture));
                itemsToRemove.Add(item);
            }

            foreach (Node item in itemsToRemove)
            {
                allNodes.Remove(item);
                item.Remove();
            }

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

        private void CheckBoxItem_ViewMode_Simplified_CheckedChanged(object sender, CheckBoxChangeEventArgs e)
        {
            simplifiedView = CheckBoxItem_ViewMode_Simplified.Checked;
            SetUIViewMode();
            LoadScrollTexts();
        }

        private void SetUIViewMode()
        {
            propSettings_VertexPointer.Visible = propSettings_FacesCount.Visible = propSettings_GroupID.Visible = !simplifiedView;

            ButtonItem_AddNew.Visible = !simplifiedView;
            bar1.Refresh();
        }

        private void ScrollTexEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Commit unsaved changed of property grid
            AdvPropertyGrid1.CommitEdit();
        }

        private void AdvTree_ScrollTexList_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            var objs = new List<ScrollTexPropertyClass>();

            foreach (Node item in advTree_ScrollTexList.SelectedNodes)
                objs.AddRange((ScrollTexPropertyClass[])item.Tag);

            AdvPropertyGrid1.SuspendLayout();
            AdvPropertyGrid1.SelectedObjects = objs.ToArray();
            AdvPropertyGrid1.ResumeLayout();
        }
    }
}