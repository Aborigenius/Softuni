using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqSide = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchHeight = int.Parse(Console.ReadLine());

            int benchArea = benchHeight * benchWidth;
            int sqArea = (sqSide * sqSide) - benchArea;
            double tileArea = tileHeight * tileWidth;

            double tilesNeeded = sqArea / tileArea;
            double timeNeeded = tilesNeeded * 0.2;

            Console.WriteLine($"{tilesNeeded}");
            Console.WriteLine($"{timeNeeded}");
        }
    }
}
