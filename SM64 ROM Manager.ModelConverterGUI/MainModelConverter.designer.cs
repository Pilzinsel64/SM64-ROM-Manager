using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [DesignerGenerated()]
    public partial class MainModelConverter : DevComponents.DotNetBar.OfficeForm
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
        private System.ComponentModel.IContainer components = new System.ComponentModel.Container();

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainModelConverter));
            this.Line2 = new DevComponents.DotNetBar.Controls.Line();
            this.LabelX_Colfile = new DevComponents.DotNetBar.LabelX();
            this.LabelX_Modelfile = new DevComponents.DotNetBar.LabelX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_EnableFog = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.Button_ColEditor = new DevComponents.DotNetBar.ButtonX();
            this.LabelX20 = new DevComponents.DotNetBar.LabelX();
            this.LabelX16 = new DevComponents.DotNetBar.LabelX();
            this.NUD_Scaling = new DevComponents.Editors.DoubleInput();
            this.Button_LoadCol = new DevComponents.DotNetBar.ButtonX();
            this.Button_LoadModel = new DevComponents.DotNetBar.ButtonX();
            this.Line3 = new DevComponents.DotNetBar.Controls.Line();
            this.Button_ConvertModel = new DevComponents.DotNetBar.ButtonX();
            this.CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.ComboBoxEx_UpAxis = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem1 = new DevComponents.Editors.ComboItem();
            this.ComboItem2 = new DevComponents.Editors.ComboItem();
            this.LabelX9 = new DevComponents.DotNetBar.LabelX();
            this.CheckBoxX_ConvertModel = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CheckBoxX_ConvertCollision = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_ResizeTextures = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX5 = new DevComponents.DotNetBar.LabelX();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.LabelX7 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_CenterModel = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.ButtonX_VisualMapPreview = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_CollisionMapPreview = new DevComponents.DotNetBar.ButtonX();
            this.SwitchButton_EnableReduceVertices = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX10 = new DevComponents.DotNetBar.LabelX();
            this.ButtonX_GraphicsEditor = new DevComponents.DotNetBar.ButtonX();
            this.ComboBox_FogTyp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.LabelX8 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_OptimizeTransChecks = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonItem_SetupDiffusePosition = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ResetDiffusePosition = new DevComponents.DotNetBar.ButtonItem();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.ColorPickerButton_ShadingAmbient = new DevComponents.DotNetBar.ColorPickerButton();
            this.ColorPickerButton_FogColor = new DevComponents.DotNetBar.ColorPickerButton();
            this.ColorPickerButton_ShadingDiffuse = new DevComponents.DotNetBar.ColorPickerButton();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Scaling)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // Line2
            // 
            resources.ApplyResources(this.Line2, "Line2");
            this.Line2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Line2.Name = "Line2";
            // 
            // LabelX_Colfile
            // 
            // 
            // 
            // 
            this.LabelX_Colfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_Colfile, "LabelX_Colfile");
            this.LabelX_Colfile.Name = "LabelX_Colfile";
            this.LabelX_Colfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.LabelX_Colfile.TextChanged += new System.EventHandler(this.LabelX_Colfile_Click);
            // 
            // LabelX_Modelfile
            // 
            // 
            // 
            // 
            this.LabelX_Modelfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_Modelfile, "LabelX_Modelfile");
            this.LabelX_Modelfile.Name = "LabelX_Modelfile";
            this.LabelX_Modelfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX2, "LabelX2");
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX1, "LabelX1");
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX4
            // 
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX4, "LabelX4");
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.SuperTooltip1.SetSuperTooltip(this.LabelX4, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("LabelX4.SuperTooltip"), resources.GetString("LabelX4.SuperTooltip1"), resources.GetString("LabelX4.SuperTooltip2"), ((System.Drawing.Image)(resources.GetObject("LabelX4.SuperTooltip3"))), ((System.Drawing.Image)(resources.GetObject("LabelX4.SuperTooltip4"))), ((DevComponents.DotNetBar.eTooltipColor)(resources.GetObject("LabelX4.SuperTooltip5"))), ((bool)(resources.GetObject("LabelX4.SuperTooltip6"))), ((bool)(resources.GetObject("LabelX4.SuperTooltip7"))), ((System.Drawing.Size)(resources.GetObject("LabelX4.SuperTooltip8")))));
            // 
            // SwitchButton_EnableFog
            // 
            // 
            // 
            // 
            this.SwitchButton_EnableFog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_EnableFog.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_EnableFog, "SwitchButton_EnableFog");
            this.SwitchButton_EnableFog.Name = "SwitchButton_EnableFog";
            this.SwitchButton_EnableFog.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_EnableFog.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_EnableFog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_EnableFog.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_EnableFog.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_EnableFog.SwitchWidth = 15;
            this.SwitchButton_EnableFog.ValueChanged += new System.EventHandler(this.SwitchButton_EnableFog_ValueChanged);
            // 
            // Button_ColEditor
            // 
            this.Button_ColEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_ColEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.Button_ColEditor, "Button_ColEditor");
            this.Button_ColEditor.FocusCuesEnabled = false;
            this.Button_ColEditor.Name = "Button_ColEditor";
            this.Button_ColEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_ColEditor.Click += new System.EventHandler(this.Button_ColEditor_Click);
            // 
            // LabelX20
            // 
            // 
            // 
            // 
            this.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX20, "LabelX20");
            this.LabelX20.Name = "LabelX20";
            this.LabelX20.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX16
            // 
            // 
            // 
            // 
            this.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX16, "LabelX16");
            this.LabelX16.Name = "LabelX16";
            this.LabelX16.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // NUD_Scaling
            // 
            // 
            // 
            // 
            this.NUD_Scaling.BackgroundStyle.Class = "DateTimeInputBackground";
            this.NUD_Scaling.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NUD_Scaling.Increment = 1D;
            this.NUD_Scaling.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            resources.ApplyResources(this.NUD_Scaling, "NUD_Scaling");
            this.NUD_Scaling.MaxValue = 1E+15D;
            this.NUD_Scaling.MinValue = 1E-32D;
            this.NUD_Scaling.Name = "NUD_Scaling";
            this.NUD_Scaling.ShowUpDown = true;
            this.SuperTooltip1.SetSuperTooltip(this.NUD_Scaling, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("NUD_Scaling.SuperTooltip"), resources.GetString("NUD_Scaling.SuperTooltip1"), resources.GetString("NUD_Scaling.SuperTooltip2"), ((System.Drawing.Image)(resources.GetObject("NUD_Scaling.SuperTooltip3"))), ((System.Drawing.Image)(resources.GetObject("NUD_Scaling.SuperTooltip4"))), ((DevComponents.DotNetBar.eTooltipColor)(resources.GetObject("NUD_Scaling.SuperTooltip5"))), ((bool)(resources.GetObject("NUD_Scaling.SuperTooltip6"))), ((bool)(resources.GetObject("NUD_Scaling.SuperTooltip7"))), ((System.Drawing.Size)(resources.GetObject("NUD_Scaling.SuperTooltip8")))));
            this.NUD_Scaling.Value = 500D;
            // 
            // Button_LoadCol
            // 
            this.Button_LoadCol.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.Button_LoadCol, "Button_LoadCol");
            this.Button_LoadCol.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_LoadCol.FocusCuesEnabled = false;
            this.Button_LoadCol.Image = global::SM64_ROM_Manager.ModelConverterGUI.My.Resources.Resources.icons8_folder_16px;
            this.Button_LoadCol.Name = "Button_LoadCol";
            this.Button_LoadCol.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SuperTooltip1.SetSuperTooltip(this.Button_LoadCol, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("Button_LoadCol.SuperTooltip"), resources.GetString("Button_LoadCol.SuperTooltip1"), resources.GetString("Button_LoadCol.SuperTooltip2"), ((System.Drawing.Image)(resources.GetObject("Button_LoadCol.SuperTooltip3"))), ((System.Drawing.Image)(resources.GetObject("Button_LoadCol.SuperTooltip4"))), ((DevComponents.DotNetBar.eTooltipColor)(resources.GetObject("Button_LoadCol.SuperTooltip5"))), ((bool)(resources.GetObject("Button_LoadCol.SuperTooltip6"))), ((bool)(resources.GetObject("Button_LoadCol.SuperTooltip7"))), ((System.Drawing.Size)(resources.GetObject("Button_LoadCol.SuperTooltip8")))));
            this.Button_LoadCol.Click += new System.EventHandler(this.Button3_LM_LoadCol_Click);
            // 
            // Button_LoadModel
            // 
            this.Button_LoadModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.Button_LoadModel, "Button_LoadModel");
            this.Button_LoadModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_LoadModel.FocusCuesEnabled = false;
            this.Button_LoadModel.Image = global::SM64_ROM_Manager.ModelConverterGUI.My.Resources.Resources.icons8_folder_16px;
            this.Button_LoadModel.Name = "Button_LoadModel";
            this.Button_LoadModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SuperTooltip1.SetSuperTooltip(this.Button_LoadModel, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("Button_LoadModel.SuperTooltip"), resources.GetString("Button_LoadModel.SuperTooltip1"), resources.GetString("Button_LoadModel.SuperTooltip2"), ((System.Drawing.Image)(resources.GetObject("Button_LoadModel.SuperTooltip3"))), ((System.Drawing.Image)(resources.GetObject("Button_LoadModel.SuperTooltip4"))), ((DevComponents.DotNetBar.eTooltipColor)(resources.GetObject("Button_LoadModel.SuperTooltip5"))), ((bool)(resources.GetObject("Button_LoadModel.SuperTooltip6"))), ((bool)(resources.GetObject("Button_LoadModel.SuperTooltip7"))), ((System.Drawing.Size)(resources.GetObject("Button_LoadModel.SuperTooltip8")))));
            this.Button_LoadModel.Click += new System.EventHandler(this.Button_LM_LoadModel_Click);
            // 
            // Line3
            // 
            resources.ApplyResources(this.Line3, "Line3");
            this.Line3.BackColor = System.Drawing.Color.Transparent;
            this.Line3.ForeColor = System.Drawing.Color.Gainsboro;
            this.Line3.Name = "Line3";
            this.Line3.VerticalLine = true;
            // 
            // Button_ConvertModel
            // 
            this.Button_ConvertModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.Button_ConvertModel, "Button_ConvertModel");
            this.Button_ConvertModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_ConvertModel.FocusCuesEnabled = false;
            this.Button_ConvertModel.Name = "Button_ConvertModel";
            this.Button_ConvertModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_ConvertModel.Click += new System.EventHandler(this.Button_ConvertModel_Click);
            // 
            // CircularProgress1
            // 
            resources.ApplyResources(this.CircularProgress1, "CircularProgress1");
            this.CircularProgress1.AnimationSpeed = 50;
            this.CircularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CircularProgress1.FocusCuesEnabled = false;
            this.CircularProgress1.Name = "CircularProgress1";
            this.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.CircularProgress1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.CircularProgress1.SetVisibleStateOnStart = true;
            this.CircularProgress1.SetVisibleStateOnStop = true;
            this.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // SuperTooltip1
            // 
            resources.ApplyResources(this.SuperTooltip1, "SuperTooltip1");
            this.SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.SuperTooltip1.MaximumWidth = 200;
            // 
            // ComboBoxEx_UpAxis
            // 
            this.ComboBoxEx_UpAxis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_UpAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx_UpAxis.DropDownWidth = 107;
            this.ComboBoxEx_UpAxis.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_UpAxis.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBoxEx_UpAxis, "ComboBoxEx_UpAxis");
            this.ComboBoxEx_UpAxis.Items.AddRange(new object[] {
            this.ComboItem1,
            this.ComboItem2});
            this.ComboBoxEx_UpAxis.Name = "ComboBoxEx_UpAxis";
            this.ComboBoxEx_UpAxis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SuperTooltip1.SetSuperTooltip(this.ComboBoxEx_UpAxis, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("ComboBoxEx_UpAxis.SuperTooltip"), resources.GetString("ComboBoxEx_UpAxis.SuperTooltip1"), resources.GetString("ComboBoxEx_UpAxis.SuperTooltip2"), ((System.Drawing.Image)(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip3"))), ((System.Drawing.Image)(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip4"))), ((DevComponents.DotNetBar.eTooltipColor)(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip5"))), ((bool)(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip6"))), ((bool)(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip7"))), ((System.Drawing.Size)(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip8")))));
            this.ComboBoxEx_UpAxis.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx1_SelectedIndexChanged);
            // 
            // ComboItem1
            // 
            resources.ApplyResources(this.ComboItem1, "ComboItem1");
            // 
            // ComboItem2
            // 
            resources.ApplyResources(this.ComboItem2, "ComboItem2");
            // 
            // LabelX9
            // 
            // 
            // 
            // 
            this.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX9, "LabelX9");
            this.LabelX9.Name = "LabelX9";
            this.LabelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // CheckBoxX_ConvertModel
            // 
            // 
            // 
            // 
            this.CheckBoxX_ConvertModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_ConvertModel.Checked = true;
            this.CheckBoxX_ConvertModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxX_ConvertModel.CheckValue = "Y";
            this.CheckBoxX_ConvertModel.FocusCuesEnabled = false;
            resources.ApplyResources(this.CheckBoxX_ConvertModel, "CheckBoxX_ConvertModel");
            this.CheckBoxX_ConvertModel.Name = "CheckBoxX_ConvertModel";
            this.CheckBoxX_ConvertModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.CheckBoxX_ConvertModel.CheckedChanged += new System.EventHandler(this.CheckBoxX_ConvertModel_CheckedChanged);
            // 
            // CheckBoxX_ConvertCollision
            // 
            // 
            // 
            // 
            this.CheckBoxX_ConvertCollision.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_ConvertCollision.Checked = true;
            this.CheckBoxX_ConvertCollision.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxX_ConvertCollision.CheckValue = "Y";
            this.CheckBoxX_ConvertCollision.FocusCuesEnabled = false;
            resources.ApplyResources(this.CheckBoxX_ConvertCollision, "CheckBoxX_ConvertCollision");
            this.CheckBoxX_ConvertCollision.Name = "CheckBoxX_ConvertCollision";
            this.CheckBoxX_ConvertCollision.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.CheckBoxX_ConvertCollision.CheckedChanged += new System.EventHandler(this.CheckBoxX_ConvertCollision_CheckedChanged);
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX3, "LabelX3");
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_ResizeTextures
            // 
            // 
            // 
            // 
            this.SwitchButton_ResizeTextures.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_ResizeTextures.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_ResizeTextures, "SwitchButton_ResizeTextures");
            this.SwitchButton_ResizeTextures.Name = "SwitchButton_ResizeTextures";
            this.SwitchButton_ResizeTextures.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_ResizeTextures.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_ResizeTextures.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_ResizeTextures.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_ResizeTextures.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_ResizeTextures.SwitchWidth = 15;
            this.SwitchButton_ResizeTextures.Value = true;
            this.SwitchButton_ResizeTextures.ValueObject = "Y";
            // 
            // LabelX5
            // 
            // 
            // 
            // 
            this.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX5, "LabelX5");
            this.LabelX5.Name = "LabelX5";
            this.LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX6
            // 
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX6, "LabelX6");
            this.LabelX6.Name = "LabelX6";
            this.LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX7
            // 
            // 
            // 
            // 
            this.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX7, "LabelX7");
            this.LabelX7.Name = "LabelX7";
            this.LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_CenterModel
            // 
            // 
            // 
            // 
            this.SwitchButton_CenterModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_CenterModel.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_CenterModel, "SwitchButton_CenterModel");
            this.SwitchButton_CenterModel.Name = "SwitchButton_CenterModel";
            this.SwitchButton_CenterModel.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_CenterModel.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_CenterModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_CenterModel.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_CenterModel.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_CenterModel.SwitchWidth = 15;
            // 
            // ButtonX_VisualMapPreview
            // 
            this.ButtonX_VisualMapPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_VisualMapPreview.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ButtonX_VisualMapPreview, "ButtonX_VisualMapPreview");
            this.ButtonX_VisualMapPreview.FocusCuesEnabled = false;
            this.ButtonX_VisualMapPreview.Name = "ButtonX_VisualMapPreview";
            this.ButtonX_VisualMapPreview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_VisualMapPreview.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // ButtonX_CollisionMapPreview
            // 
            this.ButtonX_CollisionMapPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_CollisionMapPreview.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ButtonX_CollisionMapPreview, "ButtonX_CollisionMapPreview");
            this.ButtonX_CollisionMapPreview.FocusCuesEnabled = false;
            this.ButtonX_CollisionMapPreview.Name = "ButtonX_CollisionMapPreview";
            this.ButtonX_CollisionMapPreview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_CollisionMapPreview.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // SwitchButton_EnableReduceVertices
            // 
            // 
            // 
            // 
            this.SwitchButton_EnableReduceVertices.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_EnableReduceVertices.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_EnableReduceVertices, "SwitchButton_EnableReduceVertices");
            this.SwitchButton_EnableReduceVertices.Name = "SwitchButton_EnableReduceVertices";
            this.SwitchButton_EnableReduceVertices.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_EnableReduceVertices.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_EnableReduceVertices.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_EnableReduceVertices.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_EnableReduceVertices.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_EnableReduceVertices.SwitchWidth = 15;
            this.SwitchButton_EnableReduceVertices.Value = true;
            this.SwitchButton_EnableReduceVertices.ValueObject = "Y";
            // 
            // LabelX10
            // 
            // 
            // 
            // 
            this.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX10, "LabelX10");
            this.LabelX10.Name = "LabelX10";
            this.LabelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ButtonX_GraphicsEditor
            // 
            this.ButtonX_GraphicsEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_GraphicsEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ButtonX_GraphicsEditor, "ButtonX_GraphicsEditor");
            this.ButtonX_GraphicsEditor.FocusCuesEnabled = false;
            this.ButtonX_GraphicsEditor.Name = "ButtonX_GraphicsEditor";
            this.ButtonX_GraphicsEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_GraphicsEditor.Click += new System.EventHandler(this.ButtonX_GraphicsEditor_Click);
            // 
            // ComboBox_FogTyp
            // 
            this.ComboBox_FogTyp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_FogTyp.DropDownHeight = 150;
            this.ComboBox_FogTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ComboBox_FogTyp, "ComboBox_FogTyp");
            this.ComboBox_FogTyp.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_FogTyp.FormattingEnabled = true;
            this.ComboBox_FogTyp.Items.AddRange(new object[] {
            resources.GetString("ComboBox_FogTyp.Items"),
            resources.GetString("ComboBox_FogTyp.Items1"),
            resources.GetString("ComboBox_FogTyp.Items2"),
            resources.GetString("ComboBox_FogTyp.Items3"),
            resources.GetString("ComboBox_FogTyp.Items4"),
            resources.GetString("ComboBox_FogTyp.Items5"),
            resources.GetString("ComboBox_FogTyp.Items6"),
            resources.GetString("ComboBox_FogTyp.Items7"),
            resources.GetString("ComboBox_FogTyp.Items8")});
            this.ComboBox_FogTyp.Name = "ComboBox_FogTyp";
            this.ComboBox_FogTyp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.ComboBox_FogTyp);
            this.Panel1.Controls.Add(this.LabelX20);
            this.Panel1.Controls.Add(this.SwitchButton_EnableFog);
            this.Panel1.Controls.Add(this.ColorPickerButton_FogColor);
            this.Panel1.Name = "Panel1";
            // 
            // Panel2
            // 
            resources.ApplyResources(this.Panel2, "Panel2");
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.LabelX9);
            this.Panel2.Controls.Add(this.SwitchButton_CenterModel);
            this.Panel2.Name = "Panel2";
            // 
            // Panel3
            // 
            resources.ApplyResources(this.Panel3, "Panel3");
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.Controls.Add(this.LabelX4);
            this.Panel3.Controls.Add(this.SwitchButton_EnableReduceVertices);
            this.Panel3.Name = "Panel3";
            // 
            // Panel4
            // 
            resources.ApplyResources(this.Panel4, "Panel4");
            this.Panel4.BackColor = System.Drawing.Color.Transparent;
            this.Panel4.Controls.Add(this.LabelX8);
            this.Panel4.Controls.Add(this.SwitchButton_OptimizeTransChecks);
            this.Panel4.Controls.Add(this.LabelX3);
            this.Panel4.Controls.Add(this.SwitchButton_ResizeTextures);
            this.Panel4.Name = "Panel4";
            // 
            // LabelX8
            // 
            // 
            // 
            // 
            this.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX8, "LabelX8");
            this.LabelX8.Name = "LabelX8";
            this.LabelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_OptimizeTransChecks
            // 
            // 
            // 
            // 
            this.SwitchButton_OptimizeTransChecks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_OptimizeTransChecks.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_OptimizeTransChecks, "SwitchButton_OptimizeTransChecks");
            this.SwitchButton_OptimizeTransChecks.Name = "SwitchButton_OptimizeTransChecks";
            this.SwitchButton_OptimizeTransChecks.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_OptimizeTransChecks.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_OptimizeTransChecks.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_OptimizeTransChecks.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_OptimizeTransChecks.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_OptimizeTransChecks.SwitchWidth = 15;
            this.SwitchButton_OptimizeTransChecks.Value = true;
            this.SwitchButton_OptimizeTransChecks.ValueObject = "Y";
            // 
            // Panel5
            // 
            resources.ApplyResources(this.Panel5, "Panel5");
            this.Panel5.BackColor = System.Drawing.Color.Transparent;
            this.Panel5.Controls.Add(this.ButtonX1);
            this.Panel5.Controls.Add(this.ColorPickerButton_ShadingDiffuse);
            this.Panel5.Controls.Add(this.LabelX5);
            this.Panel5.Controls.Add(this.LabelX6);
            this.Panel5.Controls.Add(this.ColorPickerButton_ShadingAmbient);
            this.Panel5.Controls.Add(this.LabelX7);
            this.Panel5.Name = "Panel5";
            // 
            // ButtonX1
            // 
            this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX1.AutoExpandOnClick = true;
            this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX1.FocusCuesEnabled = false;
            resources.ApplyResources(this.ButtonX1, "ButtonX1");
            this.ButtonX1.Name = "ButtonX1";
            this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_SetupDiffusePosition,
            this.ButtonItem_ResetDiffusePosition});
            // 
            // ButtonItem_SetupDiffusePosition
            // 
            this.ButtonItem_SetupDiffusePosition.BeginGroup = true;
            this.ButtonItem_SetupDiffusePosition.GlobalItem = false;
            this.ButtonItem_SetupDiffusePosition.Name = "ButtonItem_SetupDiffusePosition";
            resources.ApplyResources(this.ButtonItem_SetupDiffusePosition, "ButtonItem_SetupDiffusePosition");
            this.ButtonItem_SetupDiffusePosition.Click += new System.EventHandler(this.ButtonItem_SetupDiffusePosition_Click);
            // 
            // ButtonItem_ResetDiffusePosition
            // 
            this.ButtonItem_ResetDiffusePosition.GlobalItem = false;
            this.ButtonItem_ResetDiffusePosition.Name = "ButtonItem_ResetDiffusePosition";
            resources.ApplyResources(this.ButtonItem_ResetDiffusePosition, "ButtonItem_ResetDiffusePosition");
            this.ButtonItem_ResetDiffusePosition.Visible = false;
            this.ButtonItem_ResetDiffusePosition.Click += new System.EventHandler(this.ButtonItem_ResetDiffusePosition_Click);
            // 
            // Panel6
            // 
            resources.ApplyResources(this.Panel6, "Panel6");
            this.Panel6.BackColor = System.Drawing.Color.Transparent;
            this.Panel6.Controls.Add(this.LabelX16);
            this.Panel6.Controls.Add(this.NUD_Scaling);
            this.Panel6.Name = "Panel6";
            // 
            // Panel7
            // 
            resources.ApplyResources(this.Panel7, "Panel7");
            this.Panel7.BackColor = System.Drawing.Color.Transparent;
            this.Panel7.Controls.Add(this.LabelX10);
            this.Panel7.Controls.Add(this.ComboBoxEx_UpAxis);
            this.Panel7.Name = "Panel7";
            // 
            // Panel8
            // 
            resources.ApplyResources(this.Panel8, "Panel8");
            this.Panel8.BackColor = System.Drawing.Color.Transparent;
            this.Panel8.Controls.Add(this.ButtonX_VisualMapPreview);
            this.Panel8.Controls.Add(this.ButtonX_GraphicsEditor);
            this.Panel8.Name = "Panel8";
            // 
            // Panel9
            // 
            resources.ApplyResources(this.Panel9, "Panel9");
            this.Panel9.BackColor = System.Drawing.Color.Transparent;
            this.Panel9.Controls.Add(this.ButtonX_CollisionMapPreview);
            this.Panel9.Controls.Add(this.Button_ColEditor);
            this.Panel9.Name = "Panel9";
            // 
            // ColorPickerButton_ShadingAmbient
            // 
            this.ColorPickerButton_ShadingAmbient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ColorPickerButton_ShadingAmbient.AutoExpandOnClick = true;
            this.ColorPickerButton_ShadingAmbient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ColorPickerButton_ShadingAmbient.FocusCuesEnabled = false;
            this.ColorPickerButton_ShadingAmbient.Image = ((System.Drawing.Image)(resources.GetObject("ColorPickerButton_ShadingAmbient.Image")));
            resources.ApplyResources(this.ColorPickerButton_ShadingAmbient, "ColorPickerButton_ShadingAmbient");
            this.ColorPickerButton_ShadingAmbient.Name = "ColorPickerButton_ShadingAmbient";
            this.ColorPickerButton_ShadingAmbient.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.ColorPickerButton_ShadingAmbient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ColorPickerButton_FogColor
            // 
            this.ColorPickerButton_FogColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ColorPickerButton_FogColor.AutoExpandOnClick = true;
            this.ColorPickerButton_FogColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ColorPickerButton_FogColor, "ColorPickerButton_FogColor");
            this.ColorPickerButton_FogColor.FocusCuesEnabled = false;
            this.ColorPickerButton_FogColor.Image = ((System.Drawing.Image)(resources.GetObject("ColorPickerButton_FogColor.Image")));
            this.ColorPickerButton_FogColor.Name = "ColorPickerButton_FogColor";
            this.ColorPickerButton_FogColor.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.ColorPickerButton_FogColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ColorPickerButton_ShadingDiffuse
            // 
            this.ColorPickerButton_ShadingDiffuse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ColorPickerButton_ShadingDiffuse.AutoExpandOnClick = true;
            this.ColorPickerButton_ShadingDiffuse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ColorPickerButton_ShadingDiffuse.FocusCuesEnabled = false;
            this.ColorPickerButton_ShadingDiffuse.Image = ((System.Drawing.Image)(resources.GetObject("ColorPickerButton_ShadingDiffuse.Image")));
            resources.ApplyResources(this.ColorPickerButton_ShadingDiffuse, "ColorPickerButton_ShadingDiffuse");
            this.ColorPickerButton_ShadingDiffuse.Name = "ColorPickerButton_ShadingDiffuse";
            this.ColorPickerButton_ShadingDiffuse.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.ColorPickerButton_ShadingDiffuse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ColorPickerButton_ShadingDiffuse.PopupContainerLoad += new System.EventHandler(this.ColorPickerButton_ShadingDiffuse_PopupOpen);
            // 
            // MainModelConverter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel9);
            this.Controls.Add(this.Panel8);
            this.Controls.Add(this.Panel7);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.CheckBoxX_ConvertCollision);
            this.Controls.Add(this.CheckBoxX_ConvertModel);
            this.Controls.Add(this.CircularProgress1);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.LabelX_Colfile);
            this.Controls.Add(this.LabelX_Modelfile);
            this.Controls.Add(this.LabelX2);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.Button_LoadCol);
            this.Controls.Add(this.Button_LoadModel);
            this.Controls.Add(this.Button_ConvertModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainModelConverter";
            this.ShowIcon = false;
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Scaling)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel8.ResumeLayout(false);
            this.Panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevComponents.DotNetBar.Controls.Line Line2;


        private DevComponents.DotNetBar.LabelX LabelX_Colfile;


        private DevComponents.DotNetBar.LabelX LabelX_Modelfile;


        private DevComponents.DotNetBar.LabelX LabelX2;


        private DevComponents.DotNetBar.LabelX LabelX1;


        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_EnableFog;


        private DevComponents.DotNetBar.ButtonX Button_ColEditor;


        private DevComponents.DotNetBar.LabelX LabelX20;


        private DevComponents.DotNetBar.LabelX LabelX16;


        private DevComponents.Editors.DoubleInput NUD_Scaling;


        private DevComponents.DotNetBar.ButtonX Button_LoadCol;


        private DevComponents.DotNetBar.ButtonX Button_LoadModel;


        private DevComponents.DotNetBar.Controls.Line Line3;


        private DevComponents.DotNetBar.ButtonX Button_ConvertModel;


        private DevComponents.DotNetBar.LabelX LabelX4;


        private DevComponents.DotNetBar.Controls.CircularProgress CircularProgress1;


        private DevComponents.DotNetBar.SuperTooltip SuperTooltip1;


        private DevComponents.DotNetBar.LabelX LabelX3;


        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_ResizeTextures;


        private DevComponents.DotNetBar.LabelX LabelX5;


        private DevComponents.DotNetBar.LabelX LabelX6;


        private DevComponents.DotNetBar.LabelX LabelX7;


        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_CenterModel;


        private DevComponents.DotNetBar.LabelX LabelX9;


        private DevComponents.DotNetBar.ButtonX ButtonX_VisualMapPreview;


        private DevComponents.DotNetBar.ButtonX ButtonX_CollisionMapPreview;


        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_EnableReduceVertices;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_UpAxis;


        private DevComponents.DotNetBar.LabelX LabelX10;


        private DevComponents.Editors.ComboItem ComboItem1;


        private DevComponents.Editors.ComboItem ComboItem2;


        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_ConvertModel;


        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_ConvertCollision;


        private DevComponents.DotNetBar.ColorPickerButton ColorPickerButton_ShadingAmbient;


        private DevComponents.DotNetBar.ButtonX ButtonX_GraphicsEditor;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_FogTyp;


        private DevComponents.DotNetBar.ColorPickerButton ColorPickerButton_FogColor;


        private System.Windows.Forms.Panel Panel1;


        private System.Windows.Forms.Panel Panel2;


        private System.Windows.Forms.Panel Panel3;


        private System.Windows.Forms.Panel Panel4;


        private System.Windows.Forms.Panel Panel5;


        private System.Windows.Forms.Panel Panel6;


        private System.Windows.Forms.Panel Panel7;


        private System.Windows.Forms.Panel Panel8;


        private System.Windows.Forms.Panel Panel9;


        private DevComponents.DotNetBar.ColorPickerButton ColorPickerButton_ShadingDiffuse;


        private DevComponents.DotNetBar.LabelX LabelX8;


        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_OptimizeTransChecks;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_SetupDiffusePosition;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_ResetDiffusePosition;


        private DevComponents.DotNetBar.ButtonX ButtonX1;

    }
}