using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SM64_ROM_Manager.Publics
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class FilesFilterDialog : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesFilterDialog));
            _ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _Panel1 = new System.Windows.Forms.Panel();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxEx1
            // 
            _ComboBoxEx1.DisplayMember = "Text";
            _ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            _ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _ComboBoxEx1.FormattingEnabled = true;
            resources.ApplyResources(_ComboBoxEx1, "ComboBoxEx1");
            _ComboBoxEx1.Name = "ComboBoxEx1";
            _ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX1, "LabelX1");
            _LabelX1.Name = "LabelX1";
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.DialogResult = System.Windows.Forms.DialogResult.OK;
            _ButtonX1.FocusCuesEnabled = false;
            resources.ApplyResources(_ButtonX1, "ButtonX1");
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX2
            // 
            _ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            _ButtonX2.FocusCuesEnabled = false;
            resources.ApplyResources(_ButtonX2, "ButtonX2");
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            _Panel1.BackColor = System.Drawing.Color.Transparent;
            _Panel1.Controls.Add(_LabelX1);
            _Panel1.Controls.Add(_ButtonX2);
            _Panel1.Controls.Add(_ComboBoxEx1);
            _Panel1.Controls.Add(_ButtonX1);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // FilesFilterDialog
            // 
            AcceptButton = _ButtonX1;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = _ButtonX2;
            Controls.Add(_Panel1);
            DoubleBuffered = true;
            EnableGlass = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FilesFilterDialog";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx1;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ComboBoxEx1 = value;
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX1;

        internal DevComponents.DotNetBar.LabelX LabelX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX1 = value;
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX1;

        internal DevComponents.DotNetBar.ButtonX ButtonX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ButtonX1 = value;
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX2;

        internal DevComponents.DotNetBar.ButtonX ButtonX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ButtonX2 = value;
            }
        }

        private System.Windows.Forms.Panel _Panel1;

        internal System.Windows.Forms.Panel Panel1
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
    }
}