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

            var width = 3 * n;
            var middle = 0;
            var left = width / 2;
            var bottom = n / 2;
            #region Top
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}/{1}\\{0}", new string('.', left - 1), new string(' ', middle));

                Console.WriteLine();
                left--;
                middle += 2;
            }
            #endregion
            //Separator
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 2));
            #region Middle
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', n * 2 -2));
            }
            #endregion
            #region Bottom
            var kurac = n * 2 - 2;
            for (int i = 0; i < n/2; i++)
            {
                
                Console.WriteLine("{0}/{1}\\{0}", new string('.', bottom), new string('*', kurac));
                bottom--;
                kurac += 2;
            }
            #endregion

        }
    }
}
