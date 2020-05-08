using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace SM64_ROM_Manager.PatchScripts
{
    public partial class TweakProfileEditor
    {
        public TweakProfileEditor()
        {

            // Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent();

            // Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            base.UpdateAmbientColors();

            customValidator1.ValidateValue += CustomValidator1_ValidateValue;
            customValidator2.ValidateValue += CustomValidator2_ValidateValue;
        }

        private void CustomValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            e.IsValid = IsVersionValid(e.ControlToValidate.Text);
        }

        private void CustomValidator2_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            e.IsValid = IsVersionValid(e.ControlToValidate.Text) || string.IsNullOrEmpty(e.ControlToValidate.Text);
        }

        private bool IsVersionValid(string text)
        {
            return LikeOperator.LikeString(text, "#*.#*.#*.#*", CompareMethod.Text);
        }

        public string Titel
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

        public string Description
        {
            get
            {
                return TextBoxX2.Text;
            }

            set
            {
                TextBoxX2.Text = value;
            }
        }

        public Version Version
        {
            get
            {
                Version.TryParse(textBoxX3.Text, out Version ver);
                return ver;
            }
            set
            {
                if (value is object)
                    textBoxX3.Text = value.ToString();
            }
        }

        public Version MinAppVersion
        {
            get
            {
                Version.TryParse(textBoxX4.Text, out Version ver);
                return ver;
            }
            set
            {
                if (value is object)
                    textBoxX4.Text = value.ToString();
            }
        }

        public Version MaxAppVersion
        {
            get
            {
                if (!Version.TryParse(textBoxX5.Text, out Version ver))
                    ver = new Version("0.0.0.0");
                return ver;
            }
            set
            {
                if (value is object && value != new Version("0.0.0.0"))
                    textBoxX5.Text = value.ToString();
            }
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            if (superValidator1.Validate())
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}