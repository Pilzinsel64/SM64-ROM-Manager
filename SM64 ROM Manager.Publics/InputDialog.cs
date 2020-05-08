using System;
using global::System.Globalization;
using global::System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib;
using global::SM64Lib.Music;
using SM64Lib.TextValueConverter;
using SM64Lib.Patching;

namespace SM64_ROM_Manager.Publics
{
    internal partial class InputDialog
    {
        private RomManager rommgr;

        public object ReturnValue { get; set; } = null;
        public InputValueType ValueType { get; set; } = InputValueType.Byte;

        public InputDialog(InputValueType valType, RomManager rommgr, object defaultValue = null)
        {
            InitializeComponent();
            ValueType = valType;
            this.rommgr = rommgr;

            string infoText = string.Empty;
            switch (valType)
            {
                case InputValueType.Byte:
                    infoText = "Input a 8 Bit value (Byte)";
                    break;
                case InputValueType.UInt16:
                    infoText = "Input a 16 Bit value (2 Bytes)";
                    break;
                case InputValueType.UInt32:
                    infoText = "Input a 32 Bit value (4 Bytes)";
                    break;
                case InputValueType.Single:
                    infoText = "Input a float value";
                    break;
                case InputValueType.String:
                    infoText = "Input a string";
                    break;
                case InputValueType.Sequence:
                    infoText = "Input a Sequence ID";
                    break;
                case InputValueType.LevelID:
                    infoText = "Input a Level ID";
                    break;
            }

            switch (valType)
            {
                case InputValueType.Byte:
                case InputValueType.UInt16:
                case InputValueType.UInt32:
                    {
                        ComboBoxEx1.Text = defaultValue is null ? "0" : TextValueConverter.TextFromValue(Conversions.ToLong(defaultValue));
                        break;
                    }

                case InputValueType.Single:
                    {
                        ComboBoxEx1.Text = $"0{CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator}00";
                        break;
                    }

                case InputValueType.String:
                    {
                        ComboBoxEx1.Text = Conversions.ToString(defaultValue is null ? "Text" : defaultValue);
                        break;
                    }

                case InputValueType.Sequence:
                    {
                        if (rommgr is object)
                        {
                            byte id = 0;
                            foreach (MusicSequence ms in rommgr.MusicList)
                            {
                                ComboBoxEx1.Items.Add($"{id.ToString("X2")} - {ms.Name}");
                                id += 1;
                            }

                            ComboBoxEx1.DropDownStyle = ComboBoxStyle.DropDownList;
                            ComboBoxEx1.SelectedIndex = 0;
                        }

                        break;
                    }

                case InputValueType.LevelID:
                    {
                        if (rommgr is object)
                        {
                            foreach (SM64Lib.Levels.LevelInfoDataTabelList.Level lvi in rommgr.LevelInfoData)
                                ComboBoxEx1.Items.Add($"{lvi.ID.ToString("X2")} - {lvi.Name}");
                            ComboBoxEx1.DropDownStyle = ComboBoxStyle.DropDownList;
                            ComboBoxEx1.SelectedIndex = 0;
                        }

                        break;
                    }
            }

            if (infoText != null)
            {
                LabelX1.Text = infoText;
            }

            base.UpdateAmbientColors();
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            var switchExpr = ValueType;
            switch (switchExpr)
            {
                case InputValueType.Byte:
                    {
                        byte val;
                        if (byte.TryParse(Conversions.ToString(TextValueConverter.ValueFromText(ComboBoxEx1.Text.Trim())), out val))
                        {
                            ReturnValue = val;
                        }
                        else
                        {
                            ReturnValue = null;
                        }

                        break;
                    }

                case InputValueType.UInt16:
                    {
                        ushort val;
                        if (ushort.TryParse(Conversions.ToString(TextValueConverter.ValueFromText(ComboBoxEx1.Text.Trim())), out val))
                        {
                            ReturnValue = val;
                        }
                        else
                        {
                            ReturnValue = null;
                        }

                        break;
                    }

                case InputValueType.UInt32:
                    {
                        uint val;
                        if (uint.TryParse(Conversions.ToString(TextValueConverter.ValueFromText(ComboBoxEx1.Text.Trim())), out val))
                        {
                            ReturnValue = val;
                        }
                        else
                        {
                            ReturnValue = null;
                        }

                        break;
                    }

                case InputValueType.Single:
                    {
                        float val;
                        if (float.TryParse(ComboBoxEx1.Text.Trim(), out val))
                        {
                            ReturnValue = Math.Round(val, 2);
                        }
                        else
                        {
                            ReturnValue = null;
                        }

                        break;
                    }

                case InputValueType.String:
                    {
                        ReturnValue = ComboBoxEx1.Text;
                        break;
                    }

                case InputValueType.Sequence:
                    {
                        ReturnValue = Conversions.ToByte(ComboBoxEx1.SelectedIndex);
                        break;
                    }

                case InputValueType.LevelID:
                    {
                        ReturnValue = rommgr.LevelInfoData[ComboBoxEx1.SelectedIndex].ID;
                        break;
                    }
            }

            if (ReturnValue is object)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBoxEx.Show(this, "The value you entered is invalid!", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}