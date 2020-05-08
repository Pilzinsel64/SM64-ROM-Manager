using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Tab_General : UserControl
    {

        // UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_General));
            this.GroupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ItemPanel_RecentFiles = new DevComponents.DotNetBar.ItemPanel();
            this.GroupPanel6 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Button_G_SaveGameName = new DevComponents.DotNetBar.ButtonX();
            this.LabelX27 = new DevComponents.DotNetBar.LabelX();
            this.LabelX_G_Filename = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_G_GameName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX_G_Filesize = new DevComponents.DotNetBar.LabelX();
            this.LabelX34 = new DevComponents.DotNetBar.LabelX();
            this.LabelX35 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pictureBox_RomConfigStatus = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX_RomConfigStatus = new DevComponents.DotNetBar.LabelX();
            this.labelX_RomConfigFilepath = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.microChart1 = new DevComponents.DotNetBar.MicroChart();
            this.GroupPanel2.SuspendLayout();
            this.GroupPanel6.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RomConfigStatus)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPanel2
            // 
            resources.ApplyResources(this.GroupPanel2, "GroupPanel2");
            this.GroupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupPanel2.Controls.Add(this.ItemPanel_RecentFiles);
            this.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.GroupPanel2.Name = "GroupPanel2";
            // 
            // 
            // 
            this.GroupPanel2.Style.BackColorGradientAngle = 90;
            this.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderBottomWidth = 1;
            this.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderLeftWidth = 1;
            this.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderRightWidth = 1;
            this.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderTopWidth = 1;
            this.GroupPanel2.Style.CornerDiameter = 4;
            this.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ItemPanel_RecentFiles
            // 
            resources.ApplyResources(this.ItemPanel_RecentFiles, "ItemPanel_RecentFiles");
            // 
            // 
            // 
            this.ItemPanel_RecentFiles.BackgroundStyle.Class = "ItemPanel";
            this.ItemPanel_RecentFiles.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemPanel_RecentFiles.ContainerControlProcessDialogKey = true;
            this.ItemPanel_RecentFiles.DragDropSupport = true;
            this.ItemPanel_RecentFiles.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ItemPanel_RecentFiles.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ItemPanel_RecentFiles.Name = "ItemPanel_RecentFiles";
            this.ItemPanel_RecentFiles.ReserveLeftSpace = false;
            this.ItemPanel_RecentFiles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // GroupPanel6
            // 
            resources.ApplyResources(this.GroupPanel6, "GroupPanel6");
            this.GroupPanel6.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel6.CanvasColor = System.Drawing.Color.Empty;
            this.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupPanel6.Controls.Add(this.Button_G_SaveGameName);
            this.GroupPanel6.Controls.Add(this.LabelX27);
            this.GroupPanel6.Controls.Add(this.LabelX_G_Filename);
            this.GroupPanel6.Controls.Add(this.TextBoxX_G_GameName);
            this.GroupPanel6.Controls.Add(this.LabelX_G_Filesize);
            this.GroupPanel6.Controls.Add(this.LabelX34);
            this.GroupPanel6.Controls.Add(this.LabelX35);
            this.GroupPanel6.DisabledBackColor = System.Drawing.Color.Empty;
            this.GroupPanel6.Name = "GroupPanel6";
            // 
            // 
            // 
            this.GroupPanel6.Style.BackColorGradientAngle = 90;
            this.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel6.Style.BorderBottomWidth = 1;
            this.GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel6.Style.BorderLeftWidth = 1;
            this.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel6.Style.BorderRightWidth = 1;
            this.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel6.Style.BorderTopWidth = 1;
            this.GroupPanel6.Style.CornerDiameter = 4;
            this.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Button_G_SaveGameName
            // 
            this.Button_G_SaveGameName.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.Button_G_SaveGameName, "Button_G_SaveGameName");
            this.Button_G_SaveGameName.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_G_SaveGameName.FocusCuesEnabled = false;
            this.Button_G_SaveGameName.Name = "Button_G_SaveGameName";
            this.Button_G_SaveGameName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_G_SaveGameName.Click += new System.EventHandler(this.Button_G_SaveGameName_Click);
            // 
            // LabelX27
            // 
            // 
            // 
            // 
            this.LabelX27.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.LabelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX27, "LabelX27");
            this.LabelX27.Name = "LabelX27";
            this.LabelX27.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX_G_Filename
            // 
            resources.ApplyResources(this.LabelX_G_Filename, "LabelX_G_Filename");
            this.LabelX_G_Filename.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX_G_Filename.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_G_Filename.Name = "LabelX_G_Filename";
            this.LabelX_G_Filename.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // TextBoxX_G_GameName
            // 
            resources.ApplyResources(this.TextBoxX_G_GameName, "TextBoxX_G_GameName");
            this.TextBoxX_G_GameName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_G_GameName.Border.Class = "TextBoxBorder";
            this.TextBoxX_G_GameName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_G_GameName.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_G_GameName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_G_GameName.Name = "TextBoxX_G_GameName";
            this.TextBoxX_G_GameName.PreventEnterBeep = true;
            this.TextBoxX_G_GameName.TextChanged += new System.EventHandler(this.TextBoxX_G_GameName_TextChanged);
            // 
            // LabelX_G_Filesize
            // 
            resources.ApplyResources(this.LabelX_G_Filesize, "LabelX_G_Filesize");
            this.LabelX_G_Filesize.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX_G_Filesize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_G_Filesize.Name = "LabelX_G_Filesize";
            this.LabelX_G_Filesize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX34
            // 
            // 
            // 
            // 
            this.LabelX34.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.LabelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX34, "LabelX34");
            this.LabelX34.Name = "LabelX34";
            this.LabelX34.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX35
            // 
            // 
            // 
            // 
            this.LabelX35.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.LabelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX35, "LabelX35");
            this.LabelX35.Name = "LabelX35";
            this.LabelX35.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // groupPanel1
            // 
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.Color.Empty;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.pictureBox_RomConfigStatus);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelX_RomConfigStatus);
            this.groupPanel1.Controls.Add(this.labelX_RomConfigFilepath);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Name = "groupPanel1";
            // 
            // 
            // 
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // pictureBox_RomConfigStatus
            // 
            resources.ApplyResources(this.pictureBox_RomConfigStatus, "pictureBox_RomConfigStatus");
            this.pictureBox_RomConfigStatus.Name = "pictureBox_RomConfigStatus";
            this.pictureBox_RomConfigStatus.TabStop = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // labelX_RomConfigStatus
            // 
            resources.ApplyResources(this.labelX_RomConfigStatus, "labelX_RomConfigStatus");
            this.labelX_RomConfigStatus.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX_RomConfigStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_RomConfigStatus.Name = "labelX_RomConfigStatus";
            this.labelX_RomConfigStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // labelX_RomConfigFilepath
            // 
            resources.ApplyResources(this.labelX_RomConfigFilepath, "labelX_RomConfigFilepath");
            this.labelX_RomConfigFilepath.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX_RomConfigFilepath.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_RomConfigFilepath.Name = "labelX_RomConfigFilepath";
            this.labelX_RomConfigFilepath.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // labelX3
            // 
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Name = "labelX3";
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX5, "labelX5");
            this.labelX5.Name = "labelX5";
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // groupPanel3
            // 
            resources.ApplyResources(this.groupPanel3, "groupPanel3");
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.Color.Empty;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.microChart1);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Name = "groupPanel3";
            // 
            // 
            // 
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // microChart1
            // 
            // 
            // 
            // 
            this.microChart1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.microChart1.ChartType = DevComponents.DotNetBar.eMicroChartType.Pie;
            resources.ApplyResources(this.microChart1, "microChart1");
            this.microChart1.Name = "microChart1";
            this.microChart1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Tab_General
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupPanel2);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.GroupPanel6);
            this.Name = "Tab_General";
            resources.ApplyResources(this, "$this");
            this.GroupPanel2.ResumeLayout(false);
            this.GroupPanel6.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RomConfigStatus)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel2;


        internal DevComponents.DotNetBar.ItemPanel ItemPanel_RecentFiles;


        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel6;


        private DevComponents.DotNetBar.ButtonX Button_G_SaveGameName;


        private DevComponents.DotNetBar.LabelX LabelX27;


        private DevComponents.DotNetBar.LabelX LabelX_G_Filename;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_G_GameName;

        private DevComponents.DotNetBar.LabelX LabelX_G_Filesize;


        private DevComponents.DotNetBar.LabelX LabelX34;


        private DevComponents.DotNetBar.LabelX LabelX35;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX_RomConfigStatus;
        private DevComponents.DotNetBar.LabelX labelX_RomConfigFilepath;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX5;
        private PictureBox pictureBox_RomConfigStatus;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.MicroChart microChart1;
    }
}