
namespace SM64Lib.Model
{
    public class ObjectInputSettings
    {
        public sbyte ForceDisplaylist { get; set; } = -1;
        public double Scaling { get; set; } = 1.0F;
        public ReduceDuplicateVerticesLevel ReduceDupVertLevel { get; set; } = ReduceDuplicateVerticesLevel.Level1;
        public Fog Fog { get; set; } = null;
        public bool ResizeTextures { get; set; } = true;
        public bool CenterModel { get; set; } = false;
        public Pilz.S3DFileParser.Shading Shading { get; private set; } = new Pilz.S3DFileParser.Shading();
        public bool OptimizeTransparencyChecks { get; set; } = false;

        public enum ReduceDuplicateVerticesLevel
        {
            /// <summary>Don't reduce vertices.</summary>
            Level0,
            /// <summary>Reduce only, if in the same 0x4 group.</summary>
            Level1,
            /// <summary>Reduce and push up. [Buggy]</summary>
            Level2
        }
    }
}