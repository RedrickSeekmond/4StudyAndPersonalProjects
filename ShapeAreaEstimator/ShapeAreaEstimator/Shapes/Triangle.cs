using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaEstimator
{
    public class Triangle : Shape
    {
        private double _triangleASideLength;
        public double ASideLength
        {
            get => _triangleASideLength;
            set
            {
                if (value == 0)
                    value++;

                _triangleASideLength = value < 0 ? -value : value;
            }
        }

        private double _triangleBSideLength;
        public double BSideLength
        {
            get => _triangleBSideLength;
            set
            {
                if (value == 0)
                    value++;

                _triangleBSideLength = value < 0 ? -value : value;
            }
        }

        private double _triangleCSideLength;
        public double CSideLength
        {
            get => _triangleCSideLength;
            set
            {
                if (value == 0)
                    value++;

                _triangleCSideLength = value < 0 ? -value : value;
            }
        }

        public string TriangleType { get; }

        public override double Area()
        {
            var halfPerimeter = Perimeter() / 2;

            return Math.Sqrt( halfPerimeter * (halfPerimeter-ASideLength) * (halfPerimeter-BSideLength) * (halfPerimeter-CSideLength) );
        }
               
        public override double Perimeter()
        {
            return ASideLength + BSideLength + CSideLength;
        }

        public string DefineTriangleType()
        {
            var triangleSides = new List<double>()
            {
                ASideLength,
                BSideLength,
                CSideLength
            };
           
            var longestSideIndex = triangleSides.IndexOf(triangleSides.Max());
            var longestSideSqrValue = Math.Pow( triangleSides[longestSideIndex], 2 );

            triangleSides.RemoveAt(longestSideIndex);

            var supposedHypotenuse = triangleSides.Select(x => x * x).Sum();

            if (supposedHypotenuse == longestSideSqrValue)
                return "Rectangular";

            if (supposedHypotenuse < longestSideSqrValue)
                return "Blunt";
            
            return "Sharp";
        }

        public override string BuildInfo()
        {
            return $"Figure type is {Name()}; sides: a = {ASideLength: ####.###}," +
                   $" b = {BSideLength: ####.###}, c = {CSideLength: ####.###};" +
                   $" area: {Area(): ####.###}, perimeter: {Perimeter(): ####.###}";
        }
               
        public override string Name()
        {
            return "Triangle";
        }

        public Triangle( double aSide, double bSide, double cSide)
        {
            ASideLength = aSide;
            BSideLength = bSide;
            CSideLength = cSide;
            TriangleType = DefineTriangleType();

            if (ASideLength + BSideLength <= CSideLength || ASideLength + CSideLength <= BSideLength
                                       || BSideLength + CSideLength <= ASideLength)
            {
                ASideLength = 3;
                BSideLength = 4;
                CSideLength = 5;

                TriangleType = DefineTriangleType();

                return;
            }
        }

        public Triangle()
        {
            ASideLength = 3;
            BSideLength = 4;
            CSideLength = 5;
            TriangleType = DefineTriangleType();
        }
    }
}
