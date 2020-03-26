using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    [DesignerGenerated()]
    public partial class ApplicationVersionInput : DevComponents.DotNetBar.OfficeForm
    {

        // Form overrides dispose to clean up the component list.
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

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationVersionInput));
            TextBoxX_VersionName = new DevComponents.DotNetBar.Controls.TextBoxX();
            TextBoxX_Version = new DevComponents.DotNetBar.Controls.TextBoxX();
            ComboBoxEx_Channel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            IntegerInput_Build = new DevComponents.Editors.IntegerInput();
            LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            ButtonX_Okay = new DevComponents.DotNetBar.ButtonX();
            LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)IntegerInput_Build).BeginInit();
            LayoutControl1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxX_VersionName
            // 
            TextBoxX_VersionName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxX_VersionName.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_VersionName.Border.Class = "TextBoxBorder";
            TextBoxX_VersionName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_VersionName.DisabledBackColor = Color.White;
            TextBoxX_VersionName.ForeColor = Color.Black;
            TextBoxX_VersionName.Location = new Point(53, 4);
            TextBoxX_VersionName.Margin = new Padding(0);
            TextBoxX_VersionName.Name = "TextBoxX_VersionName";
            TextBoxX_VersionName.PreventEnterBeep = true;
            TextBoxX_VersionName.Size = new Size(275, 20);
            TextBoxX_VersionName.TabIndex = 0;
            TextBoxX_VersionName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            TextBoxX_VersionName.WatermarkText = "Bspw.: Version 1.2.5.0 - Dark Mode und vieles mehr!";
            // 
            // TextBoxX_Version
            // 
            TextBoxX_Version.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxX_Version.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_Version.Border.Class = "TextBoxBorder";
            TextBoxX_Version.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_Version.DisabledBackColor = Color.White;
            TextBoxX_Version.ForeColor = Color.Black;
            TextBoxX_Version.Location = new Point(53, 32);
            TextBoxX_Version.Margin = new Padding(0);
            TextBoxX_Version.Name = "TextBoxX_Version";
            TextBoxX_Version.PreventEnterBeep = true;
            TextBoxX_Version.Size = new Size(275, 20);
            TextBoxX_Version.TabIndex = 1;
            TextBoxX_Version.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            TextBoxX_Version.WatermarkText = "Bspw.: 1.2.5.0";
            // 
            // ComboBoxEx_Channel
            // 
            ComboBoxEx_Channel.DisplayMember = "Text";
            ComboBoxEx_Channel.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBoxEx_Channel.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEx_Channel.ForeColor = Color.Black;
            ComboBoxEx_Channel.FormattingEnabled = true;
            ComboBoxEx_Channel.ItemHeight = 15;
            ComboBoxEx_Channel.Location = new Point(53, 60);
            ComboBoxEx_Channel.Margin = new Padding(0);
            ComboBoxEx_Channel.Name = "ComboBoxEx_Channel";
            ComboBoxEx_Channel.Size = new Size(275, 21);
            ComboBoxEx_Channel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ComboBoxEx_Channel.TabIndex = 2;
            // 
            // IntegerInput_Build
            // 
            IntegerInput_Build.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            IntegerInput_Build.BackgroundStyle.Class = "DateTimeInputBackground";
            IntegerInput_Build.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            IntegerInput_Build.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            IntegerInput_Build.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            IntegerInput_Build.Location = new Point(53, 89);
            IntegerInput_Build.Margin = new Padding(0);
            IntegerInput_Build.MinValue = 0;
            IntegerInput_Build.Name = "IntegerInput_Build";
            IntegerInput_Build.ShowUpDown = true;
            IntegerInput_Build.Size = new Size(275, 20);
            IntegerInput_Build.TabIndex = 3;
            // 
            // LayoutControl1
            // 
            LayoutControl1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            LayoutControl1.Controls.Add(TextBoxX_VersionName);
            LayoutControl1.Controls.Add(TextBoxX_Version);
            LayoutControl1.Controls.Add(ComboBoxEx_Channel);
            LayoutControl1.Controls.Add(IntegerInput_Build);
            LayoutControl1.Controls.Add(ButtonX_Cancel);
            LayoutControl1.Controls.Add(ButtonX_Okay);
            LayoutControl1.Dock = DockStyle.Fill;
            LayoutControl1.ForeColor = Color.Black;
            LayoutControl1.Location = new Point(0, 0);
            LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { LayoutControlItem1, LayoutControlItem2, LayoutControlItem3, LayoutControlItem4, LayoutSpacerItem1, LayoutControlItem5, LayoutControlItem6 });
            LayoutControl1.Size = new Size(332, 144);
            LayoutControl1.TabIndex = 5;
            // 
            // ButtonX_Cancel
            // 
            ButtonX_Cancel.AccessibleRole = AccessibleRole.PushButton;
            ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX_Cancel.DialogResult = DialogResult.Cancel;
            ButtonX_Cancel.Location = new Point(170, 117);
            ButtonX_Cancel.Margin = new Padding(0);
            ButtonX_Cancel.Name = "ButtonX_Cancel";
            ButtonX_Cancel.Size = new Size(75, 23);
            ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ButtonX_Cancel.TabIndex = 5;
            ButtonX_Cancel.Text = "Abbrechen";
            // 
            // ButtonX_Okay
            // 
            ButtonX_Okay.AccessibleRole = AccessibleRole.PushButton;
            ButtonX_Okay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX_Okay.DialogResult = DialogResult.OK;
            ButtonX_Okay.Location = new Point(253, 117);
            ButtonX_Okay.Margin = new Padding(0);
            ButtonX_Okay.Name = "ButtonX_Okay";
            ButtonX_Okay.Size = new Size(75, 23);
            ButtonX_Okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ButtonX_Okay.TabIndex = 6;
            ButtonX_Okay.Text = "Okay";
            // 
            // LayoutControlItem1
            // 
            LayoutControlItem1.Control = TextBoxX_VersionName;
            LayoutControlItem1.Height = 28;
            LayoutControlItem1.MinSize = new Size(120, 0);
            LayoutControlItem1.Name = "LayoutControlItem1";
            LayoutControlItem1.Text = "Name:";
            LayoutControlItem1.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem1.Width = 100;
            LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            LayoutControlItem2.Control = TextBoxX_Version;
            LayoutControlItem2.Height = 28;
            LayoutControlItem2.MinSize = new Size(120, 0);
            LayoutControlItem2.Name = "LayoutControlItem2";
            LayoutControlItem2.Text = "Version:";
            LayoutControlItem2.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem2.Width = 100;
            LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            LayoutControlItem3.Control = ComboBoxEx_Channel;
            LayoutControlItem3.Height = 29;
            LayoutControlItem3.MinSize = new Size(64, 18);
            LayoutControlItem3.Name = "LayoutControlItem3";
            LayoutControlItem3.Text = "Kanal:";
            LayoutControlItem3.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem3.Width = 100;
            LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            LayoutControlItem4.Control = IntegerInput_Build;
            LayoutControlItem4.Height = 28;
            LayoutControlItem4.MinSize = new Size(120, 0);
            LayoutControlItem4.Name = "LayoutControlItem4";
            LayoutControlItem4.Text = "Build:";
            LayoutControlItem4.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem4.Width = 100;
            LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            LayoutSpacerItem1.Height = 31;
            LayoutSpacerItem1.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            LayoutSpacerItem1.Width = 99;
            LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            LayoutControlItem5.Control = ButtonX_Cancel;
            LayoutControlItem5.Height = 31;
            LayoutControlItem5.MinSize = new Size(32, 20);
            LayoutControlItem5.Name = "LayoutControlItem5";
            LayoutControlItem5.Width = 83;
            // 
            // LayoutControlItem6
            // 
            LayoutControlItem6.Control = ButtonX_Okay;
            LayoutControlItem6.Height = 31;
            LayoutControlItem6.MinSize = new Size(32, 20);
            LayoutControlItem6.Name = "LayoutControlItem6";
            LayoutControlItem6.Width = 83;
            // 
            // ApplicationVersionInput
            // 
            AcceptButton = ButtonX_Okay;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButtonX_Cancel;
            ClientSize = new Size(332, 144);
            Controls.Add(LayoutControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ApplicationVersionInput";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Version";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)IntegerInput_Build).EndInit();
            LayoutControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_VersionName;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Version;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Channel;


        private DevComponents.Editors.IntegerInput IntegerInput_Build;


        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4;


        private DevComponents.DotNetBar.ButtonX ButtonX_Cancel;


        private DevComponents.DotNetBar.ButtonX ButtonX_Okay;

        private DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6;
    }
}