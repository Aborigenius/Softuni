using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyBills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            var internet = 15.00;
            var water = 20.00;
            var electricityTotal = 0.00;
            var others = 0.00;
            for (int i = 0; i < months; i++)
            {
                var electricytyBill = double.Parse(Console.ReadLine());
                electricityTotal += electricytyBill;
                others += (electricytyBill + water + internet) * 1.20;

            }

            var internetTotal = internet * months;
            var waterTotal = water * months;


            var allTotal = internetTotal + waterTotal + electricityTotal + others;
            var Average = allTotal / months;

            Console.WriteLine($"Electricity: {electricityTotal:F2} lv");
            Console.WriteLine($"Water: {months*water:F2} lv");
            Console.WriteLine($"Internet: {internet*months:F2} lv");
            Console.WriteLine($"Other: {others:F2} lv");
            Console.WriteLine($"Average: {Average:F2} lv");


        }
    }
}
