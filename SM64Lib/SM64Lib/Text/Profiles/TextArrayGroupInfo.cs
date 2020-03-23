using System.Collections.Generic;

namespace SM64Lib.Text.Profiles
{
    public class TextArrayGroupInfo : TextGroupInfo
    {
        public List<TextArrayItemInfo> Texts { get; set; } = new List<TextArrayItemInfo>();
    }
}