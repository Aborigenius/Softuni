using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < inputNumber; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        List<T> CreateList<T>(params T[] values)
        {
            return new List<T>(values);
        }
    }

}
