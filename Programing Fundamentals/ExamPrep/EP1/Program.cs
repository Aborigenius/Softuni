using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Time = Console.ReadLine() ;
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int secondsPerStep = int.Parse(Console.ReadLine()) % 86400;

            var startTime = Convert.ToDateTime(Time);
            startTime = startTime.AddSeconds(steps * secondsPerStep);
            var arrivalTime = startTime.ToString("HH:mm:ss");

            Console.WriteLine($"Time Arrival: {arrivalTime}");
        }
    }
}
/* remove days  (% 86400 = i day in seconds), because they will do it in judge;
  DateTime myDateTime = DateTime.Parse("24 May 2009 02:19:00");

myDateTime = myDateTime + new TimeSpan(1, 1, 1);
myDateTime = myDateTime - new TimeSpan(1, 1, 1);
myDateTime += new TimeSpan(1, 1, 1);
myDateTime -= new TimeSpan(1, 1, 1);

Furthermore, you can use a set of "Add" methods
myDateTime = myDateTime.AddYears(1);                
myDateTime = myDateTime.AddMonths(1);              
myDateTime = myDateTime.AddDays(1);             
myDateTime = myDateTime.AddHours(1);               
myDateTime = myDateTime.AddMinutes(1);            
myDateTime = myDateTime.AddSeconds(1);           
myDateTime = myDateTime.AddMilliseconds(1);       
myDateTime = myDateTime.AddTicks(1); 
*/