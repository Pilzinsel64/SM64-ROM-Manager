using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Levels
{
    public static class LevelExportImporter
    {
        private static void CheckParameters(LevelExport export, object destObject, LevelExportContentType requiedContentType, LevelExportImportParameters parameters)
        {
            if (requiedContentType != LevelExportContentType.Unknown && export.ContentType != requiedContentType)
                throw new NotSupportedException("Wrong content type!");

            if (destObject == null)
                throw new ArgumentNullException("The given destination object was null.");

            if (parameters == null)
                throw new ArgumentNullException("Parameters was null");
        }

        public static void ImportLevel(LevelExport export, RomManager destRomManager, LevelExportImportParameters parameters)
        {
            CheckParameters(export, destRomManager, LevelExportContentType.Level, parameters);

            var levels = export.Content as Level[];
            if (levels != null)
            {
                foreach (var level in levels)
                {
                    throw new NotImplementedException();
                    destRomManager.Levels.Add(level);
                }
            }
        }

        public static void ImportArea(LevelExport export, Level destLevel, LevelExportImportParameters parameters)
        {
            CheckParameters(export, destLevel, LevelExportContentType.Area, parameters);

            var areas = export.Content as LevelArea[];
            if (areas != null)
            {
                foreach (var area in areas)
                {
                    throw new NotImplementedException();
                    destLevel.Areas.Add(area);
                }
            }
        }

        public static void ImportScript(LevelExport export, LevelArea destArea, LevelExportImportParameters parameters)
        {
            CheckParameters(export, destArea, LevelExportContentType.Unknown, parameters);
            throw new NotImplementedException();
        }
    }
}
