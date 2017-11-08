using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());


            for (int row = 1; row <= N; row++)
            {
                Console.Write(new string(' ', N - 1));
                Console.Write('*');

                for (int col = 0; col < row-1; col++)
                {
                    Console.Write("_*");
                }
                Console.WriteLine();
            }
          
        }
    }
}
