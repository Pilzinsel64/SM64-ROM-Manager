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
            LabelX_CollisionType.Visible = true;
            LabelX_Param1.Visible = true;
            LabelX_Param2.Visible = true;
            ComboBox_ColType.Visible = true;
            ComboBox_ColType.Enabled = true;
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

        private static List<ComboItem> terrainTypesComboItems = new List<ComboItem>();
        private static bool loadingTerrainTypesComboItems = false;
        private bool LoadingColItemSettings = false;
        private Object3D obj3d = null;
        private readonly Dictionary<int, Image> realTextures = new Dictionary<int, Image>();

        public SM64Lib.Model.Collision.CollisionSettings CollisionSettings { get; set; } = null;

        private async void Form_Shown(object sender, EventArgs e)
        {
            await LoadFloorTypes();
            LoadTexturesFromModel();
        }

        private void LoadTexturesFromModel()
        {
            ListViewItem firstItem = null;
            var imgList = new ImageList();

            // Clear Items
            ListViewEx1.Items.Clear();

            // Setup Imagelist
            imgList.ImageSize = new Size(64, 64);
            ListViewEx1.LargeImageList = imgList;
            foreach (KeyValuePair<string, Material> mat in obj3d.Materials)
            {
                var item = new ListViewItem();
                item.Tag = mat;
                item.Text = mat.Key;
                if (mat.Value.Image is object)
                {
                    int imageIndex = imgList.Images.Count;
                    var bmp = TextureManager.ResizeImage(mat.Value.Image, imgList.ImageSize, true, true);
                    item.ImageIndex = imageIndex;
                    realTextures.Add(item.ImageIndex, mat.Value.Image);
                    imgList.Images.Add(bmp);
                }

                if (firstItem is null)
                    firstItem = item;
                ListViewEx1.Items.Add(item);
            }

            // Select First Item
            if (firstItem is object)
            {
                firstItem.Selected = true;
            }

            ListViewEx1.Visible = true;
        }

        private async Task LoadFloorTypes()
        {
            await Task.Run(WaitForFloorTypes);
            ComboBox_ColType.Items.Clear();
            ComboBox_ColType.SuspendLayout();
            ComboBox_ColType.Items.AddRange(terrainTypesComboItems.ToArray());
            ComboBox_ColType.ResumeLayout();
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
                            var item = new ComboItem();

                            // Convert hex string to byte
                            typeByte = Conversions.ToByte("&H" + typeHex);

                            // Set infos to the item
                            item.Text = $"{typeByte.ToString("X2")}: {title}";
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
                                var item = new ComboItem();
                                string desc;
                                string notes;

                                // Get description & notes (will be displayed in tooltip)
                                desc = Conversions.ToString(ws.Cells[i, 5].Value);
                                notes = Conversions.ToString(ws.Cells[i, 7].Value);

                                // Set infos to the item
                                item.Text = $"{typeByte.ToString("X2")}: {title}";
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

        private void ListBoxAdv_CI_Textures_ItemClick(object sender, EventArgs e)
        {
            if (ListViewEx1.SelectedIndices.Count > 0)
            {
                var curItem = ListViewEx1.SelectedItems[0];
                KeyValuePair<string, Material> mat = (KeyValuePair<string, Material>)curItem.Tag;
                var curEntry = CollisionSettings.GetEntry(mat.Key);
                bool found = false;
                LoadingColItemSettings = true;
                foreach (ComboItem item in ComboBox_ColType.Items)
                {
                    if(!found && (byte)((object[])item.Tag)[0] == curEntry.CollisionType)
                    {
                        ComboBox_ColType.SelectedItem = item;
                        found = true;
                    }
                }
                CheckBoxX_IsNonSolid.Checked = curEntry.IsNonSolid;
                CheckBoxX1.Checked = !found;
                TextBoxX1.Text = TextValueConverter.TextFromValue(curEntry.CollisionType);
                TextBoxX_ColParam1.Text = TextValueConverter.TextFromValue(curEntry.CollisionParam1);
                TextBoxX_ColParam2.Text = TextValueConverter.TextFromValue(curEntry.CollisionParam2);
                if (curItem.ImageIndex > -1)
                {
                    Image realImg;
                    if (realTextures.ContainsKey(curItem.ImageIndex))
                    {
                        realImg = realTextures[curItem.ImageIndex];
                    }
                    else
                    {
                        realImg = ListViewEx1.LargeImageList.Images[curItem.ImageIndex];
                    }

                    PictureBox1.Image = realImg;
                }
                else
                {
                    PictureBox1.Image = null;
                }

                LoadingColItemSettings = false;
            }
        }

        private void ComboBox_CI_ColType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem selItem = (ComboItem)ComboBox_ColType.SelectedItem;
            if (selItem?.Tag is object)
            {
                byte id = (byte)((object[])selItem.Tag)[0];
                this.SetParamTipp(id);
                SetToolTip((object[])selItem.Tag);
                if (!LoadingColItemSettings)
                {
                    this.UpdateTextureListItemSettings(id);
                }
            }
        }

        private void TextBoxX1_TextChanged(object sender, EventArgs e)
        {
            byte id = Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX1.Text));
            SetParamTipp(id);
            SuperTooltip1.SetSuperTooltip(ComboBox_ColType, null);
            if (!LoadingColItemSettings)
            {
                UpdateTextureListItemSettings(id);
            }
        }

        private void SetToolTip(object[] data)
        {
            var info = new SuperTooltipInfo();
            info.HeaderText = $"{TextValueConverter.TextFromValue(Conversions.ToLong(data[0]))}: {data[1]}";
            info.BodyText = $"<u>Description:</u>{data[2]}<br/><br/><u>Notes:</u>{data[3]}";
            SuperTooltip1.SetSuperTooltip(ComboBox_ColType, info);
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
            if (ListViewEx1.SelectedIndices.Count > 0)
            {
                byte cp1 = Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX_ColParam1.Text));
                byte cp2 = Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX_ColParam2.Text));
                foreach (ListViewItem item in ListViewEx1.SelectedItems)
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

        private void CheckBoxX1_CheckedChanging(object sender, EventArgs e)
        {
            TextBoxX1.Enabled = CheckBoxX1.Checked;
            ComboBox_ColType.Enabled = !CheckBoxX1.Checked;
            if (CheckBoxX1.Checked)
            {
                TextBoxX1_TextChanged(TextBoxX1, new EventArgs());
            }
            else
            {
                ComboBox_CI_ColType_SelectedIndexChanged(ComboBox_ColType, new EventArgs());
            }
        }

        private void ButtonItem_IsNonSolid_CheckedChanged(object sender, EventArgs e)
        {
            Panel1.Enabled = !CheckBoxX_IsNonSolid.Checked;
            if (!LoadingColItemSettings)
            {
                ComboItem selItem = (ComboItem)ComboBox_ColType.SelectedItem;
                byte id = (byte)((object[])selItem.Tag)[0];
                this.UpdateTextureListItemSettings(id);
            }
        }
    }
}