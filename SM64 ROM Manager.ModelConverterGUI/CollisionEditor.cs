using System;
using System.Collections.Generic;
using global::System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using global::System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::OfficeOpenXml;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib.Model.Fast3D;
using SM64Lib.TextValueConverter;
using DevComponents.AdvTree;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    public partial class CollisionEditor
    {
        public CollisionEditor(Object3D obj)
        {
            base.Shown += Form_Shown;
            SuspendLayout();
            InitializeComponent();
            obj3d = obj;
            Button_SaveColsettings.Visible = true;
            LabelX_Param1.Visible = true;
            LabelX_Param2.Visible = true;
            TextBoxX_ColParam1.Visible = true;
            TextBoxX_ColParam2.Visible = true;
            TextBoxX_ColParam1.Enabled = true;
            TextBoxX_ColParam2.Enabled = true;
            LabelX_Param1.Enabled = true;
            LabelX_Param2.Enabled = true;
            AcceptButton = Button_SaveColsettings;
            base.UpdateAmbientColors();
            TextBoxX1.Enabled = false;
            TextBoxX_ColParam1.Enabled = false;
            TextBoxX_ColParam2.Enabled = false;
            ResumeLayout();
        }

        private static readonly Size imageSize = new Size(64, 64);
        private static List<Node> terrainTypesComboItems = new List<Node>();
        private static bool loadingTerrainTypesComboItems = false;
        private bool LoadingColItemSettings = false;
        private Object3D obj3d = null;
        private List<int> colorImages = new List<int>();
        private readonly Dictionary<Image, Image> realTextures = new Dictionary<Image, Image>();

        public SM64Lib.Model.Collision.CollisionSettings CollisionSettings { get; set; } = null;

        private async void Form_Shown(object sender, EventArgs e)
        {
            await LoadFloorTypes();
            LoadTexturesFromModel();
        }

        private void LoadTexturesFromModel()
        {
            Node firstItem = null;

            advTree1.BeginUpdate();

            // Clear Items
            advTree1.Nodes.Clear();
            colorImages.Clear();
            realTextures.Clear();

            // Setup Imagelist
            foreach (KeyValuePair<string, Material> mat in obj3d.Materials)
            {
                var item = new Node();
                item.Tag = mat;
                item.Text = mat.Key;
                if (mat.Value.Image is object)
                {
                    var bmp = TextureManager.ResizeImage(mat.Value.Image, imageSize, true, true);
                    item.Image = bmp;
                    realTextures.Add(item.Image, mat.Value.Image);
                }
                else
                {
                    Image img = GetImageFromColor((Color)mat.Value.Color, imageSize);
                    item.Image = img;
                    colorImages.Add(item.ImageIndex);
                }

                if (firstItem is null)
                    firstItem = item;
                advTree1.Nodes.Add(item);
            }

            // Select First Item
            if (firstItem is object)
            {
                advTree1.SelectedNode = firstItem;
            }

            advTree1.EndUpdate();
        }

        private Bitmap GetImageFromColor(Color color, Size size)
        {
            var bmp = new Bitmap(size.Width, size.Height);
            var g = Graphics.FromImage(bmp);
            g.Clear(color);
            return bmp;
        }

        private async Task LoadFloorTypes()
        {
            await Task.Run(WaitForFloorTypes);
            
            AdvTree_ColTypes.BeginUpdate();
            AdvTree_ColTypes.Nodes.Clear();

            var myNodes = terrainTypesComboItems.Select(n => n.Copy()).ToList();
            myNodes.ForEach(n => SetToolTip(n));
            AdvTree_ColTypes.Nodes.AddRange(myNodes.ToArray());

            AdvTree_ColTypes.EndUpdate();
        }

        private void WaitForFloorTypes()
        {
            if (!terrainTypesComboItems.Any() && !loadingTerrainTypesComboItems)
            {
                LoadFloorTypesFromDatabase();
            }
            else if (loadingTerrainTypesComboItems)
            {
                while (loadingTerrainTypesComboItems)
                {
                }
            }

            if (!terrainTypesComboItems.Any())
            {
                MessageBox.Show("The collision types table is empty.", "Load Collision Types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public static void LoadFloorTypesFromDatabaseAsync()
        {
            Task.Run(LoadFloorTypesFromDatabase);
        }

        public static void LoadFloorTypesFromDatabase()
        {
            ExcelWorksheet ws;
            loadingTerrainTypesComboItems = true;

            // Clear items
            terrainTypesComboItems.Clear();

            // Set the worksheet to load
            if (Settings.ModelConverter.UseLegacyCollisionDescriptions)
            {
                ws = Publics.General.OtherData.Worksheets["Editor Collision"];
            }
            else
            {
                ws = Publics.General.SurfaceData.Worksheets["Terrain Hexes"];
            }

            if (ws.Cells.Rows > 0)
            {
                for (int i = 2, loopTo = ws.Cells.Rows; i <= loopTo; i++)
                {
                    if (Settings.ModelConverter.UseLegacyCollisionDescriptions)
                    {
                        string typeHex = Conversions.ToString(ws.Cells[i, 1].Value);
                        string title = Conversions.ToString(ws.Cells[i, 2].Value);
                        byte typeByte;
                        if (!string.IsNullOrEmpty(typeHex) && !string.IsNullOrEmpty(title))
                        {
                            var item = new Node();

                            // Convert hex string to byte
                            typeByte = Conversions.ToByte("&H" + typeHex);

                            // Set infos to the item
                            item.Text = typeByte.ToString("X2");
                            item.Cells.Add(new Cell(title));
                            item.Tag = new object[] { typeByte, title, string.Empty, string.Empty };

                            // Add item to list
                            if (item is object)
                            {
                                terrainTypesComboItems.Add(item);
                            }
                        }
                    }
                    else if (string.IsNullOrEmpty(ws.Cells[i, 1].Style.Fill.BackgroundColor.Rgb))
                    {
                        string typeDec = Conversions.ToString(ws.Cells[i, 1].Value);
                        string title = Conversions.ToString(ws.Cells[i, 3].Value);
                        byte typeByte;
                        if (!string.IsNullOrEmpty(typeDec) && !string.IsNullOrEmpty(title))
                        {
                            if (byte.TryParse(typeDec, out typeByte))
                            {
                                var item = new Node();
                                string desc;
                                string notes;

                                // Get description & notes (will be displayed in tooltip)
                                desc = Conversions.ToString(ws.Cells[i, 5].Value);
                                notes = Conversions.ToString(ws.Cells[i, 7].Value);

                                // Set infos to the item
                                item.Text = typeByte.ToString("X2");
                                item.Cells.Add(new Cell(title));
                                item.Tag = new object[] { typeByte, title, desc, notes };

                                // Add item to list
                                if (item is object)
                                {
                                    terrainTypesComboItems.Add(item);
                                }
                            }
                        }
                    }
                }
            }

            loadingTerrainTypesComboItems = false;
        }

        private void advTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            if (advTree1.SelectedNode != null)
            {
                var curItem = advTree1.SelectedNode;
                KeyValuePair<string, Material> mat = (KeyValuePair<string, Material>)curItem.Tag;
                var curEntry = CollisionSettings.GetEntry(mat.Key);
                bool found = false;

                // Reset search
                TextBoxX_SearchColTypes.Text = string.Empty;

                LoadingColItemSettings = true;

                foreach (Node item in AdvTree_ColTypes.Nodes)
                {
                    if (!found && (byte)((object[])item.Tag)[0] == curEntry.CollisionType)
                     {
                        AdvTree_ColTypes.SelectedNode = item;
                        item.EnsureVisible();
                        found = true;
                    }
                }

                CheckBoxX_IsNonSolid.Checked = curEntry.IsNonSolid;
                CheckBoxX1.Checked = !found;
                TextBoxX1.Text = TextValueConverter.TextFromValue(curEntry.CollisionType);
                TextBoxX_ColParam1.Text = TextValueConverter.TextFromValue(curEntry.CollisionParam1);
                TextBoxX_ColParam2.Text = TextValueConverter.TextFromValue(curEntry.CollisionParam2);

                LoadingColItemSettings = false;
            }
        }

        private void TextBoxX1_TextChanged(object sender, EventArgs e)
        {
            byte id = Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX1.Text));
            SetParamTipp(id);
            if (!LoadingColItemSettings)
            {
                UpdateTextureListItemSettings(id);
            }
        }

        private void SetToolTip(Node n)
        {
            var data = (object[])n.Tag;
            var info = new SuperTooltipInfo();
            info.HeaderText = $"{TextValueConverter.TextFromValue(Conversions.ToLong(data[0]))}: {data[1]}";
            info.BodyText = $"<u>Description:</u>{data[2]}<br/><br/><u>Notes:</u>{data[3]}";
            SuperTooltip1.SetSuperTooltip(n, info);
        }

        private void SetParamTipp(byte id)
        {
            string tParamsTipp = "<u>Params-Tipp:</u><br></br>";
            switch (id)
            {
                case 14: // Water torrent force and rotation
                    {
                        LabelX_ColParamsTipp.Text = tParamsTipp + "Water torrent force and rotation";
                        LabelX_ColParamsTipp.Visible = true;
                        TextBoxX_ColParam1.Enabled = true;
                        TextBoxX_ColParam2.Enabled = true;
                        break;
                    }

                case 44: // Wind direction
                    {
                        LabelX_ColParamsTipp.Text = tParamsTipp + "Wind direction";
                        LabelX_ColParamsTipp.Visible = true;
                        TextBoxX_ColParam1.Enabled = true;
                        TextBoxX_ColParam2.Enabled = true;
                        break;
                    }

                case 36: // Moving sand direction and force
                    {
                        LabelX_ColParamsTipp.Text = tParamsTipp + "Moving sand direction and force";
                        LabelX_ColParamsTipp.Visible = true;
                        TextBoxX_ColParam1.Enabled = true;
                        TextBoxX_ColParam2.Enabled = true;
                        break;
                    }

                case 37: // Moving sand direction and force
                    {
                        LabelX_ColParamsTipp.Text = tParamsTipp + "Moving sand direction and force";
                        LabelX_ColParamsTipp.Visible = true;
                        TextBoxX_ColParam1.Enabled = true;
                        TextBoxX_ColParam2.Enabled = true;
                        break;
                    }

                case 39: // Moving sand direction and force
                    {
                        LabelX_ColParamsTipp.Text = tParamsTipp + "Moving sand direction and force";
                        LabelX_ColParamsTipp.Visible = true;
                        TextBoxX_ColParam1.Enabled = true;
                        TextBoxX_ColParam2.Enabled = true;
                        break;
                    }

                case 45: // Moving sand direction and force
                    {
                        LabelX_ColParamsTipp.Text = tParamsTipp + "Moving sand direction and force";
                        LabelX_ColParamsTipp.Visible = true;
                        TextBoxX_ColParam1.Enabled = true;
                        TextBoxX_ColParam2.Enabled = true;
                        break;
                    }

                default:
                    {
                        LabelX_ColParamsTipp.Visible = false;
                        TextBoxX_ColParam1.Enabled = false;
                        TextBoxX_ColParam2.Enabled = false;
                        break;
                    }
            }
        }

        private void UpdateTextureListItemSettings(byte ct)
        {
            if (advTree1.SelectedNode is object)
            {
                byte cp1 = Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX_ColParam1.Text));
                byte cp2 = Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX_ColParam2.Text));
                foreach (Node item in advTree1.SelectedNodes)
                {
                    KeyValuePair<string, Material> mat = (KeyValuePair<string, Material>)item.Tag;
                    var curEntry = CollisionSettings.GetEntry(mat.Key);
                    curEntry.CollisionType = ct;
                    curEntry.CollisionParam1 = cp1;
                    curEntry.CollisionParam2 = cp2;
                    curEntry.IsNonSolid = CheckBoxX_IsNonSolid.Checked;
                }
            }
        }
        private void LoadColTypeProps()
        {
            Node selItem = AdvTree_ColTypes.SelectedNode;
            if (selItem?.Tag is object)
            {
                byte id = (byte)((object[])selItem.Tag)[0];
                this.SetParamTipp(id);
                if (!LoadingColItemSettings)
                {
                    this.UpdateTextureListItemSettings(id);
                }
            }
        }

        private void CheckBoxX1_CheckedChanging(object sender, EventArgs e)
        {
            TextBoxX1.Enabled = CheckBoxX1.Checked;
            AdvTree_ColTypes.Enabled = !CheckBoxX1.Checked;
            TextBoxX_SearchColTypes.Enabled = !CheckBoxX1.Checked;

            if (CheckBoxX1.Checked)
                TextBoxX1_TextChanged(TextBoxX1, new EventArgs());
            else
                LoadColTypeProps();
        }

        private void ButtonItem_IsNonSolid_CheckedChanged(object sender, EventArgs e)
        {
            var panel3Enabled = !CheckBoxX_IsNonSolid.Checked;

            foreach (Control c in panel3.Controls)
            {
                if (c != CheckBoxX_IsNonSolid)
                    c.Enabled = panel3Enabled;
            }

            if (!LoadingColItemSettings)
            {
                Node selItem = AdvTree_ColTypes.SelectedNode;
                byte id = (byte)((object[])selItem.Tag)[0];
                this.UpdateTextureListItemSettings(id);
            }
        }

        private void AdvTree_ColTypes_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            LoadColTypeProps();
        }

        private void TextBoxX_SearchColTypes_TextChanged(object sender, EventArgs e)
        {
            AdvTree_ColTypes.BeginUpdate();

            var plainSearchText = TextBoxX_SearchColTypes.Text.Trim();

            if (string.IsNullOrEmpty(plainSearchText))
            {
                foreach (Node node in AdvTree_ColTypes.Nodes)
                    node.Visible = true;
            }
            else
            {
                var searchText = $"*{plainSearchText}*";
                foreach (Node node in AdvTree_ColTypes.Nodes)
                {
                    var data = (object[])node.Tag;
                    var wholeText = $"{(string)data[1]} {(string)data[2]} {(string)data[3]}";
                    node.Visible = LikeOperator.LikeString(wholeText, searchText, Microsoft.VisualBasic.CompareMethod.Text);
                }
            }

            AdvTree_ColTypes.EndUpdate();
            AdvTree_ColTypes.Refresh();
        }

        private void TextBoxX_ColParam1_TextChanged(object sender, EventArgs e)
        {
            LoadColTypeProps();
        }

        private void TextBoxX_ColParam2_TextChanged(object sender, EventArgs e)
        {
            LoadColTypeProps();
        }
    }
}