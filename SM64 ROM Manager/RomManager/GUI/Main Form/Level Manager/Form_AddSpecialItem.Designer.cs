using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Form_AddSpecialItem : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddSpecialItem));
            _Button_Cancel = new DevComponents.DotNetBar.ButtonX();
            _Button_Cancel.Click += new EventHandler(Button_Okay_Click);
            _Button_Okay = new DevComponents.DotNetBar.ButtonX();
            _Button_Okay.Click += new EventHandler(Button_Okay_Click);
            _GroupBox_Type = new GroupBox();
            _CheckBoxX_Mist = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_Mist.CheckedChangedEx += new DevComponents.DotNetBar.Controls.CheckBoxXChangeEventHandler(CheckBoxX_SpecialBoxType_CheckedChanged);
            _CheckBoxX_ToxicHaze = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_ToxicHaze.CheckedChangedEx += new DevComponents.DotNetBar.Controls.CheckBoxXChangeEventHandler(CheckBoxX_SpecialBoxType_CheckedChanged);
            _CheckBoxX_Water = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_Water.CheckedChangedEx += new DevComponents.DotNetBar.Controls.CheckBoxXChangeEventHandler(CheckBoxX_SpecialBoxType_CheckedChanged);
            _CheckBoxX_Water.CheckedChanged += new EventHandler(CheckBoxX_Water_CheckedChanged);
            _GroupBox_Box = new GroupBox();
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_Alpha = new DevComponents.Editors.IntegerInput();
            _IntegerInput_Alpha.ValueChanged += new EventHandler(IntegerInput1_ValueChanged);
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _ComboBox_WaterType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_WaterType.SelectedIndexChanged += new EventHandler(ComboBox_WaterType_SelectedIndexChanged);
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _Button_SetUpHeight = new DevComponents.DotNetBar.ButtonX();
            _Button_SetUpHeight.Click += new EventHandler(Button_SetUpHeight_Click);
            _LabelX_Height = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_Scale = new DevComponents.Editors.IntegerInput();
            _IntegerInput_Scale.ValueChanged += new EventHandler(IntegerInput_Scale_ValueChanged);
            _Button_SetUpPos2 = new DevComponents.DotNetBar.ButtonX();
            _Button_SetUpPos2.Click += new EventHandler(Button_SetUpPos1_Click);
            _Button_SetUpPos1 = new DevComponents.DotNetBar.ButtonX();
            _Button_SetUpPos1.Click += new EventHandler(Button_SetUpPos1_Click);
            _LabelX_Pos2 = new DevComponents.DotNetBar.LabelX();
            _LabelX_Pos1 = new DevComponents.DotNetBar.LabelX();
            _LabelX59 = new DevComponents.DotNetBar.LabelX();
            _Panel1 = new Panel();
            _GroupBox_Type.SuspendLayout();
            _GroupBox_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Alpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Scale).BeginInit();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Cancel
            // 
            _Button_Cancel.AccessibleRole = AccessibleRole.PushButton;
            _Button_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_Cancel.DialogResult = DialogResult.Cancel;
            _Button_Cancel.FocusCuesEnabled = false;
            _Button_Cancel.Location = new Point(65, 133);
            _Button_Cancel.Name = "Button_Cancel";
            _Button_Cancel.Size = new Size(56, 23);
            _Button_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_Cancel.TabIndex = 103;
            _Button_Cancel.Text = "Cancel";
            // 
            // Button_Okay
            // 
            _Button_Okay.AccessibleRole = AccessibleRole.PushButton;
            _Button_Okay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_Okay.DialogResult = DialogResult.OK;
            _Button_Okay.FocusCuesEnabled = false;
            _Button_Okay.Location = new Point(3, 133);
            _Button_Okay.Name = "Button_Okay";
            _Button_Okay.Size = new Size(56, 23);
            _Button_Okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_Okay.TabIndex = 102;
            _Button_Okay.Text = "Okay";
            // 
            // GroupBox_Type
            // 
            _GroupBox_Type.Controls.Add(_CheckBoxX_Mist);
            _GroupBox_Type.Controls.Add(_CheckBoxX_ToxicHaze);
            _GroupBox_Type.Controls.Add(_CheckBoxX_Water);
            _GroupBox_Type.Location = new Point(3, 3);
            _GroupBox_Type.Name = "GroupBox_Type";
            _GroupBox_Type.Size = new Size(118, 124);
            _GroupBox_Type.TabIndex = 104;
            _GroupBox_Type.TabStop = false;
            _GroupBox_Type.Text = "Type";
            // 
            // CheckBoxX_Mist
            // 
            // 
            // 
            // 
            _CheckBoxX_Mist.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_Mist.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            _CheckBoxX_Mist.FocusCuesEnabled = false;
            _CheckBoxX_Mist.Location = new Point(6, 71);
            _CheckBoxX_Mist.Name = "CheckBoxX_Mist";
            _CheckBoxX_Mist.Size = new Size(106, 20);
            _CheckBoxX_Mist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _CheckBoxX_Mist.TabIndex = 2;
            _CheckBoxX_Mist.Text = "Mist";
            // 
            // CheckBoxX_ToxicHaze
            // 
            // 
            // 
            // 
            _CheckBoxX_ToxicHaze.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_ToxicHaze.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            _CheckBoxX_ToxicHaze.FocusCuesEnabled = false;
            _CheckBoxX_ToxicHaze.Location = new Point(6, 45);
            _CheckBoxX_ToxicHaze.Name = "CheckBoxX_ToxicHaze";
            _CheckBoxX_ToxicHaze.Size = new Size(106, 20);
            _CheckBoxX_ToxicHaze.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _CheckBoxX_ToxicHaze.TabIndex = 1;
            _CheckBoxX_ToxicHaze.Text = "Toxic Haze";
            // 
            // CheckBoxX_Water
            // 
            // 
            // 
            // 
            _CheckBoxX_Water.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_Water.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            _CheckBoxX_Water.FocusCuesEnabled = false;
            _CheckBoxX_Water.Location = new Point(6, 19);
            _CheckBoxX_Water.Name = "CheckBoxX_Water";
            _CheckBoxX_Water.Size = new Size(106, 20);
            _CheckBoxX_Water.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _CheckBoxX_Water.TabIndex = 0;
            _CheckBoxX_Water.Text = "Water";
            // 
            // GroupBox_Box
            // 
            _GroupBox_Box.Controls.Add(_LabelX3);
            _GroupBox_Box.Controls.Add(_IntegerInput_Alpha);
            _GroupBox_Box.Controls.Add(_LabelX2);
            _GroupBox_Box.Controls.Add(_ComboBox_WaterType);
            _GroupBox_Box.Controls.Add(_LabelX1);
            _GroupBox_Box.Controls.Add(_Button_SetUpHeight);
            _GroupBox_Box.Controls.Add(_LabelX_Height);
            _GroupBox_Box.Controls.Add(_IntegerInput_Scale);
            _GroupBox_Box.Controls.Add(_Button_SetUpPos2);
            _GroupBox_Box.Controls.Add(_Button_SetUpPos1);
            _GroupBox_Box.Controls.Add(_LabelX_Pos2);
            _GroupBox_Box.Controls.Add(_LabelX_Pos1);
            _GroupBox_Box.Controls.Add(_LabelX59);
            _GroupBox_Box.Location = new Point(127, 3);
            _GroupBox_Box.Name = "GroupBox_Box";
            _GroupBox_Box.Size = new Size(258, 153);
            _GroupBox_Box.TabIndex = 105;
            _GroupBox_Box.TabStop = false;
            _GroupBox_Box.Text = "Box Settings";
            _GroupBox_Box.Visible = false;
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX3.Location = new Point(123, 121);
            _LabelX3.Name = "LabelX3";
            _LabelX3.Size = new Size(15, 23);
            _LabelX3.TabIndex = 116;
            _LabelX3.Text = "%";
            // 
            // IntegerInput_Alpha
            // 
            // 
            // 
            // 
            _IntegerInput_Alpha.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_Alpha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_Alpha.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_Alpha.Location = new Point(87, 123);
            _IntegerInput_Alpha.MaxValue = 100;
            _IntegerInput_Alpha.MinValue = 0;
            _IntegerInput_Alpha.Name = "IntegerInput_Alpha";
            _IntegerInput_Alpha.Size = new Size(30, 20);
            _IntegerInput_Alpha.TabIndex = 115;
            _IntegerInput_Alpha.Value = 30;
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Location = new Point(6, 123);
            _LabelX2.Name = "LabelX2";
            _LabelX2.Size = new Size(75, 20);
            _LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX2.TabIndex = 114;
            _LabelX2.Text = "Transparence:";
            // 
            // ComboBox_WaterType
            // 
            _ComboBox_WaterType.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_WaterType.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_WaterType.ForeColor = Color.Black;
            _ComboBox_WaterType.FormattingEnabled = true;
            _ComboBox_WaterType.ItemHeight = 15;
            _ComboBox_WaterType.Items.AddRange(new object[] { "Default Water", "Invisible Water", "JRB Water", "Green Water", "Lava Water" });
            _ComboBox_WaterType.Location = new Point(147, 97);
            _ComboBox_WaterType.Name = "ComboBox_WaterType";
            _ComboBox_WaterType.Size = new Size(105, 21);
            _ComboBox_WaterType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ComboBox_WaterType.TabIndex = 111;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Location = new Point(6, 97);
            _LabelX1.Name = "LabelX1";
            _LabelX1.Size = new Size(135, 20);
            _LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX1.TabIndex = 110;
            _LabelX1.Text = "Water Type:";
            // 
            // Button_SetUpHeight
            // 
            _Button_SetUpHeight.AccessibleRole = AccessibleRole.PushButton;
            _Button_SetUpHeight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_SetUpHeight.FocusCuesEnabled = false;
            _Button_SetUpHeight.Location = new Point(202, 70);
            _Button_SetUpHeight.Name = "Button_SetUpHeight";
            _Button_SetUpHeight.Size = new Size(50, 22);
            _Button_SetUpHeight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_SetUpHeight.TabIndex = 109;
            _Button_SetUpHeight.Text = "Set up";
            // 
            // LabelX_Height
            // 
            // 
            // 
            // 
            _LabelX_Height.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Height.Location = new Point(120, 71);
            _LabelX_Height.Name = "LabelX_Height";
            _LabelX_Height.Size = new Size(76, 20);
            _LabelX_Height.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX_Height.TabIndex = 108;
            _LabelX_Height.Text = "Height: 0";
            // 
            // IntegerInput_Scale
            // 
            // 
            // 
            // 
            _IntegerInput_Scale.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_Scale.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_Scale.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_Scale.Location = new Point(44, 71);
            _IntegerInput_Scale.MaxValue = 8192;
            _IntegerInput_Scale.MinValue = -8192;
            _IntegerInput_Scale.Name = "IntegerInput_Scale";
            _IntegerInput_Scale.ShowUpDown = true;
            _IntegerInput_Scale.Size = new Size(53, 20);
            _IntegerInput_Scale.TabIndex = 103;
            // 
            // Button_SetUpPos2
            // 
            _Button_SetUpPos2.AccessibleRole = AccessibleRole.PushButton;
            _Button_SetUpPos2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_SetUpPos2.FocusCuesEnabled = false;
            _Button_SetUpPos2.Location = new Point(202, 44);
            _Button_SetUpPos2.Name = "Button_SetUpPos2";
            _Button_SetUpPos2.Size = new Size(50, 22);
            _Button_SetUpPos2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_SetUpPos2.TabIndex = 102;
            _Button_SetUpPos2.Text = "Set up";
            // 
            // Button_SetUpPos1
            // 
            _Button_SetUpPos1.AccessibleRole = AccessibleRole.PushButton;
            _Button_SetUpPos1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_SetUpPos1.FocusCuesEnabled = false;
            _Button_SetUpPos1.Location = new Point(202, 18);
            _Button_SetUpPos1.Name = "Button_SetUpPos1";
            _Button_SetUpPos1.Size = new Size(50, 22);
            _Button_SetUpPos1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_SetUpPos1.TabIndex = 101;
            _Button_SetUpPos1.Text = "Set up";
            // 
            // LabelX_Pos2
            // 
            // 
            // 
            // 
            _LabelX_Pos2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Pos2.Location = new Point(6, 45);
            _LabelX_Pos2.Name = "LabelX_Pos2";
            _LabelX_Pos2.Size = new Size(190, 20);
            _LabelX_Pos2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX_Pos2.TabIndex = 100;
            _LabelX_Pos2.Text = "Edge 2: 0, 0";
            // 
            // LabelX_Pos1
            // 
            // 
            // 
            // 
            _LabelX_Pos1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Pos1.Location = new Point(6, 19);
            _LabelX_Pos1.Name = "LabelX_Pos1";
            _LabelX_Pos1.Size = new Size(190, 20);
            _LabelX_Pos1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX_Pos1.TabIndex = 98;
            _LabelX_Pos1.Text = "Edge 1: 0, 0";
            // 
            // LabelX59
            // 
            // 
            // 
            // 
            _LabelX59.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX59.Location = new Point(6, 71);
            _LabelX59.Name = "LabelX59";
            _LabelX59.Size = new Size(32, 20);
            _LabelX59.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX59.TabIndex = 95;
            _LabelX59.Text = "Scale:";
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_GroupBox_Type);
            _Panel1.Controls.Add(_GroupBox_Box);
            _Panel1.Controls.Add(_Button_Cancel);
            _Panel1.Controls.Add(_Button_Okay);
            _Panel1.Dock = DockStyle.Fill;
            _Panel1.Location = new Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(389, 159);
            _Panel1.TabIndex = 106;
            // 
            // Form_AddSpecialItem
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 159);
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_AddSpecialItem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Special Item";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _GroupBox_Type.ResumeLayout(false);
            _GroupBox_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Alpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Scale).EndInit();
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.ButtonX _Button_Cancel;

        internal DevComponents.DotNetBar.ButtonX Button_Cancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_Cancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_Cancel != null)
                {
                    _Button_Cancel.Click -= Button_Okay_Click;
                }

                _Button_Cancel = value;
                if (_Button_Cancel != null)
                {
                    _Button_Cancel.Click += Button_Okay_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_Okay;

        internal DevComponents.DotNetBar.ButtonX Button_Okay
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_Okay;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_Okay != null)
                {
                    _Button_Okay.Click -= Button_Okay_Click;
                }

                _Button_Okay = value;
                if (_Button_Okay != null)
                {
                    _Button_Okay.Click += Button_Okay_Click;
                }
            }
        }

        private GroupBox _GroupBox_Type;

        internal GroupBox GroupBox_Type
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox_Type;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox_Type != null)
                {
                }

                _GroupBox_Type = value;
                if (_GroupBox_Type != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_Water;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_Water
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_Water;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_Water != null)
                {
                    _CheckBoxX_Water.CheckedChangedEx -= CheckBoxX_SpecialBoxType_CheckedChanged;
                    _CheckBoxX_Water.CheckedChanged -= CheckBoxX_Water_CheckedChanged;
                }

                _CheckBoxX_Water = value;
                if (_CheckBoxX_Water != null)
                {
                    _CheckBoxX_Water.CheckedChangedEx += CheckBoxX_SpecialBoxType_CheckedChanged;
                    _CheckBoxX_Water.CheckedChanged += CheckBoxX_Water_CheckedChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_Mist;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_Mist
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_Mist;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_Mist != null)
                {
                    _CheckBoxX_Mist.CheckedChangedEx -= CheckBoxX_SpecialBoxType_CheckedChanged;
                }

                _CheckBoxX_Mist = value;
                if (_CheckBoxX_Mist != null)
                {
                    _CheckBoxX_Mist.CheckedChangedEx += CheckBoxX_SpecialBoxType_CheckedChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_ToxicHaze;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_ToxicHaze
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_ToxicHaze;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_ToxicHaze != null)
                {
                    _CheckBoxX_ToxicHaze.CheckedChangedEx -= CheckBoxX_SpecialBoxType_CheckedChanged;
                }

                _CheckBoxX_ToxicHaze = value;
                if (_CheckBoxX_ToxicHaze != null)
                {
                    _CheckBoxX_ToxicHaze.CheckedChangedEx += CheckBoxX_SpecialBoxType_CheckedChanged;
                }
            }
        }

        private GroupBox _GroupBox_Box;

        internal GroupBox GroupBox_Box
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox_Box;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox_Box != null)
                {
                }

                _GroupBox_Box = value;
                if (_GroupBox_Box != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX59;

        internal DevComponents.DotNetBar.LabelX LabelX59
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX59;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX59 != null)
                {
                }

                _LabelX59 = value;
                if (_LabelX59 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Pos2;

        internal DevComponents.DotNetBar.LabelX LabelX_Pos2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Pos2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Pos2 != null)
                {
                }

                _LabelX_Pos2 = value;
                if (_LabelX_Pos2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Pos1;

        internal DevComponents.DotNetBar.LabelX LabelX_Pos1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Pos1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Pos1 != null)
                {
                }

                _LabelX_Pos1 = value;
                if (_LabelX_Pos1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_SetUpPos2;

        internal DevComponents.DotNetBar.ButtonX Button_SetUpPos2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_SetUpPos2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_SetUpPos2 != null)
                {
                    _Button_SetUpPos2.Click -= Button_SetUpPos1_Click;
                }

                _Button_SetUpPos2 = value;
                if (_Button_SetUpPos2 != null)
                {
                    _Button_SetUpPos2.Click += Button_SetUpPos1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_SetUpPos1;

        internal DevComponents.DotNetBar.ButtonX Button_SetUpPos1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_SetUpPos1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_SetUpPos1 != null)
                {
                    _Button_SetUpPos1.Click -= Button_SetUpPos1_Click;
                }

                _Button_SetUpPos1 = value;
                if (_Button_SetUpPos1 != null)
                {
                    _Button_SetUpPos1.Click += Button_SetUpPos1_Click;
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_Scale;

        internal DevComponents.Editors.IntegerInput IntegerInput_Scale
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_Scale;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_Scale != null)
                {
                    _IntegerInput_Scale.ValueChanged -= IntegerInput_Scale_ValueChanged;
                }

                _IntegerInput_Scale = value;
                if (_IntegerInput_Scale != null)
                {
                    _IntegerInput_Scale.ValueChanged += IntegerInput_Scale_ValueChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_SetUpHeight;

        internal DevComponents.DotNetBar.ButtonX Button_SetUpHeight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_SetUpHeight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_SetUpHeight != null)
                {
                    _Button_SetUpHeight.Click -= Button_SetUpHeight_Click;
                }

                _Button_SetUpHeight = value;
                if (_Button_SetUpHeight != null)
                {
                    _Button_SetUpHeight.Click += Button_SetUpHeight_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Height;

        internal DevComponents.DotNetBar.LabelX LabelX_Height
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Height;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Height != null)
                {
                }

                _LabelX_Height = value;
                if (_LabelX_Height != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_WaterType;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_WaterType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_WaterType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_WaterType != null)
                {
                    _ComboBox_WaterType.SelectedIndexChanged -= ComboBox_WaterType_SelectedIndexChanged;
                }

                _ComboBox_WaterType = value;
                if (_ComboBox_WaterType != null)
                {
                    _ComboBox_WaterType.SelectedIndexChanged += ComboBox_WaterType_SelectedIndexChanged;
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

        private DevComponents.Editors.IntegerInput _IntegerInput_Alpha;

        internal DevComponents.Editors.IntegerInput IntegerInput_Alpha
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_Alpha;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_Alpha != null)
                {
                    _IntegerInput_Alpha.ValueChanged -= IntegerInput1_ValueChanged;
                }

                _IntegerInput_Alpha = value;
                if (_IntegerInput_Alpha != null)
                {
                    _IntegerInput_Alpha.ValueChanged += IntegerInput1_ValueChanged;
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
    }
}