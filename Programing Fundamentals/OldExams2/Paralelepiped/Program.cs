using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var height = 4 * n + 4;
            var width = 3 * n + 1;

            //First Row
            Console.Write("{0}{1}{0}", ('+'), new string('~', n - 2));
            Console.Write(new string('.', 2 * n + 1));
            Console.WriteLine();
            #region TopPart
            for (int row = 0; row <= (height / 2) - 2; row++)
            {
                Console.Write("|");
                for (int col = 1; col <= row; col++)
                {
                    Console.Write('.');
                }
                Console.Write("{0}{1}{0}", ('\\'), new string('~', n - 2));
                Console.Write("{0}", new string('.', (width - n - 1) - row));
                Console.WriteLine();
            }
            #endregion
            #region BottomPart
            for (int row = 0; row <= (height / 2) - 2; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write('.');
                }
                Console.Write("{0}", ('\\'));
                Console.Write("{0}", new string('.', (width - n - 1) - row));
                Console.Write("{0}{1}{0}", ('|'), new string('~', n - 2));
                Console.WriteLine();
            }
            #endregion

            #region LastRow
            Console.Write(new string('.', 2 * n + 1));
            Console.Write("{0}{1}{0}", ('+'), new string('~', n - 2));
            Console.WriteLine();
            #endregion
        }
    }
}
// Да се отпечатат на конзолата 4 * n + 4 
//  +~~~+...........
//  |\~~~\..........
//  |.\~~~\.........
//  |..\~~~\........
//  |...\~~~\.......
//  |....\~~~\......
//  |.....\~~~\.....
//  |......\~~~\....
//  |.......\~~~\...
//  |........\~~~\..
//  |.........\~~~\.
//  |..........\~~~\
//  \..........|~~~|
//  .\.........|~~~|
//  ..\........|~~~|
//  ...\.......|~~~|
//  ....\......|~~~|
//  .....\.....|~~~|
//  ......\....|~~~|
//  .......\...|~~~|
//  ........\..|~~~|
//  .........\.|~~~|
//  ..........\|~~~|
//  ...........+~~~+