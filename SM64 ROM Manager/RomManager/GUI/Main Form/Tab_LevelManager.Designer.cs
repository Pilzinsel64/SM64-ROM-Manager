using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Tab_LevelManager : UserControl
    {

        // UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_LevelManager));
            this.GroupBox_LM_Areas = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Button_LM_AddArea = new DevComponents.DotNetBar.ButtonX();
            this.ButtonItem_ImportArea = new DevComponents.DotNetBar.ButtonItem();
            this.Button_LM_AreaEditor = new DevComponents.DotNetBar.ButtonX();
            this.Button_LM_RemoveArea = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_EditAreaLevelScript = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem2_EditGeolayoutScript = new DevComponents.DotNetBar.ButtonItem();
            this.ListBoxAdv_LM_Areas = new SM64_ROM_Manager.Publics.Controls.ItemListBox();
            this.GroupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ButtonX_LM_LevelsMore = new DevComponents.DotNetBar.ButtonX();
            this.ButtonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem24 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem19 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem21 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.Button_LM_AddNewLevel = new DevComponents.DotNetBar.ButtonX();
            this.ButtonItem26 = new DevComponents.DotNetBar.ButtonItem();
            this.ListBoxAdv_LM_Levels = new SM64_ROM_Manager.Publics.Controls.ItemListBox();
            this.TabControl_LM_Area = new DevComponents.DotNetBar.TabControl();
            this.TabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.Slider_AreaReverbLevel = new DevComponents.DotNetBar.Controls.Slider();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.LabelX9 = new DevComponents.DotNetBar.LabelX();
            this.ComboBoxEx_LM_AreaBG = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem12 = new DevComponents.Editors.ComboItem();
            this.ComboItem13 = new DevComponents.Editors.ComboItem();
            this.TextBoxX_LM_ShowMsgID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_LM_ShowMsgEnabled = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.CheckBoxX_LM_Enable2DCamera = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.ComboBox_LM_Music = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX7 = new DevComponents.DotNetBar.LabelX();
            this.ComboBox_LM_TerrainTyp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX8 = new DevComponents.DotNetBar.LabelX();
            this.ComboBox_LM_EnvironmentEffects = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX11 = new DevComponents.DotNetBar.LabelX();
            this.ComboBox_LM_CameraPreset = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ColorPickerButton_LM_BackgroundColor = new DevComponents.DotNetBar.ColorPickerButton();
            this.TabItem4 = new DevComponents.DotNetBar.TabItem(this.components);
            this.TabControlPanel5 = new DevComponents.DotNetBar.TabControlPanel();
            this.Line2 = new DevComponents.DotNetBar.Controls.Line();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.LabelX_Area_CountOfTexAnimations = new DevComponents.DotNetBar.LabelX();
            this.LabelX10 = new DevComponents.DotNetBar.LabelX();
            this.ButtonX_EditCollision = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_EditFast3D = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_ImportCollision = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_ImportVisualMap = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_LM_ScrollTexEditor = new DevComponents.DotNetBar.ButtonX();
            this.Button_ImportModel = new DevComponents.DotNetBar.ButtonX();
            this.TabItem5 = new DevComponents.DotNetBar.TabItem(this.components);
            this.TabControlPanel6 = new DevComponents.DotNetBar.TabControlPanel();
            this.Button_LM_RemoveSpecial = new DevComponents.DotNetBar.ButtonX();
            this.Button_LM_AddSpecial = new DevComponents.DotNetBar.ButtonX();
            this.Button_LM_EditSpecial = new DevComponents.DotNetBar.ButtonX();
            this.ListViewEx_LM_Specials = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.ColumnHeaderA1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabItem6 = new DevComponents.DotNetBar.TabItem(this.components);
            this.TabControl_LM_Level = new DevComponents.DotNetBar.TabControl();
            this.TabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.LabelX_TargetLevel = new DevComponents.DotNetBar.LabelX();
            this.LabelX12 = new DevComponents.DotNetBar.LabelX();
            this.PictureBox_BGImage = new System.Windows.Forms.PictureBox();
            this.ComboBoxEx_LM_BGMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem1 = new DevComponents.Editors.ComboItem();
            this.ComboItem2 = new DevComponents.Editors.ComboItem();
            this.ComboItem3 = new DevComponents.Editors.ComboItem();
            this.LabelX15 = new DevComponents.DotNetBar.LabelX();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_LM_ActSelector = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX57 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_LM_HardcodedCameraSettings = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.ComboBox_LM_LevelBG = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX24 = new DevComponents.DotNetBar.LabelX();
            this.NUD_LM_DefaultPositionYRotation = new System.Windows.Forms.NumericUpDown();
            this.LabelX25 = new DevComponents.DotNetBar.LabelX();
            this.NUD_LM_DefaultPositionAreaID = new System.Windows.Forms.NumericUpDown();
            this.Button_LM_LoadLevelBG = new DevComponents.DotNetBar.ButtonX();
            this.Button_LM_SetUpStartPosition = new DevComponents.DotNetBar.ButtonX();
            this.TabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.TabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.ButtonX_ManageLocalObjects = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_UseLocalObjectBank = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX13 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_UseGlobalObjectBank = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.TableLayoutPanel_ObjectBankSelectorBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.TabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.GroupBox_LM_Areas.SuspendLayout();
            this.GroupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_LM_Area)).BeginInit();
            this.TabControl_LM_Area.SuspendLayout();
            this.TabControlPanel4.SuspendLayout();
            this.TabControlPanel5.SuspendLayout();
            this.TabControlPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_LM_Level)).BeginInit();
            this.TabControl_LM_Level.SuspendLayout();
            this.TabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BGImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LM_DefaultPositionYRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LM_DefaultPositionAreaID)).BeginInit();
            this.TabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_LM_Areas
            // 
            resources.ApplyResources(this.GroupBox_LM_Areas, "GroupBox_LM_Areas");
            this.GroupBox_LM_Areas.CanvasColor = System.Drawing.Color.Empty;
            this.GroupBox_LM_Areas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupBox_LM_Areas.Controls.Add(this.Button_LM_AddArea);
            this.GroupBox_LM_Areas.Controls.Add(this.Button_LM_AreaEditor);
            this.GroupBox_LM_Areas.Controls.Add(this.ListBoxAdv_LM_Areas);
            this.GroupBox_LM_Areas.DisabledBackColor = System.Drawing.Color.Empty;
            this.GroupBox_LM_Areas.Name = "GroupBox_LM_Areas";
            // 
            // 
            // 
            this.GroupBox_LM_Areas.Style.BackColorGradientAngle = 90;
            this.GroupBox_LM_Areas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupBox_LM_Areas.Style.BorderBottomWidth = 1;
            this.GroupBox_LM_Areas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupBox_LM_Areas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupBox_LM_Areas.Style.BorderLeftWidth = 1;
            this.GroupBox_LM_Areas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupBox_LM_Areas.Style.BorderRightWidth = 1;
            this.GroupBox_LM_Areas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupBox_LM_Areas.Style.BorderTopWidth = 1;
            this.GroupBox_LM_Areas.Style.CornerDiameter = 4;
            this.GroupBox_LM_Areas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupBox_LM_Areas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupBox_LM_Areas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupBox_LM_Areas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupBox_LM_Areas.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupBox_LM_Areas.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupBox_LM_Areas.EnabledChanged += new System.EventHandler(this.GroupBox_LM_Areas_EnabledChanged);
            // 
            // Button_LM_AddArea
            // 
            this.Button_LM_AddArea.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_LM_AddArea.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.Button_LM_AddArea, "Button_LM_AddArea");
            this.Button_LM_AddArea.FocusCuesEnabled = false;
            this.Button_LM_AddArea.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.Button_LM_AddArea.Name = "Button_LM_AddArea";
            this.Button_LM_AddArea.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_LM_AddArea.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ImportArea});
            this.Button_LM_AddArea.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.Button_LM_AddArea.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.Button_LM_AddArea.SymbolSize = 12F;
            this.Button_LM_AddArea.Click += new System.EventHandler(this.Button_LM_AddArea_Click);
            // 
            // ButtonItem_ImportArea
            // 
            this.ButtonItem_ImportArea.GlobalItem = false;
            this.ButtonItem_ImportArea.Name = "ButtonItem_ImportArea";
            resources.ApplyResources(this.ButtonItem_ImportArea, "ButtonItem_ImportArea");
            this.ButtonItem_ImportArea.Click += new System.EventHandler(this.ButtonItem_ImportArea_Click);
            // 
            // Button_LM_AreaEditor
            // 
            this.Button_LM_AreaEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_LM_AreaEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.Button_LM_AreaEditor, "Button_LM_AreaEditor");
            this.Button_LM_AreaEditor.FocusCuesEnabled = false;
            this.Button_LM_AreaEditor.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.Button_LM_AreaEditor.Name = "Button_LM_AreaEditor";
            this.Button_LM_AreaEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_LM_AreaEditor.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Button_LM_RemoveArea,
            this.ButtonItem_EditAreaLevelScript,
            this.ButtonItem2_EditGeolayoutScript});
            this.Button_LM_AreaEditor.SymbolColor = System.Drawing.Color.Goldenrod;
            this.Button_LM_AreaEditor.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.Button_LM_AreaEditor.SymbolSize = 12F;
            this.Button_LM_AreaEditor.Click += new System.EventHandler(this.LM_OpenAreaEditor);
            // 
            // Button_LM_RemoveArea
            // 
            this.Button_LM_RemoveArea.GlobalItem = false;
            this.Button_LM_RemoveArea.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.Button_LM_RemoveArea.Name = "Button_LM_RemoveArea";
            this.Button_LM_RemoveArea.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_LM_RemoveArea.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.Button_LM_RemoveArea.SymbolSize = 12F;
            resources.ApplyResources(this.Button_LM_RemoveArea, "Button_LM_RemoveArea");
            this.Button_LM_RemoveArea.Click += new System.EventHandler(this.Button_LM_RemoveArea_Click);
            // 
            // ButtonItem_EditAreaLevelScript
            // 
            this.ButtonItem_EditAreaLevelScript.BeginGroup = true;
            this.ButtonItem_EditAreaLevelScript.GlobalItem = false;
            this.ButtonItem_EditAreaLevelScript.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_EditAreaLevelScript.Name = "ButtonItem_EditAreaLevelScript";
            this.ButtonItem_EditAreaLevelScript.SymbolColor = System.Drawing.Color.Goldenrod;
            this.ButtonItem_EditAreaLevelScript.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_EditAreaLevelScript.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem_EditAreaLevelScript, "ButtonItem_EditAreaLevelScript");
            this.ButtonItem_EditAreaLevelScript.Click += new System.EventHandler(this.ButtonItem_EditAreaLevelScript_Click);
            // 
            // ButtonItem2_EditGeolayoutScript
            // 
            this.ButtonItem2_EditGeolayoutScript.GlobalItem = false;
            this.ButtonItem2_EditGeolayoutScript.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem2_EditGeolayoutScript.Name = "ButtonItem2_EditGeolayoutScript";
            this.ButtonItem2_EditGeolayoutScript.SymbolColor = System.Drawing.Color.Goldenrod;
            this.ButtonItem2_EditGeolayoutScript.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem2_EditGeolayoutScript.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem2_EditGeolayoutScript, "ButtonItem2_EditGeolayoutScript");
            this.ButtonItem2_EditGeolayoutScript.Click += new System.EventHandler(this.ButtonItem2_EditGeolayoutScript_Click);
            // 
            // ListBoxAdv_LM_Areas
            // 
            resources.ApplyResources(this.ListBoxAdv_LM_Areas, "ListBoxAdv_LM_Areas");
            this.ListBoxAdv_LM_Areas.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ListBoxAdv_LM_Areas.BackgroundStyle.Class = "ListBoxAdv";
            this.ListBoxAdv_LM_Areas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListBoxAdv_LM_Areas.ContainerControlProcessDialogKey = true;
            this.ListBoxAdv_LM_Areas.DragDropSupport = true;
            this.ListBoxAdv_LM_Areas.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ListBoxAdv_LM_Areas.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ListBoxAdv_LM_Areas.Name = "ListBoxAdv_LM_Areas";
            this.ListBoxAdv_LM_Areas.ReserveLeftSpace = false;
            this.ListBoxAdv_LM_Areas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ListBoxAdv_LM_Areas.SelectedIndexChanged += new System.EventHandler(this.ListBoxAdv_LM_Areas_SelectedIndexChanged);
            this.ListBoxAdv_LM_Areas.ItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxAdv_LM_Levels_ItemDoubleClick);
            // 
            // GroupPanel1
            // 
            this.GroupPanel1.CanvasColor = System.Drawing.Color.Empty;
            this.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupPanel1.Controls.Add(this.ButtonX_LM_LevelsMore);
            this.GroupPanel1.Controls.Add(this.Button_LM_AddNewLevel);
            this.GroupPanel1.Controls.Add(this.ListBoxAdv_LM_Levels);
            this.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.GroupPanel1, "GroupPanel1");
            this.GroupPanel1.Name = "GroupPanel1";
            // 
            // 
            // 
            this.GroupPanel1.Style.BackColorGradientAngle = 90;
            this.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderBottomWidth = 1;
            this.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderLeftWidth = 1;
            this.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderRightWidth = 1;
            this.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderTopWidth = 1;
            this.GroupPanel1.Style.CornerDiameter = 4;
            this.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonX_LM_LevelsMore
            // 
            this.ButtonX_LM_LevelsMore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_LM_LevelsMore.AutoExpandOnClick = true;
            this.ButtonX_LM_LevelsMore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ButtonX_LM_LevelsMore, "ButtonX_LM_LevelsMore");
            this.ButtonX_LM_LevelsMore.FocusCuesEnabled = false;
            this.ButtonX_LM_LevelsMore.Name = "ButtonX_LM_LevelsMore";
            this.ButtonX_LM_LevelsMore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_LM_LevelsMore.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem20,
            this.ButtonItem1,
            this.ButtonItem24,
            this.ButtonItem19,
            this.ButtonItem21,
            this.ButtonItem15});
            this.ButtonX_LM_LevelsMore.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonX_LM_LevelsMore.SymbolSize = 12F;
            this.ButtonX_LM_LevelsMore.PopupOpen += new System.EventHandler(this.ButtonX_LM_LevelsMore_PopupOpen);
            // 
            // ButtonItem20
            // 
            this.ButtonItem20.GlobalItem = false;
            this.ButtonItem20.Name = "ButtonItem20";
            this.ButtonItem20.SymbolColor = System.Drawing.Color.Goldenrod;
            this.ButtonItem20.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem20.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem20, "ButtonItem20");
            this.ButtonItem20.Click += new System.EventHandler(this.ButtonItem20_Click);
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.GlobalItem = false;
            this.ButtonItem1.Name = "ButtonItem1";
            resources.ApplyResources(this.ButtonItem1, "ButtonItem1");
            this.ButtonItem1.Click += new System.EventHandler(this.ButtonItem1_Click);
            // 
            // ButtonItem24
            // 
            this.ButtonItem24.GlobalItem = false;
            this.ButtonItem24.Name = "ButtonItem24";
            resources.ApplyResources(this.ButtonItem24, "ButtonItem24");
            this.ButtonItem24.Click += new System.EventHandler(this.ButtonItem24_Click);
            // 
            // ButtonItem19
            // 
            this.ButtonItem19.GlobalItem = false;
            this.ButtonItem19.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem19.Name = "ButtonItem19";
            this.ButtonItem19.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonItem19.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem19.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem19, "ButtonItem19");
            this.ButtonItem19.Click += new System.EventHandler(this.ButtonItem19_Click);
            // 
            // ButtonItem21
            // 
            this.ButtonItem21.BeginGroup = true;
            this.ButtonItem21.GlobalItem = false;
            this.ButtonItem21.Name = "ButtonItem21";
            resources.ApplyResources(this.ButtonItem21, "ButtonItem21");
            this.ButtonItem21.Click += new System.EventHandler(this.ButtonItem21_Click);
            // 
            // ButtonItem15
            // 
            this.ButtonItem15.BeginGroup = true;
            this.ButtonItem15.GlobalItem = false;
            this.ButtonItem15.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem15.Name = "ButtonItem15";
            this.ButtonItem15.SymbolColor = System.Drawing.Color.Goldenrod;
            this.ButtonItem15.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem15.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem15, "ButtonItem15");
            this.ButtonItem15.Click += new System.EventHandler(this.ButtonItem15_Click);
            // 
            // Button_LM_AddNewLevel
            // 
            this.Button_LM_AddNewLevel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_LM_AddNewLevel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_LM_AddNewLevel.FocusCuesEnabled = false;
            this.Button_LM_AddNewLevel.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(this.Button_LM_AddNewLevel, "Button_LM_AddNewLevel");
            this.Button_LM_AddNewLevel.Name = "Button_LM_AddNewLevel";
            this.Button_LM_AddNewLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_LM_AddNewLevel.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem26});
            this.Button_LM_AddNewLevel.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.Button_LM_AddNewLevel.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.Button_LM_AddNewLevel.SymbolSize = 12F;
            this.Button_LM_AddNewLevel.Click += new System.EventHandler(this.Button_LM_AddNewLevel_Click);
            // 
            // ButtonItem26
            // 
            this.ButtonItem26.GlobalItem = false;
            this.ButtonItem26.Name = "ButtonItem26";
            resources.ApplyResources(this.ButtonItem26, "ButtonItem26");
            this.ButtonItem26.Click += new System.EventHandler(this.ButtonItem26_Click);
            // 
            // ListBoxAdv_LM_Levels
            // 
            resources.ApplyResources(this.ListBoxAdv_LM_Levels, "ListBoxAdv_LM_Levels");
            this.ListBoxAdv_LM_Levels.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ListBoxAdv_LM_Levels.BackgroundStyle.Class = "ListBoxAdv";
            this.ListBoxAdv_LM_Levels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListBoxAdv_LM_Levels.ContainerControlProcessDialogKey = true;
            this.ListBoxAdv_LM_Levels.DragDropSupport = true;
            this.ListBoxAdv_LM_Levels.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ListBoxAdv_LM_Levels.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ListBoxAdv_LM_Levels.Name = "ListBoxAdv_LM_Levels";
            this.ListBoxAdv_LM_Levels.ReserveLeftSpace = false;
            this.ListBoxAdv_LM_Levels.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ListBoxAdv_LM_Levels.SelectedItemChanged += new SM64_ROM_Manager.Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(this.ListBoxAdv_LM_Levels_SelectedIndexChanged);
            this.ListBoxAdv_LM_Levels.ItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxAdv_LM_Levels_ItemDoubleClick);
            this.ListBoxAdv_LM_Levels.ItemRemoved += new DevComponents.DotNetBar.ItemControl.ItemRemovedEventHandler(this.ListBoxAdv_LM_Levels_SelectedIndexChanged);
            // 
            // TabControl_LM_Area
            // 
            resources.ApplyResources(this.TabControl_LM_Area, "TabControl_LM_Area");
            this.TabControl_LM_Area.BackColor = System.Drawing.Color.Transparent;
            this.TabControl_LM_Area.CanReorderTabs = false;
            this.TabControl_LM_Area.Controls.Add(this.TabControlPanel4);
            this.TabControl_LM_Area.Controls.Add(this.TabControlPanel5);
            this.TabControl_LM_Area.Controls.Add(this.TabControlPanel6);
            this.TabControl_LM_Area.ForeColor = System.Drawing.Color.Black;
            this.TabControl_LM_Area.Name = "TabControl_LM_Area";
            this.TabControl_LM_Area.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabControl_LM_Area.SelectedTabIndex = 0;
            this.TabControl_LM_Area.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.TabControl_LM_Area.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.TabControl_LM_Area.Tabs.Add(this.TabItem4);
            this.TabControl_LM_Area.Tabs.Add(this.TabItem5);
            this.TabControl_LM_Area.Tabs.Add(this.TabItem6);
            // 
            // TabControlPanel4
            // 
            this.TabControlPanel4.Controls.Add(this.Slider_AreaReverbLevel);
            this.TabControlPanel4.Controls.Add(this.labelX14);
            this.TabControlPanel4.Controls.Add(this.LabelX9);
            this.TabControlPanel4.Controls.Add(this.ComboBoxEx_LM_AreaBG);
            this.TabControlPanel4.Controls.Add(this.TextBoxX_LM_ShowMsgID);
            this.TabControlPanel4.Controls.Add(this.LabelX1);
            this.TabControlPanel4.Controls.Add(this.SwitchButton_LM_ShowMsgEnabled);
            this.TabControlPanel4.Controls.Add(this.LabelX2);
            this.TabControlPanel4.Controls.Add(this.CheckBoxX_LM_Enable2DCamera);
            this.TabControlPanel4.Controls.Add(this.LabelX6);
            this.TabControlPanel4.Controls.Add(this.ComboBox_LM_Music);
            this.TabControlPanel4.Controls.Add(this.LabelX7);
            this.TabControlPanel4.Controls.Add(this.ComboBox_LM_TerrainTyp);
            this.TabControlPanel4.Controls.Add(this.LabelX8);
            this.TabControlPanel4.Controls.Add(this.ComboBox_LM_EnvironmentEffects);
            this.TabControlPanel4.Controls.Add(this.LabelX11);
            this.TabControlPanel4.Controls.Add(this.ComboBox_LM_CameraPreset);
            this.TabControlPanel4.Controls.Add(this.ColorPickerButton_LM_BackgroundColor);
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
            this.TabControlPanel4.TabItem = this.TabItem4;
            // 
            // Slider_AreaReverbLevel
            // 
            this.Slider_AreaReverbLevel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.Slider_AreaReverbLevel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Slider_AreaReverbLevel.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Right;
            resources.ApplyResources(this.Slider_AreaReverbLevel, "Slider_AreaReverbLevel");
            this.Slider_AreaReverbLevel.Maximum = 9;
            this.Slider_AreaReverbLevel.Name = "Slider_AreaReverbLevel";
            this.Slider_AreaReverbLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Slider_AreaReverbLevel.Value = 0;
            this.Slider_AreaReverbLevel.ValueChanged += new System.EventHandler(this.Slider_AreaReverbLevel_ValueChanged);
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX14, "labelX14");
            this.labelX14.Name = "labelX14";
            this.labelX14.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX9
            // 
            this.LabelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX9, "LabelX9");
            this.LabelX9.Name = "LabelX9";
            this.LabelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBoxEx_LM_AreaBG
            // 
            this.ComboBoxEx_LM_AreaBG.DisplayMember = "Text";
            this.ComboBoxEx_LM_AreaBG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_LM_AreaBG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx_LM_AreaBG.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_LM_AreaBG.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBoxEx_LM_AreaBG, "ComboBoxEx_LM_AreaBG");
            this.ComboBoxEx_LM_AreaBG.Items.AddRange(new object[] {
            this.ComboItem12,
            this.ComboItem13});
            this.ComboBoxEx_LM_AreaBG.Name = "ComboBoxEx_LM_AreaBG";
            this.ComboBoxEx_LM_AreaBG.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_LM_AreaBG.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx_LM_AreaBG_SelectedIndexChanged);
            // 
            // ComboItem12
            // 
            resources.ApplyResources(this.ComboItem12, "ComboItem12");
            // 
            // ComboItem13
            // 
            resources.ApplyResources(this.ComboItem13, "ComboItem13");
            // 
            // TextBoxX_LM_ShowMsgID
            // 
            this.TextBoxX_LM_ShowMsgID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_LM_ShowMsgID.Border.Class = "TextBoxBorder";
            this.TextBoxX_LM_ShowMsgID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_LM_ShowMsgID.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_LM_ShowMsgID.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.TextBoxX_LM_ShowMsgID, "TextBoxX_LM_ShowMsgID");
            this.TextBoxX_LM_ShowMsgID.Name = "TextBoxX_LM_ShowMsgID";
            this.TextBoxX_LM_ShowMsgID.PreventEnterBeep = true;
            this.TextBoxX_LM_ShowMsgID.TextChanged += new System.EventHandler(this.TextBoxX_LM_ShowMsgID_TextChanged);
            // 
            // LabelX1
            // 
            this.LabelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX1, "LabelX1");
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_LM_ShowMsgEnabled
            // 
            // 
            // 
            // 
            this.SwitchButton_LM_ShowMsgEnabled.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_LM_ShowMsgEnabled.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_LM_ShowMsgEnabled, "SwitchButton_LM_ShowMsgEnabled");
            this.SwitchButton_LM_ShowMsgEnabled.Name = "SwitchButton_LM_ShowMsgEnabled";
            this.SwitchButton_LM_ShowMsgEnabled.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchButton_LM_ShowMsgEnabled.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_LM_ShowMsgEnabled.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_LM_ShowMsgEnabled.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_LM_ShowMsgEnabled.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_LM_ShowMsgEnabled.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_LM_ShowMsgEnabled.SwitchWidth = 15;
            this.SwitchButton_LM_ShowMsgEnabled.ValueChanged += new System.EventHandler(this.SwitchButton_LM_ShowMsgEnabled_ValueChanged);
            // 
            // LabelX2
            // 
            this.LabelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX2, "LabelX2");
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX_LM_Enable2DCamera
            // 
            // 
            // 
            // 
            this.CheckBoxX_LM_Enable2DCamera.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_LM_Enable2DCamera.FocusCuesEnabled = false;
            resources.ApplyResources(this.CheckBoxX_LM_Enable2DCamera, "CheckBoxX_LM_Enable2DCamera");
            this.CheckBoxX_LM_Enable2DCamera.Name = "CheckBoxX_LM_Enable2DCamera";
            this.CheckBoxX_LM_Enable2DCamera.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckBoxX_LM_Enable2DCamera.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.CheckBoxX_LM_Enable2DCamera.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.CheckBoxX_LM_Enable2DCamera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_LM_Enable2DCamera.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.CheckBoxX_LM_Enable2DCamera.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.CheckBoxX_LM_Enable2DCamera.SwitchWidth = 15;
            this.CheckBoxX_LM_Enable2DCamera.ValueChanged += new System.EventHandler(this.Controls_HandleToSaveAreaSettings);
            // 
            // LabelX6
            // 
            this.LabelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX6, "LabelX6");
            this.LabelX6.Name = "LabelX6";
            this.LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_Music
            // 
            this.ComboBox_LM_Music.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_LM_Music.DropDownHeight = 150;
            this.ComboBox_LM_Music.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_LM_Music.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_LM_Music.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBox_LM_Music, "ComboBox_LM_Music");
            this.ComboBox_LM_Music.Items.AddRange(new object[] {
            resources.GetString("ComboBox_LM_Music.Items"),
            resources.GetString("ComboBox_LM_Music.Items1")});
            this.ComboBox_LM_Music.Name = "ComboBox_LM_Music";
            this.ComboBox_LM_Music.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBox_LM_Music.SelectedIndexChanged += new System.EventHandler(this.Controls_HandleToSaveAreaSettings);
            // 
            // LabelX7
            // 
            this.LabelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX7, "LabelX7");
            this.LabelX7.Name = "LabelX7";
            this.LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_TerrainTyp
            // 
            this.ComboBox_LM_TerrainTyp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_LM_TerrainTyp.DropDownHeight = 150;
            this.ComboBox_LM_TerrainTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_LM_TerrainTyp.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_LM_TerrainTyp.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBox_LM_TerrainTyp, "ComboBox_LM_TerrainTyp");
            this.ComboBox_LM_TerrainTyp.Items.AddRange(new object[] {
            resources.GetString("ComboBox_LM_TerrainTyp.Items"),
            resources.GetString("ComboBox_LM_TerrainTyp.Items1"),
            resources.GetString("ComboBox_LM_TerrainTyp.Items2"),
            resources.GetString("ComboBox_LM_TerrainTyp.Items3"),
            resources.GetString("ComboBox_LM_TerrainTyp.Items4"),
            resources.GetString("ComboBox_LM_TerrainTyp.Items5"),
            resources.GetString("ComboBox_LM_TerrainTyp.Items6")});
            this.ComboBox_LM_TerrainTyp.Name = "ComboBox_LM_TerrainTyp";
            this.ComboBox_LM_TerrainTyp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBox_LM_TerrainTyp.SelectedIndexChanged += new System.EventHandler(this.Controls_HandleToSaveAreaSettings);
            // 
            // LabelX8
            // 
            this.LabelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX8, "LabelX8");
            this.LabelX8.Name = "LabelX8";
            this.LabelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_EnvironmentEffects
            // 
            this.ComboBox_LM_EnvironmentEffects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_LM_EnvironmentEffects.DropDownHeight = 150;
            this.ComboBox_LM_EnvironmentEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_LM_EnvironmentEffects.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_LM_EnvironmentEffects.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBox_LM_EnvironmentEffects, "ComboBox_LM_EnvironmentEffects");
            this.ComboBox_LM_EnvironmentEffects.Items.AddRange(new object[] {
            resources.GetString("ComboBox_LM_EnvironmentEffects.Items"),
            resources.GetString("ComboBox_LM_EnvironmentEffects.Items1"),
            resources.GetString("ComboBox_LM_EnvironmentEffects.Items2"),
            resources.GetString("ComboBox_LM_EnvironmentEffects.Items3"),
            resources.GetString("ComboBox_LM_EnvironmentEffects.Items4"),
            resources.GetString("ComboBox_LM_EnvironmentEffects.Items5"),
            resources.GetString("ComboBox_LM_EnvironmentEffects.Items6")});
            this.ComboBox_LM_EnvironmentEffects.Name = "ComboBox_LM_EnvironmentEffects";
            this.ComboBox_LM_EnvironmentEffects.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBox_LM_EnvironmentEffects.SelectedIndexChanged += new System.EventHandler(this.Controls_HandleToSaveAreaSettings);
            // 
            // LabelX11
            // 
            this.LabelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX11, "LabelX11");
            this.LabelX11.Name = "LabelX11";
            this.LabelX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_CameraPreset
            // 
            this.ComboBox_LM_CameraPreset.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_LM_CameraPreset.DropDownHeight = 150;
            this.ComboBox_LM_CameraPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_LM_CameraPreset.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_LM_CameraPreset.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBox_LM_CameraPreset, "ComboBox_LM_CameraPreset");
            this.ComboBox_LM_CameraPreset.Items.AddRange(new object[] {
            resources.GetString("ComboBox_LM_CameraPreset.Items"),
            resources.GetString("ComboBox_LM_CameraPreset.Items1"),
            resources.GetString("ComboBox_LM_CameraPreset.Items2"),
            resources.GetString("ComboBox_LM_CameraPreset.Items3"),
            resources.GetString("ComboBox_LM_CameraPreset.Items4"),
            resources.GetString("ComboBox_LM_CameraPreset.Items5"),
            resources.GetString("ComboBox_LM_CameraPreset.Items6"),
            resources.GetString("ComboBox_LM_CameraPreset.Items7"),
            resources.GetString("ComboBox_LM_CameraPreset.Items8"),
            resources.GetString("ComboBox_LM_CameraPreset.Items9"),
            resources.GetString("ComboBox_LM_CameraPreset.Items10"),
            resources.GetString("ComboBox_LM_CameraPreset.Items11"),
            resources.GetString("ComboBox_LM_CameraPreset.Items12"),
            resources.GetString("ComboBox_LM_CameraPreset.Items13"),
            resources.GetString("ComboBox_LM_CameraPreset.Items14"),
            resources.GetString("ComboBox_LM_CameraPreset.Items15")});
            this.ComboBox_LM_CameraPreset.Name = "ComboBox_LM_CameraPreset";
            this.ComboBox_LM_CameraPreset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBox_LM_CameraPreset.SelectedIndexChanged += new System.EventHandler(this.ComboBox_LM_CameraPreset_SelectedIndexChanged);
            // 
            // ColorPickerButton_LM_BackgroundColor
            // 
            this.ColorPickerButton_LM_BackgroundColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ColorPickerButton_LM_BackgroundColor.AutoExpandOnClick = true;
            this.ColorPickerButton_LM_BackgroundColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ColorPickerButton_LM_BackgroundColor.FocusCuesEnabled = false;
            this.ColorPickerButton_LM_BackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("ColorPickerButton_LM_BackgroundColor.Image")));
            resources.ApplyResources(this.ColorPickerButton_LM_BackgroundColor, "ColorPickerButton_LM_BackgroundColor");
            this.ColorPickerButton_LM_BackgroundColor.Name = "ColorPickerButton_LM_BackgroundColor";
            this.ColorPickerButton_LM_BackgroundColor.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.ColorPickerButton_LM_BackgroundColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ColorPickerButton_LM_BackgroundColor.SelectedColorChanged += new System.EventHandler(this.LM_SaveAreaBackgorund);
            // 
            // TabItem4
            // 
            this.TabItem4.AttachedControl = this.TabControlPanel4;
            this.TabItem4.Name = "TabItem4";
            resources.ApplyResources(this.TabItem4, "TabItem4");
            // 
            // TabControlPanel5
            // 
            this.TabControlPanel5.Controls.Add(this.Line2);
            this.TabControlPanel5.Controls.Add(this.line4);
            this.TabControlPanel5.Controls.Add(this.line1);
            this.TabControlPanel5.Controls.Add(this.LabelX_Area_CountOfTexAnimations);
            this.TabControlPanel5.Controls.Add(this.LabelX10);
            this.TabControlPanel5.Controls.Add(this.ButtonX_EditCollision);
            this.TabControlPanel5.Controls.Add(this.ButtonX_EditFast3D);
            this.TabControlPanel5.Controls.Add(this.buttonX2);
            this.TabControlPanel5.Controls.Add(this.ButtonX_ImportCollision);
            this.TabControlPanel5.Controls.Add(this.buttonX1);
            this.TabControlPanel5.Controls.Add(this.ButtonX_ImportVisualMap);
            this.TabControlPanel5.Controls.Add(this.ButtonX_LM_ScrollTexEditor);
            this.TabControlPanel5.Controls.Add(this.Button_ImportModel);
            this.TabControlPanel5.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.TabControlPanel5, "TabControlPanel5");
            this.TabControlPanel5.Name = "TabControlPanel5";
            this.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.TabControlPanel5.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.TabControlPanel5.Style.GradientAngle = 90;
            this.TabControlPanel5.TabItem = this.TabItem5;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Line2, "Line2");
            this.Line2.Name = "Line2";
            this.Line2.VerticalLine = true;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.line4, "line4");
            this.line4.Name = "line4";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.line1, "line1");
            this.line1.Name = "line1";
            // 
            // LabelX_Area_CountOfTexAnimations
            // 
            this.LabelX_Area_CountOfTexAnimations.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX_Area_CountOfTexAnimations.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_Area_CountOfTexAnimations, "LabelX_Area_CountOfTexAnimations");
            this.LabelX_Area_CountOfTexAnimations.Name = "LabelX_Area_CountOfTexAnimations";
            this.LabelX_Area_CountOfTexAnimations.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // LabelX10
            // 
            this.LabelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX10, "LabelX10");
            this.LabelX10.Name = "LabelX10";
            // 
            // ButtonX_EditCollision
            // 
            this.ButtonX_EditCollision.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_EditCollision.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ButtonX_EditCollision, "ButtonX_EditCollision");
            this.ButtonX_EditCollision.FocusCuesEnabled = false;
            this.ButtonX_EditCollision.Name = "ButtonX_EditCollision";
            this.ButtonX_EditCollision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_EditFast3D
            // 
            this.ButtonX_EditFast3D.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_EditFast3D.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_EditFast3D.FocusCuesEnabled = false;
            resources.ApplyResources(this.ButtonX_EditFast3D, "ButtonX_EditFast3D");
            this.ButtonX_EditFast3D.Name = "ButtonX_EditFast3D";
            this.ButtonX_EditFast3D.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_EditFast3D.Click += new System.EventHandler(this.ButtonX_EditFast3D_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.FocusCuesEnabled = false;
            resources.ApplyResources(this.buttonX2, "buttonX2");
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Click += new System.EventHandler(this.ButtonItem_ExportCollisionMap_Click);
            // 
            // ButtonX_ImportCollision
            // 
            this.ButtonX_ImportCollision.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_ImportCollision.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_ImportCollision.FocusCuesEnabled = false;
            resources.ApplyResources(this.ButtonX_ImportCollision, "ButtonX_ImportCollision");
            this.ButtonX_ImportCollision.Name = "ButtonX_ImportCollision";
            this.ButtonX_ImportCollision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_ImportCollision.Click += new System.EventHandler(this.LM_ImportModel);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.FocusCuesEnabled = false;
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Click += new System.EventHandler(this.ButtonItem_ExportVisualMap_Click);
            // 
            // ButtonX_ImportVisualMap
            // 
            this.ButtonX_ImportVisualMap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_ImportVisualMap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_ImportVisualMap.FocusCuesEnabled = false;
            resources.ApplyResources(this.ButtonX_ImportVisualMap, "ButtonX_ImportVisualMap");
            this.ButtonX_ImportVisualMap.Name = "ButtonX_ImportVisualMap";
            this.ButtonX_ImportVisualMap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_ImportVisualMap.Click += new System.EventHandler(this.LM_ImportModel);
            // 
            // ButtonX_LM_ScrollTexEditor
            // 
            this.ButtonX_LM_ScrollTexEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_LM_ScrollTexEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_LM_ScrollTexEditor.FocusCuesEnabled = false;
            resources.ApplyResources(this.ButtonX_LM_ScrollTexEditor, "ButtonX_LM_ScrollTexEditor");
            this.ButtonX_LM_ScrollTexEditor.Name = "ButtonX_LM_ScrollTexEditor";
            this.ButtonX_LM_ScrollTexEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_LM_ScrollTexEditor.Click += new System.EventHandler(this.ButtonX_LM_ScrollTexEditor_Click);
            // 
            // Button_ImportModel
            // 
            this.Button_ImportModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_ImportModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_ImportModel.FocusCuesEnabled = false;
            resources.ApplyResources(this.Button_ImportModel, "Button_ImportModel");
            this.Button_ImportModel.Name = "Button_ImportModel";
            this.Button_ImportModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_ImportModel.Click += new System.EventHandler(this.LM_ImportModel);
            // 
            // TabItem5
            // 
            this.TabItem5.AttachedControl = this.TabControlPanel5;
            this.TabItem5.Name = "TabItem5";
            resources.ApplyResources(this.TabItem5, "TabItem5");
            // 
            // TabControlPanel6
            // 
            this.TabControlPanel6.Controls.Add(this.Button_LM_RemoveSpecial);
            this.TabControlPanel6.Controls.Add(this.Button_LM_AddSpecial);
            this.TabControlPanel6.Controls.Add(this.Button_LM_EditSpecial);
            this.TabControlPanel6.Controls.Add(this.ListViewEx_LM_Specials);
            this.TabControlPanel6.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.TabControlPanel6, "TabControlPanel6");
            this.TabControlPanel6.Name = "TabControlPanel6";
            this.TabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.TabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.TabControlPanel6.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.TabControlPanel6.Style.GradientAngle = 90;
            this.TabControlPanel6.TabItem = this.TabItem6;
            // 
            // Button_LM_RemoveSpecial
            // 
            this.Button_LM_RemoveSpecial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.Button_LM_RemoveSpecial, "Button_LM_RemoveSpecial");
            this.Button_LM_RemoveSpecial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_LM_RemoveSpecial.FocusCuesEnabled = false;
            this.Button_LM_RemoveSpecial.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.Button_LM_RemoveSpecial.Name = "Button_LM_RemoveSpecial";
            this.Button_LM_RemoveSpecial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_LM_RemoveSpecial.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_LM_RemoveSpecial.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.Button_LM_RemoveSpecial.SymbolSize = 12F;
            this.Button_LM_RemoveSpecial.Click += new System.EventHandler(this.Button_LM_RemoveSpecial_Click);
            // 
            // Button_LM_AddSpecial
            // 
            this.Button_LM_AddSpecial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_LM_AddSpecial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_LM_AddSpecial.FocusCuesEnabled = false;
            this.Button_LM_AddSpecial.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(this.Button_LM_AddSpecial, "Button_LM_AddSpecial");
            this.Button_LM_AddSpecial.Name = "Button_LM_AddSpecial";
            this.Button_LM_AddSpecial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_LM_AddSpecial.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.Button_LM_AddSpecial.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.Button_LM_AddSpecial.SymbolSize = 12F;
            this.Button_LM_AddSpecial.Click += new System.EventHandler(this.Button_LM_AddEditSpecial_Click);
            // 
            // Button_LM_EditSpecial
            // 
            this.Button_LM_EditSpecial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_LM_EditSpecial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.Button_LM_EditSpecial, "Button_LM_EditSpecial");
            this.Button_LM_EditSpecial.FocusCuesEnabled = false;
            this.Button_LM_EditSpecial.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.Button_LM_EditSpecial.Name = "Button_LM_EditSpecial";
            this.Button_LM_EditSpecial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_LM_EditSpecial.SymbolColor = System.Drawing.Color.Goldenrod;
            this.Button_LM_EditSpecial.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.Button_LM_EditSpecial.SymbolSize = 12F;
            this.Button_LM_EditSpecial.Click += new System.EventHandler(this.Button_LM_AddEditSpecial_Click);
            // 
            // ListViewEx_LM_Specials
            // 
            resources.ApplyResources(this.ListViewEx_LM_Specials, "ListViewEx_LM_Specials");
            this.ListViewEx_LM_Specials.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ListViewEx_LM_Specials.Border.Class = "ListViewBorder";
            this.ListViewEx_LM_Specials.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListViewEx_LM_Specials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderA1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeaderA});
            this.ListViewEx_LM_Specials.DisabledBackColor = System.Drawing.Color.Empty;
            this.ListViewEx_LM_Specials.FocusCuesEnabled = false;
            this.ListViewEx_LM_Specials.ForeColor = System.Drawing.Color.Black;
            this.ListViewEx_LM_Specials.FullRowSelect = true;
            this.ListViewEx_LM_Specials.GridLines = true;
            this.ListViewEx_LM_Specials.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("ListViewEx_LM_Specials.Groups"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("ListViewEx_LM_Specials.Groups1"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("ListViewEx_LM_Specials.Groups2"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("ListViewEx_LM_Specials.Groups3")))});
            this.ListViewEx_LM_Specials.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewEx_LM_Specials.HideSelection = false;
            this.ListViewEx_LM_Specials.MultiSelect = false;
            this.ListViewEx_LM_Specials.Name = "ListViewEx_LM_Specials";
            this.ListViewEx_LM_Specials.ShowGroups = false;
            this.ListViewEx_LM_Specials.UseCompatibleStateImageBehavior = false;
            this.ListViewEx_LM_Specials.View = System.Windows.Forms.View.Details;
            this.ListViewEx_LM_Specials.SelectedIndexChanged += new System.EventHandler(this.ListViewEx_LM_Specials_SelectedIndexChanged);
            // 
            // ColumnHeaderA1
            // 
            resources.ApplyResources(this.ColumnHeaderA1, "ColumnHeaderA1");
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
            // ColumnHeader6
            // 
            resources.ApplyResources(this.ColumnHeader6, "ColumnHeader6");
            // 
            // ColumnHeader7
            // 
            resources.ApplyResources(this.ColumnHeader7, "ColumnHeader7");
            // 
            // ColumnHeaderA
            // 
            resources.ApplyResources(this.ColumnHeaderA, "ColumnHeaderA");
            // 
            // TabItem6
            // 
            this.TabItem6.AttachedControl = this.TabControlPanel6;
            this.TabItem6.Name = "TabItem6";
            resources.ApplyResources(this.TabItem6, "TabItem6");
            // 
            // TabControl_LM_Level
            // 
            resources.ApplyResources(this.TabControl_LM_Level, "TabControl_LM_Level");
            this.TabControl_LM_Level.BackColor = System.Drawing.Color.Transparent;
            this.TabControl_LM_Level.CanReorderTabs = false;
            this.TabControl_LM_Level.Controls.Add(this.TabControlPanel1);
            this.TabControl_LM_Level.Controls.Add(this.TabControlPanel2);
            this.TabControl_LM_Level.ForeColor = System.Drawing.Color.Black;
            this.TabControl_LM_Level.Name = "TabControl_LM_Level";
            this.TabControl_LM_Level.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabControl_LM_Level.SelectedTabIndex = 0;
            this.TabControl_LM_Level.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.TabControl_LM_Level.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.TabControl_LM_Level.Tabs.Add(this.TabItem1);
            this.TabControl_LM_Level.Tabs.Add(this.TabItem2);
            // 
            // TabControlPanel1
            // 
            this.TabControlPanel1.Controls.Add(this.LabelX_TargetLevel);
            this.TabControlPanel1.Controls.Add(this.LabelX12);
            this.TabControlPanel1.Controls.Add(this.PictureBox_BGImage);
            this.TabControlPanel1.Controls.Add(this.ComboBoxEx_LM_BGMode);
            this.TabControlPanel1.Controls.Add(this.LabelX15);
            this.TabControlPanel1.Controls.Add(this.LabelX3);
            this.TabControlPanel1.Controls.Add(this.SwitchButton_LM_ActSelector);
            this.TabControlPanel1.Controls.Add(this.LabelX57);
            this.TabControlPanel1.Controls.Add(this.SwitchButton_LM_HardcodedCameraSettings);
            this.TabControlPanel1.Controls.Add(this.LabelX4);
            this.TabControlPanel1.Controls.Add(this.ComboBox_LM_LevelBG);
            this.TabControlPanel1.Controls.Add(this.LabelX24);
            this.TabControlPanel1.Controls.Add(this.NUD_LM_DefaultPositionYRotation);
            this.TabControlPanel1.Controls.Add(this.LabelX25);
            this.TabControlPanel1.Controls.Add(this.NUD_LM_DefaultPositionAreaID);
            this.TabControlPanel1.Controls.Add(this.Button_LM_LoadLevelBG);
            this.TabControlPanel1.Controls.Add(this.Button_LM_SetUpStartPosition);
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
            this.TabControlPanel1.TabItem = this.TabItem1;
            // 
            // LabelX_TargetLevel
            // 
            this.LabelX_TargetLevel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX_TargetLevel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_TargetLevel, "LabelX_TargetLevel");
            this.LabelX_TargetLevel.Name = "LabelX_TargetLevel";
            this.LabelX_TargetLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX12
            // 
            this.LabelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX12, "LabelX12");
            this.LabelX12.Name = "LabelX12";
            this.LabelX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // PictureBox_BGImage
            // 
            this.PictureBox_BGImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PictureBox_BGImage, "PictureBox_BGImage");
            this.PictureBox_BGImage.Name = "PictureBox_BGImage";
            this.PictureBox_BGImage.TabStop = false;
            // 
            // ComboBoxEx_LM_BGMode
            // 
            this.ComboBoxEx_LM_BGMode.DisplayMember = "Text";
            this.ComboBoxEx_LM_BGMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_LM_BGMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx_LM_BGMode.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_LM_BGMode.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBoxEx_LM_BGMode, "ComboBoxEx_LM_BGMode");
            this.ComboBoxEx_LM_BGMode.Items.AddRange(new object[] {
            this.ComboItem1,
            this.ComboItem2,
            this.ComboItem3});
            this.ComboBoxEx_LM_BGMode.Name = "ComboBoxEx_LM_BGMode";
            this.ComboBoxEx_LM_BGMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_LM_BGMode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx_LM_BGMode_SelectedIndexChanged);
            // 
            // ComboItem1
            // 
            resources.ApplyResources(this.ComboItem1, "ComboItem1");
            // 
            // ComboItem2
            // 
            resources.ApplyResources(this.ComboItem2, "ComboItem2");
            // 
            // ComboItem3
            // 
            resources.ApplyResources(this.ComboItem3, "ComboItem3");
            // 
            // LabelX15
            // 
            this.LabelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX15, "LabelX15");
            this.LabelX15.Name = "LabelX15";
            this.LabelX15.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX3
            // 
            this.LabelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX3, "LabelX3");
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_LM_ActSelector
            // 
            // 
            // 
            // 
            this.SwitchButton_LM_ActSelector.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_LM_ActSelector.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_LM_ActSelector, "SwitchButton_LM_ActSelector");
            this.SwitchButton_LM_ActSelector.Name = "SwitchButton_LM_ActSelector";
            this.SwitchButton_LM_ActSelector.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchButton_LM_ActSelector.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_LM_ActSelector.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_LM_ActSelector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_LM_ActSelector.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_LM_ActSelector.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_LM_ActSelector.SwitchWidth = 15;
            this.SwitchButton_LM_ActSelector.Value = true;
            this.SwitchButton_LM_ActSelector.ValueObject = "Y";
            this.SwitchButton_LM_ActSelector.ValueChanged += new System.EventHandler(this.Controls_HandleToSaveLevelSettings);
            // 
            // LabelX57
            // 
            this.LabelX57.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX57.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX57, "LabelX57");
            this.LabelX57.Name = "LabelX57";
            this.LabelX57.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_LM_HardcodedCameraSettings
            // 
            // 
            // 
            // 
            this.SwitchButton_LM_HardcodedCameraSettings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_LM_HardcodedCameraSettings.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_LM_HardcodedCameraSettings, "SwitchButton_LM_HardcodedCameraSettings");
            this.SwitchButton_LM_HardcodedCameraSettings.Name = "SwitchButton_LM_HardcodedCameraSettings";
            this.SwitchButton_LM_HardcodedCameraSettings.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchButton_LM_HardcodedCameraSettings.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_LM_HardcodedCameraSettings.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_LM_HardcodedCameraSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_LM_HardcodedCameraSettings.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_LM_HardcodedCameraSettings.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_LM_HardcodedCameraSettings.SwitchWidth = 15;
            this.SwitchButton_LM_HardcodedCameraSettings.ValueChanged += new System.EventHandler(this.Controls_HandleToSaveLevelSettings);
            // 
            // LabelX4
            // 
            this.LabelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX4, "LabelX4");
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_LevelBG
            // 
            this.ComboBox_LM_LevelBG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_LM_LevelBG.DropDownHeight = 200;
            this.ComboBox_LM_LevelBG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_LM_LevelBG.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_LM_LevelBG.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBox_LM_LevelBG, "ComboBox_LM_LevelBG");
            this.ComboBox_LM_LevelBG.Items.AddRange(new object[] {
            resources.GetString("ComboBox_LM_LevelBG.Items"),
            resources.GetString("ComboBox_LM_LevelBG.Items1"),
            resources.GetString("ComboBox_LM_LevelBG.Items2"),
            resources.GetString("ComboBox_LM_LevelBG.Items3"),
            resources.GetString("ComboBox_LM_LevelBG.Items4"),
            resources.GetString("ComboBox_LM_LevelBG.Items5"),
            resources.GetString("ComboBox_LM_LevelBG.Items6"),
            resources.GetString("ComboBox_LM_LevelBG.Items7"),
            resources.GetString("ComboBox_LM_LevelBG.Items8"),
            resources.GetString("ComboBox_LM_LevelBG.Items9")});
            this.ComboBox_LM_LevelBG.Name = "ComboBox_LM_LevelBG";
            this.ComboBox_LM_LevelBG.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBox_LM_LevelBG.SelectedIndexChanged += new System.EventHandler(this.LM_SaveGameBackground);
            // 
            // LabelX24
            // 
            this.LabelX24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX24, "LabelX24");
            this.LabelX24.Name = "LabelX24";
            this.LabelX24.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // NUD_LM_DefaultPositionYRotation
            // 
            resources.ApplyResources(this.NUD_LM_DefaultPositionYRotation, "NUD_LM_DefaultPositionYRotation");
            this.NUD_LM_DefaultPositionYRotation.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.NUD_LM_DefaultPositionYRotation.Minimum = new decimal(new int[] {
            359,
            0,
            0,
            -2147483648});
            this.NUD_LM_DefaultPositionYRotation.Name = "NUD_LM_DefaultPositionYRotation";
            this.NUD_LM_DefaultPositionYRotation.ValueChanged += new System.EventHandler(this.Controls_HandleToSaveLevelSettings);
            // 
            // LabelX25
            // 
            this.LabelX25.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX25, "LabelX25");
            this.LabelX25.Name = "LabelX25";
            this.LabelX25.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // NUD_LM_DefaultPositionAreaID
            // 
            resources.ApplyResources(this.NUD_LM_DefaultPositionAreaID, "NUD_LM_DefaultPositionAreaID");
            this.NUD_LM_DefaultPositionAreaID.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_LM_DefaultPositionAreaID.Name = "NUD_LM_DefaultPositionAreaID";
            this.NUD_LM_DefaultPositionAreaID.ValueChanged += new System.EventHandler(this.Controls_HandleToSaveLevelSettings);
            // 
            // Button_LM_LoadLevelBG
            // 
            this.Button_LM_LoadLevelBG.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_LM_LoadLevelBG.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_LM_LoadLevelBG.FocusCuesEnabled = false;
            this.Button_LM_LoadLevelBG.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_open_folder_16px;
            resources.ApplyResources(this.Button_LM_LoadLevelBG, "Button_LM_LoadLevelBG");
            this.Button_LM_LoadLevelBG.Name = "Button_LM_LoadLevelBG";
            this.Button_LM_LoadLevelBG.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_LM_LoadLevelBG.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(172)))), ((int)(((byte)(106)))));
            this.Button_LM_LoadLevelBG.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.Button_LM_LoadLevelBG.SymbolSize = 12F;
            this.Button_LM_LoadLevelBG.Click += new System.EventHandler(this.LM_LoadCustomBackground);
            // 
            // Button_LM_SetUpStartPosition
            // 
            this.Button_LM_SetUpStartPosition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_LM_SetUpStartPosition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_LM_SetUpStartPosition.FocusCuesEnabled = false;
            this.Button_LM_SetUpStartPosition.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_support_16px;
            resources.ApplyResources(this.Button_LM_SetUpStartPosition, "Button_LM_SetUpStartPosition");
            this.Button_LM_SetUpStartPosition.Name = "Button_LM_SetUpStartPosition";
            this.Button_LM_SetUpStartPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_LM_SetUpStartPosition.SymbolColor = System.Drawing.Color.Gray;
            this.Button_LM_SetUpStartPosition.SymbolSize = 12F;
            this.Button_LM_SetUpStartPosition.Click += new System.EventHandler(this.Button_LM_SetUpOffsetModelPosition_Click);
            // 
            // TabItem1
            // 
            this.TabItem1.AttachedControl = this.TabControlPanel1;
            this.TabItem1.Name = "TabItem1";
            resources.ApplyResources(this.TabItem1, "TabItem1");
            // 
            // TabControlPanel2
            // 
            this.TabControlPanel2.Controls.Add(this.ButtonX_ManageLocalObjects);
            this.TabControlPanel2.Controls.Add(this.labelX5);
            this.TabControlPanel2.Controls.Add(this.SwitchButton_UseLocalObjectBank);
            this.TabControlPanel2.Controls.Add(this.LabelX13);
            this.TabControlPanel2.Controls.Add(this.SwitchButton_UseGlobalObjectBank);
            this.TabControlPanel2.Controls.Add(this.TableLayoutPanel_ObjectBankSelectorBoxes);
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
            this.TabControlPanel2.TabItem = this.TabItem2;
            // 
            // ButtonX_ManageLocalObjects
            // 
            this.ButtonX_ManageLocalObjects.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_ManageLocalObjects.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_ManageLocalObjects.FocusCuesEnabled = false;
            resources.ApplyResources(this.ButtonX_ManageLocalObjects, "ButtonX_ManageLocalObjects");
            this.ButtonX_ManageLocalObjects.Name = "ButtonX_ManageLocalObjects";
            this.ButtonX_ManageLocalObjects.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_ManageLocalObjects.Click += new System.EventHandler(this.ButtonX_ManageLocalObjects_Click);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX5, "labelX5");
            this.labelX5.Name = "labelX5";
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_UseLocalObjectBank
            // 
            // 
            // 
            // 
            this.SwitchButton_UseLocalObjectBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_UseLocalObjectBank.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_UseLocalObjectBank, "SwitchButton_UseLocalObjectBank");
            this.SwitchButton_UseLocalObjectBank.Name = "SwitchButton_UseLocalObjectBank";
            this.SwitchButton_UseLocalObjectBank.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchButton_UseLocalObjectBank.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_UseLocalObjectBank.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_UseLocalObjectBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_UseLocalObjectBank.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_UseLocalObjectBank.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_UseLocalObjectBank.SwitchWidth = 15;
            this.SwitchButton_UseLocalObjectBank.ValueChanged += new System.EventHandler(this.SwitchButton_UseCustomObjectBank_ValueChanged);
            // 
            // LabelX13
            // 
            this.LabelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX13, "LabelX13");
            this.LabelX13.Name = "LabelX13";
            this.LabelX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_UseGlobalObjectBank
            // 
            // 
            // 
            // 
            this.SwitchButton_UseGlobalObjectBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.SwitchButton_UseGlobalObjectBank, "SwitchButton_UseGlobalObjectBank");
            this.SwitchButton_UseGlobalObjectBank.FocusCuesEnabled = false;
            this.SwitchButton_UseGlobalObjectBank.Name = "SwitchButton_UseGlobalObjectBank";
            this.SwitchButton_UseGlobalObjectBank.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchButton_UseGlobalObjectBank.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_UseGlobalObjectBank.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_UseGlobalObjectBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_UseGlobalObjectBank.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_UseGlobalObjectBank.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_UseGlobalObjectBank.SwitchWidth = 15;
            this.SwitchButton_UseGlobalObjectBank.ValueChanged += new System.EventHandler(this.SwitchButton_UseCustomObjectBank_ValueChanged);
            // 
            // TableLayoutPanel_ObjectBankSelectorBoxes
            // 
            resources.ApplyResources(this.TableLayoutPanel_ObjectBankSelectorBoxes, "TableLayoutPanel_ObjectBankSelectorBoxes");
            this.TableLayoutPanel_ObjectBankSelectorBoxes.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel_ObjectBankSelectorBoxes.Name = "TableLayoutPanel_ObjectBankSelectorBoxes";
            // 
            // TabItem2
            // 
            this.TabItem2.AttachedControl = this.TabControlPanel2;
            this.TabItem2.Name = "TabItem2";
            resources.ApplyResources(this.TabItem2, "TabItem2");
            // 
            // Tab_LevelManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupBox_LM_Areas);
            this.Controls.Add(this.GroupPanel1);
            this.Controls.Add(this.TabControl_LM_Area);
            this.Controls.Add(this.TabControl_LM_Level);
            this.Name = "Tab_LevelManager";
            this.GroupBox_LM_Areas.ResumeLayout(false);
            this.GroupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_LM_Area)).EndInit();
            this.TabControl_LM_Area.ResumeLayout(false);
            this.TabControlPanel4.ResumeLayout(false);
            this.TabControlPanel5.ResumeLayout(false);
            this.TabControlPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_LM_Level)).EndInit();
            this.TabControl_LM_Level.ResumeLayout(false);
            this.TabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BGImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LM_DefaultPositionYRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LM_DefaultPositionAreaID)).EndInit();
            this.TabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.GroupPanel GroupBox_LM_Areas;


        private DevComponents.DotNetBar.ButtonX Button_LM_AddArea;


        private DevComponents.DotNetBar.ButtonX Button_LM_AreaEditor;


        private DevComponents.DotNetBar.ButtonItem Button_LM_RemoveArea;


        private Publics.Controls.ItemListBox ListBoxAdv_LM_Areas;


        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel1;


        private DevComponents.DotNetBar.ButtonX ButtonX_LM_LevelsMore;


        private DevComponents.DotNetBar.ButtonItem ButtonItem20;


        private DevComponents.DotNetBar.ButtonItem ButtonItem19;


        private DevComponents.DotNetBar.ButtonItem ButtonItem21;


        private DevComponents.DotNetBar.ButtonItem ButtonItem24;


        private DevComponents.DotNetBar.ButtonItem ButtonItem15;


        private DevComponents.DotNetBar.ButtonX Button_LM_AddNewLevel;


        private DevComponents.DotNetBar.ButtonItem ButtonItem26;


        private Publics.Controls.ItemListBox ListBoxAdv_LM_Levels;


        private DevComponents.DotNetBar.TabControl TabControl_LM_Area;


        private DevComponents.DotNetBar.TabControlPanel TabControlPanel4;


        private DevComponents.DotNetBar.LabelX LabelX9;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_LM_AreaBG;


        private DevComponents.Editors.ComboItem ComboItem12;


        private DevComponents.Editors.ComboItem ComboItem13;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_LM_ShowMsgID;


        private DevComponents.DotNetBar.LabelX LabelX1;


        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_LM_ShowMsgEnabled;


        private DevComponents.DotNetBar.ColorPickerButton ColorPickerButton_LM_BackgroundColor;


        private DevComponents.DotNetBar.LabelX LabelX2;


        private DevComponents.DotNetBar.Controls.SwitchButton CheckBoxX_LM_Enable2DCamera;


        private DevComponents.DotNetBar.LabelX LabelX6;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_Music;


        private DevComponents.DotNetBar.LabelX LabelX7;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_TerrainTyp;

                private DevComponents.DotNetBar.LabelX LabelX8;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_EnvironmentEffects;


        private DevComponents.DotNetBar.LabelX LabelX11;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_CameraPreset;


        private DevComponents.DotNetBar.TabItem TabItem4;


        private DevComponents.DotNetBar.TabControlPanel TabControlPanel6;


        private DevComponents.DotNetBar.ButtonX Button_LM_RemoveSpecial;


        private DevComponents.DotNetBar.ButtonX Button_LM_AddSpecial;


        private DevComponents.DotNetBar.ButtonX Button_LM_EditSpecial;

        

        private DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_LM_Specials;


        private ColumnHeader ColumnHeaderA1;


        private ColumnHeader ColumnHeader2;


        private ColumnHeader ColumnHeader3;


        private ColumnHeader ColumnHeader4;


        private ColumnHeader ColumnHeader5;


        private ColumnHeader ColumnHeader6;


        private ColumnHeader ColumnHeader7;


        private ColumnHeader ColumnHeaderA;


        private DevComponents.DotNetBar.TabItem TabItem6;


        private DevComponents.DotNetBar.TabControlPanel TabControlPanel5;


        private DevComponents.DotNetBar.ButtonX ButtonX_LM_ScrollTexEditor;


        private DevComponents.DotNetBar.ButtonX Button_ImportModel;







        private DevComponents.DotNetBar.TabItem TabItem5;


        private DevComponents.DotNetBar.TabControl TabControl_LM_Level;


        private DevComponents.DotNetBar.TabControlPanel TabControlPanel1;


        private PictureBox PictureBox_BGImage;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_LM_BGMode;


        private DevComponents.Editors.ComboItem ComboItem1;


        private DevComponents.Editors.ComboItem ComboItem2;


        private DevComponents.Editors.ComboItem ComboItem3;


        private DevComponents.DotNetBar.LabelX LabelX15;


        private DevComponents.DotNetBar.LabelX LabelX3;


        private DevComponents.DotNetBar.ButtonX Button_LM_LoadLevelBG;


        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_LM_ActSelector;


        private DevComponents.DotNetBar.LabelX LabelX57;


        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_LM_HardcodedCameraSettings;


        private DevComponents.DotNetBar.ButtonX Button_LM_SetUpStartPosition;


        private DevComponents.DotNetBar.LabelX LabelX4;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_LevelBG;


        private DevComponents.DotNetBar.LabelX LabelX24;


        private NumericUpDown NUD_LM_DefaultPositionYRotation;


        private DevComponents.DotNetBar.LabelX LabelX25;


        private NumericUpDown NUD_LM_DefaultPositionAreaID;


        private DevComponents.DotNetBar.TabItem TabItem1;


        private DevComponents.DotNetBar.TabControlPanel TabControlPanel2;


        private DevComponents.DotNetBar.TabItem TabItem2;



        private DevComponents.DotNetBar.ButtonItem ButtonItem_EditAreaLevelScript;


        private DevComponents.DotNetBar.ButtonItem ButtonItem2_EditGeolayoutScript;


        private DevComponents.DotNetBar.LabelX LabelX_Area_CountOfTexAnimations;


        private DevComponents.DotNetBar.LabelX LabelX10;



        private DevComponents.DotNetBar.Controls.Line Line2;



        private TableLayoutPanel TableLayoutPanel_ObjectBankSelectorBoxes;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportArea;

        private DevComponents.DotNetBar.LabelX LabelX_TargetLevel;

        private DevComponents.DotNetBar.LabelX LabelX12;

        private DevComponents.DotNetBar.ButtonItem ButtonItem1;

        private DevComponents.DotNetBar.LabelX LabelX13;

        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_UseGlobalObjectBank;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_UseLocalObjectBank;
        private DevComponents.DotNetBar.ButtonX ButtonX_ManageLocalObjects;
        private DevComponents.DotNetBar.ButtonX ButtonX_EditFast3D;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.ButtonX ButtonX_ImportCollision;
        private DevComponents.DotNetBar.ButtonX ButtonX_ImportVisualMap;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.ButtonX ButtonX_EditCollision;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.Slider Slider_AreaReverbLevel;
    }
}