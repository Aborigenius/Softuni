using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> campers =
              new Dictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] inputTokens = input.Split(' ');

                string name = inputTokens[0];
                string rvModel = inputTokens[1];
                int nights = int.Parse(inputTokens[2]);

                if (!campers.ContainsKey(name))
                {
                    campers[name] = new Dictionary<string, int>();
                }
                if (campers.ContainsKey(name))
                {
                    campers[name][rvModel] = nights;
                }
                input = Console.ReadLine();
            }
            foreach (var item in campers.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key.Length))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                int totalNights = 0;
                foreach (var camper in item.Value)
                {
                    totalNights += camper.Value;
                    Console.WriteLine("***{0}", camper.Key);
                    
                }
                Console.WriteLine($"Total stay: {totalNights} nights");
            }
        }
    }
}
/*Print all the people, ordered by the count of their campers.
 * If two people have an equal count of campers, order them by the length of their names in ascending order.
 * Print the campers for each person in order of receiving. 
 * */
