using Pilz.Reflection.PluginSystem.Attributes;
using SM64Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Plugin
{
    [LoadMethod()]
    public static void Main()
    {

    }

    [PluginFunction("pluginmenur")]
    public static void OpenEditor(RomManager romManager)
    {

    }
}
