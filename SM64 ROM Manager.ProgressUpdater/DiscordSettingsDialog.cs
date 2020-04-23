using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;

namespace SM64_ROM_Manager.ProgressUpdater
{
    public partial class DiscordSettingsDialog : OfficeForm
    {
        private readonly Settings settings;

        public DiscordSettingsDialog(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            TextBoxX_BotToken.Text = settings.DiscordBotToken;
            TextBoxX_ImgBaseURL.Text = settings.DiscordMsgBaseURL;
            TextBoxX_UrlExtraCounterParam.Text = settings.DiscordMsgParamCounter;
            CheckBoxX_EnableDiscordUpload.Checked = settings.DiscordUploadEnabled;
        }

        private void TextBoxX_BotToken_TextChanged(object sender, EventArgs e)
        {
            settings.DiscordBotToken = TextBoxX_BotToken.Text.Trim();
        }

        private void TextBoxX_ImgBaseURL_TextChanged(object sender, EventArgs e)
        {
            settings.DiscordMsgBaseURL = TextBoxX_ImgBaseURL.Text.Trim();
        }

        private void TextBoxX_UrlExtraCounterParam_TextChanged(object sender, EventArgs e)
        {
            settings.DiscordMsgParamCounter = TextBoxX_UrlExtraCounterParam.Text.Trim();
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            var dmgr = new DiscordMgr(settings);
            bool hasError = false;
            dmgr.LoggedMsg += (ssender, msg, isError) => { if (hasError) hasError = true; };
            dmgr.Start();

            while (!dmgr.IsReady && !hasError)
            {
                Application.DoEvents();
            }

            if (hasError)
            {
                MessageBox.Show("Entwender deaktiviert oder Token ist falsch.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AdvTree1.BeginUpdate();
                AdvTree1.Nodes.Clear();

                foreach (var guild in dmgr.Client.Guilds)
                {
                    var nGuild = new Node()
                    {
                        Name = "g" + guild.Id,
                        Text = guild.Name,
                        Tag = guild.Id
                    };

                    foreach (var channel in guild.TextChannels)
                    {
                        var nChannel = new Node()
                        {
                            Name = "c" + channel.Id,
                            Text = "#" + channel.Name,
                            Tag = channel.Id
                        };

                        nGuild.Nodes.Add(nChannel);
                    }

                    AdvTree1.Nodes.Add(nGuild);
                }

                AdvTree1.EndUpdate();
                dmgr.Stop();
            }
        }

        private void AdvTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            if (e.Node.Name.StartsWith("c"))
            {
                settings.DiscordChannelID = (ulong)e.Node.Tag;
                settings.DiscordGuildID = (ulong)e.Node.Parent.Tag;
            }
        }

        private void CheckBoxX_EnableDiscordUpload_CheckedChanged(object sender, EventArgs e)
        {
            settings.DiscordUploadEnabled = CheckBoxX_EnableDiscordUpload.Checked;
        }
    }
}