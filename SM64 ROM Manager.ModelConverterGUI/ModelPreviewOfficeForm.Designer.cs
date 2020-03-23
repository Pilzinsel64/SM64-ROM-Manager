using System.Diagnostics;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ModelPreviewOfficeForm : DevComponents.DotNetBar.OfficeForm
    {

        // Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SuspendLayout();
            // 
            // ModelPreviewOfficeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Name = "ModelPreviewOfficeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Model Preview";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ResumeLayout(false);
        }
    }
}