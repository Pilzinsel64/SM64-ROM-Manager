using global::SM64Lib.Script;

namespace SM64Lib.Levels.Script
{
    public class LevelscriptCommandCollection : BaseCommandCollection<LevelscriptCommand, LevelscriptCommandTypes>
    {
        public int IndexOfFirst(LevelscriptCommandTypes cmdType)
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