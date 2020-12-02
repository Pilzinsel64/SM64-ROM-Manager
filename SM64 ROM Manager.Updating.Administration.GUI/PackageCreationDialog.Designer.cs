using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    [DesignerGenerated()]
    public partial class PackageCreationDialog : DevComponents.DotNetBar.RibbonForm
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
        private System.ComponentModel.IContainer components = new System.ComponentModel.Container();

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageCreationDialog));
            this.SuperTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.SuperTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.AdvTree1 = new DevComponents.AdvTree.AdvTree();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.SuperTabItem_Pkg_Files = new DevComponents.DotNetBar.SuperTabItem();
            this.SuperTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.SuperTabItem_Pkg_Extensions = new DevComponents.DotNetBar.SuperTabItem();
            this.RibbonControl_Main = new DevComponents.DotNetBar.RibbonControl();
            this.RibbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.RibbonBar_Pkg_Erweiterungen = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_Pkg_AddExtension = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Pkg_RemoveExtension = new DevComponents.DotNetBar.ButtonItem();
            this.RibbonBar_Pkg_Dateien = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_Pkg_SelectFileFolder = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Pkg_RemoveFileFolder = new DevComponents.DotNetBar.ButtonItem();
            this.RibbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_Pkg_Export = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_UploadPackage = new DevComponents.DotNetBar.ButtonItem();
            this.RibbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.ButtonItem_Pkg_NewTemplate = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Pkg_OpenTemplate = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Pkg_SaveTemplate = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Pkg_SaveTemplateAs = new DevComponents.DotNetBar.ButtonItem();
            this.RibbonTabItem_Packaging = new DevComponents.DotNetBar.RibbonTabItem();
            this.advTree_Extensions = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.columnHeader3 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader4 = new DevComponents.AdvTree.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.SuperTabControl1)).BeginInit();
            this.SuperTabControl1.SuspendLayout();
            this.SuperTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).BeginInit();
            this.AdvTree1.SuspendLayout();
            this.SuperTabControlPanel4.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.RibbonControl_Main.SuspendLayout();
            this.RibbonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree_Extensions)).BeginInit();
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
            this.SuperTabControl1.Controls.Add(this.SuperTabControlPanel4);
            this.SuperTabControl1.Controls.Add(this.SuperTabControlPanel2);
            this.SuperTabControl1.ForeColor = System.Drawing.Color.Black;
            this.SuperTabControl1.Location = new System.Drawing.Point(1, 155);
            this.SuperTabControl1.Name = "SuperTabControl1";
            this.SuperTabControl1.ReorderTabsEnabled = true;
            this.SuperTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.SuperTabControl1.SelectedTabIndex = 0;
            this.SuperTabControl1.Size = new System.Drawing.Size(632, 355);
            this.SuperTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.SuperTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperTabControl1.TabIndex = 1;
            this.SuperTabControl1.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            this.SuperTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SuperTabItem_Pkg_Files,
            this.SuperTabItem_Pkg_Extensions});
            this.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.SuperTabControl1.Text = "SuperTabControl1";
            this.SuperTabControl1.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.SuperTabControl1_SelectedTabChanged);
            // 
            // SuperTabControlPanel2
            // 
            this.SuperTabControlPanel2.Controls.Add(this.AdvTree1);
            this.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuperTabControlPanel2.Location = new System.Drawing.Point(96, 0);
            this.SuperTabControlPanel2.Name = "SuperTabControlPanel2";
            this.SuperTabControlPanel2.Size = new System.Drawing.Size(552, 394);
            this.SuperTabControlPanel2.TabIndex = 0;
            this.SuperTabControlPanel2.TabItem = this.SuperTabItem_Pkg_Files;
            // 
            // AdvTree1
            // 
            this.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree1.Controls.Add(this.circularProgress1);
            this.AdvTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree1.Location = new System.Drawing.Point(0, 0);
            this.AdvTree1.Name = "AdvTree1";
            this.AdvTree1.NodesConnector = this.NodeConnector1;
            this.AdvTree1.NodeStyle = this.ElementStyle1;
            this.AdvTree1.PathSeparator = ";";
            this.AdvTree1.Size = new System.Drawing.Size(552, 394);
            this.AdvTree1.Styles.Add(this.ElementStyle1);
            this.AdvTree1.TabIndex = 0;
            this.AdvTree1.Text = "AdvTree1";
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(239, 160);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgress1.SetVisibleStateOnStart = true;
            this.circularProgress1.SetVisibleStateOnStop = true;
            this.circularProgress1.Size = new System.Drawing.Size(75, 75);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 6;
            this.circularProgress1.Visible = false;
            // 
            // NodeConnector1
            // 
            this.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // ElementStyle1
            // 
            this.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ElementStyle1.Name = "ElementStyle1";
            this.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // SuperTabItem_Pkg_Files
            // 
            this.SuperTabItem_Pkg_Files.AttachedControl = this.SuperTabControlPanel2;
            this.SuperTabItem_Pkg_Files.GlobalItem = false;
            this.SuperTabItem_Pkg_Files.Name = "SuperTabItem_Pkg_Files";
            this.SuperTabItem_Pkg_Files.Text = "Dateien";
            // 
            // SuperTabControlPanel4
            // 
            this.SuperTabControlPanel4.Controls.Add(this.Panel4);
            this.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuperTabControlPanel4.Location = new System.Drawing.Point(96, 0);
            this.SuperTabControlPanel4.Name = "SuperTabControlPanel4";
            this.SuperTabControlPanel4.Size = new System.Drawing.Size(552, 394);
            this.SuperTabControlPanel4.TabIndex = 0;
            this.SuperTabControlPanel4.TabItem = this.SuperTabItem_Pkg_Extensions;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Transparent;
            this.Panel4.Controls.Add(this.advTree_Extensions);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(552, 394);
            this.Panel4.TabIndex = 1;
            // 
            // SuperTabItem_Pkg_Extensions
            // 
            this.SuperTabItem_Pkg_Extensions.AttachedControl = this.SuperTabControlPanel4;
            this.SuperTabItem_Pkg_Extensions.GlobalItem = false;
            this.SuperTabItem_Pkg_Extensions.Name = "SuperTabItem_Pkg_Extensions";
            this.SuperTabItem_Pkg_Extensions.Text = "Erweiterungen";
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
            this.RibbonControl_Main.Controls.Add(this.RibbonPanel1);
            this.RibbonControl_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonControl_Main.ForeColor = System.Drawing.Color.Black;
            this.RibbonControl_Main.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.RibbonTabItem_Packaging});
            this.RibbonControl_Main.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.RibbonControl_Main.Location = new System.Drawing.Point(5, 1);
            this.RibbonControl_Main.Name = "RibbonControl_Main";
            this.RibbonControl_Main.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
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
            // RibbonPanel1
            // 
            this.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonPanel1.Controls.Add(this.RibbonBar_Pkg_Erweiterungen);
            this.RibbonPanel1.Controls.Add(this.RibbonBar_Pkg_Dateien);
            this.RibbonPanel1.Controls.Add(this.RibbonBar1);
            this.RibbonPanel1.Controls.Add(this.RibbonBar3);
            this.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RibbonPanel1.Location = new System.Drawing.Point(0, 56);
            this.RibbonPanel1.Name = "RibbonPanel1";
            this.RibbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.RibbonPanel1.Size = new System.Drawing.Size(640, 95);
            // 
            // 
            // 
            this.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonPanel1.TabIndex = 1;
            // 
            // RibbonBar_Pkg_Erweiterungen
            // 
            this.RibbonBar_Pkg_Erweiterungen.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.RibbonBar_Pkg_Erweiterungen.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar_Pkg_Erweiterungen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar_Pkg_Erweiterungen.ContainerControlProcessDialogKey = true;
            this.RibbonBar_Pkg_Erweiterungen.Dock = System.Windows.Forms.DockStyle.Left;
            this.RibbonBar_Pkg_Erweiterungen.DragDropSupport = true;
            this.RibbonBar_Pkg_Erweiterungen.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_Pkg_AddExtension,
            this.ButtonItem_Pkg_RemoveExtension});
            this.RibbonBar_Pkg_Erweiterungen.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.RibbonBar_Pkg_Erweiterungen.Location = new System.Drawing.Point(510, 0);
            this.RibbonBar_Pkg_Erweiterungen.Name = "RibbonBar_Pkg_Erweiterungen";
            this.RibbonBar_Pkg_Erweiterungen.Size = new System.Drawing.Size(144, 92);
            this.RibbonBar_Pkg_Erweiterungen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonBar_Pkg_Erweiterungen.TabIndex = 3;
            this.RibbonBar_Pkg_Erweiterungen.Text = "Erweiterungen";
            // 
            // 
            // 
            this.RibbonBar_Pkg_Erweiterungen.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar_Pkg_Erweiterungen.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_AddExtension
            // 
            this.ButtonItem_Pkg_AddExtension.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Pkg_AddExtension.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_merge_files_32px;
            this.ButtonItem_Pkg_AddExtension.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_Pkg_AddExtension.Name = "ButtonItem_Pkg_AddExtension";
            this.ButtonItem_Pkg_AddExtension.SubItemsExpandWidth = 14;
            this.ButtonItem_Pkg_AddExtension.Text = "Erweiterung hinzufügen";
            this.ButtonItem_Pkg_AddExtension.Click += new System.EventHandler(this.ButtonItem_Pkg_AddExtension_Click);
            // 
            // ButtonItem_Pkg_RemoveExtension
            // 
            this.ButtonItem_Pkg_RemoveExtension.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Pkg_RemoveExtension.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_delete_sign_32px_1;
            this.ButtonItem_Pkg_RemoveExtension.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_Pkg_RemoveExtension.Name = "ButtonItem_Pkg_RemoveExtension";
            this.ButtonItem_Pkg_RemoveExtension.SubItemsExpandWidth = 14;
            this.ButtonItem_Pkg_RemoveExtension.Text = "Erweiterung entfernen";
            this.ButtonItem_Pkg_RemoveExtension.Click += new System.EventHandler(this.ButtonItem_Pkg_RemoveExtension_Click);
            // 
            // RibbonBar_Pkg_Dateien
            // 
            this.RibbonBar_Pkg_Dateien.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.RibbonBar_Pkg_Dateien.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar_Pkg_Dateien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar_Pkg_Dateien.ContainerControlProcessDialogKey = true;
            this.RibbonBar_Pkg_Dateien.Dock = System.Windows.Forms.DockStyle.Left;
            this.RibbonBar_Pkg_Dateien.DragDropSupport = true;
            this.RibbonBar_Pkg_Dateien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_Pkg_SelectFileFolder,
            this.ButtonItem_Pkg_RemoveFileFolder});
            this.RibbonBar_Pkg_Dateien.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.RibbonBar_Pkg_Dateien.Location = new System.Drawing.Point(381, 0);
            this.RibbonBar_Pkg_Dateien.Name = "RibbonBar_Pkg_Dateien";
            this.RibbonBar_Pkg_Dateien.Size = new System.Drawing.Size(129, 92);
            this.RibbonBar_Pkg_Dateien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonBar_Pkg_Dateien.TabIndex = 2;
            this.RibbonBar_Pkg_Dateien.Text = "Dateien";
            // 
            // 
            // 
            this.RibbonBar_Pkg_Dateien.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar_Pkg_Dateien.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_SelectFileFolder
            // 
            this.ButtonItem_Pkg_SelectFileFolder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Pkg_SelectFileFolder.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_opened_folder_32px;
            this.ButtonItem_Pkg_SelectFileFolder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_Pkg_SelectFileFolder.Name = "ButtonItem_Pkg_SelectFileFolder";
            this.ButtonItem_Pkg_SelectFileFolder.SubItemsExpandWidth = 14;
            this.ButtonItem_Pkg_SelectFileFolder.Text = "Ordner auswählen";
            this.ButtonItem_Pkg_SelectFileFolder.Click += new System.EventHandler(this.ButtonItem_Pkg_SelectFileFolder_Click);
            // 
            // ButtonItem_Pkg_RemoveFileFolder
            // 
            this.ButtonItem_Pkg_RemoveFileFolder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Pkg_RemoveFileFolder.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_delete_sign_32px_1;
            this.ButtonItem_Pkg_RemoveFileFolder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_Pkg_RemoveFileFolder.Name = "ButtonItem_Pkg_RemoveFileFolder";
            this.ButtonItem_Pkg_RemoveFileFolder.SubItemsExpandWidth = 14;
            this.ButtonItem_Pkg_RemoveFileFolder.Text = "Ordner entfernen";
            this.ButtonItem_Pkg_RemoveFileFolder.Click += new System.EventHandler(this.ButtonItem_Pkg_RemoveFileFolder_Click);
            // 
            // RibbonBar1
            // 
            this.RibbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar1.ContainerControlProcessDialogKey = true;
            this.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.RibbonBar1.DragDropSupport = true;
            this.RibbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_Pkg_Export,
            this.ButtonItem_UploadPackage});
            this.RibbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.RibbonBar1.Location = new System.Drawing.Point(233, 0);
            this.RibbonBar1.Name = "RibbonBar1";
            this.RibbonBar1.Size = new System.Drawing.Size(148, 92);
            this.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonBar1.TabIndex = 0;
            this.RibbonBar1.Text = "Paket";
            // 
            // 
            // 
            this.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_Export
            // 
            this.ButtonItem_Pkg_Export.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Pkg_Export.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_export_32px_3;
            this.ButtonItem_Pkg_Export.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_Pkg_Export.Name = "ButtonItem_Pkg_Export";
            this.ButtonItem_Pkg_Export.SubItemsExpandWidth = 14;
            this.ButtonItem_Pkg_Export.Text = "Paket exportieren";
            this.ButtonItem_Pkg_Export.Click += new System.EventHandler(this.ButtonItem_Pkg_Export_Click);
            // 
            // ButtonItem_UploadPackage
            // 
            this.ButtonItem_UploadPackage.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_UploadPackage.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_checkmark_32px;
            this.ButtonItem_UploadPackage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_UploadPackage.Name = "ButtonItem_UploadPackage";
            this.ButtonItem_UploadPackage.SubItemsExpandWidth = 14;
            this.ButtonItem_UploadPackage.Text = "Paket fertigstellen";
            this.ButtonItem_UploadPackage.Click += new System.EventHandler(this.ButtonItem_UploadPackage_Click);
            // 
            // RibbonBar3
            // 
            this.RibbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar3.ContainerControlProcessDialogKey = true;
            this.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.RibbonBar3.DragDropSupport = true;
            this.RibbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_Pkg_NewTemplate,
            this.ButtonItem_Pkg_OpenTemplate,
            this.ButtonItem_Pkg_SaveTemplate,
            this.ButtonItem_Pkg_SaveTemplateAs});
            this.RibbonBar3.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.RibbonBar3.Location = new System.Drawing.Point(3, 0);
            this.RibbonBar3.Name = "RibbonBar3";
            this.RibbonBar3.Size = new System.Drawing.Size(230, 92);
            this.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonBar3.TabIndex = 1;
            this.RibbonBar3.Text = "Vorlage";
            // 
            // 
            // 
            this.RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonItem_Pkg_NewTemplate
            // 
            this.ButtonItem_Pkg_NewTemplate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Pkg_NewTemplate.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_new_file_32px;
            this.ButtonItem_Pkg_NewTemplate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_Pkg_NewTemplate.Name = "ButtonItem_Pkg_NewTemplate";
            this.ButtonItem_Pkg_NewTemplate.SubItemsExpandWidth = 14;
            this.ButtonItem_Pkg_NewTemplate.Text = "Neues Template";
            this.ButtonItem_Pkg_NewTemplate.Click += new System.EventHandler(this.ButtonItem_Pkg_NewTemplate_Click);
            // 
            // ButtonItem_Pkg_OpenTemplate
            // 
            this.ButtonItem_Pkg_OpenTemplate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Pkg_OpenTemplate.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_template_32px;
            this.ButtonItem_Pkg_OpenTemplate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_Pkg_OpenTemplate.Name = "ButtonItem_Pkg_OpenTemplate";
            this.ButtonItem_Pkg_OpenTemplate.SubItemsExpandWidth = 14;
            this.ButtonItem_Pkg_OpenTemplate.Text = "Vorlage Öffnen";
            this.ButtonItem_Pkg_OpenTemplate.Click += new System.EventHandler(this.ButtonItem_Pkg_OpenTemplate_Click);
            // 
            // ButtonItem_Pkg_SaveTemplate
            // 
            this.ButtonItem_Pkg_SaveTemplate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Pkg_SaveTemplate.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_save_32px;
            this.ButtonItem_Pkg_SaveTemplate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_Pkg_SaveTemplate.Name = "ButtonItem_Pkg_SaveTemplate";
            this.ButtonItem_Pkg_SaveTemplate.SubItemsExpandWidth = 14;
            this.ButtonItem_Pkg_SaveTemplate.Text = "Vorlage Speichern";
            this.ButtonItem_Pkg_SaveTemplate.Click += new System.EventHandler(this.ButtonItem_Pkg_SaveTemplate_Click);
            // 
            // ButtonItem_Pkg_SaveTemplateAs
            // 
            this.ButtonItem_Pkg_SaveTemplateAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Pkg_SaveTemplateAs.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_save_as_32px;
            this.ButtonItem_Pkg_SaveTemplateAs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonItem_Pkg_SaveTemplateAs.Name = "ButtonItem_Pkg_SaveTemplateAs";
            this.ButtonItem_Pkg_SaveTemplateAs.SubItemsExpandWidth = 14;
            this.ButtonItem_Pkg_SaveTemplateAs.Text = "Speichern unter";
            this.ButtonItem_Pkg_SaveTemplateAs.Click += new System.EventHandler(this.ButtonItem_Pkg_SaveTemplateAs_Click);
            // 
            // RibbonTabItem_Packaging
            // 
            this.RibbonTabItem_Packaging.Checked = true;
            this.RibbonTabItem_Packaging.Name = "RibbonTabItem_Packaging";
            this.RibbonTabItem_Packaging.Panel = this.RibbonPanel1;
            this.RibbonTabItem_Packaging.Text = "Paketierung";
            // 
            // advTree_Extensions
            // 
            this.advTree_Extensions.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree_Extensions.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree_Extensions.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree_Extensions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree_Extensions.Columns.Add(this.columnHeader3);
            this.advTree_Extensions.Columns.Add(this.columnHeader4);
            this.advTree_Extensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTree_Extensions.DragDropEnabled = false;
            this.advTree_Extensions.ExpandWidth = 0;
            this.advTree_Extensions.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree_Extensions.Location = new System.Drawing.Point(0, 0);
            this.advTree_Extensions.Name = "advTree_Extensions";
            this.advTree_Extensions.MultiSelect = true;
            this.advTree_Extensions.NodesConnector = this.nodeConnector2;
            this.advTree_Extensions.NodeStyle = this.elementStyle2;
            this.advTree_Extensions.PathSeparator = ";";
            this.advTree_Extensions.Size = new System.Drawing.Size(552, 394);
            this.advTree_Extensions.Styles.Add(this.elementStyle2);
            this.advTree_Extensions.TabIndex = 1;
            this.advTree_Extensions.Text = "advTree2";
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Datei";
            this.columnHeader3.Width.Absolute = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.StretchToFill = true;
            this.columnHeader4.Text = "Ort";
            this.columnHeader4.Width.Absolute = 150;
            // 
            // PackageCreationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(650, 550);
            this.Controls.Add(this.SuperTabControl1);
            this.Controls.Add(this.RibbonControl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PackageCreationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "650; 550";
            this.Text = "Paket erstellen";
            ((System.ComponentModel.ISupportInitialize)(this.SuperTabControl1)).EndInit();
            this.SuperTabControl1.ResumeLayout(false);
            this.SuperTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).EndInit();
            this.AdvTree1.ResumeLayout(false);
            this.SuperTabControlPanel4.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.RibbonControl_Main.ResumeLayout(false);
            this.RibbonControl_Main.PerformLayout();
            this.RibbonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree_Extensions)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.SuperTabControl SuperTabControl1;


        private DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel4;


        private DevComponents.DotNetBar.SuperTabItem SuperTabItem_Pkg_Extensions;




        private DevComponents.DotNetBar.RibbonControl RibbonControl_Main;


        private DevComponents.DotNetBar.RibbonPanel RibbonPanel1;


        private DevComponents.DotNetBar.RibbonBar RibbonBar1;



        private DevComponents.DotNetBar.RibbonTabItem RibbonTabItem_Packaging;



        private Panel Panel4;



        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_Export;






        private DevComponents.DotNetBar.RibbonBar RibbonBar3;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_OpenTemplate;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_SaveTemplate;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_SaveTemplateAs;




        private DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel2;


        private DevComponents.DotNetBar.SuperTabItem SuperTabItem_Pkg_Files;




        private DevComponents.AdvTree.AdvTree AdvTree1;


        private DevComponents.AdvTree.NodeConnector NodeConnector1;


        private DevComponents.DotNetBar.ElementStyle ElementStyle1;
























        private DevComponents.DotNetBar.RibbonBar RibbonBar_Pkg_Erweiterungen;


        private DevComponents.DotNetBar.RibbonBar RibbonBar_Pkg_Dateien;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_AddExtension;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_RemoveExtension;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_SelectFileFolder;



        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_NewTemplate;




        private DevComponents.DotNetBar.ButtonItem ButtonItem_Pkg_RemoveFileFolder;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_UploadPackage;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private DevComponents.AdvTree.AdvTree advTree_Extensions;
        private DevComponents.AdvTree.ColumnHeader columnHeader3;
        private DevComponents.AdvTree.ColumnHeader columnHeader4;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
    }
}