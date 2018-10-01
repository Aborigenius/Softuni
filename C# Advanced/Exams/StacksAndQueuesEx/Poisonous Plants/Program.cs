using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfPlants = int.Parse(Console.ReadLine());
            int[] plantsPoison = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Take(NumberOfPlants).ToArray();
            var daysCounter = new int[NumberOfPlants];
            Stack<int> plants = new Stack<int>();
     
            plants.Push(0);
            for (int i = 1; i < plantsPoison.Length; i++)
            {
                int maxDays = 0;

                while (plants.Count > 0 && plantsPoison[plants.Peek()] >= plantsPoison[i])
                {
                    maxDays = Math.Max(maxDays, daysCounter[plants.Pop()]);
                }

                if (plants.Count > 0)
                {
                    daysCounter[i] = maxDays + 1;
                }

                plants.Push(i);
            }

            Console.WriteLine(daysCounter.Max());
        }
    }
}
