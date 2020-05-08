namespace SM64_ROM_Manager
{
    partial class CustomAsmCodeSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomAsmCodeSelector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_Select = new DevComponents.DotNetBar.ButtonX();
            this.AdvTree1 = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonX_Cancel);
            this.panel1.Controls.Add(this.buttonX_Select);
            this.panel1.Name = "panel1";
            // 
            // buttonX_Cancel
            // 
            resources.ApplyResources(this.buttonX_Cancel, "buttonX_Cancel");
            this.buttonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX_Cancel.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.buttonX_Cancel.Name = "buttonX_Cancel";
            this.buttonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // buttonX_Select
            // 
            resources.ApplyResources(this.buttonX_Select, "buttonX_Select");
            this.buttonX_Select.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Select.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonX_Select.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_checkmark_16px_1;
            this.buttonX_Select.Name = "buttonX_Select";
            this.buttonX_Select.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // AdvTree1
            // 
            resources.ApplyResources(this.AdvTree1, "AdvTree1");
            this.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree1.Columns.Add(this.columnHeader1);
            this.AdvTree1.Columns.Add(this.columnHeader2);
            this.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree1.Name = "AdvTree1";
            this.AdvTree1.NodesConnector = this.nodeConnector1;
            this.AdvTree1.NodeStyle = this.elementStyle1;
            this.AdvTree1.PathSeparator = ";";
            this.AdvTree1.Styles.Add(this.elementStyle1);
            this.AdvTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree1_AfterNodeSelect);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            this.columnHeader1.Width.Absolute = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            this.columnHeader2.Width.Absolute = 80;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // CustomAsmCodeSelector
            // 
            this.AcceptButton = this.buttonX_Select;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonX_Cancel;
            this.Controls.Add(this.AdvTree1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CustomAsmCodeSelector";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Load += new System.EventHandler(this.CustomModelSelector_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.AdvTree.AdvTree AdvTree1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ButtonX buttonX_Select;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.DotNetBar.ButtonX buttonX_Cancel;
    }
}