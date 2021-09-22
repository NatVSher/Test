using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapeLibrary.Tests
{
    [TestClass]
    public class TriangleTest
    {       
        [TestMethod]
        public void SquareTriangle()
        {
            var a = 5;
            var b = 4;
            var c = 5;
            var triangle = new Triangle(a, b, c);

            var result = triangle.Square();

            Assert.AreEqual(9.165, result, 0.001);
        }
        [TestMethod]
        public void NotExistTriangle()
        {
            var a = 5;
            var b = 1;
            var c = 1;

            void action() => new Triangle(a, b, c);

            Assert.ThrowsException<ArgumentException>(action);
        }
        [TestMethod]
        public void NotExistSide()
        {
            var a = -5;
            var b = 1;
            var c = 0;

            void action() => new Triangle(a, b, c);

            Assert.ThrowsException<ArgumentException>(action);
        }
        [TestMethod]
        public void IsRightTriangle()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var triangle = new Triangle(a, b, c);

            var result = triangle.IsRightTriangle();

            Assert.AreEqual(true, result);
        }
    }
}
