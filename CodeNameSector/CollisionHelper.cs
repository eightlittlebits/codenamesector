using CodeNameSector;

namespace CodeNameSectorTests
{
    public static class CollisionHelper
    {
        public static bool IsPointOnLine(Vector2 point, Vector2 startLocation, Vector2 endLocation)
        {
            /*
             * http://paulbourke.net/geometry/pointline/
             * http://funplosion.com/devblog/collision-detection-line-vs-point-circle-and-rectangle.html
             * http://objectmix.com/asm-x86-asm-370/69777-point-line-segment-2d-code-faster-can-you-improve.html
             * http://stackoverflow.com/questions/907390/how-can-i-tell-if-a-point-belongs-to-a-certain-line
             * 
             * The best way to determine if a point R = (rx, ry) lies on the line connecting points 
             * P = (px, py) and Q = (qx, qy) is to check whether the determinant of the matrix
             *                         
             * {{qx - px, qy - py}, {rx - px, ry - py}},
             *             
             * namely (qx - px) * (ry - py) - (qy - py) * (rx - px) is close to 0. This solution has
             * several related advantages over the others posted: first, it requires no special case
             * for vertical lines, second, it doesn't divide (usually a slow operation), third, it 
             * doesn't trigger bad floating-point behavior when the line is almost, but not quite vertical.
             * 
             * The determinant of a 2x2 matrix is defined by
             * 
             * | a b |
             * | c d | = ad - bc
             * 
             */

            return ((endLocation.X - startLocation.X) * (point.Y - startLocation.Y) - (endLocation.Y - startLocation.Y) * (point.X - startLocation.X)) == 0;
        }
    }
}