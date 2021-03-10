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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemBoxContentEditor));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_SaveRom = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.columnHeader10 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader9 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader8 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader7 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader6 = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.advTree1);
            this.Panel1.Controls.Add(this.Bar1);
            this.Panel1.Controls.Add(this.AdvPropertyGrid1);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // Bar1
            // 
            this.Bar1.AntiAlias = true;
            resources.ApplyResources(this.Bar1, "Bar1");
            this.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.Bar1.IsMaximized = false;
            this.Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_SaveRom,
            this.ButtonItem6,
            this.ButtonItem1,
            this.ButtonItem2,
            this.ButtonItem3,
            this.ButtonItem4,
            this.ButtonItem5});
            this.Bar1.Name = "Bar1";
            this.Bar1.Stretch = true;
            this.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar1.TabStop = false;
            // 
            // ButtonItem_SaveRom
            // 
            this.ButtonItem_SaveRom.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_SaveRom.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_save_16px;
            this.ButtonItem_SaveRom.Name = "ButtonItem_SaveRom";
            this.ButtonItem_SaveRom.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.ButtonItem_SaveRom.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.ButtonItem_SaveRom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_SaveRom.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem_SaveRom, "ButtonItem_SaveRom");
            this.ButtonItem_SaveRom.Click += new System.EventHandler(this.ButtonItem_SaveRom_Click);
            // 
            // ButtonItem6
            // 
            this.ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem6.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_refresh_16px;
            this.ButtonItem6.Name = "ButtonItem6";
            this.ButtonItem6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem6.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem6, "ButtonItem6");
            this.ButtonItem6.Click += new System.EventHandler(this.ButtonItem6_Click);
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.BeginGroup = true;
            this.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem1.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem1.Name = "ButtonItem1";
            this.ButtonItem1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.ButtonItem1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem1.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem1, "ButtonItem1");
            this.ButtonItem1.Click += new System.EventHandler(this.ButtonItem1_Click);
            // 
            // ButtonItem2
            // 
            this.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem2.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem2.Name = "ButtonItem2";
            this.ButtonItem2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonItem2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem2.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem2, "ButtonItem2");
            this.ButtonItem2.Click += new System.EventHandler(this.ButtonItem2_Click);
            // 
            // ButtonItem3
            // 
            this.ButtonItem3.BeginGroup = true;
            this.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem3.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_undo_16px;
            this.ButtonItem3.Name = "ButtonItem3";
            this.ButtonItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem3.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem3, "ButtonItem3");
            this.ButtonItem3.Click += new System.EventHandler(this.ButtonItem3_Click);
            // 
            // ButtonItem4
            // 
            this.ButtonItem4.BeginGroup = true;
            this.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem4.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_import_16px;
            this.ButtonItem4.Name = "ButtonItem4";
            this.ButtonItem4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem4.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem4, "ButtonItem4");
            this.ButtonItem4.Click += new System.EventHandler(this.ButtonItem4_Click);
            // 
            // ButtonItem5
            // 
            this.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem5.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_export_16px;
            this.ButtonItem5.Name = "ButtonItem5";
            this.ButtonItem5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem5.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem5, "ButtonItem5");
            this.ButtonItem5.Click += new System.EventHandler(this.ButtonItem5_Click);
            // 
            // AdvPropertyGrid1
            // 
            resources.ApplyResources(this.AdvPropertyGrid1, "AdvPropertyGrid1");
            this.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.AdvPropertyGrid1.Name = "AdvPropertyGrid1";
            this.AdvPropertyGrid1.PropertyValueChanged += new System.ComponentModel.PropertyChangedEventHandler(this.AdvPropertyGrid1_PropertyValueChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Name = "columnHeader10";
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            this.columnHeader10.Width.Absolute = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Name = "columnHeader9";
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            this.columnHeader9.Width.Absolute = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Name = "columnHeader8";
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            this.columnHeader8.Width.Absolute = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = "columnHeader7";
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            this.columnHeader7.Width.Absolute = 60;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            this.columnHeader6.Width.Absolute = 40;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Columns.Add(this.columnHeader6);
            this.advTree1.Columns.Add(this.columnHeader7);
            this.advTree1.Columns.Add(this.columnHeader8);
            this.advTree1.Columns.Add(this.columnHeader9);
            this.advTree1.Columns.Add(this.columnHeader10);
            resources.ApplyResources(this.advTree1, "advTree1");
            this.advTree1.DragDropEnabled = false;
            this.advTree1.ExpandWidth = 0;
            this.advTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree1.MultiSelect = true;
            this.advTree1.Name = "advTree1";
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.advTree1_AfterNodeSelect);
            // 
            // ItemBoxContentEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Name = "ItemBoxContentEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemBoxContentEditor_FormClosing);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Bar Bar1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem1;

        private DevComponents.DotNetBar.AdvPropertyGrid AdvPropertyGrid1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem2;

        private DevComponents.DotNetBar.ButtonItem ButtonItem3;

        private DevComponents.DotNetBar.ButtonItem ButtonItem4;

        private DevComponents.DotNetBar.ButtonItem ButtonItem5;

        private Panel Panel1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_SaveRom;

        private DevComponents.DotNetBar.ButtonItem ButtonItem6;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.ColumnHeader columnHeader6;
        private DevComponents.AdvTree.ColumnHeader columnHeader7;
        private DevComponents.AdvTree.ColumnHeader columnHeader8;
        private DevComponents.AdvTree.ColumnHeader columnHeader9;
        private DevComponents.AdvTree.ColumnHeader columnHeader10;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}