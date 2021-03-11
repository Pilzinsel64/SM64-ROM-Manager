using System;
using System.Collections.Generic;
using System.Text;

namespace SM64_ROM_Manager.Plugins
{
    public static class FunctionCodes
    {
        public const string GetHexEditorInstallationStatus = "rm.plugins.get_hex_editor_status";
        public const string PluginMenu = "pluginmenu";
        public const string PluginMenuR = "pluginmenur";
        public const string FileLoaderModule_Load = "loadermoduleload";
        public const string FileLoaderModule_Export = "loadermoduleexport";
        public const string FileLoaderModule_GetImportFormats = "loadermoduleimpformats";
        public const string FileLoaderModule_GetExportFormats = "loadermoduleexport";
    }
}
