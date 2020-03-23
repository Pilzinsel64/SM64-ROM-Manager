using global::Newtonsoft.Json;

namespace SM64Lib.ObjectBanks.Data
{
    public class ObjectBankDataCommand
    {
        public byte[] Command { get; set; }

        [JsonIgnore]
        public byte CommandType
        {
            get
            {
                if (Command is object && Command.Length >= 1)
                {
                    return Command[0];
                }
                else
                {
                    return 0;
                }
            }
        }

        public ObjectBankDataCommand()
        {
            Command = null;
        }

        public ObjectBankDataCommand(byte[] cmd)
        {
            Command = cmd;
        }
    }
}