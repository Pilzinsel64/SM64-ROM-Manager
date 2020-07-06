using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Form_CoinsSettings : DevComponents.DotNetBar.OfficeForm
    {

        // Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components = new System.ComponentModel.Container();

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CoinsSettings));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ButtonX_SaveSettings = new DevComponents.DotNetBar.ButtonX();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.LabelX10 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_EnableNewRedCoinsCounter = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_NewRedCoinsCounterTextForCoins = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX_NewRedCoinsCounterTextForCoin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX5 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.SwitchButton_CoinsRestoreHealth = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX9 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_ShowCoinsHudOnHubs = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX8 = new DevComponents.DotNetBar.LabelX();
            this.SwitchButton_Enable100Coins = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LabelX7 = new DevComponents.DotNetBar.LabelX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.IntegerInput_CoinsForRedCoinsStar = new DevComponents.Editors.IntegerInput();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.IntegerInput_CoinsForBowserRedCoinsStar = new DevComponents.Editors.IntegerInput();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.IntegerInput_CoinsFor100CoinsStar = new DevComponents.Editors.IntegerInput();
            this.Panel1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_CoinsForRedCoinsStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_CoinsForBowserRedCoinsStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_CoinsFor100CoinsStar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.ButtonX_SaveSettings);
            this.Panel1.Controls.Add(this.GroupBox3);
            this.Panel1.Controls.Add(this.GroupBox1);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // ButtonX_SaveSettings
            // 
            this.ButtonX_SaveSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_SaveSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_SaveSettings.FocusCuesEnabled = false;
            this.ButtonX_SaveSettings.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_save_16px;
            resources.ApplyResources(this.ButtonX_SaveSettings, "ButtonX_SaveSettings");
            this.ButtonX_SaveSettings.Name = "ButtonX_SaveSettings";
            this.ButtonX_SaveSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_SaveSettings.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.LabelX10);
            this.GroupBox3.Controls.Add(this.SwitchButton_EnableNewRedCoinsCounter);
            this.GroupBox3.Controls.Add(this.LabelX6);
            this.GroupBox3.Controls.Add(this.TextBoxX_NewRedCoinsCounterTextForCoins);
            this.GroupBox3.Controls.Add(this.TextBoxX_NewRedCoinsCounterTextForCoin);
            this.GroupBox3.Controls.Add(this.LabelX5);
            this.GroupBox3.Controls.Add(this.LabelX1);
            resources.ApplyResources(this.GroupBox3, "GroupBox3");
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.TabStop = false;
            // 
            // LabelX10
            // 
            // 
            // 
            // 
            this.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX10, "LabelX10");
            this.LabelX10.Name = "LabelX10";
            // 
            // SwitchButton_EnableNewRedCoinsCounter
            // 
            // 
            // 
            // 
            this.SwitchButton_EnableNewRedCoinsCounter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_EnableNewRedCoinsCounter.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_EnableNewRedCoinsCounter, "SwitchButton_EnableNewRedCoinsCounter");
            this.SwitchButton_EnableNewRedCoinsCounter.Name = "SwitchButton_EnableNewRedCoinsCounter";
            this.SwitchButton_EnableNewRedCoinsCounter.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchButton_EnableNewRedCoinsCounter.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_EnableNewRedCoinsCounter.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_EnableNewRedCoinsCounter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_EnableNewRedCoinsCounter.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_EnableNewRedCoinsCounter.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_EnableNewRedCoinsCounter.SwitchWidth = 15;
            this.SwitchButton_EnableNewRedCoinsCounter.Value = true;
            this.SwitchButton_EnableNewRedCoinsCounter.ValueObject = "Y";
            // 
            // LabelX6
            // 
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX6, "LabelX6");
            this.LabelX6.Name = "LabelX6";
            this.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // TextBoxX_NewRedCoinsCounterTextForCoins
            // 
            this.TextBoxX_NewRedCoinsCounterTextForCoins.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_NewRedCoinsCounterTextForCoins.Border.Class = "TextBoxBorder";
            this.TextBoxX_NewRedCoinsCounterTextForCoins.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_NewRedCoinsCounterTextForCoins.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_NewRedCoinsCounterTextForCoins.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.TextBoxX_NewRedCoinsCounterTextForCoins, "TextBoxX_NewRedCoinsCounterTextForCoins");
            this.TextBoxX_NewRedCoinsCounterTextForCoins.Name = "TextBoxX_NewRedCoinsCounterTextForCoins";
            this.TextBoxX_NewRedCoinsCounterTextForCoins.PreventEnterBeep = true;
            // 
            // TextBoxX_NewRedCoinsCounterTextForCoin
            // 
            this.TextBoxX_NewRedCoinsCounterTextForCoin.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_NewRedCoinsCounterTextForCoin.Border.Class = "TextBoxBorder";
            this.TextBoxX_NewRedCoinsCounterTextForCoin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_NewRedCoinsCounterTextForCoin.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_NewRedCoinsCounterTextForCoin.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.TextBoxX_NewRedCoinsCounterTextForCoin, "TextBoxX_NewRedCoinsCounterTextForCoin");
            this.TextBoxX_NewRedCoinsCounterTextForCoin.Name = "TextBoxX_NewRedCoinsCounterTextForCoin";
            this.TextBoxX_NewRedCoinsCounterTextForCoin.PreventEnterBeep = true;
            // 
            // LabelX5
            // 
            // 
            // 
            // 
            this.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX5, "LabelX5");
            this.LabelX5.Name = "LabelX5";
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX1, "LabelX1");
            this.LabelX1.Name = "LabelX1";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.SwitchButton_CoinsRestoreHealth);
            this.GroupBox1.Controls.Add(this.LabelX9);
            this.GroupBox1.Controls.Add(this.SwitchButton_ShowCoinsHudOnHubs);
            this.GroupBox1.Controls.Add(this.LabelX8);
            this.GroupBox1.Controls.Add(this.SwitchButton_Enable100Coins);
            this.GroupBox1.Controls.Add(this.LabelX7);
            this.GroupBox1.Controls.Add(this.LabelX2);
            this.GroupBox1.Controls.Add(this.IntegerInput_CoinsForRedCoinsStar);
            this.GroupBox1.Controls.Add(this.LabelX4);
            this.GroupBox1.Controls.Add(this.IntegerInput_CoinsForBowserRedCoinsStar);
            this.GroupBox1.Controls.Add(this.LabelX3);
            this.GroupBox1.Controls.Add(this.IntegerInput_CoinsFor100CoinsStar);
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            // 
            // SwitchButton_CoinsRestoreHealth
            // 
            // 
            // 
            // 
            this.SwitchButton_CoinsRestoreHealth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_CoinsRestoreHealth.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_CoinsRestoreHealth, "SwitchButton_CoinsRestoreHealth");
            this.SwitchButton_CoinsRestoreHealth.Name = "SwitchButton_CoinsRestoreHealth";
            this.SwitchButton_CoinsRestoreHealth.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchButton_CoinsRestoreHealth.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_CoinsRestoreHealth.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_CoinsRestoreHealth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_CoinsRestoreHealth.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_CoinsRestoreHealth.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_CoinsRestoreHealth.SwitchWidth = 15;
            this.SwitchButton_CoinsRestoreHealth.Value = true;
            this.SwitchButton_CoinsRestoreHealth.ValueObject = "Y";
            // 
            // LabelX9
            // 
            // 
            // 
            // 
            this.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX9, "LabelX9");
            this.LabelX9.Name = "LabelX9";
            // 
            // SwitchButton_ShowCoinsHudOnHubs
            // 
            // 
            // 
            // 
            this.SwitchButton_ShowCoinsHudOnHubs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_ShowCoinsHudOnHubs.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_ShowCoinsHudOnHubs, "SwitchButton_ShowCoinsHudOnHubs");
            this.SwitchButton_ShowCoinsHudOnHubs.Name = "SwitchButton_ShowCoinsHudOnHubs";
            this.SwitchButton_ShowCoinsHudOnHubs.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchButton_ShowCoinsHudOnHubs.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_ShowCoinsHudOnHubs.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_ShowCoinsHudOnHubs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_ShowCoinsHudOnHubs.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_ShowCoinsHudOnHubs.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_ShowCoinsHudOnHubs.SwitchWidth = 15;
            this.SwitchButton_ShowCoinsHudOnHubs.Value = true;
            this.SwitchButton_ShowCoinsHudOnHubs.ValueObject = "Y";
            // 
            // LabelX8
            // 
            // 
            // 
            // 
            this.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX8, "LabelX8");
            this.LabelX8.Name = "LabelX8";
            // 
            // SwitchButton_Enable100Coins
            // 
            // 
            // 
            // 
            this.SwitchButton_Enable100Coins.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SwitchButton_Enable100Coins.FocusCuesEnabled = false;
            resources.ApplyResources(this.SwitchButton_Enable100Coins, "SwitchButton_Enable100Coins");
            this.SwitchButton_Enable100Coins.Name = "SwitchButton_Enable100Coins";
            this.SwitchButton_Enable100Coins.OffTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchButton_Enable100Coins.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(80)))));
            this.SwitchButton_Enable100Coins.OnTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.SwitchButton_Enable100Coins.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SwitchButton_Enable100Coins.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.SwitchButton_Enable100Coins.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.SwitchButton_Enable100Coins.SwitchWidth = 15;
            this.SwitchButton_Enable100Coins.Value = true;
            this.SwitchButton_Enable100Coins.ValueObject = "Y";
            // 
            // LabelX7
            // 
            // 
            // 
            // 
            this.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX7, "LabelX7");
            this.LabelX7.Name = "LabelX7";
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX2, "LabelX2");
            this.LabelX2.Name = "LabelX2";
            // 
            // IntegerInput_CoinsForRedCoinsStar
            // 
            // 
            // 
            // 
            this.IntegerInput_CoinsForRedCoinsStar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_CoinsForRedCoinsStar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_CoinsForRedCoinsStar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.IntegerInput_CoinsForRedCoinsStar, "IntegerInput_CoinsForRedCoinsStar");
            this.IntegerInput_CoinsForRedCoinsStar.Name = "IntegerInput_CoinsForRedCoinsStar";
            this.IntegerInput_CoinsForRedCoinsStar.ShowUpDown = true;
            // 
            // LabelX4
            // 
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX4, "LabelX4");
            this.LabelX4.Name = "LabelX4";
            // 
            // IntegerInput_CoinsForBowserRedCoinsStar
            // 
            // 
            // 
            // 
            this.IntegerInput_CoinsForBowserRedCoinsStar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_CoinsForBowserRedCoinsStar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_CoinsForBowserRedCoinsStar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.IntegerInput_CoinsForBowserRedCoinsStar, "IntegerInput_CoinsForBowserRedCoinsStar");
            this.IntegerInput_CoinsForBowserRedCoinsStar.Name = "IntegerInput_CoinsForBowserRedCoinsStar";
            this.IntegerInput_CoinsForBowserRedCoinsStar.ShowUpDown = true;
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX3, "LabelX3");
            this.LabelX3.Name = "LabelX3";
            // 
            // IntegerInput_CoinsFor100CoinsStar
            // 
            // 
            // 
            // 
            this.IntegerInput_CoinsFor100CoinsStar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_CoinsFor100CoinsStar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_CoinsFor100CoinsStar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.IntegerInput_CoinsFor100CoinsStar, "IntegerInput_CoinsFor100CoinsStar");
            this.IntegerInput_CoinsFor100CoinsStar.Name = "IntegerInput_CoinsFor100CoinsStar";
            this.IntegerInput_CoinsFor100CoinsStar.ShowUpDown = true;
            // 
            // Form_CoinsSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_CoinsSettings";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_CoinsForRedCoinsStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_CoinsForBowserRedCoinsStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_CoinsFor100CoinsStar)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel Panel1;

        private DevComponents.Editors.IntegerInput IntegerInput_CoinsFor100CoinsStar;

        private DevComponents.Editors.IntegerInput IntegerInput_CoinsForBowserRedCoinsStar;

        private DevComponents.Editors.IntegerInput IntegerInput_CoinsForRedCoinsStar;

        private DevComponents.DotNetBar.LabelX LabelX3;

        private DevComponents.DotNetBar.LabelX LabelX4;

        private DevComponents.DotNetBar.LabelX LabelX2;

        private GroupBox GroupBox1;

        private GroupBox GroupBox3;

        private DevComponents.DotNetBar.LabelX LabelX5;

        private DevComponents.DotNetBar.LabelX LabelX1;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_NewRedCoinsCounterTextForCoins;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_NewRedCoinsCounterTextForCoin;

        private DevComponents.DotNetBar.LabelX LabelX6;

        private DevComponents.DotNetBar.LabelX LabelX7;

        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_Enable100Coins;

        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_ShowCoinsHudOnHubs;

        private DevComponents.DotNetBar.LabelX LabelX8;

        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_CoinsRestoreHealth;

        private DevComponents.DotNetBar.LabelX LabelX9;

        private DevComponents.DotNetBar.LabelX LabelX10;

        private DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_EnableNewRedCoinsCounter;

        private DevComponents.DotNetBar.ButtonX ButtonX_SaveSettings;

    }
}