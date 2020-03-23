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
            _Line2 = new DevComponents.DotNetBar.Controls.Line();
            _LabelX_Colfile = new DevComponents.DotNetBar.LabelX();
            _LabelX_Colfile.TextChanged += new EventHandler(LabelX_Colfile_Click);
            _LabelX_Modelfile = new DevComponents.DotNetBar.LabelX();
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_EnableFog = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_EnableFog.ValueChanged += new EventHandler(SwitchButton_EnableFog_ValueChanged);
            _Button_ColEditor = new DevComponents.DotNetBar.ButtonX();
            _Button_ColEditor.Click += new EventHandler(Button_ColEditor_Click);
            _LabelX20 = new DevComponents.DotNetBar.LabelX();
            _LabelX16 = new DevComponents.DotNetBar.LabelX();
            _NUD_Scaling = new DevComponents.Editors.DoubleInput();
            _Button_LoadCol = new DevComponents.DotNetBar.ButtonX();
            _Button_LoadCol.Click += new EventHandler(Button3_LM_LoadCol_Click);
            _Button_LoadModel = new DevComponents.DotNetBar.ButtonX();
            _Button_LoadModel.Click += new EventHandler(Button_LM_LoadModel_Click);
            _Line3 = new DevComponents.DotNetBar.Controls.Line();
            _Button_ConvertModel = new DevComponents.DotNetBar.ButtonX();
            _Button_ConvertModel.Click += new EventHandler(Button_ConvertModel_Click);
            _CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            _SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            _ComboBoxEx_UpAxis = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_UpAxis.SelectedIndexChanged += new EventHandler(ComboBoxEx1_SelectedIndexChanged);
            _ComboItem1 = new DevComponents.Editors.ComboItem();
            _ComboItem2 = new DevComponents.Editors.ComboItem();
            _LabelX9 = new DevComponents.DotNetBar.LabelX();
            _CheckBoxX_ConvertModel = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_ConvertModel.CheckedChanged += new EventHandler(CheckBoxX_ConvertModel_CheckedChanged);
            _CheckBoxX_ConvertCollision = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_ConvertCollision.CheckedChanged += new EventHandler(CheckBoxX_ConvertCollision_CheckedChanged);
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_ResizeTextures = new DevComponents.DotNetBar.Controls.SwitchButton();
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _LabelX6 = new DevComponents.DotNetBar.LabelX();
            _LabelX7 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_CenterModel = new DevComponents.DotNetBar.Controls.SwitchButton();
            _ButtonX_VisualMapPreview = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_VisualMapPreview.Click += new EventHandler(ButtonX1_Click);
            _ButtonX_CollisionMapPreview = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_CollisionMapPreview.Click += new EventHandler(ButtonX2_Click);
            _SwitchButton_EnableReduceVertices = new DevComponents.DotNetBar.Controls.SwitchButton();
            _LabelX10 = new DevComponents.DotNetBar.LabelX();
            _ColorPickerButton_ShadingAmbient = new DevComponents.DotNetBar.ColorPickerButton();
            _ButtonX_GraphicsEditor = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_GraphicsEditor.Click += new EventHandler(ButtonX_GraphicsEditor_Click);
            _ComboBox_FogTyp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ColorPickerButton_FogColor = new DevComponents.DotNetBar.ColorPickerButton();
            _Panel1 = new System.Windows.Forms.Panel();
            _Panel2 = new System.Windows.Forms.Panel();
            _Panel3 = new System.Windows.Forms.Panel();
            _Panel4 = new System.Windows.Forms.Panel();
            _LabelX8 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_OptimizeTransChecks = new DevComponents.DotNetBar.Controls.SwitchButton();
            _Panel5 = new System.Windows.Forms.Panel();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonItem_SetupDiffusePosition = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_SetupDiffusePosition.Click += new EventHandler(ButtonItem_SetupDiffusePosition_Click);
            _ButtonItem_ResetDiffusePosition = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ResetDiffusePosition.Click += new EventHandler(ButtonItem_ResetDiffusePosition_Click);
            _ColorPickerButton_ShadingDiffuse = new DevComponents.DotNetBar.ColorPickerButton();
            _ColorPickerButton_ShadingDiffuse.PopupContainerLoad += new EventHandler(ColorPickerButton_ShadingDiffuse_PopupOpen);
            _Panel6 = new System.Windows.Forms.Panel();
            _Panel7 = new System.Windows.Forms.Panel();
            _Panel8 = new System.Windows.Forms.Panel();
            _Panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)_NUD_Scaling).BeginInit();
            _Panel1.SuspendLayout();
            _Panel2.SuspendLayout();
            _Panel3.SuspendLayout();
            _Panel4.SuspendLayout();
            _Panel5.SuspendLayout();
            _Panel6.SuspendLayout();
            _Panel7.SuspendLayout();
            _Panel8.SuspendLayout();
            _Panel9.SuspendLayout();
            SuspendLayout();
            // 
            // Line2
            // 
            resources.ApplyResources(_Line2, "Line2");
            _Line2.ForeColor = System.Drawing.Color.Gainsboro;
            _Line2.Name = "Line2";
            // 
            // LabelX_Colfile
            // 
            // 
            // 
            // 
            _LabelX_Colfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX_Colfile, "LabelX_Colfile");
            _LabelX_Colfile.Name = "LabelX_Colfile";
            _LabelX_Colfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX_Modelfile
            // 
            // 
            // 
            // 
            _LabelX_Modelfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX_Modelfile, "LabelX_Modelfile");
            _LabelX_Modelfile.Name = "LabelX_Modelfile";
            _LabelX_Modelfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX2, "LabelX2");
            _LabelX2.Name = "LabelX2";
            _LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX1, "LabelX1");
            _LabelX1.Name = "LabelX1";
            _LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX4
            // 
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX4, "LabelX4");
            _LabelX4.Name = "LabelX4";
            _LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _SuperTooltip1.SetSuperTooltip(_LabelX4, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("LabelX4.SuperTooltip"), resources.GetString("LabelX4.SuperTooltip1"), resources.GetString("LabelX4.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("LabelX4.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("LabelX4.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ToInteger(resources.GetObject("LabelX4.SuperTooltip5")), Conversions.ToBoolean(resources.GetObject("LabelX4.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("LabelX4.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("LabelX4.SuperTooltip8")));
            // 
            // SwitchButton_EnableFog
            // 
            // 
            // 
            // 
            _SwitchButton_EnableFog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_EnableFog.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_EnableFog, "SwitchButton_EnableFog");
            _SwitchButton_EnableFog.Name = "SwitchButton_EnableFog";
            _SwitchButton_EnableFog.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_EnableFog.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_EnableFog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_EnableFog.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_EnableFog.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_EnableFog.SwitchWidth = 15;
            // 
            // Button_ColEditor
            // 
            _Button_ColEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _Button_ColEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_Button_ColEditor, "Button_ColEditor");
            _Button_ColEditor.FocusCuesEnabled = false;
            _Button_ColEditor.Name = "Button_ColEditor";
            _Button_ColEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX20
            // 
            // 
            // 
            // 
            _LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX20, "LabelX20");
            _LabelX20.Name = "LabelX20";
            _LabelX20.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX16
            // 
            // 
            // 
            // 
            _LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX16, "LabelX16");
            _LabelX16.Name = "LabelX16";
            _LabelX16.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // NUD_Scaling
            // 
            // 
            // 
            // 
            _NUD_Scaling.BackgroundStyle.Class = "DateTimeInputBackground";
            _NUD_Scaling.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _NUD_Scaling.Increment = 1.0D;
            _NUD_Scaling.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            resources.ApplyResources(_NUD_Scaling, "NUD_Scaling");
            _NUD_Scaling.MaxValue = 1.0E+15D;
            _NUD_Scaling.MinValue = 1.0E-32D;
            _NUD_Scaling.Name = "NUD_Scaling";
            _NUD_Scaling.ShowUpDown = true;
            _SuperTooltip1.SetSuperTooltip(_NUD_Scaling, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("NUD_Scaling.SuperTooltip"), resources.GetString("NUD_Scaling.SuperTooltip1"), resources.GetString("NUD_Scaling.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("NUD_Scaling.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("NUD_Scaling.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ToInteger(resources.GetObject("NUD_Scaling.SuperTooltip5")), Conversions.ToBoolean(resources.GetObject("NUD_Scaling.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("NUD_Scaling.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("NUD_Scaling.SuperTooltip8")));
            _NUD_Scaling.Value = 500.0D;
            // 
            // Button_LoadCol
            // 
            _Button_LoadCol.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(_Button_LoadCol, "Button_LoadCol");
            _Button_LoadCol.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_LoadCol.FocusCuesEnabled = false;
            _Button_LoadCol.Name = "Button_LoadCol";
            _Button_LoadCol.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_Button_LoadCol, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("Button_LoadCol.SuperTooltip"), resources.GetString("Button_LoadCol.SuperTooltip1"), resources.GetString("Button_LoadCol.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("Button_LoadCol.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("Button_LoadCol.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ToInteger(resources.GetObject("Button_LoadCol.SuperTooltip5")), Conversions.ToBoolean(resources.GetObject("Button_LoadCol.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("Button_LoadCol.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("Button_LoadCol.SuperTooltip8")));
            _Button_LoadCol.Symbol = "58055";
            _Button_LoadCol.SymbolColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _Button_LoadCol.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LoadCol.SymbolSize = 12.0F;
            // 
            // Button_LoadModel
            // 
            _Button_LoadModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(_Button_LoadModel, "Button_LoadModel");
            _Button_LoadModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_LoadModel.FocusCuesEnabled = false;
            _Button_LoadModel.Name = "Button_LoadModel";
            _Button_LoadModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_Button_LoadModel, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("Button_LoadModel.SuperTooltip"), resources.GetString("Button_LoadModel.SuperTooltip1"), resources.GetString("Button_LoadModel.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("Button_LoadModel.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("Button_LoadModel.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ToInteger(resources.GetObject("Button_LoadModel.SuperTooltip5")), Conversions.ToBoolean(resources.GetObject("Button_LoadModel.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("Button_LoadModel.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("Button_LoadModel.SuperTooltip8")));
            _Button_LoadModel.Symbol = "58055";
            _Button_LoadModel.SymbolColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _Button_LoadModel.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _Button_LoadModel.SymbolSize = 12.0F;
            // 
            // Line3
            // 
            resources.ApplyResources(_Line3, "Line3");
            _Line3.BackColor = System.Drawing.Color.Transparent;
            _Line3.ForeColor = System.Drawing.Color.Gainsboro;
            _Line3.Name = "Line3";
            _Line3.VerticalLine = true;
            // 
            // Button_ConvertModel
            // 
            _Button_ConvertModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(_Button_ConvertModel, "Button_ConvertModel");
            _Button_ConvertModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_ConvertModel.FocusCuesEnabled = false;
            _Button_ConvertModel.Name = "Button_ConvertModel";
            _Button_ConvertModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CircularProgress1
            // 
            resources.ApplyResources(_CircularProgress1, "CircularProgress1");
            _CircularProgress1.AnimationSpeed = 50;
            _CircularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            _CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CircularProgress1.FocusCuesEnabled = false;
            _CircularProgress1.Name = "CircularProgress1";
            _CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            _CircularProgress1.ProgressColor = System.Drawing.Color.SeaGreen;
            _CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // SuperTooltip1
            // 
            resources.ApplyResources(_SuperTooltip1, "SuperTooltip1");
            _SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _SuperTooltip1.MaximumWidth = 200;
            // 
            // ComboBoxEx_UpAxis
            // 
            _ComboBoxEx_UpAxis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            _ComboBoxEx_UpAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _ComboBoxEx_UpAxis.DropDownWidth = 107;
            _ComboBoxEx_UpAxis.ForeColor = System.Drawing.Color.Black;
            _ComboBoxEx_UpAxis.FormattingEnabled = true;
            resources.ApplyResources(_ComboBoxEx_UpAxis, "ComboBoxEx_UpAxis");
            _ComboBoxEx_UpAxis.Items.AddRange(new object[] { _ComboItem1, _ComboItem2 });
            _ComboBoxEx_UpAxis.Name = "ComboBoxEx_UpAxis";
            _ComboBoxEx_UpAxis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ComboBoxEx_UpAxis, new DevComponents.DotNetBar.SuperTooltipInfo(resources.GetString("ComboBoxEx_UpAxis.SuperTooltip"), resources.GetString("ComboBoxEx_UpAxis.SuperTooltip1"), resources.GetString("ComboBoxEx_UpAxis.SuperTooltip2"), (System.Drawing.Image)resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip3"), (System.Drawing.Image)resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip4"), (DevComponents.DotNetBar.eTooltipColor)Conversions.ToInteger(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip5")), Conversions.ToBoolean(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip6")), Conversions.ToBoolean(resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip7")), (System.Drawing.Size)resources.GetObject("ComboBoxEx_UpAxis.SuperTooltip8")));
            // 
            // ComboItem1
            // 
            resources.ApplyResources(_ComboItem1, "ComboItem1");
            // 
            // ComboItem2
            // 
            resources.ApplyResources(_ComboItem2, "ComboItem2");
            // 
            // LabelX9
            // 
            // 
            // 
            // 
            _LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX9, "LabelX9");
            _LabelX9.Name = "LabelX9";
            _LabelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // CheckBoxX_ConvertModel
            // 
            // 
            // 
            // 
            _CheckBoxX_ConvertModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_ConvertModel.Checked = true;
            _CheckBoxX_ConvertModel.CheckState = System.Windows.Forms.CheckState.Checked;
            _CheckBoxX_ConvertModel.CheckValue = "Y";
            _CheckBoxX_ConvertModel.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX_ConvertModel, "CheckBoxX_ConvertModel");
            _CheckBoxX_ConvertModel.Name = "CheckBoxX_ConvertModel";
            _CheckBoxX_ConvertModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // CheckBoxX_ConvertCollision
            // 
            // 
            // 
            // 
            _CheckBoxX_ConvertCollision.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_ConvertCollision.Checked = true;
            _CheckBoxX_ConvertCollision.CheckState = System.Windows.Forms.CheckState.Checked;
            _CheckBoxX_ConvertCollision.CheckValue = "Y";
            _CheckBoxX_ConvertCollision.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX_ConvertCollision, "CheckBoxX_ConvertCollision");
            _CheckBoxX_ConvertCollision.Name = "CheckBoxX_ConvertCollision";
            _CheckBoxX_ConvertCollision.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX3, "LabelX3");
            _LabelX3.Name = "LabelX3";
            _LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_ResizeTextures
            // 
            // 
            // 
            // 
            _SwitchButton_ResizeTextures.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_ResizeTextures.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_ResizeTextures, "SwitchButton_ResizeTextures");
            _SwitchButton_ResizeTextures.Name = "SwitchButton_ResizeTextures";
            _SwitchButton_ResizeTextures.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_ResizeTextures.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_ResizeTextures.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_ResizeTextures.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_ResizeTextures.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_ResizeTextures.SwitchWidth = 15;
            _SwitchButton_ResizeTextures.Value = true;
            _SwitchButton_ResizeTextures.ValueObject = "Y";
            // 
            // LabelX5
            // 
            // 
            // 
            // 
            _LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX5, "LabelX5");
            _LabelX5.Name = "LabelX5";
            _LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX6
            // 
            // 
            // 
            // 
            _LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX6, "LabelX6");
            _LabelX6.Name = "LabelX6";
            _LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // LabelX7
            // 
            // 
            // 
            // 
            _LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX7, "LabelX7");
            _LabelX7.Name = "LabelX7";
            _LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_CenterModel
            // 
            // 
            // 
            // 
            _SwitchButton_CenterModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_CenterModel.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_CenterModel, "SwitchButton_CenterModel");
            _SwitchButton_CenterModel.Name = "SwitchButton_CenterModel";
            _SwitchButton_CenterModel.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_CenterModel.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_CenterModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_CenterModel.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_CenterModel.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_CenterModel.SwitchWidth = 15;
            // 
            // ButtonX_VisualMapPreview
            // 
            _ButtonX_VisualMapPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX_VisualMapPreview.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_ButtonX_VisualMapPreview, "ButtonX_VisualMapPreview");
            _ButtonX_VisualMapPreview.FocusCuesEnabled = false;
            _ButtonX_VisualMapPreview.Name = "ButtonX_VisualMapPreview";
            _ButtonX_VisualMapPreview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_CollisionMapPreview
            // 
            _ButtonX_CollisionMapPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX_CollisionMapPreview.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_ButtonX_CollisionMapPreview, "ButtonX_CollisionMapPreview");
            _ButtonX_CollisionMapPreview.FocusCuesEnabled = false;
            _ButtonX_CollisionMapPreview.Name = "ButtonX_CollisionMapPreview";
            _ButtonX_CollisionMapPreview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SwitchButton_EnableReduceVertices
            // 
            // 
            // 
            // 
            _SwitchButton_EnableReduceVertices.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_EnableReduceVertices.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_EnableReduceVertices, "SwitchButton_EnableReduceVertices");
            _SwitchButton_EnableReduceVertices.Name = "SwitchButton_EnableReduceVertices";
            _SwitchButton_EnableReduceVertices.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_EnableReduceVertices.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_EnableReduceVertices.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_EnableReduceVertices.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_EnableReduceVertices.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_EnableReduceVertices.SwitchWidth = 15;
            _SwitchButton_EnableReduceVertices.Value = true;
            _SwitchButton_EnableReduceVertices.ValueObject = "Y";
            // 
            // LabelX10
            // 
            // 
            // 
            // 
            _LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX10, "LabelX10");
            _LabelX10.Name = "LabelX10";
            _LabelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // ColorPickerButton_ShadingAmbient
            // 
            _ColorPickerButton_ShadingAmbient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ColorPickerButton_ShadingAmbient.AutoExpandOnClick = true;
            _ColorPickerButton_ShadingAmbient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ColorPickerButton_ShadingAmbient.FocusCuesEnabled = false;
            _ColorPickerButton_ShadingAmbient.Image = (System.Drawing.Image)resources.GetObject("ColorPickerButton_ShadingAmbient.Image");
            resources.ApplyResources(_ColorPickerButton_ShadingAmbient, "ColorPickerButton_ShadingAmbient");
            _ColorPickerButton_ShadingAmbient.Name = "ColorPickerButton_ShadingAmbient";
            _ColorPickerButton_ShadingAmbient.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            _ColorPickerButton_ShadingAmbient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_GraphicsEditor
            // 
            _ButtonX_GraphicsEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX_GraphicsEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_ButtonX_GraphicsEditor, "ButtonX_GraphicsEditor");
            _ButtonX_GraphicsEditor.FocusCuesEnabled = false;
            _ButtonX_GraphicsEditor.Name = "ButtonX_GraphicsEditor";
            _ButtonX_GraphicsEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_FogTyp
            // 
            _ComboBox_FogTyp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            _ComboBox_FogTyp.DropDownHeight = 150;
            _ComboBox_FogTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(_ComboBox_FogTyp, "ComboBox_FogTyp");
            _ComboBox_FogTyp.ForeColor = System.Drawing.Color.Black;
            _ComboBox_FogTyp.FormattingEnabled = true;
            _ComboBox_FogTyp.Items.AddRange(new object[] { resources.GetString("ComboBox_FogTyp.Items"), resources.GetString("ComboBox_FogTyp.Items1"), resources.GetString("ComboBox_FogTyp.Items2"), resources.GetString("ComboBox_FogTyp.Items3"), resources.GetString("ComboBox_FogTyp.Items4"), resources.GetString("ComboBox_FogTyp.Items5"), resources.GetString("ComboBox_FogTyp.Items6"), resources.GetString("ComboBox_FogTyp.Items7"), resources.GetString("ComboBox_FogTyp.Items8") });
            _ComboBox_FogTyp.Name = "ComboBox_FogTyp";
            _ComboBox_FogTyp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ColorPickerButton_FogColor
            // 
            _ColorPickerButton_FogColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ColorPickerButton_FogColor.AutoExpandOnClick = true;
            _ColorPickerButton_FogColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(_ColorPickerButton_FogColor, "ColorPickerButton_FogColor");
            _ColorPickerButton_FogColor.FocusCuesEnabled = false;
            _ColorPickerButton_FogColor.Image = (System.Drawing.Image)resources.GetObject("ColorPickerButton_FogColor.Image");
            _ColorPickerButton_FogColor.Name = "ColorPickerButton_FogColor";
            _ColorPickerButton_FogColor.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            _ColorPickerButton_FogColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.BackColor = System.Drawing.Color.Transparent;
            _Panel1.Controls.Add(_ComboBox_FogTyp);
            _Panel1.Controls.Add(_LabelX20);
            _Panel1.Controls.Add(_SwitchButton_EnableFog);
            _Panel1.Controls.Add(_ColorPickerButton_FogColor);
            _Panel1.Name = "Panel1";
            // 
            // Panel2
            // 
            resources.ApplyResources(_Panel2, "Panel2");
            _Panel2.BackColor = System.Drawing.Color.Transparent;
            _Panel2.Controls.Add(_LabelX9);
            _Panel2.Controls.Add(_SwitchButton_CenterModel);
            _Panel2.Name = "Panel2";
            // 
            // Panel3
            // 
            resources.ApplyResources(_Panel3, "Panel3");
            _Panel3.BackColor = System.Drawing.Color.Transparent;
            _Panel3.Controls.Add(_LabelX4);
            _Panel3.Controls.Add(_SwitchButton_EnableReduceVertices);
            _Panel3.Name = "Panel3";
            // 
            // Panel4
            // 
            resources.ApplyResources(_Panel4, "Panel4");
            _Panel4.BackColor = System.Drawing.Color.Transparent;
            _Panel4.Controls.Add(_LabelX8);
            _Panel4.Controls.Add(_SwitchButton_OptimizeTransChecks);
            _Panel4.Controls.Add(_LabelX3);
            _Panel4.Controls.Add(_SwitchButton_ResizeTextures);
            _Panel4.Name = "Panel4";
            // 
            // LabelX8
            // 
            // 
            // 
            // 
            _LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX8, "LabelX8");
            _LabelX8.Name = "LabelX8";
            _LabelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // SwitchButton_OptimizeTransChecks
            // 
            // 
            // 
            // 
            _SwitchButton_OptimizeTransChecks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_OptimizeTransChecks.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_OptimizeTransChecks, "SwitchButton_OptimizeTransChecks");
            _SwitchButton_OptimizeTransChecks.Name = "SwitchButton_OptimizeTransChecks";
            _SwitchButton_OptimizeTransChecks.OnBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_OptimizeTransChecks.OnTextColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_OptimizeTransChecks.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_OptimizeTransChecks.SwitchBackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_OptimizeTransChecks.SwitchBorderColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_OptimizeTransChecks.SwitchWidth = 15;
            _SwitchButton_OptimizeTransChecks.Value = true;
            _SwitchButton_OptimizeTransChecks.ValueObject = "Y";
            // 
            // Panel5
            // 
            resources.ApplyResources(_Panel5, "Panel5");
            _Panel5.BackColor = System.Drawing.Color.Transparent;
            _Panel5.Controls.Add(_ButtonX1);
            _Panel5.Controls.Add(_ColorPickerButton_ShadingDiffuse);
            _Panel5.Controls.Add(_LabelX5);
            _Panel5.Controls.Add(_LabelX6);
            _Panel5.Controls.Add(_ColorPickerButton_ShadingAmbient);
            _Panel5.Controls.Add(_LabelX7);
            _Panel5.Name = "Panel5";
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX1.AutoExpandOnClick = true;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.FocusCuesEnabled = false;
            resources.ApplyResources(_ButtonX1, "ButtonX1");
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_SetupDiffusePosition, _ButtonItem_ResetDiffusePosition });
            // 
            // ButtonItem_SetupDiffusePosition
            // 
            _ButtonItem_SetupDiffusePosition.BeginGroup = true;
            _ButtonItem_SetupDiffusePosition.GlobalItem = false;
            _ButtonItem_SetupDiffusePosition.Name = "ButtonItem_SetupDiffusePosition";
            resources.ApplyResources(_ButtonItem_SetupDiffusePosition, "ButtonItem_SetupDiffusePosition");
            // 
            // ButtonItem_ResetDiffusePosition
            // 
            _ButtonItem_ResetDiffusePosition.GlobalItem = false;
            _ButtonItem_ResetDiffusePosition.Name = "ButtonItem_ResetDiffusePosition";
            resources.ApplyResources(_ButtonItem_ResetDiffusePosition, "ButtonItem_ResetDiffusePosition");
            _ButtonItem_ResetDiffusePosition.Visible = false;
            // 
            // ColorPickerButton_ShadingDiffuse
            // 
            _ColorPickerButton_ShadingDiffuse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ColorPickerButton_ShadingDiffuse.AutoExpandOnClick = true;
            _ColorPickerButton_ShadingDiffuse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ColorPickerButton_ShadingDiffuse.FocusCuesEnabled = false;
            _ColorPickerButton_ShadingDiffuse.Image = (System.Drawing.Image)resources.GetObject("ColorPickerButton_ShadingDiffuse.Image");
            resources.ApplyResources(_ColorPickerButton_ShadingDiffuse, "ColorPickerButton_ShadingDiffuse");
            _ColorPickerButton_ShadingDiffuse.Name = "ColorPickerButton_ShadingDiffuse";
            _ColorPickerButton_ShadingDiffuse.SelectedColorImageRectangle = new System.Drawing.Rectangle(2, 2, 12, 12);
            _ColorPickerButton_ShadingDiffuse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel6
            // 
            resources.ApplyResources(_Panel6, "Panel6");
            _Panel6.BackColor = System.Drawing.Color.Transparent;
            _Panel6.Controls.Add(_LabelX16);
            _Panel6.Controls.Add(_NUD_Scaling);
            _Panel6.Name = "Panel6";
            // 
            // Panel7
            // 
            resources.ApplyResources(_Panel7, "Panel7");
            _Panel7.BackColor = System.Drawing.Color.Transparent;
            _Panel7.Controls.Add(_LabelX10);
            _Panel7.Controls.Add(_ComboBoxEx_UpAxis);
            _Panel7.Name = "Panel7";
            // 
            // Panel8
            // 
            resources.ApplyResources(_Panel8, "Panel8");
            _Panel8.BackColor = System.Drawing.Color.Transparent;
            _Panel8.Controls.Add(_ButtonX_VisualMapPreview);
            _Panel8.Controls.Add(_ButtonX_GraphicsEditor);
            _Panel8.Name = "Panel8";
            // 
            // Panel9
            // 
            resources.ApplyResources(_Panel9, "Panel9");
            _Panel9.BackColor = System.Drawing.Color.Transparent;
            _Panel9.Controls.Add(_ButtonX_CollisionMapPreview);
            _Panel9.Controls.Add(_Button_ColEditor);
            _Panel9.Name = "Panel9";
            // 
            // MainModelConverter
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(_Panel1);
            Controls.Add(_Panel9);
            Controls.Add(_Panel8);
            Controls.Add(_Panel7);
            Controls.Add(_Panel6);
            Controls.Add(_Panel5);
            Controls.Add(_Panel4);
            Controls.Add(_Panel3);
            Controls.Add(_Panel2);
            Controls.Add(_CheckBoxX_ConvertCollision);
            Controls.Add(_CheckBoxX_ConvertModel);
            Controls.Add(_CircularProgress1);
            Controls.Add(_Line3);
            Controls.Add(_Line2);
            Controls.Add(_LabelX_Colfile);
            Controls.Add(_LabelX_Modelfile);
            Controls.Add(_LabelX2);
            Controls.Add(_LabelX1);
            Controls.Add(_Button_LoadCol);
            Controls.Add(_Button_LoadModel);
            Controls.Add(_Button_ConvertModel);
            DoubleBuffered = true;
            EnableGlass = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainModelConverter";
            ShowIcon = false;
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_NUD_Scaling).EndInit();
            _Panel1.ResumeLayout(false);
            _Panel2.ResumeLayout(false);
            _Panel3.ResumeLayout(false);
            _Panel4.ResumeLayout(false);
            _Panel5.ResumeLayout(false);
            _Panel6.ResumeLayout(false);
            _Panel7.ResumeLayout(false);
            _Panel8.ResumeLayout(false);
            _Panel9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private DevComponents.DotNetBar.Controls.Line _Line2;

        internal DevComponents.DotNetBar.Controls.Line Line2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Line2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Line2 != null)
                {
                }

                _Line2 = value;
                if (_Line2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Colfile;

        internal DevComponents.DotNetBar.LabelX LabelX_Colfile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Colfile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Colfile != null)
                {
                    _LabelX_Colfile.TextChanged -= LabelX_Colfile_Click;
                }

                _LabelX_Colfile = value;
                if (_LabelX_Colfile != null)
                {
                    _LabelX_Colfile.TextChanged += LabelX_Colfile_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Modelfile;

        internal DevComponents.DotNetBar.LabelX LabelX_Modelfile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Modelfile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Modelfile != null)
                {
                }

                _LabelX_Modelfile = value;
                if (_LabelX_Modelfile != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX2;

        internal DevComponents.DotNetBar.LabelX LabelX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX2 != null)
                {
                }

                _LabelX2 = value;
                if (_LabelX2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX1;

        internal DevComponents.DotNetBar.LabelX LabelX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX1 != null)
                {
                }

                _LabelX1 = value;
                if (_LabelX1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_EnableFog;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_EnableFog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_EnableFog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_EnableFog != null)
                {
                    _SwitchButton_EnableFog.ValueChanged -= SwitchButton_EnableFog_ValueChanged;
                }

                _SwitchButton_EnableFog = value;
                if (_SwitchButton_EnableFog != null)
                {
                    _SwitchButton_EnableFog.ValueChanged += SwitchButton_EnableFog_ValueChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_ColEditor;

        internal DevComponents.DotNetBar.ButtonX Button_ColEditor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_ColEditor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_ColEditor != null)
                {
                    _Button_ColEditor.Click -= Button_ColEditor_Click;
                }

                _Button_ColEditor = value;
                if (_Button_ColEditor != null)
                {
                    _Button_ColEditor.Click += Button_ColEditor_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX20;

        internal DevComponents.DotNetBar.LabelX LabelX20
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX20;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX20 != null)
                {
                }

                _LabelX20 = value;
                if (_LabelX20 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX16;

        internal DevComponents.DotNetBar.LabelX LabelX16
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX16;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX16 != null)
                {
                }

                _LabelX16 = value;
                if (_LabelX16 != null)
                {
                }
            }
        }

        private DevComponents.Editors.DoubleInput _NUD_Scaling;

        internal DevComponents.Editors.DoubleInput NUD_Scaling
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NUD_Scaling;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NUD_Scaling != null)
                {
                }

                _NUD_Scaling = value;
                if (_NUD_Scaling != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_LoadCol;

        internal DevComponents.DotNetBar.ButtonX Button_LoadCol
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LoadCol;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LoadCol != null)
                {
                    _Button_LoadCol.Click -= Button3_LM_LoadCol_Click;
                }

                _Button_LoadCol = value;
                if (_Button_LoadCol != null)
                {
                    _Button_LoadCol.Click += Button3_LM_LoadCol_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_LoadModel;

        internal DevComponents.DotNetBar.ButtonX Button_LoadModel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_LoadModel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_LoadModel != null)
                {
                    _Button_LoadModel.Click -= Button_LM_LoadModel_Click;
                }

                _Button_LoadModel = value;
                if (_Button_LoadModel != null)
                {
                    _Button_LoadModel.Click += Button_LM_LoadModel_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.Line _Line3;

        internal DevComponents.DotNetBar.Controls.Line Line3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Line3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Line3 != null)
                {
                }

                _Line3 = value;
                if (_Line3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_ConvertModel;

        internal DevComponents.DotNetBar.ButtonX Button_ConvertModel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_ConvertModel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_ConvertModel != null)
                {
                    _Button_ConvertModel.Click -= Button_ConvertModel_Click;
                }

                _Button_ConvertModel = value;
                if (_Button_ConvertModel != null)
                {
                    _Button_ConvertModel.Click += Button_ConvertModel_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX4;

        internal DevComponents.DotNetBar.LabelX LabelX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX4 != null)
                {
                }

                _LabelX4 = value;
                if (_LabelX4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CircularProgress _CircularProgress1;

        internal DevComponents.DotNetBar.Controls.CircularProgress CircularProgress1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CircularProgress1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CircularProgress1 != null)
                {
                }

                _CircularProgress1 = value;
                if (_CircularProgress1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.SuperTooltip _SuperTooltip1;

        internal DevComponents.DotNetBar.SuperTooltip SuperTooltip1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTooltip1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTooltip1 != null)
                {
                }

                _SuperTooltip1 = value;
                if (_SuperTooltip1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX3;

        internal DevComponents.DotNetBar.LabelX LabelX3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX3 != null)
                {
                }

                _LabelX3 = value;
                if (_LabelX3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_ResizeTextures;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_ResizeTextures
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_ResizeTextures;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_ResizeTextures != null)
                {
                }

                _SwitchButton_ResizeTextures = value;
                if (_SwitchButton_ResizeTextures != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX5;

        internal DevComponents.DotNetBar.LabelX LabelX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX5 != null)
                {
                }

                _LabelX5 = value;
                if (_LabelX5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX6;

        internal DevComponents.DotNetBar.LabelX LabelX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX6 != null)
                {
                }

                _LabelX6 = value;
                if (_LabelX6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX7;

        internal DevComponents.DotNetBar.LabelX LabelX7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX7 != null)
                {
                }

                _LabelX7 = value;
                if (_LabelX7 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_CenterModel;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_CenterModel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_CenterModel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_CenterModel != null)
                {
                }

                _SwitchButton_CenterModel = value;
                if (_SwitchButton_CenterModel != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX9;

        internal DevComponents.DotNetBar.LabelX LabelX9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX9 != null)
                {
                }

                _LabelX9 = value;
                if (_LabelX9 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_VisualMapPreview;

        internal DevComponents.DotNetBar.ButtonX ButtonX_VisualMapPreview
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_VisualMapPreview;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_VisualMapPreview != null)
                {
                    _ButtonX_VisualMapPreview.Click -= ButtonX1_Click;
                }

                _ButtonX_VisualMapPreview = value;
                if (_ButtonX_VisualMapPreview != null)
                {
                    _ButtonX_VisualMapPreview.Click += ButtonX1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_CollisionMapPreview;

        internal DevComponents.DotNetBar.ButtonX ButtonX_CollisionMapPreview
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_CollisionMapPreview;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_CollisionMapPreview != null)
                {
                    _ButtonX_CollisionMapPreview.Click -= ButtonX2_Click;
                }

                _ButtonX_CollisionMapPreview = value;
                if (_ButtonX_CollisionMapPreview != null)
                {
                    _ButtonX_CollisionMapPreview.Click += ButtonX2_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_EnableReduceVertices;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_EnableReduceVertices
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_EnableReduceVertices;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_EnableReduceVertices != null)
                {
                }

                _SwitchButton_EnableReduceVertices = value;
                if (_SwitchButton_EnableReduceVertices != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_UpAxis;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_UpAxis
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_UpAxis;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_UpAxis != null)
                {
                    _ComboBoxEx_UpAxis.SelectedIndexChanged -= ComboBoxEx1_SelectedIndexChanged;
                }

                _ComboBoxEx_UpAxis = value;
                if (_ComboBoxEx_UpAxis != null)
                {
                    _ComboBoxEx_UpAxis.SelectedIndexChanged += ComboBoxEx1_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX10;

        internal DevComponents.DotNetBar.LabelX LabelX10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX10 != null)
                {
                }

                _LabelX10 = value;
                if (_LabelX10 != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem1;

        internal DevComponents.Editors.ComboItem ComboItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem1 != null)
                {
                }

                _ComboItem1 = value;
                if (_ComboItem1 != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem2;

        internal DevComponents.Editors.ComboItem ComboItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem2 != null)
                {
                }

                _ComboItem2 = value;
                if (_ComboItem2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_ConvertModel;

        public DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_ConvertModel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_ConvertModel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_ConvertModel != null)
                {
                    _CheckBoxX_ConvertModel.CheckedChanged -= CheckBoxX_ConvertModel_CheckedChanged;
                }

                _CheckBoxX_ConvertModel = value;
                if (_CheckBoxX_ConvertModel != null)
                {
                    _CheckBoxX_ConvertModel.CheckedChanged += CheckBoxX_ConvertModel_CheckedChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_ConvertCollision;

        public DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_ConvertCollision
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_ConvertCollision;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_ConvertCollision != null)
                {
                    _CheckBoxX_ConvertCollision.CheckedChanged -= CheckBoxX_ConvertCollision_CheckedChanged;
                }

                _CheckBoxX_ConvertCollision = value;
                if (_CheckBoxX_ConvertCollision != null)
                {
                    _CheckBoxX_ConvertCollision.CheckedChanged += CheckBoxX_ConvertCollision_CheckedChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ColorPickerButton _ColorPickerButton_ShadingAmbient;

        internal DevComponents.DotNetBar.ColorPickerButton ColorPickerButton_ShadingAmbient
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColorPickerButton_ShadingAmbient;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColorPickerButton_ShadingAmbient != null)
                {
                }

                _ColorPickerButton_ShadingAmbient = value;
                if (_ColorPickerButton_ShadingAmbient != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_GraphicsEditor;

        internal DevComponents.DotNetBar.ButtonX ButtonX_GraphicsEditor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_GraphicsEditor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_GraphicsEditor != null)
                {
                    _ButtonX_GraphicsEditor.Click -= ButtonX_GraphicsEditor_Click;
                }

                _ButtonX_GraphicsEditor = value;
                if (_ButtonX_GraphicsEditor != null)
                {
                    _ButtonX_GraphicsEditor.Click += ButtonX_GraphicsEditor_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_FogTyp;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_FogTyp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_FogTyp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_FogTyp != null)
                {
                }

                _ComboBox_FogTyp = value;
                if (_ComboBox_FogTyp != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ColorPickerButton _ColorPickerButton_FogColor;

        internal DevComponents.DotNetBar.ColorPickerButton ColorPickerButton_FogColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColorPickerButton_FogColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColorPickerButton_FogColor != null)
                {
                }

                _ColorPickerButton_FogColor = value;
                if (_ColorPickerButton_FogColor != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel1;

        internal System.Windows.Forms.Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel2;

        internal System.Windows.Forms.Panel Panel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel2 != null)
                {
                }

                _Panel2 = value;
                if (_Panel2 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel3;

        internal System.Windows.Forms.Panel Panel3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel3 != null)
                {
                }

                _Panel3 = value;
                if (_Panel3 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel4;

        internal System.Windows.Forms.Panel Panel4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel4 != null)
                {
                }

                _Panel4 = value;
                if (_Panel4 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel5;

        internal System.Windows.Forms.Panel Panel5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel5 != null)
                {
                }

                _Panel5 = value;
                if (_Panel5 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel6;

        internal System.Windows.Forms.Panel Panel6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel6 != null)
                {
                }

                _Panel6 = value;
                if (_Panel6 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel7;

        internal System.Windows.Forms.Panel Panel7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel7 != null)
                {
                }

                _Panel7 = value;
                if (_Panel7 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel8;

        internal System.Windows.Forms.Panel Panel8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel8 != null)
                {
                }

                _Panel8 = value;
                if (_Panel8 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel9;

        internal System.Windows.Forms.Panel Panel9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel9 != null)
                {
                }

                _Panel9 = value;
                if (_Panel9 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ColorPickerButton _ColorPickerButton_ShadingDiffuse;

        internal DevComponents.DotNetBar.ColorPickerButton ColorPickerButton_ShadingDiffuse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColorPickerButton_ShadingDiffuse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColorPickerButton_ShadingDiffuse != null)
                {
                    _ColorPickerButton_ShadingDiffuse.PopupContainerLoad -= ColorPickerButton_ShadingDiffuse_PopupOpen;
                }

                _ColorPickerButton_ShadingDiffuse = value;
                if (_ColorPickerButton_ShadingDiffuse != null)
                {
                    _ColorPickerButton_ShadingDiffuse.PopupContainerLoad += ColorPickerButton_ShadingDiffuse_PopupOpen;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX8;

        internal DevComponents.DotNetBar.LabelX LabelX8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX8 != null)
                {
                }

                _LabelX8 = value;
                if (_LabelX8 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_OptimizeTransChecks;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_OptimizeTransChecks
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_OptimizeTransChecks;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_OptimizeTransChecks != null)
                {
                }

                _SwitchButton_OptimizeTransChecks = value;
                if (_SwitchButton_OptimizeTransChecks != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_SetupDiffusePosition;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_SetupDiffusePosition
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_SetupDiffusePosition;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_SetupDiffusePosition != null)
                {
                    _ButtonItem_SetupDiffusePosition.Click -= ButtonItem_SetupDiffusePosition_Click;
                }

                _ButtonItem_SetupDiffusePosition = value;
                if (_ButtonItem_SetupDiffusePosition != null)
                {
                    _ButtonItem_SetupDiffusePosition.Click += ButtonItem_SetupDiffusePosition_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ResetDiffusePosition;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ResetDiffusePosition
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ResetDiffusePosition;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ResetDiffusePosition != null)
                {
                    _ButtonItem_ResetDiffusePosition.Click -= ButtonItem_ResetDiffusePosition_Click;
                }

                _ButtonItem_ResetDiffusePosition = value;
                if (_ButtonItem_ResetDiffusePosition != null)
                {
                    _ButtonItem_ResetDiffusePosition.Click += ButtonItem_ResetDiffusePosition_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX1;

        internal DevComponents.DotNetBar.ButtonX ButtonX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX1 != null)
                {
                }

                _ButtonX1 = value;
                if (_ButtonX1 != null)
                {
                }
            }
        }
    }
}