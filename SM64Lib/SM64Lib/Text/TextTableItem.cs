using global::SM64Lib.Text.Profiles;

namespace SM64Lib.Text
{
    public class TextTableItem : TextItem
    {
        public new TextTableGroupInfo TextGroupInfo
        {
            get
            {
                return (TextTableGroupInfo)base.TextGroupInfo;
            }
        }

        public TextTableItem(byte[] bytes, TextTableGroupInfo info) : base(bytes, info)
        {
        }
    }
}