using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.HUD
{
    public class HUDProfile
    {
        public HUDGroup RootGroup { get; set; } = new HUDGroup();

        [JsonIgnore]
        public string ProfileName
        {
            get => RootGroup.Name;
            set => RootGroup.Name = value;
        }
    }
}
