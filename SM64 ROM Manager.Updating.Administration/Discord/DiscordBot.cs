using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration.Discord
{
    public class DiscordBot
    {
        public delegate void LoggedMsgEventHandler(object sender, string logmsg, bool isError);

        public event EventHandler GotReady;
        public event EventHandler HasDisconnected;
        public event LoggedMsgEventHandler LoggedMsg;

        public DiscordBotConfig Config { get; private set; }
        public DiscordSocketClient Client { get; private set; }
        public bool IsReady { get; private set; } = false;

        // C o n s t r u c t o r

        public DiscordBot(DiscordBotConfig config)
        {
            Config = config;
        }

        // M a i n

        public async void Start()
        {
            if (!string.IsNullOrEmpty(Config.DiscordBotToken))
            {
                Client = new DiscordSocketClient();

                Client.Log += Client_Log;
                Client.Ready += Client_Ready;
                Client.Disconnected += Client_Disconnected;

                await Client.LoginAsync(TokenType.Bot, Config.DiscordBotToken);
                await Client.StartAsync();
            }
            else
                LoggedMsg?.Invoke(this, "Disabled or Token invalid", true);
        }

        public async void Stop()
        {
            await Client.StopAsync();
            await Client.LogoutAsync();
        }

        // C l i e n t - E v e n t s

        private Task Client_Disconnected(Exception exception)
        {
            Task.Run(() => HasDisconnected?.Invoke(this, new EventArgs()));
            return Task.CompletedTask;
        }

        private Task Client_Ready()
        {
            Task.Run(() =>
            {
                Task.Delay(10);
                IsReady = true;
                GotReady?.Invoke(this, new EventArgs());
            });
            return Task.CompletedTask;
        }

        private Task Client_Log(LogMessage msg)
        {
            Task.Run(() => LoggedMsg?.Invoke(this, msg.Message, msg.Exception is object));
            return Task.CompletedTask;
        }

        // F e a t u r e s

        public IReadOnlyDictionary<ulong, string> GetGuilds()
        {
            var dic = new Dictionary<ulong, string>();

            foreach (var guild in Client.Guilds)
                dic.Add(guild.Id, guild.Name);

            return dic;
        }

        public IReadOnlyDictionary<ulong, string> GetTextChannels(ulong guildID)
        {
            var dic = new Dictionary<ulong, string>();
            var guild = Client.GetGuild(guildID);
            
            if (guild is object)
            {
                foreach (var channel in guild.TextChannels)
                    dic.Add(channel.Id, channel.Name);
            }

            return dic;
        }

        public IReadOnlyDictionary<ulong, string> GetRoles(ulong guildID)
        {
            var dic = new Dictionary<ulong, string>();

            foreach (var role in Client.GetGuild(guildID).Roles)
                dic.Add(role.Id, role.Name);

            return dic;
        }

        private async Task<string> BuildUpdateMsg(string versionName, ApplicationVersion version, string changelog, ulong guildID, ulong channelID, string appName, string message, bool addChangelog, ulong? pingRole)
        {
            string msg = string.Empty;

            // Add ping
            if (pingRole != null)
                msg += $"<@&{pingRole}>\n\n";
            
            // Add version as titel
            var versionString = version.ToString();
            if (version.Channel == Channels.Stable && version.Build == 1)
                versionString = versionString.Remove(versionString.IndexOf(" "));
            msg += $"**Update:** {appName} **Version __{versionString}__**";

            // Add titel
            if (!string.IsNullOrEmpty(versionName))
                msg += $"\n> {versionName}";

            // Add message
            if (!string.IsNullOrEmpty(message))
                msg += "\n\n" + message;

            // Add changelog
            if (addChangelog && !string.IsNullOrEmpty(changelog))
            {
                var sr = new StringReader(changelog);
                var sw = new StringWriter();

                while (sr.Peek() != -1)
                {
                    var line = await sr.ReadLineAsync();
                    await sw.WriteLineAsync($"> {line}");
                }

                msg += "\n\nChangelog:\n" + sw.ToString();
                sr.Close();
                sw.Close();
            }

            return msg;
        }

        public async Task SendUpdateNotification(string versionName, ApplicationVersion version, string changelog, ulong guildID, ulong channelID, string appName, string message, bool addChangelog, bool pingEveryone)
        {
            ulong? pingRole;
            var updateNotifyRoleLower = Config.UpdateNotificationRoll.ToLower();

            if (pingEveryone)
                pingRole = GetRoles(guildID).FirstOrDefault(n => n.Value.ToLower() == updateNotifyRoleLower).Key;
            else
                pingRole = null;

            string msg = await BuildUpdateMsg(versionName, version, changelog, guildID, channelID, appName, message, addChangelog, pingRole);
            var channel = Client.GetGuild(guildID)?.GetTextChannel(channelID);

            if (channel != null)
                await channel.SendMessageAsync(msg);
        }
    }
}
