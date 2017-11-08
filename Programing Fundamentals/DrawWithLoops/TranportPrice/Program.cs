using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var time = Console.ReadLine().ToLower();

            double TransportTotal = 0;

            if (n >= 20 && n < 100)
                if (time == "day" || time == "night")
                {
                    {
                        TransportTotal = (n * 0.09);
                    }
                }
            if (n >= 100)
                if (time == "day" || time == "night")
                {
                    {
                        TransportTotal = (n * 0.06);
                    }
                }
            if (n < 20)
            {

                {
                    if (time == "day")
                    {
                        TransportTotal = (n * 0.79) + 0.70;
                    }
                    else
                    {
                        TransportTotal = (n * 0.90) + 0.70;
                    }

                }
            }
            Console.WriteLine(TransportTotal);
        }
    }
}
