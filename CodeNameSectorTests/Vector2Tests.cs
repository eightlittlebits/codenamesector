using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeNameSector;
using NUnit.Framework;

namespace CodeNameSectorTests
{
    [TestFixture]
    public class Vector2Tests
    {
        [Test]
        public void Vector2_AddingTwoVectors_ReturnsCorrectValue()
        {
            Vector2 v1 = new Vector2(2, 2);
            Vector2 v2 = new Vector2(3, 3);

            Vector2 result = v1 + v2;

            Vector2 expected = new Vector2(5, 5);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Vector2_SubtractingTwoVectors_ReturnsCorrectValue()
        {
            Vector2 v1 = new Vector2(5, 5);
            Vector2 v2 = new Vector2(3, 2);

            Vector2 result = v1 - v2;

            Vector2 expected = new Vector2(2, 3);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Vector2_MultiplyingAVectorWithAScalar_ReturnsCorrectValue()
        {
            Vector2 v1 = new Vector2(1, -1);
            const int scalar = 9;

            Vector2 result = v1 * scalar;

            Vector2 expected = new Vector2(9, -9);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Vector2_ChebyshevDistance_ReturnsCorrectValue()
        {
            Vector2 v1 = new Vector2(5, 5);
            Vector2 v2 = new Vector2(11, 7);

            int result = Vector2.ChebyshevDistance(v1, v2);

            const int expected = 6;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
