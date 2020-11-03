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
            this.ListViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_SaveRom = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.ListViewEx1);
            this.Panel1.Controls.Add(this.Bar1);
            this.Panel1.Controls.Add(this.AdvPropertyGrid1);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // ListViewEx1
            // 
            this.ListViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ListViewEx1.Border.Class = "ListViewBorder";
            this.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.ListViewEx1, "ListViewEx1");
            this.ListViewEx1.FocusCuesEnabled = false;
            this.ListViewEx1.ForeColor = System.Drawing.Color.Black;
            this.ListViewEx1.FullRowSelect = true;
            this.ListViewEx1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewEx1.HideSelection = false;
            this.ListViewEx1.Name = "ListViewEx1";
            this.ListViewEx1.UseCompatibleStateImageBehavior = false;
            this.ListViewEx1.View = System.Windows.Forms.View.Details;
            this.ListViewEx1.SelectedIndexChanged += new System.EventHandler(this.ListViewEx1_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            resources.ApplyResources(this.ColumnHeader1, "ColumnHeader1");
            // 
            // ColumnHeader2
            // 
            resources.ApplyResources(this.ColumnHeader2, "ColumnHeader2");
            // 
            // ColumnHeader3
            // 
            resources.ApplyResources(this.ColumnHeader3, "ColumnHeader3");
            // 
            // ColumnHeader4
            // 
            resources.ApplyResources(this.ColumnHeader4, "ColumnHeader4");
            // 
            // ColumnHeader5
            // 
            resources.ApplyResources(this.ColumnHeader5, "ColumnHeader5");
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
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.ListViewEx ListViewEx1;

        private DevComponents.DotNetBar.Bar Bar1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem1;

        private DevComponents.DotNetBar.AdvPropertyGrid AdvPropertyGrid1;

        private ColumnHeader ColumnHeader1;

        private ColumnHeader ColumnHeader2;

        private ColumnHeader ColumnHeader3;

        private ColumnHeader ColumnHeader4;

        private ColumnHeader ColumnHeader5;

        private DevComponents.DotNetBar.ButtonItem ButtonItem2;

        private DevComponents.DotNetBar.ButtonItem ButtonItem3;

        private DevComponents.DotNetBar.ButtonItem ButtonItem4;

        private DevComponents.DotNetBar.ButtonItem ButtonItem5;

        private Panel Panel1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_SaveRom;

        private DevComponents.DotNetBar.ButtonItem ButtonItem6;

    }
}