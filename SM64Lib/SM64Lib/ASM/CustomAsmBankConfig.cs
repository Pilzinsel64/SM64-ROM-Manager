using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.ASM
{
    public class CustomAsmBankConfig
    {
        public static int DefaultMaxLength { get; set; } = 0xA000;
        public static int DefaultRomStartAddress { get; internal set; } = 0x1206000;
        public static int DefaultRamStartAddress { get; internal set; } = 0x406000;

        public List<CustomAsmAreaConfig> Areas { get; } = new List<CustomAsmAreaConfig>();
        public int MaxLength { get; set; } = -1;
        [JsonProperty]
        public int Length { get; internal set; } = -1;
        public int RomStartAddress { get; set; } = -1;
        public int RamStartAddress { get; set; } = -1;

        public int GetRomStartAddress()
            => GetRomStartAddressAdv().address;

        public (int address, bool isDefault) GetRomStartAddressAdv()
        {
            bool isDefault = RomStartAddress == -1;
            return (isDefault ? DefaultRomStartAddress : RomStartAddress, isDefault);
        }

        public int GetRamStartAddress()
            => GetRamStartAddressAdv().address;

        public (int address, bool isDefault) GetRamStartAddressAdv()
        {
            bool isDefault = RamStartAddress == -1;
            return (isDefault ? DefaultRamStartAddress : RamStartAddress, isDefault);
        }

        public int GetMaxLength()
            => GetMaxLengthAdv().length;

        public (int length, bool isDefault) GetMaxLengthAdv()
        {
            bool isDefault = RamStartAddress == -1;
            return (isDefault ? DefaultMaxLength : MaxLength, isDefault);
        }
    }
}
