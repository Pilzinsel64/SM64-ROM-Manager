using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    [DesignerGenerated()]
    public partial class UpdateManagerWindow : DevComponents.DotNetBar.RibbonForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateManagerWindow));
            this.SuperTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.ListViewEx_Packages = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Channel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Build = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_IsPublic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuperTabItem_Packages = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.TextBoxX_UpdateInstallerDownloadUrl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.SuperTabItem_UpdateInstaller = new DevComponents.DotNetBar.SuperTabItem();
            this.RibbonControl_Main = new DevComponents.DotNetBar.RibbonControl();
            this.RibbonPanel_Project = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar_Tools = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_OpenPackageCreationDialog = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar_UpdateConfiguration = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_UploadUpdateConfiguration = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ExportUpdateConfiguration = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar_Options = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_ProjectOptions = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar_Project = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_NewProject = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_OpenProject = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_SaveProject = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel_Package = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar_Discord = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_PostMsgInDiscord = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar_PackageManagement = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_ChangeVersion = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_EditDescription = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemovePackage = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar_CreatePackage = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_CreateAndUploadPackage = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_UploadExistingPackage = new DevComponents.DotNetBar.ButtonItem();
            this.RibbonTabItem_Project = new DevComponents.DotNetBar.RibbonTabItem();
            this.RibbonTabItem_Packages = new DevComponents.DotNetBar.RibbonTabItem();
            this.StyleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ButtonItem_BotSettings = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.SuperTabControl1)).BeginInit();
            this.SuperTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.layoutControl1.SuspendLayout();
            this.RibbonControl_Main.SuspendLayout();
            this.RibbonPanel_Project.SuspendLayout();
            this.ribbonPanel_Package.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuperTabControl1
            // 
            this.SuperTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuperTabControl1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SuperTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.SuperTabControl1.ControlBox.MenuBox.Name = "";
            this.SuperTabControl1.ControlBox.Name = "";
            this.SuperTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SuperTabControl1.ControlBox.MenuBox,
            this.SuperTabControl1.ControlBox.CloseBox});
            this.SuperTabControl1.Controls.Add(this.superTabControlPanel1);
            this.SuperTabControl1.Controls.Add(this.superTabControlPanel2);
            this.SuperTabControl1.ForeColor = System.Drawing.Color.Black;
            this.SuperTabControl1.Location = new System.Drawing.Point(1, 155);
            this.SuperTabControl1.Name = "SuperTabControl1";
            this.SuperTabControl1.ReorderTabsEnabled = true;
            this.SuperTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.SuperTabControl1.SelectedTabIndex = 0;
            this.SuperTabControl1.Size = new System.Drawing.Size(648, 394);
            this.SuperTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.SuperTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperTabControl1.TabIndex = 1;
            this.SuperTabControl1.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            this.SuperTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SuperTabItem_Packages,
            this.SuperTabItem_UpdateInstaller});
            this.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.SuperTabControl1.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.SuperTabControl1_SelectedTabChanged);
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.circularProgress1);
            this.superTabControlPanel1.Controls.Add(this.ListViewEx_Packages);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(548, 394);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.SuperTabItem_Packages;
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(237, 160);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgress1.SetVisibleStateOnStart = true;
            this.circularProgress1.SetVisibleStateOnStop = true;
            this.circularProgress1.Size = new System.Drawing.Size(75, 75);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 5;
            this.circularProgress1.Visible = false;
            // 
            // ListViewEx_Packages
            // 
            this.ListViewEx_Packages.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ListViewEx_Packages.Border.Class = "ListViewBorder";
            this.ListViewEx_Packages.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListViewEx_Packages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Version,
            this.columnHeader_Channel,
            this.columnHeader_Build,
            this.columnHeader_IsPublic});
            this.ListViewEx_Packages.DisabledBackColor = System.Drawing.Color.Empty;
            this.ListViewEx_Packages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewEx_Packages.ForeColor = System.Drawing.Color.Black;
            this.ListViewEx_Packages.FullRowSelect = true;
            this.ListViewEx_Packages.GridLines = true;
            this.ListViewEx_Packages.HideSelection = false;
            this.ListViewEx_Packages.Location = new System.Drawing.Point(0, 0);
            this.ListViewEx_Packages.Name = "ListViewEx_Packages";
            this.ListViewEx_Packages.Size = new System.Drawing.Size(548, 394);
            this.ListViewEx_Packages.TabIndex = 0;
            this.ListViewEx_Packages.UseCompatibleStateImageBehavior = false;
            this.ListViewEx_Packages.View = System.Windows.Forms.View.Details;
            this.ListViewEx_Packages.SelectedIndexChanged += new System.EventHandler(this.ListViewEx_Packages_SelectedIndexChanged);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 160;
            // 
            // columnHeader_Version
            // 
            this.columnHeader_Version.Text = "Version";
            this.columnHeader_Version.Width = 100;
            // 
            // columnHeader_Channel
            // 
            this.columnHeader_Channel.Text = "Kanal";
            this.columnHeader_Channel.Width = 100;
            // 
            // columnHeader_Build
            // 
            this.columnHeader_Build.Text = "Build";
            this.columnHeader_Build.Width = 80;
            // 
            // columnHeader_IsPublic
            // 
            this.columnHeader_IsPublic.Text = "Öffentlich";
            this.columnHeader_IsPublic.Width = 80;
            // 
            // SuperTabItem_Packages
            // 
            this.SuperTabItem_Packages.AttachedControl = this.superTabControlPanel1;
            this.SuperTabItem_Packages.GlobalItem = false;
            this.SuperTabItem_Packages.Name = "SuperTabItem_Packages";
            this.SuperTabItem_Packages.Text = "Pakete";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.layoutControl1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(548, 394);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.SuperTabItem_UpdateInstaller;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.TextBoxX_UpdateInstallerDownloadUrl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.ForeColor = System.Drawing.Color.Black;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1});
            this.layoutControl1.Size = new System.Drawing.Size(548, 394);
            this.layoutControl1.TabIndex = 0;
            // 
            // TextBoxX_UpdateInstallerDownloadUrl
            // 
            this.TextBoxX_UpdateInstallerDownloadUrl.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_UpdateInstallerDownloadUrl.Border.Class = "TextBoxBorder";
            this.TextBoxX_UpdateInstallerDownloadUrl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_UpdateInstallerDownloadUrl.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_UpdateInstallerDownloadUrl.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_UpdateInstallerDownloadUrl.Location = new System.Drawing.Point(91, 4);
            this.TextBoxX_UpdateInstallerDownloadUrl.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxX_UpdateInstallerDownloadUrl.Name = "TextBoxX_UpdateInstallerDownloadUrl";
            this.TextBoxX_UpdateInstallerDownloadUrl.PreventEnterBeep = true;
            this.TextBoxX_UpdateInstallerDownloadUrl.Size = new System.Drawing.Size(453, 20);
            this.TextBoxX_UpdateInstallerDownloadUrl.TabIndex = 0;
            this.TextBoxX_UpdateInstallerDownloadUrl.TextChanged += new System.EventHandler(this.TextBoxX_UpdateInstallerDownloadUrl_TextChanged);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TextBoxX_UpdateInstallerDownloadUrl;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Download-URL:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SuperTabItem_UpdateInstaller
            // 
            this.SuperTabItem_UpdateInstaller.AttachedControl = this.superTabControlPanel2;
            this.SuperTabItem_UpdateInstaller.GlobalItem = false;
            this.SuperTabItem_UpdateInstaller.Name = "SuperTabItem_UpdateInstaller";
            this.SuperTabItem_UpdateInstaller.Text = "UpdateInstaller";
            // 
            // RibbonControl_Main
            // 
            this.RibbonControl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.RibbonControl_Main.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonControl_Main.CanCustomize = false;
            this.RibbonControl_Main.CaptionVisible = true;
            this.RibbonControl_Main.Controls.Add(this.RibbonPanel_Project);
            this.RibbonControl_Main.Controls.Add(this.ribbonPanel_Package);
            this.RibbonControl_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonControl_Main.ForeColor = System.Drawing.Color.Black;
            this.RibbonControl_Main.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.RibbonTabItem_Project,
            this.RibbonTabItem_Packages});
            this.RibbonControl_Main.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.RibbonControl_Main.Location = new System.Drawing.Point(5, 1);
            this.RibbonControl_Main.Name = "RibbonControl_Main";
            this.RibbonControl_Main.Size = new System.Drawing.Size(640, 154);
            this.RibbonControl_Main.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonControl_Main.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.RibbonControl_Main.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.RibbonControl_Main.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.RibbonControl_Main.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.RibbonControl_Main.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.RibbonControl_Main.SystemText.QatDialogAddButton = "&Add >>";
            this.RibbonControl_Main.SystemText.QatDialogCancelButton = "Cancel";
            this.RibbonControl_Main.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.RibbonControl_Main.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.RibbonControl_Main.SystemText.QatDialogOkButton = "OK";
            this.RibbonControl_Main.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.RibbonControl_Main.SystemText.QatDialogRemoveButton = "&Remove";
            this.RibbonControl_Main.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.RibbonControl_Main.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.RibbonControl_Main.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.RibbonControl_Main.TabGroupHeight = 14;
            this.RibbonControl_Main.TabIndex = 2;
            // 
            // RibbonPanel_Project
            // 
            this.RibbonPanel_Project.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonPanel_Project.Controls.Add(this.ribbonBar_Tools);
            this.RibbonPanel_Project.Controls.Add(this.ribbonBar_UpdateConfiguration);
            this.RibbonPanel_Project.Controls.Add(this.ribbonBar_Options);
            this.RibbonPanel_Project.Controls.Add(this.ribbonBar_Project);
            this.RibbonPanel_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RibbonPanel_Project.Location = new System.Drawing.Point(0, 55);
            this.RibbonPanel_Project.Name = "RibbonPanel_Project";
            this.RibbonPanel_Project.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.RibbonPanel_Project.Size = new System.Drawing.Size(640, 99);
            // 
            // 
            // 
            this.RibbonPanel_Project.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonPanel_Project.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonPanel_Project.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonPanel_Project.TabIndex = 2;
            // 
            // ribbonBar_Tools
            // 
            this.ribbonBar_Tools.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_Tools.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Tools.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_Tools.ContainerControlProcessDialogKey = true;
            this.ribbonBar_Tools.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar_Tools.DragDropSupport = true;
            this.ribbonBar_Tools.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_OpenPackageCreationDialog});
            this.ribbonBar_Tools.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar_Tools.Location = new System.Drawing.Point(452, 0);
            this.ribbonBar_Tools.Name = "ribbonBar_Tools";
            this.ribbonBar_Tools.Size = new System.Drawing.Size(90, 97);
            this.ribbonBar_Tools.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar_Tools.TabIndex = 1;
            this.ribbonBar_Tools.Text = "Werkzeuge";
            // 
            // 
            // 
            this.ribbonBar_Tools.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Tools.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_OpenPackageCreationDialog
            // 
            this.ButtonItem_OpenPackageCreationDialog.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_OpenPackageCreationDialog.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_open_box_32px;
            this.ButtonItem_OpenPackageCreationDialog.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_OpenPackageCreationDialog.Name = "ButtonItem_OpenPackageCreationDialog";
            this.ButtonItem_OpenPackageCreationDialog.SubItemsExpandWidth = 14;
            this.ButtonItem_OpenPackageCreationDialog.Text = "Neues Paket lokal erstellen";
            this.ButtonItem_OpenPackageCreationDialog.Click += new System.EventHandler(this.ButtonItem_OpenPackageCreationDialog_Click);
            // 
            // ribbonBar_UpdateConfiguration
            // 
            this.ribbonBar_UpdateConfiguration.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_UpdateConfiguration.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_UpdateConfiguration.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_UpdateConfiguration.ContainerControlProcessDialogKey = true;
            this.ribbonBar_UpdateConfiguration.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar_UpdateConfiguration.DragDropSupport = true;
            this.ribbonBar_UpdateConfiguration.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_UploadUpdateConfiguration,
            this.ButtonItem_ExportUpdateConfiguration});
            this.ribbonBar_UpdateConfiguration.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar_UpdateConfiguration.Location = new System.Drawing.Point(289, 0);
            this.ribbonBar_UpdateConfiguration.Name = "ribbonBar_UpdateConfiguration";
            this.ribbonBar_UpdateConfiguration.Size = new System.Drawing.Size(163, 97);
            this.ribbonBar_UpdateConfiguration.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar_UpdateConfiguration.TabIndex = 3;
            this.ribbonBar_UpdateConfiguration.Text = "Konfiguration";
            // 
            // 
            // 
            this.ribbonBar_UpdateConfiguration.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_UpdateConfiguration.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_UploadUpdateConfiguration
            // 
            this.ButtonItem_UploadUpdateConfiguration.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_UploadUpdateConfiguration.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_upload_32px;
            this.ButtonItem_UploadUpdateConfiguration.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_UploadUpdateConfiguration.Name = "ButtonItem_UploadUpdateConfiguration";
            this.ButtonItem_UploadUpdateConfiguration.SubItemsExpandWidth = 14;
            this.ButtonItem_UploadUpdateConfiguration.Text = "Konfiguration bereitstellen";
            this.ButtonItem_UploadUpdateConfiguration.Click += new System.EventHandler(this.ButtonItem_UploadUpdateConfiguration_Click);
            // 
            // ButtonItem_ExportUpdateConfiguration
            // 
            this.ButtonItem_ExportUpdateConfiguration.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_ExportUpdateConfiguration.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_export_32px_3;
            this.ButtonItem_ExportUpdateConfiguration.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_ExportUpdateConfiguration.Name = "ButtonItem_ExportUpdateConfiguration";
            this.ButtonItem_ExportUpdateConfiguration.SubItemsExpandWidth = 14;
            this.ButtonItem_ExportUpdateConfiguration.Text = "Konfiguration exportieren";
            this.ButtonItem_ExportUpdateConfiguration.Click += new System.EventHandler(this.ButtonItem_ExportUpdateConfiguration_Click);
            // 
            // ribbonBar_Options
            // 
            this.ribbonBar_Options.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_Options.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Options.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_Options.ContainerControlProcessDialogKey = true;
            this.ribbonBar_Options.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar_Options.DragDropSupport = true;
            this.ribbonBar_Options.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ProjectOptions});
            this.ribbonBar_Options.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar_Options.Location = new System.Drawing.Point(197, 0);
            this.ribbonBar_Options.Name = "ribbonBar_Options";
            this.ribbonBar_Options.Size = new System.Drawing.Size(92, 97);
            this.ribbonBar_Options.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar_Options.TabIndex = 2;
            this.ribbonBar_Options.Text = "Optionen";
            // 
            // 
            // 
            this.ribbonBar_Options.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Options.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_ProjectOptions
            // 
            this.ButtonItem_ProjectOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_ProjectOptions.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_support_32px_1;
            this.ButtonItem_ProjectOptions.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_ProjectOptions.Name = "ButtonItem_ProjectOptions";
            this.ButtonItem_ProjectOptions.SubItemsExpandWidth = 14;
            this.ButtonItem_ProjectOptions.Text = "Projektoptionen";
            this.ButtonItem_ProjectOptions.Click += new System.EventHandler(this.ButtonItem_ProjectOptions_Click);
            // 
            // ribbonBar_Project
            // 
            this.ribbonBar_Project.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_Project.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Project.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_Project.ContainerControlProcessDialogKey = true;
            this.ribbonBar_Project.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar_Project.DragDropSupport = true;
            this.ribbonBar_Project.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_NewProject,
            this.ButtonItem_OpenProject,
            this.ButtonItem_SaveProject});
            this.ribbonBar_Project.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar_Project.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar_Project.Name = "ribbonBar_Project";
            this.ribbonBar_Project.Size = new System.Drawing.Size(194, 97);
            this.ribbonBar_Project.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar_Project.TabIndex = 0;
            this.ribbonBar_Project.Text = "Projekt";
            // 
            // 
            // 
            this.ribbonBar_Project.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Project.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_NewProject
            // 
            this.ButtonItem_NewProject.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_NewProject.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_new_file_32px;
            this.ButtonItem_NewProject.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_NewProject.Name = "ButtonItem_NewProject";
            this.ButtonItem_NewProject.SubItemsExpandWidth = 14;
            this.ButtonItem_NewProject.Text = "Neues Projekt erstellen";
            this.ButtonItem_NewProject.Click += new System.EventHandler(this.ButtonItem_NewProject_Click);
            // 
            // ButtonItem_OpenProject
            // 
            this.ButtonItem_OpenProject.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_OpenProject.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_opened_folder_32px;
            this.ButtonItem_OpenProject.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_OpenProject.Name = "ButtonItem_OpenProject";
            this.ButtonItem_OpenProject.SubItemsExpandWidth = 14;
            this.ButtonItem_OpenProject.Text = "Projekt öffnen";
            this.ButtonItem_OpenProject.Click += new System.EventHandler(this.ButtonItem_OpenProject_Click);
            // 
            // ButtonItem_SaveProject
            // 
            this.ButtonItem_SaveProject.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_SaveProject.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_save_32px;
            this.ButtonItem_SaveProject.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_SaveProject.Name = "ButtonItem_SaveProject";
            this.ButtonItem_SaveProject.SubItemsExpandWidth = 14;
            this.ButtonItem_SaveProject.Text = "Projekt speichern";
            this.ButtonItem_SaveProject.Click += new System.EventHandler(this.ButtonItem_SaveProject_Click);
            // 
            // ribbonPanel_Package
            // 
            this.ribbonPanel_Package.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel_Package.Controls.Add(this.ribbonBar_Discord);
            this.ribbonPanel_Package.Controls.Add(this.ribbonBar_PackageManagement);
            this.ribbonPanel_Package.Controls.Add(this.ribbonBar_CreatePackage);
            this.ribbonPanel_Package.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel_Package.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel_Package.Name = "ribbonPanel_Package";
            this.ribbonPanel_Package.Padding = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.ribbonPanel_Package.Size = new System.Drawing.Size(640, 99);
            // 
            // 
            // 
            this.ribbonPanel_Package.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel_Package.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel_Package.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel_Package.TabIndex = 3;
            this.ribbonPanel_Package.Visible = false;
            // 
            // ribbonBar_Discord
            // 
            this.ribbonBar_Discord.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_Discord.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Discord.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_Discord.ContainerControlProcessDialogKey = true;
            this.ribbonBar_Discord.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar_Discord.DragDropSupport = true;
            this.ribbonBar_Discord.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_PostMsgInDiscord,
            this.ButtonItem_BotSettings});
            this.ribbonBar_Discord.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar_Discord.Location = new System.Drawing.Point(435, 0);
            this.ribbonBar_Discord.Name = "ribbonBar_Discord";
            this.ribbonBar_Discord.Size = new System.Drawing.Size(193, 97);
            this.ribbonBar_Discord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar_Discord.TabIndex = 2;
            this.ribbonBar_Discord.Text = "Discord";
            // 
            // 
            // 
            this.ribbonBar_Discord.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Discord.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_PostMsgInDiscord
            // 
            this.ButtonItem_PostMsgInDiscord.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_PostMsgInDiscord.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_discord_new_logo_32px;
            this.ButtonItem_PostMsgInDiscord.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_PostMsgInDiscord.Name = "ButtonItem_PostMsgInDiscord";
            this.ButtonItem_PostMsgInDiscord.SubItemsExpandWidth = 14;
            this.ButtonItem_PostMsgInDiscord.Text = "Updatenachricht in Discord posten";
            this.ButtonItem_PostMsgInDiscord.Click += new System.EventHandler(this.ButtonItem_PostMsgInDiscord_Click);
            // 
            // ribbonBar_PackageManagement
            // 
            this.ribbonBar_PackageManagement.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_PackageManagement.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_PackageManagement.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_PackageManagement.ContainerControlProcessDialogKey = true;
            this.ribbonBar_PackageManagement.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar_PackageManagement.DragDropSupport = true;
            this.ribbonBar_PackageManagement.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ChangeVersion,
            this.ButtonItem_EditDescription,
            this.ButtonItem_RemovePackage});
            this.ribbonBar_PackageManagement.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar_PackageManagement.Location = new System.Drawing.Point(234, 0);
            this.ribbonBar_PackageManagement.Name = "ribbonBar_PackageManagement";
            this.ribbonBar_PackageManagement.Size = new System.Drawing.Size(201, 97);
            this.ribbonBar_PackageManagement.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar_PackageManagement.TabIndex = 1;
            this.ribbonBar_PackageManagement.Text = "Paketverwaltung";
            // 
            // 
            // 
            this.ribbonBar_PackageManagement.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_PackageManagement.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_ChangeVersion
            // 
            this.ButtonItem_ChangeVersion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_ChangeVersion.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_edit_property_32px;
            this.ButtonItem_ChangeVersion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_ChangeVersion.Name = "ButtonItem_ChangeVersion";
            this.ButtonItem_ChangeVersion.SubItemsExpandWidth = 14;
            this.ButtonItem_ChangeVersion.Text = "Version ändern";
            this.ButtonItem_ChangeVersion.Click += new System.EventHandler(this.ButtonItem_ChangeVersion_Click);
            // 
            // ButtonItem_EditDescription
            // 
            this.ButtonItem_EditDescription.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_EditDescription.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_edit_file_32px;
            this.ButtonItem_EditDescription.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_EditDescription.Name = "ButtonItem_EditDescription";
            this.ButtonItem_EditDescription.SubItemsExpandWidth = 14;
            this.ButtonItem_EditDescription.Text = "Beschreibung bearbeiten";
            this.ButtonItem_EditDescription.Click += new System.EventHandler(this.ButtonItem_EditDescription_Click);
            // 
            // ButtonItem_RemovePackage
            // 
            this.ButtonItem_RemovePackage.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_RemovePackage.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_delete_sign_32px_1;
            this.ButtonItem_RemovePackage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_RemovePackage.Name = "ButtonItem_RemovePackage";
            this.ButtonItem_RemovePackage.SubItemsExpandWidth = 14;
            this.ButtonItem_RemovePackage.Text = "Vom Server löschen";
            this.ButtonItem_RemovePackage.Click += new System.EventHandler(this.ButtonItem_RemovePackage_Click);
            // 
            // ribbonBar_CreatePackage
            // 
            this.ribbonBar_CreatePackage.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_CreatePackage.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_CreatePackage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_CreatePackage.ContainerControlProcessDialogKey = true;
            this.ribbonBar_CreatePackage.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar_CreatePackage.DragDropSupport = true;
            this.ribbonBar_CreatePackage.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_CreateAndUploadPackage,
            this.ButtonItem_UploadExistingPackage});
            this.ribbonBar_CreatePackage.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar_CreatePackage.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar_CreatePackage.Name = "ribbonBar_CreatePackage";
            this.ribbonBar_CreatePackage.Size = new System.Drawing.Size(231, 97);
            this.ribbonBar_CreatePackage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar_CreatePackage.TabIndex = 0;
            this.ribbonBar_CreatePackage.Text = "Neues Paket";
            // 
            // 
            // 
            this.ribbonBar_CreatePackage.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_CreatePackage.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_CreateAndUploadPackage
            // 
            this.ButtonItem_CreateAndUploadPackage.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_CreateAndUploadPackage.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_open_box_32px;
            this.ButtonItem_CreateAndUploadPackage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_CreateAndUploadPackage.Name = "ButtonItem_CreateAndUploadPackage";
            this.ButtonItem_CreateAndUploadPackage.SubItemsExpandWidth = 14;
            this.ButtonItem_CreateAndUploadPackage.Text = "Neues Paket erstellen und hochladen";
            this.ButtonItem_CreateAndUploadPackage.Click += new System.EventHandler(this.ButtonItem_CreateAndUploadPackage_Click);
            // 
            // ButtonItem_UploadExistingPackage
            // 
            this.ButtonItem_UploadExistingPackage.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_UploadExistingPackage.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_upload_32px;
            this.ButtonItem_UploadExistingPackage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_UploadExistingPackage.Name = "ButtonItem_UploadExistingPackage";
            this.ButtonItem_UploadExistingPackage.SubItemsExpandWidth = 14;
            this.ButtonItem_UploadExistingPackage.Text = "Vorhandenes Paket hochladen";
            this.ButtonItem_UploadExistingPackage.Click += new System.EventHandler(this.ButtonItem_UploadExistingPackage_Click);
            // 
            // RibbonTabItem_Project
            // 
            this.RibbonTabItem_Project.Checked = true;
            this.RibbonTabItem_Project.Name = "RibbonTabItem_Project";
            this.RibbonTabItem_Project.Panel = this.RibbonPanel_Project;
            this.RibbonTabItem_Project.Text = "Projekt";
            // 
            // RibbonTabItem_Packages
            // 
            this.RibbonTabItem_Packages.Name = "RibbonTabItem_Packages";
            this.RibbonTabItem_Packages.Panel = this.ribbonPanel_Package;
            this.RibbonTabItem_Packages.Text = "Pakete";
            // 
            // StyleManager1
            // 
            this.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(42))))));
            // 
            // ButtonItem_BotSettings
            // 
            this.ButtonItem_BotSettings.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_BotSettings.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_administrative_tools_32px;
            this.ButtonItem_BotSettings.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_BotSettings.Name = "ButtonItem_BotSettings";
            this.ButtonItem_BotSettings.SubItemsExpandWidth = 14;
            this.ButtonItem_BotSettings.Text = "Discord Bot-Einstellungen";
            this.ButtonItem_BotSettings.Click += new System.EventHandler(this.ButtonItem_BotSettings_Click);
            // 
            // UpdateManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 550);
            this.Controls.Add(this.SuperTabControl1);
            this.Controls.Add(this.RibbonControl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateManagerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "650; 550";
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.SuperTabControl1)).EndInit();
            this.SuperTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.layoutControl1.ResumeLayout(false);
            this.RibbonControl_Main.ResumeLayout(false);
            this.RibbonControl_Main.PerformLayout();
            this.RibbonPanel_Project.ResumeLayout(false);
            this.ribbonPanel_Package.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.SuperTabControl SuperTabControl1;






        private DevComponents.DotNetBar.RibbonControl RibbonControl_Main;




        private DevComponents.DotNetBar.RibbonPanel RibbonPanel_Project;



        private DevComponents.DotNetBar.RibbonTabItem RibbonTabItem_Project;











































        private DevComponents.DotNetBar.RibbonBar ribbonBar_Project;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem SuperTabItem_Packages;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel_Package;
        private DevComponents.DotNetBar.RibbonTabItem RibbonTabItem_Packages;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem SuperTabItem_UpdateInstaller;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_NewProject;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_OpenProject;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_Tools;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_Options;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ProjectOptions;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_OpenPackageCreationDialog;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_CreatePackage;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_UploadExistingPackage;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_CreateAndUploadPackage;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_PackageManagement;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemovePackage;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_UpdateConfiguration;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_UploadUpdateConfiguration;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ExportUpdateConfiguration;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_SaveProject;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_UpdateInstallerDownloadUrl;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_Packages;
        private ColumnHeader columnHeader_Version;
        private ColumnHeader columnHeader_Channel;
        private ColumnHeader columnHeader_Build;
        private ColumnHeader columnHeader_IsPublic;
        private DevComponents.DotNetBar.StyleManager StyleManager1;
        private ColumnHeader columnHeader_Name;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_Discord;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_PostMsgInDiscord;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ChangeVersion;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_EditDescription;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_BotSettings;
    }
}