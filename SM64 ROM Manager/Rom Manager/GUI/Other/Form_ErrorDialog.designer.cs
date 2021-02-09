using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Form_ErrorDialog : DevComponents.DotNetBar.OfficeForm
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ErrorDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonX_CloseProgram = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_IgnoreErrorMessage = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_UploadErrorDiagnostic = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_ExportErrorDiagnostic = new DevComponents.DotNetBar.ButtonX();
            this.labelX_FeatureDescription = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ButtonX_CloseProgram);
            this.panel1.Controls.Add(this.ButtonX_IgnoreErrorMessage);
            this.panel1.Controls.Add(this.ButtonX_UploadErrorDiagnostic);
            this.panel1.Controls.Add(this.ButtonX_ExportErrorDiagnostic);
            this.panel1.Controls.Add(this.labelX_FeatureDescription);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Name = "panel1";
            // 
            // ButtonX_CloseProgram
            // 
            this.ButtonX_CloseProgram.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_CloseProgram.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_CloseProgram.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_close_window_32px;
            this.ButtonX_CloseProgram.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            resources.ApplyResources(this.ButtonX_CloseProgram, "ButtonX_CloseProgram");
            this.ButtonX_CloseProgram.Name = "ButtonX_CloseProgram";
            this.ButtonX_CloseProgram.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_CloseProgram.Click += new System.EventHandler(this.ButtonX_CloseProgram_Click);
            this.ButtonX_CloseProgram.MouseEnter += new System.EventHandler(this.ButtonX_CloseProgram_MouseEnter);
            this.ButtonX_CloseProgram.MouseLeave += new System.EventHandler(this.ButtonX_ExportErrorDiagnostic_MouseLeave);
            // 
            // ButtonX_IgnoreErrorMessage
            // 
            this.ButtonX_IgnoreErrorMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_IgnoreErrorMessage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_IgnoreErrorMessage.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_ostrich_head_in_sand_32px;
            this.ButtonX_IgnoreErrorMessage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            resources.ApplyResources(this.ButtonX_IgnoreErrorMessage, "ButtonX_IgnoreErrorMessage");
            this.ButtonX_IgnoreErrorMessage.Name = "ButtonX_IgnoreErrorMessage";
            this.ButtonX_IgnoreErrorMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_IgnoreErrorMessage.Click += new System.EventHandler(this.ButtonX_IgnoreErrorMessage_Click);
            this.ButtonX_IgnoreErrorMessage.MouseEnter += new System.EventHandler(this.ButtonX_IgnoreErrorMessage_MouseEnter);
            this.ButtonX_IgnoreErrorMessage.MouseLeave += new System.EventHandler(this.ButtonX_ExportErrorDiagnostic_MouseLeave);
            // 
            // ButtonX_UploadErrorDiagnostic
            // 
            this.ButtonX_UploadErrorDiagnostic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_UploadErrorDiagnostic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_UploadErrorDiagnostic.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_upload_32px;
            this.ButtonX_UploadErrorDiagnostic.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            resources.ApplyResources(this.ButtonX_UploadErrorDiagnostic, "ButtonX_UploadErrorDiagnostic");
            this.ButtonX_UploadErrorDiagnostic.Name = "ButtonX_UploadErrorDiagnostic";
            this.ButtonX_UploadErrorDiagnostic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_UploadErrorDiagnostic.Click += new System.EventHandler(this.ButtonX_UploadErrorDiagnostic_Click);
            this.ButtonX_UploadErrorDiagnostic.MouseEnter += new System.EventHandler(this.ButtonX_UploadErrorDiagnostic_MouseEnter);
            this.ButtonX_UploadErrorDiagnostic.MouseLeave += new System.EventHandler(this.ButtonX_ExportErrorDiagnostic_MouseLeave);
            // 
            // ButtonX_ExportErrorDiagnostic
            // 
            this.ButtonX_ExportErrorDiagnostic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_ExportErrorDiagnostic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_ExportErrorDiagnostic.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_export_32px;
            this.ButtonX_ExportErrorDiagnostic.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            resources.ApplyResources(this.ButtonX_ExportErrorDiagnostic, "ButtonX_ExportErrorDiagnostic");
            this.ButtonX_ExportErrorDiagnostic.Name = "ButtonX_ExportErrorDiagnostic";
            this.ButtonX_ExportErrorDiagnostic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_ExportErrorDiagnostic.Click += new System.EventHandler(this.ButtonX_ExportErrorDiagnostic_Click);
            this.ButtonX_ExportErrorDiagnostic.MouseEnter += new System.EventHandler(this.ButtonX_ExportErrorDiagnostic_MouseEnter);
            this.ButtonX_ExportErrorDiagnostic.MouseLeave += new System.EventHandler(this.ButtonX_ExportErrorDiagnostic_MouseLeave);
            // 
            // labelX_FeatureDescription
            // 
            // 
            // 
            // 
            this.labelX_FeatureDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_FeatureDescription.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.labelX_FeatureDescription, "labelX_FeatureDescription");
            this.labelX_FeatureDescription.Name = "labelX_FeatureDescription";
            this.labelX_FeatureDescription.WordWrap = true;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.Name = "labelX2";
            this.labelX2.WordWrap = true;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            // 
            // Form_ErrorDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ErrorDialog";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX_FeatureDescription;
        private DevComponents.DotNetBar.ButtonX ButtonX_CloseProgram;
        private DevComponents.DotNetBar.ButtonX ButtonX_IgnoreErrorMessage;
        private DevComponents.DotNetBar.ButtonX ButtonX_UploadErrorDiagnostic;
        private DevComponents.DotNetBar.ButtonX ButtonX_ExportErrorDiagnostic;
    }
}