using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split(' ');
            decimal[] zones = Console.ReadLine().Split(' ').Where(t => t.Length > 0)
                .Select(n => decimal.Parse(n) * -1).ToArray();
            int[] fuelPoints = Console.ReadLine().Split(' ')
                .Where(t => t.Length > 0).Select(int.Parse).Distinct().ToArray();

            foreach (var i in fuelPoints)
            {
                if (i >= 0 && i < zones.Length)
                {
                    zones[i] *= -1;
                }
            }
            foreach (var driver in drivers)
            {
                decimal initialFuelDriver = (decimal)driver[0];
                int index = 0;
                foreach (var check in zones)
                {
                    initialFuelDriver += check;
                    if (initialFuelDriver <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {index}");
                        break;
                    }
                    index++;
                }
                if (initialFuelDriver > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {initialFuelDriver:f2}");
                }
            
            }
        }
    }
}