using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.LevelEditor
{
    [DesignerGenerated()]
    public partial class TextureEditor : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureEditor));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_Textures = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.SideBar1 = new DevComponents.DotNetBar.SideBar();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PictureBox_CurImage = new System.Windows.Forms.PictureBox();
            this.AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.Highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ExpTex = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImpTex = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.Panel1.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CurImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.FlowLayoutPanel_Textures);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(684, 561);
            this.Panel1.TabIndex = 0;
            // 
            // FlowLayoutPanel_Textures
            // 
            this.FlowLayoutPanel_Textures.AutoScroll = true;
            this.FlowLayoutPanel_Textures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_Textures.Location = new System.Drawing.Point(200, 0);
            this.FlowLayoutPanel_Textures.Name = "FlowLayoutPanel_Textures";
            this.FlowLayoutPanel_Textures.Size = new System.Drawing.Size(484, 561);
            this.FlowLayoutPanel_Textures.TabIndex = 6;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.SideBar1);
            this.Panel4.Controls.Add(this.Panel2);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(200, 561);
            this.Panel4.TabIndex = 1;
            // 
            // SideBar1
            // 
            this.SideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.SideBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None;
            this.SideBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBar1.ExpandedPanel = null;
            this.SideBar1.ForeColor = System.Drawing.Color.Black;
            this.SideBar1.Location = new System.Drawing.Point(0, 0);
            this.SideBar1.Name = "SideBar1";
            this.SideBar1.Size = new System.Drawing.Size(200, 231);
            this.SideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SideBar1.TabIndex = 0;
            this.SideBar1.Text = "SideBar1";
            this.SideBar1.UsingSystemColors = true;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.PictureBox_CurImage);
            this.Panel2.Controls.Add(this.AdvPropertyGrid1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 231);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(200, 330);
            this.Panel2.TabIndex = 2;
            // 
            // PictureBox_CurImage
            // 
            this.PictureBox_CurImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_CurImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_CurImage.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_CurImage.Name = "PictureBox_CurImage";
            this.PictureBox_CurImage.Size = new System.Drawing.Size(200, 178);
            this.PictureBox_CurImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_CurImage.TabIndex = 1;
            this.PictureBox_CurImage.TabStop = false;
            this.PictureBox_CurImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            // 
            // AdvPropertyGrid1
            // 
            this.AdvPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.AdvPropertyGrid1.Location = new System.Drawing.Point(0, 178);
            this.AdvPropertyGrid1.Name = "AdvPropertyGrid1";
            this.AdvPropertyGrid1.PropertySort = DevComponents.DotNetBar.ePropertySort.Alphabetical;
            this.AdvPropertyGrid1.SearchBoxVisible = false;
            this.AdvPropertyGrid1.Size = new System.Drawing.Size(200, 152);
            this.AdvPropertyGrid1.TabIndex = 1;
            this.AdvPropertyGrid1.Text = "AdvPropertyGrid1";
            this.AdvPropertyGrid1.ToolbarVisible = false;
            // 
            // Highlighter1
            // 
            this.Highlighter1.ContainerControl = this;
            this.Highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // ContextMenuBar1
            // 
            this.ContextMenuBar1.AntiAlias = true;
            this.ContextMenuBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ContextMenuBar1.IsMaximized = false;
            this.ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem1,
            this.ButtonItem2});
            this.ContextMenuBar1.Location = new System.Drawing.Point(415, 0);
            this.ContextMenuBar1.Name = "ContextMenuBar1";
            this.ContextMenuBar1.Size = new System.Drawing.Size(206, 25);
            this.ContextMenuBar1.Stretch = true;
            this.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ContextMenuBar1.TabIndex = 1;
            this.ContextMenuBar1.TabStop = false;
            this.ContextMenuBar1.Text = "ContextMenuBar1";
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.AutoExpandOnClick = true;
            this.ButtonItem1.Name = "ButtonItem1";
            this.ButtonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ExpTex,
            this.ButtonItem_ImpTex});
            this.ButtonItem1.Text = "CM_PictureBox";
            // 
            // ButtonItem_ExpTex
            // 
            this.ButtonItem_ExpTex.Name = "ButtonItem_ExpTex";
            this.ButtonItem_ExpTex.Text = "Export Texture ...";
            this.ButtonItem_ExpTex.Click += new System.EventHandler(this.ButtonItem_ExpTex_Click);
            // 
            // ButtonItem_ImpTex
            // 
            this.ButtonItem_ImpTex.Name = "ButtonItem_ImpTex";
            this.ButtonItem_ImpTex.Text = "Import Texture ...";
            this.ButtonItem_ImpTex.Click += new System.EventHandler(this.ButtonItem_ImpTex_Click);
            // 
            // ButtonItem2
            // 
            this.ButtonItem2.AutoExpandOnClick = true;
            this.ButtonItem2.Name = "ButtonItem2";
            this.ButtonItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem3,
            this.ButtonItem4});
            this.ButtonItem2.Text = "CM_Block";
            // 
            // ButtonItem3
            // 
            this.ButtonItem3.Name = "ButtonItem3";
            this.ButtonItem3.Text = "Export Textures ...";
            this.ButtonItem3.Click += new System.EventHandler(this.ButtonItem3_Click);
            // 
            // ButtonItem4
            // 
            this.ButtonItem4.Name = "ButtonItem4";
            this.ButtonItem4.Text = "Import Textures ...";
            this.ButtonItem4.Click += new System.EventHandler(this.ButtonItem4_Click);
            // 
            // TextureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.ContextMenuBar1);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextureEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texture Editor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CurImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel Panel1;


        private DevComponents.DotNetBar.SideBar SideBar1;


        private FlowLayoutPanel FlowLayoutPanel_Textures;


        private DevComponents.DotNetBar.Validator.Highlighter Highlighter1;


        private Panel Panel4;


        private DevComponents.DotNetBar.AdvPropertyGrid AdvPropertyGrid1;


        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1;

        

        private DevComponents.DotNetBar.ButtonItem ButtonItem1;        

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ExpTex;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImpTex;
        private DevComponents.DotNetBar.ButtonItem ButtonItem2;
        private DevComponents.DotNetBar.ButtonItem ButtonItem3;
        private DevComponents.DotNetBar.ButtonItem ButtonItem4;
                private Panel Panel2;

        
        private PictureBox PictureBox_CurImage;

        
    }
}