using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SM64Lib.Data;
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
        public string ProfileName { get; set; }
        public List<HUDGroup> Groups { get; } = new();

        public void SaveAs(string filePath)
        {
            var serializer = Json.JsonHelper.CreateJsonSerializer(rememberTypeNames: true);
            File.WriteAllText(filePath, JObject.FromObject(this, serializer).ToString());
        }

        public static HUDProfile LoadFrom(string filePath)
        {
            var serializer = Json.JsonHelper.CreateJsonSerializer(rememberTypeNames:true);
            return (HUDProfile)JObject.Parse(File.ReadAllText(filePath)).ToObject(typeof(HUDProfile), serializer);
        }

        public void LoadData(BinaryData data)
        {
            foreach (var group in Groups)
                group.LoadData(data);
        }

        public void SaveData(BinaryData data)
        {
            foreach (var group in Groups)
                group.SaveData(data);
        }
    }
}
