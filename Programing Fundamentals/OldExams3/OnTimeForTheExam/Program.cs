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
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            var endtime = Convert.ToDateTime($"{arrivalHour}:{arrivalMinute}");
            var starttime = Convert.ToDateTime($"{examHour}:{examMinute}");



            TimeSpan difference = starttime - endtime;
           

            int totalMinutes = difference.Minutes + difference.Hours * 60;
            Console.WriteLine(totalMinutes);

            if (arrivalHour == examHour && arrivalMinute == examMinute)
            {
                Console.WriteLine("On time");
            }
            if (totalMinutes <= 30  )
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{difference.Minutes} minutes before the start");
            }
            if (totalMinutes > 30  )
            {
                Console.WriteLine("Early");
                if (totalMinutes >= 60)
                {

                    Console.WriteLine($"{difference.Hours}:{difference.Minutes:x.2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{totalMinutes} minutes before the start");
                }
            }
            if (totalMinutes < 0)
            {
                Console.WriteLine("Late");
                if (totalMinutes <= -60)
                {
                    Console.WriteLine($"{Math.Abs(difference.Hours)}:{Math.Abs(difference.Minutes):f2} hours before the start");

                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference.Minutes)} minutes after the start");

                }

            }


        }
    }
}
