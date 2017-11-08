using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsToProd = int.Parse(Console.ReadLine());
            var workersNymber = double.Parse(Console.ReadLine());
            var workingDays = double.Parse(Console.ReadLine());

            var totalHours = workersNymber * workingDays * 8;
            var cupsProduced = Math.Floor(totalHours / 5);

            if (cupsProduced > cupsToProd)
            {
                var total = (cupsProduced - cupsToProd) * 4.2;
                Console.WriteLine($"{total:f2} extra money");
            }
            else
            {
                var total = (cupsToProd - cupsProduced) * 4.2;
                Console.WriteLine($"Losses: {total:f2}");
            }
        }
    }
}
