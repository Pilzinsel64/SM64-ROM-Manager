
using Newtonsoft.Json;

namespace SM64Lib.Geolayout
{
    public class Geopointer
    {
        public byte Layer { get; set; } = default;
        public int SegPointer { get; set; } = 0;
        public System.Numerics.Vector3 ModelScale { get; set; } = System.Numerics.Vector3.One;
        public System.Numerics.Vector3 ModelOffset { get; set; } = System.Numerics.Vector3.Zero;

        [JsonConstructor]
        private Geopointer()
        {
        }

        public Geopointer(byte Layer) : this()
        {
            this.Layer = Layer;
        }

        public Geopointer(byte Layer, int SegPointer) : this(Layer)
        {
            this.SegPointer = SegPointer;
        }

        public Geopointer(byte Layer, int SegPointer, System.Numerics.Vector3 mdlscale, System.Numerics.Vector3 mdloffset) : this(Layer, SegPointer)
        {
            ModelScale = mdlscale;
            ModelOffset = mdloffset;
        }
    }
}