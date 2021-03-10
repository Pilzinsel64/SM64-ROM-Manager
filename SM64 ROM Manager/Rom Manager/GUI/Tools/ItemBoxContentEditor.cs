using System;
using System.Collections.Generic;
using global::System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.AdvTree;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.LevelEditor;
using global::SM64Lib;
using global::SM64Lib.Objects;
using Z.Collections.Extensions;
using Z.Core.Extensions;

namespace SM64_ROM_Manager
{
    public partial class ItemBoxContentEditor
    {
        public ItemBoxContentEditor(RomManager rommgr)
        {
            base.Shown += ItemBoxContentEditor_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();
            romMgr = rommgr;
            PropertyTree = AdvPropertyGrid1.PropertyTree;
            bpMgr = new AdvPropGrid_ObjectPropertiesHelper(AdvPropertyGrid1, rommgr, General.ObjectCombos, General.BehaviorInfos, nameof(ItemBoxContentEntry.BehavAddress), "BParam");
        }

        private AdvTree _PropertyTree;

        private AdvTree PropertyTree
        {
            get
            {
                return _PropertyTree;
            }
            set
            {
                if (_PropertyTree != null)
                {
                    _PropertyTree.Paint -= AdvPropertyGrid1_PropertyTree_Paint;
                }

                _PropertyTree = value;
                if (_PropertyTree != null)
                {
                    _PropertyTree.Paint += AdvPropertyGrid1_PropertyTree_Paint;
                }
            }
        }

        private readonly AdvPropGrid_ObjectPropertiesHelper bpMgr;
        private ItemBoxContentManager tblMgr = new ItemBoxContentManager();
        private readonly RomManager romMgr;

        private ItemBoxContentEntry SelectedEntry
        {
            get => advTree1.SelectedNode?.Tag as ItemBoxContentEntry;
        }

        private void UpdateBParamNames()
        {
            var obj = SelectedEntry;
            if (obj is object)
            {
                var info = General.BehaviorInfos.GetByBehaviorAddress(obj.BehavAddress);
                for (byte i = 1; i <= 2; i++)
                {
                    Node n = AdvPropertyGrid1.GetPropertyNode($"BParam{i}");
                    if (n is object)
                    {
                        BehaviorInfo.BParam param = (BehaviorInfo.BParam)info?.GetValue($"BParam{i}");
                        if (param is object && !string.IsNullOrEmpty(param.Name))
                        {
                            n.Text = param.Name;
                            n.TagString = param.Name;
                        }
                        else
                        {
                            n.Text = $"Behavior Param {i}";
                            n.TagString = n.Text;
                        }
                    }
                }
            }
        }

        private void AdvPropertyGrid1_PropertyTree_Paint(object sender, PaintEventArgs e)
        {
            // Property names keep reverting back to their attribute-defined values when the property is selected.
            // This is the ugly workaround
            for (byte i = 1; i <= 2; i++)
            {
                Node n = AdvPropertyGrid1.GetPropertyNode($"BParam{i}");
                if (n is object && !string.IsNullOrEmpty(n.TagString) && (n.TagString ?? "") != (n.Text ?? ""))
                {
                    n.Text = n.TagString;
                }
            }
        }

        private void ItemBoxContentEditor_Shown(object sender, EventArgs e)
        {
            ButtonItem6.RaiseClick();
        }

        private void ButtonItem6_Click(object sender, EventArgs e)
        {
            tblMgr.Read(romMgr);
            LoadList();
        }

        private void ButtonItem3_Click(object sender, EventArgs e)
        {
            tblMgr.ResetToOriginal(romMgr);
            LoadList();
        }

        private void ButtonItem_SaveRom_Click(object sender, EventArgs e)
        {
            tblMgr.Write(romMgr);
        }

        private void AdvPropertyGrid1_PropertyValueChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((e.PropertyName ?? "") == "BehavAddress")
            {
                UpdateBParamNames();
            }

            foreach (Node lvi in advTree1.SelectedNodes)
                UpdateLvi(lvi);
        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            AddContent();
        }

        private void ButtonItem2_Click(object sender, EventArgs e)
        {
            RemoveContent();
        }

