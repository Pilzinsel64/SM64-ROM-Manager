using System;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.My.Resources;
using global::SM64Lib;
using global::SM64Lib.NPCs;

namespace SM64_ROM_Manager
{
    public partial class Form_CoinsSettings
    {
        public Form_CoinsSettings(RomManager rommgr)
        {
            base.Shown += Coins_Settings_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();
            coinMgr = new CoinsManager(rommgr);
        }

        private CoinsManager coinMgr;

        private void LoadSettingsToGUI()
        {
            IntegerInput_CoinsForRedCoinsStar.Value = coinMgr.CoinsForRedCoinsStar;
            IntegerInput_CoinsForBowserRedCoinsStar.Value = coinMgr.CoinsForBowserRedCoinsStar;
            IntegerInput_CoinsFor100CoinsStar.Value = coinMgr.CoinsFor100CoinsStar;
            SwitchButton_Enable100Coins.Value = coinMgr.Enable100CoinsStar;
            SwitchButton_ShowCoinsHudOnHubs.Value = coinMgr.EnableCoinCounterInHubs;
            SwitchButton_CoinsRestoreHealth.Value = coinMgr.CoinsRestoreHealth;
            SwitchButton_EnableNewRedCoinsCounter.Value = coinMgr.EnableNewRedCoinsCounter;
            TextBoxX_NewRedCoinsCounterTextForCoin.Text = coinMgr.NewRedCoinsCounterTextForCoin;
            TextBoxX_NewRedCoinsCounterTextForCoins.Text = coinMgr.NewRedCoinsCounterTextForCoins;
        }

        private void ApplySettingsToCoinManager()
        {
            coinMgr.CoinsForRedCoinsStar = Conversions.ToShort(IntegerInput_CoinsForRedCoinsStar.Value);
            coinMgr.CoinsForBowserRedCoinsStar = Conversions.ToShort(IntegerInput_CoinsForBowserRedCoinsStar.Value);
            coinMgr.CoinsFor100CoinsStar = Conversions.ToByte(IntegerInput_CoinsFor100CoinsStar.Value);
            coinMgr.Enable100CoinsStar = SwitchButton_Enable100Coins.Value;
            coinMgr.EnableCoinCounterInHubs = SwitchButton_ShowCoinsHudOnHubs.Value;
            coinMgr.CoinsRestoreHealth = SwitchButton_CoinsRestoreHealth.Value;
            coinMgr.EnableNewRedCoinsCounter = SwitchButton_EnableNewRedCoinsCounter.Value;
            coinMgr.NewRedCoinsCounterTextForCoin = TextBoxX_NewRedCoinsCounterTextForCoin.Text;
            coinMgr.NewRedCoinsCounterTextForCoins = TextBoxX_NewRedCoinsCounterTextForCoins.Text;
        }

        private void Coins_Settings_Shown(object sender, EventArgs e)
        {
            coinMgr.LoadCoinSettings();
            LoadSettingsToGUI();
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            ApplySettingsToCoinManager();
            coinMgr.SaveCoinSettings();
        }

        private void ButtonX_ImportKaze3DCoins_Click(object sender, EventArgs e)
        {
            coinMgr.ImportKazesCoins();
            Publics.General.ShowToastnotification(Panel1, LangResCoinsManager.Notify_3DCoinsPatchesSuccess, eToastGlowColor.Green);
        }

        private void ButtonX_Remove3DCoins_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show(LangResCoinsManager.MsgBox_Experimental3DCoinsRemove, LangResCoinsManager.MsgBox_Experimental3DCoinsRemove_Titel, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                coinMgr.Remove3DCoins();
                Publics.General.ShowToastnotification(Panel1, LangResCoinsManager.Notify_3DCoinsRemovedSuccess, eToastGlowColor.Green);
            }
        }
    }
}