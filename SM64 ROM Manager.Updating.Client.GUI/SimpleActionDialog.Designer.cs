using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager.Updating.Client.GUI
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SimpleActionDialog : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleActionDialog));
            _Panel1 = new Panel();
            _LabelX_Progress = new DevComponents.DotNetBar.LabelX();
            _ProgressBarX_Progress = new DevComponents.DotNetBar.Controls.ProgressBarX();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_LabelX_Progress);
            _Panel1.Controls.Add(_ProgressBarX_Progress);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // LabelX_Progress
            // 
            resources.ApplyResources(_LabelX_Progress, "LabelX_Progress");
            // 
            // 
            // 
            _LabelX_Progress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Progress.Name = "LabelX_Progress";
            // 
            // ProgressBarX_Progress
            // 
            resources.ApplyResources(_ProgressBarX_Progress, "ProgressBarX_Progress");
            // 
            // 
            // 
            _ProgressBarX_Progress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ProgressBarX_Progress.Name = "ProgressBarX_Progress";
            // 
            // SimpleActionDialog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SimpleActionDialog";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel _Panel1;

        internal Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Panel1 = value;
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Progress;

        internal DevComponents.DotNetBar.LabelX LabelX_Progress
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Progress;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_Progress = value;
            }
        }

        private DevComponents.DotNetBar.Controls.ProgressBarX _ProgressBarX_Progress;

        internal DevComponents.DotNetBar.Controls.ProgressBarX ProgressBarX_Progress
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ProgressBarX_Progress;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ProgressBarX_Progress = value;
            }
        }
    }
}