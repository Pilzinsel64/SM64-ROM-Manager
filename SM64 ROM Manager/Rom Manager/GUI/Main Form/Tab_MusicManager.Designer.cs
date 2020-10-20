using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Tab_MusicManager : UserControl
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_MusicManager));
            _GroupPanel12 = new DevComponents.DotNetBar.Controls.GroupPanel();
            _LabelX56 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_MS_OverwriteSizeRestrictions = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_MS_OverwriteSizeRestrictions.ValueChanged += new EventHandler(SwitchButton_MS_OverwriteSizeRestrictions_ValueChanged);
            _GroupBox_MS_SeqProperties = new DevComponents.DotNetBar.Controls.GroupPanel();
            _LabelX_MS_SeqSize = new DevComponents.DotNetBar.LabelX();
            _LabelX33 = new DevComponents.DotNetBar.LabelX();
            _LabelX28 = new DevComponents.DotNetBar.LabelX();
            _LabelX_MS_SequenceID = new DevComponents.DotNetBar.LabelX();
            _GroupBox_MS_SelectedSequence = new DevComponents.DotNetBar.Controls.GroupPanel();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _ComboBox_MS_NInst = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_MS_NInst.SelectedIndexChanged += new EventHandler(ComboBox_MS_NInst_SelectedIndexChanged);
            _LabelX32 = new DevComponents.DotNetBar.LabelX();
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_MS_Sequencename = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_MS_Sequencename.TextChanged += new EventHandler(MusicSettings_SequenceNameChanged);
            _Button_MS_ExtractSequence = new DevComponents.DotNetBar.ButtonX();
            _Button_MS_ExtractSequence.Click += new EventHandler(Button_MS_ExtractSequence_Click);
            _Button_MS_ReplaceSequence = new DevComponents.DotNetBar.ButtonX();
            _Button_MS_ReplaceSequence.Click += new EventHandler(Button_MS_ReplaceSequence_Click);
            _Line6 = new DevComponents.DotNetBar.Controls.Line();
            _GroupPanel9 = new DevComponents.DotNetBar.Controls.GroupPanel();
            _ButtonX_MS_RemoveSequence = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_MS_RemoveSequence.Click += new EventHandler(ButtonX_MS_RemoveSequence_Click);
            _ButtonX_MS_AddSequence = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_MS_AddSequence.Click += new EventHandler(ButtonX_MS_AddSequence_Click);
            _ListBoxAdv_MS_MusicSequences = new Publics.Controls.ItemListBox();
            _ListBoxAdv_MS_MusicSequences.SelectedItemChanged += new Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(ListBoxAdv_MS_MusicSequences_SelectedIndexChanged);
            _GroupPanel12.SuspendLayout();
            _GroupBox_MS_SeqProperties.SuspendLayout();
            _GroupBox_MS_SelectedSequence.SuspendLayout();
            _GroupPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // GroupPanel12
            // 
            _GroupPanel12.BackColor = Color.White;
            _GroupPanel12.CanvasColor = Color.Empty;
            _GroupPanel12.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _GroupPanel12.Controls.Add(_LabelX56);
            _GroupPanel12.Controls.Add(_SwitchButton_MS_OverwriteSizeRestrictions);
            _GroupPanel12.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_GroupPanel12, "GroupPanel12");
            _GroupPanel12.Name = "GroupPanel12";
            // 
            // 
            // 
            _GroupPanel12.Style.BackColorGradientAngle = 90;
            _GroupPanel12.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel12.Style.BorderBottomWidth = 1;
            _GroupPanel12.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel12.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel12.Style.BorderLeftWidth = 1;
            _GroupPanel12.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel12.Style.BorderRightWidth = 1;
            _GroupPanel12.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel12.Style.BorderTopWidth = 1;
            _GroupPanel12.Style.CornerDiameter = 4;
            _GroupPanel12.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel12.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel12.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel12.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel12.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel12.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // LabelX56
            // 
            _LabelX56.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX56.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX56, "LabelX56");
            _LabelX56.Name = "LabelX56";
            _LabelX56.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_MS_OverwriteSizeRestrictions
            // 
            // 
            // 
            // 
            _SwitchButton_MS_OverwriteSizeRestrictions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_MS_OverwriteSizeRestrictions.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_MS_OverwriteSizeRestrictions, "SwitchButton_MS_OverwriteSizeRestrictions");
            _SwitchButton_MS_OverwriteSizeRestrictions.Name = "SwitchButton_MS_OverwriteSizeRestrictions";
            _SwitchButton_MS_OverwriteSizeRestrictions.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_MS_OverwriteSizeRestrictions.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_MS_OverwriteSizeRestrictions.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_MS_OverwriteSizeRestrictions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_MS_OverwriteSizeRestrictions.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_MS_OverwriteSizeRestrictions.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_MS_OverwriteSizeRestrictions.SwitchWidth = 15;
            // 
            // GroupBox_MS_SeqProperties
            // 
            _GroupBox_MS_SeqProperties.BackColor = Color.White;
            _GroupBox_MS_SeqProperties.CanvasColor = Color.Empty;
            _GroupBox_MS_SeqProperties.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _GroupBox_MS_SeqProperties.Controls.Add(_LabelX_MS_SeqSize);
            _GroupBox_MS_SeqProperties.Controls.Add(_LabelX33);
            _GroupBox_MS_SeqProperties.Controls.Add(_LabelX28);
            _GroupBox_MS_SeqProperties.Controls.Add(_LabelX_MS_SequenceID);
            _GroupBox_MS_SeqProperties.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_GroupBox_MS_SeqProperties, "GroupBox_MS_SeqProperties");
            _GroupBox_MS_SeqProperties.Name = "GroupBox_MS_SeqProperties";
            // 
            // 
            // 
            _GroupBox_MS_SeqProperties.Style.BackColorGradientAngle = 90;
            _GroupBox_MS_SeqProperties.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_MS_SeqProperties.Style.BorderBottomWidth = 1;
            _GroupBox_MS_SeqProperties.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupBox_MS_SeqProperties.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_MS_SeqProperties.Style.BorderLeftWidth = 1;
            _GroupBox_MS_SeqProperties.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_MS_SeqProperties.Style.BorderRightWidth = 1;
            _GroupBox_MS_SeqProperties.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_MS_SeqProperties.Style.BorderTopWidth = 1;
            _GroupBox_MS_SeqProperties.Style.CornerDiameter = 4;
            _GroupBox_MS_SeqProperties.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupBox_MS_SeqProperties.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupBox_MS_SeqProperties.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupBox_MS_SeqProperties.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupBox_MS_SeqProperties.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupBox_MS_SeqProperties.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // LabelX_MS_SeqSize
            // 
            _LabelX_MS_SeqSize.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_MS_SeqSize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX_MS_SeqSize, "LabelX_MS_SeqSize");
            _LabelX_MS_SeqSize.Name = "LabelX_MS_SeqSize";
            _LabelX_MS_SeqSize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX33
            // 
            _LabelX33.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX33, "LabelX33");
            _LabelX33.Name = "LabelX33";
            _LabelX33.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX28
            // 
            _LabelX28.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX28, "LabelX28");
            _LabelX28.Name = "LabelX28";
            _LabelX28.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX_MS_SequenceID
            // 
            _LabelX_MS_SequenceID.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_MS_SequenceID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX_MS_SequenceID, "LabelX_MS_SequenceID");
            _LabelX_MS_SequenceID.Name = "LabelX_MS_SequenceID";
            _LabelX_MS_SequenceID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // GroupBox_MS_SelectedSequence
            // 
            _GroupBox_MS_SelectedSequence.BackColor = Color.White;
            _GroupBox_MS_SelectedSequence.CanvasColor = Color.Empty;
            _GroupBox_MS_SelectedSequence.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _GroupBox_MS_SelectedSequence.Controls.Add(_ButtonX1);
            _GroupBox_MS_SelectedSequence.Controls.Add(_ComboBox_MS_NInst);
            _GroupBox_MS_SelectedSequence.Controls.Add(_LabelX32);
            _GroupBox_MS_SelectedSequence.Controls.Add(_LabelX5);
            _GroupBox_MS_SelectedSequence.Controls.Add(_TextBoxX_MS_Sequencename);
            _GroupBox_MS_SelectedSequence.Controls.Add(_Button_MS_ExtractSequence);
            _GroupBox_MS_SelectedSequence.Controls.Add(_Button_MS_ReplaceSequence);
            _GroupBox_MS_SelectedSequence.Controls.Add(_Line6);
            _GroupBox_MS_SelectedSequence.DisabledBackColor = Color.Empty;
            resources.ApplyResources(_GroupBox_MS_SelectedSequence, "GroupBox_MS_SelectedSequence");
            _GroupBox_MS_SelectedSequence.Name = "GroupBox_MS_SelectedSequence";
            // 
            // 
            // 
            _GroupBox_MS_SelectedSequence.Style.BackColorGradientAngle = 90;
            _GroupBox_MS_SelectedSequence.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_MS_SelectedSequence.Style.BorderBottomWidth = 1;
            _GroupBox_MS_SelectedSequence.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupBox_MS_SelectedSequence.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_MS_SelectedSequence.Style.BorderLeftWidth = 1;
            _GroupBox_MS_SelectedSequence.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_MS_SelectedSequence.Style.BorderRightWidth = 1;
            _GroupBox_MS_SelectedSequence.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupBox_MS_SelectedSequence.Style.BorderTopWidth = 1;
            _GroupBox_MS_SelectedSequence.Style.CornerDiameter = 4;
            _GroupBox_MS_SelectedSequence.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupBox_MS_SelectedSequence.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupBox_MS_SelectedSequence.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupBox_MS_SelectedSequence.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupBox_MS_SelectedSequence.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupBox_MS_SelectedSequence.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            // ComboBox_MS_NInst
            // 
            _ComboBox_MS_NInst.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_MS_NInst.DropDownHeight = 150;
            _ComboBox_MS_NInst.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_MS_NInst.ForeColor = Color.Black;
            _ComboBox_MS_NInst.FormattingEnabled = true;
            resources.ApplyResources(_ComboBox_MS_NInst, "ComboBox_MS_NInst");
            _ComboBox_MS_NInst.Items.AddRange(new object[] { resources.GetString("ComboBox_MS_NInst.Items"), resources.GetString("ComboBox_MS_NInst.Items1"), resources.GetString("ComboBox_MS_NInst.Items2"), resources.GetString("ComboBox_MS_NInst.Items3"), resources.GetString("ComboBox_MS_NInst.Items4"), resources.GetString("ComboBox_MS_NInst.Items5"), resources.GetString("ComboBox_MS_NInst.Items6"), resources.GetString("ComboBox_MS_NInst.Items7"), resources.GetString("ComboBox_MS_NInst.Items8"), resources.GetString("ComboBox_MS_NInst.Items9"), resources.GetString("ComboBox_MS_NInst.Items10"), resources.GetString("ComboBox_MS_NInst.Items11"), resources.GetString("ComboBox_MS_NInst.Items12"), resources.GetString("ComboBox_MS_NInst.Items13"), resources.GetString("ComboBox_MS_NInst.Items14"), resources.GetString("ComboBox_MS_NInst.Items15"), resources.GetString("ComboBox_MS_NInst.Items16"), resources.GetString("ComboBox_MS_NInst.Items17"), resources.GetString("ComboBox_MS_NInst.Items18"), resources.GetString("ComboBox_MS_NInst.Items19"), resources.GetString("ComboBox_MS_NInst.Items20"), resources.GetString("ComboBox_MS_NInst.Items21"), resources.GetString("ComboBox_MS_NInst.Items22"), resources.GetString("ComboBox_MS_NInst.Items23"), resources.GetString("ComboBox_MS_NInst.Items24"), resources.GetString("ComboBox_MS_NInst.Items25"), resources.GetString("ComboBox_MS_NInst.Items26"), resources.GetString("ComboBox_MS_NInst.Items27"), resources.GetString("ComboBox_MS_NInst.Items28"), resources.GetString("ComboBox_MS_NInst.Items29"), resources.GetString("ComboBox_MS_NInst.Items30"), resources.GetString("ComboBox_MS_NInst.Items31"), resources.GetString("ComboBox_MS_NInst.Items32"), resources.GetString("ComboBox_MS_NInst.Items33"), resources.GetString("ComboBox_MS_NInst.Items34"), resources.GetString("ComboBox_MS_NInst.Items35"), resources.GetString("ComboBox_MS_NInst.Items36"), resources.GetString("ComboBox_MS_NInst.Items37") });
            _ComboBox_MS_NInst.Name = "ComboBox_MS_NInst";
            _ComboBox_MS_NInst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX32
            // 
            _LabelX32.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX32, "LabelX32");
            _LabelX32.Name = "LabelX32";
            _LabelX32.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            _LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // TextBoxX_MS_Sequencename
            // 
            _TextBoxX_MS_Sequencename.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_MS_Sequencename.Border.Class = "TextBoxBorder";
            _TextBoxX_MS_Sequencename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_MS_Sequencename.DisabledBackColor = Color.White;
            _TextBoxX_MS_Sequencename.ForeColor = Color.Black;
            resources.ApplyResources(_TextBoxX_MS_Sequencename, "TextBoxX_MS_Sequencename");
            _TextBoxX_MS_Sequencename.Name = "TextBoxX_MS_Sequencename";
            _TextBoxX_MS_Sequencename.PreventEnterBeep = true;
            // 
            // Button_MS_ExtractSequence
            // 
            _Button_MS_ExtractSequence.AccessibleRole = AccessibleRole.PushButton;
            _Button_MS_ExtractSequence.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_MS_ExtractSequence.FocusCuesEnabled = false;
            resources.ApplyResources(_Button_MS_ExtractSequence, "Button_MS_ExtractSequence");
            _Button_MS_ExtractSequence.Name = "Button_MS_ExtractSequence";
            _Button_MS_ExtractSequence.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Button_MS_ReplaceSequence
            // 
            _Button_MS_ReplaceSequence.AccessibleRole = AccessibleRole.PushButton;
            _Button_MS_ReplaceSequence.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_MS_ReplaceSequence.FocusCuesEnabled = false;
            resources.ApplyResources(_Button_MS_ReplaceSequence, "Button_MS_ReplaceSequence");
            _Button_MS_ReplaceSequence.Name = "Button_MS_ReplaceSequence";
            _Button_MS_ReplaceSequence.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Line6
            // 
            _Line6.BackColor = Color.Transparent;
            _Line6.ForeColor = Color.Gainsboro;
            resources.ApplyResources(_Line6, "Line6");
            _Line6.Name = "Line6";
            // 
            // GroupPanel9
            // 
            resources.ApplyResources(_GroupPanel9, "GroupPanel9");
            _GroupPanel9.BackColor = Color.White;
            _GroupPanel9.CanvasColor = Color.Empty;
            _GroupPanel9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _GroupPanel9.Controls.Add(_ButtonX_MS_RemoveSequence);
            _GroupPanel9.Controls.Add(_ButtonX_MS_AddSequence);
            _GroupPanel9.Controls.Add(_ListBoxAdv_MS_MusicSequences);
            _GroupPanel9.DisabledBackColor = Color.Empty;
            _GroupPanel9.Name = "GroupPanel9";
            // 
            // 
            // 
            _GroupPanel9.Style.BackColorGradientAngle = 90;
            _GroupPanel9.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel9.Style.BorderBottomWidth = 1;
            _GroupPanel9.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel9.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel9.Style.BorderLeftWidth = 1;
            _GroupPanel9.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel9.Style.BorderRightWidth = 1;
            _GroupPanel9.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel9.Style.BorderTopWidth = 1;
            _GroupPanel9.Style.CornerDiameter = 4;
            _GroupPanel9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel9.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel9.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel9.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel9.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel9.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ButtonX_MS_RemoveSequence
            // 
            _ButtonX_MS_RemoveSequence.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_MS_RemoveSequence.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_ButtonX_MS_RemoveSequence, "ButtonX_MS_RemoveSequence");
            _ButtonX_MS_RemoveSequence.FocusCuesEnabled = false;
            _ButtonX_MS_RemoveSequence.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonX_MS_RemoveSequence.Name = "ButtonX_MS_RemoveSequence";
            _ButtonX_MS_RemoveSequence.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_MS_RemoveSequence.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonX_MS_RemoveSequence.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX_MS_RemoveSequence.SymbolSize = 12.0F;
            // 
            // ButtonX_MS_AddSequence
            // 
            _ButtonX_MS_AddSequence.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_MS_AddSequence.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_MS_AddSequence.FocusCuesEnabled = false;
            _ButtonX_MS_AddSequence.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(_ButtonX_MS_AddSequence, "ButtonX_MS_AddSequence");
            _ButtonX_MS_AddSequence.Name = "ButtonX_MS_AddSequence";
            _ButtonX_MS_AddSequence.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_MS_AddSequence.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX_MS_AddSequence.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX_MS_AddSequence.SymbolSize = 12.0F;
            // 
            // ListBoxAdv_MS_MusicSequences
            // 
            resources.ApplyResources(_ListBoxAdv_MS_MusicSequences, "ListBoxAdv_MS_MusicSequences");
            // 
            // 
            // 
            _ListBoxAdv_MS_MusicSequences.BackgroundStyle.Class = "ListBoxAdv";
            _ListBoxAdv_MS_MusicSequences.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListBoxAdv_MS_MusicSequences.ContainerControlProcessDialogKey = true;
            _ListBoxAdv_MS_MusicSequences.DragDropSupport = true;
            _ListBoxAdv_MS_MusicSequences.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ListBoxAdv_MS_MusicSequences.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ListBoxAdv_MS_MusicSequences.Name = "ListBoxAdv_MS_MusicSequences";
            _ListBoxAdv_MS_MusicSequences.ReserveLeftSpace = false;
            _ListBoxAdv_MS_MusicSequences.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Tab_MusicManager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(_GroupPanel12);
            Controls.Add(_GroupBox_MS_SeqProperties);
            Controls.Add(_GroupBox_MS_SelectedSequence);
            Controls.Add(_GroupPanel9);
            Name = "Tab_MusicManager";
            _GroupPanel12.ResumeLayout(false);
            _GroupBox_MS_SeqProperties.ResumeLayout(false);
            _GroupBox_MS_SelectedSequence.ResumeLayout(false);
            _GroupPanel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel12;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel12 != null)
                {
                }

                _GroupPanel12 = value;
                if (_GroupPanel12 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX56;

        internal DevComponents.DotNetBar.LabelX LabelX56
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX56;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX56 != null)
                {
                }

                _LabelX56 = value;
                if (_LabelX56 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_MS_OverwriteSizeRestrictions;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_MS_OverwriteSizeRestrictions
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_MS_OverwriteSizeRestrictions;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_MS_OverwriteSizeRestrictions != null)
                {
                    _SwitchButton_MS_OverwriteSizeRestrictions.ValueChanged -= SwitchButton_MS_OverwriteSizeRestrictions_ValueChanged;
                }

                _SwitchButton_MS_OverwriteSizeRestrictions = value;
                if (_SwitchButton_MS_OverwriteSizeRestrictions != null)
                {
                    _SwitchButton_MS_OverwriteSizeRestrictions.ValueChanged += SwitchButton_MS_OverwriteSizeRestrictions_ValueChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupBox_MS_SeqProperties;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupBox_MS_SeqProperties
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox_MS_SeqProperties;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox_MS_SeqProperties != null)
                {
                }

                _GroupBox_MS_SeqProperties = value;
                if (_GroupBox_MS_SeqProperties != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_MS_SeqSize;

        internal DevComponents.DotNetBar.LabelX LabelX_MS_SeqSize
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_MS_SeqSize;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_MS_SeqSize != null)
                {
                }

                _LabelX_MS_SeqSize = value;
                if (_LabelX_MS_SeqSize != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX33;

        internal DevComponents.DotNetBar.LabelX LabelX33
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX33;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX33 != null)
                {
                }

                _LabelX33 = value;
                if (_LabelX33 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX28;

        internal DevComponents.DotNetBar.LabelX LabelX28
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX28;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX28 != null)
                {
                }

                _LabelX28 = value;
                if (_LabelX28 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_MS_SequenceID;

        internal DevComponents.DotNetBar.LabelX LabelX_MS_SequenceID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_MS_SequenceID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_MS_SequenceID != null)
                {
                }

                _LabelX_MS_SequenceID = value;
                if (_LabelX_MS_SequenceID != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupBox_MS_SelectedSequence;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupBox_MS_SelectedSequence
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox_MS_SelectedSequence;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox_MS_SelectedSequence != null)
                {
                }

                _GroupBox_MS_SelectedSequence = value;
                if (_GroupBox_MS_SelectedSequence != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_MS_NInst;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_MS_NInst
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_MS_NInst;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_MS_NInst != null)
                {
                    _ComboBox_MS_NInst.SelectedIndexChanged -= ComboBox_MS_NInst_SelectedIndexChanged;
                }

                _ComboBox_MS_NInst = value;
                if (_ComboBox_MS_NInst != null)
                {
                    _ComboBox_MS_NInst.SelectedIndexChanged += ComboBox_MS_NInst_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX32;

        internal DevComponents.DotNetBar.LabelX LabelX32
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX32;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX32 != null)
                {
                }

                _LabelX32 = value;
                if (_LabelX32 != null)
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_MS_Sequencename;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_MS_Sequencename
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_MS_Sequencename;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_MS_Sequencename != null)
                {
                    _TextBoxX_MS_Sequencename.TextChanged -= MusicSettings_SequenceNameChanged;
                }

                _TextBoxX_MS_Sequencename = value;
                if (_TextBoxX_MS_Sequencename != null)
                {
                    _TextBoxX_MS_Sequencename.TextChanged += MusicSettings_SequenceNameChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_MS_ExtractSequence;

        internal DevComponents.DotNetBar.ButtonX Button_MS_ExtractSequence
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_MS_ExtractSequence;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_MS_ExtractSequence != null)
                {
                    _Button_MS_ExtractSequence.Click -= Button_MS_ExtractSequence_Click;
                }

                _Button_MS_ExtractSequence = value;
                if (_Button_MS_ExtractSequence != null)
                {
                    _Button_MS_ExtractSequence.Click += Button_MS_ExtractSequence_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_MS_ReplaceSequence;

        internal DevComponents.DotNetBar.ButtonX Button_MS_ReplaceSequence
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_MS_ReplaceSequence;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_MS_ReplaceSequence != null)
                {
                    _Button_MS_ReplaceSequence.Click -= Button_MS_ReplaceSequence_Click;
                }

                _Button_MS_ReplaceSequence = value;
                if (_Button_MS_ReplaceSequence != null)
                {
                    _Button_MS_ReplaceSequence.Click += Button_MS_ReplaceSequence_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.Line _Line6;

        internal DevComponents.DotNetBar.Controls.Line Line6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Line6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Line6 != null)
                {
                }

                _Line6 = value;
                if (_Line6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel9;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel9 != null)
                {
                }

                _GroupPanel9 = value;
                if (_GroupPanel9 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_MS_RemoveSequence;

        internal DevComponents.DotNetBar.ButtonX ButtonX_MS_RemoveSequence
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_MS_RemoveSequence;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_MS_RemoveSequence != null)
                {
                    _ButtonX_MS_RemoveSequence.Click -= ButtonX_MS_RemoveSequence_Click;
                }

                _ButtonX_MS_RemoveSequence = value;
                if (_ButtonX_MS_RemoveSequence != null)
                {
                    _ButtonX_MS_RemoveSequence.Click += ButtonX_MS_RemoveSequence_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_MS_AddSequence;

        internal DevComponents.DotNetBar.ButtonX ButtonX_MS_AddSequence
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_MS_AddSequence;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_MS_AddSequence != null)
                {
                    _ButtonX_MS_AddSequence.Click -= ButtonX_MS_AddSequence_Click;
                }

                _ButtonX_MS_AddSequence = value;
                if (_ButtonX_MS_AddSequence != null)
                {
                    _ButtonX_MS_AddSequence.Click += ButtonX_MS_AddSequence_Click;
                }
            }
        }

        private Publics.Controls.ItemListBox _ListBoxAdv_MS_MusicSequences;

        internal Publics.Controls.ItemListBox ListBoxAdv_MS_MusicSequences
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListBoxAdv_MS_MusicSequences;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListBoxAdv_MS_MusicSequences != null)
                {
                    _ListBoxAdv_MS_MusicSequences.SelectedItemChanged -= ListBoxAdv_MS_MusicSequences_SelectedIndexChanged;
                }

                _ListBoxAdv_MS_MusicSequences = value;
                if (_ListBoxAdv_MS_MusicSequences != null)
                {
                    _ListBoxAdv_MS_MusicSequences.SelectedItemChanged += ListBoxAdv_MS_MusicSequences_SelectedIndexChanged;
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
    }
}