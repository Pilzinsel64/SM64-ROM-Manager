using System.Drawing;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using global::SM64Lib;
using global::SM64Lib.Data;

namespace SM64_ROM_Manager
{
    public class HUDOptions
    {
        private BinaryData binaryData;

        public HUDOptionsBlock Block { get; private set; } = null;
        public RomManager RomManager { get; private set; }

        public HUDOptions(RomManager rommgr)
        {
            RomManager = rommgr;
        }

        public void LoadBlock(string p)
        {
            Block = JObject.Parse(File.ReadAllText(p)).ToObject<HUDOptionsBlock>();
        }

        public Point GetPosition(HUDOptionsBlock b)
        {
            Point GetPositionRet = default;
            GetPositionRet = Point.Empty;
            if (b?.Cords is object && binaryData?.CanRead == true)
            {
                binaryData.Position = (long)b.Cords.RomPosX;
                GetPositionRet.X = binaryData.ReadInt16();
                binaryData.Position = (long)b.Cords.RomPosY;
                GetPositionRet.Y = binaryData.ReadInt16();
            }

            return GetPositionRet;
        }

        public object GetValue(HUDOptionsBlock b)
        {
            object value = -1;

            if (b?.ValueSelection is HUDOptionsValueSelection && (bool)binaryData?.CanRead)
            {
                binaryData.Position = b.ValueSelection.RomPos;
                switch (b.ValueSelection.ValueType)
                {
                    case HUDOptionsValueTypes.Byte:
                        value = binaryData.ReadByte();
                        break;
                }
            }

            return value;
        }

        public void SetPosition(HUDOptionsBlock b, Point p)
        {
            if (b?.Cords is object && binaryData?.CanWrite == true)
            {
                if (b.Cords.RomPosX is object)
                {
                    binaryData.Position = (long)b.Cords.RomPosX;
                    binaryData.Write(Conversions.ToShort(p.X));
                }

                if (b.Cords.RomPosY is object)
                {
                    binaryData.Position = (long)b.Cords.RomPosY;
                    binaryData.Write(Conversions.ToShort(p.Y));
                }
            }
        }

        public void SetValue(HUDOptionsBlock b, object value)
        {
            if (b?.ValueSelection is HUDOptionsValueSelection && (bool)binaryData?.CanWrite)
            {
                binaryData.Position = b.ValueSelection.RomPos;
                switch (b.ValueSelection.ValueType)
                {
                    case HUDOptionsValueTypes.Byte:
                        binaryData.Write((byte)value);
                        break;
                }
            }
        }

        public void OpenRomRead()
        {
            if (binaryData is null || !binaryData.CanRead)
            {
                CloseRom();
                binaryData = RomManager.GetBinaryRom(FileAccess.Read);
            }
        }

        public void OpenRomWrite()
        {
            if (binaryData is null || !binaryData.CanWrite)
            {
                CloseRom();
                binaryData = RomManager.GetBinaryRom(FileAccess.ReadWrite);
            }
        }

        public void CloseRom()
        {
            if (binaryData is object)
            {
                binaryData.Close();
                binaryData = null;
            }
        }
    }
}