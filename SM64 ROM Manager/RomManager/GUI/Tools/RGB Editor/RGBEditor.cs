using System;
using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using System.Windows.Forms;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using global::SM64Lib;
using global::SM64Lib.Data;
using SM64Lib.TextValueConverter;
using Z.Core.Extensions;

namespace SM64_ROM_Manager
{
    public partial class RGBEditor
    {
        public class RGBEditInfo
        {
            public string Name { get; set; } = "";
            public uint? AlphaAddress { get; set; } = default;
            public uint? LightAddress { get; set; } = default;
            public uint? DarkAddress { get; set; } = default;
            public bool DoubleLightRGB { get; set; } = false;
            public bool DoubleDarkRGB { get; set; } = false;
        }

        // Declarations

        private readonly RomManager rommgr;
        private readonly string predifnedEntryFile = Path.Combine(Publics.General.MyDataPath, @"RGB Editor\RGB Entries.json");
        private readonly string customEntryFile = Path.Combine(Publics.General.MyDataPath, @"RGB Editor\RGB Entries Custom.json");
        private readonly List<RGBEditInfo> predifinedRgbEntries = new List<RGBEditInfo>();
        private readonly List<RGBEditInfo> customRgbEntries = new List<RGBEditInfo>();

        // Properties

        private (ComboItem item, RGBEditInfo info) CurItem
        {
            get
            {
                ComboItem c = (ComboItem)comboBox1.SelectedItem;

                if (c is object)
                {
                    return (c, (RGBEditInfo)c.Tag);
                }
                else
                {
                    return default;
                }
            }
        }

        // Constructor

        public RGBEditor(RomManager rommgr)
        {
            this.rommgr = rommgr;
            InitializeComponent();
            comboBox1.UpdateAmbientColors();
            textBox2.UpdateAmbientColors();
            textBox3.UpdateAmbientColors();
            textBox4.UpdateAmbientColors();
            textBox5.UpdateAmbientColors();
            textBox6.UpdateAmbientColors();
            textBox7.UpdateAmbientColors();
            textBox8.UpdateAmbientColors();
        }

        // Functions

        private void LoadRgbEntries()
        {
            if (File.Exists(predifnedEntryFile))
            {
                predifinedRgbEntries.AddRange(JArray.Parse(File.ReadAllText(predifnedEntryFile)).ToObject<RGBEditInfo[]>());
            }

            if (File.Exists(customEntryFile))
            {
                customRgbEntries.AddRange(JArray.Parse(File.ReadAllText(customEntryFile)).ToObject<RGBEditInfo[]>());
            }
        }

        private void SaveRgbEntries()
        {
            File.WriteAllText(customEntryFile, JArray.FromObject(customRgbEntries).ToString());
        }

        private void ListRgbEntries()
        {
            comboBox1.Items.Clear();
            foreach (RGBEditInfo e in predifinedRgbEntries.Concat(customRgbEntries))
                AddComboItem(e);
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void AddComboItem(RGBEditInfo e)
        {
            var c = new ComboItem();
            SetTextOnComboItem(c, e);
            c.Tag = e;
            comboBox1.Items.Add(c);
        }

        private void SetTextOnComboItem(ComboItem c, RGBEditInfo e)
        {
            c.Text = e.Name;
        }

        private void AddNewEntry()
        {
            RGBEditInfo e;

            // Edit
            var editor = new RGBEditInfoEditor();
            if (editor.ShowDialog() == DialogResult.OK)
            {
                e = editor.RGBEditInfo;

                // Add to lists
                customRgbEntries.Add(e);
                AddComboItem(e);

                // Save Custom Entries
                SaveRgbEntries();
            }
        }

        private bool IsPredifined(RGBEditInfo e)
        {
            return predifinedRgbEntries.Contains(e);
        }

        private bool EditCurEntry()
        {
            var cur = CurItem;

            if (!IsPredifined(cur.info))
            {
                // Edit
                var editor = new RGBEditInfoEditor() { RGBEditInfo = cur.info };
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    // Update list item
                    SetTextOnComboItem(cur.item, cur.info);

                    // Save Custom Entries
                    SaveRgbEntries();
                    return true;
                }
            }

            return false;
        }

