using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatIsTheMother
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); //Define Variable

            if (n >= 2 && n <= 100)
            {
                Console.WriteLine(new string('*', n));
                    for (int i=0; i <= n-2; i++)
                    Console.WriteLine("*" + new string (' ', n-2) + "*");
                Console.WriteLine(new string('*', n));
                
            }
                else
                {
                Console.WriteLine("Not Between 2 1nd 100!");
                }
        }
    }
}
