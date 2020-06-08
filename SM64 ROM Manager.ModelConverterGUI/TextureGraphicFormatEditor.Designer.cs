using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [DesignerGenerated()]
    public partial class TextureGraphicFormatEditor : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureGraphicFormatEditor));
            this.ListViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_SaveColsettings = new DevComponents.DotNetBar.ButtonX();
            this.ComboBox_ColType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX_MaxPixels = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.CheckBoxX_EnableTextureAnimation = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ComboBoxEx_SelectDisplaylist = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.CheckBoxX_EnableMirrorS = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CheckBoxX_EnableClampS = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CheckBoxX_EnableCrystalEffect = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.ComboBoxEx_RotateFlip = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CheckBoxX_EnableClampT = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CheckBoxX_EnableMirrorT = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.LabelX5 = new DevComponents.DotNetBar.LabelX();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.LabelX7 = new DevComponents.DotNetBar.LabelX();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.panel_MatOptions = new System.Windows.Forms.Panel();
            this.LabelX_CollisionType = new DevComponents.DotNetBar.LabelX();
            this.CheckBoxX_EnableTwoSidedFaces = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_Include = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.ButtonItem_CM_SelDL = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.panel_MatOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewEx1
            // 
            resources.ApplyResources(this.ListViewEx1, "ListViewEx1");
            this.ListViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ListViewEx1.Border.Class = "ListViewBorder";
            this.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.ListViewEx1.FocusCuesEnabled = false;
            this.ListViewEx1.ForeColor = System.Drawing.Color.Black;
            this.ListViewEx1.FullRowSelect = true;
            this.ListViewEx1.HideSelection = false;
            this.ListViewEx1.Name = "ListViewEx1";
            this.ListViewEx1.UseCompatibleStateImageBehavior = false;
            this.ListViewEx1.SelectedIndexChanged += new System.EventHandler(this.ListBoxAdv_CI_Textures_ItemClick);
            // 
            // PictureBox1
            // 
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // Button_SaveColsettings
            // 
            this.Button_SaveColsettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.Button_SaveColsettings, "Button_SaveColsettings");
            this.Button_SaveColsettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_SaveColsettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_SaveColsettings.FocusCuesEnabled = false;
            this.Button_SaveColsettings.Name = "Button_SaveColsettings";
            this.Button_SaveColsettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_ColType
            // 
            resources.ApplyResources(this.ComboBox_ColType, "ComboBox_ColType");
            this.ComboBox_ColType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_ColType.DropDownHeight = 150;
            this.ComboBox_ColType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_ColType.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_ColType.FormattingEnabled = true;
            this.ComboBox_ColType.Name = "ComboBox_ColType";
            this.ComboBox_ColType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBox_ColType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_CI_ColType_SelectedIndexChanged);
            // 
            // LabelX_MaxPixels
            // 
            resources.ApplyResources(this.LabelX_MaxPixels, "LabelX_MaxPixels");
            // 
            // 
            // 
            this.LabelX_MaxPixels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_MaxPixels.Name = "LabelX_MaxPixels";
            // 
            // LabelX1
            // 
            resources.ApplyResources(this.LabelX1, "LabelX1");
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Name = "LabelX1";
            // 
            // CheckBoxX_EnableTextureAnimation
            // 
            resources.ApplyResources(this.CheckBoxX_EnableTextureAnimation, "CheckBoxX_EnableTextureAnimation");
            // 
            // 
            // 
            this.CheckBoxX_EnableTextureAnimation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_EnableTextureAnimation.FocusCuesEnabled = false;
            this.CheckBoxX_EnableTextureAnimation.Name = "CheckBoxX_EnableTextureAnimation";
            this.CheckBoxX_EnableTextureAnimation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_EnableTextureAnimation.CheckedChanged += new System.EventHandler(this.ControlsOccusUpdateTextureListItemSettings);
            // 
            // ComboBoxEx_SelectDisplaylist
            // 
            resources.ApplyResources(this.ComboBoxEx_SelectDisplaylist, "ComboBoxEx_SelectDisplaylist");
            this.ContextMenuBar1.SetContextMenuEx(this.ComboBoxEx_SelectDisplaylist, this.ButtonItem_CM_SelDL);
            this.ComboBoxEx_SelectDisplaylist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_SelectDisplaylist.DropDownHeight = 150;
            this.ComboBoxEx_SelectDisplaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx_SelectDisplaylist.DropDownWidth = 170;
            this.ComboBoxEx_SelectDisplaylist.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_SelectDisplaylist.FormattingEnabled = true;
            this.ComboBoxEx_SelectDisplaylist.Name = "ComboBoxEx_SelectDisplaylist";
            this.ComboBoxEx_SelectDisplaylist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_SelectDisplaylist.SelectedIndexChanged += new System.EventHandler(this.ControlsOccusUpdateTextureListItemSettings);
            // 
            // LabelX2
            // 
            resources.ApplyResources(this.LabelX2, "LabelX2");
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // CheckBoxX_EnableMirrorS
            // 
            resources.ApplyResources(this.CheckBoxX_EnableMirrorS, "CheckBoxX_EnableMirrorS");
            // 
            // 
            // 
            this.CheckBoxX_EnableMirrorS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_EnableMirrorS.FocusCuesEnabled = false;
            this.CheckBoxX_EnableMirrorS.Name = "CheckBoxX_EnableMirrorS";
            this.CheckBoxX_EnableMirrorS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_EnableMirrorS.CheckedChanged += new System.EventHandler(this.ControlsOccusUpdateTextureListItemSettings);
            // 
            // CheckBoxX_EnableClampS
            // 
            resources.ApplyResources(this.CheckBoxX_EnableClampS, "CheckBoxX_EnableClampS");
            // 
            // 
            // 
            this.CheckBoxX_EnableClampS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_EnableClampS.FocusCuesEnabled = false;
            this.CheckBoxX_EnableClampS.Name = "CheckBoxX_EnableClampS";
            this.CheckBoxX_EnableClampS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_EnableClampS.CheckedChanged += new System.EventHandler(this.ControlsOccusUpdateTextureListItemSettings);
            // 
            // CheckBoxX_EnableCrystalEffect
            // 
            resources.ApplyResources(this.CheckBoxX_EnableCrystalEffect, "CheckBoxX_EnableCrystalEffect");
            // 
            // 
            // 
            this.CheckBoxX_EnableCrystalEffect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_EnableCrystalEffect.FocusCuesEnabled = false;
            this.CheckBoxX_EnableCrystalEffect.Name = "CheckBoxX_EnableCrystalEffect";
            this.CheckBoxX_EnableCrystalEffect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_EnableCrystalEffect.CheckedChanged += new System.EventHandler(this.ControlsOccusUpdateTextureListItemSettings);
            // 
            // LabelX3
            // 
            resources.ApplyResources(this.LabelX3, "LabelX3");
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX3.Name = "LabelX3";
            // 
            // ComboBoxEx_RotateFlip
            // 
            resources.ApplyResources(this.ComboBoxEx_RotateFlip, "ComboBoxEx_RotateFlip");
            this.ComboBoxEx_RotateFlip.DisplayMember = "Text";
            this.ComboBoxEx_RotateFlip.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_RotateFlip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx_RotateFlip.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_RotateFlip.FormattingEnabled = true;
            this.ComboBoxEx_RotateFlip.Name = "ComboBoxEx_RotateFlip";
            this.ComboBoxEx_RotateFlip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_RotateFlip.SelectedIndexChanged += new System.EventHandler(this.ControlsOccusUpdateTextureListItemSettings);
            // 
            // CheckBoxX_EnableClampT
            // 
            resources.ApplyResources(this.CheckBoxX_EnableClampT, "CheckBoxX_EnableClampT");
            // 
            // 
            // 
            this.CheckBoxX_EnableClampT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_EnableClampT.FocusCuesEnabled = false;
            this.CheckBoxX_EnableClampT.Name = "CheckBoxX_EnableClampT";
            this.CheckBoxX_EnableClampT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_EnableClampT.CheckedChanged += new System.EventHandler(this.ControlsOccusUpdateTextureListItemSettings);
            // 
            // CheckBoxX_EnableMirrorT
            // 
            resources.ApplyResources(this.CheckBoxX_EnableMirrorT, "CheckBoxX_EnableMirrorT");
            // 
            // 
            // 
            this.CheckBoxX_EnableMirrorT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_EnableMirrorT.FocusCuesEnabled = false;
            this.CheckBoxX_EnableMirrorT.Name = "CheckBoxX_EnableMirrorT";
            this.CheckBoxX_EnableMirrorT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_EnableMirrorT.CheckedChanged += new System.EventHandler(this.ControlsOccusUpdateTextureListItemSettings);
            // 
            // LabelX4
            // 
            resources.ApplyResources(this.LabelX4, "LabelX4");
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX5
            // 
            resources.ApplyResources(this.LabelX5, "LabelX5");
            // 
            // 
            // 
            this.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX5.Name = "LabelX5";
            this.LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX6
            // 
            resources.ApplyResources(this.LabelX6, "LabelX6");
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX6.Name = "LabelX6";
            this.LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX7
            // 
            resources.ApplyResources(this.LabelX7, "LabelX7");
            // 
            // 
            // 
            this.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX7.Name = "LabelX7";
            this.LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.panel_MatOptions);
            this.Panel1.Controls.Add(this.checkBoxX_Include);
            this.Panel1.Controls.Add(this.Button_SaveColsettings);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.ListViewEx1);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // panel_MatOptions
            // 
            resources.ApplyResources(this.panel_MatOptions, "panel_MatOptions");
            this.panel_MatOptions.Controls.Add(this.LabelX_CollisionType);
            this.panel_MatOptions.Controls.Add(this.LabelX4);
            this.panel_MatOptions.Controls.Add(this.CheckBoxX_EnableClampT);
            this.panel_MatOptions.Controls.Add(this.LabelX6);
            this.panel_MatOptions.Controls.Add(this.CheckBoxX_EnableMirrorT);
            this.panel_MatOptions.Controls.Add(this.LabelX2);
            this.panel_MatOptions.Controls.Add(this.ComboBoxEx_RotateFlip);
            this.panel_MatOptions.Controls.Add(this.LabelX5);
            this.panel_MatOptions.Controls.Add(this.CheckBoxX_EnableTextureAnimation);
            this.panel_MatOptions.Controls.Add(this.LabelX3);
            this.panel_MatOptions.Controls.Add(this.LabelX7);
            this.panel_MatOptions.Controls.Add(this.LabelX1);
            this.panel_MatOptions.Controls.Add(this.CheckBoxX_EnableTwoSidedFaces);
            this.panel_MatOptions.Controls.Add(this.ComboBoxEx_SelectDisplaylist);
            this.panel_MatOptions.Controls.Add(this.CheckBoxX_EnableCrystalEffect);
            this.panel_MatOptions.Controls.Add(this.LabelX_MaxPixels);
            this.panel_MatOptions.Controls.Add(this.CheckBoxX_EnableMirrorS);
            this.panel_MatOptions.Controls.Add(this.CheckBoxX_EnableClampS);
            this.panel_MatOptions.Controls.Add(this.ComboBox_ColType);
            this.panel_MatOptions.Name = "panel_MatOptions";
            // 
            // LabelX_CollisionType
            // 
            resources.ApplyResources(this.LabelX_CollisionType, "LabelX_CollisionType");
            // 
            // 
            // 
            this.LabelX_CollisionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_CollisionType.Name = "LabelX_CollisionType";
            this.LabelX_CollisionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // CheckBoxX_EnableTwoSidedFaces
            // 
            resources.ApplyResources(this.CheckBoxX_EnableTwoSidedFaces, "CheckBoxX_EnableTwoSidedFaces");
            // 
            // 
            // 
            this.CheckBoxX_EnableTwoSidedFaces.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_EnableTwoSidedFaces.FocusCuesEnabled = false;
            this.CheckBoxX_EnableTwoSidedFaces.Name = "CheckBoxX_EnableTwoSidedFaces";
            this.CheckBoxX_EnableTwoSidedFaces.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_EnableTwoSidedFaces.CheckedChanged += new System.EventHandler(this.ControlsOccusUpdateTextureListItemSettings);
            // 
            // checkBoxX_Include
            // 
            resources.ApplyResources(this.checkBoxX_Include, "checkBoxX_Include");
            // 
            // 
            // 
            this.checkBoxX_Include.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_Include.FocusCuesEnabled = false;
            this.checkBoxX_Include.Name = "checkBoxX_Include";
            this.checkBoxX_Include.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_Include.CheckedChanged += new System.EventHandler(this.CheckBoxX_IncludeMat_CheckedChanged);
            // 
            // ContextMenuBar1
            // 
            this.ContextMenuBar1.AntiAlias = true;
            resources.ApplyResources(this.ContextMenuBar1, "ContextMenuBar1");
            this.ContextMenuBar1.IsMaximized = false;
            this.ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_CM_SelDL});
            this.ContextMenuBar1.Name = "ContextMenuBar1";
            this.ContextMenuBar1.Stretch = true;
            this.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ContextMenuBar1.TabStop = false;
            // 
            // ButtonItem_CM_SelDL
            // 
            this.ButtonItem_CM_SelDL.AutoExpandOnClick = true;
            this.ButtonItem_CM_SelDL.Name = "ButtonItem_CM_SelDL";
            this.ButtonItem_CM_SelDL.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem1});
            resources.ApplyResources(this.ButtonItem_CM_SelDL, "ButtonItem_CM_SelDL");
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.Image = global::SM64_ROM_Manager.ModelConverterGUI.My.Resources.Resources.icons8_edit_16px;
            this.ButtonItem1.Name = "ButtonItem1";
            resources.ApplyResources(this.ButtonItem1, "ButtonItem1");
            this.ButtonItem1.Click += new System.EventHandler(this.ButtonItem_EditCustomDisplaylists_Click);
            // 
            // TextureGraphicFormatEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContextMenuBar1);
            this.Controls.Add(this.Panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextureGraphicFormatEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.panel_MatOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.ListViewEx ListViewEx1;



        private System.Windows.Forms.PictureBox PictureBox1;


        private DevComponents.DotNetBar.ButtonX Button_SaveColsettings;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_ColType;



        private DevComponents.DotNetBar.LabelX LabelX_MaxPixels;


        private DevComponents.DotNetBar.LabelX LabelX1;


        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableTextureAnimation;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_SelectDisplaylist;


        private DevComponents.DotNetBar.LabelX LabelX2;


        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableMirrorS;


        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableClampS;


        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableCrystalEffect;


        private DevComponents.DotNetBar.LabelX LabelX3;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_RotateFlip;


        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableClampT;


        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableMirrorT;


        private DevComponents.DotNetBar.LabelX LabelX4;


        private DevComponents.DotNetBar.LabelX LabelX5;


        private DevComponents.DotNetBar.LabelX LabelX6;


        private DevComponents.DotNetBar.LabelX LabelX7;


        private System.Windows.Forms.Panel Panel1;


        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_CM_SelDL;


        private DevComponents.DotNetBar.ButtonItem ButtonItem1;
        private DevComponents.DotNetBar.LabelX LabelX_CollisionType;
        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableTwoSidedFaces;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_Include;
        private System.Windows.Forms.Panel panel_MatOptions;
    }
}