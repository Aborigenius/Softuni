using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string textToCount = Console.ReadLine();

            SortedDictionary<char, int> characterCount = new SortedDictionary<char, int>();

            foreach (var character in textToCount)
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }

            foreach (var item in characterCount)
            {
                Console.WriteLine($"{item.Key}: {String.Join("", item.Value)} time/s");
            }
        }
    }
}
