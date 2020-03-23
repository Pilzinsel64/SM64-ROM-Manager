using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Form_SM64TextConverter : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SM64TextConverter));
            _TextBoxX_Input = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_Input.TextChanged += new EventHandler(TextBoxX1_TextChanged);
            _TextBoxX_Input.MouseDown += new MouseEventHandler(TextBoxX_Input_MouseClick);
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_Output = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_Output.MouseDown += new MouseEventHandler(TextBoxX_Input_MouseClick);
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _ComboBoxEx_Mode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboItem1 = new DevComponents.Editors.ComboItem();
            _ComboItem2 = new DevComponents.Editors.ComboItem();
            _ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            _ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Copy = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Copy.Click += new EventHandler(ButtonItem2_Click);
            _ButtonItem_cut = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_cut.Click += new EventHandler(ButtonItem5_Click);
            _ButtonItem_Paste = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Paste.Click += new EventHandler(ButtonItem3_Click);
            _ButtonItem_SelectAll = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_SelectAll.Click += new EventHandler(ButtonItem4_Click);
            _ButtonItem_Remove = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Remove.Click += new EventHandler(ButtonItem5_Click_1);
            _ButtonX_Convert = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Convert.Click += new EventHandler(ButtonX1_Click);
            _ButtonX_CopyOutput = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_CopyOutput.Click += new EventHandler(ButtonX_CopyOutput_Click);
            _Panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).BeginInit();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxX_Input
            // 
            resources.ApplyResources(_TextBoxX_Input, "TextBoxX_Input");
            _TextBoxX_Input.AutoSelectAll = true;
            _TextBoxX_Input.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Input.Border.Class = "TextBoxBorder";
            _TextBoxX_Input.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Input.DisabledBackColor = Color.White;
            _TextBoxX_Input.ForeColor = Color.Black;
            _TextBoxX_Input.Name = "TextBoxX_Input";
            _TextBoxX_Input.PreventEnterBeep = true;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX1, "LabelX1");
            _LabelX1.Name = "LabelX1";
            // 
            // TextBoxX_Output
            // 
            resources.ApplyResources(_TextBoxX_Output, "TextBoxX_Output");
            _TextBoxX_Output.AutoSelectAll = true;
            _TextBoxX_Output.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Output.Border.Class = "TextBoxBorder";
            _TextBoxX_Output.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Output.DisabledBackColor = Color.White;
            _TextBoxX_Output.ForeColor = Color.Black;
            _TextBoxX_Output.Name = "TextBoxX_Output";
            _TextBoxX_Output.PreventEnterBeep = true;
            _TextBoxX_Output.ReadOnly = true;
            // 
            // LabelX2
            // 
            resources.ApplyResources(_LabelX2, "LabelX2");
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Name = "LabelX2";
            // 
            // ComboBoxEx_Mode
            // 
            _ComboBoxEx_Mode.DisplayMember = "Text";
            _ComboBoxEx_Mode.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_Mode.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_Mode.ForeColor = Color.Black;
            _ComboBoxEx_Mode.FormattingEnabled = true;
            resources.ApplyResources(_ComboBoxEx_Mode, "ComboBoxEx_Mode");
            _ComboBoxEx_Mode.Items.AddRange(new object[] { _ComboItem1, _ComboItem2 });
            _ComboBoxEx_Mode.Name = "ComboBoxEx_Mode";
            _ComboBoxEx_Mode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboItem1
            // 
            resources.ApplyResources(_ComboItem1, "ComboItem1");
            // 
            // ComboItem2
            // 
            resources.ApplyResources(_ComboItem2, "ComboItem2");
            // 
            // ContextMenuBar1
            // 
            _ContextMenuBar1.AntiAlias = true;
            _ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            resources.ApplyResources(_ContextMenuBar1, "ContextMenuBar1");
            _ContextMenuBar1.IsMaximized = false;
            _ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem1 });
            _ContextMenuBar1.Name = "ContextMenuBar1";
            _ContextMenuBar1.Stretch = true;
            _ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ContextMenuBar1.TabStop = false;
            // 
            // ButtonItem1
            // 
            _ButtonItem1.AutoExpandOnClick = true;
            _ButtonItem1.Name = "ButtonItem1";
            _ButtonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_Copy, _ButtonItem_cut, _ButtonItem_Paste, _ButtonItem_SelectAll, _ButtonItem_Remove });
            // 
            // ButtonItem_Copy
            // 
            _ButtonItem_Copy.Image = My.Resources.MyIcons.icons8_copy_16px;
            _ButtonItem_Copy.Name = "ButtonItem_Copy";
            _ButtonItem_Copy.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            _ButtonItem_Copy.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_Copy.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_Copy, "ButtonItem_Copy");
            // 
            // ButtonItem_cut
            // 
            _ButtonItem_cut.Image = My.Resources.MyIcons.icons8_cut_16px;
            _ButtonItem_cut.Name = "ButtonItem_cut";
            _ButtonItem_cut.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            _ButtonItem_cut.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_cut.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_cut, "ButtonItem_cut");
            // 
            // ButtonItem_Paste
            // 
            _ButtonItem_Paste.Image = My.Resources.MyIcons.icons8_paste_16px;
            _ButtonItem_Paste.Name = "ButtonItem_Paste";
            _ButtonItem_Paste.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            _ButtonItem_Paste.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_Paste.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_Paste, "ButtonItem_Paste");
            // 
            // ButtonItem_SelectAll
            // 
            _ButtonItem_SelectAll.BeginGroup = true;
            _ButtonItem_SelectAll.Name = "ButtonItem_SelectAll";
            _ButtonItem_SelectAll.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            _ButtonItem_SelectAll.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_SelectAll, "ButtonItem_SelectAll");
            // 
            // ButtonItem_Remove
            // 
            _ButtonItem_Remove.BeginGroup = true;
            _ButtonItem_Remove.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem_Remove.Name = "ButtonItem_Remove";
            _ButtonItem_Remove.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            _ButtonItem_Remove.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonItem_Remove.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_Remove.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_Remove, "ButtonItem_Remove");
            // 
            // ButtonX_Convert
            // 
            _ButtonX_Convert.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Convert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Convert.FocusCuesEnabled = false;
            _ButtonX_Convert.Image = My.Resources.MyIcons.icons8_arrow_40px;
            resources.ApplyResources(_ButtonX_Convert, "ButtonX_Convert");
            _ButtonX_Convert.Name = "ButtonX_Convert";
            _ButtonX_Convert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Convert.SymbolColor = Color.Gray;
            _ButtonX_Convert.SymbolSize = 30.0F;
            // 
            // ButtonX_CopyOutput
            // 
            _ButtonX_CopyOutput.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX_CopyOutput, "ButtonX_CopyOutput");
            _ButtonX_CopyOutput.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_CopyOutput.FocusCuesEnabled = false;
            _ButtonX_CopyOutput.Image = My.Resources.MyIcons.icons8_copy_16px;
            _ButtonX_CopyOutput.Name = "ButtonX_CopyOutput";
            _ButtonX_CopyOutput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_CopyOutput.SymbolColor = Color.Gray;
            _ButtonX_CopyOutput.SymbolSize = 12.0F;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_ContextMenuBar1);
            _Panel1.Controls.Add(_LabelX1);
            _Panel1.Controls.Add(_ComboBoxEx_Mode);
            _Panel1.Controls.Add(_TextBoxX_Input);
            _Panel1.Controls.Add(_ButtonX_Convert);
            _Panel1.Controls.Add(_TextBoxX_Output);
            _Panel1.Controls.Add(_LabelX2);
            _Panel1.Controls.Add(_ButtonX_CopyOutput);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // Form_SM64TextConverter
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form_SM64TextConverter";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).EndInit();
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Input;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Input
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Input;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Input != null)
                {
                    _TextBoxX_Input.TextChanged -= TextBoxX1_TextChanged;
                    _TextBoxX_Input.MouseDown -= TextBoxX_Input_MouseClick;
                }

                _TextBoxX_Input = value;
                if (_TextBoxX_Input != null)
                {
                    _TextBoxX_Input.TextChanged += TextBoxX1_TextChanged;
                    _TextBoxX_Input.MouseDown += TextBoxX_Input_MouseClick;
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Output;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Output
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Output;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Output != null)
                {
                    _TextBoxX_Output.MouseDown -= TextBoxX_Input_MouseClick;
                }

                _TextBoxX_Output = value;
                if (_TextBoxX_Output != null)
                {
                    _TextBoxX_Output.MouseDown += TextBoxX_Input_MouseClick;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_CopyOutput;

        internal DevComponents.DotNetBar.ButtonX ButtonX_CopyOutput
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_CopyOutput;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_CopyOutput != null)
                {
                    _ButtonX_CopyOutput.Click -= ButtonX_CopyOutput_Click;
                }

                _ButtonX_CopyOutput = value;
                if (_ButtonX_CopyOutput != null)
                {
                    _ButtonX_CopyOutput.Click += ButtonX_CopyOutput_Click;
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

        private DevComponents.DotNetBar.ButtonX _ButtonX_Convert;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Convert
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Convert;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Convert != null)
                {
                    _ButtonX_Convert.Click -= ButtonX1_Click;
                }

                _ButtonX_Convert = value;
                if (_ButtonX_Convert != null)
                {
                    _ButtonX_Convert.Click += ButtonX1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_Mode;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Mode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_Mode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_Mode != null)
                {
                }

                _ComboBoxEx_Mode = value;
                if (_ComboBoxEx_Mode != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem1;

        internal DevComponents.Editors.ComboItem ComboItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem1 != null)
                {
                }

                _ComboItem1 = value;
                if (_ComboItem1 != null)
                {
                }
            }
        }

        private DevComponents.Editors.ComboItem _ComboItem2;

        internal DevComponents.Editors.ComboItem ComboItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboItem2 != null)
                {
                }

                _ComboItem2 = value;
                if (_ComboItem2 != null)
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
                }

                _ButtonItem1 = value;
                if (_ButtonItem1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Copy;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Copy
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Copy;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Copy != null)
                {
                    _ButtonItem_Copy.Click -= ButtonItem2_Click;
                }

                _ButtonItem_Copy = value;
                if (_ButtonItem_Copy != null)
                {
                    _ButtonItem_Copy.Click += ButtonItem2_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_cut;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_cut
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_cut;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_cut != null)
                {
                    _ButtonItem_cut.Click -= ButtonItem5_Click;
                }

                _ButtonItem_cut = value;
                if (_ButtonItem_cut != null)
                {
                    _ButtonItem_cut.Click += ButtonItem5_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Paste;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Paste
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Paste;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Paste != null)
                {
                    _ButtonItem_Paste.Click -= ButtonItem3_Click;
                }

                _ButtonItem_Paste = value;
                if (_ButtonItem_Paste != null)
                {
                    _ButtonItem_Paste.Click += ButtonItem3_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_SelectAll;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_SelectAll
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_SelectAll;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_SelectAll != null)
                {
                    _ButtonItem_SelectAll.Click -= ButtonItem4_Click;
                }

                _ButtonItem_SelectAll = value;
                if (_ButtonItem_SelectAll != null)
                {
                    _ButtonItem_SelectAll.Click += ButtonItem4_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Remove;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Remove
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Remove;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Remove != null)
                {
                    _ButtonItem_Remove.Click -= ButtonItem5_Click_1;
                }

                _ButtonItem_Remove = value;
                if (_ButtonItem_Remove != null)
                {
                    _ButtonItem_Remove.Click += ButtonItem5_Click_1;
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
    }
}