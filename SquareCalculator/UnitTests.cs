using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareCalculatorlibrary;

class UnitTests
    { 
    static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("Choose form of figure to calculate square \n1)Circle \n2)Triangle");
            switch (Console.ReadLine()) 
            {
                case "1":
                    Console.WriteLine("write radius of circle");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double result = SquareCalculator.CalculateCircleArea(radius);
                    Console.WriteLine($"Square of circle is {result}");
                    break;
                case "2":
                    {
                        Console.WriteLine("enter A side");
                        double A = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter B side");
                        double B = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter C side");
                        double C = Convert.ToDouble(Console.ReadLine());
                        double square = SquareCalculator.CalculateTriangleSquare(C, A, B);
                        bool rightAngles = SquareCalculator.IsTriangleRightAngles(C, A, B);
                        Console.WriteLine($"The square is {square}. Triangle is right angles - {rightAngles}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong choose");
                        break;
                    }
            }

        }
    }
}
