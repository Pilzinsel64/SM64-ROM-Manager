using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Form_About : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _PictureBox_Donate = new PictureBox();
            _PictureBox_Donate.Click += new EventHandler(PictureBox_Donate_Click);
            ((System.ComponentModel.ISupportInitialize)_PictureBox_Donate).BeginInit();
            SuspendLayout();
            // 
            // LabelX1
            // 
            resources.ApplyResources(_LabelX1, "LabelX1");
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Name = "LabelX1";
            _LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            _LabelX1.TextLineAlignment = StringAlignment.Near;
            // 
            // PictureBox_Donate
            // 
            resources.ApplyResources(_PictureBox_Donate, "PictureBox_Donate");
            _PictureBox_Donate.BackColor = Color.Transparent;
            _PictureBox_Donate.Cursor = Cursors.Hand;
            _PictureBox_Donate.Image = My.Resources.Resources.btn_donateCC_LG;
            _PictureBox_Donate.Name = "PictureBox_Donate";
            _PictureBox_Donate.TabStop = false;
            // 
            // Form_About
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_PictureBox_Donate);
            Controls.Add(_LabelX1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_About";
            ShowIcon = false;
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_PictureBox_Donate).EndInit();
            ResumeLayout(false);
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

        private PictureBox _PictureBox_Donate;

        internal PictureBox PictureBox_Donate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox_Donate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox_Donate != null)
                {
                    _PictureBox_Donate.Click -= PictureBox_Donate_Click;
                }

                _PictureBox_Donate = value;
                if (_PictureBox_Donate != null)
                {
                    _PictureBox_Donate.Click += PictureBox_Donate_Click;
                }
            }
        }
    }
}