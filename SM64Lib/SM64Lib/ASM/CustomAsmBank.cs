using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.ASM
{
    public class CustomAsmBank
    {
        public CustomAsmBankConfig Config { get; }
        public List<CustomAsmArea> Areas { get; } = new List<CustomAsmArea>();

        public CustomAsmBank() : this(new CustomAsmBankConfig())
        {
        }

        public CustomAsmBank(CustomAsmBankConfig config)
        {
            Config = config;
        }

        public void Load(RomManager romManager)
        {
            Areas.Clear();

            bool canLoadArea(CustomAsmAreaConfig areaConfig) =>
                areaConfig.RomAddress != -1 && areaConfig.Length > 0;

            if (Config.Areas.Where(n => canLoadArea(n)).Any())
            {
                var data = romManager.GetBinaryRom(System.IO.FileAccess.Read);

                foreach (var areaConfig in Config.Areas)
                {
                    var area = new CustomAsmArea(areaConfig);
                    area.Load(data, Config);
                    Areas.Add(area);
                }

                data.Close();
            }
        }

        public void Save(RomManager romManager)
        {
            var startAddr = Config.GetRomStartAddress();
            var curRomAddr = startAddr;

            if (Areas.Any())
            {
                var data = romManager.GetBinaryRom(System.IO.FileAccess.ReadWrite);

                foreach (var area in Areas)
                    curRomAddr += area.Save(data, curRomAddr, Config);

                data.Close();
            }

            Config.Areas.Clear();
            Config.Areas.AddRange(Areas.Select(n => n.Config));
            Config.Length = curRomAddr - startAddr;
        }

        public void UpdateAddresses()
        {
            if (Areas.Any())
            {
                var startAddr = Config.GetRomStartAddress();
                var curRomAddr = startAddr;
                foreach (var area in Areas)
                    curRomAddr += area.UpdateAddresses(curRomAddr, Config);
                Config.Length = curRomAddr - startAddr;
            }
        }
    }
}
