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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_TextManager));
            _GroupPanel_TM_DialogProps = new DevComponents.DotNetBar.Controls.GroupPanel();
            _LabelX22 = new DevComponents.DotNetBar.LabelX();
            _LabelX21 = new DevComponents.DotNetBar.LabelX();
            _ComboBoxEx_TM_DialogPosY = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_TM_DialogPosY.TextChanged += new EventHandler(TM_CheckComboBoxText);
            _ComboItem10 = new DevComponents.Editors.ComboItem();
            _ComboItem8 = new DevComponents.Editors.ComboItem();
            _IntegerInput_TM_DialogSize = new DevComponents.Editors.IntegerInput();
            _IntegerInput_TM_DialogSize.ValueChanged += new EventHandler(IntegerInput_TM_DialogSize_ValueChanged);
            _ComboBoxEx_TM_DialogPosX = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_TM_DialogPosX.TextChanged += new EventHandler(TM_CheckComboBoxText);
            _ComboItem5 = new DevComponents.Editors.ComboItem();
            _ComboItem6 = new DevComponents.Editors.ComboItem();
            _ComboItem7 = new DevComponents.Editors.ComboItem();
            _LabelX18 = new DevComponents.DotNetBar.LabelX();
            _TabStrip_TextTable = new DevComponents.DotNetBar.TabStrip();
            _TabStrip_TextTable.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(TabStrip1_SelectedTabChanged);
            _ListViewEx_TM_TableEntries = new DevComponents.DotNetBar.Controls.ListViewEx();
            _ListViewEx_TM_TableEntries.SelectedIndexChanged += new EventHandler(ListViewEx1_SelectedIndexChanged);
            _ColumnHeader1 = new ColumnHeader();
            _ColumnHeader13 = new ColumnHeader();
            _ColumnHeader14 = new ColumnHeader();
            _Line_TM_Green = new DevComponents.DotNetBar.Controls.Line();
            _Line_TM_Warning1 = new DevComponents.DotNetBar.Controls.Line();
            _Line_TM_Warning2 = new DevComponents.DotNetBar.Controls.Line();
            _TextBoxX_TM_TextEditor = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_TM_TextEditor.TextChanged += new EventHandler(TextBoxX_TM_TextEditor_TextChanged);
            _TextBoxX_TM_TextEditor.SizeChanged += new EventHandler(TextBoxX_TM_TextEditor_SizeChanged);
            _Bar_AddRemoveItems = new DevComponents.DotNetBar.Bar();
            _ButtonItem_CurProfile = new DevComponents.DotNetBar.ButtonItem();
            _ComboBoxItem_CurProfile = new DevComponents.DotNetBar.ComboBoxItem();
            _ComboBoxItem_CurProfile.SelectedIndexChanged += new EventHandler(ComboBoxItem_CurProfile_SelectedIndexChanged);
            _ButtonItem_AddTextItem = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_AddTextItem.Click += new EventHandler(ButtonItem_AddTextItem_Click);
            _ButtonItem_RemoveTextItem = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveTextItem.Click += new EventHandler(ButtonItem_RemoveTextItem_Click);
            _Bar_TextOptions = new DevComponents.DotNetBar.Bar();
            _ButtonItem_AddButtons = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem4.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem1.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem5.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem6.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem7 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem7.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem9 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem8 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem8.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem11 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem11.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem12 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem12.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem13 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem13.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem10 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem15 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem15.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem14 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem14.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem16 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem16.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem17 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem17.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem18 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem18.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem19 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem19.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _ButtonItem20 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem20.Click += new EventHandler(ButtonItemAddSpecialChar_Click);
            _Panel1 = new Panel();
            _Panel3 = new Panel();
            _GroupPanel_TM_DialogProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_TM_DialogSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Bar_AddRemoveItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Bar_TextOptions).BeginInit();
            _Panel1.SuspendLayout();
            _Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // GroupPanel_TM_DialogProps
            // 
            resources.ApplyResources(_GroupPanel_TM_DialogProps, "GroupPanel_TM_DialogProps");
            _GroupPanel_TM_DialogProps.BackColor = Color.Transparent;
            _GroupPanel_TM_DialogProps.CanvasColor = SystemColors.Control;
            _GroupPanel_TM_DialogProps.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            _GroupPanel_TM_DialogProps.Controls.Add(_LabelX22);
            _GroupPanel_TM_DialogProps.Controls.Add(_LabelX21);
            _GroupPanel_TM_DialogProps.Controls.Add(_ComboBoxEx_TM_DialogPosY);
            _GroupPanel_TM_DialogProps.Controls.Add(_IntegerInput_TM_DialogSize);
            _GroupPanel_TM_DialogProps.Controls.Add(_ComboBoxEx_TM_DialogPosX);
            _GroupPanel_TM_DialogProps.Controls.Add(_LabelX18);
            _GroupPanel_TM_DialogProps.DisabledBackColor = Color.Empty;
            _GroupPanel_TM_DialogProps.Name = "GroupPanel_TM_DialogProps";
            // 
            // 
            // 
            _GroupPanel_TM_DialogProps.Style.BackColorGradientAngle = 90;
            _GroupPanel_TM_DialogProps.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel_TM_DialogProps.Style.BorderBottomWidth = 1;
            _GroupPanel_TM_DialogProps.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel_TM_DialogProps.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel_TM_DialogProps.Style.BorderLeftWidth = 1;
            _GroupPanel_TM_DialogProps.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel_TM_DialogProps.Style.BorderRightWidth = 1;
            _GroupPanel_TM_DialogProps.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel_TM_DialogProps.Style.BorderTopWidth = 1;
            _GroupPanel_TM_DialogProps.Style.CornerDiameter = 4;
            _GroupPanel_TM_DialogProps.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel_TM_DialogProps.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel_TM_DialogProps.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel_TM_DialogProps.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel_TM_DialogProps.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel_TM_DialogProps.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // LabelX22
            // 
            resources.ApplyResources(_LabelX22, "LabelX22");
            // 
            // 
            // 
            _LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX22.Name = "LabelX22";
            // 
            // LabelX21
            // 
            resources.ApplyResources(_LabelX21, "LabelX21");
            // 
            // 
            // 
            _LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX21.Name = "LabelX21";
            // 
            // ComboBoxEx_TM_DialogPosY
            // 
            resources.ApplyResources(_ComboBoxEx_TM_DialogPosY, "ComboBoxEx_TM_DialogPosY");
            _ComboBoxEx_TM_DialogPosY.DisplayMember = "Text";
            _ComboBoxEx_TM_DialogPosY.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_TM_DialogPosY.ForeColor = Color.Black;
            _ComboBoxEx_TM_DialogPosY.FormattingEnabled = true;
            _ComboBoxEx_TM_DialogPosY.Items.AddRange(new object[] { _ComboItem10, _ComboItem8 });
            _ComboBoxEx_TM_DialogPosY.Name = "ComboBoxEx_TM_DialogPosY";
            _ComboBoxEx_TM_DialogPosY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem10
            // 
            resources.ApplyResources(_ComboItem10, "ComboItem10");
            // 
            // ComboItem8
            // 
            resources.ApplyResources(_ComboItem8, "ComboItem8");
            // 
            // IntegerInput_TM_DialogSize
            // 
            resources.ApplyResources(_IntegerInput_TM_DialogSize, "IntegerInput_TM_DialogSize");
            // 
            // 
            // 
            _IntegerInput_TM_DialogSize.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_TM_DialogSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_TM_DialogSize.ButtonCalculator.DisplayPosition = Conversions.ToInteger(resources.GetObject("IntegerInput_TM_DialogSize.ButtonCalculator.DisplayPosition"));
            _IntegerInput_TM_DialogSize.ButtonCalculator.Image = (Image)resources.GetObject("IntegerInput_TM_DialogSize.ButtonCalculator.Image");
            _IntegerInput_TM_DialogSize.ButtonCalculator.Text = resources.GetString("IntegerInput_TM_DialogSize.ButtonCalculator.Text");
            _IntegerInput_TM_DialogSize.ButtonCalculator.Tooltip = resources.GetString("IntegerInput_TM_DialogSize.ButtonCalculator.Tooltip");
            _IntegerInput_TM_DialogSize.ButtonClear.DisplayPosition = Conversions.ToInteger(resources.GetObject("IntegerInput_TM_DialogSize.ButtonClear.DisplayPosition"));
            _IntegerInput_TM_DialogSize.ButtonClear.Image = (Image)resources.GetObject("IntegerInput_TM_DialogSize.ButtonClear.Image");
            _IntegerInput_TM_DialogSize.ButtonClear.Text = resources.GetString("IntegerInput_TM_DialogSize.ButtonClear.Text");
            _IntegerInput_TM_DialogSize.ButtonClear.Tooltip = resources.GetString("IntegerInput_TM_DialogSize.ButtonClear.Tooltip");
            _IntegerInput_TM_DialogSize.ButtonCustom.DisplayPosition = Conversions.ToInteger(resources.GetObject("IntegerInput_TM_DialogSize.ButtonCustom.DisplayPosition"));
            _IntegerInput_TM_DialogSize.ButtonCustom.Image = (Image)resources.GetObject("IntegerInput_TM_DialogSize.ButtonCustom.Image");
            _IntegerInput_TM_DialogSize.ButtonCustom.Text = resources.GetString("IntegerInput_TM_DialogSize.ButtonCustom.Text");
            _IntegerInput_TM_DialogSize.ButtonCustom.Tooltip = resources.GetString("IntegerInput_TM_DialogSize.ButtonCustom.Tooltip");
            _IntegerInput_TM_DialogSize.ButtonCustom2.DisplayPosition = Conversions.ToInteger(resources.GetObject("IntegerInput_TM_DialogSize.ButtonCustom2.DisplayPosition"));
            _IntegerInput_TM_DialogSize.ButtonCustom2.Image = (Image)resources.GetObject("IntegerInput_TM_DialogSize.ButtonCustom2.Image");
            _IntegerInput_TM_DialogSize.ButtonCustom2.Text = resources.GetString("IntegerInput_TM_DialogSize.ButtonCustom2.Text");
            _IntegerInput_TM_DialogSize.ButtonCustom2.Tooltip = resources.GetString("IntegerInput_TM_DialogSize.ButtonCustom2.Tooltip");
            _IntegerInput_TM_DialogSize.ButtonDropDown.DisplayPosition = Conversions.ToInteger(resources.GetObject("IntegerInput_TM_DialogSize.ButtonDropDown.DisplayPosition"));
            _IntegerInput_TM_DialogSize.ButtonDropDown.Image = (Image)resources.GetObject("IntegerInput_TM_DialogSize.ButtonDropDown.Image");
            _IntegerInput_TM_DialogSize.ButtonDropDown.Text = resources.GetString("IntegerInput_TM_DialogSize.ButtonDropDown.Text");
            _IntegerInput_TM_DialogSize.ButtonDropDown.Tooltip = resources.GetString("IntegerInput_TM_DialogSize.ButtonDropDown.Tooltip");
            _IntegerInput_TM_DialogSize.ButtonFreeText.DisplayPosition = Conversions.ToInteger(resources.GetObject("IntegerInput_TM_DialogSize.ButtonFreeText.DisplayPosition"));
            _IntegerInput_TM_DialogSize.ButtonFreeText.Image = (Image)resources.GetObject("IntegerInput_TM_DialogSize.ButtonFreeText.Image");
            _IntegerInput_TM_DialogSize.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_TM_DialogSize.ButtonFreeText.Text = resources.GetString("IntegerInput_TM_DialogSize.ButtonFreeText.Text");
            _IntegerInput_TM_DialogSize.ButtonFreeText.Tooltip = resources.GetString("IntegerInput_TM_DialogSize.ButtonFreeText.Tooltip");
            _IntegerInput_TM_DialogSize.MaxValue = 255;
            _IntegerInput_TM_DialogSize.MinValue = 1;
            _IntegerInput_TM_DialogSize.Name = "IntegerInput_TM_DialogSize";
            _IntegerInput_TM_DialogSize.ShowUpDown = true;
            _IntegerInput_TM_DialogSize.Value = 1;
            // 
            // ComboBoxEx_TM_DialogPosX
            // 
            resources.ApplyResources(_ComboBoxEx_TM_DialogPosX, "ComboBoxEx_TM_DialogPosX");
            _ComboBoxEx_TM_DialogPosX.DisplayMember = "Text";
            _ComboBoxEx_TM_DialogPosX.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_TM_DialogPosX.ForeColor = Color.Black;
            _ComboBoxEx_TM_DialogPosX.FormattingEnabled = true;
            _ComboBoxEx_TM_DialogPosX.Items.AddRange(new object[] { _ComboItem5, _ComboItem6, _ComboItem7 });
            _ComboBoxEx_TM_DialogPosX.Name = "ComboBoxEx_TM_DialogPosX";
            _ComboBoxEx_TM_DialogPosX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem5
            // 
            resources.ApplyResources(_ComboItem5, "ComboItem5");
            // 
            // ComboItem6
            // 
            resources.ApplyResources(_ComboItem6, "ComboItem6");
            // 
            // ComboItem7
            // 
            resources.ApplyResources(_ComboItem7, "ComboItem7");
            // 
            // LabelX18
            // 
            resources.ApplyResources(_LabelX18, "LabelX18");
            // 
            // 
            // 
            _LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX18.Name = "LabelX18";
            // 
            // TabStrip_TextTable
            // 
            resources.ApplyResources(_TabStrip_TextTable, "TabStrip_TextTable");
            _TabStrip_TextTable.AutoSelectAttachedControl = true;
            _TabStrip_TextTable.CanReorderTabs = false;
            _TabStrip_TextTable.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            _TabStrip_TextTable.CloseButtonVisible = true;
            _TabStrip_TextTable.Cursor = Cursors.Default;
            _TabStrip_TextTable.ForeColor = Color.Black;
            _TabStrip_TextTable.Name = "TabStrip_TextTable";
            _TabStrip_TextTable.SelectedTab = null;
            _TabStrip_TextTable.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            _TabStrip_TextTable.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            // 
            // ListViewEx_TM_TableEntries
            // 
            resources.ApplyResources(_ListViewEx_TM_TableEntries, "ListViewEx_TM_TableEntries");
            _ListViewEx_TM_TableEntries.BackColor = Color.White;
            // 
            // 
            // 
            _ListViewEx_TM_TableEntries.Border.Class = "ListViewBorder";
            _ListViewEx_TM_TableEntries.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx_TM_TableEntries.Columns.AddRange(new ColumnHeader[] { _ColumnHeader1, _ColumnHeader13, _ColumnHeader14 });
            _ListViewEx_TM_TableEntries.DisabledBackColor = Color.Empty;
            _ListViewEx_TM_TableEntries.FocusCuesEnabled = false;
            _ListViewEx_TM_TableEntries.ForeColor = Color.Black;
            _ListViewEx_TM_TableEntries.FullRowSelect = true;
            _ListViewEx_TM_TableEntries.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _ListViewEx_TM_TableEntries.HideSelection = false;
            _ListViewEx_TM_TableEntries.Name = "ListViewEx_TM_TableEntries";
            _ListViewEx_TM_TableEntries.UseCompatibleStateImageBehavior = false;
            _ListViewEx_TM_TableEntries.View = View.Details;
            // 
            // ColumnHeader1
            // 
            resources.ApplyResources(_ColumnHeader1, "ColumnHeader1");
            // 
            // ColumnHeader13
            // 
            resources.ApplyResources(_ColumnHeader13, "ColumnHeader13");
            // 
            // ColumnHeader14
            // 
            resources.ApplyResources(_ColumnHeader14, "ColumnHeader14");
            // 
            // Line_TM_Green
            // 
            resources.ApplyResources(_Line_TM_Green, "Line_TM_Green");
            _Line_TM_Green.BackColor = Color.Transparent;
            _Line_TM_Green.Cursor = Cursors.IBeam;
            _Line_TM_Green.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            _Line_TM_Green.ForeColor = Color.YellowGreen;
            _Line_TM_Green.Name = "Line_TM_Green";
            _Line_TM_Green.VerticalLine = true;
            // 
            // Line_TM_Warning1
            // 
            resources.ApplyResources(_Line_TM_Warning1, "Line_TM_Warning1");
            _Line_TM_Warning1.BackColor = Color.Transparent;
            _Line_TM_Warning1.Cursor = Cursors.IBeam;
            _Line_TM_Warning1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            _Line_TM_Warning1.ForeColor = Color.Orange;
            _Line_TM_Warning1.Name = "Line_TM_Warning1";
            _Line_TM_Warning1.VerticalLine = true;
            // 
            // Line_TM_Warning2
            // 
            resources.ApplyResources(_Line_TM_Warning2, "Line_TM_Warning2");
            _Line_TM_Warning2.BackColor = Color.Transparent;
            _Line_TM_Warning2.Cursor = Cursors.IBeam;
            _Line_TM_Warning2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            _Line_TM_Warning2.ForeColor = Color.Red;
            _Line_TM_Warning2.Name = "Line_TM_Warning2";
            _Line_TM_Warning2.VerticalLine = true;
            // 
            // TextBoxX_TM_TextEditor
            // 
            resources.ApplyResources(_TextBoxX_TM_TextEditor, "TextBoxX_TM_TextEditor");
            _TextBoxX_TM_TextEditor.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_TM_TextEditor.Border.Class = "TextBoxBorder";
            _TextBoxX_TM_TextEditor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_TM_TextEditor.ButtonCustom.DisplayPosition = Conversions.ToInteger(resources.GetObject("TextBoxX_TM_TextEditor.ButtonCustom.DisplayPosition"));
            _TextBoxX_TM_TextEditor.ButtonCustom.Image = (Image)resources.GetObject("TextBoxX_TM_TextEditor.ButtonCustom.Image");
            _TextBoxX_TM_TextEditor.ButtonCustom.Text = resources.GetString("TextBoxX_TM_TextEditor.ButtonCustom.Text");
            _TextBoxX_TM_TextEditor.ButtonCustom.Tooltip = resources.GetString("TextBoxX_TM_TextEditor.ButtonCustom.Tooltip");
            _TextBoxX_TM_TextEditor.ButtonCustom2.DisplayPosition = Conversions.ToInteger(resources.GetObject("TextBoxX_TM_TextEditor.ButtonCustom2.DisplayPosition"));
            _TextBoxX_TM_TextEditor.ButtonCustom2.Image = (Image)resources.GetObject("TextBoxX_TM_TextEditor.ButtonCustom2.Image");
            _TextBoxX_TM_TextEditor.ButtonCustom2.Text = resources.GetString("TextBoxX_TM_TextEditor.ButtonCustom2.Text");
            _TextBoxX_TM_TextEditor.ButtonCustom2.Tooltip = resources.GetString("TextBoxX_TM_TextEditor.ButtonCustom2.Tooltip");
            _TextBoxX_TM_TextEditor.DisabledBackColor = Color.White;
            _TextBoxX_TM_TextEditor.ForeColor = Color.Black;
            _TextBoxX_TM_TextEditor.Name = "TextBoxX_TM_TextEditor";
            _TextBoxX_TM_TextEditor.PreventEnterBeep = true;
            _TextBoxX_TM_TextEditor.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            // 
            // Bar_AddRemoveItems
            // 
            resources.ApplyResources(_Bar_AddRemoveItems, "Bar_AddRemoveItems");
            _Bar_AddRemoveItems.AntiAlias = true;
            _Bar_AddRemoveItems.IsMaximized = false;
            _Bar_AddRemoveItems.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_CurProfile, _ButtonItem_AddTextItem, _ButtonItem_RemoveTextItem });
            _Bar_AddRemoveItems.Name = "Bar_AddRemoveItems";
            _Bar_AddRemoveItems.Stretch = true;
            _Bar_AddRemoveItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            _Bar_AddRemoveItems.TabStop = false;
            // 
            // ButtonItem_CurProfile
            // 
            resources.ApplyResources(_ButtonItem_CurProfile, "ButtonItem_CurProfile");
            _ButtonItem_CurProfile.AutoExpandOnClick = true;
            _ButtonItem_CurProfile.Name = "ButtonItem_CurProfile";
            _ButtonItem_CurProfile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ComboBoxItem_CurProfile });
            // 
            // ComboBoxItem_CurProfile
            // 
            resources.ApplyResources(_ComboBoxItem_CurProfile, "ComboBoxItem_CurProfile");
            _ComboBoxItem_CurProfile.ComboWidth = 150;
            _ComboBoxItem_CurProfile.DropDownHeight = 106;
            _ComboBoxItem_CurProfile.DropDownWidth = 150;
            _ComboBoxItem_CurProfile.Name = "ComboBoxItem_CurProfile";
            // 
            // ButtonItem_AddTextItem
            // 
            resources.ApplyResources(_ButtonItem_AddTextItem, "ButtonItem_AddTextItem");
            _ButtonItem_AddTextItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_AddTextItem.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            _ButtonItem_AddTextItem.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            _ButtonItem_AddTextItem.Name = "ButtonItem_AddTextItem";
            // 
            // ButtonItem_RemoveTextItem
            // 
            resources.ApplyResources(_ButtonItem_RemoveTextItem, "ButtonItem_RemoveTextItem");
            _ButtonItem_RemoveTextItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            _ButtonItem_RemoveTextItem.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem_RemoveTextItem.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            _ButtonItem_RemoveTextItem.Name = "ButtonItem_RemoveTextItem";
            // 
            // Bar_TextOptions
            // 
            resources.ApplyResources(_Bar_TextOptions, "Bar_TextOptions");
            _Bar_TextOptions.AntiAlias = true;
            _Bar_TextOptions.IsMaximized = false;
            _Bar_TextOptions.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_AddButtons, _ButtonItem9, _ButtonItem10 });
            _Bar_TextOptions.Name = "Bar_TextOptions";
            _Bar_TextOptions.Stretch = true;
            _Bar_TextOptions.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            _Bar_TextOptions.TabStop = false;
            // 
            // ButtonItem_AddButtons
            // 
            resources.ApplyResources(_ButtonItem_AddButtons, "ButtonItem_AddButtons");
            _ButtonItem_AddButtons.AutoExpandOnClick = true;
            _ButtonItem_AddButtons.Name = "ButtonItem_AddButtons";
            _ButtonItem_AddButtons.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem4, _ButtonItem1, _ButtonItem5, _ButtonItem6, _ButtonItem7 });
            // 
            // ButtonItem4
            // 
            resources.ApplyResources(_ButtonItem4, "ButtonItem4");
            _ButtonItem4.Name = "ButtonItem4";
            // 
            // ButtonItem1
            // 
            resources.ApplyResources(_ButtonItem1, "ButtonItem1");
            _ButtonItem1.Name = "ButtonItem1";
            // 
            // ButtonItem5
            // 
            resources.ApplyResources(_ButtonItem5, "ButtonItem5");
            _ButtonItem5.Name = "ButtonItem5";
            // 
            // ButtonItem6
            // 
            resources.ApplyResources(_ButtonItem6, "ButtonItem6");
            _ButtonItem6.Name = "ButtonItem6";
            // 
            // ButtonItem7
            // 
            resources.ApplyResources(_ButtonItem7, "ButtonItem7");
            _ButtonItem7.Name = "ButtonItem7";
            // 
            // ButtonItem9
            // 
            resources.ApplyResources(_ButtonItem9, "ButtonItem9");
            _ButtonItem9.AutoExpandOnClick = true;
            _ButtonItem9.Name = "ButtonItem9";
            _ButtonItem9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem8, _ButtonItem11, _ButtonItem12, _ButtonItem13 });
            // 
            // ButtonItem8
            // 
            resources.ApplyResources(_ButtonItem8, "ButtonItem8");
            _ButtonItem8.Name = "ButtonItem8";
            // 
            // ButtonItem11
            // 
            resources.ApplyResources(_ButtonItem11, "ButtonItem11");
            _ButtonItem11.Name = "ButtonItem11";
            // 
            // ButtonItem12
            // 
            resources.ApplyResources(_ButtonItem12, "ButtonItem12");
            _ButtonItem12.Name = "ButtonItem12";
            // 
            // ButtonItem13
            // 
            resources.ApplyResources(_ButtonItem13, "ButtonItem13");
            _ButtonItem13.Name = "ButtonItem13";
            // 
            // ButtonItem10
            // 
            resources.ApplyResources(_ButtonItem10, "ButtonItem10");
            _ButtonItem10.AutoExpandOnClick = true;
            _ButtonItem10.Name = "ButtonItem10";
            _ButtonItem10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem15, _ButtonItem14, _ButtonItem16, _ButtonItem17, _ButtonItem18, _ButtonItem19, _ButtonItem20 });
            // 
            // ButtonItem15
            // 
            resources.ApplyResources(_ButtonItem15, "ButtonItem15");
            _ButtonItem15.Name = "ButtonItem15";
            // 
            // ButtonItem14
            // 
            resources.ApplyResources(_ButtonItem14, "ButtonItem14");
            _ButtonItem14.Name = "ButtonItem14";
            // 
            // ButtonItem16
            // 
            resources.ApplyResources(_ButtonItem16, "ButtonItem16");
            _ButtonItem16.Name = "ButtonItem16";
            // 
            // ButtonItem17
            // 
            resources.ApplyResources(_ButtonItem17, "ButtonItem17");
            _ButtonItem17.Name = "ButtonItem17";
            // 
            // ButtonItem18
            // 
            resources.ApplyResources(_ButtonItem18, "ButtonItem18");
            _ButtonItem18.Name = "ButtonItem18";
            // 
            // ButtonItem19
            // 
            resources.ApplyResources(_ButtonItem19, "ButtonItem19");
            _ButtonItem19.Name = "ButtonItem19";
            // 
            // ButtonItem20
            // 
            resources.ApplyResources(_ButtonItem20, "ButtonItem20");
            _ButtonItem20.Name = "ButtonItem20";
            // 
            // Panel1
            // 
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_Line_TM_Warning2);
            _Panel1.Controls.Add(_Line_TM_Green);
            _Panel1.Controls.Add(_Line_TM_Warning1);
            _Panel1.Controls.Add(_TextBoxX_TM_TextEditor);
            _Panel1.Controls.Add(_GroupPanel_TM_DialogProps);
            _Panel1.Controls.Add(_Bar_TextOptions);
            _Panel1.Name = "Panel1";
            // 
            // Panel3
            // 
            resources.ApplyResources(_Panel3, "Panel3");
            _Panel3.BackColor = Color.Transparent;
            _Panel3.Controls.Add(_ListViewEx_TM_TableEntries);
            _Panel3.Controls.Add(_TabStrip_TextTable);
            _Panel3.Controls.Add(_Bar_AddRemoveItems);
            _Panel3.Name = "Panel3";
            // 
            // Tab_TextManager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel3);
            Controls.Add(_Panel1);
            Name = "Tab_TextManager";
            _GroupPanel_TM_DialogProps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_TM_DialogSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Bar_AddRemoveItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Bar_TextOptions).EndInit();
            _Panel1.ResumeLayout(false);
            _Panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel_TM_DialogProps;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel_TM_DialogProps
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel_TM_DialogProps;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel_TM_DialogProps != null)
                {
                }

                _GroupPanel_TM_DialogProps = value;
                if (_GroupPanel_TM_DialogProps != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX22;

        internal DevComponents.DotNetBar.LabelX LabelX22
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX22;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX22 != null)
                {
                }

                _LabelX22 = value;
                if (_LabelX22 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX21;

        internal DevComponents.DotNetBar.LabelX LabelX21
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX21;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX21 != null)
                {
                }

                _LabelX21 = value;
                if (_LabelX21 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_TM_DialogPosY;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_TM_DialogPosY
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_TM_DialogPosY;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_TM_DialogPosY != null)
                {
                    _ComboBoxEx_TM_DialogPosY.TextChanged -= TM_CheckComboBoxText;
                }

                _ComboBoxEx_TM_DialogPosY = value;
                if (_ComboBoxEx_TM_DialogPosY != null)
                {
                    _ComboBoxEx_TM_DialogPosY.TextChanged += TM_CheckComboBoxText;
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem10;

        internal DevComponents.Editors.ComboItem ComboItem10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem10 != null)
                {
                }

                _ComboItem10 = value;
                if (_ComboItem10 != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem8;

        internal DevComponents.Editors.ComboItem ComboItem8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem8 != null)
                {
                }

                _ComboItem8 = value;
                if (_ComboItem8 != null)
                {
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_TM_DialogSize;

        internal DevComponents.Editors.IntegerInput IntegerInput_TM_DialogSize
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_TM_DialogSize;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_TM_DialogSize != null)
                {
                    _IntegerInput_TM_DialogSize.ValueChanged -= IntegerInput_TM_DialogSize_ValueChanged;
                }

                _IntegerInput_TM_DialogSize = value;
                if (_IntegerInput_TM_DialogSize != null)
                {
                    _IntegerInput_TM_DialogSize.ValueChanged += IntegerInput_TM_DialogSize_ValueChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_TM_DialogPosX;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_TM_DialogPosX
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_TM_DialogPosX;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_TM_DialogPosX != null)
                {
                    _ComboBoxEx_TM_DialogPosX.TextChanged -= TM_CheckComboBoxText;
                }

                _ComboBoxEx_TM_DialogPosX = value;
                if (_ComboBoxEx_TM_DialogPosX != null)
                {
                    _ComboBoxEx_TM_DialogPosX.TextChanged += TM_CheckComboBoxText;
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem5;

        internal DevComponents.Editors.ComboItem ComboItem5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem5 != null)
                {
                }

                _ComboItem5 = value;
                if (_ComboItem5 != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem6;

        internal DevComponents.Editors.ComboItem ComboItem6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem6 != null)
                {
                }

                _ComboItem6 = value;
                if (_ComboItem6 != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem7;

        internal DevComponents.Editors.ComboItem ComboItem7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem7 != null)
                {
                }

                _ComboItem7 = value;
                if (_ComboItem7 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX18;

        internal DevComponents.DotNetBar.LabelX LabelX18
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX18;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX18 != null)
                {
                }

                _LabelX18 = value;
                if (_LabelX18 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabStrip _TabStrip_TextTable;

        internal DevComponents.DotNetBar.TabStrip TabStrip_TextTable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabStrip_TextTable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabStrip_TextTable != null)
                {
                    _TabStrip_TextTable.SelectedTabChanged -= TabStrip1_SelectedTabChanged;
                }

                _TabStrip_TextTable = value;
                if (_TabStrip_TextTable != null)
                {
                    _TabStrip_TextTable.SelectedTabChanged += TabStrip1_SelectedTabChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ListViewEx _ListViewEx_TM_TableEntries;

        internal DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_TM_TableEntries
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewEx_TM_TableEntries;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewEx_TM_TableEntries != null)
                {
                    _ListViewEx_TM_TableEntries.SelectedIndexChanged -= ListViewEx1_SelectedIndexChanged;
                }

                _ListViewEx_TM_TableEntries = value;
                if (_ListViewEx_TM_TableEntries != null)
                {
                    _ListViewEx_TM_TableEntries.SelectedIndexChanged += ListViewEx1_SelectedIndexChanged;
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

        private ColumnHeader _ColumnHeader13;

        internal ColumnHeader ColumnHeader13
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader13;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader13 != null)
                {
                }

                _ColumnHeader13 = value;
                if (_ColumnHeader13 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader14;

        internal ColumnHeader ColumnHeader14
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader14;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader14 != null)
                {
                }

                _ColumnHeader14 = value;
                if (_ColumnHeader14 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.Line _Line_TM_Green;

        internal DevComponents.DotNetBar.Controls.Line Line_TM_Green
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Line_TM_Green;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Line_TM_Green != null)
                {
                }

                _Line_TM_Green = value;
                if (_Line_TM_Green != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.Line _Line_TM_Warning1;

        internal DevComponents.DotNetBar.Controls.Line Line_TM_Warning1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Line_TM_Warning1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Line_TM_Warning1 != null)
                {
                }

                _Line_TM_Warning1 = value;
                if (_Line_TM_Warning1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.Line _Line_TM_Warning2;

        internal DevComponents.DotNetBar.Controls.Line Line_TM_Warning2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Line_TM_Warning2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Line_TM_Warning2 != null)
                {
                }

                _Line_TM_Warning2 = value;
                if (_Line_TM_Warning2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_TM_TextEditor;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_TM_TextEditor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_TM_TextEditor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_TM_TextEditor != null)
                {
                    _TextBoxX_TM_TextEditor.TextChanged -= TextBoxX_TM_TextEditor_TextChanged;
                    _TextBoxX_TM_TextEditor.SizeChanged -= TextBoxX_TM_TextEditor_SizeChanged;
                }

                _TextBoxX_TM_TextEditor = value;
                if (_TextBoxX_TM_TextEditor != null)
                {
                    _TextBoxX_TM_TextEditor.TextChanged += TextBoxX_TM_TextEditor_TextChanged;
                    _TextBoxX_TM_TextEditor.SizeChanged += TextBoxX_TM_TextEditor_SizeChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Bar _Bar_AddRemoveItems;

        internal DevComponents.DotNetBar.Bar Bar_AddRemoveItems
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Bar_AddRemoveItems;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Bar_AddRemoveItems != null)
                {
                }

                _Bar_AddRemoveItems = value;
                if (_Bar_AddRemoveItems != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_AddTextItem;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_AddTextItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_AddTextItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_AddTextItem != null)
                {
                    _ButtonItem_AddTextItem.Click -= ButtonItem_AddTextItem_Click;
                }

                _ButtonItem_AddTextItem = value;
                if (_ButtonItem_AddTextItem != null)
                {
                    _ButtonItem_AddTextItem.Click += ButtonItem_AddTextItem_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveTextItem;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveTextItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveTextItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveTextItem != null)
                {
                    _ButtonItem_RemoveTextItem.Click -= ButtonItem_RemoveTextItem_Click;
                }

                _ButtonItem_RemoveTextItem = value;
                if (_ButtonItem_RemoveTextItem != null)
                {
                    _ButtonItem_RemoveTextItem.Click += ButtonItem_RemoveTextItem_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Bar _Bar_TextOptions;

        internal DevComponents.DotNetBar.Bar Bar_TextOptions
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Bar_TextOptions;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Bar_TextOptions != null)
                {
                }

                _Bar_TextOptions = value;
                if (_Bar_TextOptions != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_AddButtons;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_AddButtons
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_AddButtons;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_AddButtons != null)
                {
                }

                _ButtonItem_AddButtons = value;
                if (_ButtonItem_AddButtons != null)
                {
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
                    _ButtonItem4.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem4 = value;
                if (_ButtonItem4 != null)
                {
                    _ButtonItem4.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem1.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem1 = value;
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem5.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem5 = value;
                if (_ButtonItem5 != null)
                {
                    _ButtonItem5.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem6.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem6 = value;
                if (_ButtonItem6 != null)
                {
                    _ButtonItem6.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem7.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem7 = value;
                if (_ButtonItem7 != null)
                {
                    _ButtonItem7.Click += ButtonItemAddSpecialChar_Click;
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
                }

                _ButtonItem9 = value;
                if (_ButtonItem9 != null)
                {
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
                }

                _ButtonItem10 = value;
                if (_ButtonItem10 != null)
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
                    _ButtonItem8.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem8 = value;
                if (_ButtonItem8 != null)
                {
                    _ButtonItem8.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem11.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem11 = value;
                if (_ButtonItem11 != null)
                {
                    _ButtonItem11.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem12.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem12 = value;
                if (_ButtonItem12 != null)
                {
                    _ButtonItem12.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem13.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem13 = value;
                if (_ButtonItem13 != null)
                {
                    _ButtonItem13.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem14.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem14 = value;
                if (_ButtonItem14 != null)
                {
                    _ButtonItem14.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem15.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem15 = value;
                if (_ButtonItem15 != null)
                {
                    _ButtonItem15.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem16.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem16 = value;
                if (_ButtonItem16 != null)
                {
                    _ButtonItem16.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem17.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem17 = value;
                if (_ButtonItem17 != null)
                {
                    _ButtonItem17.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem18.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem18 = value;
                if (_ButtonItem18 != null)
                {
                    _ButtonItem18.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem19.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem19 = value;
                if (_ButtonItem19 != null)
                {
                    _ButtonItem19.Click += ButtonItemAddSpecialChar_Click;
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
                    _ButtonItem20.Click -= ButtonItemAddSpecialChar_Click;
                }

                _ButtonItem20 = value;
                if (_ButtonItem20 != null)
                {
                    _ButtonItem20.Click += ButtonItemAddSpecialChar_Click;
                }
            }
        }

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

        private DevComponents.DotNetBar.ComboBoxItem _ComboBoxItem_CurProfile;

        internal DevComponents.DotNetBar.ComboBoxItem ComboBoxItem_CurProfile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxItem_CurProfile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxItem_CurProfile != null)
                {
                    _ComboBoxItem_CurProfile.SelectedIndexChanged -= ComboBoxItem_CurProfile_SelectedIndexChanged;
                }

                _ComboBoxItem_CurProfile = value;
                if (_ComboBoxItem_CurProfile != null)
                {
                    _ComboBoxItem_CurProfile.SelectedIndexChanged += ComboBoxItem_CurProfile_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CurProfile;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CurProfile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CurProfile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CurProfile != null)
                {
                }

                _ButtonItem_CurProfile = value;
                if (_ButtonItem_CurProfile != null)
                {
                }
            }
        }
    }
}