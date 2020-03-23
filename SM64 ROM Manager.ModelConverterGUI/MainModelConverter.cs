using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using global::System.Drawing;
using global::System.IO;
using System.Linq;
using System.Threading.Tasks;
using global::System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.ModelConverterGUI.My.Resources;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib.Model;
using global::SM64Lib.Model.Fast3D;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    public partial class MainModelConverter
    {

        // C o n s t r u c t o r
        public MainModelConverter()
        {
            base.FormClosing += Form_ModelConverter_FormClosing;
            this.Shown += MainModelConverter_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();
        }

        // C o n s t a n t s

        private const string EXT_CONVERSION_PREFERENCES = ".conpref";
        private const string EXT_GRAPHICS_SETTINGS = ".gf";
        private const string EXT_COLLISION_SETTINGS = ".col";

        // F i e l d s

        private DialogResult DResult = DialogResult.None;
        private ObjectInputSettings objSettings = new ObjectInputSettings();
        private Object3D objVisualMap = null;
        private Object3D objCollisionMap = null;
        private string curModelFile = "";
        private string curCollisionFile = "";
        private SM64Lib.Model.Collision.CollisionSettings curColSettings;
        private TextureFormatSettings curTexFormatSettings;
        private Vertex curDiffusePos = null;

        // P r o p e r t i e s

        public ObjectModel ResModel { get; set; } = null;
        public sbyte ForceDisplaylist { get; set; } = -1;

        // F e a t u r e s

        private Color GetColorFromShadingByte(byte value)
        {
            return Color.FromArgb(0xFF, value, value, value);
        }

        public new DialogResult ShowDialog()
        {
            ComboBoxEx_UpAxis.SelectedIndex = (int)Settings.FileParser.UpAxis;
            ComboBox_FogTyp.SelectedIndex = 0;
            LoadGuiSettings();
            LoadRecentFiles();
            DialogResult res = default;
            bool ende = false;
            while (!ende)
            {
                try
                {
                    res = base.ShowDialog();
                    ende = true;
                }
                catch (Exception)
                {
                }
            }

            return res;
        }

        private void LoadGuiSettings()
        {
            GuiInputPreferences guiInputSettings;
            if (CheckBoxX_ConvertModel.Checked && File.Exists(curModelFile))
            {
                guiInputSettings = GuiInputPreferences.Load(curModelFile + EXT_CONVERSION_PREFERENCES);
            }
            else if (CheckBoxX_ConvertCollision.Checked && File.Exists(curCollisionFile))
            {
                guiInputSettings = GuiInputPreferences.Load(curCollisionFile + EXT_CONVERSION_PREFERENCES);
            }
            else
            {
                guiInputSettings = new GuiInputPreferences();
            }

            NUD_Scaling.Value = guiInputSettings.Scaling;
            SwitchButton_EnableReduceVertices.Value = Conversions.ToBoolean(guiInputSettings.ReduceDupVerts);
            SwitchButton_ResizeTextures.Value = guiInputSettings.ResizeTextures;
            SwitchButton_CenterModel.Value = guiInputSettings.CenterModel;
            ColorPickerButton_ShadingAmbient.SelectedColor = guiInputSettings.Shading.AmbientColor;
            ColorPickerButton_ShadingDiffuse.SelectedColor = guiInputSettings.Shading.DiffuseColor;
            curDiffusePos = guiInputSettings.Shading.DiffusePosition;
            bool isFogNotNothing = guiInputSettings.Fog is object;
            SwitchButton_EnableFog.Value = isFogNotNothing;
            if (isFogNotNothing)
            {
                ColorPickerButton_FogColor.SelectedColor = guiInputSettings.Fog.Color;
                ComboBox_FogTyp.SelectedIndex = (int)guiInputSettings.Fog.Type;
            }
        }

        private void SaveGuiSettings(bool importVMap, bool importColMap)
        {
            var guiInputSettings = new GuiInputPreferences();
            guiInputSettings.Scaling = NUD_Scaling.Value;
            guiInputSettings.ReduceDupVerts = SwitchButton_EnableReduceVertices.Value;
            guiInputSettings.ResizeTextures = SwitchButton_ResizeTextures.Value;
            guiInputSettings.CenterModel = SwitchButton_CenterModel.Value;
            guiInputSettings.Shading.AmbientColor = ColorPickerButton_ShadingAmbient.SelectedColor;
            guiInputSettings.Shading.DiffuseColor = ColorPickerButton_ShadingDiffuse.SelectedColor;
            guiInputSettings.Shading.DiffusePosition = curDiffusePos;
            if (SwitchButton_EnableFog.Value)
            {
                guiInputSettings.Fog = new Fog() { Color = ColorPickerButton_FogColor.SelectedColor, Type = (FogPreset)ComboBox_FogTyp.SelectedIndex };
            }
            else
            {
                guiInputSettings.Fog = null;
            }

            if (importVMap)
            {
                guiInputSettings.Save(curModelFile + EXT_CONVERSION_PREFERENCES);
            }

            if (importColMap)
            {
                guiInputSettings.Save(curCollisionFile + EXT_CONVERSION_PREFERENCES);
            }
        }

        // G u i

        private async void Button_ConvertModel_Click(object sender, EventArgs e)
        {
            // Set Convert Settings
            {
                var withBlock = objSettings;
                withBlock.ReduceDupVertLevel = SwitchButton_EnableReduceVertices.Value ? ObjectInputSettings.ReduceDuplicateVerticesLevel.Level1 : ObjectInputSettings.ReduceDuplicateVerticesLevel.Level0;
                withBlock.ResizeTextures = SwitchButton_ResizeTextures.Value;
                withBlock.CenterModel = SwitchButton_CenterModel.Value;
                withBlock.ForceDisplaylist = ForceDisplaylist;
                withBlock.Shading.AmbientColor = ColorPickerButton_ShadingAmbient.SelectedColor;
                withBlock.Shading.DiffuseColor = ColorPickerButton_ShadingDiffuse.SelectedColor;
                withBlock.Shading.DiffusePosition = curDiffusePos;
                if (SwitchButton_EnableFog.Value)
                {
                    withBlock.Fog = new Fog() { Color = ColorPickerButton_FogColor.SelectedColor, Type = (FogPreset)ComboBox_FogTyp.SelectedIndex };
                }
                else
                {
                    withBlock.Fog = null;
                }
            }

            // Get Model
            Object3D vmap = null;
            Object3D colmap = null;
            if (CheckBoxX_ConvertModel.Checked)
                vmap = objVisualMap;
            if (CheckBoxX_ConvertCollision.Checked)
                colmap = objCollisionMap;

            // Check for Triangluation
            if (vmap is object)
            {
                if (vmap.Meshes.Where(n => n.Faces.Where(nn => nn.Points.Count != 3).Count() > 0).Count() > 0)
                {
                    MessageBoxEx.Show(MainModelconverter_Resources.MsgBox_VMapIsnotTriangled, MainModelconverter_Resources.MsgBox_VMapIsnotTriangled_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (colmap is object && vmap != colmap)
            {
                if (colmap.Meshes.Where(n => n.Faces.Where(nn => nn.Points.Count != 3).Count() > 0).Count() > 0)
                {
                    MessageBoxEx.Show(MainModelconverter_Resources.MsgBox_ColMapIsnotTriangled, MainModelconverter_Resources.MsgBox_ColMapIsnotTriangled_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (vmap is object)
            {
                if (vmap.Meshes.Where(n => n.Vertices.Where(v => CheckIfInBounds(v)).Any()).Any())
                {
                    string msg = vmap == colmap ? "model" : "visual map";
                    MessageBoxEx.Show(string.Format(MainModelconverter_Resources.MsgBox_ModelTooBig, msg), MainModelconverter_Resources.MsgBox_ModelTooBig_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (colmap is object && vmap != colmap)
            {
                if (colmap.Meshes.Where(n => n.Vertices.Where(v => CheckIfInBounds(v)).Any()).Any())
                {
                    MessageBoxEx.Show(string.Format(MainModelconverter_Resources.MsgBox_ModelTooBig, "collision map"), MainModelconverter_Resources.MsgBox_ModelTooBig_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            EnableCirProgress();

            // Prepaire Textures
            if (vmap is object)
            {
                PrepaireTexture(vmap, curTexFormatSettings, SwitchButton_ResizeTextures.Value);
            }

            // Set Null Values
            if (vmap is object)
            {
                vmap.SetNullVertices();
                vmap.SetNullUVs();
                vmap.SetNullNormals();
            }

            if (colmap is object && vmap != colmap)
            {
                colmap.SetNullVertices();
            }

            // Center Model
            if (SwitchButton_CenterModel.Value)
            {
                var mapsToCenter = new List<Mesh>();
                if (vmap is object)
                    mapsToCenter.AddRange(vmap.Meshes);
                if (colmap is object && vmap != colmap)
                    mapsToCenter.AddRange(colmap.Meshes);
                Mesh.CenterModel(mapsToCenter);
            }

            // Scale Model
            if (vmap is object)
            {
                vmap.ScaleModel(Conversions.ToSingle(NUD_Scaling.Value));
            }

            if (colmap is object && vmap != colmap)
            {
                colmap.ScaleModel(Conversions.ToSingle(NUD_Scaling.Value));
            }

            // Convert Model
            ResModel = new ObjectModel();
            if (vmap is null ^ colmap is null)
            {
                if (colmap is object)
                {
                    ResModel.Collision = new SM64Lib.Model.Collision.CollisionMap();
                    await ResModel.Collision.FromObject3DAsync(objSettings, colmap, curColSettings);
                }

                if (vmap is object)
                {
                    ResModel.Fast3DBuffer = new Fast3DBuffer();
                    await ResModel.Fast3DBuffer.FromModelAsync(objSettings, vmap, curTexFormatSettings);
                }
            }
            else
            {
                await ResModel.FromModelAsync(objSettings, vmap, colmap, curTexFormatSettings, curColSettings);
            }

            SaveGuiSettings(vmap is object, colmap is object);
            EnableCirProgress(true);
            DialogResult = DialogResult.OK;
        }

        private bool CheckIfInBounds(Vertex v)
        {
            float var;
            var = Conversions.ToSingle(Math.Round(v.X * NUD_Scaling.Value));
            if (var > short.MaxValue || var < short.MinValue)
            {
                return true;
            }

            var = Conversions.ToSingle(Math.Round(v.Y * NUD_Scaling.Value));
            if (var > short.MaxValue || var < short.MinValue)
            {
                return true;
            }

            var = Conversions.ToSingle(Math.Round(v.Z * NUD_Scaling.Value));
            if (var > short.MaxValue || var < short.MinValue)
            {
                return true;
            }

            return false;
        }

        private void PrepaireTexture(Object3D model, TextureFormatSettings texSettings, bool fitImageSize)
        {
            foreach (var mat in model.Materials)
            {
                if (mat.Value.Image is object)
                {
                    var entry = curTexFormatSettings.GetEntry(mat.Key);
                    Bitmap argbmp = (Bitmap)mat.Value.Image;
                    TextureManager.PrepaireImage(ref argbmp, entry.RotateFlip, SM64Lib.N64Graphics.N64Graphics.StringCodec(texSettings.GetEntry(mat.Key).TextureFormat), fitImageSize);
                }
            }
        }

        private void EnableCirProgress(bool Disable = false)
        {
            CircularProgress1.Visible = !Disable;
            CircularProgress1.IsRunning = !Disable;
            Button_LoadModel.Enabled = Disable;
            Button_LoadCol.Enabled = Disable;
            CloseEnabled = Disable;
        }

        private void Form_ModelConverter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DResult == DialogResult.None)
            {
                DResult = DialogResult.Cancel;
            }
        }

        private async void Button_LM_LoadModel_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = Publics.General.GetExtensionFilter(Settings.FileParser.FileLoaderModule, 0); // "All supported files|*.obj;*.dae|OBJ Files (*.obj)|*.obj|Collada Files (*.dae)|*.dae"
            var p = Settings.RecentFiles.RecentModelFiles;
            if (p.Count > 0)
                ofd.InitialDirectory = Path.GetDirectoryName(p[0]);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                await LoadModel(ofd.FileName);
            }
        }

        private async void Button3_LM_LoadCol_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = Publics.General.GetExtensionFilter(Settings.FileParser.FileLoaderModule, 0); // "All supported files|*.obj;*.dae|OBJ Files (*.obj)|*.obj|Collada Files (*.dae)|*.dae"
            var p = Settings.RecentFiles.RecentModelFiles;
            if (p.Count > 0)
                ofd.InitialDirectory = Path.GetDirectoryName(p[0]);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                await LoadCollision(ofd.FileName);
            }
        }

        private async Task LoadModel(string fileName)
        {
            EnableCirProgress();
            var m = Publics.Publics.GetLoaderModuleFromID(Settings.FileParser.FileLoaderModule);
            bool useascoltoo = CheckBoxX_ConvertCollision.Checked && objCollisionMap is null || objCollisionMap == objVisualMap;

            /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped DisabledTextTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
            objVisualMap = m.Invoke(fileName, new LoaderOptions(true, (UpAxis)ComboBoxEx_UpAxis.SelectedIndex));
            curTexFormatSettings = new TextureFormatSettings();
            await curTexFormatSettings.Load(fileName + EXT_GRAPHICS_SETTINGS);
            objVisualMap.RemoveUnusedMaterials();
            var argcollection = Settings.RecentFiles.RecentModelFiles;
            Publics.Publics.AddRecentFile(ref argcollection, fileName);
            LoadRecentFiles();
            LabelX_Modelfile.Text = Path.GetFileName(fileName);
            curModelFile = fileName;
            LoadGuiSettings();
            if (useascoltoo)
            {
                curCollisionFile = fileName;
                objCollisionMap = objVisualMap;
                LabelX_Colfile.Text = Path.GetFileName(fileName);
                curColSettings = new SM64Lib.Model.Collision.CollisionSettings();
                await curColSettings.Load(fileName + EXT_COLLISION_SETTINGS);
            }

            EnableModelControls();

            /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped DisabledTextTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
            EnableCirProgress(true);
        }

        private async Task LoadCollision(string fileName)
        {
            EnableCirProgress();
            var m = Publics.Publics.GetLoaderModuleFromID(Settings.FileParser.FileLoaderModule);

            /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped DisabledTextTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
            objCollisionMap = m.Invoke(fileName, new LoaderOptions(true, (UpAxis)ComboBoxEx_UpAxis.SelectedIndex));
            curColSettings = new SM64Lib.Model.Collision.CollisionSettings();
            await curColSettings.Load(fileName + EXT_COLLISION_SETTINGS);
            objCollisionMap.RemoveUnusedMaterials();
            var argcollection = Settings.RecentFiles.RecentModelFiles;
            Publics.Publics.AddRecentFile(ref argcollection, fileName);
            LoadRecentFiles();
            LabelX_Colfile.Text = Path.GetFileName(fileName);
            curCollisionFile = fileName;
            LoadGuiSettings();
            EnableModelControls();
            EnableCirProgress(true);

            /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped DisabledTextTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
        }

        private void ShowVCPP2017IsMissingMessage()
        {
            MessageBoxEx.MarkupLinkClick += MessageBoxEx_LinkClicked;
            MessageBoxEx.Show(MainModelconverter_Resources.MsgBox_MVCppMissing, MainModelconverter_Resources.MsgBox_MVCppMissing_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBoxEx.MarkupLinkClick -= MessageBoxEx_LinkClicked;
        }

        private void MessageBoxEx_LinkClicked(object sender, MarkupLinkClickEventArgs e)
        {
            try
            {
                Process.Start(e.HRef);
            }
            catch (Exception)
            {
                Clipboard.SetText(e.HRef);
            }
        }

        private void EnableModelControls()
        {
            Button_ConvertModel.Enabled = true;
            if (objVisualMap is object)
            {
                ButtonX_VisualMapPreview.Enabled = true;
                ButtonX_GraphicsEditor.Enabled = true;
            }

            if (objCollisionMap is object)
            {
                ButtonX_CollisionMapPreview.Enabled = true;
                Button_ColEditor.Enabled = true;
            }
        }

        private void LoadRecentFiles()
        {
            Button_LoadModel.SubItems.Clear();
            Button_LoadCol.SubItems.Clear();
            var argcollection = Settings.RecentFiles.RecentModelFiles;
            Publics.Publics.MergeRecentFiles(ref argcollection);
            foreach (string f in Settings.RecentFiles.RecentModelFiles)
            {
                string sf = Path.GetFileName(f);
                Image ico = Pilz.Win32.Internals.IconExtractor.ExtractIcon(f, true).ToBitmap();
                var btnItem = new ButtonItem();
                btnItem.ButtonStyle = eButtonStyle.ImageAndText;
                btnItem.Text = sf;
                btnItem.Click += ButtonItem_RecentModelFile_Click;
                btnItem.Image = ico;
                Button_LoadModel.SubItems.Add(btnItem);
                btnItem = new ButtonItem(sf);
                btnItem.ButtonStyle = eButtonStyle.ImageAndText;
                btnItem.Text = sf;
                btnItem.Click += ButtonItem_RecentModelFile_Click;
                btnItem.Image = ico;
                Button_LoadCol.SubItems.Add(btnItem);
            }

            Button_LoadModel.Refresh();
            Button_LoadCol.Refresh();
        }

        private async void ButtonItem_RecentModelFile_Click(object osender, EventArgs e)
        {
            var sender = osender as ButtonItem;
            string f = Settings.RecentFiles.RecentModelFiles[sender.Parent.SubItems.IndexOf(sender)];
            if (!string.IsNullOrEmpty(f))
            {
                if (Button_LoadModel.SubItems.Contains(sender))
                {
                    await LoadModel(f);
                }
                else if (Button_LoadCol.SubItems.Contains(sender))
                {
                    await LoadCollision(f);
                }
            }
        }

        private void LabelX_Colfile_Click(object sender, EventArgs e)
        {
            EnableModelControls();
        }

        private async void Button_ColEditor_Click(object sender, EventArgs e)
        {
            var frm = new CollisionEditor(objCollisionMap);
            frm.CollisionSettings = curColSettings;
            frm.ShowDialog();
            await curColSettings.Save(curCollisionFile + EXT_COLLISION_SETTINGS);
        }

        private async void ButtonX_GraphicsEditor_Click(object sender, EventArgs e)
        {
            var frm = new TextureGraphicFormatEditor(objVisualMap);
            frm.TextureFormatSettings = curTexFormatSettings;
            frm.ShowDialog();
            await curTexFormatSettings.Save(curModelFile + EXT_GRAPHICS_SETTINGS);
        }

        private void SwitchButton_EnableFog_ValueChanged(object sender, EventArgs e)
        {
            ComboBox_FogTyp.Enabled = SwitchButton_EnableFog.Value;
            ColorPickerButton_FogColor.Enabled = SwitchButton_EnableFog.Value;
            var switchExpr = SwitchButton_EnableFog.Value;
            switch (switchExpr)
            {
                case true:
                    {
                        if (objSettings.Fog is null)
                        {
                            objSettings.Fog = new Fog();
                        }

                        break;
                    }

                case false:
                    {
                        objSettings.Fog = null;
                        break;
                    }
            }
        }

        private void CheckBoxX_ConvertModel_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = CheckBoxX_ConvertModel.Checked;
            LabelX_Modelfile.Enabled = isChecked;
            Button_LoadModel.Enabled = isChecked;
        }

        private void CheckBoxX_ConvertCollision_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = CheckBoxX_ConvertCollision.Checked;
            LabelX_Colfile.Enabled = isChecked;
            Button_LoadCol.Enabled = isChecked;
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            if (objVisualMap is object)
            {
                var mp = new ModelPreviewOfficeForm(objVisualMap, Conversions.ToSingle(NUD_Scaling.Value));
                mp.Show();
            }
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            if (objCollisionMap is object)
            {
                var mp = new ModelPreviewOfficeForm(objCollisionMap, Conversions.ToSingle(NUD_Scaling.Value));
                mp.Show();
            }
        }

        private void ComboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.FileParser.UpAxis = (UpAxis)ComboBoxEx_UpAxis.SelectedIndex;
        }

        private void Slider1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Slider1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void MainModelConverter_Shown(object sender, EventArgs e)
        {
            if (Environment.ProcessorCount >= 4)
            {
                CollisionEditor.LoadFloorTypesFromDatabaseAsync();
            }
        }

        private void ButtonItem_ResetDiffusePosition_Click(object sender, EventArgs e)
        {
            curDiffusePos = null;
            ButtonItem_ResetDiffusePosition.Visible = false;
        }

        private void ButtonItem_SetupDiffusePosition_Click(object sender, EventArgs e)
        {
            int cx = default, cy = default, cz = default;
            if (curDiffusePos is object)
            {
                cx = Conversions.ToInteger(curDiffusePos.X);
                cy = Conversions.ToInteger(curDiffusePos.Y);
                cz = Conversions.ToInteger(curDiffusePos.Z);
            }

            var editor = new DialogSetUpPoint("Diffuse point", true, true, true, cx, cy, cz);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (curDiffusePos is null)
                {
                    curDiffusePos = new Vertex();
                }

                curDiffusePos.X = editor.IntegerInput_X.Value;
                curDiffusePos.Y = editor.IntegerInput_Y.Value;
                curDiffusePos.Z = editor.IntegerInput_Z.Value;
                ButtonItem_ResetDiffusePosition.Visible = true;
            }
        }

        private void ColorPickerButton_ShadingDiffuse_PopupOpen(object sender, EventArgs e)
        {
            ColorPickerButton_ShadingDiffuse.SubItems.Add(ButtonItem_SetupDiffusePosition);
            ColorPickerButton_ShadingDiffuse.SubItems.Add(ButtonItem_ResetDiffusePosition);
        }
    }
}