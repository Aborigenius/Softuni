using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            int[] setsLegnths = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int setOneLenght = setsLegnths[0];
            int setTwoLenght = setsLegnths[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < setOneLenght; i++)
            {
                int input = int.Parse(Console.ReadLine());
                set1.Add(input);
            }
            for (int i = 0; i < setTwoLenght; i++)
            {
                int input = int.Parse(Console.ReadLine());
                set2.Add(input);
            }

            HashSet<int> resultSet = new HashSet<int>();
            if (set1.Contains)
            {

            }
        }
    }
}
