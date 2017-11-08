using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathroomTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var savedMoney = double.Parse(Console.ReadLine());
            var floorWidth = double.Parse(Console.ReadLine());
            var floorHeight = double.Parse(Console.ReadLine());

            var trinagleTilesSide = double.Parse(Console.ReadLine());
            var trinagleTilesHeight = double.Parse(Console.ReadLine());
            var tilesPrice = double.Parse(Console.ReadLine());
            var MaistorPrice = double.Parse(Console.ReadLine());

            var floorArea = floorHeight * floorWidth;
            var tileArea = (trinagleTilesHeight * trinagleTilesSide) / 2;

            var neededTiles = Math.Ceiling(floorArea / tileArea) + 5;

            var tilesTotal = (tilesPrice * neededTiles) + MaistorPrice;

            if (tilesTotal <= savedMoney)
            {
                tilesTotal = Math.Abs(savedMoney - tilesTotal);
                Console.WriteLine($"{tilesTotal:F2} lv left.");
            }
            else
            {
                tilesTotal = Math.Abs(tilesTotal - savedMoney);
                Console.WriteLine($"You'll need {tilesTotal:F2} lv more.");  
            }
        }
    }
}
