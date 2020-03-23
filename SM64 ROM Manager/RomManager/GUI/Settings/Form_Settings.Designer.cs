using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Form_Settings : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            _ComboBox_DefaultValueType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_SearchUpdates = new DevComponents.DotNetBar.Controls.SwitchButton();
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _ComboBox_AreaEditor_DefaultWindowMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _LabelX7 = new DevComponents.DotNetBar.LabelX();
            _ComboBox_AreaEditor_DefaultCameraMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _LabelX6 = new DevComponents.DotNetBar.LabelX();
            _TabControl2 = new DevComponents.DotNetBar.TabControl();
            _TabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            _ComboBoxEx_NotifyOnRomChanges = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_NotifyOnRomChanges.SelectedIndexChanged += new EventHandler(ComboBoxEx_Language_SelectedIndexChanged);
            _ComboItem4 = new DevComponents.Editors.ComboItem();
            _ComboItem5 = new DevComponents.Editors.ComboItem();
            _ComboItem11 = new DevComponents.Editors.ComboItem();
            _ComboBoxEx_Language = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_Language.SelectedIndexChanged += new EventHandler(ComboBoxEx_Language_SelectedIndexChanged);
            _ComboItem_AutoLang = new DevComponents.Editors.ComboItem();
            _LabelX12 = new DevComponents.DotNetBar.LabelX();
            _LabelX11 = new DevComponents.DotNetBar.LabelX();
            _ComboBoxEx_AutoScaleMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboItem6 = new DevComponents.Editors.ComboItem();
            _ComboItem9 = new DevComponents.Editors.ComboItem();
            _ComboItem10 = new DevComponents.Editors.ComboItem();
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX4.Click += new EventHandler(ButtonX4_Click);
            _ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboItem1 = new DevComponents.Editors.ComboItem();
            _ComboItem2 = new DevComponents.Editors.ComboItem();
            _ComboItem3 = new DevComponents.Editors.ComboItem();
            _LabelX10 = new DevComponents.DotNetBar.LabelX();
            _TabItem1 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel7 = new DevComponents.DotNetBar.TabControlPanel();
            _TextBoxX_ProxyPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ProxyUsr = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LabelX16 = new DevComponents.DotNetBar.LabelX();
            _LabelX13 = new DevComponents.DotNetBar.LabelX();
            _ComboBoxEx_UpdateLevel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_UpdateLevel.SelectedIndexChanged += new EventHandler(ComboBoxEx_Language_SelectedIndexChanged);
            _ComboItem12 = new DevComponents.Editors.ComboItem();
            _ComboItem13 = new DevComponents.Editors.ComboItem();
            _ComboItem14 = new DevComponents.Editors.ComboItem();
            _TabItem8 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel6 = new DevComponents.DotNetBar.TabControlPanel();
            _LabelX15 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_TMForceUppercase = new DevComponents.DotNetBar.Controls.SwitchButton();
            _TabItem7 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel5 = new DevComponents.DotNetBar.TabControlPanel();
            _ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX6.Click += new EventHandler(ButtonX6_Click);
            _LabelX14 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_UseLegacyCollisionDescriptions = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_UseLegacyCollisionDescriptions.ValueChanged += new EventHandler(ComboBoxEx_Language_SelectedIndexChanged);
            _TabItem6 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            _LabelX9 = new DevComponents.DotNetBar.LabelX();
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX2.Click += new EventHandler(ButtonX2_Click);
            _TextBoxX_HexEditorCustomPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            _ButtonX5 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX5.Click += new EventHandler(ButtonX5_Click);
            _TextBoxX_EmulatorPatch = new DevComponents.DotNetBar.Controls.TextBoxX();
            _ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX3.Click += new EventHandler(ButtonX3_Click);
            _ComboBoxEx_HexEditorMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_HexEditorMode.SelectedIndexChanged += new EventHandler(ComboBoxEx2_SelectedIndexChanged);
            _ComboItem7 = new DevComponents.Editors.ComboItem();
            _ComboItem8 = new DevComponents.Editors.ComboItem();
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _TabItem5 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel_LoaderModules = new DevComponents.DotNetBar.TabControlPanel();
            _ComboBoxEx_ExporterModule = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _LabelX8 = new DevComponents.DotNetBar.LabelX();
            _ComboBoxEx_LoaderModule = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _TabItem4 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _TabItem3 = new DevComponents.DotNetBar.TabItem(components);
            _TabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            _TabItem2 = new DevComponents.DotNetBar.TabItem(components);
            _SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            _PictureBox_Warning = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)_TabControl2).BeginInit();
            _TabControl2.SuspendLayout();
            _TabControlPanel1.SuspendLayout();
            _TabControlPanel7.SuspendLayout();
            _TabControlPanel6.SuspendLayout();
            _TabControlPanel5.SuspendLayout();
            _TabControlPanel4.SuspendLayout();
            _TabControlPanel_LoaderModules.SuspendLayout();
            _TabControlPanel3.SuspendLayout();
            _TabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_PictureBox_Warning).BeginInit();
            SuspendLayout();
            // 
            // ComboBox_DefaultValueType
            // 
            resources.ApplyResources(_ComboBox_DefaultValueType, "ComboBox_DefaultValueType");
            _ComboBox_DefaultValueType.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_DefaultValueType.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_DefaultValueType.ForeColor = Color.Black;
            _ComboBox_DefaultValueType.FormattingEnabled = true;
            _ComboBox_DefaultValueType.Items.AddRange(new object[] { resources.GetString("ComboBox_DefaultValueType.Items"), resources.GetString("ComboBox_DefaultValueType.Items1"), resources.GetString("ComboBox_DefaultValueType.Items2"), resources.GetString("ComboBox_DefaultValueType.Items3") });
            _ComboBox_DefaultValueType.Name = "ComboBox_DefaultValueType";
            _ComboBox_DefaultValueType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            _LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_SearchUpdates
            // 
            resources.ApplyResources(_SwitchButton_SearchUpdates, "SwitchButton_SearchUpdates");
            // 
            // 
            // 
            _SwitchButton_SearchUpdates.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_SearchUpdates.Name = "SwitchButton_SearchUpdates";
            _SwitchButton_SearchUpdates.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_SearchUpdates.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_SearchUpdates.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_SearchUpdates.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_SearchUpdates.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_SearchUpdates.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_SearchUpdates.SwitchWidth = 15;
            _SwitchButton_SearchUpdates.Value = true;
            _SwitchButton_SearchUpdates.ValueObject = "Y";
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
            _LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ComboBox_AreaEditor_DefaultWindowMode
            // 
            resources.ApplyResources(_ComboBox_AreaEditor_DefaultWindowMode, "ComboBox_AreaEditor_DefaultWindowMode");
            _ComboBox_AreaEditor_DefaultWindowMode.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_AreaEditor_DefaultWindowMode.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_AreaEditor_DefaultWindowMode.ForeColor = Color.Black;
            _ComboBox_AreaEditor_DefaultWindowMode.FormattingEnabled = true;
            _ComboBox_AreaEditor_DefaultWindowMode.Items.AddRange(new object[] { resources.GetString("ComboBox_AreaEditor_DefaultWindowMode.Items"), resources.GetString("ComboBox_AreaEditor_DefaultWindowMode.Items1") });
            _ComboBox_AreaEditor_DefaultWindowMode.Name = "ComboBox_AreaEditor_DefaultWindowMode";
            _ComboBox_AreaEditor_DefaultWindowMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            _LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ComboBox_AreaEditor_DefaultCameraMode
            // 
            resources.ApplyResources(_ComboBox_AreaEditor_DefaultCameraMode, "ComboBox_AreaEditor_DefaultCameraMode");
            _ComboBox_AreaEditor_DefaultCameraMode.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_AreaEditor_DefaultCameraMode.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_AreaEditor_DefaultCameraMode.ForeColor = Color.Black;
            _ComboBox_AreaEditor_DefaultCameraMode.FormattingEnabled = true;
            _ComboBox_AreaEditor_DefaultCameraMode.Items.AddRange(new object[] { resources.GetString("ComboBox_AreaEditor_DefaultCameraMode.Items"), resources.GetString("ComboBox_AreaEditor_DefaultCameraMode.Items1") });
            _ComboBox_AreaEditor_DefaultCameraMode.Name = "ComboBox_AreaEditor_DefaultCameraMode";
            _ComboBox_AreaEditor_DefaultCameraMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            _LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // TabControl2
            // 
            _TabControl2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControl2.CanReorderTabs = false;
            _TabControl2.Controls.Add(_TabControlPanel1);
            _TabControl2.Controls.Add(_TabControlPanel7);
            _TabControl2.Controls.Add(_TabControlPanel6);
            _TabControl2.Controls.Add(_TabControlPanel5);
            _TabControl2.Controls.Add(_TabControlPanel4);
            _TabControl2.Controls.Add(_TabControlPanel_LoaderModules);
            _TabControl2.Controls.Add(_TabControlPanel3);
            _TabControl2.Controls.Add(_TabControlPanel2);
            resources.ApplyResources(_TabControl2, "TabControl2");
            _TabControl2.ForeColor = Color.Black;
            _TabControl2.Name = "TabControl2";
            _TabControl2.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            _TabControl2.SelectedTabIndex = 0;
            _TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            _TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            _TabControl2.Tabs.Add(_TabItem1);
            _TabControl2.Tabs.Add(_TabItem8);
            _TabControl2.Tabs.Add(_TabItem3);
            _TabControl2.Tabs.Add(_TabItem2);
            _TabControl2.Tabs.Add(_TabItem7);
            _TabControl2.Tabs.Add(_TabItem4);
            _TabControl2.Tabs.Add(_TabItem5);
            _TabControl2.Tabs.Add(_TabItem6);
            // 
            // TabControlPanel1
            // 
            _TabControlPanel1.Controls.Add(_ComboBoxEx_NotifyOnRomChanges);
            _TabControlPanel1.Controls.Add(_ComboBoxEx_Language);
            _TabControlPanel1.Controls.Add(_LabelX12);
            _TabControlPanel1.Controls.Add(_LabelX11);
            _TabControlPanel1.Controls.Add(_ComboBoxEx_AutoScaleMode);
            _TabControlPanel1.Controls.Add(_LabelX5);
            _TabControlPanel1.Controls.Add(_ButtonX4);
            _TabControlPanel1.Controls.Add(_ComboBoxEx1);
            _TabControlPanel1.Controls.Add(_LabelX10);
            _TabControlPanel1.Controls.Add(_LabelX3);
            _TabControlPanel1.Controls.Add(_ComboBox_DefaultValueType);
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
            // ComboBoxEx_NotifyOnRomChanges
            // 
            resources.ApplyResources(_ComboBoxEx_NotifyOnRomChanges, "ComboBoxEx_NotifyOnRomChanges");
            _ComboBoxEx_NotifyOnRomChanges.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_NotifyOnRomChanges.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_NotifyOnRomChanges.ForeColor = Color.Black;
            _ComboBoxEx_NotifyOnRomChanges.FormattingEnabled = true;
            _ComboBoxEx_NotifyOnRomChanges.Items.AddRange(new object[] { _ComboItem4, _ComboItem5, _ComboItem11 });
            _ComboBoxEx_NotifyOnRomChanges.Name = "ComboBoxEx_NotifyOnRomChanges";
            _ComboBoxEx_NotifyOnRomChanges.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem4
            // 
            resources.ApplyResources(_ComboItem4, "ComboItem4");
            // 
            // ComboItem5
            // 
            resources.ApplyResources(_ComboItem5, "ComboItem5");
            // 
            // ComboItem11
            // 
            resources.ApplyResources(_ComboItem11, "ComboItem11");
            // 
            // ComboBoxEx_Language
            // 
            resources.ApplyResources(_ComboBoxEx_Language, "ComboBoxEx_Language");
            _ComboBoxEx_Language.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_Language.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_Language.ForeColor = Color.Black;
            _ComboBoxEx_Language.FormattingEnabled = true;
            _ComboBoxEx_Language.Items.AddRange(new object[] { _ComboItem_AutoLang });
            _ComboBoxEx_Language.Name = "ComboBoxEx_Language";
            _ComboBoxEx_Language.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem_AutoLang
            // 
            resources.ApplyResources(_ComboItem_AutoLang, "ComboItem_AutoLang");
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
            _LabelX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
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
            _LabelX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ComboBoxEx_AutoScaleMode
            // 
            resources.ApplyResources(_ComboBoxEx_AutoScaleMode, "ComboBoxEx_AutoScaleMode");
            _ComboBoxEx_AutoScaleMode.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_AutoScaleMode.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_AutoScaleMode.ForeColor = Color.Black;
            _ComboBoxEx_AutoScaleMode.FormattingEnabled = true;
            _ComboBoxEx_AutoScaleMode.Items.AddRange(new object[] { _ComboItem6, _ComboItem9, _ComboItem10 });
            _ComboBoxEx_AutoScaleMode.Name = "ComboBoxEx_AutoScaleMode";
            _ComboBoxEx_AutoScaleMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem6
            // 
            resources.ApplyResources(_ComboItem6, "ComboItem6");
            // 
            // ComboItem9
            // 
            resources.ApplyResources(_ComboItem9, "ComboItem9");
            // 
            // ComboItem10
            // 
            resources.ApplyResources(_ComboItem10, "ComboItem10");
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
            _LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ButtonX4
            // 
            _ButtonX4.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX4, "ButtonX4");
            _ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX4.Name = "ButtonX4";
            _ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBoxEx1
            // 
            resources.ApplyResources(_ComboBoxEx1, "ComboBoxEx1");
            _ComboBoxEx1.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx1.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx1.ForeColor = Color.Black;
            _ComboBoxEx1.FormattingEnabled = true;
            _ComboBoxEx1.Items.AddRange(new object[] { _ComboItem1, _ComboItem2, _ComboItem3 });
            _ComboBoxEx1.Name = "ComboBoxEx1";
            _ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            // LabelX10
            // 
            _LabelX10.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX10, "LabelX10");
            _LabelX10.Name = "LabelX10";
            _LabelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // TabItem1
            // 
            _TabItem1.AttachedControl = _TabControlPanel1;
            _TabItem1.Name = "TabItem1";
            resources.ApplyResources(_TabItem1, "TabItem1");
            // 
            // TabControlPanel7
            // 
            _TabControlPanel7.Controls.Add(_TextBoxX_ProxyPwd);
            _TabControlPanel7.Controls.Add(_TextBoxX_ProxyUsr);
            _TabControlPanel7.Controls.Add(_LabelX16);
            _TabControlPanel7.Controls.Add(_LabelX13);
            _TabControlPanel7.Controls.Add(_LabelX1);
            _TabControlPanel7.Controls.Add(_SwitchButton_SearchUpdates);
            _TabControlPanel7.Controls.Add(_ComboBoxEx_UpdateLevel);
            _TabControlPanel7.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel7, "TabControlPanel7");
            _TabControlPanel7.Name = "TabControlPanel7";
            _TabControlPanel7.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel7.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel7.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel7.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel7.Style.GradientAngle = 90;
            _TabControlPanel7.TabItem = _TabItem8;
            // 
            // TextBoxX_ProxyPwd
            // 
            // 
            // 
            // 
            _TextBoxX_ProxyPwd.Border.Class = "TextBoxBorder";
            _TextBoxX_ProxyPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_TextBoxX_ProxyPwd, "TextBoxX_ProxyPwd");
            _TextBoxX_ProxyPwd.Name = "TextBoxX_ProxyPwd";
            _TextBoxX_ProxyPwd.PreventEnterBeep = true;
            _TextBoxX_ProxyPwd.UseSystemPasswordChar = true;
            _TextBoxX_ProxyPwd.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            // 
            // TextBoxX_ProxyUsr
            // 
            // 
            // 
            // 
            _TextBoxX_ProxyUsr.Border.Class = "TextBoxBorder";
            _TextBoxX_ProxyUsr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_TextBoxX_ProxyUsr, "TextBoxX_ProxyUsr");
            _TextBoxX_ProxyUsr.Name = "TextBoxX_ProxyUsr";
            _TextBoxX_ProxyUsr.PreventEnterBeep = true;
            _TextBoxX_ProxyUsr.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            // 
            // LabelX16
            // 
            _LabelX16.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX16, "LabelX16");
            _LabelX16.Name = "LabelX16";
            _LabelX16.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
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
            _LabelX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ComboBoxEx_UpdateLevel
            // 
            resources.ApplyResources(_ComboBoxEx_UpdateLevel, "ComboBoxEx_UpdateLevel");
            _ComboBoxEx_UpdateLevel.DisplayMember = "Text";
            _ComboBoxEx_UpdateLevel.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_UpdateLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_UpdateLevel.FormattingEnabled = true;
            _ComboBoxEx_UpdateLevel.Items.AddRange(new object[] { _ComboItem12, _ComboItem13, _ComboItem14 });
            _ComboBoxEx_UpdateLevel.Name = "ComboBoxEx_UpdateLevel";
            _ComboBoxEx_UpdateLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem12
            // 
            resources.ApplyResources(_ComboItem12, "ComboItem12");
            // 
            // ComboItem13
            // 
            resources.ApplyResources(_ComboItem13, "ComboItem13");
            // 
            // ComboItem14
            // 
            resources.ApplyResources(_ComboItem14, "ComboItem14");
            // 
            // TabItem8
            // 
            _TabItem8.AttachedControl = _TabControlPanel7;
            _TabItem8.Name = "TabItem8";
            resources.ApplyResources(_TabItem8, "TabItem8");
            // 
            // TabControlPanel6
            // 
            _TabControlPanel6.Controls.Add(_LabelX15);
            _TabControlPanel6.Controls.Add(_SwitchButton_TMForceUppercase);
            _TabControlPanel6.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel6, "TabControlPanel6");
            _TabControlPanel6.Name = "TabControlPanel6";
            _TabControlPanel6.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel6.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel6.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel6.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel6.Style.GradientAngle = 90;
            _TabControlPanel6.TabItem = _TabItem7;
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
            _LabelX15.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_TMForceUppercase
            // 
            resources.ApplyResources(_SwitchButton_TMForceUppercase, "SwitchButton_TMForceUppercase");
            // 
            // 
            // 
            _SwitchButton_TMForceUppercase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_TMForceUppercase.Name = "SwitchButton_TMForceUppercase";
            _SwitchButton_TMForceUppercase.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_TMForceUppercase.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_TMForceUppercase.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_TMForceUppercase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_TMForceUppercase.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_TMForceUppercase.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_TMForceUppercase.SwitchWidth = 15;
            _SwitchButton_TMForceUppercase.Value = true;
            _SwitchButton_TMForceUppercase.ValueObject = "Y";
            // 
            // TabItem7
            // 
            _TabItem7.AttachedControl = _TabControlPanel6;
            _TabItem7.Name = "TabItem7";
            resources.ApplyResources(_TabItem7, "TabItem7");
            // 
            // TabControlPanel5
            // 
            _TabControlPanel5.Controls.Add(_ButtonX6);
            _TabControlPanel5.Controls.Add(_LabelX14);
            _TabControlPanel5.Controls.Add(_SwitchButton_UseLegacyCollisionDescriptions);
            _TabControlPanel5.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel5, "TabControlPanel5");
            _TabControlPanel5.Name = "TabControlPanel5";
            _TabControlPanel5.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel5.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel5.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel5.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel5.Style.GradientAngle = 90;
            _TabControlPanel5.TabItem = _TabItem6;
            // 
            // ButtonX6
            // 
            _ButtonX6.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX6, "ButtonX6");
            _ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX6.Name = "ButtonX6";
            _ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX14
            // 
            _LabelX14.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX14, "LabelX14");
            _LabelX14.Name = "LabelX14";
            _LabelX14.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_UseLegacyCollisionDescriptions
            // 
            resources.ApplyResources(_SwitchButton_UseLegacyCollisionDescriptions, "SwitchButton_UseLegacyCollisionDescriptions");
            // 
            // 
            // 
            _SwitchButton_UseLegacyCollisionDescriptions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_UseLegacyCollisionDescriptions.Name = "SwitchButton_UseLegacyCollisionDescriptions";
            _SwitchButton_UseLegacyCollisionDescriptions.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_UseLegacyCollisionDescriptions.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_UseLegacyCollisionDescriptions.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_UseLegacyCollisionDescriptions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_UseLegacyCollisionDescriptions.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_UseLegacyCollisionDescriptions.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_UseLegacyCollisionDescriptions.SwitchWidth = 15;
            // 
            // TabItem6
            // 
            _TabItem6.AttachedControl = _TabControlPanel5;
            _TabItem6.Name = "TabItem6";
            resources.ApplyResources(_TabItem6, "TabItem6");
            // 
            // TabControlPanel4
            // 
            _TabControlPanel4.Controls.Add(_LabelX9);
            _TabControlPanel4.Controls.Add(_ButtonX2);
            _TabControlPanel4.Controls.Add(_TextBoxX_HexEditorCustomPath);
            _TabControlPanel4.Controls.Add(_ButtonX5);
            _TabControlPanel4.Controls.Add(_TextBoxX_EmulatorPatch);
            _TabControlPanel4.Controls.Add(_ButtonX3);
            _TabControlPanel4.Controls.Add(_ComboBoxEx_HexEditorMode);
            _TabControlPanel4.Controls.Add(_LabelX4);
            _TabControlPanel4.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel4, "TabControlPanel4");
            _TabControlPanel4.Name = "TabControlPanel4";
            _TabControlPanel4.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel4.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel4.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel4.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel4.Style.GradientAngle = 90;
            _TabControlPanel4.TabItem = _TabItem5;
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
            _LabelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ButtonX2
            // 
            _ButtonX2.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX2, "ButtonX2");
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX2.FocusCuesEnabled = false;
            _ButtonX2.Image = My.Resources.MyIcons.icons8_folder_16px;
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX2.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX2.SymbolSize = 12.0F;
            // 
            // TextBoxX_HexEditorCustomPath
            // 
            resources.ApplyResources(_TextBoxX_HexEditorCustomPath, "TextBoxX_HexEditorCustomPath");
            _TextBoxX_HexEditorCustomPath.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_HexEditorCustomPath.Border.Class = "TextBoxBorder";
            _TextBoxX_HexEditorCustomPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_HexEditorCustomPath.DisabledBackColor = Color.White;
            _TextBoxX_HexEditorCustomPath.ForeColor = Color.Black;
            _TextBoxX_HexEditorCustomPath.Name = "TextBoxX_HexEditorCustomPath";
            _TextBoxX_HexEditorCustomPath.PreventEnterBeep = true;
            // 
            // ButtonX5
            // 
            _ButtonX5.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX5, "ButtonX5");
            _ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX5.FocusCuesEnabled = false;
            _ButtonX5.Image = My.Resources.MyIcons.icons8_folder_16px;
            _ButtonX5.Name = "ButtonX5";
            _ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX5.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _ButtonX5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX5.SymbolSize = 12.0F;
            // 
            // TextBoxX_EmulatorPatch
            // 
            resources.ApplyResources(_TextBoxX_EmulatorPatch, "TextBoxX_EmulatorPatch");
            _TextBoxX_EmulatorPatch.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_EmulatorPatch.Border.Class = "TextBoxBorder";
            _TextBoxX_EmulatorPatch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_EmulatorPatch.DisabledBackColor = Color.White;
            _TextBoxX_EmulatorPatch.ForeColor = Color.Black;
            _TextBoxX_EmulatorPatch.Name = "TextBoxX_EmulatorPatch";
            _TextBoxX_EmulatorPatch.PreventEnterBeep = true;
            // 
            // ButtonX3
            // 
            _ButtonX3.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX3, "ButtonX3");
            _ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX3.FocusCuesEnabled = false;
            _ButtonX3.Name = "ButtonX3";
            _ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // ComboBoxEx_HexEditorMode
            // 
            resources.ApplyResources(_ComboBoxEx_HexEditorMode, "ComboBoxEx_HexEditorMode");
            _ComboBoxEx_HexEditorMode.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_HexEditorMode.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_HexEditorMode.ForeColor = Color.Black;
            _ComboBoxEx_HexEditorMode.FormattingEnabled = true;
            _ComboBoxEx_HexEditorMode.Items.AddRange(new object[] { _ComboItem7, _ComboItem8 });
            _ComboBoxEx_HexEditorMode.Name = "ComboBoxEx_HexEditorMode";
            _ComboBoxEx_HexEditorMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem7
            // 
            resources.ApplyResources(_ComboItem7, "ComboItem7");
            // 
            // ComboItem8
            // 
            resources.ApplyResources(_ComboItem8, "ComboItem8");
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
            _LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // TabItem5
            // 
            _TabItem5.AttachedControl = _TabControlPanel4;
            _TabItem5.Name = "TabItem5";
            resources.ApplyResources(_TabItem5, "TabItem5");
            // 
            // TabControlPanel_LoaderModules
            // 
            _TabControlPanel_LoaderModules.Controls.Add(_ComboBoxEx_ExporterModule);
            _TabControlPanel_LoaderModules.Controls.Add(_LabelX8);
            _TabControlPanel_LoaderModules.Controls.Add(_ComboBoxEx_LoaderModule);
            _TabControlPanel_LoaderModules.Controls.Add(_LabelX2);
            _TabControlPanel_LoaderModules.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel_LoaderModules, "TabControlPanel_LoaderModules");
            _TabControlPanel_LoaderModules.Name = "TabControlPanel_LoaderModules";
            _TabControlPanel_LoaderModules.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel_LoaderModules.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel_LoaderModules.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel_LoaderModules.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel_LoaderModules.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel_LoaderModules.Style.GradientAngle = 90;
            _TabControlPanel_LoaderModules.TabItem = _TabItem4;
            // 
            // ComboBoxEx_ExporterModule
            // 
            resources.ApplyResources(_ComboBoxEx_ExporterModule, "ComboBoxEx_ExporterModule");
            _ComboBoxEx_ExporterModule.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_ExporterModule.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_ExporterModule.ForeColor = Color.Black;
            _ComboBoxEx_ExporterModule.FormattingEnabled = true;
            _ComboBoxEx_ExporterModule.Name = "ComboBoxEx_ExporterModule";
            _ComboBoxEx_ExporterModule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            _LabelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ComboBoxEx_LoaderModule
            // 
            resources.ApplyResources(_ComboBoxEx_LoaderModule, "ComboBoxEx_LoaderModule");
            _ComboBoxEx_LoaderModule.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_LoaderModule.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_LoaderModule.ForeColor = Color.Black;
            _ComboBoxEx_LoaderModule.FormattingEnabled = true;
            _ComboBoxEx_LoaderModule.Name = "ComboBoxEx_LoaderModule";
            _ComboBoxEx_LoaderModule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            _LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // TabItem4
            // 
            _TabItem4.AttachedControl = _TabControlPanel_LoaderModules;
            _TabItem4.Name = "TabItem4";
            resources.ApplyResources(_TabItem4, "TabItem4");
            // 
            // TabControlPanel3
            // 
            _TabControlPanel3.Controls.Add(_ButtonX1);
            _TabControlPanel3.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_TabControlPanel3, "TabControlPanel3");
            _TabControlPanel3.Name = "TabControlPanel3";
            _TabControlPanel3.Style.BackColor1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(227)), Conversions.ToInteger(Conversions.ToByte(239)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel3.Style.BackColor2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(176)), Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(255)));
            _TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _TabControlPanel3.Style.BorderColor.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(146)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(199)));
            _TabControlPanel3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Bottom;
            _TabControlPanel3.Style.GradientAngle = 90;
            _TabControlPanel3.TabItem = _TabItem3;
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.FocusCuesEnabled = false;
            resources.ApplyResources(_ButtonX1, "ButtonX1");
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // TabItem3
            // 
            _TabItem3.AttachedControl = _TabControlPanel3;
            _TabItem3.Name = "TabItem3";
            resources.ApplyResources(_TabItem3, "TabItem3");
            _TabItem3.Visible = false;
            // 
            // TabControlPanel2
            // 
            _TabControlPanel2.Controls.Add(_LabelX6);
            _TabControlPanel2.Controls.Add(_ComboBox_AreaEditor_DefaultCameraMode);
            _TabControlPanel2.Controls.Add(_ComboBox_AreaEditor_DefaultWindowMode);
            _TabControlPanel2.Controls.Add(_LabelX7);
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
            // TabItem2
            // 
            _TabItem2.AttachedControl = _TabControlPanel2;
            _TabItem2.Name = "TabItem2";
            resources.ApplyResources(_TabItem2, "TabItem2");
            // 
            // SuperTooltip1
            // 
            resources.ApplyResources(_SuperTooltip1, "SuperTooltip1");
            _SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // PictureBox_Warning
            // 
            resources.ApplyResources(_PictureBox_Warning, "PictureBox_Warning");
            _PictureBox_Warning.BackColor = Color.Transparent;
            _PictureBox_Warning.Image = My.Resources.MyIcons.icons8_error_16px;
            _PictureBox_Warning.Name = "PictureBox_Warning";
            _PictureBox_Warning.TabStop = false;
            // 
            // Form_Settings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_PictureBox_Warning);
            Controls.Add(_TabControl2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Settings";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_TabControl2).EndInit();
            _TabControl2.ResumeLayout(false);
            _TabControlPanel1.ResumeLayout(false);
            _TabControlPanel7.ResumeLayout(false);
            _TabControlPanel6.ResumeLayout(false);
            _TabControlPanel5.ResumeLayout(false);
            _TabControlPanel4.ResumeLayout(false);
            _TabControlPanel_LoaderModules.ResumeLayout(false);
            _TabControlPanel3.ResumeLayout(false);
            _TabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_PictureBox_Warning).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_SearchUpdates;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_SearchUpdates
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_SearchUpdates;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_SearchUpdates != null)
                {
                }

                _SwitchButton_SearchUpdates = value;
                if (_SwitchButton_SearchUpdates != null)
                {
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_DefaultValueType;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_DefaultValueType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_DefaultValueType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_DefaultValueType != null)
                {
                }

                _ComboBox_DefaultValueType = value;
                if (_ComboBox_DefaultValueType != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_AreaEditor_DefaultWindowMode;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_AreaEditor_DefaultWindowMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_AreaEditor_DefaultWindowMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_AreaEditor_DefaultWindowMode != null)
                {
                }

                _ComboBox_AreaEditor_DefaultWindowMode = value;
                if (_ComboBox_AreaEditor_DefaultWindowMode != null)
                {
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_AreaEditor_DefaultCameraMode;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_AreaEditor_DefaultCameraMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_AreaEditor_DefaultCameraMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_AreaEditor_DefaultCameraMode != null)
                {
                }

                _ComboBox_AreaEditor_DefaultCameraMode = value;
                if (_ComboBox_AreaEditor_DefaultCameraMode != null)
                {
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

        private DevComponents.DotNetBar.TabControl _TabControl2;

        internal DevComponents.DotNetBar.TabControl TabControl2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControl2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControl2 != null)
                {
                }

                _TabControl2 = value;
                if (_TabControl2 != null)
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

        private DevComponents.DotNetBar.TabItem _TabItem3;

        internal DevComponents.DotNetBar.TabItem TabItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem3 != null)
                {
                }

                _TabItem3 = value;
                if (_TabItem3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX1;

        internal DevComponents.DotNetBar.ButtonX ButtonX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX1 != null)
                {
                    _ButtonX1.Click -= ButtonX1_Click;
                }

                _ButtonX1 = value;
                if (_ButtonX1 != null)
                {
                    _ButtonX1.Click += ButtonX1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.TabControlPanel _TabControlPanel_LoaderModules;

        internal DevComponents.DotNetBar.TabControlPanel TabControlPanel_LoaderModules
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControlPanel_LoaderModules;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControlPanel_LoaderModules != null)
                {
                }

                _TabControlPanel_LoaderModules = value;
                if (_TabControlPanel_LoaderModules != null)
                {
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_LoaderModule;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_LoaderModule
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_LoaderModule;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_LoaderModule != null)
                {
                }

                _ComboBoxEx_LoaderModule = value;
                if (_ComboBoxEx_LoaderModule != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX2;

        internal DevComponents.DotNetBar.ButtonX ButtonX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX2 != null)
                {
                    _ButtonX2.Click -= ButtonX2_Click;
                }

                _ButtonX2 = value;
                if (_ButtonX2 != null)
                {
                    _ButtonX2.Click += ButtonX2_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_EmulatorPatch;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_EmulatorPatch
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_EmulatorPatch;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_EmulatorPatch != null)
                {
                }

                _TextBoxX_EmulatorPatch = value;
                if (_TextBoxX_EmulatorPatch != null)
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

        private DevComponents.DotNetBar.ButtonX _ButtonX3;

        internal DevComponents.DotNetBar.ButtonX ButtonX3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX3 != null)
                {
                    _ButtonX3.Click -= ButtonX3_Click;
                }

                _ButtonX3 = value;
                if (_ButtonX3 != null)
                {
                    _ButtonX3.Click += ButtonX3_Click;
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx1;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx1 != null)
                {
                }

                _ComboBoxEx1 = value;
                if (_ComboBoxEx1 != null)
                {
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

        private DevComponents.DotNetBar.ButtonX _ButtonX4;

        internal DevComponents.DotNetBar.ButtonX ButtonX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX4 != null)
                {
                    _ButtonX4.Click -= ButtonX4_Click;
                }

                _ButtonX4 = value;
                if (_ButtonX4 != null)
                {
                    _ButtonX4.Click += ButtonX4_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_HexEditorCustomPath;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_HexEditorCustomPath
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_HexEditorCustomPath;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_HexEditorCustomPath != null)
                {
                }

                _TextBoxX_HexEditorCustomPath = value;
                if (_TextBoxX_HexEditorCustomPath != null)
                {
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_HexEditorMode;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_HexEditorMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_HexEditorMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_HexEditorMode != null)
                {
                    _ComboBoxEx_HexEditorMode.SelectedIndexChanged -= ComboBoxEx2_SelectedIndexChanged;
                }

                _ComboBoxEx_HexEditorMode = value;
                if (_ComboBoxEx_HexEditorMode != null)
                {
                    _ComboBoxEx_HexEditorMode.SelectedIndexChanged += ComboBoxEx2_SelectedIndexChanged;
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

        private DevComponents.DotNetBar.ButtonX _ButtonX5;

        internal DevComponents.DotNetBar.ButtonX ButtonX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX5 != null)
                {
                    _ButtonX5.Click -= ButtonX5_Click;
                }

                _ButtonX5 = value;
                if (_ButtonX5 != null)
                {
                    _ButtonX5.Click += ButtonX5_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_AutoScaleMode;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_AutoScaleMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_AutoScaleMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_AutoScaleMode != null)
                {
                }

                _ComboBoxEx_AutoScaleMode = value;
                if (_ComboBoxEx_AutoScaleMode != null)
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

        private DevComponents.Editors.ComboItem _ComboItem9;

        internal DevComponents.Editors.ComboItem ComboItem9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem9 != null)
                {
                }

                _ComboItem9 = value;
                if (_ComboItem9 != null)
                {
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_ExporterModule;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_ExporterModule
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_ExporterModule;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_ExporterModule != null)
                {
                }

                _ComboBoxEx_ExporterModule = value;
                if (_ComboBoxEx_ExporterModule != null)
                {
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_Language;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Language
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_Language;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_Language != null)
                {
                    _ComboBoxEx_Language.SelectedIndexChanged -= ComboBoxEx_Language_SelectedIndexChanged;
                }

                _ComboBoxEx_Language = value;
                if (_ComboBoxEx_Language != null)
                {
                    _ComboBoxEx_Language.SelectedIndexChanged += ComboBoxEx_Language_SelectedIndexChanged;
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

        private DevComponents.Editors.ComboItem _ComboItem_AutoLang;

        internal DevComponents.Editors.ComboItem ComboItem_AutoLang
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem_AutoLang;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem_AutoLang != null)
                {
                }

                _ComboItem_AutoLang = value;
                if (_ComboItem_AutoLang != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.SuperTooltip _SuperTooltip1;

        internal DevComponents.DotNetBar.SuperTooltip SuperTooltip1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTooltip1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTooltip1 != null)
                {
                }

                _SuperTooltip1 = value;
                if (_SuperTooltip1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_NotifyOnRomChanges;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_NotifyOnRomChanges
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_NotifyOnRomChanges;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_NotifyOnRomChanges != null)
                {
                    _ComboBoxEx_NotifyOnRomChanges.SelectedIndexChanged -= ComboBoxEx_Language_SelectedIndexChanged;
                }

                _ComboBoxEx_NotifyOnRomChanges = value;
                if (_ComboBoxEx_NotifyOnRomChanges != null)
                {
                    _ComboBoxEx_NotifyOnRomChanges.SelectedIndexChanged += ComboBoxEx_Language_SelectedIndexChanged;
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

        private DevComponents.Editors.ComboItem _ComboItem4;

        internal DevComponents.Editors.ComboItem ComboItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem4 != null)
                {
                }

                _ComboItem4 = value;
                if (_ComboItem4 != null)
                {
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

        private DevComponents.Editors.ComboItem _ComboItem11;

        internal DevComponents.Editors.ComboItem ComboItem11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem11 != null)
                {
                }

                _ComboItem11 = value;
                if (_ComboItem11 != null)
                {
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_UpdateLevel;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_UpdateLevel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_UpdateLevel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_UpdateLevel != null)
                {
                    _ComboBoxEx_UpdateLevel.SelectedIndexChanged -= ComboBoxEx_Language_SelectedIndexChanged;
                }

                _ComboBoxEx_UpdateLevel = value;
                if (_ComboBoxEx_UpdateLevel != null)
                {
                    _ComboBoxEx_UpdateLevel.SelectedIndexChanged += ComboBoxEx_Language_SelectedIndexChanged;
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

        private DevComponents.Editors.ComboItem _ComboItem14;

        internal DevComponents.Editors.ComboItem ComboItem14
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem14;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem14 != null)
                {
                }

                _ComboItem14 = value;
                if (_ComboItem14 != null)
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

        private DevComponents.DotNetBar.LabelX _LabelX14;

        internal DevComponents.DotNetBar.LabelX LabelX14
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX14;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX14 != null)
                {
                }

                _LabelX14 = value;
                if (_LabelX14 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_UseLegacyCollisionDescriptions;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_UseLegacyCollisionDescriptions
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_UseLegacyCollisionDescriptions;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_UseLegacyCollisionDescriptions != null)
                {
                    _SwitchButton_UseLegacyCollisionDescriptions.ValueChanged -= ComboBoxEx_Language_SelectedIndexChanged;
                }

                _SwitchButton_UseLegacyCollisionDescriptions = value;
                if (_SwitchButton_UseLegacyCollisionDescriptions != null)
                {
                    _SwitchButton_UseLegacyCollisionDescriptions.ValueChanged += ComboBoxEx_Language_SelectedIndexChanged;
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

        private DevComponents.DotNetBar.ButtonX _ButtonX6;

        internal DevComponents.DotNetBar.ButtonX ButtonX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX6 != null)
                {
                    _ButtonX6.Click -= ButtonX6_Click;
                }

                _ButtonX6 = value;
                if (_ButtonX6 != null)
                {
                    _ButtonX6.Click += ButtonX6_Click;
                }
            }
        }

        private PictureBox _PictureBox_Warning;

        internal PictureBox PictureBox_Warning
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox_Warning;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox_Warning != null)
                {
                }

                _PictureBox_Warning = value;
                if (_PictureBox_Warning != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabControlPanel _TabControlPanel7;

        internal DevComponents.DotNetBar.TabControlPanel TabControlPanel7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControlPanel7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControlPanel7 != null)
                {
                }

                _TabControlPanel7 = value;
                if (_TabControlPanel7 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.TabItem _TabItem8;

        internal DevComponents.DotNetBar.TabItem TabItem8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem8 != null)
                {
                }

                _TabItem8 = value;
                if (_TabItem8 != null)
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

        private DevComponents.DotNetBar.TabItem _TabItem7;

        internal DevComponents.DotNetBar.TabItem TabItem7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabItem7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabItem7 != null)
                {
                }

                _TabItem7 = value;
                if (_TabItem7 != null)
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

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_TMForceUppercase;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_TMForceUppercase
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_TMForceUppercase;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_TMForceUppercase != null)
                {
                }

                _SwitchButton_TMForceUppercase = value;
                if (_SwitchButton_TMForceUppercase != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX16;

        internal DevComponents.DotNetBar.LabelX LabelX16
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX16;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX16 != null)
                {
                }

                _LabelX16 = value;
                if (_LabelX16 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ProxyPwd;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ProxyPwd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ProxyPwd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ProxyPwd != null)
                {
                }

                _TextBoxX_ProxyPwd = value;
                if (_TextBoxX_ProxyPwd != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ProxyUsr;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ProxyUsr
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ProxyUsr;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ProxyUsr != null)
                {
                }

                _TextBoxX_ProxyUsr = value;
                if (_TextBoxX_ProxyUsr != null)
                {
                }
            }
        }
    }
}