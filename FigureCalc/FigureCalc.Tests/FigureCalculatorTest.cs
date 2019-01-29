using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureCalc.Tests
{
    [TestClass]
    public class FigureCalculatorTest
    {
        [TestMethod]
        public void TriangleIsRectangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            bool actual = FigureCalculator.IsTriangleRectangular(sideA, sideB, sideC);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TriangleIsNotRectangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;

            bool actual = FigureCalculator.IsTriangleRectangular(sideA, sideB, sideC);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The sum of the lengths of the two any sides of the triangle must be greater than the length of the third side")]
        public void CreateTriangleLargeLengthException()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 8;

           FigureCalculator.GetTriangleArea(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Length of triangle's side can't be null or negative")]
        public void CreateTriangleNegativeLengthException()
        {
            double sideA = -1;
            double sideB = 4;
            double sideC = 8;

            FigureCalculator.GetTriangleArea(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The Radius can't be negative")]
        public void FailedCreateCircleException()
        {
            double radius = -3;

            FigureCalculator.GetCircleArea(radius);
        }

        [TestMethod]
        public void CalcTriangleArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expected = 6;


            double actual = FigureCalculator.GetTriangleArea(sideA, sideB, sideC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcCircleArea()
        {
            double radius = 3;
            double expected = 28.27;

            double actual = Math.Round(FigureCalculator.GetCircleArea(radius),2);

            Assert.AreEqual(expected, actual);
        }
    }
}
