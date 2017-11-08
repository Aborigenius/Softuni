using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberAbsoluteValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 10;

            do
            {
                var n = int.Parse(Console.ReadLine());
                if (n % 2 == 0 || count <= 0)
                {
                    Console.WriteLine("Please write an odd number.");
                    count--;
                }

                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }

            } while (count >= 0);
        }

    }
}

