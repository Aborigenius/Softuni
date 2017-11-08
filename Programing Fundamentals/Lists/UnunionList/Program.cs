using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primal = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int N = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            for (int i = 0; i < N; i++)
            {
                List<int> toProcess = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                foreach (var item in toProcess)
                {
                    if (!primal.Contains(item))
                    {
                        primal.Add(item);
                    }
                    else
                    {
                        primal.RemoveAll(f => f == item);
                    }
                }

            }
            primal.Sort();
            for (int i = 0; i < primal.Count; i++)
            {
                Console.Write(primal[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
