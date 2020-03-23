using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    [DesignerGenerated()]
    public partial class EditorWindow : DevComponents.DotNetBar.RibbonForm
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorWindow));
            _SuperTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            _SuperTabControl1.SelectedTabChanged += new EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(SuperTabControl1_SelectedTabChanged);
            _SuperTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            _LayoutControl2 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _LabelX_UI_UpdateInstallerExeDownloadlink = new DevComponents.DotNetBar.LabelX();
            _LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _SuperTabItem_UI_General = new DevComponents.DotNetBar.SuperTabItem();
            _SuperTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            _LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _LabelX_UI_PackageVersion = new DevComponents.DotNetBar.LabelX();
            _LabelX_UI_PackageChannel = new DevComponents.DotNetBar.LabelX();
            _LabelX_UI_PackageBuild = new DevComponents.DotNetBar.LabelX();
            _LabelX_UI_PackageDownloadlink = new DevComponents.DotNetBar.LabelX();
            _LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            _LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _SuperTabItem_UI_PackageInfo = new DevComponents.DotNetBar.SuperTabItem();
            _SuperTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            _Panel3 = new Panel();
            _TextBoxX_UI_PackageChangelog = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            _TextBoxX_UI_PackageChangelog.TextChanged += new EventHandler(TextBoxX_UI_PackageChangelog_TextChanged);
            _SuperTabItem_UI_Changelog = new DevComponents.DotNetBar.SuperTabItem();
            _SuperTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            _Panel4 = new Panel();
            _ListViewEx_Files = new DevComponents.DotNetBar.Controls.ListViewEx();
            _ColumnHeader1 = new ColumnHeader();
            _ColumnHeader2 = new ColumnHeader();
            _SuperTabItem_Pkg_Extensions = new DevComponents.DotNetBar.SuperTabItem();
            _SuperTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            _AdvTree1 = new DevComponents.AdvTree.AdvTree();
            _NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            _ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            _SuperTabItem_Pkg_Files = new DevComponents.DotNetBar.SuperTabItem();
            _RibbonControl_Main = new DevComponents.DotNetBar.RibbonControl();
            _RibbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            _RibbonBar_UI_PackageInfo = new DevComponents.DotNetBar.RibbonBar();
            _ItemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            _ComboBoxItem_UI_PackageInfoList = new DevComponents.DotNetBar.ComboBoxItem();
            _ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += new EventHandler(ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged);
            _ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += new EventHandler(ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged);
            _ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += new EventHandler(ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged);
            _ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += new EventHandler(ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged);
            _ButtonItem_UI_AddPackageInfo = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_UI_AddPackageInfo.Click += new EventHandler(ButtonItem_UI_AddPackageInfo_Click);
            _ButtonItem_UI_DeletePackageInfo = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_UI_DeletePackageInfo.Click += new EventHandler(ButtonItem_UI_DeletePackageInfo_Click);
            _ButtonItem_UI_EditVersion = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_UI_EditVersion.Click += new EventHandler(ButtonItem_UI_EditVersion_Click);
            _ButtonItem_UI_EditDownloadlink = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_UI_EditDownloadlink.Click += new EventHandler(ButtonItem_UI_EditDownloadlink_Click);
            _RibbonBar_UI_Allgemein = new DevComponents.DotNetBar.RibbonBar();
            _ButtonItem_UI_EditConfiguration = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_UI_EditConfiguration.Click += new EventHandler(ButtonItem_UI_EditConfiguration_Click);
            _RibbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            _ButtonItem_UI_NewPackage = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_UI_NewPackage.Click += new EventHandler(ButtonItem_UI_NewPackage_Click);
            _ButtonItem_UI_Open = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_UI_Open.Click += new EventHandler(ButtonItem_UI_Open_Click);
            _ButtonItem_UI_Save = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_UI_Save.Click += new EventHandler(ButtonItem_UI_Save_Click);
            _ButtonItem_UI_SaveAs = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_UI_SaveAs.Click += new EventHandler(ButtonItem_UI_SaveAs_Click);
            _RibbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            _RibbonBar_Pkg_Erweiterungen = new DevComponents.DotNetBar.RibbonBar();
            _ButtonItem_Pkg_AddExtension = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Pkg_AddExtension.Click += new EventHandler(ButtonItem_Pkg_AddExtension_Click);
            _ButtonItem_Pkg_RemoveExtension = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Pkg_RemoveExtension.Click += new EventHandler(ButtonItem_Pkg_RemoveExtension_Click);
            _RibbonBar_Pkg_Dateien = new DevComponents.DotNetBar.RibbonBar();
            _ButtonItem_Pkg_SelectFileFolder = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Pkg_SelectFileFolder.Click += new EventHandler(ButtonItem_Pkg_SelectFileFolder_Click);
            _ButtonItem_Pkg_RemoveFileFolder = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Pkg_RemoveFileFolder.Click += new EventHandler(ButtonItem_Pkg_RemoveFileFolder_Click);
            _RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            _ButtonItem_ButtonItem_Pkg_Export = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ButtonItem_Pkg_Export.Click += new EventHandler(ButtonItem_ButtonItem_Pkg_Export_Click);
            _RibbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            _ButtonItem_Pkg_NewTemplate = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Pkg_NewTemplate.Click += new EventHandler(ButtonItem_Pkg_NewTemplate_Click);
            _ButtonItem_Pkg_OpenTemplate = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Pkg_OpenTemplate.Click += new EventHandler(ButtonItem_Pkg_OpenTemplate_Click);
            _ButtonItem_Pkg_SaveTemplate = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Pkg_SaveTemplate.Click += new EventHandler(ButtonItem_Pkg_SaveTemplate_Click);
            _ButtonItem_Pkg_SaveTemplateAs = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Pkg_SaveTemplateAs.Click += new EventHandler(ButtonItem_Pkg_SaveTemplateAs_Click);
            _RibbonTabItem_UpdateInfo = new DevComponents.DotNetBar.RibbonTabItem();
            _RibbonTabItem_Packaging = new DevComponents.DotNetBar.RibbonTabItem();
            ((System.ComponentModel.ISupportInitialize)_SuperTabControl1).BeginInit();
            _SuperTabControl1.SuspendLayout();
            _SuperTabControlPanel1.SuspendLayout();
            _LayoutControl2.SuspendLayout();
            _SuperTabControlPanel5.SuspendLayout();
            _LayoutControl1.SuspendLayout();
            _SuperTabControlPanel3.SuspendLayout();
            _Panel3.SuspendLayout();
            _SuperTabControlPanel4.SuspendLayout();
            _Panel4.SuspendLayout();
            _SuperTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_AdvTree1).BeginInit();
            _RibbonControl_Main.SuspendLayout();
            _RibbonPanel2.SuspendLayout();
            _RibbonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SuperTabControl1
            // 
            _SuperTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _SuperTabControl1.BackColor = Color.Transparent;
            // 
            // 
            // 
            // 
            // 
            // 
            _SuperTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            _SuperTabControl1.ControlBox.MenuBox.Name = "";
            _SuperTabControl1.ControlBox.Name = "";
            _SuperTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _SuperTabControl1.ControlBox.MenuBox, _SuperTabControl1.ControlBox.CloseBox });
            _SuperTabControl1.Controls.Add(_SuperTabControlPanel1);
            _SuperTabControl1.Controls.Add(_SuperTabControlPanel5);
            _SuperTabControl1.Controls.Add(_SuperTabControlPanel3);
            _SuperTabControl1.Controls.Add(_SuperTabControlPanel4);
            _SuperTabControl1.Controls.Add(_SuperTabControlPanel2);
            _SuperTabControl1.ForeColor = Color.Black;
            _SuperTabControl1.Location = new Point(1, 155);
            _SuperTabControl1.Name = "SuperTabControl1";
            _SuperTabControl1.ReorderTabsEnabled = true;
            _SuperTabControl1.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            _SuperTabControl1.SelectedTabIndex = 0;
            _SuperTabControl1.Size = new Size(648, 394);
            _SuperTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            _SuperTabControl1.TabFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _SuperTabControl1.TabIndex = 1;
            _SuperTabControl1.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            _SuperTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] { _SuperTabItem_UI_General, _SuperTabItem_UI_PackageInfo, _SuperTabItem_UI_Changelog, _SuperTabItem_Pkg_Files, _SuperTabItem_Pkg_Extensions });
            _SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            _SuperTabControl1.Text = "SuperTabControl1";
            // 
            // SuperTabControlPanel1
            // 
            _SuperTabControlPanel1.Controls.Add(_LayoutControl2);
            _SuperTabControlPanel1.Dock = DockStyle.Fill;
            _SuperTabControlPanel1.Location = new Point(98, 0);
            _SuperTabControlPanel1.Name = "SuperTabControlPanel1";
            _SuperTabControlPanel1.Size = new Size(550, 394);
            _SuperTabControlPanel1.TabIndex = 0;
            _SuperTabControlPanel1.TabItem = _SuperTabItem_UI_General;
            // 
            // LayoutControl2
            // 
            _LayoutControl2.BackColor = Color.Transparent;
            _LayoutControl2.Controls.Add(_LabelX_UI_UpdateInstallerExeDownloadlink);
            _LayoutControl2.Dock = DockStyle.Fill;
            _LayoutControl2.ForeColor = Color.Black;
            _LayoutControl2.Location = new Point(0, 0);
            _LayoutControl2.Name = "LayoutControl2";
            // 
            // 
            // 
            _LayoutControl2.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem6 });
            _LayoutControl2.Size = new Size(550, 394);
            _LayoutControl2.TabIndex = 0;
            // 
            // LabelX_UI_UpdateInstallerExeDownloadlink
            // 
            // 
            // 
            // 
            _LabelX_UI_UpdateInstallerExeDownloadlink.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_UI_UpdateInstallerExeDownloadlink.Location = new Point(183, 4);
            _LabelX_UI_UpdateInstallerExeDownloadlink.Margin = new Padding(0);
            _LabelX_UI_UpdateInstallerExeDownloadlink.Name = "LabelX_UI_UpdateInstallerExeDownloadlink";
            _LabelX_UI_UpdateInstallerExeDownloadlink.Size = new Size(363, 23);
            _LabelX_UI_UpdateInstallerExeDownloadlink.TabIndex = 0;
            _LabelX_UI_UpdateInstallerExeDownloadlink.Text = "-";
            _LabelX_UI_UpdateInstallerExeDownloadlink.WordWrap = true;
            // 
            // LayoutControlItem6
            // 
            _LayoutControlItem6.Control = _LabelX_UI_UpdateInstallerExeDownloadlink;
            _LayoutControlItem6.Height = 31;
            _LayoutControlItem6.MinSize = new Size(64, 18);
            _LayoutControlItem6.Name = "LayoutControlItem6";
            _LayoutControlItem6.Text = "UpdateInstaller.exe Downloadlink:";
            _LayoutControlItem6.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem6.TextPadding = new Padding(0, 1, 0, 0);
            _LayoutControlItem6.Width = 100;
            _LayoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SuperTabItem_UI_General
            // 
            _SuperTabItem_UI_General.AttachedControl = _SuperTabControlPanel1;
            _SuperTabItem_UI_General.GlobalItem = false;
            _SuperTabItem_UI_General.Name = "SuperTabItem_UI_General";
            _SuperTabItem_UI_General.Text = "Allgemein";
            // 
            // SuperTabControlPanel5
            // 
            _SuperTabControlPanel5.Controls.Add(_LayoutControl1);
            _SuperTabControlPanel5.Dock = DockStyle.Fill;
            _SuperTabControlPanel5.Location = new Point(98, 0);
            _SuperTabControlPanel5.Name = "SuperTabControlPanel5";
            _SuperTabControlPanel5.Size = new Size(550, 394);
            _SuperTabControlPanel5.TabIndex = 0;
            _SuperTabControlPanel5.TabItem = _SuperTabItem_UI_PackageInfo;
            // 
            // LayoutControl1
            // 
            _LayoutControl1.BackColor = Color.Transparent;
            _LayoutControl1.Controls.Add(_LabelX_UI_PackageVersion);
            _LayoutControl1.Controls.Add(_LabelX_UI_PackageChannel);
            _LayoutControl1.Controls.Add(_LabelX_UI_PackageBuild);
            _LayoutControl1.Controls.Add(_LabelX_UI_PackageDownloadlink);
            _LayoutControl1.Dock = DockStyle.Fill;
            _LayoutControl1.ForeColor = Color.Black;
            _LayoutControl1.Location = new Point(0, 0);
            _LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            _LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem2, _LayoutControlItem3, _LayoutControlItem4, _LayoutSpacerItem1, _LayoutControlItem5 });
            _LayoutControl1.Size = new Size(550, 394);
            _LayoutControl1.TabIndex = 0;
            // 
            // LabelX_UI_PackageVersion
            // 
            _LabelX_UI_PackageVersion.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_UI_PackageVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_UI_PackageVersion.Location = new Point(60, 4);
            _LabelX_UI_PackageVersion.Margin = new Padding(0);
            _LabelX_UI_PackageVersion.Name = "LabelX_UI_PackageVersion";
            _LabelX_UI_PackageVersion.Size = new Size(486, 23);
            _LabelX_UI_PackageVersion.TabIndex = 0;
            _LabelX_UI_PackageVersion.Text = "-";
            // 
            // LabelX_UI_PackageChannel
            // 
            _LabelX_UI_PackageChannel.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_UI_PackageChannel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_UI_PackageChannel.Location = new Point(60, 35);
            _LabelX_UI_PackageChannel.Margin = new Padding(0);
            _LabelX_UI_PackageChannel.Name = "LabelX_UI_PackageChannel";
            _LabelX_UI_PackageChannel.Size = new Size(486, 23);
            _LabelX_UI_PackageChannel.TabIndex = 1;
            _LabelX_UI_PackageChannel.Text = "-";
            // 
            // LabelX_UI_PackageBuild
            // 
            _LabelX_UI_PackageBuild.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_UI_PackageBuild.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_UI_PackageBuild.Location = new Point(60, 66);
            _LabelX_UI_PackageBuild.Margin = new Padding(0);
            _LabelX_UI_PackageBuild.Name = "LabelX_UI_PackageBuild";
            _LabelX_UI_PackageBuild.Size = new Size(486, 23);
            _LabelX_UI_PackageBuild.TabIndex = 2;
            _LabelX_UI_PackageBuild.Text = "-";
            // 
            // LabelX_UI_PackageDownloadlink
            // 
            _LabelX_UI_PackageDownloadlink.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_UI_PackageDownloadlink.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_UI_PackageDownloadlink.Location = new Point(60, 129);
            _LabelX_UI_PackageDownloadlink.Margin = new Padding(0);
            _LabelX_UI_PackageDownloadlink.Name = "LabelX_UI_PackageDownloadlink";
            _LabelX_UI_PackageDownloadlink.Size = new Size(486, 23);
            _LabelX_UI_PackageDownloadlink.TabIndex = 4;
            _LabelX_UI_PackageDownloadlink.Text = "-";
            _LabelX_UI_PackageDownloadlink.WordWrap = true;
            // 
            // LayoutControlItem2
            // 
            _LayoutControlItem2.Control = _LabelX_UI_PackageVersion;
            _LayoutControlItem2.Height = 31;
            _LayoutControlItem2.MinSize = new Size(64, 18);
            _LayoutControlItem2.Name = "LayoutControlItem2";
            _LayoutControlItem2.Text = "Version:";
            _LayoutControlItem2.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem2.TextPadding = new Padding(0, 1, 0, 0);
            _LayoutControlItem2.Width = 100;
            _LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            _LayoutControlItem3.Control = _LabelX_UI_PackageChannel;
            _LayoutControlItem3.Height = 31;
            _LayoutControlItem3.MinSize = new Size(64, 18);
            _LayoutControlItem3.Name = "LayoutControlItem3";
            _LayoutControlItem3.Text = "Kanal:";
            _LayoutControlItem3.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem3.TextPadding = new Padding(0, 1, 0, 0);
            _LayoutControlItem3.Width = 100;
            _LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            _LayoutControlItem4.Control = _LabelX_UI_PackageBuild;
            _LayoutControlItem4.Height = 31;
            _LayoutControlItem4.MinSize = new Size(64, 18);
            _LayoutControlItem4.Name = "LayoutControlItem4";
            _LayoutControlItem4.Text = "Build:";
            _LayoutControlItem4.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem4.TextPadding = new Padding(0, 1, 0, 0);
            _LayoutControlItem4.Width = 100;
            _LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            _LayoutSpacerItem1.Height = 32;
            _LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            _LayoutSpacerItem1.Width = 100;
            _LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            _LayoutControlItem5.Control = _LabelX_UI_PackageDownloadlink;
            _LayoutControlItem5.Height = 31;
            _LayoutControlItem5.MinSize = new Size(64, 18);
            _LayoutControlItem5.Name = "LayoutControlItem5";
            _LayoutControlItem5.Text = "Paketlink:";
            _LayoutControlItem5.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem5.TextPadding = new Padding(0, 1, 0, 0);
            _LayoutControlItem5.Width = 100;
            _LayoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SuperTabItem_UI_PackageInfo
            // 
            _SuperTabItem_UI_PackageInfo.AttachedControl = _SuperTabControlPanel5;
            _SuperTabItem_UI_PackageInfo.GlobalItem = false;
            _SuperTabItem_UI_PackageInfo.Name = "SuperTabItem_UI_PackageInfo";
            _SuperTabItem_UI_PackageInfo.Text = "Paket-Info";
            // 
            // SuperTabControlPanel3
            // 
            _SuperTabControlPanel3.Controls.Add(_Panel3);
            _SuperTabControlPanel3.Dock = DockStyle.Fill;
            _SuperTabControlPanel3.Location = new Point(98, 0);
            _SuperTabControlPanel3.Name = "SuperTabControlPanel3";
            _SuperTabControlPanel3.Size = new Size(550, 394);
            _SuperTabControlPanel3.TabIndex = 0;
            _SuperTabControlPanel3.TabItem = _SuperTabItem_UI_Changelog;
            // 
            // Panel3
            // 
            _Panel3.BackColor = Color.Transparent;
            _Panel3.Controls.Add(_TextBoxX_UI_PackageChangelog);
            _Panel3.Dock = DockStyle.Fill;
            _Panel3.Location = new Point(0, 0);
            _Panel3.Name = "Panel3";
            _Panel3.Size = new Size(550, 394);
            _Panel3.TabIndex = 1;
            // 
            // TextBoxX_UI_PackageChangelog
            // 
            _TextBoxX_UI_PackageChangelog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _TextBoxX_UI_PackageChangelog.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_UI_PackageChangelog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_UI_PackageChangelog.ForeColor = Color.Black;
            _TextBoxX_UI_PackageChangelog.Location = new Point(0, 0);
            _TextBoxX_UI_PackageChangelog.Name = "TextBoxX_UI_PackageChangelog";
            _TextBoxX_UI_PackageChangelog.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fnil\fcharset0 Microsoft S" + "ans Serif;}}" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + @"\viewkind4\uc1\pard\f0\fs17\par" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "}" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
            _TextBoxX_UI_PackageChangelog.Size = new Size(550, 394);
            _TextBoxX_UI_PackageChangelog.TabIndex = 0;
            // 
            // SuperTabItem_UI_Changelog
            // 
            _SuperTabItem_UI_Changelog.AttachedControl = _SuperTabControlPanel3;
            _SuperTabItem_UI_Changelog.GlobalItem = false;
            _SuperTabItem_UI_Changelog.Name = "SuperTabItem_UI_Changelog";
            _SuperTabItem_UI_Changelog.Text = "Änderungsliste";
            // 
            // SuperTabControlPanel4
            // 
            _SuperTabControlPanel4.Controls.Add(_Panel4);
            _SuperTabControlPanel4.Dock = DockStyle.Fill;
            _SuperTabControlPanel4.Location = new Point(98, 0);
            _SuperTabControlPanel4.Name = "SuperTabControlPanel4";
            _SuperTabControlPanel4.Size = new Size(550, 394);
            _SuperTabControlPanel4.TabIndex = 0;
            _SuperTabControlPanel4.TabItem = _SuperTabItem_Pkg_Extensions;
            // 
            // Panel4
            // 
            _Panel4.BackColor = Color.Transparent;
            _Panel4.Controls.Add(_ListViewEx_Files);
            _Panel4.Dock = DockStyle.Fill;
            _Panel4.Location = new Point(0, 0);
            _Panel4.Name = "Panel4";
            _Panel4.Size = new Size(550, 394);
            _Panel4.TabIndex = 1;
            // 
            // ListViewEx_Files
            // 
            _ListViewEx_Files.BackColor = Color.White;
            // 
            // 
            // 
            _ListViewEx_Files.Border.Class = "ListViewBorder";
            _ListViewEx_Files.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx_Files.Columns.AddRange(new ColumnHeader[] { _ColumnHeader1, _ColumnHeader2 });
            _ListViewEx_Files.DisabledBackColor = Color.Empty;
            _ListViewEx_Files.Dock = DockStyle.Fill;
            _ListViewEx_Files.ForeColor = Color.Black;
            _ListViewEx_Files.FullRowSelect = true;
            _ListViewEx_Files.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _ListViewEx_Files.HideSelection = false;
            _ListViewEx_Files.Location = new Point(0, 0);
            _ListViewEx_Files.Name = "ListViewEx_Files";
            _ListViewEx_Files.Size = new Size(550, 394);
            _ListViewEx_Files.TabIndex = 0;
            _ListViewEx_Files.UseCompatibleStateImageBehavior = false;
            _ListViewEx_Files.View = View.Details;
            // 
            // ColumnHeader1
            // 
            _ColumnHeader1.Text = "Datei";
            _ColumnHeader1.Width = 150;
            // 
            // ColumnHeader2
            // 
            _ColumnHeader2.Text = "Ort";
            _ColumnHeader2.Width = 360;
            // 
            // SuperTabItem_Pkg_Extensions
            // 
            _SuperTabItem_Pkg_Extensions.AttachedControl = _SuperTabControlPanel4;
            _SuperTabItem_Pkg_Extensions.GlobalItem = false;
            _SuperTabItem_Pkg_Extensions.Name = "SuperTabItem_Pkg_Extensions";
            _SuperTabItem_Pkg_Extensions.Text = "Erweiterungen";
            // 
            // SuperTabControlPanel2
            // 
            _SuperTabControlPanel2.Controls.Add(_AdvTree1);
            _SuperTabControlPanel2.Dock = DockStyle.Fill;
            _SuperTabControlPanel2.Location = new Point(98, 0);
            _SuperTabControlPanel2.Name = "SuperTabControlPanel2";
            _SuperTabControlPanel2.Size = new Size(550, 394);
            _SuperTabControlPanel2.TabIndex = 0;
            _SuperTabControlPanel2.TabItem = _SuperTabItem_Pkg_Files;
            // 
            // AdvTree1
            // 
            _AdvTree1.AccessibleRole = AccessibleRole.Outline;
            _AdvTree1.BackColor = SystemColors.Window;
            // 
            // 
            // 
            _AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
            _AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _AdvTree1.Dock = DockStyle.Fill;
            _AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _AdvTree1.Location = new Point(0, 0);
            _AdvTree1.Name = "AdvTree1";
            _AdvTree1.NodesConnector = _NodeConnector1;
            _AdvTree1.NodeStyle = _ElementStyle1;
            _AdvTree1.PathSeparator = ";";
            _AdvTree1.Size = new Size(550, 394);
            _AdvTree1.Styles.Add(_ElementStyle1);
            _AdvTree1.TabIndex = 0;
            _AdvTree1.Text = "AdvTree1";
            // 
            // NodeConnector1
            // 
            _NodeConnector1.LineColor = SystemColors.ControlText;
            // 
            // ElementStyle1
            // 
            _ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ElementStyle1.Name = "ElementStyle1";
            _ElementStyle1.TextColor = SystemColors.ControlText;
            // 
            // SuperTabItem_Pkg_Files
            // 
            _SuperTabItem_Pkg_Files.AttachedControl = _SuperTabControlPanel2;
            _SuperTabItem_Pkg_Files.GlobalItem = false;
            _SuperTabItem_Pkg_Files.Name = "SuperTabItem_Pkg_Files";
            _SuperTabItem_Pkg_Files.Text = "Dateien";
            // 
            // RibbonControl_Main
            // 
            _RibbonControl_Main.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            // 
            // 
            // 
            _RibbonControl_Main.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonControl_Main.CanCustomize = false;
            _RibbonControl_Main.CaptionVisible = true;
            _RibbonControl_Main.Controls.Add(_RibbonPanel2);
            _RibbonControl_Main.Controls.Add(_RibbonPanel1);
            _RibbonControl_Main.Dock = DockStyle.Top;
            _RibbonControl_Main.ForeColor = Color.Black;
            _RibbonControl_Main.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _RibbonTabItem_UpdateInfo, _RibbonTabItem_Packaging });
            _RibbonControl_Main.KeyTipsFont = new Font("Tahoma", 7.0F);
            _RibbonControl_Main.Location = new Point(5, 1);
            _RibbonControl_Main.Name = "RibbonControl_Main";
            _RibbonControl_Main.Padding = new Padding(0, 0, 0, 3);
            _RibbonControl_Main.Size = new Size(640, 154);
            _RibbonControl_Main.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonControl_Main.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            _RibbonControl_Main.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            _RibbonControl_Main.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            _RibbonControl_Main.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            _RibbonControl_Main.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            _RibbonControl_Main.SystemText.QatDialogAddButton = "&Add >>";
            _RibbonControl_Main.SystemText.QatDialogCancelButton = "Cancel";
            _RibbonControl_Main.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            _RibbonControl_Main.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            _RibbonControl_Main.SystemText.QatDialogOkButton = "OK";
            _RibbonControl_Main.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            _RibbonControl_Main.SystemText.QatDialogRemoveButton = "&Remove";
            _RibbonControl_Main.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            _RibbonControl_Main.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            _RibbonControl_Main.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            _RibbonControl_Main.TabGroupHeight = 14;
            _RibbonControl_Main.TabIndex = 2;
            // 
            // RibbonPanel2
            // 
            _RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonPanel2.Controls.Add(_RibbonBar_UI_PackageInfo);
            _RibbonPanel2.Controls.Add(_RibbonBar_UI_Allgemein);
            _RibbonPanel2.Controls.Add(_RibbonBar2);
            _RibbonPanel2.Dock = DockStyle.Fill;
            _RibbonPanel2.Location = new Point(0, 56);
            _RibbonPanel2.Name = "RibbonPanel2";
            _RibbonPanel2.Padding = new Padding(3, 0, 3, 3);
            _RibbonPanel2.Size = new Size(640, 95);
            // 
            // 
            // 
            _RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonPanel2.TabIndex = 2;
            // 
            // RibbonBar_UI_PackageInfo
            // 
            _RibbonBar_UI_PackageInfo.AutoOverflowEnabled = true;
            // 
            // 
            // 
            _RibbonBar_UI_PackageInfo.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar_UI_PackageInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonBar_UI_PackageInfo.ContainerControlProcessDialogKey = true;
            _RibbonBar_UI_PackageInfo.Dock = DockStyle.Left;
            _RibbonBar_UI_PackageInfo.DragDropSupport = true;
            _RibbonBar_UI_PackageInfo.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ItemContainer1, _ButtonItem_UI_EditVersion, _ButtonItem_UI_EditDownloadlink });
            _RibbonBar_UI_PackageInfo.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _RibbonBar_UI_PackageInfo.Location = new Point(327, 0);
            _RibbonBar_UI_PackageInfo.Name = "RibbonBar_UI_PackageInfo";
            _RibbonBar_UI_PackageInfo.Size = new Size(302, 92);
            _RibbonBar_UI_PackageInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonBar_UI_PackageInfo.TabIndex = 1;
            _RibbonBar_UI_PackageInfo.Text = "Paket-Info";
            // 
            // 
            // 
            _RibbonBar_UI_PackageInfo.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar_UI_PackageInfo.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ItemContainer1
            // 
            // 
            // 
            // 
            _ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemContainer1.Name = "ItemContainer1";
            _ItemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ComboBoxItem_UI_PackageInfoList, _ButtonItem_UI_AddPackageInfo, _ButtonItem_UI_DeletePackageInfo });
            // 
            // 
            // 
            _ItemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ComboBoxItem_UI_PackageInfoList
            // 
            _ComboBoxItem_UI_PackageInfoList.ComboWidth = 150;
            _ComboBoxItem_UI_PackageInfoList.DropDownHeight = 106;
            _ComboBoxItem_UI_PackageInfoList.Name = "ComboBoxItem_UI_PackageInfoList";
            _ComboBoxItem_UI_PackageInfoList.Text = "ComboBoxItem_UI_PackageInfoList";
            // 
            // ButtonItem_UI_AddPackageInfo
            // 
            _ButtonItem_UI_AddPackageInfo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_UI_AddPackageInfo.Image = My.Resources.Resources.icons8_add_16px;
            _ButtonItem_UI_AddPackageInfo.Name = "ButtonItem_UI_AddPackageInfo";
            _ButtonItem_UI_AddPackageInfo.Text = "Neue Paket-Info";
            // 
            // ButtonItem_UI_DeletePackageInfo
            // 
            _ButtonItem_UI_DeletePackageInfo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_UI_DeletePackageInfo.Image = My.Resources.Resources.icons8_delete_sign_16px;
            _ButtonItem_UI_DeletePackageInfo.Name = "ButtonItem_UI_DeletePackageInfo";
            _ButtonItem_UI_DeletePackageInfo.Text = "Paket-Info löschen";
            // 
            // ButtonItem_UI_EditVersion
            // 
            _ButtonItem_UI_EditVersion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_UI_EditVersion.Image = My.Resources.Resources.icons8_versions_32px;
            _ButtonItem_UI_EditVersion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_UI_EditVersion.Name = "ButtonItem_UI_EditVersion";
            _ButtonItem_UI_EditVersion.SubItemsExpandWidth = 14;
            _ButtonItem_UI_EditVersion.Text = "Version bearbeiten";
            // 
            // ButtonItem_UI_EditDownloadlink
            // 
            _ButtonItem_UI_EditDownloadlink.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_UI_EditDownloadlink.Image = My.Resources.Resources.icons8_link_32px;
            _ButtonItem_UI_EditDownloadlink.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_UI_EditDownloadlink.Name = "ButtonItem_UI_EditDownloadlink";
            _ButtonItem_UI_EditDownloadlink.SubItemsExpandWidth = 14;
            _ButtonItem_UI_EditDownloadlink.Text = "Paketlink bearbeiten";
            // 
            // RibbonBar_UI_Allgemein
            // 
            _RibbonBar_UI_Allgemein.AutoOverflowEnabled = true;
            // 
            // 
            // 
            _RibbonBar_UI_Allgemein.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar_UI_Allgemein.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonBar_UI_Allgemein.ContainerControlProcessDialogKey = true;
            _RibbonBar_UI_Allgemein.Dock = DockStyle.Left;
            _RibbonBar_UI_Allgemein.DragDropSupport = true;
            _RibbonBar_UI_Allgemein.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_UI_EditConfiguration });
            _RibbonBar_UI_Allgemein.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _RibbonBar_UI_Allgemein.Location = new Point(233, 0);
            _RibbonBar_UI_Allgemein.Name = "RibbonBar_UI_Allgemein";
            _RibbonBar_UI_Allgemein.Size = new Size(94, 92);
            _RibbonBar_UI_Allgemein.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonBar_UI_Allgemein.TabIndex = 2;
            _RibbonBar_UI_Allgemein.Text = "Allgemein";
            // 
            // 
            // 
            _RibbonBar_UI_Allgemein.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar_UI_Allgemein.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_UI_EditConfiguration
            // 
            _ButtonItem_UI_EditConfiguration.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_UI_EditConfiguration.Image = My.Resources.Resources.icons8_edit_property_32px;
            _ButtonItem_UI_EditConfiguration.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_UI_EditConfiguration.Name = "ButtonItem_UI_EditConfiguration";
            _ButtonItem_UI_EditConfiguration.SubItemsExpandWidth = 14;
            _ButtonItem_UI_EditConfiguration.Text = "Konfiguration bearbeiten";
            // 
            // RibbonBar2
            // 
            _RibbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            _RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonBar2.ContainerControlProcessDialogKey = true;
            _RibbonBar2.Dock = DockStyle.Left;
            _RibbonBar2.DragDropSupport = true;
            _RibbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_UI_NewPackage, _ButtonItem_UI_Open, _ButtonItem_UI_Save, _ButtonItem_UI_SaveAs });
            _RibbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _RibbonBar2.Location = new Point(3, 0);
            _RibbonBar2.Name = "RibbonBar2";
            _RibbonBar2.Size = new Size(230, 92);
            _RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonBar2.TabIndex = 0;
            _RibbonBar2.Text = "Konfiguration";
            // 
            // 
            // 
            _RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_UI_NewPackage
            // 
            _ButtonItem_UI_NewPackage.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_UI_NewPackage.Image = My.Resources.Resources.icons8_new_file_32px;
            _ButtonItem_UI_NewPackage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_UI_NewPackage.Name = "ButtonItem_UI_NewPackage";
            _ButtonItem_UI_NewPackage.SubItemsExpandWidth = 14;
            _ButtonItem_UI_NewPackage.Text = "Neue Info";
            // 
            // ButtonItem_UI_Open
            // 
            _ButtonItem_UI_Open.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_UI_Open.Image = My.Resources.Resources.icons8_code_file_32px;
            _ButtonItem_UI_Open.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_UI_Open.Name = "ButtonItem_UI_Open";
            _ButtonItem_UI_Open.SubItemsExpandWidth = 14;
            _ButtonItem_UI_Open.Text = "Info Öffnen";
            // 
            // ButtonItem_UI_Save
            // 
            _ButtonItem_UI_Save.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_UI_Save.Image = My.Resources.Resources.icons8_save_32px;
            _ButtonItem_UI_Save.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_UI_Save.Name = "ButtonItem_UI_Save";
            _ButtonItem_UI_Save.SubItemsExpandWidth = 14;
            _ButtonItem_UI_Save.Text = "Info Speichern";
            // 
            // ButtonItem_UI_SaveAs
            // 
            _ButtonItem_UI_SaveAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_UI_SaveAs.Image = My.Resources.Resources.icons8_save_as_32px;
            _ButtonItem_UI_SaveAs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_UI_SaveAs.Name = "ButtonItem_UI_SaveAs";
            _ButtonItem_UI_SaveAs.SubItemsExpandWidth = 14;
            _ButtonItem_UI_SaveAs.Text = "Speichern unter";
            // 
            // RibbonPanel1
            // 
            _RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonPanel1.Controls.Add(_RibbonBar_Pkg_Erweiterungen);
            _RibbonPanel1.Controls.Add(_RibbonBar_Pkg_Dateien);
            _RibbonPanel1.Controls.Add(_RibbonBar1);
            _RibbonPanel1.Controls.Add(_RibbonBar3);
            _RibbonPanel1.Dock = DockStyle.Fill;
            _RibbonPanel1.Location = new Point(0, 56);
            _RibbonPanel1.Name = "RibbonPanel1";
            _RibbonPanel1.Padding = new Padding(3, 0, 3, 3);
            _RibbonPanel1.Size = new Size(640, 95);
            // 
            // 
            // 
            _RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonPanel1.TabIndex = 1;
            _RibbonPanel1.Visible = false;
            // 
            // RibbonBar_Pkg_Erweiterungen
            // 
            _RibbonBar_Pkg_Erweiterungen.AutoOverflowEnabled = true;
            // 
            // 
            // 
            _RibbonBar_Pkg_Erweiterungen.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar_Pkg_Erweiterungen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonBar_Pkg_Erweiterungen.ContainerControlProcessDialogKey = true;
            _RibbonBar_Pkg_Erweiterungen.Dock = DockStyle.Left;
            _RibbonBar_Pkg_Erweiterungen.DragDropSupport = true;
            _RibbonBar_Pkg_Erweiterungen.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_Pkg_AddExtension, _ButtonItem_Pkg_RemoveExtension });
            _RibbonBar_Pkg_Erweiterungen.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _RibbonBar_Pkg_Erweiterungen.Location = new Point(463, 0);
            _RibbonBar_Pkg_Erweiterungen.Name = "RibbonBar_Pkg_Erweiterungen";
            _RibbonBar_Pkg_Erweiterungen.Size = new Size(144, 92);
            _RibbonBar_Pkg_Erweiterungen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonBar_Pkg_Erweiterungen.TabIndex = 3;
            _RibbonBar_Pkg_Erweiterungen.Text = "Erweiterungen";
            // 
            // 
            // 
            _RibbonBar_Pkg_Erweiterungen.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar_Pkg_Erweiterungen.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_AddExtension
            // 
            _ButtonItem_Pkg_AddExtension.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_Pkg_AddExtension.Image = My.Resources.Resources.icons8_merge_files_32px;
            _ButtonItem_Pkg_AddExtension.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_Pkg_AddExtension.Name = "ButtonItem_Pkg_AddExtension";
            _ButtonItem_Pkg_AddExtension.SubItemsExpandWidth = 14;
            _ButtonItem_Pkg_AddExtension.Text = "Erweiterung hinzufügen";
            // 
            // ButtonItem_Pkg_RemoveExtension
            // 
            _ButtonItem_Pkg_RemoveExtension.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_Pkg_RemoveExtension.Image = My.Resources.Resources.icons8_delete_sign_32px_1;
            _ButtonItem_Pkg_RemoveExtension.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_Pkg_RemoveExtension.Name = "ButtonItem_Pkg_RemoveExtension";
            _ButtonItem_Pkg_RemoveExtension.SubItemsExpandWidth = 14;
            _ButtonItem_Pkg_RemoveExtension.Text = "Erweiterung entfernen";
            // 
            // RibbonBar_Pkg_Dateien
            // 
            _RibbonBar_Pkg_Dateien.AutoOverflowEnabled = true;
            // 
            // 
            // 
            _RibbonBar_Pkg_Dateien.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar_Pkg_Dateien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonBar_Pkg_Dateien.ContainerControlProcessDialogKey = true;
            _RibbonBar_Pkg_Dateien.Dock = DockStyle.Left;
            _RibbonBar_Pkg_Dateien.DragDropSupport = true;
            _RibbonBar_Pkg_Dateien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_Pkg_SelectFileFolder, _ButtonItem_Pkg_RemoveFileFolder });
            _RibbonBar_Pkg_Dateien.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _RibbonBar_Pkg_Dateien.Location = new Point(314, 0);
            _RibbonBar_Pkg_Dateien.Name = "RibbonBar_Pkg_Dateien";
            _RibbonBar_Pkg_Dateien.Size = new Size(149, 92);
            _RibbonBar_Pkg_Dateien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonBar_Pkg_Dateien.TabIndex = 2;
            _RibbonBar_Pkg_Dateien.Text = "Dateien";
            // 
            // 
            // 
            _RibbonBar_Pkg_Dateien.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar_Pkg_Dateien.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_SelectFileFolder
            // 
            _ButtonItem_Pkg_SelectFileFolder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_Pkg_SelectFileFolder.Image = My.Resources.Resources.icons8_opened_folder_32px;
            _ButtonItem_Pkg_SelectFileFolder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_Pkg_SelectFileFolder.Name = "ButtonItem_Pkg_SelectFileFolder";
            _ButtonItem_Pkg_SelectFileFolder.SubItemsExpandWidth = 14;
            _ButtonItem_Pkg_SelectFileFolder.Text = "Ordner auswählen";
            // 
            // ButtonItem_Pkg_RemoveFileFolder
            // 
            _ButtonItem_Pkg_RemoveFileFolder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_Pkg_RemoveFileFolder.Image = My.Resources.Resources.icons8_delete_sign_32px_1;
            _ButtonItem_Pkg_RemoveFileFolder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_Pkg_RemoveFileFolder.Name = "ButtonItem_Pkg_RemoveFileFolder";
            _ButtonItem_Pkg_RemoveFileFolder.SubItemsExpandWidth = 14;
            _ButtonItem_Pkg_RemoveFileFolder.Text = "Ordner entfernen";
            // 
            // RibbonBar1
            // 
            _RibbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            _RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonBar1.ContainerControlProcessDialogKey = true;
            _RibbonBar1.Dock = DockStyle.Left;
            _RibbonBar1.DragDropSupport = true;
            _RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_ButtonItem_Pkg_Export });
            _RibbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _RibbonBar1.Location = new Point(233, 0);
            _RibbonBar1.Name = "RibbonBar1";
            _RibbonBar1.Size = new Size(81, 92);
            _RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonBar1.TabIndex = 0;
            _RibbonBar1.Text = "Paket";
            // 
            // 
            // 
            _RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_ButtonItem_Pkg_Export
            // 
            _ButtonItem_ButtonItem_Pkg_Export.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_ButtonItem_Pkg_Export.Image = My.Resources.Resources.icons8_export_32px_3;
            _ButtonItem_ButtonItem_Pkg_Export.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_ButtonItem_Pkg_Export.Name = "ButtonItem_ButtonItem_Pkg_Export";
            _ButtonItem_ButtonItem_Pkg_Export.SubItemsExpandWidth = 14;
            _ButtonItem_ButtonItem_Pkg_Export.Text = "Paket exportieren";
            // 
            // RibbonBar3
            // 
            _RibbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            _RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _RibbonBar3.ContainerControlProcessDialogKey = true;
            _RibbonBar3.Dock = DockStyle.Left;
            _RibbonBar3.DragDropSupport = true;
            _RibbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_Pkg_NewTemplate, _ButtonItem_Pkg_OpenTemplate, _ButtonItem_Pkg_SaveTemplate, _ButtonItem_Pkg_SaveTemplateAs });
            _RibbonBar3.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _RibbonBar3.Location = new Point(3, 0);
            _RibbonBar3.Name = "RibbonBar3";
            _RibbonBar3.Size = new Size(230, 92);
            _RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _RibbonBar3.TabIndex = 1;
            _RibbonBar3.Text = "Vorlage";
            // 
            // 
            // 
            _RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_NewTemplate
            // 
            _ButtonItem_Pkg_NewTemplate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_Pkg_NewTemplate.Image = My.Resources.Resources.icons8_new_file_32px;
            _ButtonItem_Pkg_NewTemplate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_Pkg_NewTemplate.Name = "ButtonItem_Pkg_NewTemplate";
            _ButtonItem_Pkg_NewTemplate.SubItemsExpandWidth = 14;
            _ButtonItem_Pkg_NewTemplate.Text = "Neues Template";
            // 
            // ButtonItem_Pkg_OpenTemplate
            // 
            _ButtonItem_Pkg_OpenTemplate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_Pkg_OpenTemplate.Image = My.Resources.Resources.icons8_template_32px;
            _ButtonItem_Pkg_OpenTemplate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_Pkg_OpenTemplate.Name = "ButtonItem_Pkg_OpenTemplate";
            _ButtonItem_Pkg_OpenTemplate.SubItemsExpandWidth = 14;
            _ButtonItem_Pkg_OpenTemplate.Text = "Vorlage Öffnen";
            // 
            // ButtonItem_Pkg_SaveTemplate
            // 
            _ButtonItem_Pkg_SaveTemplate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_Pkg_SaveTemplate.Image = My.Resources.Resources.icons8_save_32px;
            _ButtonItem_Pkg_SaveTemplate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_Pkg_SaveTemplate.Name = "ButtonItem_Pkg_SaveTemplate";
            _ButtonItem_Pkg_SaveTemplate.SubItemsExpandWidth = 14;
            _ButtonItem_Pkg_SaveTemplate.Text = "Vorlage Speichern";
            // 
            // ButtonItem_Pkg_SaveTemplateAs
            // 
            _ButtonItem_Pkg_SaveTemplateAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_Pkg_SaveTemplateAs.Image = My.Resources.Resources.icons8_save_as_32px;
            _ButtonItem_Pkg_SaveTemplateAs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            _ButtonItem_Pkg_SaveTemplateAs.Name = "ButtonItem_Pkg_SaveTemplateAs";
            _ButtonItem_Pkg_SaveTemplateAs.SubItemsExpandWidth = 14;
            _ButtonItem_Pkg_SaveTemplateAs.Text = "Speichern unter";
            // 
            // RibbonTabItem_UpdateInfo
            // 
            _RibbonTabItem_UpdateInfo.Checked = true;
            _RibbonTabItem_UpdateInfo.Name = "RibbonTabItem_UpdateInfo";
            _RibbonTabItem_UpdateInfo.Panel = _RibbonPanel2;
            _RibbonTabItem_UpdateInfo.Text = "Update-Info";
            // 
            // RibbonTabItem_Packaging
            // 
            _RibbonTabItem_Packaging.Name = "RibbonTabItem_Packaging";
            _RibbonTabItem_Packaging.Panel = _RibbonPanel1;
            _RibbonTabItem_Packaging.Text = "Paketierung";
            // 
            // EditorWindow
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 550);
            Controls.Add(_SuperTabControl1);
            Controls.Add(_RibbonControl_Main);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditorWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "650; 550";
            Text = "Update-Administration";
            ((System.ComponentModel.ISupportInitialize)_SuperTabControl1).EndInit();
            _SuperTabControl1.ResumeLayout(false);
            _SuperTabControlPanel1.ResumeLayout(false);
            _LayoutControl2.ResumeLayout(false);
            _SuperTabControlPanel5.ResumeLayout(false);
            _LayoutControl1.ResumeLayout(false);
            _SuperTabControlPanel3.ResumeLayout(false);
            _Panel3.ResumeLayout(false);
            _SuperTabControlPanel4.ResumeLayout(false);
            _Panel4.ResumeLayout(false);
            _SuperTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_AdvTree1).EndInit();
            _RibbonControl_Main.ResumeLayout(false);
            _RibbonControl_Main.PerformLayout();
            _RibbonPanel2.ResumeLayout(false);
            _RibbonPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.SuperTabControl _SuperTabControl1;

        internal DevComponents.DotNetBar.SuperTabControl SuperTabControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabControl1 != null)
                {
                    _SuperTabControl1.SelectedTabChanged -= SuperTabControl1_SelectedTabChanged;
                }

                _SuperTabControl1 = value;
                if (_SuperTabControl1 != null)
                {
                    _SuperTabControl1.SelectedTabChanged += SuperTabControl1_SelectedTabChanged;
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabControlPanel _SuperTabControlPanel4;

        internal DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabControlPanel4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabControlPanel4 != null)
                {
                }

                _SuperTabControlPanel4 = value;
                if (_SuperTabControlPanel4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabItem _SuperTabItem_Pkg_Extensions;

        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem_Pkg_Extensions
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabItem_Pkg_Extensions;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabItem_Pkg_Extensions != null)
                {
                }

                _SuperTabItem_Pkg_Extensions = value;
                if (_SuperTabItem_Pkg_Extensions != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabControlPanel _SuperTabControlPanel3;

        internal DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabControlPanel3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabControlPanel3 != null)
                {
                }

                _SuperTabControlPanel3 = value;
                if (_SuperTabControlPanel3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabItem _SuperTabItem_UI_Changelog;

        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem_UI_Changelog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabItem_UI_Changelog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabItem_UI_Changelog != null)
                {
                }

                _SuperTabItem_UI_Changelog = value;
                if (_SuperTabItem_UI_Changelog != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonControl _RibbonControl_Main;

        internal DevComponents.DotNetBar.RibbonControl RibbonControl_Main
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonControl_Main;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonControl_Main != null)
                {
                }

                _RibbonControl_Main = value;
                if (_RibbonControl_Main != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonPanel _RibbonPanel1;

        internal DevComponents.DotNetBar.RibbonPanel RibbonPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonPanel1 != null)
                {
                }

                _RibbonPanel1 = value;
                if (_RibbonPanel1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonBar _RibbonBar1;

        internal DevComponents.DotNetBar.RibbonBar RibbonBar1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonBar1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonBar1 != null)
                {
                }

                _RibbonBar1 = value;
                if (_RibbonBar1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonPanel _RibbonPanel2;

        internal DevComponents.DotNetBar.RibbonPanel RibbonPanel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonPanel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonPanel2 != null)
                {
                }

                _RibbonPanel2 = value;
                if (_RibbonPanel2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonTabItem _RibbonTabItem_Packaging;

        internal DevComponents.DotNetBar.RibbonTabItem RibbonTabItem_Packaging
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonTabItem_Packaging;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonTabItem_Packaging != null)
                {
                }

                _RibbonTabItem_Packaging = value;
                if (_RibbonTabItem_Packaging != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonTabItem _RibbonTabItem_UpdateInfo;

        internal DevComponents.DotNetBar.RibbonTabItem RibbonTabItem_UpdateInfo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonTabItem_UpdateInfo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonTabItem_UpdateInfo != null)
                {
                }

                _RibbonTabItem_UpdateInfo = value;
                if (_RibbonTabItem_UpdateInfo != null)
                {
                }
            }
        }

        private Panel _Panel4;

        internal Panel Panel4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel4 != null)
                {
                }

                _Panel4 = value;
                if (_Panel4 != null)
                {
                }
            }
        }

        private Panel _Panel3;

        internal Panel Panel3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel3 != null)
                {
                }

                _Panel3 = value;
                if (_Panel3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ButtonItem_Pkg_Export;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ButtonItem_Pkg_Export
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ButtonItem_Pkg_Export;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ButtonItem_Pkg_Export != null)
                {
                    _ButtonItem_ButtonItem_Pkg_Export.Click -= ButtonItem_ButtonItem_Pkg_Export_Click;
                }

                _ButtonItem_ButtonItem_Pkg_Export = value;
                if (_ButtonItem_ButtonItem_Pkg_Export != null)
                {
                    _ButtonItem_ButtonItem_Pkg_Export.Click += ButtonItem_ButtonItem_Pkg_Export_Click;
                }
            }
        }

        private DevComponents.DotNetBar.RibbonBar _RibbonBar2;

        internal DevComponents.DotNetBar.RibbonBar RibbonBar2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonBar2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonBar2 != null)
                {
                }

                _RibbonBar2 = value;
                if (_RibbonBar2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_UI_Open;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_UI_Open
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_UI_Open;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_UI_Open != null)
                {
                    _ButtonItem_UI_Open.Click -= ButtonItem_UI_Open_Click;
                }

                _ButtonItem_UI_Open = value;
                if (_ButtonItem_UI_Open != null)
                {
                    _ButtonItem_UI_Open.Click += ButtonItem_UI_Open_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_UI_Save;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_UI_Save
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_UI_Save;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_UI_Save != null)
                {
                    _ButtonItem_UI_Save.Click -= ButtonItem_UI_Save_Click;
                }

                _ButtonItem_UI_Save = value;
                if (_ButtonItem_UI_Save != null)
                {
                    _ButtonItem_UI_Save.Click += ButtonItem_UI_Save_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_UI_SaveAs;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_UI_SaveAs
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_UI_SaveAs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_UI_SaveAs != null)
                {
                    _ButtonItem_UI_SaveAs.Click -= ButtonItem_UI_SaveAs_Click;
                }

                _ButtonItem_UI_SaveAs = value;
                if (_ButtonItem_UI_SaveAs != null)
                {
                    _ButtonItem_UI_SaveAs.Click += ButtonItem_UI_SaveAs_Click;
                }
            }
        }

        private DevComponents.DotNetBar.RibbonBar _RibbonBar3;

        internal DevComponents.DotNetBar.RibbonBar RibbonBar3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonBar3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonBar3 != null)
                {
                }

                _RibbonBar3 = value;
                if (_RibbonBar3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Pkg_OpenTemplate;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_OpenTemplate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Pkg_OpenTemplate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Pkg_OpenTemplate != null)
                {
                    _ButtonItem_Pkg_OpenTemplate.Click -= ButtonItem_Pkg_OpenTemplate_Click;
                }

                _ButtonItem_Pkg_OpenTemplate = value;
                if (_ButtonItem_Pkg_OpenTemplate != null)
                {
                    _ButtonItem_Pkg_OpenTemplate.Click += ButtonItem_Pkg_OpenTemplate_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Pkg_SaveTemplate;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_SaveTemplate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Pkg_SaveTemplate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Pkg_SaveTemplate != null)
                {
                    _ButtonItem_Pkg_SaveTemplate.Click -= ButtonItem_Pkg_SaveTemplate_Click;
                }

                _ButtonItem_Pkg_SaveTemplate = value;
                if (_ButtonItem_Pkg_SaveTemplate != null)
                {
                    _ButtonItem_Pkg_SaveTemplate.Click += ButtonItem_Pkg_SaveTemplate_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Pkg_SaveTemplateAs;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_SaveTemplateAs
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Pkg_SaveTemplateAs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Pkg_SaveTemplateAs != null)
                {
                    _ButtonItem_Pkg_SaveTemplateAs.Click -= ButtonItem_Pkg_SaveTemplateAs_Click;
                }

                _ButtonItem_Pkg_SaveTemplateAs = value;
                if (_ButtonItem_Pkg_SaveTemplateAs != null)
                {
                    _ButtonItem_Pkg_SaveTemplateAs.Click += ButtonItem_Pkg_SaveTemplateAs_Click;
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabControlPanel _SuperTabControlPanel5;

        internal DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabControlPanel5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabControlPanel5 != null)
                {
                }

                _SuperTabControlPanel5 = value;
                if (_SuperTabControlPanel5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabItem _SuperTabItem_UI_PackageInfo;

        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem_UI_PackageInfo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabItem_UI_PackageInfo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabItem_UI_PackageInfo != null)
                {
                }

                _SuperTabItem_UI_PackageInfo = value;
                if (_SuperTabItem_UI_PackageInfo != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabControlPanel _SuperTabControlPanel2;

        internal DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabControlPanel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabControlPanel2 != null)
                {
                }

                _SuperTabControlPanel2 = value;
                if (_SuperTabControlPanel2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabItem _SuperTabItem_Pkg_Files;

        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem_Pkg_Files
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabItem_Pkg_Files;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabItem_Pkg_Files != null)
                {
                }

                _SuperTabItem_Pkg_Files = value;
                if (_SuperTabItem_Pkg_Files != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.RichTextBoxEx _TextBoxX_UI_PackageChangelog;

        internal DevComponents.DotNetBar.Controls.RichTextBoxEx TextBoxX_UI_PackageChangelog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_UI_PackageChangelog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_UI_PackageChangelog != null)
                {
                    _TextBoxX_UI_PackageChangelog.TextChanged -= TextBoxX_UI_PackageChangelog_TextChanged;
                }

                _TextBoxX_UI_PackageChangelog = value;
                if (_TextBoxX_UI_PackageChangelog != null)
                {
                    _TextBoxX_UI_PackageChangelog.TextChanged += TextBoxX_UI_PackageChangelog_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ListViewEx _ListViewEx_Files;

        internal DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_Files
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewEx_Files;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewEx_Files != null)
                {
                }

                _ListViewEx_Files = value;
                if (_ListViewEx_Files != null)
                {
                }
            }
        }

        private DevComponents.AdvTree.AdvTree _AdvTree1;

        internal DevComponents.AdvTree.AdvTree AdvTree1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AdvTree1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AdvTree1 != null)
                {
                }

                _AdvTree1 = value;
                if (_AdvTree1 != null)
                {
                }
            }
        }

        private DevComponents.AdvTree.NodeConnector _NodeConnector1;

        internal DevComponents.AdvTree.NodeConnector NodeConnector1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NodeConnector1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NodeConnector1 != null)
                {
                }

                _NodeConnector1 = value;
                if (_NodeConnector1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ElementStyle _ElementStyle1;

        internal DevComponents.DotNetBar.ElementStyle ElementStyle1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ElementStyle1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ElementStyle1 != null)
                {
                }

                _ElementStyle1 = value;
                if (_ElementStyle1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControl _LayoutControl1;

        internal DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControl1 != null)
                {
                }

                _LayoutControl1 = value;
                if (_LayoutControl1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonBar _RibbonBar_UI_PackageInfo;

        internal DevComponents.DotNetBar.RibbonBar RibbonBar_UI_PackageInfo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonBar_UI_PackageInfo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonBar_UI_PackageInfo != null)
                {
                }

                _RibbonBar_UI_PackageInfo = value;
                if (_RibbonBar_UI_PackageInfo != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_UI_EditVersion;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_UI_EditVersion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_UI_EditVersion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_UI_EditVersion != null)
                {
                    _ButtonItem_UI_EditVersion.Click -= ButtonItem_UI_EditVersion_Click;
                }

                _ButtonItem_UI_EditVersion = value;
                if (_ButtonItem_UI_EditVersion != null)
                {
                    _ButtonItem_UI_EditVersion.Click += ButtonItem_UI_EditVersion_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_UI_EditDownloadlink;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_UI_EditDownloadlink
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_UI_EditDownloadlink;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_UI_EditDownloadlink != null)
                {
                    _ButtonItem_UI_EditDownloadlink.Click -= ButtonItem_UI_EditDownloadlink_Click;
                }

                _ButtonItem_UI_EditDownloadlink = value;
                if (_ButtonItem_UI_EditDownloadlink != null)
                {
                    _ButtonItem_UI_EditDownloadlink.Click += ButtonItem_UI_EditDownloadlink_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_UI_PackageVersion;

        internal DevComponents.DotNetBar.LabelX LabelX_UI_PackageVersion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_UI_PackageVersion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_UI_PackageVersion != null)
                {
                }

                _LabelX_UI_PackageVersion = value;
                if (_LabelX_UI_PackageVersion != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_UI_PackageChannel;

        internal DevComponents.DotNetBar.LabelX LabelX_UI_PackageChannel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_UI_PackageChannel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_UI_PackageChannel != null)
                {
                }

                _LabelX_UI_PackageChannel = value;
                if (_LabelX_UI_PackageChannel != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_UI_PackageBuild;

        internal DevComponents.DotNetBar.LabelX LabelX_UI_PackageBuild
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_UI_PackageBuild;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_UI_PackageBuild != null)
                {
                }

                _LabelX_UI_PackageBuild = value;
                if (_LabelX_UI_PackageBuild != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem2;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem2 != null)
                {
                }

                _LayoutControlItem2 = value;
                if (_LayoutControlItem2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem3;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem3 != null)
                {
                }

                _LayoutControlItem3 = value;
                if (_LayoutControlItem3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem4;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem4 != null)
                {
                }

                _LayoutControlItem4 = value;
                if (_LayoutControlItem4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutSpacerItem _LayoutSpacerItem1;

        internal DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutSpacerItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutSpacerItem1 != null)
                {
                }

                _LayoutSpacerItem1 = value;
                if (_LayoutSpacerItem1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ItemContainer _ItemContainer1;

        internal DevComponents.DotNetBar.ItemContainer ItemContainer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemContainer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemContainer1 != null)
                {
                }

                _ItemContainer1 = value;
                if (_ItemContainer1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_UI_AddPackageInfo;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_UI_AddPackageInfo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_UI_AddPackageInfo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_UI_AddPackageInfo != null)
                {
                    _ButtonItem_UI_AddPackageInfo.Click -= ButtonItem_UI_AddPackageInfo_Click;
                }

                _ButtonItem_UI_AddPackageInfo = value;
                if (_ButtonItem_UI_AddPackageInfo != null)
                {
                    _ButtonItem_UI_AddPackageInfo.Click += ButtonItem_UI_AddPackageInfo_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_UI_DeletePackageInfo;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_UI_DeletePackageInfo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_UI_DeletePackageInfo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_UI_DeletePackageInfo != null)
                {
                    _ButtonItem_UI_DeletePackageInfo.Click -= ButtonItem_UI_DeletePackageInfo_Click;
                }

                _ButtonItem_UI_DeletePackageInfo = value;
                if (_ButtonItem_UI_DeletePackageInfo != null)
                {
                    _ButtonItem_UI_DeletePackageInfo.Click += ButtonItem_UI_DeletePackageInfo_Click;
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabControlPanel _SuperTabControlPanel1;

        internal DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabControlPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabControlPanel1 != null)
                {
                }

                _SuperTabControlPanel1 = value;
                if (_SuperTabControlPanel1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.SuperTabItem _SuperTabItem_UI_General;

        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem_UI_General
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTabItem_UI_General;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTabItem_UI_General != null)
                {
                }

                _SuperTabItem_UI_General = value;
                if (_SuperTabItem_UI_General != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_UI_PackageDownloadlink;

        internal DevComponents.DotNetBar.LabelX LabelX_UI_PackageDownloadlink
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_UI_PackageDownloadlink;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_UI_PackageDownloadlink != null)
                {
                }

                _LabelX_UI_PackageDownloadlink = value;
                if (_LabelX_UI_PackageDownloadlink != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem5;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem5 != null)
                {
                }

                _LayoutControlItem5 = value;
                if (_LayoutControlItem5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControl _LayoutControl2;

        internal DevComponents.DotNetBar.Layout.LayoutControl LayoutControl2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControl2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControl2 != null)
                {
                }

                _LayoutControl2 = value;
                if (_LayoutControl2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonBar _RibbonBar_UI_Allgemein;

        internal DevComponents.DotNetBar.RibbonBar RibbonBar_UI_Allgemein
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonBar_UI_Allgemein;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonBar_UI_Allgemein != null)
                {
                }

                _RibbonBar_UI_Allgemein = value;
                if (_RibbonBar_UI_Allgemein != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_UI_EditConfiguration;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_UI_EditConfiguration
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_UI_EditConfiguration;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_UI_EditConfiguration != null)
                {
                    _ButtonItem_UI_EditConfiguration.Click -= ButtonItem_UI_EditConfiguration_Click;
                }

                _ButtonItem_UI_EditConfiguration = value;
                if (_ButtonItem_UI_EditConfiguration != null)
                {
                    _ButtonItem_UI_EditConfiguration.Click += ButtonItem_UI_EditConfiguration_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_UI_UpdateInstallerExeDownloadlink;

        internal DevComponents.DotNetBar.LabelX LabelX_UI_UpdateInstallerExeDownloadlink
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_UI_UpdateInstallerExeDownloadlink;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_UI_UpdateInstallerExeDownloadlink != null)
                {
                }

                _LabelX_UI_UpdateInstallerExeDownloadlink = value;
                if (_LabelX_UI_UpdateInstallerExeDownloadlink != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem6;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem6 != null)
                {
                }

                _LayoutControlItem6 = value;
                if (_LayoutControlItem6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonBar _RibbonBar_Pkg_Erweiterungen;

        internal DevComponents.DotNetBar.RibbonBar RibbonBar_Pkg_Erweiterungen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonBar_Pkg_Erweiterungen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonBar_Pkg_Erweiterungen != null)
                {
                }

                _RibbonBar_Pkg_Erweiterungen = value;
                if (_RibbonBar_Pkg_Erweiterungen != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.RibbonBar _RibbonBar_Pkg_Dateien;

        internal DevComponents.DotNetBar.RibbonBar RibbonBar_Pkg_Dateien
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RibbonBar_Pkg_Dateien;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RibbonBar_Pkg_Dateien != null)
                {
                }

                _RibbonBar_Pkg_Dateien = value;
                if (_RibbonBar_Pkg_Dateien != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Pkg_AddExtension;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_AddExtension
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Pkg_AddExtension;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Pkg_AddExtension != null)
                {
                    _ButtonItem_Pkg_AddExtension.Click -= ButtonItem_Pkg_AddExtension_Click;
                }

                _ButtonItem_Pkg_AddExtension = value;
                if (_ButtonItem_Pkg_AddExtension != null)
                {
                    _ButtonItem_Pkg_AddExtension.Click += ButtonItem_Pkg_AddExtension_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Pkg_RemoveExtension;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_RemoveExtension
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Pkg_RemoveExtension;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Pkg_RemoveExtension != null)
                {
                    _ButtonItem_Pkg_RemoveExtension.Click -= ButtonItem_Pkg_RemoveExtension_Click;
                }

                _ButtonItem_Pkg_RemoveExtension = value;
                if (_ButtonItem_Pkg_RemoveExtension != null)
                {
                    _ButtonItem_Pkg_RemoveExtension.Click += ButtonItem_Pkg_RemoveExtension_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Pkg_SelectFileFolder;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_SelectFileFolder
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Pkg_SelectFileFolder;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Pkg_SelectFileFolder != null)
                {
                    _ButtonItem_Pkg_SelectFileFolder.Click -= ButtonItem_Pkg_SelectFileFolder_Click;
                }

                _ButtonItem_Pkg_SelectFileFolder = value;
                if (_ButtonItem_Pkg_SelectFileFolder != null)
                {
                    _ButtonItem_Pkg_SelectFileFolder.Click += ButtonItem_Pkg_SelectFileFolder_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_UI_NewPackage;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_UI_NewPackage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_UI_NewPackage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_UI_NewPackage != null)
                {
                    _ButtonItem_UI_NewPackage.Click -= ButtonItem_UI_NewPackage_Click;
                }

                _ButtonItem_UI_NewPackage = value;
                if (_ButtonItem_UI_NewPackage != null)
                {
                    _ButtonItem_UI_NewPackage.Click += ButtonItem_UI_NewPackage_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Pkg_NewTemplate;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_NewTemplate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Pkg_NewTemplate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Pkg_NewTemplate != null)
                {
                    _ButtonItem_Pkg_NewTemplate.Click -= ButtonItem_Pkg_NewTemplate_Click;
                }

                _ButtonItem_Pkg_NewTemplate = value;
                if (_ButtonItem_Pkg_NewTemplate != null)
                {
                    _ButtonItem_Pkg_NewTemplate.Click += ButtonItem_Pkg_NewTemplate_Click;
                }
            }
        }

        private ColumnHeader _ColumnHeader1;

        internal ColumnHeader ColumnHeader1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader1 != null)
                {
                }

                _ColumnHeader1 = value;
                if (_ColumnHeader1 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader2;

        internal ColumnHeader ColumnHeader2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader2 != null)
                {
                }

                _ColumnHeader2 = value;
                if (_ColumnHeader2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Pkg_RemoveFileFolder;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_RemoveFileFolder
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Pkg_RemoveFileFolder;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Pkg_RemoveFileFolder != null)
                {
                    _ButtonItem_Pkg_RemoveFileFolder.Click -= ButtonItem_Pkg_RemoveFileFolder_Click;
                }

                _ButtonItem_Pkg_RemoveFileFolder = value;
                if (_ButtonItem_Pkg_RemoveFileFolder != null)
                {
                    _ButtonItem_Pkg_RemoveFileFolder.Click += ButtonItem_Pkg_RemoveFileFolder_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ComboBoxItem _ComboBoxItem_UI_PackageInfoList;

        internal DevComponents.DotNetBar.ComboBoxItem ComboBoxItem_UI_PackageInfoList
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxItem_UI_PackageInfoList;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxItem_UI_PackageInfoList != null)
                {
                    _ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged -= ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged;
                    _ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged -= ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged;
                }

                _ComboBoxItem_UI_PackageInfoList = value;
                if (_ComboBoxItem_UI_PackageInfoList != null)
                {
                    _ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged;
                    _ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged;
                }
            }
        }
    }
}