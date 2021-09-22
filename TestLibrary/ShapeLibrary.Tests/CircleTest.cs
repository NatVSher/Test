using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapeLibrary.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void SquareExistCircle()
        {
            var circle = new Circle(3.2);

            var result = circle.Square();

            Assert.AreEqual(10.24 * Math.PI, result, 0.001);
        }
        [TestMethod]
        public void NotExistCircle()
        {
            var r = 0;

            void action() => new Circle(r);

            Assert.ThrowsException<ArgumentException>(action);
        }
    }
}
