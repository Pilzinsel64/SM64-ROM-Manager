using System.Collections.Generic;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.SegmentedBanking;

namespace SM64Lib.Model.Fast3D.DisplayLists.Script
{
    public class DisplayListScript : List<DisplayListCommand>
    {
        public void FromStream(RomManager rommgr, int segAddress, byte? AreaID)
        {
            Close();

            var lastPositions = new Stack<int>();
            var curSeg = FromStream_GetSegBank(rommgr, segAddress, AreaID);

            if (curSeg is null) return;

            curSeg.Data.Position = curSeg.BankOffsetFromSegAddr(segAddress);

            bool continueDo = true;
            while (curSeg.Data.Position < curSeg.Length && continueDo)
            {
                // Read Command
                var cmdbytes = new byte[8];
                curSeg.Data.Read(cmdbytes, 0, cmdbytes.Length);

                // Create & Add Command
                var cmd = new DisplayListCommand(cmdbytes)
                {
                    RomAddress = (int)(curSeg.RomStart + curSeg.Data.Position),
                    BankAddress = (int)(curSeg.BankAddress + curSeg.Data.Position)
                };
                Add(cmd);

                switch (cmd.CommandType)
                {
                    case CommandTypes.NOOP:
                        {
                            cmd.Position = 0;
                            int checkVal = cmd.ReadInt32();
                            cmd.Position = 0;
                            if (checkVal != 0)
                                break;
                            break;
                        }

                    case CommandTypes.DisplayList:
                        {
                            cmd.Position = 4;
                            int segAddr = cmd.ReadInt32();
                            cmd.Position = 0;
                            curSeg = FromStream_GetSegBank(rommgr, segAddr, AreaID);
                            if (curSeg is object)
                            {
                                if (cmdbytes[1] != 1)
                                {
                                    lastPositions.Push(Conversions.ToInteger(curSeg.Data.Position));
                                }
                                else
                                {
                                    lastPositions.Clear();
                                }

                                curSeg.Data.Position = curSeg.BankOffsetFromSegAddr(segAddr);
                            }
                            else
                            {
                                break;
                            }

                            break;
                        }

                    case CommandTypes.EndDisplaylist:
                        {
                            if (lastPositions.Count > 0)
                            {
                                curSeg.Data.Position = lastPositions.Pop();
                            }
                            else
                            {
                                continueDo = false;
                            }

                            break;
                        }
                }
            }
        }

        private SegmentedBank FromStream_GetSegBank(RomManager rommgr, int segAddr, byte? areaID)
        {
            var seg = rommgr.GetSegBank(Conversions.ToByte(segAddr >> 24), areaID);
            seg?.ReadDataIfNull(rommgr.RomFile);
            return seg;
        }

        public void ToStream(Stream s, uint pos)
        {
            s.Position = pos;
            foreach (DisplayListCommand cmd in this)
                s.Write(cmd.ToArray(), 0, Conversions.ToInteger(cmd.Length));
        }

        public void Close()
        {
            foreach (var cmd in this)
                cmd.Close();
        }
    }
}