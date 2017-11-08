using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var midMid = 2 * N;
            var leftBot = 2 * N + 2;
            var bottom = N;
            var leftM = 1;
            var middle1 = (2*N) - 2;
            var middle2 = 2;
            //TopRow
            Console.WriteLine("{0}{1}{0}{1}{0}", new string('#', 2), new string('.', 2 * N));

            #region Top
            for (int i =1 ; i < N; i++)
            {


                    Console.Write("#{0}#{1}#", new string ('~', i), new string('.', middle1));
                Console.Write("{0}#{1}",  new string('.', middle2), new string('.', middle1));
                Console.WriteLine("#{0}#", new string('~', i));
                middle1 -= 2;
                middle2 += 2;
               
            }

            #endregion


            #region Middle 
            for (int row = 1; row <= N; row++)
            {
               
                Console.Write("{0}", new string('.', leftM));
                for (int i = N; i >= N; i--)
                {
                    Console.Write("#{0}#{1}#{0}#{2}", new string('~', bottom), new string('.', midMid), new string('.', leftM));
                    
                }
                Console.WriteLine();
                bottom--;
                leftM += 2;
                midMid -= 2;
            }


            #endregion
            Console.WriteLine("{0}{1}{0}", new string('.', 2*N+1), new string('#', 4));

            #region Bottom
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', leftBot), new string('#', 2));
            }
            #endregion
        }
    }
}
