using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<string>>();
            List<string> participants = Console.ReadLine().Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries).ToList();
            string play = Console.ReadLine();

            while (play != "dawn")
            {
                string[] input = play.Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries);
                string participantName = input[0];
                string song = input[1];
                string award = input[2];

                if (participants.Any(p => p.Contains(participantName))
                    && songs.Any(s => s.Contains(song)))
                {
                    if (!result.ContainsKey(participantName))
                    {
                        result.Add(participantName, new List<string>());
                    }
                    if (!result[participantName].Contains(award))
                    {
                        result[participantName].Add(award);
                    }

                }
                play = Console.ReadLine();
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in result.OrderByDescending(a => a.Value.Count)
                    .ThenBy(name => name.Key.Length))
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                    foreach (var award in item.Value.OrderBy(award => award))
                    {
                        Console.WriteLine($"--{award}");
                    }

                }
            }
        }
    }
}
