using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldExams
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var windowsNumber = int.Parse(Console.ReadLine());
            var styroInPacket = double.Parse(Console.ReadLine());
            var styroPrice = double.Parse(Console.ReadLine());

            var windowArea = 2.4;

            var houseWindowsArea = windowsNumber * windowArea;
            var houseNoWindowsAreaTotal = (houseArea - houseWindowsArea);
            var plus10Perc = houseNoWindowsAreaTotal * 1.10;
            var styroNeeded = Math.Ceiling(plus10Perc / styroInPacket);

            var moneyNeeded = styroNeeded * styroPrice;

            if (budget > moneyNeeded)
            {
                Console.WriteLine("Spent: {0:F2}", moneyNeeded);
                Console.WriteLine("Left: {0:F2} ", budget -moneyNeeded);;
            }
            else
            {
                Console.WriteLine("Need more: {0:F2}", moneyNeeded - budget);
            }
        }
    }
}