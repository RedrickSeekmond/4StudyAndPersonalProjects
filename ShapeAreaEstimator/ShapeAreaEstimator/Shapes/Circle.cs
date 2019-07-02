using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaEstimator
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set
            {
                if (value == 0)
                    value++;

                _radius = value < 0 ? -value : value;
            }
        }
        
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
               
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
               
        public override string BuildInfo()
        {
            return $"Figure type is {Name()}; radius: {Radius}," +
                              $" area: {Area(): ####.###}, perimeter(length): {Perimeter(): ####.###}";
        }
               
        public override string Name()
        {
            return "Circle";
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
