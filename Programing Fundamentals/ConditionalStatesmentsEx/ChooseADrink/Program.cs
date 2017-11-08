using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                double totalprice = quantity * 0.70;
                Console.WriteLine($"The {profession} has to pay {totalprice:f2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                double totalprice = quantity * 1.00;
                Console.WriteLine($"The {profession} has to pay {totalprice:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                double totalprice = quantity * 1.70;
                Console.WriteLine($"The {profession} has to pay {totalprice:f2}.");
            }
            else
            {
                double totalprice = quantity * 1.20;
                Console.WriteLine($"The {profession} has to pay {totalprice:f2}.");
            }
        }
    }
}
