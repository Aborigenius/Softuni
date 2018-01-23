using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPerGreenLight = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();
            var carQueue = new Queue<string>();
            int passedCars = 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    var carThatCanPass = Math.Min(carQueue.Count,
                        carsPerGreenLight);
                    for (int cnt = 0; cnt < carThatCanPass; cnt++)
                    {
                        Console.WriteLine($"{carQueue.Dequeue()} passed!");
                        passedCars += 1;
                    }
                }
                else
                {
                    carQueue.Enqueue(input);
                }
            
                input = Console.ReadLine();
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
