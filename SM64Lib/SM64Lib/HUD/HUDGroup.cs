using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.HUD
{
    public class HUDGroup
    {
        public string Name { get; set; }
        public List<HUDGroup> Groups { get; } = new();
        public List<HUDItem> Items { get; } = new();
    }
}
