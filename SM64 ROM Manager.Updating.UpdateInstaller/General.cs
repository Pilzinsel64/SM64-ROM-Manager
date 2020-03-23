using global::System.IO;
using global::System.Reflection;

namespace SM64_ROM_Manager.Updating.UpdateInstaller
{
    internal static class General
    {
        private static string p = string.Empty;

        public static string MyAppPath
        {
            get
            {
                if (string.IsNullOrEmpty(p))
                {
                    p = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                }

                return p;
            }
        }
    }
}