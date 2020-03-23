using global::System.IO;

namespace SM64Lib.Data
{
    public class BinaryFile : BinaryStreamData
    {
        public BinaryFile(string filePath, FileMode fileMode, FileAccess fileAccess) : base(new FileStream(filePath, fileMode, fileAccess))
        {
        }
    }
}