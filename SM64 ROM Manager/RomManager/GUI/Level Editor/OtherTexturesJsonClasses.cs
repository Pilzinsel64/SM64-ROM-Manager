
namespace SM64_ROM_Manager.LevelEditor
{
    public class TextureInfosJsonClass
    {
        public string Name { get; set; }
        public string FromSegmentAddress { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Format { get; set; }
        public string LoadLvlscript { get; set; }
    }

    public class TextureBlocksJsonClass
    {
        public string Name { get; set; }
        public TextureInfosJsonClass[] Textures { get; set; }
    }
}