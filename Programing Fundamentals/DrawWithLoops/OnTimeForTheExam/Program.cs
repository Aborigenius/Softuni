using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());

            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinutes = int.Parse(Console.ReadLine());

            if (examHour == arrivalHour)
            {
                if (examMinutes == arrivalMinutes || (arrivalMinutes - examMinutes) <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{arrivalMinutes - examMinutes} minutes before the start");
                }

            }

        }
    }
}
