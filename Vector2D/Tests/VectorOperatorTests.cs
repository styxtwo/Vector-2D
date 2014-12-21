using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vector2D.Tests {
    [TestClass]
    public class VectorOperatorTests {

        [TestMethod]
        public void Equals() {
            Vector v1 = new Vector(10, 10);
            Vector v2 = new Vector(10, 10);
            Vector v3 = null;
            Assert.AreEqual(v1, v2);
            Assert.AreNotEqual(v3, v2);
            Assert.AreNotEqual(v1, v3);
            Assert.AreEqual(v3, v3);
        }
        [TestMethod]
        public void Addition() {
            Vector v1 = new Vector(10, 10);
            Vector v2 = new Vector(5, -5);
            Vector v3 = v1 + v2;
            Assert.AreEqual(new Vector(15, 5), v3);
        }

        [TestMethod]
        public void Subtraction() {
            Vector v1 = new Vector(10, 10);
            Vector v2 = new Vector(5, -5);
            Vector v3 = v1 - v2;
            Assert.AreEqual(new Vector(5, 15), v3);
        }

        [TestMethod]
        public void VectorMultiplication() {
            Vector v1 = new Vector(2, 6);
            Vector v2 = new Vector(3, -5);
            Vector v3 = v1 * v2;
            Assert.AreEqual(new Vector(6, -30), v3);
        }

        [TestMethod]
        public void FloatMultiplication() {
            Vector v1 = new Vector(2, 6);
            float f1 = 10;
            Vector v3 = v1 * f1;
            Vector v4 = f1 * v1;
            Assert.AreEqual(new Vector(20, 60), v3);
            Assert.AreEqual(new Vector(20, 60), v4);
        }

        [TestMethod]
        public void VectorDivision() {
            Vector v1 = new Vector(30, 25);
            Vector v2 = new Vector(3, -5);
            Vector v3 = v1 / v2;
            Assert.AreEqual(new Vector(10, -5), v3);
        }

        [TestMethod]
        public void FloatDivision() {
            Vector v1 = new Vector(200, 600);
            float f1 = 10;
            Vector v3 = v1 / f1;
            Vector v4 = f1 / v1;
            Assert.AreEqual(new Vector(20, 60), v3);
            Assert.AreEqual(new Vector(20, 60), v4);
        }
    }
}
