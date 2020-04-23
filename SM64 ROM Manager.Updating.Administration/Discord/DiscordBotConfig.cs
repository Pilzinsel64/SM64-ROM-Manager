using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration.Discord
{
    public class DiscordBotConfig
    {
        public string DiscordBotToken { get; set; } = string.Empty;
        public string DefaultUpdateMessage { get; set; } = string.Empty;
        public string DefaultAppName { get; set; } = string.Empty;
        public string UpdateNotificationRoll { get; set; } = string.Empty;
    }
}
