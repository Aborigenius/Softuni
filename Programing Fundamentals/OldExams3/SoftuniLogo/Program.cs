using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var height = 4 * n - 2;
            var width = 12 * n - 5;
            var spaces = 1;
            var leftDots = width / 2;
            var rightDots = width / 2;
            #region TopPart
            // Console.WriteLine("{0}#{0}", new string('.', width / 2));
            for (int row = 0; row < 2 * n - 1; row++)
            {

                Console.WriteLine("{0}{1}{2}", new string('.', leftDots), new string('#', spaces), new string('.', rightDots));
                spaces = spaces + 6;
                leftDots = leftDots - 3;
                rightDots -= 3;
            }
            #endregion
            //MiddleRow
            Console.WriteLine("{0}", new string('#', width));
            #region Middle
            spaces = width - 6;
            leftDots = 3;
            for (int row = 0; row < n - 2; row++)

            {
                rightDots = leftDots;
                Console.Write("|{0}{1}{2}", new string('.', leftDots-1), new string('#', spaces), new string('.', rightDots));
                spaces -= 6;
                leftDots += 3;
               
                Console.WriteLine();
                rightDots = rightDots + 3;
            }
            #endregion
            for (int i = 0; i < n-1; i++)
            {
                rightDots = leftDots;
               Console.WriteLine("|{0}{1}{2}", new string('.', leftDots-1), new string('#', spaces), new string('.', rightDots));
            }
            Console.WriteLine("@{0}{1}{2}", new string('.', leftDots - 1), new string('#', spaces), new string('.', rightDots));
        }
    }
}