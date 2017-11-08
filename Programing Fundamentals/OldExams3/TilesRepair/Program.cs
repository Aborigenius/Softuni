using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilesRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double benchWidth = double.Parse(Console.ReadLine());
            double benchHeight = double.Parse(Console.ReadLine());

            //timePertile = 0.2 minutes

            var totalToCover = N * N;
            var tilesArea = tileHeight * tileWidth;
            var benchArea = benchWidth * benchHeight;

            var areaToCover = totalToCover - benchArea;
            var neededTiles = areaToCover / tilesArea;
            var timeNeeded = neededTiles * 0.2;

            Console.WriteLine(neededTiles);
            Console.WriteLine(timeNeeded);
        }
    }
}
