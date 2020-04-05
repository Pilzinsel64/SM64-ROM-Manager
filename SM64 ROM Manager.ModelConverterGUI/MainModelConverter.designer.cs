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
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainModelConverter));
            Line2 = new DevComponents.DotNetBar.Controls.Line();
            LabelX_Colfile = new DevComponents.DotNetBar.LabelX();
            LabelX_Colfile.TextChanged += new EventHandler(LabelX_Colfile_Click);
            LabelX_Modelfile = new DevComponents.DotNetBar.LabelX();
            LabelX2 = new DevComponents.DotNetBar.LabelX();
            LabelX1 = new DevComponents.DotNetBar.LabelX();
            LabelX4 = new DevComponents.DotNetBar.LabelX();
            SwitchButton_EnableFog = new DevComponents.DotNetBar.Controls.SwitchButton();
            SwitchButton_EnableFog.ValueChanged += new EventHandler(SwitchButton_EnableFog_ValueChanged);
            Button_ColEditor = new DevComponents.DotNetBar.ButtonX();
            Button_ColEditor.Click += new EventHandler(Button_ColEditor_Click);
            LabelX20 = new DevComponents.DotNetBar.LabelX();
            LabelX16 = new DevComponents.DotNetBar.LabelX();
            NUD_Scaling = new DevComponents.Editors.DoubleInput();
            Button_LoadCol = new DevComponents.DotNetBar.ButtonX();
            Button_LoadCol.Click += new EventHandler(Button3_LM_LoadCol_Click);
            Button_LoadModel = new DevComponents.DotNetBar.ButtonX();
            Button_LoadModel.Click += new EventHandler(Button_LM_LoadModel_Click);
            Line3 = new DevComponents.DotNetBar.Controls.Line();
            Button_ConvertModel = new DevComponents.DotNetBar.ButtonX();
            Button_ConvertModel.Click += new EventHandler(Button_ConvertModel_Click);
            CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            ComboBoxEx_UpAxis = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ComboBoxEx_UpAxis.SelectedIndexChanged += new EventHandler(ComboBoxEx1_SelectedIndexChanged);
            ComboItem1 = new DevComponents.Editors.ComboItem();
            ComboItem2 = new DevComponents.Editors.ComboItem();
            LabelX9 = new DevComponents.DotNetBar.LabelX();
            CheckBoxX_ConvertModel = new DevComponents.DotNetBar.Controls.CheckBoxX();
            CheckBoxX_ConvertModel.CheckedChanged += new EventHandler(CheckBoxX_ConvertModel_CheckedChanged);
            CheckBoxX_ConvertCollision = new DevComponents.DotNetBar.Controls.CheckBoxX();
            CheckBoxX_ConvertCollision.CheckedChanged += new EventHandler(CheckBoxX_ConvertCollision_CheckedChanged);
            LabelX3 = new DevComponents.DotNetBar.LabelX();
            SwitchButton_ResizeTextures = new DevComponents.DotNetBar.Controls.SwitchButton();
            LabelX5 = new DevComponents.DotNetBar.LabelX();
            LabelX6 = new DevComponents.DotNetBar.LabelX();
            LabelX7 = new DevComponents.DotNetBar.LabelX();
            SwitchButton_CenterModel = new DevComponents.DotNetBar.Controls.SwitchButton();
            ButtonX_VisualMapPreview = new DevComponents.DotNetBar.ButtonX();
            ButtonX_VisualMapPreview.Click += new EventHandler(ButtonX1_Click);
            ButtonX_CollisionMapPreview = new DevComponents.DotNetBar.ButtonX();
            ButtonX_CollisionMapPreview.Click += new EventHandler(ButtonX2_Click);
            SwitchButton_EnableReduceVertices = new DevComponents.DotNetBar.Controls.SwitchButton();
            LabelX10 = new DevComponents.DotNetBar.LabelX();
            ColorPickerButton_ShadingAmbient = new DevComponents.DotNetBar.ColorPickerButton();
            ButtonX_GraphicsEditor = new DevComponents.DotNetBar.ButtonX();
            ButtonX_GraphicsEditor.Click += new EventHandler(ButtonX_GraphicsEditor_Click);
            ComboBox_FogTyp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ColorPickerButton_FogColor = new DevComponents.DotNetBar.ColorPickerButton();
            Panel1 = new System.Windows.Forms.Panel();
            Panel2 = new System.Windows.Forms.Panel();
            Panel3 = new System.Windows.Forms.Panel();
            Panel4 = new System.Windows.Forms.Panel();
            LabelX8 = new DevComponents.DotNetBar.LabelX();
            SwitchButton_OptimizeTransChecks = new DevComponents.DotNetBar.Controls.SwitchButton();
            Panel5 = new System.Windows.Forms.Panel();
            ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            ButtonItem_SetupDiffusePosition = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_SetupDiffusePosition.Click += new EventHandler(ButtonItem_SetupDiffusePosition_Click);
            ButtonItem_ResetDiffusePosition = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_ResetDiffusePosition.Click += new EventHandler(ButtonItem_ResetDiffusePosition_Click);
            ColorPickerButton_ShadingDiffuse = new DevComponents.DotNetBar.ColorPickerButton();
            ColorPickerButton_ShadingDiffuse.PopupContainerLoad += new EventHandler(ColorPickerButton_ShadingDiffuse_PopupOpen);
            Panel6 = new System.Windows.Forms.Panel();
            Panel7 = new System.Windows.Forms.Panel();
            Panel8 = new System.Windows.Forms.Panel();
            Panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)NUD_Scaling).BeginInit();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            Panel3.SuspendLayout();
            Panel4.SuspendLayout();
            Panel5.SuspendLayout();
            Panel6.SuspendLayout();
            Panel7.SuspendLayout();
            Panel8.SuspendLayout();
            Panel9.SuspendLayout();
            SuspendLayout();
            // 
            // Line2
            // 
            resources.ApplyResources(Line2, "Line2");
            Line2.ForeColor = System.Drawing.Color.Gainsboro;
            Line2.Name = "Line2";
            // 
            // LabelX_Colfile
            // 
            // 
            // 
            // 
            LabelX_Colfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX_Colfile, "LabelX_Colfile");
            LabelX_Colfile.Name = "LabelX_Colfile";
            LabelX_Colfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX_Modelfile
            // 
            // 
            // 
            // 
            LabelX_Modelfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX_Modelfile, "LabelX_Modelfile");
            LabelX_Modelfile.Name = "LabelX_Modelfile";
            LabelX_Modelfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX2, "LabelX2");
            LabelX2.Name = "LabelX2";
            LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX1, "LabelX1");
            LabelX1.Name = "LabelX1";
            LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX4
            // 
            // 
            // 
            // 
            LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX4, "LabelX4");
            LabelX4.Name = "LabelX4";
            LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            SuperTooltip1.SetSuperTooltip(LabelX4, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("LabelX4.SuperTooltip"), resources.GetString("LabelX4.SuperTooltip1"), resources.GetString("LabelX4.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("LabelX4.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("LabelX4.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ChangeType(Conversions.ToInteger(resources.GetObject("LabelX4.SuperTooltip5")), typeof(DevComponents.DotNetBar.eTooltipColor)), Conversions.ToBoolean(resources.GetObject("LabelX4.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("LabelX4.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("LabelX4.SuperTooltip8")));
            // 
            // SwitchButton_EnableFog
            // 
            // 
            // 
            // 
            SwitchButton_EnableFog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            SwitchButton_EnableFog.FocusCuesEnabled = false;
            resources.ApplyResources(SwitchButton_EnableFog, "SwitchButton_EnableFog");
            SwitchButton_EnableFog.Name = "SwitchButton_EnableFog";
            SwitchButton_EnableFog.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            SwitchButton_EnableFog.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            SwitchButton_EnableFog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            SwitchButton_EnableFog.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            SwitchButton_EnableFog.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            SwitchButton_EnableFog.SwitchWidth = 15;
            // 
            // Button_ColEditor
            // 
            Button_ColEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            Button_ColEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(Button_ColEditor, "Button_ColEditor");
            Button_ColEditor.FocusCuesEnabled = false;
            Button_ColEditor.Name = "Button_ColEditor";
            Button_ColEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX20
            // 
            // 
            // 
            // 
            LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX20, "LabelX20");
            LabelX20.Name = "LabelX20";
            LabelX20.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX16
            // 
            // 
            // 
            // 
            LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX16, "LabelX16");
            LabelX16.Name = "LabelX16";
            LabelX16.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // NUD_Scaling
            // 
            // 
            // 
            // 
            NUD_Scaling.BackgroundStyle.Class = "DateTimeInputBackground";
            NUD_Scaling.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            NUD_Scaling.Increment = 1.0D;
            NUD_Scaling.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            resources.ApplyResources(NUD_Scaling, "NUD_Scaling");
            NUD_Scaling.MaxValue = 1.0E+15D;
            NUD_Scaling.MinValue = 1.0E-32D;
            NUD_Scaling.Name = "NUD_Scaling";
            NUD_Scaling.ShowUpDown = true;
            SuperTooltip1.SetSuperTooltip(NUD_Scaling, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("NUD_Scaling.SuperTooltip"), resources.GetString("NUD_Scaling.SuperTooltip1"), resources.GetString("NUD_Scaling.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("NUD_Scaling.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("NUD_Scaling.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ChangeType(Conversions.ToInteger(resources.GetObject("NUD_Scaling.SuperTooltip5")), typeof(DevComponents.DotNetBar.eTooltipColor)), Conversions.ToBoolean(resources.GetObject("NUD_Scaling.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("NUD_Scaling.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("NUD_Scaling.SuperTooltip8")));
            NUD_Scaling.Value = 500.0D;
            // 
            // Button_LoadCol
            // 
            Button_LoadCol.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(Button_LoadCol, "Button_LoadCol");
            Button_LoadCol.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            Button_LoadCol.FocusCuesEnabled = false;
            Button_LoadCol.Name = "Button_LoadCol";
            Button_LoadCol.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            SuperTooltip1.SetSuperTooltip(Button_LoadCol, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("Button_LoadCol.SuperTooltip"), resources.GetString("Button_LoadCol.SuperTooltip1"), resources.GetString("Button_LoadCol.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("Button_LoadCol.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("Button_LoadCol.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ChangeType(Conversions.ToInteger(resources.GetObject("Button_LoadCol.SuperTooltip5")), typeof(DevComponents.DotNetBar.eTooltipColor)), Conversions.ToBoolean(resources.GetObject("Button_LoadCol.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("Button_LoadCol.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("Button_LoadCol.SuperTooltip8")));
            Button_LoadCol.Symbol = "58055";
            Button_LoadCol.SymbolColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            Button_LoadCol.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            Button_LoadCol.SymbolSize = 12.0F;
            // 
            // Button_LoadModel
            // 
            Button_LoadModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(Button_LoadModel, "Button_LoadModel");
            Button_LoadModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            Button_LoadModel.FocusCuesEnabled = false;
            Button_LoadModel.Name = "Button_LoadModel";
            Button_LoadModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            SuperTooltip1.SetSuperTooltip(Button_LoadModel, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("Button_LoadModel.SuperTooltip"), resources.GetString("Button_LoadModel.SuperTooltip1"), resources.GetString("Button_LoadModel.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("Button_LoadModel.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("Button_LoadModel.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ChangeType(Conversions.ToInteger(resources.GetObject("Button_LoadModel.SuperTooltip5")), typeof(DevComponents.DotNetBar.eTooltipColor)), Conversions.ToBoolean(resources.GetObject("Button_LoadModel.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("Button_LoadModel.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("Button_LoadModel.SuperTooltip8")));
            Button_LoadModel.Symbol = "58055";
            Button_LoadModel.SymbolColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            Button_LoadModel.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            Button_LoadModel.SymbolSize = 12.0F;
            // 
            // Line3
            // 
            resources.ApplyResources(Line3, "Line3");
            Line3.BackColor = System.Drawing.Color.Transparent;
            Line3.ForeColor = System.Drawing.Color.Gainsboro;
            Line3.Name = "Line3";
            Line3.VerticalLine = true;
            // 
            // Button_ConvertModel
            // 
            Button_ConvertModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(Button_ConvertModel, "Button_ConvertModel");
            Button_ConvertModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            Button_ConvertModel.FocusCuesEnabled = false;
            Button_ConvertModel.Name = "Button_ConvertModel";
            Button_ConvertModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CircularProgress1
            // 
            resources.ApplyResources(CircularProgress1, "CircularProgress1");
            CircularProgress1.AnimationSpeed = 50;
            CircularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            CircularProgress1.FocusCuesEnabled = false;
            CircularProgress1.Name = "CircularProgress1";
            CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            CircularProgress1.ProgressColor = System.Drawing.Color.SeaGreen;
            CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // SuperTooltip1
            // 
            resources.ApplyResources(SuperTooltip1, "SuperTooltip1");
            SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            SuperTooltip1.MaximumWidth = 200;
            // 
            // ComboBoxEx_UpAxis
            // 
            ComboBoxEx_UpAxis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            ComboBoxEx_UpAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboBoxEx_UpAxis.DropDownWidth = 107;
            ComboBoxEx_UpAxis.ForeColor = System.Drawing.Color.Black;
            ComboBoxEx_UpAxis.FormattingEnabled = true;
            resources.ApplyResources(ComboBoxEx_UpAxis, "ComboBoxEx_UpAxis");
            ComboBoxEx_UpAxis.Items.AddRange(new object[] { ComboItem1, ComboItem2 });
            ComboBoxEx_UpAxis.Name = "ComboBoxEx_UpAxis";
            ComboBoxEx_UpAxis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            SuperTooltip1.SetSuperTooltip(ComboBoxEx_UpAxis, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("ComboBoxEx_UpAxis.SuperTooltip"), resources.GetString("ComboBoxEx_UpAxis.SuperTooltip1"), resources.GetString("ComboBoxEx_UpAxis.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ChangeType(Conversions.ToInteger(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip5")), typeof(DevComponents.DotNetBar.eTooltipColor)), Conversions.ToBoolean(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip8")));
            // 
            // ComboItem1
            // 
            resources.ApplyResources(ComboItem1, "ComboItem1");
            // 
            // ComboItem2
            // 
            resources.ApplyResources(ComboItem2, "ComboItem2");
            // 
            // LabelX9
            // 
            // 
            // 
            // 
            LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX9, "LabelX9");
            LabelX9.Name = "LabelX9";
            LabelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // CheckBoxX_ConvertModel
            // 
            // 
            // 
            // 
            CheckBoxX_ConvertModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            CheckBoxX_ConvertModel.Checked = true;
            CheckBoxX_ConvertModel.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckBoxX_ConvertModel.CheckValue = "Y";
            CheckBoxX_ConvertModel.FocusCuesEnabled = false;
            resources.ApplyResources(CheckBoxX_ConvertModel, "CheckBoxX_ConvertModel");
            CheckBoxX_ConvertModel.Name = "CheckBoxX_ConvertModel";
            CheckBoxX_ConvertModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // CheckBoxX_ConvertCollision
            // 
            // 
            // 
            // 
            CheckBoxX_ConvertCollision.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            CheckBoxX_ConvertCollision.Checked = true;
            CheckBoxX_ConvertCollision.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckBoxX_ConvertCollision.CheckValue = "Y";
            CheckBoxX_ConvertCollision.FocusCuesEnabled = false;
            resources.ApplyResources(CheckBoxX_ConvertCollision, "CheckBoxX_ConvertCollision");
            CheckBoxX_ConvertCollision.Name = "CheckBoxX_ConvertCollision";
            CheckBoxX_ConvertCollision.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX3, "LabelX3");
            LabelX3.Name = "LabelX3";
            LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_ResizeTextures
            // 
            // 
            // 
            // 
            SwitchButton_ResizeTextures.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            SwitchButton_ResizeTextures.FocusCuesEnabled = false;
            resources.ApplyResources(SwitchButton_ResizeTextures, "SwitchButton_ResizeTextures");
            SwitchButton_ResizeTextures.Name = "SwitchButton_ResizeTextures";
            SwitchButton_ResizeTextures.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            SwitchButton_ResizeTextures.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            SwitchButton_ResizeTextures.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            SwitchButton_ResizeTextures.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            SwitchButton_ResizeTextures.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            SwitchButton_ResizeTextures.SwitchWidth = 15;
            SwitchButton_ResizeTextures.Value = true;
            SwitchButton_ResizeTextures.ValueObject = "Y";
            // 
            // LabelX5
            // 
            // 
            // 
            // 
            LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX5, "LabelX5");
            LabelX5.Name = "LabelX5";
            LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX6
            // 
            // 
            // 
            // 
            LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX6, "LabelX6");
            LabelX6.Name = "LabelX6";
            LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX7
            // 
            // 
            // 
            // 
            LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX7, "LabelX7");
            LabelX7.Name = "LabelX7";
            LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_CenterModel
            // 
            // 
            // 
            // 
            SwitchButton_CenterModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            SwitchButton_CenterModel.FocusCuesEnabled = false;
            resources.ApplyResources(SwitchButton_CenterModel, "SwitchButton_CenterModel");
            SwitchButton_CenterModel.Name = "SwitchButton_CenterModel";
            SwitchButton_CenterModel.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            SwitchButton_CenterModel.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            SwitchButton_CenterModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            SwitchButton_CenterModel.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            SwitchButton_CenterModel.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            SwitchButton_CenterModel.SwitchWidth = 15;
            // 
            // ButtonX_VisualMapPreview
            // 
            ButtonX_VisualMapPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            ButtonX_VisualMapPreview.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(ButtonX_VisualMapPreview, "ButtonX_VisualMapPreview");
            ButtonX_VisualMapPreview.FocusCuesEnabled = false;
            ButtonX_VisualMapPreview.Name = "ButtonX_VisualMapPreview";
            ButtonX_VisualMapPreview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_CollisionMapPreview
            // 
            ButtonX_CollisionMapPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            ButtonX_CollisionMapPreview.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(ButtonX_CollisionMapPreview, "ButtonX_CollisionMapPreview");
            ButtonX_CollisionMapPreview.FocusCuesEnabled = false;
            ButtonX_CollisionMapPreview.Name = "ButtonX_CollisionMapPreview";
            ButtonX_CollisionMapPreview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_EnableReduceVertices
            // 
            // 
            // 
            // 
            SwitchButton_EnableReduceVertices.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            SwitchButton_EnableReduceVertices.FocusCuesEnabled = false;
            resources.ApplyResources(SwitchButton_EnableReduceVertices, "SwitchButton_EnableReduceVertices");
            SwitchButton_EnableReduceVertices.Name = "SwitchButton_EnableReduceVertices";
            SwitchButton_EnableReduceVertices.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            SwitchButton_EnableReduceVertices.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            SwitchButton_EnableReduceVertices.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            SwitchButton_EnableReduceVertices.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            SwitchButton_EnableReduceVertices.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            SwitchButton_EnableReduceVertices.SwitchWidth = 15;
            SwitchButton_EnableReduceVertices.Value = true;
            SwitchButton_EnableReduceVertices.ValueObject = "Y";
            // 
            // LabelX10
            // 
            // 
            // 
            // 
            LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX10, "LabelX10");
            LabelX10.Name = "LabelX10";
            LabelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ColorPickerButton_ShadingAmbient
            // 
            ColorPickerButton_ShadingAmbient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            ColorPickerButton_ShadingAmbient.AutoExpandOnClick = true;
            ColorPickerButton_ShadingAmbient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ColorPickerButton_ShadingAmbient.FocusCuesEnabled = false;
            ColorPickerButton_ShadingAmbient.Image = (System.Drawing.Image)resources.GetObject("ColorPickerButton_ShadingAmbient.Image");
            resources.ApplyResources(ColorPickerButton_ShadingAmbient, "ColorPickerButton_ShadingAmbient");
            ColorPickerButton_ShadingAmbient.Name = "ColorPickerButton_ShadingAmbient";
            ColorPickerButton_ShadingAmbient.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            ColorPickerButton_ShadingAmbient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_GraphicsEditor
            // 
            ButtonX_GraphicsEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            ButtonX_GraphicsEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(ButtonX_GraphicsEditor, "ButtonX_GraphicsEditor");
            ButtonX_GraphicsEditor.FocusCuesEnabled = false;
            ButtonX_GraphicsEditor.Name = "ButtonX_GraphicsEditor";
            ButtonX_GraphicsEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_FogTyp
            // 
            ComboBox_FogTyp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            ComboBox_FogTyp.DropDownHeight = 150;
            ComboBox_FogTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(ComboBox_FogTyp, "ComboBox_FogTyp");
            ComboBox_FogTyp.ForeColor = System.Drawing.Color.Black;
            ComboBox_FogTyp.FormattingEnabled = true;
            ComboBox_FogTyp.Items.AddRange(new object[] { resources.GetString("ComboBox_FogTyp.Items"), resources.GetString("ComboBox_FogTyp.Items1"), resources.GetString("ComboBox_FogTyp.Items2"), resources.GetString("ComboBox_FogTyp.Items3"), resources.GetString("ComboBox_FogTyp.Items4"), resources.GetString("ComboBox_FogTyp.Items5"), resources.GetString("ComboBox_FogTyp.Items6"), resources.GetString("ComboBox_FogTyp.Items7"), resources.GetString("ComboBox_FogTyp.Items8") });
            ComboBox_FogTyp.Name = "ComboBox_FogTyp";
            ComboBox_FogTyp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ColorPickerButton_FogColor
            // 
            ColorPickerButton_FogColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            ColorPickerButton_FogColor.AutoExpandOnClick = true;
            ColorPickerButton_FogColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(ColorPickerButton_FogColor, "ColorPickerButton_FogColor");
            ColorPickerButton_FogColor.FocusCuesEnabled = false;
            ColorPickerButton_FogColor.Image = (System.Drawing.Image)resources.GetObject("ColorPickerButton_FogColor.Image");
            ColorPickerButton_FogColor.Name = "ColorPickerButton_FogColor";
            ColorPickerButton_FogColor.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            ColorPickerButton_FogColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            resources.ApplyResources(Panel1, "Panel1");
            Panel1.BackColor = System.Drawing.Color.Transparent;
            Panel1.Controls.Add(ComboBox_FogTyp);
            Panel1.Controls.Add(LabelX20);
            Panel1.Controls.Add(SwitchButton_EnableFog);
            Panel1.Controls.Add(ColorPickerButton_FogColor);
            Panel1.Name = "Panel1";
            // 
            // Panel2
            // 
            resources.ApplyResources(Panel2, "Panel2");
            Panel2.BackColor = System.Drawing.Color.Transparent;
            Panel2.Controls.Add(LabelX9);
            Panel2.Controls.Add(SwitchButton_CenterModel);
            Panel2.Name = "Panel2";
            // 
            // Panel3
            // 
            resources.ApplyResources(Panel3, "Panel3");
            Panel3.BackColor = System.Drawing.Color.Transparent;
            Panel3.Controls.Add(LabelX4);
            Panel3.Controls.Add(SwitchButton_EnableReduceVertices);
            Panel3.Name = "Panel3";
            // 
            // Panel4
            // 
            resources.ApplyResources(Panel4, "Panel4");
            Panel4.BackColor = System.Drawing.Color.Transparent;
            Panel4.Controls.Add(LabelX8);
            Panel4.Controls.Add(SwitchButton_OptimizeTransChecks);
            Panel4.Controls.Add(LabelX3);
            Panel4.Controls.Add(SwitchButton_ResizeTextures);
            Panel4.Name = "Panel4";
            // 
            // LabelX8
            // 
            // 
            // 
            // 
            LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX8, "LabelX8");
            LabelX8.Name = "LabelX8";
            LabelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_OptimizeTransChecks
            // 
            // 
            // 
            // 
            SwitchButton_OptimizeTransChecks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            SwitchButton_OptimizeTransChecks.FocusCuesEnabled = false;
            resources.ApplyResources(SwitchButton_OptimizeTransChecks, "SwitchButton_OptimizeTransChecks");
            SwitchButton_OptimizeTransChecks.Name = "SwitchButton_OptimizeTransChecks";
            SwitchButton_OptimizeTransChecks.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            SwitchButton_OptimizeTransChecks.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            SwitchButton_OptimizeTransChecks.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            SwitchButton_OptimizeTransChecks.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            SwitchButton_OptimizeTransChecks.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            SwitchButton_OptimizeTransChecks.SwitchWidth = 15;
            SwitchButton_OptimizeTransChecks.Value = true;
            SwitchButton_OptimizeTransChecks.ValueObject = "Y";
            // 
            // Panel5
            // 
            resources.ApplyResources(Panel5, "Panel5");
            Panel5.BackColor = System.Drawing.Color.Transparent;
            Panel5.Controls.Add(ButtonX1);
            Panel5.Controls.Add(ColorPickerButton_ShadingDiffuse);
            Panel5.Controls.Add(LabelX5);
            Panel5.Controls.Add(LabelX6);
            Panel5.Controls.Add(ColorPickerButton_ShadingAmbient);
            Panel5.Controls.Add(LabelX7);
            Panel5.Name = "Panel5";
            // 
            // ButtonX1
            // 
            ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            ButtonX1.AutoExpandOnClick = true;
            ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX1.FocusCuesEnabled = false;
            resources.ApplyResources(ButtonX1, "ButtonX1");
            ButtonX1.Name = "ButtonX1";
            ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ButtonX1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { ButtonItem_SetupDiffusePosition, ButtonItem_ResetDiffusePosition });
            // 
            // ButtonItem_SetupDiffusePosition
            // 
            ButtonItem_SetupDiffusePosition.BeginGroup = true;
            ButtonItem_SetupDiffusePosition.GlobalItem = false;
            ButtonItem_SetupDiffusePosition.Name = "ButtonItem_SetupDiffusePosition";
            resources.ApplyResources(ButtonItem_SetupDiffusePosition, "ButtonItem_SetupDiffusePosition");
            // 
            // ButtonItem_ResetDiffusePosition
            // 
            ButtonItem_ResetDiffusePosition.GlobalItem = false;
            ButtonItem_ResetDiffusePosition.Name = "ButtonItem_ResetDiffusePosition";
            resources.ApplyResources(ButtonItem_ResetDiffusePosition, "ButtonItem_ResetDiffusePosition");
            ButtonItem_ResetDiffusePosition.Visible = false;
            // 
            // ColorPickerButton_ShadingDiffuse
            // 
            ColorPickerButton_ShadingDiffuse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            ColorPickerButton_ShadingDiffuse.AutoExpandOnClick = true;
            ColorPickerButton_ShadingDiffuse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ColorPickerButton_ShadingDiffuse.FocusCuesEnabled = false;
            ColorPickerButton_ShadingDiffuse.Image = (System.Drawing.Image)resources.GetObject("ColorPickerButton_ShadingDiffuse.Image");
            resources.ApplyResources(ColorPickerButton_ShadingDiffuse, "ColorPickerButton_ShadingDiffuse");
            ColorPickerButton_ShadingDiffuse.Name = "ColorPickerButton_ShadingDiffuse";
            ColorPickerButton_ShadingDiffuse.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            ColorPickerButton_ShadingDiffuse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel6
            // 
            resources.ApplyResources(Panel6, "Panel6");
            Panel6.BackColor = System.Drawing.Color.Transparent;
            Panel6.Controls.Add(LabelX16);
            Panel6.Controls.Add(NUD_Scaling);
            Panel6.Name = "Panel6";
            // 
            // Panel7
            // 
            resources.ApplyResources(Panel7, "Panel7");
            Panel7.BackColor = System.Drawing.Color.Transparent;
            Panel7.Controls.Add(LabelX10);
            Panel7.Controls.Add(ComboBoxEx_UpAxis);
            Panel7.Name = "Panel7";
            // 
            // Panel8
            // 
            resources.ApplyResources(Panel8, "Panel8");
            Panel8.BackColor = System.Drawing.Color.Transparent;
            Panel8.Controls.Add(ButtonX_VisualMapPreview);
            Panel8.Controls.Add(ButtonX_GraphicsEditor);
            Panel8.Name = "Panel8";
            // 
            // Panel9
            // 
            resources.ApplyResources(Panel9, "Panel9");
            Panel9.BackColor = System.Drawing.Color.Transparent;
            Panel9.Controls.Add(ButtonX_CollisionMapPreview);
            Panel9.Controls.Add(Button_ColEditor);
            Panel9.Name = "Panel9";
            // 
            // MainModelConverter
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(Panel1);
            Controls.Add(Panel9);
            Controls.Add(Panel8);
            Controls.Add(Panel7);
            Controls.Add(Panel6);
            Controls.Add(Panel5);
            Controls.Add(Panel4);
            Controls.Add(Panel3);
            Controls.Add(Panel2);
            Controls.Add(CheckBoxX_ConvertCollision);
            Controls.Add(CheckBoxX_ConvertModel);
            Controls.Add(CircularProgress1);
            Controls.Add(Line3);
            Controls.Add(Line2);
            Controls.Add(LabelX_Colfile);
            Controls.Add(LabelX_Modelfile);
            Controls.Add(LabelX2);
            Controls.Add(LabelX1);
            Controls.Add(Button_LoadCol);
            Controls.Add(Button_LoadModel);
            Controls.Add(Button_ConvertModel);
            DoubleBuffered = true;
            EnableGlass = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainModelConverter";
            ShowIcon = false;
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)NUD_Scaling).EndInit();
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel6.ResumeLayout(false);
            Panel7.ResumeLayout(false);
            Panel8.ResumeLayout(false);
            Panel9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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