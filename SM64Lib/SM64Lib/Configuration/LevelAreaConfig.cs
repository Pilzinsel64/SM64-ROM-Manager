using System.Collections.Generic;

namespace SM64Lib.Configuration
{
    public class LevelAreaConfig
    {
        public string AreaName { get; set; }
        public Dictionary<short, string> ScrollingNames { get; set; } = new Dictionary<short, string>();
    }
}