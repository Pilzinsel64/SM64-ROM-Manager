using global::SM64Lib.Text.Profiles;

namespace SM64Lib.Text
{
    public class TextArrayItem : TextItem
    {
        public TextArrayItemInfo ItemInfo { get; private set; }

        public new TextArrayGroupInfo TextGroupInfo
        {
            get
            {
                return (TextArrayGroupInfo)base.TextGroupInfo;
            }
        }

        public TextArrayItem(byte[] bytes, TextArrayGroupInfo groupInfo, TextArrayItemInfo info) : base(bytes, groupInfo)
        {
            ItemInfo = info;

            // Remove empty chars at the end of ascii text
            if (groupInfo.Encoding == System.Text.Encoding.ASCII)
            {
                Text = Text.TrimEnd();
            }
        }
    }
}