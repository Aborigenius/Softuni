using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfTurns = int.Parse(Console.ReadLine());
            double points = 0.00;
            double invalid = 0;
            double zeronine = 0;
            double tennineteen = 0;
            double twentytwnine = 0;
            double thirtythnine = 0.00;
            double fourthy = 0.00;

            for (int i = 0; i < numberOfTurns;  i++)
            {
                var numbers = double.Parse(Console.ReadLine());

                if (numbers >= 0 && 10 > numbers)
                {
                    points += numbers * 20 / 100;
                    zeronine++;
                }
                if (numbers >= 10 && 20 > numbers)
                {
                    points += numbers * 30 / 100;
                    tennineteen++;
                }
                if (numbers >= 20 && 30 > numbers)
                {
                    points += numbers * 40 / 100;
                    twentytwnine++;
                }
                if (numbers >= 30 && 39 > numbers)
                {
                    points += 50;
                    thirtythnine++;
                }
                if (numbers <= 50 && 39 < numbers)
                {
                    points += 100;
                    fourthy++;
                }
                if (numbers > 50 || 0 > numbers)
                {
                    points /= 2;
                    invalid++;
                }
               
                numbers = 0;
            }
            Console.WriteLine($"{points:f2}");
            Console.WriteLine("From 0 to 9: {0:f2}%", zeronine / numberOfTurns * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", tennineteen / numberOfTurns * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", twentytwnine / numberOfTurns * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", thirtythnine / numberOfTurns * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", fourthy / numberOfTurns * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalid / numberOfTurns * 100);


        }
    }
}
