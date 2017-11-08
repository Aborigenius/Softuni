using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFromN
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                
                for (var c = 0; c < n; c++)
                {
                    Console.Write(("* "));
                }
                Console.WriteLine();
            }
        }
    }
}
