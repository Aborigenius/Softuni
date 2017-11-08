using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var height = 2 * n + 1;
            var width = 2 * n + 1;
            var spaces = width - 4;
            var center = n;
            var right = width / 2;

            //FirstRow
            Console.WriteLine(new string('*', width));
            Console.WriteLine("{0}*{1}*{0}", new string('.', 1), new string(' ', spaces));

            for (int row = 2; row < n; row++)
            {
                Console.Write(new string('.', row));
                Console.Write(new string('*', 1));

                for (int i = n; i > n - 2; i--)
                    if (i % 2 == 0)
                    {

                    }
                    else
                    {
                        Console.Write("{0}", new string('@', spaces - 2));
                        spaces -= 2;
                    }

                Console.Write(new string('*', 1));
                Console.Write(new string('.', row));
                Console.WriteLine();

            }
       
                Console.WriteLine("{0}*{0}", new string ('.', right));

            //BottomPart

            spaces = 0;
            for (int row = 0; row < n -2; row++)
            {
                
                Console.Write("{0}{1}{2}@{2}{1}{0}", new string('.', right - 1), '*', new string (' ', spaces));
                Console.WriteLine();
                right--;
                spaces++;
            }
            
            //LastRow
            for (int row = 0; row < 1; row++)
            {
                spaces = width - 4;
                Console.Write("{0}*{1}*{0}", '.', new string('@', spaces));
                Console.WriteLine();

            }
            Console.WriteLine(new string('*', width));

        }

    }
}
