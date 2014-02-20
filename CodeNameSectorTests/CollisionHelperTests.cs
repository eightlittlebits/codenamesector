using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeNameSector;
using NUnit.Framework;

namespace CodeNameSectorTests
{
    [TestFixture]
    public class CollisionHelperTests
    {
        [Test]
        public void CollisionHelper_WhenPointNotOnLine_ReturnsFalse()
        {
            // S = Start, E = End, P = Point

            // ....E
            // .../.
            // ../P.
            // ./...
            // S....
            
            Vector2 point = new Vector2(38, 37);

            Vector2 startLocation = new Vector2(35, 35);
            Vector2 endLocation = new Vector2(40, 40);

            bool result = CollisionHelper.IsPointOnLine(point, startLocation, endLocation);

            const bool expected = false;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CollisionHelper_WhenPointOnLine_ReturnsTrue()
        {
            // S = Start, E = End, P = Point

            // ....E
            // .../.
            // ..P..
            // ./...
            // S....

            Vector2 point = new Vector2(37, 37);

            Vector2 startLocation = new Vector2(35, 35);
            Vector2 endLocation = new Vector2(40, 40);

            bool result = CollisionHelper.IsPointOnLine(point, startLocation, endLocation);

            const bool expected = true;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
