using TestLibForMB.Logic.Exceptions;
using TestLibForMB.Logic.FigureCircle;

namespace Tests
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        [ExpectedException(typeof(CircleArgumentException), "Radius is zero")]
        public void TestRadiusZero()
        {
            new Circle(0);
        }
        [ExpectedException(typeof(CircleArgumentException), "Radius is less than zero")]
        [TestMethod]
        public void TestRadiusLessThanZero()
        {
            new Circle(-1);
        }
        [TestMethod]
        public void TestGetSquare()
        {
            double radius = 5;
            Circle test = new(radius);
            double testSquare = test.GetSquare(2);
            double expectedSquare = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            Assert.AreEqual(expectedSquare, testSquare);
        }
    }
}