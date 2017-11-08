using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int lrspaces = 0;
            int middleSpaces = N-2;

            for (int i = 0; i < N/2; i++)
            {
                Console.Write("{0}x{1}x{0}", new string(' ', lrspaces), new string(' ', middleSpaces));
                lrspaces++;
                middleSpaces -= 2;
                Console.WriteLine();
            }
            lrspaces = N/2;
            middleSpaces = 1;
            Console.WriteLine("{0}x{0}", new string(' ', lrspaces));
            for (int i = 0; i < N/2; i++)
            {
                lrspaces--;
                Console.Write("{0}x{1}x{0}",new string (' ', lrspaces), new string (' ', middleSpaces));
                Console.WriteLine();
                middleSpaces += 2;
            }
        }
    }
}
