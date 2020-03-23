using global::System.ComponentModel;

namespace SM64Lib.Objects
{
    public class ItemBoxContentEntry
    {
        [DisplayName("Content ID")]
        public byte ID { get; set; }
        [DisplayName("Model ID")]
        public byte ModelID { get; set; }
        [DisplayName("Behavior Param 1")]
        public byte BParam1 { get; set; }
        [DisplayName("Behavior Param 2")]
        public byte BParam2 { get; set; }
        [DisplayName("Behavior Address")]
        public uint BehavAddress { get; set; }
    }
}