using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [DesignerGenerated()]
    public partial class CollisionEditor : DevComponents.DotNetBar.OfficeForm
    {

        // Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollisionEditor));
            this.TextBoxX_ColParam2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX_ColParam1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX_ColParamsTipp = new DevComponents.DotNetBar.LabelX();
            this.LabelX_Param2 = new DevComponents.DotNetBar.LabelX();
            this.LabelX_Param1 = new DevComponents.DotNetBar.LabelX();
            this.Button_SaveColsettings = new DevComponents.DotNetBar.ButtonX();
            this.LabelX48 = new DevComponents.DotNetBar.LabelX();
            this.ComboBox_ColType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX_CollisionType = new DevComponents.DotNetBar.LabelX();
            this.CheckBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.CheckBoxX_IsNonSolid = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ListViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxX_ColParam2
            // 
            resources.ApplyResources(this.TextBoxX_ColParam2, "_TextBoxX_ColParam2");
            this.TextBoxX_ColParam2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ColParam2.Border.Class = "TextBoxBorder";
            this.TextBoxX_ColParam2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ColParam2.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ColParam2.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ColParam2.Name = "_TextBoxX_ColParam2";
            this.TextBoxX_ColParam2.PreventEnterBeep = true;
            this.TextBoxX_ColParam2.TextChanged += new System.EventHandler(this.ComboBox_CI_ColType_SelectedIndexChanged);
            // 
            // TextBoxX_ColParam1
            // 
            resources.ApplyResources(this.TextBoxX_ColParam1, "_TextBoxX_ColParam1");
            this.TextBoxX_ColParam1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ColParam1.Border.Class = "TextBoxBorder";
            this.TextBoxX_ColParam1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ColParam1.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ColParam1.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ColParam1.Name = "_TextBoxX_ColParam1";
            this.TextBoxX_ColParam1.PreventEnterBeep = true;
            this.TextBoxX_ColParam1.TextChanged += new System.EventHandler(this.ComboBox_CI_ColType_SelectedIndexChanged);
            // 
            // LabelX_ColParamsTipp
            // 
            resources.ApplyResources(this.LabelX_ColParamsTipp, "_LabelX_ColParamsTipp");
            // 
            // 
            // 
            this.LabelX_ColParamsTipp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_ColParamsTipp.Name = "_LabelX_ColParamsTipp";
            this.LabelX_ColParamsTipp.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.LabelX_ColParamsTipp.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // LabelX_Param2
            // 
            resources.ApplyResources(this.LabelX_Param2, "_LabelX_Param2");
            // 
            // 
            // 
            this.LabelX_Param2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_Param2.Name = "_LabelX_Param2";
            this.LabelX_Param2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX_Param1
            // 
            resources.ApplyResources(this.LabelX_Param1, "_LabelX_Param1");
            // 
            // 
            // 
            this.LabelX_Param1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_Param1.Name = "_LabelX_Param1";
            this.LabelX_Param1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // Button_SaveColsettings
            // 
            this.Button_SaveColsettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.Button_SaveColsettings, "_Button_SaveColsettings");
            this.Button_SaveColsettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_SaveColsettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_SaveColsettings.FocusCuesEnabled = false;
            this.Button_SaveColsettings.Name = "_Button_SaveColsettings";
            this.Button_SaveColsettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX48
            // 
            // 
            // 
            // 
            this.LabelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX48, "_LabelX48");
            this.LabelX48.Name = "_LabelX48";
            this.LabelX48.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // ComboBox_ColType
            // 
            resources.ApplyResources(this.ComboBox_ColType, "_ComboBox_ColType");
            this.ComboBox_ColType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_ColType.DropDownHeight = 150;
            this.ComboBox_ColType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_ColType.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_ColType.FormattingEnabled = true;
            this.ComboBox_ColType.Name = "_ComboBox_ColType";
            this.ComboBox_ColType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBox_ColType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_CI_ColType_SelectedIndexChanged);
            // 
            // LabelX_CollisionType
            // 
            resources.ApplyResources(this.LabelX_CollisionType, "_LabelX_CollisionType");
            // 
            // 
            // 
            this.LabelX_CollisionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_CollisionType.Name = "_LabelX_CollisionType";
            this.LabelX_CollisionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // CheckBoxX1
            // 
            resources.ApplyResources(this.CheckBoxX1, "_CheckBoxX1");
            // 
            // 
            // 
            this.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX1.FocusCuesEnabled = false;
            this.CheckBoxX1.Name = "_CheckBoxX1";
            this.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX1.CheckedChanged += new System.EventHandler(this.CheckBoxX1_CheckedChanging);
            // 
            // TextBoxX1
            // 
            resources.ApplyResources(this.TextBoxX1, "_TextBoxX1");
            this.TextBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX1.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX1.Name = "_TextBoxX1";
            this.TextBoxX1.PreventEnterBeep = true;
            this.TextBoxX1.TextChanged += new System.EventHandler(this.TextBoxX1_TextChanged);
            // 
            // SuperTooltip1
            // 
            resources.ApplyResources(this.SuperTooltip1, "_SuperTooltip1");
            this.SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // PictureBox1
            // 
            resources.ApplyResources(this.PictureBox1, "_PictureBox1");
            this.PictureBox1.Name = "_PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            resources.ApplyResources(this.Panel1, "_Panel1");
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.LabelX_CollisionType);
            this.Panel1.Controls.Add(this.ComboBox_ColType);
            this.Panel1.Controls.Add(this.LabelX_Param2);
            this.Panel1.Controls.Add(this.LabelX_ColParamsTipp);
            this.Panel1.Controls.Add(this.LabelX_Param1);
            this.Panel1.Controls.Add(this.TextBoxX_ColParam1);
            this.Panel1.Controls.Add(this.CheckBoxX1);
            this.Panel1.Controls.Add(this.TextBoxX_ColParam2);
            this.Panel1.Controls.Add(this.TextBoxX1);
            this.Panel1.Name = "_Panel1";
            // 
            // CheckBoxX_IsNonSolid
            // 
            resources.ApplyResources(this.CheckBoxX_IsNonSolid, "_CheckBoxX_IsNonSolid");
            // 
            // 
            // 
            this.CheckBoxX_IsNonSolid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_IsNonSolid.FocusCuesEnabled = false;
            this.CheckBoxX_IsNonSolid.Name = "_CheckBoxX_IsNonSolid";
            this.CheckBoxX_IsNonSolid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_IsNonSolid.CheckedChanged += new System.EventHandler(this.ButtonItem_IsNonSolid_CheckedChanged);
            // 
            // CircularProgress1
            // 
            resources.ApplyResources(this.CircularProgress1, "_CircularProgress1");
            this.CircularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CircularProgress1.Name = "_CircularProgress1";
            this.CircularProgress1.SetVisibleStateOnStart = true;
            this.CircularProgress1.SetVisibleStateOnStop = true;
            this.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.LabelX48);
            this.Panel2.Controls.Add(this.CircularProgress1);
            this.Panel2.Controls.Add(this.Button_SaveColsettings);
            this.Panel2.Controls.Add(this.CheckBoxX_IsNonSolid);
            this.Panel2.Controls.Add(this.ListViewEx1);
            this.Panel2.Controls.Add(this.Panel1);
            this.Panel2.Controls.Add(this.PictureBox1);
            resources.ApplyResources(this.Panel2, "_Panel2");
            this.Panel2.Name = "_Panel2";
            // 
            // ListViewEx1
            // 
            resources.ApplyResources(this.ListViewEx1, "_ListViewEx1");
            this.ListViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ListViewEx1.Border.Class = "ListViewBorder";
            this.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.ListViewEx1.FocusCuesEnabled = false;
            this.ListViewEx1.ForeColor = System.Drawing.Color.Black;
            this.ListViewEx1.FullRowSelect = true;
            this.ListViewEx1.HideSelection = false;
            this.ListViewEx1.Name = "_ListViewEx1";
            this.ListViewEx1.UseCompatibleStateImageBehavior = false;
            this.ListViewEx1.SelectedIndexChanged += new System.EventHandler(this.ListBoxAdv_CI_Textures_ItemClick);
            // 
            // CollisionEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollisionEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ColParam2;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ColParam1;

        private DevComponents.DotNetBar.LabelX LabelX_ColParamsTipp;

        private DevComponents.DotNetBar.LabelX LabelX_Param2;

        private DevComponents.DotNetBar.LabelX LabelX_Param1;

        private DevComponents.DotNetBar.ButtonX Button_SaveColsettings;

        private DevComponents.DotNetBar.LabelX LabelX48;

        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_ColType;

        private DevComponents.DotNetBar.LabelX LabelX_CollisionType;

        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX1;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;

        private DevComponents.DotNetBar.SuperTooltip SuperTooltip1;

        private System.Windows.Forms.PictureBox PictureBox1;

        private System.Windows.Forms.Panel Panel1;

        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_IsNonSolid;

        private DevComponents.DotNetBar.Controls.CircularProgress CircularProgress1;

        private System.Windows.Forms.Panel Panel2;
        private DevComponents.DotNetBar.Controls.ListViewEx ListViewEx1;

    }
}