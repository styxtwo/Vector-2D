using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Vector2D.Tests {

    [TestClass]
    public class VectorUtilTests {

        [TestMethod]
        public void Dot() {
            Vector v1 = new Vector(2, 6);
            Vector v2 = new Vector(3, -5);
            double dot = VectorUtil.Dot(v1, v2);
            Assert.AreEqual(-24, dot);
        }

        [TestMethod]
        public void Cross() {
            Vector v1 = new Vector(2, 6);
            Vector v2 = new Vector(3, -5);
            double cross = VectorUtil.Cross(v1, v2);
            Assert.AreEqual(-28, cross);
        }

        [TestMethod]
        public void Angle() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = new Vector(1, -1);
            double angle = VectorUtil.Angle(v1, v2);
            Assert.AreEqual(135, AngleUtil.ToDegrees(angle));
        }

        [TestMethod]
        public void Normalise() {
            Vector v1 = new Vector(908, 3);
            Vector v2 = VectorUtil.Normalise(v1);
            Assert.AreEqual(1, v2.Length());
        }

        [TestMethod]
        public void Rotate() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = VectorUtil.Rotate(v1, Math.PI);
            Vector v3 = VectorUtil.Rotate(v1, Math.PI / 2);
            Assert.AreEqual(-1, v2.Y);
            Assert.AreEqual(-1, v3.X);
        }

        [TestMethod]
        public void TurnLeft() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = VectorUtil.TurnLeft(v1);
            Assert.AreEqual(new Vector(-1, 0), v2);
        }

        [TestMethod]
        public void TurnRight() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = VectorUtil.TurnRight(v1);
            Assert.AreEqual(new Vector(1, 0), v2);
        }

        [TestMethod]
        public void Distance() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = new Vector(0, 2);
            double distance = VectorUtil.Distance(v1, v2);
            Assert.AreEqual(1, distance);
        }

        [TestMethod]
        public void Lerp() {
            Vector v1 = new Vector(1, 1);
            Vector v2 = new Vector(3, 3);
            Vector v3 = VectorUtil.Lerp(v1, v2, 0.5);
            Assert.AreEqual(new Vector(2, 2), v3);
        }
    }
}
