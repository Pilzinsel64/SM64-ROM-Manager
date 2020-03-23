using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Form_SetUpPoint : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SetUpPoint));
            _Button_Okay = new DevComponents.DotNetBar.ButtonX();
            _IntegerInput_X = new DevComponents.Editors.IntegerInput();
            _LabelX_X = new DevComponents.DotNetBar.LabelX();
            _LabelX_Y = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_Y = new DevComponents.Editors.IntegerInput();
            _LabelX_Z = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_Z = new DevComponents.Editors.IntegerInput();
            _Button_Cancel = new DevComponents.DotNetBar.ButtonX();
            _Panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Z).BeginInit();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Okay
            // 
            _Button_Okay.AccessibleRole = AccessibleRole.PushButton;
            _Button_Okay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_Okay.DialogResult = DialogResult.OK;
            _Button_Okay.FocusCuesEnabled = false;
            _Button_Okay.Location = new Point(3, 81);
            _Button_Okay.Name = "Button_Okay";
            _Button_Okay.Size = new Size(56, 23);
            _Button_Okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_Okay.TabIndex = 0;
            _Button_Okay.Text = "Okay";
            // 
            // IntegerInput_X
            // 
            // 
            // 
            // 
            _IntegerInput_X.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_X.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_X.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_X.Location = new Point(27, 3);
            _IntegerInput_X.MaxValue = 32767;
            _IntegerInput_X.MinValue = -32767;
            _IntegerInput_X.Name = "IntegerInput_X";
            _IntegerInput_X.ShowUpDown = true;
            _IntegerInput_X.Size = new Size(100, 20);
            _IntegerInput_X.TabIndex = 1;
            _IntegerInput_X.Visible = false;
            // 
            // LabelX_X
            // 
            // 
            // 
            // 
            _LabelX_X.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_X.Location = new Point(3, 3);
            _LabelX_X.Name = "LabelX_X";
            _LabelX_X.Size = new Size(18, 20);
            _LabelX_X.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX_X.TabIndex = 91;
            _LabelX_X.Text = "X:";
            _LabelX_X.Visible = false;
            // 
            // LabelX_Y
            // 
            // 
            // 
            // 
            _LabelX_Y.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Y.Location = new Point(3, 29);
            _LabelX_Y.Name = "LabelX_Y";
            _LabelX_Y.Size = new Size(18, 20);
            _LabelX_Y.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX_Y.TabIndex = 93;
            _LabelX_Y.Text = "Y:";
            _LabelX_Y.Visible = false;
            // 
            // IntegerInput_Y
            // 
            // 
            // 
            // 
            _IntegerInput_Y.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_Y.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_Y.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_Y.Location = new Point(27, 29);
            _IntegerInput_Y.MaxValue = 32767;
            _IntegerInput_Y.MinValue = -32767;
            _IntegerInput_Y.Name = "IntegerInput_Y";
            _IntegerInput_Y.ShowUpDown = true;
            _IntegerInput_Y.Size = new Size(100, 20);
            _IntegerInput_Y.TabIndex = 92;
            _IntegerInput_Y.Visible = false;
            // 
            // LabelX_Z
            // 
            // 
            // 
            // 
            _LabelX_Z.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Z.Location = new Point(3, 55);
            _LabelX_Z.Name = "LabelX_Z";
            _LabelX_Z.Size = new Size(18, 20);
            _LabelX_Z.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX_Z.TabIndex = 95;
            _LabelX_Z.Text = "Z:";
            _LabelX_Z.Visible = false;
            // 
            // IntegerInput_Z
            // 
            // 
            // 
            // 
            _IntegerInput_Z.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_Z.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_Z.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_Z.Location = new Point(27, 55);
            _IntegerInput_Z.MaxValue = 32767;
            _IntegerInput_Z.MinValue = -32767;
            _IntegerInput_Z.Name = "IntegerInput_Z";
            _IntegerInput_Z.ShowUpDown = true;
            _IntegerInput_Z.Size = new Size(100, 20);
            _IntegerInput_Z.TabIndex = 94;
            _IntegerInput_Z.Visible = false;
            // 
            // Button_Cancel
            // 
            _Button_Cancel.AccessibleRole = AccessibleRole.PushButton;
            _Button_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_Cancel.DialogResult = DialogResult.Cancel;
            _Button_Cancel.FocusCuesEnabled = false;
            _Button_Cancel.Location = new Point(71, 81);
            _Button_Cancel.Name = "Button_Cancel";
            _Button_Cancel.Size = new Size(56, 23);
            _Button_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_Cancel.TabIndex = 96;
            _Button_Cancel.Text = "Cancel";
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_LabelX_X);
            _Panel1.Controls.Add(_Button_Cancel);
            _Panel1.Controls.Add(_Button_Okay);
            _Panel1.Controls.Add(_LabelX_Z);
            _Panel1.Controls.Add(_IntegerInput_X);
            _Panel1.Controls.Add(_IntegerInput_Z);
            _Panel1.Controls.Add(_IntegerInput_Y);
            _Panel1.Controls.Add(_LabelX_Y);
            _Panel1.Dock = DockStyle.Fill;
            _Panel1.Location = new Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(130, 107);
            _Panel1.TabIndex = 97;
            // 
            // Form_SetUpPoint
            // 
            AcceptButton = _Button_Okay;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _Button_Cancel;
            ClientSize = new Size(130, 107);
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_SetUpPoint";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Point";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_X).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Z).EndInit();
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
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
                _Button_Okay = value;
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_X;

        internal DevComponents.Editors.IntegerInput IntegerInput_X
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_X;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _IntegerInput_X = value;
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_X;

        internal DevComponents.DotNetBar.LabelX LabelX_X
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_X;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_X = value;
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Y;

        internal DevComponents.DotNetBar.LabelX LabelX_Y
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Y;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_Y = value;
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_Y;

        internal DevComponents.Editors.IntegerInput IntegerInput_Y
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_Y;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _IntegerInput_Y = value;
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Z;

        internal DevComponents.DotNetBar.LabelX LabelX_Z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX_Z = value;
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_Z;

        internal DevComponents.Editors.IntegerInput IntegerInput_Z
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_Z;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _IntegerInput_Z = value;
            }
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
                _Button_Cancel = value;
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
                _Panel1 = value;
            }
        }
    }
}