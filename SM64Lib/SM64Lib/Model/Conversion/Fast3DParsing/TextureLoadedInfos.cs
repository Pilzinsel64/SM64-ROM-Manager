using global::System.Drawing;

namespace SM64Lib.Model.Conversion.Fast3DParsing
{
    public class TextureLoadedInfos
    {
        public string Name { get; private set; }
        public N64Graphics.N64Codec TextureFormat { get; private set; }
        public int TextureSegAddress { get; private set; }
        public int TexturePaletteSegAddress { get; private set; }
        public int TextureRomAddress { get; private set; }
        public int TexturePaletteRomAddress { get; private set; }
        public Size TextureSize { get; private set; }
        public bool IsReadOnly { get; private set; }

        public TextureLoadedInfos(string name, N64Graphics.N64Codec textureFormat, int textureSegAddress, int texturePaletteSegAddress, int textureRomAddress, int texturePaletteRomAddress, Size textureSize) : this(name, textureFormat, textureSegAddress, texturePaletteSegAddress, textureRomAddress, texturePaletteRomAddress, textureSize, false)
        {
        }

        public TextureLoadedInfos(string name, N64Graphics.N64Codec textureFormat, int textureSegAddress, int texturePaletteSegAddress, int textureRomAddress, int texturePaletteRomAddress, Size textureSize, bool isReadOnly)
        {
            Name = name;
            TextureFormat = textureFormat;
            TextureSegAddress = textureSegAddress;
            TexturePaletteSegAddress = texturePaletteSegAddress;
            TextureRomAddress = textureRomAddress;
            TexturePaletteRomAddress = texturePaletteRomAddress;
            TextureSize = textureSize;
            IsReadOnly = isReadOnly;
        }
    }
}