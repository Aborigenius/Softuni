using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondStatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (profession == "Athlete")
            {
                totalPrice = quantity * 0.7;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                totalPrice = quantity * 1.00;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                totalPrice = quantity * 1.70;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else
            {
                totalPrice = quantity * 1.20;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
        }
    }
}
