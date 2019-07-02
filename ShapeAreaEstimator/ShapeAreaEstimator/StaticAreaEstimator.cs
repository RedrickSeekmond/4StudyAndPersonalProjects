using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaEstimator
{
    public static class StaticAreaEstimator
    {
        public static double GetTrianglePerimeter(double aSide, double bSide, double cSide)
        {
            if (aSide >= bSide + cSide || bSide >= aSide + cSide || cSide >= aSide + bSide)
                throw new ArgumentException("One side of triangle can't be less than sum of the others");

            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
                throw new ArgumentException("The sides of triangle can't be less or equal 0");

            return aSide + bSide + cSide;
        }

        public static double GetTriangleArea(double aSide, double bSide, double cSide)
        {
            if ( aSide >= bSide + cSide || bSide >= aSide + cSide || cSide >= aSide + bSide )
                throw new ArgumentException("One side of triangle can't be less than sum of the others");

            if ( aSide <= 0 || bSide <= 0 || cSide <= 0 )
                throw new ArgumentException("The sides of triangle can't be less or equal 0");

            var halfPerimeter = GetTrianglePerimeter(aSide, bSide, cSide) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - aSide) * (halfPerimeter - bSide) * (halfPerimeter - cSide));
        }
        
        public static double GetCircleArea(double radius)
        {
            if ( radius <= 0 )
                throw new ArgumentException("Radius can't be less or equal 0");

            return Math.PI * Math.Pow(radius, 2);
        }

        public static double GetCirclePerimeter(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius can't be less or equal 0");

            return 2 * Math.PI * radius;
        }

        public static bool IsTriangleRectangular(double aSide, double bSide, double cSide)
        {
            if (aSide >= bSide + cSide || bSide >= aSide + cSide || cSide >= aSide + bSide)
                throw new ArgumentException("One side of triangle can't be less than sum of the others");

            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
                throw new ArgumentException("The sides of triangle can't be less or equal 0");

            var triangleSides = new List<double>()
            {
                aSide,
                bSide,
                cSide
            };

            var longestSideIndex = triangleSides.IndexOf(triangleSides.Max());
            var longestSideSqrValue = Math.Pow(triangleSides[longestSideIndex], 2);

            triangleSides.RemoveAt(longestSideIndex);

            var supposedHypotenuse = triangleSides.Select(x => x * x).Sum();

            if (supposedHypotenuse == longestSideSqrValue)
                return true;

            return false;
        }
    }
}
