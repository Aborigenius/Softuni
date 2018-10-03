using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < inputLines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (var item in input)
                {
                    periodicTable.Add(item);
                }
            }

            foreach (var element in periodicTable)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
