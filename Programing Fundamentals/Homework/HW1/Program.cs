using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hours = Console.ReadLine();
            string minutes = Console.ReadLine();
            string hm = hours + ':' + minutes;

            var time = Convert.ToDateTime(hm);
            string inThirty = time.AddMinutes(30).ToString("H:mm");

            Console.WriteLine(inThirty);
        }
    }
}
