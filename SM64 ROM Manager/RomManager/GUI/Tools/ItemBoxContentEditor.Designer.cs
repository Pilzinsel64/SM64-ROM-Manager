using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class ItemBoxContentEditor : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemBoxContentEditor));
            _Panel1 = new Panel();
            _ListViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            _ListViewEx1.SelectedIndexChanged += new EventHandler(ListViewEx1_SelectedIndexChanged);
            _ColumnHeader1 = new ColumnHeader();
            _ColumnHeader2 = new ColumnHeader();
            _ColumnHeader3 = new ColumnHeader();
            _ColumnHeader4 = new ColumnHeader();
            _ColumnHeader5 = new ColumnHeader();
            _Bar1 = new DevComponents.DotNetBar.Bar();
            _ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem6.Click += new EventHandler(ButtonItem6_Click);
            _ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem3.Click += new EventHandler(ButtonItem3_Click);
            _ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem4.Click += new EventHandler(ButtonItem4_Click);
            _ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem5.Click += new EventHandler(ButtonItem5_Click);
            _AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            _AdvPropertyGrid1.PropertyValueChanged += new System.ComponentModel.PropertyChangedEventHandler(AdvPropertyGrid1_PropertyValueChanged);
            _ButtonItem_SaveRom = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_SaveRom.Click += new EventHandler(ButtonItem_SaveRom_Click);
            _ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem1.Click += new EventHandler(ButtonItem1_Click);
            _ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem2.Click += new EventHandler(ButtonItem2_Click);
            _Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_Bar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_AdvPropertyGrid1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_ListViewEx1);
            _Panel1.Controls.Add(_Bar1);
            _Panel1.Controls.Add(_AdvPropertyGrid1);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // ListViewEx1
            // 
            _ListViewEx1.BackColor = Color.White;
            // 
            // 
            // 
            _ListViewEx1.Border.Class = "ListViewBorder";
            _ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx1.Columns.AddRange(new ColumnHeader[] { _ColumnHeader1, _ColumnHeader2, _ColumnHeader3, _ColumnHeader4, _ColumnHeader5 });
            _ListViewEx1.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_ListViewEx1, "ListViewEx1");
            _ListViewEx1.FocusCuesEnabled = false;
            _ListViewEx1.ForeColor = Color.Black;
            _ListViewEx1.FullRowSelect = true;
            _ListViewEx1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _ListViewEx1.HideSelection = false;
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
            // ColumnHeader5
            // 
            resources.ApplyResources(_ColumnHeader5, "ColumnHeader5");
            // 
            // Bar1
            // 
            _Bar1.AntiAlias = true;
            resources.ApplyResources(_Bar1, "Bar1");
            _Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            _Bar1.IsMaximized = false;
            _Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_SaveRom, _ButtonItem6, _ButtonItem1, _ButtonItem2, _ButtonItem3, _ButtonItem4, _ButtonItem5 });
            _Bar1.Name = "Bar1";
            _Bar1.Stretch = true;
            _Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Bar1.TabStop = false;
            // 
            // ButtonItem6
            // 
            _ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem6.Image = My.Resources.MyIcons.icons8_refresh_16px;
            _ButtonItem6.Name = "ButtonItem6";
            _ButtonItem6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem6.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem6, "ButtonItem6");
            // 
            // ButtonItem3
            // 
            _ButtonItem3.BeginGroup = true;
            _ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem3.Image = My.Resources.MyIcons.icons8_undo_16px;
            _ButtonItem3.Name = "ButtonItem3";
            _ButtonItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem3.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem3, "ButtonItem3");
            // 
            // ButtonItem4
            // 
            _ButtonItem4.BeginGroup = true;
            _ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem4.Image = My.Resources.MyIcons.icons8_import_16px;
            _ButtonItem4.Name = "ButtonItem4";
            _ButtonItem4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem4.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem4, "ButtonItem4");
            // 
            // ButtonItem5
            // 
            _ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem5.Image = My.Resources.MyIcons.icons8_export_16px;
            _ButtonItem5.Name = "ButtonItem5";
            _ButtonItem5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem5.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem5, "ButtonItem5");
            // 
            // AdvPropertyGrid1
            // 
            resources.ApplyResources(_AdvPropertyGrid1, "AdvPropertyGrid1");
            _AdvPropertyGrid1.GridLinesColor = Color.WhiteSmoke;
            _AdvPropertyGrid1.Name = "AdvPropertyGrid1";
            // 
            // ButtonItem_SaveRom
            // 
            _ButtonItem_SaveRom.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_SaveRom.Image = My.Resources.MyIcons.icons8_save_16px;
            _ButtonItem_SaveRom.Name = "ButtonItem_SaveRom";
            _ButtonItem_SaveRom.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            _ButtonItem_SaveRom.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonItem_SaveRom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_SaveRom.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_SaveRom, "ButtonItem_SaveRom");
            // 
            // ButtonItem1
            // 
            _ButtonItem1.BeginGroup = true;
            _ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem1.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            _ButtonItem1.Name = "ButtonItem1";
            _ButtonItem1.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonItem1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem1.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem1, "ButtonItem1");
            // 
            // ButtonItem2
            // 
            _ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem2.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem2.Name = "ButtonItem2";
            _ButtonItem2.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonItem2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem2.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem2, "ButtonItem2");
            // 
            // ItemBoxContentEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel1);
            Name = "ItemBoxContentEditor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_Bar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_AdvPropertyGrid1).EndInit();
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

        private DevComponents.DotNetBar.Bar _Bar1;

        internal DevComponents.DotNetBar.Bar Bar1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Bar1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Bar1 != null)
                {
                }

                _Bar1 = value;
                if (_Bar1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem1;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click -= ButtonItem1_Click;
                }

                _ButtonItem1 = value;
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click += ButtonItem1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.AdvPropertyGrid _AdvPropertyGrid1;

        internal DevComponents.DotNetBar.AdvPropertyGrid AdvPropertyGrid1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AdvPropertyGrid1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AdvPropertyGrid1 != null)
                {
                    _AdvPropertyGrid1.PropertyValueChanged -= AdvPropertyGrid1_PropertyValueChanged;
                }

                _AdvPropertyGrid1 = value;
                if (_AdvPropertyGrid1 != null)
                {
                    _AdvPropertyGrid1.PropertyValueChanged += AdvPropertyGrid1_PropertyValueChanged;
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

        private ColumnHeader _ColumnHeader5;

        internal ColumnHeader ColumnHeader5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader5 != null)
                {
                }

                _ColumnHeader5 = value;
                if (_ColumnHeader5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem2;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem2 != null)
                {
                    _ButtonItem2.Click -= ButtonItem2_Click;
                }

                _ButtonItem2 = value;
                if (_ButtonItem2 != null)
                {
                    _ButtonItem2.Click += ButtonItem2_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem3;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem3 != null)
                {
                    _ButtonItem3.Click -= ButtonItem3_Click;
                }

                _ButtonItem3 = value;
                if (_ButtonItem3 != null)
                {
                    _ButtonItem3.Click += ButtonItem3_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem4;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem4 != null)
                {
                    _ButtonItem4.Click -= ButtonItem4_Click;
                }

                _ButtonItem4 = value;
                if (_ButtonItem4 != null)
                {
                    _ButtonItem4.Click += ButtonItem4_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem5;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem5 != null)
                {
                    _ButtonItem5.Click -= ButtonItem5_Click;
                }

                _ButtonItem5 = value;
                if (_ButtonItem5 != null)
                {
                    _ButtonItem5.Click += ButtonItem5_Click;
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

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_SaveRom;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_SaveRom
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_SaveRom;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_SaveRom != null)
                {
                    _ButtonItem_SaveRom.Click -= ButtonItem_SaveRom_Click;
                }

                _ButtonItem_SaveRom = value;
                if (_ButtonItem_SaveRom != null)
                {
                    _ButtonItem_SaveRom.Click += ButtonItem_SaveRom_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem6;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem6 != null)
                {
                    _ButtonItem6.Click -= ButtonItem6_Click;
                }

                _ButtonItem6 = value;
                if (_ButtonItem6 != null)
                {
                    _ButtonItem6.Click += ButtonItem6_Click;
                }
            }
        }
    }
}