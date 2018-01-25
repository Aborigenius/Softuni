using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsNum = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < pumpsNum; i++)
            {
                int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                queue.Enqueue(input);
            }
            for (int start = 0; start < pumpsNum - 1; start++)
            {
                int fuel = 0;
                bool isFuelEnough = true;

                for (int pumpsPassed = 0; pumpsPassed < pumpsNum; pumpsPassed++)
                {
                    var currentPump = queue.Dequeue();
                    int pumpFuel = currentPump[0];
                    int nextPumpDistance = currentPump[1];

                    queue.Enqueue(currentPump);

                    fuel += pumpFuel - nextPumpDistance;

                    if (fuel < 0)
                    {
                        start += pumpsPassed;
                        isFuelEnough = false;
                        break;
                    }
                }
                if (isFuelEnough == true)
                {
                    Console.WriteLine(start);
                    Environment.Exit(0);
                }
            }

        }
    }
}
