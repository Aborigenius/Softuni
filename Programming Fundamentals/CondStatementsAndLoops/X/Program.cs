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
            int n = int.Parse(Console.ReadLine());
             int height = n;
            int spaces = 1;
            //First Row
            Console.WriteLine("x{0}x", new string(' ', n-2));

            for (int i = 0; i < n/2; i++)
            {
                Console.Write("{0}x{0}", new string (' ', spaces));

                Console.WriteLine();
                spaces++;
            }

        }
    }
}
