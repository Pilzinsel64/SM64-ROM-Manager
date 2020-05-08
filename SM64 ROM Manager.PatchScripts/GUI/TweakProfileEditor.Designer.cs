using System.Diagnostics;
using System.Runtime.CompilerServices;
using global::System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.PatchScripts
{
    [DesignerGenerated()]
    public partial class TweakProfileEditor : DevComponents.DotNetBar.OfficeForm
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
        private System.ComponentModel.IContainer components = null;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweakProfileEditor));
            this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this.LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator2 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxX1
            // 
            this.TextBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX1.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX1.Location = new System.Drawing.Point(4, 21);
            this.TextBoxX1.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.PreventEnterBeep = true;
            this.TextBoxX1.Size = new System.Drawing.Size(367, 20);
            this.TextBoxX1.TabIndex = 0;
            this.superValidator1.SetValidator1(this.TextBoxX1, this.requiredFieldValidator1);
            // 
            // TextBoxX2
            // 
            this.TextBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX2.Border.Class = "TextBoxBorder";
            this.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX2.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX2.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX2.Location = new System.Drawing.Point(4, 66);
            this.TextBoxX2.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxX2.Multiline = true;
            this.TextBoxX2.Name = "TextBoxX2";
            this.TextBoxX2.PreventEnterBeep = true;
            this.TextBoxX2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxX2.Size = new System.Drawing.Size(367, 155);
            this.TextBoxX2.TabIndex = 1;
            // 
            // ButtonX2
            // 
            this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX2.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_checkmark_16px;
            this.ButtonX2.Location = new System.Drawing.Point(213, 313);
            this.ButtonX2.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX2.Name = "ButtonX2";
            this.ButtonX2.Size = new System.Drawing.Size(75, 24);
            this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX2.SymbolSize = 12F;
            this.ButtonX2.TabIndex = 6;
            this.ButtonX2.Text = "Okay";
            this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // ButtonX1
            // 
            this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonX1.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_delete_sign_16px_1;
            this.ButtonX1.Location = new System.Drawing.Point(296, 313);
            this.ButtonX1.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX1.Name = "ButtonX1";
            this.ButtonX1.Size = new System.Drawing.Size(75, 24);
            this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX1.SymbolSize = 12F;
            this.ButtonX1.TabIndex = 7;
            this.ButtonX1.Text = "Cancel";
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.LayoutControl1.Controls.Add(this.TextBoxX1);
            this.LayoutControl1.Controls.Add(this.TextBoxX2);
            this.LayoutControl1.Controls.Add(this.ButtonX2);
            this.LayoutControl1.Controls.Add(this.ButtonX1);
            this.LayoutControl1.Controls.Add(this.textBoxX3);
            this.LayoutControl1.Controls.Add(this.textBoxX4);
            this.LayoutControl1.Controls.Add(this.textBoxX5);
            this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            this.LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem1,
            this.LayoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.LayoutSpacerItem1,
            this.LayoutControlItem3,
            this.LayoutControlItem4});
            this.LayoutControl1.Size = new System.Drawing.Size(375, 341);
            this.LayoutControl1.TabIndex = 5;
            // 
            // textBoxX3
            // 
            this.textBoxX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX3.ForeColor = System.Drawing.Color.Black;
            this.textBoxX3.Location = new System.Drawing.Point(198, 229);
            this.textBoxX3.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.PreventEnterBeep = true;
            this.textBoxX3.Size = new System.Drawing.Size(173, 20);
            this.textBoxX3.TabIndex = 2;
            this.superValidator1.SetValidator1(this.textBoxX3, this.customValidator1);
            // 
            // textBoxX4
            // 
            this.textBoxX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX4.ForeColor = System.Drawing.Color.Black;
            this.textBoxX4.Location = new System.Drawing.Point(198, 257);
            this.textBoxX4.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.PreventEnterBeep = true;
            this.textBoxX4.Size = new System.Drawing.Size(173, 20);
            this.textBoxX4.TabIndex = 3;
            this.superValidator1.SetValidator1(this.textBoxX4, this.customValidator1);
            this.textBoxX4.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            // 
            // textBoxX5
            // 
            this.textBoxX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX5.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX5.ForeColor = System.Drawing.Color.Black;
            this.textBoxX5.Location = new System.Drawing.Point(198, 285);
            this.textBoxX5.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.PreventEnterBeep = true;
            this.textBoxX5.Size = new System.Drawing.Size(173, 20);
            this.textBoxX5.TabIndex = 4;
            this.superValidator1.SetValidator1(this.textBoxX5, this.customValidator2);
            this.textBoxX5.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.textBoxX5.WatermarkText = "Leave empty, if no limit.";
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.TextBoxX1;
            this.LayoutControlItem1.Height = 45;
            this.LayoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            this.LayoutControlItem1.Text = "Name:";
            this.LayoutControlItem1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutControlItem1.Width = 100;
            this.LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.TextBoxX2;
            this.LayoutControlItem2.Height = 100;
            this.LayoutControlItem2.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.LayoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            this.LayoutControlItem2.Text = "Description:";
            this.LayoutControlItem2.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutControlItem2.Width = 100;
            this.LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textBoxX3;
            this.layoutControlItem5.Height = 28;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Text = "Version:";
            this.layoutControlItem5.Width = 100;
            this.layoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textBoxX4;
            this.layoutControlItem6.Height = 28;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Text = "Minimal Application Version requied:";
            this.layoutControlItem6.Width = 100;
            this.layoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textBoxX5;
            this.layoutControlItem7.Height = 28;
            this.layoutControlItem7.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Text = "Maximal Application Version requied:";
            this.layoutControlItem7.Width = 100;
            this.layoutControlItem7.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            this.LayoutSpacerItem1.Height = 32;
            this.LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            this.LayoutSpacerItem1.Width = 99;
            this.LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.ButtonX2;
            this.LayoutControlItem3.Height = 31;
            this.LayoutControlItem3.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            this.LayoutControlItem3.Width = 83;
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.ButtonX1;
            this.LayoutControlItem4.Height = 31;
            this.LayoutControlItem4.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            this.LayoutControlItem4.Width = 83;
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "Your error message here.";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator2
            // 
            this.customValidator2.ErrorMessage = "Your error message here.";
            this.customValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // TweakProfileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 341);
            this.ControlBox = false;
            this.Controls.Add(this.LayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TweakProfileEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tweak Editor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.ButtonX ButtonX2;


        private DevComponents.DotNetBar.ButtonX ButtonX1;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX2;


        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;


        private DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;


        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator2;
    }
}