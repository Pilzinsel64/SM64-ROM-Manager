
namespace SM64Lib.Behavior.Script
{
    public enum BehaviorscriptCommandTypes
    {
        StartBehavior = 0,
        JumpAndLinkToAddress = 2,
        ReturnBackFromJumpAndLink = 3,
        JumpToAddress = 4,
        LoopXTimes = 5,
        x6 = 6,
        InfiniteLoop = 7,
        StartLoop = 8,
        EndLoop = 9,
        EndBehaviorScript1 = 0xA,
        EndBehaviorScript2 = 0xB,
        CallAsmFunction = 0xC
    }
}