using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class TextProfileEditor : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TextProfileEditor));
            _AdvTree1 = new DevComponents.AdvTree.AdvTree();
            _AdvTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(AdvTree1_AfterNodeSelect);
            _NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            _ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            _Panel1 = new Panel();
            _Panel2 = new Panel();
            _Panel3 = new Panel();
            _ItemListBox1 = new Publics.Controls.ItemListBox();
            _ItemListBox1.SelectedItemChanged += new Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(ItemListBox1_SelectedChanged);
            _Bar2 = new DevComponents.DotNetBar.Bar();
            _ButtonItem_AddArrayItem = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_AddArrayItem.Click += new EventHandler(ButtonItem_AddArrayItem_Click);
            _ButtonItem_RemoveArrayItem = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveArrayItem.Click += new EventHandler(ButtonItem_RemoveArrayItem_Click);
            _ButtonItem_ClearArrayItems = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ClearArrayItems.Click += new EventHandler(ButtonItem_ClearArrayItems_Click);
            _AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            _AdvPropertyGrid1.PropertyValueChanged += new System.ComponentModel.PropertyChangedEventHandler(AdvPropertyGrid1_PropertyChanged);
            _Bar1 = new DevComponents.DotNetBar.Bar();
            _ButtonItem_AddTableGroup = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_AddTableGroup.Click += new EventHandler(ButtonItem_AddTableGroup_Click);
            _ButtonItem_AddArrayGroup = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_AddArrayGroup.Click += new EventHandler(ButtonItem_AddArrayGroup_Click);
            _ButtonItem_RemoveGroup = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveGroup.Click += new EventHandler(ButtonItem_RemoveGroup_Click);
            ((System.ComponentModel.ISupportInitialize)_AdvTree1).BeginInit();
            _Panel1.SuspendLayout();
            _Panel2.SuspendLayout();
            _Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_Bar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_AdvPropertyGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Bar1).BeginInit();
            SuspendLayout();
            // 
            // AdvTree1
            // 
            _AdvTree1.AccessibleRole = AccessibleRole.Outline;
            _AdvTree1.BackColor = SystemColors.Window;
            // 
            // 
            // 
            _AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
            _AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _AdvTree1.Dock = DockStyle.Left;
            _AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _AdvTree1.Location = new Point(0, 0);
            _AdvTree1.Name = "AdvTree1";
            _AdvTree1.NodesConnector = _NodeConnector1;
            _AdvTree1.NodeStyle = _ElementStyle1;
            _AdvTree1.PathSeparator = ";";
            _AdvTree1.Size = new Size(241, 472);
            _AdvTree1.Styles.Add(_ElementStyle1);
            _AdvTree1.TabIndex = 0;
            _AdvTree1.Text = "AdvTree1";
            // 
            // NodeConnector1
            // 
            _NodeConnector1.LineColor = SystemColors.ControlText;
            // 
            // ElementStyle1
            // 
            _ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ElementStyle1.Name = "ElementStyle1";
            _ElementStyle1.TextColor = SystemColors.ControlText;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_Panel2);
            _Panel1.Controls.Add(_AdvTree1);
            _Panel1.Dock = DockStyle.Fill;
            _Panel1.Location = new Point(0, 25);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(567, 472);
            _Panel1.TabIndex = 1;
            // 
            // Panel2
            // 
            _Panel2.Controls.Add(_Panel3);
            _Panel2.Controls.Add(_AdvPropertyGrid1);
            _Panel2.Dock = DockStyle.Fill;
            _Panel2.Location = new Point(241, 0);
            _Panel2.Name = "Panel2";
            _Panel2.Size = new Size(326, 472);
            _Panel2.TabIndex = 1;
            // 
            // Panel3
            // 
            _Panel3.Controls.Add(_ItemListBox1);
            _Panel3.Controls.Add(_Bar2);
            _Panel3.Dock = DockStyle.Fill;
            _Panel3.Location = new Point(0, 194);
            _Panel3.Name = "Panel3";
            _Panel3.Size = new Size(326, 278);
            _Panel3.TabIndex = 4;
            // 
            // ItemListBox1
            // 
            _ItemListBox1.AutoScroll = true;
            // 
            // 
            // 
            _ItemListBox1.BackgroundStyle.Class = "ItemPanel";
            _ItemListBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemListBox1.ContainerControlProcessDialogKey = true;
            _ItemListBox1.Dock = DockStyle.Fill;
            _ItemListBox1.DragDropSupport = true;
            _ItemListBox1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemListBox1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemListBox1.Location = new Point(0, 25);
            _ItemListBox1.Name = "ItemListBox1";
            _ItemListBox1.ReserveLeftSpace = false;
            _ItemListBox1.Size = new Size(326, 253);
            _ItemListBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ItemListBox1.TabIndex = 0;
            _ItemListBox1.Text = "ItemListBox1";
            // 
            // Bar2
            // 
            _Bar2.AccessibleDescription = "Bar2 (Bar2)";
            _Bar2.AccessibleName = "Bar2";
            _Bar2.AccessibleRole = AccessibleRole.ToolBar;
            _Bar2.AntiAlias = true;
            _Bar2.Dock = DockStyle.Top;
            _Bar2.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            _Bar2.Font = new Font("Segoe UI", 9.0F);
            _Bar2.IsMaximized = false;
            _Bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_AddArrayItem, _ButtonItem_RemoveArrayItem, _ButtonItem_ClearArrayItems });
            _Bar2.Location = new Point(0, 0);
            _Bar2.Name = "Bar2";
            _Bar2.RoundCorners = false;
            _Bar2.Size = new Size(326, 25);
            _Bar2.Stretch = true;
            _Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Bar2.TabIndex = 3;
            _Bar2.TabStop = false;
            _Bar2.Text = "Bar2";
            // 
            // ButtonItem_AddArrayItem
            // 
            _ButtonItem_AddArrayItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_AddArrayItem.Image = My.Resources.MyIcons.icons8_add_subnode_16px;
            _ButtonItem_AddArrayItem.Name = "ButtonItem_AddArrayItem";
            _ButtonItem_AddArrayItem.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonItem_AddArrayItem.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_AddArrayItem.SymbolSize = 12.0F;
            _ButtonItem_AddArrayItem.Text = "Text Item";
            // 
            // ButtonItem_RemoveArrayItem
            // 
            _ButtonItem_RemoveArrayItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_RemoveArrayItem.Image = My.Resources.MyIcons.icons8_delete_subnode_16px;
            _ButtonItem_RemoveArrayItem.Name = "ButtonItem_RemoveArrayItem";
            _ButtonItem_RemoveArrayItem.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonItem_RemoveArrayItem.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_RemoveArrayItem.SymbolSize = 12.0F;
            _ButtonItem_RemoveArrayItem.Text = "Remove Item";
            // 
            // ButtonItem_ClearArrayItems
            // 
            _ButtonItem_ClearArrayItems.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_ClearArrayItems.Image = My.Resources.MyIcons.icons8_delete_2_16px;
            _ButtonItem_ClearArrayItems.Name = "ButtonItem_ClearArrayItems";
            _ButtonItem_ClearArrayItems.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonItem_ClearArrayItems.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_ClearArrayItems.SymbolSize = 12.0F;
            _ButtonItem_ClearArrayItems.Text = "Clear List";
            // 
            // AdvPropertyGrid1
            // 
            _AdvPropertyGrid1.Dock = DockStyle.Top;
            _AdvPropertyGrid1.GridLinesColor = Color.WhiteSmoke;
            _AdvPropertyGrid1.Location = new Point(0, 0);
            _AdvPropertyGrid1.Name = "AdvPropertyGrid1";
            _AdvPropertyGrid1.Size = new Size(326, 194);
            _AdvPropertyGrid1.TabIndex = 1;
            _AdvPropertyGrid1.Text = "AdvPropertyGrid1";
            // 
            // Bar1
            // 
            _Bar1.AccessibleDescription = "Bar1 (Bar1)";
            _Bar1.AccessibleName = "Bar1";
            _Bar1.AccessibleRole = AccessibleRole.ToolBar;
            _Bar1.AntiAlias = true;
            _Bar1.Dock = DockStyle.Top;
            _Bar1.Font = new Font("Segoe UI", 9.0F);
            _Bar1.IsMaximized = false;
            _Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_AddTableGroup, _ButtonItem_AddArrayGroup, _ButtonItem_RemoveGroup });
            _Bar1.Location = new Point(0, 0);
            _Bar1.Name = "Bar1";
            _Bar1.RoundCorners = false;
            _Bar1.Size = new Size(567, 25);
            _Bar1.Stretch = true;
            _Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Bar1.TabIndex = 2;
            _Bar1.TabStop = false;
            _Bar1.Text = "Bar1";
            // 
            // ButtonItem_AddTableGroup
            // 
            _ButtonItem_AddTableGroup.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_AddTableGroup.Image = My.Resources.MyIcons.icons8_add_node_16px;
            _ButtonItem_AddTableGroup.Name = "ButtonItem_AddTableGroup";
            _ButtonItem_AddTableGroup.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonItem_AddTableGroup.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_AddTableGroup.SymbolSize = 12.0F;
            _ButtonItem_AddTableGroup.Text = "Table Group";
            // 
            // ButtonItem_AddArrayGroup
            // 
            _ButtonItem_AddArrayGroup.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_AddArrayGroup.Image = My.Resources.MyIcons.icons8_add_node_16px;
            _ButtonItem_AddArrayGroup.Name = "ButtonItem_AddArrayGroup";
            _ButtonItem_AddArrayGroup.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonItem_AddArrayGroup.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_AddArrayGroup.SymbolSize = 12.0F;
            _ButtonItem_AddArrayGroup.Text = "Array Group";
            // 
            // ButtonItem_RemoveGroup
            // 
            _ButtonItem_RemoveGroup.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_RemoveGroup.Image = My.Resources.MyIcons.icons8_delete_node_16px;
            _ButtonItem_RemoveGroup.Name = "ButtonItem_RemoveGroup";
            _ButtonItem_RemoveGroup.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonItem_RemoveGroup.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_RemoveGroup.SymbolSize = 12.0F;
            _ButtonItem_RemoveGroup.Text = "Remove Group";
            // 
            // TextProfileEditor
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 497);
            Controls.Add(_Panel1);
            Controls.Add(_Bar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TextProfileEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text Profile Editor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_AdvTree1).EndInit();
            _Panel1.ResumeLayout(false);
            _Panel2.ResumeLayout(false);
            _Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_Bar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_AdvPropertyGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Bar1).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.AdvTree.AdvTree _AdvTree1;

        internal DevComponents.AdvTree.AdvTree AdvTree1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AdvTree1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AdvTree1 != null)
                {
                    _AdvTree1.AfterNodeSelect -= AdvTree1_AfterNodeSelect;
                }

                _AdvTree1 = value;
                if (_AdvTree1 != null)
                {
                    _AdvTree1.AfterNodeSelect += AdvTree1_AfterNodeSelect;
                }
            }
        }

        private DevComponents.AdvTree.NodeConnector _NodeConnector1;

        internal DevComponents.AdvTree.NodeConnector NodeConnector1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NodeConnector1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NodeConnector1 != null)
                {
                }

                _NodeConnector1 = value;
                if (_NodeConnector1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ElementStyle _ElementStyle1;

        internal DevComponents.DotNetBar.ElementStyle ElementStyle1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ElementStyle1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ElementStyle1 != null)
                {
                }

                _ElementStyle1 = value;
                if (_ElementStyle1 != null)
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

        private Panel _Panel2;

        internal Panel Panel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel2 != null)
                {
                }

                _Panel2 = value;
                if (_Panel2 != null)
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
                    _AdvPropertyGrid1.PropertyValueChanged -= AdvPropertyGrid1_PropertyChanged;
                }

                _AdvPropertyGrid1 = value;
                if (_AdvPropertyGrid1 != null)
                {
                    _AdvPropertyGrid1.PropertyValueChanged += AdvPropertyGrid1_PropertyChanged;
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

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_AddTableGroup;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_AddTableGroup
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_AddTableGroup;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_AddTableGroup != null)
                {
                    _ButtonItem_AddTableGroup.Click -= ButtonItem_AddTableGroup_Click;
                }

                _ButtonItem_AddTableGroup = value;
                if (_ButtonItem_AddTableGroup != null)
                {
                    _ButtonItem_AddTableGroup.Click += ButtonItem_AddTableGroup_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_AddArrayGroup;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_AddArrayGroup
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_AddArrayGroup;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_AddArrayGroup != null)
                {
                    _ButtonItem_AddArrayGroup.Click -= ButtonItem_AddArrayGroup_Click;
                }

                _ButtonItem_AddArrayGroup = value;
                if (_ButtonItem_AddArrayGroup != null)
                {
                    _ButtonItem_AddArrayGroup.Click += ButtonItem_AddArrayGroup_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveGroup;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveGroup
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveGroup;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveGroup != null)
                {
                    _ButtonItem_RemoveGroup.Click -= ButtonItem_RemoveGroup_Click;
                }

                _ButtonItem_RemoveGroup = value;
                if (_ButtonItem_RemoveGroup != null)
                {
                    _ButtonItem_RemoveGroup.Click += ButtonItem_RemoveGroup_Click;
                }
            }
        }

        private Panel _Panel3;

        internal Panel Panel3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel3 != null)
                {
                }

                _Panel3 = value;
                if (_Panel3 != null)
                {
                }
            }
        }

        private Publics.Controls.ItemListBox _ItemListBox1;

        internal Publics.Controls.ItemListBox ItemListBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemListBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemListBox1 != null)
                {
                    _ItemListBox1.SelectedItemChanged -= ItemListBox1_SelectedChanged;
                }

                _ItemListBox1 = value;
                if (_ItemListBox1 != null)
                {
                    _ItemListBox1.SelectedItemChanged += ItemListBox1_SelectedChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Bar _Bar2;

        internal DevComponents.DotNetBar.Bar Bar2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Bar2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Bar2 != null)
                {
                }

                _Bar2 = value;
                if (_Bar2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ClearArrayItems;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ClearArrayItems
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ClearArrayItems;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ClearArrayItems != null)
                {
                    _ButtonItem_ClearArrayItems.Click -= ButtonItem_ClearArrayItems_Click;
                }

                _ButtonItem_ClearArrayItems = value;
                if (_ButtonItem_ClearArrayItems != null)
                {
                    _ButtonItem_ClearArrayItems.Click += ButtonItem_ClearArrayItems_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveArrayItem;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveArrayItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveArrayItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveArrayItem != null)
                {
                    _ButtonItem_RemoveArrayItem.Click -= ButtonItem_RemoveArrayItem_Click;
                }

                _ButtonItem_RemoveArrayItem = value;
                if (_ButtonItem_RemoveArrayItem != null)
                {
                    _ButtonItem_RemoveArrayItem.Click += ButtonItem_RemoveArrayItem_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_AddArrayItem;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_AddArrayItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_AddArrayItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_AddArrayItem != null)
                {
                    _ButtonItem_AddArrayItem.Click -= ButtonItem_AddArrayItem_Click;
                }

                _ButtonItem_AddArrayItem = value;
                if (_ButtonItem_AddArrayItem != null)
                {
                    _ButtonItem_AddArrayItem.Click += ButtonItem_AddArrayItem_Click;
                }
            }
        }
    }
}