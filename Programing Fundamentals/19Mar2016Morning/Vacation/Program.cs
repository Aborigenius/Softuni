using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            string loc = "";
            string place = "";
            double endPrice = 0.00;


            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "summer")
                {
                    loc = "Alaska";
                    endPrice = budget * 65 / 100;

                }
                if (season == "winter")
                {
                    loc = "Morocco";
                    endPrice = budget * 45 / 100;
                }
            }
            if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                if (season == "summer")
                {
                    loc = "Alaska";
                    endPrice = budget * 80 / 100;

                }
                if (season == "winter")
                {
                    loc = "Morocco";
                    endPrice = budget * 60 / 100;
                }
            }
            if (budget > 3000)
            {
                place = "Hotel";
                if (season == "summer")
                {
                    loc = "Alaska";
                    endPrice = budget * 90 / 100;

                }
                if (season == "winter")
                {
                    loc = "Morocco";
                    endPrice = budget * 90 / 100;
                }
            }

            Console.WriteLine($"{loc} - {place} - {endPrice:f2}");
        }
    }
}
