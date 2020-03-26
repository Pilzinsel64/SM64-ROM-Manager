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
            SuperTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            SuperTabControl1.SelectedTabChanged += new EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(SuperTabControl1_SelectedTabChanged);
            SuperTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            LayoutControl2 = new DevComponents.DotNetBar.Layout.LayoutControl();
            LabelX_UI_UpdateInstallerExeDownloadlink = new DevComponents.DotNetBar.LabelX();
            LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            SuperTabItem_UI_General = new DevComponents.DotNetBar.SuperTabItem();
            SuperTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            LabelX_UI_PackageVersion = new DevComponents.DotNetBar.LabelX();
            LabelX_UI_PackageChannel = new DevComponents.DotNetBar.LabelX();
            LabelX_UI_PackageBuild = new DevComponents.DotNetBar.LabelX();
            LabelX_UI_PackageDownloadlink = new DevComponents.DotNetBar.LabelX();
            LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            SuperTabItem_UI_PackageInfo = new DevComponents.DotNetBar.SuperTabItem();
            SuperTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            Panel3 = new Panel();
            TextBoxX_UI_PackageChangelog = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            TextBoxX_UI_PackageChangelog.TextChanged += new EventHandler(TextBoxX_UI_PackageChangelog_TextChanged);
            SuperTabItem_UI_Changelog = new DevComponents.DotNetBar.SuperTabItem();
            SuperTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            Panel4 = new Panel();
            ListViewEx_Files = new DevComponents.DotNetBar.Controls.ListViewEx();
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader2 = new ColumnHeader();
            SuperTabItem_Pkg_Extensions = new DevComponents.DotNetBar.SuperTabItem();
            SuperTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            AdvTree1 = new DevComponents.AdvTree.AdvTree();
            NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            SuperTabItem_Pkg_Files = new DevComponents.DotNetBar.SuperTabItem();
            RibbonControl_Main = new DevComponents.DotNetBar.RibbonControl();
            RibbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            RibbonBar_UI_PackageInfo = new DevComponents.DotNetBar.RibbonBar();
            ItemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            ComboBoxItem_UI_PackageInfoList = new DevComponents.DotNetBar.ComboBoxItem();
            ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += new EventHandler(ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged);
            ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += new EventHandler(ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged);
            ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += new EventHandler(ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged);
            ComboBoxItem_UI_PackageInfoList.SelectedIndexChanged += new EventHandler(ComboBoxItem_UI_PackageInfoList_SelectedIndexChanged);
            ButtonItem_UI_AddPackageInfo = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_UI_AddPackageInfo.Click += new EventHandler(ButtonItem_UI_AddPackageInfo_Click);
            ButtonItem_UI_DeletePackageInfo = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_UI_DeletePackageInfo.Click += new EventHandler(ButtonItem_UI_DeletePackageInfo_Click);
            ButtonItem_UI_EditVersion = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_UI_EditVersion.Click += new EventHandler(ButtonItem_UI_EditVersion_Click);
            ButtonItem_UI_EditDownloadlink = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_UI_EditDownloadlink.Click += new EventHandler(ButtonItem_UI_EditDownloadlink_Click);
            RibbonBar_UI_Allgemein = new DevComponents.DotNetBar.RibbonBar();
            ButtonItem_UI_EditConfiguration = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_UI_EditConfiguration.Click += new EventHandler(ButtonItem_UI_EditConfiguration_Click);
            RibbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            ButtonItem_UI_NewPackage = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_UI_NewPackage.Click += new EventHandler(ButtonItem_UI_NewPackage_Click);
            ButtonItem_UI_Open = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_UI_Open.Click += new EventHandler(ButtonItem_UI_Open_Click);
            ButtonItem_UI_Save = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_UI_Save.Click += new EventHandler(ButtonItem_UI_Save_Click);
            ButtonItem_UI_SaveAs = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_UI_SaveAs.Click += new EventHandler(ButtonItem_UI_SaveAs_Click);
            RibbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            RibbonBar_Pkg_Erweiterungen = new DevComponents.DotNetBar.RibbonBar();
            ButtonItem_Pkg_AddExtension = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_Pkg_AddExtension.Click += new EventHandler(ButtonItem_Pkg_AddExtension_Click);
            ButtonItem_Pkg_RemoveExtension = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_Pkg_RemoveExtension.Click += new EventHandler(ButtonItem_Pkg_RemoveExtension_Click);
            RibbonBar_Pkg_Dateien = new DevComponents.DotNetBar.RibbonBar();
            ButtonItem_Pkg_SelectFileFolder = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_Pkg_SelectFileFolder.Click += new EventHandler(ButtonItem_Pkg_SelectFileFolder_Click);
            ButtonItem_Pkg_RemoveFileFolder = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_Pkg_RemoveFileFolder.Click += new EventHandler(ButtonItem_Pkg_RemoveFileFolder_Click);
            RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            ButtonItem_ButtonItem_Pkg_Export = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_ButtonItem_Pkg_Export.Click += new EventHandler(ButtonItem_ButtonItem_Pkg_Export_Click);
            RibbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            ButtonItem_Pkg_NewTemplate = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_Pkg_NewTemplate.Click += new EventHandler(ButtonItem_Pkg_NewTemplate_Click);
            ButtonItem_Pkg_OpenTemplate = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_Pkg_OpenTemplate.Click += new EventHandler(ButtonItem_Pkg_OpenTemplate_Click);
            ButtonItem_Pkg_SaveTemplate = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_Pkg_SaveTemplate.Click += new EventHandler(ButtonItem_Pkg_SaveTemplate_Click);
            ButtonItem_Pkg_SaveTemplateAs = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_Pkg_SaveTemplateAs.Click += new EventHandler(ButtonItem_Pkg_SaveTemplateAs_Click);
            RibbonTabItem_UpdateInfo = new DevComponents.DotNetBar.RibbonTabItem();
            RibbonTabItem_Packaging = new DevComponents.DotNetBar.RibbonTabItem();
            ((System.ComponentModel.ISupportInitialize)SuperTabControl1).BeginInit();
            SuperTabControl1.SuspendLayout();
            SuperTabControlPanel1.SuspendLayout();
            LayoutControl2.SuspendLayout();
            SuperTabControlPanel5.SuspendLayout();
            LayoutControl1.SuspendLayout();
            SuperTabControlPanel3.SuspendLayout();
            Panel3.SuspendLayout();
            SuperTabControlPanel4.SuspendLayout();
            Panel4.SuspendLayout();
            SuperTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdvTree1).BeginInit();
            RibbonControl_Main.SuspendLayout();
            RibbonPanel2.SuspendLayout();
            RibbonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SuperTabControl1
            // 
            SuperTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            SuperTabControl1.BackColor = Color.Transparent;
            // 
            // 
            // 
            // 
            // 
            // 
            SuperTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            SuperTabControl1.ControlBox.MenuBox.Name = "";
            SuperTabControl1.ControlBox.Name = "";
            SuperTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { SuperTabControl1.ControlBox.MenuBox, SuperTabControl1.ControlBox.CloseBox });
            SuperTabControl1.Controls.Add(SuperTabControlPanel1);
            SuperTabControl1.Controls.Add(SuperTabControlPanel5);
            SuperTabControl1.Controls.Add(SuperTabControlPanel3);
            SuperTabControl1.Controls.Add(SuperTabControlPanel4);
            SuperTabControl1.Controls.Add(SuperTabControlPanel2);
            SuperTabControl1.ForeColor = Color.Black;
            SuperTabControl1.Location = new Point(1, 155);
            SuperTabControl1.Name = "SuperTabControl1";
            SuperTabControl1.ReorderTabsEnabled = true;
            SuperTabControl1.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            SuperTabControl1.SelectedTabIndex = 0;
            SuperTabControl1.Size = new Size(648, 394);
            SuperTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            SuperTabControl1.TabFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SuperTabControl1.TabIndex = 1;
            SuperTabControl1.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            SuperTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] { SuperTabItem_UI_General, SuperTabItem_UI_PackageInfo, SuperTabItem_UI_Changelog, SuperTabItem_Pkg_Files, SuperTabItem_Pkg_Extensions });
            SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            SuperTabControl1.Text = "SuperTabControl1";
            // 
            // SuperTabControlPanel1
            // 
            SuperTabControlPanel1.Controls.Add(LayoutControl2);
            SuperTabControlPanel1.Dock = DockStyle.Fill;
            SuperTabControlPanel1.Location = new Point(98, 0);
            SuperTabControlPanel1.Name = "SuperTabControlPanel1";
            SuperTabControlPanel1.Size = new Size(550, 394);
            SuperTabControlPanel1.TabIndex = 0;
            SuperTabControlPanel1.TabItem = SuperTabItem_UI_General;
            // 
            // LayoutControl2
            // 
            LayoutControl2.BackColor = Color.Transparent;
            LayoutControl2.Controls.Add(LabelX_UI_UpdateInstallerExeDownloadlink);
            LayoutControl2.Dock = DockStyle.Fill;
            LayoutControl2.ForeColor = Color.Black;
            LayoutControl2.Location = new Point(0, 0);
            LayoutControl2.Name = "LayoutControl2";
            // 
            // 
            // 
            LayoutControl2.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { LayoutControlItem6 });
            LayoutControl2.Size = new Size(550, 394);
            LayoutControl2.TabIndex = 0;
            // 
            // LabelX_UI_UpdateInstallerExeDownloadlink
            // 
            // 
            // 
            // 
            LabelX_UI_UpdateInstallerExeDownloadlink.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX_UI_UpdateInstallerExeDownloadlink.Location = new Point(183, 4);
            LabelX_UI_UpdateInstallerExeDownloadlink.Margin = new Padding(0);
            LabelX_UI_UpdateInstallerExeDownloadlink.Name = "LabelX_UI_UpdateInstallerExeDownloadlink";
            LabelX_UI_UpdateInstallerExeDownloadlink.Size = new Size(363, 23);
            LabelX_UI_UpdateInstallerExeDownloadlink.TabIndex = 0;
            LabelX_UI_UpdateInstallerExeDownloadlink.Text = "-";
            LabelX_UI_UpdateInstallerExeDownloadlink.WordWrap = true;
            // 
            // LayoutControlItem6
            // 
            LayoutControlItem6.Control = LabelX_UI_UpdateInstallerExeDownloadlink;
            LayoutControlItem6.Height = 31;
            LayoutControlItem6.MinSize = new Size(64, 18);
            LayoutControlItem6.Name = "LayoutControlItem6";
            LayoutControlItem6.Text = "UpdateInstaller.exe Downloadlink:";
            LayoutControlItem6.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem6.TextPadding = new Padding(0, 1, 0, 0);
            LayoutControlItem6.Width = 100;
            LayoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SuperTabItem_UI_General
            // 
            SuperTabItem_UI_General.AttachedControl = SuperTabControlPanel1;
            SuperTabItem_UI_General.GlobalItem = false;
            SuperTabItem_UI_General.Name = "SuperTabItem_UI_General";
            SuperTabItem_UI_General.Text = "Allgemein";
            // 
            // SuperTabControlPanel5
            // 
            SuperTabControlPanel5.Controls.Add(LayoutControl1);
            SuperTabControlPanel5.Dock = DockStyle.Fill;
            SuperTabControlPanel5.Location = new Point(98, 0);
            SuperTabControlPanel5.Name = "SuperTabControlPanel5";
            SuperTabControlPanel5.Size = new Size(550, 394);
            SuperTabControlPanel5.TabIndex = 0;
            SuperTabControlPanel5.TabItem = SuperTabItem_UI_PackageInfo;
            // 
            // LayoutControl1
            // 
            LayoutControl1.BackColor = Color.Transparent;
            LayoutControl1.Controls.Add(LabelX_UI_PackageVersion);
            LayoutControl1.Controls.Add(LabelX_UI_PackageChannel);
            LayoutControl1.Controls.Add(LabelX_UI_PackageBuild);
            LayoutControl1.Controls.Add(LabelX_UI_PackageDownloadlink);
            LayoutControl1.Dock = DockStyle.Fill;
            LayoutControl1.ForeColor = Color.Black;
            LayoutControl1.Location = new Point(0, 0);
            LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { LayoutControlItem2, LayoutControlItem3, LayoutControlItem4, LayoutSpacerItem1, LayoutControlItem5 });
            LayoutControl1.Size = new Size(550, 394);
            LayoutControl1.TabIndex = 0;
            // 
            // LabelX_UI_PackageVersion
            // 
            LabelX_UI_PackageVersion.BackColor = Color.Transparent;
            // 
            // 
            // 
            LabelX_UI_PackageVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX_UI_PackageVersion.Location = new Point(60, 4);
            LabelX_UI_PackageVersion.Margin = new Padding(0);
            LabelX_UI_PackageVersion.Name = "LabelX_UI_PackageVersion";
            LabelX_UI_PackageVersion.Size = new Size(486, 23);
            LabelX_UI_PackageVersion.TabIndex = 0;
            LabelX_UI_PackageVersion.Text = "-";
            // 
            // LabelX_UI_PackageChannel
            // 
            LabelX_UI_PackageChannel.BackColor = Color.Transparent;
            // 
            // 
            // 
            LabelX_UI_PackageChannel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX_UI_PackageChannel.Location = new Point(60, 35);
            LabelX_UI_PackageChannel.Margin = new Padding(0);
            LabelX_UI_PackageChannel.Name = "LabelX_UI_PackageChannel";
            LabelX_UI_PackageChannel.Size = new Size(486, 23);
            LabelX_UI_PackageChannel.TabIndex = 1;
            LabelX_UI_PackageChannel.Text = "-";
            // 
            // LabelX_UI_PackageBuild
            // 
            LabelX_UI_PackageBuild.BackColor = Color.Transparent;
            // 
            // 
            // 
            LabelX_UI_PackageBuild.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX_UI_PackageBuild.Location = new Point(60, 66);
            LabelX_UI_PackageBuild.Margin = new Padding(0);
            LabelX_UI_PackageBuild.Name = "LabelX_UI_PackageBuild";
            LabelX_UI_PackageBuild.Size = new Size(486, 23);
            LabelX_UI_PackageBuild.TabIndex = 2;
            LabelX_UI_PackageBuild.Text = "-";
            // 
            // LabelX_UI_PackageDownloadlink
            // 
            LabelX_UI_PackageDownloadlink.BackColor = Color.Transparent;
            // 
            // 
            // 
            LabelX_UI_PackageDownloadlink.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX_UI_PackageDownloadlink.Location = new Point(60, 129);
            LabelX_UI_PackageDownloadlink.Margin = new Padding(0);
            LabelX_UI_PackageDownloadlink.Name = "LabelX_UI_PackageDownloadlink";
            LabelX_UI_PackageDownloadlink.Size = new Size(486, 23);
            LabelX_UI_PackageDownloadlink.TabIndex = 4;
            LabelX_UI_PackageDownloadlink.Text = "-";
            LabelX_UI_PackageDownloadlink.WordWrap = true;
            // 
            // LayoutControlItem2
            // 
            LayoutControlItem2.Control = LabelX_UI_PackageVersion;
            LayoutControlItem2.Height = 31;
            LayoutControlItem2.MinSize = new Size(64, 18);
            LayoutControlItem2.Name = "LayoutControlItem2";
            LayoutControlItem2.Text = "Version:";
            LayoutControlItem2.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem2.TextPadding = new Padding(0, 1, 0, 0);
            LayoutControlItem2.Width = 100;
            LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            LayoutControlItem3.Control = LabelX_UI_PackageChannel;
            LayoutControlItem3.Height = 31;
            LayoutControlItem3.MinSize = new Size(64, 18);
            LayoutControlItem3.Name = "LayoutControlItem3";
            LayoutControlItem3.Text = "Kanal:";
            LayoutControlItem3.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem3.TextPadding = new Padding(0, 1, 0, 0);
            LayoutControlItem3.Width = 100;
            LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            LayoutControlItem4.Control = LabelX_UI_PackageBuild;
            LayoutControlItem4.Height = 31;
            LayoutControlItem4.MinSize = new Size(64, 18);
            LayoutControlItem4.Name = "LayoutControlItem4";
            LayoutControlItem4.Text = "Build:";
            LayoutControlItem4.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem4.TextPadding = new Padding(0, 1, 0, 0);
            LayoutControlItem4.Width = 100;
            LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            LayoutSpacerItem1.Height = 32;
            LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            LayoutSpacerItem1.Width = 100;
            LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            LayoutControlItem5.Control = LabelX_UI_PackageDownloadlink;
            LayoutControlItem5.Height = 31;
            LayoutControlItem5.MinSize = new Size(64, 18);
            LayoutControlItem5.Name = "LayoutControlItem5";
            LayoutControlItem5.Text = "Paketlink:";
            LayoutControlItem5.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem5.TextPadding = new Padding(0, 1, 0, 0);
            LayoutControlItem5.Width = 100;
            LayoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SuperTabItem_UI_PackageInfo
            // 
            SuperTabItem_UI_PackageInfo.AttachedControl = SuperTabControlPanel5;
            SuperTabItem_UI_PackageInfo.GlobalItem = false;
            SuperTabItem_UI_PackageInfo.Name = "SuperTabItem_UI_PackageInfo";
            SuperTabItem_UI_PackageInfo.Text = "Paket-Info";
            // 
            // SuperTabControlPanel3
            // 
            SuperTabControlPanel3.Controls.Add(Panel3);
            SuperTabControlPanel3.Dock = DockStyle.Fill;
            SuperTabControlPanel3.Location = new Point(98, 0);
            SuperTabControlPanel3.Name = "SuperTabControlPanel3";
            SuperTabControlPanel3.Size = new Size(550, 394);
            SuperTabControlPanel3.TabIndex = 0;
            SuperTabControlPanel3.TabItem = SuperTabItem_UI_Changelog;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.Transparent;
            Panel3.Controls.Add(TextBoxX_UI_PackageChangelog);
            Panel3.Dock = DockStyle.Fill;
            Panel3.Location = new Point(0, 0);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(550, 394);
            Panel3.TabIndex = 1;
            // 
            // TextBoxX_UI_PackageChangelog
            // 
            TextBoxX_UI_PackageChangelog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TextBoxX_UI_PackageChangelog.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_UI_PackageChangelog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_UI_PackageChangelog.ForeColor = Color.Black;
            TextBoxX_UI_PackageChangelog.Location = new Point(0, 0);
            TextBoxX_UI_PackageChangelog.Name = "TextBoxX_UI_PackageChangelog";
            TextBoxX_UI_PackageChangelog.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fnil\fcharset0 Microsoft S" + "ans Serif;}}" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + @"\viewkind4\uc1\pard\f0\fs17\par" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "}" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
            TextBoxX_UI_PackageChangelog.Size = new Size(550, 394);
            TextBoxX_UI_PackageChangelog.TabIndex = 0;
            // 
            // SuperTabItem_UI_Changelog
            // 
            SuperTabItem_UI_Changelog.AttachedControl = SuperTabControlPanel3;
            SuperTabItem_UI_Changelog.GlobalItem = false;
            SuperTabItem_UI_Changelog.Name = "SuperTabItem_UI_Changelog";
            SuperTabItem_UI_Changelog.Text = "Änderungsliste";
            // 
            // SuperTabControlPanel4
            // 
            SuperTabControlPanel4.Controls.Add(Panel4);
            SuperTabControlPanel4.Dock = DockStyle.Fill;
            SuperTabControlPanel4.Location = new Point(98, 0);
            SuperTabControlPanel4.Name = "SuperTabControlPanel4";
            SuperTabControlPanel4.Size = new Size(550, 394);
            SuperTabControlPanel4.TabIndex = 0;
            SuperTabControlPanel4.TabItem = SuperTabItem_Pkg_Extensions;
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.Transparent;
            Panel4.Controls.Add(ListViewEx_Files);
            Panel4.Dock = DockStyle.Fill;
            Panel4.Location = new Point(0, 0);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(550, 394);
            Panel4.TabIndex = 1;
            // 
            // ListViewEx_Files
            // 
            ListViewEx_Files.BackColor = Color.White;
            // 
            // 
            // 
            ListViewEx_Files.Border.Class = "ListViewBorder";
            ListViewEx_Files.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ListViewEx_Files.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader2 });
            ListViewEx_Files.DisabledBackColor = Color.Empty;
            ListViewEx_Files.Dock = DockStyle.Fill;
            ListViewEx_Files.ForeColor = Color.Black;
            ListViewEx_Files.FullRowSelect = true;
            ListViewEx_Files.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewEx_Files.HideSelection = false;
            ListViewEx_Files.Location = new Point(0, 0);
            ListViewEx_Files.Name = "ListViewEx_Files";
            ListViewEx_Files.Size = new Size(550, 394);
            ListViewEx_Files.TabIndex = 0;
            ListViewEx_Files.UseCompatibleStateImageBehavior = false;
            ListViewEx_Files.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Datei";
            ColumnHeader1.Width = 150;
            // 
            // ColumnHeader2
            // 
            ColumnHeader2.Text = "Ort";
            ColumnHeader2.Width = 360;
            // 
            // SuperTabItem_Pkg_Extensions
            // 
            SuperTabItem_Pkg_Extensions.AttachedControl = SuperTabControlPanel4;
            SuperTabItem_Pkg_Extensions.GlobalItem = false;
            SuperTabItem_Pkg_Extensions.Name = "SuperTabItem_Pkg_Extensions";
            SuperTabItem_Pkg_Extensions.Text = "Erweiterungen";
            // 
            // SuperTabControlPanel2
            // 
            SuperTabControlPanel2.Controls.Add(AdvTree1);
            SuperTabControlPanel2.Dock = DockStyle.Fill;
            SuperTabControlPanel2.Location = new Point(98, 0);
            SuperTabControlPanel2.Name = "SuperTabControlPanel2";
            SuperTabControlPanel2.Size = new Size(550, 394);
            SuperTabControlPanel2.TabIndex = 0;
            SuperTabControlPanel2.TabItem = SuperTabItem_Pkg_Files;
            // 
            // AdvTree1
            // 
            AdvTree1.AccessibleRole = AccessibleRole.Outline;
            AdvTree1.BackColor = SystemColors.Window;
            // 
            // 
            // 
            AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
            AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            AdvTree1.Dock = DockStyle.Fill;
            AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            AdvTree1.Location = new Point(0, 0);
            AdvTree1.Name = "AdvTree1";
            AdvTree1.NodesConnector = NodeConnector1;
            AdvTree1.NodeStyle = ElementStyle1;
            AdvTree1.PathSeparator = ";";
            AdvTree1.Size = new Size(550, 394);
            AdvTree1.Styles.Add(ElementStyle1);
            AdvTree1.TabIndex = 0;
            AdvTree1.Text = "AdvTree1";
            // 
            // NodeConnector1
            // 
            NodeConnector1.LineColor = SystemColors.ControlText;
            // 
            // ElementStyle1
            // 
            ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ElementStyle1.Name = "ElementStyle1";
            ElementStyle1.TextColor = SystemColors.ControlText;
            // 
            // SuperTabItem_Pkg_Files
            // 
            SuperTabItem_Pkg_Files.AttachedControl = SuperTabControlPanel2;
            SuperTabItem_Pkg_Files.GlobalItem = false;
            SuperTabItem_Pkg_Files.Name = "SuperTabItem_Pkg_Files";
            SuperTabItem_Pkg_Files.Text = "Dateien";
            // 
            // RibbonControl_Main
            // 
            RibbonControl_Main.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            // 
            // 
            // 
            RibbonControl_Main.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonControl_Main.CanCustomize = false;
            RibbonControl_Main.CaptionVisible = true;
            RibbonControl_Main.Controls.Add(RibbonPanel2);
            RibbonControl_Main.Controls.Add(RibbonPanel1);
            RibbonControl_Main.Dock = DockStyle.Top;
            RibbonControl_Main.ForeColor = Color.Black;
            RibbonControl_Main.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { RibbonTabItem_UpdateInfo, RibbonTabItem_Packaging });
            RibbonControl_Main.KeyTipsFont = new Font("Tahoma", 7.0F);
            RibbonControl_Main.Location = new Point(5, 1);
            RibbonControl_Main.Name = "RibbonControl_Main";
            RibbonControl_Main.Padding = new Padding(0, 0, 0, 3);
            RibbonControl_Main.Size = new Size(640, 154);
            RibbonControl_Main.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonControl_Main.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            RibbonControl_Main.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            RibbonControl_Main.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            RibbonControl_Main.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            RibbonControl_Main.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            RibbonControl_Main.SystemText.QatDialogAddButton = "&Add >>";
            RibbonControl_Main.SystemText.QatDialogCancelButton = "Cancel";
            RibbonControl_Main.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            RibbonControl_Main.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            RibbonControl_Main.SystemText.QatDialogOkButton = "OK";
            RibbonControl_Main.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            RibbonControl_Main.SystemText.QatDialogRemoveButton = "&Remove";
            RibbonControl_Main.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            RibbonControl_Main.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            RibbonControl_Main.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            RibbonControl_Main.TabGroupHeight = 14;
            RibbonControl_Main.TabIndex = 2;
            // 
            // RibbonPanel2
            // 
            RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonPanel2.Controls.Add(RibbonBar_UI_PackageInfo);
            RibbonPanel2.Controls.Add(RibbonBar_UI_Allgemein);
            RibbonPanel2.Controls.Add(RibbonBar2);
            RibbonPanel2.Dock = DockStyle.Fill;
            RibbonPanel2.Location = new Point(0, 56);
            RibbonPanel2.Name = "RibbonPanel2";
            RibbonPanel2.Padding = new Padding(3, 0, 3, 3);
            RibbonPanel2.Size = new Size(640, 95);
            // 
            // 
            // 
            RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonPanel2.TabIndex = 2;
            // 
            // RibbonBar_UI_PackageInfo
            // 
            RibbonBar_UI_PackageInfo.AutoOverflowEnabled = true;
            // 
            // 
            // 
            RibbonBar_UI_PackageInfo.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar_UI_PackageInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonBar_UI_PackageInfo.ContainerControlProcessDialogKey = true;
            RibbonBar_UI_PackageInfo.Dock = DockStyle.Left;
            RibbonBar_UI_PackageInfo.DragDropSupport = true;
            RibbonBar_UI_PackageInfo.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { ItemContainer1, ButtonItem_UI_EditVersion, ButtonItem_UI_EditDownloadlink });
            RibbonBar_UI_PackageInfo.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            RibbonBar_UI_PackageInfo.Location = new Point(327, 0);
            RibbonBar_UI_PackageInfo.Name = "RibbonBar_UI_PackageInfo";
            RibbonBar_UI_PackageInfo.Size = new Size(302, 92);
            RibbonBar_UI_PackageInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonBar_UI_PackageInfo.TabIndex = 1;
            RibbonBar_UI_PackageInfo.Text = "Paket-Info";
            // 
            // 
            // 
            RibbonBar_UI_PackageInfo.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar_UI_PackageInfo.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ItemContainer1
            // 
            // 
            // 
            // 
            ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            ItemContainer1.Name = "ItemContainer1";
            ItemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { ComboBoxItem_UI_PackageInfoList, ButtonItem_UI_AddPackageInfo, ButtonItem_UI_DeletePackageInfo });
            // 
            // 
            // 
            ItemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ComboBoxItem_UI_PackageInfoList
            // 
            ComboBoxItem_UI_PackageInfoList.ComboWidth = 150;
            ComboBoxItem_UI_PackageInfoList.DropDownHeight = 106;
            ComboBoxItem_UI_PackageInfoList.Name = "ComboBoxItem_UI_PackageInfoList";
            ComboBoxItem_UI_PackageInfoList.Text = "ComboBoxItem_UI_PackageInfoList";
            // 
            // ButtonItem_UI_AddPackageInfo
            // 
            ButtonItem_UI_AddPackageInfo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_UI_AddPackageInfo.Image = My.Resources.Resources.icons8_add_16px;
            ButtonItem_UI_AddPackageInfo.Name = "ButtonItem_UI_AddPackageInfo";
            ButtonItem_UI_AddPackageInfo.Text = "Neue Paket-Info";
            // 
            // ButtonItem_UI_DeletePackageInfo
            // 
            ButtonItem_UI_DeletePackageInfo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_UI_DeletePackageInfo.Image = My.Resources.Resources.icons8_delete_sign_16px;
            ButtonItem_UI_DeletePackageInfo.Name = "ButtonItem_UI_DeletePackageInfo";
            ButtonItem_UI_DeletePackageInfo.Text = "Paket-Info löschen";
            // 
            // ButtonItem_UI_EditVersion
            // 
            ButtonItem_UI_EditVersion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_UI_EditVersion.Image = My.Resources.Resources.icons8_versions_32px;
            ButtonItem_UI_EditVersion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_UI_EditVersion.Name = "ButtonItem_UI_EditVersion";
            ButtonItem_UI_EditVersion.SubItemsExpandWidth = 14;
            ButtonItem_UI_EditVersion.Text = "Version bearbeiten";
            // 
            // ButtonItem_UI_EditDownloadlink
            // 
            ButtonItem_UI_EditDownloadlink.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_UI_EditDownloadlink.Image = My.Resources.Resources.icons8_link_32px;
            ButtonItem_UI_EditDownloadlink.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_UI_EditDownloadlink.Name = "ButtonItem_UI_EditDownloadlink";
            ButtonItem_UI_EditDownloadlink.SubItemsExpandWidth = 14;
            ButtonItem_UI_EditDownloadlink.Text = "Paketlink bearbeiten";
            // 
            // RibbonBar_UI_Allgemein
            // 
            RibbonBar_UI_Allgemein.AutoOverflowEnabled = true;
            // 
            // 
            // 
            RibbonBar_UI_Allgemein.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar_UI_Allgemein.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonBar_UI_Allgemein.ContainerControlProcessDialogKey = true;
            RibbonBar_UI_Allgemein.Dock = DockStyle.Left;
            RibbonBar_UI_Allgemein.DragDropSupport = true;
            RibbonBar_UI_Allgemein.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { ButtonItem_UI_EditConfiguration });
            RibbonBar_UI_Allgemein.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            RibbonBar_UI_Allgemein.Location = new Point(233, 0);
            RibbonBar_UI_Allgemein.Name = "RibbonBar_UI_Allgemein";
            RibbonBar_UI_Allgemein.Size = new Size(94, 92);
            RibbonBar_UI_Allgemein.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonBar_UI_Allgemein.TabIndex = 2;
            RibbonBar_UI_Allgemein.Text = "Allgemein";
            // 
            // 
            // 
            RibbonBar_UI_Allgemein.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar_UI_Allgemein.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_UI_EditConfiguration
            // 
            ButtonItem_UI_EditConfiguration.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_UI_EditConfiguration.Image = My.Resources.Resources.icons8_edit_property_32px;
            ButtonItem_UI_EditConfiguration.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_UI_EditConfiguration.Name = "ButtonItem_UI_EditConfiguration";
            ButtonItem_UI_EditConfiguration.SubItemsExpandWidth = 14;
            ButtonItem_UI_EditConfiguration.Text = "Konfiguration bearbeiten";
            // 
            // RibbonBar2
            // 
            RibbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonBar2.ContainerControlProcessDialogKey = true;
            RibbonBar2.Dock = DockStyle.Left;
            RibbonBar2.DragDropSupport = true;
            RibbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { ButtonItem_UI_NewPackage, ButtonItem_UI_Open, ButtonItem_UI_Save, ButtonItem_UI_SaveAs });
            RibbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            RibbonBar2.Location = new Point(3, 0);
            RibbonBar2.Name = "RibbonBar2";
            RibbonBar2.Size = new Size(230, 92);
            RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonBar2.TabIndex = 0;
            RibbonBar2.Text = "Konfiguration";
            // 
            // 
            // 
            RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_UI_NewPackage
            // 
            ButtonItem_UI_NewPackage.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_UI_NewPackage.Image = My.Resources.Resources.icons8_new_file_32px;
            ButtonItem_UI_NewPackage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_UI_NewPackage.Name = "ButtonItem_UI_NewPackage";
            ButtonItem_UI_NewPackage.SubItemsExpandWidth = 14;
            ButtonItem_UI_NewPackage.Text = "Neue Info";
            // 
            // ButtonItem_UI_Open
            // 
            ButtonItem_UI_Open.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_UI_Open.Image = My.Resources.Resources.icons8_code_file_32px;
            ButtonItem_UI_Open.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_UI_Open.Name = "ButtonItem_UI_Open";
            ButtonItem_UI_Open.SubItemsExpandWidth = 14;
            ButtonItem_UI_Open.Text = "Info Öffnen";
            // 
            // ButtonItem_UI_Save
            // 
            ButtonItem_UI_Save.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_UI_Save.Image = My.Resources.Resources.icons8_save_32px;
            ButtonItem_UI_Save.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_UI_Save.Name = "ButtonItem_UI_Save";
            ButtonItem_UI_Save.SubItemsExpandWidth = 14;
            ButtonItem_UI_Save.Text = "Info Speichern";
            // 
            // ButtonItem_UI_SaveAs
            // 
            ButtonItem_UI_SaveAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_UI_SaveAs.Image = My.Resources.Resources.icons8_save_as_32px;
            ButtonItem_UI_SaveAs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_UI_SaveAs.Name = "ButtonItem_UI_SaveAs";
            ButtonItem_UI_SaveAs.SubItemsExpandWidth = 14;
            ButtonItem_UI_SaveAs.Text = "Speichern unter";
            // 
            // RibbonPanel1
            // 
            RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonPanel1.Controls.Add(RibbonBar_Pkg_Erweiterungen);
            RibbonPanel1.Controls.Add(RibbonBar_Pkg_Dateien);
            RibbonPanel1.Controls.Add(RibbonBar1);
            RibbonPanel1.Controls.Add(RibbonBar3);
            RibbonPanel1.Dock = DockStyle.Fill;
            RibbonPanel1.Location = new Point(0, 56);
            RibbonPanel1.Name = "RibbonPanel1";
            RibbonPanel1.Padding = new Padding(3, 0, 3, 3);
            RibbonPanel1.Size = new Size(640, 95);
            // 
            // 
            // 
            RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonPanel1.TabIndex = 1;
            RibbonPanel1.Visible = false;
            // 
            // RibbonBar_Pkg_Erweiterungen
            // 
            RibbonBar_Pkg_Erweiterungen.AutoOverflowEnabled = true;
            // 
            // 
            // 
            RibbonBar_Pkg_Erweiterungen.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar_Pkg_Erweiterungen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonBar_Pkg_Erweiterungen.ContainerControlProcessDialogKey = true;
            RibbonBar_Pkg_Erweiterungen.Dock = DockStyle.Left;
            RibbonBar_Pkg_Erweiterungen.DragDropSupport = true;
            RibbonBar_Pkg_Erweiterungen.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { ButtonItem_Pkg_AddExtension, ButtonItem_Pkg_RemoveExtension });
            RibbonBar_Pkg_Erweiterungen.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            RibbonBar_Pkg_Erweiterungen.Location = new Point(463, 0);
            RibbonBar_Pkg_Erweiterungen.Name = "RibbonBar_Pkg_Erweiterungen";
            RibbonBar_Pkg_Erweiterungen.Size = new Size(144, 92);
            RibbonBar_Pkg_Erweiterungen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonBar_Pkg_Erweiterungen.TabIndex = 3;
            RibbonBar_Pkg_Erweiterungen.Text = "Erweiterungen";
            // 
            // 
            // 
            RibbonBar_Pkg_Erweiterungen.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar_Pkg_Erweiterungen.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_AddExtension
            // 
            ButtonItem_Pkg_AddExtension.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_Pkg_AddExtension.Image = My.Resources.Resources.icons8_merge_files_32px;
            ButtonItem_Pkg_AddExtension.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_Pkg_AddExtension.Name = "ButtonItem_Pkg_AddExtension";
            ButtonItem_Pkg_AddExtension.SubItemsExpandWidth = 14;
            ButtonItem_Pkg_AddExtension.Text = "Erweiterung hinzufügen";
            // 
            // ButtonItem_Pkg_RemoveExtension
            // 
            ButtonItem_Pkg_RemoveExtension.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_Pkg_RemoveExtension.Image = My.Resources.Resources.icons8_delete_sign_32px_1;
            ButtonItem_Pkg_RemoveExtension.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_Pkg_RemoveExtension.Name = "ButtonItem_Pkg_RemoveExtension";
            ButtonItem_Pkg_RemoveExtension.SubItemsExpandWidth = 14;
            ButtonItem_Pkg_RemoveExtension.Text = "Erweiterung entfernen";
            // 
            // RibbonBar_Pkg_Dateien
            // 
            RibbonBar_Pkg_Dateien.AutoOverflowEnabled = true;
            // 
            // 
            // 
            RibbonBar_Pkg_Dateien.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar_Pkg_Dateien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonBar_Pkg_Dateien.ContainerControlProcessDialogKey = true;
            RibbonBar_Pkg_Dateien.Dock = DockStyle.Left;
            RibbonBar_Pkg_Dateien.DragDropSupport = true;
            RibbonBar_Pkg_Dateien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { ButtonItem_Pkg_SelectFileFolder, ButtonItem_Pkg_RemoveFileFolder });
            RibbonBar_Pkg_Dateien.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            RibbonBar_Pkg_Dateien.Location = new Point(314, 0);
            RibbonBar_Pkg_Dateien.Name = "RibbonBar_Pkg_Dateien";
            RibbonBar_Pkg_Dateien.Size = new Size(149, 92);
            RibbonBar_Pkg_Dateien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonBar_Pkg_Dateien.TabIndex = 2;
            RibbonBar_Pkg_Dateien.Text = "Dateien";
            // 
            // 
            // 
            RibbonBar_Pkg_Dateien.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar_Pkg_Dateien.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_SelectFileFolder
            // 
            ButtonItem_Pkg_SelectFileFolder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_Pkg_SelectFileFolder.Image = My.Resources.Resources.icons8_opened_folder_32px;
            ButtonItem_Pkg_SelectFileFolder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_Pkg_SelectFileFolder.Name = "ButtonItem_Pkg_SelectFileFolder";
            ButtonItem_Pkg_SelectFileFolder.SubItemsExpandWidth = 14;
            ButtonItem_Pkg_SelectFileFolder.Text = "Ordner auswählen";
            // 
            // ButtonItem_Pkg_RemoveFileFolder
            // 
            ButtonItem_Pkg_RemoveFileFolder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_Pkg_RemoveFileFolder.Image = My.Resources.Resources.icons8_delete_sign_32px_1;
            ButtonItem_Pkg_RemoveFileFolder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_Pkg_RemoveFileFolder.Name = "ButtonItem_Pkg_RemoveFileFolder";
            ButtonItem_Pkg_RemoveFileFolder.SubItemsExpandWidth = 14;
            ButtonItem_Pkg_RemoveFileFolder.Text = "Ordner entfernen";
            // 
            // RibbonBar1
            // 
            RibbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonBar1.ContainerControlProcessDialogKey = true;
            RibbonBar1.Dock = DockStyle.Left;
            RibbonBar1.DragDropSupport = true;
            RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { ButtonItem_ButtonItem_Pkg_Export });
            RibbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            RibbonBar1.Location = new Point(233, 0);
            RibbonBar1.Name = "RibbonBar1";
            RibbonBar1.Size = new Size(81, 92);
            RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonBar1.TabIndex = 0;
            RibbonBar1.Text = "Paket";
            // 
            // 
            // 
            RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_ButtonItem_Pkg_Export
            // 
            ButtonItem_ButtonItem_Pkg_Export.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_ButtonItem_Pkg_Export.Image = My.Resources.Resources.icons8_export_32px_3;
            ButtonItem_ButtonItem_Pkg_Export.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_ButtonItem_Pkg_Export.Name = "ButtonItem_ButtonItem_Pkg_Export";
            ButtonItem_ButtonItem_Pkg_Export.SubItemsExpandWidth = 14;
            ButtonItem_ButtonItem_Pkg_Export.Text = "Paket exportieren";
            // 
            // RibbonBar3
            // 
            RibbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            RibbonBar3.ContainerControlProcessDialogKey = true;
            RibbonBar3.Dock = DockStyle.Left;
            RibbonBar3.DragDropSupport = true;
            RibbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { ButtonItem_Pkg_NewTemplate, ButtonItem_Pkg_OpenTemplate, ButtonItem_Pkg_SaveTemplate, ButtonItem_Pkg_SaveTemplateAs });
            RibbonBar3.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            RibbonBar3.Location = new Point(3, 0);
            RibbonBar3.Name = "RibbonBar3";
            RibbonBar3.Size = new Size(230, 92);
            RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            RibbonBar3.TabIndex = 1;
            RibbonBar3.Text = "Vorlage";
            // 
            // 
            // 
            RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_NewTemplate
            // 
            ButtonItem_Pkg_NewTemplate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_Pkg_NewTemplate.Image = My.Resources.Resources.icons8_new_file_32px;
            ButtonItem_Pkg_NewTemplate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_Pkg_NewTemplate.Name = "ButtonItem_Pkg_NewTemplate";
            ButtonItem_Pkg_NewTemplate.SubItemsExpandWidth = 14;
            ButtonItem_Pkg_NewTemplate.Text = "Neues Template";
            // 
            // ButtonItem_Pkg_OpenTemplate
            // 
            ButtonItem_Pkg_OpenTemplate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_Pkg_OpenTemplate.Image = My.Resources.Resources.icons8_template_32px;
            ButtonItem_Pkg_OpenTemplate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_Pkg_OpenTemplate.Name = "ButtonItem_Pkg_OpenTemplate";
            ButtonItem_Pkg_OpenTemplate.SubItemsExpandWidth = 14;
            ButtonItem_Pkg_OpenTemplate.Text = "Vorlage Öffnen";
            // 
            // ButtonItem_Pkg_SaveTemplate
            // 
            ButtonItem_Pkg_SaveTemplate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_Pkg_SaveTemplate.Image = My.Resources.Resources.icons8_save_32px;
            ButtonItem_Pkg_SaveTemplate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_Pkg_SaveTemplate.Name = "ButtonItem_Pkg_SaveTemplate";
            ButtonItem_Pkg_SaveTemplate.SubItemsExpandWidth = 14;
            ButtonItem_Pkg_SaveTemplate.Text = "Vorlage Speichern";
            // 
            // ButtonItem_Pkg_SaveTemplateAs
            // 
            ButtonItem_Pkg_SaveTemplateAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            ButtonItem_Pkg_SaveTemplateAs.Image = My.Resources.Resources.icons8_save_as_32px;
            ButtonItem_Pkg_SaveTemplateAs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            ButtonItem_Pkg_SaveTemplateAs.Name = "ButtonItem_Pkg_SaveTemplateAs";
            ButtonItem_Pkg_SaveTemplateAs.SubItemsExpandWidth = 14;
            ButtonItem_Pkg_SaveTemplateAs.Text = "Speichern unter";
            // 
            // RibbonTabItem_UpdateInfo
            // 
            RibbonTabItem_UpdateInfo.Checked = true;
            RibbonTabItem_UpdateInfo.Name = "RibbonTabItem_UpdateInfo";
            RibbonTabItem_UpdateInfo.Panel = RibbonPanel2;
            RibbonTabItem_UpdateInfo.Text = "Update-Info";
            // 
            // RibbonTabItem_Packaging
            // 
            RibbonTabItem_Packaging.Name = "RibbonTabItem_Packaging";
            RibbonTabItem_Packaging.Panel = RibbonPanel1;
            RibbonTabItem_Packaging.Text = "Paketierung";
            // 
            // EditorWindow
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 550);
            Controls.Add(SuperTabControl1);
            Controls.Add(RibbonControl_Main);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditorWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "650; 550";
            Text = "Update-Administration";
            ((System.ComponentModel.ISupportInitialize)SuperTabControl1).EndInit();
            SuperTabControl1.ResumeLayout(false);
            SuperTabControlPanel1.ResumeLayout(false);
            LayoutControl2.ResumeLayout(false);
            SuperTabControlPanel5.ResumeLayout(false);
            LayoutControl1.ResumeLayout(false);
            SuperTabControlPanel3.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            SuperTabControlPanel4.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            SuperTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdvTree1).EndInit();
            RibbonControl_Main.ResumeLayout(false);
            RibbonControl_Main.PerformLayout();
            RibbonPanel2.ResumeLayout(false);
            RibbonPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.SuperTabControl SuperTabControl1;


        private DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel4;


        private DevComponents.DotNetBar.SuperTabItem SuperTabItem_Pkg_Extensions;


        private DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel3;


        private DevComponents.DotNetBar.SuperTabItem SuperTabItem_UI_Changelog;


        private DevComponents.DotNetBar.RibbonControl RibbonControl_Main;


        private DevComponents.DotNetBar.RibbonPanel RibbonPanel1;


        private DevComponents.DotNetBar.RibbonBar RibbonBar1;


        private DevComponents.DotNetBar.RibbonPanel RibbonPanel2;


        private DevComponents.DotNetBar.RibbonTabItem RibbonTabItem_Packaging;


        private DevComponents.DotNetBar.RibbonTabItem RibbonTabItem_UpdateInfo;


        private Panel Panel4;


        private Panel Panel3;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_ButtonItem_Pkg_Export;


        private DevComponents.DotNetBar.RibbonBar RibbonBar2;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_UI_Open;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_UI_Save;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_UI_SaveAs;


        private DevComponents.DotNetBar.RibbonBar RibbonBar3;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_OpenTemplate;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_SaveTemplate;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_SaveTemplateAs;


        private DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel5;


        private DevComponents.DotNetBar.SuperTabItem SuperTabItem_UI_PackageInfo;


        private DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel2;


        private DevComponents.DotNetBar.SuperTabItem SuperTabItem_Pkg_Files;


        private DevComponents.DotNetBar.Controls.RichTextBoxEx TextBoxX_UI_PackageChangelog;


        private DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_Files;


        private DevComponents.AdvTree.AdvTree AdvTree1;


        private DevComponents.AdvTree.NodeConnector NodeConnector1;


        private DevComponents.DotNetBar.ElementStyle ElementStyle1;


        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;


        private DevComponents.DotNetBar.RibbonBar RibbonBar_UI_PackageInfo;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_UI_EditVersion;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_UI_EditDownloadlink;


        private DevComponents.DotNetBar.LabelX LabelX_UI_PackageVersion;


        private DevComponents.DotNetBar.LabelX LabelX_UI_PackageChannel;


        private DevComponents.DotNetBar.LabelX LabelX_UI_PackageBuild;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4;


        private DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1;


        private DevComponents.DotNetBar.ItemContainer ItemContainer1;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_UI_AddPackageInfo;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_UI_DeletePackageInfo;


        private DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel1;


        private DevComponents.DotNetBar.SuperTabItem SuperTabItem_UI_General;


        private DevComponents.DotNetBar.LabelX LabelX_UI_PackageDownloadlink;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5;


        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl2;


        private DevComponents.DotNetBar.RibbonBar RibbonBar_UI_Allgemein;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_UI_EditConfiguration;


        private DevComponents.DotNetBar.LabelX LabelX_UI_UpdateInstallerExeDownloadlink;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6;

        private DevComponents.DotNetBar.RibbonBar RibbonBar_Pkg_Erweiterungen;


        private DevComponents.DotNetBar.RibbonBar RibbonBar_Pkg_Dateien;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_AddExtension;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_RemoveExtension;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_SelectFileFolder;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_UI_NewPackage;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_NewTemplate;


        private ColumnHeader ColumnHeader1;


        private ColumnHeader ColumnHeader2;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_RemoveFileFolder;


        private DevComponents.DotNetBar.ComboBoxItem ComboBoxItem_UI_PackageInfoList;

    }
}