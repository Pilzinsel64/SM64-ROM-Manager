using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::HexEdit;

namespace SM64_ROM_Manager
{
    public partial class HexEditor
    {
        public HexEditor(byte[] buffer)
        {
            Shown += HexEditor_Shown;
            InitializeComponent();

            hexEditor = new HexEditBox();
            hexEditor.InitializeComponent();
            hexEditor.Dock = DockStyle.Fill;
            hexEditor.Font = new Font(hexEditor.Font.FontFamily, 12.0F);
            Controls.Add(hexEditor);

            input = buffer;
        }

        private byte[] input;
        private HexEditBox hexEditor;

        private void HexEditor_Shown(object sender, EventArgs e)
        {
            hexEditor.LoadData(input);
        }

        public byte[] GetData()
        {
            return hexEditor.ArrayData;
        }
    }
}