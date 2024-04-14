using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculatorlibrary
{
    public class SquareCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            double square = Math.PI + Math.Pow(radius, 2);
            return square;
        }

        public static double CalculateTriangleSquare(double aSide, double bSide, double cSide)
        {
            double semiperimeter = aSide + bSide + cSide;
            double square = Math.Sqrt(semiperimeter) * (semiperimeter - aSide) * (semiperimeter - bSide) * (semiperimeter - cSide);
            bool isRightAngels = IsTriangleRightAngles(aSide, bSide, cSide);
            return square;
        }

        public static bool IsTriangleRightAngles(double aSide, double bSide, double cSide)
        {
            double[] sides = { aSide, bSide, cSide };
            Array.Sort(sides);
            bool result = Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
            return result;
        }
    }
}