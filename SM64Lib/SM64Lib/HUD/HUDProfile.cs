using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.HUD
{
    public class HUDProfile
    {
        public HUDGroup RootGroup { get; } = new HUDGroup();

        [JsonIgnore]
        public string ProfileName
        {
            get => RootGroup.Name;
            set => RootGroup.Name = value;
        }

        public void SaveAs(string filePath)
        {
            File.WriteAllText(filePath, JObject.FromObject(this).ToString());
        }

        public static HUDProfile LoadFrom(string filePath)
        {
            return JObject.Parse(File.ReadAllText(filePath)).ToObject<HUDProfile>();
        }
    }
}
