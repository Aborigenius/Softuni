using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var events = new Dictionary<string, Dictionary<string, List<string>>>();
            while (input != "Time for Code")
            {
                string[] inputs = input.Split(new string[] {" " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string id = inputs[0];
                string eve = inputs[1];
                string eventName = eve.Substring(1);
                if (eve[0] != '#')
                {
                    goto Enter;
                }
                if (!events.ContainsKey(id))
                {
                    events.Add(id, new Dictionary<string, List<string>>());
                    events[id].Add(eventName, new List<string>());
                }
                if (!events[id].ContainsKey(eventName))
                {
                    goto Enter;
                }
                if (events.ContainsKey(id) && events[id].ContainsKey(eventName))
                {
                    for (int i = 2; i < inputs.Length; i++)
                    {
                        string participant = inputs[i];
                        if (!events[id][eventName].Contains(participant) && participant[0] == '@')
                        {
                            events[id][eventName].Add(participant);
                        }
                    }
                }
                Enter:
                input = Console.ReadLine();
            }
            foreach (var item in events
                .OrderByDescending(x => x.Value.Values.Sum(p => p.Count))
                .ThenBy(x => x.Key))
                
            
            {
                Dictionary<string, List<string>> result = item.Value;

        
                foreach (var v in result)
                {
                    string eve = v.Key;
                   
                    Console.WriteLine($"{eve} - {v.Value.Count}");
                    foreach (var p in v.Value.OrderBy(n => n))
                    {
                        Console.WriteLine(p);
                    }
                }
            }
        }
    }
}
// foreach (var res in eventList.OrderByDescending(x => x.Value.Values.Sum(p => p.Count)))