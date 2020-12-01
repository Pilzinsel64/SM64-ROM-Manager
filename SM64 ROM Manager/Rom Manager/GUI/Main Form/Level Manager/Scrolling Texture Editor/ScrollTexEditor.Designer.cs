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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrollTexEditor));
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_AddNew = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Remove = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Options = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.CheckBoxItem_ViewMode_Simplified = new DevComponents.DotNetBar.CheckBoxItem();
            this.CheckBoxItem_ViewMode_Expert = new DevComponents.DotNetBar.CheckBoxItem();
            this.AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.advTree_ScrollTexList = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.columnHeader_Number = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_Material = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_Behavior = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_Type = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_Duration = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_Speed = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_VertexPointer = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_Vertices = new DevComponents.AdvTree.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree_ScrollTexList)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SplitContainer1, "SplitContainer1");
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.advTree_ScrollTexList);
            this.SplitContainer1.Panel1.Controls.Add(this.bar1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.AdvPropertyGrid1);
            // 
            // bar1
            // 
            resources.ApplyResources(this.bar1, "bar1");
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_AddNew,
            this.ButtonItem_Remove,
            this.buttonItem_Options});
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabStop = false;
            // 
            // ButtonItem_AddNew
            // 
            this.ButtonItem_AddNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_AddNew.Visible = false;
            this.ButtonItem_AddNew.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_AddNew.Name = "ButtonItem_AddNew";
            this.ButtonItem_AddNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.ButtonItem_AddNew.SubItemsExpandWidth = 14;
            this.ButtonItem_AddNew.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.ButtonItem_AddNew.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_AddNew.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem_AddNew, "ButtonItem_AddNew");
            this.ButtonItem_AddNew.Click += new System.EventHandler(this.ButtonItem44_Click);
            // 
            // ButtonItem_Remove
            // 
            this.ButtonItem_Remove.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Remove.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_Remove.Name = "ButtonItem_Remove";
            this.ButtonItem_Remove.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.ButtonItem_Remove.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonItem_Remove.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_Remove.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem_Remove, "ButtonItem_Remove");
            this.ButtonItem_Remove.Click += new System.EventHandler(this.ButtonItem43_Click);
            // 
            // buttonItem_Options
            // 
            this.buttonItem_Options.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Options.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_settings_16px;
            this.buttonItem_Options.Name = "buttonItem_Options";
            this.buttonItem_Options.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.CheckBoxItem_ViewMode_Simplified,
            this.CheckBoxItem_ViewMode_Expert});
            resources.ApplyResources(this.buttonItem_Options, "buttonItem_Options");
            // 
            // labelItem1
            // 
            this.labelItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.labelItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.PaddingBottom = 1;
            this.labelItem1.PaddingLeft = 10;
            this.labelItem1.PaddingTop = 1;
            this.labelItem1.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            resources.ApplyResources(this.labelItem1, "labelItem1");
            // 
            // CheckBoxItem_ViewMode_Simplified
            // 
            this.CheckBoxItem_ViewMode_Simplified.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.CheckBoxItem_ViewMode_Simplified.Checked = true;
            this.CheckBoxItem_ViewMode_Simplified.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxItem_ViewMode_Simplified.Name = "CheckBoxItem_ViewMode_Simplified";
            resources.ApplyResources(this.CheckBoxItem_ViewMode_Simplified, "CheckBoxItem_ViewMode_Simplified");
            this.CheckBoxItem_ViewMode_Simplified.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.CheckBoxItem_ViewMode_Simplified_CheckedChanged);
            // 
            // CheckBoxItem_ViewMode_Expert
            // 
            this.CheckBoxItem_ViewMode_Expert.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.CheckBoxItem_ViewMode_Expert.Name = "CheckBoxItem_ViewMode_Expert";
            resources.ApplyResources(this.CheckBoxItem_ViewMode_Expert, "CheckBoxItem_ViewMode_Expert");
            // 
            // AdvPropertyGrid1
            // 
            resources.ApplyResources(this.AdvPropertyGrid1, "AdvPropertyGrid1");
            this.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.AdvPropertyGrid1.Name = "AdvPropertyGrid1";
            this.AdvPropertyGrid1.ConvertPropertyValueToString += new DevComponents.DotNetBar.ConvertValueEventHandler(this.AdvPropertyGrid1_ConvertPropertyValueToString);
            this.AdvPropertyGrid1.ConvertFromStringToPropertyValue += new DevComponents.DotNetBar.ConvertValueEventHandler(this.AdvPropertyGrid1_ConvertFromStringToPropertyValue);
            this.AdvPropertyGrid1.PropertyValueChanged += new System.ComponentModel.PropertyChangedEventHandler(this.AdvPropertyGrid1_PropertyValueChanged);
            // 
            // advTree_ScrollTexList
            // 
            this.advTree_ScrollTexList.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree_ScrollTexList.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree_ScrollTexList.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree_ScrollTexList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree_ScrollTexList.Columns.Add(this.columnHeader_Number);
            this.advTree_ScrollTexList.Columns.Add(this.columnHeader_Material);
            this.advTree_ScrollTexList.Columns.Add(this.columnHeader_Behavior);
            this.advTree_ScrollTexList.Columns.Add(this.columnHeader_Type);
            this.advTree_ScrollTexList.Columns.Add(this.columnHeader_Duration);
            this.advTree_ScrollTexList.Columns.Add(this.columnHeader_Speed);
            this.advTree_ScrollTexList.Columns.Add(this.columnHeader_VertexPointer);
            this.advTree_ScrollTexList.Columns.Add(this.columnHeader_Vertices);
            resources.ApplyResources(this.advTree_ScrollTexList, "advTree_ScrollTexList");
            this.advTree_ScrollTexList.DragDropEnabled = false;
            this.advTree_ScrollTexList.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree_ScrollTexList.MultiSelect = true;
            this.advTree_ScrollTexList.Name = "advTree_ScrollTexList";
            this.advTree_ScrollTexList.NodesConnector = this.nodeConnector1;
            this.advTree_ScrollTexList.NodeStyle = this.elementStyle1;
            this.advTree_ScrollTexList.PathSeparator = ";";
            this.advTree_ScrollTexList.Styles.Add(this.elementStyle1);
            this.advTree_ScrollTexList.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree_ScrollTexList_AfterNodeSelect);
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
            // columnHeader_Number
            // 
            this.columnHeader_Number.Name = "columnHeader_Number";
            resources.ApplyResources(this.columnHeader_Number, "columnHeader_Number");
            this.columnHeader_Number.Width.Absolute = 60;
            // 
            // columnHeader_Material
            // 
            this.columnHeader_Material.Name = "columnHeader_Material";
            resources.ApplyResources(this.columnHeader_Material, "columnHeader_Material");
            this.columnHeader_Material.Width.Absolute = 100;
            // 
            // columnHeader_Behavior
            // 
            this.columnHeader_Behavior.Name = "columnHeader_Behavior";
            resources.ApplyResources(this.columnHeader_Behavior, "columnHeader_Behavior");
            this.columnHeader_Behavior.Width.Absolute = 100;
            // 
            // columnHeader_Type
            // 
            this.columnHeader_Type.Name = "columnHeader_Type";
            resources.ApplyResources(this.columnHeader_Type, "columnHeader_Type");
            this.columnHeader_Type.Width.Absolute = 100;
            // 
            // columnHeader_Duration
            // 
            this.columnHeader_Duration.Name = "columnHeader_Duration";
            resources.ApplyResources(this.columnHeader_Duration, "columnHeader_Duration");
            this.columnHeader_Duration.Width.Absolute = 60;
            // 
            // columnHeader_Speed
            // 
            this.columnHeader_Speed.Name = "columnHeader_Speed";
            resources.ApplyResources(this.columnHeader_Speed, "columnHeader_Speed");
            this.columnHeader_Speed.Width.Absolute = 60;
            // 
            // columnHeader_VertexPointer
            // 
            this.columnHeader_VertexPointer.Name = "columnHeader_VertexPointer";
            resources.ApplyResources(this.columnHeader_VertexPointer, "columnHeader_VertexPointer");
            this.columnHeader_VertexPointer.Width.Absolute = 100;
            // 
            // columnHeader_Vertices
            // 
            this.columnHeader_Vertices.Name = "columnHeader_Vertices";
            resources.ApplyResources(this.columnHeader_Vertices, "columnHeader_Vertices");
            this.columnHeader_Vertices.Width.Absolute = 100;
            // 
            // ScrollTexEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScrollTexEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrollTexEditor_FormClosing);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree_ScrollTexList)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.AdvPropertyGrid AdvPropertyGrid1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_AddNew;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_Remove;

        private SplitContainer SplitContainer1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Options;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.CheckBoxItem CheckBoxItem_ViewMode_Simplified;
        private DevComponents.DotNetBar.CheckBoxItem CheckBoxItem_ViewMode_Expert;
        private DevComponents.AdvTree.AdvTree advTree_ScrollTexList;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Number;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Material;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Behavior;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Type;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Duration;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Speed;
        private DevComponents.AdvTree.ColumnHeader columnHeader_VertexPointer;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Vertices;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}