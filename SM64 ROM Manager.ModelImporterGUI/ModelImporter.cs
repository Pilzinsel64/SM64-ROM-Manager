using System;
using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using global::System.Reflection;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.ModelConverterGUI;
using global::SM64_ROM_Manager.ModelImporterGUI.ImporterPresets;
using global::SM64_ROM_Manager.Publics;
using global::SM64Lib.Geolayout;
using global::SM64Lib.Model;
using global::SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager.ModelImporterGUI
{
    public partial class ModelImporter
    {
        public ModelImporter()
        {
            this.Shown += ModelImporter_Shown;
            // SetDPIAware

            InitializeComponent();
            if (Assembly.GetExecutingAssembly() == Assembly.GetEntryAssembly())
            {
                General.DoDefaultInitsAfterApplicationStartup();
            }

            base.UpdateAmbientColors();
            Panel1.BackColor = base.BackColor;
            ComboBoxEx1.Items.Clear();
            ComboBoxEx1.Items.AddRange(new[] { new ComboItem() { Text = "Don't force", Tag = -1 }, new ComboItem() { Text = "1 - Solid", Tag = 1 }, new ComboItem() { Text = "2 - Solid Foreground", Tag = 2 }, new ComboItem() { Text = "4 - Alpha", Tag = 4 }, new ComboItem() { Text = "5 - Transparent", Tag = 5 }, new ComboItem() { Text = "6 - Transparent Foreground", Tag = 6 } });
            ComboBoxEx1.SelectedIndex = 3;
            ComboBoxEx1.UpdateAmbientColors();
        }

        private string _RomFile = "";
        private ObjectModel mdl = null;
        private List<ImporterProfile> presets = new List<ImporterProfile>();
        private SM64Lib.RomManager rommgr = null;

        public string RomFile
        {
            get
            {
                return _RomFile;
            }

            set
            {
                _RomFile = value;
                if (!string.IsNullOrEmpty(value))
                {
                    LabelX1.Text = Path.GetFileName(value);
                    LabelX1.Symbol = "";
                }
            }
        }

        public ModelImporter(SM64Lib.RomManager rommgr) : this()
        {
            this.rommgr = rommgr;
        }

        private void ClearOutput()
        {
            TextBoxX_Output.Text = "";
        }

        private void WriteOutput()
        {
            TextBoxX_Output.AppendText(Constants.vbNewLine);
        }

        private void WriteOutput(string msg)
        {
            TextBoxX_Output.AppendText(msg + Constants.vbNewLine);
        }

        private void ButtonX_OpenRom_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "SM64 ROMs (*.z64)|*.z64|All files (*.*)|*.*" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RomFile = ofd.FileName;
                rommgr = new SM64Lib.RomManager(RomFile);
            }
        }

        private void ButtonX_ConvertMdl_Click(object sender, EventArgs e)
        {
            var resMdl = PublicFunctions.GetModelViaModelConverter(forceDisplaylist: Conversions.ToSByte(((ComboItem)ComboBoxEx1.SelectedItem).Tag), inputsKey: Conversions.ToString(SelectedProfile().FileName.GetHashCode()));
            if (resMdl is object)
            {
                mdl = resMdl?.mdl;
                ButtonX_ConvertMdl.Symbol = "";
                ButtonX_ImportMdl.Enabled = true;
            }
        }

        private void ButtonX_ImportMdl_Click(object sender, EventArgs e)
        {
            ButtonX_ImportMdl.Symbol = "";
            var pap = SelectedProfileAndPreset();
            var profile = pap.profile;
            var preset = pap.preset;
            int romAddr = preset.RomAddress; // ValueFromText(TextBoxX_RomAddr.Text)
            int bankAddr = preset.RamAddress; // ValueFromText(TextBoxX_BankAddr.Text)
            int maxLength = preset.MaxLength; // ValueFromText(TextBoxX_MaxLength.Text)
            var pm = new PatchScripts.PatchingManager();
            var scriptparams = new Dictionary<string, object>() { { "romfile", RomFile }, { "presetName", preset.Name }, { "presetDescription", preset.Description }, { "RomAddress", preset.RomAddress }, { "RamAddress", preset.RamAddress }, { "MaxLength", preset.MaxLength }, { "CollisionPointersArray", preset.CollisionPointers.ToArray() }, { "GeoPointersArray", preset.GeometryPointers.ToArray() }, { "ConvertedModelLength", mdl.Length }, { "ConvertedModel", mdl }, { "profilepath", profile.FileName } };
            if (maxLength > 0 && mdl.Length > maxLength)
            {
                MessageBoxEx.Show("Model is bigger then the max allowed length!", "Model too big", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearOutput();

            // Execute Script Before
            if (preset.ScriptBefore is object && !string.IsNullOrEmpty(preset.ScriptBefore.Script))
            {
                WriteOutput("Executing Script ...");
                pm.Patch(preset.ScriptBefore, this, scriptparams);
            }

            int col = -1;
            var geo = Array.Empty<Geopointer>();
            int len = 0;
            ObjectModel.SaveResult sr = null;
            bool iscollisionempty = mdl.Collision is null;
            bool isf3disempty = mdl.Fast3DBuffer is null;
            var fs = new FileStream(_RomFile, FileMode.Open, FileAccess.ReadWrite);
            var bw = new BinaryWriter(fs);

            // Write to stream
            WriteOutput("Writing Model ...");
            sr = mdl.ToStream(fs, romAddr, romAddr - (bankAddr & 0xFFFFFF), (int)(bankAddr & 0xFF000000));
            if (sr is object)
            {
                geo = sr.GeoPointers.ToArray();
                col = sr.CollisionPointer;
                len = Conversions.ToInteger(sr.Length);
            }

            // Write Collision Pointer
            if (col > -1)
            {
                WriteOutput("Chaning Collision Pointers ...");
                foreach (int cp in SelectedPreset().CollisionPointers)
                {
                    fs.Position = cp;
                    bw.Write(SwapInts.SwapInt32(col));
                }
            }

            // Write Geopointer
            if (geo.Length > 0)
            {
                WriteOutput("Chaning Geometry Pointers ...");
                foreach (int gp in SelectedPreset().GeometryPointers)
                {
                    fs.Position = gp;
                    bw.Write(SwapInts.SwapInt32(geo[0].SegPointer));
                    fs.Position = gp - 4;
                    if (fs.ReadByte() == 0x15)
                    {
                        fs.WriteByte(geo[0].Layer);
                    }
                    else
                    {
                        fs.Position = gp - 8;
                        if (fs.ReadByte() == 0x13)
                        {
                            fs.WriteByte(geo[0].Layer);
                        }
                    }
                }
            }

            fs.Close();
            if (preset.ScriptAfter is object && !string.IsNullOrEmpty(preset.ScriptAfter.Script))
            {
                WriteOutput("Executing Script ...");
                pm.Patch(preset.ScriptAfter, this, scriptparams);
            }

            if (col > -1)
            {
                WriteOutput($"Collision Pointer:{Constants.vbTab}{sr.CollisionPointer.ToString("X")}");
            }

            foreach (Geopointer g in geo)
                WriteOutput($"DL-Pointer:{Constants.vbTab}{g.SegPointer.ToString("X")} ({g.Layer.ToString()})");
            WriteOutput();
            WriteOutput(DateAndTime.Now.ToShortTimeString() + " - Done");

            // MessageBoxEx.Show("Model has been imported succesfully!", "Model imported", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonX_ImportMdl.Symbol = "";
        }

        private void LoadPresets()
        {
            // Add Custom Preset

            var custom = new ImporterProfile();
            custom.Name = "Custom";
            custom.Presets.Add(new ImporterPreset());
            presets.Add(custom);

            // Load Files

            var mgr = new ImporterProfileManager();
            var files = Directory.GetFiles(General.MyImporterPresetsPath, "*", SearchOption.AllDirectories);
            foreach (string f in files)
            {
                var ext = Path.GetExtension(f);
                if (ext == ".json" || ext == ".xml")
                {
                    var preset = mgr.Read(f);
                    presets.Add(preset);
                }
            }

            // Create List

            ComboBoxEx2.SuspendLayout();
            ComboBoxEx2.Items.Clear();
            foreach (ImporterProfile preset in presets)
            {
                var ci = new ComboItem();
                ci.Text = preset.Name;
                ci.Tag = preset;
                ComboBoxEx2.Items.Add(ci);
            }

            ComboBoxEx2.SelectedIndex = 0;
            ComboBoxEx2.ResumeLayout();
        }

        private ImporterProfile SelectedProfile()
        {
            return (ImporterProfile)((ComboItem)ComboBoxEx2.SelectedItem)?.Tag;
        }

        private ImporterPreset SelectedPreset()
        {
            return SelectedProfileAndPreset().preset;
        }

        private (ImporterProfile profile, ImporterPreset preset) SelectedProfileAndPreset()
        {
            var profile = SelectedProfile();
            var preset = profile?.Presets.FirstOrDefault();
            return (profile, preset);
        }

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            Flyout1.Close();
        }

        private void ButtonX4_Click(object sender, EventArgs e)
        {
            var custom = new ImporterProfile();
            custom.Name = "New Importer Preset _" + Conversions.ToString(presets.Count);
            custom.Presets.Add(new ImporterPreset());
            presets.Add(custom);
            var ci = new ComboItem();
            ci.Text = custom.Name;
            ci.Tag = custom;
            ComboBoxEx2.Items.Add(ci);
            ComboBoxEx2.SelectedItem = ci;
        }

        private void SaveProfile(ImporterProfile p)
        {
            if (p is object)
            {
                var mgr = new ImporterProfileManager();
                mgr.Save(p, General.MyImporterPresetsPath);
            }
        }

        private void ButtonX7_Click(object sender, EventArgs e)
        {
            ComboBoxEx2.SuspendLayout();
            File.Delete(SelectedProfile().FileName);
            presets.Remove(SelectedProfile());
            ComboBoxEx2.Items.Remove(ComboBoxEx2.SelectedItem);
            ComboBoxEx2.SelectedIndex = 0;
            ComboBoxEx2.ResumeLayout();
            Flyout1.Close();
        }

        private void EditScript(ref PatchScripts.PatchScript script)
        {
            if (script is null)
                script = new PatchScripts.PatchScript();
            var editor = new PatchScripts.TweakScriptEditor(script, rommgr);
            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                if (editor.NeedToSave)
                {
                    SaveProfile(SelectedProfile());
                }
            }
        }

        private void ButtonItem2_Click(object sender, EventArgs e)
        {
            var p = SelectedPreset();
            var argscript = p.ScriptAfter;
            EditScript(ref argscript);
            p.ScriptAfter = argscript;
        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            var p = SelectedPreset();
            var argscript = p.ScriptBefore;
            EditScript(ref argscript);
            p.ScriptBefore = argscript;
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            var editor = new PatchScripts.TweakProfileEditor();
            var profile = SelectedProfile();

            editor.Titel = profile.Name;
            editor.Description = profile.Description;
            editor.Version = profile.Version;

            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                profile.Name = editor.Titel.Trim();
                profile.Description = editor.Description.Trim();
                profile.Version = editor.Version;
                ((ComboItem)ComboBoxEx2.SelectedItem).Text = profile.Name;
                ShowProfileInfo(SelectedProfile());
                SaveProfile(profile);
            }
        }

        private void ShowProfileInfo(ImporterProfile preset)
        {
            if (preset is object)
            {
                LabelX_PatchName.Text = preset.Name;
                LabelX_Description.Text = preset.Description;
                labelX_Version.Text = $"Version {preset.Version}";
            }
            else
            {
                LabelX_PatchName.Text = string.Empty;
                LabelX_Description.Text = string.Empty;
                labelX_Version.Text = string.Empty;
            }
        }

        private void Flyout1_PrepareContent(object sender, EventArgs e)
        {
            ShowProfileInfo(SelectedProfile());
        }

        private void ModelImporter_Shown(object sender, EventArgs e)
        {
            LoadPresets();
        }

        private void LoadPreset(ImporterPreset preset)
        {
            TextBoxX_BankAddr.Text = TextValueConverter.TextFromValue(preset.RamAddress);
            TextBoxX_RomAddr.Text = TextValueConverter.TextFromValue(preset.RomAddress);
            TextBoxX_MaxLength.Text = TextValueConverter.TextFromValue(preset.MaxLength);
            string colText = "";
            foreach (int cp in preset.CollisionPointers)
            {
                if (!string.IsNullOrEmpty(colText))
                {
                    colText += ", ";
                }

                colText += TextValueConverter.TextFromValue(cp);
            }

            TextBoxX2.Text = colText;
            string geoText = "";
            foreach (int gp in preset.GeometryPointers)
            {
                if (!string.IsNullOrEmpty(geoText))
                {
                    geoText += ", ";
                }

                geoText += TextValueConverter.TextFromValue(gp);
            }

            TextBoxX1.Text = geoText;
        }

        private void ComboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedProfile() is object)
            {
                LoadPreset(SelectedPreset());
            }
        }

        private void TextBoxX2_TextChanged(object sender, EventArgs e)
        {
            var preset = SelectedPreset();
            if (preset is object)
            {
                preset.CollisionPointers.Clear();
                foreach (string cp in TextBoxX2.Text.Split(','))
                {
                    if (!string.IsNullOrEmpty(cp))
                    {
                        preset.CollisionPointers.Add(TextValueConverter.ValueFromText(cp.Trim()));
                    }
                }
            }
        }

        private void TextBoxX1_TextChanged(object sender, EventArgs e)
        {
            var preset = SelectedPreset();
            if (preset is object)
            {
                preset.GeometryPointers.Clear();
                foreach (string gp in TextBoxX1.Text.Split(','))
                {
                    if (!string.IsNullOrEmpty(gp))
                    {
                        preset.GeometryPointers.Add(TextValueConverter.ValueFromText(gp.Trim()));
                    }
                }
            }
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            SaveProfile(SelectedProfile());
        }

        private void TextBoxX_RomAddr_TextChanged(object sender, EventArgs e)
        {
            var p = SelectedPreset();
            if (p is object)
            {
                p.RomAddress = TextValueConverter.ValueFromText(TextBoxX_RomAddr.Text);
            }
        }

        private void TextBoxX_BankAddr_TextChanged(object sender, EventArgs e)
        {
            var p = SelectedPreset();
            if (p is object)
            {
                p.RamAddress = TextValueConverter.ValueFromText(TextBoxX_BankAddr.Text);
            }
        }

        private void TextBoxX_MaxLength_TextChanged(object sender, EventArgs e)
        {
            var p = SelectedPreset();
            if (p is object)
            {
                p.MaxLength = TextValueConverter.ValueFromText(TextBoxX_MaxLength.Text);
            }
        }

        private void Flyout1_FlyoutShowing(object sender, DevComponents.DotNetBar.Controls.FlyoutShowingEventArgs e)
        {
            e.Cancel = ComboBoxEx2.SelectedIndex == 0;
        }
    }
}