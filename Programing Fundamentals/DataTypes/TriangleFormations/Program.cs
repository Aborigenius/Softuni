using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            bool valid = false;
            bool rightAB = false;
            bool rightBC = false;
            bool rightAC = false;

            if (a + b > c && a + c > b && b + c > a)
            {
                valid = true;
            }
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                rightAB = true;
            }
            else if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
            {
                rightBC = true;
            }
            else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
            {
                rightAC = true;
            }

            if (valid == true)
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }
            if (rightAB == true)
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (rightBC == true)
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (rightAC == true)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
    }
}
