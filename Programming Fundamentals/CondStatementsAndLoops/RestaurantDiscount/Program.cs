using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double totalPrice = 0;
            double perPerson = 0;
            string hall = " ";
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            else if (groupSize <= 50)
            {
                hall = "Small Hall";
                if (package == "Normal")
                {
                    totalPrice = 3000 * 0.95;
                    perPerson = totalPrice / groupSize;
                }
                else if (package == "Gold")
                {
                    totalPrice = 3250 * 0.90;
                    perPerson = totalPrice / groupSize;
                }
                else if (package == "Platinum")
                {
                    totalPrice = 3500 * 0.85;
                    perPerson = totalPrice / groupSize;
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                if (package == "Normal")
                {
                    totalPrice = 5500 * 0.95;
                    perPerson = totalPrice / groupSize;
                }
                else if (package == "Gold")
                {
                    totalPrice = 5750 * 0.90;
                    perPerson = totalPrice / groupSize;
                }
                else if (package == "Platinum")
                {
                    totalPrice = 6000 * 0.85;
                    perPerson = totalPrice / groupSize;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                if (package == "Normal")
                {
                    totalPrice = 8000 * 0.95;
                    perPerson = totalPrice / groupSize;
                }
                else if (package == "Gold")
                {
                    totalPrice = 8250 * 0.90;
                    perPerson = totalPrice / groupSize;
                }
                else if (package == "Platinum")
                {
                    totalPrice = 8500 * 0.85;
                    perPerson = totalPrice / groupSize;
                }
            }
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {perPerson:f2}$");
        }
    }
}
