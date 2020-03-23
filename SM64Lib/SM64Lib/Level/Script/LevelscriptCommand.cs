using System;
using global::SM64Lib.Script;

namespace SM64Lib.Levels.Script
{
    [Serializable]
    public class LevelscriptCommand : BaseCommand<LevelscriptCommandTypes>
    {
        public LevelscriptCommand(byte[] bytes) : base(bytes)
        {
        }

        public LevelscriptCommand() : base()
        {
        }

        public LevelscriptCommand(string bytes, bool enabledHex = true) : base(bytes, enabledHex)
        {
        }

        public override LevelscriptCommandTypes CommandType
        {
            get
            {
                Position = 0;
                LevelscriptCommandTypes t = (LevelscriptCommandTypes)ReadByte();
                Position = 0;
                return t;
            }

            set
            {
                Position = 0;
                WriteByte((byte)value);
                Position = 0;
            }
        }
    }
}