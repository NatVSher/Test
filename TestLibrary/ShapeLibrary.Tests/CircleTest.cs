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

            Assert.AreEqual(10.24 * Math.PI, result);
        }
        [TestMethod]
        public void NotExistCircle()
        {
            try
            {
                var circle = new Circle(0);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Длина радиуса не может быть отрицательной или равной 0.", e.Message);
            }
        }
    }
}
