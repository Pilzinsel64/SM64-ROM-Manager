using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class TrajectoryEditor : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TrajectoryEditor));
            _ListViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            _ListViewEx1.SelectedIndexChanged += new EventHandler(ListViewEx1_SelectedIndexChanged);
            _ColumnHeader1 = new ColumnHeader();
            _ColumnHeader2 = new ColumnHeader();
            _ColumnHeader3 = new ColumnHeader();
            _ColumnHeader4 = new ColumnHeader();
            _ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx1.SelectedIndexChanged += new EventHandler(ComboBoxEx1_SelectedIndexChanged);
            _IntegerInput1 = new DevComponents.Editors.IntegerInput();
            _IntegerInput1.ValueChanged += new EventHandler(IntegerInput1_ValueChanged);
            _IntegerInput2 = new DevComponents.Editors.IntegerInput();
            _IntegerInput2.ValueChanged += new EventHandler(IntegerInput1_ValueChanged);
            _IntegerInput3 = new DevComponents.Editors.IntegerInput();
            _IntegerInput3.ValueChanged += new EventHandler(IntegerInput1_ValueChanged);
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX2.Click += new EventHandler(ButtonX2_Click);
            _ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX3.Click += new EventHandler(ButtonX3_Click);
            _ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX4.Click += new EventHandler(ButtonX4_Click);
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _LabelX6 = new DevComponents.DotNetBar.LabelX();
            _LabelX7 = new DevComponents.DotNetBar.LabelX();
            _ButtonX5 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX5.Click += new EventHandler(ButtonX5_Click);
            _ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX6.Click += new EventHandler(ButtonX6_Click);
            _ButtonX7 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX7.Click += new EventHandler(ButtonX7_Click);
            _ButtonX8 = new DevComponents.DotNetBar.ButtonX();
            _Panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput3).BeginInit();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewEx1
            // 
            resources.ApplyResources(_ListViewEx1, "ListViewEx1");
            _ListViewEx1.BackColor = Color.White;
            // 
            // 
            // 
            _ListViewEx1.Border.Class = "ListViewBorder";
            _ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx1.Columns.AddRange(new ColumnHeader[] { _ColumnHeader1, _ColumnHeader2, _ColumnHeader3, _ColumnHeader4 });
            _ListViewEx1.DisabledBackColor = Color.Empty;
            _ListViewEx1.FocusCuesEnabled = false;
            _ListViewEx1.ForeColor = Color.Black;
            _ListViewEx1.FullRowSelect = true;
            _ListViewEx1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _ListViewEx1.HideSelection = false;
            _ListViewEx1.MultiSelect = false;
            _ListViewEx1.Name = "ListViewEx1";
            _ListViewEx1.UseCompatibleStateImageBehavior = false;
            _ListViewEx1.View = View.Details;
            // 
            // ColumnHeader1
            // 
            resources.ApplyResources(_ColumnHeader1, "ColumnHeader1");
            // 
            // ColumnHeader2
            // 
            resources.ApplyResources(_ColumnHeader2, "ColumnHeader2");
            // 
            // ColumnHeader3
            // 
            resources.ApplyResources(_ColumnHeader3, "ColumnHeader3");
            // 
            // ColumnHeader4
            // 
            resources.ApplyResources(_ColumnHeader4, "ColumnHeader4");
            // 
            // ComboBoxEx1
            // 
            resources.ApplyResources(_ComboBoxEx1, "ComboBoxEx1");
            _ComboBoxEx1.DisplayMember = "Text";
            _ComboBoxEx1.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx1.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx1.DropDownWidth = 250;
            _ComboBoxEx1.ForeColor = Color.Black;
            _ComboBoxEx1.FormattingEnabled = true;
            _ComboBoxEx1.Name = "ComboBoxEx1";
            _ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // IntegerInput1
            // 
            resources.ApplyResources(_IntegerInput1, "IntegerInput1");
            // 
            // 
            // 
            _IntegerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput1.MaxValue = 65535;
            _IntegerInput1.MinValue = -65535;
            _IntegerInput1.Name = "IntegerInput1";
            _IntegerInput1.ShowUpDown = true;
            // 
            // IntegerInput2
            // 
            resources.ApplyResources(_IntegerInput2, "IntegerInput2");
            // 
            // 
            // 
            _IntegerInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput2.MaxValue = 65535;
            _IntegerInput2.MinValue = -65535;
            _IntegerInput2.Name = "IntegerInput2";
            _IntegerInput2.ShowUpDown = true;
            // 
            // IntegerInput3
            // 
            resources.ApplyResources(_IntegerInput3, "IntegerInput3");
            // 
            // 
            // 
            _IntegerInput3.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput3.MaxValue = 65535;
            _IntegerInput3.MinValue = -65535;
            _IntegerInput3.Name = "IntegerInput3";
            _IntegerInput3.ShowUpDown = true;
            // 
            // LabelX2
            // 
            resources.ApplyResources(_LabelX2, "LabelX2");
            _LabelX2.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Name = "LabelX2";
            _LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX3
            // 
            resources.ApplyResources(_LabelX3, "LabelX3");
            _LabelX3.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX3.Name = "LabelX3";
            _LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX1, "ButtonX1");
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.FocusCuesEnabled = false;
            _ButtonX1.Image = My.Resources.MyIcons.icons8_add_subnode_16px;
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX1.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX1.SymbolSize = 12.0F;
            // 
            // ButtonX2
            // 
            _ButtonX2.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX2, "ButtonX2");
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX2.FocusCuesEnabled = false;
            _ButtonX2.Image = My.Resources.MyIcons.icons8_delete_subnode_16px;
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX2.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX2.SymbolSize = 12.0F;
            // 
            // ButtonX3
            // 
            _ButtonX3.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX3, "ButtonX3");
            _ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX3.FocusCuesEnabled = false;
            _ButtonX3.Image = My.Resources.MyIcons.icons8_export_16px;
            _ButtonX3.Name = "ButtonX3";
            _ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX4
            // 
            _ButtonX4.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX4, "ButtonX4");
            _ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX4.FocusCuesEnabled = false;
            _ButtonX4.Image = My.Resources.MyIcons.icons8_import_16px;
            _ButtonX4.Name = "ButtonX4";
            _ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX4
            // 
            resources.ApplyResources(_LabelX4, "LabelX4");
            _LabelX4.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX4.Name = "LabelX4";
            // 
            // LabelX5
            // 
            resources.ApplyResources(_LabelX5, "LabelX5");
            _LabelX5.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX5.Name = "LabelX5";
            // 
            // LabelX6
            // 
            resources.ApplyResources(_LabelX6, "LabelX6");
            _LabelX6.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX6.Name = "LabelX6";
            // 
            // LabelX7
            // 
            resources.ApplyResources(_LabelX7, "LabelX7");
            _LabelX7.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX7.Name = "LabelX7";
            // 
            // ButtonX5
            // 
            _ButtonX5.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX5, "ButtonX5");
            _ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX5.FocusCuesEnabled = false;
            _ButtonX5.Image = My.Resources.MyIcons.icons8_save_16px;
            _ButtonX5.Name = "ButtonX5";
            _ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX6
            // 
            _ButtonX6.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX6, "ButtonX6");
            _ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX6.FocusCuesEnabled = false;
            _ButtonX6.Image = My.Resources.MyIcons.icons8_move_node_up_16px;
            _ButtonX6.Name = "ButtonX6";
            _ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX6.SymbolSize = 12.0F;
            // 
            // ButtonX7
            // 
            _ButtonX7.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX7, "ButtonX7");
            _ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX7.FocusCuesEnabled = false;
            _ButtonX7.Image = My.Resources.MyIcons.icons8_move_node_down_16px;
            _ButtonX7.Name = "ButtonX7";
            _ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX7.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX7.SymbolSize = 12.0F;
            // 
            // ButtonX8
            // 
            _ButtonX8.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX8, "ButtonX8");
            _ButtonX8.AutoExpandOnClick = true;
            _ButtonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX8.FocusCuesEnabled = false;
            _ButtonX8.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            _ButtonX8.Name = "ButtonX8";
            _ButtonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX8.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX8.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX8.SymbolSize = 12.0F;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_ButtonX8);
            _Panel1.Controls.Add(_ListViewEx1);
            _Panel1.Controls.Add(_ButtonX6);
            _Panel1.Controls.Add(_ComboBoxEx1);
            _Panel1.Controls.Add(_ButtonX7);
            _Panel1.Controls.Add(_LabelX4);
            _Panel1.Controls.Add(_ButtonX5);
            _Panel1.Controls.Add(_ButtonX3);
            _Panel1.Controls.Add(_LabelX7);
            _Panel1.Controls.Add(_ButtonX2);
            _Panel1.Controls.Add(_IntegerInput3);
            _Panel1.Controls.Add(_IntegerInput2);
            _Panel1.Controls.Add(_LabelX5);
            _Panel1.Controls.Add(_LabelX6);
            _Panel1.Controls.Add(_LabelX3);
            _Panel1.Controls.Add(_LabelX2);
            _Panel1.Controls.Add(_ButtonX4);
            _Panel1.Controls.Add(_ButtonX1);
            _Panel1.Controls.Add(_IntegerInput1);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // TrajectoryEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TrajectoryEditor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_IntegerInput1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput3).EndInit();
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.ListViewEx _ListViewEx1;

        internal DevComponents.DotNetBar.Controls.ListViewEx ListViewEx1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewEx1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewEx1 != null)
                {
                    _ListViewEx1.SelectedIndexChanged -= ListViewEx1_SelectedIndexChanged;
                }

                _ListViewEx1 = value;
                if (_ListViewEx1 != null)
                {
                    _ListViewEx1.SelectedIndexChanged += ListViewEx1_SelectedIndexChanged;
                }
            }
        }

        private ColumnHeader _ColumnHeader1;

        internal ColumnHeader ColumnHeader1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader1 != null)
                {
                }

                _ColumnHeader1 = value;
                if (_ColumnHeader1 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader2;

        internal ColumnHeader ColumnHeader2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader2 != null)
                {
                }

                _ColumnHeader2 = value;
                if (_ColumnHeader2 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader3;

        internal ColumnHeader ColumnHeader3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader3 != null)
                {
                }

                _ColumnHeader3 = value;
                if (_ColumnHeader3 != null)
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

        private DevComponents.Editors.IntegerInput _IntegerInput1;

        internal DevComponents.Editors.IntegerInput IntegerInput1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput1 != null)
                {
                    _IntegerInput1.ValueChanged -= IntegerInput1_ValueChanged;
                }

                _IntegerInput1 = value;
                if (_IntegerInput1 != null)
                {
                    _IntegerInput1.ValueChanged += IntegerInput1_ValueChanged;
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput2;

        internal DevComponents.Editors.IntegerInput IntegerInput2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput2 != null)
                {
                    _IntegerInput2.ValueChanged -= IntegerInput1_ValueChanged;
                }

                _IntegerInput2 = value;
                if (_IntegerInput2 != null)
                {
                    _IntegerInput2.ValueChanged += IntegerInput1_ValueChanged;
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput3;

        internal DevComponents.Editors.IntegerInput IntegerInput3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput3 != null)
                {
                    _IntegerInput3.ValueChanged -= IntegerInput1_ValueChanged;
                }

                _IntegerInput3 = value;
                if (_IntegerInput3 != null)
                {
                    _IntegerInput3.ValueChanged += IntegerInput1_ValueChanged;
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

        private DevComponents.DotNetBar.ButtonX _ButtonX4;

        internal DevComponents.DotNetBar.ButtonX ButtonX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX4 != null)
                {
                    _ButtonX4.Click -= ButtonX4_Click;
                }

                _ButtonX4 = value;
                if (_ButtonX4 != null)
                {
                    _ButtonX4.Click += ButtonX4_Click;
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

        private DevComponents.DotNetBar.LabelX _LabelX6;

        internal DevComponents.DotNetBar.LabelX LabelX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX6 != null)
                {
                }

                _LabelX6 = value;
                if (_LabelX6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX7;

        internal DevComponents.DotNetBar.LabelX LabelX7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX7 != null)
                {
                }

                _LabelX7 = value;
                if (_LabelX7 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX5;

        internal DevComponents.DotNetBar.ButtonX ButtonX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX5 != null)
                {
                    _ButtonX5.Click -= ButtonX5_Click;
                }

                _ButtonX5 = value;
                if (_ButtonX5 != null)
                {
                    _ButtonX5.Click += ButtonX5_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX6;

        internal DevComponents.DotNetBar.ButtonX ButtonX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX6 != null)
                {
                    _ButtonX6.Click -= ButtonX6_Click;
                }

                _ButtonX6 = value;
                if (_ButtonX6 != null)
                {
                    _ButtonX6.Click += ButtonX6_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX7;

        internal DevComponents.DotNetBar.ButtonX ButtonX7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX7 != null)
                {
                    _ButtonX7.Click -= ButtonX7_Click;
                }

                _ButtonX7 = value;
                if (_ButtonX7 != null)
                {
                    _ButtonX7.Click += ButtonX7_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX8;

        internal DevComponents.DotNetBar.ButtonX ButtonX8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX8 != null)
                {
                }

                _ButtonX8 = value;
                if (_ButtonX8 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader4;

        internal ColumnHeader ColumnHeader4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader4 != null)
                {
                }

                _ColumnHeader4 = value;
                if (_ColumnHeader4 != null)
                {
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