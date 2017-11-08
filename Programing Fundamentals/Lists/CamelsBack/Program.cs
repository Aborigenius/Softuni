using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> start = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBack = int.Parse(Console.ReadLine());
            int rounds = 0;
            int lenght = start.Count;
            for (int i = 0; i <= camelBack; i++)
            {
                if (lenght != camelBack)
                {
                    start.RemoveAt(start.Count - 1);
                    start.RemoveAt(0);
                    rounds++;
                    lenght -= 2;
                }

            }
            List<string> result = new List<string>();
            foreach (var item in start)
            {
                result.Add(item.ToString());
            }

            if (rounds != 0)
            {
                Console.WriteLine($"{rounds} rounds");
                Console.Write("remaining: ");
                
            }
            else
            {
                Console.Write("already stable: ");
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
