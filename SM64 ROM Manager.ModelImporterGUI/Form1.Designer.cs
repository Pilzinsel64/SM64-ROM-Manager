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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelImporter));
            this.LabelX50 = new DevComponents.DotNetBar.LabelX();
            this.LabelX51 = new DevComponents.DotNetBar.LabelX();
            this.LabelX54 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_RomAddr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX_MaxLength = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX_BankAddr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonX_OpenRom = new DevComponents.DotNetBar.ButtonX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.Line2 = new DevComponents.DotNetBar.Controls.Line();
            this.Line1 = new DevComponents.DotNetBar.Controls.Line();
            this.Line3 = new DevComponents.DotNetBar.Controls.Line();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_Output = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonX_ImportMdl = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_ConvertMdl = new DevComponents.DotNetBar.ButtonX();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboBoxEx2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.LabelX7 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.labelX_Version = new DevComponents.DotNetBar.LabelX();
            this.LabelX5 = new DevComponents.DotNetBar.LabelX();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelX_Description = new DevComponents.DotNetBar.LabelX();
            this.LabelX_PatchName = new DevComponents.DotNetBar.LabelX();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Flyout1 = new DevComponents.DotNetBar.Controls.Flyout(this.components);
            this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX7 = new DevComponents.DotNetBar.ButtonX();
            this.Panel1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelX50
            // 
            this.LabelX50.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX50.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX50.Location = new System.Drawing.Point(12, 168);
            this.LabelX50.Name = "LabelX50";
            this.LabelX50.Size = new System.Drawing.Size(90, 20);
            this.LabelX50.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LabelX50.TabIndex = 92;
            this.LabelX50.Text = "Rom Address:";
            // 
            // LabelX51
            // 
            this.LabelX51.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX51.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX51.Location = new System.Drawing.Point(12, 220);
            this.LabelX51.Name = "LabelX51";
            this.LabelX51.Size = new System.Drawing.Size(90, 20);
            this.LabelX51.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LabelX51.TabIndex = 93;
            this.LabelX51.Text = "Max Length:";
            // 
            // LabelX54
            // 
            this.LabelX54.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX54.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX54.Location = new System.Drawing.Point(12, 194);
            this.LabelX54.Name = "LabelX54";
            this.LabelX54.Size = new System.Drawing.Size(90, 20);
            this.LabelX54.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LabelX54.TabIndex = 94;
            this.LabelX54.Text = "Bank Address:";
            // 
            // TextBoxX_RomAddr
            // 
            this.TextBoxX_RomAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX_RomAddr.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_RomAddr.Border.Class = "TextBoxBorder";
            this.TextBoxX_RomAddr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_RomAddr.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_RomAddr.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_RomAddr.Location = new System.Drawing.Point(162, 168);
            this.TextBoxX_RomAddr.Name = "TextBoxX_RomAddr";
            this.TextBoxX_RomAddr.PreventEnterBeep = true;
            this.TextBoxX_RomAddr.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_RomAddr.TabIndex = 95;
            this.TextBoxX_RomAddr.Text = "0x0";
            this.TextBoxX_RomAddr.TextChanged += new System.EventHandler(this.TextBoxX_RomAddr_TextChanged);
            // 
            // TextBoxX_MaxLength
            // 
            this.TextBoxX_MaxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX_MaxLength.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_MaxLength.Border.Class = "TextBoxBorder";
            this.TextBoxX_MaxLength.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_MaxLength.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_MaxLength.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_MaxLength.Location = new System.Drawing.Point(162, 220);
            this.TextBoxX_MaxLength.Name = "TextBoxX_MaxLength";
            this.TextBoxX_MaxLength.PreventEnterBeep = true;
            this.TextBoxX_MaxLength.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_MaxLength.TabIndex = 96;
            this.TextBoxX_MaxLength.Text = "0x0";
            this.TextBoxX_MaxLength.TextChanged += new System.EventHandler(this.TextBoxX_MaxLength_TextChanged);
            // 
            // TextBoxX_BankAddr
            // 
            this.TextBoxX_BankAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX_BankAddr.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_BankAddr.Border.Class = "TextBoxBorder";
            this.TextBoxX_BankAddr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_BankAddr.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_BankAddr.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_BankAddr.Location = new System.Drawing.Point(162, 194);
            this.TextBoxX_BankAddr.Name = "TextBoxX_BankAddr";
            this.TextBoxX_BankAddr.PreventEnterBeep = true;
            this.TextBoxX_BankAddr.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_BankAddr.TabIndex = 97;
            this.TextBoxX_BankAddr.Text = "0x0";
            this.TextBoxX_BankAddr.TextChanged += new System.EventHandler(this.TextBoxX_BankAddr_TextChanged);
            // 
            // ButtonX_OpenRom
            // 
            this.ButtonX_OpenRom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_OpenRom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_OpenRom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_OpenRom.FocusCuesEnabled = false;
            this.ButtonX_OpenRom.Image = global::SM64_ROM_Manager.ModelImporterGUI.My.Resources.Resources.icons8_folder_16px;
            this.ButtonX_OpenRom.Location = new System.Drawing.Point(187, 12);
            this.ButtonX_OpenRom.Name = "ButtonX_OpenRom";
            this.ButtonX_OpenRom.Size = new System.Drawing.Size(75, 23);
            this.ButtonX_OpenRom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_OpenRom.TabIndex = 98;
            this.ButtonX_OpenRom.Text = "Load ...";
            this.ButtonX_OpenRom.Click += new System.EventHandler(this.ButtonX_OpenRom_Click);
            // 
            // LabelX1
            // 
            this.LabelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(49, 12);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(132, 23);
            this.LabelX1.TabIndex = 0;
            this.LabelX1.Text = "No file loaded!";
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX2.Location = new System.Drawing.Point(12, 16);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(31, 15);
            this.LabelX2.TabIndex = 99;
            this.LabelX2.Text = "ROM:";
            // 
            // Line2
            // 
            this.Line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Line2.BackColor = System.Drawing.Color.Transparent;
            this.Line2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Line2.Location = new System.Drawing.Point(12, 38);
            this.Line2.Margin = new System.Windows.Forms.Padding(0);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(250, 23);
            this.Line2.TabIndex = 100;
            this.Line2.Text = "Line2";
            // 
            // Line1
            // 
            this.Line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Line1.BackColor = System.Drawing.Color.Transparent;
            this.Line1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Line1.Location = new System.Drawing.Point(12, 116);
            this.Line1.Margin = new System.Windows.Forms.Padding(0);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(250, 23);
            this.Line1.TabIndex = 101;
            this.Line1.Text = "Line1";
            // 
            // Line3
            // 
            this.Line3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Line3.BackColor = System.Drawing.Color.Transparent;
            this.Line3.ForeColor = System.Drawing.Color.Gainsboro;
            this.Line3.Location = new System.Drawing.Point(12, 324);
            this.Line3.Margin = new System.Windows.Forms.Padding(0);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(250, 23);
            this.Line3.TabIndex = 103;
            this.Line3.Text = "Line3";
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX3.Location = new System.Drawing.Point(12, 350);
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.Size = new System.Drawing.Size(75, 23);
            this.LabelX3.TabIndex = 104;
            this.LabelX3.Text = "Result:";
            // 
            // TextBoxX_Output
            // 
            this.TextBoxX_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX_Output.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_Output.Border.Class = "TextBoxBorder";
            this.TextBoxX_Output.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_Output.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_Output.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_Output.Location = new System.Drawing.Point(12, 379);
            this.TextBoxX_Output.Multiline = true;
            this.TextBoxX_Output.Name = "TextBoxX_Output";
            this.TextBoxX_Output.PreventEnterBeep = true;
            this.TextBoxX_Output.ReadOnly = true;
            this.TextBoxX_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxX_Output.Size = new System.Drawing.Size(250, 96);
            this.TextBoxX_Output.TabIndex = 105;
            // 
            // ButtonX_ImportMdl
            // 
            this.ButtonX_ImportMdl.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_ImportMdl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonX_ImportMdl.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_ImportMdl.Enabled = false;
            this.ButtonX_ImportMdl.FocusCuesEnabled = false;
            this.ButtonX_ImportMdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX_ImportMdl.Location = new System.Drawing.Point(78, 298);
            this.ButtonX_ImportMdl.Name = "ButtonX_ImportMdl";
            this.ButtonX_ImportMdl.Size = new System.Drawing.Size(119, 23);
            this.ButtonX_ImportMdl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_ImportMdl.TabIndex = 106;
            this.ButtonX_ImportMdl.Text = "Import Model";
            this.ButtonX_ImportMdl.Click += new System.EventHandler(this.ButtonX_ImportMdl_Click);
            // 
            // ButtonX_ConvertMdl
            // 
            this.ButtonX_ConvertMdl.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_ConvertMdl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonX_ConvertMdl.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_ConvertMdl.FocusCuesEnabled = false;
            this.ButtonX_ConvertMdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX_ConvertMdl.Location = new System.Drawing.Point(78, 90);
            this.ButtonX_ConvertMdl.Name = "ButtonX_ConvertMdl";
            this.ButtonX_ConvertMdl.Size = new System.Drawing.Size(119, 23);
            this.ButtonX_ConvertMdl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_ConvertMdl.TabIndex = 107;
            this.ButtonX_ConvertMdl.Text = "Convert Model";
            this.ButtonX_ConvertMdl.Click += new System.EventHandler(this.ButtonX_ConvertMdl_Click);
            // 
            // LabelX4
            // 
            this.LabelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX4.Location = new System.Drawing.Point(12, 64);
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Size = new System.Drawing.Size(90, 20);
            this.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LabelX4.TabIndex = 108;
            this.LabelX4.Text = "Force Displaylist:";
            // 
            // ComboBoxEx1
            // 
            this.ComboBoxEx1.DisplayMember = "Text";
            this.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx1.FormattingEnabled = true;
            this.ComboBoxEx1.ItemHeight = 15;
            this.ComboBoxEx1.Location = new System.Drawing.Point(108, 63);
            this.ComboBoxEx1.Name = "ComboBoxEx1";
            this.ComboBoxEx1.Size = new System.Drawing.Size(154, 21);
            this.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx1.TabIndex = 109;
            // 
            // ComboBoxEx2
            // 
            this.ComboBoxEx2.DisplayMember = "Text";
            this.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx2.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx2.FormattingEnabled = true;
            this.ComboBoxEx2.ItemHeight = 15;
            this.ComboBoxEx2.Location = new System.Drawing.Point(12, 142);
            this.ComboBoxEx2.Name = "ComboBoxEx2";
            this.ComboBoxEx2.Size = new System.Drawing.Size(224, 21);
            this.ComboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx2.TabIndex = 111;
            this.ComboBoxEx2.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx2_SelectedIndexChanged);
            // 
            // LabelX6
            // 
            this.LabelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX6.Location = new System.Drawing.Point(12, 272);
            this.LabelX6.Name = "LabelX6";
            this.LabelX6.Size = new System.Drawing.Size(90, 20);
            this.LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LabelX6.TabIndex = 112;
            this.LabelX6.Text = "Geo Pointer:";
            // 
            // LabelX7
            // 
            this.LabelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX7.Location = new System.Drawing.Point(12, 246);
            this.LabelX7.Name = "LabelX7";
            this.LabelX7.Size = new System.Drawing.Size(90, 20);
            this.LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LabelX7.TabIndex = 113;
            this.LabelX7.Text = "Collision Pointer:";
            // 
            // TextBoxX1
            // 
            this.TextBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX1.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX1.Location = new System.Drawing.Point(108, 272);
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.PreventEnterBeep = true;
            this.TextBoxX1.Size = new System.Drawing.Size(154, 20);
            this.SuperTooltip1.SetSuperTooltip(this.TextBoxX1, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "The Geopointers will be written to this addresses.\r\nSeperate them with comma.\r\n\r\n" +
            "Example:\r\n0x1250000, 0x18E0000", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new System.Drawing.Size(0, 0)));
            this.TextBoxX1.TabIndex = 114;
            this.TextBoxX1.LostFocus += new System.EventHandler(this.TextBoxX1_TextChanged);
            // 
            // TextBoxX2
            // 
            this.TextBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX2.Border.Class = "TextBoxBorder";
            this.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX2.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX2.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX2.Location = new System.Drawing.Point(108, 246);
            this.TextBoxX2.Name = "TextBoxX2";
            this.TextBoxX2.PreventEnterBeep = true;
            this.TextBoxX2.Size = new System.Drawing.Size(154, 20);
            this.SuperTooltip1.SetSuperTooltip(this.TextBoxX2, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "The Collision Pointer will be written to this addresses.\r\nSeperate them with comm" +
            "a.\r\n\r\nExample:\r\n0x1250000, 0x18E0000", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new System.Drawing.Size(0, 0)));
            this.TextBoxX2.TabIndex = 115;
            this.TextBoxX2.LostFocus += new System.EventHandler(this.TextBoxX2_TextChanged);
            // 
            // SuperTooltip1
            // 
            this.SuperTooltip1.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            this.SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.labelX_Version);
            this.Panel1.Controls.Add(this.LabelX5);
            this.Panel1.Controls.Add(this.TableLayoutPanel2);
            this.Panel1.Controls.Add(this.LabelX_Description);
            this.Panel1.Controls.Add(this.LabelX_PatchName);
            this.Panel1.Controls.Add(this.TableLayoutPanel1);
            this.Panel1.Location = new System.Drawing.Point(17, 220);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(298, 265);
            this.Panel1.TabIndex = 117;
            this.Panel1.Visible = false;
            // 
            // labelX_Version
            // 
            this.labelX_Version.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX_Version.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_Version.Location = new System.Drawing.Point(3, 85);
            this.labelX_Version.Name = "labelX_Version";
            this.labelX_Version.Size = new System.Drawing.Size(381, 23);
            this.labelX_Version.TabIndex = 53;
            this.labelX_Version.Text = "Version:";
            // 
            // LabelX5
            // 
            this.LabelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX5.Location = new System.Drawing.Point(3, 114);
            this.LabelX5.Name = "LabelX5";
            this.LabelX5.Size = new System.Drawing.Size(230, 23);
            this.LabelX5.TabIndex = 52;
            this.LabelX5.Text = "Description:";
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel2.AutoSize = true;
            this.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel2.Controls.Add(this.ButtonX3, 0, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(272, 0);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(26, 26);
            this.TableLayoutPanel2.TabIndex = 48;
            // 
            // LabelX_Description
            // 
            this.LabelX_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelX_Description.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX_Description.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_Description.Location = new System.Drawing.Point(3, 146);
            this.LabelX_Description.Name = "LabelX_Description";
            this.LabelX_Description.Size = new System.Drawing.Size(292, 116);
            this.LabelX_Description.TabIndex = 50;
            this.LabelX_Description.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.LabelX_Description.WordWrap = true;
            // 
            // LabelX_PatchName
            // 
            this.LabelX_PatchName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX_PatchName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_PatchName.Location = new System.Drawing.Point(3, 58);
            this.LabelX_PatchName.Name = "LabelX_PatchName";
            this.LabelX_PatchName.Size = new System.Drawing.Size(381, 23);
            this.LabelX_PatchName.TabIndex = 49;
            this.LabelX_PatchName.Text = "Name:";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Controls.Add(this.ButtonX1, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.ButtonX6, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonX2, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonX7, 0, 1);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(236, 52);
            this.TableLayoutPanel1.TabIndex = 47;
            // 
            // Flyout1
            // 
            this.Flyout1.Content = this.Panel1;
            this.Flyout1.DisplayMode = DevComponents.DotNetBar.Controls.eFlyoutDisplayMode.MouseHover;
            this.Flyout1.DropShadow = false;
            this.Flyout1.TargetControl = this.ComboBoxEx2;
            this.Flyout1.PrepareContent += new System.EventHandler(this.Flyout1_PrepareContent);
            this.Flyout1.FlyoutShowing += new DevComponents.DotNetBar.Controls.FlyoutShowingEventHandler(this.Flyout1_FlyoutShowing);
            // 
            // ButtonX4
            // 
            this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX4.FocusCuesEnabled = false;
            this.ButtonX4.Image = global::SM64_ROM_Manager.ModelImporterGUI.My.Resources.Resources.icons8_plus_math_16px;
            this.ButtonX4.Location = new System.Drawing.Point(242, 142);
            this.ButtonX4.Name = "ButtonX4";
            this.ButtonX4.Size = new System.Drawing.Size(20, 20);
            this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX4.TabIndex = 42;
            this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
            // 
            // ButtonX3
            // 
            this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX3.FocusCuesEnabled = false;
            this.ButtonX3.Image = global::SM64_ROM_Manager.ModelImporterGUI.My.Resources.Resources.icons8_cancel_16px;
            this.ButtonX3.Location = new System.Drawing.Point(3, 3);
            this.ButtonX3.MinimumSize = new System.Drawing.Size(20, 20);
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Size = new System.Drawing.Size(20, 20);
            this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SuperTooltip1.SetSuperTooltip(this.ButtonX3, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Close Popup", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new System.Drawing.Size(0, 0)));
            this.ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX3.TabIndex = 39;
            this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
            // 
            // ButtonX1
            // 
            this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX1.FocusCuesEnabled = false;
            this.ButtonX1.Image = global::SM64_ROM_Manager.ModelImporterGUI.My.Resources.Resources.icons8_save_16px;
            this.ButtonX1.Location = new System.Drawing.Point(112, 29);
            this.ButtonX1.MinimumSize = new System.Drawing.Size(20, 20);
            this.ButtonX1.Name = "ButtonX1";
            this.ButtonX1.Size = new System.Drawing.Size(95, 20);
            this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SuperTooltip1.SetSuperTooltip(this.ButtonX1, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit Name & Description", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new System.Drawing.Size(0, 0)));
            this.ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX1.TabIndex = 46;
            this.ButtonX1.Text = "Save Preset";
            this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // ButtonX6
            // 
            this.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonX6.AutoExpandOnClick = true;
            this.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX6.FocusCuesEnabled = false;
            this.ButtonX6.Image = global::SM64_ROM_Manager.ModelImporterGUI.My.Resources.Resources.icons8_edit_16px;
            this.ButtonX6.Location = new System.Drawing.Point(3, 3);
            this.ButtonX6.Name = "ButtonX6";
            this.ButtonX6.Size = new System.Drawing.Size(103, 20);
            this.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem1,
            this.ButtonItem2});
            this.ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX6.TabIndex = 44;
            this.ButtonX6.Text = "Edit Script";
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.GlobalItem = false;
            this.ButtonItem1.Name = "ButtonItem1";
            this.ButtonItem1.Text = "Script \"Before\"";
            this.ButtonItem1.Click += new System.EventHandler(this.ButtonItem1_Click);
            // 
            // ButtonItem2
            // 
            this.ButtonItem2.GlobalItem = false;
            this.ButtonItem2.Name = "ButtonItem2";
            this.ButtonItem2.Text = "Script \"After\"";
            this.ButtonItem2.Click += new System.EventHandler(this.ButtonItem2_Click);
            // 
            // ButtonX2
            // 
            this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX2.FocusCuesEnabled = false;
            this.ButtonX2.Image = global::SM64_ROM_Manager.ModelImporterGUI.My.Resources.Resources.icons8_edit_16px;
            this.ButtonX2.Location = new System.Drawing.Point(112, 3);
            this.ButtonX2.MinimumSize = new System.Drawing.Size(20, 20);
            this.ButtonX2.Name = "ButtonX2";
            this.ButtonX2.Size = new System.Drawing.Size(115, 20);
            this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SuperTooltip1.SetSuperTooltip(this.ButtonX2, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit Name & Description", null, null, DevComponents.DotNetBar.eTooltipColor.Gray, false, false, new System.Drawing.Size(0, 0)));
            this.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX2.TabIndex = 45;
            this.ButtonX2.Text = "Edit Preset Info";
            this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // ButtonX7
            // 
            this.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX7.FocusCuesEnabled = false;
            this.ButtonX7.Image = global::SM64_ROM_Manager.ModelImporterGUI.My.Resources.Resources.icons8_delete_2_16px;
            this.ButtonX7.Location = new System.Drawing.Point(3, 29);
            this.ButtonX7.Name = "ButtonX7";
            this.ButtonX7.Size = new System.Drawing.Size(103, 20);
            this.ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX7.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX7.TabIndex = 45;
            this.ButtonX7.Text = "Delete Preset";
            this.ButtonX7.Click += new System.EventHandler(this.ButtonX7_Click);
            // 
            // ModelImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 489);
            this.Controls.Add(this.ButtonX4);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.LabelX6);
            this.Controls.Add(this.LabelX7);
            this.Controls.Add(this.TextBoxX1);
            this.Controls.Add(this.TextBoxX2);
            this.Controls.Add(this.ComboBoxEx2);
            this.Controls.Add(this.ComboBoxEx1);
            this.Controls.Add(this.LabelX4);
            this.Controls.Add(this.ButtonX_ConvertMdl);
            this.Controls.Add(this.ButtonX_ImportMdl);
            this.Controls.Add(this.TextBoxX_Output);
            this.Controls.Add(this.LabelX3);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.LabelX2);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.ButtonX_OpenRom);
            this.Controls.Add(this.LabelX50);
            this.Controls.Add(this.LabelX51);
            this.Controls.Add(this.LabelX54);
            this.Controls.Add(this.TextBoxX_RomAddr);
            this.Controls.Add(this.TextBoxX_MaxLength);
            this.Controls.Add(this.TextBoxX_BankAddr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModelImporter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Importer";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.LabelX LabelX50;


        private DevComponents.DotNetBar.LabelX LabelX51;


        private DevComponents.DotNetBar.LabelX LabelX54;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_RomAddr;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_MaxLength;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_BankAddr;


        private DevComponents.DotNetBar.ButtonX ButtonX_OpenRom;


        private DevComponents.DotNetBar.LabelX LabelX1;


        private DevComponents.DotNetBar.LabelX LabelX2;


        private DevComponents.DotNetBar.Controls.Line Line2;


        private DevComponents.DotNetBar.Controls.Line Line1;


        private DevComponents.DotNetBar.Controls.Line Line3;


        private DevComponents.DotNetBar.LabelX LabelX3;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Output;


        private DevComponents.DotNetBar.ButtonX ButtonX_ImportMdl;


        private DevComponents.DotNetBar.ButtonX ButtonX_ConvertMdl;


        private DevComponents.DotNetBar.LabelX LabelX4;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx1;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx2;


        private DevComponents.DotNetBar.LabelX LabelX6;


        private DevComponents.DotNetBar.LabelX LabelX7;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX2;


        private DevComponents.DotNetBar.SuperTooltip SuperTooltip1;


        private Panel Panel1;


        private DevComponents.DotNetBar.LabelX LabelX5;


        private TableLayoutPanel TableLayoutPanel2;


        private DevComponents.DotNetBar.ButtonX ButtonX3;


        private DevComponents.DotNetBar.LabelX LabelX_Description;


        private DevComponents.DotNetBar.LabelX LabelX_PatchName;


        private TableLayoutPanel TableLayoutPanel1;


        private DevComponents.DotNetBar.ButtonX ButtonX4;


        private DevComponents.DotNetBar.ButtonX ButtonX7;


        private DevComponents.DotNetBar.ButtonX ButtonX6;


        private DevComponents.DotNetBar.Controls.Flyout Flyout1;


        private DevComponents.DotNetBar.ButtonX ButtonX1;


        private DevComponents.DotNetBar.ButtonX ButtonX2;


        private DevComponents.DotNetBar.ButtonItem ButtonItem1;


        private DevComponents.DotNetBar.ButtonItem ButtonItem2;
        private DevComponents.DotNetBar.LabelX labelX_Version;
    }
}