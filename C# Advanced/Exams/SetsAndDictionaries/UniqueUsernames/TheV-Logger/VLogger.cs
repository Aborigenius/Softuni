using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class VLogger
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, SortedSet<string>>> vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string [] inputTokens = input.Split(" ");

                string user = inputTokens[0];
                string action = inputTokens[1];

                switch (action)
                {
                    case "joined":
                        if (!vloggers.ContainsKey(user))
                        {
                            vloggers.Add(user, new Dictionary<string, SortedSet<string>>());
                            vloggers[user].Add("following", new SortedSet<string>());
                            vloggers[user].Add("followers", new SortedSet<string>());
                        }
                        break;
                    case "followed":
                        string following = inputTokens[2];
                        Dictionary<string, SortedSet<string>> follow = new Dictionary<string, SortedSet<string>>();
                        if (vloggers.ContainsKey(following) && following != user && vloggers.ContainsKey(user))
                        {
                            vloggers[user]["following"].Add(following);
                            vloggers[following]["followers"].Add(user);
                        }
                       
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            var sortedVloggers = vloggers.OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count);

            int counter = 1;
            foreach (var item in sortedVloggers)
            {
                Console.WriteLine($"{counter++}. {item.Key} : {item.Value["followers"].Count} followers, " +
                    $"{item.Value["following"].Count} following");
             
                if (counter -1 == 1)
                {
                    foreach (var name in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {name}");
                    }
                }
        

            }
        }   
    }
}
