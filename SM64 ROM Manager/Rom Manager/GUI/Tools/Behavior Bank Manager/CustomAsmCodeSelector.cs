using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64Lib;
using SM64Lib.ASM;
using SM64Lib.Behaviors;
using SM64Lib.Configuration;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SM64Lib.TextValueConverter.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class CustomAsmCodeSelector : OfficeForm
    {
        private readonly RomManager romManager;
        public CustomAsmArea AsmArea { get; set; } = null;

        public CustomAsmCodeSelector(RomManager romManager)
        {
            General.LoadBehaviorInfosIfEmpty(romManager);
            this.romManager = romManager;
            InitializeComponent();
            UpdateAmbientColors();
        }

        private void LoadList()
        {
            AdvTree1.BeginUpdate();
            AdvTree1.Nodes.Clear();

            Node nToSelect = null;

            foreach (var area in romManager.GlobalCustomAsmBank.Areas)
            {
                var n = GetNode(area);

                AdvTree1.Nodes.Add(n);

                if (area == AsmArea)
                    nToSelect = n;
            }

            AdvTree1.EndUpdate();

            if (nToSelect is object)
            {
                AdvTree1.SelectedNode = nToSelect;
                nToSelect.EnsureVisible();
            }
        }

        private Node GetNode(CustomAsmArea area)
        {
            var n = new Node()
            {
                Text = area.Config.Name,
                Tag = area
            };

            n.Cells.Add(new Cell(TextFromValue(area.Config.RomAddress)));

            return n;
        }

        private void AdvTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            AsmArea = e.Node?.Tag as CustomAsmArea;
            buttonX_Select.Enabled = AsmArea != null;
        }

        private void CustomModelSelector_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
