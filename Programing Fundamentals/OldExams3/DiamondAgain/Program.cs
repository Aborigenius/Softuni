using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var width = 5 * N;
            var height = 3 * N + 2;

            var spaces = 3 * N; ;
            var left = N;

            Console.WriteLine("{0}{1}{0}", new string('.', left), new string('*', spaces));

            for (int i = 1; i < N; i++)
            {

                Console.Write("{0}*{1}*{0}", new string('.', left - 1), new string('.', spaces));
                Console.WriteLine();
                left--;
                spaces += 2;
            }
            //MiddleRow
            Console.WriteLine(new string('*', width));
            left = 1;
            spaces = width - 4;
            for (int bot = 1; bot <= N * 2; bot++)
            {
      
            
                Console.WriteLine("{0}*{1}*{0}", new string('.', left), new string('.', spaces));
                spaces-=2;
                left++;
                
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', left), new string('*', spaces));

        }
    }
}
