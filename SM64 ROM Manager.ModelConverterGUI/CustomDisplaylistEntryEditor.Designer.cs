using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [DesignerGenerated()]
    public partial class CustomDisplaylistEntryEditor : System.Windows.Forms.UserControl
    {

        // UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
            _IntegerInput_ID = new DevComponents.Editors.IntegerInput();
            _IntegerInput_ID.ValueChanged += new EventHandler(IntegerInput_ID_ValueChanged);
            _ComboBoxEx_Layer = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_Layer.SelectedIndexChanged += new EventHandler(ComboBoxEx_Layer_SelectedIndexChanged);
            _ButtonX_Remove = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Remove.Click += new EventHandler(ButtonX_Remove_Click);
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_ID).BeginInit();
            SuspendLayout();
            // 
            // IntegerInput_ID
            // 
            // 
            // 
            // 
            _IntegerInput_ID.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_ID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_ID.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            _IntegerInput_ID.Location = new System.Drawing.Point(34, 5);
            _IntegerInput_ID.MinValue = 0;
            _IntegerInput_ID.Name = "IntegerInput_ID";
            _IntegerInput_ID.ShowUpDown = true;
            _IntegerInput_ID.Size = new System.Drawing.Size(53, 20);
            _IntegerInput_ID.TabIndex = 0;
            // 
            // ComboBoxEx_Layer
            // 
            _ComboBoxEx_Layer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _ComboBoxEx_Layer.DisplayMember = "Text";
            _ComboBoxEx_Layer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            _ComboBoxEx_Layer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _ComboBoxEx_Layer.ForeColor = System.Drawing.Color.Black;
            _ComboBoxEx_Layer.FormattingEnabled = true;
            _ComboBoxEx_Layer.ItemHeight = 15;
            _ComboBoxEx_Layer.Location = new System.Drawing.Point(140, 4);
            _ComboBoxEx_Layer.Name = "ComboBoxEx_Layer";
            _ComboBoxEx_Layer.Size = new System.Drawing.Size(148, 21);
            _ComboBoxEx_Layer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ComboBoxEx_Layer.TabIndex = 0;
            // 
            // ButtonX_Remove
            // 
            _ButtonX_Remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            _ButtonX_Remove.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _ButtonX_Remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Remove.Image = My.Resources.Resources.icons8_delete_sign_16px;
            _ButtonX_Remove.Location = new System.Drawing.Point(294, 3);
            _ButtonX_Remove.Name = "ButtonX_Remove";
            _ButtonX_Remove.Size = new System.Drawing.Size(23, 23);
            _ButtonX_Remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Remove.TabIndex = 2;
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Location = new System.Drawing.Point(3, 3);
            _LabelX1.Name = "LabelX1";
            _LabelX1.Size = new System.Drawing.Size(25, 23);
            _LabelX1.TabIndex = 3;
            _LabelX1.Text = "ID:";
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Location = new System.Drawing.Point(93, 3);
            _LabelX2.Name = "LabelX2";
            _LabelX2.Size = new System.Drawing.Size(41, 23);
            _LabelX2.TabIndex = 3;
            _LabelX2.Text = "Layer:";
            // 
            // CustomDisplaylistEntryEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(_LabelX2);
            Controls.Add(_LabelX1);
            Controls.Add(_ButtonX_Remove);
            Controls.Add(_IntegerInput_ID);
            Controls.Add(_ComboBoxEx_Layer);
            Name = "CustomDisplaylistEntryEditor";
            Size = new System.Drawing.Size(320, 29);
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_ID).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_ID;

        internal DevComponents.Editors.IntegerInput IntegerInput_ID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_ID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_ID != null)
                {
                    _IntegerInput_ID.ValueChanged -= IntegerInput_ID_ValueChanged;
                }

                _IntegerInput_ID = value;
                if (_IntegerInput_ID != null)
                {
                    _IntegerInput_ID.ValueChanged += IntegerInput_ID_ValueChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_Layer;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Layer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_Layer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_Layer != null)
                {
                    _ComboBoxEx_Layer.SelectedIndexChanged -= ComboBoxEx_Layer_SelectedIndexChanged;
                }

                _ComboBoxEx_Layer = value;
                if (_ComboBoxEx_Layer != null)
                {
                    _ComboBoxEx_Layer.SelectedIndexChanged += ComboBoxEx_Layer_SelectedIndexChanged;
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
                    _ButtonX_Remove.Click -= ButtonX_Remove_Click;
                }

                _ButtonX_Remove = value;
                if (_ButtonX_Remove != null)
                {
                    _ButtonX_Remove.Click += ButtonX_Remove_Click;
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
    }
}