using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Form_SetUpRGBA : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SetUpRGBA));
            _Button_Cancel = new Button();
            _Button_Okay = new Button();
            _GroupBox5 = new GroupBox();
            _Label22 = new Label();
            _Label21 = new Label();
            _Label20 = new Label();
            _NumericUpDown_FogBlue = new NumericUpDown();
            _NumericUpDown_FogGreen = new NumericUpDown();
            _NumericUpDown_FogRed = new NumericUpDown();
            _GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_NumericUpDown_FogBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_NumericUpDown_FogGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_NumericUpDown_FogRed).BeginInit();
            SuspendLayout();
            // 
            // Button_Cancel
            // 
            _Button_Cancel.DialogResult = DialogResult.Cancel;
            _Button_Cancel.Location = new Point(80, 226);
            _Button_Cancel.Name = "Button_Cancel";
            _Button_Cancel.Size = new Size(56, 23);
            _Button_Cancel.TabIndex = 98;
            _Button_Cancel.Text = "Cancel";
            _Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Button_Okay
            // 
            _Button_Okay.DialogResult = DialogResult.OK;
            _Button_Okay.Location = new Point(12, 226);
            _Button_Okay.Name = "Button_Okay";
            _Button_Okay.Size = new Size(56, 23);
            _Button_Okay.TabIndex = 97;
            _Button_Okay.Text = "Okay";
            _Button_Okay.UseVisualStyleBackColor = true;
            // 
            // GroupBox5
            // 
            _GroupBox5.Controls.Add(_Label22);
            _GroupBox5.Controls.Add(_Label21);
            _GroupBox5.Controls.Add(_Label20);
            _GroupBox5.Controls.Add(_NumericUpDown_FogBlue);
            _GroupBox5.Controls.Add(_NumericUpDown_FogGreen);
            _GroupBox5.Controls.Add(_NumericUpDown_FogRed);
            _GroupBox5.Location = new Point(12, 39);
            _GroupBox5.Name = "GroupBox5";
            _GroupBox5.Size = new Size(119, 102);
            _GroupBox5.TabIndex = 100;
            _GroupBox5.TabStop = false;
            _GroupBox5.Text = "Color";
            // 
            // Label22
            // 
            _Label22.AutoSize = true;
            _Label22.Location = new Point(6, 73);
            _Label22.Name = "Label22";
            _Label22.Size = new Size(31, 13);
            _Label22.TabIndex = 26;
            _Label22.Text = "Blue:";
            // 
            // Label21
            // 
            _Label21.AutoSize = true;
            _Label21.Location = new Point(6, 47);
            _Label21.Name = "Label21";
            _Label21.Size = new Size(39, 13);
            _Label21.TabIndex = 25;
            _Label21.Text = "Green:";
            // 
            // Label20
            // 
            _Label20.AutoSize = true;
            _Label20.Location = new Point(6, 21);
            _Label20.Name = "Label20";
            _Label20.Size = new Size(30, 13);
            _Label20.TabIndex = 24;
            _Label20.Text = "Red:";
            // 
            // NumericUpDown_FogBlue
            // 
            _NumericUpDown_FogBlue.Location = new Point(53, 71);
            _NumericUpDown_FogBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            _NumericUpDown_FogBlue.Name = "NumericUpDown_FogBlue";
            _NumericUpDown_FogBlue.Size = new Size(59, 20);
            _NumericUpDown_FogBlue.TabIndex = 23;
            // 
            // NumericUpDown_FogGreen
            // 
            _NumericUpDown_FogGreen.Location = new Point(53, 45);
            _NumericUpDown_FogGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            _NumericUpDown_FogGreen.Name = "NumericUpDown_FogGreen";
            _NumericUpDown_FogGreen.Size = new Size(59, 20);
            _NumericUpDown_FogGreen.TabIndex = 22;
            // 
            // NumericUpDown_FogRed
            // 
            _NumericUpDown_FogRed.Location = new Point(53, 19);
            _NumericUpDown_FogRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            _NumericUpDown_FogRed.Name = "NumericUpDown_FogRed";
            _NumericUpDown_FogRed.Size = new Size(59, 20);
            _NumericUpDown_FogRed.TabIndex = 21;
            // 
            // Form_SetUpRGBA
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(156, 256);
            Controls.Add(_GroupBox5);
            Controls.Add(_Button_Cancel);
            Controls.Add(_Button_Okay);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_SetUpRGBA";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fog";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _GroupBox5.ResumeLayout(false);
            _GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_NumericUpDown_FogBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)_NumericUpDown_FogGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)_NumericUpDown_FogRed).EndInit();
            ResumeLayout(false);
        }

        private Button _Button_Cancel;

        internal Button Button_Cancel
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

        private Button _Button_Okay;

        internal Button Button_Okay
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

        private GroupBox _GroupBox5;

        internal GroupBox GroupBox5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _GroupBox5 = value;
            }
        }

        private Label _Label22;

        internal Label Label22
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label22;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Label22 = value;
            }
        }

        private Label _Label21;

        internal Label Label21
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label21;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Label21 = value;
            }
        }

        private Label _Label20;

        internal Label Label20
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label20;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Label20 = value;
            }
        }

        private NumericUpDown _NumericUpDown_FogBlue;

        internal NumericUpDown NumericUpDown_FogBlue
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NumericUpDown_FogBlue;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _NumericUpDown_FogBlue = value;
            }
        }

        private NumericUpDown _NumericUpDown_FogGreen;

        internal NumericUpDown NumericUpDown_FogGreen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NumericUpDown_FogGreen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _NumericUpDown_FogGreen = value;
            }
        }

        private NumericUpDown _NumericUpDown_FogRed;

        internal NumericUpDown NumericUpDown_FogRed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NumericUpDown_FogRed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _NumericUpDown_FogRed = value;
            }
        }
    }
}