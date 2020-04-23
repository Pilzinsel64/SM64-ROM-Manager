using System;
using System.Collections.Generic;
using System.Drawing;
using global::System.IO;
using System.Linq;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Validator;
using global::Microsoft.WindowsAPICodePack.Dialogs;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.Publics;
using global::SM64_ROM_Manager.Publics.My.Resources;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib;
using global::SM64Lib.Model.Conversion.Fast3DParsing;

namespace SM64_ROM_Manager.LevelEditor
{
    public partial class TextureEditor
    {
        public event TextureReplacedEventHandler TextureReplaced;

        public delegate void TextureReplacedEventHandler(object sender, EventArgs e);

        private readonly RomManager rommgr = null;
        private ButtonItem lastClickedButton = null;
        private PictureBox lastPictureBox = null;

        public TextureEditor(RomManager rommgr, TextureCategory[] categories)
        {
            this.rommgr = rommgr;
            InitializeComponent();
            LoadCategories(categories);
            base.UpdateAmbientColors();

            // Set dark background for light theme
            if (Settings.StyleManager.IsWhiteTheme())
            {
                base.BackColor = StyleManagerSettingsStruc.VisualThemeGray.CanvasColor;
            }
        }

        private TextureBlock CurBlock
        {
            get
            {
                return lastClickedButton?.Tag as TextureBlock;
            }
        }

        private Material CurTexture
        {
            get
            {
                return lastPictureBox?.Tag as Material;
            }
        }

        private TextureLoadedInfos CurTextureInfo
        {
            get
            {
                return CurTexture?.Tag as TextureLoadedInfos;
            }
        }

        private void LoadCategories(TextureCategory[] categories)
        {
            foreach (TextureCategory cat in categories)
            {
                var pnl = new SideBarPanelItem() { Text = cat.Name };
                foreach (TextureBlock b in cat.Blocks)
                {
                    var btn = new ButtonItem()
                    {
                        Tag = b,
                        Text = b.Name,
                        ColorTable = eButtonColor.Orange
                    };
                    btn.Click += ButtonItem_Clicked;
                    btn.MouseUp += ButtonItem_MouseUp;
                    pnl.SubItems.Add(btn);
                }

                SideBar1.Panels.Add(pnl);
            }
        }

        private void LoadTexturesFromCategorie()
        {
            LoadTexturesFromCategorie(CurBlock);
        }

        private void LoadTexturesFromCategorie(TextureBlock block)
        {
            var controls = new Control[FlowLayoutPanel_Textures.Controls.Count];
            FlowLayoutPanel_Textures.Controls.CopyTo(controls, 0);
            FlowLayoutPanel_Textures.SuspendLayout();

            foreach (Control c in controls)
            {
                if (c is PictureBox)
                {
                    Highlighter1.SetHighlightColor(c, eHighlightColor.None);
                    FlowLayoutPanel_Textures.Controls.Remove(c);
                }
            }

            foreach (Material mat in block.Textures)
            {
                TextureLoadedInfos info = mat.Tag as TextureLoadedInfos;
                var pb = new PictureBox()
                {
                    Image = mat.Image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Tag = mat,
                    Size = new Size(70, 70)
                };
                pb.Click += PictureBox_Clicked;
                pb.MouseEnter += PictureBox_MouseEnter;
                pb.MouseLeave += PictureBox_MouseLeave;
                pb.MouseClick += PictureBox_MouseClick;
                var lbl = new LabelX()
                {
                    Text = info.Name,
                    Size = new Size(70, 14),
                    Location = new System.Drawing.Point(1, 55),
                    TextAlignment = StringAlignment.Center
                };
                pb.Controls.Add(lbl);
                lbl.Click += (sender, e) => PictureBox_Clicked(pb, e);
                lbl.MouseEnter += (sender, e) => PictureBox_MouseEnter(pb, e);
                lbl.MouseLeave += (sender, e) => PictureBox_MouseLeave(pb, e);
                lbl.MouseClick += (sender, e) => PictureBox_MouseClick(pb, e);
                FlowLayoutPanel_Textures.Controls.Add(pb);
            }

            FlowLayoutPanel_Textures.ResumeLayout();
        }

