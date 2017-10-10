using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();
            double result = 0;
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = (side * height) / 2;
            }
            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                result = side * side;
            }
            if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = height * width;
            }
            if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = radius * radius * Math.PI;
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
