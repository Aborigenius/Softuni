using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionariesAdvanced
{
    class SetsAndDictionariesAdvanced
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            Dictionary<double, int> countNumbers = new Dictionary<double, int>();
            foreach (var num in inputNumbers)
            {
                if (countNumbers.ContainsKey(num))
                {
                    countNumbers[num]++;
                }
                else
                {
                    countNumbers.Add(num, 1);
                }
            }

            foreach (var item in countNumbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
