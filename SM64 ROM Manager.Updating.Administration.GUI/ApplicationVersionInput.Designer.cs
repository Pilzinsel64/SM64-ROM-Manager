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
            _TextBoxX_VersionName = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_Version = new DevComponents.DotNetBar.Controls.TextBoxX();
            _ComboBoxEx_Channel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _IntegerInput_Build = new DevComponents.Editors.IntegerInput();
            _LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Okay = new DevComponents.DotNetBar.ButtonX();
            _LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            _LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Build).BeginInit();
            _LayoutControl1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxX_VersionName
            // 
            _TextBoxX_VersionName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _TextBoxX_VersionName.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_VersionName.Border.Class = "TextBoxBorder";
            _TextBoxX_VersionName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_VersionName.DisabledBackColor = Color.White;
            _TextBoxX_VersionName.ForeColor = Color.Black;
            _TextBoxX_VersionName.Location = new Point(53, 4);
            _TextBoxX_VersionName.Margin = new Padding(0);
            _TextBoxX_VersionName.Name = "TextBoxX_VersionName";
            _TextBoxX_VersionName.PreventEnterBeep = true;
            _TextBoxX_VersionName.Size = new Size(275, 20);
            _TextBoxX_VersionName.TabIndex = 0;
            _TextBoxX_VersionName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            _TextBoxX_VersionName.WatermarkText = "Bspw.: Version 1.2.5.0 - Dark Mode und vieles mehr!";
            // 
            // TextBoxX_Version
            // 
            _TextBoxX_Version.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _TextBoxX_Version.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Version.Border.Class = "TextBoxBorder";
            _TextBoxX_Version.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Version.DisabledBackColor = Color.White;
            _TextBoxX_Version.ForeColor = Color.Black;
            _TextBoxX_Version.Location = new Point(53, 32);
            _TextBoxX_Version.Margin = new Padding(0);
            _TextBoxX_Version.Name = "TextBoxX_Version";
            _TextBoxX_Version.PreventEnterBeep = true;
            _TextBoxX_Version.Size = new Size(275, 20);
            _TextBoxX_Version.TabIndex = 1;
            _TextBoxX_Version.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            _TextBoxX_Version.WatermarkText = "Bspw.: 1.2.5.0";
            // 
            // ComboBoxEx_Channel
            // 
            _ComboBoxEx_Channel.DisplayMember = "Text";
            _ComboBoxEx_Channel.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_Channel.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_Channel.ForeColor = Color.Black;
            _ComboBoxEx_Channel.FormattingEnabled = true;
            _ComboBoxEx_Channel.ItemHeight = 15;
            _ComboBoxEx_Channel.Location = new Point(53, 60);
            _ComboBoxEx_Channel.Margin = new Padding(0);
            _ComboBoxEx_Channel.Name = "ComboBoxEx_Channel";
            _ComboBoxEx_Channel.Size = new Size(275, 21);
            _ComboBoxEx_Channel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ComboBoxEx_Channel.TabIndex = 2;
            // 
            // IntegerInput_Build
            // 
            _IntegerInput_Build.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _IntegerInput_Build.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_Build.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_Build.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_Build.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            _IntegerInput_Build.Location = new Point(53, 89);
            _IntegerInput_Build.Margin = new Padding(0);
            _IntegerInput_Build.MinValue = 0;
            _IntegerInput_Build.Name = "IntegerInput_Build";
            _IntegerInput_Build.ShowUpDown = true;
            _IntegerInput_Build.Size = new Size(275, 20);
            _IntegerInput_Build.TabIndex = 3;
            // 
            // LayoutControl1
            // 
            _LayoutControl1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _LayoutControl1.Controls.Add(_TextBoxX_VersionName);
            _LayoutControl1.Controls.Add(_TextBoxX_Version);
            _LayoutControl1.Controls.Add(_ComboBoxEx_Channel);
            _LayoutControl1.Controls.Add(_IntegerInput_Build);
            _LayoutControl1.Controls.Add(_ButtonX_Cancel);
            _LayoutControl1.Controls.Add(_ButtonX_Okay);
            _LayoutControl1.Dock = DockStyle.Fill;
            _LayoutControl1.ForeColor = Color.Black;
            _LayoutControl1.Location = new Point(0, 0);
            _LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            _LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem1, _LayoutControlItem2, _LayoutControlItem3, _LayoutControlItem4, _LayoutSpacerItem1, _LayoutControlItem5, _LayoutControlItem6 });
            _LayoutControl1.Size = new Size(332, 144);
            _LayoutControl1.TabIndex = 5;
            // 
            // ButtonX_Cancel
            // 
            _ButtonX_Cancel.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Cancel.DialogResult = DialogResult.Cancel;
            _ButtonX_Cancel.Location = new Point(170, 117);
            _ButtonX_Cancel.Margin = new Padding(0);
            _ButtonX_Cancel.Name = "ButtonX_Cancel";
            _ButtonX_Cancel.Size = new Size(75, 23);
            _ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Cancel.TabIndex = 5;
            _ButtonX_Cancel.Text = "Abbrechen";
            // 
            // ButtonX_Okay
            // 
            _ButtonX_Okay.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Okay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Okay.DialogResult = DialogResult.OK;
            _ButtonX_Okay.Location = new Point(253, 117);
            _ButtonX_Okay.Margin = new Padding(0);
            _ButtonX_Okay.Name = "ButtonX_Okay";
            _ButtonX_Okay.Size = new Size(75, 23);
            _ButtonX_Okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Okay.TabIndex = 6;
            _ButtonX_Okay.Text = "Okay";
            // 
            // LayoutControlItem1
            // 
            _LayoutControlItem1.Control = _TextBoxX_VersionName;
            _LayoutControlItem1.Height = 28;
            _LayoutControlItem1.MinSize = new Size(120, 0);
            _LayoutControlItem1.Name = "LayoutControlItem1";
            _LayoutControlItem1.Text = "Name:";
            _LayoutControlItem1.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem1.Width = 100;
            _LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            _LayoutControlItem2.Control = _TextBoxX_Version;
            _LayoutControlItem2.Height = 28;
            _LayoutControlItem2.MinSize = new Size(120, 0);
            _LayoutControlItem2.Name = "LayoutControlItem2";
            _LayoutControlItem2.Text = "Version:";
            _LayoutControlItem2.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem2.Width = 100;
            _LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            _LayoutControlItem3.Control = _ComboBoxEx_Channel;
            _LayoutControlItem3.Height = 29;
            _LayoutControlItem3.MinSize = new Size(64, 18);
            _LayoutControlItem3.Name = "LayoutControlItem3";
            _LayoutControlItem3.Text = "Kanal:";
            _LayoutControlItem3.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem3.Width = 100;
            _LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            _LayoutControlItem4.Control = _IntegerInput_Build;
            _LayoutControlItem4.Height = 28;
            _LayoutControlItem4.MinSize = new Size(120, 0);
            _LayoutControlItem4.Name = "LayoutControlItem4";
            _LayoutControlItem4.Text = "Build:";
            _LayoutControlItem4.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            _LayoutControlItem4.Width = 100;
            _LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            _LayoutSpacerItem1.Height = 31;
            _LayoutSpacerItem1.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            _LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            _LayoutSpacerItem1.Width = 99;
            _LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            _LayoutControlItem5.Control = _ButtonX_Cancel;
            _LayoutControlItem5.Height = 31;
            _LayoutControlItem5.MinSize = new Size(32, 20);
            _LayoutControlItem5.Name = "LayoutControlItem5";
            _LayoutControlItem5.Width = 83;
            // 
            // LayoutControlItem6
            // 
            _LayoutControlItem6.Control = _ButtonX_Okay;
            _LayoutControlItem6.Height = 31;
            _LayoutControlItem6.MinSize = new Size(32, 20);
            _LayoutControlItem6.Name = "LayoutControlItem6";
            _LayoutControlItem6.Width = 83;
            // 
            // ApplicationVersionInput
            // 
            AcceptButton = _ButtonX_Okay;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _ButtonX_Cancel;
            ClientSize = new Size(332, 144);
            Controls.Add(_LayoutControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ApplicationVersionInput";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Version";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Build).EndInit();
            _LayoutControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_VersionName;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_VersionName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_VersionName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TextBoxX_VersionName = value;
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Version;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Version
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Version;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TextBoxX_Version = value;
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_Channel;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Channel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_Channel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ComboBoxEx_Channel = value;
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_Build;

        internal DevComponents.Editors.IntegerInput IntegerInput_Build
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_Build;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _IntegerInput_Build = value;
            }
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

        private DevComponents.DotNetBar.ButtonX _ButtonX_Cancel;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Cancel
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

        private DevComponents.DotNetBar.ButtonX _ButtonX_Okay;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Okay
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Okay;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ButtonX_Okay = value;
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
    }
}