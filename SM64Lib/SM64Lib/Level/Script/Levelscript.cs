using System;
using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;
using global::SM64Lib.Levels.Script.Commands;
using global::SM64Lib.SegmentedBanking;

namespace SM64Lib.Levels.Script
{
    public class Levelscript : LevelscriptCommandCollection
    {
        public new void Close()
        {
            for (int i = 0, loopTo = Count - 1; i <= loopTo; i++)
                this[i].Close();
            Clear();
        }

        public Levelscript()
        {
        }

        public void Read(RomManager rommgr, int scriptStartInBank, LevelscriptCommandTypes EndAtCommands = LevelscriptCommandTypes.EndOfLevel, Dictionary<byte, SegmentedBank> segDic = null, bool storeToRommgr = true)
        {
            Stream s = null;
            BinaryReader br = null;
            FileStream fs = null;
            BinaryReader brfs = null;
            var tb = new List<byte>();
            LevelscriptCommandTypes cb = default;
            bool enableDo = true;
            SegmentedBank curSegBank = null;
            var dicBankBinaryReaders = new Dictionary<byte, BinaryReader>();
            var brStack = new Stack<BinaryReader>();
            var sStack = new Stack<Stream>();
            var jumpStack = new Stack<int>();
            var segStack = new Stack<SegmentedBank>();
            Close();
            Read_GetStream(ref curSegBank, ref s, ref br, ref fs, ref brfs, rommgr, scriptStartInBank, dicBankBinaryReaders, segDic);
            while (enableDo)
            {
                try
                {
                    cb = (LevelscriptCommandTypes)br.ReadByte();
                    byte lenth = 0;
                    lenth = br.ReadByte();
                    if (lenth == 0)
                        lenth = 4;
                    tb.Add((byte)cb);
                    tb.Add(lenth);
                    for (int i = 3, loopTo = lenth; i <= loopTo; i++)
                        tb.Add(br.ReadByte());
                    var curLvlCmd = new LevelscriptCommand(tb.ToArray());
                    int bankOffset = (int)(br.BaseStream.Position - lenth);
                    curLvlCmd.RomAddress = (int)(curSegBank?.RomStart + bankOffset);
                    curLvlCmd.BankAddress = (int)(curSegBank?.BankAddress + bankOffset);
                    Add(curLvlCmd);
                    tb.Clear();
                    var switchExpr = curLvlCmd.CommandType;
                    switch (switchExpr)
                    {
                        case LevelscriptCommandTypes.LoadRomToRam:
                        case LevelscriptCommandTypes.x1A:
                        case LevelscriptCommandTypes.x18:
                        case LevelscriptCommandTypes.x00:
                        case LevelscriptCommandTypes.x01:
                            {
                                var bank = new SegmentedBank()
                                {
                                    BankID = clLoadRomToRam.GetSegmentedID(curLvlCmd),
                                    RomStart = clLoadRomToRam.GetRomStart(curLvlCmd),
                                    RomEnd = clLoadRomToRam.GetRomEnd(curLvlCmd)
                                };
                                if (curLvlCmd.CommandType == LevelscriptCommandTypes.x1A)
                                    bank.MakeAsMIO0();
                                if (storeToRommgr)
                                    rommgr?.SetSegBank(bank);
                                if (segDic is object)
                                {
                                    if (segDic.ContainsKey(bank.BankID))
                                    {
                                        segDic[bank.BankID] = bank;
                                    }
                                    else
                                    {
                                        segDic.Add(bank.BankID, bank);
                                    }
                                }

                                if (new[] { LevelscriptCommandTypes.x00, LevelscriptCommandTypes.x01 }.Contains(curLvlCmd.CommandType))
                                {
                                    int SegAddr = clLoadRomToRam.GetSegmentedAddressToJump(curLvlCmd);
                                    JumpTo(jumpStack, sStack, brStack, segStack, ref curSegBank, ref s, ref br, ref fs, ref brfs, rommgr, SegAddr, dicBankBinaryReaders, segDic);
                                }

                                break;
                            }

                        case LevelscriptCommandTypes.JumpToSegAddr:
                            {
                                int SegAddr = clJumpToSegAddr.GetSegJumpAddr(curLvlCmd);
                                if (new[] { 0x19, 0xE }.Contains(SegAddr >> 24))
                                {
                                    JumpTo(jumpStack, sStack, brStack, segStack, ref curSegBank, ref s, ref br, ref fs, ref brfs, rommgr, SegAddr, dicBankBinaryReaders, segDic);
                                }

                                break;
                            }

                        case LevelscriptCommandTypes.JumpBack:
                        case (LevelscriptCommandTypes)0xA: // Jump back
                            {
                                curSegBank = segStack.Pop();
                                s = sStack.Pop();
                                br = brStack.Pop();
                                s.Position = jumpStack.Pop();
                                break;
                            }
                    }

                    if (curLvlCmd.CommandType == LevelscriptCommandTypes.EndOfLevel || curLvlCmd.CommandType == EndAtCommands)
                    {
                        enableDo = false;
                    }
                }
                catch (Exception)
                {
                    enableDo = false;
                }
            }

            // If s Is fs Then s?.Close()
            fs?.Close();
        }

