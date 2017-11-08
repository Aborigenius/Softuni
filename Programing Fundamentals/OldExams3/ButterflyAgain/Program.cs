using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterflyAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var width = 2 * N - 1;
            var height = 2 * (N - 2) + 1;
            var left = N - 1;
            var spaces = 1;

            for (int i = 0; i < N - 2; i++)
            {
                if (i % 2 == 0)
                {

                    Console.Write("{0}\\{1}/{0}", new string('*', N - 2), new string(' ', spaces));

                }
                else
                {
                    Console.Write("{0}\\{1}/{0}", new string('-', N - 2), new string(' ', spaces));
                }
                Console.WriteLine();

            }
            Console.WriteLine("{0}{1}{0}", new string(' ', left), new string('@', spaces));
            for (int i = 0; i < N - 2; i++)
            {
                if (i % 2 == 0)
                {

                    Console.Write("{0}/{1}\\{0}", new string('*', N - 2), new string(' ', spaces));

                }
                else
                {
                    Console.Write("{0}/{1}\\{0}", new string('-', N - 2), new string(' ', spaces));
                }
                Console.WriteLine();

            }

        }
    }
}
