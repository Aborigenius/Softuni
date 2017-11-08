using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var inhertedMoney = double.Parse(Console.ReadLine());
            var yearToLive = int.Parse(Console.ReadLine());
            var IvanchoYears = 18;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    inhertedMoney -= 12000;
                }
                else
                {
                    inhertedMoney -= (12000 + IvanchoYears * 50);
                }
                IvanchoYears++;
            }
            if (inhertedMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inhertedMoney:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inhertedMoney):F2} dollars to survive.");
            }
        }
    }
}
