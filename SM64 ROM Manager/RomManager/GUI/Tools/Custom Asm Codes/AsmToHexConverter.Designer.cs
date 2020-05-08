namespace SM64_ROM_Manager
{
    partial class AsmToHexConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsmToHexConverter));
            this.fastColoredTextBox_Code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProgBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.ButtonX_Convert = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_CopyHex = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX_Hex = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_Code)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastColoredTextBox_Code
            // 
            this.fastColoredTextBox_Code.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            resources.ApplyResources(this.fastColoredTextBox_Code, "fastColoredTextBox_Code");
            this.fastColoredTextBox_Code.BackBrush = null;
            this.fastColoredTextBox_Code.CharHeight = 14;
            this.fastColoredTextBox_Code.CharWidth = 8;
            this.fastColoredTextBox_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox_Code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox_Code.IsReplaceMode = false;
            this.fastColoredTextBox_Code.Name = "fastColoredTextBox_Code";
            this.fastColoredTextBox_Code.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox_Code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox_Code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox_Code.ServiceColors")));
            this.fastColoredTextBox_Code.Zoom = 100;
            this.fastColoredTextBox_Code.DragDrop += new System.Windows.Forms.DragEventHandler(this.FastColoredTextBox_Code_DragDrop);
            this.fastColoredTextBox_Code.DragEnter += new System.Windows.Forms.DragEventHandler(this.FastColoredTextBox_Code_DragEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ProgBar);
            this.panel1.Controls.Add(this.ButtonX_Convert);
            this.panel1.Controls.Add(this.ButtonX_CopyHex);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ProgBar
            // 
            // 
            // 
            // 
            this.ProgBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.ProgBar, "ProgBar");
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.ProgBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Convert
            // 
            this.ButtonX_Convert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Convert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ButtonX_Convert, "ButtonX_Convert");
            this.ButtonX_Convert.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_thick_arrow_pointing_down_16px;
            this.ButtonX_Convert.Name = "ButtonX_Convert";
            this.ButtonX_Convert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Convert.Click += new System.EventHandler(this.ButtonX_Convert_Click);
            // 
            // ButtonX_CopyHex
            // 
            this.ButtonX_CopyHex.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_CopyHex.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_CopyHex.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_copy_16px;
            resources.ApplyResources(this.ButtonX_CopyHex, "ButtonX_CopyHex");
            this.ButtonX_CopyHex.Name = "ButtonX_CopyHex";
            this.ButtonX_CopyHex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_CopyHex.Click += new System.EventHandler(this.ButtonX_CopyHex_Click);
            // 
            // textBoxX_Hex
            // 
            this.textBoxX_Hex.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_Hex.Border.Class = "TextBoxBorder";
            this.textBoxX_Hex.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_Hex.DisabledBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxX_Hex, "textBoxX_Hex");
            this.textBoxX_Hex.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_Hex.Name = "textBoxX_Hex";
            this.textBoxX_Hex.PreventEnterBeep = true;
            this.textBoxX_Hex.ReadOnly = true;
            // 
            // AsmToHexConverter
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fastColoredTextBox_Code);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxX_Hex);
            this.Name = "AsmToHexConverter";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox_Code)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox_Code;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Hex;
        private DevComponents.DotNetBar.ButtonX ButtonX_Convert;
        private DevComponents.DotNetBar.ButtonX ButtonX_CopyHex;
        private DevComponents.DotNetBar.Controls.ProgressBarX ProgBar;
    }
}