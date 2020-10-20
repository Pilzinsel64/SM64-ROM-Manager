using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Text;
using Z.Collections.Extensions;
using Z.Core.Extensions;

namespace SM64_ROM_Manager
{
    public partial class Form_SM64TextConverter
    {

        private TextBoxX activeTextBox = null;
        private bool RaisedClick { get; set; } = false;

        public Form_SM64TextConverter()
        {
            InitializeComponent();
            StyleManager.UpdateAmbientColors(this);
            Load += Form_SM64TextConverter_Load;
            activeTextBox = TextBoxX_Input;
        }

        private void Form_SM64TextConverter_Load(object sender, EventArgs e)
        {
            ComboBoxEx_Mode.SelectedIndex = 0;
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            var switchExpr = ComboBoxEx_Mode.SelectedIndex;
            switch (switchExpr)
            {
                case 0:
                    {
                        TextBoxX_Output.Text = "";
                        if (!string.IsNullOrEmpty(TextBoxX_Input.Text))
                        {
                            try
                            {
                                foreach (byte b in M64TextEncoding.M64Text.GetBytes(TextBoxX_Input.Text.Trim()))
                                {
                                    if (!string.IsNullOrEmpty(TextBoxX_Output.Text))
                                    {
                                        TextBoxX_Output.Text += " ";
                                    }

                                    string hexstring = Conversion.Hex(b);
                                    if (hexstring.Count() == 1)
                                    {
                                        hexstring = "0" + hexstring;
                                    }

                                    TextBoxX_Output.Text += hexstring;
                                }
                            }
                            catch (Exception ex)
                            {
                                if (!RaisedClick)
                                {
                                    MessageBoxEx.Show("Eror error at converting from Text to Hexadecimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        break;
                    }

                case 1:
                    {
                        var byteList = new List<byte>();
                        foreach (string b in TextBoxX_Input.Text.Trim().Split(" "))
                        {
                            if (string.IsNullOrEmpty(b))
                                continue;
                            try
                            {
                                byteList.Add(Conversions.ToByte(Conversions.ToInteger("&H" + b)));
                            }
                            catch (Exception ex)
                            {
                            }
                        }

                        try
                        {
                            TextBoxX_Output.Text = M64TextEncoding.M64Text.GetString(byteList.ToArray());
                        }
                        catch (Exception ex)
                        {
                            if (!RaisedClick)
                            {
                                MessageBoxEx.Show("Eror error at converting from Hexadecimal to Text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        break;
                    }
            }

            RaisedClick = false;
        }

        private void TextBoxX1_TextChanged(object sender, EventArgs e)
        {
            ButtonX_Convert.PerformClick();
            RaisedClick = true;
        }

        private void ButtonX_CopyOutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBoxX_Output.Text);
        }

        private void TextBoxX_Input_MouseClick(object sender, MouseEventArgs e)
        {
            activeTextBox = (TextBoxX)sender;
            activeTextBox.ShortcutsEnabled = false;
            bool isEnabled = !activeTextBox.ReadOnly;
            ButtonItem_Remove.Enabled = isEnabled;
            ButtonItem_cut.Enabled = isEnabled;
            ButtonItem_Paste.Enabled = isEnabled;
            if (e.Button == MouseButtons.Right)
                ButtonItem1.Popup(Cursor.Position);
        }

        private void ButtonItem2_Click(object sender, EventArgs e)
        {
            activeTextBox.Copy();
        }

        private void ButtonItem5_Click(object sender, EventArgs e)
        {
            activeTextBox.Cut();
        }

        private void ButtonItem3_Click(object sender, EventArgs e)
        {
            activeTextBox.Paste(Clipboard.GetText());
        }

        private void ButtonItem5_Click_1(object sender, EventArgs e)
        {
            string str = activeTextBox.SelectedText;
            if (!string.IsNullOrEmpty(str))
            {
                activeTextBox.Text = activeTextBox.Text.Replace(str, string.Empty);
            }
        }

        private void ButtonItem4_Click(object sender, EventArgs e)
        {
            activeTextBox.SelectAll();
        }
    }
}