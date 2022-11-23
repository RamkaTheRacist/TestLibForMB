using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibForMB.Logic.Exceptions
{
    /// <summary>
    /// The exception that is thrown when radius of circle is or less than zero 
    /// </summary>
    public class CircleArgumentException : ArgumentException
    {
        /// <summary>
        /// Constructor of CircleArgumentException with message
        /// </summary>
        /// <param name="message">Message for exception</param>
        public CircleArgumentException(string message) : base("Invalid input data : " + message)
        {
        }
    }
}
