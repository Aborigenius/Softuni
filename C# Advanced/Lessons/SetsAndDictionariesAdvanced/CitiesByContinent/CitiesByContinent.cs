using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinent
{
    class CitiesByContinent
    {
        static void Main(string[] args)
        {
            int inputNums = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> cities = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < inputNums; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = inputData[0];
                string country = inputData[1];
                string capital = inputData[2];

                if (!cities.ContainsKey(continent))
                {
                    cities.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent][country] =  new List<string>();
                }
           
                    cities[continent][country].Add(capital);
            }

            foreach (var item in cities)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var capital in item.Value)
                {
                    Console.WriteLine($"{capital.Key} -> {String.Join(", ", capital.Value)}");
                }
            }
        }
    }
}
