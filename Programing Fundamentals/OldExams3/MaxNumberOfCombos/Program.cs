using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberOfCombos
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int maxCombos = int.Parse(Console.ReadLine());

            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                for (int f = intervalStart; f <= intervalEnd; f++)
                {

                    Console.Write($"<{i}-{f}>");

                    maxCombos--;
                    if (maxCombos == 0)
                    {

                        return;
                    }
                }

            }

        }
    }
}
