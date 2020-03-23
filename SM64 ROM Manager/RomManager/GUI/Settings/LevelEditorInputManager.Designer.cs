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
            _TextBoxX_CamMoveLeft = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_CamMoveLeft.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveLeft.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveLeft.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveLeft.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveLeft.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_CamMoveLeft.TextChanged += new EventHandler(TextBoxX_CamMoveLeft_TextChanged);
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _GroupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            _LabelX9 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_CamMoveDown = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_CamMoveDown.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveDown.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveDown.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveDown.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveDown.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_CamMoveDown.TextChanged += new EventHandler(TextBoxX_CamMoveDown_TextChanged);
            _LabelX10 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_CamMoveUp = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_CamMoveUp.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveUp.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveUp.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveUp.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveUp.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_CamMoveUp.TextChanged += new EventHandler(TextBoxX_CamMoveUp_TextChanged);
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_CamMoveBackward = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_CamMoveBackward.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveBackward.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveBackward.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveBackward.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveBackward.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_CamMoveBackward.TextChanged += new EventHandler(TextBoxX_CamMoveBackward_TextChanged);
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_CamMoveFordward = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_CamMoveFordward.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveFordward.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveFordward.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveFordward.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveFordward.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_CamMoveFordward.TextChanged += new EventHandler(TextBoxX_CamMoveFordward_TextChanged);
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_CamMoveRight = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_CamMoveRight.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveRight.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveRight.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveRight.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_CamMoveRight.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_CamMoveRight.TextChanged += new EventHandler(TextBoxX_CamMoveRight_TextChanged);
            _GroupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            _LabelX13 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_ObjMoveDown = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ObjMoveDown.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveDown.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveDown.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveDown.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveDown.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_ObjMoveDown.TextChanged += new EventHandler(TextBoxX_ObjMoveDown_TextChanged);
            _LabelX14 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_ObjMoveUp = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ObjMoveUp.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveUp.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveUp.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveUp.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveUp.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_ObjMoveUp.TextChanged += new EventHandler(TextBoxX_ObjMoveUp_TextChanged);
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_ObjMoveBackward = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ObjMoveBackward.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveBackward.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveBackward.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveBackward.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveBackward.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_ObjMoveBackward.TextChanged += new EventHandler(TextBoxX_ObjMoveBackward_TextChanged);
            _LabelX6 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_ObjMoveFordward = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ObjMoveFordward.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveFordward.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveFordward.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveFordward.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveFordward.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_ObjMoveFordward.TextChanged += new EventHandler(TextBoxX_ObjMoveFordward_TextChanged);
            _LabelX7 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_ObjMoveRight = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ObjMoveRight.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveRight.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveRight.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveRight.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveRight.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_ObjMoveRight.TextChanged += new EventHandler(TextBoxX_ObjMoveRight_TextChanged);
            _LabelX8 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_ObjMoveLeft = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ObjMoveLeft.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveLeft.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveLeft.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveLeft.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_ObjMoveLeft.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_ObjMoveLeft.TextChanged += new EventHandler(TextBoxX_ObjMoveLeft_TextChanged);
            _GroupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            _LabelX15 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_DropToGround = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_DropToGround.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_DropToGround.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_DropToGround.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_DropToGround.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_DropToGround.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_DropToGround.TextChanged += new EventHandler(TextBoxX_TopToGround_TextChanged);
            _LabelX11 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_NextObj = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_NextObj.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_NextObj.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_NextObj.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_NextObj.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_NextObj.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_NextObj.TextChanged += new EventHandler(TextBoxX_NextObj_TextChanged);
            _LabelX12 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_LastObj = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_LastObj.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_LastObj.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_LastObj.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_LastObj.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_LastObj.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_LastObj.TextChanged += new EventHandler(TextBoxX_LastObj_TextChanged);
            _GroupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            _LabelX17 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_NextArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_NextArea.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_NextArea.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_NextArea.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_NextArea.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_NextArea.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_NextArea.TextChanged += new EventHandler(TextBoxX_NextArea_TextChanged);
            _LabelX18 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_LastArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_LastArea.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_LastArea.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_LastArea.LostFocus += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_LastArea.TextChanged += new EventHandler(TextBoxX_LostFocus_TextChanged);
            _TextBoxX_LastArea.Click += new EventHandler(TextBoxX_Click);
            _TextBoxX_LastArea.TextChanged += new EventHandler(TextBoxX_LastArea_TextChanged);
            _ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx1.SelectedIndexChanged += new EventHandler(ComboBoxEx1_SelectedIndexChanged);
            _ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX4.Click += new EventHandler(ButtonX4_Click);
            _LabelX16 = new DevComponents.DotNetBar.LabelX();
            _ButtonX5 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX5.Click += new EventHandler(ButtonX5_Click);
            _ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX6.Click += new EventHandler(ButtonX6_Click);
            _GroupPanel1.SuspendLayout();
            _GroupPanel2.SuspendLayout();
            _GroupPanel3.SuspendLayout();
            _GroupPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxX_CamMoveLeft
            // 
            _TextBoxX_CamMoveLeft.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_CamMoveLeft.Border.Class = "TextBoxBorder";
            _TextBoxX_CamMoveLeft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_CamMoveLeft.DisabledBackColor = Color.White;
            _TextBoxX_CamMoveLeft.ForeColor = Color.Black;
            _TextBoxX_CamMoveLeft.Location = new Point(62, 4);
            _TextBoxX_CamMoveLeft.Name = "TextBoxX_CamMoveLeft";
            _TextBoxX_CamMoveLeft.PreventEnterBeep = true;
            _TextBoxX_CamMoveLeft.ReadOnly = true;
            _TextBoxX_CamMoveLeft.Size = new Size(100, 20);
            _TextBoxX_CamMoveLeft.TabIndex = 4;
            _TextBoxX_CamMoveLeft.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Location = new Point(3, 3);
            _LabelX1.Name = "LabelX1";
            _LabelX1.Size = new Size(53, 23);
            _LabelX1.TabIndex = 5;
            _LabelX1.Text = "Left";
            // 
            // GroupPanel1
            // 
            _GroupPanel1.BackColor = Color.Transparent;
            _GroupPanel1.CanvasColor = Color.Transparent;
            _GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _GroupPanel1.Controls.Add(_LabelX9);
            _GroupPanel1.Controls.Add(_TextBoxX_CamMoveDown);
            _GroupPanel1.Controls.Add(_LabelX10);
            _GroupPanel1.Controls.Add(_TextBoxX_CamMoveUp);
            _GroupPanel1.Controls.Add(_LabelX3);
            _GroupPanel1.Controls.Add(_TextBoxX_CamMoveBackward);
            _GroupPanel1.Controls.Add(_LabelX4);
            _GroupPanel1.Controls.Add(_TextBoxX_CamMoveFordward);
            _GroupPanel1.Controls.Add(_LabelX2);
            _GroupPanel1.Controls.Add(_TextBoxX_CamMoveRight);
            _GroupPanel1.Controls.Add(_LabelX1);
            _GroupPanel1.Controls.Add(_TextBoxX_CamMoveLeft);
            _GroupPanel1.DisabledBackColor = Color.Empty;
            _GroupPanel1.Location = new Point(12, 41);
            _GroupPanel1.Name = "GroupPanel1";
            _GroupPanel1.Size = new Size(174, 197);
            // 
            // 
            // 
            _GroupPanel1.Style.BackColor = Color.Transparent;
            _GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            _GroupPanel1.Style.BackColorGradientAngle = 90;
            _GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel1.Style.BorderBottomWidth = 1;
            _GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel1.Style.BorderLeftWidth = 1;
            _GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel1.Style.BorderRightWidth = 1;
            _GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel1.Style.BorderTopWidth = 1;
            _GroupPanel1.Style.CornerDiameter = 4;
            _GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            _GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel1.TabIndex = 6;
            _GroupPanel1.Text = "Camera Movement";
            // 
            // LabelX9
            // 
            // 
            // 
            // 
            _LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX9.Location = new Point(3, 148);
            _LabelX9.Name = "LabelX9";
            _LabelX9.Size = new Size(53, 23);
            _LabelX9.TabIndex = 15;
            _LabelX9.Text = "Down";
            // 
            // TextBoxX_CamMoveDown
            // 
            _TextBoxX_CamMoveDown.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_CamMoveDown.Border.Class = "TextBoxBorder";
            _TextBoxX_CamMoveDown.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_CamMoveDown.DisabledBackColor = Color.White;
            _TextBoxX_CamMoveDown.ForeColor = Color.Black;
            _TextBoxX_CamMoveDown.Location = new Point(62, 149);
            _TextBoxX_CamMoveDown.Name = "TextBoxX_CamMoveDown";
            _TextBoxX_CamMoveDown.PreventEnterBeep = true;
            _TextBoxX_CamMoveDown.ReadOnly = true;
            _TextBoxX_CamMoveDown.Size = new Size(100, 20);
            _TextBoxX_CamMoveDown.TabIndex = 14;
            _TextBoxX_CamMoveDown.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX10
            // 
            // 
            // 
            // 
            _LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX10.Location = new Point(3, 119);
            _LabelX10.Name = "LabelX10";
            _LabelX10.Size = new Size(53, 23);
            _LabelX10.TabIndex = 13;
            _LabelX10.Text = "Up";
            // 
            // TextBoxX_CamMoveUp
            // 
            _TextBoxX_CamMoveUp.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_CamMoveUp.Border.Class = "TextBoxBorder";
            _TextBoxX_CamMoveUp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_CamMoveUp.DisabledBackColor = Color.White;
            _TextBoxX_CamMoveUp.ForeColor = Color.Black;
            _TextBoxX_CamMoveUp.Location = new Point(62, 120);
            _TextBoxX_CamMoveUp.Name = "TextBoxX_CamMoveUp";
            _TextBoxX_CamMoveUp.PreventEnterBeep = true;
            _TextBoxX_CamMoveUp.ReadOnly = true;
            _TextBoxX_CamMoveUp.Size = new Size(100, 20);
            _TextBoxX_CamMoveUp.TabIndex = 12;
            _TextBoxX_CamMoveUp.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX3.Location = new Point(3, 90);
            _LabelX3.Name = "LabelX3";
            _LabelX3.Size = new Size(53, 23);
            _LabelX3.TabIndex = 11;
            _LabelX3.Text = "Backward";
            // 
            // TextBoxX_CamMoveBackward
            // 
            _TextBoxX_CamMoveBackward.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_CamMoveBackward.Border.Class = "TextBoxBorder";
            _TextBoxX_CamMoveBackward.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_CamMoveBackward.DisabledBackColor = Color.White;
            _TextBoxX_CamMoveBackward.ForeColor = Color.Black;
            _TextBoxX_CamMoveBackward.Location = new Point(62, 91);
            _TextBoxX_CamMoveBackward.Name = "TextBoxX_CamMoveBackward";
            _TextBoxX_CamMoveBackward.PreventEnterBeep = true;
            _TextBoxX_CamMoveBackward.ReadOnly = true;
            _TextBoxX_CamMoveBackward.Size = new Size(100, 20);
            _TextBoxX_CamMoveBackward.TabIndex = 10;
            _TextBoxX_CamMoveBackward.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX4
            // 
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX4.Location = new Point(3, 61);
            _LabelX4.Name = "LabelX4";
            _LabelX4.Size = new Size(53, 23);
            _LabelX4.TabIndex = 9;
            _LabelX4.Text = "Fordward";
            // 
            // TextBoxX_CamMoveFordward
            // 
            _TextBoxX_CamMoveFordward.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_CamMoveFordward.Border.Class = "TextBoxBorder";
            _TextBoxX_CamMoveFordward.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_CamMoveFordward.DisabledBackColor = Color.White;
            _TextBoxX_CamMoveFordward.ForeColor = Color.Black;
            _TextBoxX_CamMoveFordward.Location = new Point(62, 62);
            _TextBoxX_CamMoveFordward.Name = "TextBoxX_CamMoveFordward";
            _TextBoxX_CamMoveFordward.PreventEnterBeep = true;
            _TextBoxX_CamMoveFordward.ReadOnly = true;
            _TextBoxX_CamMoveFordward.Size = new Size(100, 20);
            _TextBoxX_CamMoveFordward.TabIndex = 8;
            _TextBoxX_CamMoveFordward.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Location = new Point(3, 32);
            _LabelX2.Name = "LabelX2";
            _LabelX2.Size = new Size(53, 23);
            _LabelX2.TabIndex = 7;
            _LabelX2.Text = "Right";
            // 
            // TextBoxX_CamMoveRight
            // 
            _TextBoxX_CamMoveRight.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_CamMoveRight.Border.Class = "TextBoxBorder";
            _TextBoxX_CamMoveRight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_CamMoveRight.DisabledBackColor = Color.White;
            _TextBoxX_CamMoveRight.ForeColor = Color.Black;
            _TextBoxX_CamMoveRight.Location = new Point(62, 33);
            _TextBoxX_CamMoveRight.Name = "TextBoxX_CamMoveRight";
            _TextBoxX_CamMoveRight.PreventEnterBeep = true;
            _TextBoxX_CamMoveRight.ReadOnly = true;
            _TextBoxX_CamMoveRight.Size = new Size(100, 20);
            _TextBoxX_CamMoveRight.TabIndex = 6;
            _TextBoxX_CamMoveRight.TextAlign = HorizontalAlignment.Center;
            // 
            // GroupPanel2
            // 
            _GroupPanel2.BackColor = Color.Transparent;
            _GroupPanel2.CanvasColor = Color.Transparent;
            _GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _GroupPanel2.Controls.Add(_LabelX13);
            _GroupPanel2.Controls.Add(_TextBoxX_ObjMoveDown);
            _GroupPanel2.Controls.Add(_LabelX14);
            _GroupPanel2.Controls.Add(_TextBoxX_ObjMoveUp);
            _GroupPanel2.Controls.Add(_LabelX5);
            _GroupPanel2.Controls.Add(_TextBoxX_ObjMoveBackward);
            _GroupPanel2.Controls.Add(_LabelX6);
            _GroupPanel2.Controls.Add(_TextBoxX_ObjMoveFordward);
            _GroupPanel2.Controls.Add(_LabelX7);
            _GroupPanel2.Controls.Add(_TextBoxX_ObjMoveRight);
            _GroupPanel2.Controls.Add(_LabelX8);
            _GroupPanel2.Controls.Add(_TextBoxX_ObjMoveLeft);
            _GroupPanel2.DisabledBackColor = Color.Empty;
            _GroupPanel2.Location = new Point(192, 41);
            _GroupPanel2.Name = "GroupPanel2";
            _GroupPanel2.Size = new Size(174, 197);
            // 
            // 
            // 
            _GroupPanel2.Style.BackColor = Color.Transparent;
            _GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            _GroupPanel2.Style.BackColorGradientAngle = 90;
            _GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel2.Style.BorderBottomWidth = 1;
            _GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel2.Style.BorderLeftWidth = 1;
            _GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel2.Style.BorderRightWidth = 1;
            _GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel2.Style.BorderTopWidth = 1;
            _GroupPanel2.Style.CornerDiameter = 4;
            _GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            _GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel2.TabIndex = 7;
            _GroupPanel2.Text = "Object Movement";
            // 
            // LabelX13
            // 
            // 
            // 
            // 
            _LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX13.Location = new Point(3, 148);
            _LabelX13.Name = "LabelX13";
            _LabelX13.Size = new Size(53, 23);
            _LabelX13.TabIndex = 19;
            _LabelX13.Text = "Down";
            // 
            // TextBoxX_ObjMoveDown
            // 
            _TextBoxX_ObjMoveDown.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ObjMoveDown.Border.Class = "TextBoxBorder";
            _TextBoxX_ObjMoveDown.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ObjMoveDown.DisabledBackColor = Color.White;
            _TextBoxX_ObjMoveDown.ForeColor = Color.Black;
            _TextBoxX_ObjMoveDown.Location = new Point(62, 149);
            _TextBoxX_ObjMoveDown.Name = "TextBoxX_ObjMoveDown";
            _TextBoxX_ObjMoveDown.PreventEnterBeep = true;
            _TextBoxX_ObjMoveDown.ReadOnly = true;
            _TextBoxX_ObjMoveDown.Size = new Size(100, 20);
            _TextBoxX_ObjMoveDown.TabIndex = 18;
            _TextBoxX_ObjMoveDown.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX14
            // 
            // 
            // 
            // 
            _LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX14.Location = new Point(3, 119);
            _LabelX14.Name = "LabelX14";
            _LabelX14.Size = new Size(53, 23);
            _LabelX14.TabIndex = 17;
            _LabelX14.Text = "Up";
            // 
            // TextBoxX_ObjMoveUp
            // 
            _TextBoxX_ObjMoveUp.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ObjMoveUp.Border.Class = "TextBoxBorder";
            _TextBoxX_ObjMoveUp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ObjMoveUp.DisabledBackColor = Color.White;
            _TextBoxX_ObjMoveUp.ForeColor = Color.Black;
            _TextBoxX_ObjMoveUp.Location = new Point(62, 120);
            _TextBoxX_ObjMoveUp.Name = "TextBoxX_ObjMoveUp";
            _TextBoxX_ObjMoveUp.PreventEnterBeep = true;
            _TextBoxX_ObjMoveUp.ReadOnly = true;
            _TextBoxX_ObjMoveUp.Size = new Size(100, 20);
            _TextBoxX_ObjMoveUp.TabIndex = 16;
            _TextBoxX_ObjMoveUp.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX5
            // 
            // 
            // 
            // 
            _LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX5.Location = new Point(3, 90);
            _LabelX5.Name = "LabelX5";
            _LabelX5.Size = new Size(53, 23);
            _LabelX5.TabIndex = 11;
            _LabelX5.Text = "Backward";
            // 
            // TextBoxX_ObjMoveBackward
            // 
            _TextBoxX_ObjMoveBackward.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ObjMoveBackward.Border.Class = "TextBoxBorder";
            _TextBoxX_ObjMoveBackward.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ObjMoveBackward.DisabledBackColor = Color.White;
            _TextBoxX_ObjMoveBackward.ForeColor = Color.Black;
            _TextBoxX_ObjMoveBackward.Location = new Point(62, 91);
            _TextBoxX_ObjMoveBackward.Name = "TextBoxX_ObjMoveBackward";
            _TextBoxX_ObjMoveBackward.PreventEnterBeep = true;
            _TextBoxX_ObjMoveBackward.ReadOnly = true;
            _TextBoxX_ObjMoveBackward.Size = new Size(100, 20);
            _TextBoxX_ObjMoveBackward.TabIndex = 10;
            _TextBoxX_ObjMoveBackward.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX6
            // 
            // 
            // 
            // 
            _LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX6.Location = new Point(3, 61);
            _LabelX6.Name = "LabelX6";
            _LabelX6.Size = new Size(53, 23);
            _LabelX6.TabIndex = 9;
            _LabelX6.Text = "Fordward";
            // 
            // TextBoxX_ObjMoveFordward
            // 
            _TextBoxX_ObjMoveFordward.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ObjMoveFordward.Border.Class = "TextBoxBorder";
            _TextBoxX_ObjMoveFordward.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ObjMoveFordward.DisabledBackColor = Color.White;
            _TextBoxX_ObjMoveFordward.ForeColor = Color.Black;
            _TextBoxX_ObjMoveFordward.Location = new Point(62, 62);
            _TextBoxX_ObjMoveFordward.Name = "TextBoxX_ObjMoveFordward";
            _TextBoxX_ObjMoveFordward.PreventEnterBeep = true;
            _TextBoxX_ObjMoveFordward.ReadOnly = true;
            _TextBoxX_ObjMoveFordward.Size = new Size(100, 20);
            _TextBoxX_ObjMoveFordward.TabIndex = 8;
            _TextBoxX_ObjMoveFordward.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX7
            // 
            // 
            // 
            // 
            _LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX7.Location = new Point(3, 32);
            _LabelX7.Name = "LabelX7";
            _LabelX7.Size = new Size(53, 23);
            _LabelX7.TabIndex = 7;
            _LabelX7.Text = "Right";
            // 
            // TextBoxX_ObjMoveRight
            // 
            _TextBoxX_ObjMoveRight.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ObjMoveRight.Border.Class = "TextBoxBorder";
            _TextBoxX_ObjMoveRight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ObjMoveRight.DisabledBackColor = Color.White;
            _TextBoxX_ObjMoveRight.ForeColor = Color.Black;
            _TextBoxX_ObjMoveRight.Location = new Point(62, 33);
            _TextBoxX_ObjMoveRight.Name = "TextBoxX_ObjMoveRight";
            _TextBoxX_ObjMoveRight.PreventEnterBeep = true;
            _TextBoxX_ObjMoveRight.ReadOnly = true;
            _TextBoxX_ObjMoveRight.Size = new Size(100, 20);
            _TextBoxX_ObjMoveRight.TabIndex = 6;
            _TextBoxX_ObjMoveRight.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX8
            // 
            // 
            // 
            // 
            _LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX8.Location = new Point(3, 3);
            _LabelX8.Name = "LabelX8";
            _LabelX8.Size = new Size(53, 23);
            _LabelX8.TabIndex = 5;
            _LabelX8.Text = "Left";
            // 
            // TextBoxX_ObjMoveLeft
            // 
            _TextBoxX_ObjMoveLeft.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ObjMoveLeft.Border.Class = "TextBoxBorder";
            _TextBoxX_ObjMoveLeft.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ObjMoveLeft.DisabledBackColor = Color.White;
            _TextBoxX_ObjMoveLeft.ForeColor = Color.Black;
            _TextBoxX_ObjMoveLeft.Location = new Point(62, 4);
            _TextBoxX_ObjMoveLeft.Name = "TextBoxX_ObjMoveLeft";
            _TextBoxX_ObjMoveLeft.PreventEnterBeep = true;
            _TextBoxX_ObjMoveLeft.ReadOnly = true;
            _TextBoxX_ObjMoveLeft.Size = new Size(100, 20);
            _TextBoxX_ObjMoveLeft.TabIndex = 4;
            _TextBoxX_ObjMoveLeft.TextAlign = HorizontalAlignment.Center;
            // 
            // GroupPanel3
            // 
            _GroupPanel3.BackColor = Color.Transparent;
            _GroupPanel3.CanvasColor = Color.Transparent;
            _GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _GroupPanel3.Controls.Add(_LabelX15);
            _GroupPanel3.Controls.Add(_TextBoxX_DropToGround);
            _GroupPanel3.Controls.Add(_LabelX11);
            _GroupPanel3.Controls.Add(_TextBoxX_NextObj);
            _GroupPanel3.Controls.Add(_LabelX12);
            _GroupPanel3.Controls.Add(_TextBoxX_LastObj);
            _GroupPanel3.DisabledBackColor = Color.Empty;
            _GroupPanel3.Location = new Point(372, 41);
            _GroupPanel3.Name = "GroupPanel3";
            _GroupPanel3.Size = new Size(216, 110);
            // 
            // 
            // 
            _GroupPanel3.Style.BackColor = Color.Transparent;
            _GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            _GroupPanel3.Style.BackColorGradientAngle = 90;
            _GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel3.Style.BorderBottomWidth = 1;
            _GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel3.Style.BorderLeftWidth = 1;
            _GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel3.Style.BorderRightWidth = 1;
            _GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel3.Style.BorderTopWidth = 1;
            _GroupPanel3.Style.CornerDiameter = 4;
            _GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            _GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel3.TabIndex = 8;
            _GroupPanel3.Text = "Object Properties";
            // 
            // LabelX15
            // 
            // 
            // 
            // 
            _LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX15.Location = new Point(3, 61);
            _LabelX15.Name = "LabelX15";
            _LabelX15.Size = new Size(94, 23);
            _LabelX15.TabIndex = 9;
            _LabelX15.Text = "Top to Ground";
            // 
            // TextBoxX_DropToGround
            // 
            _TextBoxX_DropToGround.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_DropToGround.Border.Class = "TextBoxBorder";
            _TextBoxX_DropToGround.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_DropToGround.DisabledBackColor = Color.White;
            _TextBoxX_DropToGround.ForeColor = Color.Black;
            _TextBoxX_DropToGround.Location = new Point(103, 62);
            _TextBoxX_DropToGround.Name = "TextBoxX_DropToGround";
            _TextBoxX_DropToGround.PreventEnterBeep = true;
            _TextBoxX_DropToGround.ReadOnly = true;
            _TextBoxX_DropToGround.Size = new Size(100, 20);
            _TextBoxX_DropToGround.TabIndex = 8;
            _TextBoxX_DropToGround.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX11
            // 
            // 
            // 
            // 
            _LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX11.Location = new Point(3, 32);
            _LabelX11.Name = "LabelX11";
            _LabelX11.Size = new Size(94, 23);
            _LabelX11.TabIndex = 7;
            _LabelX11.Text = "Next Object in List";
            // 
            // TextBoxX_NextObj
            // 
            _TextBoxX_NextObj.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_NextObj.Border.Class = "TextBoxBorder";
            _TextBoxX_NextObj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_NextObj.DisabledBackColor = Color.White;
            _TextBoxX_NextObj.ForeColor = Color.Black;
            _TextBoxX_NextObj.Location = new Point(103, 33);
            _TextBoxX_NextObj.Name = "TextBoxX_NextObj";
            _TextBoxX_NextObj.PreventEnterBeep = true;
            _TextBoxX_NextObj.ReadOnly = true;
            _TextBoxX_NextObj.Size = new Size(100, 20);
            _TextBoxX_NextObj.TabIndex = 6;
            _TextBoxX_NextObj.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX12
            // 
            // 
            // 
            // 
            _LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX12.Location = new Point(3, 3);
            _LabelX12.Name = "LabelX12";
            _LabelX12.Size = new Size(94, 23);
            _LabelX12.TabIndex = 5;
            _LabelX12.Text = "Last Object in List";
            // 
            // TextBoxX_LastObj
            // 
            _TextBoxX_LastObj.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_LastObj.Border.Class = "TextBoxBorder";
            _TextBoxX_LastObj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_LastObj.DisabledBackColor = Color.White;
            _TextBoxX_LastObj.ForeColor = Color.Black;
            _TextBoxX_LastObj.Location = new Point(103, 4);
            _TextBoxX_LastObj.Name = "TextBoxX_LastObj";
            _TextBoxX_LastObj.PreventEnterBeep = true;
            _TextBoxX_LastObj.ReadOnly = true;
            _TextBoxX_LastObj.Size = new Size(100, 20);
            _TextBoxX_LastObj.TabIndex = 4;
            _TextBoxX_LastObj.TextAlign = HorizontalAlignment.Center;
            // 
            // GroupPanel4
            // 
            _GroupPanel4.BackColor = Color.Transparent;
            _GroupPanel4.CanvasColor = Color.Transparent;
            _GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _GroupPanel4.Controls.Add(_LabelX17);
            _GroupPanel4.Controls.Add(_TextBoxX_NextArea);
            _GroupPanel4.Controls.Add(_LabelX18);
            _GroupPanel4.Controls.Add(_TextBoxX_LastArea);
            _GroupPanel4.DisabledBackColor = Color.Empty;
            _GroupPanel4.Location = new Point(372, 157);
            _GroupPanel4.Name = "GroupPanel4";
            _GroupPanel4.Size = new Size(216, 81);
            // 
            // 
            // 
            _GroupPanel4.Style.BackColor = Color.Transparent;
            _GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            _GroupPanel4.Style.BackColorGradientAngle = 90;
            _GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel4.Style.BorderBottomWidth = 1;
            _GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel4.Style.BorderLeftWidth = 1;
            _GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel4.Style.BorderRightWidth = 1;
            _GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel4.Style.BorderTopWidth = 1;
            _GroupPanel4.Style.CornerDiameter = 4;
            _GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            _GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel4.TabIndex = 9;
            _GroupPanel4.Text = "Area selection";
            // 
            // LabelX17
            // 
            // 
            // 
            // 
            _LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX17.Location = new Point(3, 32);
            _LabelX17.Name = "LabelX17";
            _LabelX17.Size = new Size(94, 23);
            _LabelX17.TabIndex = 7;
            _LabelX17.Text = "Next Area";
            // 
            // TextBoxX_NextArea
            // 
            _TextBoxX_NextArea.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_NextArea.Border.Class = "TextBoxBorder";
            _TextBoxX_NextArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_NextArea.DisabledBackColor = Color.White;
            _TextBoxX_NextArea.ForeColor = Color.Black;
            _TextBoxX_NextArea.Location = new Point(103, 33);
            _TextBoxX_NextArea.Name = "TextBoxX_NextArea";
            _TextBoxX_NextArea.PreventEnterBeep = true;
            _TextBoxX_NextArea.ReadOnly = true;
            _TextBoxX_NextArea.Size = new Size(100, 20);
            _TextBoxX_NextArea.TabIndex = 6;
            _TextBoxX_NextArea.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelX18
            // 
            // 
            // 
            // 
            _LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX18.Location = new Point(3, 3);
            _LabelX18.Name = "LabelX18";
            _LabelX18.Size = new Size(94, 23);
            _LabelX18.TabIndex = 5;
            _LabelX18.Text = "Last Area";
            // 
            // TextBoxX_LastArea
            // 
            _TextBoxX_LastArea.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_LastArea.Border.Class = "TextBoxBorder";
            _TextBoxX_LastArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_LastArea.DisabledBackColor = Color.White;
            _TextBoxX_LastArea.ForeColor = Color.Black;
            _TextBoxX_LastArea.Location = new Point(103, 4);
            _TextBoxX_LastArea.Name = "TextBoxX_LastArea";
            _TextBoxX_LastArea.PreventEnterBeep = true;
            _TextBoxX_LastArea.ReadOnly = true;
            _TextBoxX_LastArea.Size = new Size(100, 20);
            _TextBoxX_LastArea.TabIndex = 4;
            _TextBoxX_LastArea.TextAlign = HorizontalAlignment.Center;
            // 
            // ComboBoxEx1
            // 
            _ComboBoxEx1.DisplayMember = "Text";
            _ComboBoxEx1.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx1.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx1.ForeColor = Color.Black;
            _ComboBoxEx1.FormattingEnabled = true;
            _ComboBoxEx1.ItemHeight = 15;
            _ComboBoxEx1.Location = new Point(77, 13);
            _ComboBoxEx1.Name = "ComboBoxEx1";
            _ComboBoxEx1.Size = new Size(198, 21);
            _ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ComboBoxEx1.TabIndex = 0;
            // 
            // ButtonX4
            // 
            _ButtonX4.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX4.FocusCuesEnabled = false;
            _ButtonX4.Location = new Point(281, 12);
            _ButtonX4.Name = "ButtonX4";
            _ButtonX4.Size = new Size(23, 23);
            _ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX4.Symbol = "";
            _ButtonX4.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX4.SymbolSize = 12.0F;
            _ButtonX4.TabIndex = 10;
            // 
            // LabelX16
            // 
            // 
            // 
            // 
            _LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX16.Location = new Point(12, 12);
            _LabelX16.Name = "LabelX16";
            _LabelX16.Size = new Size(59, 23);
            _LabelX16.TabIndex = 11;
            _LabelX16.Text = "Controller:";
            // 
            // ButtonX5
            // 
            _ButtonX5.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX5.FocusCuesEnabled = false;
            _ButtonX5.Location = new Point(352, 12);
            _ButtonX5.Name = "ButtonX5";
            _ButtonX5.Size = new Size(121, 23);
            _ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX5.Symbol = "57697";
            _ButtonX5.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX5.SymbolSize = 12.0F;
            _ButtonX5.TabIndex = 12;
            _ButtonX5.Text = "Save Profile as ...";
            // 
            // ButtonX6
            // 
            _ButtonX6.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX6.FocusCuesEnabled = false;
            _ButtonX6.Location = new Point(479, 12);
            _ButtonX6.Name = "ButtonX6";
            _ButtonX6.Size = new Size(109, 23);
            _ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX6.Symbol = "58055";
            _ButtonX6.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(172)), Conversions.ToInteger(Conversions.ToByte(106)));
            _ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX6.SymbolSize = 12.0F;
            _ButtonX6.TabIndex = 13;
            _ButtonX6.Text = "Load Profile ...";
            // 
            // LevelEditorInputManager
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 248);
            Controls.Add(_ButtonX6);
            Controls.Add(_ButtonX5);
            Controls.Add(_LabelX16);
            Controls.Add(_GroupPanel1);
            Controls.Add(_ButtonX4);
            Controls.Add(_ComboBoxEx1);
            Controls.Add(_GroupPanel4);
            Controls.Add(_GroupPanel3);
            Controls.Add(_GroupPanel2);
            DoubleBuffered = true;
            EnableGlass = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LevelEditorInputManager";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Input Manager";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _GroupPanel1.ResumeLayout(false);
            _GroupPanel2.ResumeLayout(false);
            _GroupPanel3.ResumeLayout(false);
            _GroupPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_CamMoveLeft;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveLeft
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_CamMoveLeft;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_CamMoveLeft != null)
                {
                    _TextBoxX_CamMoveLeft.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveLeft.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveLeft.Click -= TextBoxX_Click;
                    _TextBoxX_CamMoveLeft.TextChanged -= TextBoxX_CamMoveLeft_TextChanged;
                }

                _TextBoxX_CamMoveLeft = value;
                if (_TextBoxX_CamMoveLeft != null)
                {
                    _TextBoxX_CamMoveLeft.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveLeft.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveLeft.Click += TextBoxX_Click;
                    _TextBoxX_CamMoveLeft.TextChanged += TextBoxX_CamMoveLeft_TextChanged;
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

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel1;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel1 != null)
                {
                }

                _GroupPanel1 = value;
                if (_GroupPanel1 != null)
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_CamMoveBackward;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveBackward
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_CamMoveBackward;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_CamMoveBackward != null)
                {
                    _TextBoxX_CamMoveBackward.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveBackward.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveBackward.Click -= TextBoxX_Click;
                    _TextBoxX_CamMoveBackward.TextChanged -= TextBoxX_CamMoveBackward_TextChanged;
                }

                _TextBoxX_CamMoveBackward = value;
                if (_TextBoxX_CamMoveBackward != null)
                {
                    _TextBoxX_CamMoveBackward.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveBackward.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveBackward.Click += TextBoxX_Click;
                    _TextBoxX_CamMoveBackward.TextChanged += TextBoxX_CamMoveBackward_TextChanged;
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_CamMoveFordward;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveFordward
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_CamMoveFordward;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_CamMoveFordward != null)
                {
                    _TextBoxX_CamMoveFordward.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveFordward.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveFordward.Click -= TextBoxX_Click;
                    _TextBoxX_CamMoveFordward.TextChanged -= TextBoxX_CamMoveFordward_TextChanged;
                }

                _TextBoxX_CamMoveFordward = value;
                if (_TextBoxX_CamMoveFordward != null)
                {
                    _TextBoxX_CamMoveFordward.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveFordward.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveFordward.Click += TextBoxX_Click;
                    _TextBoxX_CamMoveFordward.TextChanged += TextBoxX_CamMoveFordward_TextChanged;
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_CamMoveRight;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveRight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_CamMoveRight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_CamMoveRight != null)
                {
                    _TextBoxX_CamMoveRight.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveRight.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveRight.Click -= TextBoxX_Click;
                    _TextBoxX_CamMoveRight.TextChanged -= TextBoxX_CamMoveRight_TextChanged;
                }

                _TextBoxX_CamMoveRight = value;
                if (_TextBoxX_CamMoveRight != null)
                {
                    _TextBoxX_CamMoveRight.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveRight.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveRight.Click += TextBoxX_Click;
                    _TextBoxX_CamMoveRight.TextChanged += TextBoxX_CamMoveRight_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel2;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel2 != null)
                {
                }

                _GroupPanel2 = value;
                if (_GroupPanel2 != null)
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ObjMoveBackward;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveBackward
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ObjMoveBackward;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ObjMoveBackward != null)
                {
                    _TextBoxX_ObjMoveBackward.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveBackward.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveBackward.Click -= TextBoxX_Click;
                    _TextBoxX_ObjMoveBackward.TextChanged -= TextBoxX_ObjMoveBackward_TextChanged;
                }

                _TextBoxX_ObjMoveBackward = value;
                if (_TextBoxX_ObjMoveBackward != null)
                {
                    _TextBoxX_ObjMoveBackward.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveBackward.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveBackward.Click += TextBoxX_Click;
                    _TextBoxX_ObjMoveBackward.TextChanged += TextBoxX_ObjMoveBackward_TextChanged;
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ObjMoveFordward;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveFordward
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ObjMoveFordward;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ObjMoveFordward != null)
                {
                    _TextBoxX_ObjMoveFordward.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveFordward.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveFordward.Click -= TextBoxX_Click;
                    _TextBoxX_ObjMoveFordward.TextChanged -= TextBoxX_ObjMoveFordward_TextChanged;
                }

                _TextBoxX_ObjMoveFordward = value;
                if (_TextBoxX_ObjMoveFordward != null)
                {
                    _TextBoxX_ObjMoveFordward.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveFordward.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveFordward.Click += TextBoxX_Click;
                    _TextBoxX_ObjMoveFordward.TextChanged += TextBoxX_ObjMoveFordward_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX7;

        internal DevComponents.DotNetBar.LabelX LabelX7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX7 != null)
                {
                }

                _LabelX7 = value;
                if (_LabelX7 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ObjMoveRight;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveRight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ObjMoveRight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ObjMoveRight != null)
                {
                    _TextBoxX_ObjMoveRight.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveRight.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveRight.Click -= TextBoxX_Click;
                    _TextBoxX_ObjMoveRight.TextChanged -= TextBoxX_ObjMoveRight_TextChanged;
                }

                _TextBoxX_ObjMoveRight = value;
                if (_TextBoxX_ObjMoveRight != null)
                {
                    _TextBoxX_ObjMoveRight.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveRight.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveRight.Click += TextBoxX_Click;
                    _TextBoxX_ObjMoveRight.TextChanged += TextBoxX_ObjMoveRight_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX8;

        internal DevComponents.DotNetBar.LabelX LabelX8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX8 != null)
                {
                }

                _LabelX8 = value;
                if (_LabelX8 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ObjMoveLeft;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveLeft
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ObjMoveLeft;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ObjMoveLeft != null)
                {
                    _TextBoxX_ObjMoveLeft.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveLeft.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveLeft.Click -= TextBoxX_Click;
                    _TextBoxX_ObjMoveLeft.TextChanged -= TextBoxX_ObjMoveLeft_TextChanged;
                }

                _TextBoxX_ObjMoveLeft = value;
                if (_TextBoxX_ObjMoveLeft != null)
                {
                    _TextBoxX_ObjMoveLeft.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveLeft.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveLeft.Click += TextBoxX_Click;
                    _TextBoxX_ObjMoveLeft.TextChanged += TextBoxX_ObjMoveLeft_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel3;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel3 != null)
                {
                }

                _GroupPanel3 = value;
                if (_GroupPanel3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX11;

        internal DevComponents.DotNetBar.LabelX LabelX11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX11 != null)
                {
                }

                _LabelX11 = value;
                if (_LabelX11 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_NextObj;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_NextObj
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_NextObj;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_NextObj != null)
                {
                    _TextBoxX_NextObj.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_NextObj.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_NextObj.Click -= TextBoxX_Click;
                    _TextBoxX_NextObj.TextChanged -= TextBoxX_NextObj_TextChanged;
                }

                _TextBoxX_NextObj = value;
                if (_TextBoxX_NextObj != null)
                {
                    _TextBoxX_NextObj.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_NextObj.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_NextObj.Click += TextBoxX_Click;
                    _TextBoxX_NextObj.TextChanged += TextBoxX_NextObj_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX12;

        internal DevComponents.DotNetBar.LabelX LabelX12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX12 != null)
                {
                }

                _LabelX12 = value;
                if (_LabelX12 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_LastObj;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_LastObj
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_LastObj;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_LastObj != null)
                {
                    _TextBoxX_LastObj.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_LastObj.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_LastObj.Click -= TextBoxX_Click;
                    _TextBoxX_LastObj.TextChanged -= TextBoxX_LastObj_TextChanged;
                }

                _TextBoxX_LastObj = value;
                if (_TextBoxX_LastObj != null)
                {
                    _TextBoxX_LastObj.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_LastObj.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_LastObj.Click += TextBoxX_Click;
                    _TextBoxX_LastObj.TextChanged += TextBoxX_LastObj_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX9;

        internal DevComponents.DotNetBar.LabelX LabelX9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX9 != null)
                {
                }

                _LabelX9 = value;
                if (_LabelX9 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_CamMoveDown;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveDown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_CamMoveDown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_CamMoveDown != null)
                {
                    _TextBoxX_CamMoveDown.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveDown.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveDown.Click -= TextBoxX_Click;
                    _TextBoxX_CamMoveDown.TextChanged -= TextBoxX_CamMoveDown_TextChanged;
                }

                _TextBoxX_CamMoveDown = value;
                if (_TextBoxX_CamMoveDown != null)
                {
                    _TextBoxX_CamMoveDown.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveDown.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveDown.Click += TextBoxX_Click;
                    _TextBoxX_CamMoveDown.TextChanged += TextBoxX_CamMoveDown_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX10;

        internal DevComponents.DotNetBar.LabelX LabelX10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX10 != null)
                {
                }

                _LabelX10 = value;
                if (_LabelX10 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_CamMoveUp;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_CamMoveUp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_CamMoveUp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_CamMoveUp != null)
                {
                    _TextBoxX_CamMoveUp.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveUp.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveUp.Click -= TextBoxX_Click;
                    _TextBoxX_CamMoveUp.TextChanged -= TextBoxX_CamMoveUp_TextChanged;
                }

                _TextBoxX_CamMoveUp = value;
                if (_TextBoxX_CamMoveUp != null)
                {
                    _TextBoxX_CamMoveUp.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveUp.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_CamMoveUp.Click += TextBoxX_Click;
                    _TextBoxX_CamMoveUp.TextChanged += TextBoxX_CamMoveUp_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX13;

        internal DevComponents.DotNetBar.LabelX LabelX13
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX13;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX13 != null)
                {
                }

                _LabelX13 = value;
                if (_LabelX13 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ObjMoveDown;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveDown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ObjMoveDown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ObjMoveDown != null)
                {
                    _TextBoxX_ObjMoveDown.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveDown.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveDown.Click -= TextBoxX_Click;
                    _TextBoxX_ObjMoveDown.TextChanged -= TextBoxX_ObjMoveDown_TextChanged;
                }

                _TextBoxX_ObjMoveDown = value;
                if (_TextBoxX_ObjMoveDown != null)
                {
                    _TextBoxX_ObjMoveDown.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveDown.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveDown.Click += TextBoxX_Click;
                    _TextBoxX_ObjMoveDown.TextChanged += TextBoxX_ObjMoveDown_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX14;

        internal DevComponents.DotNetBar.LabelX LabelX14
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX14;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX14 != null)
                {
                }

                _LabelX14 = value;
                if (_LabelX14 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ObjMoveUp;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ObjMoveUp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ObjMoveUp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ObjMoveUp != null)
                {
                    _TextBoxX_ObjMoveUp.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveUp.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveUp.Click -= TextBoxX_Click;
                    _TextBoxX_ObjMoveUp.TextChanged -= TextBoxX_ObjMoveUp_TextChanged;
                }

                _TextBoxX_ObjMoveUp = value;
                if (_TextBoxX_ObjMoveUp != null)
                {
                    _TextBoxX_ObjMoveUp.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveUp.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_ObjMoveUp.Click += TextBoxX_Click;
                    _TextBoxX_ObjMoveUp.TextChanged += TextBoxX_ObjMoveUp_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX15;

        internal DevComponents.DotNetBar.LabelX LabelX15
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX15;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX15 != null)
                {
                }

                _LabelX15 = value;
                if (_LabelX15 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_DropToGround;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_DropToGround
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_DropToGround;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_DropToGround != null)
                {
                    _TextBoxX_DropToGround.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_DropToGround.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_DropToGround.Click -= TextBoxX_Click;
                    _TextBoxX_DropToGround.TextChanged -= TextBoxX_TopToGround_TextChanged;
                }

                _TextBoxX_DropToGround = value;
                if (_TextBoxX_DropToGround != null)
                {
                    _TextBoxX_DropToGround.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_DropToGround.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_DropToGround.Click += TextBoxX_Click;
                    _TextBoxX_DropToGround.TextChanged += TextBoxX_TopToGround_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel4;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel4 != null)
                {
                }

                _GroupPanel4 = value;
                if (_GroupPanel4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX17;

        internal DevComponents.DotNetBar.LabelX LabelX17
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX17;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX17 != null)
                {
                }

                _LabelX17 = value;
                if (_LabelX17 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_NextArea;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_NextArea
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_NextArea;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_NextArea != null)
                {
                    _TextBoxX_NextArea.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_NextArea.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_NextArea.Click -= TextBoxX_Click;
                    _TextBoxX_NextArea.TextChanged -= TextBoxX_NextArea_TextChanged;
                }

                _TextBoxX_NextArea = value;
                if (_TextBoxX_NextArea != null)
                {
                    _TextBoxX_NextArea.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_NextArea.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_NextArea.Click += TextBoxX_Click;
                    _TextBoxX_NextArea.TextChanged += TextBoxX_NextArea_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX18;

        internal DevComponents.DotNetBar.LabelX LabelX18
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX18;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX18 != null)
                {
                }

                _LabelX18 = value;
                if (_LabelX18 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_LastArea;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_LastArea
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_LastArea;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_LastArea != null)
                {
                    _TextBoxX_LastArea.LostFocus -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_LastArea.TextChanged -= TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_LastArea.Click -= TextBoxX_Click;
                    _TextBoxX_LastArea.TextChanged -= TextBoxX_LastArea_TextChanged;
                }

                _TextBoxX_LastArea = value;
                if (_TextBoxX_LastArea != null)
                {
                    _TextBoxX_LastArea.LostFocus += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_LastArea.TextChanged += TextBoxX_LostFocus_TextChanged;
                    _TextBoxX_LastArea.Click += TextBoxX_Click;
                    _TextBoxX_LastArea.TextChanged += TextBoxX_LastArea_TextChanged;
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
                    _ComboBoxEx1.SelectedIndexChanged -= ComboBoxEx1_SelectedIndexChanged;
                }

                _ComboBoxEx1 = value;
                if (_ComboBoxEx1 != null)
                {
                    _ComboBoxEx1.SelectedIndexChanged += ComboBoxEx1_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX4;

        internal DevComponents.DotNetBar.ButtonX ButtonX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX4 != null)
                {
                    _ButtonX4.Click -= ButtonX4_Click;
                }

                _ButtonX4 = value;
                if (_ButtonX4 != null)
                {
                    _ButtonX4.Click += ButtonX4_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX16;

        internal DevComponents.DotNetBar.LabelX LabelX16
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX16;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX16 != null)
                {
                }

                _LabelX16 = value;
                if (_LabelX16 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX5;

        internal DevComponents.DotNetBar.ButtonX ButtonX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX5 != null)
                {
                    _ButtonX5.Click -= ButtonX5_Click;
                }

                _ButtonX5 = value;
                if (_ButtonX5 != null)
                {
                    _ButtonX5.Click += ButtonX5_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX6;

        internal DevComponents.DotNetBar.ButtonX ButtonX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX6 != null)
                {
                    _ButtonX6.Click -= ButtonX6_Click;
                }

                _ButtonX6 = value;
                if (_ButtonX6 != null)
                {
                    _ButtonX6.Click += ButtonX6_Click;
                }
            }
        }
    }
}