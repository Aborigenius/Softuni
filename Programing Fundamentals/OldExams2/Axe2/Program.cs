using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = n * 5;
            var LeftSide = n * 3;
            var MiddleSpaces = 0;
            var rightSide = width - LeftSide - MiddleSpaces - 2;

            for (int row = 0; row < n; row++)
            {

                Console.WriteLine("{0}*{1}*{2}", new string('-', LeftSide), new string('-', MiddleSpaces), new string('-', rightSide));
                MiddleSpaces++;
                rightSide--;

            }
            for (int i = 0; i < n / 2; i++)
            {
               
                Console.WriteLine("{0}*{1}*{2}", new string('*', LeftSide), new string('-', MiddleSpaces), new string('-', rightSide));
               

            }


            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', LeftSide), new string('-', MiddleSpaces), new string('-', rightSide));
                LeftSide--;
                MiddleSpaces += 2;
                rightSide--;

            }

            Console.WriteLine("{0}*{1}*{2}", new string('-', LeftSide), new string('*', MiddleSpaces), new string('-', rightSide));
        }
    }
}
