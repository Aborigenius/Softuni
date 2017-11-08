using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomTheSleepyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacationDays = int.Parse(Console.ReadLine());

            var yearDays = 365;

            var workingDays = yearDays - vacationDays;

            var playtimeWorkingDays = workingDays * 63;
            var playtimeVacationDays = vacationDays * 127;

            var totalPlaytime = playtimeVacationDays + playtimeWorkingDays;
            var playtimeLeft = Math.Abs(30000 - totalPlaytime);

            var playtimeInHours = TimeSpan.FromMinutes(playtimeLeft);
            var hours = (int)playtimeInHours.TotalHours;
            var minutes = playtimeInHours.Minutes;
            

            if (totalPlaytime < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");

            }
        }
    }
}
