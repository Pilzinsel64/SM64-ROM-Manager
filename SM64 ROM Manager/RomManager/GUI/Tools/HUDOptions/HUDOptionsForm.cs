using System;
using System.Collections.Generic;
using System.Drawing;
using global::System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::DevComponents.AdvTree;
using global::Newtonsoft.Json.Linq;
using global::SM64_ROM_Manager.My.Resources;
using global::SM64Lib;

namespace SM64_ROM_Manager
{
    public partial class HUDOptionsForm
    {

        // C o n s t r u c t o r

        public HUDOptionsForm(RomManager rommgr)
        {

            // G U I

            this.Load += HUDOptionsForm_Load;
            hud = new HUDOptions(rommgr);
            InitializeComponent();
            base.UpdateAmbientColors();
        }

        // C o n s t a n t s

        private const string FILTER_HUDPOSITIONS = "HUD-Positions (*.json)|*.json";

        // F i e l d s

        private readonly HUDOptions hud;
        private readonly List<HUDOptionsBlock> positionBlocks = new List<HUDOptionsBlock>();

        // F e a t u r e s

        private void LoadBlocks()
        {
            hud.LoadBlock(Path.Combine(Publics.General.MyDataPath, @"Other\HUD Positions.json"));
            base.Invoke(new Action(() =>
            {
                AdvTree1.BeginUpdate();
                AdvTree1.Nodes.Clear();
            }));
            LoadBlock(hud.Block, AdvTree1.Nodes);
            base.Invoke(new Action(() =>
            {
                AdvTree1.ExpandAll();
                AdvTree1.EndUpdate();
            }));
        }

        private void LoadBlock(HUDOptionsBlock b, NodeCollection parentCollection)
        {
            var n = new Node()
            {
                Text = HUDOptionsLangRes.ResourceManager.GetString("HUDPos_" + b.Name),
                Tag = b
            };
            base.Invoke(new Action(() => parentCollection.Add(n)));
            if (b.Childs is object)
            {
                foreach (HUDOptionsBlock bb in b.Childs)
                    LoadBlock(bb, n.Nodes);
            }
        }

        private HUDOptionsBlock GetSelectedBlock()
        {
            return (HUDOptionsBlock)AdvTree1.SelectedNode?.Tag;
        }

        private void LoadPosition(HUDOptionsBlock b)
        {
            if (b is object)
            {
                hud.OpenRomRead();
                var pos = hud.GetPosition(b);
                hud.CloseRom();
                base.Invoke(new Action(() =>
                {
                    IntegerInput_PosX.Value = pos.X;
                    IntegerInput_PosY.Value = pos.Y;
                }));
            }
        }

        private void SavePosition(HUDOptionsBlock b)
        {
            if (b is object)
            {
                hud.OpenRomWrite();
                hud.SetPosition(b, new Point(IntegerInput_PosX.Value, IntegerInput_PosY.Value));
                hud.CloseRom();
            }
        }

        private void ExportToFile(string filePath)
        {
            var dicValues = new Dictionary<string, Point>();

            void addBlock(HUDOptionsBlock block)
            {
                if (block.Cords is object)
                {
                    dicValues.Add(block.Name, hud.GetPosition(block));
                }

                if (block.Childs is object)
                {
                    foreach (HUDOptionsBlock b in block.Childs)
                        addBlock(b);
                }
            }

            hud.OpenRomRead();
            addBlock(hud.Block);
            hud.CloseRom();
            File.WriteAllText(filePath, JObject.FromObject(dicValues).ToString());
        }

        private void ImportFromFile(string filePath)
        {
            var dicValues = JObject.Parse(File.ReadAllText(filePath)).ToObject<Dictionary<string, Point>>();

            void readBlock(HUDOptionsBlock block)
            {
                if (block.Cords != null && dicValues.ContainsKey(block.Name))
                {
                    hud.SetPosition(block, dicValues[block.Name]);
                }

                if (block.Childs != null)
                {
                    foreach (HUDOptionsBlock b in block.Childs)
                        readBlock(b);
                }
            }

            hud.OpenRomWrite();
            readBlock(hud.Block);
            hud.CloseRom();
            LoadPosition(GetSelectedBlock());
        }

        private void HUDOptionsForm_Load(object sender, EventArgs e)
        {
            Task.Run(() => LoadBlocks());
        }

        private void AdvTree1_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            Task.Run(() => LoadPosition((HUDOptionsBlock)e.Node.Tag));
        }

        private void ButtonX_RestorePosition_Click(object sender, EventArgs e)
        {
            Task.Run(() => LoadPosition(GetSelectedBlock()));
        }

        private void ButtonX_SavePosition_Click(object sender, EventArgs e)
        {
            Task.Run(() => SavePosition(GetSelectedBlock()));
        }

        private void ButtonItem_ExportPosToFile_Click(object sender, EventArgs e)
        {
            var sfd_exporthudpos = new SaveFileDialog() { Filter = FILTER_HUDPOSITIONS };
            if (sfd_exporthudpos.ShowDialog() == DialogResult.OK)
            {
                Task.Run(() => ExportToFile(sfd_exporthudpos.FileName));
            }
        }

        private void ButtonItem_ImportPosFromFile_Click(object sender, EventArgs e)
        {
            var ofd_importhudpos = new OpenFileDialog() { Filter = FILTER_HUDPOSITIONS };
            if (ofd_importhudpos.ShowDialog() == DialogResult.OK)
            {
                Task.Run(() => ImportFromFile(ofd_importhudpos.FileName));
            }
        }
    }
}