using global::System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.S3DFileParser;

namespace SM64_ROM_Manager.LevelEditor
{
    public class ManagedColFace
    {
        [Browsable(false)]
        public readonly Face Face;

        public ManagedColFace(Face face)
        {
            Face = face;
        }

        [Category("")]
        [DisplayName("Collision Type")]
        public byte CollisionType
        {
            get
            {
                return Conversions.ToByte(Face.Tag);
            }

            set
            {
                Face.Tag = value;
            }
        }
    }
}