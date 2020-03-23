using global::SM64Lib.Script;

namespace SM64Lib.Geolayout.Script
{
    public class GeolayoutCommandCollection : BaseCommandCollection<GeolayoutCommand, GeolayoutCommandTypes>
    {
        public int IndexOfFirst(GeolayoutCommandTypes cmdType)
        {
            for (int index = 0, loopTo = Count - 1; index <= loopTo; index++)
            {
                if (this[index].CommandType == cmdType)
                    return index;
            }

            return -1;
        }
    }
}