using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            string [] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                double parsNum = double.Parse(input[i]);

                if (counts.ContainsKey(parsNum))
                {
                    counts[parsNum]++;
                }
                else
                {
                    counts[parsNum] = 1;
                }
            }

            //Console.WriteLine(string.Join(" ", input));
            foreach (var item in counts.Keys)
            {
                Console.WriteLine($"{item} -> {counts[item]}");
            }
        }
    }
}
