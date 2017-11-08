using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var width = 4 * N + 3;
            var spaces = 2 * N - 1;
            var left = N;
            var bottom = width - 9;

            //FirstRow
            Console.WriteLine("{0}{1}{0}", new string('.', N + 1), new string('_', 2 * N + 1));

            #region Top

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0}{1}{2}\\\\{0}", new string('.', left), new string('/', 2), new string('_', spaces));

                spaces += 2;
                left--;
                Console.WriteLine();
            }

            #endregion
            #region Middle

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', bottom / 2));


            #endregion

            #region Bottom

            spaces = 4 * N - 1;
            left = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', left),new string('_', spaces));
                spaces -= 2;
                left++;
            }

            #endregion
        }
    }
}
