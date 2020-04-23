using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Client.GUI
{
    [DesignerGenerated()]
    internal partial class UpdatesAvailableDialog : OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatesAvailableDialog));
            LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            PictureBox_AppIcon = new PictureBox();
            LabelX1 = new LabelX();
            LabelX_NewVersion = new LabelX();
            LabelX_NewChannel = new LabelX();
            LabelX_NewBuild = new LabelX();
            LabelX_CurrentVersion = new LabelX();
            LabelX_CurrentChannel = new LabelX();
            LabelX_CurrentBuild = new LabelX();
            RichTextBoxEx_Changelog = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            ButtonX_Install = new ButtonX();
            ButtonX_Cancel = new ButtonX();
            LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem8 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem9 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            LayoutControlItem10 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem11 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_AppIcon).BeginInit();
            SuspendLayout();
            // 
            // LayoutControl1
            // 
            LayoutControl1.BackColor = Color.Transparent;
            LayoutControl1.Controls.Add(PictureBox_AppIcon);
            LayoutControl1.Controls.Add(LabelX1);
            LayoutControl1.Controls.Add(LabelX_NewVersion);
            LayoutControl1.Controls.Add(LabelX_NewChannel);
            LayoutControl1.Controls.Add(LabelX_NewBuild);
            LayoutControl1.Controls.Add(LabelX_CurrentVersion);
            LayoutControl1.Controls.Add(LabelX_CurrentChannel);
            LayoutControl1.Controls.Add(LabelX_CurrentBuild);
            LayoutControl1.Controls.Add(RichTextBoxEx_Changelog);
            LayoutControl1.Controls.Add(ButtonX_Install);
            LayoutControl1.Controls.Add(ButtonX_Cancel);
            resources.ApplyResources(LayoutControl1, "LayoutControl1");
            LayoutControl1.ForeColor = Color.Black;
            LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { LayoutControlItem1, LayoutControlItem2, LayoutControlItem3, LayoutControlItem4, LayoutControlItem5, LayoutControlItem6, LayoutControlItem7, LayoutControlItem8, LayoutControlItem9, LayoutSpacerItem1, LayoutControlItem10, LayoutControlItem11 });
            // 
            // PictureBox_AppIcon
            // 
            resources.ApplyResources(PictureBox_AppIcon, "PictureBox_AppIcon");
            PictureBox_AppIcon.Name = "PictureBox_AppIcon";
            PictureBox_AppIcon.TabStop = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            LabelX1.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(LabelX1, "LabelX1");
            LabelX1.Name = "LabelX1";
            LabelX1.TextAlignment = StringAlignment.Center;
            // 
            // LabelX_NewVersion
            // 
            // 
            // 
            // 
            LabelX_NewVersion.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(LabelX_NewVersion, "LabelX_NewVersion");
            LabelX_NewVersion.Name = "LabelX_NewVersion";
            // 
            // LabelX_NewChannel
            // 
            // 
            // 
            // 
            LabelX_NewChannel.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(LabelX_NewChannel, "LabelX_NewChannel");
            LabelX_NewChannel.Name = "LabelX_NewChannel";
            // 
            // LabelX_NewBuild
            // 
            // 
            // 
            // 
            LabelX_NewBuild.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(LabelX_NewBuild, "LabelX_NewBuild");
            LabelX_NewBuild.Name = "LabelX_NewBuild";
            // 
            // LabelX_CurrentVersion
            // 
            // 
            // 
            // 
            LabelX_CurrentVersion.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(LabelX_CurrentVersion, "LabelX_CurrentVersion");
            LabelX_CurrentVersion.Name = "LabelX_CurrentVersion";
            // 
            // LabelX_CurrentChannel
            // 
            // 
            // 
            // 
            LabelX_CurrentChannel.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(LabelX_CurrentChannel, "LabelX_CurrentChannel");
            LabelX_CurrentChannel.Name = "LabelX_CurrentChannel";
            // 
            // LabelX_CurrentBuild
            // 
            // 
            // 
            // 
            LabelX_CurrentBuild.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(LabelX_CurrentBuild, "LabelX_CurrentBuild");
            LabelX_CurrentBuild.Name = "LabelX_CurrentBuild";
            // 
            // RichTextBoxEx_Changelog
            // 
            // 
            // 
            // 
            RichTextBoxEx_Changelog.BackgroundStyle.Class = "RichTextBoxBorder";
            RichTextBoxEx_Changelog.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(RichTextBoxEx_Changelog, "RichTextBoxEx_Changelog");
            RichTextBoxEx_Changelog.Name = "RichTextBoxEx_Changelog";
            RichTextBoxEx_Changelog.ReadOnly = true;
            RichTextBoxEx_Changelog.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fnil\fcharset0 Microsoft S" + "ans Serif;}}" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + @"\viewkind4\uc1\pard\f0\fs17\par" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "}" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
            // 
            // ButtonX_Install
            // 
            ButtonX_Install.AccessibleRole = AccessibleRole.PushButton;
            ButtonX_Install.ColorTable = eButtonColor.OrangeWithBackground;
            ButtonX_Install.DialogResult = DialogResult.OK;
            resources.ApplyResources(ButtonX_Install, "ButtonX_Install");
            ButtonX_Install.Name = "ButtonX_Install";
            ButtonX_Install.Style = eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Cancel
            // 
            ButtonX_Cancel.AccessibleRole = AccessibleRole.PushButton;
            ButtonX_Cancel.ColorTable = eButtonColor.OrangeWithBackground;
            ButtonX_Cancel.DialogResult = DialogResult.Cancel;
            resources.ApplyResources(ButtonX_Cancel, "ButtonX_Cancel");
            ButtonX_Cancel.Name = "ButtonX_Cancel";
            ButtonX_Cancel.Style = eDotNetBarStyle.StyleManagerControlled;
            // 
            // LayoutControlItem1
            // 
            LayoutControlItem1.Control = PictureBox_AppIcon;
            LayoutControlItem1.Height = 58;
            LayoutControlItem1.MinSize = new Size(50, 50);
            LayoutControlItem1.Name = "LayoutControlItem1";
            resources.ApplyResources(LayoutControlItem1, "LayoutControlItem1");
            LayoutControlItem1.TextVisible = false;
            LayoutControlItem1.Width = 58;
            // 
            // LayoutControlItem2
            // 
            LayoutControlItem2.Control = LabelX1;
            LayoutControlItem2.Height = 31;
            LayoutControlItem2.MinSize = new Size(64, 18);
            LayoutControlItem2.Name = "LayoutControlItem2";
            resources.ApplyResources(LayoutControlItem2, "LayoutControlItem2");
            LayoutControlItem2.TextVisible = false;
            LayoutControlItem2.Width = 99;
            LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            LayoutControlItem3.Control = LabelX_NewVersion;
            LayoutControlItem3.Height = 31;
            LayoutControlItem3.MinSize = new Size(64, 18);
            LayoutControlItem3.Name = "LayoutControlItem3";
            resources.ApplyResources(LayoutControlItem3, "LayoutControlItem3");
            LayoutControlItem3.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem3.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            LayoutControlItem3.Width = 50;
            LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            LayoutControlItem4.Control = LabelX_NewChannel;
            LayoutControlItem4.Height = 31;
            LayoutControlItem4.MinSize = new Size(64, 18);
            LayoutControlItem4.Name = "LayoutControlItem4";
            LayoutControlItem4.SharedTextSizeEnabled = false;
            resources.ApplyResources(LayoutControlItem4, "LayoutControlItem4");
            LayoutControlItem4.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem4.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            LayoutControlItem4.Width = 30;
            LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            LayoutControlItem5.Control = LabelX_NewBuild;
            LayoutControlItem5.Height = 31;
            LayoutControlItem5.MinSize = new Size(64, 18);
            LayoutControlItem5.Name = "LayoutControlItem5";
            LayoutControlItem5.SharedTextSizeEnabled = false;
            resources.ApplyResources(LayoutControlItem5, "LayoutControlItem5");
            LayoutControlItem5.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem5.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            LayoutControlItem5.Width = 20;
            LayoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem6
            // 
            LayoutControlItem6.Control = LabelX_CurrentVersion;
            LayoutControlItem6.Height = 31;
            LayoutControlItem6.MinSize = new Size(64, 18);
            LayoutControlItem6.Name = "LayoutControlItem6";
            resources.ApplyResources(LayoutControlItem6, "LayoutControlItem6");
            LayoutControlItem6.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem6.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            LayoutControlItem6.Width = 50;
            LayoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem7
            // 
            LayoutControlItem7.Control = LabelX_CurrentChannel;
            LayoutControlItem7.Height = 31;
            LayoutControlItem7.MinSize = new Size(64, 18);
            LayoutControlItem7.Name = "LayoutControlItem7";
            LayoutControlItem7.SharedTextSizeEnabled = false;
            resources.ApplyResources(LayoutControlItem7, "LayoutControlItem7");
            LayoutControlItem7.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem7.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            LayoutControlItem7.Width = 30;
            LayoutControlItem7.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem8
            // 
            LayoutControlItem8.Control = LabelX_CurrentBuild;
            LayoutControlItem8.Height = 31;
            LayoutControlItem8.MinSize = new Size(64, 18);
            LayoutControlItem8.Name = "LayoutControlItem8";
            LayoutControlItem8.SharedTextSizeEnabled = false;
            resources.ApplyResources(LayoutControlItem8, "LayoutControlItem8");
            LayoutControlItem8.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem8.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            LayoutControlItem8.Width = 20;
            LayoutControlItem8.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem9
            // 
            LayoutControlItem9.Control = RichTextBoxEx_Changelog;
            LayoutControlItem9.Height = 99;
            LayoutControlItem9.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            LayoutControlItem9.MinSize = new Size(64, 18);
            LayoutControlItem9.Name = "LayoutControlItem9";
            resources.ApplyResources(LayoutControlItem9, "LayoutControlItem9");
            LayoutControlItem9.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            LayoutControlItem9.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            LayoutControlItem9.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            LayoutControlItem9.Width = 100;
            LayoutControlItem9.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            LayoutSpacerItem1.Height = 31;
            LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            LayoutSpacerItem1.Width = 99;
            LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem10
            // 
            LayoutControlItem10.Control = ButtonX_Install;
            LayoutControlItem10.Height = 31;
            LayoutControlItem10.MinSize = new Size(32, 20);
            LayoutControlItem10.Name = "LayoutControlItem10";
            LayoutControlItem10.Width = 100;
            // 
            // LayoutControlItem11
            // 
            LayoutControlItem11.Control = ButtonX_Cancel;
            LayoutControlItem11.Height = 31;
            LayoutControlItem11.MinSize = new Size(32, 20);
            LayoutControlItem11.Name = "LayoutControlItem11";
            LayoutControlItem11.Width = 100;
            // 
            // UpdatesAvailableDialog
            // 
            AcceptButton = ButtonX_Install;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButtonX_Cancel;
            Controls.Add(LayoutControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdatesAvailableDialog";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox_AppIcon).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;

        private PictureBox PictureBox_AppIcon;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;

        private LabelX LabelX1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;

        private LabelX LabelX_NewVersion;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;

        private DevComponents.DotNetBar.Controls.RichTextBoxEx RichTextBoxEx_Changelog;

        private LabelX LabelX_NewChannel;

        private LabelX LabelX_NewBuild;

        private LabelX LabelX_CurrentVersion;

        private LabelX LabelX_CurrentChannel;

        private LabelX LabelX_CurrentBuild;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem7;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem8;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem9;

        private ButtonX ButtonX_Install;

        private ButtonX ButtonX_Cancel;

        private DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem10;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem11;

    }
}