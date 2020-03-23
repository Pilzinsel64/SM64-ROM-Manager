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
            _LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _PictureBox_AppIcon = new PictureBox();
            _LabelX1 = new LabelX();
            _LabelX_NewVersion = new LabelX();
            _LabelX_NewChannel = new LabelX();
            _LabelX_NewBuild = new LabelX();
            _LabelX_CurrentVersion = new LabelX();
            _LabelX_CurrentChannel = new LabelX();
            _LabelX_CurrentBuild = new LabelX();
            _RichTextBoxEx_Changelog = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            _ButtonX_Install = new ButtonX();
            _ButtonX_Cancel = new ButtonX();
            _LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem8 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem9 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            _LayoutControlItem10 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem11 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_PictureBox_AppIcon).BeginInit();
            SuspendLayout();
            // 
            // LayoutControl1
            // 
            _LayoutControl1.BackColor = Color.Transparent;
            _LayoutControl1.Controls.Add(_PictureBox_AppIcon);
            _LayoutControl1.Controls.Add(_LabelX1);
            _LayoutControl1.Controls.Add(_LabelX_NewVersion);
            _LayoutControl1.Controls.Add(_LabelX_NewChannel);
            _LayoutControl1.Controls.Add(_LabelX_NewBuild);
            _LayoutControl1.Controls.Add(_LabelX_CurrentVersion);
            _LayoutControl1.Controls.Add(_LabelX_CurrentChannel);
            _LayoutControl1.Controls.Add(_LabelX_CurrentBuild);
            _LayoutControl1.Controls.Add(_RichTextBoxEx_Changelog);
            _LayoutControl1.Controls.Add(_ButtonX_Install);
            _LayoutControl1.Controls.Add(_ButtonX_Cancel);
            resources.ApplyResources(_LayoutControl1, "LayoutControl1");
            _LayoutControl1.ForeColor = Color.Black;
            _LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            _LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem1, _LayoutControlItem2, _LayoutControlItem3, _LayoutControlItem4, _LayoutControlItem5, _LayoutControlItem6, _LayoutControlItem7, _LayoutControlItem8, _LayoutControlItem9, _LayoutSpacerItem1, _LayoutControlItem10, _LayoutControlItem11 });
            // 
            // PictureBox_AppIcon
            // 
            resources.ApplyResources(_PictureBox_AppIcon, "PictureBox_AppIcon");
            _PictureBox_AppIcon.Name = "PictureBox_AppIcon";
            _PictureBox_AppIcon.TabStop = false;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(_LabelX1, "LabelX1");
            _LabelX1.Name = "LabelX1";
            _LabelX1.TextAlignment = StringAlignment.Center;
            // 
            // LabelX_NewVersion
            // 
            // 
            // 
            // 
            _LabelX_NewVersion.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(_LabelX_NewVersion, "LabelX_NewVersion");
            _LabelX_NewVersion.Name = "LabelX_NewVersion";
            // 
            // LabelX_NewChannel
            // 
            // 
            // 
            // 
            _LabelX_NewChannel.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(_LabelX_NewChannel, "LabelX_NewChannel");
            _LabelX_NewChannel.Name = "LabelX_NewChannel";
            // 
            // LabelX_NewBuild
            // 
            // 
            // 
            // 
            _LabelX_NewBuild.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(_LabelX_NewBuild, "LabelX_NewBuild");
            _LabelX_NewBuild.Name = "LabelX_NewBuild";
            // 
            // LabelX_CurrentVersion
            // 
            // 
            // 
            // 
            _LabelX_CurrentVersion.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(_LabelX_CurrentVersion, "LabelX_CurrentVersion");
            _LabelX_CurrentVersion.Name = "LabelX_CurrentVersion";
            // 
            // LabelX_CurrentChannel
            // 
            // 
            // 
            // 
            _LabelX_CurrentChannel.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(_LabelX_CurrentChannel, "LabelX_CurrentChannel");
            _LabelX_CurrentChannel.Name = "LabelX_CurrentChannel";
            // 
            // LabelX_CurrentBuild
            // 
            // 
            // 
            // 
            _LabelX_CurrentBuild.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(_LabelX_CurrentBuild, "LabelX_CurrentBuild");
            _LabelX_CurrentBuild.Name = "LabelX_CurrentBuild";
            // 
            // RichTextBoxEx_Changelog
            // 
            // 
            // 
            // 
            _RichTextBoxEx_Changelog.BackgroundStyle.Class = "RichTextBoxBorder";
            _RichTextBoxEx_Changelog.BackgroundStyle.CornerType = eCornerType.Square;
            resources.ApplyResources(_RichTextBoxEx_Changelog, "RichTextBoxEx_Changelog");
            _RichTextBoxEx_Changelog.Name = "RichTextBoxEx_Changelog";
            _RichTextBoxEx_Changelog.ReadOnly = true;
            _RichTextBoxEx_Changelog.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fnil\fcharset0 Microsoft S" + "ans Serif;}}" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + @"\viewkind4\uc1\pard\f0\fs17\par" + Conversions.ToString((char)13) + Conversions.ToString((char)10) + "}" + Conversions.ToString((char)13) + Conversions.ToString((char)10);
            // 
            // ButtonX_Install
            // 
            _ButtonX_Install.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Install.ColorTable = eButtonColor.OrangeWithBackground;
            _ButtonX_Install.DialogResult = DialogResult.OK;
            resources.ApplyResources(_ButtonX_Install, "ButtonX_Install");
            _ButtonX_Install.Name = "ButtonX_Install";
            _ButtonX_Install.Style = eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Cancel
            // 
            _ButtonX_Cancel.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Cancel.ColorTable = eButtonColor.OrangeWithBackground;
            _ButtonX_Cancel.DialogResult = DialogResult.Cancel;
            resources.ApplyResources(_ButtonX_Cancel, "ButtonX_Cancel");
            _ButtonX_Cancel.Name = "ButtonX_Cancel";
            _ButtonX_Cancel.Style = eDotNetBarStyle.StyleManagerControlled;
            // 
            // LayoutControlItem1
            // 
            _LayoutControlItem1.Control = _PictureBox_AppIcon;
            _LayoutControlItem1.Height = 58;
            _LayoutControlItem1.MinSize = new Size(50, 50);
            _LayoutControlItem1.Name = "LayoutControlItem1";
            resources.ApplyResources(_LayoutControlItem1, "LayoutControlItem1");
            _LayoutControlItem1.TextVisible = false;
            _LayoutControlItem1.Width = 58;
            // 
            // LayoutControlItem2
            // 
            _LayoutControlItem2.Control = _LabelX1;
            _LayoutControlItem2.Height = 31;
            _LayoutControlItem2.MinSize = new Size(64, 18);
            _LayoutControlItem2.Name = "LayoutControlItem2";
            resources.ApplyResources(_LayoutControlItem2, "LayoutControlItem2");
            _LayoutControlItem2.TextVisible = false;
            _LayoutControlItem2.Width = 99;
            _LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            _LayoutControlItem3.Control = _LabelX_NewVersion;
            _LayoutControlItem3.Height = 31;
            _LayoutControlItem3.MinSize = new Size(64, 18);
            _LayoutControlItem3.Name = "LayoutControlItem3";
            resources.ApplyResources(_LayoutControlItem3, "LayoutControlItem3");
            _LayoutControlItem3.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem3.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            _LayoutControlItem3.Width = 50;
            _LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            _LayoutControlItem4.Control = _LabelX_NewChannel;
            _LayoutControlItem4.Height = 31;
            _LayoutControlItem4.MinSize = new Size(64, 18);
            _LayoutControlItem4.Name = "LayoutControlItem4";
            _LayoutControlItem4.SharedTextSizeEnabled = false;
            resources.ApplyResources(_LayoutControlItem4, "LayoutControlItem4");
            _LayoutControlItem4.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem4.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            _LayoutControlItem4.Width = 30;
            _LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            _LayoutControlItem5.Control = _LabelX_NewBuild;
            _LayoutControlItem5.Height = 31;
            _LayoutControlItem5.MinSize = new Size(64, 18);
            _LayoutControlItem5.Name = "LayoutControlItem5";
            _LayoutControlItem5.SharedTextSizeEnabled = false;
            resources.ApplyResources(_LayoutControlItem5, "LayoutControlItem5");
            _LayoutControlItem5.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem5.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            _LayoutControlItem5.Width = 20;
            _LayoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem6
            // 
            _LayoutControlItem6.Control = _LabelX_CurrentVersion;
            _LayoutControlItem6.Height = 31;
            _LayoutControlItem6.MinSize = new Size(64, 18);
            _LayoutControlItem6.Name = "LayoutControlItem6";
            resources.ApplyResources(_LayoutControlItem6, "LayoutControlItem6");
            _LayoutControlItem6.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem6.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            _LayoutControlItem6.Width = 50;
            _LayoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem7
            // 
            _LayoutControlItem7.Control = _LabelX_CurrentChannel;
            _LayoutControlItem7.Height = 31;
            _LayoutControlItem7.MinSize = new Size(64, 18);
            _LayoutControlItem7.Name = "LayoutControlItem7";
            _LayoutControlItem7.SharedTextSizeEnabled = false;
            resources.ApplyResources(_LayoutControlItem7, "LayoutControlItem7");
            _LayoutControlItem7.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem7.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            _LayoutControlItem7.Width = 30;
            _LayoutControlItem7.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem8
            // 
            _LayoutControlItem8.Control = _LabelX_CurrentBuild;
            _LayoutControlItem8.Height = 31;
            _LayoutControlItem8.MinSize = new Size(64, 18);
            _LayoutControlItem8.Name = "LayoutControlItem8";
            _LayoutControlItem8.SharedTextSizeEnabled = false;
            resources.ApplyResources(_LayoutControlItem8, "LayoutControlItem8");
            _LayoutControlItem8.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem8.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            _LayoutControlItem8.Width = 20;
            _LayoutControlItem8.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem9
            // 
            _LayoutControlItem9.Control = _RichTextBoxEx_Changelog;
            _LayoutControlItem9.Height = 99;
            _LayoutControlItem9.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            _LayoutControlItem9.MinSize = new Size(64, 18);
            _LayoutControlItem9.Name = "LayoutControlItem9";
            resources.ApplyResources(_LayoutControlItem9, "LayoutControlItem9");
            _LayoutControlItem9.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem9.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            _LayoutControlItem9.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            _LayoutControlItem9.Width = 100;
            _LayoutControlItem9.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            _LayoutSpacerItem1.Height = 31;
            _LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            _LayoutSpacerItem1.Width = 99;
            _LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem10
            // 
            _LayoutControlItem10.Control = _ButtonX_Install;
            _LayoutControlItem10.Height = 31;
            _LayoutControlItem10.MinSize = new Size(32, 20);
            _LayoutControlItem10.Name = "LayoutControlItem10";
            _LayoutControlItem10.Width = 100;
            // 
            // LayoutControlItem11
            // 
            _LayoutControlItem11.Control = _ButtonX_Cancel;
            _LayoutControlItem11.Height = 31;
            _LayoutControlItem11.MinSize = new Size(32, 20);
            _LayoutControlItem11.Name = "LayoutControlItem11";
            _LayoutControlItem11.Width = 100;
            // 
            // UpdatesAvailableDialog
            // 
            AcceptButton = _ButtonX_Install;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _ButtonX_Cancel;
            Controls.Add(_LayoutControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdatesAvailableDialog";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_PictureBox_AppIcon).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Layout.LayoutControl _LayoutControl1;

        internal DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControl1 = value;
            }
        }

        private PictureBox _PictureBox_AppIcon;

        internal PictureBox PictureBox_AppIcon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox_AppIcon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _PictureBox_AppIcon = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem1;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem1 = value;
            }
        }

        private LabelX _LabelX1;

        internal LabelX LabelX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX1 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem2;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem2 = value;
            }
        }

        private LabelX _LabelX_NewVersion;

        internal LabelX LabelX_NewVersion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_NewVersion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_NewVersion = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem3;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem3 = value;
            }
        }

        private DevComponents.DotNetBar.Controls.RichTextBoxEx _RichTextBoxEx_Changelog;

        internal DevComponents.DotNetBar.Controls.RichTextBoxEx RichTextBoxEx_Changelog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RichTextBoxEx_Changelog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _RichTextBoxEx_Changelog = value;
            }
        }

        private LabelX _LabelX_NewChannel;

        internal LabelX LabelX_NewChannel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_NewChannel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_NewChannel = value;
            }
        }

        private LabelX _LabelX_NewBuild;

        internal LabelX LabelX_NewBuild
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_NewBuild;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_NewBuild = value;
            }
        }

        private LabelX _LabelX_CurrentVersion;

        internal LabelX LabelX_CurrentVersion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_CurrentVersion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_CurrentVersion = value;
            }
        }

        private LabelX _LabelX_CurrentChannel;

        internal LabelX LabelX_CurrentChannel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_CurrentChannel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_CurrentChannel = value;
            }
        }

        private LabelX _LabelX_CurrentBuild;

        internal LabelX LabelX_CurrentBuild
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_CurrentBuild;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_CurrentBuild = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem4;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem4 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem5;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem5 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem6;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem6 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem7;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem7 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem8;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem8 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem9;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem9 = value;
            }
        }

        private ButtonX _ButtonX_Install;

        internal ButtonX ButtonX_Install
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Install;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ButtonX_Install = value;
            }
        }

        private ButtonX _ButtonX_Cancel;

        internal ButtonX ButtonX_Cancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Cancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ButtonX_Cancel = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutSpacerItem _LayoutSpacerItem1;

        internal DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutSpacerItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutSpacerItem1 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem10;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem10 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem11;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem11 = value;
            }
        }
    }
}