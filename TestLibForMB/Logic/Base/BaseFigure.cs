using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibForMB.Logic.Base
{
    /// <summary>
    /// Base class for any figure
    /// </summary>
    public abstract class BaseFigure
    {
        private double AnySide { get; }
        /// <summary>
        /// Base constructor for any figure
        /// </summary>
        /// <param name="anySide">Base parameter for any figure (figure can`t has 0 parameters)</param>
        protected BaseFigure(double anySide)
        {
            AnySide = anySide;
        }
        /// <summary>
        /// Method for getting square of figure with specified number of digits after the decimal point
        /// </summary>
        /// <param name="digits">Number of digits after the decimal point. Default 2.</param>
        /// <returns>Number of square of figure as double-type number </returns>
        public abstract double GetSquare(int digits = 2);
    }
}
