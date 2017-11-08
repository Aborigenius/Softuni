using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            //LeftToTight
            var firstDigit = (N / 100) % 10;
            var secondDigit = (N / 10) % 10;
            var thirdDigit = (N / 1) % 10;
            var nextNumber = N;
            for (int row = 0; row < firstDigit + secondDigit; row++)
            {
                for (int col = 0; col < firstDigit + thirdDigit; col++)
                {

                    if (nextNumber % 5 == 0)
                    {
                        nextNumber -= firstDigit;

                    }
                    else if (nextNumber % 3 == 0)
                    {
                        nextNumber -= secondDigit;
                    }
                    else
                    {
                        nextNumber += thirdDigit;
                    }
                    Console.Write(nextNumber + " ");

                }
                Console.WriteLine();

            }

        }
    }
}

