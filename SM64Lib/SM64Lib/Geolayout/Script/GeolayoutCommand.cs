using global::SM64Lib.Script;

namespace SM64Lib.Geolayout.Script
{
    public class GeolayoutCommand : BaseCommand<GeolayoutCommandTypes>
    {
        public GeolayoutCommand(byte[] bytes) : base(bytes)
        {
        }

        public GeolayoutCommand() : base()
        {
        }

        public GeolayoutCommand(string bytes, bool enabledHex = true) : base(bytes, enabledHex)
        {
        }

        public override GeolayoutCommandTypes CommandType
        {
            get
            {
                Position = 0;
                GeolayoutCommandTypes t = (GeolayoutCommandTypes)ReadByte();
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