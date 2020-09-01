using Discord;
using Discord.Rest;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.VisualBasic.CompilerServices.LikeOperator;

namespace SM64_ROM_Manager.ProgressUpdater
{
    public class DiscordMgr
    {
        public delegate void LoggedMsgEventHandler(object sender, string logmsg, bool isError);

        public event EventHandler GotReady;
        public event EventHandler HasDisconnected;
        public event LoggedMsgEventHandler LoggedMsg;

        private Settings settings;
        private string ParamCounterName { get => settings.DiscordMsgParamCounter + "="; }
        public DiscordSocketClient Client { get; private set; }
        public bool IsReady { get; private set; } = false;

        public DiscordMgr(Settings settings)
        {
            SetSettings(settings);
        }

        public void SetSettings(Settings settings)
        {
            this.settings = settings;
        }

        public async void Start()
        {
            if (settings.DiscordUploadEnabled && !string.IsNullOrEmpty(settings.DiscordBotToken))
            {
                var socketConfig = new DiscordSocketConfig();
                socketConfig.RestClientProvider = Discord.Net.Rest.DefaultRestClientProvider.Create(useProxy: true);
                socketConfig.WebSocketProvider = Discord.Net.WebSockets.DefaultWebSocketProvider.Create(System.Net.WebRequest.DefaultWebProxy);

                Client = new DiscordSocketClient(socketConfig);
                
                Client.Log += Client_Log;
                Client.Ready += Client_Ready;
                Client.Disconnected += Client_Disconnected;

                await Client.LoginAsync(TokenType.Bot, settings.DiscordBotToken);
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

        public async void SetOnline()
        {
            await Client.SetStatusAsync(UserStatus.Online);
        }

        public async Task SendMessage()
        {
            var newVersion = new Version(settings.Version);
            var guild = Client.GetGuild(settings.DiscordGuildID);
            if (guild is object)
            {
                var channel = guild.GetTextChannel(settings.DiscordChannelID);
                if (channel is object)
                {
                    int newCounter = -1;
                    RestUserMessage msgToDelete = null;

                    // Delete last messages
                    var lastMsgs = await channel.GetMessagesAsync(10).ToArrayAsync();
                    foreach (var msgs in lastMsgs)
                    {
                        foreach (var msg in msgs)
                        {
                            if (newCounter == -1 && msg is RestUserMessage)
                            {
                                var umsg = (RestUserMessage)msg;
                                bool deleteMsg = false;

                                bool checkMsgString(string strMsg) =>
                                    LikeString(strMsg, string.Format(settings.DiscordMsgBaseURL, newVersion.Major, newVersion.Minor, newVersion.Build, newVersion.Revision, "*"), Microsoft.VisualBasic.CompareMethod.Text);
                                int getNewCounter(string strUrl) =>
                                    Convert.ToInt32(strUrl.Substring(strUrl.IndexOf(ParamCounterName) + ParamCounterName.Length));

                                foreach (var embed in umsg.Embeds)
                                {
                                    if (!deleteMsg && !string.IsNullOrEmpty(embed.Image?.Url) && checkMsgString(embed.Image?.Url))
                                    {
                                        deleteMsg = true;
                                        newCounter = getNewCounter(embed.Image?.Url);
                                    }
                                }

                                if (!deleteMsg && !string.IsNullOrEmpty(umsg.Content) && checkMsgString(umsg.Content))
                                {
                                    deleteMsg = true;
                                    newCounter = getNewCounter(umsg.Content);
                                }

                                if (deleteMsg)
                                    msgToDelete = umsg;                                    
                            }                            
                        }
                    }

                    // Set new counter
                    newCounter += 1;

                    // Build embed
                    var embedBuilder = new EmbedBuilder();
                    embedBuilder.ImageUrl = string.Format(settings.DiscordMsgBaseURL, newVersion.Major, newVersion.Minor, newVersion.Build, newVersion.Revision, newCounter);
                    var newEmbed = embedBuilder.Build();

                    // Send Message
                    await channel.SendMessageAsync(embed: newEmbed);

                    // Delete old message
                    if (msgToDelete is object)
                        await msgToDelete.DeleteAsync();
                }
            }
        }
    }
}
