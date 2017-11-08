using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var boughtChrysanthemums = int.Parse(Console.ReadLine());
            var boughtRoses = int.Parse(Console.ReadLine());
            var boughtTulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var isItHoliday = Console.ReadLine().ToLower();

            var boughtFlowersTotal = boughtChrysanthemums + boughtRoses + boughtTulips;
            var finalPrice = 0.00;
            double soldTulips = 0.00;
            double soldRoses = 0.00;
            double soldChrysanthemums = 0.00;

            if (season == "spring" || season == "summer")
            {
                if (isItHoliday == "y")
                {
                    soldChrysanthemums = boughtChrysanthemums * 2;
                    soldRoses = boughtRoses * 4.10;
                    soldTulips = boughtTulips * 2.50;
                    var finalPrice1 = soldRoses + soldTulips + soldChrysanthemums;
                    finalPrice = finalPrice1 + (finalPrice1 * 15 / 100);
                }
                if (isItHoliday == "n")
                {
                    soldChrysanthemums = boughtChrysanthemums * 2;
                    soldRoses = boughtRoses * 4.10;
                    soldTulips = boughtTulips * 2.50;
                    finalPrice = soldRoses + soldTulips + soldChrysanthemums;
                }
                if (boughtTulips > 7)
                {
                    finalPrice = finalPrice - (finalPrice * 5 / 100);
                }
                if (boughtFlowersTotal > 20)
                {
                    finalPrice = finalPrice - (finalPrice * 20 / 100);
                }

            }

            else if (season == "autumn" || season == "winter")
            {
                if (isItHoliday == "y")
                {
                    soldChrysanthemums = boughtChrysanthemums * 3.75;
                    soldRoses = boughtRoses * 4.50;
                    soldTulips = boughtRoses * 4.15;
                    var finalPrice1 = soldRoses + soldTulips + soldChrysanthemums;
                    finalPrice = finalPrice1 + (finalPrice1 * 15 / 100);
                }
                if (isItHoliday == "n")
                {
                    soldChrysanthemums = boughtChrysanthemums * 3.75;
                    soldRoses = boughtRoses * 4.50;
                    soldTulips = boughtTulips * 4.15;
                    finalPrice = soldRoses + soldTulips + soldChrysanthemums;
                }
                if (boughtRoses >= 10)
                {
                    finalPrice = finalPrice - (finalPrice * 10 / 100);
                }
                if (boughtFlowersTotal > 20)
                {
                    finalPrice = finalPrice - (finalPrice * 20 / 100);
                }
            }
            Console.WriteLine("{0:F2}",finalPrice + 2);


        }

    }
}
