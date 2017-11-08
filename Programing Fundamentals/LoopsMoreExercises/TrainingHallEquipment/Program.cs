using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItemsToBuy = int.Parse(Console.ReadLine());
            double subtotal = 0;

            for (int i = 0; i < numberOfItemsToBuy; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount == 1 )
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }

                subtotal += (itemPrice * itemCount);
            }
            double total = Math.Abs(budget - subtotal);
            Console.WriteLine($"Subtotal: ${subtotal:f2}");
            if (budget >= subtotal)
            {
                Console.WriteLine($"Money left: ${total:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${total:f2} more.");
            }
           
        }
    }
}
