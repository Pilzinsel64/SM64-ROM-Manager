using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64Lib.Geolayout.Script;
using static SM64Lib.TextValueConverter.TextValueConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SM64Lib.Model.Fast3D.DisplayLists.Script;

namespace SM64_ROM_Manager.LevelEditor
{
    public partial class FormScriptDumps : RibbonForm
    {

        // F i e l d s

        private readonly Dictionary<int, Geolayoutscript> dicGeolayoutScripts = new Dictionary<int, Geolayoutscript>();
        private readonly Dictionary<int, DisplayListScript[]> dicDisplaylistScripts = new Dictionary<int, DisplayListScript[]>();

        // D e f a u l t   N o d e s

        private Node nGeolayoutScripts = new Node()
        {
            Name = "nGeoScripts",
            Text = "Geolayouts",
            Expanded = false
        };

        private Node nDisplaylistScripts = new Node()
        {
            Name = "nDLScripts",
            Text = "Fast3D",
            Expanded = false
        };

        // C o n s t r u c t o r

        public FormScriptDumps()
        {
            InitializeComponent();
            UpdateAmbientColors();
            ScriptTree.Nodes.Add(nGeolayoutScripts);
            ScriptTree.Nodes.Add(nDisplaylistScripts);
        }

        // F e a t u r e s

        private Node AddScriptNode(object tag, string text, string name, Node parent)
        {
            var n = new Node()
            {
                Text = text,
                Tag = tag,
                Name = name
            };
            parent.Nodes.Add(n);
            return n;
        }

        public void AddAreaGeolayoutScript(byte areaID, Geolayoutscript script)
        {
            int id = areaID * -1;

            dicGeolayoutScripts.Add(id, script);
            AddScriptNode(
                id,
                $"Area {TextFromValue(areaID)} ({TextFromValue(script.FirstOrDefault()?.RomAddress ?? 0)})",
                nGeolayoutScripts.Text + id.ToString(),
                nGeolayoutScripts);
        }

        public void AddObjectGeolayoutScript(byte modelID, Geolayoutscript script)
        {
            dicGeolayoutScripts.Add(modelID, script);
            AddScriptNode(
                (int)modelID,
                $"{TextFromValue(modelID, charCount:3)} ({TextFromValue(script.FirstOrDefault()?.RomAddress ?? 0)})",
                nGeolayoutScripts.Text + modelID.ToString(),
                nGeolayoutScripts);
        }

        public void AddObjectDisplaylistScripts(byte modelID, DisplayListScript[] scripts)
        {
            AddDisplaylistScripts(modelID, scripts, false);
        }

        public void AddAreaDisplaylistScripts(byte areaID, DisplayListScript[] scripts)
        {
            AddDisplaylistScripts(areaID, scripts, true);
        }

        private void AddDisplaylistScripts(int inputID, DisplayListScript[] scripts, bool isAreaID)
        {
            int id;
            if (isAreaID)
                id = inputID * -1;
            else
                id = inputID;

            dicDisplaylistScripts.Add(id, scripts);

            string nname;
            if (isAreaID)
                nname = $"Area {TextFromValue(inputID)}";
            else
                nname = $"{TextFromValue(id, charCount: 3)}";

            var n = AddScriptNode(
                id,
                nname,
                nDisplaylistScripts.Name + id,
                nDisplaylistScripts);

            for (int i = 0; i < scripts.Length; i++)
            {
                var script = scripts[i];
                AddScriptNode(
                    new int[] { id, i },
                    i.ToString(),
                    n.Name + i,
                    n);
            }
        }

        private void ShowGeolayoutScript(int modelID)
        {
            var sw = new StringWriter();

            foreach (GeolayoutCommand command in dicGeolayoutScripts[modelID])
            {
                sw.WriteLine($"{command.ToString()}");
            }

            RichTextBoxEx_Script.Text = sw.ToString();
            sw.Close();
        }

        private void ShowDisplaylistScript(int[] tag)
        {
            var sw = new StringWriter();

            foreach (DisplayListCommand command in dicDisplaylistScripts[tag[0]][tag[1]])
            {
                sw.WriteLine($"{command.ToString()}");
            }

            RichTextBoxEx_Script.Text = sw.ToString();
            sw.Close();
        }

        // G U I

        private void ScriptTree_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            if (e.Node.Parent == nGeolayoutScripts)
                ShowGeolayoutScript((int)e.Node.Tag);
            else if (e.Node.Name.StartsWith(nDisplaylistScripts.Name) && e.Node.Tag is int[])
                ShowDisplaylistScript((int[])e.Node.Tag);
            else
                RichTextBoxEx_Script.Text = string.Empty;
        }

        private void ButtonItem_ZoomTo100Percent_Click(object sender, EventArgs e)
        {
            SliderItem_Zoom.Value = 100;
        }

        private void SliderItem_Zoom_ValueChanged(object sender, EventArgs e)
        {
            RichTextBoxEx_Script.ZoomFactor = (float)SliderItem_Zoom.Value / 100;
            SliderItem_Zoom.Text = "Zoom: " + SliderItem_Zoom.Value.ToString() + "%";
        }
    }
}
