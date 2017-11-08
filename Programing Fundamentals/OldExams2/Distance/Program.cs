using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialSpeedKMH = double.Parse(Console.ReadLine());
            var firstTimeInMinutes = double.Parse(Console.ReadLine());
            var secondTimeInMinutes = double.Parse(Console.ReadLine());
            var thirdTimeInMinutes = double.Parse(Console.ReadLine());

            double firstInHours = firstTimeInMinutes / 60;
            double firstDistance = firstInHours * initialSpeedKMH;

            double secondInHours = secondTimeInMinutes / 60;
            double secondDistance = ((initialSpeedKMH * 10 / 100 + initialSpeedKMH) * secondInHours);
            double secondSpeed = (initialSpeedKMH * 10 / 100 + initialSpeedKMH);

            double thirdInHours = thirdTimeInMinutes / 60;
            double thirdSpeed = (secondSpeed - (secondSpeed * 5 / 100));
            double thirdDistance = (thirdSpeed * thirdInHours);

            var totalDistance = thirdDistance + secondDistance + firstDistance;

            Console.WriteLine($"{totalDistance:F2}");
        }
    }
}
