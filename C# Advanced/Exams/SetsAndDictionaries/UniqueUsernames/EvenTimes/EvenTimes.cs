using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class EvenTimes
    {
        public static List<T> CreateList<T>(params T[] values)
        {
            return new List<T>(values);
        }
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            List<int> duplicates = new List<int>();
            for (int i = 0; i < inputLines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                duplicates.Add(input);
            }
            //Console.WriteLine( duplicates.GroupBy(n => n).Any(c => c.Count() > 1)); bool to check is there any duplicates

            var duplicateKeys = duplicates.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key);

            foreach (var item in duplicateKeys)
            {
                Console.WriteLine(item);
            }

        }
       
    }
 
}
