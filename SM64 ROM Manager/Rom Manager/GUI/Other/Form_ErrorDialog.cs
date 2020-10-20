using System;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class Form_ErrorDialog
    {
        private void ButtonX1_Click(object sender, EventArgs e)
        {
            ExitApplicaiton = true;
        }

        public bool ExitApplicaiton { get; private set; } = false;

        public string ErrorText
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

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBoxX1.Text);
        }

        public Form_ErrorDialog()
        {
            InitializeComponent();
            base.UpdateAmbientColors();
        }
    }
}