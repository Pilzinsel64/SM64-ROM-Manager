using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    partial class CameraFrustumDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraFrustumDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_Near = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_Far = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.textBoxX_Near);
            this.panel1.Controls.Add(this.textBoxX_Far);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.buttonX2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 87);
            this.panel1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Near:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 32);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Far:";
            // 
            // textBoxX_Near
            // 
            // 
            // 
            // 
            this.textBoxX_Near.Border.Class = "TextBoxBorder";
            this.textBoxX_Near.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_Near.Location = new System.Drawing.Point(65, 5);
            this.textBoxX_Near.Name = "textBoxX_Near";
            this.textBoxX_Near.PreventEnterBeep = true;
            this.textBoxX_Near.Size = new System.Drawing.Size(94, 20);
            this.textBoxX_Near.TabIndex = 3;
            // 
            // textBoxX_Far
            // 
            // 
            // 
            // 
            this.textBoxX_Far.Border.Class = "TextBoxBorder";
            this.textBoxX_Far.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_Far.Location = new System.Drawing.Point(65, 34);
            this.textBoxX_Far.Name = "textBoxX_Far";
            this.textBoxX_Far.PreventEnterBeep = true;
            this.textBoxX_Far.Size = new System.Drawing.Size(94, 20);
            this.textBoxX_Far.TabIndex = 4;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_checkmark_16px_1;
            this.buttonX1.Location = new System.Drawing.Point(3, 61);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "Save";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX2.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.buttonX2.Location = new System.Drawing.Point(84, 61);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 0;
            this.buttonX2.Text = "Cancel";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // CameraFrustumDialog
            // 
            this.AcceptButton = this.buttonX1;
            this.CancelButton = this.buttonX2;
            this.ClientSize = new System.Drawing.Size(162, 87);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CameraFrustumDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Camera Frustum";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private LabelX labelX1;
        private LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Near;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Far;
        private ButtonX buttonX1;
        private ButtonX buttonX2;
        private Panel panel1;

        #endregion
    }
}