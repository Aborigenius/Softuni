using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Mar2016Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            var houseHeight = double.Parse(Console.ReadLine());
            var houseWidth = double.Parse(Console.ReadLine());
            var roofTriangleHeight = double.Parse(Console.ReadLine());

            var frontBackWall = 2 * (houseHeight * houseHeight) - 1.2 * 2;
            var sideWalls = 2 * (houseHeight * houseWidth) - 2 * 2.25;

            var roofBigSides = 2 * (houseWidth * houseHeight);
            var roofSmallSides = 2 * (houseHeight * roofTriangleHeight /2);

            var houseArea = frontBackWall + sideWalls;
            var roofArea = roofBigSides + roofSmallSides;

            var greenPaint = houseArea / 3.4;
            var redPaint = roofArea / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");

        }
    }
}
