using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
           

            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < inputLines; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];
                string[] sameColorClothes = input[1].Split(",");
                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                foreach (var cloth in sameColorClothes)
                {
                    Dictionary<string, int> sameColor = clothes[color];
                    if (!sameColor.ContainsKey(cloth))
                    {
                        sameColor.Add(cloth, 0);
                    }

                    sameColor[cloth]++;
                }
     
            }

            string[] findWhat = Console.ReadLine().Split(" ");

            foreach (var item in clothes)
            {
                string color = item.Key;

                Console.WriteLine($"{color} clothes:");
                foreach (var cl in item.Value)
                {
                    string clothName = cl.Key;
                    int times = cl.Value;

                    Console.Write($"* {clothName} - {times}");
                    if (findWhat[0] == color && findWhat[1] == clothName)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
