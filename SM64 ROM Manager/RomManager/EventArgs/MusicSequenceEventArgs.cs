using System;
using global::SM64Lib.Music;

namespace SM64_ROM_Manager.EventArguments
{
    public class MusicSequenceEventArgs : EventArgs
    {
        public int Index { get; private set; }
        public MusicSequence Sequence { get; private set; }

        public MusicSequenceEventArgs(int index, MusicSequence sequence)
        {
            Index = index;
            Sequence = sequence;
        }
    }
}