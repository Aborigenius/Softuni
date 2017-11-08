using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVSpeed1
{
    class Program
    {
        static void Main(string[] args)
        {
            double speedLimit = 120.00;
            Console.WriteLine("Enter starting time: (HH:mm:ss)");
            string entryTime = Console.ReadLine();
            DateTime entry = DateTime.ParseExact(entryTime, "HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter exit/current time: (HH:mm:ss)");
            string exitTime = Console.ReadLine();
            DateTime exit = DateTime.ParseExact(exitTime, "HH:mm:ss", CultureInfo.InvariantCulture);
//            exit.ToString("HH:mm:ss");
//            entry.ToString("HH:mm:ss");
            Console.WriteLine("Current Distance is (in kilometers)");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine($"Speed Limit is: {speedLimit}");

            TimeSpan timeInhours = exit.Subtract(entry);
            double time = timeInhours.TotalHours;
            Console.WriteLine($"Time in Hours is: {timeInhours}");

            double avgSpeed = distance / time;

            if (avgSpeed > speedLimit)
            {
                Console.WriteLine($"Hold on, you're {avgSpeed - speedLimit:f2}km above speed limit. Stop!");
            }
            else
            {
                Console.WriteLine($"Your current average speed is: {Math.Round(avgSpeed):f2}");
            }
        } 
    }
}
