using Pilz.Reflection.PluginSystem.Attributes;
using SM64_ROM_Manager.Plugins;
using System;
using System.Collections.Generic;
using System.IO;

public static class Plugin
{
    [PluginFunction(FunctionCodes.GetHexEditorInstallationStatus, "HxD Hex Editor", "HxD Hex Editor")]
    public static HexEditorStatus GetStatus_HxDHexEditor()
    {
        var status = new HexEditorStatus();
        var probingPaths = new List<string>();

        probingPaths.AddRange(new [] {
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"HxD\HxD.exe"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"HxD\HxD.exe")
        });

        foreach (var path in probingPaths)
        {
            if (!status.IsInstalled && File.Exists(path))
            {
                status.ExecutablePath = path;
                status.IsInstalled = true;
            }
        }

        return status;
    }
}
