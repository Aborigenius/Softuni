using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());
            double totalStudio = 0;
            double totalDouble = 0;
            double totalSuite = 0;

            switch (month)
            {
                case "may":
                case "october": totalStudio = 50; totalDouble = 65; totalSuite = 75; break;
                case "june":
                case "september": totalStudio = 60; totalDouble = 72; totalSuite = 82; break;
                case "july":
                case "august":
                case "december": totalStudio = 68; totalDouble = 77; totalSuite = 89; break;
            }
            if ((month == "may" || month == "october") && nights > 7)
            {
                totalStudio *= 0.95;
            }
            else if ((month == "june" || month == "september") && nights > 14)
            {
                totalDouble *= 0.9;
            }
            else if ((month == "july" || month == "august" || month == "december") && nights > 14)
            {
                totalSuite *= 0.85;
            }
            double endPriceStudio = totalStudio * nights;
            double endPriceDouble = totalDouble * nights;
            double endPriceSuite = totalSuite * nights;

            if ((month == "september" || month == "october") && nights > 7)
            {
                endPriceStudio -= totalStudio;
            }

            Console.WriteLine($"Studio: {endPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {endPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {endPriceSuite:f2} lv.");
        }
    }
}
