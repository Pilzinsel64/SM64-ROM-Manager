using System;

namespace SM64_ROM_Manager.EventArguments
{
    public class RequestValueEventArgs<TValue> : EventArgs
    {
        public TValue Value { get; set; }

        public RequestValueEventArgs() : base()
        {
        }

        public RequestValueEventArgs(TValue value) : this()
        {
            Value = value;
        }
    }
}