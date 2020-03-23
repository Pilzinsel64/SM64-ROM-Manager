using global::System.IO;

namespace SM64Lib.Data
{
    public class BinaryRom : BinaryFile
    {
        public BinaryRom(RomManager rommgr, FileAccess romAccess) : base(rommgr.RomFile, FileMode.Open, romAccess)
        {
            SetRomManager(rommgr);
        }

        // Inherits BinaryData

        // Public ReadOnly Property RomAccess As FileAccess = FileAccess.Read

        // Public Sub New(rommgr As RomManager, romAccess As FileAccess)
        // SetRomManager(rommgr)
        // Me.RomAccess = romAccess
        // End Sub

        // Protected Overrides Function GetBaseStream() As Stream
        // Return RomManager.GetStream(RomAccess)
        // End Function

    }
}