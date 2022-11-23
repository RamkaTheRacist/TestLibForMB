using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibForMB.Logic.Base;
using TestLibForMB.Logic.Exceptions;

namespace TestLibForMB.Logic.FigureTriangle
{
    /// <summary>
    /// Create figure "triangle". Extends BaseFigure
    /// </summary>
    public class Triangle : BaseFigure
    {
        private double SideA { get; }
        private double SideB { get; }
        private double SideC { get; }
        /// <summary>
        /// Boolean value which contains value if triangle is right or not 
        /// </summary>
        public bool isRight;
        /// <summary>
        /// Base constructor for creating triangle
        /// </summary>
        /// <param name="sideA">First side of triangle</param>
        /// <param name="sideB">Second side of triangle</param>
        /// <param name="sideC">Third side of triangle</param>
        public Triangle(double sideA, double sideB, double sideC) : base(sideA)
        {
            if (sideA <= 0) throw new TriangleArgumentException($"{nameof(sideA)} ({sideA}) is or less zero");
            if (sideB <= 0) throw new TriangleArgumentException($"{nameof(sideB)} ({sideB}) is or less zero");
            if (sideC <= 0) throw new TriangleArgumentException($"{nameof(sideC)} ({sideC}) is or less zero");
            double maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            if ((sideA + sideB + sideC) - maxSide - maxSide <= 0)
                throw new TriangleArgumentException($"Triangle with sides {sideA}, {sideB}, {sideC} can`t exists");
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            isRight = IfTriangleIsRight();
        }
        private bool IfTriangleIsRight()
        {
            if ((SideA + SideB + SideC) / SideA == 3) return false;
            else
            {
                double maxSide = SideA, secondSide = SideB, thirdSide = SideC;
                if (Math.Max(SideA, Math.Max(SideB, SideC)) == secondSide)
                {
                    double tmpValue = maxSide;
                    maxSide = secondSide;
                    secondSide = tmpValue;
                }
                else if (Math.Max(SideA, Math.Max(SideB, SideC)) == thirdSide)
                {
                    double tmpValue = maxSide;
                    maxSide = thirdSide;
                    thirdSide = tmpValue;
                }
                return (((Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) == Math.Pow(maxSide, 2)));
            }
        }
        /// <summary>
        /// Method for getting square of triangle with specified number of digits after the decimal point
        /// </summary>
        /// <param name="digits">Number of digits after the decimal point. Default 2</param>
        /// <returns>Number of square of figure as double-type number</returns>
        public override double GetSquare(int digits = 2)
        {
            double halfPer = (SideA + SideB + SideC) / 2;
            return Math.Round(Math.Sqrt(halfPer * (halfPer - SideA) * (halfPer - SideB) * (halfPer - SideC)), digits);
        }
    }
}
