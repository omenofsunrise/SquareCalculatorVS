using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareCalculatorlibrary;
using System.Diagnostics;

class UnitTests
    { 
    public static void TestCalculateCircleArea()
    {
        double actual;
        double expected = 1;

        actual = SquareCalculator.CalculateCircleArea(1);
        Debug.Assert(expected == actual, "an arror in CalculateCircleArea function");
    }
    
    public static void TestCalculateTriangleSquare()
    {
        double actual;
        double expected = 1;

        actual = SquareCalculator.CalculateTriangleSquare(1, 1, 1);
        Debug.Assert(expected == actual, "an arror in CalculateTriangleSquare function");
    }

    public static void TestIsTriangleRightAngles()
    {
        bool actual;
        bool expected = true;

        actual = SquareCalculator.IsTriangleRightAngles(3, 5, 4);
        Debug.Assert(expected == actual, "an arror in IsTriangleRightAngles function");
    }
}
