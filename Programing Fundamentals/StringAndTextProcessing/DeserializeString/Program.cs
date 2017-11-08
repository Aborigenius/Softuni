using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, char> deserialized = new SortedDictionary<int, char>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(':');
                char @char = tokens[0][0];
                int[] numbers = tokens[1].Split('/').Select(int.Parse).ToArray();

                foreach (int index in numbers)
                {
                    deserialized[index] = @char;
                }
                input = Console.ReadLine();

            }

            Console.WriteLine(deserialized.Values.ToArray());
        }
    }
}
