using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            CalcCube(cubeSide, parameter);
        }

        static void CalcCube(double cubeSide, string parameter)
        {
            double result = 0;
            if (parameter == "face")
            {//
                result = Math.Sqrt(2 * (cubeSide * cubeSide));
            }
            if (parameter == "space")
            {
                result = Math.Sqrt(3 * (cubeSide * cubeSide));
            }
            if (parameter == "volume")
            {
                result = Math.Pow(cubeSide, 3);

            }
            if (parameter == "area")
            {
                result = 6 * (Math.Pow(cubeSide, 2));
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
