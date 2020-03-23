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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ErrorDialog));
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _Panel1 = new Panel();
            _ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX3.Click += new EventHandler(ButtonX3_Click);
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _Panel1.SuspendLayout();
            SuspendLayout();
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
            // TextBoxX1
            // 
            _TextBoxX1.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX1.Border.Class = "TextBoxBorder";
            _TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX1.DisabledBackColor = Color.White;
            _TextBoxX1.ForeColor = Color.Black;
            resources.ApplyResources(_TextBoxX1, "TextBoxX1");
            _TextBoxX1.Name = "TextBoxX1";
            _TextBoxX1.PreventEnterBeep = true;
            _TextBoxX1.ReadOnly = true;
            // 
            // ButtonX2
            // 
            _ButtonX2.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX2.DialogResult = DialogResult.OK;
            _ButtonX2.FocusCuesEnabled = false;
            _ButtonX2.Image = My.Resources.MyIcons.icons8_forward_16px;
            resources.ApplyResources(_ButtonX2, "ButtonX2");
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_LabelX1);
            _Panel1.Controls.Add(_ButtonX3);
            _Panel1.Controls.Add(_TextBoxX1);
            _Panel1.Controls.Add(_ButtonX2);
            _Panel1.Controls.Add(_ButtonX1);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // ButtonX3
            // 
            _ButtonX3.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX3.FocusCuesEnabled = false;
            _ButtonX3.Image = My.Resources.MyIcons.icons8_copy_16px;
            resources.ApplyResources(_ButtonX3, "ButtonX3");
            _ButtonX3.Name = "ButtonX3";
            _ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX3.SymbolSize = 12.0F;
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX1.BackColor = Color.White;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.DialogResult = DialogResult.Cancel;
            _ButtonX1.FocusCuesEnabled = false;
            _ButtonX1.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            resources.ApplyResources(_ButtonX1, "ButtonX1");
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX1.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX1.SymbolSize = 12.0F;
            // 
            // Form_ErrorDialog
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            ControlBox = false;
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_ErrorDialog";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
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
                if (_LabelX1 != null)
                {
                }

                _LabelX1 = value;
                if (_LabelX1 != null)
                {
                }
            }
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

        private DevComponents.DotNetBar.ButtonX _ButtonX3;

        internal DevComponents.DotNetBar.ButtonX ButtonX3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX3 != null)
                {
                    _ButtonX3.Click -= ButtonX3_Click;
                }

                _ButtonX3 = value;
                if (_ButtonX3 != null)
                {
                    _ButtonX3.Click += ButtonX3_Click;
                }
            }
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