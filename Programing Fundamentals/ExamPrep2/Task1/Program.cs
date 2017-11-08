using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            long marathonDays = long.Parse(Console.ReadLine());
            long runnersSigned = long.Parse(Console.ReadLine());
            long averageLaps = long.Parse(Console.ReadLine());
            long trackLenght = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKM = decimal.Parse(Console.ReadLine());

            long trackTotalCapacity = trackCapacity * marathonDays;
           
            if (trackTotalCapacity <= runnersSigned)
            {
                runnersSigned = trackTotalCapacity;
            }

            long totalMeters = runnersSigned * (averageLaps * trackLenght);
            long totalKM = (long)totalMeters / 1000;


                decimal moneyRaised = totalKM * moneyPerKM;
                Console.WriteLine($"Money raised: {moneyRaised:F2}");
            
            
        }
    }
}
