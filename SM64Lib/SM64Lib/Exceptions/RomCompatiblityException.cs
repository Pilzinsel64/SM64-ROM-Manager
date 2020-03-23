using System;

namespace SM64Lib.Exceptions
{
    public class RomCompatiblityException : Exception
    {
        public RomCompatiblityException(string msg) : base(msg)
        {
        }
    }
}