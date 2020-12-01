using System;
using System.Collections.Generic;
using global::System.Drawing;
using System.Linq;
using global::System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.ModelConverterGUI.My.Resources;
using global::SM64Lib.Geolayout;
using global::SM64Lib.Model.Conversion.Fast3DWriting;
using global::SM64Lib.Model.Fast3D;
using global::SM64Lib.N64Graphics;
using SM64Lib.Model.Conversion;
using DevComponents.AdvTree;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    public partial class TextureGraphicFormatEditor
    {

        private readonly Size imageSize = new Size(64, 64);
        private LabelX labelX_TexSize;
        private Object3D obj3d = null;
        private bool loadingtexItemSettings = false;
        private bool hasInit = false;
        private List<int> colorImages = new List<int>();
        private TextureFormatSettings _TextureFormatSettings = null;
        private readonly Dictionary<Image, Image> realTextures = new Dictionary<Image, Image>();

        public TextureFormatSettings TextureFormatSettings
        {
            get
            {
                return _TextureFormatSettings;
            }

            set
            {
                _TextureFormatSettings = value;
                LoadDisplayListTypes();
            }
        }

        public TextureGraphicFormatEditor(Object3D obj)
        {
            base.Shown += Form_Shown;
            SuspendLayout();
            InitializeComponent();
            obj3d = obj;
            AcceptButton = Button_SaveColsettings;
            LoadDisplayListTypes();
            LoadN64TextureFormatTypes();
            LoadRotateFlip();
            AddPicBoxLabel();
            base.UpdateAmbientColors();
            hasInit = true;
            ResumeLayout();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            LoadTexturesFromModel();
        }

        private void AddPicBoxLabel()
        {
            labelX_TexSize = new LabelX
            {
                TextAlignment = StringAlignment.Center,
                Dock = DockStyle.Bottom,
                Height = 23
            };
            PictureBox1.Controls.Add(labelX_TexSize);
        }

        private void LoadDisplayListTypes()
        {
            ComboBoxEx_SelectDisplaylist.BeginUpdate();
            ComboBoxEx_SelectDisplaylist.Items.Clear();
            ComboBoxEx_SelectDisplaylist.Items.Add(new ComboItem() { Text = MainModelconverter_Resources.Automatic });
            ComboBoxEx_SelectDisplaylist.Items.AddRange(PublicFunctions.GetDefaultGeolayerComboItems());
            if (TextureFormatSettings?.CustomDisplayLists is object)
            {
                foreach (DisplaylistProps dlprop in TextureFormatSettings.CustomDisplayLists)
                {
                    int layerID = (int)dlprop.Layer;
                    ComboBoxEx_SelectDisplaylist.Items.Add(new ComboItem()
                    {
                        Text = $"#{dlprop.ID} ({layerID} - {MainModelconverter_Resources.ResourceManager.GetString($"Layer{layerID}")})",
                        Tag = dlprop.ID
                    });
                }
            }

            ComboBoxEx_SelectDisplaylist.EndUpdate();
        }

        private void LoadRotateFlip()
        {
            {
                ComboBoxEx_RotateFlip.Items.Add(new ComboItem() { Text = "None", Tag = RotateFlipType.RotateNoneFlipNone });
                ComboBoxEx_RotateFlip.Items.Add(new ComboItem() { Text = "Y", Tag = RotateFlipType.RotateNoneFlipY });
                ComboBoxEx_RotateFlip.Items.Add(new ComboItem() { Text = "X", Tag = RotateFlipType.RotateNoneFlipX });
                ComboBoxEx_RotateFlip.Items.Add(new ComboItem() { Text = "X & Y", Tag = RotateFlipType.RotateNoneFlipXY });
            }

            ComboBoxEx_RotateFlip.SelectedIndex = 0;
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
                var item = new Node()
                {
                    Text = mat.Key,
                    Tag = mat
                };
                if (mat.Value.Image is object)
                {
                    var bmp = TextureManager.ResizeImage(mat.Value.Image, imageSize, true, true);
                    item.Image = bmp;
                    realTextures.Add(bmp, mat.Value.Image);
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

        private void LoadN64TextureFormatTypes()
        {
            ComboBox_ColType.SuspendLayout();
            ComboBox_ColType.Items.Clear();
            var eType = typeof(N64Codec);
            var names = Enum.GetNames(eType);
            int[] values = (int[])Enum.GetValues(eType);
            for (int i = 0, loopTo = names.Count() - 2; i <= loopTo; i++)
            {
                var item = new ComboItem();
                item.Text = names[i];
                item.Tag = N64Graphics.CodecString((N64Codec)values[i]);
                ComboBox_ColType.Items.Add(item);
            }

            ComboBox_ColType.ResumeLayout();
        }

        private void LoadTextureProps()
        {
            if (advTree1.SelectedNode is object)
            {
                var curItem = advTree1.SelectedNode;
                string matName = ((KeyValuePair<string, Material>)curItem.Tag).Key;
                var curEntry = TextureFormatSettings.GetEntry(matName);

                bool found = false;
                loadingtexItemSettings = true;

                checkBoxX_Include.Checked = curEntry.Include;

                foreach (ComboItem item in ComboBox_ColType.Items)
                {
                    if ((string)item.Tag == curEntry.TextureFormat)
                    {
                        ComboBox_ColType.SelectedItem = item;
                        found = true;
                        break;
                    }
                }

                if (curItem.ImageIndex > -1)
                {
                    Image realImg;
                    if (realTextures.ContainsKey(curItem.Image))
                    {
                        realImg = realTextures[curItem.Image];
                    }
                    else
                    {
                        realImg = curItem.Image;
                    }

                    PictureBox1.Image = realImg;
                    labelX_TexSize.Text = $"{realImg.Width} x {realImg.Height}";
                }
                else
                {
                    PictureBox1.Image = null;
                    labelX_TexSize.Text = string.Empty;
                    LabelX1.Text = string.Empty;
                }

                CheckBoxX_EnableTextureAnimation.Checked = curEntry.IsScrollingTexture;
                CheckBoxX_EnableMirrorS.Checked = curEntry.EnableMirrorS;
                CheckBoxX_EnableMirrorT.Checked = curEntry.EnableMirrorT;
                CheckBoxX_EnableClampS.Checked = curEntry.EnableClampS;
                CheckBoxX_EnableClampT.Checked = curEntry.EnableClampT;
                CheckBoxX_EnableCrystalEffect.Checked = curEntry.EnableCrystalEffect;
                CheckBoxX_EnableTwoSidedFaces.Checked = curEntry.FaceCullingMode != FaceCullingMode.Back;
                ComboBoxEx_RotateFlip.SelectedItem = GetRotateFlipComboItem(curEntry.RotateFlip);

                foreach (ComboItem item in ComboBoxEx_SelectDisplaylist.Items)
                {
                    switch (curEntry.DisplaylistSelection.SelectionMode)
                    {
                        case DisplaylistSelectionMode.Automatic:
                            ComboBoxEx_SelectDisplaylist.SelectedIndex = 0;
                            break;
                        case DisplaylistSelectionMode.Default:
                            if (item.Tag == null || (DefaultGeolayers)item.Tag == curEntry.DisplaylistSelection.DefaultGeolayer)
                                ComboBoxEx_SelectDisplaylist.SelectedItem = item;
                            break;
                        case DisplaylistSelectionMode.Custom:
                            if (item.Tag == null || (int)item.Tag == curEntry.DisplaylistSelection.CustomDisplaylistID)
                                ComboBoxEx_SelectDisplaylist.SelectedItem = item;
                            break;
                    }
                }

                bool enTexTools = !colorImages.Contains(curItem.ImageIndex);
                CheckBoxX_EnableTextureAnimation.Enabled = enTexTools;
                CheckBoxX_EnableMirrorS.Enabled = enTexTools;
                CheckBoxX_EnableClampS.Enabled = enTexTools;
                CheckBoxX_EnableCrystalEffect.Enabled = enTexTools;
                ComboBoxEx_RotateFlip.Enabled = enTexTools;

                loadingtexItemSettings = false;

                if (!found)
                {
                    ComboBox_ColType.SelectedIndex = 0;
                }
            }
        }

        private ComboItem GetRotateFlipComboItem(RotateFlipType type)
        {
            ComboItem var = null;
            foreach (ComboItem item in ComboBoxEx_RotateFlip.Items)
            {
                if (var is null && (RotateFlipType)item.Tag == type)
                {
                    var = item;
                }
            }

            if (var is null && ComboBoxEx_RotateFlip.Items.Count > 0)
            {
                var = (ComboItem)ComboBoxEx_RotateFlip.Items[0];
            }

            return var;
        }

        private void ComboBox_CI_ColType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem selItem = (ComboItem)ComboBox_ColType.SelectedItem;
            string id = Conversions.ToString(selItem.Tag);
            LabelX_MaxPixels.Text = $"Maximal Pixels: {TextureManager.GetMaxPixls(N64Graphics.StringCodec(id))}";
            if (!loadingtexItemSettings)
            {
                UpdateTextureListItemSettings(id);
            }
        }

        private void UpdateTextureListItemSettings(string id)
        {
            if (advTree1.SelectedNode is object)
            {
                foreach (Node item in advTree1.SelectedNodes)
                {
                    KeyValuePair<string, Material> mat = (KeyValuePair<string, Material>)item.Tag;
                    var curEntry = TextureFormatSettings.GetEntry(mat.Key);

                    curEntry.Include = checkBoxX_Include.Checked;

                    if (curEntry.Include)
                    {
                        curEntry.IsScrollingTexture = CheckBoxX_EnableTextureAnimation.Checked;
                        curEntry.TextureFormat = id;
                        curEntry.EnableMirrorS = CheckBoxX_EnableMirrorS.Checked;
                        curEntry.EnableMirrorT = CheckBoxX_EnableMirrorT.Checked;
                        curEntry.EnableClampS = CheckBoxX_EnableClampS.Checked;
                        curEntry.EnableClampT = CheckBoxX_EnableClampT.Checked;
                        curEntry.EnableCrystalEffect = CheckBoxX_EnableCrystalEffect.Checked;
                        curEntry.RotateFlip = (RotateFlipType)((ComboItem)ComboBoxEx_RotateFlip.SelectedItem).Tag;
                        curEntry.FaceCullingMode = CheckBoxX_EnableTwoSidedFaces.Checked ? FaceCullingMode.NoCulling : FaceCullingMode.Back;

                        var selDL = ((ComboItem)ComboBoxEx_SelectDisplaylist.SelectedItem).Tag;
                        if (selDL is DefaultGeolayers)
                        {
                            curEntry.DisplaylistSelection.SelectionMode = DisplaylistSelectionMode.Default;
                            curEntry.DisplaylistSelection.DefaultGeolayer = (DefaultGeolayers)selDL;
                        }
                        else if (selDL is int)
                        {
                            curEntry.DisplaylistSelection.SelectionMode = DisplaylistSelectionMode.Custom;
                            curEntry.DisplaylistSelection.CustomDisplaylistID = Conversions.ToInteger(selDL);
                        }
                        else
                        {
                            curEntry.DisplaylistSelection.SelectionMode = DisplaylistSelectionMode.Automatic;
                        }
                    }
                }
            }
        }

        private void ControlsOccusUpdateTextureListItemSettings(object sender, EventArgs e)
        {
            if (hasInit && !loadingtexItemSettings)
            {
                ComboItem selItem = (ComboItem)ComboBox_ColType.SelectedItem;
                string id = Conversions.ToString(selItem.Tag);
                UpdateTextureListItemSettings(id);
            }
        }

        private void ButtonItem_EditCustomDisplaylists_Click(object sender, EventArgs e)
        {
            var frm = new CustomDisplaylistEditor(TextureFormatSettings.CustomDisplayLists);
            frm.ShowDialog();
            LoadDisplayListTypes();
            LoadTextureProps();
        }

        private void CheckBoxX_IncludeMat_CheckedChanged(object sender, EventArgs e)
        {
            panel_MatOptions.Enabled = checkBoxX_Include.Checked;
            ControlsOccusUpdateTextureListItemSettings(sender, e);
        }

        private void advTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            LoadTextureProps();
        }
    }
}