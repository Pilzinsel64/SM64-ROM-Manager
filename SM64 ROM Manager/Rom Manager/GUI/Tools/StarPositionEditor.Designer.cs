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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarPositionEditor));
            this._Panel1 = new System.Windows.Forms.Panel();
            this._LabelX5 = new DevComponents.DotNetBar.LabelX();
            this._LabelX4 = new DevComponents.DotNetBar.LabelX();
            this._LabelX3 = new DevComponents.DotNetBar.LabelX();
            this._ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this._LabelX2 = new DevComponents.DotNetBar.LabelX();
            this._IntegerInput_z = new DevComponents.Editors.IntegerInput();
            this._IntegerInput_Y = new DevComponents.Editors.IntegerInput();
            this._IntegerInput_X = new DevComponents.Editors.IntegerInput();
            this._ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this._LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.ButtonX_PastePosition = new DevComponents.DotNetBar.ButtonX();
            this._Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._IntegerInput_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._IntegerInput_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._IntegerInput_X)).BeginInit();
            this.SuspendLayout();
            // 
            // _Panel1
            // 
            this._Panel1.BackColor = System.Drawing.Color.Transparent;
            this._Panel1.Controls.Add(this.ButtonX_PastePosition);
            this._Panel1.Controls.Add(this._LabelX5);
            this._Panel1.Controls.Add(this._LabelX4);
            this._Panel1.Controls.Add(this._LabelX3);
            this._Panel1.Controls.Add(this._ButtonX1);
            this._Panel1.Controls.Add(this._LabelX2);
            this._Panel1.Controls.Add(this._IntegerInput_z);
            this._Panel1.Controls.Add(this._IntegerInput_Y);
            this._Panel1.Controls.Add(this._IntegerInput_X);
            this._Panel1.Controls.Add(this._ComboBoxEx1);
            this._Panel1.Controls.Add(this._LabelX1);
            resources.ApplyResources(this._Panel1, "_Panel1");
            this._Panel1.Name = "_Panel1";
            // 
            // _LabelX5
            // 
            // 
            // 
            // 
            this._LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this._LabelX5, "_LabelX5");
            this._LabelX5.Name = "_LabelX5";
            // 
            // _LabelX4
            // 
            // 
            // 
            // 
            this._LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this._LabelX4, "_LabelX4");
            this._LabelX4.Name = "_LabelX4";
            // 
            // _LabelX3
            // 
            // 
            // 
            // 
            this._LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this._LabelX3, "_LabelX3");
            this._LabelX3.Name = "_LabelX3";
            // 
            // _ButtonX1
            // 
            this._ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._ButtonX1.FocusCuesEnabled = false;
            this._ButtonX1.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_save_16px;
            resources.ApplyResources(this._ButtonX1, "_ButtonX1");
            this._ButtonX1.Name = "_ButtonX1";
            this._ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this._ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this._ButtonX1.SymbolSize = 12F;
            this._ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // _LabelX2
            // 
            // 
            // 
            // 
            this._LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this._LabelX2, "_LabelX2");
            this._LabelX2.Name = "_LabelX2";
            // 
            // _IntegerInput_z
            // 
            // 
            // 
            // 
            this._IntegerInput_z.BackgroundStyle.Class = "DateTimeInputBackground";
            this._IntegerInput_z.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._IntegerInput_z.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this._IntegerInput_z, "_IntegerInput_z");
            this._IntegerInput_z.MaxValue = 32767;
            this._IntegerInput_z.MinValue = -32768;
            this._IntegerInput_z.Name = "_IntegerInput_z";
            this._IntegerInput_z.ShowUpDown = true;
            // 
            // _IntegerInput_Y
            // 
            // 
            // 
            // 
            this._IntegerInput_Y.BackgroundStyle.Class = "DateTimeInputBackground";
            this._IntegerInput_Y.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._IntegerInput_Y.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this._IntegerInput_Y, "_IntegerInput_Y");
            this._IntegerInput_Y.MaxValue = 32767;
            this._IntegerInput_Y.MinValue = -32768;
            this._IntegerInput_Y.Name = "_IntegerInput_Y";
            this._IntegerInput_Y.ShowUpDown = true;
            // 
            // _IntegerInput_X
            // 
            // 
            // 
            // 
            this._IntegerInput_X.BackgroundStyle.Class = "DateTimeInputBackground";
            this._IntegerInput_X.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._IntegerInput_X.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this._IntegerInput_X, "_IntegerInput_X");
            this._IntegerInput_X.MaxValue = 32767;
            this._IntegerInput_X.MinValue = -32768;
            this._IntegerInput_X.Name = "_IntegerInput_X";
            this._IntegerInput_X.ShowUpDown = true;
            // 
            // _ComboBoxEx1
            // 
            this._ComboBoxEx1.DisplayMember = "Text";
            this._ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ComboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this._ComboBoxEx1.FormattingEnabled = true;
            resources.ApplyResources(this._ComboBoxEx1, "_ComboBoxEx1");
            this._ComboBoxEx1.Name = "_ComboBoxEx1";
            this._ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ComboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx1_SelectedIndexChanged);
            // 
            // _LabelX1
            // 
            // 
            // 
            // 
            this._LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this._LabelX1, "_LabelX1");
            this._LabelX1.Name = "_LabelX1";
            // 
            // ButtonX_PastePosition
            // 
            this.ButtonX_PastePosition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_PastePosition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_PastePosition.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_paste_16px;
            resources.ApplyResources(this.ButtonX_PastePosition, "ButtonX_PastePosition");
            this.ButtonX_PastePosition.Name = "ButtonX_PastePosition";
            this.ButtonX_PastePosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_PastePosition.Click += new System.EventHandler(this.ButtonX_PastePosition_Click);
            // 
            // StarPositionEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StarPositionEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this._Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._IntegerInput_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._IntegerInput_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._IntegerInput_X)).EndInit();
            this.ResumeLayout(false);

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
        private DevComponents.DotNetBar.ButtonX ButtonX_PastePosition;

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