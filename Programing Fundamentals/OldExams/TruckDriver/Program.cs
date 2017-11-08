using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonth = double.Parse(Console.ReadLine());

            if (season == "Spring")
            {
                if (kmPerMonth <= 5000)
                {

                }

            }
            if (season == "Summer" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {

                }
            }

            if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {

                }
            }

        }
    }
}
