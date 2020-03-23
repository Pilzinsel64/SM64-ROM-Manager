using System;

namespace SM64Lib.Levels.Script
{
    [Serializable]
    public enum LevelscriptCommandTypes
    {
        x00 = 0x0,
        x01 = 0x1,
        EndOfLevel = 0x2,
        x03 = 0x3,
        x04 = 0x4,
        x05 = 0x5,
        JumpToSegAddr = 0x6,
        JumpBack = 0x7,
        x0A = 0xA,
        x0C = 0xC,
        x10 = 0x10,
        x11 = 0x11,
        x12 = 0x12,
        x16 = 0x16,
        LoadRomToRam = 0x17,
        x18 = 0x18,
        x19 = 0x19,
        x1A = 0x1A,
        x1B = 0x1B,
        x1C = 0x1C,
        x1D = 0x1D,
        x1E = 0x1E,
        StartArea = 0x1F,
        EndOfArea = 0x20,
        LoadPolygonWithGeo = 0x22,
        LoadPolygonWithoutGeo = 0x21,
        Normal3DObject = 0x24,
        x25 = 0x25,
        ConnectedWarp = 0x26,
        PaintingWarp = 0x27,
        InstantWarp = 0x28,
        DefaultPosition = 0x2B,
        AreaCollision = 0x2E,
        ShowDialog = 0x30,
        Tarrain = 0x31,
        x34 = 0x34,
        AreaMusic = 0x36,
        AreaMusicSimple = 0x37,
        Macro3DObject = 0x39,
        x3B = 0x3B
    }
}