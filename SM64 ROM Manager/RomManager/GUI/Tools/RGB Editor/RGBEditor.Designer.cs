using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class RGBEditor : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RGBEditor));
            this._panel1 = new System.Windows.Forms.Panel();
            this._TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this._ButtonX_Edit = new DevComponents.DotNetBar.ButtonX();
            this._ButtonX_Remove = new DevComponents.DotNetBar.ButtonX();
            this._label6 = new DevComponents.DotNetBar.LabelX();
            this._textBox8 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._comboBox1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this._label5 = new DevComponents.DotNetBar.LabelX();
            this._button2 = new DevComponents.DotNetBar.ButtonX();
            this._textBox5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._textBox2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._textBox6 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._textBox3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._textBox7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._textBox4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._label4 = new DevComponents.DotNetBar.LabelX();
            this._label1 = new DevComponents.DotNetBar.LabelX();
            this._label3 = new DevComponents.DotNetBar.LabelX();
            this._label2 = new DevComponents.DotNetBar.LabelX();
            this._panel1.SuspendLayout();
            this._TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel1
            // 
            this._panel1.BackColor = System.Drawing.Color.Transparent;
            this._panel1.Controls.Add(this._TableLayoutPanel1);
            this._panel1.Controls.Add(this._label6);
            this._panel1.Controls.Add(this._textBox8);
            this._panel1.Controls.Add(this._comboBox1);
            this._panel1.Controls.Add(this._label5);
            this._panel1.Controls.Add(this._button2);
            this._panel1.Controls.Add(this._textBox5);
            this._panel1.Controls.Add(this._textBox2);
            this._panel1.Controls.Add(this._textBox6);
            this._panel1.Controls.Add(this._textBox3);
            this._panel1.Controls.Add(this._textBox7);
            this._panel1.Controls.Add(this._textBox4);
            this._panel1.Controls.Add(this._label4);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel1.Location = new System.Drawing.Point(0, 0);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(273, 131);
            this._panel1.TabIndex = 20;
            // 
            // _TableLayoutPanel1
            // 
            this._TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._TableLayoutPanel1.AutoSize = true;
            this._TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this._TableLayoutPanel1.ColumnCount = 3;
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._TableLayoutPanel1.Controls.Add(this._ButtonX1, 0, 0);
            this._TableLayoutPanel1.Controls.Add(this._ButtonX_Edit, 1, 0);
            this._TableLayoutPanel1.Controls.Add(this._ButtonX_Remove, 2, 0);
            this._TableLayoutPanel1.Location = new System.Drawing.Point(191, 1);
            this._TableLayoutPanel1.Name = "_TableLayoutPanel1";
            this._TableLayoutPanel1.RowCount = 1;
            this._TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel1.Size = new System.Drawing.Size(78, 26);
            this._TableLayoutPanel1.TabIndex = 48;
            // 
            // _ButtonX1
            // 
            this._ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this._ButtonX1.FocusCuesEnabled = false;
            this._ButtonX1.Location = new System.Drawing.Point(3, 3);
            this._ButtonX1.Name = "_ButtonX1";
            this._ButtonX1.Size = new System.Drawing.Size(20, 20);
            this._ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX1.Symbol = "57669";
            this._ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this._ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this._ButtonX1.SymbolSize = 12F;
            this._ButtonX1.TabIndex = 42;
            this._ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // _ButtonX_Edit
            // 
            this._ButtonX_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._ButtonX_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._ButtonX_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this._ButtonX_Edit.FocusCuesEnabled = false;
            this._ButtonX_Edit.Location = new System.Drawing.Point(29, 3);
            this._ButtonX_Edit.Name = "_ButtonX_Edit";
            this._ButtonX_Edit.Size = new System.Drawing.Size(20, 20);
            this._ButtonX_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX_Edit.Symbol = "57680";
            this._ButtonX_Edit.SymbolColor = System.Drawing.Color.Goldenrod;
            this._ButtonX_Edit.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this._ButtonX_Edit.SymbolSize = 12F;
            this._ButtonX_Edit.TabIndex = 44;
            this._ButtonX_Edit.Click += new System.EventHandler(this.ButtonX6_Click);
            // 
            // _ButtonX_Remove
            // 
            this._ButtonX_Remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._ButtonX_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._ButtonX_Remove.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this._ButtonX_Remove.FocusCuesEnabled = false;
            this._ButtonX_Remove.Location = new System.Drawing.Point(55, 3);
            this._ButtonX_Remove.Name = "_ButtonX_Remove";
            this._ButtonX_Remove.Size = new System.Drawing.Size(20, 20);
            this._ButtonX_Remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX_Remove.Symbol = "57676";
            this._ButtonX_Remove.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._ButtonX_Remove.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this._ButtonX_Remove.SymbolSize = 12F;
            this._ButtonX_Remove.TabIndex = 45;
            this._ButtonX_Remove.Click += new System.EventHandler(this.ButtonX4_Click);
            // 
            // _label6
            // 
            // 
            // 
            // 
            this._label6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label6.ForeColor = System.Drawing.Color.Gray;
            this._label6.Location = new System.Drawing.Point(210, 40);
            this._label6.Name = "_label6";
            this._label6.Size = new System.Drawing.Size(40, 15);
            this._label6.TabIndex = 18;
            this._label6.Text = "AA";
            this._label6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // _textBox8
            // 
            this._textBox8.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._textBox8.Border.Class = "TextBoxBorder";
            this._textBox8.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._textBox8.DisabledBackColor = System.Drawing.Color.White;
            this._textBox8.ForeColor = System.Drawing.Color.Black;
            this._textBox8.Location = new System.Drawing.Point(210, 61);
            this._textBox8.MaxLength = 100;
            this._textBox8.Name = "_textBox8";
            this._textBox8.Size = new System.Drawing.Size(40, 20);
            this._textBox8.TabIndex = 16;
            // 
            // _comboBox1
            // 
            this._comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox1.ForeColor = System.Drawing.Color.Black;
            this._comboBox1.FormattingEnabled = true;
            this._comboBox1.ItemHeight = 15;
            this._comboBox1.Location = new System.Drawing.Point(3, 4);
            this._comboBox1.Name = "_comboBox1";
            this._comboBox1.Size = new System.Drawing.Size(185, 21);
            this._comboBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._comboBox1.TabIndex = 3;
            this._comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // _label5
            // 
            // 
            // 
            // 
            this._label5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label5.Location = new System.Drawing.Point(3, 106);
            this._label5.Name = "_label5";
            this._label5.Size = new System.Drawing.Size(46, 15);
            this._label5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._label5.TabIndex = 15;
            this._label5.Text = "Shading:";
            // 
            // _button2
            // 
            this._button2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._button2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._button2.Enabled = false;
            this._button2.FocusCuesEnabled = false;
            this._button2.Location = new System.Drawing.Point(191, 102);
            this._button2.Name = "_button2";
            this._button2.Size = new System.Drawing.Size(75, 23);
            this._button2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._button2.TabIndex = 4;
            this._button2.Text = "Patch";
            this._button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // _textBox5
            // 
            this._textBox5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._textBox5.Border.Class = "TextBoxBorder";
            this._textBox5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._textBox5.DisabledBackColor = System.Drawing.Color.White;
            this._textBox5.ForeColor = System.Drawing.Color.Black;
            this._textBox5.Location = new System.Drawing.Point(140, 104);
            this._textBox5.MaxLength = 100;
            this._textBox5.Name = "_textBox5";
            this._textBox5.Size = new System.Drawing.Size(40, 20);
            this._textBox5.TabIndex = 14;
            // 
            // _textBox2
            // 
            this._textBox2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._textBox2.Border.Class = "TextBoxBorder";
            this._textBox2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._textBox2.DisabledBackColor = System.Drawing.Color.White;
            this._textBox2.ForeColor = System.Drawing.Color.Black;
            this._textBox2.Location = new System.Drawing.Point(62, 61);
            this._textBox2.MaxLength = 100;
            this._textBox2.Name = "_textBox2";
            this._textBox2.Size = new System.Drawing.Size(40, 20);
            this._textBox2.TabIndex = 5;
            // 
            // _textBox6
            // 
            this._textBox6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._textBox6.Border.Class = "TextBoxBorder";
            this._textBox6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._textBox6.DisabledBackColor = System.Drawing.Color.White;
            this._textBox6.ForeColor = System.Drawing.Color.Black;
            this._textBox6.Location = new System.Drawing.Point(101, 104);
            this._textBox6.MaxLength = 100;
            this._textBox6.Name = "_textBox6";
            this._textBox6.Size = new System.Drawing.Size(40, 20);
            this._textBox6.TabIndex = 13;
            // 
            // _textBox3
            // 
            this._textBox3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._textBox3.Border.Class = "TextBoxBorder";
            this._textBox3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._textBox3.DisabledBackColor = System.Drawing.Color.White;
            this._textBox3.ForeColor = System.Drawing.Color.Black;
            this._textBox3.Location = new System.Drawing.Point(101, 61);
            this._textBox3.MaxLength = 100;
            this._textBox3.Name = "_textBox3";
            this._textBox3.Size = new System.Drawing.Size(40, 20);
            this._textBox3.TabIndex = 6;
            // 
            // _textBox7
            // 
            this._textBox7.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._textBox7.Border.Class = "TextBoxBorder";
            this._textBox7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._textBox7.DisabledBackColor = System.Drawing.Color.White;
            this._textBox7.ForeColor = System.Drawing.Color.Black;
            this._textBox7.Location = new System.Drawing.Point(62, 104);
            this._textBox7.MaxLength = 100;
            this._textBox7.Name = "_textBox7";
            this._textBox7.Size = new System.Drawing.Size(40, 20);
            this._textBox7.TabIndex = 12;
            // 
            // _textBox4
            // 
            this._textBox4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._textBox4.Border.Class = "TextBoxBorder";
            this._textBox4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._textBox4.DisabledBackColor = System.Drawing.Color.White;
            this._textBox4.ForeColor = System.Drawing.Color.Black;
            this._textBox4.Location = new System.Drawing.Point(140, 61);
            this._textBox4.MaxLength = 100;
            this._textBox4.Name = "_textBox4";
            this._textBox4.Size = new System.Drawing.Size(40, 20);
            this._textBox4.TabIndex = 7;
            // 
            // _label4
            // 
            // 
            // 
            // 
            this._label4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this._label4.Location = new System.Drawing.Point(140, 40);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(40, 15);
            this._label4.TabIndex = 11;
            this._label4.Text = "BB";
            this._label4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // _label1
            // 
            // 
            // 
            // 
            this._label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label1.Location = new System.Drawing.Point(3, 63);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(50, 15);
            this._label1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._label1.TabIndex = 8;
            this._label1.Text = "Standard:";
            // 
            // _label3
            // 
            // 
            // 
            // 
            this._label3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label3.ForeColor = System.Drawing.Color.Green;
            this._label3.Location = new System.Drawing.Point(101, 40);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(40, 15);
            this._label3.TabIndex = 10;
            this._label3.Text = "GG";
            this._label3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // _label2
            // 
            // 
            // 
            // 
            this._label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label2.ForeColor = System.Drawing.Color.Red;
            this._label2.Location = new System.Drawing.Point(62, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(40, 15);
            this._label2.TabIndex = 9;
            this._label2.Text = "RR";
            this._label2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // RGBEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 131);
            this.Controls.Add(this._panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RGBEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB Editor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Shown += new System.EventHandler(this.RGBEditor_Shown);
            this._panel1.ResumeLayout(false);
            this._panel1.PerformLayout();
            this._TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel _panel1;

        private Panel panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_panel1 != null)
                {
                }

                _panel1 = value;
                if (_panel1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _label6;

        private DevComponents.DotNetBar.LabelX label6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _label6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label6 != null)
                {
                }

                _label6 = value;
                if (_label6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _textBox8;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _textBox8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox8 != null)
                {
                }

                _textBox8 = value;
                if (_textBox8 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _comboBox1;

        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _comboBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_comboBox1 != null)
                {
                    _comboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
                }

                _comboBox1 = value;
                if (_comboBox1 != null)
                {
                    _comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _label5;

        private DevComponents.DotNetBar.LabelX label5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _label5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label5 != null)
                {
                }

                _label5 = value;
                if (_label5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _button2;

        private DevComponents.DotNetBar.ButtonX button2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _button2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_button2 != null)
                {
                    _button2.Click -= Button2_Click;
                }

                _button2 = value;
                if (_button2 != null)
                {
                    _button2.Click += Button2_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _textBox5;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _textBox5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox5 != null)
                {
                }

                _textBox5 = value;
                if (_textBox5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _textBox2;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _textBox2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox2 != null)
                {
                }

                _textBox2 = value;
                if (_textBox2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _textBox6;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _textBox6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox6 != null)
                {
                }

                _textBox6 = value;
                if (_textBox6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _textBox3;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _textBox3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox3 != null)
                {
                }

                _textBox3 = value;
                if (_textBox3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _textBox7;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _textBox7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox7 != null)
                {
                }

                _textBox7 = value;
                if (_textBox7 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _textBox4;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _textBox4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox4 != null)
                {
                }

                _textBox4 = value;
                if (_textBox4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _label4;

        private DevComponents.DotNetBar.LabelX label4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _label4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label4 != null)
                {
                }

                _label4 = value;
                if (_label4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _label1;

        private DevComponents.DotNetBar.LabelX label1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _label1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label1 != null)
                {
                }

                _label1 = value;
                if (_label1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _label3;

        private DevComponents.DotNetBar.LabelX label3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _label3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label3 != null)
                {
                }

                _label3 = value;
                if (_label3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _label2;

        private DevComponents.DotNetBar.LabelX label2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _label2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label2 != null)
                {
                }

                _label2 = value;
                if (_label2 != null)
                {
                }
            }
        }

        private TableLayoutPanel _TableLayoutPanel1;

        internal TableLayoutPanel TableLayoutPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel1 != null)
                {
                }

                _TableLayoutPanel1 = value;
                if (_TableLayoutPanel1 != null)
                {
                }
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

        private DevComponents.DotNetBar.ButtonX _ButtonX_Edit;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Edit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Edit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Edit != null)
                {
                    _ButtonX_Edit.Click -= ButtonX6_Click;
                }

                _ButtonX_Edit = value;
                if (_ButtonX_Edit != null)
                {
                    _ButtonX_Edit.Click += ButtonX6_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Remove;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Remove
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Remove;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Remove != null)
                {
                    _ButtonX_Remove.Click -= ButtonX4_Click;
                }

                _ButtonX_Remove = value;
                if (_ButtonX_Remove != null)
                {
                    _ButtonX_Remove.Click += ButtonX4_Click;
                }
            }
        }
    }
}