        private bool RemoveEntry()
        {
            var cur = CurItem;

            if (!IsPredifined(cur.info))
            {
                // Remove item
                customRgbEntries.Remove(cur.info);
                comboBox1.Items.Remove(cur.item);

                // Select first
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }

                // Save Custom Entries
                SaveRgbEntries();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoadValues()
        {
            BinaryData rom = null;
            var info = CurItem.info;
            bool infoisnotnothing = info is object;
            button2.Enabled = infoisnotnothing;
            if (infoisnotnothing)
            {
                rom = rommgr.GetBinaryRom(FileAccess.Read);

                // Alpha

                bool enableAlpha = info.AlphaAddress is object;
                textBox8.Enabled = enableAlpha;
                if (enableAlpha)
                {
                    rom.Position = (long)info.AlphaAddress;
                    textBox8.Text = TextValueConverter.TextFromValue(rom.ReadByte());
                }

                // Dark

                bool enableDark = info.DarkAddress is object;
                textBox5.Enabled = enableDark;
                textBox6.Enabled = enableDark;
                textBox7.Enabled = enableDark;
                if (enableDark)
                {
                    rom.Position = (long)info.DarkAddress;
                    textBox7.Text = TextValueConverter.TextFromValue(rom.ReadByte());
                    textBox6.Text = TextValueConverter.TextFromValue(rom.ReadByte());
                    textBox5.Text = TextValueConverter.TextFromValue(rom.ReadByte());
                }

                // Light

                bool enableLight = info.LightAddress is object;
                textBox2.Enabled = enableLight;
                textBox3.Enabled = enableLight;
                textBox4.Enabled = enableLight;
                if (enableLight)
                {
                    rom.Position = (long)info.LightAddress;
                    textBox2.Text = TextValueConverter.TextFromValue(rom.ReadByte());
                    textBox3.Text = TextValueConverter.TextFromValue(rom.ReadByte());
                    textBox4.Text = TextValueConverter.TextFromValue(rom.ReadByte());
                }
            }

            rom?.Close();
        }

        private void PatchValues()
        {
            BinaryData rom = null;
            var info = CurItem.info;
            if (info is object)
            {
                rom = rommgr.GetBinaryRom(FileAccess.ReadWrite);

                // Light

                bool enableLight = info.LightAddress is object;
                if (enableLight)
                {
                    rom.Position = (long)info.LightAddress;
                    for (int i = 1, loopTo = info.DoubleLightRGB ? 2 : 1; i <= loopTo; i++)
                    {
                        rom.WriteByte(Conversions.ToByte(TextValueConverter.ValueFromText(textBox2.Text)));
                        rom.WriteByte(Conversions.ToByte(TextValueConverter.ValueFromText(textBox3.Text)));
                        rom.WriteByte(Conversions.ToByte(TextValueConverter.ValueFromText(textBox4.Text)));
                        rom.Position += 1;
                    }
                }

                // Dark

                bool enableDark = info.DarkAddress is object;
                if (enableDark)
                {
                    rom.Position = (long)info.DarkAddress;
                    for (int i = 1, loopTo1 = info.DoubleDarkRGB ? 2 : 1; i <= loopTo1; i++)
                    {
                        rom.WriteByte(Conversions.ToByte(TextValueConverter.ValueFromText(textBox7.Text)));
                        rom.WriteByte(Conversions.ToByte(TextValueConverter.ValueFromText(textBox6.Text)));
                        rom.WriteByte(Conversions.ToByte(TextValueConverter.ValueFromText(textBox5.Text)));
                        rom.Position += 1;
                    }
                }

                // Alpha

                bool enableAlpha = info.AlphaAddress is object;
                if (enableAlpha)
                {
                    rom.Position = (long)info.AlphaAddress;
                    rom.WriteByte(Conversions.ToByte(TextValueConverter.ValueFromText(textBox8.Text)));
                }
            }

            rom?.Close();
        }

        // User Interface

        private void RGBEditor_Shown(object sender, EventArgs e)
        {
            LoadRgbEntries();
            ListRgbEntries();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PatchValues();
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            AddNewEntry();
        }

        private void ButtonX6_Click(object sender, EventArgs e)
        {
            EditCurEntry();
        }

        private void ButtonX4_Click(object sender, EventArgs e)
        {
            RemoveEntry();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableEdit = !IsPredifined(CurItem.info);
            ButtonX_Edit.Enabled = enableEdit;
            ButtonX_Remove.Enabled = enableEdit;
            LoadValues();
        }
    }
}