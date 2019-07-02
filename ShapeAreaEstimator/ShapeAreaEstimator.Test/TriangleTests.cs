using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ShapeAreaEstimator.Test
{
    [TestFixture]
    class TriangleTests
    {
        [Test]
        public void Name_WriteNameToVariable_TriangleReturned()
        {
            //arrange
            var triangle = new Triangle();

            //act
            var res = triangle.Name();

            //assert
            Assert.AreEqual("Triangle", res);
        }

        [Test]
        public void BuildInfo_WriteInfoToVariable_FormatedDataReturned()
        {
            //arrange
            var triangle = new Triangle();

            //act
            var res = triangle.BuildInfo();

            //assert
            Assert.AreEqual($"Figure type is Triangle; sides: a = {triangle.ASideLength: ####.###}," +
                            $" b = {triangle.BSideLength: ####.###}, c = {triangle.CSideLength: ####.###};" +
                            $" area: {triangle.Area(): ####.###}, perimeter: {triangle.Perimeter(): ####.###}", res);
        }

        [Test]
        public void Area_AreaOfEgyptTriangle_Returned6()
        {
            //arrange
            var triangle = new Triangle();

            //act
            var res = triangle.Area();

            //assert
            Assert.AreEqual(6, res);
        }

        [Test]
        public void Perimeter_PerimeterOfEgyptTriangle_Returned12()
        {
            //arrange
            var triangle = new Triangle();

            //act
            var res = triangle.Perimeter();

            //assert
            Assert.AreEqual(12, res);
        }

        [Test]
        public void DefineTriangleType_TriangleTypeOfEgyptTriangle_ReturnedRectangular()
        {
            //arrange
            var triangle = new Triangle();

            //act
            var res = triangle.DefineTriangleType();

            //assert
            Assert.AreEqual("Rectangular", res);
        }

        [Test]
        public void ASideLength_InitializeWithZero_Returned1()
        {
            //arrange
            var triangle = new Triangle(0, 1, 1);

            //act
            var res = triangle.ASideLength;

            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void BSideLength_InitializeWithZero_Returned1()
        {
            //arrange
            var triangle = new Triangle(1, 0, 1);

            //act
            var res = triangle.BSideLength;

            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void CSideLength_InitializeWithZero_Returned1()
        {
            //arrange
            var triangle = new Triangle(1, 1, 0);

            //act
            var res = triangle.CSideLength;

            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void ASideLength_InitializeWithNegative5_ReturnedPositive5()
        {
            //arrange
            var triangle = new Triangle(-5, 4, 3);

            //act
            var res = triangle.ASideLength;

            //assert
            Assert.AreEqual(5, res);
        }

        [Test]
        public void BSideLength_InitializeWithNegative5_ReturnedPositiveFive()
        {
            //arrange
            var triangle = new Triangle(3, -5, 4);

            //act
            var res = triangle.BSideLength;

            //assert
            Assert.AreEqual(5, res);
        }

        [Test]
        public void CSideLength_InitializeWithNegative5_ReturnedPositiveFive()
        {
            //arrange
            var triangle = new Triangle(3, 4, -5);

            //act
            var res = triangle.CSideLength;

            //assert
            Assert.AreEqual(5, res);
        }

        [Test]
        public void ASideLength_CSidePlusBSideLessThanASide_ReturnedEgyptTriangle()
        {
            //arrange
            var triangle = new Triangle(6, 2, 3);

            //act
            var res = $"{triangle.ASideLength}, {triangle.BSideLength}, {triangle.CSideLength}";

            //assert
            Assert.AreEqual("3, 4, 5", res);
        }

        [Test]
        public void BSideLength_ASidePlusCSideLessThanASide_ReturnedEgyptTriangle()
        {
            //arrange
            var triangle = new Triangle(2, 6, 3);

            //act
            var res = $"{triangle.ASideLength}, {triangle.BSideLength}, {triangle.CSideLength}";

            //assert
            Assert.AreEqual("3, 4, 5", res);
        }

        [Test]
        public void CSideLength_ASidePlusBSideLessThanASide_ReturnedEgyptTriangle()
        {
            //arrange
            var triangle = new Triangle(2, 3, 6);

            //act
            var res = $"{triangle.ASideLength}, {triangle.BSideLength}, {triangle.CSideLength}";

            //assert
            Assert.AreEqual("3, 4, 5", res);
        }
    }
}
