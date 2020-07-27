using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Geolayout
{
    public enum ObjectShadowType
    {
        Circle_9Verts = 0,
        Circle_4Verts = 1,
        Circle_4Verts_Flat_Unused = 2,
        SquarePermanent = 10,
        SquareScaleable = 11,
        SquareTooglable = 12,
        /**
         * This defines an offset after which rectangular shadows with custom
         * widths and heights can be defined.
         */
        RectangleHardcodedOffset = 50,
        CirclePlayer = 99
    }
}
