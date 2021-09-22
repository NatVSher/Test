using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapeLibrary.Tests
{
    [TestClass]
    public class TriangleTest
    {       
        [TestMethod]
        public void SquareRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            var result = triangle.Square();

            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void NotExistTriangle()
        {
            try
            {
                var triangle = new Triangle(3, 4, 3);
            }
            catch (Exception e)
            {
                Assert.AreEqual("������ ����� ������ �� �������� �����������", e.Message);
            }
        }
        [TestMethod]
        public void NotExistSide()
        {
            try
            {
                var triangle = new Triangle(3, 4, -3);
            }
            catch (Exception e)
            {
                Assert.AreEqual("����� ������� �� ����� ���� ������������� ��� ������ 0.", e.Message);
            }
        }
    }
}
