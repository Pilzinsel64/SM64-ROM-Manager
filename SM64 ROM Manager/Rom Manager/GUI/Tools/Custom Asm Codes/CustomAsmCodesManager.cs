using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64Lib;
using SM64Lib.ASM;
using static SM64Lib.TextValueConverter.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class CustomAsmCodesManager : OfficeForm
    {
        // F i e l d s

        private readonly CustomAsmBank asmBank;

        // C o n s t r u c t o r

        public CustomAsmCodesManager(CustomAsmBank asmBank, RomManager rommgr)
        {
            this.asmBank = asmBank;

            InitializeComponent();
            UpdateAmbientColors();

            rommgr.AfterRomSave += Rommgr_AfterRomSave;
        }

        // R o m M a n a g e r - E v e n t s

        private void Rommgr_AfterRomSave(RomManager sender, EventArgs e)
        {
            UpdateAsmList();
        }

        // F e a t u r e s

        private CustomAsmArea GetSelectedAsm()
        {
            return AdvTree_Codes.SelectedNode?.Tag as CustomAsmArea;
        }

        private void LoadAsmList()
        {
            SetSelectedAsm(null);

            AdvTree_Codes.BeginUpdate();
            AdvTree_Codes.Nodes.Clear();

            foreach (var area in asmBank.Areas)
                AdvTree_Codes.Nodes.Add(GetNode(area));

            AdvTree_Codes.EndUpdate();
        }

        private void UpdateAsmList()
        {
            AdvTree_Codes.BeginUpdate();
            foreach (Node n in AdvTree_Codes.Nodes)
                UpdateNode(n);
            AdvTree_Codes.EndUpdate();
        }

        private Node GetNode(CustomAsmArea asm)
        {
            var n = new Node
            {
                Tag = asm
            };
            n.Cells.Add(new Cell());
            n.ContextMenu = ButtonItem_Edit;
            UpdateNode(n);
            return n;
        }

        private Node FindNode(CustomAsmArea asm)
        {
            Node n = null;

            foreach (Node nn in AdvTree_Codes.Nodes)
            {
                if (nn.Tag == asm)
                    n = nn;
            }

            return n;
        }

        private void UpdateAsm(CustomAsmArea asm)
        {
            UpdateNode(FindNode(asm));
        }

        private void UpdateNode(Node n)
        {
            if (n?.Tag is CustomAsmArea)
            {
                var asm = (CustomAsmArea)n.Tag;
                n.Text = asm.Config.Name;
                n.Cells[1].Text = TextFromValue(asm.Config.RamAddress);
            }
        }

        private void EditAsm(CustomAsmArea asm)
        {
            if (asm is object)
            {
                var buf = asm.AreaBytes;
                General.OpenHexEditor(ref buf);
                asm.AreaBytes = buf;

                asmBank.UpdateAddresses();
                UpdateAsm(asm);
            }
        }

        private void SetSelectedAsm(CustomAsmArea asm)
        {
            var isNotNull = asm is object;

            ButtonItem_Remove.Enabled = isNotNull;
            ButtonItem_Edit.Enabled = isNotNull;
        }

        private void AddNewAsm()
        {
            // Create Asm Area
            var asm = new CustomAsmArea();
            asm.Config.Name = "New Custom Asm Area";
            asm.Config.ID.Generate();

            // Add Area
            asmBank.Areas.Add(asm);
            asmBank.UpdateAddresses();

            // Add Node
            var n = GetNode(asm);
            AdvTree_Codes.Nodes.Add(n);
            AdvTree_Codes.SelectedNode = n;
            n.EnsureVisible();
        }

        private void RemoveAsm(Node n)
        {
            if (n?.Tag is CustomAsmArea asm)
            {
                n.Remove();
                asmBank.Areas.Remove(asm);
                asmBank.UpdateAddresses();
                UpdateAsmList();
            }
        }

        private void RemoveAsm(CustomAsmArea asm)
        {
            RemoveAsm(FindNode(asm));
        }

        // G u i

        private void ButtonItem_AsmToHexConverter_Click(object sender, EventArgs e)
        {
            var frm = new AsmToHexConverter();
            frm.Show();
        }

        private void ButtonItem_ChangeRomAreaForAsm_Click(object sender, EventArgs e)
        {
            var frm = new ChangeRomAreaForAsmCodesDialog(asmBank);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                asmBank.UpdateAddresses();
                UpdateAsmList();
            }
        }

        private void ButtonItem_Add_Click(object sender, EventArgs e)
        {
            AddNewAsm();
        }

        private void ButtonItem_Remove_Click(object sender, EventArgs e)
        {
            RemoveAsm(GetSelectedAsm());
        }

        private void ButtonItem_EditHex_Click(object sender, EventArgs e)
        {
            EditAsm(GetSelectedAsm());
        }

        private void ButtonItem_EditName_Click(object sender, EventArgs e)
        {
            AdvTree_Codes.SelectedNode?.BeginEdit(0);
        }

        private void CustomAsmCodesManager_Shown(object sender, EventArgs e)
        {
            LoadAsmList();
        }

        private void AdvTree_Codes_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            SetSelectedAsm(e.Node?.Tag as CustomAsmArea);
        }

        private void AdvTree_Codes_AfterCellEdit(object sender, CellEditEventArgs e)
        {
            if (e.Cell.Parent.Tag is CustomAsmArea asm)
                asm.Config.Name = e.NewText.Trim();
        }

        private void AdvTree_Codes_BeforeCellEdit(object sender, CellEditEventArgs e)
        {
            e.Cancel = !(e.Cell.Parent.Tag is CustomAsmArea) || e.Cell.Parent.Cells.IndexOf(e.Cell) != 0;
        }

        private void AdvTree_Codes_AfterCellEditComplete(object sender, CellEditEventArgs e)
        {
            UpdateNode(e.Cell.Parent);
        }

        private void AdvTree_Codes_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            EditAsm(e.Node?.Tag as CustomAsmArea);
        }
    }
}