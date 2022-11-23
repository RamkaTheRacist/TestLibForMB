using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibForMB.Logic.Exceptions;
using TestLibForMB.Logic.FigureTriangle;

namespace Tests
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        [ExpectedException(typeof(TriangleArgumentException), "SideA is zero")]
        public void TestSideAZero()
        {
            new Triangle(0, 1, 1);
        }
        [TestMethod]
        [ExpectedException(typeof(TriangleArgumentException), "SideB is zero")]
        public void TestSideBZero()
        {
            new Triangle(1, 0, 1);
        }
        [TestMethod]
        [ExpectedException(typeof(TriangleArgumentException), "SideC is zero")]
        public void TestSideCZero()
        {
            new Triangle(1, 1, 0);
        }
        [ExpectedException(typeof(TriangleArgumentException), "SideA is less than zero")]
        [TestMethod]
        public void TestSideALessZero()
        {
            new Triangle(-1, 1, 1);
        }
        [ExpectedException(typeof(TriangleArgumentException), "SideB is less than zero")]
        [TestMethod]
        public void TestSideBLessZero()
        {
            new Triangle(1, -1, 1);
        }
        [ExpectedException(typeof(TriangleArgumentException), "SideC is less than zero")]
        [TestMethod]
        public void TestSideCLessZero()
        {
            new Triangle(1, 1, -1);
        }
        [ExpectedException(typeof(TriangleArgumentException), "Triangle doesnt exists")]
        [TestMethod]
        public void TestTriangleDoesntExists()
        {
            new Triangle(1, 1, 13);
        }
        [TestMethod]
        public void TestGetSquare()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle test = new(sideA, sideB, sideC);
            double testSquare = test.GetSquare(2);
            double halfPer = (sideA + sideB + sideC) / 2;
            double expectedSquare = Math.Round(Math.Sqrt(halfPer * (halfPer - sideA) * (halfPer - sideB) * (halfPer - sideC)), 2);
            Assert.AreEqual(expectedSquare, testSquare);
        }
        [TestMethod]
        public void TestIsRightTrue()
        {
            Triangle test = new(3, 4, 5);
            Assert.IsTrue(test.isRight);

        }
        [TestMethod]
        public void TestIsRightFalse()
        {
            Triangle test = new(5, 5, 9);
            Assert.IsFalse(test.isRight);
        }
    }
}
