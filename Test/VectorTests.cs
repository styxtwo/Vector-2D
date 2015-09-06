using System;
using NUnit.Framework;

namespace BasicVector.Tests {
    [TestFixture]
    public class VectorTest {
        [Test]
        public void Length() {
            Vector v1 = new Vector(3,-4);
            Assert.AreEqual(5, v1.Length);
        }

        [Test]
        public void SquaredLength() {
            Vector v1 = new Vector(-3, -4);
            Assert.AreEqual(25, v1.SquaredLength);
        }

        [Test]
        public void Angle() {
            Vector v1 = new Vector(1,1);
            Assert.AreEqual(45, AngleUtil.ToDegrees(v1.Angle));
        }
    }
}
