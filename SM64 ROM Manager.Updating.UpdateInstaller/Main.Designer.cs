using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.UpdateInstaller
{
    [DesignerGenerated()]
    public partial class Main : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            _ProgressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            _Panel1 = new Panel();
            _LabelX_Header = new DevComponents.DotNetBar.LabelX();
            _LabelX_Status = new DevComponents.DotNetBar.LabelX();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProgressBarX1
            // 
            _ProgressBarX1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ProgressBarX1.Location = new Point(3, 94);
            _ProgressBarX1.Name = "ProgressBarX1";
            _ProgressBarX1.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            _ProgressBarX1.Size = new Size(628, 16);
            _ProgressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ProgressBarX1.TabIndex = 0;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_LabelX_Header);
            _Panel1.Controls.Add(_LabelX_Status);
            _Panel1.Controls.Add(_ProgressBarX1);
            _Panel1.Dock = DockStyle.Fill;
            _Panel1.Location = new Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(634, 111);
            _Panel1.TabIndex = 1;
            // 
            // LabelX_Header
            // 
            _LabelX_Header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _LabelX_Header.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Header.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _LabelX_Header.Location = new Point(3, 3);
            _LabelX_Header.Name = "LabelX_Header";
            _LabelX_Header.Size = new Size(628, 56);
            _LabelX_Header.TabIndex = 3;
            _LabelX_Header.Text = "<div align=\"center\" valign=\"center\"><font color=\"#B7472A\" size=\"20\"><b>SM64 ROM M" + "anager wird aktuallisierung ...</b></font></div>";
            // 
            // LabelX_Status
            // 
            _LabelX_Status.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _LabelX_Status.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Status.Location = new Point(3, 65);
            _LabelX_Status.Name = "LabelX_Status";
            _LabelX_Status.Size = new Size(628, 23);
            _LabelX_Status.TabIndex = 2;
            _LabelX_Status.Text = "Idle ...";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 111);
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Installing";
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.ProgressBarX _ProgressBarX1;

        internal DevComponents.DotNetBar.Controls.ProgressBarX ProgressBarX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ProgressBarX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ProgressBarX1 != null)
                {
                }

                _ProgressBarX1 = value;
                if (_ProgressBarX1 != null)
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

        private DevComponents.DotNetBar.LabelX _LabelX_Status;

        internal DevComponents.DotNetBar.LabelX LabelX_Status
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Status;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Status != null)
                {
                }

                _LabelX_Status = value;
                if (_LabelX_Status != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Header;

        internal DevComponents.DotNetBar.LabelX LabelX_Header
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Header;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Header != null)
                {
                }

                _LabelX_Header = value;
                if (_LabelX_Header != null)
                {
                }
            }
        }
    }
}