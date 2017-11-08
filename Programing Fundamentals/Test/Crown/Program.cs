using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int width = (2 * N) - 1;
            int height = (N / 2) + 4;

            int spaces = N-3;
            int middlesSpaces = 1;

            //FirstRow
            Console.WriteLine("@{0}@{0}@", new string(' ', N - 2));
            Console.WriteLine("**{0}*{0}**",new string (' ', spaces));

            for (int i = 0; i <= N/2-1; i++)
            {
                Console.Write("*{0}*{1}", new string('.', middlesSpaces), new string(' ', spaces-2));
                Console.Write('&');
                middlesSpaces++;
                if (spaces > 3)
                {
                    spaces -= 2;
                }
                
                Console.WriteLine();
            }
            Console.WriteLine();
            //           Console.WriteLine(new string('*', width));
            //           Console.WriteLine(new string('*', width));

        }
    }
}
