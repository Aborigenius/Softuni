using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatGardener
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegiesPerKilo = double.Parse(Console.ReadLine());
            double fruitsPerKilo = double.Parse(Console.ReadLine());
            int vegiesInKGtotal = int.Parse(Console.ReadLine());
            int fruitsInKGTotal = int.Parse(Console.ReadLine());

            var euro = 1.94;

            var vegetablesTotal = vegiesPerKilo * vegiesInKGtotal;
            var fruitsTotal = fruitsPerKilo * fruitsInKGTotal;
            var final = (vegetablesTotal + fruitsTotal) / euro;

            Console.WriteLine(final);


        }
    }
}
