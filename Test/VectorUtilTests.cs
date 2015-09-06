using NUnit.Framework;
using System;
namespace BasicVector.Tests {
    [TestFixture]
    public class VectorUtilTests {

        [Test]
        public void Dot() {
            Vector v1 = new Vector(2, 6);
            Vector v2 = new Vector(3, -5);
            double dot = VectorUtil.Dot(v1, v2);
            Assert.AreEqual(-24, dot);
        }

        [Test]
        public void Cross() {
            Vector v1 = new Vector(2, 6);
            Vector v2 = new Vector(3, -5);
            double cross = VectorUtil.Cross(v1, v2);
            Assert.AreEqual(-28, cross);
        }

        [Test]
        public void Angle() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = new Vector(1, -1);
            double angle = VectorUtil.Angle(v1, v2);
            Assert.AreEqual(135, AngleUtil.ToDegrees(angle));
        }

        [Test]
        public void SingleAngle() {
            Vector v1 = new Vector(0, 1);
            double angle = VectorUtil.Angle(v1);
            Assert.AreEqual(90, AngleUtil.ToDegrees(angle));
        }

        [Test]
        public void Normalize() {
            Vector v1 = new Vector(908, 3);
            Vector v2 = VectorUtil.Normalize(v1);
            Assert.AreEqual(1, v2.Length);

            //fraction
            Vector v3 = new Vector(0.1, 0);
            Vector v4 = VectorUtil.Normalize(v3);
            Assert.AreEqual(1, v4.Length);

            //normalizing zero vector returns zero vector.
            Vector v5 = new Vector(0, 0);
            Vector v6 = VectorUtil.Normalize(v5);
            Assert.AreEqual(0, v6.Length);
        }

        [Test]
        public void SetLength() {
            Vector v1 = new Vector(0, 3);
            Vector v2 = VectorUtil.SetLength(v1,5);
            Assert.AreEqual(new Vector(0, 5), v2);
            Assert.AreEqual(5, v2.Length);
        }

        [Test]
        public void Rotate() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = VectorUtil.Rotate(v1, Math.PI);
            Vector v3 = VectorUtil.Rotate(v1, Math.PI / 2);
            Assert.AreEqual(-1, v2.Y);
            Assert.AreEqual(-1, v3.X);
        }

        [Test]
        public void RotateTo() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = VectorUtil.RotateTo(v1, 0);
            Vector v3 = VectorUtil.RotateTo(v2, Math.PI / 2);
            Assert.AreEqual(0, v2.Y);
            Assert.AreEqual(1, v2.Length);
            Assert.AreEqual(1, v3.Length);
        }

        [Test]
        public void TurnLeft() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = VectorUtil.TurnLeft(v1);
            Assert.AreEqual(new Vector(-1, 0), v2);
        }

        [Test]
        public void TurnRight() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = VectorUtil.TurnRight(v1);
            Assert.AreEqual(new Vector(1, 0), v2);
        }

        [Test]
        public void Distance() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = new Vector(0, 2);
            double distance = VectorUtil.Distance(v1, v2);
            Assert.AreEqual(1, distance);
        }

        [Test]
        public void SquaredDistance() {
            Vector v1 = new Vector(0, 1);
            Vector v2 = new Vector(0, 3);
            double distance = VectorUtil.SquaredDistance(v1, v2);
            Assert.AreEqual(4, distance);
        }

        [Test]
        public void Lerp() {
            Vector v1 = new Vector(1, 1);
            Vector v2 = new Vector(3, 3);
            Vector v3 = VectorUtil.Lerp(v1, v2, 0.5);
            Assert.AreEqual(new Vector(2, 2), v3);
        }

        [Test]
        public void Reflect() {
            Vector v1 = new Vector(3, 3);
            Vector v2 = new Vector(0, 1);
            Vector v3 = VectorUtil.Reflect(v1, v2);
            Assert.AreEqual(new Vector(-3, 3), v3);
        }

        [Test]
        public void ClampLength() {
            //too long
            Vector v1 = new Vector(0, 6);
            Vector v2 = VectorUtil.ClampLength(v1, 1, 5);
            Assert.AreEqual(new Vector(0, 5), v2);

            //too short
            Vector v3 = new Vector(0, 0.5);
            Vector v4 = VectorUtil.ClampLength(v3, 1, 5);
            Assert.AreEqual(new Vector(0, 1), v4);

            //just right
            Vector v5 = new Vector(0, 4);
            Vector v6 = VectorUtil.ClampLength(v5, 1, 5);
            Assert.AreEqual(new Vector(0, 4), v6);
        }

        [Test]
        public void CreateVector() {
            Vector v = VectorUtil.CreateVector(8, Math.PI*3/4);
            Assert.AreEqual(8, v.Length);
            Assert.AreEqual(Math.PI * 3 / 4, v.Angle);
        }

        [Test]
        public void InsideRectangle() {
            bool inside = VectorUtil.InsideRectangle(new Vector(1, 2), new Vector(-1, 3), new Vector(4, 0));
            Assert.AreEqual(true, inside);

            bool outside = VectorUtil.InsideRectangle(new Vector(1, 2), new Vector(2, 3), new Vector(4, 0));
            Assert.AreEqual(false, outside);

            bool onEdge = VectorUtil.InsideRectangle(new Vector(1, 2), new Vector(1, 3), new Vector(4, 0));
            Assert.AreEqual(false, onEdge);
        }
    }
}
