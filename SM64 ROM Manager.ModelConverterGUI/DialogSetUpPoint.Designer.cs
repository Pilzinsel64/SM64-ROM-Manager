using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [DesignerGenerated()]
    public partial class DialogSetUpPoint : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSetUpPoint));
            _Button_Okay = new DevComponents.DotNetBar.ButtonX();
            _IntegerInput_X = new DevComponents.Editors.IntegerInput();
            _LabelX_X = new DevComponents.DotNetBar.LabelX();
            _LabelX_Y = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_Y = new DevComponents.Editors.IntegerInput();
            _LabelX_Z = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_Z = new DevComponents.Editors.IntegerInput();
            _Button_Cancle = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Z).BeginInit();
            SuspendLayout();
            // 
            // Button_Okay
            // 
            _Button_Okay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _Button_Okay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_Okay.DialogResult = System.Windows.Forms.DialogResult.OK;
            _Button_Okay.FocusCuesEnabled = false;
            _Button_Okay.Location = new System.Drawing.Point(12, 90);
            _Button_Okay.Name = "Button_Okay";
            _Button_Okay.Size = new System.Drawing.Size(56, 23);
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
            _IntegerInput_X.Location = new System.Drawing.Point(36, 12);
            _IntegerInput_X.MaxValue = 32767;
            _IntegerInput_X.MinValue = -32767;
            _IntegerInput_X.Name = "IntegerInput_X";
            _IntegerInput_X.ShowUpDown = true;
            _IntegerInput_X.Size = new System.Drawing.Size(100, 20);
            _IntegerInput_X.TabIndex = 1;
            _IntegerInput_X.Visible = false;
            // 
            // LabelX_X
            // 
            // 
            // 
            // 
            _LabelX_X.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_X.Location = new System.Drawing.Point(12, 12);
            _LabelX_X.Name = "LabelX_X";
            _LabelX_X.Size = new System.Drawing.Size(18, 20);
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
            _LabelX_Y.Location = new System.Drawing.Point(12, 38);
            _LabelX_Y.Name = "LabelX_Y";
            _LabelX_Y.Size = new System.Drawing.Size(18, 20);
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
            _IntegerInput_Y.Location = new System.Drawing.Point(36, 38);
            _IntegerInput_Y.MaxValue = 32767;
            _IntegerInput_Y.MinValue = -32767;
            _IntegerInput_Y.Name = "IntegerInput_Y";
            _IntegerInput_Y.ShowUpDown = true;
            _IntegerInput_Y.Size = new System.Drawing.Size(100, 20);
            _IntegerInput_Y.TabIndex = 92;
            _IntegerInput_Y.Visible = false;
            // 
            // LabelX_Z
            // 
            // 
            // 
            // 
            _LabelX_Z.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Z.Location = new System.Drawing.Point(12, 64);
            _LabelX_Z.Name = "LabelX_Z";
            _LabelX_Z.Size = new System.Drawing.Size(18, 20);
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
            _IntegerInput_Z.Location = new System.Drawing.Point(36, 64);
            _IntegerInput_Z.MaxValue = 32767;
            _IntegerInput_Z.MinValue = -32767;
            _IntegerInput_Z.Name = "IntegerInput_Z";
            _IntegerInput_Z.ShowUpDown = true;
            _IntegerInput_Z.Size = new System.Drawing.Size(100, 20);
            _IntegerInput_Z.TabIndex = 94;
            _IntegerInput_Z.Visible = false;
            // 
            // Button_Cancle
            // 
            _Button_Cancle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _Button_Cancle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_Cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            _Button_Cancle.FocusCuesEnabled = false;
            _Button_Cancle.Location = new System.Drawing.Point(80, 90);
            _Button_Cancle.Name = "Button_Cancle";
            _Button_Cancle.Size = new System.Drawing.Size(56, 23);
            _Button_Cancle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Button_Cancle.TabIndex = 96;
            _Button_Cancle.Text = "Cancel";
            // 
            // DialogSetUpPoint
            // 
            AcceptButton = _Button_Okay;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = _Button_Cancle;
            ClientSize = new System.Drawing.Size(148, 125);
            Controls.Add(_Button_Cancle);
            Controls.Add(_LabelX_Z);
            Controls.Add(_IntegerInput_Z);
            Controls.Add(_LabelX_Y);
            Controls.Add(_IntegerInput_Y);
            Controls.Add(_LabelX_X);
            Controls.Add(_IntegerInput_X);
            Controls.Add(_Button_Okay);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogSetUpPoint";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Point";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_X).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_Z).EndInit();
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

        private DevComponents.DotNetBar.ButtonX _Button_Cancle;

        internal DevComponents.DotNetBar.ButtonX Button_Cancle
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_Cancle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Button_Cancle = value;
            }
        }
    }
}