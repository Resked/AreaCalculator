using ShapeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleAreaTest()
        {
            double a = 4;
            double b = 3;
            double c = 3;
            double expected = 4.47213595499958;

            Triangle triangle = new(a, b, c);

            Assert.AreEqual(expected, triangle.GetArea(), "Неверный  вывод");
        }

        [TestMethod]
        public void TrianglePerimeterTest()
        {
            double a = 4;
            double b = 3;
            double c = 3;
            double expected = 10;

            Triangle triangle = new(a, b, c);

            Assert.AreEqual(expected, triangle.GetPerimeter(), "Неверный  вывод");
        }

        [TestMethod]
        public void TriangleRightPerimeterTest()
        {
            double a = 0;
            double b = 2;
            double c = 2;
            double expected = 4;

            Triangle triangle = new(a, b, c);

            Assert.AreEqual(expected, triangle.GetPerimeter(), "Неверный  вывод");
        }
    }
}