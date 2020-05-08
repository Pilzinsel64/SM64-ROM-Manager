using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ApplyPPF
{
    [DesignerGenerated()]
    public partial class ApplyPPFDialog : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyPPFDialog));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.CheckBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.CheckBoxX1);
            this.Panel1.Controls.Add(this.LabelX4);
            this.Panel1.Controls.Add(this.LabelX3);
            this.Panel1.Controls.Add(this.CircularProgress1);
            this.Panel1.Controls.Add(this.ButtonX3);
            this.Panel1.Controls.Add(this.ButtonX2);
            this.Panel1.Controls.Add(this.ButtonX1);
            this.Panel1.Controls.Add(this.LabelX2);
            this.Panel1.Controls.Add(this.LabelX1);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // CheckBoxX1
            // 
            resources.ApplyResources(this.CheckBoxX1, "CheckBoxX1");
            // 
            // 
            // 
            this.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX1.FocusCuesEnabled = false;
            this.CheckBoxX1.Name = "CheckBoxX1";
            this.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX4
            // 
            resources.ApplyResources(this.LabelX4, "LabelX4");
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.TextChanged += new System.EventHandler(this.TextBoxX1_TextChanged);
            // 
            // LabelX3
            // 
            resources.ApplyResources(this.LabelX3, "LabelX3");
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.TextChanged += new System.EventHandler(this.TextBoxX1_TextChanged);
            // 
            // CircularProgress1
            // 
            resources.ApplyResources(this.CircularProgress1, "CircularProgress1");
            // 
            // 
            // 
            this.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CircularProgress1.FocusCuesEnabled = false;
            this.CircularProgress1.Name = "CircularProgress1";
            this.CircularProgress1.ProgressColor = System.Drawing.Color.Empty;
            this.CircularProgress1.SetVisibleStateOnStart = true;
            this.CircularProgress1.SetVisibleStateOnStop = true;
            this.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // ButtonX3
            // 
            this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX3, "ButtonX3");
            this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX3.FocusCuesEnabled = false;
            this.ButtonX3.Image = global::SM64_ROM_Manager.ApplyPPF.My.Resources.Resources.icons8_folder_16px;
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(172)))), ((int)(((byte)(106)))));
            this.ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX3.SymbolSize = 12F;
            this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
            // 
            // ButtonX2
            // 
            this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX2, "ButtonX2");
            this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX2.FocusCuesEnabled = false;
            this.ButtonX2.Image = global::SM64_ROM_Manager.ApplyPPF.My.Resources.Resources.icons8_folder_16px;
            this.ButtonX2.Name = "ButtonX2";
            this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(172)))), ((int)(((byte)(106)))));
            this.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX2.SymbolSize = 12F;
            this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // ButtonX1
            // 
            this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX1, "ButtonX1");
            this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX1.FocusCuesEnabled = false;
            this.ButtonX1.Name = "ButtonX1";
            this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX2, "LabelX2");
            this.LabelX2.Name = "LabelX2";
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX1, "LabelX1");
            this.LabelX1.Name = "LabelX1";
            // 
            // ApplyPPFDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.MaximizeBox = false;
            this.Name = "ApplyPPFDialog";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel Panel1;

        private DevComponents.DotNetBar.LabelX LabelX1;

        private DevComponents.DotNetBar.ButtonX ButtonX1;

        private DevComponents.DotNetBar.LabelX LabelX2;

        private DevComponents.DotNetBar.ButtonX ButtonX2;

        private DevComponents.DotNetBar.ButtonX ButtonX3;

        private DevComponents.DotNetBar.Controls.CircularProgress CircularProgress1;

        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX1;

        private DevComponents.DotNetBar.LabelX LabelX4;

        private DevComponents.DotNetBar.LabelX LabelX3;

    }
}