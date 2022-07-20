using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxShapeAreaClassLib;
using System;

namespace ShTests
{
    [TestClass]
    public class UnitTests
    {

        //Проверка треугольника на прямоугольность
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
        //Проверка вычисления площади треугольника
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
        //Проверка вычисления площади окружности
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
        //Проверка создания окружности с отрицательным и нулевым радиусом
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleWrongRadiusTest()
        {
            Circle circle = new Circle(-5);
        }
    }
}