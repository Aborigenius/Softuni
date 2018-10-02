using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            SortedSet<string> guestsList = new SortedSet<string>();

            string input = Console.ReadLine();

            while (input?.ToLower() != "party")
            {
                guestsList.Add(input);
                input = Console.ReadLine();
            }

            string newInput = Console.ReadLine();

            while (newInput?.ToLower() != "end")
            {
                guestsList.Remove(newInput);
                newInput = Console.ReadLine();
            }

            Console.WriteLine(guestsList.Count());
            foreach (var guest in guestsList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