        private void ButtonItem_Clicked(object sender, EventArgs e)
        {
            if (lastClickedButton is object)
                lastClickedButton.Checked = false;
            lastClickedButton = (ButtonItem)sender;
            lastClickedButton.Checked = true;
            LoadTexturesFromCategorie();
        }

        private void ButtonItem_MouseUp(object sender, MouseEventArgs e)
        {
            if (((ButtonItem)sender).Checked && e.Button == MouseButtons.Right)
            {
                ButtonItem2.Popup(Cursor.Position);
            }
        }

        private void PictureBox_Clicked(object sender, EventArgs e)
        {
            if (lastPictureBox != sender)
            {
                if (lastPictureBox is object)
                {
                    Highlighter1.SetHighlightColor(lastPictureBox, eHighlightColor.None);
                }

                lastPictureBox = (PictureBox)sender;
                Highlighter1.SetHighlightColor(lastPictureBox, eHighlightColor.Green);
                ShowTextureInfos();
            }
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (Highlighter1.GetHighlightColor((Control)sender) == eHighlightColor.None)
            {
                Highlighter1.SetHighlightColor((Control)sender, eHighlightColor.Blue);
            }
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (Highlighter1.GetHighlightColor((Control)sender) == eHighlightColor.Blue)
            {
                Highlighter1.SetHighlightColor((Control)sender, eHighlightColor.None);
                // FlowLayoutPanel1.Refresh()
            }
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox && ((PictureBox)sender).Image is object)
            {
                if (e.Button == MouseButtons.Right)
                {
                    ButtonItem1.Popup(Cursor.Position);
                }
            }
        }

        private void ClearTexturesPanel()
        {
            var controls = new Control[FlowLayoutPanel_Textures.Controls.Count];
            FlowLayoutPanel_Textures.Controls.CopyTo(controls, 0);
            foreach (Control c in controls)
                FlowLayoutPanel_Textures.Controls.Remove(c);
        }

        private void ShowTextureInfos()
        {
            var info = CurTextureInfo;
            var tex = CurTexture;
            if (info is object && tex is object)
            {
                PictureBox_CurImage.Image = tex.Image;
                AdvPropertyGrid1.SelectedObject = info;
            }
        }

