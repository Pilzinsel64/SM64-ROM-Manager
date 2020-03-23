
namespace SM64Lib.Model.Fast3D.DisplayLists.Script
{
    public enum CommandTypes
    {
        NOOP = 0x0,
        Movemem = 0x3,
        DisplayList = 0x6,
        EndDisplaylist = 0xB8,
        Vertex = 0x4,
        SetOtherMode_H = 0xBA,
        Triangle1 = 0xBF,
        ClearGeometryMode = 0xB6,
        SetGeometryMode = 0xB7,
        Loadtlut = 0xF0,
        SetTileSize = 0xF2,
        SetImage = 0xFD,
        Loadback = 0xF3,
        SetTile = 0xF5,
        Texture = 0xBB
    }
}