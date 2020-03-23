using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using global::System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelImporterGUI
{
    [DesignerGenerated()]
    public partial class InfoEditor : DevComponents.DotNetBar.OfficeForm
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEditor));
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TableLayoutPanel1 = new TableLayoutPanel();
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Location = new Point(12, 12);
            _LabelX1.Name = "LabelX1";
            _LabelX1.Size = new Size(458, 23);
            _LabelX1.TabIndex = 0;
            _LabelX1.Text = "Name:";
            // 
            // TextBoxX1
            // 
            _TextBoxX1.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX1.Border.Class = "TextBoxBorder";
            _TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX1.DisabledBackColor = Color.White;
            _TextBoxX1.ForeColor = Color.Black;
            _TextBoxX1.Location = new Point(12, 41);
            _TextBoxX1.Name = "TextBoxX1";
            _TextBoxX1.PreventEnterBeep = true;
            _TextBoxX1.Size = new Size(458, 20);
            _TextBoxX1.TabIndex = 1;
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Location = new Point(12, 67);
            _LabelX2.Name = "LabelX2";
            _LabelX2.Size = new Size(458, 23);
            _LabelX2.TabIndex = 2;
            _LabelX2.Text = "Description:";
            // 
            // TextBoxX2
            // 
            _TextBoxX2.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX2.Border.Class = "TextBoxBorder";
            _TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX2.DisabledBackColor = Color.White;
            _TextBoxX2.ForeColor = Color.Black;
            _TextBoxX2.Location = new Point(12, 96);
            _TextBoxX2.Multiline = true;
            _TextBoxX2.Name = "TextBoxX2";
            _TextBoxX2.PreventEnterBeep = true;
            _TextBoxX2.Size = new Size(458, 204);
            _TextBoxX2.TabIndex = 3;
            // 
            // TableLayoutPanel1
            // 
            _TableLayoutPanel1.AutoSize = true;
            _TableLayoutPanel1.ColumnCount = 2;
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            _TableLayoutPanel1.Controls.Add(_ButtonX2, 0, 0);
            _TableLayoutPanel1.Controls.Add(_ButtonX1, 1, 0);
            _TableLayoutPanel1.Location = new Point(308, 306);
            _TableLayoutPanel1.Name = "TableLayoutPanel1";
            _TableLayoutPanel1.RowCount = 1;
            _TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            _TableLayoutPanel1.Size = new Size(162, 29);
            _TableLayoutPanel1.TabIndex = 4;
            // 
            // ButtonX2
            // 
            _ButtonX2.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX2.DialogResult = DialogResult.OK;
            _ButtonX2.Location = new Point(3, 3);
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Size = new Size(75, 23);
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX2.Symbol = "58826";
            _ButtonX2.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX2.SymbolSize = 12.0F;
            _ButtonX2.TabIndex = 1;
            _ButtonX2.Text = "Okay";
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.DialogResult = DialogResult.Cancel;
            _ButtonX1.Location = new Point(84, 3);
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Size = new Size(75, 23);
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX1.Symbol = "58829";
            _ButtonX1.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX1.SymbolSize = 12.0F;
            _ButtonX1.TabIndex = 0;
            _ButtonX1.Text = "Cancel";
            // 
            // InfoEditor
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 347);
            ControlBox = false;
            Controls.Add(_TableLayoutPanel1);
            Controls.Add(_TextBoxX2);
            Controls.Add(_LabelX2);
            Controls.Add(_TextBoxX1);
            Controls.Add(_LabelX1);
            DoubleBuffered = true;
            EnableGlass = false;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InfoEditor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tweak Editor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX2;

        internal DevComponents.DotNetBar.ButtonX ButtonX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ButtonX2 = value;
            }
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
                _ButtonX1 = value;
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX1;

        private DevComponents.DotNetBar.LabelX LabelX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX1 = value;
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX1;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TextBoxX1 = value;
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX2;

        private DevComponents.DotNetBar.LabelX LabelX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelX2 = value;
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX2;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TextBoxX2 = value;
            }
        }

        private TableLayoutPanel _TableLayoutPanel1;

        private TableLayoutPanel TableLayoutPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TableLayoutPanel1 = value;
            }
        }
    }
}