        private void ButtonItem4_Click(object sender, EventArgs e)
        {
            ImportContent();
        }

        private void ButtonItem5_Click(object sender, EventArgs e)
        {
            ExportContent();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void LoadList()
        {
            advTree1.BeginUpdate();
            advTree1.Nodes.Clear();
            foreach (ItemBoxContentEntry content in tblMgr.ContentTable)
                AddLviFromContent(content);
            advTree1.EndUpdate();
        }

        private Node AddLviFromContent(ItemBoxContentEntry content)
        {
            var item = new Node { Tag = content };
            for (int i = item.Cells.Count; i <= 4; i++)
                item.Cells.Add(new Cell());
            UpdateLvi(item);
            advTree1.Nodes.Add(item);
            return item;
        }

        public void UpdateLvi(Node lvi)
        {
            if (lvi.Tag is ItemBoxContentEntry)
            {
                ItemBoxContentEntry content = (ItemBoxContentEntry)lvi.Tag;
                lvi.Cells[0].Text = Conversions.ToString(content.ID);
                lvi.Cells[1].Text = Conversions.ToString(content.ModelID);
                lvi.Cells[2].Text = Conversions.ToString(content.BehavAddress);
                lvi.Cells[3].Text = Conversions.ToString(content.BParam1);
                lvi.Cells[4].Text = Conversions.ToString(content.BParam2);
            }
        }

        private void SelectLvis(Node[] items)
        {
            advTree1.BeginUpdate();

            foreach (Node item in advTree1.Nodes)
            {
                if (items.Contains(item))
                {
                    if (!advTree1.SelectedNodes.Contains(item))
                        advTree1.SelectedNodes.Add(item);
                }
                else if (advTree1.SelectedNodes.Contains(item))
                    advTree1.SelectedNodes.Remove(item);
            }

            advTree1.EndUpdate();
        }

        private void AddContent()
        {
            var content = new ItemBoxContentEntry() { ID = Conversions.ToByte(tblMgr.ContentTable.Count) };
            tblMgr.ContentTable.Add(content);
            var lvi = AddLviFromContent(content);
            SelectLvis(new[] { lvi });
        }

        private void RemoveContent()
        {
            foreach (Node lvi in advTree1.SelectedNodes.ToArray())
            {
                if (lvi.Tag is ItemBoxContentEntry)
                {
                    tblMgr.ContentTable.Remove((ItemBoxContentEntry)lvi.Tag);
                }

                advTree1.Nodes.Remove(lvi);
            }
        }

        private void ImportContent()
        {
            var ofd = new OpenFileDialog() { Filter = GetOpenFileDialogFilter() };
            if (Conversions.ToBoolean(ofd.ShowDialog()))
            {
                tblMgr.Read(ofd.FileName);
                LoadList();
            }
        }

        private void ExportContent()
        {
            var sfd = new SaveFileDialog() { Filter = GetSaveFileDialogFilter() };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tblMgr.Write(sfd.FileName);
            }
        }

        private string GetOpenFileDialogFilter()
        {
            return "Itembox Content Files (*.ibc, *.txt)|*.ibc;*.txt|SM64 ROM Manager Format (*.ibc)|*.ibc|SM64 Editor Format (*.txt)|*.txt|All files (*)|*";
        }

        private string GetSaveFileDialogFilter()
        {
            return "Itembox Content File (SM64 ROM Manager Format) (*.ibc)|*.ibc|Itembox Content File (SM64 Editor Format) (*.txt)|*.txt|All files (*)|*";
        }

        private void ItemBoxContentEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Commit unsaved changed of property grid
            AdvPropertyGrid1.CommitEdit();
        }

        private void advTree1_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            var list = new List<ItemBoxContentEntry>();
            foreach (Node lvi in advTree1.SelectedNodes)
            {
                if (lvi.Tag is ItemBoxContentEntry)
                {
                    list.Add((ItemBoxContentEntry)lvi.Tag);
                }
            }

            AdvPropertyGrid1.SuspendLayout();
            AdvPropertyGrid1.SelectedObjects = list.ToArray();
            UpdateBParamNames();
            AdvPropertyGrid1.RefreshPropertyValues();
            AdvPropertyGrid1.ResumeLayout();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}