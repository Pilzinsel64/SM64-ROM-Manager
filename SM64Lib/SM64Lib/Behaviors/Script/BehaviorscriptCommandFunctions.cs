using SM64Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Behaviors.Script
{
    public class BehaviorscriptCommandFunctions
    {
        public class X2A
        {
            public static int GetCollisionPointer(BehaviorscriptCommand cmd)
            {
                cmd.Position = 4;
                return cmd.ReadInt32();
            }
            public static void SetCollisionPointer(BehaviorscriptCommand cmd, int pointer)
            {
                cmd.Position = 4;
                cmd.Write(pointer);
            }
        }
        public class X0C
        {
            public static int GetAsmPointer(BehaviorscriptCommand cmd)
            {
                cmd.Position = 4;
                return cmd.ReadInt32();
            }
            public static void SetAsmPointer(BehaviorscriptCommand cmd, int pointer)
            {
                cmd.Position = 4;
                cmd.Write(pointer);
            }
        }
    }
}
