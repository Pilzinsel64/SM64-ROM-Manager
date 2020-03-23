using global::System.IO;

namespace SM64Lib.Data
{
    public class BinaryArrayData : BinaryStreamData
    {
        public FileAccess RomAccess { get; private set; } = FileAccess.Read;

        public BinaryArrayData(byte[] buffer) : base(new MemoryStream(buffer))
        {
        }

        // Inherits BinaryData

        // Private ReadOnly myBaseStream As Stream

        // Public ReadOnly Property RomAccess As FileAccess = FileAccess.Read

        // Public Sub New(buffer As Byte())
        // myBaseStream = New MemoryStream(buffer)
        // End Sub

        // Protected Overrides Function GetBaseStream() As Stream
        // Return myBaseStream
        // End Function

    }
}