using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", new string('*', n));
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("*{0}*", new string(' ', n -2));
                Console.WriteLine();

            }
            Console.WriteLine("{0}", new string('*', n));
        }
    }
}
