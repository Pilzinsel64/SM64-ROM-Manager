using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64_ROM_Manager.Updating.Administration.Discord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class DiscordPostDialog : OfficeForm
    {
        // F i e l d s

        private readonly DiscordBot bot;
        private readonly string versionName, changelog;
        private readonly ApplicationVersion version;

        // C o n s t r u c t o r

        public DiscordPostDialog(DiscordBot bot, string versionName, string changelog, ApplicationVersion version)
        {
            this.bot = bot;
            this.versionName = versionName;
            this.version = version;
            this.changelog = changelog;

            InitializeComponent();
            UpdateAmbientColors();

            textBoxX_AppName.Text = General.CurProject.DiscordBotConfig.DefaultAppName;
            textBoxX_Msg.Text = General.CurProject.DiscordBotConfig.DefaultUpdateMessage;

            LoadBgrTree();
        }

        private void LoadBgrTree()
        {
            advTree1.BeginUpdate();
            advTree1.Nodes.Clear();

            foreach (var guild in bot.GetGuilds())
            {
                var nGuild = new Node()
                {
                    Name = "g" + guild.Key,
                    Text = guild.Value,
                    Tag = guild.Key,
                    Expanded = true
                };

                foreach (var channel in bot.GetTextChannels(guild.Key).OrderBy((n) => n.Value))
                {
                    var nChannel = new Node()
                    {
                        Name = "c" + channel.Key,
                        Text = "#" + channel.Value,
                        Tag = channel.Key
                    };

                    nGuild.Nodes.Add(nChannel);
                }

                advTree1.Nodes.Add(nGuild);
            }

            advTree1.EndUpdate();
        }

        private async void ButtonX_SendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                var selNode = advTree1.SelectedNode;
                ulong gID = (ulong)selNode.Parent.Tag;
                ulong cID = (ulong)selNode.Tag;
                var msg = textBoxX_Msg.Text;

                await bot.SendUpdateNotification(versionName, version, changelog, gID, cID, textBoxX_AppName.Text, msg, checkBoxX_AddChangelog.Checked, checkBoxX_PingAtEveryone.Checked);

                MessageBoxEx.Show(this, "Nachricht erfolgreich gesendet.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch(Exception)
            {
                MessageBoxEx.Show(this, "Fehler beim Senden der Nachricht.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
