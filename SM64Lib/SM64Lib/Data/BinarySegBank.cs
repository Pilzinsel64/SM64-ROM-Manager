using global::System.IO;
using global::SM64Lib.SegmentedBanking;

namespace SM64Lib.Data
{
    public class BinarySegBank : BinaryData
    {
        public SegmentedBank SegBank { get; private set; }

        public BinarySegBank(SegmentedBank segBank, RomManager rommgr)
        {
            SegBank = segBank;
            SetRomManager(rommgr);
        }

        public BinarySegBank(SegmentedBank segBank)
        {
            SegBank = segBank;
        }

        protected override Stream GetBaseStream()
        {
            if (RomManager is object)
            {
                var s = RomManager.GetBinaryRom(FileAccess.Read);
                SegBank.ReadDataIfNull(s.BaseStream);
                s.Close();
            }

            return SegBank.Data;
        }
    }
}