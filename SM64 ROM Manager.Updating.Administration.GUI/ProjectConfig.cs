using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    class ProjectConfig
    {
        public static ProjectConfig Current { get; set; }

        public UpdateServerInfo UpdateServerInfo { get; set; } = new UpdateServerInfo();

        public static ProjectConfig Load(string filePath)
        {
            if (File.Exists(filePath))
                return JObject.Parse(File.ReadAllText(filePath)).ToObject<ProjectConfig>();
            else
                return new ProjectConfig();
        }

        public void Save(string filePath)
        {
            File.WriteAllText(filePath, JObject.FromObject(this).ToString());
        }
    }
}
