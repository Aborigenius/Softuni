using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFun1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripDistanceinMiles = float.Parse(Console.ReadLine());
            var fuelTankLiters = float.Parse(Console.ReadLine());
            var milesInHeavyWinds = float.Parse(Console.ReadLine());

            var milesNonHeavy = tripDistanceinMiles - milesInHeavyWinds;
            var nonHeavyConsumption = milesNonHeavy * 25;
            var heavyConsumption = milesInHeavyWinds * (25 * 1.5);

            var totalFuelUsed = nonHeavyConsumption + heavyConsumption + ((nonHeavyConsumption + heavyConsumption) * 0.05);

            Console.WriteLine($"Fuel needed: {totalFuelUsed:f2}L");
            if (totalFuelUsed <= fuelTankLiters)
            {
                Console.WriteLine($"Enough with {Math.Abs(fuelTankLiters - totalFuelUsed):f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(totalFuelUsed - fuelTankLiters):f2}L more fuel.");
            }
        }
    }
}
