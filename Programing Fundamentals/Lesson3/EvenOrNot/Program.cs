using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var rem = number % 2;
            if (rem == 0)
            {
                Console.WriteLine("It is Even!");
            }
            else
            {
                Console.WriteLine("Odd!");
            }
        }
    }
}
