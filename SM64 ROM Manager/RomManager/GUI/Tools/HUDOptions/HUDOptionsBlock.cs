
namespace SM64_ROM_Manager
{
    public class HUDOptionsBlock
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public HUDOptionsCords Cords { get; set; }
        public HUDOptionsBlock[] Childs { get; set; }
    }
}