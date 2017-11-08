using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double dollarsPerDay = double.Parse(Console.ReadLine());
            double dollarsToLeva = double.Parse(Console.ReadLine());

            double monthlySalary = workingDays * dollarsPerDay;
            double yearlySalary = (monthlySalary * 12) + (monthlySalary * 2.5);
            double salaryAfterTax = yearlySalary - (yearlySalary * 0.25);
            double dailyAfterTax = salaryAfterTax / 365;
            double dailyFinalLV = dailyAfterTax * dollarsToLeva;

            Console.WriteLine($"{dailyFinalLV:f2}");
        }
    }
}
