using System;
using global::System.Windows.Forms;
using global::DevComponents.DotNetBar;

namespace SM64_ROM_Manager.Publics
{
    public partial class StringInputDialog
    {
        public StringInputDialog()
        {
            InitializeComponent();
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxX1.Text.Trim()))
            {
                MessageBoxEx.Show("The input is empty! Please enter a text first.", "Empty input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        public string Value
        {
            get
            {
                return TextBoxX1.Text;
            }

            set
            {
                TextBoxX1.Text = value;
            }
        }

        public string Titel
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
            }
        }
    }
}