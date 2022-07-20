using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MindboxShapeAreaClassLib;

namespace ShapeTests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void RectangularTriangle()
        {
            MindboxShapeAreaClassLib.

                Calc calc = new Calc();
            var triangle = new Triangle(5,6,7);
            bool expected = true;
            // act
            double result = calc
            // assert            
            Assert.AreEqual(expected, result);

        }
    }
}
