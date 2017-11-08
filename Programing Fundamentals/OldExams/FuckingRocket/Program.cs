using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingRocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = n * 3;
            var center = (width - 2) / 2;
            var spaces = 0;

            #region Top
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', center), new string(' ', spaces));
                center--;
                spaces += 2;
            }
            #endregion


            center++;
            Console.WriteLine("{0}{1}{0}", new string('.', center), new string('*', spaces));
            spaces -= 2;
            #region Body
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', center), new string(' ', spaces));
            }
            #endregion
            #region Bottom


            #endregion

        }
    }
}
