using System;
using global::System.IO;

namespace SM64_ROM_Manager.Updating
{
    internal static class MyPaths
    {
        private static string p = string.Empty;

        public static string GetMyAppDataPath()
        {
            if (string.IsNullOrEmpty(p))
            {
                p = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PilzUpdater");
                if (!Directory.Exists(p))
                {
                    Directory.CreateDirectory(p);
                }
            }

            return p;
        }
    }
}