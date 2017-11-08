using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var sum = 0.0;
            for (var i = 1; i <= number1; i++)
            {
                var currentnumber = double.Parse(Console.ReadLine());
                sum += currentnumber;
            }
            Console.WriteLine(sum);
        }
    }
}
