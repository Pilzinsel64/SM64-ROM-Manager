using System;

namespace SM64_ROM_Manager.EventArguments
{
    public class TextItemEventArgs : EventArgs
    {
        public string TableName { get; private set; }
        public int ItemIndex { get; private set; }

        public TextItemEventArgs(string tableName, int itemIndex)
        {
            TableName = tableName;
            ItemIndex = itemIndex;
        }
    }
}