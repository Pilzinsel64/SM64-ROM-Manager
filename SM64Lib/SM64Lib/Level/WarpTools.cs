using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;

namespace SM64Lib.Levels
{
    public class WarpTools
    {
        public static int GetWarpsCountInArea(LevelArea cArea)
        {
            int count = 0;
            count += cArea.Warps.Where(n => new[] { LevelscriptCommandTypes.PaintingWarp, LevelscriptCommandTypes.ConnectedWarp }.Contains(n.CommandType)).Count();
            count += cArea.WarpsForGame.Concat(cArea.Warps).Count();
            return count;
        }

        public static int GetWarpsCountInLevel(Level cLevel)
        {
            int count = 0;
            foreach (LevelArea a in cLevel.Areas)
                count += GetWarpsCountInArea(a);
            return count;
        }

        public static byte GetNextUnusedWarpID(LevelArea cArea)
        {
            var forbitten = new List<byte>();
            foreach (LevelscriptCommand cmd in cArea.WarpsForGame.Concat(cArea.Warps))
                forbitten.Add(clWarp.GetWarpID(cmd));
            for (int i = byte.MinValue; i <= byte.MaxValue; i++)
            {
                if (!forbitten.Contains(Conversions.ToByte(i)))
                    return Conversions.ToByte(i);
            }

            return byte.MaxValue;
        }
    }
}