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
        private System.ComponentModel.IContainer components = new System.ComponentModel.Container();

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatesAvailableDialog));
            this.LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.PictureBox_AppIcon = new System.Windows.Forms.PictureBox();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.LabelX_NewVersion = new DevComponents.DotNetBar.LabelX();
            this.LabelX_NewChannel = new DevComponents.DotNetBar.LabelX();
            this.LabelX_NewBuild = new DevComponents.DotNetBar.LabelX();
            this.LabelX_CurrentVersion = new DevComponents.DotNetBar.LabelX();
            this.LabelX_CurrentChannel = new DevComponents.DotNetBar.LabelX();
            this.LabelX_CurrentBuild = new DevComponents.DotNetBar.LabelX();
            this.Panel_Changelog = new System.Windows.Forms.Panel();
            this.ButtonX_Install = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem8 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem9 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.LayoutControlItem10 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem11 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_AppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.LayoutControl1.Controls.Add(this.PictureBox_AppIcon);
            this.LayoutControl1.Controls.Add(this.LabelX1);
            this.LayoutControl1.Controls.Add(this.LabelX_NewVersion);
            this.LayoutControl1.Controls.Add(this.LabelX_NewChannel);
            this.LayoutControl1.Controls.Add(this.LabelX_NewBuild);
            this.LayoutControl1.Controls.Add(this.LabelX_CurrentVersion);
            this.LayoutControl1.Controls.Add(this.LabelX_CurrentChannel);
            this.LayoutControl1.Controls.Add(this.LabelX_CurrentBuild);
            this.LayoutControl1.Controls.Add(this.Panel_Changelog);
            this.LayoutControl1.Controls.Add(this.ButtonX_Install);
            this.LayoutControl1.Controls.Add(this.ButtonX_Cancel);
            resources.ApplyResources(this.LayoutControl1, "LayoutControl1");
            this.LayoutControl1.ForeColor = System.Drawing.Color.Black;
            this.LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            this.LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem1,
            this.LayoutControlItem2,
            this.LayoutControlItem3,
            this.LayoutControlItem4,
            this.LayoutControlItem5,
            this.LayoutControlItem6,
            this.LayoutControlItem7,
            this.LayoutControlItem8,
            this.LayoutControlItem9,
            this.LayoutSpacerItem1,
            this.LayoutControlItem10,
            this.LayoutControlItem11});
            // 
            // PictureBox_AppIcon
            // 
            resources.ApplyResources(this.PictureBox_AppIcon, "PictureBox_AppIcon");
            this.PictureBox_AppIcon.Name = "PictureBox_AppIcon";
            this.PictureBox_AppIcon.TabStop = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX1, "LabelX1");
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LabelX_NewVersion
            // 
            // 
            // 
            // 
            this.LabelX_NewVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_NewVersion, "LabelX_NewVersion");
            this.LabelX_NewVersion.Name = "LabelX_NewVersion";
            // 
            // LabelX_NewChannel
            // 
            // 
            // 
            // 
            this.LabelX_NewChannel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_NewChannel, "LabelX_NewChannel");
            this.LabelX_NewChannel.Name = "LabelX_NewChannel";
            // 
            // LabelX_NewBuild
            // 
            // 
            // 
            // 
            this.LabelX_NewBuild.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_NewBuild, "LabelX_NewBuild");
            this.LabelX_NewBuild.Name = "LabelX_NewBuild";
            // 
            // LabelX_CurrentVersion
            // 
            // 
            // 
            // 
            this.LabelX_CurrentVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_CurrentVersion, "LabelX_CurrentVersion");
            this.LabelX_CurrentVersion.Name = "LabelX_CurrentVersion";
            // 
            // LabelX_CurrentChannel
            // 
            // 
            // 
            // 
            this.LabelX_CurrentChannel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_CurrentChannel, "LabelX_CurrentChannel");
            this.LabelX_CurrentChannel.Name = "LabelX_CurrentChannel";
            // 
            // LabelX_CurrentBuild
            // 
            // 
            // 
            // 
            this.LabelX_CurrentBuild.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_CurrentBuild, "LabelX_CurrentBuild");
            this.LabelX_CurrentBuild.Name = "LabelX_CurrentBuild";
            // 
            // Panel_Changelog
            // 
            this.Panel_Changelog.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Panel_Changelog, "Panel_Changelog");
            this.Panel_Changelog.Name = "Panel_Changelog";
            // 
            // ButtonX_Install
            // 
            this.ButtonX_Install.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Install.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Install.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.ButtonX_Install, "ButtonX_Install");
            this.ButtonX_Install.Name = "ButtonX_Install";
            this.ButtonX_Install.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Cancel
            // 
            this.ButtonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.ButtonX_Cancel, "ButtonX_Cancel");
            this.ButtonX_Cancel.Name = "ButtonX_Cancel";
            this.ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.PictureBox_AppIcon;
            this.LayoutControlItem1.Height = 58;
            this.LayoutControlItem1.MinSize = new System.Drawing.Size(50, 50);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            resources.ApplyResources(this.LayoutControlItem1, "LayoutControlItem1");
            this.LayoutControlItem1.TextVisible = false;
            this.LayoutControlItem1.Width = 58;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.LabelX1;
            this.LayoutControlItem2.Height = 31;
            this.LayoutControlItem2.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            resources.ApplyResources(this.LayoutControlItem2, "LayoutControlItem2");
            this.LayoutControlItem2.TextVisible = false;
            this.LayoutControlItem2.Width = 99;
            this.LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.LabelX_NewVersion;
            this.LayoutControlItem3.Height = 31;
            this.LayoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            resources.ApplyResources(this.LayoutControlItem3, "LayoutControlItem3");
            this.LayoutControlItem3.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem3.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LayoutControlItem3.Width = 50;
            this.LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.LabelX_NewChannel;
            this.LayoutControlItem4.Height = 31;
            this.LayoutControlItem4.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            this.LayoutControlItem4.SharedTextSizeEnabled = false;
            resources.ApplyResources(this.LayoutControlItem4, "LayoutControlItem4");
            this.LayoutControlItem4.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem4.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LayoutControlItem4.Width = 30;
            this.LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            this.LayoutControlItem5.Control = this.LabelX_NewBuild;
            this.LayoutControlItem5.Height = 31;
            this.LayoutControlItem5.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem5.Name = "LayoutControlItem5";
            this.LayoutControlItem5.SharedTextSizeEnabled = false;
            resources.ApplyResources(this.LayoutControlItem5, "LayoutControlItem5");
            this.LayoutControlItem5.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem5.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LayoutControlItem5.Width = 20;
            this.LayoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem6
            // 
            this.LayoutControlItem6.Control = this.LabelX_CurrentVersion;
            this.LayoutControlItem6.Height = 31;
            this.LayoutControlItem6.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem6.Name = "LayoutControlItem6";
            resources.ApplyResources(this.LayoutControlItem6, "LayoutControlItem6");
            this.LayoutControlItem6.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem6.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LayoutControlItem6.Width = 50;
            this.LayoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem7
            // 
            this.LayoutControlItem7.Control = this.LabelX_CurrentChannel;
            this.LayoutControlItem7.Height = 31;
            this.LayoutControlItem7.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem7.Name = "LayoutControlItem7";
            this.LayoutControlItem7.SharedTextSizeEnabled = false;
            resources.ApplyResources(this.LayoutControlItem7, "LayoutControlItem7");
            this.LayoutControlItem7.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem7.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LayoutControlItem7.Width = 30;
            this.LayoutControlItem7.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem8
            // 
            this.LayoutControlItem8.Control = this.LabelX_CurrentBuild;
            this.LayoutControlItem8.Height = 31;
            this.LayoutControlItem8.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem8.Name = "LayoutControlItem8";
            this.LayoutControlItem8.SharedTextSizeEnabled = false;
            resources.ApplyResources(this.LayoutControlItem8, "LayoutControlItem8");
            this.LayoutControlItem8.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem8.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LayoutControlItem8.Width = 20;
            this.LayoutControlItem8.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem9
            // 
            this.LayoutControlItem9.Control = this.Panel_Changelog;
            this.LayoutControlItem9.Height = 99;
            this.LayoutControlItem9.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.LayoutControlItem9.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem9.Name = "LayoutControlItem9";
            resources.ApplyResources(this.LayoutControlItem9, "LayoutControlItem9");
            this.LayoutControlItem9.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem9.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LayoutControlItem9.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutControlItem9.Width = 100;
            this.LayoutControlItem9.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            this.LayoutSpacerItem1.Height = 31;
            this.LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            this.LayoutSpacerItem1.Width = 99;
            this.LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem10
            // 
            this.LayoutControlItem10.Control = this.ButtonX_Install;
            this.LayoutControlItem10.Height = 31;
            this.LayoutControlItem10.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem10.Name = "LayoutControlItem10";
            this.LayoutControlItem10.Width = 100;
            // 
            // LayoutControlItem11
            // 
            this.LayoutControlItem11.Control = this.ButtonX_Cancel;
            this.LayoutControlItem11.Height = 31;
            this.LayoutControlItem11.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem11.Name = "LayoutControlItem11";
            this.LayoutControlItem11.Width = 100;
            // 
            // UpdatesAvailableDialog
            // 
            this.AcceptButton = this.ButtonX_Install;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonX_Cancel;
            this.Controls.Add(this.LayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatesAvailableDialog";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_AppIcon)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;

        private PictureBox PictureBox_AppIcon;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;

        private LabelX LabelX1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;

        private LabelX LabelX_NewVersion;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;

        private System.Windows.Forms.Panel Panel_Changelog;

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