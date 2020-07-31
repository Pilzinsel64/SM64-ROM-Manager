using Pilz.Reflection.PluginSystem.Attributes;
using SM64_ROM_Manager.Plugins.RomConfigEditor;
using SM64Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Plugin
{
    [PluginFunction("pluginmenur", "ROM.config Editor")]
    public static void OpenEditor(RomManager romManager)
    {
        var frm = new RomConfigEditor(romManager);
        frm.Show();
    }
}
