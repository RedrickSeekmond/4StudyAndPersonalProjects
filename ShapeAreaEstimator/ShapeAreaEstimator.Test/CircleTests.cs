using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ShapeAreaEstimator.Test
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Name_WriteNameToVariable_CircleReturned()
        {
            //arrange
            var circle = new Circle(2);

            //act
            var res = circle.Name();

            //assert
            Assert.AreEqual("Circle", res);
        }

        [Test]
        public void BuildInfo_WriteInfoToVariable_FormatedDataReturned()
        {
            //arrange
            var circle = new Circle(2);

            //act
            var res = circle.BuildInfo();

            //assert
            Assert.AreEqual($"Figure type is {circle.Name()}; radius: {circle.Radius}," +
                            $" area: {circle.Area(): ####.###}, " +
                            $"perimeter(length): {circle.Perimeter(): ####.###}", res);
        }

        [Test]
        public void Area_AreaOfCircleWithRadiusPi_PowPi3()
        {
            //arrange
            var circle = new Circle(Math.PI);

            //act
            var res = circle.Area();

            //assert
            Assert.AreEqual( Math.Pow(Math.PI, 3), res );
        }

        [Test]
        public void Perimeter_PerimeterOfCircleWithRadiusPi_2PiPow2()
        {
            //arrange
            var circle = new Circle(Math.PI);

            //act
            var res = circle.Perimeter();

            //assert
            Assert.AreEqual( 2 * Math.Pow(Math.PI, 2), res );
        }

        [Test]
        public void Radius_InitializeWithZero_ReturnedRadius1()
        {
            //arrange
            var circle = new Circle(0);

            //act
            var res = circle.Radius;

            //assert
            Assert.AreEqual(1, res);
        }

        [Test]
        public void Radius_InitializeWithNegative5_ReturnedRadiusPositive5()
        {
            //arrange
            var circle = new Circle(-5);

            //act
            var res = circle.Radius;

            //assert
            Assert.AreEqual(5, res);
        }
    }
}
