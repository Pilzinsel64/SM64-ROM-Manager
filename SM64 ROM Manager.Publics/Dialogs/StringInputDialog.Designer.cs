using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SM64_ROM_Manager.Publics
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class StringInputDialog : DevComponents.DotNetBar.OfficeForm
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
            components = new System.ComponentModel.Container();
            _TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _Panel1 = new System.Windows.Forms.Panel();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxX1
            // 
            _TextBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX1.Border.Class = "TextBoxBorder";
            _TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX1.ForeColor = System.Drawing.Color.Black;
            _TextBoxX1.Location = new System.Drawing.Point(3, 3);
            _TextBoxX1.Name = "TextBoxX1";
            _TextBoxX1.PreventEnterBeep = true;
            _TextBoxX1.Size = new System.Drawing.Size(278, 20);
            _TextBoxX1.TabIndex = 0;
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.FocusCuesEnabled = false;
            _ButtonX1.Location = new System.Drawing.Point(206, 29);
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Size = new System.Drawing.Size(75, 23);
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX1.TabIndex = 1;
            _ButtonX1.Text = "Okay";
            // 
            // ButtonX2
            // 
            _ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            _ButtonX2.FocusCuesEnabled = false;
            _ButtonX2.Location = new System.Drawing.Point(125, 29);
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Size = new System.Drawing.Size(75, 23);
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX2.TabIndex = 2;
            _ButtonX2.Text = "Cancel";
            // 
            // Panel1
            // 
            _Panel1.Controls.Add(_TextBoxX1);
            _Panel1.Controls.Add(_ButtonX2);
            _Panel1.Controls.Add(_ButtonX1);
            _Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            _Panel1.Location = new System.Drawing.Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new System.Drawing.Size(284, 55);
            _Panel1.TabIndex = 3;
            // 
            // StringInputDialog
            // 
            AcceptButton = _ButtonX1;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            CancelButton = _ButtonX2;
            ClientSize = new System.Drawing.Size(284, 55);
            Controls.Add(_Panel1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "StringInputDialog";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX1;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX1 != null)
                {
                }

                _TextBoxX1 = value;
                if (_TextBoxX1 != null)
                {
                }
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
                if (_ButtonX1 != null)
                {
                    _ButtonX1.Click -= ButtonX1_Click;
                }

                _ButtonX1 = value;
                if (_ButtonX1 != null)
                {
                    _ButtonX1.Click += ButtonX1_Click;
                }
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
                if (_ButtonX2 != null)
                {
                }

                _ButtonX2 = value;
                if (_ButtonX2 != null)
                {
                }
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
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
            }
        }
    }
}