        private void JumpTo(Stack<int> jumpStack, Stack<Stream> sStack, Stack<BinaryReader> brStack, Stack<SegmentedBank> segStack, ref SegmentedBank curSegBank, ref Stream s, ref BinaryReader br, ref FileStream fs, ref BinaryReader brfs, RomManager rommgr, int scriptStartInBank, Dictionary<byte, BinaryReader> dicBankBinaryReaders, Dictionary<byte, SegmentedBank> segDic)
        {
            jumpStack.Push(Conversions.ToInteger(s.Position));
            sStack.Push(s);
            brStack.Push(br);
            segStack.Push(curSegBank);
            Read_GetStream(ref curSegBank, ref s, ref br, ref fs, ref brfs, rommgr, scriptStartInBank, dicBankBinaryReaders, segDic);
        }

        private void Read_GetStream(ref SegmentedBank curSegBank, ref Stream s, ref BinaryReader br, ref FileStream fs, ref BinaryReader brfs, RomManager rommgr, int scriptStartInBank, Dictionary<byte, BinaryReader> dicBankBinaryReaders, Dictionary<byte, SegmentedBank> segDic)
        {
            byte bankID = Conversions.ToByte(scriptStartInBank >> 24);
            curSegBank = rommgr.GetSegBank(bankID);
            if (curSegBank is null && segDic?.ContainsKey(bankID) == true)
            {
                curSegBank = segDic[bankID];
            }

            if (curSegBank?.Data is object)
            {
                s = curSegBank.Data;
                if (dicBankBinaryReaders.ContainsKey(curSegBank.BankID))
                {
                    br = dicBankBinaryReaders[curSegBank.BankID];
                }
                else
                {
                    br = new BinaryReader(curSegBank.Data);
                    dicBankBinaryReaders.Add(curSegBank.BankID, br);
                }
            }
            else
            {
                if (fs is null)
                    fs = new FileStream(rommgr.RomFile, FileMode.Open, FileAccess.Read);
                if (brfs is null)
                    brfs = new BinaryReader(fs);
                s = fs;
                br = brfs;
            }

            if (curSegBank is object)
            {
                s.Position = s == fs ? curSegBank.SegToRomAddr(scriptStartInBank) : curSegBank.BankOffsetFromSegAddr(scriptStartInBank);
            }
        }

        public void Write(Stream s, int LevelscriptStart)
        {
            Write(new BinaryStreamData(s), LevelscriptStart);
        }

        public void Write(BinaryData data, int LevelscriptStart)
        {
            var JumpList = new List<int>();

            // Write new Levelscript
            data.Position = LevelscriptStart;
            foreach (LevelscriptCommand c in this)
            {
                foreach (byte b in c.ToArray())
                    data.Write(b);
            }
        }
    }
}