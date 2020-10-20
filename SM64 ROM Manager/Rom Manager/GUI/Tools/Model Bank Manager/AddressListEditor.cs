using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using global::DevComponents.DotNetBar;
using SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class AddressListEditor
    {

        // C o n s t r u c t o r

        public AddressListEditor()
        {
            this.Load += AddressListEditor_Load;
            InitializeComponent();
            base.UpdateAmbientColors();
            EnableAddressItemControls = false;
        }

        // P r o p e r t i e s

        public IList<int> AddressList { get; set; }

        private bool EnableAddressItemControls
        {
            set
            {
                ButtonX_Entfernen.Enabled = value;
            }
        }

        // F e a t u r e s

        private void LoadAddressList()
        {
            ItemPanel_Values.BeginUpdate();
            ItemPanel_Values.Items.Clear();
            foreach (int addr in AddressList)
                ItemPanel_Values.Items.Add(GetAddressItem(addr));
            ItemPanel_Values.EndUpdate();
            ItemPanel_Values.Refresh();
        }

        private BaseItem GetAddressItem(int addr)
        {
            var item = new ButtonItem() { Text = TextValueConverter.TextFromValue(addr) };
            item.Click += (sender, e) => ItemPanel_Values.SelectedItem = (BaseItem)sender;
            return item;
        }

        private int GetSelectedIndex()
        {
            return ItemPanel_Values.SelectedIndex;
        }

        private int GetSelectedAddress()
        {
            return AddressList.ElementAtOrDefault(GetSelectedIndex());
        }

        private void SetSelectedAddress(int addr)
        {
            int index = GetSelectedIndex();
            if (index > -1)
            {
                AddressList[index] = addr;
                UpdateButtonText(index, addr);
                ItemPanel_Values.Refresh();
            }
        }

        private void UpdateButtonText(int index, int addr)
        {
            ItemPanel_Values.Items[index].Text = TextValueConverter.TextFromValue(addr);
        }

        private void AddAddress(int addr)
        {
            // Add to addresslist
            AddressList.Add(addr);

            // Add list item
            var item = GetAddressItem(addr);
            ItemPanel_Values.Items.Add(item);
            ItemPanel_Values.SelectedItem = item;
            ItemPanel_Values.Refresh();
        }

        private void RemoveSelectedAddress()
        {
            int index = GetSelectedIndex();
            if (index > -1)
            {
                // Remove from addresslist
                AddressList.RemoveAt(index);

                // Remove item
                ItemPanel_Values.Items.RemoveAt(index);
                ItemPanel_Values.SelectedIndex = -1;
                ItemPanel_Values.Refresh();
            }
        }

        // G u i

        private void ButtonX_Hinzufügen_Click(object sender, EventArgs e)
        {
            AddAddress(TextValueConverter.ValueFromText(TextBoxX_Value.Text));
        }

        private void ButtonX_Entfernen_Click(object sender, EventArgs e)
        {
            RemoveSelectedAddress();
        }

        private void TextBoxX_Value_TextChanged(object sender, EventArgs e)
        {
            SetSelectedAddress(TextValueConverter.ValueFromText(TextBoxX_Value.Text));
        }

        private void ItemPanel_Values_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxX_Value.Text = TextValueConverter.TextFromValue(GetSelectedAddress());
            EnableAddressItemControls = ItemPanel_Values.SelectedItem is object;
        }

        private void AddressListEditor_Load(object sender, EventArgs e)
        {
            LoadAddressList();
        }
    }
}