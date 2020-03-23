
namespace SM64Lib.Script
{
    public interface ICommand
    {
        int RomAddress { get; set; }
        int BankAddress { get; set; }
        bool IsDirty { get; }
    }
}