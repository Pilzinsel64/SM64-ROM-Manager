using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class StarPositionEditor : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(StarPositionEditor));
            _Panel1 = new Panel();
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_z = new DevComponents.Editors.IntegerInput();
            _IntegerInput_Y = new DevComponents.Editors.IntegerInput();
            _IntegerInput_X = new DevComponents.Editors.IntegerInput();
            _ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx1.SelectedIndexChanged += new EventHandler(ComboBoxEx1_SelectedIndexChanged);
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_z).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_X).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_LabelX5);
            _Panel1.Controls.Add(_LabelX4);
            _Panel1.Controls.Add(_LabelX3);
            _Panel1.Controls.Add(_ButtonX1);
            _Panel1.Controls.Add(_LabelX2);
            _Panel1.Controls.Add(_IntegerInput_z);
            _Panel1.Controls.Add(_IntegerInput_Y);
            _Panel1.Controls.Add(_IntegerInput_X);
            _Panel1.Controls.Add(_ComboBoxEx1);
            _Panel1.Controls.Add(_LabelX1);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // LabelX5
            // 
            // 
            // 
            // 
            _LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX5, "LabelX5");
            _LabelX5.Name = "LabelX5";
            // 
            // LabelX4
            // 
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX4, "LabelX4");
            _LabelX4.Name = "LabelX4";
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX3, "LabelX3");
            _LabelX3.Name = "LabelX3";
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.FocusCuesEnabled = false;
            _ButtonX1.Image = My.Resources.MyIcons.icons8_save_16px;
            resources.ApplyResources(_ButtonX1, "ButtonX1");
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX1.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX1.SymbolSize = 12.0F;
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
            // IntegerInput_z
            // 
            // 
            // 
            // 
            _IntegerInput_z.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_z.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_z.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(_IntegerInput_z, "IntegerInput_z");
            _IntegerInput_z.MaxValue = 32767;
            _IntegerInput_z.MinValue = -32768;
            _IntegerInput_z.Name = "IntegerInput_z";
            _IntegerInput_z.ShowUpDown = true;
            // 
            // IntegerInput_Y
            // 
            // 
            // 
            // 
            _IntegerInput_Y.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_Y.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_Y.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(_IntegerInput_Y, "IntegerInput_Y");
            _IntegerInput_Y.MaxValue = 32767;
            _IntegerInput_Y.MinValue = -32768;
            _IntegerInput_Y.Name = "IntegerInput_Y";
            _IntegerInput_Y.ShowUpDown = true;
            // 
            // IntegerInput_X
            // 
            // 
            // 
            // 
            _IntegerInput_X.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_X.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_X.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(_IntegerInput_X, "IntegerInput_X");
            _IntegerInput_X.MaxValue = 32767;
            _IntegerInput_X.MinValue = -32768;
            _IntegerInput_X.Name = "IntegerInput_X";
            _IntegerInput_X.ShowUpDown = true;
            // 
            // ComboBoxEx1
            // 
            _ComboBoxEx1.DisplayMember = "Text";
            _ComboBoxEx1.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx1.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx1.ForeColor = Color.Black;
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
            // StarPositionEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StarPositionEditor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_z).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_X).EndInit();
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

        private DevComponents.Editors.IntegerInput _IntegerInput_z;

        internal DevComponents.Editors.IntegerInput IntegerInput_z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_z != null)
                {
                }

                _IntegerInput_z = value;
                if (_IntegerInput_z != null)
                {
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_Y;

        internal DevComponents.Editors.IntegerInput IntegerInput_Y
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_Y;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_Y != null)
                {
                }

                _IntegerInput_Y = value;
                if (_IntegerInput_Y != null)
                {
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_X;

        internal DevComponents.Editors.IntegerInput IntegerInput_X
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_X;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_X != null)
                {
                }

                _IntegerInput_X = value;
                if (_IntegerInput_X != null)
                {
                }
            }
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
                if (_ComboBoxEx1 != null)
                {
                    _ComboBoxEx1.SelectedIndexChanged -= ComboBoxEx1_SelectedIndexChanged;
                }

                _ComboBoxEx1 = value;
                if (_ComboBoxEx1 != null)
                {
                    _ComboBoxEx1.SelectedIndexChanged += ComboBoxEx1_SelectedIndexChanged;
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

        private DevComponents.DotNetBar.LabelX _LabelX5;

        internal DevComponents.DotNetBar.LabelX LabelX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX5 != null)
                {
                }

                _LabelX5 = value;
                if (_LabelX5 != null)
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
                }

                _LabelX4 = value;
                if (_LabelX4 != null)
                {
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
                }

                _LabelX3 = value;
                if (_LabelX3 != null)
                {
                }
            }
        }
    }
}