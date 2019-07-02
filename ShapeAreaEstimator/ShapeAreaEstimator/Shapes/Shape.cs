using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaEstimator
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract string BuildInfo();
        public abstract string Name();
    }
}
