using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class MainForm : DevComponents.DotNetBar.RibbonForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TabControl1 = new DevComponents.DotNetBar.TabControl();
            this.TabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabGeneral = new SM64_ROM_Manager.Tab_General();
            this.TabItem_General = new DevComponents.DotNetBar.TabItem(this.components);
            this.TabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabMusicManager = new SM64_ROM_Manager.Tab_MusicManager();
            this.TabItem_MusicManager = new DevComponents.DotNetBar.TabItem(this.components);
            this.TabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabTextManager = new SM64_ROM_Manager.Tab_TextManager();
            this.TabItem_TextManager = new DevComponents.DotNetBar.TabItem(this.components);
            this.TabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabLevelManager = new SM64_ROM_Manager.Tab_LevelManager();
            this.TabItem_LevelManager = new DevComponents.DotNetBar.TabItem(this.components);
            this.Bar2 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_SaveRom = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LaunchROM = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.LabelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.ButtonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.LabelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.ButtonItem_ModelImporter = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_TrajectoryEditor = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_HudOptions = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CustomObjects = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_GlobalBehaviorBank = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem22 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_M64ToMidiConverter = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_TextureEditor = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem23 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Bar_Plugins = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem558 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem25 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem19 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Bar_EnableExpertMode = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem27 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem28 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem29 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem24 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_BugReport = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_FeatureRequest = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem21 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Supporter = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem30 = new DevComponents.DotNetBar.ButtonItem();
            this.Bar1 = new DevComponents.DotNetBar.Bar();
            this.LabelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.LabelItem_OtherInfoText = new DevComponents.DotNetBar.LabelItem();
            this.RibbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ButtonItem_HackingDocuments = new DevComponents.DotNetBar.ButtonItem();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabControlPanel1.SuspendLayout();
            this.TabControlPanel4.SuspendLayout();
            this.TabControlPanel3.SuspendLayout();
            this.TabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.TabControl1);
            this.Panel1.Controls.Add(this.Bar2);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // TabControl1
            // 
            resources.ApplyResources(this.TabControl1, "TabControl1");
            this.TabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabControl1.CanReorderTabs = false;
            this.TabControl1.Controls.Add(this.TabControlPanel1);
            this.TabControl1.Controls.Add(this.TabControlPanel4);
            this.TabControl1.Controls.Add(this.TabControlPanel3);
            this.TabControl1.Controls.Add(this.TabControlPanel2);
            this.TabControl1.ForeColor = System.Drawing.Color.Black;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabControl1.SelectedTabIndex = 0;
            this.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.TabControl1.Tabs.Add(this.TabItem_General);
            this.TabControl1.Tabs.Add(this.TabItem_LevelManager);
            this.TabControl1.Tabs.Add(this.TabItem_TextManager);
            this.TabControl1.Tabs.Add(this.TabItem_MusicManager);
            this.TabControl1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.TabControl_Main_SelectedIndexChanged);
            this.TabControl1.SelectedTabChanging += new DevComponents.DotNetBar.TabStrip.SelectedTabChangingEventHandler(this.SuperTabControl_Main_SelectedTabChanging);
            this.TabControl1.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.SuperTabControl_Main_TabItemClose);
            this.TabControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SuperTabControl_Main_ControlAdded);
            // 
            // TabControlPanel1
            // 
            this.TabControlPanel1.Controls.Add(this.tabGeneral);
            this.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.TabControlPanel1, "TabControlPanel1");
            this.TabControlPanel1.Name = "TabControlPanel1";
            this.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.TabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.TabControlPanel1.Style.GradientAngle = 90;
            this.TabControlPanel1.TabItem = this.TabItem_General;
            // 
            // tabGeneral
            // 
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.BackColor = System.Drawing.Color.White;
            this.tabGeneral.Controller = null;
            this.tabGeneral.Name = "tabGeneral";
            // 
            // TabItem_General
            // 
            this.TabItem_General.AttachedControl = this.TabControlPanel1;
            this.TabItem_General.Name = "TabItem_General";
            resources.ApplyResources(this.TabItem_General, "TabItem_General");
            // 
            // TabControlPanel4
            // 
            this.TabControlPanel4.Controls.Add(this.tabMusicManager);
            this.TabControlPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.TabControlPanel4, "TabControlPanel4");
            this.TabControlPanel4.Name = "TabControlPanel4";
            this.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.TabControlPanel4.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.TabControlPanel4.Style.GradientAngle = 90;
            this.TabControlPanel4.TabItem = this.TabItem_MusicManager;
            // 
            // tabMusicManager
            // 
            resources.ApplyResources(this.tabMusicManager, "tabMusicManager");
            this.tabMusicManager.BackColor = System.Drawing.Color.White;
            this.tabMusicManager.Controller = null;
            this.tabMusicManager.Name = "tabMusicManager";
            // 
            // TabItem_MusicManager
            // 
            this.TabItem_MusicManager.AttachedControl = this.TabControlPanel4;
            this.TabItem_MusicManager.Name = "TabItem_MusicManager";
            resources.ApplyResources(this.TabItem_MusicManager, "TabItem_MusicManager");
            // 
            // TabControlPanel3
            // 
            this.TabControlPanel3.Controls.Add(this.tabTextManager);
            this.TabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.TabControlPanel3, "TabControlPanel3");
            this.TabControlPanel3.Name = "TabControlPanel3";
            this.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.TabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.TabControlPanel3.Style.GradientAngle = 90;
            this.TabControlPanel3.TabItem = this.TabItem_TextManager;
            // 
            // tabTextManager
            // 
            resources.ApplyResources(this.tabTextManager, "tabTextManager");
            this.tabTextManager.BackColor = System.Drawing.Color.White;
            this.tabTextManager.Name = "tabTextManager";
            this.tabTextManager.TMController = null;
            // 
            // TabItem_TextManager
            // 
            this.TabItem_TextManager.AttachedControl = this.TabControlPanel3;
            this.TabItem_TextManager.Name = "TabItem_TextManager";
            resources.ApplyResources(this.TabItem_TextManager, "TabItem_TextManager");
            // 
            // TabControlPanel2
            // 
            this.TabControlPanel2.Controls.Add(this.tabLevelManager);
            this.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.TabControlPanel2, "TabControlPanel2");
            this.TabControlPanel2.Name = "TabControlPanel2";
            this.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.TabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.TabControlPanel2.Style.GradientAngle = 90;
            this.TabControlPanel2.TabItem = this.TabItem_LevelManager;
            // 
            // tabLevelManager
            // 
            resources.ApplyResources(this.tabLevelManager, "tabLevelManager");
            this.tabLevelManager.BackColor = System.Drawing.Color.White;
            this.tabLevelManager.Controller = null;
            this.tabLevelManager.Name = "tabLevelManager";
            // 
            // TabItem_LevelManager
            // 
            this.TabItem_LevelManager.AttachedControl = this.TabControlPanel2;
            this.TabItem_LevelManager.Name = "TabItem_LevelManager";
            resources.ApplyResources(this.TabItem_LevelManager, "TabItem_LevelManager");
            // 
            // Bar2
            // 
            resources.ApplyResources(this.Bar2, "Bar2");
            this.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Bar2.AntiAlias = true;
            this.Bar2.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.Bar2.IsMaximized = false;
            this.Bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem2)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem7)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem22)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem12)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_Bar_Plugins)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem558)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem24))});
            this.Bar2.MenuBar = true;
            this.Bar2.Name = "Bar2";
            this.Bar2.Stretch = true;
            this.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar2.TabStop = false;
            // 
            // ButtonItem2
            // 
            this.ButtonItem2.Name = "ButtonItem2";
            this.ButtonItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem3)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_SaveRom)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_LaunchROM)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem6))});
            resources.ApplyResources(this.ButtonItem2, "ButtonItem2");
            // 
            // ButtonItem3
            // 
            this.ButtonItem3.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_open_folder_16px;
            this.ButtonItem3.Name = "ButtonItem3";
            this.ButtonItem3.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
            this.ButtonItem3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(172)))), ((int)(((byte)(106)))));
            this.ButtonItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem3.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem3, "ButtonItem3");
            this.ButtonItem3.Click += new System.EventHandler(this.MenuItem_OpenROM_Click);
            // 
            // ButtonItem_SaveRom
            // 
            this.ButtonItem_SaveRom.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_save_16px;
            this.ButtonItem_SaveRom.Name = "ButtonItem_SaveRom";
            this.ButtonItem_SaveRom.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.ButtonItem_SaveRom.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.ButtonItem_SaveRom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_SaveRom.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem_SaveRom, "ButtonItem_SaveRom");
            this.ButtonItem_SaveRom.Click += new System.EventHandler(this.ButtonItem12_Click);
            // 
            // ButtonItem_LaunchROM
            // 
            this.ButtonItem_LaunchROM.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_controller_16px;
            this.ButtonItem_LaunchROM.Name = "ButtonItem_LaunchROM";
            this.ButtonItem_LaunchROM.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.ButtonItem_LaunchROM.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem_LaunchROM, "ButtonItem_LaunchROM");
            this.ButtonItem_LaunchROM.Click += new System.EventHandler(this.MenuItem_LaunchROM_Click);
            // 
            // ButtonItem6
            // 
            resources.ApplyResources(this.ButtonItem6, "ButtonItem6");
            this.ButtonItem6.BeginGroup = true;
            this.ButtonItem6.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_cancel_16px;
            this.ButtonItem6.Name = "ButtonItem6";
            this.ButtonItem6.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonItem6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem6.SymbolSize = 12F;
            this.ButtonItem6.Click += new System.EventHandler(this.MenuItem11_Click);
            // 
            // ButtonItem7
            // 
            this.ButtonItem7.BeginGroup = true;
            this.ButtonItem7.Name = "ButtonItem7";
            this.ButtonItem7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            ((DevComponents.DotNetBar.BaseItem)(this.LabelItem2)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem8)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem10)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem11)),
            ((DevComponents.DotNetBar.BaseItem)(this.LabelItem3)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_ModelImporter)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem17)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_TrajectoryEditor)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem14)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem13)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem15)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem16)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_HudOptions)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_CustomObjects)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem18)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_GlobalBehaviorBank))});
            resources.ApplyResources(this.ButtonItem7, "ButtonItem7");
            // 
            // LabelItem2
            // 
            this.LabelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.LabelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.LabelItem2.Name = "LabelItem2";
            this.LabelItem2.PaddingBottom = 1;
            this.LabelItem2.PaddingLeft = 10;
            this.LabelItem2.PaddingTop = 1;
            this.LabelItem2.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            resources.ApplyResources(this.LabelItem2, "LabelItem2");
            // 
            // ButtonItem8
            // 
            this.ButtonItem8.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_map_16px;
            this.ButtonItem8.Name = "ButtonItem8";
            resources.ApplyResources(this.ButtonItem8, "ButtonItem8");
            this.ButtonItem8.Click += new System.EventHandler(this.MenuItem20_Click);
            // 
            // ButtonItem10
            // 
            this.ButtonItem10.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_music_16px;
            this.ButtonItem10.Name = "ButtonItem10";
            resources.ApplyResources(this.ButtonItem10, "ButtonItem10");
            this.ButtonItem10.Click += new System.EventHandler(this.MenuItem17_Click);
            // 
            // ButtonItem11
            // 
            this.ButtonItem11.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_text_16px;
            this.ButtonItem11.Name = "ButtonItem11";
            resources.ApplyResources(this.ButtonItem11, "ButtonItem11");
            this.ButtonItem11.Click += new System.EventHandler(this.MenuItem16_Click);
            // 
            // LabelItem3
            // 
            this.LabelItem3.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.LabelItem3.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.LabelItem3.Name = "LabelItem3";
            this.LabelItem3.PaddingBottom = 1;
            this.LabelItem3.PaddingLeft = 10;
            this.LabelItem3.PaddingTop = 1;
            this.LabelItem3.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            resources.ApplyResources(this.LabelItem3, "LabelItem3");
            // 
            // ButtonItem_ModelImporter
            // 
            this.ButtonItem_ModelImporter.Icon = ((System.Drawing.Icon)(resources.GetObject("ButtonItem_ModelImporter.Icon")));
            this.ButtonItem_ModelImporter.Name = "ButtonItem_ModelImporter";
            resources.ApplyResources(this.ButtonItem_ModelImporter, "ButtonItem_ModelImporter");
            this.ButtonItem_ModelImporter.Click += new System.EventHandler(this.ButtonItem_ModelImporter_Click);
            // 
            // ButtonItem17
            // 
            this.ButtonItem17.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_pills_16px;
            this.ButtonItem17.Name = "ButtonItem17";
            resources.ApplyResources(this.ButtonItem17, "ButtonItem17");
            this.ButtonItem17.Click += new System.EventHandler(this.ButtonItem17_Click);
            // 
            // ButtonItem_TrajectoryEditor
            // 
            this.ButtonItem_TrajectoryEditor.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_node_16px;
            this.ButtonItem_TrajectoryEditor.Name = "ButtonItem_TrajectoryEditor";
            resources.ApplyResources(this.ButtonItem_TrajectoryEditor, "ButtonItem_TrajectoryEditor");
            this.ButtonItem_TrajectoryEditor.Click += new System.EventHandler(this.ButtonItem_TrajectoryEditor_Click);
            // 
            // ButtonItem14
            // 
            this.ButtonItem14.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_package_16px;
            this.ButtonItem14.Name = "ButtonItem14";
            resources.ApplyResources(this.ButtonItem14, "ButtonItem14");
            this.ButtonItem14.Click += new System.EventHandler(this.ButtonItem14_Click);
            // 
            // ButtonItem13
            // 
            this.ButtonItem13.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_filled_star_location_16px;
            this.ButtonItem13.Name = "ButtonItem13";
            resources.ApplyResources(this.ButtonItem13, "ButtonItem13");
            this.ButtonItem13.Click += new System.EventHandler(this.ButtonItem13_Click);
            // 
            // ButtonItem15
            // 
            this.ButtonItem15.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_variation_16px;
            this.ButtonItem15.Name = "ButtonItem15";
            resources.ApplyResources(this.ButtonItem15, "ButtonItem15");
            this.ButtonItem15.Click += new System.EventHandler(this.ButtonItem15_Click);
            // 
            // ButtonItem16
            // 
            this.ButtonItem16.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_coins_16px;
            this.ButtonItem16.Name = "ButtonItem16";
            resources.ApplyResources(this.ButtonItem16, "ButtonItem16");
            this.ButtonItem16.Click += new System.EventHandler(this.ButtonItem16_Click);
            // 
            // ButtonItem_HudOptions
            // 
            this.ButtonItem_HudOptions.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_300_degrees_16px;
            this.ButtonItem_HudOptions.Name = "ButtonItem_HudOptions";
            resources.ApplyResources(this.ButtonItem_HudOptions, "ButtonItem_HudOptions");
            this.ButtonItem_HudOptions.Click += new System.EventHandler(this.ButtonItem_HudOptions_Click);
            // 
            // ButtonItem_CustomObjects
            // 
            this.ButtonItem_CustomObjects.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_module_16px;
            this.ButtonItem_CustomObjects.Name = "ButtonItem_CustomObjects";
            resources.ApplyResources(this.ButtonItem_CustomObjects, "ButtonItem_CustomObjects");
            this.ButtonItem_CustomObjects.Click += new System.EventHandler(this.ButtonItem_CustomObjects_Click);
            // 
            // ButtonItem18
            // 
            this.ButtonItem18.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_cube_16px;
            this.ButtonItem18.Name = "ButtonItem18";
            resources.ApplyResources(this.ButtonItem18, "ButtonItem18");
            this.ButtonItem18.Click += new System.EventHandler(this.ButtonItem18_Click);
            // 
            // ButtonItem_GlobalBehaviorBank
            // 
            this.ButtonItem_GlobalBehaviorBank.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_static_view_level1_16px;
            this.ButtonItem_GlobalBehaviorBank.Name = "ButtonItem_GlobalBehaviorBank";
            resources.ApplyResources(this.ButtonItem_GlobalBehaviorBank, "ButtonItem_GlobalBehaviorBank");
            this.ButtonItem_GlobalBehaviorBank.Click += new System.EventHandler(this.ButtonItem_GlobalBehaviorBank_Click);
            // 
            // ButtonItem22
            // 
            this.ButtonItem22.Name = "ButtonItem22";
            this.ButtonItem22.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem1)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem9)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_M64ToMidiConverter)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_TextureEditor))});
            resources.ApplyResources(this.ButtonItem22, "ButtonItem22");
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem1.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_text_16px;
            this.ButtonItem1.Name = "ButtonItem1";
            this.ButtonItem1.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem1, "ButtonItem1");
            this.ButtonItem1.Click += new System.EventHandler(this.ButtonItem1_Click);
            // 
            // ButtonItem9
            // 
            this.ButtonItem9.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_syringe_16px;
            this.ButtonItem9.Name = "ButtonItem9";
            resources.ApplyResources(this.ButtonItem9, "ButtonItem9");
            this.ButtonItem9.Click += new System.EventHandler(this.ButtonItem9_Click);
            // 
            // ButtonItem_M64ToMidiConverter
            // 
            this.ButtonItem_M64ToMidiConverter.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_music_16px;
            this.ButtonItem_M64ToMidiConverter.Name = "ButtonItem_M64ToMidiConverter";
            resources.ApplyResources(this.ButtonItem_M64ToMidiConverter, "ButtonItem_M64ToMidiConverter");
            this.ButtonItem_M64ToMidiConverter.Click += new System.EventHandler(this.ButtonItem_M64ToMidiConverter_Click);
            // 
            // ButtonItem_TextureEditor
            // 
            this.ButtonItem_TextureEditor.Name = "ButtonItem_TextureEditor";
            resources.ApplyResources(this.ButtonItem_TextureEditor, "ButtonItem_TextureEditor");
            this.ButtonItem_TextureEditor.Click += new System.EventHandler(this.ButtonItem_TextureEditor_Click);
            // 
            // ButtonItem12
            // 
            this.ButtonItem12.Name = "ButtonItem12";
            this.ButtonItem12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem23))});
            resources.ApplyResources(this.ButtonItem12, "ButtonItem12");
            // 
            // ButtonItem23
            // 
            this.ButtonItem23.Name = "ButtonItem23";
            this.ButtonItem23.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9);
            resources.ApplyResources(this.ButtonItem23, "ButtonItem23");
            this.ButtonItem23.Click += new System.EventHandler(this.ButtonItem23_Click);
            // 
            // ButtonItem_Bar_Plugins
            // 
            this.ButtonItem_Bar_Plugins.BeginGroup = true;
            this.ButtonItem_Bar_Plugins.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Bar_Plugins.Name = "ButtonItem_Bar_Plugins";
            this.ButtonItem_Bar_Plugins.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem20))});
            this.ButtonItem_Bar_Plugins.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem_Bar_Plugins, "ButtonItem_Bar_Plugins");
            // 
            // ButtonItem20
            // 
            this.ButtonItem20.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plugin_16px;
            this.ButtonItem20.Name = "ButtonItem20";
            resources.ApplyResources(this.ButtonItem20, "ButtonItem20");
            this.ButtonItem20.Click += new System.EventHandler(this.ButtonItem_Bar_Plugins_ManagePlugins_Click);
            // 
            // ButtonItem558
            // 
            this.ButtonItem558.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem558.Name = "ButtonItem558";
            this.ButtonItem558.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem25)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem5)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem19)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem4)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_Bar_EnableExpertMode)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem27)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem28)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem29))});
            this.ButtonItem558.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem558, "ButtonItem558");
            // 
            // ButtonItem25
            // 
            this.ButtonItem25.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_settings_16px;
            this.ButtonItem25.Name = "ButtonItem25";
            this.ButtonItem25.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem25, "ButtonItem25");
            this.ButtonItem25.Click += new System.EventHandler(this.MenuItem_Settings_Click);
            // 
            // ButtonItem5
            // 
            this.ButtonItem5.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_color_dropper_16px;
            this.ButtonItem5.Name = "ButtonItem5";
            this.ButtonItem5.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem5, "ButtonItem5");
            this.ButtonItem5.Click += new System.EventHandler(this.ButtonItem5_Click);
            // 
            // ButtonItem19
            // 
            this.ButtonItem19.BeginGroup = true;
            this.ButtonItem19.Name = "ButtonItem19";
            resources.ApplyResources(this.ButtonItem19, "ButtonItem19");
            this.ButtonItem19.Click += new System.EventHandler(this.ButtonItem19_Click);
            // 
            // ButtonItem4
            // 
            this.ButtonItem4.Name = "ButtonItem4";
            resources.ApplyResources(this.ButtonItem4, "ButtonItem4");
            this.ButtonItem4.Click += new System.EventHandler(this.ButtonItem4_Click);
            // 
            // ButtonItem_Bar_EnableExpertMode
            // 
            this.ButtonItem_Bar_EnableExpertMode.AutoCheckOnClick = true;
            this.ButtonItem_Bar_EnableExpertMode.BeginGroup = true;
            this.ButtonItem_Bar_EnableExpertMode.Name = "ButtonItem_Bar_EnableExpertMode";
            resources.ApplyResources(this.ButtonItem_Bar_EnableExpertMode, "ButtonItem_Bar_EnableExpertMode");
            this.ButtonItem_Bar_EnableExpertMode.Visible = false;
            // 
            // ButtonItem27
            // 
            this.ButtonItem27.BeginGroup = true;
            this.ButtonItem27.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_help_16px;
            this.ButtonItem27.Name = "ButtonItem27";
            this.ButtonItem27.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem27.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem27, "ButtonItem27");
            this.ButtonItem27.Visible = false;
            // 
            // ButtonItem28
            // 
            this.ButtonItem28.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem28.Image")));
            this.ButtonItem28.Name = "ButtonItem28";
            resources.ApplyResources(this.ButtonItem28, "ButtonItem28");
            this.ButtonItem28.Visible = false;
            // 
            // ButtonItem29
            // 
            this.ButtonItem29.BeginGroup = true;
            this.ButtonItem29.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_downloading_updates_16px;
            this.ButtonItem29.Name = "ButtonItem29";
            this.ButtonItem29.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem29, "ButtonItem29");
            this.ButtonItem29.Click += new System.EventHandler(this.ButtonItem29_Click);
            // 
            // ButtonItem24
            // 
            this.ButtonItem24.Name = "ButtonItem24";
            this.ButtonItem24.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_BugReport)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_FeatureRequest)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem21)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_HackingDocuments)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem_Supporter)),
            ((DevComponents.DotNetBar.BaseItem)(this.ButtonItem30))});
            resources.ApplyResources(this.ButtonItem24, "ButtonItem24");
            // 
            // ButtonItem_BugReport
            // 
            this.ButtonItem_BugReport.Name = "ButtonItem_BugReport";
            resources.ApplyResources(this.ButtonItem_BugReport, "ButtonItem_BugReport");
            this.ButtonItem_BugReport.Click += new System.EventHandler(this.ButtonItem_BugReport_Click);
            // 
            // ButtonItem_FeatureRequest
            // 
            this.ButtonItem_FeatureRequest.Name = "ButtonItem_FeatureRequest";
            resources.ApplyResources(this.ButtonItem_FeatureRequest, "ButtonItem_FeatureRequest");
            this.ButtonItem_FeatureRequest.Click += new System.EventHandler(this.ButtonItem_FeatureRequest_Click);
            // 
            // ButtonItem21
            // 
            this.ButtonItem21.Name = "ButtonItem21";
            resources.ApplyResources(this.ButtonItem21, "ButtonItem21");
            this.ButtonItem21.Click += new System.EventHandler(this.ButtonItem21_Click);
            // 
            // ButtonItem_Supporter
            // 
            this.ButtonItem_Supporter.BeginGroup = true;
            this.ButtonItem_Supporter.Name = "ButtonItem_Supporter";
            resources.ApplyResources(this.ButtonItem_Supporter, "ButtonItem_Supporter");
            this.ButtonItem_Supporter.Click += new System.EventHandler(this.ButtonItem_Supporter_Click);
            // 
            // ButtonItem30
            // 
            this.ButtonItem30.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_about_16px;
            this.ButtonItem30.Name = "ButtonItem30";
            this.ButtonItem30.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem30.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem30, "ButtonItem30");
            this.ButtonItem30.Click += new System.EventHandler(this.MenuItem_About_Click);
            // 
            // Bar1
            // 
            this.Bar1.AntiAlias = true;
            this.Bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            resources.ApplyResources(this.Bar1, "Bar1");
            this.Bar1.IsMaximized = false;
            this.Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            ((DevComponents.DotNetBar.BaseItem)(this.LabelItem1)),
            ((DevComponents.DotNetBar.BaseItem)(this.LabelItem_OtherInfoText))});
            this.Bar1.Name = "Bar1";
            this.Bar1.Stretch = true;
            this.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar1.TabStop = false;
            // 
            // LabelItem1
            // 
            this.LabelItem1.Name = "LabelItem1";
            // 
            // LabelItem_OtherInfoText
            // 
            this.LabelItem_OtherInfoText.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.LabelItem_OtherInfoText.Name = "LabelItem_OtherInfoText";
            // 
            // RibbonControl1
            // 
            this.RibbonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonControl1.CanCustomize = false;
            this.RibbonControl1.CaptionVisible = true;
            resources.ApplyResources(this.RibbonControl1, "RibbonControl1");
            this.RibbonControl1.ForeColor = System.Drawing.Color.Black;
            this.RibbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.RibbonControl1.Name = "RibbonControl1";
            this.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonControl1.SystemText.MaximizeRibbonText = resources.GetString("RibbonControl1.SystemText.MaximizeRibbonText");
            this.RibbonControl1.SystemText.MinimizeRibbonText = resources.GetString("RibbonControl1.SystemText.MinimizeRibbonText");
            this.RibbonControl1.SystemText.QatAddItemText = resources.GetString("RibbonControl1.SystemText.QatAddItemText");
            this.RibbonControl1.SystemText.QatCustomizeMenuLabel = resources.GetString("RibbonControl1.SystemText.QatCustomizeMenuLabel");
            this.RibbonControl1.SystemText.QatCustomizeText = resources.GetString("RibbonControl1.SystemText.QatCustomizeText");
            this.RibbonControl1.SystemText.QatDialogAddButton = resources.GetString("RibbonControl1.SystemText.QatDialogAddButton");
            this.RibbonControl1.SystemText.QatDialogCancelButton = resources.GetString("RibbonControl1.SystemText.QatDialogCancelButton");
            this.RibbonControl1.SystemText.QatDialogCaption = resources.GetString("RibbonControl1.SystemText.QatDialogCaption");
            this.RibbonControl1.SystemText.QatDialogCategoriesLabel = resources.GetString("RibbonControl1.SystemText.QatDialogCategoriesLabel");
            this.RibbonControl1.SystemText.QatDialogOkButton = resources.GetString("RibbonControl1.SystemText.QatDialogOkButton");
            this.RibbonControl1.SystemText.QatDialogPlacementCheckbox = resources.GetString("RibbonControl1.SystemText.QatDialogPlacementCheckbox");
            this.RibbonControl1.SystemText.QatDialogRemoveButton = resources.GetString("RibbonControl1.SystemText.QatDialogRemoveButton");
            this.RibbonControl1.SystemText.QatPlaceAboveRibbonText = resources.GetString("RibbonControl1.SystemText.QatPlaceAboveRibbonText");
            this.RibbonControl1.SystemText.QatPlaceBelowRibbonText = resources.GetString("RibbonControl1.SystemText.QatPlaceBelowRibbonText");
            this.RibbonControl1.SystemText.QatRemoveItemText = resources.GetString("RibbonControl1.SystemText.QatRemoveItemText");
            this.RibbonControl1.TabGroupHeight = 14;
            // 
            // ButtonItem_HackingDocuments
            // 
            this.ButtonItem_HackingDocuments.BeginGroup = true;
            this.ButtonItem_HackingDocuments.Name = "ButtonItem_HackingDocuments";
            resources.ApplyResources(this.ButtonItem_HackingDocuments, "ButtonItem_HackingDocuments");
            this.ButtonItem_HackingDocuments.Click += new System.EventHandler(this.ButtonItem_HackingDocuments_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RibbonControl1);
            this.Controls.Add(this.Bar1);
            this.Controls.Add(this.Panel1);
            this.Name = "MainForm";
            this.Tag = "696; 650";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabControlPanel1.ResumeLayout(false);
            this.TabControlPanel4.ResumeLayout(false);
            this.TabControlPanel3.ResumeLayout(false);
            this.TabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).EndInit();
            this.ResumeLayout(false);

        }

        /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
        private Panel Panel1;

        private DevComponents.DotNetBar.Bar Bar1;

        private DevComponents.DotNetBar.TabControl TabControl1;

        private DevComponents.DotNetBar.Bar Bar2;

        private DevComponents.DotNetBar.ButtonItem ButtonItem2;

        private DevComponents.DotNetBar.ButtonItem ButtonItem3;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_SaveRom;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_LaunchROM;

        private DevComponents.DotNetBar.ButtonItem ButtonItem6;

        private DevComponents.DotNetBar.ButtonItem ButtonItem7;

        private DevComponents.DotNetBar.LabelItem LabelItem2;

        private DevComponents.DotNetBar.ButtonItem ButtonItem8;


        private DevComponents.DotNetBar.ButtonItem ButtonItem10;

        private DevComponents.DotNetBar.ButtonItem ButtonItem11;


        private DevComponents.DotNetBar.LabelItem LabelItem3;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_ModelImporter;


        private DevComponents.DotNetBar.ButtonItem ButtonItem17;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_TrajectoryEditor;

        private DevComponents.DotNetBar.ButtonItem ButtonItem14;


        private DevComponents.DotNetBar.ButtonItem ButtonItem22;


        private DevComponents.DotNetBar.ButtonItem ButtonItem1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem12;

        private DevComponents.DotNetBar.ButtonItem ButtonItem23;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_Bar_Plugins;

        private DevComponents.DotNetBar.ButtonItem ButtonItem558;

        private DevComponents.DotNetBar.ButtonItem ButtonItem25;

        private DevComponents.DotNetBar.ButtonItem ButtonItem5;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_Bar_EnableExpertMode;

        private DevComponents.DotNetBar.ButtonItem ButtonItem27;

        private DevComponents.DotNetBar.ButtonItem ButtonItem28;

        private DevComponents.DotNetBar.ButtonItem ButtonItem29;

        private DevComponents.DotNetBar.ButtonItem ButtonItem30;

        private DevComponents.DotNetBar.LabelItem LabelItem1;

        private DevComponents.DotNetBar.LabelItem LabelItem_OtherInfoText;

        private DevComponents.DotNetBar.TabControlPanel TabControlPanel1;

        private DevComponents.DotNetBar.TabItem TabItem_General;

        private DevComponents.DotNetBar.TabControlPanel TabControlPanel2;

        private DevComponents.DotNetBar.TabItem TabItem_LevelManager;

        private DevComponents.DotNetBar.TabControlPanel TabControlPanel3;

        private DevComponents.DotNetBar.TabItem TabItem_TextManager;

        private DevComponents.DotNetBar.TabControlPanel TabControlPanel4;

        private DevComponents.DotNetBar.TabItem TabItem_MusicManager;

        private Tab_General tabGeneral;

        private Tab_LevelManager tabLevelManager;

        private Tab_MusicManager tabMusicManager;

        private Tab_TextManager tabTextManager;

        private DevComponents.DotNetBar.ButtonItem ButtonItem9;

        private DevComponents.DotNetBar.ButtonItem ButtonItem13;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_M64ToMidiConverter;

        private DevComponents.DotNetBar.ButtonItem ButtonItem15;

        private DevComponents.DotNetBar.ButtonItem ButtonItem16;

        private DevComponents.DotNetBar.RibbonControl RibbonControl1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem19;

        private DevComponents.DotNetBar.ButtonItem ButtonItem18;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_Bar_Plugins_ManagePlugins;

        private DevComponents.DotNetBar.ButtonItem ButtonItem20;

        private DevComponents.DotNetBar.ButtonItem ButtonItem4;

        private DevComponents.DotNetBar.ButtonItem ButtonItem24;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_BugReport;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_FeatureRequest;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_Supporter;

        private DevComponents.DotNetBar.ButtonItem ButtonItem21;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_HudOptions;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_GlobalBehaviorBank;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_CustomObjects;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_TextureEditor;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_HackingDocuments;
    }
}