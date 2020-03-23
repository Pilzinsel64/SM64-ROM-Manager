using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ProgressUpdater
{
    [DesignerGenerated()]
    public partial class Form1 : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            _Panel1 = new Panel();
            _ButtonX_PasteClipboard = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_PasteClipboard.Click += new EventHandler(ButtonX1_Click);
            _PictureBox1 = new PictureBox();
            _Panel2 = new Panel();
            _ButtonX_Upload = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Upload.Click += new EventHandler(ButtonX_Upload_Click);
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_WebDavUploadPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ProxPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_WebDavUploadUri = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_WebDavUploadUsr = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LabelX6 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_Version = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_ProxUsr = new DevComponents.DotNetBar.Controls.TextBoxX();
            _StyleManager1 = new DevComponents.DotNetBar.StyleManager(components);
            _Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).BeginInit();
            _Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_ButtonX_PasteClipboard);
            _Panel1.Controls.Add(_PictureBox1);
            _Panel1.Controls.Add(_Panel2);
            _Panel1.Dock = DockStyle.Fill;
            _Panel1.Location = new Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(694, 508);
            _Panel1.TabIndex = 0;
            // 
            // ButtonX_PasteClipboard
            // 
            _ButtonX_PasteClipboard.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_PasteClipboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _ButtonX_PasteClipboard.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_PasteClipboard.Location = new Point(562, 3);
            _ButtonX_PasteClipboard.Name = "ButtonX_PasteClipboard";
            _ButtonX_PasteClipboard.Size = new Size(129, 23);
            _ButtonX_PasteClipboard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_PasteClipboard.TabIndex = 0;
            _ButtonX_PasteClipboard.Text = "Paste from Clipboard";
            // 
            // PictureBox1
            // 
            _PictureBox1.Dock = DockStyle.Fill;
            _PictureBox1.Location = new Point(200, 0);
            _PictureBox1.Name = "PictureBox1";
            _PictureBox1.Size = new Size(494, 508);
            _PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            _PictureBox1.TabIndex = 0;
            _PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            _Panel2.Controls.Add(_ButtonX_Upload);
            _Panel2.Controls.Add(_LabelX5);
            _Panel2.Controls.Add(_LabelX2);
            _Panel2.Controls.Add(_TextBoxX_WebDavUploadPwd);
            _Panel2.Controls.Add(_TextBoxX_ProxPwd);
            _Panel2.Controls.Add(_LabelX3);
            _Panel2.Controls.Add(_TextBoxX_WebDavUploadUri);
            _Panel2.Controls.Add(_LabelX4);
            _Panel2.Controls.Add(_TextBoxX_WebDavUploadUsr);
            _Panel2.Controls.Add(_LabelX6);
            _Panel2.Controls.Add(_TextBoxX_Version);
            _Panel2.Controls.Add(_LabelX1);
            _Panel2.Controls.Add(_TextBoxX_ProxUsr);
            _Panel2.Dock = DockStyle.Left;
            _Panel2.Location = new Point(0, 0);
            _Panel2.Name = "Panel2";
            _Panel2.Size = new Size(200, 508);
            _Panel2.TabIndex = 1;
            // 
            // ButtonX_Upload
            // 
            _ButtonX_Upload.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _ButtonX_Upload.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Upload.Location = new Point(3, 465);
            _ButtonX_Upload.Name = "ButtonX_Upload";
            _ButtonX_Upload.Size = new Size(194, 40);
            _ButtonX_Upload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Upload.TabIndex = 10;
            _ButtonX_Upload.Text = "Upload";
            // 
            // LabelX5
            // 
            _LabelX5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX5.Location = new Point(3, 113);
            _LabelX5.Name = "LabelX5";
            _LabelX5.Size = new Size(194, 23);
            _LabelX5.TabIndex = 1;
            _LabelX5.Text = "WebDav Password:";
            // 
            // LabelX2
            // 
            _LabelX2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Location = new Point(3, 223);
            _LabelX2.Name = "LabelX2";
            _LabelX2.Size = new Size(194, 23);
            _LabelX2.TabIndex = 1;
            _LabelX2.Text = "Proxy Password:";
            // 
            // TextBoxX_WebDavUploadPwd
            // 
            _TextBoxX_WebDavUploadPwd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _TextBoxX_WebDavUploadPwd.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_WebDavUploadPwd.Border.Class = "TextBoxBorder";
            _TextBoxX_WebDavUploadPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_WebDavUploadPwd.DisabledBackColor = Color.White;
            _TextBoxX_WebDavUploadPwd.ForeColor = Color.Black;
            _TextBoxX_WebDavUploadPwd.Location = new Point(3, 142);
            _TextBoxX_WebDavUploadPwd.Name = "TextBoxX_WebDavUploadPwd";
            _TextBoxX_WebDavUploadPwd.PreventEnterBeep = true;
            _TextBoxX_WebDavUploadPwd.Size = new Size(194, 20);
            _TextBoxX_WebDavUploadPwd.TabIndex = 3;
            _TextBoxX_WebDavUploadPwd.UseSystemPasswordChar = true;
            // 
            // TextBoxX_ProxPwd
            // 
            _TextBoxX_ProxPwd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _TextBoxX_ProxPwd.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ProxPwd.Border.Class = "TextBoxBorder";
            _TextBoxX_ProxPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ProxPwd.DisabledBackColor = Color.White;
            _TextBoxX_ProxPwd.ForeColor = Color.Black;
            _TextBoxX_ProxPwd.Location = new Point(3, 252);
            _TextBoxX_ProxPwd.Name = "TextBoxX_ProxPwd";
            _TextBoxX_ProxPwd.PreventEnterBeep = true;
            _TextBoxX_ProxPwd.Size = new Size(194, 20);
            _TextBoxX_ProxPwd.TabIndex = 5;
            _TextBoxX_ProxPwd.UseSystemPasswordChar = true;
            // 
            // LabelX3
            // 
            _LabelX3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX3.Location = new Point(3, 3);
            _LabelX3.Name = "LabelX3";
            _LabelX3.Size = new Size(194, 23);
            _LabelX3.TabIndex = 1;
            _LabelX3.Text = "WebDav Directory Address:";
            // 
            // TextBoxX_WebDavUploadUri
            // 
            _TextBoxX_WebDavUploadUri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _TextBoxX_WebDavUploadUri.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_WebDavUploadUri.Border.Class = "TextBoxBorder";
            _TextBoxX_WebDavUploadUri.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_WebDavUploadUri.DisabledBackColor = Color.White;
            _TextBoxX_WebDavUploadUri.ForeColor = Color.Black;
            _TextBoxX_WebDavUploadUri.Location = new Point(3, 32);
            _TextBoxX_WebDavUploadUri.Name = "TextBoxX_WebDavUploadUri";
            _TextBoxX_WebDavUploadUri.PreventEnterBeep = true;
            _TextBoxX_WebDavUploadUri.Size = new Size(194, 20);
            _TextBoxX_WebDavUploadUri.TabIndex = 1;
            // 
            // LabelX4
            // 
            _LabelX4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX4.Location = new Point(3, 58);
            _LabelX4.Name = "LabelX4";
            _LabelX4.Size = new Size(194, 23);
            _LabelX4.TabIndex = 1;
            _LabelX4.Text = "WebDav Username:";
            // 
            // TextBoxX_WebDavUploadUsr
            // 
            _TextBoxX_WebDavUploadUsr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _TextBoxX_WebDavUploadUsr.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_WebDavUploadUsr.Border.Class = "TextBoxBorder";
            _TextBoxX_WebDavUploadUsr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_WebDavUploadUsr.DisabledBackColor = Color.White;
            _TextBoxX_WebDavUploadUsr.ForeColor = Color.Black;
            _TextBoxX_WebDavUploadUsr.Location = new Point(3, 87);
            _TextBoxX_WebDavUploadUsr.Name = "TextBoxX_WebDavUploadUsr";
            _TextBoxX_WebDavUploadUsr.PreventEnterBeep = true;
            _TextBoxX_WebDavUploadUsr.Size = new Size(194, 20);
            _TextBoxX_WebDavUploadUsr.TabIndex = 2;
            // 
            // LabelX6
            // 
            _LabelX6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX6.Location = new Point(3, 278);
            _LabelX6.Name = "LabelX6";
            _LabelX6.Size = new Size(194, 23);
            _LabelX6.TabIndex = 1;
            _LabelX6.Text = "Version:";
            // 
            // TextBoxX_Version
            // 
            _TextBoxX_Version.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _TextBoxX_Version.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Version.Border.Class = "TextBoxBorder";
            _TextBoxX_Version.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Version.DisabledBackColor = Color.White;
            _TextBoxX_Version.ForeColor = Color.Black;
            _TextBoxX_Version.Location = new Point(3, 307);
            _TextBoxX_Version.Name = "TextBoxX_Version";
            _TextBoxX_Version.PreventEnterBeep = true;
            _TextBoxX_Version.Size = new Size(194, 20);
            _TextBoxX_Version.TabIndex = 6;
            _TextBoxX_Version.WatermarkText = "e.g. 1.2.0.0";
            // 
            // LabelX1
            // 
            _LabelX1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Location = new Point(3, 168);
            _LabelX1.Name = "LabelX1";
            _LabelX1.Size = new Size(194, 23);
            _LabelX1.TabIndex = 1;
            _LabelX1.Text = "Proxy Username:";
            // 
            // TextBoxX_ProxUsr
            // 
            _TextBoxX_ProxUsr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _TextBoxX_ProxUsr.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ProxUsr.Border.Class = "TextBoxBorder";
            _TextBoxX_ProxUsr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ProxUsr.DisabledBackColor = Color.White;
            _TextBoxX_ProxUsr.ForeColor = Color.Black;
            _TextBoxX_ProxUsr.Location = new Point(3, 197);
            _TextBoxX_ProxUsr.Name = "TextBoxX_ProxUsr";
            _TextBoxX_ProxUsr.PreventEnterBeep = true;
            _TextBoxX_ProxUsr.Size = new Size(194, 20);
            _TextBoxX_ProxUsr.TabIndex = 4;
            // 
            // StyleManager1
            // 
            _StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            _StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255))), Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(57)), Conversions.ToInteger(Conversions.ToByte(123))));
            // 
            // Form1
            // 
            AcceptButton = _ButtonX_Upload;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 508);
            Controls.Add(_Panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SM64RM Progress Updater";
            _Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).EndInit();
            _Panel2.ResumeLayout(false);
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

        private DevComponents.DotNetBar.StyleManager _StyleManager1;

        internal DevComponents.DotNetBar.StyleManager StyleManager1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StyleManager1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StyleManager1 != null)
                {
                }

                _StyleManager1 = value;
                if (_StyleManager1 != null)
                {
                }
            }
        }

        private PictureBox _PictureBox1;

        internal PictureBox PictureBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox1 != null)
                {
                }

                _PictureBox1 = value;
                if (_PictureBox1 != null)
                {
                }
            }
        }

        private Panel _Panel2;

        internal Panel Panel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel2 != null)
                {
                }

                _Panel2 = value;
                if (_Panel2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Upload;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Upload
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Upload;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Upload != null)
                {
                    _ButtonX_Upload.Click -= ButtonX_Upload_Click;
                }

                _ButtonX_Upload = value;
                if (_ButtonX_Upload != null)
                {
                    _ButtonX_Upload.Click += ButtonX_Upload_Click;
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ProxUsr;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ProxUsr
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ProxUsr;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ProxUsr != null)
                {
                }

                _TextBoxX_ProxUsr = value;
                if (_TextBoxX_ProxUsr != null)
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ProxPwd;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ProxPwd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ProxPwd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ProxPwd != null)
                {
                }

                _TextBoxX_ProxPwd = value;
                if (_TextBoxX_ProxPwd != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX5;

        internal DevComponents.DotNetBar.LabelX LabelX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX5 != null)
                {
                }

                _LabelX5 = value;
                if (_LabelX5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_WebDavUploadPwd;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_WebDavUploadPwd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_WebDavUploadPwd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_WebDavUploadPwd != null)
                {
                }

                _TextBoxX_WebDavUploadPwd = value;
                if (_TextBoxX_WebDavUploadPwd != null)
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_WebDavUploadUri;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_WebDavUploadUri
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_WebDavUploadUri;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_WebDavUploadUri != null)
                {
                }

                _TextBoxX_WebDavUploadUri = value;
                if (_TextBoxX_WebDavUploadUri != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX4;

        internal DevComponents.DotNetBar.LabelX LabelX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX4 != null)
                {
                }

                _LabelX4 = value;
                if (_LabelX4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_WebDavUploadUsr;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_WebDavUploadUsr
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_WebDavUploadUsr;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_WebDavUploadUsr != null)
                {
                }

                _TextBoxX_WebDavUploadUsr = value;
                if (_TextBoxX_WebDavUploadUsr != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_PasteClipboard;

        internal DevComponents.DotNetBar.ButtonX ButtonX_PasteClipboard
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_PasteClipboard;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_PasteClipboard != null)
                {
                    _ButtonX_PasteClipboard.Click -= ButtonX1_Click;
                }

                _ButtonX_PasteClipboard = value;
                if (_ButtonX_PasteClipboard != null)
                {
                    _ButtonX_PasteClipboard.Click += ButtonX1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Version;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Version
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Version;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Version != null)
                {
                }

                _TextBoxX_Version = value;
                if (_TextBoxX_Version != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX6;

        internal DevComponents.DotNetBar.LabelX LabelX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX6 != null)
                {
                }

                _LabelX6 = value;
                if (_LabelX6 != null)
                {
                }
            }
        }
    }
}