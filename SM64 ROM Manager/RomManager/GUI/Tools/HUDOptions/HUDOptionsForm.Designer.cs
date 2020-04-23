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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HUDOptionsForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TabControl1 = new DevComponents.DotNetBar.TabControl();
            this.TabControlPanel_Positions = new DevComponents.DotNetBar.TabControlPanel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.AdvTree1 = new DevComponents.AdvTree.AdvTree();
            this.Node1 = new DevComponents.AdvTree.Node();
            this.NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.IntegerInput_PosX = new DevComponents.Editors.IntegerInput();
            this.IntegerInput_PosY = new DevComponents.Editors.IntegerInput();
            this.ButtonX_SavePosition = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_RestorePosition = new DevComponents.DotNetBar.ButtonX();
            this.LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.TabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.Bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImportPosFromFile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ExportPosToFile = new DevComponents.DotNetBar.ButtonItem();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabControlPanel_Positions.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).BeginInit();
            this.LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_PosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_PosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.TabControl1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 24);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(508, 426);
            this.Panel1.TabIndex = 0;
            // 
            // TabControl1
            // 
            this.TabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabControl1.CanReorderTabs = true;
            this.TabControl1.Controls.Add(this.TabControlPanel_Positions);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.ForeColor = System.Drawing.Color.Black;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabControl1.SelectedTabIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(508, 426);
            this.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.TabControl1.TabIndex = 0;
            this.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.TabControl1.Tabs.Add(this.TabItem1);
            // 
            // TabControlPanel_Positions
            // 
            this.TabControlPanel_Positions.Controls.Add(this.Panel2);
            this.TabControlPanel_Positions.DisabledBackColor = System.Drawing.Color.Empty;
            this.TabControlPanel_Positions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPanel_Positions.Location = new System.Drawing.Point(0, 27);
            this.TabControlPanel_Positions.Name = "TabControlPanel_Positions";
            this.TabControlPanel_Positions.Padding = new System.Windows.Forms.Padding(1);
            this.TabControlPanel_Positions.Size = new System.Drawing.Size(508, 399);
            this.TabControlPanel_Positions.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.TabControlPanel_Positions.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.TabControlPanel_Positions.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TabControlPanel_Positions.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.TabControlPanel_Positions.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.TabControlPanel_Positions.Style.GradientAngle = 90;
            this.TabControlPanel_Positions.TabIndex = 1;
            this.TabControlPanel_Positions.TabItem = this.TabItem1;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.AdvTree1);
            this.Panel2.Controls.Add(this.LayoutControl1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(1, 1);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(506, 397);
            this.Panel2.TabIndex = 1;
            // 
            // AdvTree1
            // 
            this.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree1.Location = new System.Drawing.Point(0, 0);
            this.AdvTree1.Name = "AdvTree1";
            this.AdvTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.Node1});
            this.AdvTree1.NodesConnector = this.NodeConnector1;
            this.AdvTree1.NodeStyle = this.ElementStyle1;
            this.AdvTree1.PathSeparator = ";";
            this.AdvTree1.Size = new System.Drawing.Size(312, 397);
            this.AdvTree1.Styles.Add(this.ElementStyle1);
            this.AdvTree1.TabIndex = 0;
            this.AdvTree1.Text = "AdvTree1";
            this.AdvTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree1_AfterNodeSelect);
            // 
            // Node1
            // 
            this.Node1.Expanded = true;
            this.Node1.Name = "Node1";
            this.Node1.Text = "Node1";
            // 
            // NodeConnector1
            // 
            this.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // ElementStyle1
            // 
            this.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ElementStyle1.Name = "ElementStyle1";
            this.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.Controls.Add(this.IntegerInput_PosX);
            this.LayoutControl1.Controls.Add(this.IntegerInput_PosY);
            this.LayoutControl1.Controls.Add(this.ButtonX_SavePosition);
            this.LayoutControl1.Controls.Add(this.ButtonX_RestorePosition);
            this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.LayoutControl1.Location = new System.Drawing.Point(312, 0);
            this.LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            this.LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem1,
            this.LayoutControlItem2,
            this.LayoutSpacerItem1,
            this.LayoutControlItem4,
            this.LayoutControlItem3});
            this.LayoutControl1.Size = new System.Drawing.Size(194, 397);
            this.LayoutControl1.TabIndex = 1;
            // 
            // IntegerInput_PosX
            // 
            // 
            // 
            // 
            this.IntegerInput_PosX.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_PosX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_PosX.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput_PosX.Location = new System.Drawing.Point(22, 4);
            this.IntegerInput_PosX.Margin = new System.Windows.Forms.Padding(0);
            this.IntegerInput_PosX.Name = "IntegerInput_PosX";
            this.IntegerInput_PosX.ShowUpDown = true;
            this.IntegerInput_PosX.Size = new System.Drawing.Size(168, 20);
            this.IntegerInput_PosX.TabIndex = 0;
            // 
            // IntegerInput_PosY
            // 
            // 
            // 
            // 
            this.IntegerInput_PosY.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_PosY.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_PosY.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput_PosY.Location = new System.Drawing.Point(22, 32);
            this.IntegerInput_PosY.Margin = new System.Windows.Forms.Padding(0);
            this.IntegerInput_PosY.Name = "IntegerInput_PosY";
            this.IntegerInput_PosY.ShowUpDown = true;
            this.IntegerInput_PosY.Size = new System.Drawing.Size(168, 20);
            this.IntegerInput_PosY.TabIndex = 1;
            // 
            // ButtonX_SavePosition
            // 
            this.ButtonX_SavePosition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_SavePosition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_SavePosition.Location = new System.Drawing.Point(115, 60);
            this.ButtonX_SavePosition.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_SavePosition.Name = "ButtonX_SavePosition";
            this.ButtonX_SavePosition.Size = new System.Drawing.Size(75, 24);
            this.ButtonX_SavePosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_SavePosition.TabIndex = 4;
            this.ButtonX_SavePosition.Text = "Save";
            this.ButtonX_SavePosition.Click += new System.EventHandler(this.ButtonX_SavePosition_Click);
            // 
            // ButtonX_RestorePosition
            // 
            this.ButtonX_RestorePosition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_RestorePosition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_RestorePosition.Location = new System.Drawing.Point(32, 60);
            this.ButtonX_RestorePosition.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_RestorePosition.Name = "ButtonX_RestorePosition";
            this.ButtonX_RestorePosition.Size = new System.Drawing.Size(75, 24);
            this.ButtonX_RestorePosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_RestorePosition.TabIndex = 3;
            this.ButtonX_RestorePosition.Text = "Restore";
            this.ButtonX_RestorePosition.Click += new System.EventHandler(this.ButtonX_RestorePosition_Click);
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.IntegerInput_PosX;
            this.LayoutControlItem1.Height = 28;
            this.LayoutControlItem1.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            this.LayoutControlItem1.Text = "X:";
            this.LayoutControlItem1.Width = 100;
            this.LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.IntegerInput_PosY;
            this.LayoutControlItem2.Height = 28;
            this.LayoutControlItem2.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            this.LayoutControlItem2.Text = "Y:";
            this.LayoutControlItem2.Width = 100;
            this.LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            this.LayoutSpacerItem1.Height = 32;
            this.LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            this.LayoutSpacerItem1.Width = 99;
            this.LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.ButtonX_RestorePosition;
            this.LayoutControlItem4.Height = 32;
            this.LayoutControlItem4.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            this.LayoutControlItem4.Width = 83;
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.ButtonX_SavePosition;
            this.LayoutControlItem3.Height = 31;
            this.LayoutControlItem3.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            this.LayoutControlItem3.Width = 83;
            // 
            // TabItem1
            // 
            this.TabItem1.AttachedControl = this.TabControlPanel_Positions;
            this.TabItem1.Name = "TabItem1";
            this.TabItem1.Text = "Positions";
            // 
            // Bar1
            // 
            this.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)";
            this.Bar1.AccessibleName = "DotNetBar Bar";
            this.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Bar1.AntiAlias = true;
            this.Bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.Bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Bar1.IsMaximized = false;
            this.Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem1});
            this.Bar1.Location = new System.Drawing.Point(0, 0);
            this.Bar1.MenuBar = true;
            this.Bar1.Name = "Bar1";
            this.Bar1.Size = new System.Drawing.Size(508, 24);
            this.Bar1.Stretch = true;
            this.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar1.TabIndex = 1;
            this.Bar1.TabStop = false;
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.Name = "ButtonItem1";
            this.ButtonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ImportPosFromFile,
            this.ButtonItem_ExportPosToFile});
            this.ButtonItem1.Text = "Positions";
            // 
            // ButtonItem_ImportPosFromFile
            // 
            this.ButtonItem_ImportPosFromFile.Name = "ButtonItem_ImportPosFromFile";
            this.ButtonItem_ImportPosFromFile.Text = "Import from file ...";
            this.ButtonItem_ImportPosFromFile.Click += new System.EventHandler(this.ButtonItem_ImportPosFromFile_Click);
            // 
            // ButtonItem_ExportPosToFile
            // 
            this.ButtonItem_ExportPosToFile.Name = "ButtonItem_ExportPosToFile";
            this.ButtonItem_ExportPosToFile.Text = "Export to file ...";
            this.ButtonItem_ExportPosToFile.Click += new System.EventHandler(this.ButtonItem_ExportPosToFile_Click);
            // 
            // HUDOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Bar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HUDOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HUD Options";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabControlPanel_Positions.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).EndInit();
            this.LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_PosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_PosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel Panel1;

        private DevComponents.DotNetBar.TabControl TabControl1;

        private DevComponents.DotNetBar.TabControlPanel TabControlPanel_Positions;

        private DevComponents.DotNetBar.TabItem TabItem1;

        private DevComponents.DotNetBar.Bar Bar1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem1;

        private Panel Panel2;

        private DevComponents.AdvTree.AdvTree AdvTree1;

        private DevComponents.AdvTree.Node Node1;

        private DevComponents.AdvTree.NodeConnector NodeConnector1;

        private DevComponents.DotNetBar.ElementStyle ElementStyle1;

        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;

        private DevComponents.Editors.IntegerInput IntegerInput_PosY;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;

        private DevComponents.DotNetBar.ButtonX ButtonX_SavePosition;

        private DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;

        private DevComponents.DotNetBar.ButtonX ButtonX_RestorePosition;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4;

        private DevComponents.Editors.IntegerInput IntegerInput_PosX;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportPosFromFile;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ExportPosToFile;

    }
}