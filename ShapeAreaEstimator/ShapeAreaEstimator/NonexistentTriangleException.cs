using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaEstimator
{
    public class NonexistentTriangleException : Exception
    {
        public NonexistentTriangleException(string message)
            : base(message)
        {
        }
    }
}
