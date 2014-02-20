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
            
            Vector2 point = new Vector2(3, 2);

            Vector2 startLocation = new Vector2(0, 0);
            Vector2 endLocation = new Vector2(5, 5);

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

            Vector2 point = new Vector2(2, 2);

            Vector2 startLocation = new Vector2(0, 0);
            Vector2 endLocation = new Vector2(5, 5);

            bool result = CollisionHelper.IsPointOnLine(point, startLocation, endLocation);

            const bool expected = true;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
