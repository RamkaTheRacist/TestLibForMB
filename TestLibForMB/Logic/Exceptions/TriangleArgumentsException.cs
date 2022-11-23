using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibForMB.Logic.Exceptions
{
    /// <summary>
    /// The exception that is thrown when side of triangle is or less than zero 
    /// </summary>
    public class TriangleArgumentException : ArgumentException
    {
        /// <summary>
        /// Constructor of TriangleArgumentException with message
        /// </summary>
        /// <param name="message">Message for exception</param>
        public TriangleArgumentException(string message) : base("Invalid input data : " + message)
        {
        }
    }
}
