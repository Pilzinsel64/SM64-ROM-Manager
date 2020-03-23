using System.Diagnostics;
using System.Runtime.CompilerServices;
using global::System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.PatchScripts
{
    [DesignerGenerated()]
    public partial class TweakProfileEditor : DevComponents.DotNetBar.OfficeForm
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
        private System.ComponentModel.IContainer components = null;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TweakProfileEditor));
            _TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            _LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControl1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxX1
            // 
            _TextBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX1.Border.Class = "TextBoxBorder";
            _TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX1.ForeColor = System.Drawing.Color.Black;
            _TextBoxX1.Location = new System.Drawing.Point(4, 21);
            _TextBoxX1.Margin = new Padding(0);
            _TextBoxX1.Name = "TextBoxX1";
            _TextBoxX1.PreventEnterBeep = true;
            _TextBoxX1.Size = new System.Drawing.Size(367, 20);
            _TextBoxX1.TabIndex = 0;
            // 
            // TextBoxX2
            // 
            _TextBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX2.Border.Class = "TextBoxBorder";
            _TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX2.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX2.ForeColor = System.Drawing.Color.Black;
            _TextBoxX2.Location = new System.Drawing.Point(4, 66);
            _TextBoxX2.Margin = new Padding(0);
            _TextBoxX2.Multiline = true;
            _TextBoxX2.Name = "TextBoxX2";
            _TextBoxX2.PreventEnterBeep = true;
            _TextBoxX2.Size = new System.Drawing.Size(367, 204);
            _TextBoxX2.TabIndex = 1;
            // 
            // ButtonX2
            // 
            _ButtonX2.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX2.DialogResult = DialogResult.OK;
            _ButtonX2.Image = MyIcons.icons8_checkmark_16px;
            _ButtonX2.Location = new System.Drawing.Point(213, 278);
            _ButtonX2.Margin = new Padding(0);
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Size = new System.Drawing.Size(75, 24);
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX2.SymbolSize = 12.0F;
            _ButtonX2.TabIndex = 3;
            _ButtonX2.Text = "Okay";
            // 
            // ButtonX1
            // 
            _ButtonX1.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX1.DialogResult = DialogResult.Cancel;
            _ButtonX1.Image = MyIcons.icons8_delete_sign_16px_1;
            _ButtonX1.Location = new System.Drawing.Point(296, 278);
            _ButtonX1.Margin = new Padding(0);
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Size = new System.Drawing.Size(75, 24);
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX1.SymbolSize = 12.0F;
            _ButtonX1.TabIndex = 4;
            _ButtonX1.Text = "Cancel";
            // 
            // LayoutControl1
            // 
            _LayoutControl1.BackColor = System.Drawing.Color.Transparent;
            _LayoutControl1.Controls.Add(_TextBoxX1);
            _LayoutControl1.Controls.Add(_TextBoxX2);
            _LayoutControl1.Controls.Add(_ButtonX2);
            _LayoutControl1.Controls.Add(_ButtonX1);
            _LayoutControl1.Dock = DockStyle.Fill;
            _LayoutControl1.Location = new System.Drawing.Point(0, 0);
            _LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            _LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem1, _LayoutControlItem2, _LayoutSpacerItem1, _LayoutControlItem3, _LayoutControlItem4 });
            _LayoutControl1.Size = new System.Drawing.Size(375, 306);
            _LayoutControl1.TabIndex = 5;
            // 
            // LayoutControlItem1
            // 
            _LayoutControlItem1.Control = _TextBoxX1;
            _LayoutControlItem1.Height = 45;
            _LayoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            _LayoutControlItem1.Name = "LayoutControlItem1";
            _LayoutControlItem1.Text = "Name:";
            _LayoutControlItem1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            _LayoutControlItem1.Width = 100;
            _LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            _LayoutControlItem2.Control = _TextBoxX2;
            _LayoutControlItem2.Height = 229;
            _LayoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            _LayoutControlItem2.Name = "LayoutControlItem2";
            _LayoutControlItem2.Text = "Description:";
            _LayoutControlItem2.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            _LayoutControlItem2.Width = 100;
            _LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutSpacerItem1
            // 
            _LayoutSpacerItem1.Height = 32;
            _LayoutSpacerItem1.Name = "LayoutSpacerItem1";
            _LayoutSpacerItem1.Width = 99;
            _LayoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            _LayoutControlItem3.Control = _ButtonX2;
            _LayoutControlItem3.Height = 31;
            _LayoutControlItem3.MinSize = new System.Drawing.Size(32, 20);
            _LayoutControlItem3.Name = "LayoutControlItem3";
            _LayoutControlItem3.Width = 83;
            // 
            // LayoutControlItem4
            // 
            _LayoutControlItem4.Control = _ButtonX1;
            _LayoutControlItem4.Height = 31;
            _LayoutControlItem4.MinSize = new System.Drawing.Size(32, 20);
            _LayoutControlItem4.Name = "LayoutControlItem4";
            _LayoutControlItem4.Width = 83;
            // 
            // TweakProfileEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(375, 306);
            ControlBox = false;
            Controls.Add(_LayoutControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "TweakProfileEditor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tweak Editor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _LayoutControl1.ResumeLayout(false);
            ResumeLayout(false);
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

        private DevComponents.DotNetBar.Layout.LayoutControl _LayoutControl1;

        internal DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControl1 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem1;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem1 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem2;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem2 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutSpacerItem _LayoutSpacerItem1;

        internal DevComponents.DotNetBar.Layout.LayoutSpacerItem LayoutSpacerItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutSpacerItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutSpacerItem1 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem3;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem3 = value;
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem4;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LayoutControlItem4 = value;
            }
        }
    }
}