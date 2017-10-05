using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DistanceToStars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal proxima = (decimal)4.22 * 9450000000000;
            decimal MilkyCenter = (decimal)26000 * 9450000000000;
            decimal milkyDiameter = 100000 * 9450000000000;
            decimal universeEdge = 46500000000 * (decimal)9450000000000;

            Console.WriteLine($"{proxima:e2}");
            Console.WriteLine($"{MilkyCenter:e2}");
            Console.WriteLine($"{milkyDiameter:e2}");
            Console.WriteLine($"{universeEdge:e2}"); 
        }
    }
}
