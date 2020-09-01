using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SM64_ROM_Manager.Updating.Administration.Discord;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class DiscordBotSettingsWindow : DevComponents.DotNetBar.OfficeForm
    {
        private readonly DiscordBotConfig config = null;

        public DiscordBotSettingsWindow(DiscordBotConfig config)
        {
            this.config = config;

            InitializeComponent();
            UpdateAmbientColors();

            TextBoxX_BotToken.Text = config.DiscordBotToken;
            TextBoxX_AppName.Text = config.DefaultAppName;
            TextBoxX_Msg.Text = config.DefaultUpdateMessage;
            switchButton_UseProxy.Value = config.UseProxy;
        }

        private void TextBoxX_Msg_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxX_AppName_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxX_BotToken_TextChanged(object sender, EventArgs e)
        {
        }

        private void ButtonX_Okay_Click(object sender, EventArgs e)
        {
            config.DefaultUpdateMessage = TextBoxX_Msg.Text.Trim();
            config.DefaultAppName = TextBoxX_AppName.Text.Trim();
            config.DiscordBotToken = TextBoxX_BotToken.Text.Trim();
            config.UseProxy = switchButton_UseProxy.Value;
        }
    }
}