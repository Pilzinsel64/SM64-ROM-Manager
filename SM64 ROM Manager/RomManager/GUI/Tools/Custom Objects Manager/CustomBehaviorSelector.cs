using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64Lib;
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
    public partial class CustomBehaviorSelector : OfficeForm
    {
        private readonly RomManager romManager;
        public BehaviorConfig Behavior { get; set; } = null;

        public CustomBehaviorSelector(RomManager romManager)
        {
            General.LoadBehaviorInfosIfEmpty();
            this.romManager = romManager;
            InitializeComponent();
            UpdateAmbientColors();
        }

        private void LoadList()
        {
            AdvTree1.BeginUpdate();
            AdvTree1.Nodes.Clear();

            var nVanilla = new Node("Vanilla") { Expanded = true };
            var nCustom = new Node("Custom") { Expanded = true };
            Node nToSelect = null;

            foreach (var behav in romManager.GlobalBehaviorBank.Behaviors)
            {
                var n = GetNode(behav);

                if (behav.Config.IsVanilla)
                    nVanilla.Nodes.Add(n);
                else
                    nCustom.Nodes.Add(n);

                if (behav.Config == Behavior)
                    nToSelect = n;
            }

            if (nCustom.Nodes.Count > 0)
                AdvTree1.Nodes.Add(nCustom);
            AdvTree1.Nodes.Add(nVanilla);

            AdvTree1.EndUpdate();

            if (nToSelect is object)
            {
                AdvTree1.SelectedNode = nToSelect;
                nToSelect.EnsureVisible();
            }
        }

        private Node GetNode(Behavior behav)
        {
            var name = behav.Config.Name;
            if (string.IsNullOrEmpty(name))
                name = General.BehaviorInfos.GetByBehaviorAddress((uint)behav.Config.BankAddress)?.Name;
            if (string.IsNullOrEmpty(name))
                name = General.BehaviorInfosCustom.GetByBehaviorAddress((uint)behav.Config.BankAddress)?.Name;
            if (string.IsNullOrEmpty(name))
                name = "Unnamed";

            var n = new Node()
            {
                Text = name,
                Tag = behav.Config
            };

            n.Cells.Add(new Cell(TextFromValue(behav.Config.BankAddress)));

            return n;
        }

        private void AdvTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            Behavior = e.Node?.Tag as BehaviorConfig;
            buttonX_Select.Enabled = Behavior != null;
        }

        private void CustomModelSelector_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
