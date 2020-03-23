using global::SM64Lib.Text.Profiles;

namespace SM64Lib.Text
{
    public abstract class TextItem
    {
        public byte[] Data { get; private set; }
        public TextGroupInfo TextGroupInfo { get; private set; }

        public string Text
        {
            get
            {
                return TextGroupInfo.Encoding.GetString(Data);
            }

            set
            {
                Data = TextGroupInfo.Encoding.GetBytes(value);
            }
        }

        public TextItem(byte[] bytes, TextGroupInfo groupInfo)
        {
            TextGroupInfo = groupInfo;
            Data = bytes;
        }
    }
}