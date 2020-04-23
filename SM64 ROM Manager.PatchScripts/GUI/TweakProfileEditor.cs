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
        }

        private void CustomValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            e.IsValid = LikeOperator.LikeString(e.ControlToValidate.Text, "#*.#*.#*.#*", CompareMethod.Text);
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

        private void ButtonX2_Click(object sender, System.EventArgs e)
        {
            if (superValidator1.Validate())
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}