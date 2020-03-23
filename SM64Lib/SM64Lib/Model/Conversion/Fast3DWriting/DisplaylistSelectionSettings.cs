using global::SM64Lib.Geolayout;

namespace SM64Lib.Model.Conversion.Fast3DWriting
{
    public class DisplaylistSelectionSettings
    {
        public DisplaylistSelectionMode SelectionMode { get; set; } = DisplaylistSelectionMode.Automatic;
        public DefaultGeolayers DefaultGeolayer { get; set; } = DefaultGeolayers.Solid;
        public int CustomDisplaylistID { get; set; } = 0;
    }
}