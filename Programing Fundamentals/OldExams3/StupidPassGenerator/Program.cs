using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPassGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int letter = int.Parse(Console.ReadLine());

            for (var d1 = 1; d1 <= number; d1++)
                for (var d2 = 1; d2 <= number; d2++)
                    for (var l1 = 'a'; l1 < 'a' + letter; l1++)
                        for (var l2 = 'a'; l2 < 'a' + letter; l2++)
                            for (var d3 = Math.Max(d1, d2) + 1; d3 <= number; d3++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",
                                    d1, d2, l1, l2, d3);
                            }
            Console.WriteLine();
        }
    }
}