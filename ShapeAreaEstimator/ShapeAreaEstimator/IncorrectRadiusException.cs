using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaEstimator
{
    class IncorrectRadiusException : Exception
    {
        public IncorrectRadiusException(string message)
            : base(message)
        {
        }
    }
}
