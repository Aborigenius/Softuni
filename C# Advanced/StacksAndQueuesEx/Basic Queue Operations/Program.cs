using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NSX = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int N = NSX[0];
            int S = NSX[1];
            int X = NSX[2];

            Queue<int> queue = new Queue<int>();

                Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(strNumber => queue.Enqueue(int.Parse(strNumber)));
            
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            bool isEmpty = !queue.Any();
            if (isEmpty == true)
            {
                Console.WriteLine("0");
                return;
            }
            foreach (var item in queue)
            {

                if (queue.Contains(X))
                {
                    Console.WriteLine("true");
                    return;
                }

                else
                {
                    Console.WriteLine(queue.Min());
                    return;
                }
            }
        }
    }
}
