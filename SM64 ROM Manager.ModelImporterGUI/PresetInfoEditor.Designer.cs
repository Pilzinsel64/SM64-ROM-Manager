using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using global::System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelImporterGUI
{
    [DesignerGenerated()]
    public partial class InfoEditor : DevComponents.DotNetBar.OfficeForm
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
        private System.ComponentModel.IContainer components = new System.ComponentModel.Container();

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEditor));
            this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControl1.SuspendLayout();
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
            this.TextBoxX1.Location = new System.Drawing.Point(84, 4);
            this.TextBoxX1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.PreventEnterBeep = true;
            this.TextBoxX1.Size = new System.Drawing.Size(315, 20);
            this.TextBoxX1.TabIndex = 0;
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
            this.TextBoxX2.Location = new System.Drawing.Point(84, 32);
            this.TextBoxX2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.TextBoxX2.Multiline = true;
            this.TextBoxX2.Name = "TextBoxX2";
            this.TextBoxX2.PreventEnterBeep = true;
            this.TextBoxX2.Size = new System.Drawing.Size(315, 229);
            this.TextBoxX2.TabIndex = 1;
            // 
            // ButtonX2
            // 
            this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonX2.Image = global::SM64_ROM_Manager.ModelImporterGUI.My.Resources.Resources.icons8_checkmark_16px_1;
            this.ButtonX2.Location = new System.Drawing.Point(241, 269);
            this.ButtonX2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ButtonX2.Name = "ButtonX2";
            this.ButtonX2.Size = new System.Drawing.Size(75, 23);
            this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX2.TabIndex = 3;
            this.ButtonX2.Text = "Okay";
            // 
            // ButtonX1
            // 
            this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonX1.Image = global::SM64_ROM_Manager.ModelImporterGUI.My.Resources.Resources.icons8_delete_sign_16px;
            this.ButtonX1.Location = new System.Drawing.Point(324, 269);
            this.ButtonX1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ButtonX1.Name = "ButtonX1";
            this.ButtonX1.Size = new System.Drawing.Size(75, 23);
            this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX1.TabIndex = 4;
            this.ButtonX1.Text = "Cancel";
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.TextBoxX1);
            this.layoutControl1.Controls.Add(this.TextBoxX2);
            this.layoutControl1.Controls.Add(this.ButtonX2);
            this.layoutControl1.Controls.Add(this.ButtonX1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutSpacerItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControl1.Size = new System.Drawing.Size(403, 296);
            this.layoutControl1.TabIndex = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TextBoxX1;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Name:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TextBoxX2;
            this.layoutControlItem2.Height = 100;
            this.layoutControlItem2.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "Beschreibung:";
            this.layoutControlItem2.Width = 100;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 31;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 99;
            this.layoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ButtonX2;
            this.layoutControlItem3.Height = 31;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Width = 83;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ButtonX1;
            this.layoutControlItem4.Height = 31;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Width = 83;
            // 
            // InfoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 296);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tweak Editor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.layoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.ButtonX ButtonX2;

        private DevComponents.DotNetBar.ButtonX ButtonX1;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX2;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
    }
}