using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = (2 * n) - 1;
            var height = 2 * (n - 2) + 1;

            for (int row = 0; row < n ; row++)
            {
                Console.Write("*");
            }
        }
    }
}

//
//  *\ /*
//    @
//  */ \*
