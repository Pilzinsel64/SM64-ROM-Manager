using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64Lib;
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
    public partial class CustomModelSelector : OfficeForm
    {
        private readonly RomManager romManager;
        private bool isBankPicker = false;
        public CustomModelConfig Model { get; set; }
        public CustomModelBank SelectedBank { get; private set; }

        public CustomModelSelector(RomManager romManager)
        {
            this.romManager = romManager;
            InitializeComponent();
            UpdateAmbientColors();
        }

        public void SetAsBankPicker(CustomModelBank selectedBank)
        {
            isBankPicker = true;
            columnHeader2.Visible = false;
            SelectedBank = selectedBank;
        }

        private void LoadList()
        {
            Node nToSelect = null;

            AdvTree1.BeginUpdate();
            AdvTree1.Nodes.Clear();

            // Global Object Bank
            goThourghtBank(romManager.GlobalModelBank, "Global Object Bank", AdvTree1.Nodes);

            // Local Object Banks
            var nlob = new Node("Local Object Bank") { Expanded = true };
            foreach (var lvl in romManager.Levels)
            {
                string levelName = romManager.RomConfig.GetLevelConfig(lvl.LevelID)?.LevelName;
                if (string.IsNullOrEmpty(levelName))
                    levelName = romManager.LevelInfoData.FirstOrDefault(n => n.ID == lvl.LevelID).Name;
                goThourghtBank(lvl.LocalObjectBank, levelName, nlob.Nodes);
            }
            if (nlob.Nodes.Count > 0 || isBankPicker)
                AdvTree1.Nodes.Add(nlob);

            void goThourghtBank(CustomModelBank bank, string bankName, NodeCollection collection)
            {
                var n = new Node(bankName)
                {
                    Tag = bank
                };

                if (!isBankPicker)
                {
                    foreach (var mdl in bank.Models)
                    {
                        var nMdl = GetNode(mdl);
                        n.Nodes.Add(nMdl);
                        if (mdl.Config == Model)
                            nToSelect = nMdl;
                    }
                }
                else if (bank == SelectedBank)
                    nToSelect = n;

                if (n.Nodes.Count > 0 || isBankPicker)
                    collection.Add(n);
            }

            AdvTree1.EndUpdate();

            if (nToSelect is object)
            {
                AdvTree1.SelectedNode = nToSelect;
                nToSelect.EnsureVisible();
            }
        }

        private Node GetNode(CustomModel model)
        {
            var n = new Node()
            {
                Text = model.Config.Name,
                Tag = model.Config
            };
            n.Cells.Add(new Cell(TextFromValue(model.ModelID)));
            return n;
        }

        private void AdvTree1_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            if (isBankPicker)
            {
                SelectedBank = e.Node?.Tag as CustomModelBank;
                buttonX_Select.Enabled = SelectedBank != null;
            }
            else
            {
                Model = e.Node?.Tag as CustomModelConfig;
                buttonX_Select.Enabled = Model != null;
            }
        }

        private void CustomModelSelector_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
