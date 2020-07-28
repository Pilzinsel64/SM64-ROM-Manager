using SM64Lib.Levels.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Levels
{
    public static class LevelExportImporter
    {
        public static void ImportLevel(LevelExport export, RomManager destRomManager, KeyValuePair<Level, short>[] levelIDs)
        {
            var levels = export.Content as Level[];
            if (levels != null)
            {
                foreach (var level in levels)
                {
                    var id = (ushort?)levelIDs.FirstOrDefault(n => n.Key == level).Value;
                    if (id is object)
                    {
                        level.LevelID = (ushort)id;
                        destRomManager.Levels.Add(level);
                    }
                }
            }
        }

        public static void ImportArea(LevelExport export, Level destLevel, KeyValuePair<LevelArea, byte>[] areaIDs)
        {
            var areas = export.Content as LevelArea[];
            if (areas != null)
            {
                foreach (var area in areas)
                {
                    var id = (byte?)areaIDs.FirstOrDefault(n => n.Key == area).Value;
                    if (id is object)
                    {
                        area.AreaID = (byte)id;
                        destLevel.Areas.Add(area);
                    }
                }
            }
        }

        public static void ImportScript(LevelExport export, LevelArea destArea, LevelscriptCommand[] allowedCommands)
        {
            var cmds = export.Content as LevelscriptCommand[];
            if (cmds is object)
            {
                foreach (var cmd in cmds)
                {
                    if (allowedCommands.Contains(cmd))
                    {
                        switch (export.ContentType)
                        {
                            case LevelExportContentType.Objects:
                                destArea.Objects.Add(cmd);
                                break;
                            case LevelExportContentType.Warps:
                                destArea.Warps.Add(cmd);
                                break;
                        }
                    }
                }
            }
        }
    }
}
