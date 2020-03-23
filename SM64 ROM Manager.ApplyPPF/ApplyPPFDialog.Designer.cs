using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ApplyPPF
{
    [DesignerGenerated()]
    public partial class ApplyPPFDialog : DevComponents.DotNetBar.OfficeForm
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
        private System.ComponentModel.IContainer components = null;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyPPFDialog));
            _Panel1 = new Panel();
            _CheckBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _LabelX4.TextChanged += new EventHandler(TextBoxX1_TextChanged);
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _LabelX3.TextChanged += new EventHandler(TextBoxX1_TextChanged);
            _CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            _ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX3.Click += new EventHandler(ButtonX3_Click);
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX2.Click += new EventHandler(ButtonX2_Click);
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.Controls.Add(_CheckBoxX1);
            _Panel1.Controls.Add(_LabelX4);
            _Panel1.Controls.Add(_LabelX3);
            _Panel1.Controls.Add(_CircularProgress1);
            _Panel1.Controls.Add(_ButtonX3);
            _Panel1.Controls.Add(_ButtonX2);
            _Panel1.Controls.Add(_ButtonX1);
            _Panel1.Controls.Add(_LabelX2);
            _Panel1.Controls.Add(_LabelX1);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // CheckBoxX1
            // 
            resources.ApplyResources(_CheckBoxX1, "CheckBoxX1");
            // 
            // 
            // 
            _CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX1.FocusCuesEnabled = false;
            _CheckBoxX1.Name = "CheckBoxX1";
            _CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX4
            // 
            resources.ApplyResources(_LabelX4, "LabelX4");
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX4.Name = "LabelX4";
            // 
            // LabelX3
            // 
            resources.ApplyResources(_LabelX3, "LabelX3");
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX3.Name = "LabelX3";
            // 
            // CircularProgress1
            // 
            resources.ApplyResources(_CircularProgress1, "CircularProgress1");
            // 
            // 
            // 
            _CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CircularProgress1.FocusCuesEnabled = false;
            _CircularProgress1.Name = "CircularProgress1";
            _CircularProgress1.ProgressColor = Color.Empty;
            _CircularProgress1.SetVisibleStateOnStart = true;
            _CircularProgress1.SetVisibleStateOnStop = true;
            _CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // ButtonX3
            // 
            _ButtonX3.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX3, "ButtonX3");
            _ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX3.FocusCuesEnabled = false;
            _ButtonX3.Image = My.Resources.Resources.icons8_folder_16px;
            _ButtonX3.Name = "ButtonX3";
            _ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX3.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX3.SymbolSize = 12.0F;
            // 
            // ButtonX2
            // 
            _ButtonX2.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX2, "ButtonX2");
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX2.FocusCuesEnabled = false;
            _ButtonX2.Image = My.Resources.Resources.icons8_folder_16px;
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX2.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX2.SymbolSize = 12.0F;
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX1, "ButtonX1");
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.FocusCuesEnabled = false;
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX2, "LabelX2");
            _LabelX2.Name = "LabelX2";
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
            // ApplyPPFDialog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel1);
            MaximizeBox = false;
            Name = "ApplyPPFDialog";
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
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
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
                if (_LabelX1 != null)
                {
                }

                _LabelX1 = value;
                if (_LabelX1 != null)
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

        private DevComponents.DotNetBar.LabelX _LabelX2;

        internal DevComponents.DotNetBar.LabelX LabelX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX2 != null)
                {
                }

                _LabelX2 = value;
                if (_LabelX2 != null)
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
                    _ButtonX2.Click -= ButtonX2_Click;
                }

                _ButtonX2 = value;
                if (_ButtonX2 != null)
                {
                    _ButtonX2.Click += ButtonX2_Click;
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

        private DevComponents.DotNetBar.Controls.CircularProgress _CircularProgress1;

        internal DevComponents.DotNetBar.Controls.CircularProgress CircularProgress1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CircularProgress1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CircularProgress1 != null)
                {
                }

                _CircularProgress1 = value;
                if (_CircularProgress1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX1;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX1 != null)
                {
                }

                _CheckBoxX1 = value;
                if (_CheckBoxX1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX4;

        internal DevComponents.DotNetBar.LabelX LabelX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX4 != null)
                {
                    _LabelX4.TextChanged -= TextBoxX1_TextChanged;
                }

                _LabelX4 = value;
                if (_LabelX4 != null)
                {
                    _LabelX4.TextChanged += TextBoxX1_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX3;

        internal DevComponents.DotNetBar.LabelX LabelX3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX3 != null)
                {
                    _LabelX3.TextChanged -= TextBoxX1_TextChanged;
                }

                _LabelX3 = value;
                if (_LabelX3 != null)
                {
                    _LabelX3.TextChanged += TextBoxX1_TextChanged;
                }
            }
        }
    }
}