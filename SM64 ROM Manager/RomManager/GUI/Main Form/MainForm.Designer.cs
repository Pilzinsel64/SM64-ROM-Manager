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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            _Panel1 = new Panel();
            _TabControl1 = new DevComponents.DotNetBar.TabControl();
            _TabControl1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(TabControl_Main_SelectedIndexChanged);
            _TabControl1.SelectedTabChanging += new DevComponents.DotNetBar.TabStrip.SelectedTabChangingEventHandler(SuperTabControl_Main_SelectedTabChanging);
            _TabControl1.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(SuperTabControl_Main_TabItemClose);
            _TabControl1.ControlAdded += new ControlEventHandler(SuperTabControl_Main_ControlAdded);
            _TabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            _tabGeneral = new Tab_General();
            _TabItem_General = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            _tabMusicManager = new Tab_MusicManager();
            _TabItem_MusicManager = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            _tabTextManager = new Tab_TextManager();
            _TabItem_TextManager = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            _tabLevelManager = new Tab_LevelManager();
            _TabItem_LevelManager = new DevComponents.DotNetBar.TabItem(components);
            _Bar2 = new DevComponents.DotNetBar.Bar();
            _ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem3.Click += new EventHandler(MenuItem_OpenROM_Click);
            _ButtonItem_SaveRom = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_SaveRom.Click += new EventHandler(ButtonItem12_Click);
            _ButtonItem_LaunchROM = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_LaunchROM.Click += new EventHandler(MenuItem_LaunchROM_Click);
            _ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem6.Click += new EventHandler(MenuItem11_Click);
            _ButtonItem7 = new DevComponents.DotNetBar.ButtonItem();
            _LabelItem2 = new DevComponents.DotNetBar.LabelItem();
            _ButtonItem8 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem8.Click += new EventHandler(MenuItem20_Click);
            _ButtonItem10 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem10.Click += new EventHandler(MenuItem17_Click);
            _ButtonItem11 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem11.Click += new EventHandler(MenuItem16_Click);
            _LabelItem3 = new DevComponents.DotNetBar.LabelItem();
            _ButtonItem_ModelImporter = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ModelImporter.Click += new EventHandler(ButtonItem_ModelImporter_Click);
            _ButtonItem17 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem17.Click += new EventHandler(ButtonItem17_Click);
            _ButtonItem_TrajectoryEditor = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_TrajectoryEditor.Click += new EventHandler(ButtonItem_TrajectoryEditor_Click);
            _ButtonItem14 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem14.Click += new EventHandler(ButtonItem14_Click);
            _ButtonItem13 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem13.Click += new EventHandler(ButtonItem13_Click);
            _ButtonItem15 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem15.Click += new EventHandler(ButtonItem15_Click);
            _ButtonItem16 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem16.Click += new EventHandler(ButtonItem16_Click);
            _ButtonItem18 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem18.Click += new EventHandler(ButtonItem18_Click);
            _ButtonItem_HudOptions = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_HudOptions.Click += new EventHandler(ButtonItem_HudOptions_Click);
            _ButtonItem22 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem1.Click += new EventHandler(ButtonItem1_Click);
            _ButtonItem9 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem9.Click += new EventHandler(ButtonItem9_Click);
            _ButtonItem_M64ToMidiConverter = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_M64ToMidiConverter.Click += new EventHandler(ButtonItem_M64ToMidiConverter_Click);
            _ButtonItem12 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem23 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem23.Click += new EventHandler(ButtonItem23_Click);
            _ButtonItem_Bar_Plugins = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem20 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem20.Click += new EventHandler(ButtonItem_Bar_Plugins_ManagePlugins_Click);
            _ButtonItem558 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem25 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem25.Click += new EventHandler(MenuItem_Settings_Click);
            _ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem5.Click += new EventHandler(ButtonItem5_Click);
            _ButtonItem19 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem19.Click += new EventHandler(ButtonItem19_Click);
            _ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem4.Click += new EventHandler(ButtonItem4_Click);
            _ButtonItem_Bar_EnableExpertMode = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem27 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem28 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem29 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem29.Click += new EventHandler(ButtonItem29_Click);
            _ButtonItem24 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_BugReport = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_BugReport.Click += new EventHandler(ButtonItem_BugReport_Click);
            _ButtonItem_FeatureRequest = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_FeatureRequest.Click += new EventHandler(ButtonItem_FeatureRequest_Click);
            _ButtonItem21 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem21.Click += new EventHandler(ButtonItem21_Click);
            _ButtonItem_Supporter = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Supporter.Click += new EventHandler(ButtonItem_Supporter_Click);
            _ButtonItem30 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem30.Click += new EventHandler(MenuItem_About_Click);
            _Bar1 = new DevComponents.DotNetBar.Bar();
            _LabelItem1 = new DevComponents.DotNetBar.LabelItem();
            _LabelItem_OtherInfoText = new DevComponents.DotNetBar.LabelItem();
            _RibbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            _Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TabControl1).BeginInit();
            _TabControl1.SuspendLayout();
            _TabControlPanel1.SuspendLayout();
            _TabControlPanel4.SuspendLayout();
            _TabControlPanel3.SuspendLayout();
            _TabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_Bar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Bar1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.Controls.Add(_TabControl1);
            _Panel1.Controls.Add(_Bar2);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // TabControl1
            // 
            resources.ApplyResources(_TabControl1, "TabControl1");
            _TabControl1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControl1.CanReorderTabs = false;
            _TabControl1.Controls.Add(_TabControlPanel1);
            _TabControl1.Controls.Add(_TabControlPanel4);
            _TabControl1.Controls.Add(_TabControlPanel3);
            _TabControl1.Controls.Add(_TabControlPanel2);
            _TabControl1.ForeColor = Color.Black;
            _TabControl1.Name = "TabControl1";
            _TabControl1.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            _TabControl1.SelectedTabIndex = 0;
            _TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            _TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            _TabControl1.Tabs.Add(_TabItem_General);
            _TabControl1.Tabs.Add(_TabItem_LevelManager);
            _TabControl1.Tabs.Add(_TabItem_TextManager);
            _TabControl1.Tabs.Add(_TabItem_MusicManager);
            // 
            // TabControlPanel1
            // 
            _TabControlPanel1.Controls.Add(_tabGeneral);
            _TabControlPanel1.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel1, "TabControlPanel1");
            _TabControlPanel1.Name = "TabControlPanel1";
            _TabControlPanel1.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel1.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel1.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel1.Style.GradientAngle = 90;
            _TabControlPanel1.TabItem = _TabItem_General;
            // 
            // tabGeneral
            // 
            resources.ApplyResources(_tabGeneral, "tabGeneral");
            _tabGeneral.BackColor = Color.White;
            _tabGeneral.Name = "tabGeneral";
            // 
            // TabItem_General
            // 
            _TabItem_General.AttachedControl = _TabControlPanel1;
            _TabItem_General.Name = "TabItem_General";
            resources.ApplyResources(_TabItem_General, "TabItem_General");
            // 
            // TabControlPanel4
            // 
            _TabControlPanel4.Controls.Add(_tabMusicManager);
            _TabControlPanel4.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel4, "TabControlPanel4");
            _TabControlPanel4.Name = "TabControlPanel4";
            _TabControlPanel4.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel4.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel4.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel4.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel4.Style.GradientAngle = 90;
            _TabControlPanel4.TabItem = _TabItem_MusicManager;
            // 
            // tabMusicManager
            // 
            resources.ApplyResources(_tabMusicManager, "tabMusicManager");
            _tabMusicManager.BackColor = Color.White;
            _tabMusicManager.Name = "tabMusicManager";
            // 
            // TabItem_MusicManager
            // 
            _TabItem_MusicManager.AttachedControl = _TabControlPanel4;
            _TabItem_MusicManager.Name = "TabItem_MusicManager";
            resources.ApplyResources(_TabItem_MusicManager, "TabItem_MusicManager");
            // 
            // TabControlPanel3
            // 
            _TabControlPanel3.Controls.Add(_tabTextManager);
            _TabControlPanel3.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel3, "TabControlPanel3");
            _TabControlPanel3.Name = "TabControlPanel3";
            _TabControlPanel3.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel3.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel3.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel3.Style.GradientAngle = 90;
            _TabControlPanel3.TabItem = _TabItem_TextManager;
            // 
            // tabTextManager
            // 
            resources.ApplyResources(_tabTextManager, "tabTextManager");
            _tabTextManager.BackColor = Color.White;
            _tabTextManager.Name = "tabTextManager";
            // 
            // TabItem_TextManager
            // 
            _TabItem_TextManager.AttachedControl = _TabControlPanel3;
            _TabItem_TextManager.Name = "TabItem_TextManager";
            resources.ApplyResources(_TabItem_TextManager, "TabItem_TextManager");
            // 
            // TabControlPanel2
            // 
            _TabControlPanel2.Controls.Add(_tabLevelManager);
            _TabControlPanel2.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel2, "TabControlPanel2");
            _TabControlPanel2.Name = "TabControlPanel2";
            _TabControlPanel2.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel2.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel2.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel2.Style.GradientAngle = 90;
            _TabControlPanel2.TabItem = _TabItem_LevelManager;
            // 
            // tabLevelManager
            // 
            resources.ApplyResources(_tabLevelManager, "tabLevelManager");
            _tabLevelManager.BackColor = Color.White;
            _tabLevelManager.Name = "tabLevelManager";
            // 
            // TabItem_LevelManager
            // 
            _TabItem_LevelManager.AttachedControl = _TabControlPanel2;
            _TabItem_LevelManager.Name = "TabItem_LevelManager";
            resources.ApplyResources(_TabItem_LevelManager, "TabItem_LevelManager");
            // 
            // Bar2
            // 
            resources.ApplyResources(_Bar2, "Bar2");
            _Bar2.AccessibleRole = AccessibleRole.MenuBar;
            _Bar2.AntiAlias = true;
            _Bar2.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            _Bar2.IsMaximized = false;
            _Bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem2, _ButtonItem7, _ButtonItem22, _ButtonItem12, _ButtonItem_Bar_Plugins, _ButtonItem558, _ButtonItem24 });
            _Bar2.MenuBar = true;
            _Bar2.Name = "Bar2";
            _Bar2.Stretch = true;
            _Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Bar2.TabStop = false;
            // 
            // ButtonItem2
            // 
            _ButtonItem2.Name = "ButtonItem2";
            _ButtonItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem3, _ButtonItem_SaveRom, _ButtonItem_LaunchROM, _ButtonItem6 });
            resources.ApplyResources(_ButtonItem2, "ButtonItem2");
            // 
            // ButtonItem3
            // 
            _ButtonItem3.Image = My.Resources.MyIcons.icons8_open_folder_16px;
            _ButtonItem3.Name = "ButtonItem3";
            _ButtonItem3.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
            _ButtonItem3.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _ButtonItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem3.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem3, "ButtonItem3");
            // 
            // ButtonItem_SaveRom
            // 
            _ButtonItem_SaveRom.Image = My.Resources.MyIcons.icons8_save_16px;
            _ButtonItem_SaveRom.Name = "ButtonItem_SaveRom";
            _ButtonItem_SaveRom.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            _ButtonItem_SaveRom.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonItem_SaveRom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_SaveRom.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_SaveRom, "ButtonItem_SaveRom");
            // 
            // ButtonItem_LaunchROM
            // 
            _ButtonItem_LaunchROM.Image = My.Resources.MyIcons.icons8_controller_16px;
            _ButtonItem_LaunchROM.Name = "ButtonItem_LaunchROM";
            _ButtonItem_LaunchROM.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            _ButtonItem_LaunchROM.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_LaunchROM, "ButtonItem_LaunchROM");
            // 
            // ButtonItem6
            // 
            resources.ApplyResources(_ButtonItem6, "ButtonItem6");
            _ButtonItem6.BeginGroup = true;
            _ButtonItem6.Image = My.Resources.MyIcons.icons8_cancel_16px;
            _ButtonItem6.Name = "ButtonItem6";
            _ButtonItem6.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonItem6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem6.SymbolSize = 12.0F;
            // 
            // ButtonItem7
            // 
            _ButtonItem7.BeginGroup = true;
            _ButtonItem7.Name = "ButtonItem7";
            _ButtonItem7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _LabelItem2, _ButtonItem8, _ButtonItem10, _ButtonItem11, _LabelItem3, _ButtonItem_ModelImporter, _ButtonItem17, _ButtonItem_TrajectoryEditor, _ButtonItem14, _ButtonItem13, _ButtonItem15, _ButtonItem16, _ButtonItem18, _ButtonItem_HudOptions });
            resources.ApplyResources(_ButtonItem7, "ButtonItem7");
            // 
            // LabelItem2
            // 
            _LabelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            _LabelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            _LabelItem2.Name = "LabelItem2";
            _LabelItem2.PaddingBottom = 1;
            _LabelItem2.PaddingLeft = 10;
            _LabelItem2.PaddingTop = 1;
            _LabelItem2.SingleLineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(197)), Conversions.ToInteger(Conversions.ToByte(197)), Conversions.ToInteger(Conversions.ToByte(197)));
            resources.ApplyResources(_LabelItem2, "LabelItem2");
            // 
            // ButtonItem8
            // 
            _ButtonItem8.Image = My.Resources.MyIcons.icons8_map_16px;
            _ButtonItem8.Name = "ButtonItem8";
            resources.ApplyResources(_ButtonItem8, "ButtonItem8");
            // 
            // ButtonItem10
            // 
            _ButtonItem10.Image = My.Resources.MyIcons.icons8_music_16px;
            _ButtonItem10.Name = "ButtonItem10";
            resources.ApplyResources(_ButtonItem10, "ButtonItem10");
            // 
            // ButtonItem11
            // 
            _ButtonItem11.Image = My.Resources.MyIcons.icons8_text_16px;
            _ButtonItem11.Name = "ButtonItem11";
            resources.ApplyResources(_ButtonItem11, "ButtonItem11");
            // 
            // LabelItem3
            // 
            _LabelItem3.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            _LabelItem3.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            _LabelItem3.Name = "LabelItem3";
            _LabelItem3.PaddingBottom = 1;
            _LabelItem3.PaddingLeft = 10;
            _LabelItem3.PaddingTop = 1;
            _LabelItem3.SingleLineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(197)), Conversions.ToInteger(Conversions.ToByte(197)), Conversions.ToInteger(Conversions.ToByte(197)));
            resources.ApplyResources(_LabelItem3, "LabelItem3");
            // 
            // ButtonItem_ModelImporter
            // 
            _ButtonItem_ModelImporter.Icon = (Icon)resources.GetObject("ButtonItem_ModelImporter.Icon");
            _ButtonItem_ModelImporter.Name = "ButtonItem_ModelImporter";
            resources.ApplyResources(_ButtonItem_ModelImporter, "ButtonItem_ModelImporter");
            // 
            // ButtonItem17
            // 
            _ButtonItem17.Image = My.Resources.MyIcons.icons8_pills_16px;
            _ButtonItem17.Name = "ButtonItem17";
            resources.ApplyResources(_ButtonItem17, "ButtonItem17");
            // 
            // ButtonItem_TrajectoryEditor
            // 
            _ButtonItem_TrajectoryEditor.Image = My.Resources.MyIcons.icons8_edit_node_16px;
            _ButtonItem_TrajectoryEditor.Name = "ButtonItem_TrajectoryEditor";
            resources.ApplyResources(_ButtonItem_TrajectoryEditor, "ButtonItem_TrajectoryEditor");
            // 
            // ButtonItem14
            // 
            _ButtonItem14.Name = "ButtonItem14";
            resources.ApplyResources(_ButtonItem14, "ButtonItem14");
            // 
            // ButtonItem13
            // 
            _ButtonItem13.Image = My.Resources.MyIcons.icons8_filled_star_location_16px;
            _ButtonItem13.Name = "ButtonItem13";
            resources.ApplyResources(_ButtonItem13, "ButtonItem13");
            // 
            // ButtonItem15
            // 
            _ButtonItem15.Image = My.Resources.MyIcons.icons8_variation_16px;
            _ButtonItem15.Name = "ButtonItem15";
            resources.ApplyResources(_ButtonItem15, "ButtonItem15");
            // 
            // ButtonItem16
            // 
            _ButtonItem16.Image = My.Resources.MyIcons.icons8_coins_16px;
            _ButtonItem16.Name = "ButtonItem16";
            resources.ApplyResources(_ButtonItem16, "ButtonItem16");
            // 
            // ButtonItem18
            // 
            _ButtonItem18.Name = "ButtonItem18";
            resources.ApplyResources(_ButtonItem18, "ButtonItem18");
            // 
            // ButtonItem_HudOptions
            // 
            _ButtonItem_HudOptions.Name = "ButtonItem_HudOptions";
            resources.ApplyResources(_ButtonItem_HudOptions, "ButtonItem_HudOptions");
            // 
            // ButtonItem22
            // 
            _ButtonItem22.Name = "ButtonItem22";
            _ButtonItem22.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem1, _ButtonItem9, _ButtonItem_M64ToMidiConverter });
            resources.ApplyResources(_ButtonItem22, "ButtonItem22");
            // 
            // ButtonItem1
            // 
            _ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem1.Image = My.Resources.MyIcons.icons8_text_16px;
            _ButtonItem1.Name = "ButtonItem1";
            _ButtonItem1.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem1, "ButtonItem1");
            // 
            // ButtonItem9
            // 
            _ButtonItem9.Image = My.Resources.MyIcons.icons8_syringe_16px;
            _ButtonItem9.Name = "ButtonItem9";
            resources.ApplyResources(_ButtonItem9, "ButtonItem9");
            // 
            // ButtonItem_M64ToMidiConverter
            // 
            _ButtonItem_M64ToMidiConverter.Image = My.Resources.MyIcons.icons8_music_16px;
            _ButtonItem_M64ToMidiConverter.Name = "ButtonItem_M64ToMidiConverter";
            resources.ApplyResources(_ButtonItem_M64ToMidiConverter, "ButtonItem_M64ToMidiConverter");
            // 
            // ButtonItem12
            // 
            _ButtonItem12.Name = "ButtonItem12";
            _ButtonItem12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem23 });
            resources.ApplyResources(_ButtonItem12, "ButtonItem12");
            // 
            // ButtonItem23
            // 
            _ButtonItem23.Name = "ButtonItem23";
            _ButtonItem23.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9);
            resources.ApplyResources(_ButtonItem23, "ButtonItem23");
            // 
            // ButtonItem_Bar_Plugins
            // 
            _ButtonItem_Bar_Plugins.BeginGroup = true;
            _ButtonItem_Bar_Plugins.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_Bar_Plugins.Name = "ButtonItem_Bar_Plugins";
            _ButtonItem_Bar_Plugins.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem20 });
            _ButtonItem_Bar_Plugins.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_Bar_Plugins, "ButtonItem_Bar_Plugins");
            // 
            // ButtonItem20
            // 
            _ButtonItem20.Image = My.Resources.MyIcons.icons8_plugin_16px;
            _ButtonItem20.Name = "ButtonItem20";
            resources.ApplyResources(_ButtonItem20, "ButtonItem20");
            // 
            // ButtonItem558
            // 
            _ButtonItem558.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem558.Name = "ButtonItem558";
            _ButtonItem558.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem25, _ButtonItem5, _ButtonItem19, _ButtonItem4, _ButtonItem_Bar_EnableExpertMode, _ButtonItem27, _ButtonItem28, _ButtonItem29 });
            _ButtonItem558.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem558, "ButtonItem558");
            // 
            // ButtonItem25
            // 
            _ButtonItem25.Image = My.Resources.MyIcons.icons8_settings_16px;
            _ButtonItem25.Name = "ButtonItem25";
            _ButtonItem25.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem25, "ButtonItem25");
            // 
            // ButtonItem5
            // 
            _ButtonItem5.Image = My.Resources.MyIcons.icons8_color_dropper_16px;
            _ButtonItem5.Name = "ButtonItem5";
            _ButtonItem5.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem5, "ButtonItem5");
            // 
            // ButtonItem19
            // 
            _ButtonItem19.BeginGroup = true;
            _ButtonItem19.Name = "ButtonItem19";
            resources.ApplyResources(_ButtonItem19, "ButtonItem19");
            // 
            // ButtonItem4
            // 
            _ButtonItem4.Name = "ButtonItem4";
            resources.ApplyResources(_ButtonItem4, "ButtonItem4");
            // 
            // ButtonItem_Bar_EnableExpertMode
            // 
            _ButtonItem_Bar_EnableExpertMode.AutoCheckOnClick = true;
            _ButtonItem_Bar_EnableExpertMode.BeginGroup = true;
            _ButtonItem_Bar_EnableExpertMode.Name = "ButtonItem_Bar_EnableExpertMode";
            resources.ApplyResources(_ButtonItem_Bar_EnableExpertMode, "ButtonItem_Bar_EnableExpertMode");
            _ButtonItem_Bar_EnableExpertMode.Visible = false;
            // 
            // ButtonItem27
            // 
            _ButtonItem27.BeginGroup = true;
            _ButtonItem27.Image = My.Resources.MyIcons.icons8_help_16px;
            _ButtonItem27.Name = "ButtonItem27";
            _ButtonItem27.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem27.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem27, "ButtonItem27");
            _ButtonItem27.Visible = false;
            // 
            // ButtonItem28
            // 
            _ButtonItem28.Image = (Image)resources.GetObject("ButtonItem28.Image");
            _ButtonItem28.Name = "ButtonItem28";
            resources.ApplyResources(_ButtonItem28, "ButtonItem28");
            _ButtonItem28.Visible = false;
            // 
            // ButtonItem29
            // 
            _ButtonItem29.BeginGroup = true;
            _ButtonItem29.Image = My.Resources.MyIcons.icons8_downloading_updates_16px;
            _ButtonItem29.Name = "ButtonItem29";
            _ButtonItem29.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem29, "ButtonItem29");
            // 
            // ButtonItem24
            // 
            _ButtonItem24.Name = "ButtonItem24";
            _ButtonItem24.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_BugReport, _ButtonItem_FeatureRequest, _ButtonItem21, _ButtonItem_Supporter, _ButtonItem30 });
            resources.ApplyResources(_ButtonItem24, "ButtonItem24");
            // 
            // ButtonItem_BugReport
            // 
            _ButtonItem_BugReport.Name = "ButtonItem_BugReport";
            resources.ApplyResources(_ButtonItem_BugReport, "ButtonItem_BugReport");
            // 
            // ButtonItem_FeatureRequest
            // 
            _ButtonItem_FeatureRequest.Name = "ButtonItem_FeatureRequest";
            resources.ApplyResources(_ButtonItem_FeatureRequest, "ButtonItem_FeatureRequest");
            // 
            // ButtonItem21
            // 
            _ButtonItem21.Name = "ButtonItem21";
            resources.ApplyResources(_ButtonItem21, "ButtonItem21");
            // 
            // ButtonItem_Supporter
            // 
            _ButtonItem_Supporter.BeginGroup = true;
            _ButtonItem_Supporter.Name = "ButtonItem_Supporter";
            resources.ApplyResources(_ButtonItem_Supporter, "ButtonItem_Supporter");
            // 
            // ButtonItem30
            // 
            _ButtonItem30.Image = My.Resources.MyIcons.icons8_about_16px;
            _ButtonItem30.Name = "ButtonItem30";
            _ButtonItem30.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem30.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem30, "ButtonItem30");
            // 
            // Bar1
            // 
            _Bar1.AntiAlias = true;
            _Bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            resources.ApplyResources(_Bar1, "Bar1");
            _Bar1.IsMaximized = false;
            _Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _LabelItem1, _LabelItem_OtherInfoText });
            _Bar1.Name = "Bar1";
            _Bar1.Stretch = true;
            _Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Bar1.TabStop = false;
            // 
            // LabelItem1
            // 
            _LabelItem1.Name = "LabelItem1";
            // 
            // LabelItem_OtherInfoText
            // 
            _LabelItem_OtherInfoText.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            _LabelItem_OtherInfoText.Name = "LabelItem_OtherInfoText";
            // 
            // RibbonControl1
            // 
            _RibbonControl1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            // 
            // 
            // 
            _RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonControl1.CanCustomize = false;
            _RibbonControl1.CaptionVisible = true;
            resources.ApplyResources(_RibbonControl1, "RibbonControl1");
            _RibbonControl1.ForeColor = Color.Black;
            _RibbonControl1.KeyTipsFont = new Font("Tahoma", 7.0F);
            _RibbonControl1.Name = "RibbonControl1";
            _RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonControl1.SystemText.MaximizeRibbonText = resources.GetString("RibbonControl1.SystemText.MaximizeRibbonText");
            _RibbonControl1.SystemText.MinimizeRibbonText = resources.GetString("RibbonControl1.SystemText.MinimizeRibbonText");
            _RibbonControl1.SystemText.QatAddItemText = resources.GetString("RibbonControl1.SystemText.QatAddItemText");
            _RibbonControl1.SystemText.QatCustomizeMenuLabel = resources.GetString("RibbonControl1.SystemText.QatCustomizeMenuLabel");
            _RibbonControl1.SystemText.QatCustomizeText = resources.GetString("RibbonControl1.SystemText.QatCustomizeText");
            _RibbonControl1.SystemText.QatDialogAddButton = resources.GetString("RibbonControl1.SystemText.QatDialogAddButton");
            _RibbonControl1.SystemText.QatDialogCancelButton = resources.GetString("RibbonControl1.SystemText.QatDialogCancelButton");
            _RibbonControl1.SystemText.QatDialogCaption = resources.GetString("RibbonControl1.SystemText.QatDialogCaption");
            _RibbonControl1.SystemText.QatDialogCategoriesLabel = resources.GetString("RibbonControl1.SystemText.QatDialogCategoriesLabel");
            _RibbonControl1.SystemText.QatDialogOkButton = resources.GetString("RibbonControl1.SystemText.QatDialogOkButton");
            _RibbonControl1.SystemText.QatDialogPlacementCheckbox = resources.GetString("RibbonControl1.SystemText.QatDialogPlacementCheckbox");
            _RibbonControl1.SystemText.QatDialogRemoveButton = resources.GetString("RibbonControl1.SystemText.QatDialogRemoveButton");
            _RibbonControl1.SystemText.QatPlaceAboveRibbonText = resources.GetString("RibbonControl1.SystemText.QatPlaceAboveRibbonText");
            _RibbonControl1.SystemText.QatPlaceBelowRibbonText = resources.GetString("RibbonControl1.SystemText.QatPlaceBelowRibbonText");
            _RibbonControl1.SystemText.QatRemoveItemText = resources.GetString("RibbonControl1.SystemText.QatRemoveItemText");
            _RibbonControl1.TabGroupHeight = 14;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_RibbonControl1);
            Controls.Add(_Bar1);
            Controls.Add(_Panel1);
            Name = "MainForm";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_TabControl1).EndInit();
            _TabControl1.ResumeLayout(false);
            _TabControlPanel1.ResumeLayout(false);
            _TabControlPanel4.ResumeLayout(false);
            _TabControlPanel3.ResumeLayout(false);
            _TabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_Bar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Bar1).EndInit();
            ResumeLayout(false);
        }

        /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
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
                    _TabControl1.SelectedTabChanged -= TabControl_Main_SelectedIndexChanged;
                    _TabControl1.SelectedTabChanging -= SuperTabControl_Main_SelectedTabChanging;
                    _TabControl1.TabItemClose -= SuperTabControl_Main_TabItemClose;
                    _TabControl1.ControlAdded -= SuperTabControl_Main_ControlAdded;
                }

                _TabControl1 = value;
                if (_TabControl1 != null)
                {
                    _TabControl1.SelectedTabChanged += TabControl_Main_SelectedIndexChanged;
                    _TabControl1.SelectedTabChanging += SuperTabControl_Main_SelectedTabChanging;
                    _TabControl1.TabItemClose += SuperTabControl_Main_TabItemClose;
                    _TabControl1.ControlAdded += SuperTabControl_Main_ControlAdded;
                }
            }
        }

        private DevComponents.DotNetBar.Bar _Bar2;

        internal DevComponents.DotNetBar.Bar Bar2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Bar2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Bar2 != null)
                {
                }

                _Bar2 = value;
                if (_Bar2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem2;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem2 != null)
                {
                }

                _ButtonItem2 = value;
                if (_ButtonItem2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem3;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem3 != null)
                {
                    _ButtonItem3.Click -= MenuItem_OpenROM_Click;
                }

                _ButtonItem3 = value;
                if (_ButtonItem3 != null)
                {
                    _ButtonItem3.Click += MenuItem_OpenROM_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_SaveRom;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_SaveRom
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_SaveRom;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_SaveRom != null)
                {
                    _ButtonItem_SaveRom.Click -= ButtonItem12_Click;
                }

                _ButtonItem_SaveRom = value;
                if (_ButtonItem_SaveRom != null)
                {
                    _ButtonItem_SaveRom.Click += ButtonItem12_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_LaunchROM;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_LaunchROM
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_LaunchROM;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_LaunchROM != null)
                {
                    _ButtonItem_LaunchROM.Click -= MenuItem_LaunchROM_Click;
                }

                _ButtonItem_LaunchROM = value;
                if (_ButtonItem_LaunchROM != null)
                {
                    _ButtonItem_LaunchROM.Click += MenuItem_LaunchROM_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem6;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem6 != null)
                {
                    _ButtonItem6.Click -= MenuItem11_Click;
                }

                _ButtonItem6 = value;
                if (_ButtonItem6 != null)
                {
                    _ButtonItem6.Click += MenuItem11_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem7;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem7 != null)
                {
                }

                _ButtonItem7 = value;
                if (_ButtonItem7 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelItem _LabelItem2;

        internal DevComponents.DotNetBar.LabelItem LabelItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelItem2 != null)
                {
                }

                _LabelItem2 = value;
                if (_LabelItem2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem8;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem8 != null)
                {
                    _ButtonItem8.Click -= MenuItem20_Click;
                }

                _ButtonItem8 = value;
                if (_ButtonItem8 != null)
                {
                    _ButtonItem8.Click += MenuItem20_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem10;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem10 != null)
                {
                    _ButtonItem10.Click -= MenuItem17_Click;
                }

                _ButtonItem10 = value;
                if (_ButtonItem10 != null)
                {
                    _ButtonItem10.Click += MenuItem17_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem11;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem11 != null)
                {
                    _ButtonItem11.Click -= MenuItem16_Click;
                }

                _ButtonItem11 = value;
                if (_ButtonItem11 != null)
                {
                    _ButtonItem11.Click += MenuItem16_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelItem _LabelItem3;

        internal DevComponents.DotNetBar.LabelItem LabelItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelItem3 != null)
                {
                }

                _LabelItem3 = value;
                if (_LabelItem3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ModelImporter;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ModelImporter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ModelImporter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ModelImporter != null)
                {
                    _ButtonItem_ModelImporter.Click -= ButtonItem_ModelImporter_Click;
                }

                _ButtonItem_ModelImporter = value;
                if (_ButtonItem_ModelImporter != null)
                {
                    _ButtonItem_ModelImporter.Click += ButtonItem_ModelImporter_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem17;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem17
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem17;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem17 != null)
                {
                    _ButtonItem17.Click -= ButtonItem17_Click;
                }

                _ButtonItem17 = value;
                if (_ButtonItem17 != null)
                {
                    _ButtonItem17.Click += ButtonItem17_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_TrajectoryEditor;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_TrajectoryEditor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_TrajectoryEditor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_TrajectoryEditor != null)
                {
                    _ButtonItem_TrajectoryEditor.Click -= ButtonItem_TrajectoryEditor_Click;
                }

                _ButtonItem_TrajectoryEditor = value;
                if (_ButtonItem_TrajectoryEditor != null)
                {
                    _ButtonItem_TrajectoryEditor.Click += ButtonItem_TrajectoryEditor_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem14;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem14
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem14;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem14 != null)
                {
                    _ButtonItem14.Click -= ButtonItem14_Click;
                }

                _ButtonItem14 = value;
                if (_ButtonItem14 != null)
                {
                    _ButtonItem14.Click += ButtonItem14_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem22;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem22
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem22;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem22 != null)
                {
                }

                _ButtonItem22 = value;
                if (_ButtonItem22 != null)
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
                    _ButtonItem1.Click -= ButtonItem1_Click;
                }

                _ButtonItem1 = value;
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click += ButtonItem1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem12;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem12 != null)
                {
                }

                _ButtonItem12 = value;
                if (_ButtonItem12 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem23;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem23
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem23;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem23 != null)
                {
                    _ButtonItem23.Click -= ButtonItem23_Click;
                }

                _ButtonItem23 = value;
                if (_ButtonItem23 != null)
                {
                    _ButtonItem23.Click += ButtonItem23_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Bar_Plugins;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Bar_Plugins
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Bar_Plugins;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Bar_Plugins != null)
                {
                }

                _ButtonItem_Bar_Plugins = value;
                if (_ButtonItem_Bar_Plugins != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem558;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem558
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem558;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem558 != null)
                {
                }

                _ButtonItem558 = value;
                if (_ButtonItem558 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem25;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem25
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem25;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem25 != null)
                {
                    _ButtonItem25.Click -= MenuItem_Settings_Click;
                }

                _ButtonItem25 = value;
                if (_ButtonItem25 != null)
                {
                    _ButtonItem25.Click += MenuItem_Settings_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem5;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem5 != null)
                {
                    _ButtonItem5.Click -= ButtonItem5_Click;
                }

                _ButtonItem5 = value;
                if (_ButtonItem5 != null)
                {
                    _ButtonItem5.Click += ButtonItem5_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Bar_EnableExpertMode;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Bar_EnableExpertMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Bar_EnableExpertMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Bar_EnableExpertMode != null)
                {
                }

                _ButtonItem_Bar_EnableExpertMode = value;
                if (_ButtonItem_Bar_EnableExpertMode != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem27;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem27
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem27;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem27 != null)
                {
                }

                _ButtonItem27 = value;
                if (_ButtonItem27 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem28;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem28
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem28;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem28 != null)
                {
                }

                _ButtonItem28 = value;
                if (_ButtonItem28 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem29;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem29
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem29;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem29 != null)
                {
                    _ButtonItem29.Click -= ButtonItem29_Click;
                }

                _ButtonItem29 = value;
                if (_ButtonItem29 != null)
                {
                    _ButtonItem29.Click += ButtonItem29_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem30;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem30
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem30;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem30 != null)
                {
                    _ButtonItem30.Click -= MenuItem_About_Click;
                }

                _ButtonItem30 = value;
                if (_ButtonItem30 != null)
                {
                    _ButtonItem30.Click += MenuItem_About_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelItem _LabelItem1;

        internal DevComponents.DotNetBar.LabelItem LabelItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelItem1 != null)
                {
                }

                _LabelItem1 = value;
                if (_LabelItem1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelItem _LabelItem_OtherInfoText;

        internal DevComponents.DotNetBar.LabelItem LabelItem_OtherInfoText
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelItem_OtherInfoText;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelItem_OtherInfoText != null)
                {
                }

                _LabelItem_OtherInfoText = value;
                if (_LabelItem_OtherInfoText != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabControlPanel _TabControlPanel1;

        internal DevComponents.DotNetBar.TabControlPanel TabControlPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControlPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControlPanel1 != null)
                {
                }

                _TabControlPanel1 = value;
                if (_TabControlPanel1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem_General;

        internal DevComponents.DotNetBar.TabItem TabItem_General
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem_General;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem_General != null)
                {
                }

                _TabItem_General = value;
                if (_TabItem_General != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabControlPanel _TabControlPanel2;

        internal DevComponents.DotNetBar.TabControlPanel TabControlPanel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControlPanel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControlPanel2 != null)
                {
                }

                _TabControlPanel2 = value;
                if (_TabControlPanel2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem_LevelManager;

        internal DevComponents.DotNetBar.TabItem TabItem_LevelManager
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem_LevelManager;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem_LevelManager != null)
                {
                }

                _TabItem_LevelManager = value;
                if (_TabItem_LevelManager != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabControlPanel _TabControlPanel3;

        internal DevComponents.DotNetBar.TabControlPanel TabControlPanel3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControlPanel3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControlPanel3 != null)
                {
                }

                _TabControlPanel3 = value;
                if (_TabControlPanel3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem_TextManager;

        internal DevComponents.DotNetBar.TabItem TabItem_TextManager
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem_TextManager;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem_TextManager != null)
                {
                }

                _TabItem_TextManager = value;
                if (_TabItem_TextManager != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabControlPanel _TabControlPanel4;

        internal DevComponents.DotNetBar.TabControlPanel TabControlPanel4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControlPanel4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControlPanel4 != null)
                {
                }

                _TabControlPanel4 = value;
                if (_TabControlPanel4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem_MusicManager;

        internal DevComponents.DotNetBar.TabItem TabItem_MusicManager
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem_MusicManager;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem_MusicManager != null)
                {
                }

                _TabItem_MusicManager = value;
                if (_TabItem_MusicManager != null)
                {
                }
            }
        }

        private Tab_General _tabGeneral;

        internal Tab_General tabGeneral
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tabGeneral;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabGeneral != null)
                {
                }

                _tabGeneral = value;
                if (_tabGeneral != null)
                {
                }
            }
        }

        private Tab_LevelManager _tabLevelManager;

        internal Tab_LevelManager tabLevelManager
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tabLevelManager;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabLevelManager != null)
                {
                }

                _tabLevelManager = value;
                if (_tabLevelManager != null)
                {
                }
            }
        }

        private Tab_MusicManager _tabMusicManager;

        internal Tab_MusicManager tabMusicManager
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tabMusicManager;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabMusicManager != null)
                {
                }

                _tabMusicManager = value;
                if (_tabMusicManager != null)
                {
                }
            }
        }

        private Tab_TextManager _tabTextManager;

        internal Tab_TextManager tabTextManager
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tabTextManager;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabTextManager != null)
                {
                }

                _tabTextManager = value;
                if (_tabTextManager != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem9;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem9 != null)
                {
                    _ButtonItem9.Click -= ButtonItem9_Click;
                }

                _ButtonItem9 = value;
                if (_ButtonItem9 != null)
                {
                    _ButtonItem9.Click += ButtonItem9_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem13;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem13
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem13;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem13 != null)
                {
                    _ButtonItem13.Click -= ButtonItem13_Click;
                }

                _ButtonItem13 = value;
                if (_ButtonItem13 != null)
                {
                    _ButtonItem13.Click += ButtonItem13_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_M64ToMidiConverter;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_M64ToMidiConverter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_M64ToMidiConverter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_M64ToMidiConverter != null)
                {
                    _ButtonItem_M64ToMidiConverter.Click -= ButtonItem_M64ToMidiConverter_Click;
                }

                _ButtonItem_M64ToMidiConverter = value;
                if (_ButtonItem_M64ToMidiConverter != null)
                {
                    _ButtonItem_M64ToMidiConverter.Click += ButtonItem_M64ToMidiConverter_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem15;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem15
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem15;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem15 != null)
                {
                    _ButtonItem15.Click -= ButtonItem15_Click;
                }

                _ButtonItem15 = value;
                if (_ButtonItem15 != null)
                {
                    _ButtonItem15.Click += ButtonItem15_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem16;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem16
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem16;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem16 != null)
                {
                    _ButtonItem16.Click -= ButtonItem16_Click;
                }

                _ButtonItem16 = value;
                if (_ButtonItem16 != null)
                {
                    _ButtonItem16.Click += ButtonItem16_Click;
                }
            }
        }

        private DevComponents.DotNetBar.RibbonControl _RibbonControl1;

        internal DevComponents.DotNetBar.RibbonControl RibbonControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonControl1 != null)
                {
                }

                _RibbonControl1 = value;
                if (_RibbonControl1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem19;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem19
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem19;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem19 != null)
                {
                    _ButtonItem19.Click -= ButtonItem19_Click;
                }

                _ButtonItem19 = value;
                if (_ButtonItem19 != null)
                {
                    _ButtonItem19.Click += ButtonItem19_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem18;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem18
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem18;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem18 != null)
                {
                    _ButtonItem18.Click -= ButtonItem18_Click;
                }

                _ButtonItem18 = value;
                if (_ButtonItem18 != null)
                {
                    _ButtonItem18.Click += ButtonItem18_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Bar_Plugins_ManagePlugins;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Bar_Plugins_ManagePlugins
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Bar_Plugins_ManagePlugins;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Bar_Plugins_ManagePlugins != null)
                {
                    _ButtonItem_Bar_Plugins_ManagePlugins.Click -= ButtonItem_Bar_Plugins_ManagePlugins_Click;
                }

                _ButtonItem_Bar_Plugins_ManagePlugins = value;
                if (_ButtonItem_Bar_Plugins_ManagePlugins != null)
                {
                    _ButtonItem_Bar_Plugins_ManagePlugins.Click += ButtonItem_Bar_Plugins_ManagePlugins_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem20;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem20
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem20;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem20 != null)
                {
                    _ButtonItem20.Click -= ButtonItem_Bar_Plugins_ManagePlugins_Click;
                }

                _ButtonItem20 = value;
                if (_ButtonItem20 != null)
                {
                    _ButtonItem20.Click += ButtonItem_Bar_Plugins_ManagePlugins_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem4;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem4 != null)
                {
                    _ButtonItem4.Click -= ButtonItem4_Click;
                }

                _ButtonItem4 = value;
                if (_ButtonItem4 != null)
                {
                    _ButtonItem4.Click += ButtonItem4_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem24;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem24
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem24;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem24 != null)
                {
                }

                _ButtonItem24 = value;
                if (_ButtonItem24 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_BugReport;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_BugReport
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_BugReport;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_BugReport != null)
                {
                    _ButtonItem_BugReport.Click -= ButtonItem_BugReport_Click;
                }

                _ButtonItem_BugReport = value;
                if (_ButtonItem_BugReport != null)
                {
                    _ButtonItem_BugReport.Click += ButtonItem_BugReport_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_FeatureRequest;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_FeatureRequest
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_FeatureRequest;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_FeatureRequest != null)
                {
                    _ButtonItem_FeatureRequest.Click -= ButtonItem_FeatureRequest_Click;
                }

                _ButtonItem_FeatureRequest = value;
                if (_ButtonItem_FeatureRequest != null)
                {
                    _ButtonItem_FeatureRequest.Click += ButtonItem_FeatureRequest_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Supporter;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Supporter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Supporter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Supporter != null)
                {
                    _ButtonItem_Supporter.Click -= ButtonItem_Supporter_Click;
                }

                _ButtonItem_Supporter = value;
                if (_ButtonItem_Supporter != null)
                {
                    _ButtonItem_Supporter.Click += ButtonItem_Supporter_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem21;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem21
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem21;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem21 != null)
                {
                    _ButtonItem21.Click -= ButtonItem21_Click;
                }

                _ButtonItem21 = value;
                if (_ButtonItem21 != null)
                {
                    _ButtonItem21.Click += ButtonItem21_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_HudOptions;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_HudOptions
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_HudOptions;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_HudOptions != null)
                {
                    _ButtonItem_HudOptions.Click -= ButtonItem_HudOptions_Click;
                }

                _ButtonItem_HudOptions = value;
                if (_ButtonItem_HudOptions != null)
                {
                    _ButtonItem_HudOptions.Click += ButtonItem_HudOptions_Click;
                }
            }
        }
    }
}