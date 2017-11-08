using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            var year = 2017;

            DateTime inputDate = new DateTime(year, month, day);
            DateTime afterFive = inputDate.AddDays(5);
            Console.WriteLine(afterFive.ToString("d.MM"));
        }
    }
}
