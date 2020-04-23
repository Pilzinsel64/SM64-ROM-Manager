
namespace SM64Lib.Behaviors.Script
{
    public class BehaviorscriptCommandCollection : SM64Lib.Script.BaseCommandCollection<BehaviorscriptCommand, BehaviorscriptCommandTypes>
    {
        public long Length
        {
            get
            {
                var length = 0L;

                foreach (var cmd in this)
                    length += cmd.Length;

                return length;
            }
        }
    }
}