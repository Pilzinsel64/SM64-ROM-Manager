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
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CoinsSettings));
            _Panel1 = new Panel();
            _ButtonX_SaveSettings = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_SaveSettings.Click += new EventHandler(ButtonX1_Click);
            _GroupBox4 = new GroupBox();
            _ButtonX_Remove3DCoins = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Remove3DCoins.Click += new EventHandler(ButtonX_Remove3DCoins_Click);
            _ButtonX_ImportKaze3DCoins = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_ImportKaze3DCoins.Click += new EventHandler(ButtonX_ImportKaze3DCoins_Click);
            _GroupBox3 = new GroupBox();
            _LabelX10 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_EnableNewRedCoinsCounter = new DevComponents.DotNetBar.Controls.SwitchButton();
            _LabelX6 = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_NewRedCoinsCounterTextForCoins = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_NewRedCoinsCounterTextForCoin = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _GroupBox1 = new GroupBox();
            _SwitchButton_CoinsRestoreHealth = new DevComponents.DotNetBar.Controls.SwitchButton();
            _LabelX9 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_ShowCoinsHudOnHubs = new DevComponents.DotNetBar.Controls.SwitchButton();
            _LabelX8 = new DevComponents.DotNetBar.LabelX();
            _SwitchButton_Enable100Coins = new DevComponents.DotNetBar.Controls.SwitchButton();
            _LabelX7 = new DevComponents.DotNetBar.LabelX();
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_CoinsForRedCoinsStar = new DevComponents.Editors.IntegerInput();
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_CoinsForBowserRedCoinsStar = new DevComponents.Editors.IntegerInput();
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _IntegerInput_CoinsFor100CoinsStar = new DevComponents.Editors.IntegerInput();
            _Panel1.SuspendLayout();
            _GroupBox4.SuspendLayout();
            _GroupBox3.SuspendLayout();
            _GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_CoinsForRedCoinsStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_CoinsForBowserRedCoinsStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_CoinsFor100CoinsStar).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_ButtonX_SaveSettings);
            _Panel1.Controls.Add(_GroupBox4);
            _Panel1.Controls.Add(_GroupBox3);
            _Panel1.Controls.Add(_GroupBox1);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // ButtonX_SaveSettings
            // 
            _ButtonX_SaveSettings.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_SaveSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_SaveSettings.FocusCuesEnabled = false;
            _ButtonX_SaveSettings.Image = My.Resources.MyIcons.icons8_save_16px;
            resources.ApplyResources(_ButtonX_SaveSettings, "ButtonX_SaveSettings");
            _ButtonX_SaveSettings.Name = "ButtonX_SaveSettings";
            _ButtonX_SaveSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // GroupBox4
            // 
            _GroupBox4.Controls.Add(_ButtonX_Remove3DCoins);
            _GroupBox4.Controls.Add(_ButtonX_ImportKaze3DCoins);
            resources.ApplyResources(_GroupBox4, "GroupBox4");
            _GroupBox4.Name = "GroupBox4";
            _GroupBox4.TabStop = false;
            // 
            // ButtonX_Remove3DCoins
            // 
            _ButtonX_Remove3DCoins.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Remove3DCoins.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Remove3DCoins.FocusCuesEnabled = false;
            _ButtonX_Remove3DCoins.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            resources.ApplyResources(_ButtonX_Remove3DCoins, "ButtonX_Remove3DCoins");
            _ButtonX_Remove3DCoins.Name = "ButtonX_Remove3DCoins";
            _ButtonX_Remove3DCoins.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_ImportKaze3DCoins
            // 
            _ButtonX_ImportKaze3DCoins.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_ImportKaze3DCoins.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_ImportKaze3DCoins.FocusCuesEnabled = false;
            resources.ApplyResources(_ButtonX_ImportKaze3DCoins, "ButtonX_ImportKaze3DCoins");
            _ButtonX_ImportKaze3DCoins.Name = "ButtonX_ImportKaze3DCoins";
            _ButtonX_ImportKaze3DCoins.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // GroupBox3
            // 
            _GroupBox3.Controls.Add(_LabelX10);
            _GroupBox3.Controls.Add(_SwitchButton_EnableNewRedCoinsCounter);
            _GroupBox3.Controls.Add(_LabelX6);
            _GroupBox3.Controls.Add(_TextBoxX_NewRedCoinsCounterTextForCoins);
            _GroupBox3.Controls.Add(_TextBoxX_NewRedCoinsCounterTextForCoin);
            _GroupBox3.Controls.Add(_LabelX5);
            _GroupBox3.Controls.Add(_LabelX1);
            resources.ApplyResources(_GroupBox3, "GroupBox3");
            _GroupBox3.Name = "GroupBox3";
            _GroupBox3.TabStop = false;
            // 
            // LabelX10
            // 
            // 
            // 
            // 
            _LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX10, "LabelX10");
            _LabelX10.Name = "LabelX10";
            // 
            // SwitchButton_EnableNewRedCoinsCounter
            // 
            // 
            // 
            // 
            _SwitchButton_EnableNewRedCoinsCounter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_EnableNewRedCoinsCounter.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_EnableNewRedCoinsCounter, "SwitchButton_EnableNewRedCoinsCounter");
            _SwitchButton_EnableNewRedCoinsCounter.Name = "SwitchButton_EnableNewRedCoinsCounter";
            _SwitchButton_EnableNewRedCoinsCounter.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_EnableNewRedCoinsCounter.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_EnableNewRedCoinsCounter.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_EnableNewRedCoinsCounter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_EnableNewRedCoinsCounter.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_EnableNewRedCoinsCounter.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_EnableNewRedCoinsCounter.SwitchWidth = 15;
            _SwitchButton_EnableNewRedCoinsCounter.Value = true;
            _SwitchButton_EnableNewRedCoinsCounter.ValueObject = "Y";
            // 
            // LabelX6
            // 
            // 
            // 
            // 
            _LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX6, "LabelX6");
            _LabelX6.Name = "LabelX6";
            _LabelX6.TextAlignment = StringAlignment.Center;
            // 
            // TextBoxX_NewRedCoinsCounterTextForCoins
            // 
            _TextBoxX_NewRedCoinsCounterTextForCoins.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_NewRedCoinsCounterTextForCoins.Border.Class = "TextBoxBorder";
            _TextBoxX_NewRedCoinsCounterTextForCoins.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_NewRedCoinsCounterTextForCoins.DisabledBackColor = Color.White;
            _TextBoxX_NewRedCoinsCounterTextForCoins.ForeColor = Color.Black;
            resources.ApplyResources(_TextBoxX_NewRedCoinsCounterTextForCoins, "TextBoxX_NewRedCoinsCounterTextForCoins");
            _TextBoxX_NewRedCoinsCounterTextForCoins.Name = "TextBoxX_NewRedCoinsCounterTextForCoins";
            _TextBoxX_NewRedCoinsCounterTextForCoins.PreventEnterBeep = true;
            // 
            // TextBoxX_NewRedCoinsCounterTextForCoin
            // 
            _TextBoxX_NewRedCoinsCounterTextForCoin.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_NewRedCoinsCounterTextForCoin.Border.Class = "TextBoxBorder";
            _TextBoxX_NewRedCoinsCounterTextForCoin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_NewRedCoinsCounterTextForCoin.DisabledBackColor = Color.White;
            _TextBoxX_NewRedCoinsCounterTextForCoin.ForeColor = Color.Black;
            resources.ApplyResources(_TextBoxX_NewRedCoinsCounterTextForCoin, "TextBoxX_NewRedCoinsCounterTextForCoin");
            _TextBoxX_NewRedCoinsCounterTextForCoin.Name = "TextBoxX_NewRedCoinsCounterTextForCoin";
            _TextBoxX_NewRedCoinsCounterTextForCoin.PreventEnterBeep = true;
            // 
            // LabelX5
            // 
            // 
            // 
            // 
            _LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX5, "LabelX5");
            _LabelX5.Name = "LabelX5";
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX1, "LabelX1");
            _LabelX1.Name = "LabelX1";
            // 
            // GroupBox1
            // 
            _GroupBox1.Controls.Add(_SwitchButton_CoinsRestoreHealth);
            _GroupBox1.Controls.Add(_LabelX9);
            _GroupBox1.Controls.Add(_SwitchButton_ShowCoinsHudOnHubs);
            _GroupBox1.Controls.Add(_LabelX8);
            _GroupBox1.Controls.Add(_SwitchButton_Enable100Coins);
            _GroupBox1.Controls.Add(_LabelX7);
            _GroupBox1.Controls.Add(_LabelX2);
            _GroupBox1.Controls.Add(_IntegerInput_CoinsForRedCoinsStar);
            _GroupBox1.Controls.Add(_LabelX4);
            _GroupBox1.Controls.Add(_IntegerInput_CoinsForBowserRedCoinsStar);
            _GroupBox1.Controls.Add(_LabelX3);
            _GroupBox1.Controls.Add(_IntegerInput_CoinsFor100CoinsStar);
            resources.ApplyResources(_GroupBox1, "GroupBox1");
            _GroupBox1.Name = "GroupBox1";
            _GroupBox1.TabStop = false;
            // 
            // SwitchButton_CoinsRestoreHealth
            // 
            // 
            // 
            // 
            _SwitchButton_CoinsRestoreHealth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_CoinsRestoreHealth.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_CoinsRestoreHealth, "SwitchButton_CoinsRestoreHealth");
            _SwitchButton_CoinsRestoreHealth.Name = "SwitchButton_CoinsRestoreHealth";
            _SwitchButton_CoinsRestoreHealth.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_CoinsRestoreHealth.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_CoinsRestoreHealth.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_CoinsRestoreHealth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_CoinsRestoreHealth.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_CoinsRestoreHealth.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_CoinsRestoreHealth.SwitchWidth = 15;
            _SwitchButton_CoinsRestoreHealth.Value = true;
            _SwitchButton_CoinsRestoreHealth.ValueObject = "Y";
            // 
            // LabelX9
            // 
            // 
            // 
            // 
            _LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX9, "LabelX9");
            _LabelX9.Name = "LabelX9";
            // 
            // SwitchButton_ShowCoinsHudOnHubs
            // 
            // 
            // 
            // 
            _SwitchButton_ShowCoinsHudOnHubs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_ShowCoinsHudOnHubs.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_ShowCoinsHudOnHubs, "SwitchButton_ShowCoinsHudOnHubs");
            _SwitchButton_ShowCoinsHudOnHubs.Name = "SwitchButton_ShowCoinsHudOnHubs";
            _SwitchButton_ShowCoinsHudOnHubs.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_ShowCoinsHudOnHubs.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_ShowCoinsHudOnHubs.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_ShowCoinsHudOnHubs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_ShowCoinsHudOnHubs.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_ShowCoinsHudOnHubs.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_ShowCoinsHudOnHubs.SwitchWidth = 15;
            _SwitchButton_ShowCoinsHudOnHubs.Value = true;
            _SwitchButton_ShowCoinsHudOnHubs.ValueObject = "Y";
            // 
            // LabelX8
            // 
            // 
            // 
            // 
            _LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX8, "LabelX8");
            _LabelX8.Name = "LabelX8";
            // 
            // SwitchButton_Enable100Coins
            // 
            // 
            // 
            // 
            _SwitchButton_Enable100Coins.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _SwitchButton_Enable100Coins.FocusCuesEnabled = false;
            resources.ApplyResources(_SwitchButton_Enable100Coins, "SwitchButton_Enable100Coins");
            _SwitchButton_Enable100Coins.Name = "SwitchButton_Enable100Coins";
            _SwitchButton_Enable100Coins.OffTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SwitchButton_Enable100Coins.OnBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(139)), Conversions.ToInteger(Conversions.ToByte(195)), Conversions.ToInteger(Conversions.ToByte(80)));
            _SwitchButton_Enable100Coins.OnTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(21)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(139)));
            _SwitchButton_Enable100Coins.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SwitchButton_Enable100Coins.SwitchBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(147)), Conversions.ToInteger(Conversions.ToByte(164)), Conversions.ToInteger(Conversions.ToByte(181)));
            _SwitchButton_Enable100Coins.SwitchBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(69)), Conversions.ToInteger(Conversions.ToByte(85)), Conversions.ToInteger(Conversions.ToByte(107)));
            _SwitchButton_Enable100Coins.SwitchWidth = 15;
            _SwitchButton_Enable100Coins.Value = true;
            _SwitchButton_Enable100Coins.ValueObject = "Y";
            // 
            // LabelX7
            // 
            // 
            // 
            // 
            _LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX7, "LabelX7");
            _LabelX7.Name = "LabelX7";
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX2, "LabelX2");
            _LabelX2.Name = "LabelX2";
            // 
            // IntegerInput_CoinsForRedCoinsStar
            // 
            // 
            // 
            // 
            _IntegerInput_CoinsForRedCoinsStar.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_CoinsForRedCoinsStar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_CoinsForRedCoinsStar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(_IntegerInput_CoinsForRedCoinsStar, "IntegerInput_CoinsForRedCoinsStar");
            _IntegerInput_CoinsForRedCoinsStar.Name = "IntegerInput_CoinsForRedCoinsStar";
            _IntegerInput_CoinsForRedCoinsStar.ShowUpDown = true;
            // 
            // LabelX4
            // 
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX4, "LabelX4");
            _LabelX4.Name = "LabelX4";
            // 
            // IntegerInput_CoinsForBowserRedCoinsStar
            // 
            // 
            // 
            // 
            _IntegerInput_CoinsForBowserRedCoinsStar.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_CoinsForBowserRedCoinsStar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_CoinsForBowserRedCoinsStar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(_IntegerInput_CoinsForBowserRedCoinsStar, "IntegerInput_CoinsForBowserRedCoinsStar");
            _IntegerInput_CoinsForBowserRedCoinsStar.Name = "IntegerInput_CoinsForBowserRedCoinsStar";
            _IntegerInput_CoinsForBowserRedCoinsStar.ShowUpDown = true;
            // 
            // LabelX3
            // 
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX3, "LabelX3");
            _LabelX3.Name = "LabelX3";
            // 
            // IntegerInput_CoinsFor100CoinsStar
            // 
            // 
            // 
            // 
            _IntegerInput_CoinsFor100CoinsStar.BackgroundStyle.Class = "DateTimeInputBackground";
            _IntegerInput_CoinsFor100CoinsStar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _IntegerInput_CoinsFor100CoinsStar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(_IntegerInput_CoinsFor100CoinsStar, "IntegerInput_CoinsFor100CoinsStar");
            _IntegerInput_CoinsFor100CoinsStar.Name = "IntegerInput_CoinsFor100CoinsStar";
            _IntegerInput_CoinsFor100CoinsStar.ShowUpDown = true;
            // 
            // Form_CoinsSettings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form_CoinsSettings";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            _GroupBox4.ResumeLayout(false);
            _GroupBox3.ResumeLayout(false);
            _GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_CoinsForRedCoinsStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_CoinsForBowserRedCoinsStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)_IntegerInput_CoinsFor100CoinsStar).EndInit();
            ResumeLayout(false);
        }

        private Panel _Panel1;

        internal Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_CoinsFor100CoinsStar;

        internal DevComponents.Editors.IntegerInput IntegerInput_CoinsFor100CoinsStar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_CoinsFor100CoinsStar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_CoinsFor100CoinsStar != null)
                {
                }

                _IntegerInput_CoinsFor100CoinsStar = value;
                if (_IntegerInput_CoinsFor100CoinsStar != null)
                {
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_CoinsForBowserRedCoinsStar;

        internal DevComponents.Editors.IntegerInput IntegerInput_CoinsForBowserRedCoinsStar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_CoinsForBowserRedCoinsStar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_CoinsForBowserRedCoinsStar != null)
                {
                }

                _IntegerInput_CoinsForBowserRedCoinsStar = value;
                if (_IntegerInput_CoinsForBowserRedCoinsStar != null)
                {
                }
            }
        }

        private DevComponents.Editors.IntegerInput _IntegerInput_CoinsForRedCoinsStar;

        internal DevComponents.Editors.IntegerInput IntegerInput_CoinsForRedCoinsStar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _IntegerInput_CoinsForRedCoinsStar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_IntegerInput_CoinsForRedCoinsStar != null)
                {
                }

                _IntegerInput_CoinsForRedCoinsStar = value;
                if (_IntegerInput_CoinsForRedCoinsStar != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX3;

        internal DevComponents.DotNetBar.LabelX LabelX3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX3 != null)
                {
                }

                _LabelX3 = value;
                if (_LabelX3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX4;

        internal DevComponents.DotNetBar.LabelX LabelX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX4 != null)
                {
                }

                _LabelX4 = value;
                if (_LabelX4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX2;

        internal DevComponents.DotNetBar.LabelX LabelX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX2 != null)
                {
                }

                _LabelX2 = value;
                if (_LabelX2 != null)
                {
                }
            }
        }

        private GroupBox _GroupBox1;

        internal GroupBox GroupBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox1 != null)
                {
                }

                _GroupBox1 = value;
                if (_GroupBox1 != null)
                {
                }
            }
        }

        private GroupBox _GroupBox3;

        internal GroupBox GroupBox3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox3 != null)
                {
                }

                _GroupBox3 = value;
                if (_GroupBox3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX5;

        internal DevComponents.DotNetBar.LabelX LabelX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX5 != null)
                {
                }

                _LabelX5 = value;
                if (_LabelX5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX1;

        internal DevComponents.DotNetBar.LabelX LabelX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX1 != null)
                {
                }

                _LabelX1 = value;
                if (_LabelX1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_NewRedCoinsCounterTextForCoins;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_NewRedCoinsCounterTextForCoins
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_NewRedCoinsCounterTextForCoins;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_NewRedCoinsCounterTextForCoins != null)
                {
                }

                _TextBoxX_NewRedCoinsCounterTextForCoins = value;
                if (_TextBoxX_NewRedCoinsCounterTextForCoins != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_NewRedCoinsCounterTextForCoin;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_NewRedCoinsCounterTextForCoin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_NewRedCoinsCounterTextForCoin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_NewRedCoinsCounterTextForCoin != null)
                {
                }

                _TextBoxX_NewRedCoinsCounterTextForCoin = value;
                if (_TextBoxX_NewRedCoinsCounterTextForCoin != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX6;

        internal DevComponents.DotNetBar.LabelX LabelX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX6 != null)
                {
                }

                _LabelX6 = value;
                if (_LabelX6 != null)
                {
                }
            }
        }

        private GroupBox _GroupBox4;

        internal GroupBox GroupBox4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox4 != null)
                {
                }

                _GroupBox4 = value;
                if (_GroupBox4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Remove3DCoins;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Remove3DCoins
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Remove3DCoins;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Remove3DCoins != null)
                {
                    _ButtonX_Remove3DCoins.Click -= ButtonX_Remove3DCoins_Click;
                }

                _ButtonX_Remove3DCoins = value;
                if (_ButtonX_Remove3DCoins != null)
                {
                    _ButtonX_Remove3DCoins.Click += ButtonX_Remove3DCoins_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_ImportKaze3DCoins;

        internal DevComponents.DotNetBar.ButtonX ButtonX_ImportKaze3DCoins
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_ImportKaze3DCoins;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_ImportKaze3DCoins != null)
                {
                    _ButtonX_ImportKaze3DCoins.Click -= ButtonX_ImportKaze3DCoins_Click;
                }

                _ButtonX_ImportKaze3DCoins = value;
                if (_ButtonX_ImportKaze3DCoins != null)
                {
                    _ButtonX_ImportKaze3DCoins.Click += ButtonX_ImportKaze3DCoins_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX7;

        internal DevComponents.DotNetBar.LabelX LabelX7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX7 != null)
                {
                }

                _LabelX7 = value;
                if (_LabelX7 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_Enable100Coins;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_Enable100Coins
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_Enable100Coins;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_Enable100Coins != null)
                {
                }

                _SwitchButton_Enable100Coins = value;
                if (_SwitchButton_Enable100Coins != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_ShowCoinsHudOnHubs;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_ShowCoinsHudOnHubs
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_ShowCoinsHudOnHubs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_ShowCoinsHudOnHubs != null)
                {
                }

                _SwitchButton_ShowCoinsHudOnHubs = value;
                if (_SwitchButton_ShowCoinsHudOnHubs != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX8;

        internal DevComponents.DotNetBar.LabelX LabelX8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX8 != null)
                {
                }

                _LabelX8 = value;
                if (_LabelX8 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_CoinsRestoreHealth;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_CoinsRestoreHealth
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_CoinsRestoreHealth;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_CoinsRestoreHealth != null)
                {
                }

                _SwitchButton_CoinsRestoreHealth = value;
                if (_SwitchButton_CoinsRestoreHealth != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX9;

        internal DevComponents.DotNetBar.LabelX LabelX9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX9 != null)
                {
                }

                _LabelX9 = value;
                if (_LabelX9 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX10;

        internal DevComponents.DotNetBar.LabelX LabelX10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX10 != null)
                {
                }

                _LabelX10 = value;
                if (_LabelX10 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.SwitchButton _SwitchButton_EnableNewRedCoinsCounter;

        internal DevComponents.DotNetBar.Controls.SwitchButton SwitchButton_EnableNewRedCoinsCounter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SwitchButton_EnableNewRedCoinsCounter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SwitchButton_EnableNewRedCoinsCounter != null)
                {
                }

                _SwitchButton_EnableNewRedCoinsCounter = value;
                if (_SwitchButton_EnableNewRedCoinsCounter != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_SaveSettings;

        internal DevComponents.DotNetBar.ButtonX ButtonX_SaveSettings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_SaveSettings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_SaveSettings != null)
                {
                    _ButtonX_SaveSettings.Click -= ButtonX1_Click;
                }

                _ButtonX_SaveSettings = value;
                if (_ButtonX_SaveSettings != null)
                {
                    _ButtonX_SaveSettings.Click += ButtonX1_Click;
                }
            }
        }
    }
}