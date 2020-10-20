using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class LevelEditorInputManager : DevComponents.DotNetBar.OfficeForm
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
            this.TextBoxX_CamMoveLeft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.GroupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.LabelX9 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_CamMoveDown = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX10 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_CamMoveUp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_CamMoveBackward = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_CamMoveFordward = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_CamMoveRight = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GroupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.LabelX13 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_ObjMoveDown = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX14 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_ObjMoveUp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX5 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_ObjMoveBackward = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_ObjMoveFordward = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX7 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_ObjMoveRight = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX8 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_ObjMoveLeft = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GroupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.LabelX15 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_DropToGround = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX11 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_NextObj = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX12 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_LastObj = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GroupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.LabelX17 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_NextArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX18 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_LastArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            this.LabelX16 = new DevComponents.DotNetBar.LabelX();
            this.ButtonX5 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            this.GroupPanel1.SuspendLayout();
            this.GroupPanel2.SuspendLayout();
            this.GroupPanel3.SuspendLayout();
            this.GroupPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxX_CamMoveLeft
            // 
            this.TextBoxX_CamMoveLeft.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_CamMoveLeft.Border.Class = "TextBoxBorder";
            this.TextBoxX_CamMoveLeft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_CamMoveLeft.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_CamMoveLeft.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_CamMoveLeft.Location = new System.Drawing.Point(62, 4);
            this.TextBoxX_CamMoveLeft.Name = "TextBoxX_CamMoveLeft";
            this.TextBoxX_CamMoveLeft.PreventEnterBeep = true;
            this.TextBoxX_CamMoveLeft.ReadOnly = true;
            this.TextBoxX_CamMoveLeft.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_CamMoveLeft.TabIndex = 4;
            this.TextBoxX_CamMoveLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_CamMoveLeft.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_CamMoveLeft.TextChanged += new System.EventHandler(this.TextBoxX_CamMoveLeft_TextChanged);
            this.TextBoxX_CamMoveLeft.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(3, 3);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(53, 23);
            this.LabelX1.TabIndex = 5;
            this.LabelX1.Text = "Left";
            // 
            // GroupPanel1
            // 
            this.GroupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel1.CanvasColor = System.Drawing.Color.Transparent;
            this.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GroupPanel1.Controls.Add(this.LabelX9);
            this.GroupPanel1.Controls.Add(this.TextBoxX_CamMoveDown);
            this.GroupPanel1.Controls.Add(this.LabelX10);
            this.GroupPanel1.Controls.Add(this.TextBoxX_CamMoveUp);
            this.GroupPanel1.Controls.Add(this.LabelX3);
            this.GroupPanel1.Controls.Add(this.TextBoxX_CamMoveBackward);
            this.GroupPanel1.Controls.Add(this.LabelX4);
            this.GroupPanel1.Controls.Add(this.TextBoxX_CamMoveFordward);
            this.GroupPanel1.Controls.Add(this.LabelX2);
            this.GroupPanel1.Controls.Add(this.TextBoxX_CamMoveRight);
            this.GroupPanel1.Controls.Add(this.LabelX1);
            this.GroupPanel1.Controls.Add(this.TextBoxX_CamMoveLeft);
            this.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.GroupPanel1.Location = new System.Drawing.Point(12, 41);
            this.GroupPanel1.Name = "GroupPanel1";
            this.GroupPanel1.Size = new System.Drawing.Size(174, 197);
            // 
            // 
            // 
            this.GroupPanel1.Style.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GroupPanel1.Style.BackColorGradientAngle = 90;
            this.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderBottomWidth = 1;
            this.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderLeftWidth = 1;
            this.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderRightWidth = 1;
            this.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderTopWidth = 1;
            this.GroupPanel1.Style.CornerDiameter = 4;
            this.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupPanel1.TabIndex = 6;
            this.GroupPanel1.Text = "Camera Movement";
            // 
            // LabelX9
            // 
            // 
            // 
            // 
            this.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX9.Location = new System.Drawing.Point(3, 148);
            this.LabelX9.Name = "LabelX9";
            this.LabelX9.Size = new System.Drawing.Size(53, 23);
            this.LabelX9.TabIndex = 15;
            this.LabelX9.Text = "Down";
            // 
            // TextBoxX_CamMoveDown
            // 
            this.TextBoxX_CamMoveDown.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_CamMoveDown.Border.Class = "TextBoxBorder";
            this.TextBoxX_CamMoveDown.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_CamMoveDown.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_CamMoveDown.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_CamMoveDown.Location = new System.Drawing.Point(62, 149);
            this.TextBoxX_CamMoveDown.Name = "TextBoxX_CamMoveDown";
            this.TextBoxX_CamMoveDown.PreventEnterBeep = true;
            this.TextBoxX_CamMoveDown.ReadOnly = true;
            this.TextBoxX_CamMoveDown.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_CamMoveDown.TabIndex = 14;
            this.TextBoxX_CamMoveDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_CamMoveDown.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_CamMoveDown.TextChanged += new System.EventHandler(this.TextBoxX_CamMoveDown_TextChanged);
            this.TextBoxX_CamMoveDown.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX10
            // 
            // 
            // 
            // 
            this.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX10.Location = new System.Drawing.Point(3, 119);
            this.LabelX10.Name = "LabelX10";
            this.LabelX10.Size = new System.Drawing.Size(53, 23);
            this.LabelX10.TabIndex = 13;
            this.LabelX10.Text = "Up";
            // 
            // TextBoxX_CamMoveUp
            // 
            this.TextBoxX_CamMoveUp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_CamMoveUp.Border.Class = "TextBoxBorder";
            this.TextBoxX_CamMoveUp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_CamMoveUp.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_CamMoveUp.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_CamMoveUp.Location = new System.Drawing.Point(62, 120);
            this.TextBoxX_CamMoveUp.Name = "TextBoxX_CamMoveUp";
            this.TextBoxX_CamMoveUp.PreventEnterBeep = true;
            this.TextBoxX_CamMoveUp.ReadOnly = true;
            this.TextBoxX_CamMoveUp.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_CamMoveUp.TabIndex = 12;
            this.TextBoxX_CamMoveUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_CamMoveUp.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_CamMoveUp.TextChanged += new System.EventHandler(this.TextBoxX_CamMoveUp_TextChanged);
            this.TextBoxX_CamMoveUp.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX3.Location = new System.Drawing.Point(3, 90);
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.Size = new System.Drawing.Size(53, 23);
            this.LabelX3.TabIndex = 11;
            this.LabelX3.Text = "Backward";
            // 
            // TextBoxX_CamMoveBackward
            // 
            this.TextBoxX_CamMoveBackward.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_CamMoveBackward.Border.Class = "TextBoxBorder";
            this.TextBoxX_CamMoveBackward.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_CamMoveBackward.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_CamMoveBackward.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_CamMoveBackward.Location = new System.Drawing.Point(62, 91);
            this.TextBoxX_CamMoveBackward.Name = "TextBoxX_CamMoveBackward";
            this.TextBoxX_CamMoveBackward.PreventEnterBeep = true;
            this.TextBoxX_CamMoveBackward.ReadOnly = true;
            this.TextBoxX_CamMoveBackward.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_CamMoveBackward.TabIndex = 10;
            this.TextBoxX_CamMoveBackward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_CamMoveBackward.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_CamMoveBackward.TextChanged += new System.EventHandler(this.TextBoxX_CamMoveBackward_TextChanged);
            this.TextBoxX_CamMoveBackward.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX4
            // 
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX4.Location = new System.Drawing.Point(3, 61);
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Size = new System.Drawing.Size(53, 23);
            this.LabelX4.TabIndex = 9;
            this.LabelX4.Text = "Fordward";
            // 
            // TextBoxX_CamMoveFordward
            // 
            this.TextBoxX_CamMoveFordward.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_CamMoveFordward.Border.Class = "TextBoxBorder";
            this.TextBoxX_CamMoveFordward.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_CamMoveFordward.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_CamMoveFordward.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_CamMoveFordward.Location = new System.Drawing.Point(62, 62);
            this.TextBoxX_CamMoveFordward.Name = "TextBoxX_CamMoveFordward";
            this.TextBoxX_CamMoveFordward.PreventEnterBeep = true;
            this.TextBoxX_CamMoveFordward.ReadOnly = true;
            this.TextBoxX_CamMoveFordward.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_CamMoveFordward.TabIndex = 8;
            this.TextBoxX_CamMoveFordward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_CamMoveFordward.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_CamMoveFordward.TextChanged += new System.EventHandler(this.TextBoxX_CamMoveFordward_TextChanged);
            this.TextBoxX_CamMoveFordward.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX2.Location = new System.Drawing.Point(3, 32);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(53, 23);
            this.LabelX2.TabIndex = 7;
            this.LabelX2.Text = "Right";
            // 
            // TextBoxX_CamMoveRight
            // 
            this.TextBoxX_CamMoveRight.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_CamMoveRight.Border.Class = "TextBoxBorder";
            this.TextBoxX_CamMoveRight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_CamMoveRight.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_CamMoveRight.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_CamMoveRight.Location = new System.Drawing.Point(62, 33);
            this.TextBoxX_CamMoveRight.Name = "TextBoxX_CamMoveRight";
            this.TextBoxX_CamMoveRight.PreventEnterBeep = true;
            this.TextBoxX_CamMoveRight.ReadOnly = true;
            this.TextBoxX_CamMoveRight.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_CamMoveRight.TabIndex = 6;
            this.TextBoxX_CamMoveRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_CamMoveRight.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_CamMoveRight.TextChanged += new System.EventHandler(this.TextBoxX_CamMoveRight_TextChanged);
            this.TextBoxX_CamMoveRight.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // GroupPanel2
            // 
            this.GroupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel2.CanvasColor = System.Drawing.Color.Transparent;
            this.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GroupPanel2.Controls.Add(this.LabelX13);
            this.GroupPanel2.Controls.Add(this.TextBoxX_ObjMoveDown);
            this.GroupPanel2.Controls.Add(this.LabelX14);
            this.GroupPanel2.Controls.Add(this.TextBoxX_ObjMoveUp);
            this.GroupPanel2.Controls.Add(this.LabelX5);
            this.GroupPanel2.Controls.Add(this.TextBoxX_ObjMoveBackward);
            this.GroupPanel2.Controls.Add(this.LabelX6);
            this.GroupPanel2.Controls.Add(this.TextBoxX_ObjMoveFordward);
            this.GroupPanel2.Controls.Add(this.LabelX7);
            this.GroupPanel2.Controls.Add(this.TextBoxX_ObjMoveRight);
            this.GroupPanel2.Controls.Add(this.LabelX8);
            this.GroupPanel2.Controls.Add(this.TextBoxX_ObjMoveLeft);
            this.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.GroupPanel2.Location = new System.Drawing.Point(192, 41);
            this.GroupPanel2.Name = "GroupPanel2";
            this.GroupPanel2.Size = new System.Drawing.Size(174, 197);
            // 
            // 
            // 
            this.GroupPanel2.Style.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GroupPanel2.Style.BackColorGradientAngle = 90;
            this.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderBottomWidth = 1;
            this.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderLeftWidth = 1;
            this.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderRightWidth = 1;
            this.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderTopWidth = 1;
            this.GroupPanel2.Style.CornerDiameter = 4;
            this.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupPanel2.TabIndex = 7;
            this.GroupPanel2.Text = "Object Movement";
            // 
            // LabelX13
            // 
            // 
            // 
            // 
            this.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX13.Location = new System.Drawing.Point(3, 148);
            this.LabelX13.Name = "LabelX13";
            this.LabelX13.Size = new System.Drawing.Size(53, 23);
            this.LabelX13.TabIndex = 19;
            this.LabelX13.Text = "Down";
            // 
            // TextBoxX_ObjMoveDown
            // 
            this.TextBoxX_ObjMoveDown.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ObjMoveDown.Border.Class = "TextBoxBorder";
            this.TextBoxX_ObjMoveDown.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ObjMoveDown.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ObjMoveDown.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ObjMoveDown.Location = new System.Drawing.Point(62, 149);
            this.TextBoxX_ObjMoveDown.Name = "TextBoxX_ObjMoveDown";
            this.TextBoxX_ObjMoveDown.PreventEnterBeep = true;
            this.TextBoxX_ObjMoveDown.ReadOnly = true;
            this.TextBoxX_ObjMoveDown.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_ObjMoveDown.TabIndex = 18;
            this.TextBoxX_ObjMoveDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_ObjMoveDown.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_ObjMoveDown.TextChanged += new System.EventHandler(this.TextBoxX_ObjMoveDown_TextChanged);
            this.TextBoxX_ObjMoveDown.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX14
            // 
            // 
            // 
            // 
            this.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX14.Location = new System.Drawing.Point(3, 119);
            this.LabelX14.Name = "LabelX14";
            this.LabelX14.Size = new System.Drawing.Size(53, 23);
            this.LabelX14.TabIndex = 17;
            this.LabelX14.Text = "Up";
            // 
            // TextBoxX_ObjMoveUp
            // 
            this.TextBoxX_ObjMoveUp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ObjMoveUp.Border.Class = "TextBoxBorder";
            this.TextBoxX_ObjMoveUp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ObjMoveUp.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ObjMoveUp.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ObjMoveUp.Location = new System.Drawing.Point(62, 120);
            this.TextBoxX_ObjMoveUp.Name = "TextBoxX_ObjMoveUp";
            this.TextBoxX_ObjMoveUp.PreventEnterBeep = true;
            this.TextBoxX_ObjMoveUp.ReadOnly = true;
            this.TextBoxX_ObjMoveUp.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_ObjMoveUp.TabIndex = 16;
            this.TextBoxX_ObjMoveUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_ObjMoveUp.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_ObjMoveUp.TextChanged += new System.EventHandler(this.TextBoxX_ObjMoveUp_TextChanged);
            this.TextBoxX_ObjMoveUp.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX5
            // 
            // 
            // 
            // 
            this.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX5.Location = new System.Drawing.Point(3, 90);
            this.LabelX5.Name = "LabelX5";
            this.LabelX5.Size = new System.Drawing.Size(53, 23);
            this.LabelX5.TabIndex = 11;
            this.LabelX5.Text = "Backward";
            // 
            // TextBoxX_ObjMoveBackward
            // 
            this.TextBoxX_ObjMoveBackward.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ObjMoveBackward.Border.Class = "TextBoxBorder";
            this.TextBoxX_ObjMoveBackward.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ObjMoveBackward.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ObjMoveBackward.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ObjMoveBackward.Location = new System.Drawing.Point(62, 91);
            this.TextBoxX_ObjMoveBackward.Name = "TextBoxX_ObjMoveBackward";
            this.TextBoxX_ObjMoveBackward.PreventEnterBeep = true;
            this.TextBoxX_ObjMoveBackward.ReadOnly = true;
            this.TextBoxX_ObjMoveBackward.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_ObjMoveBackward.TabIndex = 10;
            this.TextBoxX_ObjMoveBackward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_ObjMoveBackward.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_ObjMoveBackward.TextChanged += new System.EventHandler(this.TextBoxX_ObjMoveBackward_TextChanged);
            this.TextBoxX_ObjMoveBackward.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX6
            // 
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX6.Location = new System.Drawing.Point(3, 61);
            this.LabelX6.Name = "LabelX6";
            this.LabelX6.Size = new System.Drawing.Size(53, 23);
            this.LabelX6.TabIndex = 9;
            this.LabelX6.Text = "Fordward";
            // 
            // TextBoxX_ObjMoveFordward
            // 
            this.TextBoxX_ObjMoveFordward.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ObjMoveFordward.Border.Class = "TextBoxBorder";
            this.TextBoxX_ObjMoveFordward.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ObjMoveFordward.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ObjMoveFordward.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ObjMoveFordward.Location = new System.Drawing.Point(62, 62);
            this.TextBoxX_ObjMoveFordward.Name = "TextBoxX_ObjMoveFordward";
            this.TextBoxX_ObjMoveFordward.PreventEnterBeep = true;
            this.TextBoxX_ObjMoveFordward.ReadOnly = true;
            this.TextBoxX_ObjMoveFordward.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_ObjMoveFordward.TabIndex = 8;
            this.TextBoxX_ObjMoveFordward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_ObjMoveFordward.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_ObjMoveFordward.TextChanged += new System.EventHandler(this.TextBoxX_ObjMoveFordward_TextChanged);
            this.TextBoxX_ObjMoveFordward.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX7
            // 
            // 
            // 
            // 
            this.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX7.Location = new System.Drawing.Point(3, 32);
            this.LabelX7.Name = "LabelX7";
            this.LabelX7.Size = new System.Drawing.Size(53, 23);
            this.LabelX7.TabIndex = 7;
            this.LabelX7.Text = "Right";
            // 
            // TextBoxX_ObjMoveRight
            // 
            this.TextBoxX_ObjMoveRight.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ObjMoveRight.Border.Class = "TextBoxBorder";
            this.TextBoxX_ObjMoveRight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ObjMoveRight.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ObjMoveRight.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ObjMoveRight.Location = new System.Drawing.Point(62, 33);
            this.TextBoxX_ObjMoveRight.Name = "TextBoxX_ObjMoveRight";
            this.TextBoxX_ObjMoveRight.PreventEnterBeep = true;
            this.TextBoxX_ObjMoveRight.ReadOnly = true;
            this.TextBoxX_ObjMoveRight.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_ObjMoveRight.TabIndex = 6;
            this.TextBoxX_ObjMoveRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_ObjMoveRight.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_ObjMoveRight.TextChanged += new System.EventHandler(this.TextBoxX_ObjMoveRight_TextChanged);
            this.TextBoxX_ObjMoveRight.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX8
            // 
            // 
            // 
            // 
            this.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX8.Location = new System.Drawing.Point(3, 3);
            this.LabelX8.Name = "LabelX8";
            this.LabelX8.Size = new System.Drawing.Size(53, 23);
            this.LabelX8.TabIndex = 5;
            this.LabelX8.Text = "Left";
            // 
            // TextBoxX_ObjMoveLeft
            // 
            this.TextBoxX_ObjMoveLeft.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ObjMoveLeft.Border.Class = "TextBoxBorder";
            this.TextBoxX_ObjMoveLeft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ObjMoveLeft.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ObjMoveLeft.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ObjMoveLeft.Location = new System.Drawing.Point(62, 4);
            this.TextBoxX_ObjMoveLeft.Name = "TextBoxX_ObjMoveLeft";
            this.TextBoxX_ObjMoveLeft.PreventEnterBeep = true;
            this.TextBoxX_ObjMoveLeft.ReadOnly = true;
            this.TextBoxX_ObjMoveLeft.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_ObjMoveLeft.TabIndex = 4;
            this.TextBoxX_ObjMoveLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_ObjMoveLeft.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_ObjMoveLeft.TextChanged += new System.EventHandler(this.TextBoxX_ObjMoveLeft_TextChanged);
            this.TextBoxX_ObjMoveLeft.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // GroupPanel3
            // 
            this.GroupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel3.CanvasColor = System.Drawing.Color.Transparent;
            this.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GroupPanel3.Controls.Add(this.LabelX15);
            this.GroupPanel3.Controls.Add(this.TextBoxX_DropToGround);
            this.GroupPanel3.Controls.Add(this.LabelX11);
            this.GroupPanel3.Controls.Add(this.TextBoxX_NextObj);
            this.GroupPanel3.Controls.Add(this.LabelX12);
            this.GroupPanel3.Controls.Add(this.TextBoxX_LastObj);
            this.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.GroupPanel3.Location = new System.Drawing.Point(372, 41);
            this.GroupPanel3.Name = "GroupPanel3";
            this.GroupPanel3.Size = new System.Drawing.Size(216, 110);
            // 
            // 
            // 
            this.GroupPanel3.Style.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GroupPanel3.Style.BackColorGradientAngle = 90;
            this.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel3.Style.BorderBottomWidth = 1;
            this.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel3.Style.BorderLeftWidth = 1;
            this.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel3.Style.BorderRightWidth = 1;
            this.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel3.Style.BorderTopWidth = 1;
            this.GroupPanel3.Style.CornerDiameter = 4;
            this.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupPanel3.TabIndex = 8;
            this.GroupPanel3.Text = "Object Properties";
            // 
            // LabelX15
            // 
            // 
            // 
            // 
            this.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX15.Location = new System.Drawing.Point(3, 61);
            this.LabelX15.Name = "LabelX15";
            this.LabelX15.Size = new System.Drawing.Size(94, 23);
            this.LabelX15.TabIndex = 9;
            this.LabelX15.Text = "Top to Ground";
            // 
            // TextBoxX_DropToGround
            // 
            this.TextBoxX_DropToGround.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_DropToGround.Border.Class = "TextBoxBorder";
            this.TextBoxX_DropToGround.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_DropToGround.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_DropToGround.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_DropToGround.Location = new System.Drawing.Point(103, 62);
            this.TextBoxX_DropToGround.Name = "TextBoxX_DropToGround";
            this.TextBoxX_DropToGround.PreventEnterBeep = true;
            this.TextBoxX_DropToGround.ReadOnly = true;
            this.TextBoxX_DropToGround.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_DropToGround.TabIndex = 8;
            this.TextBoxX_DropToGround.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_DropToGround.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_DropToGround.TextChanged += new System.EventHandler(this.TextBoxX_TopToGround_TextChanged);
            this.TextBoxX_DropToGround.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX11
            // 
            // 
            // 
            // 
            this.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX11.Location = new System.Drawing.Point(3, 32);
            this.LabelX11.Name = "LabelX11";
            this.LabelX11.Size = new System.Drawing.Size(94, 23);
            this.LabelX11.TabIndex = 7;
            this.LabelX11.Text = "Next Object in List";
            // 
            // TextBoxX_NextObj
            // 
            this.TextBoxX_NextObj.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_NextObj.Border.Class = "TextBoxBorder";
            this.TextBoxX_NextObj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_NextObj.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_NextObj.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_NextObj.Location = new System.Drawing.Point(103, 33);
            this.TextBoxX_NextObj.Name = "TextBoxX_NextObj";
            this.TextBoxX_NextObj.PreventEnterBeep = true;
            this.TextBoxX_NextObj.ReadOnly = true;
            this.TextBoxX_NextObj.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_NextObj.TabIndex = 6;
            this.TextBoxX_NextObj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_NextObj.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_NextObj.TextChanged += new System.EventHandler(this.TextBoxX_NextObj_TextChanged);
            this.TextBoxX_NextObj.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX12
            // 
            // 
            // 
            // 
            this.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX12.Location = new System.Drawing.Point(3, 3);
            this.LabelX12.Name = "LabelX12";
            this.LabelX12.Size = new System.Drawing.Size(94, 23);
            this.LabelX12.TabIndex = 5;
            this.LabelX12.Text = "Last Object in List";
            // 
            // TextBoxX_LastObj
            // 
            this.TextBoxX_LastObj.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_LastObj.Border.Class = "TextBoxBorder";
            this.TextBoxX_LastObj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_LastObj.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_LastObj.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_LastObj.Location = new System.Drawing.Point(103, 4);
            this.TextBoxX_LastObj.Name = "TextBoxX_LastObj";
            this.TextBoxX_LastObj.PreventEnterBeep = true;
            this.TextBoxX_LastObj.ReadOnly = true;
            this.TextBoxX_LastObj.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_LastObj.TabIndex = 4;
            this.TextBoxX_LastObj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_LastObj.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_LastObj.TextChanged += new System.EventHandler(this.TextBoxX_LastObj_TextChanged);
            this.TextBoxX_LastObj.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // GroupPanel4
            // 
            this.GroupPanel4.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel4.CanvasColor = System.Drawing.Color.Transparent;
            this.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GroupPanel4.Controls.Add(this.LabelX17);
            this.GroupPanel4.Controls.Add(this.TextBoxX_NextArea);
            this.GroupPanel4.Controls.Add(this.LabelX18);
            this.GroupPanel4.Controls.Add(this.TextBoxX_LastArea);
            this.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.GroupPanel4.Location = new System.Drawing.Point(372, 157);
            this.GroupPanel4.Name = "GroupPanel4";
            this.GroupPanel4.Size = new System.Drawing.Size(216, 81);
            // 
            // 
            // 
            this.GroupPanel4.Style.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GroupPanel4.Style.BackColorGradientAngle = 90;
            this.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel4.Style.BorderBottomWidth = 1;
            this.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel4.Style.BorderLeftWidth = 1;
            this.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel4.Style.BorderRightWidth = 1;
            this.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel4.Style.BorderTopWidth = 1;
            this.GroupPanel4.Style.CornerDiameter = 4;
            this.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupPanel4.TabIndex = 9;
            this.GroupPanel4.Text = "Area selection";
            // 
            // LabelX17
            // 
            // 
            // 
            // 
            this.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX17.Location = new System.Drawing.Point(3, 32);
            this.LabelX17.Name = "LabelX17";
            this.LabelX17.Size = new System.Drawing.Size(94, 23);
            this.LabelX17.TabIndex = 7;
            this.LabelX17.Text = "Next Area";
            // 
            // TextBoxX_NextArea
            // 
            this.TextBoxX_NextArea.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_NextArea.Border.Class = "TextBoxBorder";
            this.TextBoxX_NextArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_NextArea.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_NextArea.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_NextArea.Location = new System.Drawing.Point(103, 33);
            this.TextBoxX_NextArea.Name = "TextBoxX_NextArea";
            this.TextBoxX_NextArea.PreventEnterBeep = true;
            this.TextBoxX_NextArea.ReadOnly = true;
            this.TextBoxX_NextArea.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_NextArea.TabIndex = 6;
            this.TextBoxX_NextArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_NextArea.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_NextArea.TextChanged += new System.EventHandler(this.TextBoxX_NextArea_TextChanged);
            this.TextBoxX_NextArea.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // LabelX18
            // 
            // 
            // 
            // 
            this.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX18.Location = new System.Drawing.Point(3, 3);
            this.LabelX18.Name = "LabelX18";
            this.LabelX18.Size = new System.Drawing.Size(94, 23);
            this.LabelX18.TabIndex = 5;
            this.LabelX18.Text = "Last Area";
            // 
            // TextBoxX_LastArea
            // 
            this.TextBoxX_LastArea.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_LastArea.Border.Class = "TextBoxBorder";
            this.TextBoxX_LastArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_LastArea.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_LastArea.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_LastArea.Location = new System.Drawing.Point(103, 4);
            this.TextBoxX_LastArea.Name = "TextBoxX_LastArea";
            this.TextBoxX_LastArea.PreventEnterBeep = true;
            this.TextBoxX_LastArea.ReadOnly = true;
            this.TextBoxX_LastArea.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_LastArea.TabIndex = 4;
            this.TextBoxX_LastArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxX_LastArea.Click += new System.EventHandler(this.TextBoxX_Click);
            this.TextBoxX_LastArea.TextChanged += new System.EventHandler(this.TextBoxX_LastArea_TextChanged);
            this.TextBoxX_LastArea.LostFocus += new System.EventHandler(this.TextBoxX_LostFocus_TextChanged);
            // 
            // ComboBoxEx1
            // 
            this.ComboBoxEx1.DisplayMember = "Text";
            this.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx1.FormattingEnabled = true;
            this.ComboBoxEx1.ItemHeight = 15;
            this.ComboBoxEx1.Location = new System.Drawing.Point(77, 13);
            this.ComboBoxEx1.Name = "ComboBoxEx1";
            this.ComboBoxEx1.Size = new System.Drawing.Size(198, 21);
            this.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx1.TabIndex = 0;
            this.ComboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx1_SelectedIndexChanged);
            // 
            // ButtonX4
            // 
            this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX4.FocusCuesEnabled = false;
            this.ButtonX4.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_refresh_16px;
            this.ButtonX4.Location = new System.Drawing.Point(281, 12);
            this.ButtonX4.Name = "ButtonX4";
            this.ButtonX4.Size = new System.Drawing.Size(23, 23);
            this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX4.TabIndex = 10;
            this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
            // 
            // LabelX16
            // 
            // 
            // 
            // 
            this.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX16.Location = new System.Drawing.Point(12, 12);
            this.LabelX16.Name = "LabelX16";
            this.LabelX16.Size = new System.Drawing.Size(59, 23);
            this.LabelX16.TabIndex = 11;
            this.LabelX16.Text = "Controller:";
            // 
            // ButtonX5
            // 
            this.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX5.FocusCuesEnabled = false;
            this.ButtonX5.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_save_16px;
            this.ButtonX5.Location = new System.Drawing.Point(352, 12);
            this.ButtonX5.Name = "ButtonX5";
            this.ButtonX5.Size = new System.Drawing.Size(121, 23);
            this.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX5.TabIndex = 12;
            this.ButtonX5.Text = "Save Profile as ...";
            this.ButtonX5.Click += new System.EventHandler(this.ButtonX5_Click);
            // 
            // ButtonX6
            // 
            this.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX6.FocusCuesEnabled = false;
            this.ButtonX6.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_folder_16px;
            this.ButtonX6.Location = new System.Drawing.Point(479, 12);
            this.ButtonX6.Name = "ButtonX6";
            this.ButtonX6.Size = new System.Drawing.Size(109, 23);
            this.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX6.TabIndex = 13;
            this.ButtonX6.Text = "Load Profile ...";
            this.ButtonX6.Click += new System.EventHandler(this.ButtonX6_Click);
            // 
            // LevelEditorInputManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 248);
            this.Controls.Add(this.ButtonX6);
            this.Controls.Add(this.ButtonX5);
            this.Controls.Add(this.LabelX16);
            this.Controls.Add(this.GroupPanel1);
            this.Controls.Add(this.ButtonX4);
            this.Controls.Add(this.ComboBoxEx1);
            this.Controls.Add(this.GroupPanel4);
            this.Controls.Add(this.GroupPanel3);
            this.Controls.Add(this.GroupPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LevelEditorInputManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Manager";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.GroupPanel1.ResumeLayout(false);
            this.GroupPanel2.ResumeLayout(false);
            this.GroupPanel3.ResumeLayout(false);
            this.GroupPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveLeft;

        private DevComponents.DotNetBar.LabelX LabelX1;

        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel1;

        private DevComponents.DotNetBar.LabelX LabelX3;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveBackward;

        private DevComponents.DotNetBar.LabelX LabelX4;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveFordward;

        private DevComponents.DotNetBar.LabelX LabelX2;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveRight;

        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel2;

        private DevComponents.DotNetBar.LabelX LabelX5;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveBackward;

        private DevComponents.DotNetBar.LabelX LabelX6;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveFordward;

        private DevComponents.DotNetBar.LabelX LabelX7;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveRight;

        private DevComponents.DotNetBar.LabelX LabelX8;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveLeft;

        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel3;

        private DevComponents.DotNetBar.LabelX LabelX11;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_NextObj;

        private DevComponents.DotNetBar.LabelX LabelX12;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_LastObj;

        private DevComponents.DotNetBar.LabelX LabelX9;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveDown;

        private DevComponents.DotNetBar.LabelX LabelX10;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveUp;

        private DevComponents.DotNetBar.LabelX LabelX13;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveDown;

        private DevComponents.DotNetBar.LabelX LabelX14;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveUp;

        private DevComponents.DotNetBar.LabelX LabelX15;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_DropToGround;

        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel4;

        private DevComponents.DotNetBar.LabelX LabelX17;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_NextArea;

        private DevComponents.DotNetBar.LabelX LabelX18;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_LastArea;

        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx1;

        private DevComponents.DotNetBar.ButtonX ButtonX4;

        private DevComponents.DotNetBar.LabelX LabelX16;

        private DevComponents.DotNetBar.ButtonX ButtonX5;

        private DevComponents.DotNetBar.ButtonX ButtonX6;

    }
}