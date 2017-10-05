using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TravvelingWithLightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal lightYearKM = 9450000000000M;
            decimal lightSpeed = 300000M;

            decimal totalInSeconds = (lightYearKM / lightSpeed) * lightYears;

            TimeSpan calc = TimeSpan.FromSeconds((double)totalInSeconds);
            string result = string.Format("{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
            calc.Days / 7,
            calc.Days % 7,
            calc.Hours,
            calc.Minutes,
            calc.Seconds);

            Console.WriteLine(result);

        }
    }
}
//Assume that the speed of light == 300 000 km / second
//Assume that 1 light year == 9 450 000 000 000 km.