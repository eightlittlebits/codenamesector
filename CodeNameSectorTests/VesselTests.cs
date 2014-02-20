using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeNameSector;
using NUnit.Framework;

namespace CodeNameSectorTests
{
    [TestFixture]
    public class VesselTests
    {
        [Test]
        public void Vessel_ProjectedMove_MovesCorrectDistanceAndDirection()
        {
            Vector2 position = new Vector2(35, 25); // 35N, 25E
            Vector2 bearing = new Vector2(1, 1);    // NE
            const int speed = 4;
            
            Vessel v = new Vessel(position, bearing, speed);

            Vector2 result = v.ProjectedMove();

            Vector2 expectedPosition = new Vector2(39, 29);

            Assert.That(result, Is.EqualTo(expectedPosition));
        }
    }
}
