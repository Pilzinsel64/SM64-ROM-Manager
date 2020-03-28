namespace SM64_ROM_Manager.LevelEditor
{
    partial class FormScriptDumps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScriptDumps));
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxEx1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.ItemPanel_ScriptSelection = new DevComponents.DotNetBar.ItemPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.richTextBoxEx1);
            this.panel1.Controls.Add(this.ItemPanel_ScriptSelection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // richTextBoxEx1
            // 
            // 
            // 
            // 
            this.richTextBoxEx1.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx1.Location = new System.Drawing.Point(200, 0);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.ReadOnly = true;
            this.richTextBoxEx1.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1031{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx1.Size = new System.Drawing.Size(600, 450);
            this.richTextBoxEx1.TabIndex = 0;
            // 
            // ItemPanel_ScriptSelection
            // 
            // 
            // 
            // 
            this.ItemPanel_ScriptSelection.BackgroundStyle.Class = "ItemPanel";
            this.ItemPanel_ScriptSelection.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemPanel_ScriptSelection.ContainerControlProcessDialogKey = true;
            this.ItemPanel_ScriptSelection.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemPanel_ScriptSelection.DragDropSupport = true;
            this.ItemPanel_ScriptSelection.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ItemPanel_ScriptSelection.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ItemPanel_ScriptSelection.Location = new System.Drawing.Point(0, 0);
            this.ItemPanel_ScriptSelection.Name = "ItemPanel_ScriptSelection";
            this.ItemPanel_ScriptSelection.ReserveLeftSpace = false;
            this.ItemPanel_ScriptSelection.Size = new System.Drawing.Size(200, 450);
            this.ItemPanel_ScriptSelection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ItemPanel_ScriptSelection.TabIndex = 1;
            // 
            // FormScriptDumps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScriptDumps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script Dumps";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx1;
        private DevComponents.DotNetBar.ItemPanel ItemPanel_ScriptSelection;
    }
}