using Newtonsoft.Json.Linq;
using SM64_ROM_Manager.Updating.Administration.Discord;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration
{
    public class UpdateProject
    {
        public UpdateServerConfig UpdateServerConfig { get; } = new UpdateServerConfig();
        public DiscordBotConfig DiscordBotConfig { get; } = new DiscordBotConfig();
        public ProxyConfiguration ProxyConfig { get; } = new ProxyConfiguration();
        
        public static UpdateProject Load(string filePath)
        {
            if (File.Exists(filePath))
                return JObject.Parse(File.ReadAllText(filePath)).ToObject<UpdateProject>();
            else
                return new UpdateProject();
        }

        public void Save(string filePath)
        {
            File.WriteAllText(filePath, JObject.FromObject(this).ToString());
        }
    }
}
