namespace SM64_ROM_Manager
{
    partial class BehaviorParameterInfoEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BehaviorParameterInfoEditor));
            this.advPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonX_Close = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advPropertyGrid1
            // 
            resources.ApplyResources(this.advPropertyGrid1, "advPropertyGrid1");
            this.advPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.advPropertyGrid1.Name = "advPropertyGrid1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ButtonX_Close);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ButtonX_Close
            // 
            this.ButtonX_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX_Close, "ButtonX_Close");
            this.ButtonX_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonX_Close.Name = "ButtonX_Close";
            this.ButtonX_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // BehaviorParameterInfoEditor
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.advPropertyGrid1);
            this.Name = "BehaviorParameterInfoEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGrid1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX ButtonX_Close;
    }
}