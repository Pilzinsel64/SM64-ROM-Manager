using System.Collections.Generic;

namespace SM64Lib.Objects.ObjectBanks.Data
{
    public class ObjectBankData
    {
        public string Name { get; set; }
        public List<string> Objects { get; private set; } = new List<string>();
        public List<ObjectBankDataCommand> Commands { get; private set; } = new List<ObjectBankDataCommand>();

        public ObjectBankData()
        {
        }

        public ObjectBankData(string name)
        {
            Name = name;
        }
    }
}