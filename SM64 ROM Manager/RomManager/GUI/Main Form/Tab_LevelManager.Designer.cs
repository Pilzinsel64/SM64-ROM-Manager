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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_LevelManager));
            _GroupBox_LM_Areas = new DevComponents.DotNetBar.Controls.GroupPanel();
            _GroupBox_LM_Areas.EnabledChanged += new EventHandler(GroupBox_LM_Areas_EnabledChanged);
            _Button_LM_AddArea = new DevComponents.DotNetBar.ButtonX();
            _Button_LM_AddArea.Click += new EventHandler(Button_LM_AddArea_Click);
            _ButtonItem_ImportArea = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ImportArea.Click += new EventHandler(ButtonItem_ImportArea_Click);
            _Button_LM_AreaEditor = new DevComponents.DotNetBar.ButtonX();
            _Button_LM_AreaEditor.Click += new EventHandler(LM_OpenAreaEditor);
            _Button_LM_RemoveArea = new DevComponents.DotNetBar.ButtonItem();
            _Button_LM_RemoveArea.Click += new EventHandler(Button_LM_RemoveArea_Click);
            _ButtonItem_EditAreaLevelScript = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_EditAreaLevelScript.Click += new EventHandler(ButtonItem_EditAreaLevelScript_Click);
            _ButtonItem2_EditGeolayoutScript = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem2_EditGeolayoutScript.Click += new EventHandler(ButtonItem2_EditGeolayoutScript_Click);
            _ListBoxAdv_LM_Areas = new Publics.Controls.ItemListBox();
            _ListBoxAdv_LM_Areas.SelectedIndexChanged += new EventHandler(ListBoxAdv_LM_Areas_SelectedIndexChanged);
            _ListBoxAdv_LM_Areas.ItemDoubleClick += new MouseEventHandler(ListBoxAdv_LM_Levels_ItemDoubleClick);
            _GroupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            _ButtonX_LM_LevelsMore = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_LM_LevelsMore.PopupOpen += new EventHandler(ButtonX_LM_LevelsMore_PopupOpen);
            _ButtonItem20 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem20.Click += new EventHandler(ButtonItem20_Click);
            _ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem1.Click += new EventHandler(ButtonItem1_Click);
            _ButtonItem24 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem24.Click += new EventHandler(ButtonItem24_Click);
            _ButtonItem19 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem19.Click += new EventHandler(ButtonItem19_Click);
            _ButtonItem21 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem21.Click += new EventHandler(ButtonItem21_Click);
            _ButtonItem15 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem15.Click += new EventHandler(ButtonItem15_Click);
            _Button_LM_AddNewLevel = new DevComponents.DotNetBar.ButtonX();
            _Button_LM_AddNewLevel.Click += new EventHandler(Button_LM_AddNewLevel_Click);
            _ButtonItem26 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem26.Click += new EventHandler(ButtonItem26_Click);
            _ListBoxAdv_LM_Levels = new Publics.Controls.ItemListBox();
            _ListBoxAdv_LM_Levels.SelectedItemChanged += new Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(ListBoxAdv_LM_Levels_SelectedIndexChanged);
            _ListBoxAdv_LM_Levels.ItemRemoved += new DevComponents.DotNetBar.ItemControl.ItemRemovedEventHandler(ListBoxAdv_LM_Levels_SelectedIndexChanged);
            _ListBoxAdv_LM_Levels.SelectedItemChanged += new Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(ListBoxAdv_LM_Levels_SelectedIndexChanged);
            _ListBoxAdv_LM_Levels.ItemRemoved += new DevComponents.DotNetBar.ItemControl.ItemRemovedEventHandler(ListBoxAdv_LM_Levels_SelectedIndexChanged);
            _ListBoxAdv_LM_Levels.ItemDoubleClick += new MouseEventHandler(ListBoxAdv_LM_Levels_ItemDoubleClick);
            _TabControl_LM_Area = new DevComponents.DotNetBar.TabControl();
            _TabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            _LabelX9 = new DevComponents.DotNetBar.LabelX();
            _ComboBoxEx_LM_AreaBG = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_LM_AreaBG.SelectedIndexChanged += new EventHandler(ComboBoxEx_LM_AreaBG_SelectedIndexChanged);
            _ComboItem12 = new DevComponents.Editors.ComboItem();
            _ComboItem13 = new DevComponents.Editors.ComboItem();
            _TextBoxX_LM_ShowMsgID = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_LM_ShowMsgID.TextChanged += new EventHandler(TextBoxX_LM_ShowMsgID_TextChanged);
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_LM_ShowMsgEnabled = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_LM_ShowMsgEnabled.ValueChanged += new EventHandler(SwitchButton_LM_ShowMsgEnabled_ValueChanged);
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _CheckBoxX_LM_Enable2DCamera = new DevComponents.DotNetBar.Controls.SwitchButton();
            _CheckBoxX_LM_Enable2DCamera.ValueChanged += new EventHandler(Controls_HandleToSaveAreaSettings);
            _LabelX6 = new DevComponents.DotNetBar.LabelX();
            _ComboBox_LM_Music = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_LM_Music.SelectedIndexChanged += new EventHandler(Controls_HandleToSaveAreaSettings);
            _LabelX7 = new DevComponents.DotNetBar.LabelX();
            _ComboBox_LM_TerrainTyp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_LM_TerrainTyp.SelectedIndexChanged += new EventHandler(Controls_HandleToSaveAreaSettings);
            _LabelX8 = new DevComponents.DotNetBar.LabelX();
            _ComboBox_LM_EnvironmentEffects = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_LM_EnvironmentEffects.SelectedIndexChanged += new EventHandler(Controls_HandleToSaveAreaSettings);
            _LabelX11 = new DevComponents.DotNetBar.LabelX();
            _ComboBox_LM_CameraPreset = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_LM_CameraPreset.SelectedIndexChanged += new EventHandler(Controls_HandleToSaveAreaSettings);
            _ComboBox_LM_CameraPreset.SelectedIndexChanged += new EventHandler(ComboBox_LM_CameraPreset_SelectedIndexChanged);
            _ColorPickerButton_LM_BackgroundColor = new DevComponents.DotNetBar.ColorPickerButton();
            _ColorPickerButton_LM_BackgroundColor.SelectedColorChanged += new EventHandler(LM_SaveAreaBackgorund);
            _TabItem4 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel6 = new DevComponents.DotNetBar.TabControlPanel();
            _Button_LM_RemoveSpecial = new DevComponents.DotNetBar.ButtonX();
            _Button_LM_RemoveSpecial.Click += new EventHandler(Button_LM_RemoveSpecial_Click);
            _Button_LM_AddSpecial = new DevComponents.DotNetBar.ButtonX();
            _Button_LM_AddSpecial.Click += new EventHandler(Button_LM_AddEditSpecial_Click);
            _Button_LM_EditSpecial = new DevComponents.DotNetBar.ButtonX();
            _Button_LM_EditSpecial.Click += new EventHandler(Button_LM_AddEditSpecial_Click);
            _ListViewEx_LM_Specials = new DevComponents.DotNetBar.Controls.ListViewEx();
            _ListViewEx_LM_Specials.SelectedIndexChanged += new EventHandler(ListViewEx_LM_Specials_SelectedIndexChanged);
            _ColumnHeaderA1 = new ColumnHeader();
            _ColumnHeader2 = new ColumnHeader();
            _ColumnHeader3 = new ColumnHeader();
            _ColumnHeader4 = new ColumnHeader();
            _ColumnHeader5 = new ColumnHeader();
            _ColumnHeader6 = new ColumnHeader();
            _ColumnHeader7 = new ColumnHeader();
            _ColumnHeaderA = new ColumnHeader();
            _TabItem6 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel5 = new DevComponents.DotNetBar.TabControlPanel();
            _Line2 = new DevComponents.DotNetBar.Controls.Line();
            _LabelX_Area_CountOfCustomObjects = new DevComponents.DotNetBar.LabelX();
            _LabelX_Area_CountOfTexAnimations = new DevComponents.DotNetBar.LabelX();
            _LabelX10 = new DevComponents.DotNetBar.LabelX();
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _ButtonX_CustomObjects = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_CustomObjects.Click += new EventHandler(ButtonX_CustomObjects_Click);
            _ButtonX_LM_ScrollTexEditor = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_LM_ScrollTexEditor.Click += new EventHandler(ButtonX_LM_ScrollTexEditor_Click);
            _Button_ImportModel = new DevComponents.DotNetBar.ButtonX();
            _Button_ImportModel.Click += new EventHandler(LM_ImportModel);
            _ButtonItem9 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem9.Click += new EventHandler(LM_ImportModel);
            _ButtonItem13 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem13.Click += new EventHandler(LM_ImportModel);
            _ButtonItem_ExportModel = new DevComponents.DotNetBar.ButtonX();
            _ButtonItem_ExportVisualMap = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ExportVisualMap.Click += new EventHandler(ButtonItem_ExportVisualMap_Click);
            _ButtonItem_ExportCollisionMap = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ExportCollisionMap.Click += new EventHandler(ButtonItem_ExportCollisionMap_Click);
            _TabItem5 = new DevComponents.DotNetBar.TabItem(components);
            _TabControl_LM_Level = new DevComponents.DotNetBar.TabControl();
            _TabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            _LabelX_TargetLevel = new DevComponents.DotNetBar.LabelX();
            _LabelX12 = new DevComponents.DotNetBar.LabelX();
            _PictureBox_BGImage = new PictureBox();
            _ComboBoxEx_LM_BGMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_LM_BGMode.SelectedIndexChanged += new EventHandler(ComboBoxEx_LM_BGMode_SelectedIndexChanged);
            _ComboItem1 = new DevComponents.Editors.ComboItem();
            _ComboItem2 = new DevComponents.Editors.ComboItem();
            _ComboItem3 = new DevComponents.Editors.ComboItem();
            _LabelX15 = new DevComponents.DotNetBar.LabelX();
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_LM_ActSelector = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_LM_ActSelector.ValueChanged += new EventHandler(Controls_HandleToSaveLevelSettings);
            _LabelX57 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_LM_HardcodedCameraSettings = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_LM_HardcodedCameraSettings.ValueChanged += new EventHandler(Controls_HandleToSaveLevelSettings);
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _ComboBox_LM_LevelBG = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_LM_LevelBG.SelectedIndexChanged += new EventHandler(LM_SaveGameBackground);
            _LabelX24 = new DevComponents.DotNetBar.LabelX();
            _NUD_LM_DefaultPositionYRotation = new NumericUpDown();
            _NUD_LM_DefaultPositionYRotation.ValueChanged += new EventHandler(Controls_HandleToSaveLevelSettings);
            _LabelX25 = new DevComponents.DotNetBar.LabelX();
            _NUD_LM_DefaultPositionAreaID = new NumericUpDown();
            _NUD_LM_DefaultPositionAreaID.ValueChanged += new EventHandler(Controls_HandleToSaveLevelSettings);
            _Button_LM_LoadLevelBG = new DevComponents.DotNetBar.ButtonX();
            _Button_LM_LoadLevelBG.Click += new EventHandler(LM_LoadCustomBackground);
            _Button_LM_SetUpStartPosition = new DevComponents.DotNetBar.ButtonX();
            _Button_LM_SetUpStartPosition.Click += new EventHandler(Button_LM_SetUpOffsetModelPosition_Click);
            _TabItem1 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            _LabelX13 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_UseGlobalObjectBank = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_UseGlobalObjectBank.ValueChanged += new EventHandler(Controls_HandleToSaveLevelSettings);
            _SwitchButton_UseGlobalObjectBank.ValueChanged += new EventHandler(SwitchButton_UseGlobalObjectBank_ValueChanged);
            _TableLayoutPanel_ObjectBankSelectorBoxes = new TableLayoutPanel();
            _TabItem2 = new DevComponents.DotNetBar.TabItem(components);
            _GroupBox_LM_Areas.SuspendLayout();
            _GroupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TabControl_LM_Area).BeginInit();
            _TabControl_LM_Area.SuspendLayout();
            _TabControlPanel4.SuspendLayout();
            _TabControlPanel6.SuspendLayout();
            _TabControlPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TabControl_LM_Level).BeginInit();
            _TabControl_LM_Level.SuspendLayout();
            _TabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_PictureBox_BGImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_NUD_LM_DefaultPositionYRotation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_NUD_LM_DefaultPositionAreaID).BeginInit();
            _TabControlPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_LM_Areas
            // 
            resources.ApplyResources(_GroupBox_LM_Areas, "GroupBox_LM_Areas");
            _GroupBox_LM_Areas.CanvasColor = Color.Empty;
            _GroupBox_LM_Areas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            _GroupBox_LM_Areas.Controls.Add(_Button_LM_AddArea);
            _GroupBox_LM_Areas.Controls.Add(_Button_LM_AreaEditor);
            _GroupBox_LM_Areas.Controls.Add(_ListBoxAdv_LM_Areas);
            _GroupBox_LM_Areas.DisabledBackColor = Color.Empty;
            _GroupBox_LM_Areas.Name = "GroupBox_LM_Areas";
            // 
            // 
            // 
            _GroupBox_LM_Areas.Style.BackColorGradientAngle = 90;
            _GroupBox_LM_Areas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_LM_Areas.Style.BorderBottomWidth = 1;
            _GroupBox_LM_Areas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupBox_LM_Areas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_LM_Areas.Style.BorderLeftWidth = 1;
            _GroupBox_LM_Areas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_LM_Areas.Style.BorderRightWidth = 1;
            _GroupBox_LM_Areas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_LM_Areas.Style.BorderTopWidth = 1;
            _GroupBox_LM_Areas.Style.CornerDiameter = 4;
            _GroupBox_LM_Areas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupBox_LM_Areas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupBox_LM_Areas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupBox_LM_Areas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupBox_LM_Areas.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupBox_LM_Areas.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Button_LM_AddArea
            // 
            _Button_LM_AddArea.AccessibleRole = AccessibleRole.PushButton;
            _Button_LM_AddArea.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_Button_LM_AddArea, "Button_LM_AddArea");
            _Button_LM_AddArea.FocusCuesEnabled = false;
            _Button_LM_AddArea.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            _Button_LM_AddArea.Name = "Button_LM_AddArea";
            _Button_LM_AddArea.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_LM_AddArea.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_ImportArea });
            _Button_LM_AddArea.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _Button_LM_AddArea.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LM_AddArea.SymbolSize = 12.0F;
            // 
            // ButtonItem_ImportArea
            // 
            _ButtonItem_ImportArea.GlobalItem = false;
            _ButtonItem_ImportArea.Name = "ButtonItem_ImportArea";
            resources.ApplyResources(_ButtonItem_ImportArea, "ButtonItem_ImportArea");
            // 
            // Button_LM_AreaEditor
            // 
            _Button_LM_AreaEditor.AccessibleRole = AccessibleRole.PushButton;
            _Button_LM_AreaEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_Button_LM_AreaEditor, "Button_LM_AreaEditor");
            _Button_LM_AreaEditor.FocusCuesEnabled = false;
            _Button_LM_AreaEditor.Image = My.Resources.MyIcons.icons8_edit_16px;
            _Button_LM_AreaEditor.Name = "Button_LM_AreaEditor";
            _Button_LM_AreaEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_LM_AreaEditor.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _Button_LM_RemoveArea, _ButtonItem_EditAreaLevelScript, _ButtonItem2_EditGeolayoutScript });
            _Button_LM_AreaEditor.SymbolColor = Color.Goldenrod;
            _Button_LM_AreaEditor.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LM_AreaEditor.SymbolSize = 12.0F;
            // 
            // Button_LM_RemoveArea
            // 
            _Button_LM_RemoveArea.GlobalItem = false;
            _Button_LM_RemoveArea.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _Button_LM_RemoveArea.Name = "Button_LM_RemoveArea";
            _Button_LM_RemoveArea.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _Button_LM_RemoveArea.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LM_RemoveArea.SymbolSize = 12.0F;
            resources.ApplyResources(_Button_LM_RemoveArea, "Button_LM_RemoveArea");
            // 
            // ButtonItem_EditAreaLevelScript
            // 
            _ButtonItem_EditAreaLevelScript.BeginGroup = true;
            _ButtonItem_EditAreaLevelScript.GlobalItem = false;
            _ButtonItem_EditAreaLevelScript.Image = My.Resources.MyIcons.icons8_edit_16px;
            _ButtonItem_EditAreaLevelScript.Name = "ButtonItem_EditAreaLevelScript";
            _ButtonItem_EditAreaLevelScript.SymbolColor = Color.Goldenrod;
            _ButtonItem_EditAreaLevelScript.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_EditAreaLevelScript.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_EditAreaLevelScript, "ButtonItem_EditAreaLevelScript");
            // 
            // ButtonItem2_EditGeolayoutScript
            // 
            _ButtonItem2_EditGeolayoutScript.GlobalItem = false;
            _ButtonItem2_EditGeolayoutScript.Image = My.Resources.MyIcons.icons8_edit_16px;
            _ButtonItem2_EditGeolayoutScript.Name = "ButtonItem2_EditGeolayoutScript";
            _ButtonItem2_EditGeolayoutScript.SymbolColor = Color.Goldenrod;
            _ButtonItem2_EditGeolayoutScript.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem2_EditGeolayoutScript.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem2_EditGeolayoutScript, "ButtonItem2_EditGeolayoutScript");
            // 
            // ListBoxAdv_LM_Areas
            // 
            resources.ApplyResources(_ListBoxAdv_LM_Areas, "ListBoxAdv_LM_Areas");
            _ListBoxAdv_LM_Areas.BackColor = Color.White;
            // 
            // 
            // 
            _ListBoxAdv_LM_Areas.BackgroundStyle.Class = "ListBoxAdv";
            _ListBoxAdv_LM_Areas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListBoxAdv_LM_Areas.ContainerControlProcessDialogKey = true;
            _ListBoxAdv_LM_Areas.DragDropSupport = true;
            _ListBoxAdv_LM_Areas.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ListBoxAdv_LM_Areas.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ListBoxAdv_LM_Areas.Name = "ListBoxAdv_LM_Areas";
            _ListBoxAdv_LM_Areas.ReserveLeftSpace = false;
            _ListBoxAdv_LM_Areas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // GroupPanel1
            // 
            _GroupPanel1.CanvasColor = Color.Empty;
            _GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            _GroupPanel1.Controls.Add(_ButtonX_LM_LevelsMore);
            _GroupPanel1.Controls.Add(_Button_LM_AddNewLevel);
            _GroupPanel1.Controls.Add(_ListBoxAdv_LM_Levels);
            _GroupPanel1.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_GroupPanel1, "GroupPanel1");
            _GroupPanel1.Name = "GroupPanel1";
            // 
            // 
            // 
            _GroupPanel1.Style.BackColorGradientAngle = 90;
            _GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel1.Style.BorderBottomWidth = 1;
            _GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel1.Style.BorderLeftWidth = 1;
            _GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel1.Style.BorderRightWidth = 1;
            _GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel1.Style.BorderTopWidth = 1;
            _GroupPanel1.Style.CornerDiameter = 4;
            _GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonX_LM_LevelsMore
            // 
            _ButtonX_LM_LevelsMore.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_LM_LevelsMore.AutoExpandOnClick = true;
            _ButtonX_LM_LevelsMore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_ButtonX_LM_LevelsMore, "ButtonX_LM_LevelsMore");
            _ButtonX_LM_LevelsMore.FocusCuesEnabled = false;
            _ButtonX_LM_LevelsMore.Name = "ButtonX_LM_LevelsMore";
            _ButtonX_LM_LevelsMore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_LM_LevelsMore.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem20, _ButtonItem1, _ButtonItem24, _ButtonItem19, _ButtonItem21, _ButtonItem15 });
            _ButtonX_LM_LevelsMore.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonX_LM_LevelsMore.SymbolSize = 12.0F;
            // 
            // ButtonItem20
            // 
            _ButtonItem20.GlobalItem = false;
            _ButtonItem20.Name = "ButtonItem20";
            _ButtonItem20.SymbolColor = Color.Goldenrod;
            _ButtonItem20.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem20.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem20, "ButtonItem20");
            // 
            // ButtonItem1
            // 
            _ButtonItem1.GlobalItem = false;
            _ButtonItem1.Name = "ButtonItem1";
            resources.ApplyResources(_ButtonItem1, "ButtonItem1");
            // 
            // ButtonItem24
            // 
            _ButtonItem24.GlobalItem = false;
            _ButtonItem24.Name = "ButtonItem24";
            resources.ApplyResources(_ButtonItem24, "ButtonItem24");
            // 
            // ButtonItem19
            // 
            _ButtonItem19.GlobalItem = false;
            _ButtonItem19.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem19.Name = "ButtonItem19";
            _ButtonItem19.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonItem19.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem19.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem19, "ButtonItem19");
            // 
            // ButtonItem21
            // 
            _ButtonItem21.BeginGroup = true;
            _ButtonItem21.GlobalItem = false;
            _ButtonItem21.Name = "ButtonItem21";
            resources.ApplyResources(_ButtonItem21, "ButtonItem21");
            // 
            // ButtonItem15
            // 
            _ButtonItem15.BeginGroup = true;
            _ButtonItem15.GlobalItem = false;
            _ButtonItem15.Image = My.Resources.MyIcons.icons8_edit_16px;
            _ButtonItem15.Name = "ButtonItem15";
            _ButtonItem15.SymbolColor = Color.Goldenrod;
            _ButtonItem15.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem15.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem15, "ButtonItem15");
            // 
            // Button_LM_AddNewLevel
            // 
            _Button_LM_AddNewLevel.AccessibleRole = AccessibleRole.PushButton;
            _Button_LM_AddNewLevel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_LM_AddNewLevel.FocusCuesEnabled = false;
            _Button_LM_AddNewLevel.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(_Button_LM_AddNewLevel, "Button_LM_AddNewLevel");
            _Button_LM_AddNewLevel.Name = "Button_LM_AddNewLevel";
            _Button_LM_AddNewLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_LM_AddNewLevel.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem26 });
            _Button_LM_AddNewLevel.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _Button_LM_AddNewLevel.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LM_AddNewLevel.SymbolSize = 12.0F;
            // 
            // ButtonItem26
            // 
            _ButtonItem26.GlobalItem = false;
            _ButtonItem26.Name = "ButtonItem26";
            resources.ApplyResources(_ButtonItem26, "ButtonItem26");
            // 
            // ListBoxAdv_LM_Levels
            // 
            resources.ApplyResources(_ListBoxAdv_LM_Levels, "ListBoxAdv_LM_Levels");
            _ListBoxAdv_LM_Levels.BackColor = Color.White;
            // 
            // 
            // 
            _ListBoxAdv_LM_Levels.BackgroundStyle.Class = "ListBoxAdv";
            _ListBoxAdv_LM_Levels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListBoxAdv_LM_Levels.ContainerControlProcessDialogKey = true;
            _ListBoxAdv_LM_Levels.DragDropSupport = true;
            _ListBoxAdv_LM_Levels.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ListBoxAdv_LM_Levels.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ListBoxAdv_LM_Levels.Name = "ListBoxAdv_LM_Levels";
            _ListBoxAdv_LM_Levels.ReserveLeftSpace = false;
            _ListBoxAdv_LM_Levels.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // TabControl_LM_Area
            // 
            resources.ApplyResources(_TabControl_LM_Area, "TabControl_LM_Area");
            _TabControl_LM_Area.BackColor = Color.Transparent;
            _TabControl_LM_Area.CanReorderTabs = false;
            _TabControl_LM_Area.Controls.Add(_TabControlPanel4);
            _TabControl_LM_Area.Controls.Add(_TabControlPanel6);
            _TabControl_LM_Area.Controls.Add(_TabControlPanel5);
            _TabControl_LM_Area.ForeColor = Color.Black;
            _TabControl_LM_Area.Name = "TabControl_LM_Area";
            _TabControl_LM_Area.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            _TabControl_LM_Area.SelectedTabIndex = 0;
            _TabControl_LM_Area.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            _TabControl_LM_Area.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            _TabControl_LM_Area.Tabs.Add(_TabItem4);
            _TabControl_LM_Area.Tabs.Add(_TabItem5);
            _TabControl_LM_Area.Tabs.Add(_TabItem6);
            // 
            // TabControlPanel4
            // 
            _TabControlPanel4.Controls.Add(_LabelX9);
            _TabControlPanel4.Controls.Add(_ComboBoxEx_LM_AreaBG);
            _TabControlPanel4.Controls.Add(_TextBoxX_LM_ShowMsgID);
            _TabControlPanel4.Controls.Add(_LabelX1);
            _TabControlPanel4.Controls.Add(_SwitchButton_LM_ShowMsgEnabled);
            _TabControlPanel4.Controls.Add(_LabelX2);
            _TabControlPanel4.Controls.Add(_CheckBoxX_LM_Enable2DCamera);
            _TabControlPanel4.Controls.Add(_LabelX6);
            _TabControlPanel4.Controls.Add(_ComboBox_LM_Music);
            _TabControlPanel4.Controls.Add(_LabelX7);
            _TabControlPanel4.Controls.Add(_ComboBox_LM_TerrainTyp);
            _TabControlPanel4.Controls.Add(_LabelX8);
            _TabControlPanel4.Controls.Add(_ComboBox_LM_EnvironmentEffects);
            _TabControlPanel4.Controls.Add(_LabelX11);
            _TabControlPanel4.Controls.Add(_ComboBox_LM_CameraPreset);
            _TabControlPanel4.Controls.Add(_ColorPickerButton_LM_BackgroundColor);
            _TabControlPanel4.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel4, "TabControlPanel4");
            _TabControlPanel4.Name = "TabControlPanel4";
            _TabControlPanel4.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel4.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel4.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel4.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel4.Style.GradientAngle = 90;
            _TabControlPanel4.TabItem = _TabItem4;
            // 
            // LabelX9
            // 
            _LabelX9.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX9, "LabelX9");
            _LabelX9.Name = "LabelX9";
            _LabelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBoxEx_LM_AreaBG
            // 
            _ComboBoxEx_LM_AreaBG.DisplayMember = "Text";
            _ComboBoxEx_LM_AreaBG.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_LM_AreaBG.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_LM_AreaBG.ForeColor = Color.Black;
            _ComboBoxEx_LM_AreaBG.FormattingEnabled = true;
            resources.ApplyResources(_ComboBoxEx_LM_AreaBG, "ComboBoxEx_LM_AreaBG");
            _ComboBoxEx_LM_AreaBG.Items.AddRange(new object[] { _ComboItem12, _ComboItem13 });
            _ComboBoxEx_LM_AreaBG.Name = "ComboBoxEx_LM_AreaBG";
            _ComboBoxEx_LM_AreaBG.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem12
            // 
            resources.ApplyResources(_ComboItem12, "ComboItem12");
            // 
            // ComboItem13
            // 
            resources.ApplyResources(_ComboItem13, "ComboItem13");
            // 
            // TextBoxX_LM_ShowMsgID
            // 
            _TextBoxX_LM_ShowMsgID.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_LM_ShowMsgID.Border.Class = "TextBoxBorder";
            _TextBoxX_LM_ShowMsgID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_LM_ShowMsgID.DisabledBackColor = Color.White;
            _TextBoxX_LM_ShowMsgID.ForeColor = Color.Black;
            resources.ApplyResources(_TextBoxX_LM_ShowMsgID, "TextBoxX_LM_ShowMsgID");
            _TextBoxX_LM_ShowMsgID.Name = "TextBoxX_LM_ShowMsgID";
            _TextBoxX_LM_ShowMsgID.PreventEnterBeep = true;
            // 
            // LabelX1
            // 
            _LabelX1.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX1, "LabelX1");
            _LabelX1.Name = "LabelX1";
            _LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_LM_ShowMsgEnabled
            // 
            // 
            // 
            // 
            _SwitchButton_LM_ShowMsgEnabled.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_LM_ShowMsgEnabled.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_LM_ShowMsgEnabled, "SwitchButton_LM_ShowMsgEnabled");
            _SwitchButton_LM_ShowMsgEnabled.Name = "SwitchButton_LM_ShowMsgEnabled";
            _SwitchButton_LM_ShowMsgEnabled.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_LM_ShowMsgEnabled.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_LM_ShowMsgEnabled.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_LM_ShowMsgEnabled.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_LM_ShowMsgEnabled.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_LM_ShowMsgEnabled.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_LM_ShowMsgEnabled.SwitchWidth = 15;
            // 
            // LabelX2
            // 
            _LabelX2.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX2, "LabelX2");
            _LabelX2.Name = "LabelX2";
            _LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX_LM_Enable2DCamera
            // 
            // 
            // 
            // 
            _CheckBoxX_LM_Enable2DCamera.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_LM_Enable2DCamera.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX_LM_Enable2DCamera, "CheckBoxX_LM_Enable2DCamera");
            _CheckBoxX_LM_Enable2DCamera.Name = "CheckBoxX_LM_Enable2DCamera";
            _CheckBoxX_LM_Enable2DCamera.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _CheckBoxX_LM_Enable2DCamera.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _CheckBoxX_LM_Enable2DCamera.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _CheckBoxX_LM_Enable2DCamera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _CheckBoxX_LM_Enable2DCamera.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _CheckBoxX_LM_Enable2DCamera.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _CheckBoxX_LM_Enable2DCamera.SwitchWidth = 15;
            // 
            // LabelX6
            // 
            _LabelX6.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX6, "LabelX6");
            _LabelX6.Name = "LabelX6";
            _LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_Music
            // 
            _ComboBox_LM_Music.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_LM_Music.DropDownHeight = 150;
            _ComboBox_LM_Music.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_LM_Music.ForeColor = Color.Black;
            _ComboBox_LM_Music.FormattingEnabled = true;
            resources.ApplyResources(_ComboBox_LM_Music, "ComboBox_LM_Music");
            _ComboBox_LM_Music.Items.AddRange(new object[] { resources.GetString("ComboBox_LM_Music.Items"), resources.GetString("ComboBox_LM_Music.Items1") });
            _ComboBox_LM_Music.Name = "ComboBox_LM_Music";
            _ComboBox_LM_Music.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX7
            // 
            _LabelX7.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX7, "LabelX7");
            _LabelX7.Name = "LabelX7";
            _LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_TerrainTyp
            // 
            _ComboBox_LM_TerrainTyp.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_LM_TerrainTyp.DropDownHeight = 150;
            _ComboBox_LM_TerrainTyp.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_LM_TerrainTyp.ForeColor = Color.Black;
            _ComboBox_LM_TerrainTyp.FormattingEnabled = true;
            resources.ApplyResources(_ComboBox_LM_TerrainTyp, "ComboBox_LM_TerrainTyp");
            _ComboBox_LM_TerrainTyp.Items.AddRange(new object[] { resources.GetString("ComboBox_LM_TerrainTyp.Items"), resources.GetString("ComboBox_LM_TerrainTyp.Items1"), resources.GetString("ComboBox_LM_TerrainTyp.Items2"), resources.GetString("ComboBox_LM_TerrainTyp.Items3"), resources.GetString("ComboBox_LM_TerrainTyp.Items4"), resources.GetString("ComboBox_LM_TerrainTyp.Items5"), resources.GetString("ComboBox_LM_TerrainTyp.Items6") });
            _ComboBox_LM_TerrainTyp.Name = "ComboBox_LM_TerrainTyp";
            _ComboBox_LM_TerrainTyp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX8
            // 
            _LabelX8.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX8, "LabelX8");
            _LabelX8.Name = "LabelX8";
            _LabelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_EnvironmentEffects
            // 
            _ComboBox_LM_EnvironmentEffects.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_LM_EnvironmentEffects.DropDownHeight = 150;
            _ComboBox_LM_EnvironmentEffects.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_LM_EnvironmentEffects.ForeColor = Color.Black;
            _ComboBox_LM_EnvironmentEffects.FormattingEnabled = true;
            resources.ApplyResources(_ComboBox_LM_EnvironmentEffects, "ComboBox_LM_EnvironmentEffects");
            _ComboBox_LM_EnvironmentEffects.Items.AddRange(new object[] { resources.GetString("ComboBox_LM_EnvironmentEffects.Items"), resources.GetString("ComboBox_LM_EnvironmentEffects.Items1"), resources.GetString("ComboBox_LM_EnvironmentEffects.Items2"), resources.GetString("ComboBox_LM_EnvironmentEffects.Items3"), resources.GetString("ComboBox_LM_EnvironmentEffects.Items4"), resources.GetString("ComboBox_LM_EnvironmentEffects.Items5"), resources.GetString("ComboBox_LM_EnvironmentEffects.Items6") });
            _ComboBox_LM_EnvironmentEffects.Name = "ComboBox_LM_EnvironmentEffects";
            _ComboBox_LM_EnvironmentEffects.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX11
            // 
            _LabelX11.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX11, "LabelX11");
            _LabelX11.Name = "LabelX11";
            _LabelX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_CameraPreset
            // 
            _ComboBox_LM_CameraPreset.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_LM_CameraPreset.DropDownHeight = 150;
            _ComboBox_LM_CameraPreset.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_LM_CameraPreset.ForeColor = Color.Black;
            _ComboBox_LM_CameraPreset.FormattingEnabled = true;
            resources.ApplyResources(_ComboBox_LM_CameraPreset, "ComboBox_LM_CameraPreset");
            _ComboBox_LM_CameraPreset.Items.AddRange(new object[] { resources.GetString("ComboBox_LM_CameraPreset.Items"), resources.GetString("ComboBox_LM_CameraPreset.Items1"), resources.GetString("ComboBox_LM_CameraPreset.Items2"), resources.GetString("ComboBox_LM_CameraPreset.Items3"), resources.GetString("ComboBox_LM_CameraPreset.Items4"), resources.GetString("ComboBox_LM_CameraPreset.Items5"), resources.GetString("ComboBox_LM_CameraPreset.Items6"), resources.GetString("ComboBox_LM_CameraPreset.Items7"), resources.GetString("ComboBox_LM_CameraPreset.Items8"), resources.GetString("ComboBox_LM_CameraPreset.Items9"), resources.GetString("ComboBox_LM_CameraPreset.Items10"), resources.GetString("ComboBox_LM_CameraPreset.Items11"), resources.GetString("ComboBox_LM_CameraPreset.Items12"), resources.GetString("ComboBox_LM_CameraPreset.Items13"), resources.GetString("ComboBox_LM_CameraPreset.Items14"), resources.GetString("ComboBox_LM_CameraPreset.Items15") });
            _ComboBox_LM_CameraPreset.Name = "ComboBox_LM_CameraPreset";
            _ComboBox_LM_CameraPreset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ColorPickerButton_LM_BackgroundColor
            // 
            _ColorPickerButton_LM_BackgroundColor.AccessibleRole = AccessibleRole.PushButton;
            _ColorPickerButton_LM_BackgroundColor.AutoExpandOnClick = true;
            _ColorPickerButton_LM_BackgroundColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ColorPickerButton_LM_BackgroundColor.FocusCuesEnabled = false;
            _ColorPickerButton_LM_BackgroundColor.Image = (Image)resources.GetObject("ColorPickerButton_LM_BackgroundColor.Image");
            resources.ApplyResources(_ColorPickerButton_LM_BackgroundColor, "ColorPickerButton_LM_BackgroundColor");
            _ColorPickerButton_LM_BackgroundColor.Name = "ColorPickerButton_LM_BackgroundColor";
            _ColorPickerButton_LM_BackgroundColor.SelectedColorImageRectangle = new Rectangle(2, 2, 12, 12);
            _ColorPickerButton_LM_BackgroundColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // TabItem4
            // 
            _TabItem4.AttachedControl = _TabControlPanel4;
            _TabItem4.Name = "TabItem4";
            resources.ApplyResources(_TabItem4, "TabItem4");
            // 
            // TabControlPanel6
            // 
            _TabControlPanel6.Controls.Add(_Button_LM_RemoveSpecial);
            _TabControlPanel6.Controls.Add(_Button_LM_AddSpecial);
            _TabControlPanel6.Controls.Add(_Button_LM_EditSpecial);
            _TabControlPanel6.Controls.Add(_ListViewEx_LM_Specials);
            _TabControlPanel6.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel6, "TabControlPanel6");
            _TabControlPanel6.Name = "TabControlPanel6";
            _TabControlPanel6.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel6.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel6.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel6.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel6.Style.GradientAngle = 90;
            _TabControlPanel6.TabItem = _TabItem6;
            // 
            // Button_LM_RemoveSpecial
            // 
            _Button_LM_RemoveSpecial.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_Button_LM_RemoveSpecial, "Button_LM_RemoveSpecial");
            _Button_LM_RemoveSpecial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_LM_RemoveSpecial.FocusCuesEnabled = false;
            _Button_LM_RemoveSpecial.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _Button_LM_RemoveSpecial.Name = "Button_LM_RemoveSpecial";
            _Button_LM_RemoveSpecial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_LM_RemoveSpecial.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _Button_LM_RemoveSpecial.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LM_RemoveSpecial.SymbolSize = 12.0F;
            // 
            // Button_LM_AddSpecial
            // 
            _Button_LM_AddSpecial.AccessibleRole = AccessibleRole.PushButton;
            _Button_LM_AddSpecial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_LM_AddSpecial.FocusCuesEnabled = false;
            _Button_LM_AddSpecial.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(_Button_LM_AddSpecial, "Button_LM_AddSpecial");
            _Button_LM_AddSpecial.Name = "Button_LM_AddSpecial";
            _Button_LM_AddSpecial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_LM_AddSpecial.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _Button_LM_AddSpecial.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LM_AddSpecial.SymbolSize = 12.0F;
            // 
            // Button_LM_EditSpecial
            // 
            _Button_LM_EditSpecial.AccessibleRole = AccessibleRole.PushButton;
            _Button_LM_EditSpecial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_Button_LM_EditSpecial, "Button_LM_EditSpecial");
            _Button_LM_EditSpecial.FocusCuesEnabled = false;
            _Button_LM_EditSpecial.Image = My.Resources.MyIcons.icons8_edit_16px;
            _Button_LM_EditSpecial.Name = "Button_LM_EditSpecial";
            _Button_LM_EditSpecial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_LM_EditSpecial.SymbolColor = Color.Goldenrod;
            _Button_LM_EditSpecial.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LM_EditSpecial.SymbolSize = 12.0F;
            // 
            // ListViewEx_LM_Specials
            // 
            resources.ApplyResources(_ListViewEx_LM_Specials, "ListViewEx_LM_Specials");
            _ListViewEx_LM_Specials.BackColor = Color.White;
            // 
            // 
            // 
            _ListViewEx_LM_Specials.Border.Class = "ListViewBorder";
            _ListViewEx_LM_Specials.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx_LM_Specials.Columns.AddRange(new ColumnHeader[] { _ColumnHeaderA1, _ColumnHeader2, _ColumnHeader3, _ColumnHeader4, _ColumnHeader5, _ColumnHeader6, _ColumnHeader7, _ColumnHeaderA });
            _ListViewEx_LM_Specials.DisabledBackColor = Color.Empty;
            _ListViewEx_LM_Specials.FocusCuesEnabled = false;
            _ListViewEx_LM_Specials.ForeColor = Color.Black;
            _ListViewEx_LM_Specials.FullRowSelect = true;
            _ListViewEx_LM_Specials.GridLines = true;
            _ListViewEx_LM_Specials.Groups.AddRange(new ListViewGroup[] { (ListViewGroup)resources.GetObject("ListViewEx_LM_Specials.Groups"), (ListViewGroup)resources.GetObject("ListViewEx_LM_Specials.Groups1"), (ListViewGroup)resources.GetObject("ListViewEx_LM_Specials.Groups2"), (ListViewGroup)resources.GetObject("ListViewEx_LM_Specials.Groups3") });
            _ListViewEx_LM_Specials.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _ListViewEx_LM_Specials.HideSelection = false;
            _ListViewEx_LM_Specials.MultiSelect = false;
            _ListViewEx_LM_Specials.Name = "ListViewEx_LM_Specials";
            _ListViewEx_LM_Specials.ShowGroups = false;
            _ListViewEx_LM_Specials.UseCompatibleStateImageBehavior = false;
            _ListViewEx_LM_Specials.View = View.Details;
            // 
            // ColumnHeaderA1
            // 
            resources.ApplyResources(_ColumnHeaderA1, "ColumnHeaderA1");
            // 
            // ColumnHeader2
            // 
            resources.ApplyResources(_ColumnHeader2, "ColumnHeader2");
            // 
            // ColumnHeader3
            // 
            resources.ApplyResources(_ColumnHeader3, "ColumnHeader3");
            // 
            // ColumnHeader4
            // 
            resources.ApplyResources(_ColumnHeader4, "ColumnHeader4");
            // 
            // ColumnHeader5
            // 
            resources.ApplyResources(_ColumnHeader5, "ColumnHeader5");
            // 
            // ColumnHeader6
            // 
            resources.ApplyResources(_ColumnHeader6, "ColumnHeader6");
            // 
            // ColumnHeader7
            // 
            resources.ApplyResources(_ColumnHeader7, "ColumnHeader7");
            // 
            // ColumnHeaderA
            // 
            resources.ApplyResources(_ColumnHeaderA, "ColumnHeaderA");
            // 
            // TabItem6
            // 
            _TabItem6.AttachedControl = _TabControlPanel6;
            _TabItem6.Name = "TabItem6";
            resources.ApplyResources(_TabItem6, "TabItem6");
            // 
            // TabControlPanel5
            // 
            _TabControlPanel5.Controls.Add(_Line2);
            _TabControlPanel5.Controls.Add(_LabelX_Area_CountOfCustomObjects);
            _TabControlPanel5.Controls.Add(_LabelX_Area_CountOfTexAnimations);
            _TabControlPanel5.Controls.Add(_LabelX10);
            _TabControlPanel5.Controls.Add(_LabelX5);
            _TabControlPanel5.Controls.Add(_ButtonX_CustomObjects);
            _TabControlPanel5.Controls.Add(_ButtonX_LM_ScrollTexEditor);
            _TabControlPanel5.Controls.Add(_Button_ImportModel);
            _TabControlPanel5.Controls.Add(_ButtonItem_ExportModel);
            _TabControlPanel5.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel5, "TabControlPanel5");
            _TabControlPanel5.Name = "TabControlPanel5";
            _TabControlPanel5.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel5.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel5.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel5.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel5.Style.GradientAngle = 90;
            _TabControlPanel5.TabItem = _TabItem5;
            // 
            // Line2
            // 
            _Line2.BackColor = Color.Transparent;
            resources.ApplyResources(_Line2, "Line2");
            _Line2.Name = "Line2";
            _Line2.VerticalLine = true;
            // 
            // LabelX_Area_CountOfCustomObjects
            // 
            _LabelX_Area_CountOfCustomObjects.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_Area_CountOfCustomObjects.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX_Area_CountOfCustomObjects, "LabelX_Area_CountOfCustomObjects");
            _LabelX_Area_CountOfCustomObjects.Name = "LabelX_Area_CountOfCustomObjects";
            _LabelX_Area_CountOfCustomObjects.TextAlignment = StringAlignment.Far;
            // 
            // LabelX_Area_CountOfTexAnimations
            // 
            _LabelX_Area_CountOfTexAnimations.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_Area_CountOfTexAnimations.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX_Area_CountOfTexAnimations, "LabelX_Area_CountOfTexAnimations");
            _LabelX_Area_CountOfTexAnimations.Name = "LabelX_Area_CountOfTexAnimations";
            _LabelX_Area_CountOfTexAnimations.TextAlignment = StringAlignment.Far;
            // 
            // LabelX10
            // 
            _LabelX10.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX10, "LabelX10");
            _LabelX10.Name = "LabelX10";
            // 
            // LabelX5
            // 
            _LabelX5.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX5, "LabelX5");
            _LabelX5.Name = "LabelX5";
            // 
            // ButtonX_CustomObjects
            // 
            _ButtonX_CustomObjects.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_CustomObjects.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_ButtonX_CustomObjects, "ButtonX_CustomObjects");
            _ButtonX_CustomObjects.FocusCuesEnabled = false;
            _ButtonX_CustomObjects.Name = "ButtonX_CustomObjects";
            _ButtonX_CustomObjects.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_LM_ScrollTexEditor
            // 
            _ButtonX_LM_ScrollTexEditor.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_LM_ScrollTexEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_LM_ScrollTexEditor.FocusCuesEnabled = false;
            resources.ApplyResources(_ButtonX_LM_ScrollTexEditor, "ButtonX_LM_ScrollTexEditor");
            _ButtonX_LM_ScrollTexEditor.Name = "ButtonX_LM_ScrollTexEditor";
            _ButtonX_LM_ScrollTexEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Button_ImportModel
            // 
            _Button_ImportModel.AccessibleRole = AccessibleRole.PushButton;
            _Button_ImportModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_ImportModel.FocusCuesEnabled = false;
            resources.ApplyResources(_Button_ImportModel, "Button_ImportModel");
            _Button_ImportModel.Name = "Button_ImportModel";
            _Button_ImportModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_ImportModel.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem9, _ButtonItem13 });
            // 
            // ButtonItem9
            // 
            _ButtonItem9.GlobalItem = false;
            _ButtonItem9.Name = "ButtonItem9";
            resources.ApplyResources(_ButtonItem9, "ButtonItem9");
            // 
            // ButtonItem13
            // 
            _ButtonItem13.GlobalItem = false;
            _ButtonItem13.Name = "ButtonItem13";
            resources.ApplyResources(_ButtonItem13, "ButtonItem13");
            // 
            // ButtonItem_ExportModel
            // 
            _ButtonItem_ExportModel.AccessibleRole = AccessibleRole.PushButton;
            _ButtonItem_ExportModel.AutoExpandOnClick = true;
            _ButtonItem_ExportModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonItem_ExportModel.FocusCuesEnabled = false;
            resources.ApplyResources(_ButtonItem_ExportModel, "ButtonItem_ExportModel");
            _ButtonItem_ExportModel.Name = "ButtonItem_ExportModel";
            _ButtonItem_ExportModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonItem_ExportModel.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_ExportVisualMap, _ButtonItem_ExportCollisionMap });
            // 
            // ButtonItem_ExportVisualMap
            // 
            _ButtonItem_ExportVisualMap.GlobalItem = false;
            _ButtonItem_ExportVisualMap.Name = "ButtonItem_ExportVisualMap";
            resources.ApplyResources(_ButtonItem_ExportVisualMap, "ButtonItem_ExportVisualMap");
            // 
            // ButtonItem_ExportCollisionMap
            // 
            _ButtonItem_ExportCollisionMap.GlobalItem = false;
            _ButtonItem_ExportCollisionMap.Name = "ButtonItem_ExportCollisionMap";
            resources.ApplyResources(_ButtonItem_ExportCollisionMap, "ButtonItem_ExportCollisionMap");
            // 
            // TabItem5
            // 
            _TabItem5.AttachedControl = _TabControlPanel5;
            _TabItem5.Name = "TabItem5";
            resources.ApplyResources(_TabItem5, "TabItem5");
            // 
            // TabControl_LM_Level
            // 
            resources.ApplyResources(_TabControl_LM_Level, "TabControl_LM_Level");
            _TabControl_LM_Level.BackColor = Color.Transparent;
            _TabControl_LM_Level.CanReorderTabs = false;
            _TabControl_LM_Level.Controls.Add(_TabControlPanel1);
            _TabControl_LM_Level.Controls.Add(_TabControlPanel2);
            _TabControl_LM_Level.ForeColor = Color.Black;
            _TabControl_LM_Level.Name = "TabControl_LM_Level";
            _TabControl_LM_Level.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            _TabControl_LM_Level.SelectedTabIndex = 0;
            _TabControl_LM_Level.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            _TabControl_LM_Level.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            _TabControl_LM_Level.Tabs.Add(_TabItem1);
            _TabControl_LM_Level.Tabs.Add(_TabItem2);
            // 
            // TabControlPanel1
            // 
            _TabControlPanel1.Controls.Add(_LabelX_TargetLevel);
            _TabControlPanel1.Controls.Add(_LabelX12);
            _TabControlPanel1.Controls.Add(_PictureBox_BGImage);
            _TabControlPanel1.Controls.Add(_ComboBoxEx_LM_BGMode);
            _TabControlPanel1.Controls.Add(_LabelX15);
            _TabControlPanel1.Controls.Add(_LabelX3);
            _TabControlPanel1.Controls.Add(_SwitchButton_LM_ActSelector);
            _TabControlPanel1.Controls.Add(_LabelX57);
            _TabControlPanel1.Controls.Add(_SwitchButton_LM_HardcodedCameraSettings);
            _TabControlPanel1.Controls.Add(_LabelX4);
            _TabControlPanel1.Controls.Add(_ComboBox_LM_LevelBG);
            _TabControlPanel1.Controls.Add(_LabelX24);
            _TabControlPanel1.Controls.Add(_NUD_LM_DefaultPositionYRotation);
            _TabControlPanel1.Controls.Add(_LabelX25);
            _TabControlPanel1.Controls.Add(_NUD_LM_DefaultPositionAreaID);
            _TabControlPanel1.Controls.Add(_Button_LM_LoadLevelBG);
            _TabControlPanel1.Controls.Add(_Button_LM_SetUpStartPosition);
            _TabControlPanel1.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel1, "TabControlPanel1");
            _TabControlPanel1.Name = "TabControlPanel1";
            _TabControlPanel1.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel1.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel1.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel1.Style.GradientAngle = 90;
            _TabControlPanel1.TabItem = _TabItem1;
            // 
            // LabelX_TargetLevel
            // 
            _LabelX_TargetLevel.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_TargetLevel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX_TargetLevel, "LabelX_TargetLevel");
            _LabelX_TargetLevel.Name = "LabelX_TargetLevel";
            _LabelX_TargetLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX12
            // 
            _LabelX12.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX12, "LabelX12");
            _LabelX12.Name = "LabelX12";
            _LabelX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // PictureBox_BGImage
            // 
            _PictureBox_BGImage.BackColor = Color.Transparent;
            resources.ApplyResources(_PictureBox_BGImage, "PictureBox_BGImage");
            _PictureBox_BGImage.Name = "PictureBox_BGImage";
            _PictureBox_BGImage.TabStop = false;
            // 
            // ComboBoxEx_LM_BGMode
            // 
            _ComboBoxEx_LM_BGMode.DisplayMember = "Text";
            _ComboBoxEx_LM_BGMode.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_LM_BGMode.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_LM_BGMode.ForeColor = Color.Black;
            _ComboBoxEx_LM_BGMode.FormattingEnabled = true;
            resources.ApplyResources(_ComboBoxEx_LM_BGMode, "ComboBoxEx_LM_BGMode");
            _ComboBoxEx_LM_BGMode.Items.AddRange(new object[] { _ComboItem1, _ComboItem2, _ComboItem3 });
            _ComboBoxEx_LM_BGMode.Name = "ComboBoxEx_LM_BGMode";
            _ComboBoxEx_LM_BGMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem1
            // 
            resources.ApplyResources(_ComboItem1, "ComboItem1");
            // 
            // ComboItem2
            // 
            resources.ApplyResources(_ComboItem2, "ComboItem2");
            // 
            // ComboItem3
            // 
            resources.ApplyResources(_ComboItem3, "ComboItem3");
            // 
            // LabelX15
            // 
            _LabelX15.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX15, "LabelX15");
            _LabelX15.Name = "LabelX15";
            _LabelX15.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX3
            // 
            _LabelX3.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX3, "LabelX3");
            _LabelX3.Name = "LabelX3";
            _LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_LM_ActSelector
            // 
            // 
            // 
            // 
            _SwitchButton_LM_ActSelector.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_LM_ActSelector.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_LM_ActSelector, "SwitchButton_LM_ActSelector");
            _SwitchButton_LM_ActSelector.Name = "SwitchButton_LM_ActSelector";
            _SwitchButton_LM_ActSelector.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_LM_ActSelector.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_LM_ActSelector.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_LM_ActSelector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_LM_ActSelector.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_LM_ActSelector.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_LM_ActSelector.SwitchWidth = 15;
            _SwitchButton_LM_ActSelector.Value = true;
            _SwitchButton_LM_ActSelector.ValueObject = "Y";
            // 
            // LabelX57
            // 
            _LabelX57.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX57.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX57, "LabelX57");
            _LabelX57.Name = "LabelX57";
            _LabelX57.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_LM_HardcodedCameraSettings
            // 
            // 
            // 
            // 
            _SwitchButton_LM_HardcodedCameraSettings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_LM_HardcodedCameraSettings.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_LM_HardcodedCameraSettings, "SwitchButton_LM_HardcodedCameraSettings");
            _SwitchButton_LM_HardcodedCameraSettings.Name = "SwitchButton_LM_HardcodedCameraSettings";
            _SwitchButton_LM_HardcodedCameraSettings.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_LM_HardcodedCameraSettings.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_LM_HardcodedCameraSettings.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_LM_HardcodedCameraSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_LM_HardcodedCameraSettings.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_LM_HardcodedCameraSettings.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_LM_HardcodedCameraSettings.SwitchWidth = 15;
            // 
            // LabelX4
            // 
            _LabelX4.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX4, "LabelX4");
            _LabelX4.Name = "LabelX4";
            _LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_LM_LevelBG
            // 
            _ComboBox_LM_LevelBG.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_LM_LevelBG.DropDownHeight = 200;
            _ComboBox_LM_LevelBG.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_LM_LevelBG.ForeColor = Color.Black;
            _ComboBox_LM_LevelBG.FormattingEnabled = true;
            resources.ApplyResources(_ComboBox_LM_LevelBG, "ComboBox_LM_LevelBG");
            _ComboBox_LM_LevelBG.Items.AddRange(new object[] { resources.GetString("ComboBox_LM_LevelBG.Items"), resources.GetString("ComboBox_LM_LevelBG.Items1"), resources.GetString("ComboBox_LM_LevelBG.Items2"), resources.GetString("ComboBox_LM_LevelBG.Items3"), resources.GetString("ComboBox_LM_LevelBG.Items4"), resources.GetString("ComboBox_LM_LevelBG.Items5"), resources.GetString("ComboBox_LM_LevelBG.Items6"), resources.GetString("ComboBox_LM_LevelBG.Items7"), resources.GetString("ComboBox_LM_LevelBG.Items8"), resources.GetString("ComboBox_LM_LevelBG.Items9") });
            _ComboBox_LM_LevelBG.Name = "ComboBox_LM_LevelBG";
            _ComboBox_LM_LevelBG.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX24
            // 
            _LabelX24.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX24, "LabelX24");
            _LabelX24.Name = "LabelX24";
            _LabelX24.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // NUD_LM_DefaultPositionYRotation
            // 
            resources.ApplyResources(_NUD_LM_DefaultPositionYRotation, "NUD_LM_DefaultPositionYRotation");
            _NUD_LM_DefaultPositionYRotation.Maximum = new decimal(new int[] { 359, 0, 0, 0 });
            _NUD_LM_DefaultPositionYRotation.Minimum = new decimal(new int[] { 359, 0, 0, -2147483648 });
            _NUD_LM_DefaultPositionYRotation.Name = "NUD_LM_DefaultPositionYRotation";
            // 
            // LabelX25
            // 
            _LabelX25.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX25, "LabelX25");
            _LabelX25.Name = "LabelX25";
            _LabelX25.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // NUD_LM_DefaultPositionAreaID
            // 
            resources.ApplyResources(_NUD_LM_DefaultPositionAreaID, "NUD_LM_DefaultPositionAreaID");
            _NUD_LM_DefaultPositionAreaID.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            _NUD_LM_DefaultPositionAreaID.Name = "NUD_LM_DefaultPositionAreaID";
            // 
            // Button_LM_LoadLevelBG
            // 
            _Button_LM_LoadLevelBG.AccessibleRole = AccessibleRole.PushButton;
            _Button_LM_LoadLevelBG.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_LM_LoadLevelBG.FocusCuesEnabled = false;
            _Button_LM_LoadLevelBG.Image = My.Resources.MyIcons.icons8_open_folder_16px;
            resources.ApplyResources(_Button_LM_LoadLevelBG, "Button_LM_LoadLevelBG");
            _Button_LM_LoadLevelBG.Name = "Button_LM_LoadLevelBG";
            _Button_LM_LoadLevelBG.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_LM_LoadLevelBG.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _Button_LM_LoadLevelBG.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LM_LoadLevelBG.SymbolSize = 12.0F;
            // 
            // Button_LM_SetUpStartPosition
            // 
            _Button_LM_SetUpStartPosition.AccessibleRole = AccessibleRole.PushButton;
            _Button_LM_SetUpStartPosition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_LM_SetUpStartPosition.FocusCuesEnabled = false;
            _Button_LM_SetUpStartPosition.Image = My.Resources.MyIcons.icons8_support_16px;
            resources.ApplyResources(_Button_LM_SetUpStartPosition, "Button_LM_SetUpStartPosition");
            _Button_LM_SetUpStartPosition.Name = "Button_LM_SetUpStartPosition";
            _Button_LM_SetUpStartPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_LM_SetUpStartPosition.SymbolColor = Color.Gray;
            _Button_LM_SetUpStartPosition.SymbolSize = 12.0F;
            // 
            // TabItem1
            // 
            _TabItem1.AttachedControl = _TabControlPanel1;
            _TabItem1.Name = "TabItem1";
            resources.ApplyResources(_TabItem1, "TabItem1");
            // 
            // TabControlPanel2
            // 
            _TabControlPanel2.Controls.Add(_LabelX13);
            _TabControlPanel2.Controls.Add(_SwitchButton_UseGlobalObjectBank);
            _TabControlPanel2.Controls.Add(_TableLayoutPanel_ObjectBankSelectorBoxes);
            _TabControlPanel2.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel2, "TabControlPanel2");
            _TabControlPanel2.Name = "TabControlPanel2";
            _TabControlPanel2.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel2.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel2.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel2.Style.GradientAngle = 90;
            _TabControlPanel2.TabItem = _TabItem2;
            // 
            // LabelX13
            // 
            _LabelX13.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX13, "LabelX13");
            _LabelX13.Name = "LabelX13";
            _LabelX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_UseGlobalObjectBank
            // 
            // 
            // 
            // 
            _SwitchButton_UseGlobalObjectBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_SwitchButton_UseGlobalObjectBank, "SwitchButton_UseGlobalObjectBank");
            _SwitchButton_UseGlobalObjectBank.FocusCuesEnabled = false;
            _SwitchButton_UseGlobalObjectBank.Name = "SwitchButton_UseGlobalObjectBank";
            _SwitchButton_UseGlobalObjectBank.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_UseGlobalObjectBank.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_UseGlobalObjectBank.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_UseGlobalObjectBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_UseGlobalObjectBank.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_UseGlobalObjectBank.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_UseGlobalObjectBank.SwitchWidth = 15;
            // 
            // TableLayoutPanel_ObjectBankSelectorBoxes
            // 
            resources.ApplyResources(_TableLayoutPanel_ObjectBankSelectorBoxes, "TableLayoutPanel_ObjectBankSelectorBoxes");
            _TableLayoutPanel_ObjectBankSelectorBoxes.BackColor = Color.Transparent;
            _TableLayoutPanel_ObjectBankSelectorBoxes.Name = "TableLayoutPanel_ObjectBankSelectorBoxes";
            // 
            // TabItem2
            // 
            _TabItem2.AttachedControl = _TabControlPanel2;
            _TabItem2.Name = "TabItem2";
            resources.ApplyResources(_TabItem2, "TabItem2");
            // 
            // Tab_LevelManager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(_GroupBox_LM_Areas);
            Controls.Add(_GroupPanel1);
            Controls.Add(_TabControl_LM_Area);
            Controls.Add(_TabControl_LM_Level);
            Name = "Tab_LevelManager";
            _GroupBox_LM_Areas.ResumeLayout(false);
            _GroupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_TabControl_LM_Area).EndInit();
            _TabControl_LM_Area.ResumeLayout(false);
            _TabControlPanel4.ResumeLayout(false);
            _TabControlPanel6.ResumeLayout(false);
            _TabControlPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_TabControl_LM_Level).EndInit();
            _TabControl_LM_Level.ResumeLayout(false);
            _TabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_PictureBox_BGImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)_NUD_LM_DefaultPositionYRotation).EndInit();
            ((System.ComponentModel.ISupportInitialize)_NUD_LM_DefaultPositionAreaID).EndInit();
            _TabControlPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupBox_LM_Areas;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupBox_LM_Areas
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox_LM_Areas;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox_LM_Areas != null)
                {
                    _GroupBox_LM_Areas.EnabledChanged -= GroupBox_LM_Areas_EnabledChanged;
                }

                _GroupBox_LM_Areas = value;
                if (_GroupBox_LM_Areas != null)
                {
                    _GroupBox_LM_Areas.EnabledChanged += GroupBox_LM_Areas_EnabledChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_LM_AddArea;

        internal DevComponents.DotNetBar.ButtonX Button_LM_AddArea
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LM_AddArea;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LM_AddArea != null)
                {
                    _Button_LM_AddArea.Click -= (_, __) => Button_LM_AddArea_Click();
                }

                _Button_LM_AddArea = value;
                if (_Button_LM_AddArea != null)
                {
                    _Button_LM_AddArea.Click += (_, __) => Button_LM_AddArea_Click();
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_LM_AreaEditor;

        internal DevComponents.DotNetBar.ButtonX Button_LM_AreaEditor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LM_AreaEditor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LM_AreaEditor != null)
                {
                    _Button_LM_AreaEditor.Click -= (_, __) => LM_OpenAreaEditor();
                }

                _Button_LM_AreaEditor = value;
                if (_Button_LM_AreaEditor != null)
                {
                    _Button_LM_AreaEditor.Click += (_, __) => LM_OpenAreaEditor();
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _Button_LM_RemoveArea;

        internal DevComponents.DotNetBar.ButtonItem Button_LM_RemoveArea
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LM_RemoveArea;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LM_RemoveArea != null)
                {
                    _Button_LM_RemoveArea.Click -= (_, __) => Button_LM_RemoveArea_Click();
                }

                _Button_LM_RemoveArea = value;
                if (_Button_LM_RemoveArea != null)
                {
                    _Button_LM_RemoveArea.Click += (_, __) => Button_LM_RemoveArea_Click();
                }
            }
        }

        private Publics.Controls.ItemListBox _ListBoxAdv_LM_Areas;

        internal Publics.Controls.ItemListBox ListBoxAdv_LM_Areas
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListBoxAdv_LM_Areas;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListBoxAdv_LM_Areas != null)
                {
                    _ListBoxAdv_LM_Areas.SelectedIndexChanged -= ListBoxAdv_LM_Areas_SelectedIndexChanged;
                    _ListBoxAdv_LM_Areas.ItemDoubleClick -= ListBoxAdv_LM_Levels_ItemDoubleClick;
                }

                _ListBoxAdv_LM_Areas = value;
                if (_ListBoxAdv_LM_Areas != null)
                {
                    _ListBoxAdv_LM_Areas.SelectedIndexChanged += ListBoxAdv_LM_Areas_SelectedIndexChanged;
                    _ListBoxAdv_LM_Areas.ItemDoubleClick += ListBoxAdv_LM_Levels_ItemDoubleClick;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel1;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel1 != null)
                {
                }

                _GroupPanel1 = value;
                if (_GroupPanel1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_LM_LevelsMore;

        internal DevComponents.DotNetBar.ButtonX ButtonX_LM_LevelsMore
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_LM_LevelsMore;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_LM_LevelsMore != null)
                {
                    _ButtonX_LM_LevelsMore.PopupOpen -= ButtonX_LM_LevelsMore_PopupOpen;
                }

                _ButtonX_LM_LevelsMore = value;
                if (_ButtonX_LM_LevelsMore != null)
                {
                    _ButtonX_LM_LevelsMore.PopupOpen += ButtonX_LM_LevelsMore_PopupOpen;
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
                    _ButtonItem20.Click -= ButtonItem20_Click;
                }

                _ButtonItem20 = value;
                if (_ButtonItem20 != null)
                {
                    _ButtonItem20.Click += ButtonItem20_Click;
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
                    _ButtonItem24.Click -= ButtonItem24_Click;
                }

                _ButtonItem24 = value;
                if (_ButtonItem24 != null)
                {
                    _ButtonItem24.Click += ButtonItem24_Click;
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

        private DevComponents.DotNetBar.ButtonX _Button_LM_AddNewLevel;

        internal DevComponents.DotNetBar.ButtonX Button_LM_AddNewLevel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LM_AddNewLevel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LM_AddNewLevel != null)
                {
                    _Button_LM_AddNewLevel.Click -= (_, __) => Button_LM_AddNewLevel_Click();
                }

                _Button_LM_AddNewLevel = value;
                if (_Button_LM_AddNewLevel != null)
                {
                    _Button_LM_AddNewLevel.Click += (_, __) => Button_LM_AddNewLevel_Click();
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem26;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem26
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem26;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem26 != null)
                {
                    _ButtonItem26.Click -= ButtonItem26_Click;
                }

                _ButtonItem26 = value;
                if (_ButtonItem26 != null)
                {
                    _ButtonItem26.Click += ButtonItem26_Click;
                }
            }
        }

        private Publics.Controls.ItemListBox _ListBoxAdv_LM_Levels;

        internal Publics.Controls.ItemListBox ListBoxAdv_LM_Levels
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListBoxAdv_LM_Levels;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListBoxAdv_LM_Levels != null)
                {
                    _ListBoxAdv_LM_Levels.SelectedItemChanged -= ListBoxAdv_LM_Levels_SelectedIndexChanged;
                    _ListBoxAdv_LM_Levels.ItemRemoved -= ListBoxAdv_LM_Levels_SelectedIndexChanged;
                    _ListBoxAdv_LM_Levels.ItemDoubleClick -= ListBoxAdv_LM_Levels_ItemDoubleClick;
                }

                _ListBoxAdv_LM_Levels = value;
                if (_ListBoxAdv_LM_Levels != null)
                {
                    _ListBoxAdv_LM_Levels.SelectedItemChanged += ListBoxAdv_LM_Levels_SelectedIndexChanged;
                    _ListBoxAdv_LM_Levels.ItemRemoved += ListBoxAdv_LM_Levels_SelectedIndexChanged;
                    _ListBoxAdv_LM_Levels.ItemDoubleClick += ListBoxAdv_LM_Levels_ItemDoubleClick;
                }
            }
        }

        private DevComponents.DotNetBar.TabControl _TabControl_LM_Area;

        internal DevComponents.DotNetBar.TabControl TabControl_LM_Area
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControl_LM_Area;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControl_LM_Area != null)
                {
                }

                _TabControl_LM_Area = value;
                if (_TabControl_LM_Area != null)
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

        private DevComponents.DotNetBar.LabelX _LabelX9;

        internal DevComponents.DotNetBar.LabelX LabelX9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX9 != null)
                {
                }

                _LabelX9 = value;
                if (_LabelX9 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_LM_AreaBG;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_LM_AreaBG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_LM_AreaBG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_LM_AreaBG != null)
                {
                    _ComboBoxEx_LM_AreaBG.SelectedIndexChanged -= (_, __) => ComboBoxEx_LM_AreaBG_SelectedIndexChanged();
                }

                _ComboBoxEx_LM_AreaBG = value;
                if (_ComboBoxEx_LM_AreaBG != null)
                {
                    _ComboBoxEx_LM_AreaBG.SelectedIndexChanged += (_, __) => ComboBoxEx_LM_AreaBG_SelectedIndexChanged();
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem12;

        internal DevComponents.Editors.ComboItem ComboItem12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem12 != null)
                {
                }

                _ComboItem12 = value;
                if (_ComboItem12 != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem13;

        internal DevComponents.Editors.ComboItem ComboItem13
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem13;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem13 != null)
                {
                }

                _ComboItem13 = value;
                if (_ComboItem13 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_LM_ShowMsgID;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_LM_ShowMsgID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_LM_ShowMsgID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_LM_ShowMsgID != null)
                {
                    _TextBoxX_LM_ShowMsgID.TextChanged -= TextBoxX_LM_ShowMsgID_TextChanged;
                }

                _TextBoxX_LM_ShowMsgID = value;
                if (_TextBoxX_LM_ShowMsgID != null)
                {
                    _TextBoxX_LM_ShowMsgID.TextChanged += TextBoxX_LM_ShowMsgID_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX1;

        internal DevComponents.DotNetBar.LabelX LabelX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX1 != null)
                {
                }

                _LabelX1 = value;
                if (_LabelX1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_LM_ShowMsgEnabled;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_LM_ShowMsgEnabled
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_LM_ShowMsgEnabled;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_LM_ShowMsgEnabled != null)
                {
                    _SwitchButton_LM_ShowMsgEnabled.ValueChanged -= SwitchButton_LM_ShowMsgEnabled_ValueChanged;
                }

                _SwitchButton_LM_ShowMsgEnabled = value;
                if (_SwitchButton_LM_ShowMsgEnabled != null)
                {
                    _SwitchButton_LM_ShowMsgEnabled.ValueChanged += SwitchButton_LM_ShowMsgEnabled_ValueChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ColorPickerButton _ColorPickerButton_LM_BackgroundColor;

        internal DevComponents.DotNetBar.ColorPickerButton ColorPickerButton_LM_BackgroundColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColorPickerButton_LM_BackgroundColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColorPickerButton_LM_BackgroundColor != null)
                {
                    _ColorPickerButton_LM_BackgroundColor.SelectedColorChanged -= (_, __) => LM_SaveAreaBackgorund();
                }

                _ColorPickerButton_LM_BackgroundColor = value;
                if (_ColorPickerButton_LM_BackgroundColor != null)
                {
                    _ColorPickerButton_LM_BackgroundColor.SelectedColorChanged += (_, __) => LM_SaveAreaBackgorund();
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX2;

        internal DevComponents.DotNetBar.LabelX LabelX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX2 != null)
                {
                }

                _LabelX2 = value;
                if (_LabelX2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _CheckBoxX_LM_Enable2DCamera;

        internal DevComponents.DotNetBar.Controls.SwitchButton CheckBoxX_LM_Enable2DCamera
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_LM_Enable2DCamera;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_LM_Enable2DCamera != null)
                {
                    _CheckBoxX_LM_Enable2DCamera.ValueChanged -= (_, __) => Controls_HandleToSaveAreaSettings();
                }

                _CheckBoxX_LM_Enable2DCamera = value;
                if (_CheckBoxX_LM_Enable2DCamera != null)
                {
                    _CheckBoxX_LM_Enable2DCamera.ValueChanged += (_, __) => Controls_HandleToSaveAreaSettings();
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX6;

        internal DevComponents.DotNetBar.LabelX LabelX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX6 != null)
                {
                }

                _LabelX6 = value;
                if (_LabelX6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_LM_Music;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_Music
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_LM_Music;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_LM_Music != null)
                {
                    _ComboBox_LM_Music.SelectedIndexChanged -= (_, __) => Controls_HandleToSaveAreaSettings();
                }

                _ComboBox_LM_Music = value;
                if (_ComboBox_LM_Music != null)
                {
                    _ComboBox_LM_Music.SelectedIndexChanged += (_, __) => Controls_HandleToSaveAreaSettings();
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX7;

        internal DevComponents.DotNetBar.LabelX LabelX7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX7 != null)
                {
                }

                _LabelX7 = value;
                if (_LabelX7 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_LM_TerrainTyp;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_TerrainTyp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_LM_TerrainTyp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_LM_TerrainTyp != null)
                {
                    _ComboBox_LM_TerrainTyp.SelectedIndexChanged -= (_, __) => Controls_HandleToSaveAreaSettings();
                }

                _ComboBox_LM_TerrainTyp = value;
                if (_ComboBox_LM_TerrainTyp != null)
                {
                    _ComboBox_LM_TerrainTyp.SelectedIndexChanged += (_, __) => Controls_HandleToSaveAreaSettings();
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX8;

        internal DevComponents.DotNetBar.LabelX LabelX8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX8 != null)
                {
                }

                _LabelX8 = value;
                if (_LabelX8 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_LM_EnvironmentEffects;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_EnvironmentEffects
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_LM_EnvironmentEffects;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_LM_EnvironmentEffects != null)
                {
                    _ComboBox_LM_EnvironmentEffects.SelectedIndexChanged -= (_, __) => Controls_HandleToSaveAreaSettings();
                }

                _ComboBox_LM_EnvironmentEffects = value;
                if (_ComboBox_LM_EnvironmentEffects != null)
                {
                    _ComboBox_LM_EnvironmentEffects.SelectedIndexChanged += (_, __) => Controls_HandleToSaveAreaSettings();
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX11;

        internal DevComponents.DotNetBar.LabelX LabelX11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX11 != null)
                {
                }

                _LabelX11 = value;
                if (_LabelX11 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_LM_CameraPreset;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_CameraPreset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_LM_CameraPreset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_LM_CameraPreset != null)
                {
                    _ComboBox_LM_CameraPreset.SelectedIndexChanged -= (_, __) => Controls_HandleToSaveAreaSettings();
                    _ComboBox_LM_CameraPreset.SelectedIndexChanged -= ComboBox_LM_CameraPreset_SelectedIndexChanged;
                }

                _ComboBox_LM_CameraPreset = value;
                if (_ComboBox_LM_CameraPreset != null)
                {
                    _ComboBox_LM_CameraPreset.SelectedIndexChanged += (_, __) => Controls_HandleToSaveAreaSettings();
                    _ComboBox_LM_CameraPreset.SelectedIndexChanged += ComboBox_LM_CameraPreset_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem4;

        internal DevComponents.DotNetBar.TabItem TabItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem4 != null)
                {
                }

                _TabItem4 = value;
                if (_TabItem4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabControlPanel _TabControlPanel6;

        internal DevComponents.DotNetBar.TabControlPanel TabControlPanel6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControlPanel6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControlPanel6 != null)
                {
                }

                _TabControlPanel6 = value;
                if (_TabControlPanel6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_LM_RemoveSpecial;

        internal DevComponents.DotNetBar.ButtonX Button_LM_RemoveSpecial
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LM_RemoveSpecial;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LM_RemoveSpecial != null)
                {
                    _Button_LM_RemoveSpecial.Click -= Button_LM_RemoveSpecial_Click;
                }

                _Button_LM_RemoveSpecial = value;
                if (_Button_LM_RemoveSpecial != null)
                {
                    _Button_LM_RemoveSpecial.Click += Button_LM_RemoveSpecial_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_LM_AddSpecial;

        internal DevComponents.DotNetBar.ButtonX Button_LM_AddSpecial
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LM_AddSpecial;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LM_AddSpecial != null)
                {
                    _Button_LM_AddSpecial.Click -= Button_LM_AddEditSpecial_Click;
                }

                _Button_LM_AddSpecial = value;
                if (_Button_LM_AddSpecial != null)
                {
                    _Button_LM_AddSpecial.Click += Button_LM_AddEditSpecial_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_LM_EditSpecial;

        internal DevComponents.DotNetBar.ButtonX Button_LM_EditSpecial
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LM_EditSpecial;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LM_EditSpecial != null)
                {
                    _Button_LM_EditSpecial.Click -= Button_LM_AddEditSpecial_Click;
                }

                _Button_LM_EditSpecial = value;
                if (_Button_LM_EditSpecial != null)
                {
                    _Button_LM_EditSpecial.Click += Button_LM_AddEditSpecial_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ListViewEx _ListViewEx_LM_Specials;

        internal DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_LM_Specials
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewEx_LM_Specials;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewEx_LM_Specials != null)
                {
                    _ListViewEx_LM_Specials.SelectedIndexChanged -= ListViewEx_LM_Specials_SelectedIndexChanged;
                }

                _ListViewEx_LM_Specials = value;
                if (_ListViewEx_LM_Specials != null)
                {
                    _ListViewEx_LM_Specials.SelectedIndexChanged += ListViewEx_LM_Specials_SelectedIndexChanged;
                }
            }
        }

        private ColumnHeader _ColumnHeaderA1;

        internal ColumnHeader ColumnHeaderA1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeaderA1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeaderA1 != null)
                {
                }

                _ColumnHeaderA1 = value;
                if (_ColumnHeaderA1 != null)
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

        private ColumnHeader _ColumnHeader3;

        internal ColumnHeader ColumnHeader3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader3 != null)
                {
                }

                _ColumnHeader3 = value;
                if (_ColumnHeader3 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader4;

        internal ColumnHeader ColumnHeader4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader4 != null)
                {
                }

                _ColumnHeader4 = value;
                if (_ColumnHeader4 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader5;

        internal ColumnHeader ColumnHeader5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader5 != null)
                {
                }

                _ColumnHeader5 = value;
                if (_ColumnHeader5 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader6;

        internal ColumnHeader ColumnHeader6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader6 != null)
                {
                }

                _ColumnHeader6 = value;
                if (_ColumnHeader6 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader7;

        internal ColumnHeader ColumnHeader7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader7 != null)
                {
                }

                _ColumnHeader7 = value;
                if (_ColumnHeader7 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeaderA;

        internal ColumnHeader ColumnHeaderA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeaderA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeaderA != null)
                {
                }

                _ColumnHeaderA = value;
                if (_ColumnHeaderA != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem6;

        internal DevComponents.DotNetBar.TabItem TabItem6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem6 != null)
                {
                }

                _TabItem6 = value;
                if (_TabItem6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabControlPanel _TabControlPanel5;

        internal DevComponents.DotNetBar.TabControlPanel TabControlPanel5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControlPanel5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControlPanel5 != null)
                {
                }

                _TabControlPanel5 = value;
                if (_TabControlPanel5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_LM_ScrollTexEditor;

        internal DevComponents.DotNetBar.ButtonX ButtonX_LM_ScrollTexEditor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_LM_ScrollTexEditor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_LM_ScrollTexEditor != null)
                {
                    _ButtonX_LM_ScrollTexEditor.Click -= ButtonX_LM_ScrollTexEditor_Click;
                }

                _ButtonX_LM_ScrollTexEditor = value;
                if (_ButtonX_LM_ScrollTexEditor != null)
                {
                    _ButtonX_LM_ScrollTexEditor.Click += ButtonX_LM_ScrollTexEditor_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_ImportModel;

        internal DevComponents.DotNetBar.ButtonX Button_ImportModel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_ImportModel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_ImportModel != null)
                {
                    _Button_ImportModel.Click -= LM_ImportModel;
                }

                _Button_ImportModel = value;
                if (_Button_ImportModel != null)
                {
                    _Button_ImportModel.Click += LM_ImportModel;
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
                    _ButtonItem9.Click -= LM_ImportModel;
                }

                _ButtonItem9 = value;
                if (_ButtonItem9 != null)
                {
                    _ButtonItem9.Click += LM_ImportModel;
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
                    _ButtonItem13.Click -= LM_ImportModel;
                }

                _ButtonItem13 = value;
                if (_ButtonItem13 != null)
                {
                    _ButtonItem13.Click += LM_ImportModel;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonItem_ExportModel;

        internal DevComponents.DotNetBar.ButtonX ButtonItem_ExportModel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ExportModel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ExportModel != null)
                {
                }

                _ButtonItem_ExportModel = value;
                if (_ButtonItem_ExportModel != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ExportVisualMap;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ExportVisualMap
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ExportVisualMap;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ExportVisualMap != null)
                {
                    _ButtonItem_ExportVisualMap.Click -= ButtonItem_ExportVisualMap_Click;
                }

                _ButtonItem_ExportVisualMap = value;
                if (_ButtonItem_ExportVisualMap != null)
                {
                    _ButtonItem_ExportVisualMap.Click += ButtonItem_ExportVisualMap_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ExportCollisionMap;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ExportCollisionMap
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ExportCollisionMap;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ExportCollisionMap != null)
                {
                    _ButtonItem_ExportCollisionMap.Click -= ButtonItem_ExportCollisionMap_Click;
                }

                _ButtonItem_ExportCollisionMap = value;
                if (_ButtonItem_ExportCollisionMap != null)
                {
                    _ButtonItem_ExportCollisionMap.Click += ButtonItem_ExportCollisionMap_Click;
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem5;

        internal DevComponents.DotNetBar.TabItem TabItem5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem5 != null)
                {
                }

                _TabItem5 = value;
                if (_TabItem5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabControl _TabControl_LM_Level;

        internal DevComponents.DotNetBar.TabControl TabControl_LM_Level
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControl_LM_Level;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControl_LM_Level != null)
                {
                }

                _TabControl_LM_Level = value;
                if (_TabControl_LM_Level != null)
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

        private PictureBox _PictureBox_BGImage;

        internal PictureBox PictureBox_BGImage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox_BGImage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox_BGImage != null)
                {
                }

                _PictureBox_BGImage = value;
                if (_PictureBox_BGImage != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_LM_BGMode;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_LM_BGMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_LM_BGMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_LM_BGMode != null)
                {
                    _ComboBoxEx_LM_BGMode.SelectedIndexChanged -= (_, __) => ComboBoxEx_LM_BGMode_SelectedIndexChanged();
                }

                _ComboBoxEx_LM_BGMode = value;
                if (_ComboBoxEx_LM_BGMode != null)
                {
                    _ComboBoxEx_LM_BGMode.SelectedIndexChanged += (_, __) => ComboBoxEx_LM_BGMode_SelectedIndexChanged();
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem1;

        internal DevComponents.Editors.ComboItem ComboItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem1 != null)
                {
                }

                _ComboItem1 = value;
                if (_ComboItem1 != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem2;

        internal DevComponents.Editors.ComboItem ComboItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem2 != null)
                {
                }

                _ComboItem2 = value;
                if (_ComboItem2 != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem3;

        internal DevComponents.Editors.ComboItem ComboItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem3 != null)
                {
                }

                _ComboItem3 = value;
                if (_ComboItem3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX15;

        internal DevComponents.DotNetBar.LabelX LabelX15
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX15;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX15 != null)
                {
                }

                _LabelX15 = value;
                if (_LabelX15 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX3;

        internal DevComponents.DotNetBar.LabelX LabelX3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX3 != null)
                {
                }

                _LabelX3 = value;
                if (_LabelX3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_LM_LoadLevelBG;

        internal DevComponents.DotNetBar.ButtonX Button_LM_LoadLevelBG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LM_LoadLevelBG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LM_LoadLevelBG != null)
                {
                    _Button_LM_LoadLevelBG.Click -= (_, __) => LM_LoadCustomBackground();
                }

                _Button_LM_LoadLevelBG = value;
                if (_Button_LM_LoadLevelBG != null)
                {
                    _Button_LM_LoadLevelBG.Click += (_, __) => LM_LoadCustomBackground();
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_LM_ActSelector;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_LM_ActSelector
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_LM_ActSelector;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_LM_ActSelector != null)
                {
                    _SwitchButton_LM_ActSelector.ValueChanged -= (_, __) => Controls_HandleToSaveLevelSettings();
                }

                _SwitchButton_LM_ActSelector = value;
                if (_SwitchButton_LM_ActSelector != null)
                {
                    _SwitchButton_LM_ActSelector.ValueChanged += (_, __) => Controls_HandleToSaveLevelSettings();
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX57;

        internal DevComponents.DotNetBar.LabelX LabelX57
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX57;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX57 != null)
                {
                }

                _LabelX57 = value;
                if (_LabelX57 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_LM_HardcodedCameraSettings;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_LM_HardcodedCameraSettings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_LM_HardcodedCameraSettings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_LM_HardcodedCameraSettings != null)
                {
                    _SwitchButton_LM_HardcodedCameraSettings.ValueChanged -= (_, __) => Controls_HandleToSaveLevelSettings();
                }

                _SwitchButton_LM_HardcodedCameraSettings = value;
                if (_SwitchButton_LM_HardcodedCameraSettings != null)
                {
                    _SwitchButton_LM_HardcodedCameraSettings.ValueChanged += (_, __) => Controls_HandleToSaveLevelSettings();
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_LM_SetUpStartPosition;

        internal DevComponents.DotNetBar.ButtonX Button_LM_SetUpStartPosition
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LM_SetUpStartPosition;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LM_SetUpStartPosition != null)
                {
                    _Button_LM_SetUpStartPosition.Click -= Button_LM_SetUpOffsetModelPosition_Click;
                }

                _Button_LM_SetUpStartPosition = value;
                if (_Button_LM_SetUpStartPosition != null)
                {
                    _Button_LM_SetUpStartPosition.Click += Button_LM_SetUpOffsetModelPosition_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX4;

        internal DevComponents.DotNetBar.LabelX LabelX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX4 != null)
                {
                }

                _LabelX4 = value;
                if (_LabelX4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_LM_LevelBG;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_LM_LevelBG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_LM_LevelBG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_LM_LevelBG != null)
                {
                    _ComboBox_LM_LevelBG.SelectedIndexChanged -= (_, __) => LM_SaveGameBackground();
                }

                _ComboBox_LM_LevelBG = value;
                if (_ComboBox_LM_LevelBG != null)
                {
                    _ComboBox_LM_LevelBG.SelectedIndexChanged += (_, __) => LM_SaveGameBackground();
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX24;

        internal DevComponents.DotNetBar.LabelX LabelX24
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX24;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX24 != null)
                {
                }

                _LabelX24 = value;
                if (_LabelX24 != null)
                {
                }
            }
        }

        private NumericUpDown _NUD_LM_DefaultPositionYRotation;

        internal NumericUpDown NUD_LM_DefaultPositionYRotation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NUD_LM_DefaultPositionYRotation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NUD_LM_DefaultPositionYRotation != null)
                {
                    _NUD_LM_DefaultPositionYRotation.ValueChanged -= (_, __) => Controls_HandleToSaveLevelSettings();
                }

                _NUD_LM_DefaultPositionYRotation = value;
                if (_NUD_LM_DefaultPositionYRotation != null)
                {
                    _NUD_LM_DefaultPositionYRotation.ValueChanged += (_, __) => Controls_HandleToSaveLevelSettings();
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX25;

        internal DevComponents.DotNetBar.LabelX LabelX25
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX25;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX25 != null)
                {
                }

                _LabelX25 = value;
                if (_LabelX25 != null)
                {
                }
            }
        }

        private NumericUpDown _NUD_LM_DefaultPositionAreaID;

        internal NumericUpDown NUD_LM_DefaultPositionAreaID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NUD_LM_DefaultPositionAreaID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NUD_LM_DefaultPositionAreaID != null)
                {
                    _NUD_LM_DefaultPositionAreaID.ValueChanged -= (_, __) => Controls_HandleToSaveLevelSettings();
                }

                _NUD_LM_DefaultPositionAreaID = value;
                if (_NUD_LM_DefaultPositionAreaID != null)
                {
                    _NUD_LM_DefaultPositionAreaID.ValueChanged += (_, __) => Controls_HandleToSaveLevelSettings();
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem1;

        internal DevComponents.DotNetBar.TabItem TabItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem1 != null)
                {
                }

                _TabItem1 = value;
                if (_TabItem1 != null)
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

        private DevComponents.DotNetBar.TabItem _TabItem2;

        internal DevComponents.DotNetBar.TabItem TabItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem2 != null)
                {
                }

                _TabItem2 = value;
                if (_TabItem2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_CustomObjects;

        internal DevComponents.DotNetBar.ButtonX ButtonX_CustomObjects
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_CustomObjects;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_CustomObjects != null)
                {
                    _ButtonX_CustomObjects.Click -= ButtonX_CustomObjects_Click;
                }

                _ButtonX_CustomObjects = value;
                if (_ButtonX_CustomObjects != null)
                {
                    _ButtonX_CustomObjects.Click += ButtonX_CustomObjects_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_EditAreaLevelScript;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_EditAreaLevelScript
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_EditAreaLevelScript;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_EditAreaLevelScript != null)
                {
                    _ButtonItem_EditAreaLevelScript.Click -= ButtonItem_EditAreaLevelScript_Click;
                }

                _ButtonItem_EditAreaLevelScript = value;
                if (_ButtonItem_EditAreaLevelScript != null)
                {
                    _ButtonItem_EditAreaLevelScript.Click += ButtonItem_EditAreaLevelScript_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem2_EditGeolayoutScript;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem2_EditGeolayoutScript
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem2_EditGeolayoutScript;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem2_EditGeolayoutScript != null)
                {
                    _ButtonItem2_EditGeolayoutScript.Click -= ButtonItem2_EditGeolayoutScript_Click;
                }

                _ButtonItem2_EditGeolayoutScript = value;
                if (_ButtonItem2_EditGeolayoutScript != null)
                {
                    _ButtonItem2_EditGeolayoutScript.Click += ButtonItem2_EditGeolayoutScript_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Area_CountOfTexAnimations;

        internal DevComponents.DotNetBar.LabelX LabelX_Area_CountOfTexAnimations
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Area_CountOfTexAnimations;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Area_CountOfTexAnimations != null)
                {
                }

                _LabelX_Area_CountOfTexAnimations = value;
                if (_LabelX_Area_CountOfTexAnimations != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX10;

        internal DevComponents.DotNetBar.LabelX LabelX10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX10 != null)
                {
                }

                _LabelX10 = value;
                if (_LabelX10 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX5;

        internal DevComponents.DotNetBar.LabelX LabelX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX5 != null)
                {
                }

                _LabelX5 = value;
                if (_LabelX5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.Line _Line2;

        internal DevComponents.DotNetBar.Controls.Line Line2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Line2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Line2 != null)
                {
                }

                _Line2 = value;
                if (_Line2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Area_CountOfCustomObjects;

        internal DevComponents.DotNetBar.LabelX LabelX_Area_CountOfCustomObjects
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Area_CountOfCustomObjects;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Area_CountOfCustomObjects != null)
                {
                }

                _LabelX_Area_CountOfCustomObjects = value;
                if (_LabelX_Area_CountOfCustomObjects != null)
                {
                }
            }
        }

        private TableLayoutPanel _TableLayoutPanel_ObjectBankSelectorBoxes;

        internal TableLayoutPanel TableLayoutPanel_ObjectBankSelectorBoxes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel_ObjectBankSelectorBoxes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel_ObjectBankSelectorBoxes != null)
                {
                }

                _TableLayoutPanel_ObjectBankSelectorBoxes = value;
                if (_TableLayoutPanel_ObjectBankSelectorBoxes != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ImportArea;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ImportArea
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ImportArea;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ImportArea != null)
                {
                    _ButtonItem_ImportArea.Click -= ButtonItem_ImportArea_Click;
                }

                _ButtonItem_ImportArea = value;
                if (_ButtonItem_ImportArea != null)
                {
                    _ButtonItem_ImportArea.Click += ButtonItem_ImportArea_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_TargetLevel;

        internal DevComponents.DotNetBar.LabelX LabelX_TargetLevel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_TargetLevel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_TargetLevel != null)
                {
                }

                _LabelX_TargetLevel = value;
                if (_LabelX_TargetLevel != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX12;

        internal DevComponents.DotNetBar.LabelX LabelX12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX12 != null)
                {
                }

                _LabelX12 = value;
                if (_LabelX12 != null)
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

        private DevComponents.DotNetBar.LabelX _LabelX13;

        internal DevComponents.DotNetBar.LabelX LabelX13
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX13;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX13 != null)
                {
                }

                _LabelX13 = value;
                if (_LabelX13 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_UseGlobalObjectBank;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_UseGlobalObjectBank
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_UseGlobalObjectBank;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_UseGlobalObjectBank != null)
                {
                    _SwitchButton_UseGlobalObjectBank.ValueChanged -= (_, __) => Controls_HandleToSaveLevelSettings();
                    _SwitchButton_UseGlobalObjectBank.ValueChanged -= (_, __) => SwitchButton_UseGlobalObjectBank_ValueChanged();
                }

                _SwitchButton_UseGlobalObjectBank = value;
                if (_SwitchButton_UseGlobalObjectBank != null)
                {
                    _SwitchButton_UseGlobalObjectBank.ValueChanged += (_, __) => Controls_HandleToSaveLevelSettings();
                    _SwitchButton_UseGlobalObjectBank.ValueChanged += (_, __) => SwitchButton_UseGlobalObjectBank_ValueChanged();
                }
            }
        }
    }
}