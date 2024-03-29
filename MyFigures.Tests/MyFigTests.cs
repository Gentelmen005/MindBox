using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyFigures.Tests
{
    [TestClass]
    public class MyFigTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.AreEqual(Math.PI * Math.Pow(5, 2), circle.GetArea(), 0.0001);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var p = (3 + 4 + 5) / 2;
            Assert.AreEqual(Math.Sqrt(p * (p - 3) * (p - 4) * (p - 5)), triangle.GetArea(), 0.0001);
        }

        [TestMethod]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}
