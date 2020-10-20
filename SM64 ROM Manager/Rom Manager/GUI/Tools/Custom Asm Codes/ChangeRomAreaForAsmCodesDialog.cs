using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SM64Lib;
using SM64Lib.ASM;
using static SM64Lib.TextValueConverter.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class ChangeRomAreaForAsmCodesDialog : OfficeForm
    {
        private readonly CustomAsmBank asmBank;

        public ChangeRomAreaForAsmCodesDialog(CustomAsmBank asmBank)
        {
            this.asmBank = asmBank;

            InitializeComponent();
            UpdateAmbientColors();

            var romAddr = asmBank.Config.GetRomStartAddressAdv();
            if (romAddr.isDefault)
                textBoxX_RomAddress.WatermarkText = TextFromValue(romAddr.address);
            else
            {
                textBoxX_RomAddress.WatermarkText = TextFromValue(CustomAsmBankConfig.DefaultRomStartAddress);
                textBoxX_RomAddress.Text = TextFromValue(romAddr.address);
            }

            var ramAddr = asmBank.Config.GetRamStartAddressAdv();
            if (ramAddr.isDefault)
                textBoxX_RamAddress.WatermarkText = TextFromValue(ramAddr.address);
            else
            {
                textBoxX_RamAddress.WatermarkText = TextFromValue(CustomAsmBankConfig.DefaultRamStartAddress);
                textBoxX_RamAddress.Text = TextFromValue(ramAddr.address);
            }

            var length = asmBank.Config.GetMaxLengthAdv();
            if (length.isDefault)
                textBoxX_Length.WatermarkText = TextFromValue(length.length);
            else
            {
                textBoxX_Length.WatermarkText = TextFromValue(CustomAsmBankConfig.DefaultMaxLength);
                textBoxX_Length.Text = TextFromValue(length.length);
            }
        }

        private void ButtonX_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxX_RomAddress.Text.Trim()))
                asmBank.Config.RomStartAddress = -1;
            else
                asmBank.Config.RomStartAddress = ValueFromText(textBoxX_RomAddress.Text);

            if (string.IsNullOrEmpty(textBoxX_RamAddress.Text.Trim()))
                asmBank.Config.RamStartAddress = -1;
            else
                asmBank.Config.RamStartAddress = ValueFromText(textBoxX_RamAddress.Text);

            if (string.IsNullOrEmpty(textBoxX_Length.Text.Trim()))
                asmBank.Config.MaxLength = -1;
            else
                asmBank.Config.MaxLength = ValueFromText(textBoxX_Length.Text);

            DialogResult = DialogResult.OK;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            textBoxX_RomAddress.Text = string.Empty;
            textBoxX_RamAddress.Text = string.Empty;
            textBoxX_Length.Text = string.Empty;
        }
    }
}