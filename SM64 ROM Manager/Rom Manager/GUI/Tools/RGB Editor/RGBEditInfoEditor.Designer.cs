using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class RGBEditInfoEditor : DevComponents.DotNetBar.OfficeForm
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
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(RGBEditInfoEditor));
            _Panel1 = new Panel();
            _ButtonX_Okay = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            _SwitchButton_Alpha = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_Alpha.ValueChanged += new EventHandler(SwitchButton_Alpha_ValueChanged);
            _SwitchButton_Dark = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_Dark.ValueChanged += new EventHandler(SwitchButton_Dark_ValueChanged);
            _SwitchButton_Light = new DevComponents.DotNetBar.Controls.SwitchButton();
            _SwitchButton_Light.ValueChanged += new EventHandler(SwitchButton_Light_ValueChanged);
            _SwitchButton_DarkMult = new DevComponents.DotNetBar.Controls.SwitchButton();
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_Alpha = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_Dark = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_LightMult = new DevComponents.DotNetBar.Controls.SwitchButton();
            _TextBoxX_Light = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            _SuperValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            _RegularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            _ErrorProvider1 = new ErrorProvider(components);
            _Highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            _Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_ErrorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.Controls.Add(_ButtonX_Okay);
            _Panel1.Controls.Add(_ButtonX_Cancel);
            _Panel1.Controls.Add(_SwitchButton_Alpha);
            _Panel1.Controls.Add(_SwitchButton_Dark);
            _Panel1.Controls.Add(_SwitchButton_Light);
            _Panel1.Controls.Add(_SwitchButton_DarkMult);
            _Panel1.Controls.Add(_LabelX3);
            _Panel1.Controls.Add(_TextBoxX_Alpha);
            _Panel1.Controls.Add(_LabelX2);
            _Panel1.Controls.Add(_TextBoxX_Dark);
            _Panel1.Controls.Add(_LabelX1);
            _Panel1.Controls.Add(_SwitchButton_LightMult);
            _Panel1.Controls.Add(_TextBoxX_Light);
            _Panel1.Controls.Add(_TextBoxX_Name);
            _Panel1.Dock = DockStyle.Fill;
            _Panel1.Location = new Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(284, 140);
            _Panel1.TabIndex = 1;
            // 
            // ButtonX_Okay
            // 
            _ButtonX_Okay.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Okay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _ButtonX_Okay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Okay.DialogResult = DialogResult.OK;
            _ButtonX_Okay.FocusCuesEnabled = false;
            _ButtonX_Okay.Location = new Point(206, 114);
            _ButtonX_Okay.Name = "ButtonX_Okay";
            _ButtonX_Okay.Size = new Size(75, 23);
            _ButtonX_Okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Okay.TabIndex = 108;
            _ButtonX_Okay.Text = "Okay";
            // 
            // ButtonX_Cancel
            // 
            _ButtonX_Cancel.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Cancel.DialogResult = DialogResult.Cancel;
            _ButtonX_Cancel.FocusCuesEnabled = false;
            _ButtonX_Cancel.Location = new Point(125, 114);
            _ButtonX_Cancel.Name = "ButtonX_Cancel";
            _ButtonX_Cancel.Size = new Size(75, 23);
            _ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Cancel.TabIndex = 107;
            _ButtonX_Cancel.Text = "Cancel";
            // 
            // SwitchButton_Alpha
            // 
            // 
            // 
            // 
            _SwitchButton_Alpha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_Alpha.FocusCuesEnabled = false;
            _SwitchButton_Alpha.Location = new Point(58, 82);
            _SwitchButton_Alpha.Name = "SwitchButton_Alpha";
            _SwitchButton_Alpha.OffText = "No";
            _SwitchButton_Alpha.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_Alpha.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_Alpha.OnText = "Yes";
            _SwitchButton_Alpha.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_Alpha.Size = new Size(57, 20);
            _SwitchButton_Alpha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_Alpha.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_Alpha.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_Alpha.SwitchWidth = 15;
            _SwitchButton_Alpha.TabIndex = 106;
            // 
            // SwitchButton_Dark
            // 
            // 
            // 
            // 
            _SwitchButton_Dark.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_Dark.FocusCuesEnabled = false;
            _SwitchButton_Dark.Location = new Point(58, 56);
            _SwitchButton_Dark.Name = "SwitchButton_Dark";
            _SwitchButton_Dark.OffText = "No";
            _SwitchButton_Dark.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_Dark.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_Dark.OnText = "Yes";
            _SwitchButton_Dark.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_Dark.Size = new Size(57, 20);
            _SwitchButton_Dark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_Dark.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_Dark.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_Dark.SwitchWidth = 15;
            _SwitchButton_Dark.TabIndex = 105;
            // 
            // SwitchButton_Light
            // 
            // 
            // 
            // 
            _SwitchButton_Light.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_Light.FocusCuesEnabled = false;
            _SwitchButton_Light.Location = new Point(58, 30);
            _SwitchButton_Light.Name = "SwitchButton_Light";
            _SwitchButton_Light.OffText = "No";
            _SwitchButton_Light.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_Light.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_Light.OnText = "Yes";
            _SwitchButton_Light.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_Light.Size = new Size(57, 20);
            _SwitchButton_Light.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_Light.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_Light.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_Light.SwitchWidth = 15;
            _SwitchButton_Light.TabIndex = 104;
            // 
            // SwitchButton_DarkMult
            // 
            // 
            // 
            // 
            _SwitchButton_DarkMult.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_DarkMult.FocusCuesEnabled = false;
            _SwitchButton_DarkMult.Location = new Point(121, 56);
            _SwitchButton_DarkMult.Name = "SwitchButton_DarkMult";
            _SwitchButton_DarkMult.OffText = "Single";
            _SwitchButton_DarkMult.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_DarkMult.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_DarkMult.OnText = "Double";
            _SwitchButton_DarkMult.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_DarkMult.Size = new Size(63, 20);
            _SwitchButton_DarkMult.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_DarkMult.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_DarkMult.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_DarkMult.SwitchWidth = 15;
            _SwitchButton_DarkMult.TabIndex = 103;
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX3.Location = new Point(3, 82);
            _LabelX3.Name = "LabelX3";
            _LabelX3.Size = new Size(49, 20);
            _LabelX3.TabIndex = 102;
            _LabelX3.Text = "Alpha:";
            // 
            // TextBoxX_Alpha
            // 
            _TextBoxX_Alpha.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Alpha.Border.Class = "TextBoxBorder";
            _TextBoxX_Alpha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Alpha.DisabledBackColor = Color.White;
            _TextBoxX_Alpha.ForeColor = Color.Black;
            _TextBoxX_Alpha.Location = new Point(190, 82);
            _TextBoxX_Alpha.Name = "TextBoxX_Alpha";
            _TextBoxX_Alpha.PreventEnterBeep = true;
            _TextBoxX_Alpha.Size = new Size(91, 20);
            _TextBoxX_Alpha.TabIndex = 100;
            _TextBoxX_Alpha.TextAlign = HorizontalAlignment.Center;
            _TextBoxX_Alpha.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            _TextBoxX_Alpha.WatermarkText = "Address";
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Location = new Point(3, 56);
            _LabelX2.Name = "LabelX2";
            _LabelX2.Size = new Size(49, 20);
            _LabelX2.TabIndex = 99;
            _LabelX2.Text = "Dark:";
            // 
            // TextBoxX_Dark
            // 
            _TextBoxX_Dark.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Dark.Border.Class = "TextBoxBorder";
            _TextBoxX_Dark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Dark.DisabledBackColor = Color.White;
            _TextBoxX_Dark.ForeColor = Color.Black;
            _TextBoxX_Dark.Location = new Point(190, 56);
            _TextBoxX_Dark.Name = "TextBoxX_Dark";
            _TextBoxX_Dark.PreventEnterBeep = true;
            _TextBoxX_Dark.Size = new Size(91, 20);
            _TextBoxX_Dark.TabIndex = 97;
            _TextBoxX_Dark.TextAlign = HorizontalAlignment.Center;
            _TextBoxX_Dark.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            _TextBoxX_Dark.WatermarkText = "Address";
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Location = new Point(3, 30);
            _LabelX1.Name = "LabelX1";
            _LabelX1.Size = new Size(49, 20);
            _LabelX1.TabIndex = 96;
            _LabelX1.Text = "Light:";
            // 
            // SwitchButton_LightMult
            // 
            // 
            // 
            // 
            _SwitchButton_LightMult.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_LightMult.FocusCuesEnabled = false;
            _SwitchButton_LightMult.Location = new Point(121, 30);
            _SwitchButton_LightMult.Name = "SwitchButton_LightMult";
            _SwitchButton_LightMult.OffText = "Single";
            _SwitchButton_LightMult.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_LightMult.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_LightMult.OnText = "Double";
            _SwitchButton_LightMult.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_LightMult.Size = new Size(63, 20);
            _SwitchButton_LightMult.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_LightMult.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_LightMult.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_LightMult.SwitchWidth = 15;
            _SwitchButton_LightMult.TabIndex = 95;
            // 
            // TextBoxX_Light
            // 
            _TextBoxX_Light.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Light.Border.Class = "TextBoxBorder";
            _TextBoxX_Light.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Light.DisabledBackColor = Color.White;
            _TextBoxX_Light.ForeColor = Color.Black;
            _TextBoxX_Light.Location = new Point(190, 30);
            _TextBoxX_Light.Name = "TextBoxX_Light";
            _TextBoxX_Light.PreventEnterBeep = true;
            _TextBoxX_Light.Size = new Size(91, 20);
            _TextBoxX_Light.TabIndex = 2;
            _TextBoxX_Light.TextAlign = HorizontalAlignment.Center;
            _TextBoxX_Light.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            _TextBoxX_Light.WatermarkText = "Address";
            // 
            // TextBoxX_Name
            // 
            _TextBoxX_Name.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Name.Border.Class = "TextBoxBorder";
            _TextBoxX_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Name.DisabledBackColor = Color.White;
            _TextBoxX_Name.ForeColor = Color.Black;
            _TextBoxX_Name.Location = new Point(3, 4);
            _TextBoxX_Name.Name = "TextBoxX_Name";
            _TextBoxX_Name.PreventEnterBeep = true;
            _TextBoxX_Name.Size = new Size(278, 20);
            _TextBoxX_Name.TabIndex = 1;
            _SuperValidator1.SetValidator1(_TextBoxX_Name, _RegularExpressionValidator1);
            _TextBoxX_Name.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            _TextBoxX_Name.WatermarkText = "Name";
            // 
            // SuperValidator1
            // 
            _SuperValidator1.ContainerControl = this;
            _SuperValidator1.ErrorProvider = _ErrorProvider1;
            _SuperValidator1.Highlighter = _Highlighter1;
            _SuperValidator1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // RegularExpressionValidator1
            // 
            _RegularExpressionValidator1.ErrorMessage = "Your error message here.";
            _RegularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            _RegularExpressionValidator1.ValidationExpression = @"\S{5,5}";
            _RegularExpressionValidator1.ValuePropertyName = "Text";
            // 
            // ErrorProvider1
            // 
            _ErrorProvider1.ContainerControl = this;
            _ErrorProvider1.Icon = (Icon)resources.GetObject("ErrorProvider1.Icon");
            // 
            // Highlighter1
            // 
            _Highlighter1.ContainerControl = this;
            _Highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // RGBEditInfoEditor
            // 
            AcceptButton = _ButtonX_Okay;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _ButtonX_Cancel;
            ClientSize = new Size(284, 140);
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RGBEditInfoEditor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit RGB Info";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_ErrorProvider1).EndInit();
            ResumeLayout(false);
        }

        private Panel _Panel1;

        internal Panel Panel1
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Name;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Name
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Name;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Name != null)
                {
                }

                _TextBoxX_Name = value;
                if (_TextBoxX_Name != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Light;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Light
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Light;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Light != null)
                {
                }

                _TextBoxX_Light = value;
                if (_TextBoxX_Light != null)
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

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_LightMult;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_LightMult
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_LightMult;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_LightMult != null)
                {
                }

                _SwitchButton_LightMult = value;
                if (_SwitchButton_LightMult != null)
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Alpha;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Alpha
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Alpha;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Alpha != null)
                {
                }

                _TextBoxX_Alpha = value;
                if (_TextBoxX_Alpha != null)
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Dark;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Dark
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Dark;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Dark != null)
                {
                }

                _TextBoxX_Dark = value;
                if (_TextBoxX_Dark != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_DarkMult;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_DarkMult
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_DarkMult;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_DarkMult != null)
                {
                }

                _SwitchButton_DarkMult = value;
                if (_SwitchButton_DarkMult != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_Dark;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_Dark
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_Dark;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_Dark != null)
                {
                    _SwitchButton_Dark.ValueChanged -= SwitchButton_Dark_ValueChanged;
                }

                _SwitchButton_Dark = value;
                if (_SwitchButton_Dark != null)
                {
                    _SwitchButton_Dark.ValueChanged += SwitchButton_Dark_ValueChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_Light;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_Light
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_Light;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_Light != null)
                {
                    _SwitchButton_Light.ValueChanged -= SwitchButton_Light_ValueChanged;
                }

                _SwitchButton_Light = value;
                if (_SwitchButton_Light != null)
                {
                    _SwitchButton_Light.ValueChanged += SwitchButton_Light_ValueChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_Alpha;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_Alpha
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_Alpha;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_Alpha != null)
                {
                    _SwitchButton_Alpha.ValueChanged -= SwitchButton_Alpha_ValueChanged;
                }

                _SwitchButton_Alpha = value;
                if (_SwitchButton_Alpha != null)
                {
                    _SwitchButton_Alpha.ValueChanged += SwitchButton_Alpha_ValueChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Okay;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Okay
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Okay;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Okay != null)
                {
                }

                _ButtonX_Okay = value;
                if (_ButtonX_Okay != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Cancel;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Cancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Cancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Cancel != null)
                {
                }

                _ButtonX_Cancel = value;
                if (_ButtonX_Cancel != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Validator.SuperValidator _SuperValidator1;

        internal DevComponents.DotNetBar.Validator.SuperValidator SuperValidator1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperValidator1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperValidator1 != null)
                {
                }

                _SuperValidator1 = value;
                if (_SuperValidator1 != null)
                {
                }
            }
        }

        private ErrorProvider _ErrorProvider1;

        internal ErrorProvider ErrorProvider1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ErrorProvider1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ErrorProvider1 != null)
                {
                }

                _ErrorProvider1 = value;
                if (_ErrorProvider1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Validator.Highlighter _Highlighter1;

        internal DevComponents.DotNetBar.Validator.Highlighter Highlighter1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Highlighter1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Highlighter1 != null)
                {
                }

                _Highlighter1 = value;
                if (_Highlighter1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Validator.RegularExpressionValidator _RegularExpressionValidator1;

        internal DevComponents.DotNetBar.Validator.RegularExpressionValidator RegularExpressionValidator1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RegularExpressionValidator1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RegularExpressionValidator1 != null)
                {
                }

                _RegularExpressionValidator1 = value;
                if (_RegularExpressionValidator1 != null)
                {
                }
            }
        }
    }
}