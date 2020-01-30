using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCoolMath
{   
    [TestClass]
    public class CoolMathTest
    {
        [TestMethod]
        public void CircleWhenArgZero()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() => CoolMath.WantArea.GetArea(0));
            Assert.AreEqual("Bad arguments", ex.Message);
        }

        [TestMethod]
        public void CircleWhenArgNegative()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() => CoolMath.WantArea.GetArea(-1));
            Assert.AreEqual("Bad arguments", ex.Message);
        }

        [TestMethod]
        public void TriangleWhenArgsZero()
        {
            Assert.ThrowsException<ArgumentException>(() => CoolMath.WantArea.GetArea(0, 0, 2));
        }

        [TestMethod]
        public void TriangleWhenArgsNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => CoolMath.WantArea.GetArea(-1, 5, -2));
        }

        [TestMethod]
        public void CircleWhenResultTrue()
        {
            Assert.AreEqual(Math.PI, CoolMath.WantArea.GetArea(1), 4);
        }

        [TestMethod]
        public void RectWhenResultTrue()
        {
            Assert.IsFalse(CoolMath.Triangle.IsRect(3, 4, 4));
        }

        [TestMethod]
        public void RectWhenArgsZeroAndNegative()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() => CoolMath.Triangle.IsRect(-1, 0, 5));
            Assert.AreEqual("Bad arguments", ex.Message);
        }
    }
}
