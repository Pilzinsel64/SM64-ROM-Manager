using System.Collections.Generic;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.SegmentedBanking;
using SM64Lib.Data;

namespace SM64Lib.Model.Fast3D.DisplayLists.Script
{
    public class DisplayListScript : List<DisplayListCommand>
    {
        public void FromStream(object input, int segAddress, byte? AreaID)
        {
            Close();

            var rommgr = input as RomManager;
            var data = input as BinaryData;
            var lastPositions = new Stack<int>();
            SegmentedBank curSeg = null;

            void getSegBank(int segAddr)
            {
                if (rommgr is object)
                {
                    curSeg = FromStream_GetSegBank(rommgr, segAddress, AreaID);
                    data = new BinaryStreamData(curSeg.Data);
                }
            }

            getSegBank(segAddress);
            data.Position = curSeg is object ? curSeg.BankOffsetFromSegAddr(segAddress) : segAddress & 0xffffff;

            bool continueDo = true;
            while (data.Position < curSeg.Length && continueDo)
            {
                // Read Command
                var cmdbytes = new byte[8];
                data.Read(cmdbytes);

                // Create & Add Command
                var cmd = new DisplayListCommand(cmdbytes)
                {
                    RomAddress =  (int)(curSeg?.RomStart    ?? 0 + data.Position),
                    BankAddress = (int)(curSeg?.BankAddress ?? 0 + data.Position)
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
                            getSegBank(segAddr);

                            if (curSeg is object)
                            {
                                if (cmdbytes[1] != 1)
                                    lastPositions.Push(Conversions.ToInteger(data.Position));
                                else
                                    lastPositions.Clear();
                                data.Position = curSeg.BankOffsetFromSegAddr(segAddr);
                            }
                            else
                                break;

                            break;
                        }

                    case CommandTypes.EndDisplaylist:
                        {
                            if (lastPositions.Count > 0)
                                curSeg.Data.Position = lastPositions.Pop();
                            else
                                continueDo = false;
                            break;
                        }
                }
            }
        }

        private SegmentedBank FromStream_GetSegBank(RomManager rommgr, int segAddr, byte? areaID)
        {
            SegmentedBank seg = null;
            
            if (rommgr is object)
            {
                seg = rommgr.GetSegBank(Conversions.ToByte(segAddr >> 24), areaID);
                seg?.ReadDataIfNull(rommgr.RomFile);
            }

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