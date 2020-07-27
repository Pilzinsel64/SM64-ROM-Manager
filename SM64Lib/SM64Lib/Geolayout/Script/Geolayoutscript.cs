using System.Collections.Generic;
using global::System.IO;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;

namespace SM64Lib.Geolayout.Script
{
    public class Geolayoutscript : GeolayoutCommandCollection
    {
        public List<int> GeopointerOffsets = new List<int>();

        public Geolayoutscript()
        {
        }

        public Task ReadAsync(RomManager rommgr, int segAddress)
        {
            var t = new Task(() => Read(rommgr, segAddress));
            t.Start();
            return t;
        }

        public void Read(RomManager rommgr, int segAddress)
        {
            Close();
            Clear();
            GeopointerOffsets.Clear();
            var segBank = rommgr.GetSegBank(Conversions.ToByte(segAddress >> 24));
            if (segBank is null)
                return;
            segBank.ReadDataIfNull(rommgr.RomFile);
            var data = new BinaryStreamData(segBank.Data);
            data.Position = segBank.BankOffsetFromSegAddr(segAddress);
            var tb = new List<byte>();
            GeolayoutCommandTypes cb = default;
            int subNodeIndex = 0;
            bool ende = false;
            while (!ende)
            {
                if (data.Position >= data.Length)
                    break;
                cb = (GeolayoutCommandTypes)data.ReadByte();
                byte lenth = 0;
                switch (cb)
                {
                    case GeolayoutCommandTypes.Background:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.CameraPreset:
                        lenth = 0x14;
                        break;
                    case GeolayoutCommandTypes.DrawingDistance:
                        lenth = 0x4;
                        break;
                    case GeolayoutCommandTypes.EndOfGeolayout:
                        lenth = 0x4;
                        break;
                    case GeolayoutCommandTypes.EndOfNode:
                        lenth = 0x4;
                        break;
                    case GeolayoutCommandTypes.JumpBack:
                        lenth = 0x4;
                        break;
                    case GeolayoutCommandTypes.JumpToSegAddr:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.LoadDisplaylist:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.LoadDisplaylistWithOffset:
                        lenth = 0xC;
                        break;
                    case GeolayoutCommandTypes.ObjectShadown:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.Scale1:
                        lenth = 0x4;
                        break;
                    case GeolayoutCommandTypes.Scale2:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.StartOfNode:
                        lenth = 0x4;
                        break;
                    case GeolayoutCommandTypes.SetScreenRenderArea:
                        lenth = 0xC;
                        break;
                    case GeolayoutCommandTypes.BillboardModel:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.BranchAndStore:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.CameraFrustrum:
                        {
                            var switchExpr = data.ReadByte();
                            switch (switchExpr)
                            {
                                case 0x1:
                                    lenth = 0xC;
                                    break;
                                default:
                                    lenth = 0x8;
                                    break;
                            }

                            segBank.Data.Position -= 1;
                            break;
                        }
                    case GeolayoutCommandTypes.x0B:
                        lenth = 0x4;
                        break;
                    case GeolayoutCommandTypes.x0C:
                        lenth = 0x4;
                        break;
                    case GeolayoutCommandTypes.x0D:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.x0E:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.x10:
                        lenth = 0x10;
                        break;
                    case GeolayoutCommandTypes.x11:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.x12:
                        {
                            var switchExpr = data.ReadByte() >> 4;
                            switch (switchExpr)
                            {
                                case 0x8:
                                    lenth = 0xC;
                                    break;
                                default:
                                    lenth = 0x8;
                                    break;
                            }

                            segBank.Data.Position -= 1;
                            break;
                        }
                    case GeolayoutCommandTypes.x17:
                        lenth = 0x4;
                        break;
                    case GeolayoutCommandTypes.x18:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.x1A:
                        lenth = 0x8;
                        break;
                    case GeolayoutCommandTypes.x1C:
                        lenth = 0xC;
                        break;
                    case var @case when @case == GeolayoutCommandTypes.x1E:
                        lenth = 0x8;
                        break;
                    case var case1 when case1 == GeolayoutCommandTypes.x1f:
                        lenth = 0x10;
                        break;
                    default:
                        break;
                }

                segBank.Data.Position -= 1;
                if (lenth == 0 || segBank.Data.Position + lenth > segBank.Data.Length)
                    break;

                for (int i = 1, loopTo = lenth; i <= loopTo; i++)
                    tb.Add(data.ReadByte());

                var tCommand = new GeolayoutCommand(tb.ToArray());
                int bankOffset = (int)(segBank.Data.Position - lenth);
                tCommand.RomAddress = segBank.RomStart + bankOffset;
                tCommand.BankAddress = segBank.BankAddress + bankOffset;
                Add(tCommand);
                tb.Clear();

                var switchExpr1 = tCommand.CommandType;
                switch (switchExpr1)
                {
                    case GeolayoutCommandTypes.EndOfGeolayout:
                        ende = true;
                        break;
                    case GeolayoutCommandTypes.EndOfNode:
                        subNodeIndex -= 1;
                        break;
                    case GeolayoutCommandTypes.StartOfNode:
                        subNodeIndex += 1;
                        break;
                }
            }
        }

        public void Write(Stream s, int GeolayoutStart)
        {
            var bw = new BinaryWriter(s);

            // Write new Levelscript
            s.Position = GeolayoutStart;
            foreach (GeolayoutCommand c in this)
            {
                if (c.CommandType == GeolayoutCommandTypes.LoadDisplaylist)
                    GeopointerOffsets.Add((int)(s.Position + 0x4));
                foreach (byte b in c.ToArray())
                    bw.Write(b);
            }
        }

        public GeolayoutCommand GetFirst(GeolayoutCommandTypes cmdType)
        {
            foreach (GeolayoutCommand cmd in this)
            {
                if (cmd.CommandType == cmdType)
                {
                    return cmd;
                }
            }

            return null;
        }
    }
}