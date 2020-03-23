using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class ObjectBankSelectorBox : UserControl
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
            _ComboBox_ObjectBankSelector = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_ObjectBankSelector.SelectedIndexChanged += new EventHandler(ComboBox_ObjectBankSelector_SelectedIndexChanged);
            _ListBoxAdv_Content = new DevComponents.DotNetBar.ItemPanel();
            _LabelX29 = new DevComponents.DotNetBar.LabelX();
            SuspendLayout();
            // 
            // ComboBox_ObjectBankSelector
            // 
            _ComboBox_ObjectBankSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _ComboBox_ObjectBankSelector.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_ObjectBankSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_ObjectBankSelector.ForeColor = Color.Black;
            _ComboBox_ObjectBankSelector.FormattingEnabled = true;
            _ComboBox_ObjectBankSelector.ItemHeight = 15;
            _ComboBox_ObjectBankSelector.Items.AddRange(new object[] { "Disabled", "Haunted Objects", "Snow Objects", "Assorted Enemies (1)", "Desert Objects", "Big Bob-Omb Boss", "Assorted Enemies (2)", "Water Objects", "Assorted Enemies (3)", "Peach & Yoshi", "Switches", "Lava Objects" });
            _ComboBox_ObjectBankSelector.Location = new Point(3, 3);
            _ComboBox_ObjectBankSelector.Name = "ComboBox_ObjectBankSelector";
            _ComboBox_ObjectBankSelector.Size = new Size(150, 21);
            _ComboBox_ObjectBankSelector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ComboBox_ObjectBankSelector.TabIndex = 42;
            // 
            // ListBoxAdv_LM_ContentOfOB0x0C
            // 
            _ListBoxAdv_Content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _ListBoxAdv_Content.AutoScroll = true;
            // 
            // 
            // 
            _ListBoxAdv_Content.BackgroundStyle.Class = "ListBoxAdv";
            _ListBoxAdv_Content.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListBoxAdv_Content.ContainerControlProcessDialogKey = true;
            _ListBoxAdv_Content.DragDropSupport = true;
            _ListBoxAdv_Content.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ListBoxAdv_Content.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ListBoxAdv_Content.Location = new Point(3, 57);
            _ListBoxAdv_Content.Name = "ListBoxAdv_LM_ContentOfOB0x0C";
            _ListBoxAdv_Content.ReserveLeftSpace = false;
            _ListBoxAdv_Content.Size = new Size(150, 85);
            _ListBoxAdv_Content.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ListBoxAdv_Content.TabIndex = 41;
            // 
            // LabelX29
            // 
            _LabelX29.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _LabelX29.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX29.Location = new Point(3, 30);
            _LabelX29.Name = "LabelX29";
            _LabelX29.Size = new Size(150, 21);
            _LabelX29.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _LabelX29.TabIndex = 43;
            _LabelX29.Text = "Content of Bank 0x0C:";
            _LabelX29.TextAlignment = StringAlignment.Center;
            // 
            // ObjectBankSelectorBox
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_ComboBox_ObjectBankSelector);
            Controls.Add(_ListBoxAdv_Content);
            Controls.Add(_LabelX29);
            Name = "ObjectBankSelectorBox";
            Size = new Size(156, 145);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_ObjectBankSelector;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_ObjectBankSelector
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_ObjectBankSelector;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_ObjectBankSelector != null)
                {
                    _ComboBox_ObjectBankSelector.SelectedIndexChanged -= ComboBox_ObjectBankSelector_SelectedIndexChanged;
                }

                _ComboBox_ObjectBankSelector = value;
                if (_ComboBox_ObjectBankSelector != null)
                {
                    _ComboBox_ObjectBankSelector.SelectedIndexChanged += ComboBox_ObjectBankSelector_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ItemPanel _ListBoxAdv_Content;

        internal DevComponents.DotNetBar.ItemPanel ListBoxAdv_Content
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListBoxAdv_Content;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListBoxAdv_Content != null)
                {
                }

                _ListBoxAdv_Content = value;
                if (_ListBoxAdv_Content != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX29;

        internal DevComponents.DotNetBar.LabelX LabelX29
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX29;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX29 != null)
                {
                }

                _LabelX29 = value;
                if (_LabelX29 != null)
                {
                }
            }
        }
    }
}