using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddsumEven
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sumEven = 0.0;
            var sumOdd = 0.0;

            for (int i = 0; i < number; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine($"Yes sum: {sumOdd}");
            }
            else
            {
                var diff = Math.Abs(sumOdd - sumEven);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