        private void ButtonItem_ExpTex_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = FileDialogFilters.FilterPictureFormats_Single,
                FileName = CurTextureInfo.Name
            };
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                ExportTexture(sfd.FileName);
            }
        }

        private void ButtonItem_ImpTex_Click(object sender, EventArgs e)
        {
            if (CurTextureInfo.IsReadOnly)
            {
                MessageBoxEx.Show(this, "This texture is read-only. Probably it was loaded from a compressed MIO0-Bank.", "Import Texture", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var ofd = new OpenFileDialog() { Filter = FileDialogFilters.FilterPictureFormats_All + "|" + FileDialogFilters.FilterPictureFormats_Single };
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    ImportTexture(ofd.FileName, CurTexture);
                    TextureReplaced?.Invoke(this, new EventArgs());
                }
            }
        }

        private void ButtonItem3_Click(object sender, EventArgs e)
        {
            var ofd = new CommonOpenFileDialog()
            {
                IsFolderPicker = true,
                DefaultFileName = CurBlock.Name
            };
            if (ofd.ShowDialog(Handle) == CommonFileDialogResult.Ok)
            {
                var filterselector = new FilesFilterDialog() { Filter = FileDialogFilters.FilterPictureFormats_Single };
                if (filterselector.ShowDialog(this) == DialogResult.OK)
                {
                    ExportAllTextures(ofd.FileName, filterselector.FileExtension.Substring(1));
                }
            }
        }

        private void ButtonItem4_Click(object sender, EventArgs e)
        {
            var ofd = new CommonOpenFileDialog()
            {
                IsFolderPicker = true,
                DefaultFileName = CurBlock.Name
            };
            if (ofd.ShowDialog(Handle) == CommonFileDialogResult.Ok)
            {
                ImportAllTextures(ofd.FileName, FileDialogFilters.FilterPictureFormats_All.Substring(FileDialogFilters.FilterPictureFormats_All.IndexOf("|") + 1));
            }
        }

        private void ExportAllTextures(string outputDirectory, string fileExtension)
        {
            foreach (var tex in CurBlock.Textures)
            {
                string outFile = Path.Combine(outputDirectory, LegalizeFilePath(((TextureLoadedInfos)tex.Tag).Name) + fileExtension);
                ExportTexture(outFile, tex);
            }
        }

        private string LegalizeFilePath(string str)
        {
            var illegalChars = Path.GetInvalidFileNameChars();
            foreach (char c in illegalChars)
            {
                string cs = char.ToString(c);
                switch (c)
                {
                    case '"':
                        {
                            str = str.Replace(cs, "_highcome_");
                            break;
                        }

                    case '|':
                        {
                            str = str.Replace(cs, "_sep_");
                            break;
                        }

                    case '<':
                        {
                            str = str.Replace(cs, "_quakauf_");
                            break;
                        }

                    case '>':
                        {
                            str = str.Replace(cs, "_quakzu_");
                            break;
                        }

                    case ':':
                        {
                            str = str.Replace(cs, "_dp_");
                            break;
                        }

                    case '*':
                        {
                            str = str.Replace(cs, "_star_");
                            break;
                        }

                    case '?':
                        {
                            str = str.Replace(cs, "_qm_");
                            break;
                        }

                    case '/':
                        {
                            str = str.Replace(cs, "_rsep_");
                            break;
                        }

                    case '\\':
                        {
                            str = str.Replace(cs, "_lsep_");
                            break;
                        }
                }
            }

            return str;
        }

        private void ImportAllTextures(string inputDirecotry, string extensionFilter)
        {
            var files = Directory.GetFiles(inputDirecotry);
            foreach (var tex in CurBlock.Textures)
            {
                TextureLoadedInfos info = (TextureLoadedInfos)tex.Tag;
                string legalizedName = LegalizeFilePath(info.Name);
                string f = files.FirstOrDefault(n => (Path.GetFileNameWithoutExtension(n) ?? "") == (legalizedName ?? ""));
                if (!string.IsNullOrEmpty(f) && !info.IsReadOnly)
                {
                    ImportTexture(f, tex);
                }

                TextureReplaced?.Invoke(this, new EventArgs());
            }
        }

        private void ExportTexture(string outputFile)
        {
            ExportTexture(outputFile, CurTexture);
        }

        private void ExportTexture(string outputFile, Material tex)
        {
            tex.Image.Save(outputFile);
        }

        private void ImportTexture(string inputFile, Material mat)
        {
            byte[] texdata = null;
            byte[] palette = null;
            TextureLoadedInfos info = (TextureLoadedInfos)mat.Tag;
            var fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            var img1 = Image.FromFile(inputFile);
            var img = new Bitmap(img1);
            img1.Dispose();
            fs.Close();

            // Resize image to fit current one
            if (mat.Image.Size != img.Size)
            {
                img = (Bitmap)SM64Lib.Model.Fast3D.TextureManager.ResizeImage(img, mat.Image.Size);
            }

            // Convert Image to N64 Texture
            SM64Lib.N64Graphics.N64Graphics.Convert(ref texdata, ref palette, info.TextureFormat, img);

            // Write Texture & Palete Data to ROM
            var rom = rommgr.GetBinaryRom(FileAccess.ReadWrite);
            rom.Position = info.TextureRomAddress;
            rom.Write(texdata);
            if (palette is object)
            {
                rom.Position = info.TexturePaletteRomAddress;
                rom.Write(palette);
            }

            rom.Close();

            // Set new Image to Material
            mat.Image = img;

            // Set new Image to PictureBox
            var pb = SearchPictureBoxByMaterial(mat);
            if (pb is object)
            {
                pb.Image = img;
            }

            // Reload Texture Info
            ShowTextureInfos();
        }

        private PictureBox SearchPictureBoxByMaterial(Material mat)
        {
            foreach (Control c in FlowLayoutPanel_Textures.Controls)
            {
                if (c is PictureBox && (Material)c?.Tag == mat)
                {
                    return (PictureBox)c;
                }
            }

            return null;
        }

        public class TextureBlock
        {
            public string Name { get; set; } = "";
            public List<Material> Textures { get; private set; } = new List<Material>();
        }

        public class TextureCategory
        {
            public string Name { get; set; } = "";
            public List<TextureBlock> Blocks { get; private set; } = new List<TextureBlock>();
        }
    }
}