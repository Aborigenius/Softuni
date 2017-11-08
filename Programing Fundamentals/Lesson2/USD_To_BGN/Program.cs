using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_To_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var howmuch = double.Parse(Console.ReadLine());
            double USD = 1.79549;
            var result = (howmuch * USD);
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
