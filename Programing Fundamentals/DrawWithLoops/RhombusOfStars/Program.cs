using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            #region TOP
            for (var row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                for (int col = 0; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            #endregion

            for (var row = n-1; row >= 1; row--)
            {
                Console.Write(new string(' ', n-row));
                for (int col = 0; col < row ; col++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }


        }
    }
}
