using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Behaviors.Script
{
    public static class BehaviorscriptCommandFactory
    {
        public static BehaviorscriptCommand Build_x2A(int collisionPointer = -1)
        {
            var cmd = new BehaviorscriptCommand("2a 00 00 00 00 00 00 00");
            if (collisionPointer != -1)
                BehaviorscriptCommandFunctions.X2A.SetCollisionPointer(cmd, collisionPointer);
            return cmd;
        }

        public static BehaviorscriptCommand Build_x08()
        {
            return new BehaviorscriptCommand("08 00 00 00");
        }

        public static BehaviorscriptCommand Build_x0C(int asmPointer = -1)
        {
            var cmd = new BehaviorscriptCommand("0C 00 00 00 00 00 00 00");
            if (asmPointer != -1)
                BehaviorscriptCommandFunctions.X2A.SetCollisionPointer(cmd, asmPointer);
            return cmd;
        }
    }
}
