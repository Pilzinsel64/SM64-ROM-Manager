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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Edit = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Remove = new DevComponents.DotNetBar.ButtonX();
            this.label6 = new DevComponents.DotNetBar.LabelX();
            this.textBox8 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBox1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label5 = new DevComponents.DotNetBar.LabelX();
            this.button2 = new DevComponents.DotNetBar.ButtonX();
            this.textBox5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox6 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new DevComponents.DotNetBar.LabelX();
            this.label3 = new DevComponents.DotNetBar.LabelX();
            this.label2 = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.TableLayoutPanel1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 131);
            this.panel1.TabIndex = 20;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel1.ColumnCount = 3;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Controls.Add(this.ButtonX1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonX_Edit, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonX_Remove, 2, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(191, 1);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(78, 26);
            this.TableLayoutPanel1.TabIndex = 48;
            // 
            // ButtonX1
            // 
            this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX1.FocusCuesEnabled = false;
            this.ButtonX1.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonX1.Location = new System.Drawing.Point(3, 3);
            this.ButtonX1.Name = "ButtonX1";
            this.ButtonX1.Size = new System.Drawing.Size(20, 20);
            this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX1.TabIndex = 42;
            this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // ButtonX_Edit
            // 
            this.ButtonX_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonX_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX_Edit.FocusCuesEnabled = false;
            this.ButtonX_Edit.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonX_Edit.Location = new System.Drawing.Point(29, 3);
            this.ButtonX_Edit.Name = "ButtonX_Edit";
            this.ButtonX_Edit.Size = new System.Drawing.Size(20, 20);
            this.ButtonX_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Edit.TabIndex = 44;
            this.ButtonX_Edit.Click += new System.EventHandler(this.ButtonX6_Click);
            // 
            // ButtonX_Remove
            // 
            this.ButtonX_Remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonX_Remove.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX_Remove.FocusCuesEnabled = false;
            this.ButtonX_Remove.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonX_Remove.Location = new System.Drawing.Point(55, 3);
            this.ButtonX_Remove.Name = "ButtonX_Remove";
            this.ButtonX_Remove.Size = new System.Drawing.Size(20, 20);
            this.ButtonX_Remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Remove.TabIndex = 45;
            this.ButtonX_Remove.Click += new System.EventHandler(this.ButtonX4_Click);
            // 
            // label6
            // 
            // 
            // 
            // 
            this.label6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(210, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "AA";
            this.label6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBox8.Border.Class = "TextBoxBorder";
            this.textBox8.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox8.DisabledBackColor = System.Drawing.Color.White;
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(210, 61);
            this.textBox8.MaxLength = 100;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(40, 20);
            this.textBox8.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 15;
            this.comboBox1.Location = new System.Drawing.Point(3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            // 
            // 
            // 
            this.label5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.label5.TabIndex = 15;
            this.label5.Text = "Shading:";
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button2.Enabled = false;
            this.button2.FocusCuesEnabled = false;
            this.button2.Location = new System.Drawing.Point(191, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button2.TabIndex = 4;
            this.button2.Text = "Patch";
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBox5.Border.Class = "TextBoxBorder";
            this.textBox5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox5.DisabledBackColor = System.Drawing.Color.White;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(140, 104);
            this.textBox5.MaxLength = 100;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBox2.Border.Class = "TextBoxBorder";
            this.textBox2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox2.DisabledBackColor = System.Drawing.Color.White;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(62, 61);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBox6.Border.Class = "TextBoxBorder";
            this.textBox6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox6.DisabledBackColor = System.Drawing.Color.White;
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(101, 104);
            this.textBox6.MaxLength = 100;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBox3.Border.Class = "TextBoxBorder";
            this.textBox3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox3.DisabledBackColor = System.Drawing.Color.White;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(101, 61);
            this.textBox3.MaxLength = 100;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBox7.Border.Class = "TextBoxBorder";
            this.textBox7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox7.DisabledBackColor = System.Drawing.Color.White;
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(62, 104);
            this.textBox7.MaxLength = 100;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(40, 20);
            this.textBox7.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBox4.Border.Class = "TextBoxBorder";
            this.textBox4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox4.DisabledBackColor = System.Drawing.Color.White;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(140, 61);
            this.textBox4.MaxLength = 100;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            // 
            // 
            // 
            this.label4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(140, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "BB";
            this.label4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.label1.TabIndex = 8;
            this.label1.Text = "Standard:";
            // 
            // label3
            // 
            // 
            // 
            // 
            this.label3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(101, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "GG";
            this.label3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            // 
            // 
            // 
            this.label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(62, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "RR";
            this.label2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // RGBEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 131);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RGBEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB Editor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Shown += new System.EventHandler(this.RGBEditor_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel panel1;

        private DevComponents.DotNetBar.LabelX label6;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox8;

        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox1;

        private DevComponents.DotNetBar.LabelX label5;

        private DevComponents.DotNetBar.ButtonX button2;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox5;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox2;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox6;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox3;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox7;

        private DevComponents.DotNetBar.Controls.TextBoxX textBox4;

        private DevComponents.DotNetBar.LabelX label4;

        private DevComponents.DotNetBar.LabelX label1;

        private DevComponents.DotNetBar.LabelX label3;

        private DevComponents.DotNetBar.LabelX label2;

        private TableLayoutPanel TableLayoutPanel1;

        private DevComponents.DotNetBar.ButtonX ButtonX1;

        private DevComponents.DotNetBar.ButtonX ButtonX_Edit;

        private DevComponents.DotNetBar.ButtonX ButtonX_Remove;

    }
}