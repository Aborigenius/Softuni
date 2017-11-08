using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerPong
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> pong =
                new Dictionary<string, Dictionary<string, int>>();

            while (input != "stop the game")
            {
                string[] inputTokens = input.Split('|');

                string name = inputTokens[0];
                string team = inputTokens[1];
                int points = int.Parse(inputTokens[2]);

                if (!pong.ContainsKey(team))
                {
                    pong[team] = new Dictionary<string, int>();
                }
                if (pong[team].Values.Count == 3)
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    pong[team][name] = points;
                }
                input = Console.ReadLine();
            }
            int some = 0;
            //           int TeamSum = pong.Values.Sum(points => points.Values.Sum());
            foreach (var item in pong.Where(players => players.Value.Count == 3)
                .OrderByDescending((x => x.Value.Values.Sum())))
            {
                some++;
                Console.WriteLine($"{some}. {item.Key}; Players:");
                
                foreach (var player in item.Value.OrderByDescending(points => 
                points.Value))
                {
                    Console.WriteLine($"###{player.Key}: {player.Value}");
                }
                
            }
        }
    }
}
