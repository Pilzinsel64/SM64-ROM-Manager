using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelImporterGUI
{
    [DesignerGenerated()]
    public partial class ModelImporter : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelImporter));
            _LabelX50 = new DevComponents.DotNetBar.LabelX();
            _LabelX51 = new DevComponents.DotNetBar.LabelX();
            _LabelX54 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_RomAddr = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_RomAddr.TextChanged += new EventHandler(TextBoxX_RomAddr_TextChanged);
            _TextBoxX_MaxLength = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_MaxLength.TextChanged += new EventHandler(TextBoxX_MaxLength_TextChanged);
            _TextBoxX_BankAddr = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_BankAddr.TextChanged += new EventHandler(TextBoxX_BankAddr_TextChanged);
            _ButtonX_OpenRom = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_OpenRom.Click += new EventHandler(ButtonX_OpenRom_Click);
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _Line2 = new DevComponents.DotNetBar.Controls.Line();
            _Line1 = new DevComponents.DotNetBar.Controls.Line();
            _Line3 = new DevComponents.DotNetBar.Controls.Line();
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_Output = new DevComponents.DotNetBar.Controls.TextBoxX();
            _ButtonX_ImportMdl = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_ImportMdl.Click += new EventHandler(ButtonX_ImportMdl_Click);
            _ButtonX_ConvertMdl = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_ConvertMdl.Click += new EventHandler(ButtonX_ConvertMdl_Click);
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx2.SelectedIndexChanged += new EventHandler(ComboBoxEx2_SelectedIndexChanged);
            _LabelX6 = new DevComponents.DotNetBar.LabelX();
            _LabelX7 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX1.LostFocus += new EventHandler(TextBoxX1_TextChanged);
            _TextBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX2.LostFocus += new EventHandler(TextBoxX2_TextChanged);
            _SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            _ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX3.Click += new EventHandler(ButtonX3_Click);
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX2.Click += new EventHandler(ButtonX2_Click);
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _Panel1 = new Panel();
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _TableLayoutPanel2 = new TableLayoutPanel();
            _LabelX_Description = new DevComponents.DotNetBar.LabelX();
            _LabelX_PatchName = new DevComponents.DotNetBar.LabelX();
            _TableLayoutPanel1 = new TableLayoutPanel();
            _ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            _ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem1.Click += new EventHandler(ButtonItem1_Click);
            _ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem2.Click += new EventHandler(ButtonItem2_Click);
            _ButtonX7 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX7.Click += new EventHandler(ButtonX7_Click);
            _ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX4.Click += new EventHandler(ButtonX4_Click);
            _Flyout1 = new DevComponents.DotNetBar.Controls.Flyout(components);
            _Flyout1.PrepareContent += new EventHandler(Flyout1_PrepareContent);
            _Flyout1.FlyoutShowing += new DevComponents.DotNetBar.Controls.FlyoutShowingEventHandler(Flyout1_FlyoutShowing);
            _Panel1.SuspendLayout();
            _TableLayoutPanel2.SuspendLayout();
            _TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelX50
            // 
            _LabelX50.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX50.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX50.Location = new Point(12, 168);
            _LabelX50.Name = "LabelX50";
            _LabelX50.Size = new Size(90, 20);
            _LabelX50.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _LabelX50.TabIndex = 92;
            _LabelX50.Text = "Rom Address:";
            // 
            // LabelX51
            // 
            _LabelX51.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX51.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX51.Location = new Point(12, 220);
            _LabelX51.Name = "LabelX51";
            _LabelX51.Size = new Size(90, 20);
            _LabelX51.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _LabelX51.TabIndex = 93;
            _LabelX51.Text = "Max Length:";
            // 
            // LabelX54
            // 
            _LabelX54.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX54.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX54.Location = new Point(12, 194);
            _LabelX54.Name = "LabelX54";
            _LabelX54.Size = new Size(90, 20);
            _LabelX54.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _LabelX54.TabIndex = 94;
            _LabelX54.Text = "Bank Address:";
            // 
            // TextBoxX_RomAddr
            // 
            _TextBoxX_RomAddr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _TextBoxX_RomAddr.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_RomAddr.Border.Class = "TextBoxBorder";
            _TextBoxX_RomAddr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_RomAddr.DisabledBackColor = Color.White;
            _TextBoxX_RomAddr.ForeColor = Color.Black;
            _TextBoxX_RomAddr.Location = new Point(162, 168);
            _TextBoxX_RomAddr.Name = "TextBoxX_RomAddr";
            _TextBoxX_RomAddr.PreventEnterBeep = true;
            _TextBoxX_RomAddr.Size = new Size(100, 20);
            _TextBoxX_RomAddr.TabIndex = 95;
            _TextBoxX_RomAddr.Text = "0x0";
            // 
            // TextBoxX_MaxLength
            // 
            _TextBoxX_MaxLength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _TextBoxX_MaxLength.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_MaxLength.Border.Class = "TextBoxBorder";
            _TextBoxX_MaxLength.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_MaxLength.DisabledBackColor = Color.White;
            _TextBoxX_MaxLength.ForeColor = Color.Black;
            _TextBoxX_MaxLength.Location = new Point(162, 220);
            _TextBoxX_MaxLength.Name = "TextBoxX_MaxLength";
            _TextBoxX_MaxLength.PreventEnterBeep = true;
            _TextBoxX_MaxLength.Size = new Size(100, 20);
            _TextBoxX_MaxLength.TabIndex = 96;
            _TextBoxX_MaxLength.Text = "0x0";
            // 
            // TextBoxX_BankAddr
            // 
            _TextBoxX_BankAddr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _TextBoxX_BankAddr.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_BankAddr.Border.Class = "TextBoxBorder";
            _TextBoxX_BankAddr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_BankAddr.DisabledBackColor = Color.White;
            _TextBoxX_BankAddr.ForeColor = Color.Black;
            _TextBoxX_BankAddr.Location = new Point(162, 194);
            _TextBoxX_BankAddr.Name = "TextBoxX_BankAddr";
            _TextBoxX_BankAddr.PreventEnterBeep = true;
            _TextBoxX_BankAddr.Size = new Size(100, 20);
            _TextBoxX_BankAddr.TabIndex = 97;
            _TextBoxX_BankAddr.Text = "0x0";
            // 
            // ButtonX_OpenRom
            // 
            _ButtonX_OpenRom.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_OpenRom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _ButtonX_OpenRom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_OpenRom.FocusCuesEnabled = false;
            _ButtonX_OpenRom.Location = new Point(187, 12);
            _ButtonX_OpenRom.Name = "ButtonX_OpenRom";
            _ButtonX_OpenRom.Size = new Size(75, 23);
            _ButtonX_OpenRom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_OpenRom.Symbol = "58055";
            _ButtonX_OpenRom.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _ButtonX_OpenRom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX_OpenRom.SymbolSize = 12.0F;
            _ButtonX_OpenRom.TabIndex = 98;
            _ButtonX_OpenRom.Text = "Load ...";
            // 
            // LabelX1
            // 
            _LabelX1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Location = new Point(49, 12);
            _LabelX1.Name = "LabelX1";
            _LabelX1.Size = new Size(132, 23);
            _LabelX1.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _LabelX1.SymbolSize = 12.0F;
            _LabelX1.TabIndex = 0;
            _LabelX1.Text = "No file loaded!";
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Location = new Point(12, 16);
            _LabelX2.Name = "LabelX2";
            _LabelX2.Size = new Size(31, 15);
            _LabelX2.TabIndex = 99;
            _LabelX2.Text = "ROM:";
            // 
            // Line2
            // 
            _Line2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _Line2.BackColor = Color.Transparent;
            _Line2.ForeColor = Color.Gainsboro;
            _Line2.Location = new Point(12, 38);
            _Line2.Margin = new Padding(0);
            _Line2.Name = "Line2";
            _Line2.Size = new Size(250, 23);
            _Line2.TabIndex = 100;
            _Line2.Text = "Line2";
            // 
            // Line1
            // 
            _Line1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _Line1.BackColor = Color.Transparent;
            _Line1.ForeColor = Color.Gainsboro;
            _Line1.Location = new Point(12, 116);
            _Line1.Margin = new Padding(0);
            _Line1.Name = "Line1";
            _Line1.Size = new Size(250, 23);
            _Line1.TabIndex = 101;
            _Line1.Text = "Line1";
            // 
            // Line3
            // 
            _Line3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _Line3.BackColor = Color.Transparent;
            _Line3.ForeColor = Color.Gainsboro;
            _Line3.Location = new Point(12, 324);
            _Line3.Margin = new Padding(0);
            _Line3.Name = "Line3";
            _Line3.Size = new Size(250, 23);
            _Line3.TabIndex = 103;
            _Line3.Text = "Line3";
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX3.Location = new Point(12, 350);
            _LabelX3.Name = "LabelX3";
            _LabelX3.Size = new Size(75, 23);
            _LabelX3.TabIndex = 104;
            _LabelX3.Text = "Result:";
            // 
            // TextBoxX_Output
            // 
            _TextBoxX_Output.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _TextBoxX_Output.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Output.Border.Class = "TextBoxBorder";
            _TextBoxX_Output.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Output.DisabledBackColor = Color.White;
            _TextBoxX_Output.ForeColor = Color.Black;
            _TextBoxX_Output.Location = new Point(12, 379);
            _TextBoxX_Output.Multiline = true;
            _TextBoxX_Output.Name = "TextBoxX_Output";
            _TextBoxX_Output.PreventEnterBeep = true;
            _TextBoxX_Output.ReadOnly = true;
            _TextBoxX_Output.ScrollBars = ScrollBars.Vertical;
            _TextBoxX_Output.Size = new Size(250, 96);
            _TextBoxX_Output.TabIndex = 105;
            // 
            // ButtonX_ImportMdl
            // 
            _ButtonX_ImportMdl.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_ImportMdl.Anchor = AnchorStyles.Top;
            _ButtonX_ImportMdl.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_ImportMdl.Enabled = false;
            _ButtonX_ImportMdl.FocusCuesEnabled = false;
            _ButtonX_ImportMdl.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _ButtonX_ImportMdl.Location = new Point(78, 298);
            _ButtonX_ImportMdl.Name = "ButtonX_ImportMdl";
            _ButtonX_ImportMdl.Size = new Size(119, 23);
            _ButtonX_ImportMdl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_ImportMdl.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX_ImportMdl.SymbolSize = 12.0F;
            _ButtonX_ImportMdl.TabIndex = 106;
            _ButtonX_ImportMdl.Text = "Import Model";
            // 
            // ButtonX_ConvertMdl
            // 
            _ButtonX_ConvertMdl.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_ConvertMdl.Anchor = AnchorStyles.Top;
            _ButtonX_ConvertMdl.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_ConvertMdl.FocusCuesEnabled = false;
            _ButtonX_ConvertMdl.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ButtonX_ConvertMdl.Location = new Point(78, 90);
            _ButtonX_ConvertMdl.Name = "ButtonX_ConvertMdl";
            _ButtonX_ConvertMdl.Size = new Size(119, 23);
            _ButtonX_ConvertMdl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_ConvertMdl.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX_ConvertMdl.SymbolSize = 12.0F;
            _ButtonX_ConvertMdl.TabIndex = 107;
            _ButtonX_ConvertMdl.Text = "Convert Model";
            // 
            // LabelX4
            // 
            _LabelX4.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX4.Location = new Point(12, 64);
            _LabelX4.Name = "LabelX4";
            _LabelX4.Size = new Size(90, 20);
            _LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _LabelX4.TabIndex = 108;
            _LabelX4.Text = "Force Displaylist:";
            // 
            // ComboBoxEx1
            // 
            _ComboBoxEx1.DisplayMember = "Text";
            _ComboBoxEx1.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx1.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx1.ForeColor = Color.Black;
            _ComboBoxEx1.FormattingEnabled = true;
            _ComboBoxEx1.ItemHeight = 15;
            _ComboBoxEx1.Location = new Point(108, 63);
            _ComboBoxEx1.Name = "ComboBoxEx1";
            _ComboBoxEx1.Size = new Size(154, 21);
            _ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ComboBoxEx1.TabIndex = 109;
            // 
            // ComboBoxEx2
            // 
            _ComboBoxEx2.DisplayMember = "Text";
            _ComboBoxEx2.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx2.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx2.ForeColor = Color.Black;
            _ComboBoxEx2.FormattingEnabled = true;
            _ComboBoxEx2.ItemHeight = 15;
            _ComboBoxEx2.Location = new Point(12, 142);
            _ComboBoxEx2.Name = "ComboBoxEx2";
            _ComboBoxEx2.Size = new Size(224, 21);
            _ComboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ComboBoxEx2.TabIndex = 111;
            // 
            // LabelX6
            // 
            _LabelX6.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX6.Location = new Point(12, 272);
            _LabelX6.Name = "LabelX6";
            _LabelX6.Size = new Size(90, 20);
            _LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _LabelX6.TabIndex = 112;
            _LabelX6.Text = "Geo Pointer:";
            // 
            // LabelX7
            // 
            _LabelX7.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX7.Location = new Point(12, 246);
            _LabelX7.Name = "LabelX7";
            _LabelX7.Size = new Size(90, 20);
            _LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _LabelX7.TabIndex = 113;
            _LabelX7.Text = "Collision Pointer:";
            // 
            // TextBoxX1
            // 
            _TextBoxX1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _TextBoxX1.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX1.Border.Class = "TextBoxBorder";
            _TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX1.DisabledBackColor = Color.White;
            _TextBoxX1.ForeColor = Color.Black;
            _TextBoxX1.Location = new Point(108, 272);
            _TextBoxX1.Name = "TextBoxX1";
            _TextBoxX1.PreventEnterBeep = true;
            _TextBoxX1.Size = new Size(154, 20);
            _SuperTooltip1.SetSuperTooltip(_TextBoxX1, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "The Geopointers will be written to this addresses." + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "Seperate them with comma." + Conversions.ToString((char)13) + Conversions.ToString((char)10) + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "Example:" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "0x1250000, 0x18E0000", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new Size(0, 0)));
            _TextBoxX1.TabIndex = 114;
            // 
            // TextBoxX2
            // 
            _TextBoxX2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _TextBoxX2.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX2.Border.Class = "TextBoxBorder";
            _TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX2.DisabledBackColor = Color.White;
            _TextBoxX2.ForeColor = Color.Black;
            _TextBoxX2.Location = new Point(108, 246);
            _TextBoxX2.Name = "TextBoxX2";
            _TextBoxX2.PreventEnterBeep = true;
            _TextBoxX2.Size = new Size(154, 20);
            _SuperTooltip1.SetSuperTooltip(_TextBoxX2, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "The Collision Pointer will be written to this addresses." + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "Seperate them with comm" + "a." + Conversions.ToString((char)13) + Conversions.ToString((char)10) + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "Example:" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "0x1250000, 0x18E0000", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new Size(0, 0)));
            _TextBoxX2.TabIndex = 115;
            // 
            // SuperTooltip1
            // 
            _SuperTooltip1.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            _SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // ButtonX3
            // 
            _ButtonX3.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX3.FocusCuesEnabled = false;
            _ButtonX3.Location = new Point(3, 3);
            _ButtonX3.MinimumSize = new Size(20, 20);
            _ButtonX3.Name = "ButtonX3";
            _ButtonX3.Size = new Size(20, 20);
            _ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX3, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Close Popup", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new Size(0, 0)));
            _ButtonX3.Symbol = "57676";
            _ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX3.SymbolSize = 12.0F;
            _ButtonX3.TabIndex = 39;
            // 
            // ButtonX2
            // 
            _ButtonX2.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX2.FocusCuesEnabled = false;
            _ButtonX2.Location = new Point(112, 3);
            _ButtonX2.MinimumSize = new Size(20, 20);
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Size = new Size(115, 20);
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX2, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit Name & Description", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new Size(0, 0)));
            _ButtonX2.Symbol = "57680";
            _ButtonX2.SymbolColor = Color.Goldenrod;
            _ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX2.SymbolSize = 12.0F;
            _ButtonX2.TabIndex = 45;
            _ButtonX2.Text = "Edit Preset Info";
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX1.FocusCuesEnabled = false;
            _ButtonX1.Location = new Point(112, 29);
            _ButtonX1.MinimumSize = new Size(20, 20);
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Size = new Size(95, 20);
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX1, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit Name & Description", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new Size(0, 0)));
            _ButtonX1.Symbol = "57697";
            _ButtonX1.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX1.SymbolSize = 12.0F;
            _ButtonX1.TabIndex = 46;
            _ButtonX1.Text = "Save Preset";
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_LabelX5);
            _Panel1.Controls.Add(_TableLayoutPanel2);
            _Panel1.Controls.Add(_LabelX_Description);
            _Panel1.Controls.Add(_LabelX_PatchName);
            _Panel1.Controls.Add(_TableLayoutPanel1);
            _Panel1.Location = new Point(17, 294);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(298, 191);
            _Panel1.TabIndex = 117;
            _Panel1.Visible = false;
            // 
            // LabelX5
            // 
            _LabelX5.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX5.Location = new Point(3, 87);
            _LabelX5.Name = "LabelX5";
            _LabelX5.Size = new Size(230, 23);
            _LabelX5.TabIndex = 52;
            _LabelX5.Text = "Description:";
            // 
            // TableLayoutPanel2
            // 
            _TableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _TableLayoutPanel2.AutoSize = true;
            _TableLayoutPanel2.BackColor = Color.Transparent;
            _TableLayoutPanel2.ColumnCount = 1;
            _TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            _TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20.0F));
            _TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20.0F));
            _TableLayoutPanel2.Controls.Add(_ButtonX3, 0, 0);
            _TableLayoutPanel2.Location = new Point(272, 0);
            _TableLayoutPanel2.Name = "TableLayoutPanel2";
            _TableLayoutPanel2.RowCount = 1;
            _TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            _TableLayoutPanel2.Size = new Size(26, 26);
            _TableLayoutPanel2.TabIndex = 48;
            // 
            // LabelX_Description
            // 
            _LabelX_Description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _LabelX_Description.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_Description.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Description.Location = new Point(3, 116);
            _LabelX_Description.Name = "LabelX_Description";
            _LabelX_Description.Size = new Size(292, 72);
            _LabelX_Description.TabIndex = 50;
            _LabelX_Description.TextLineAlignment = StringAlignment.Near;
            _LabelX_Description.WordWrap = true;
            // 
            // LabelX_PatchName
            // 
            _LabelX_PatchName.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_PatchName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_PatchName.Location = new Point(3, 58);
            _LabelX_PatchName.Name = "LabelX_PatchName";
            _LabelX_PatchName.Size = new Size(381, 23);
            _LabelX_PatchName.TabIndex = 49;
            _LabelX_PatchName.Text = "Name:";
            // 
            // TableLayoutPanel1
            // 
            _TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _TableLayoutPanel1.AutoSize = true;
            _TableLayoutPanel1.BackColor = Color.Transparent;
            _TableLayoutPanel1.ColumnCount = 2;
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20.0F));
            _TableLayoutPanel1.Controls.Add(_ButtonX1, 1, 1);
            _TableLayoutPanel1.Controls.Add(_ButtonX6, 0, 0);
            _TableLayoutPanel1.Controls.Add(_ButtonX2, 1, 0);
            _TableLayoutPanel1.Controls.Add(_ButtonX7, 0, 1);
            _TableLayoutPanel1.Location = new Point(0, 0);
            _TableLayoutPanel1.Name = "TableLayoutPanel1";
            _TableLayoutPanel1.RowCount = 2;
            _TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0F));
            _TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0F));
            _TableLayoutPanel1.Size = new Size(236, 52);
            _TableLayoutPanel1.TabIndex = 47;
            // 
            // ButtonX6
            // 
            _ButtonX6.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _ButtonX6.AutoExpandOnClick = true;
            _ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX6.FocusCuesEnabled = false;
            _ButtonX6.Location = new Point(3, 3);
            _ButtonX6.Name = "ButtonX6";
            _ButtonX6.Size = new Size(103, 20);
            _ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem1, _ButtonItem2 });
            _ButtonX6.Symbol = "57680";
            _ButtonX6.SymbolColor = Color.Goldenrod;
            _ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX6.SymbolSize = 12.0F;
            _ButtonX6.TabIndex = 44;
            _ButtonX6.Text = "Edit Script";
            // 
            // ButtonItem1
            // 
            _ButtonItem1.GlobalItem = false;
            _ButtonItem1.Name = "ButtonItem1";
            _ButtonItem1.Text = "Script \"Before\"";
            // 
            // ButtonItem2
            // 
            _ButtonItem2.GlobalItem = false;
            _ButtonItem2.Name = "ButtonItem2";
            _ButtonItem2.Text = "Script \"After\"";
            // 
            // ButtonX7
            // 
            _ButtonX7.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX7.FocusCuesEnabled = false;
            _ButtonX7.Location = new Point(3, 29);
            _ButtonX7.Name = "ButtonX7";
            _ButtonX7.Size = new Size(103, 20);
            _ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX7.Symbol = "57676";
            _ButtonX7.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonX7.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX7.SymbolSize = 12.0F;
            _ButtonX7.TabIndex = 45;
            _ButtonX7.Text = "Delete Preset";
            // 
            // ButtonX4
            // 
            _ButtonX4.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX4.FocusCuesEnabled = false;
            _ButtonX4.Location = new Point(242, 142);
            _ButtonX4.Name = "ButtonX4";
            _ButtonX4.Size = new Size(20, 20);
            _ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX4.Symbol = "57669";
            _ButtonX4.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX4.SymbolSize = 12.0F;
            _ButtonX4.TabIndex = 42;
            // 
            // Flyout1
            // 
            _Flyout1.Content = _Panel1;
            _Flyout1.DisplayMode = DevComponents.DotNetBar.Controls.eFlyoutDisplayMode.MouseHover;
            _Flyout1.DropShadow = false;
            _Flyout1.TargetControl = _ComboBoxEx2;
            // 
            // ModelImporter
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 489);
            Controls.Add(_ButtonX4);
            Controls.Add(_Panel1);
            Controls.Add(_LabelX6);
            Controls.Add(_LabelX7);
            Controls.Add(_TextBoxX1);
            Controls.Add(_TextBoxX2);
            Controls.Add(_ComboBoxEx2);
            Controls.Add(_ComboBoxEx1);
            Controls.Add(_LabelX4);
            Controls.Add(_ButtonX_ConvertMdl);
            Controls.Add(_ButtonX_ImportMdl);
            Controls.Add(_TextBoxX_Output);
            Controls.Add(_LabelX3);
            Controls.Add(_Line3);
            Controls.Add(_Line1);
            Controls.Add(_Line2);
            Controls.Add(_LabelX2);
            Controls.Add(_LabelX1);
            Controls.Add(_ButtonX_OpenRom);
            Controls.Add(_LabelX50);
            Controls.Add(_LabelX51);
            Controls.Add(_LabelX54);
            Controls.Add(_TextBoxX_RomAddr);
            Controls.Add(_TextBoxX_MaxLength);
            Controls.Add(_TextBoxX_BankAddr);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ModelImporter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Model Importer";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            _Panel1.PerformLayout();
            _TableLayoutPanel2.ResumeLayout(false);
            _TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.LabelX _LabelX50;

        internal DevComponents.DotNetBar.LabelX LabelX50
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX50;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX50 != null)
                {
                }

                _LabelX50 = value;
                if (_LabelX50 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX51;

        internal DevComponents.DotNetBar.LabelX LabelX51
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX51;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX51 != null)
                {
                }

                _LabelX51 = value;
                if (_LabelX51 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX54;

        internal DevComponents.DotNetBar.LabelX LabelX54
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX54;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX54 != null)
                {
                }

                _LabelX54 = value;
                if (_LabelX54 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_RomAddr;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_RomAddr
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_RomAddr;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_RomAddr != null)
                {
                    _TextBoxX_RomAddr.TextChanged -= TextBoxX_RomAddr_TextChanged;
                }

                _TextBoxX_RomAddr = value;
                if (_TextBoxX_RomAddr != null)
                {
                    _TextBoxX_RomAddr.TextChanged += TextBoxX_RomAddr_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_MaxLength;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_MaxLength
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_MaxLength;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_MaxLength != null)
                {
                    _TextBoxX_MaxLength.TextChanged -= TextBoxX_MaxLength_TextChanged;
                }

                _TextBoxX_MaxLength = value;
                if (_TextBoxX_MaxLength != null)
                {
                    _TextBoxX_MaxLength.TextChanged += TextBoxX_MaxLength_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_BankAddr;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_BankAddr
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_BankAddr;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_BankAddr != null)
                {
                    _TextBoxX_BankAddr.TextChanged -= TextBoxX_BankAddr_TextChanged;
                }

                _TextBoxX_BankAddr = value;
                if (_TextBoxX_BankAddr != null)
                {
                    _TextBoxX_BankAddr.TextChanged += TextBoxX_BankAddr_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_OpenRom;

        internal DevComponents.DotNetBar.ButtonX ButtonX_OpenRom
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_OpenRom;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_OpenRom != null)
                {
                    _ButtonX_OpenRom.Click -= ButtonX_OpenRom_Click;
                }

                _ButtonX_OpenRom = value;
                if (_ButtonX_OpenRom != null)
                {
                    _ButtonX_OpenRom.Click += ButtonX_OpenRom_Click;
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

        private DevComponents.DotNetBar.Controls.Line _Line1;

        internal DevComponents.DotNetBar.Controls.Line Line1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Line1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Line1 != null)
                {
                }

                _Line1 = value;
                if (_Line1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.Line _Line3;

        internal DevComponents.DotNetBar.Controls.Line Line3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Line3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Line3 != null)
                {
                }

                _Line3 = value;
                if (_Line3 != null)
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Output;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Output
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Output;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Output != null)
                {
                }

                _TextBoxX_Output = value;
                if (_TextBoxX_Output != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_ImportMdl;

        internal DevComponents.DotNetBar.ButtonX ButtonX_ImportMdl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_ImportMdl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_ImportMdl != null)
                {
                    _ButtonX_ImportMdl.Click -= ButtonX_ImportMdl_Click;
                }

                _ButtonX_ImportMdl = value;
                if (_ButtonX_ImportMdl != null)
                {
                    _ButtonX_ImportMdl.Click += ButtonX_ImportMdl_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_ConvertMdl;

        internal DevComponents.DotNetBar.ButtonX ButtonX_ConvertMdl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_ConvertMdl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_ConvertMdl != null)
                {
                    _ButtonX_ConvertMdl.Click -= ButtonX_ConvertMdl_Click;
                }

                _ButtonX_ConvertMdl = value;
                if (_ButtonX_ConvertMdl != null)
                {
                    _ButtonX_ConvertMdl.Click += ButtonX_ConvertMdl_Click;
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx2;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx2 != null)
                {
                    _ComboBoxEx2.SelectedIndexChanged -= ComboBoxEx2_SelectedIndexChanged;
                }

                _ComboBoxEx2 = value;
                if (_ComboBoxEx2 != null)
                {
                    _ComboBoxEx2.SelectedIndexChanged += ComboBoxEx2_SelectedIndexChanged;
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX1;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX1 != null)
                {
                    _TextBoxX1.LostFocus -= TextBoxX1_TextChanged;
                }

                _TextBoxX1 = value;
                if (_TextBoxX1 != null)
                {
                    _TextBoxX1.LostFocus += TextBoxX1_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX2;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX2 != null)
                {
                    _TextBoxX2.LostFocus -= TextBoxX2_TextChanged;
                }

                _TextBoxX2 = value;
                if (_TextBoxX2 != null)
                {
                    _TextBoxX2.LostFocus += TextBoxX2_TextChanged;
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

        private TableLayoutPanel _TableLayoutPanel2;

        internal TableLayoutPanel TableLayoutPanel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel2 != null)
                {
                }

                _TableLayoutPanel2 = value;
                if (_TableLayoutPanel2 != null)
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

        private DevComponents.DotNetBar.LabelX _LabelX_Description;

        internal DevComponents.DotNetBar.LabelX LabelX_Description
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Description;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Description != null)
                {
                }

                _LabelX_Description = value;
                if (_LabelX_Description != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_PatchName;

        internal DevComponents.DotNetBar.LabelX LabelX_PatchName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_PatchName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_PatchName != null)
                {
                }

                _LabelX_PatchName = value;
                if (_LabelX_PatchName != null)
                {
                }
            }
        }

        private TableLayoutPanel _TableLayoutPanel1;

        internal TableLayoutPanel TableLayoutPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel1 != null)
                {
                }

                _TableLayoutPanel1 = value;
                if (_TableLayoutPanel1 != null)
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

        private DevComponents.DotNetBar.ButtonX _ButtonX7;

        internal DevComponents.DotNetBar.ButtonX ButtonX7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX7 != null)
                {
                    _ButtonX7.Click -= ButtonX7_Click;
                }

                _ButtonX7 = value;
                if (_ButtonX7 != null)
                {
                    _ButtonX7.Click += ButtonX7_Click;
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
                }

                _ButtonX6 = value;
                if (_ButtonX6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.Flyout _Flyout1;

        internal DevComponents.DotNetBar.Controls.Flyout Flyout1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Flyout1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Flyout1 != null)
                {
                    _Flyout1.PrepareContent -= Flyout1_PrepareContent;
                    _Flyout1.FlyoutShowing -= Flyout1_FlyoutShowing;
                }

                _Flyout1 = value;
                if (_Flyout1 != null)
                {
                    _Flyout1.PrepareContent += Flyout1_PrepareContent;
                    _Flyout1.FlyoutShowing += Flyout1_FlyoutShowing;
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

        private DevComponents.DotNetBar.ButtonItem _ButtonItem2;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem2 != null)
                {
                    _ButtonItem2.Click -= ButtonItem2_Click;
                }

                _ButtonItem2 = value;
                if (_ButtonItem2 != null)
                {
                    _ButtonItem2.Click += ButtonItem2_Click;
                }
            }
        }
    }
}