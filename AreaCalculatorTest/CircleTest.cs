using ShapeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTest
{
    [TestClass]
    public class CircumferenceTest
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            double radius = 5;
            double expected = 78.53981633974483;

            Circle circle = new(radius);

            Assert.AreEqual(expected, circle.GetArea(), "Неверный  вывод");
        }

        [TestMethod]
        public void CirclePerimeterTestCircle()
        {
            double radius = 5;
            double expected = 31.41592653589793;

            Circle circle = new(radius);

            Assert.AreEqual(expected, circle.GetPerimeter(), "Неверный  вывод");
        }
    }
}