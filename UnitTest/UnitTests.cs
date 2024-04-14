using System.Diagnostics;
using SquareCalculatorlibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
    public class UnitTests
    {
        [TestMethod]
        public static void TestCalculateCircleArea()
        {
            double actual;
            double expected = 3.14;

            actual = SquareCalculator.CalculateCircleArea(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public static void TestCalculateTriangleSquare()
        {
            double actual;
            double expected = 4.683748498798798;

            actual = SquareCalculator.CalculateTriangleSquare(1, 1, 1);
        Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public static void TestIsTriangleRightAngles()
        {
            bool actual;
            bool expected = true;

            actual = SquareCalculator.IsTriangleRightAngles(3, 5, 4);
            Assert.AreEqual(expected, actual);
        }
    }