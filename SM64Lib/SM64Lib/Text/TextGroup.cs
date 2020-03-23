using System.Collections.Generic;
using global::SM64Lib.Data;
using global::SM64Lib.Text.Profiles;

namespace SM64Lib.Text
{
    public abstract class TextGroup : List<TextItem>
    {
        public bool NeedToSave { get; set; } = false;
        public TextGroupInfo TextGroupInfo { get; private set; }

        public int DataLength
        {
            get
            {
                int count = 0;
                foreach (TextItem item in this)
                    count += item.Data.Length;
                return count;
            }
        }

        public TextGroup(TextGroupInfo groupInfo)
        {
            TextGroupInfo = groupInfo;
        }

        public abstract void Read(BinaryData data);
        public abstract void Save(BinaryData data);
    }
}