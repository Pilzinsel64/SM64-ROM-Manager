
namespace SM64_ROM_Manager.Extensions
{
    public static class Int16Extensions
    {
        public static bool IsInRange(this short value, short min, short max)
        {
            return value >= min && value <= max;
        }
    }
}