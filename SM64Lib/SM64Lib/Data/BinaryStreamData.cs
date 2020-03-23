using global::System.IO;

namespace SM64Lib.Data
{
    public class BinaryStreamData : BinaryData
    {
        protected readonly Stream myBaseStream;

        public BinaryStreamData(Stream stream)
        {
            myBaseStream = stream;
        }

        protected override Stream GetBaseStream()
        {
            return myBaseStream;
        }
    }
}