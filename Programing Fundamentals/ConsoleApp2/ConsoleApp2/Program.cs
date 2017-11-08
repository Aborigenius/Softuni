using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());
            decimal x3 = decimal.Parse(Console.ReadLine());
            decimal y3 = decimal.Parse(Console.ReadLine());

            var sideA = Math.Abs(x3 - x2);
            var triangleHeight = Math.Abs(y1 - y3);
            var triangleArea = sideA * triangleHeight / 2;

            Console.WriteLine(triangleArea);

        }
    }
}
