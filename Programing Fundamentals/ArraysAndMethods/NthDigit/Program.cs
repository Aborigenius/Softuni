using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }

        static long FindNthDigit(long number, int index)
        {
            int n = 1;
            while (number > 0)
            {
                if (n == index)
                {
                    number = number % 10;
                    break;
                }
                else
                {
                    number = number / 10;
                }
                n++;
            }
            return number;
        }
    }
}
