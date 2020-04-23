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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationVersionInput));
            this.TextBoxX_Version = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ComboBoxEx_Channel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.IntegerInput_Build = new DevComponents.Editors.IntegerInput();
            this.LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Okay = new DevComponents.DotNetBar.ButtonX();
            this.LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_Build)).BeginInit();
            this.LayoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxX_Version
            // 
            this.TextBoxX_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX_Version.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_Version.Border.Class = "TextBoxBorder";
            this.TextBoxX_Version.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_Version.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_Version.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_Version.Location = new System.Drawing.Point(53, 4);
            this.TextBoxX_Version.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxX_Version.Name = "TextBoxX_Version";
            this.TextBoxX_Version.PreventEnterBeep = true;
            this.TextBoxX_Version.Size = new System.Drawing.Size(275, 20);
            this.TextBoxX_Version.TabIndex = 0;
            this.TextBoxX_Version.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TextBoxX_Version.WatermarkText = "Bspw.: 1.2.5.0";
            // 
            // ComboBoxEx_Channel
            // 
            this.ComboBoxEx_Channel.DisplayMember = "Text";
            this.ComboBoxEx_Channel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx_Channel.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_Channel.FormattingEnabled = true;
            this.ComboBoxEx_Channel.ItemHeight = 15;
            this.ComboBoxEx_Channel.Location = new System.Drawing.Point(53, 32);
            this.ComboBoxEx_Channel.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxEx_Channel.Name = "ComboBoxEx_Channel";
            this.ComboBoxEx_Channel.Size = new System.Drawing.Size(275, 21);
            this.ComboBoxEx_Channel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_Channel.TabIndex = 1;
            // 
            // IntegerInput_Build
            // 
            this.IntegerInput_Build.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.IntegerInput_Build.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_Build.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_Build.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput_Build.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.IntegerInput_Build.Location = new System.Drawing.Point(53, 61);
            this.IntegerInput_Build.Margin = new System.Windows.Forms.Padding(0);
            this.IntegerInput_Build.MinValue = 0;
            this.IntegerInput_Build.Name = "IntegerInput_Build";
            this.IntegerInput_Build.ShowUpDown = true;
            this.IntegerInput_Build.Size = new System.Drawing.Size(275, 20);
            this.IntegerInput_Build.TabIndex = 2;
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LayoutControl1.Controls.Add(this.TextBoxX_Version);
            this.LayoutControl1.Controls.Add(this.ComboBoxEx_Channel);
            this.LayoutControl1.Controls.Add(this.IntegerInput_Build);
            this.LayoutControl1.Controls.Add(this.ButtonX_Cancel);
            this.LayoutControl1.Controls.Add(this.ButtonX_Okay);
            this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl1.ForeColor = System.Drawing.Color.Black;
            this.LayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            this.LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem2,
            this.LayoutControlItem3,
            this.LayoutControlItem4,
            this.LayoutSpacerItem1,
            this.LayoutControlItem5,
            this.LayoutControlItem6});
            this.LayoutControl1.Size = new System.Drawing.Size(332, 116);
            this.LayoutControl1.TabIndex = 5;
            // 
            // ButtonX_Cancel
            // 
            this.ButtonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonX_Cancel.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_delete_sign_16px;
            this.ButtonX_Cancel.Location = new System.Drawing.Point(170, 89);
            this.ButtonX_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_Cancel.Name = "ButtonX_Cancel";
            this.ButtonX_Cancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Cancel.TabIndex = 4;
            this.ButtonX_Cancel.Text = "Abbrechen";
            // 
            // ButtonX_Okay
            // 
            this.ButtonX_Okay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Okay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Okay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonX_Okay.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_checkmark_16px;
            this.ButtonX_Okay.Location = new System.Drawing.Point(253, 89);
            this.ButtonX_Okay.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_Okay.Name = "ButtonX_Okay";
            this.ButtonX_Okay.Size = new System.Drawing.Size(75, 23);
            this.ButtonX_Okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Okay.TabIndex = 5;
            this.ButtonX_Okay.Text = "Okay";
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.TextBoxX_Version;
            this.LayoutControlItem2.Height = 28;
            this.LayoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            this.LayoutControlItem2.Text = "Version:";
            this.LayoutControlItem2.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem2.Width = 100;
            this.LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.ComboBoxEx_Channel;
            this.LayoutControlItem3.Height = 29;
            this.LayoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            this.LayoutControlItem3.Text = "Kanal:";
            this.LayoutControlItem3.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem3.Width = 100;
            this.LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.IntegerInput_Build;
            this.LayoutControlItem4.Height = 28;
            this.LayoutControlItem4.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            this.LayoutControlItem4.Text = "Build:";
            this.LayoutControlItem4.TextLineAlignment = DevComponents.DotNetBar.Layout.eTextLineAlignment.Middle;
            this.LayoutControlItem4.Width = 100;
            this.LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            this.LayoutSpacerItem1.Height = 31;
            this.LayoutSpacerItem1.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            this.LayoutSpacerItem1.Width = 99;
            this.LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            this.LayoutControlItem5.Control = this.ButtonX_Cancel;
            this.LayoutControlItem5.Height = 31;
            this.LayoutControlItem5.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem5.Name = "LayoutControlItem5";
            this.LayoutControlItem5.Width = 83;
            // 
            // LayoutControlItem6
            // 
            this.LayoutControlItem6.Control = this.ButtonX_Okay;
            this.LayoutControlItem6.Height = 31;
            this.LayoutControlItem6.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem6.Name = "LayoutControlItem6";
            this.LayoutControlItem6.Width = 83;
            // 
            // ApplicationVersionInput
            // 
            this.AcceptButton = this.ButtonX_Okay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonX_Cancel;
            this.ClientSize = new System.Drawing.Size(332, 116);
            this.Controls.Add(this.LayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationVersionInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Version";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_Build)).EndInit();
            this.LayoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Version;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Channel;


        private DevComponents.Editors.IntegerInput IntegerInput_Build;


        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;



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