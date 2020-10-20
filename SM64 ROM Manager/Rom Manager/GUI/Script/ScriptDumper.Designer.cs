using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class ScriptDumper<TCmd, eTypes> : DevComponents.DotNetBar.OfficeForm
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
            _PanelEx_PaintingControl1 = new DevComponents.DotNetBar.PanelEx();
            _ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            _CM_Cmd = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem3.Click += new EventHandler(ButtonItem3_Click);
            _ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem4.Click += new EventHandler(ButtonItem4_Click);
            _ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem1.Click += new EventHandler(ButtonItem1_Click);
            _ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem2.Click += new EventHandler(ButtonItem2_Click);
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).BeginInit();
            SuspendLayout();
            // 
            // PanelEx_PaintingControl1
            // 
            _PanelEx_PaintingControl1.AutoScroll = true;
            _PanelEx_PaintingControl1.CanvasColor = SystemColors.Control;
            _PanelEx_PaintingControl1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _PanelEx_PaintingControl1.DisabledBackColor = Color.Empty;
            _PanelEx_PaintingControl1.Dock = DockStyle.Fill;
            _PanelEx_PaintingControl1.Location = new Point(0, 0);
            _PanelEx_PaintingControl1.Name = "PanelEx_PaintingControl1";
            _PanelEx_PaintingControl1.Size = new Size(998, 679);
            _PanelEx_PaintingControl1.Style.Alignment = StringAlignment.Center;
            _PanelEx_PaintingControl1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            _PanelEx_PaintingControl1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            _PanelEx_PaintingControl1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _PanelEx_PaintingControl1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _PanelEx_PaintingControl1.Style.GradientAngle = 90;
            _PanelEx_PaintingControl1.TabIndex = 0;
            // 
            // ContextMenuBar1
            // 
            _ContextMenuBar1.AntiAlias = true;
            _ContextMenuBar1.Font = new Font("Segoe UI", 9.0F);
            _ContextMenuBar1.IsMaximized = false;
            _ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _CM_Cmd });
            _ContextMenuBar1.Location = new Point(772, 0);
            _ContextMenuBar1.Name = "ContextMenuBar1";
            _ContextMenuBar1.Size = new Size(75, 25);
            _ContextMenuBar1.Stretch = true;
            _ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ContextMenuBar1.TabIndex = 4;
            _ContextMenuBar1.TabStop = false;
            _ContextMenuBar1.Text = "ContextMenuBar1";
            // 
            // CM_Cmd
            // 
            _CM_Cmd.AutoExpandOnClick = true;
            _CM_Cmd.Name = "CM_Cmd";
            _CM_Cmd.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem3, _ButtonItem4, _ButtonItem1, _ButtonItem2 });
            _CM_Cmd.Text = "CM_Cmd";
            // 
            // ButtonItem3
            // 
            _ButtonItem3.Name = "ButtonItem3";
            _ButtonItem3.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            _ButtonItem3.Text = "Edit Command ...";
            // 
            // ButtonItem4
            // 
            _ButtonItem4.BeginGroup = true;
            _ButtonItem4.Name = "ButtonItem4";
            _ButtonItem4.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            _ButtonItem4.Text = "Copy Command";
            // 
            // ButtonItem1
            // 
            _ButtonItem1.Name = "ButtonItem1";
            _ButtonItem1.Text = "Copy ROM Address";
            // 
            // ButtonItem2
            // 
            _ButtonItem2.Name = "ButtonItem2";
            _ButtonItem2.Text = "Copy Bank Address";
            // 
            // ScriptDumper
            // 
            AutoScaleDimensions = new SizeF(96.0F, 96.0F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(998, 679);
            Controls.Add(_ContextMenuBar1);
            Controls.Add(_PanelEx_PaintingControl1);
            Name = "ScriptDumper";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Script Editor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.PanelEx _PanelEx_PaintingControl1;

        internal DevComponents.DotNetBar.PanelEx PanelEx_PaintingControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PanelEx_PaintingControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PanelEx_PaintingControl1 != null)
                {
                }

                _PanelEx_PaintingControl1 = value;
                if (_PanelEx_PaintingControl1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ContextMenuBar _ContextMenuBar1;

        internal DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContextMenuBar1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContextMenuBar1 != null)
                {
                }

                _ContextMenuBar1 = value;
                if (_ContextMenuBar1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _CM_Cmd;

        internal DevComponents.DotNetBar.ButtonItem CM_Cmd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CM_Cmd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CM_Cmd != null)
                {
                }

                _CM_Cmd = value;
                if (_CM_Cmd != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem1;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click -= ButtonItem1_Click;
                }

                _ButtonItem1 = value;
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click += ButtonItem1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem2;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem2 != null)
                {
                    _ButtonItem2.Click -= ButtonItem2_Click;
                }

                _ButtonItem2 = value;
                if (_ButtonItem2 != null)
                {
                    _ButtonItem2.Click += ButtonItem2_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem3;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem3 != null)
                {
                    _ButtonItem3.Click -= ButtonItem3_Click;
                }

                _ButtonItem3 = value;
                if (_ButtonItem3 != null)
                {
                    _ButtonItem3.Click += ButtonItem3_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem4;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem4 != null)
                {
                    _ButtonItem4.Click -= ButtonItem4_Click;
                }

                _ButtonItem4 = value;
                if (_ButtonItem4 != null)
                {
                    _ButtonItem4.Click += ButtonItem4_Click;
                }
            }
        }
    }
}