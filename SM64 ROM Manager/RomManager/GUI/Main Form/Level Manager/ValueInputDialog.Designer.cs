using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ValueInputDialog : DevComponents.DotNetBar.OfficeForm
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
            _ValueTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            _InfoLabel = new DevComponents.DotNetBar.LabelX();
            _ButtonX_Okay = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            SuspendLayout();
            // 
            // ValueTextBox
            // 
            _ValueTextBox.BackColor = Color.White;
            // 
            // 
            // 
            _ValueTextBox.Border.Class = "TextBoxBorder";
            _ValueTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ValueTextBox.DisabledBackColor = Color.White;
            _ValueTextBox.ForeColor = Color.Black;
            _ValueTextBox.Location = new Point(12, 41);
            _ValueTextBox.Name = "ValueTextBox";
            _ValueTextBox.PreventEnterBeep = true;
            _ValueTextBox.Size = new Size(128, 20);
            _ValueTextBox.TabIndex = 0;
            // 
            // InfoLabel
            // 
            // 
            // 
            // 
            _InfoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _InfoLabel.Location = new Point(12, 12);
            _InfoLabel.Name = "InfoLabel";
            _InfoLabel.Size = new Size(128, 23);
            _InfoLabel.TabIndex = 1;
            _InfoLabel.Text = "Value:";
            // 
            // ButtonX_Okay
            // 
            _ButtonX_Okay.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Okay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Okay.DialogResult = DialogResult.OK;
            _ButtonX_Okay.FocusCuesEnabled = false;
            _ButtonX_Okay.Location = new Point(12, 67);
            _ButtonX_Okay.Name = "ButtonX_Okay";
            _ButtonX_Okay.Size = new Size(61, 23);
            _ButtonX_Okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Okay.TabIndex = 2;
            _ButtonX_Okay.Text = "Okay";
            // 
            // ButtonX_Cancel
            // 
            _ButtonX_Cancel.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Cancel.DialogResult = DialogResult.Cancel;
            _ButtonX_Cancel.FocusCuesEnabled = false;
            _ButtonX_Cancel.Location = new Point(79, 67);
            _ButtonX_Cancel.Name = "ButtonX_Cancel";
            _ButtonX_Cancel.Size = new Size(61, 23);
            _ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Cancel.TabIndex = 3;
            _ButtonX_Cancel.Text = "Cancel";
            // 
            // ValueInputDialog
            // 
            AcceptButton = _ButtonX_Okay;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _ButtonX_Cancel;
            ClientSize = new Size(151, 101);
            ControlBox = false;
            Controls.Add(_ButtonX_Cancel);
            Controls.Add(_ButtonX_Okay);
            Controls.Add(_InfoLabel);
            Controls.Add(_ValueTextBox);
            DoubleBuffered = true;
            EnableGlass = false;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ValueInputDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _ValueTextBox;

        internal DevComponents.DotNetBar.Controls.TextBoxX ValueTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ValueTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ValueTextBox = value;
            }
        }

        private DevComponents.DotNetBar.LabelX _InfoLabel;

        internal DevComponents.DotNetBar.LabelX InfoLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InfoLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _InfoLabel = value;
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
                _ButtonX_Okay = value;
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
                _ButtonX_Cancel = value;
            }
        }
    }
}