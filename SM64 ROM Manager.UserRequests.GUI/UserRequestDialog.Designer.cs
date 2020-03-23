using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.UserRequests.GUI
{
    [DesignerGenerated()]
    public partial class UserRequestDialog : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRequestDialog));
            _LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _SuperValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            _ErrorProvider1 = new ErrorProvider(components);
            _Highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)_ErrorProvider1).BeginInit();
            SuspendLayout();
            // 
            // LayoutControl1
            // 
            _LayoutControl1.BackColor = Color.Transparent;
            _LayoutControl1.Dock = DockStyle.Fill;
            _LayoutControl1.Location = new Point(0, 0);
            _LayoutControl1.Name = "LayoutControl1";
            _LayoutControl1.Size = new Size(439, 536);
            _LayoutControl1.TabIndex = 0;
            // 
            // SuperValidator1
            // 
            _SuperValidator1.ContainerControl = _LayoutControl1;
            _SuperValidator1.ErrorProvider = _ErrorProvider1;
            _SuperValidator1.Highlighter = _Highlighter1;
            _SuperValidator1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // ErrorProvider1
            // 
            _ErrorProvider1.ContainerControl = this;
            _ErrorProvider1.Icon = (Icon)resources.GetObject("ErrorProvider1.Icon");
            // 
            // Highlighter1
            // 
            _Highlighter1.ContainerControl = this;
            _Highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // UserRequestDialog
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 536);
            Controls.Add(_LayoutControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserRequestDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Request";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_ErrorProvider1).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Layout.LayoutControl _LayoutControl1;

        internal DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControl1 = value;
            }
        }

        private DevComponents.DotNetBar.Validator.SuperValidator _SuperValidator1;

        internal DevComponents.DotNetBar.Validator.SuperValidator SuperValidator1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperValidator1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _SuperValidator1 = value;
            }
        }

        private ErrorProvider _ErrorProvider1;

        internal ErrorProvider ErrorProvider1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ErrorProvider1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ErrorProvider1 = value;
            }
        }

        private DevComponents.DotNetBar.Validator.Highlighter _Highlighter1;

        internal DevComponents.DotNetBar.Validator.Highlighter Highlighter1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Highlighter1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Highlighter1 = value;
            }
        }
    }
}