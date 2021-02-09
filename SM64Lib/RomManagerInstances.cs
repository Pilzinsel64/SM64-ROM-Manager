using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib
{
    public static class RomManagerInstances
    {
        private static readonly List<RomManager> romManagers = new List<RomManager>();

        public static IEnumerable<RomManager> CurrentInstances
        {
            get => romManagers;
        }

        internal static void RegisterRomManager(RomManager romManager)
        {
            if(!romManagers.Contains(romManager))
                romManagers.Add(romManager);
        }

        internal static void UnregisterRomManager(RomManager romManager)
        {
            if (romManagers.Contains(romManager))
                romManagers.Remove(romManager);
        }
    }
}
