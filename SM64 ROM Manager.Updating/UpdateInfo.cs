using System.Collections.Generic;
using global::Newtonsoft.Json.Linq;

namespace SM64_ROM_Manager.Updating
{
    public class UpdateInfo
    {
        public string UpdateInstallerLink { get; set; }
        public List<UpdatePackageInfo> Packages { get; set; } = new List<UpdatePackageInfo>();

        public static UpdateInfo Parse(string str)
        {
            return JObject.Parse(str).ToObject<UpdateInfo>();
        }

        public override string ToString()
        {
            return JObject.FromObject(this).ToString();
        }
    }
}