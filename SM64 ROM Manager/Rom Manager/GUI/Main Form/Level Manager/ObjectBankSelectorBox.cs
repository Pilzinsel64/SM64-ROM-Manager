using System;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;

namespace SM64_ROM_Manager
{
    public partial class ObjectBankSelectorBox
    {
        public ObjectBankSelectorBox()
        {
            InitializeComponent();
        }

        public event EventHandler SelectedComboIndexChanged;

        public string ContentLabelText
        {
            get
            {
                return LabelX29.Text;
            }

            set
            {
                LabelX29.Text = value;
            }
        }

        public int SelectedComboIndex
        {
            get
            {
                return ComboBox_ObjectBankSelector.SelectedIndex;
            }

            set
            {
                ComboBox_ObjectBankSelector.SelectedIndex = value;
            }
        }

        public object SelectedComboItem
        {
            get
            {
                return ComboBox_ObjectBankSelector.SelectedItem;
            }

            set
            {
                ComboBox_ObjectBankSelector.SelectedItem = value;
            }
        }

        public ComboBox.ObjectCollection ComboItems
        {
            get
            {
                return ComboBox_ObjectBankSelector.Items;
            }
        }

        public SubItemsCollection ContentItems
        {
            get
            {
                return ListBoxAdv_Content.Items;
            }
        }

        private void ComboBox_ObjectBankSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedComboIndexChanged?.Invoke(this, e);
        }
    }
}