using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherMagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
           // int minNumber = 111111;
            int maxNumber = 999999;

            for (int i = 1; i <= maxNumber; i++)
            {
                var first = (i / 100000) % 10;
                var second = (i / 10000) % 10;
                var third = (i / 1000) % 10;
                var fourth = (i / 100) % 10;
                var fifth = (i / 10) % 10;
                var sixt = (i / 1) % 10;
                if (first * second * third * fourth * fifth * sixt == N)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
