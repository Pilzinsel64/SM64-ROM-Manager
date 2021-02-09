using DevComponents.DotNetBar;
using SM64_ROM_Manager.My.Resources;
using System;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class Form_ErrorDialog
    {
        public bool ExitApplicaiton { get; private set; } = false;
        public Exception CurrentException { get; set; }

        public Form_ErrorDialog()
        {
            InitializeComponent();
            SetFeatureDescription(ErrorDialogLangRes.FeatureDescription_NoDescription);
            ButtonX_IgnoreErrorMessage.Enabled = IsMainFormStillOpen();
            UpdateAmbientColors();
        }

        private static bool IsMainFormStillOpen()
        {
            var val = false;

            foreach (var form in Application.OpenForms)
            {
                if (!val && form is MainForm)
                    val = true;
            }

            return val;
        }

        private void CloseWindow(bool exitApplication)
        {
            ExitApplicaiton = exitApplication;
            Close();
        }

        private void SetFeatureDescription(string text)
        {
            labelX_FeatureDescription.Text = string.Format(ErrorDialogLangRes.FeatureDescription_BaseText, text);
        }

        private void ButtonX_ExportErrorDiagnostic_Click(object sender, EventArgs e)
        {
            General.ExportDiagnosticsProtocol(this, CurrentException);
        }

        private void ButtonX_UploadErrorDiagnostic_Click(object sender, EventArgs e)
        {
            General.UploadDiagnosticsProtocol(this, CurrentException);
        }

        private void ButtonX_IgnoreErrorMessage_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show(this, ErrorDialogLangRes.MsgBox_SureToIgnore, ErrorDialogLangRes.MsgBox_SureToIgnore_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                CloseWindow(false);
        }

        private void ButtonX_CloseProgram_Click(object sender, EventArgs e)
        {
            CloseWindow(true);
        }

        private void ButtonX_ExportErrorDiagnostic_MouseLeave(object sender, EventArgs e)
        {
            SetFeatureDescription(ErrorDialogLangRes.FeatureDescription_NoDescription);
        }

        private void ButtonX_ExportErrorDiagnostic_MouseEnter(object sender, EventArgs e)
        {
            SetFeatureDescription(ErrorDialogLangRes.FeatureDescription_ExportErrorDiagnostic);
        }

        private void ButtonX_UploadErrorDiagnostic_MouseEnter(object sender, EventArgs e)
        {
            SetFeatureDescription(ErrorDialogLangRes.FeatureDescription_UploadErrorDiagnostic);
        }

        private void ButtonX_IgnoreErrorMessage_MouseEnter(object sender, EventArgs e)
        {
            SetFeatureDescription(ErrorDialogLangRes.FeatureDescription_IgnoreErrorMessage);
        }

        private void ButtonX_CloseProgram_MouseEnter(object sender, EventArgs e)
        {
            SetFeatureDescription(ErrorDialogLangRes.FeatureDescription_CloseProgram);
        }
    }
}