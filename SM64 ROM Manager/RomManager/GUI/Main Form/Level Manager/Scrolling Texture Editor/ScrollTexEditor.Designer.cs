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
            this.ListViewEx_LM_ScrollTexList = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.ColumnHeader_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MaterialName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Behavior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_VertexPointer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Vertices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_AddNew = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Remove = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Options = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.CheckBoxItem_ViewMode_Simplified = new DevComponents.DotNetBar.CheckBoxItem();
            this.CheckBoxItem_ViewMode_Expert = new DevComponents.DotNetBar.CheckBoxItem();
            this.AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).BeginInit();
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
            this.SplitContainer1.Panel1.Controls.Add(this.ListViewEx_LM_ScrollTexList);
            this.SplitContainer1.Panel1.Controls.Add(this.bar1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.AdvPropertyGrid1);
            // 
            // ListViewEx_LM_ScrollTexList
            // 
            this.ListViewEx_LM_ScrollTexList.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ListViewEx_LM_ScrollTexList.Border.Class = "ListViewBorder";
            this.ListViewEx_LM_ScrollTexList.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListViewEx_LM_ScrollTexList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_Number,
            this.columnHeader_MaterialName,
            this.ColumnHeader_Behavior,
            this.ColumnHeader_Type,
            this.ColumnHeader_Duration,
            this.ColumnHeader_Speed,
            this.ColumnHeader_VertexPointer,
            this.ColumnHeader_Vertices});
            this.ListViewEx_LM_ScrollTexList.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.ListViewEx_LM_ScrollTexList, "ListViewEx_LM_ScrollTexList");
            this.ListViewEx_LM_ScrollTexList.FocusCuesEnabled = false;
            this.ListViewEx_LM_ScrollTexList.ForeColor = System.Drawing.Color.Black;
            this.ListViewEx_LM_ScrollTexList.FullRowSelect = true;
            this.ListViewEx_LM_ScrollTexList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewEx_LM_ScrollTexList.HideSelection = false;
            this.ListViewEx_LM_ScrollTexList.MultiSelect = false;
            this.ListViewEx_LM_ScrollTexList.Name = "ListViewEx_LM_ScrollTexList";
            this.ListViewEx_LM_ScrollTexList.UseCompatibleStateImageBehavior = false;
            this.ListViewEx_LM_ScrollTexList.View = System.Windows.Forms.View.Details;
            this.ListViewEx_LM_ScrollTexList.SelectedIndexChanged += new System.EventHandler(this.ListViewEx_LM_ScrollTexList_SelectedIndexChanged);
            // 
            // ColumnHeader_Number
            // 
            resources.ApplyResources(this.ColumnHeader_Number, "ColumnHeader_Number");
            // 
            // columnHeader_MaterialName
            // 
            resources.ApplyResources(this.columnHeader_MaterialName, "columnHeader_MaterialName");
            // 
            // ColumnHeader_Behavior
            // 
            resources.ApplyResources(this.ColumnHeader_Behavior, "ColumnHeader_Behavior");
            // 
            // ColumnHeader_Type
            // 
            resources.ApplyResources(this.ColumnHeader_Type, "ColumnHeader_Type");
            // 
            // ColumnHeader_Duration
            // 
            resources.ApplyResources(this.ColumnHeader_Duration, "ColumnHeader_Duration");
            // 
            // ColumnHeader_Speed
            // 
            resources.ApplyResources(this.ColumnHeader_Speed, "ColumnHeader_Speed");
            // 
            // ColumnHeader_VertexPointer
            // 
            resources.ApplyResources(this.ColumnHeader_VertexPointer, "ColumnHeader_VertexPointer");
            // 
            // ColumnHeader_Vertices
            // 
            resources.ApplyResources(this.ColumnHeader_Vertices, "ColumnHeader_Vertices");
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
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_LM_ScrollTexList;

        private ColumnHeader ColumnHeader_Number;

        private ColumnHeader ColumnHeader_Behavior;

        private ColumnHeader ColumnHeader_Type;

        private ColumnHeader ColumnHeader_Duration;

        private ColumnHeader ColumnHeader_Speed;

        private DevComponents.DotNetBar.AdvPropertyGrid AdvPropertyGrid1;

        private ColumnHeader ColumnHeader_VertexPointer;

        private ColumnHeader ColumnHeader_Vertices;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_AddNew;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_Remove;

        private SplitContainer SplitContainer1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Options;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.CheckBoxItem CheckBoxItem_ViewMode_Simplified;
        private DevComponents.DotNetBar.CheckBoxItem CheckBoxItem_ViewMode_Expert;
        private ColumnHeader columnHeader_MaterialName;
    }
}