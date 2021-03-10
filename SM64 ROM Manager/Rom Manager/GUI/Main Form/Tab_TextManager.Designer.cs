using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Tab_TextManager : UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_TextManager));
            this.GroupPanel_TM_DialogProps = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.LabelX22 = new DevComponents.DotNetBar.LabelX();
            this.LabelX21 = new DevComponents.DotNetBar.LabelX();
            this.ComboBoxEx_TM_DialogPosY = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem10 = new DevComponents.Editors.ComboItem();
            this.ComboItem8 = new DevComponents.Editors.ComboItem();
            this.IntegerInput_TM_DialogSize = new DevComponents.Editors.IntegerInput();
            this.ComboBoxEx_SoundEffect = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboBoxEx_TM_DialogPosX = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem5 = new DevComponents.Editors.ComboItem();
            this.ComboItem6 = new DevComponents.Editors.ComboItem();
            this.ComboItem7 = new DevComponents.Editors.ComboItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.LabelX18 = new DevComponents.DotNetBar.LabelX();
            this.TabStrip_TextTable = new DevComponents.DotNetBar.TabStrip();
            this.Line_TM_Green = new DevComponents.DotNetBar.Controls.Line();
            this.Line_TM_Warning1 = new DevComponents.DotNetBar.Controls.Line();
            this.Line_TM_Warning2 = new DevComponents.DotNetBar.Controls.Line();
            this.TextBoxX_TM_TextEditor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Bar_AddRemoveItems = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_AddTextItem = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveTextItem = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem21 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ClearAllItems = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ExportCurTable = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ExportAllTables = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImportFrom = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_TextProfile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CreateProfile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ResetProfile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ManageProfile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ExportProfile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImportProfile = new DevComponents.DotNetBar.ButtonItem();
            this.Bar_TextOptions = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_AddButtons = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem19 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TextBoxX_ItemDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.advTree_TextEntries = new DevComponents.AdvTree.AdvTree();
            this.columnHeader_Number = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_Description = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_Message = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.GroupPanel_TM_DialogProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_TM_DialogSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_AddRemoveItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_TextOptions)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree_TextEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupPanel_TM_DialogProps
            // 
            this.GroupPanel_TM_DialogProps.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel_TM_DialogProps.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupPanel_TM_DialogProps.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupPanel_TM_DialogProps.Controls.Add(this.LabelX22);
            this.GroupPanel_TM_DialogProps.Controls.Add(this.LabelX21);
            this.GroupPanel_TM_DialogProps.Controls.Add(this.ComboBoxEx_TM_DialogPosY);
            this.GroupPanel_TM_DialogProps.Controls.Add(this.IntegerInput_TM_DialogSize);
            this.GroupPanel_TM_DialogProps.Controls.Add(this.ComboBoxEx_SoundEffect);
            this.GroupPanel_TM_DialogProps.Controls.Add(this.ComboBoxEx_TM_DialogPosX);
            this.GroupPanel_TM_DialogProps.Controls.Add(this.labelX1);
            this.GroupPanel_TM_DialogProps.Controls.Add(this.LabelX18);
            this.GroupPanel_TM_DialogProps.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.GroupPanel_TM_DialogProps, "GroupPanel_TM_DialogProps");
            this.GroupPanel_TM_DialogProps.Name = "GroupPanel_TM_DialogProps";
            // 
            // 
            // 
            this.GroupPanel_TM_DialogProps.Style.BackColorGradientAngle = 90;
            this.GroupPanel_TM_DialogProps.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel_TM_DialogProps.Style.BorderBottomWidth = 1;
            this.GroupPanel_TM_DialogProps.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel_TM_DialogProps.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel_TM_DialogProps.Style.BorderLeftWidth = 1;
            this.GroupPanel_TM_DialogProps.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel_TM_DialogProps.Style.BorderRightWidth = 1;
            this.GroupPanel_TM_DialogProps.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel_TM_DialogProps.Style.BorderTopWidth = 1;
            this.GroupPanel_TM_DialogProps.Style.CornerDiameter = 4;
            this.GroupPanel_TM_DialogProps.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupPanel_TM_DialogProps.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel_TM_DialogProps.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel_TM_DialogProps.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupPanel_TM_DialogProps.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupPanel_TM_DialogProps.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // LabelX22
            // 
            // 
            // 
            // 
            this.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX22, "LabelX22");
            this.LabelX22.Name = "LabelX22";
            // 
            // LabelX21
            // 
            // 
            // 
            // 
            this.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX21, "LabelX21");
            this.LabelX21.Name = "LabelX21";
            // 
            // ComboBoxEx_TM_DialogPosY
            // 
            this.ComboBoxEx_TM_DialogPosY.DisplayMember = "Text";
            this.ComboBoxEx_TM_DialogPosY.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_TM_DialogPosY.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_TM_DialogPosY.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBoxEx_TM_DialogPosY, "ComboBoxEx_TM_DialogPosY");
            this.ComboBoxEx_TM_DialogPosY.Items.AddRange(new object[] {
            this.ComboItem10,
            this.ComboItem8});
            this.ComboBoxEx_TM_DialogPosY.Name = "ComboBoxEx_TM_DialogPosY";
            this.ComboBoxEx_TM_DialogPosY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_TM_DialogPosY.TextChanged += new System.EventHandler(this.TM_CheckComboBoxText);
            // 
            // ComboItem10
            // 
            resources.ApplyResources(this.ComboItem10, "ComboItem10");
            // 
            // ComboItem8
            // 
            resources.ApplyResources(this.ComboItem8, "ComboItem8");
            // 
            // IntegerInput_TM_DialogSize
            // 
            // 
            // 
            // 
            this.IntegerInput_TM_DialogSize.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_TM_DialogSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_TM_DialogSize.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.IntegerInput_TM_DialogSize, "IntegerInput_TM_DialogSize");
            this.IntegerInput_TM_DialogSize.MaxValue = 255;
            this.IntegerInput_TM_DialogSize.MinValue = 1;
            this.IntegerInput_TM_DialogSize.Name = "IntegerInput_TM_DialogSize";
            this.IntegerInput_TM_DialogSize.ShowUpDown = true;
            this.IntegerInput_TM_DialogSize.Value = 1;
            this.IntegerInput_TM_DialogSize.ValueChanged += new System.EventHandler(this.IntegerInput_TM_DialogSize_ValueChanged);
            // 
            // ComboBoxEx_SoundEffect
            // 
            this.ComboBoxEx_SoundEffect.DisplayMember = "Text";
            this.ComboBoxEx_SoundEffect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_SoundEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx_SoundEffect.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_SoundEffect.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBoxEx_SoundEffect, "ComboBoxEx_SoundEffect");
            this.ComboBoxEx_SoundEffect.Name = "ComboBoxEx_SoundEffect";
            this.ComboBoxEx_SoundEffect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_SoundEffect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx_SoundEffect_SelectedIndexChanged);
            this.ComboBoxEx_SoundEffect.TextChanged += new System.EventHandler(this.TM_CheckComboBoxText);
            // 
            // ComboBoxEx_TM_DialogPosX
            // 
            this.ComboBoxEx_TM_DialogPosX.DisplayMember = "Text";
            this.ComboBoxEx_TM_DialogPosX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_TM_DialogPosX.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_TM_DialogPosX.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBoxEx_TM_DialogPosX, "ComboBoxEx_TM_DialogPosX");
            this.ComboBoxEx_TM_DialogPosX.Items.AddRange(new object[] {
            this.ComboItem5,
            this.ComboItem6,
            this.ComboItem7});
            this.ComboBoxEx_TM_DialogPosX.Name = "ComboBoxEx_TM_DialogPosX";
            this.ComboBoxEx_TM_DialogPosX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_TM_DialogPosX.TextChanged += new System.EventHandler(this.TM_CheckComboBoxText);
            // 
            // ComboItem5
            // 
            resources.ApplyResources(this.ComboItem5, "ComboItem5");
            // 
            // ComboItem6
            // 
            resources.ApplyResources(this.ComboItem6, "ComboItem6");
            // 
            // ComboItem7
            // 
            resources.ApplyResources(this.ComboItem7, "ComboItem7");
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            // 
            // LabelX18
            // 
            // 
            // 
            // 
            this.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX18, "LabelX18");
            this.LabelX18.Name = "LabelX18";
            // 
            // TabStrip_TextTable
            // 
            this.TabStrip_TextTable.AutoSelectAttachedControl = true;
            this.TabStrip_TextTable.CanReorderTabs = false;
            this.TabStrip_TextTable.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.TabStrip_TextTable.CloseButtonVisible = true;
            this.TabStrip_TextTable.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.TabStrip_TextTable, "TabStrip_TextTable");
            this.TabStrip_TextTable.ForeColor = System.Drawing.Color.Black;
            this.TabStrip_TextTable.Name = "TabStrip_TextTable";
            this.TabStrip_TextTable.SelectedTab = null;
            this.TabStrip_TextTable.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.TabStrip_TextTable.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.TabStrip_TextTable.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.TabStrip1_SelectedTabChanged);
            // 
            // Line_TM_Green
            // 
            resources.ApplyResources(this.Line_TM_Green, "Line_TM_Green");
            this.Line_TM_Green.BackColor = System.Drawing.Color.Transparent;
            this.Line_TM_Green.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Line_TM_Green.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Line_TM_Green.ForeColor = System.Drawing.Color.YellowGreen;
            this.Line_TM_Green.Name = "Line_TM_Green";
            this.Line_TM_Green.VerticalLine = true;
            // 
            // Line_TM_Warning1
            // 
            resources.ApplyResources(this.Line_TM_Warning1, "Line_TM_Warning1");
            this.Line_TM_Warning1.BackColor = System.Drawing.Color.Transparent;
            this.Line_TM_Warning1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Line_TM_Warning1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Line_TM_Warning1.ForeColor = System.Drawing.Color.Orange;
            this.Line_TM_Warning1.Name = "Line_TM_Warning1";
            this.Line_TM_Warning1.VerticalLine = true;
            // 
            // Line_TM_Warning2
            // 
            resources.ApplyResources(this.Line_TM_Warning2, "Line_TM_Warning2");
            this.Line_TM_Warning2.BackColor = System.Drawing.Color.Transparent;
            this.Line_TM_Warning2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Line_TM_Warning2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Line_TM_Warning2.ForeColor = System.Drawing.Color.Red;
            this.Line_TM_Warning2.Name = "Line_TM_Warning2";
            this.Line_TM_Warning2.VerticalLine = true;
            // 
            // TextBoxX_TM_TextEditor
            // 
            this.TextBoxX_TM_TextEditor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_TM_TextEditor.Border.Class = "TextBoxBorder";
            this.TextBoxX_TM_TextEditor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_TM_TextEditor.DisabledBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.TextBoxX_TM_TextEditor, "TextBoxX_TM_TextEditor");
            this.TextBoxX_TM_TextEditor.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_TM_TextEditor.Name = "TextBoxX_TM_TextEditor";
            this.TextBoxX_TM_TextEditor.PreventEnterBeep = true;
            this.TextBoxX_TM_TextEditor.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TextBoxX_TM_TextEditor.SizeChanged += new System.EventHandler(this.TextBoxX_TM_TextEditor_SizeChanged);
            this.TextBoxX_TM_TextEditor.TextChanged += new System.EventHandler(this.TextBoxX_TM_TextEditor_TextChanged);
            // 
            // Bar_AddRemoveItems
            // 
            resources.ApplyResources(this.Bar_AddRemoveItems, "Bar_AddRemoveItems");
            this.Bar_AddRemoveItems.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Bar_AddRemoveItems.AntiAlias = true;
            this.Bar_AddRemoveItems.IsMaximized = false;
            this.Bar_AddRemoveItems.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_AddTextItem,
            this.ButtonItem_RemoveTextItem,
            this.buttonItem21});
            this.Bar_AddRemoveItems.MenuBar = true;
            this.Bar_AddRemoveItems.Name = "Bar_AddRemoveItems";
            this.Bar_AddRemoveItems.Stretch = true;
            this.Bar_AddRemoveItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.Bar_AddRemoveItems.TabStop = false;
            // 
            // ButtonItem_AddTextItem
            // 
            this.ButtonItem_AddTextItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_AddTextItem.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_AddTextItem.Name = "ButtonItem_AddTextItem";
            resources.ApplyResources(this.ButtonItem_AddTextItem, "ButtonItem_AddTextItem");
            this.ButtonItem_AddTextItem.Click += new System.EventHandler(this.ButtonItem_AddTextItem_Click);
            // 
            // ButtonItem_RemoveTextItem
            // 
            this.ButtonItem_RemoveTextItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_RemoveTextItem.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveTextItem.Name = "ButtonItem_RemoveTextItem";
            resources.ApplyResources(this.ButtonItem_RemoveTextItem, "ButtonItem_RemoveTextItem");
            this.ButtonItem_RemoveTextItem.Click += new System.EventHandler(this.ButtonItem_RemoveTextItem_Click);
            // 
            // buttonItem21
            // 
            this.buttonItem21.AutoExpandOnClick = true;
            this.buttonItem21.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_expand_arrow_16px;
            this.buttonItem21.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItem21.Name = "buttonItem21";
            this.buttonItem21.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ClearAllItems,
            this.ButtonItem_ExportCurTable,
            this.ButtonItem_ExportAllTables,
            this.ButtonItem_ImportFrom,
            this.ButtonItem_TextProfile});
            // 
            // ButtonItem_ClearAllItems
            // 
            this.ButtonItem_ClearAllItems.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_ClearAllItems.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_refresh_16px;
            this.ButtonItem_ClearAllItems.Name = "ButtonItem_ClearAllItems";
            resources.ApplyResources(this.ButtonItem_ClearAllItems, "ButtonItem_ClearAllItems");
            this.ButtonItem_ClearAllItems.Click += new System.EventHandler(this.ButtonItem_ClearAllItems_Click);
            // 
            // ButtonItem_ExportCurTable
            // 
            this.ButtonItem_ExportCurTable.BeginGroup = true;
            this.ButtonItem_ExportCurTable.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_export_16px;
            this.ButtonItem_ExportCurTable.Name = "ButtonItem_ExportCurTable";
            resources.ApplyResources(this.ButtonItem_ExportCurTable, "ButtonItem_ExportCurTable");
            this.ButtonItem_ExportCurTable.Click += new System.EventHandler(this.ButtonItem_ExportCurTable_Click);
            // 
            // ButtonItem_ExportAllTables
            // 
            this.ButtonItem_ExportAllTables.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_export_16px;
            this.ButtonItem_ExportAllTables.Name = "ButtonItem_ExportAllTables";
            resources.ApplyResources(this.ButtonItem_ExportAllTables, "ButtonItem_ExportAllTables");
            this.ButtonItem_ExportAllTables.Click += new System.EventHandler(this.ButtonItem_ExportAllTables_Click);
            // 
            // ButtonItem_ImportFrom
            // 
            this.ButtonItem_ImportFrom.BeginGroup = true;
            this.ButtonItem_ImportFrom.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_import_16px;
            this.ButtonItem_ImportFrom.Name = "ButtonItem_ImportFrom";
            resources.ApplyResources(this.ButtonItem_ImportFrom, "ButtonItem_ImportFrom");
            this.ButtonItem_ImportFrom.Click += new System.EventHandler(this.ButtonItem_ImportFrom_Click);
            // 
            // ButtonItem_TextProfile
            // 
            this.ButtonItem_TextProfile.BeginGroup = true;
            this.ButtonItem_TextProfile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_database_16px;
            this.ButtonItem_TextProfile.Name = "ButtonItem_TextProfile";
            this.ButtonItem_TextProfile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_CreateProfile,
            this.ButtonItem_ResetProfile,
            this.ButtonItem_ManageProfile,
            this.ButtonItem_ExportProfile,
            this.ButtonItem_ImportProfile});
            resources.ApplyResources(this.ButtonItem_TextProfile, "ButtonItem_TextProfile");
            // 
            // ButtonItem_CreateProfile
            // 
            this.ButtonItem_CreateProfile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_data_recovery_16px;
            this.ButtonItem_CreateProfile.Name = "ButtonItem_CreateProfile";
            resources.ApplyResources(this.ButtonItem_CreateProfile, "ButtonItem_CreateProfile");
            this.ButtonItem_CreateProfile.Click += new System.EventHandler(this.ButtonItem_CreateProfile_Click);
            // 
            // ButtonItem_ResetProfile
            // 
            this.ButtonItem_ResetProfile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_data_backup_16px;
            this.ButtonItem_ResetProfile.Name = "ButtonItem_ResetProfile";
            resources.ApplyResources(this.ButtonItem_ResetProfile, "ButtonItem_ResetProfile");
            this.ButtonItem_ResetProfile.Click += new System.EventHandler(this.ButtonItem_ResetProfile_Click);
            // 
            // ButtonItem_ManageProfile
            // 
            this.ButtonItem_ManageProfile.BeginGroup = true;
            this.ButtonItem_ManageProfile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_database_administrator_16px;
            this.ButtonItem_ManageProfile.Name = "ButtonItem_ManageProfile";
            resources.ApplyResources(this.ButtonItem_ManageProfile, "ButtonItem_ManageProfile");
            this.ButtonItem_ManageProfile.Click += new System.EventHandler(this.ButtonItem_ManageProfile_Click);
            // 
            // ButtonItem_ExportProfile
            // 
            this.ButtonItem_ExportProfile.BeginGroup = true;
            this.ButtonItem_ExportProfile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_database_export_16px;
            this.ButtonItem_ExportProfile.Name = "ButtonItem_ExportProfile";
            resources.ApplyResources(this.ButtonItem_ExportProfile, "ButtonItem_ExportProfile");
            this.ButtonItem_ExportProfile.Click += new System.EventHandler(this.ButtonItem_ExportProfile_Click);
            // 
            // ButtonItem_ImportProfile
            // 
            this.ButtonItem_ImportProfile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_database_restore_16px;
            this.ButtonItem_ImportProfile.Name = "ButtonItem_ImportProfile";
            resources.ApplyResources(this.ButtonItem_ImportProfile, "ButtonItem_ImportProfile");
            this.ButtonItem_ImportProfile.Click += new System.EventHandler(this.ButtonItem_ImportProfile_Click);
            // 
            // Bar_TextOptions
            // 
            resources.ApplyResources(this.Bar_TextOptions, "Bar_TextOptions");
            this.Bar_TextOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.Bar_TextOptions.AntiAlias = true;
            this.Bar_TextOptions.IsMaximized = false;
            this.Bar_TextOptions.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_AddButtons,
            this.ButtonItem9,
            this.ButtonItem10});
            this.Bar_TextOptions.Name = "Bar_TextOptions";
            this.Bar_TextOptions.Stretch = true;
            this.Bar_TextOptions.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.Bar_TextOptions.TabStop = false;
            // 
            // ButtonItem_AddButtons
            // 
            this.ButtonItem_AddButtons.AutoExpandOnClick = true;
            this.ButtonItem_AddButtons.Name = "ButtonItem_AddButtons";
            this.ButtonItem_AddButtons.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem4,
            this.ButtonItem1,
            this.ButtonItem5,
            this.ButtonItem6,
            this.ButtonItem7});
            resources.ApplyResources(this.ButtonItem_AddButtons, "ButtonItem_AddButtons");
            // 
            // ButtonItem4
            // 
            this.ButtonItem4.Name = "ButtonItem4";
            resources.ApplyResources(this.ButtonItem4, "ButtonItem4");
            this.ButtonItem4.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.Name = "ButtonItem1";
            resources.ApplyResources(this.ButtonItem1, "ButtonItem1");
            this.ButtonItem1.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem5
            // 
            this.ButtonItem5.Name = "ButtonItem5";
            resources.ApplyResources(this.ButtonItem5, "ButtonItem5");
            this.ButtonItem5.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem6
            // 
            this.ButtonItem6.Name = "ButtonItem6";
            resources.ApplyResources(this.ButtonItem6, "ButtonItem6");
            this.ButtonItem6.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem7
            // 
            this.ButtonItem7.Name = "ButtonItem7";
            resources.ApplyResources(this.ButtonItem7, "ButtonItem7");
            this.ButtonItem7.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem9
            // 
            this.ButtonItem9.AutoExpandOnClick = true;
            this.ButtonItem9.Name = "ButtonItem9";
            this.ButtonItem9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem8,
            this.ButtonItem11,
            this.ButtonItem12,
            this.ButtonItem13});
            resources.ApplyResources(this.ButtonItem9, "ButtonItem9");
            // 
            // ButtonItem8
            // 
            this.ButtonItem8.Name = "ButtonItem8";
            resources.ApplyResources(this.ButtonItem8, "ButtonItem8");
            this.ButtonItem8.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem11
            // 
            this.ButtonItem11.Name = "ButtonItem11";
            resources.ApplyResources(this.ButtonItem11, "ButtonItem11");
            this.ButtonItem11.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem12
            // 
            this.ButtonItem12.Name = "ButtonItem12";
            resources.ApplyResources(this.ButtonItem12, "ButtonItem12");
            this.ButtonItem12.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem13
            // 
            this.ButtonItem13.Name = "ButtonItem13";
            resources.ApplyResources(this.ButtonItem13, "ButtonItem13");
            this.ButtonItem13.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem10
            // 
            this.ButtonItem10.AutoExpandOnClick = true;
            this.ButtonItem10.Name = "ButtonItem10";
            this.ButtonItem10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.buttonItem3,
            this.ButtonItem15,
            this.ButtonItem14,
            this.ButtonItem16,
            this.ButtonItem17,
            this.ButtonItem18,
            this.ButtonItem19,
            this.ButtonItem20});
            resources.ApplyResources(this.ButtonItem10, "ButtonItem10");
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            resources.ApplyResources(this.buttonItem2, "buttonItem2");
            this.buttonItem2.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            resources.ApplyResources(this.buttonItem3, "buttonItem3");
            this.buttonItem3.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem15
            // 
            this.ButtonItem15.Name = "ButtonItem15";
            resources.ApplyResources(this.ButtonItem15, "ButtonItem15");
            this.ButtonItem15.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem14
            // 
            this.ButtonItem14.Name = "ButtonItem14";
            resources.ApplyResources(this.ButtonItem14, "ButtonItem14");
            this.ButtonItem14.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem16
            // 
            this.ButtonItem16.Name = "ButtonItem16";
            resources.ApplyResources(this.ButtonItem16, "ButtonItem16");
            this.ButtonItem16.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem17
            // 
            this.ButtonItem17.Name = "ButtonItem17";
            resources.ApplyResources(this.ButtonItem17, "ButtonItem17");
            this.ButtonItem17.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem18
            // 
            this.ButtonItem18.Name = "ButtonItem18";
            resources.ApplyResources(this.ButtonItem18, "ButtonItem18");
            this.ButtonItem18.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem19
            // 
            this.ButtonItem19.Name = "ButtonItem19";
            resources.ApplyResources(this.ButtonItem19, "ButtonItem19");
            this.ButtonItem19.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // ButtonItem20
            // 
            this.ButtonItem20.Name = "ButtonItem20";
            resources.ApplyResources(this.ButtonItem20, "ButtonItem20");
            this.ButtonItem20.Click += new System.EventHandler(this.ButtonItemAddSpecialChar_Click);
            // 
            // Panel1
            // 
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.Line_TM_Warning2);
            this.Panel1.Controls.Add(this.Line_TM_Green);
            this.Panel1.Controls.Add(this.Line_TM_Warning1);
            this.Panel1.Controls.Add(this.TextBoxX_TM_TextEditor);
            this.Panel1.Controls.Add(this.GroupPanel_TM_DialogProps);
            this.Panel1.Controls.Add(this.TextBoxX_ItemDescription);
            this.Panel1.Controls.Add(this.Bar_TextOptions);
            this.Panel1.Name = "Panel1";
            // 
            // TextBoxX_ItemDescription
            // 
            // 
            // 
            // 
            this.TextBoxX_ItemDescription.Border.Class = "TextBoxBorder";
            this.TextBoxX_ItemDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.TextBoxX_ItemDescription, "TextBoxX_ItemDescription");
            this.TextBoxX_ItemDescription.Name = "TextBoxX_ItemDescription";
            this.TextBoxX_ItemDescription.PreventEnterBeep = true;
            this.TextBoxX_ItemDescription.ReadOnly = true;
            this.TextBoxX_ItemDescription.TextChanged += new System.EventHandler(this.TextBoxX_ItemDescription_TextChanged);
            // 
            // Panel3
            // 
            resources.ApplyResources(this.Panel3, "Panel3");
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.Controls.Add(this.advTree_TextEntries);
            this.Panel3.Controls.Add(this.TabStrip_TextTable);
            this.Panel3.Controls.Add(this.Bar_AddRemoveItems);
            this.Panel3.Name = "Panel3";
            // 
            // advTree_TextEntries
            // 
            this.advTree_TextEntries.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree_TextEntries.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree_TextEntries.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree_TextEntries.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree_TextEntries.Columns.Add(this.columnHeader_Number);
            this.advTree_TextEntries.Columns.Add(this.columnHeader_Description);
            this.advTree_TextEntries.Columns.Add(this.columnHeader_Message);
            resources.ApplyResources(this.advTree_TextEntries, "advTree_TextEntries");
            this.advTree_TextEntries.DragDropEnabled = false;
            this.advTree_TextEntries.ExpandWidth = 2;
            this.advTree_TextEntries.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree_TextEntries.Name = "advTree_TextEntries";
            this.advTree_TextEntries.NodesConnector = this.nodeConnector1;
            this.advTree_TextEntries.NodeStyle = this.elementStyle1;
            this.advTree_TextEntries.PathSeparator = ";";
            this.advTree_TextEntries.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
            this.advTree_TextEntries.Styles.Add(this.elementStyle1);
            this.advTree_TextEntries.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree1_AfterNodeSelect);
            // 
            // columnHeader_Number
            // 
            this.columnHeader_Number.Name = "columnHeader_Number";
            resources.ApplyResources(this.columnHeader_Number, "columnHeader_Number");
            this.columnHeader_Number.Width.Absolute = 50;
            // 
            // columnHeader_Description
            // 
            this.columnHeader_Description.Name = "columnHeader_Description";
            resources.ApplyResources(this.columnHeader_Description, "columnHeader_Description");
            this.columnHeader_Description.Width.Absolute = 150;
            // 
            // columnHeader_Message
            // 
            this.columnHeader_Message.Name = "columnHeader_Message";
            resources.ApplyResources(this.columnHeader_Message, "columnHeader_Message");
            this.columnHeader_Message.Width.Absolute = 180;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // Tab_TextManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Name = "Tab_TextManager";
            this.GroupPanel_TM_DialogProps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_TM_DialogSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_AddRemoveItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_TextOptions)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree_TextEntries)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel_TM_DialogProps;

        private DevComponents.DotNetBar.LabelX LabelX22;

        private DevComponents.DotNetBar.LabelX LabelX21;

        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_TM_DialogPosY;

        private DevComponents.Editors.ComboItem ComboItem10;

        private DevComponents.Editors.ComboItem ComboItem8;

        private DevComponents.Editors.IntegerInput IntegerInput_TM_DialogSize;

        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_TM_DialogPosX;

        private DevComponents.Editors.ComboItem ComboItem5;

        private DevComponents.Editors.ComboItem ComboItem6;

        private DevComponents.Editors.ComboItem ComboItem7;

        private DevComponents.DotNetBar.LabelX LabelX18;

        private DevComponents.DotNetBar.TabStrip TabStrip_TextTable;

        internal DevComponents.DotNetBar.Controls.Line Line_TM_Green;

        internal DevComponents.DotNetBar.Controls.Line Line_TM_Warning1;

        internal DevComponents.DotNetBar.Controls.Line Line_TM_Warning2;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_TM_TextEditor;

        private DevComponents.DotNetBar.Bar Bar_AddRemoveItems;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_AddTextItem;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveTextItem;

        private DevComponents.DotNetBar.Bar Bar_TextOptions;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_AddButtons;

        private DevComponents.DotNetBar.ButtonItem ButtonItem4;

        private DevComponents.DotNetBar.ButtonItem ButtonItem1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem5;

        private DevComponents.DotNetBar.ButtonItem ButtonItem6;

        private DevComponents.DotNetBar.ButtonItem ButtonItem7;

        private DevComponents.DotNetBar.ButtonItem ButtonItem9;

        private DevComponents.DotNetBar.ButtonItem ButtonItem10;

        private DevComponents.DotNetBar.ButtonItem ButtonItem8;

        private DevComponents.DotNetBar.ButtonItem ButtonItem11;

        private DevComponents.DotNetBar.ButtonItem ButtonItem12;

        private DevComponents.DotNetBar.ButtonItem ButtonItem13;

        private DevComponents.DotNetBar.ButtonItem ButtonItem14;

        private DevComponents.DotNetBar.ButtonItem ButtonItem15;

        private DevComponents.DotNetBar.ButtonItem ButtonItem16;

        private DevComponents.DotNetBar.ButtonItem ButtonItem17;

        private DevComponents.DotNetBar.ButtonItem ButtonItem18;

        private DevComponents.DotNetBar.ButtonItem ButtonItem19;

        private DevComponents.DotNetBar.ButtonItem ButtonItem20;

        private Panel Panel1;

        private Panel Panel3;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ClearAllItems;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ItemDescription;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_SoundEffect;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem buttonItem21;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ExportCurTable;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ExportAllTables;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportFrom;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_TextProfile;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ResetProfile;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ManageProfile;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportProfile;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ExportProfile;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_CreateProfile;
        private DevComponents.AdvTree.AdvTree advTree_TextEntries;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Number;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Description;
        private DevComponents.AdvTree.ColumnHeader columnHeader_Message;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}