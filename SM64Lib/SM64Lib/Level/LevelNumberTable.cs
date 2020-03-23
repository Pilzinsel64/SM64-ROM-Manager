using System.Collections.Generic;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64Lib.Levels
{
    public class LevelNumberTable : List<byte>
    {
        public void ReadFromROM(string Romfile, int Address = 0xE8D98)
        {
            var fs = new FileStream(Romfile, FileMode.Open, FileAccess.Read);
            ReadFromROM(ref fs);
            fs.Close();
        }

        public void ReadFromROM(ref FileStream fs, int Address = 0xE8D98)
        {
            Clear();
            for (int i = 0; i <= 30; i++)
            {
                fs.Position = Address + General.GetLevelIDFromIndex(Conversions.ToByte(i));
                Add(Conversions.ToByte(fs.ReadByte()));
            }
        }
    }
}