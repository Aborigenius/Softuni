using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeString
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, List<int>> serialized = new Dictionary<char, List<int>>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char @char = input[i];
                int index = i;

                if (!serialized.ContainsKey(input[i]))
                {
                    serialized[@char] = new List<int>();
                }
                serialized[@char].Add(index);
            }
            foreach (var item in serialized)
            {
                Console.Write($"{item.Key}:");
                List<int> indexes = item.Value;
                foreach (var index in indexes)
                {
                    if (index != indexes.Last())
                    {
                        Console.Write($"{index}/");
                    }
                    else
                    {
                        Console.Write(index);
                    }
                    
                }
                Console.WriteLine();
            }

        }
    }
}
