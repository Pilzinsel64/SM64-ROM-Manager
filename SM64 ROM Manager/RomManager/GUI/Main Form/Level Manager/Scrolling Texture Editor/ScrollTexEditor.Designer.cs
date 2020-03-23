using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class ScrollTexEditor : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrollTexEditor));
            _ListViewEx_LM_ScrollTexList = new DevComponents.DotNetBar.Controls.ListViewEx();
            _ListViewEx_LM_ScrollTexList.SelectedIndexChanged += new EventHandler(ListViewEx_LM_ScrollTexList_SelectedIndexChanged);
            _ListViewEx_LM_ScrollTexList.MouseUp += new MouseEventHandler(ListViewEx_LM_ScrollTexList_MouseClick);
            _ColumnHeader8 = new ColumnHeader();
            _ColumnHeader9 = new ColumnHeader();
            _ColumnHeader10 = new ColumnHeader();
            _ColumnHeader11 = new ColumnHeader();
            _ColumnHeader12 = new ColumnHeader();
            _ColumnHeader1 = new ColumnHeader();
            _ColumnHeader2 = new ColumnHeader();
            _AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            _AdvPropertyGrid1.ConvertFromStringToPropertyValue += new DevComponents.DotNetBar.ConvertValueEventHandler(AdvPropertyGrid1_ConvertFromStringToPropertyValue);
            _AdvPropertyGrid1.ConvertPropertyValueToString += new DevComponents.DotNetBar.ConvertValueEventHandler(AdvPropertyGrid1_ConvertPropertyValueToString);
            _AdvPropertyGrid1.PropertyValueChanged += new System.ComponentModel.PropertyChangedEventHandler(AdvPropertyGrid1_PropertyValueChanged);
            _ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            _ButtonItem_CM = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem44 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem44.Click += new EventHandler(ButtonItem44_Click);
            _ButtonItem43 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem43.Click += new EventHandler(ButtonItem43_Click);
            _SplitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)_AdvPropertyGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_SplitContainer1).BeginInit();
            _SplitContainer1.Panel1.SuspendLayout();
            _SplitContainer1.Panel2.SuspendLayout();
            _SplitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewEx_LM_ScrollTexList
            // 
            _ListViewEx_LM_ScrollTexList.BackColor = Color.White;
            // 
            // 
            // 
            _ListViewEx_LM_ScrollTexList.Border.Class = "ListViewBorder";
            _ListViewEx_LM_ScrollTexList.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx_LM_ScrollTexList.Columns.AddRange(new ColumnHeader[] { _ColumnHeader8, _ColumnHeader9, _ColumnHeader10, _ColumnHeader11, _ColumnHeader12, _ColumnHeader1, _ColumnHeader2 });
            _ListViewEx_LM_ScrollTexList.DisabledBackColor = Color.Empty;
            _ListViewEx_LM_ScrollTexList.Dock = DockStyle.Fill;
            _ListViewEx_LM_ScrollTexList.FocusCuesEnabled = false;
            _ListViewEx_LM_ScrollTexList.ForeColor = Color.Black;
            _ListViewEx_LM_ScrollTexList.FullRowSelect = true;
            _ListViewEx_LM_ScrollTexList.GridLines = true;
            _ListViewEx_LM_ScrollTexList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _ListViewEx_LM_ScrollTexList.HideSelection = false;
            _ListViewEx_LM_ScrollTexList.Location = new Point(0, 0);
            _ListViewEx_LM_ScrollTexList.MultiSelect = false;
            _ListViewEx_LM_ScrollTexList.Name = "ListViewEx_LM_ScrollTexList";
            _ListViewEx_LM_ScrollTexList.Size = new Size(583, 633);
            _ListViewEx_LM_ScrollTexList.TabIndex = 2;
            _ListViewEx_LM_ScrollTexList.UseCompatibleStateImageBehavior = false;
            _ListViewEx_LM_ScrollTexList.View = View.Details;
            // 
            // ColumnHeader8
            // 
            _ColumnHeader8.Text = "#";
            _ColumnHeader8.Width = 30;
            // 
            // ColumnHeader9
            // 
            _ColumnHeader9.Text = "Behavior";
            _ColumnHeader9.Width = 100;
            // 
            // ColumnHeader10
            // 
            _ColumnHeader10.Text = "Type";
            _ColumnHeader10.Width = 100;
            // 
            // ColumnHeader11
            // 
            _ColumnHeader11.Text = "Duration";
            // 
            // ColumnHeader12
            // 
            _ColumnHeader12.Text = "Speed";
            // 
            // ColumnHeader1
            // 
            _ColumnHeader1.Text = "Vertex Pointer";
            _ColumnHeader1.Width = 100;
            // 
            // ColumnHeader2
            // 
            _ColumnHeader2.Text = "Vertices";
            _ColumnHeader2.Width = 100;
            // 
            // AdvPropertyGrid1
            // 
            _AdvPropertyGrid1.Dock = DockStyle.Fill;
            _AdvPropertyGrid1.GridLinesColor = Color.WhiteSmoke;
            _AdvPropertyGrid1.Location = new Point(0, 0);
            _AdvPropertyGrid1.Name = "AdvPropertyGrid1";
            _AdvPropertyGrid1.Size = new Size(315, 633);
            _AdvPropertyGrid1.TabIndex = 8;
            _AdvPropertyGrid1.Text = "AdvPropertyGrid1";
            // 
            // ContextMenuBar1
            // 
            _ContextMenuBar1.AntiAlias = true;
            _ContextMenuBar1.Font = new Font("Segoe UI", 9.0F);
            _ContextMenuBar1.IsMaximized = false;
            _ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_CM });
            _ContextMenuBar1.Location = new Point(787, 0);
            _ContextMenuBar1.Name = "ContextMenuBar1";
            _ContextMenuBar1.Size = new Size(78, 25);
            _ContextMenuBar1.Stretch = true;
            _ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ContextMenuBar1.TabIndex = 9;
            _ContextMenuBar1.TabStop = false;
            _ContextMenuBar1.Text = "ContextMenuBar1";
            // 
            // ButtonItem_CM
            // 
            _ButtonItem_CM.AutoExpandOnClick = true;
            _ButtonItem_CM.Name = "ButtonItem_CM";
            _ButtonItem_CM.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem44, _ButtonItem43 });
            _ButtonItem_CM.Text = "ContextMenu";
            // 
            // ButtonItem44
            // 
            _ButtonItem44.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem44.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            _ButtonItem44.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem44.Name = "ButtonItem44";
            _ButtonItem44.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            _ButtonItem44.SubItemsExpandWidth = 14;
            _ButtonItem44.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonItem44.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem44.SymbolSize = 12.0F;
            _ButtonItem44.Text = "Add New";
            // 
            // ButtonItem43
            // 
            _ButtonItem43.BeginGroup = true;
            _ButtonItem43.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem43.Name = "ButtonItem43";
            _ButtonItem43.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            _ButtonItem43.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonItem43.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem43.SymbolSize = 12.0F;
            _ButtonItem43.Text = "Remove";
            // 
            // SplitContainer1
            // 
            _SplitContainer1.BackColor = Color.Transparent;
            _SplitContainer1.Dock = DockStyle.Fill;
            _SplitContainer1.FixedPanel = FixedPanel.Panel2;
            _SplitContainer1.Location = new Point(0, 0);
            _SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            _SplitContainer1.Panel1.Controls.Add(_ListViewEx_LM_ScrollTexList);
            // 
            // SplitContainer1.Panel2
            // 
            _SplitContainer1.Panel2.Controls.Add(_AdvPropertyGrid1);
            _SplitContainer1.Size = new Size(902, 633);
            _SplitContainer1.SplitterDistance = 583;
            _SplitContainer1.TabIndex = 9;
            // 
            // ScrollTexEditor
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 633);
            Controls.Add(_ContextMenuBar1);
            Controls.Add(_SplitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ScrollTexEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Texture Animation Editor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_AdvPropertyGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).EndInit();
            _SplitContainer1.Panel1.ResumeLayout(false);
            _SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_SplitContainer1).EndInit();
            _SplitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.ListViewEx _ListViewEx_LM_ScrollTexList;

        internal DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_LM_ScrollTexList
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewEx_LM_ScrollTexList;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewEx_LM_ScrollTexList != null)
                {
                    _ListViewEx_LM_ScrollTexList.SelectedIndexChanged -= ListViewEx_LM_ScrollTexList_SelectedIndexChanged;
                    _ListViewEx_LM_ScrollTexList.MouseUp -= ListViewEx_LM_ScrollTexList_MouseClick;
                }

                _ListViewEx_LM_ScrollTexList = value;
                if (_ListViewEx_LM_ScrollTexList != null)
                {
                    _ListViewEx_LM_ScrollTexList.SelectedIndexChanged += ListViewEx_LM_ScrollTexList_SelectedIndexChanged;
                    _ListViewEx_LM_ScrollTexList.MouseUp += ListViewEx_LM_ScrollTexList_MouseClick;
                }
            }
        }

        private ColumnHeader _ColumnHeader8;

        internal ColumnHeader ColumnHeader8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader8 != null)
                {
                }

                _ColumnHeader8 = value;
                if (_ColumnHeader8 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader9;

        internal ColumnHeader ColumnHeader9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader9 != null)
                {
                }

                _ColumnHeader9 = value;
                if (_ColumnHeader9 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader10;

        internal ColumnHeader ColumnHeader10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader10 != null)
                {
                }

                _ColumnHeader10 = value;
                if (_ColumnHeader10 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader11;

        internal ColumnHeader ColumnHeader11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader11 != null)
                {
                }

                _ColumnHeader11 = value;
                if (_ColumnHeader11 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader12;

        internal ColumnHeader ColumnHeader12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader12 != null)
                {
                }

                _ColumnHeader12 = value;
                if (_ColumnHeader12 != null)
                {
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
                    _AdvPropertyGrid1.ConvertFromStringToPropertyValue -= AdvPropertyGrid1_ConvertFromStringToPropertyValue;
                    _AdvPropertyGrid1.ConvertPropertyValueToString -= AdvPropertyGrid1_ConvertPropertyValueToString;
                    _AdvPropertyGrid1.PropertyValueChanged -= AdvPropertyGrid1_PropertyValueChanged;
                }

                _AdvPropertyGrid1 = value;
                if (_AdvPropertyGrid1 != null)
                {
                    _AdvPropertyGrid1.ConvertFromStringToPropertyValue += AdvPropertyGrid1_ConvertFromStringToPropertyValue;
                    _AdvPropertyGrid1.ConvertPropertyValueToString += AdvPropertyGrid1_ConvertPropertyValueToString;
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

        private DevComponents.DotNetBar.ContextMenuBar _ContextMenuBar1;

        internal DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContextMenuBar1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContextMenuBar1 != null)
                {
                }

                _ContextMenuBar1 = value;
                if (_ContextMenuBar1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CM;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CM
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CM;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CM != null)
                {
                }

                _ButtonItem_CM = value;
                if (_ButtonItem_CM != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem44;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem44
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem44;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem44 != null)
                {
                    _ButtonItem44.Click -= ButtonItem44_Click;
                }

                _ButtonItem44 = value;
                if (_ButtonItem44 != null)
                {
                    _ButtonItem44.Click += ButtonItem44_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem43;

        private DevComponents.DotNetBar.ButtonItem ButtonItem43
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem43;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem43 != null)
                {
                    _ButtonItem43.Click -= ButtonItem43_Click;
                }

                _ButtonItem43 = value;
                if (_ButtonItem43 != null)
                {
                    _ButtonItem43.Click += ButtonItem43_Click;
                }
            }
        }

        private SplitContainer _SplitContainer1;

        internal SplitContainer SplitContainer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SplitContainer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SplitContainer1 != null)
                {
                }

                _SplitContainer1 = value;
                if (_SplitContainer1 != null)
                {
                }
            }
        }
    }
}