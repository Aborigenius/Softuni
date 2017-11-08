using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            double totalPrice = 0;
            string hall = " ";

            if (groupsize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            else if (groupsize <= 50)
            {
               hall = "Small Hall";
                if (package == "normal")
                {
                    totalPrice = ((2500 + 500) * 0.95) / groupsize;
                }
                else if (package == "gold")
                {
                    totalPrice = ((2500 + 750) * 0.90) / groupsize;
                }
                else if (package == "platinum")
                {
                    totalPrice = ((2500 + 1000) * 0.85) / groupsize;
                }
            }
            else if (groupsize > 50 && groupsize <= 100)
            {
                hall = "Terrace";
                if (package == "normal")
                {
                    totalPrice = ((5000 + 500) * 0.95) / groupsize;
                }
                else if (package == "gold")
                {
                    totalPrice = ((5000 + 750) * 0.90) / groupsize;
                }
                else if (package == "platinum")
                {
                    totalPrice = ((5000 + 1000) * 0.85) / groupsize;
                }
            }
            else if (groupsize > 100 && groupsize <= 120)
            {
                hall = "Great Hall";
                if (package == "normal")
                {
                    totalPrice = ((7500 + 500) * 0.95) / groupsize;
                }
                else if (package == "gold")
                {
                    totalPrice = ((7500 + 750) * 0.90) / groupsize;
                }
                else if (package == "platinum")
                {
                    totalPrice = ((7500 + 1000) * 0.85) / groupsize;
                }

            }
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {totalPrice:f2}$");
        }
    }
}
