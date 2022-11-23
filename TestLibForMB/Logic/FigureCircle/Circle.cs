using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibForMB.Logic.Base;
using TestLibForMB.Logic.Exceptions;

namespace TestLibForMB.Logic.FigureCircle
{
    /// <summary>
    /// Create figure "circle". Extends BaseFigure
    /// </summary>
    public class Circle : BaseFigure
    {
        private double Radius { get; }
        /// <summary>
        /// Base constructor for creating circle
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        public Circle(double radius) : base(radius)
        {
            if (radius <= 0)
            {
                throw new CircleArgumentException($"{nameof(radius)} ({radius}) is or less zero");
            }
            Radius = radius;
        }
        /// <summary>
        /// Method for getting square of circle with specified number of digits after the decimal point
        /// </summary>
        /// <param name="digits">Number of digits after the decimal point. Default 2</param>
        /// <returns>Number of square of figure as double-type number </returns>
        public override double GetSquare(int digits = 2)
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), digits);
        }

    }
}
