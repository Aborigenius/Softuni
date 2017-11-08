using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAxe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var width = 5 * N;
            var spaces = 0;
            var left = 3 * N;
            var right = 2 * N - 2;

            //FirstRow
            Console.WriteLine("{0}**{1}", new string('-', 3 * N), new string('-', right));
            #region Top
            for (int i = 0; i < N - 1; i++)
            {
                Console.Write("{0}*{1}*", new string('-', 3 * N), new string('-', spaces+1));
                Console.Write(new string('-', right-1));
                spaces++;
                right--;
                Console.WriteLine();
            }

            #endregion
            #region Middle/Handle
            for (int i = 0; i < N / 2; i++)
            {
                Console.Write("{0}*{1}*", new string('*', 3 * N), new string('-', spaces));
                Console.Write(new string('-', right));
                Console.WriteLine();
            }
            #endregion
            for (int i = 0; i < N / 2-1; i++)
            {
                Console.Write("{0}*{1}*", new string ('-', left), new string ('-', spaces));
                Console.Write(new string('-', right));
                Console.WriteLine();
                spaces+=2;
                left--;
                right--;
            }
            Console.Write("{0}*{1}*", new string('-', left), new string('*', spaces));
            Console.WriteLine(new string('-', right));
        }
    }
}
