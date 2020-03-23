using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class HUDOptionsForm : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(HUDOptionsForm));
            _Panel1 = new Panel();
            _TabControl1 = new DevComponents.DotNetBar.TabControl();
            _TabControlPanel_Positions = new DevComponents.DotNetBar.TabControlPanel();
            _Panel2 = new Panel();
            _AdvTree1 = new DevComponents.AdvTree.AdvTree();
            _AdvTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(AdvTree1_AfterNodeSelect);
            _Node1 = new DevComponents.AdvTree.Node();
            _NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            _ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            _LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _IntegerInput_PosX = new DevComponents.Editors.IntegerInput();
            _IntegerInput_PosY = new DevComponents.Editors.IntegerInput();
            _ButtonX_SavePosition = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_SavePosition.Click += new EventHandler(ButtonX_SavePosition_Click);
            _ButtonX_RestorePosition = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_RestorePosition.Click += new EventHandler(ButtonX_RestorePosition_Click);
            _LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            _LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _TabItem1 = new DevComponents.DotNetBar.TabItem(components);
            _Bar1 = new DevComponents.DotNetBar.Bar();
            _ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ImportPosFromFile = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ImportPosFromFile.Click += new EventHandler(ButtonItem_ImportPosFromFile_Click);
            _ButtonItem_ExportPosToFile = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ExportPosToFile.Click += new EventHandler(ButtonItem_ExportPosToFile_Click);
            _Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TabControl1).BeginInit();
            _TabControl1.SuspendLayout();
            _TabControlPanel_Positions.SuspendLayout();
            _Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_AdvTree1).BeginInit();
            _LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_PosX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_PosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Bar1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_TabControl1);
            _Panel1.Dock = DockStyle.Fill;
            _Panel1.Location = new Point(0, 24);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(508, 426);
            _Panel1.TabIndex = 0;
            // 
            // TabControl1
            // 
            _TabControl1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControl1.CanReorderTabs = true;
            _TabControl1.Controls.Add(_TabControlPanel_Positions);
            _TabControl1.Dock = DockStyle.Fill;
            _TabControl1.ForeColor = Color.Black;
            _TabControl1.Location = new Point(0, 0);
            _TabControl1.Name = "TabControl1";
            _TabControl1.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            _TabControl1.SelectedTabIndex = 0;
            _TabControl1.Size = new Size(508, 426);
            _TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            _TabControl1.TabIndex = 0;
            _TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            _TabControl1.Tabs.Add(_TabItem1);
            // 
            // TabControlPanel_Positions
            // 
            _TabControlPanel_Positions.Controls.Add(_Panel2);
            _TabControlPanel_Positions.DisabledBackColor = Color.Empty;
            _TabControlPanel_Positions.Dock = DockStyle.Fill;
            _TabControlPanel_Positions.Location = new Point(0, 27);
            _TabControlPanel_Positions.Name = "TabControlPanel_Positions";
            _TabControlPanel_Positions.Padding = new Padding(1);
            _TabControlPanel_Positions.Size = new Size(508, 399);
            _TabControlPanel_Positions.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel_Positions.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel_Positions.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel_Positions.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel_Positions.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel_Positions.Style.GradientAngle = 90;
            _TabControlPanel_Positions.TabIndex = 1;
            _TabControlPanel_Positions.TabItem = _TabItem1;
            // 
            // Panel2
            // 
            _Panel2.BackColor = Color.Transparent;
            _Panel2.Controls.Add(_AdvTree1);
            _Panel2.Controls.Add(_LayoutControl1);
            _Panel2.Dock = DockStyle.Fill;
            _Panel2.Location = new Point(1, 1);
            _Panel2.Name = "Panel2";
            _Panel2.Size = new Size(506, 397);
            _Panel2.TabIndex = 1;
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
            _AdvTree1.Dock = DockStyle.Fill;
            _AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _AdvTree1.Location = new Point(0, 0);
            _AdvTree1.Name = "AdvTree1";
            _AdvTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] { _Node1 });
            _AdvTree1.NodesConnector = _NodeConnector1;
            _AdvTree1.NodeStyle = _ElementStyle1;
            _AdvTree1.PathSeparator = ";";
            _AdvTree1.Size = new Size(312, 397);
            _AdvTree1.Styles.Add(_ElementStyle1);
            _AdvTree1.TabIndex = 0;
            _AdvTree1.Text = "AdvTree1";
            // 
            // Node1
            // 
            _Node1.Expanded = true;
            _Node1.Name = "Node1";
            _Node1.Text = "Node1";
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
            // LayoutControl1
            // 
            _LayoutControl1.Controls.Add(_IntegerInput_PosX);
            _LayoutControl1.Controls.Add(_IntegerInput_PosY);
            _LayoutControl1.Controls.Add(_ButtonX_SavePosition);
            _LayoutControl1.Controls.Add(_ButtonX_RestorePosition);
            _LayoutControl1.Dock = DockStyle.Right;
            _LayoutControl1.Location = new Point(312, 0);
            _LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            _LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem1, _LayoutControlItem2, _LayoutSpacerItem1, _LayoutControlItem4, _LayoutControlItem3 });
            _LayoutControl1.Size = new Size(194, 397);
            _LayoutControl1.TabIndex = 1;
            // 
            // IntegerInput_PosX
            // 
            // 
            // 
            // 
            _IntegerInput_PosX.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_PosX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_PosX.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_PosX.Location = new Point(22, 4);
            _IntegerInput_PosX.Margin = new Padding(0);
            _IntegerInput_PosX.Name = "IntegerInput_PosX";
            _IntegerInput_PosX.ShowUpDown = true;
            _IntegerInput_PosX.Size = new Size(168, 20);
            _IntegerInput_PosX.TabIndex = 0;
            // 
            // IntegerInput_PosY
            // 
            // 
            // 
            // 
            _IntegerInput_PosY.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_PosY.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_PosY.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_PosY.Location = new Point(22, 32);
            _IntegerInput_PosY.Margin = new Padding(0);
            _IntegerInput_PosY.Name = "IntegerInput_PosY";
            _IntegerInput_PosY.ShowUpDown = true;
            _IntegerInput_PosY.Size = new Size(168, 20);
            _IntegerInput_PosY.TabIndex = 1;
            // 
            // ButtonX_SavePosition
            // 
            _ButtonX_SavePosition.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_SavePosition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_SavePosition.Location = new Point(115, 60);
            _ButtonX_SavePosition.Margin = new Padding(0);
            _ButtonX_SavePosition.Name = "ButtonX_SavePosition";
            _ButtonX_SavePosition.Size = new Size(75, 24);
            _ButtonX_SavePosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_SavePosition.TabIndex = 4;
            _ButtonX_SavePosition.Text = "Save";
            // 
            // ButtonX_RestorePosition
            // 
            _ButtonX_RestorePosition.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_RestorePosition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_RestorePosition.Location = new Point(32, 60);
            _ButtonX_RestorePosition.Margin = new Padding(0);
            _ButtonX_RestorePosition.Name = "ButtonX_RestorePosition";
            _ButtonX_RestorePosition.Size = new Size(75, 24);
            _ButtonX_RestorePosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_RestorePosition.TabIndex = 3;
            _ButtonX_RestorePosition.Text = "Restore";
            // 
            // LayoutControlItem1
            // 
            _LayoutControlItem1.Control = _IntegerInput_PosX;
            _LayoutControlItem1.Height = 28;
            _LayoutControlItem1.MinSize = new Size(64, 18);
            _LayoutControlItem1.Name = "LayoutControlItem1";
            _LayoutControlItem1.Text = "X:";
            _LayoutControlItem1.Width = 100;
            _LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            _LayoutControlItem2.Control = _IntegerInput_PosY;
            _LayoutControlItem2.Height = 28;
            _LayoutControlItem2.MinSize = new Size(64, 18);
            _LayoutControlItem2.Name = "LayoutControlItem2";
            _LayoutControlItem2.Text = "Y:";
            _LayoutControlItem2.Width = 100;
            _LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            _LayoutSpacerItem1.Height = 32;
            _LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            _LayoutSpacerItem1.Width = 99;
            _LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            _LayoutControlItem4.Control = _ButtonX_RestorePosition;
            _LayoutControlItem4.Height = 32;
            _LayoutControlItem4.MinSize = new Size(32, 20);
            _LayoutControlItem4.Name = "LayoutControlItem4";
            _LayoutControlItem4.Width = 83;
            // 
            // LayoutControlItem3
            // 
            _LayoutControlItem3.Control = _ButtonX_SavePosition;
            _LayoutControlItem3.Height = 31;
            _LayoutControlItem3.MinSize = new Size(32, 20);
            _LayoutControlItem3.Name = "LayoutControlItem3";
            _LayoutControlItem3.Width = 83;
            // 
            // TabItem1
            // 
            _TabItem1.AttachedControl = _TabControlPanel_Positions;
            _TabItem1.Name = "TabItem1";
            _TabItem1.Text = "Positions";
            // 
            // Bar1
            // 
            _Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)";
            _Bar1.AccessibleName = "DotNetBar Bar";
            _Bar1.AccessibleRole = AccessibleRole.MenuBar;
            _Bar1.AntiAlias = true;
            _Bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            _Bar1.Dock = DockStyle.Top;
            _Bar1.Font = new Font("Segoe UI", 9.0F);
            _Bar1.IsMaximized = false;
            _Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem1 });
            _Bar1.Location = new Point(0, 0);
            _Bar1.MenuBar = true;
            _Bar1.Name = "Bar1";
            _Bar1.Size = new Size(508, 24);
            _Bar1.Stretch = true;
            _Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Bar1.TabIndex = 1;
            _Bar1.TabStop = false;
            // 
            // ButtonItem1
            // 
            _ButtonItem1.Name = "ButtonItem1";
            _ButtonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_ImportPosFromFile, _ButtonItem_ExportPosToFile });
            _ButtonItem1.Text = "Positions";
            // 
            // ButtonItem_ImportPosFromFile
            // 
            _ButtonItem_ImportPosFromFile.Name = "ButtonItem_ImportPosFromFile";
            _ButtonItem_ImportPosFromFile.Text = "Import from file ...";
            // 
            // ButtonItem_ExportPosToFile
            // 
            _ButtonItem_ExportPosToFile.Name = "ButtonItem_ExportPosToFile";
            _ButtonItem_ExportPosToFile.Text = "Export to file ...";
            // 
            // HUDOptionsForm
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(_Panel1);
            Controls.Add(_Bar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HUDOptionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HUD Options";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_TabControl1).EndInit();
            _TabControl1.ResumeLayout(false);
            _TabControlPanel_Positions.ResumeLayout(false);
            _Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_AdvTree1).EndInit();
            _LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_PosX).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_PosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Bar1).EndInit();
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

        private DevComponents.DotNetBar.TabControl _TabControl1;

        internal DevComponents.DotNetBar.TabControl TabControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControl1 != null)
                {
                }

                _TabControl1 = value;
                if (_TabControl1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabControlPanel _TabControlPanel_Positions;

        internal DevComponents.DotNetBar.TabControlPanel TabControlPanel_Positions
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControlPanel_Positions;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControlPanel_Positions != null)
                {
                }

                _TabControlPanel_Positions = value;
                if (_TabControlPanel_Positions != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem1;

        internal DevComponents.DotNetBar.TabItem TabItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem1 != null)
                {
                }

                _TabItem1 = value;
                if (_TabItem1 != null)
                {
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
                }

                _ButtonItem1 = value;
                if (_ButtonItem1 != null)
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

        private DevComponents.AdvTree.Node _Node1;

        internal DevComponents.AdvTree.Node Node1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Node1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Node1 != null)
                {
                }

                _Node1 = value;
                if (_Node1 != null)
                {
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

        private DevComponents.DotNetBar.Layout.LayoutControl _LayoutControl1;

        internal DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControl1 != null)
                {
                }

                _LayoutControl1 = value;
                if (_LayoutControl1 != null)
                {
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_PosY;

        internal DevComponents.Editors.IntegerInput IntegerInput_PosY
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_PosY;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_PosY != null)
                {
                }

                _IntegerInput_PosY = value;
                if (_IntegerInput_PosY != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem2;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem2 != null)
                {
                }

                _LayoutControlItem2 = value;
                if (_LayoutControlItem2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_SavePosition;

        internal DevComponents.DotNetBar.ButtonX ButtonX_SavePosition
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_SavePosition;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_SavePosition != null)
                {
                    _ButtonX_SavePosition.Click -= ButtonX_SavePosition_Click;
                }

                _ButtonX_SavePosition = value;
                if (_ButtonX_SavePosition != null)
                {
                    _ButtonX_SavePosition.Click += ButtonX_SavePosition_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutSpacerItem _LayoutSpacerItem1;

        internal DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutSpacerItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutSpacerItem1 != null)
                {
                }

                _LayoutSpacerItem1 = value;
                if (_LayoutSpacerItem1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem3;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem3 != null)
                {
                }

                _LayoutControlItem3 = value;
                if (_LayoutControlItem3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_RestorePosition;

        internal DevComponents.DotNetBar.ButtonX ButtonX_RestorePosition
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_RestorePosition;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_RestorePosition != null)
                {
                    _ButtonX_RestorePosition.Click -= ButtonX_RestorePosition_Click;
                }

                _ButtonX_RestorePosition = value;
                if (_ButtonX_RestorePosition != null)
                {
                    _ButtonX_RestorePosition.Click += ButtonX_RestorePosition_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem4;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem4 != null)
                {
                }

                _LayoutControlItem4 = value;
                if (_LayoutControlItem4 != null)
                {
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_PosX;

        internal DevComponents.Editors.IntegerInput IntegerInput_PosX
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_PosX;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_PosX != null)
                {
                }

                _IntegerInput_PosX = value;
                if (_IntegerInput_PosX != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem1;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem1 != null)
                {
                }

                _LayoutControlItem1 = value;
                if (_LayoutControlItem1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ImportPosFromFile;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ImportPosFromFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ImportPosFromFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ImportPosFromFile != null)
                {
                    _ButtonItem_ImportPosFromFile.Click -= ButtonItem_ImportPosFromFile_Click;
                }

                _ButtonItem_ImportPosFromFile = value;
                if (_ButtonItem_ImportPosFromFile != null)
                {
                    _ButtonItem_ImportPosFromFile.Click += ButtonItem_ImportPosFromFile_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ExportPosToFile;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ExportPosToFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ExportPosToFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ExportPosToFile != null)
                {
                    _ButtonItem_ExportPosToFile.Click -= ButtonItem_ExportPosToFile_Click;
                }

                _ButtonItem_ExportPosToFile = value;
                if (_ButtonItem_ExportPosToFile != null)
                {
                    _ButtonItem_ExportPosToFile.Click += ButtonItem_ExportPosToFile_Click;
                }
            }
        }
    }
}