using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicVector.Tests {
    [TestClass]
    public class VectorTest {
        [TestMethod]
        public void Length() {
            Vector v1 = new Vector(3,-4);
            Assert.AreEqual(5, v1.Length);
        }

        [TestMethod]
        public void SquaredLength() {
            Vector v1 = new Vector(-3, -4);
            Assert.AreEqual(25, v1.SquaredLength);
        }

        [TestMethod]
        public void Angle() {
            Vector v1 = new Vector(1,1);
            Assert.AreEqual(45, AngleUtil.ToDegrees(v1.Angle));
        }
    }
}
