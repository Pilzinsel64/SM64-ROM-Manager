using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.ProgressUpdater
{
    public class Settings
    {
        public string ProxyUsr { get; set; } = string.Empty;
        public string ProxyPwd { get; set; } = string.Empty;
        public string WebDavUsr { get; set; } = string.Empty;
        public string WebDavPwd { get; set; } = string.Empty;
        public string WebDavUri { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public bool DiscordUploadEnabled { get; set; } = false;
        public string DiscordBotToken { get; set; } = default;
        public ulong DiscordGuildID { get; set; } = default;
        public ulong DiscordChannelID { get; set; } = default;
        public string DiscordMsgBaseURL { get; set; } = string.Empty;
        public string DiscordMsgParamCounter { get; set; } = string.Empty;
    }
}
