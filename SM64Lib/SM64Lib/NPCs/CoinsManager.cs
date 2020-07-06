using System;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;
using System.Collections.Generic;

namespace SM64Lib.NPCs
{
    public class CoinsManager
    {
        public RomManager RomManager { get; private set; }
        public short CoinsForRedCoinsStar { get; set; } = 8;
        public short CoinsForBowserRedCoinsStar { get; set; } = 8;
        public byte CoinsFor100CoinsStar { get; set; } = 0;
        public bool Enable100CoinsStar { get; set; } = true;
        public bool EnableCoinCounterInHubs { get; set; } = false;
        public bool CoinsRestoreHealth { get; set; } = true;
        public bool EnableNewRedCoinsCounter { get; set; } = false;
        public string NewRedCoinsCounterTextForCoins { get; set; } = "";
        public string NewRedCoinsCounterTextForCoin { get; set; } = "";

        public CoinsManager(RomManager rommgr)
        {
            RomManager = rommgr;
        }

        /// <summary>
        /// Loads all the properties from ROM.
        /// </summary>
        public void LoadCoinSettings()
        {
            BinaryData data = RomManager.GetBinaryRom(FileAccess.Read);

            // Coins for Red Coins Star
            data.Position = 0xADDDE;
            CoinsForRedCoinsStar = data.ReadInt16();

            // Coins for Bowser Red Coins Star
            data.Position = 0xADF82;
            CoinsForBowserRedCoinsStar = data.ReadInt16();

            // Coins for 100 Coins Star
            data.Position = 0x8BB3;
            CoinsFor100CoinsStar = data.ReadByte();

            // Enable 100 Coins
            data.Position = 0x8BC8;
            Enable100CoinsStar = data.ReadInt32() != 0;

            // Enable Coins Counter in Hubs
            data.Position = 0x61AB;
            EnableCoinCounterInHubs = data.ReadByte() == 0xFF;

            // Coins restore health
            data.Position = 0x8B70;
            CoinsRestoreHealth = data.ReadInt32() != 0;

            // Enable New Red Coins Counter
            data.Position = 0x966E8;
            EnableNewRedCoinsCounter = data.ReadInt32() == 0x27BDFFE8;

            // New Red Coins Counter Text For Coins
            if (EnableNewRedCoinsCounter)
            {
                data.Position = 0x69908;
                NewRedCoinsCounterTextForCoins = System.Text.Encoding.ASCII.GetString(data.Read(0x10)).Trim();
            }
            else
            {
                NewRedCoinsCounterTextForCoins = "%d RED COINS";
            }

            // New Red Coins Counter Text For Coins
            if (EnableNewRedCoinsCounter)
            {
                data.Position = 0x69918;
                NewRedCoinsCounterTextForCoin = System.Text.Encoding.ASCII.GetString(data.Read(0x10)).Trim();
            }
            else
            {
                NewRedCoinsCounterTextForCoin = "%d RED COIN";
            }

            data.Close();
        }

        /// <summary>
        /// Saves all the properties to ROM and updates checksum.
        /// </summary>
        public void SaveCoinSettings()
        {
            SaveCoinSettings(true);
        }

        /// <summary>
        /// Saves all the properties to ROM and updates checksum if requested.
        /// </summary>
        public void SaveCoinSettings(bool updateChecksum)
        {
            BinaryData data = RomManager.GetBinaryRom(FileAccess.ReadWrite);

            // Coins for Red Coins Star
            data.Position = 0xADDDE;
            data.Write(CoinsForRedCoinsStar);

            // Coins for Bowser Red Coins Star
            data.Position = 0xADF82;
            data.Write(CoinsForBowserRedCoinsStar);

            // Coins for 100 Coins Star
            data.Position = 0x8BB3;
            data.Write(CoinsFor100CoinsStar);
            data.Position = 0x8BBF;
            data.Write(CoinsFor100CoinsStar);
            data.Position = 0x8BB4;
            data.Write(Conversions.ToShort(0x1020));

            // Enable 100 Coins
            data.Position = 0x8BC8;
            if (Enable100CoinsStar)
            {
                data.Write(0xC0AAD56);
            }
            else
            {
                data.Write(0);
            }

            // Enable Coins Counter in Hubs
            data.Position = 0x61AB;
            if (EnableCoinCounterInHubs)
            {
                data.WriteByte(0xFF);
            }
            else
            {
                data.WriteByte(0xFD);
            }

            // Coins restore health
            data.Position = 0x8B70;
            if (CoinsRestoreHealth)
            {
                data.Write(0xA13800B3);
            }
            else
            {
                data.Write(0);
            }

            // Enable New Red Coins Counter
            data.Position = 0x966E8;
            string nrccCode;
            if (EnableNewRedCoinsCounter)
            {
                nrccCode = "27 BD FF E8 AF BF 00 14 3C 0E 80 36 81 C7 13 FE 10 E0 00 10 00 00 00 00 24 01 00 01 10 E1 00 08 00 00 00 00 24 05 00 24 3C 06 80 2A 34 C6 E9 08 0C 0B 58 B6 24 04 00 A0 10 00 00 06 00 00 00 00 24 05 00 24 3C 06 80 2A 34 C6 E9 18 0C 0B 58 B6 24 04 00 A0 8F BF 00 14 03 E0 00 08 27 BD 00 18";
            }
            else
            {
                nrccCode = "27 BD FF E0 AF BF 00 14 3C 0E 80 36 81 CE 13 FE A3 A0 00 1F 19 C0 00 12 00 00 00 00 83 AF 00 1F 24 19 01 22 24 05 00 10 00 0F C0 80 03 0F C0 21 00 18 C0 80 0C 0B 6D 26 03 38 20 23 83 A8 00 1F 3C 0C 80 36 81 8C 13 FE 25 09 00 01 00 09 56 00 00 0A 5E 03 01 6C 08 2A 14 20 FF F0 A3 A9 00 1F";
            }

            foreach (string b in nrccCode.Split(' '))
                data.Write(Convert.ToByte(b, 16));

            // New Red Coins Counter Text For Coins
            if (EnableNewRedCoinsCounter)
            {
                data.Position = 0x69908;
                data.Write(System.Text.Encoding.ASCII.GetBytes(General.FillStrToCharCount(NewRedCoinsCounterTextForCoins, 0x10, " ")));
            }

            // New Red Coins Counter Text For Coins
            if (EnableNewRedCoinsCounter)
            {
                data.Position = 0x69918;
                data.Write(System.Text.Encoding.ASCII.GetBytes(General.FillStrToCharCount(NewRedCoinsCounterTextForCoin, 0x10, " ")));
            }

            data.Close();

            // Update checksum (because of code changes)
            if (updateChecksum)
            {
                General.PatchClass.UpdateChecksum(RomManager.RomFile);
            }
        }
    }
}