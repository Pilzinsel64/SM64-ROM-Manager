using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Publics
{
    [DesignerGenerated()]
    internal partial class InputDialog : DevComponents.DotNetBar.OfficeForm
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
        private System.ComponentModel.IContainer components = null;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDialog));
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _Panel1 = new System.Windows.Forms.Panel();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.FocusCuesEnabled = false;
            _ButtonX1.Location = new System.Drawing.Point(218, 32);
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Size = new System.Drawing.Size(75, 23);
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX1.TabIndex = 1;
            _ButtonX1.Text = "Okay";
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Location = new System.Drawing.Point(3, 3);
            _LabelX1.Name = "LabelX1";
            _LabelX1.Size = new System.Drawing.Size(290, 23);
            _LabelX1.TabIndex = 2;
            _LabelX1.Text = "Input a value here:";
            // 
            // ComboBoxEx1
            // 
            _ComboBoxEx1.DisplayMember = "Text";
            _ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            _ComboBoxEx1.ForeColor = System.Drawing.Color.Black;
            _ComboBoxEx1.FormattingEnabled = true;
            _ComboBoxEx1.ItemHeight = 14;
            _ComboBoxEx1.Location = new System.Drawing.Point(3, 34);
            _ComboBoxEx1.Name = "ComboBoxEx1";
            _ComboBoxEx1.Size = new System.Drawing.Size(209, 20);
            _ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ComboBoxEx1.TabIndex = 3;
            // 
            // Panel1
            // 
            _Panel1.BackColor = System.Drawing.Color.Transparent;
            _Panel1.Controls.Add(_LabelX1);
            _Panel1.Controls.Add(_ComboBoxEx1);
            _Panel1.Controls.Add(_ButtonX1);
            _Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            _Panel1.Location = new System.Drawing.Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new System.Drawing.Size(296, 58);
            _Panel1.TabIndex = 4;
            // 
            // InputDialog
            // 
            AcceptButton = _ButtonX1;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(296, 58);
            ControlBox = false;
            Controls.Add(_Panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "InputDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Input";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
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
                    _ButtonX1.Click -= ButtonX1_Click;
                }

                _ButtonX1 = value;
                if (_ButtonX1 != null)
                {
                    _ButtonX1.Click += ButtonX1_Click;
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx1;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx1 != null)
                {
                }

                _ComboBoxEx1 = value;
                if (_ComboBoxEx1 != null)
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
    }
}