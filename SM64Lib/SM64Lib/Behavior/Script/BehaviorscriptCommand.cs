
namespace SM64Lib.Behavior.Script
{
    public class BehaviorscriptCommand : SM64Lib.Script.BaseCommand<byte>
    {
        public override byte CommandType
        {
            get
            {
                Position = 0;
                return ReadByte();
            }

            set
            {
                Position = 0;
                WriteByte(value);
            }
        }
    }
}