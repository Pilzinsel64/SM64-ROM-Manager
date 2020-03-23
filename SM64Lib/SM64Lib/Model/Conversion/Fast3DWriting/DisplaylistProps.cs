using global::SM64Lib.Geolayout;

namespace SM64Lib.Model.Conversion.Fast3DWriting
{
    public class DisplaylistProps
    {
        public int ID { get; set; }
        public DefaultGeolayers Layer { get; set; } = DefaultGeolayers.Solid;

        public DisplaylistProps(int ID)
        {
            this.ID = ID;
        }
    }
}