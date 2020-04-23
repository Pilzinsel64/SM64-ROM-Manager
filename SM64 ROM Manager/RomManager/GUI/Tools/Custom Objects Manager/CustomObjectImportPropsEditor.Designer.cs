namespace SM64_ROM_Manager
{
    partial class CustomObjectImportPropsEditor
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomObjectImportPropsEditor));
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_ModelID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonX_ChangeDestModelBank = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            resources.ApplyResources(this.labelX2, "labelX2");
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Name = "labelX2";
            this.labelX2.Tag = "mdl";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // TextBoxX_ModelID
            // 
            resources.ApplyResources(this.TextBoxX_ModelID, "TextBoxX_ModelID");
            // 
            // 
            // 
            this.TextBoxX_ModelID.Border.Class = "TextBoxBorder";
            this.TextBoxX_ModelID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ModelID.Name = "TextBoxX_ModelID";
            this.TextBoxX_ModelID.PreventEnterBeep = true;
            this.TextBoxX_ModelID.Tag = "mdl";
            this.TextBoxX_ModelID.TextChanged += new System.EventHandler(this.TextBoxX_ModelID_TextChanged);
            // 
            // ButtonX_ChangeDestModelBank
            // 
            this.ButtonX_ChangeDestModelBank.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX_ChangeDestModelBank, "ButtonX_ChangeDestModelBank");
            this.ButtonX_ChangeDestModelBank.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_ChangeDestModelBank.Name = "ButtonX_ChangeDestModelBank";
            this.ButtonX_ChangeDestModelBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_ChangeDestModelBank.Tag = "mdl";
            this.ButtonX_ChangeDestModelBank.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            // 
            // labelX3
            // 
            resources.ApplyResources(this.labelX3, "labelX3");
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Name = "labelX3";
            this.labelX3.Tag = "mdl";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // TextBoxX_Name
            // 
            resources.ApplyResources(this.TextBoxX_Name, "TextBoxX_Name");
            // 
            // 
            // 
            this.TextBoxX_Name.Border.Class = "TextBoxBorder";
            this.TextBoxX_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_Name.Name = "TextBoxX_Name";
            this.TextBoxX_Name.PreventEnterBeep = true;
            this.TextBoxX_Name.TextChanged += new System.EventHandler(this.TextBoxX_Name_TextChanged);
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Checked = true;
            this.checkBoxX1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX1.CheckValue = "Y";
            resources.ApplyResources(this.checkBoxX1, "checkBoxX1");
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.CheckedChanged += new System.EventHandler(this.CheckBoxX1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.ButtonX_ChangeDestModelBank);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.TextBoxX_Name);
            this.panel1.Controls.Add(this.TextBoxX_ModelID);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // CustomObjectImportPropsEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxX1);
            this.Name = "CustomObjectImportPropsEditor";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ModelID;
        private DevComponents.DotNetBar.ButtonX ButtonX_ChangeDestModelBank;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Name;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private System.Windows.Forms.Panel panel1;
    }
}
