using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeNameSector
{
    public static class Direction
    {
        public static Vector2 N     = new Vector2( 0,  1);
        public static Vector2 NE    = new Vector2( 1,  1);
        public static Vector2 E     = new Vector2( 1,  0);
        public static Vector2 SE    = new Vector2( 1, -1);
        public static Vector2 S     = new Vector2( 0, -1);
        public static Vector2 SW    = new Vector2(-1, -1);
        public static Vector2 W     = new Vector2(-1,  0);
        public static Vector2 NW    = new Vector2(-1,  1);

        public static Vector2 GetDirection(int direction)
        {
            if (direction < 0 || direction > 7)
            {
                throw new ArgumentOutOfRangeException("direction", direction, "direction must be between 0 and 7 inclusive");
            }

            switch (direction)
            {
                case 0:
                    return N;

                case 1:
                    return NE;

                case 2:
                    return E;

                case 3:
                    return SE;

                case 4:
                    return S;

                case 5:
                    return SW;

                case 6:
                    return W;

                case 7:
                    return NW;

                default:
                    throw new ArgumentOutOfRangeException("direction", direction, "direction must be between 0 and 7 inclusive");
            }
        }
    }
}
