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
            this.ListViewEx_LM_ScrollTexList = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.ColumnHeader_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MaterialName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Behavior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_VertexPointer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Vertices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.ButtonItem44 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem43 = new DevComponents.DotNetBar.ButtonItem();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.CheckBoxItem_ViewMode_Simplified = new DevComponents.DotNetBar.CheckBoxItem();
            this.CheckBoxItem_ViewMode_Expert = new DevComponents.DotNetBar.CheckBoxItem();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
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
            this.ListViewEx_LM_ScrollTexList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewEx_LM_ScrollTexList.FocusCuesEnabled = false;
            this.ListViewEx_LM_ScrollTexList.ForeColor = System.Drawing.Color.Black;
            this.ListViewEx_LM_ScrollTexList.FullRowSelect = true;
            this.ListViewEx_LM_ScrollTexList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewEx_LM_ScrollTexList.HideSelection = false;
            this.ListViewEx_LM_ScrollTexList.Location = new System.Drawing.Point(0, 24);
            this.ListViewEx_LM_ScrollTexList.MultiSelect = false;
            this.ListViewEx_LM_ScrollTexList.Name = "ListViewEx_LM_ScrollTexList";
            this.ListViewEx_LM_ScrollTexList.Size = new System.Drawing.Size(583, 609);
            this.ListViewEx_LM_ScrollTexList.TabIndex = 2;
            this.ListViewEx_LM_ScrollTexList.UseCompatibleStateImageBehavior = false;
            this.ListViewEx_LM_ScrollTexList.View = System.Windows.Forms.View.Details;
            this.ListViewEx_LM_ScrollTexList.SelectedIndexChanged += new System.EventHandler(this.ListViewEx_LM_ScrollTexList_SelectedIndexChanged);
            this.ListViewEx_LM_ScrollTexList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListViewEx_LM_ScrollTexList_MouseClick);
            // 
            // ColumnHeader_Number
            // 
            this.ColumnHeader_Number.Text = "#";
            this.ColumnHeader_Number.Width = 30;
            // 
            // columnHeader_MaterialName
            // 
            this.columnHeader_MaterialName.Text = "Material";
            this.columnHeader_MaterialName.Width = 100;
            // 
            // ColumnHeader_Behavior
            // 
            this.ColumnHeader_Behavior.Text = "Behavior";
            this.ColumnHeader_Behavior.Width = 100;
            // 
            // ColumnHeader_Type
            // 
            this.ColumnHeader_Type.Text = "Type";
            this.ColumnHeader_Type.Width = 100;
            // 
            // ColumnHeader_Duration
            // 
            this.ColumnHeader_Duration.Text = "Duration";
            // 
            // ColumnHeader_Speed
            // 
            this.ColumnHeader_Speed.Text = "Speed";
            // 
            // ColumnHeader_VertexPointer
            // 
            this.ColumnHeader_VertexPointer.Text = "Vertex Pointer";
            this.ColumnHeader_VertexPointer.Width = 100;
            // 
            // ColumnHeader_Vertices
            // 
            this.ColumnHeader_Vertices.Text = "Vertices";
            this.ColumnHeader_Vertices.Width = 100;
            // 
            // AdvPropertyGrid1
            // 
            this.AdvPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.AdvPropertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.AdvPropertyGrid1.Name = "AdvPropertyGrid1";
            this.AdvPropertyGrid1.Size = new System.Drawing.Size(315, 633);
            this.AdvPropertyGrid1.TabIndex = 8;
            this.AdvPropertyGrid1.Text = "AdvPropertyGrid1";
            this.AdvPropertyGrid1.ConvertPropertyValueToString += new DevComponents.DotNetBar.ConvertValueEventHandler(this.AdvPropertyGrid1_ConvertPropertyValueToString);
            this.AdvPropertyGrid1.ConvertFromStringToPropertyValue += new DevComponents.DotNetBar.ConvertValueEventHandler(this.AdvPropertyGrid1_ConvertFromStringToPropertyValue);
            this.AdvPropertyGrid1.PropertyValueChanged += new System.ComponentModel.PropertyChangedEventHandler(this.AdvPropertyGrid1_PropertyValueChanged);
            this.AdvPropertyGrid1.PropertiesLoaded += new System.EventHandler(this.AdvPropertyGrid1_PropertiesLoaded);
            this.AdvPropertyGrid1.Click += new System.EventHandler(this.AdvPropertyGrid1_Click);
            // 
            // ButtonItem44
            // 
            this.ButtonItem44.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem44.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem44.Name = "ButtonItem44";
            this.ButtonItem44.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.ButtonItem44.SubItemsExpandWidth = 14;
            this.ButtonItem44.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.ButtonItem44.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem44.SymbolSize = 12F;
            this.ButtonItem44.Text = "Add New";
            this.ButtonItem44.Click += new System.EventHandler(this.ButtonItem44_Click);
            // 
            // ButtonItem43
            // 
            this.ButtonItem43.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem43.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem43.Name = "ButtonItem43";
            this.ButtonItem43.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.ButtonItem43.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonItem43.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem43.SymbolSize = 12F;
            this.ButtonItem43.Text = "Remove";
            this.ButtonItem43.Click += new System.EventHandler(this.ButtonItem43_Click);
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.SplitContainer1.Size = new System.Drawing.Size(902, 633);
            this.SplitContainer1.SplitterDistance = 583;
            this.SplitContainer1.TabIndex = 9;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem44,
            this.ButtonItem43,
            this.buttonItem1});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(583, 24);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 3;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_settings_16px;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.CheckBoxItem_ViewMode_Simplified,
            this.CheckBoxItem_ViewMode_Expert});
            this.buttonItem1.Text = "Options";
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
            this.labelItem1.Text = "View mode:";
            // 
            // CheckBoxItem_ViewMode_Simplified
            // 
            this.CheckBoxItem_ViewMode_Simplified.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.CheckBoxItem_ViewMode_Simplified.Checked = true;
            this.CheckBoxItem_ViewMode_Simplified.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxItem_ViewMode_Simplified.Name = "CheckBoxItem_ViewMode_Simplified";
            this.CheckBoxItem_ViewMode_Simplified.Text = "Simplified";
            this.CheckBoxItem_ViewMode_Simplified.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.CheckBoxItem_ViewMode_Simplified_CheckedChanged);
            // 
            // CheckBoxItem_ViewMode_Expert
            // 
            this.CheckBoxItem_ViewMode_Expert.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.CheckBoxItem_ViewMode_Expert.Name = "CheckBoxItem_ViewMode_Expert";
            this.CheckBoxItem_ViewMode_Expert.Text = "Expert";
            // 
            // ScrollTexEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 633);
            this.Controls.Add(this.SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScrollTexEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texture Animation Editor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).EndInit();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
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

        private DevComponents.DotNetBar.ButtonItem ButtonItem44;

        private DevComponents.DotNetBar.ButtonItem ButtonItem43;

        private SplitContainer SplitContainer1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.CheckBoxItem CheckBoxItem_ViewMode_Simplified;
        private DevComponents.DotNetBar.CheckBoxItem CheckBoxItem_ViewMode_Expert;
        private ColumnHeader columnHeader_MaterialName;
    }
}