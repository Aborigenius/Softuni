using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToTenPrinted
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var num1 = int.Parse(Console.ReadLine());

            if (num1 >= 10)
            {
                Console.WriteLine("number too big");
            }
            else if (num1 == 1)
            {
                Console.WriteLine("one");
            }
            else if (num1 == 2)
            {
                Console.WriteLine("two");
            }
            else if (num1 == 3)
            {
                Console.WriteLine("three");
            }
            else if (num1 == 4)
            {
                Console.WriteLine("four");
            }
            else if (num1 == 5)
            {
                Console.WriteLine("five");
            }
            else if (num1 == 6)
            {
                Console.WriteLine("six");
            }
            else if (num1 == 7)
            {
                Console.WriteLine("seven");
            }
            else if (num1 == 8)
            {
                Console.WriteLine("eight");
            }
            else if (num1 == 9)
            {
                Console.WriteLine("nine");
            }

        }
    }
}
