using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddressListEditor : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressListEditor));
            ItemPanel_Values = new DevComponents.DotNetBar.ItemPanel();
            ItemPanel_Values.SelectedIndexChanged += new EventHandler(ItemPanel_Values_SelectedIndexChanged);
            LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            TextBoxX_Value = new DevComponents.DotNetBar.Controls.TextBoxX();
            TextBoxX_Value.TextChanged += new EventHandler(TextBoxX_Value_TextChanged);
            ButtonX_Hinzufügen = new DevComponents.DotNetBar.ButtonX();
            ButtonX_Hinzufügen.Click += new EventHandler(ButtonX_Hinzufügen_Click);
            ButtonX_Entfernen = new DevComponents.DotNetBar.ButtonX();
            ButtonX_Entfernen.Click += new EventHandler(ButtonX_Entfernen_Click);
            LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControl1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemPanel_Values
            // 
            resources.ApplyResources(ItemPanel_Values, "ItemPanel_Values");
            ItemPanel_Values.BackColor = Color.Transparent;
            // 
            // 
            // 
            ItemPanel_Values.BackgroundStyle.Class = "ItemPanel";
            ItemPanel_Values.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ItemPanel_Values.ContainerControlProcessDialogKey = true;
            ItemPanel_Values.DragDropSupport = true;
            ItemPanel_Values.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            ItemPanel_Values.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            ItemPanel_Values.Name = "ItemPanel_Values";
            ItemPanel_Values.ReserveLeftSpace = false;
            ItemPanel_Values.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LayoutControl1
            // 
            LayoutControl1.BackColor = Color.Transparent;
            LayoutControl1.Controls.Add(TextBoxX_Value);
            LayoutControl1.Controls.Add(ButtonX_Hinzufügen);
            LayoutControl1.Controls.Add(ButtonX_Entfernen);
            resources.ApplyResources(LayoutControl1, "LayoutControl1");
            LayoutControl1.ForeColor = Color.Black;
            LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { LayoutControlItem1, LayoutControlItem2, LayoutControlItem3 });
            // 
            // TextBoxX_Value
            // 
            TextBoxX_Value.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_Value.Border.Class = "TextBoxBorder";
            TextBoxX_Value.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_Value.DisabledBackColor = Color.White;
            TextBoxX_Value.ForeColor = Color.Black;
            resources.ApplyResources(TextBoxX_Value, "TextBoxX_Value");
            TextBoxX_Value.Name = "TextBoxX_Value";
            TextBoxX_Value.PreventEnterBeep = true;
            // 
            // ButtonX_Hinzufügen
            // 
            ButtonX_Hinzufügen.AccessibleRole = AccessibleRole.PushButton;
            ButtonX_Hinzufügen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX_Hinzufügen.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(ButtonX_Hinzufügen, "ButtonX_Hinzufügen");
            ButtonX_Hinzufügen.Name = "ButtonX_Hinzufügen";
            ButtonX_Hinzufügen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Entfernen
            // 
            ButtonX_Entfernen.AccessibleRole = AccessibleRole.PushButton;
            ButtonX_Entfernen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX_Entfernen.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            resources.ApplyResources(ButtonX_Entfernen, "ButtonX_Entfernen");
            ButtonX_Entfernen.Name = "ButtonX_Entfernen";
            ButtonX_Entfernen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LayoutControlItem1
            // 
            LayoutControlItem1.Control = TextBoxX_Value;
            LayoutControlItem1.Height = 28;
            LayoutControlItem1.MinSize = new Size(120, 0);
            LayoutControlItem1.Name = "LayoutControlItem1";
            LayoutControlItem1.Width = 100;
            LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            LayoutControlItem2.Control = ButtonX_Hinzufügen;
            LayoutControlItem2.Height = 31;
            LayoutControlItem2.MinSize = new Size(32, 20);
            LayoutControlItem2.Name = "LayoutControlItem2";
            LayoutControlItem2.Width = 50;
            LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            LayoutControlItem3.Control = ButtonX_Entfernen;
            LayoutControlItem3.Height = 31;
            LayoutControlItem3.MinSize = new Size(32, 20);
            LayoutControlItem3.Name = "LayoutControlItem3";
            LayoutControlItem3.Width = 50;
            LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // AddressListEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemPanel_Values);
            Controls.Add(LayoutControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddressListEditor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            LayoutControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.ItemPanel ItemPanel_Values;

        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Value;

        private DevComponents.DotNetBar.ButtonX ButtonX_Hinzufügen;

        private DevComponents.DotNetBar.ButtonX ButtonX_Entfernen;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;

    }
}