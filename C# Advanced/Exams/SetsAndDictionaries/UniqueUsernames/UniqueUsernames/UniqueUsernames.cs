using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < inputN; i++)
            {
                string input = Console.ReadLine();
                uniqueNames.Add(input);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
