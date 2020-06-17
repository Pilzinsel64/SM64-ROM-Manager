using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    [DesignerGenerated()]
    public partial class PackageDescriptionEditor : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageDescriptionEditor));
            this.LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Okay = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.comboBoxEx_Format = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LayoutControl1.Controls.Add(this.ButtonX_Cancel);
            this.LayoutControl1.Controls.Add(this.ButtonX_Okay);
            this.LayoutControl1.Controls.Add(this.textBoxX1);
            this.LayoutControl1.Controls.Add(this.textBoxX2);
            this.LayoutControl1.Controls.Add(this.comboBoxEx_Format);
            this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl1.ForeColor = System.Drawing.Color.Black;
            this.LayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            this.LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.LayoutSpacerItem1,
            this.LayoutControlItem5,
            this.LayoutControlItem6});
            this.LayoutControl1.Size = new System.Drawing.Size(384, 311);
            this.LayoutControl1.TabIndex = 5;
            // 
            // ButtonX_Cancel
            // 
            this.ButtonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonX_Cancel.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_delete_sign_16px;
            this.ButtonX_Cancel.Location = new System.Drawing.Point(222, 284);
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
            this.ButtonX_Okay.Location = new System.Drawing.Point(305, 284);
            this.ButtonX_Okay.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_Okay.Name = "ButtonX_Okay";
            this.ButtonX_Okay.Size = new System.Drawing.Size(75, 23);
            this.ButtonX_Okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Okay.TabIndex = 5;
            this.ButtonX_Okay.Text = "Okay";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(84, 4);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(296, 20);
            this.textBoxX1.TabIndex = 0;
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.BackgroundStyle.Class = "TextBoxBorder";
            this.textBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.textBoxX2.Location = new System.Drawing.Point(84, 32);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1031{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.textBoxX2.Size = new System.Drawing.Size(296, 216);
            this.textBoxX2.TabIndex = 1;
            // 
            // comboBoxEx_Format
            // 
            this.comboBoxEx_Format.DisplayMember = "Text";
            this.comboBoxEx_Format.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx_Format.FormattingEnabled = true;
            this.comboBoxEx_Format.ItemHeight = 15;
            this.comboBoxEx_Format.Location = new System.Drawing.Point(84, 256);
            this.comboBoxEx_Format.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxEx_Format.Name = "comboBoxEx_Format";
            this.comboBoxEx_Format.Size = new System.Drawing.Size(296, 21);
            this.comboBoxEx_Format.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx_Format.TabIndex = 2;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textBoxX1;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Titel:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxX2;
            this.layoutControlItem2.Height = 100;
            this.layoutControlItem2.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "Beschreibung:";
            this.layoutControlItem2.Width = 100;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboBoxEx_Format;
            this.layoutControlItem3.Height = 28;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "Formatierung:";
            this.layoutControlItem3.Width = 100;
            this.layoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            this.LayoutSpacerItem1.Height = 31;
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
            // PackageDescriptionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonX_Cancel;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.LayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackageDescriptionEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Beschreibung";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.LayoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }





        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;






        private DevComponents.DotNetBar.ButtonX ButtonX_Cancel;


        private DevComponents.DotNetBar.ButtonX ButtonX_Okay;

        private DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx textBoxX2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx_Format;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
    }
}