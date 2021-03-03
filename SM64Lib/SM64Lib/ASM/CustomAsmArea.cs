using Newtonsoft.Json;
using SM64Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.ASM
{
    public class CustomAsmArea
    {
        public CustomAsmAreaConfig Config { get; }
        public byte[] AreaBytes { get; set; }

        [JsonConstructor]
        private CustomAsmArea(JsonConstructorAttribute emptyObject)
            : this(false)
        {
        }

        public CustomAsmArea()
            : this(true)
        {
        }

        private CustomAsmArea(bool createEmptyAreaBytesArray)
            : this(new CustomAsmAreaConfig(), createEmptyAreaBytesArray)
        {
        }

        public CustomAsmArea(CustomAsmAreaConfig config)
            : this(config, false)
        {
        }

        private CustomAsmArea(CustomAsmAreaConfig config, bool createEmptyAreaBytesArray)
        {
            Config = config;

            if (createEmptyAreaBytesArray)
                AreaBytes = new byte[] { };
        }

        public void Load(BinaryData data, CustomAsmBankConfig bankConfig)
        {
            if (Config.RomAddress != -1 && Config.Length > 0)
            {
                data.Position = Config.RomAddress;
                AreaBytes = data.Read(Config.Length);
            }
            else
                AreaBytes = new byte[] { };
        }

        public int Save(BinaryData data, int address, CustomAsmBankConfig bankConfig)
        {
            data.Position = address;
            data.Write(AreaBytes);
            return UpdateAddresses(address, bankConfig);
        }

        internal int UpdateAddresses(int address, CustomAsmBankConfig bankConfig)
        {
            Config.RomAddress = address;
            Config.Length = AreaBytes.Length;
            Config.RamAddress = address - bankConfig.GetRomStartAddress() + bankConfig.GetRamStartAddress();
            return Config.Length;
        }
    }
}
