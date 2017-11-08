using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] search = Console.ReadLine().Split(' ');

            string searchLetter = search[0];
            int occurence = int.Parse(search[1]);
            List<int> foundindexes = new List<int>();

            for (int i = text.IndexOf(searchLetter); i > -1; i = text.IndexOf(searchLetter, i + 1))
            {
                foundindexes.Add(i);
            }

            if (foundindexes.Count >= occurence)
            {
                for (int k = 0; k < foundindexes.Count; k++)
                {
                    if (k == occurence - 1)
                    {
                        Console.WriteLine(foundindexes[k]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }



        }

    }
}

