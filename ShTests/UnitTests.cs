using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxShapeAreaClassLib;
using System;

namespace ShTests
{
    [TestClass]
    public class UnitTests
    {
        //Check triangle - is rectangular?
        [TestMethod]
        public void IsTriangleRectangular()
        {
            Triangle triangle = new Triangle(8, 6, 10);
            bool expected = true;
            // act
            bool result = triangle.IsRectangular();
            // assert            
            Assert.AreEqual(expected, result);
        }
        //Check calculation of triangle area
        [TestMethod]
        public void CheckTriangleArea()
        {
            Calc calc = new Calc();
            Triangle triangle = new Triangle(8, 6, 10);
            double expected = 24;
            // act
            double result = calc.AreaCalc(triangle);
            // assert            
            Assert.AreEqual(expected, result);
        }
        //Check calculation of circle area
        [TestMethod]
        public void CheckCircleArea()
        {
            Calc calc = new Calc();
            Circle circle = new Circle(5);
            double expected = 78.5;
            // act
            double result = Math.Round(calc.AreaCalc(circle),1);
            // assert            
            Assert.AreEqual(expected, result);
        }
        //Check creation of triangle with negative or zero length sides
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleWrongSidesTest()
        {
            Triangle tr = new Triangle(-1, 5, 6);
        }

        //Check creation circle with negative or zero radius
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleWrongRadiusTest()
        {
            Circle circle = new Circle(-5);
        }
    }
}