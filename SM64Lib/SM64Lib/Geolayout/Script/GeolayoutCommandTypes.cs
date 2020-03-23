
namespace SM64Lib.Geolayout.Script
{
    public enum GeolayoutCommandTypes
    {
        BranchAndStore = 0x0,
        EndOfGeolayout = 0x1,
        JumpToSegAddr = 0x2,
        JumpBack = 0x3,
        StartOfNode = 0x4,
        EndOfNode = 0x5,
        SetScreenRenderArea = 0x8,
        Scale1 = 0x9,
        x0A = 0xA,
        x0B = 0xB,
        x0C = 0xC,
        x0D = 0xD,
        x0E = 0xE,
        CameraPreset = 0xF,
        x10 = 0x10,
        x11 = 0x11,
        LoadDisplaylistWithOffset = 0x13,
        BillboardModel = 0x14,
        LoadDisplaylist = 0x15,
        ObjectShadown = 0x16,
        x17 = 0x17,
        x18 = 0x18,
        Background = 0x19,
        x1A = 0x1A,
        x1C = 0x1C,
        Scale2 = 0x1D,
        x1E = 0xE,
        x1f = 0xF,
        DrawingDistance = 0x20
    }
}