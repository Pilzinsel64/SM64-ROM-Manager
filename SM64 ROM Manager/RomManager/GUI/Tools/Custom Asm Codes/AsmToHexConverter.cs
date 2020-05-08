using DevComponents.DotNetBar;
using SM64Lib.Patching;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class AsmToHexConverter : OfficeForm
    {
        public AsmToHexConverter()
        {
            InitializeComponent();
            UpdateAmbientColors();
        }

        private void ButtonX_CopyHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxX_Hex.Text);
        }

        private void ButtonX_Convert_Click(object sender, EventArgs e)
        {
            byte[] bytes;
            var sb = new StringBuilder();

            ProgBar.Visible = true;
            ButtonX_Convert.Enabled = false;

            try
            {
                var code = ".org 0x0\n";
                code += fastColoredTextBox_Code.Text;
                bytes = PatchingManager.ConvertAsmToBytes(code);
            }
            catch (Exception)
            {
                bytes = null;
            }

            if (bytes is object)
            {
                foreach (var b in bytes)
                {
                    if (sb.Length != 0)
                        sb.Append(" ");
                    sb.Append(b.ToString("X2"));
                }
            }

            textBoxX_Hex.Text = sb.ToString();

            ProgBar.Visible = false;
            ButtonX_Convert.Enabled = true;
        }

        private void FastColoredTextBox_Code_DragEnter(object sender, DragEventArgs e)
        {
            var isValid = false;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Any())
                {
                    var file1 = files[0];
                    if (new string[] { ".txt", ".asm" }.Contains(Path.GetExtension(file1)))
                        isValid = true;
                }
            }

            e.Effect = isValid ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void FastColoredTextBox_Code_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Any())
                fastColoredTextBox_Code.Text = File.ReadAllText(files[0]);
        }
    }
}
