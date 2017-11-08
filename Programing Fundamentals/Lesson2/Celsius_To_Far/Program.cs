using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_To_Far
{
    class Program
    {
        static void Main(string[] args)
        {
            var cel = double.Parse(Console.ReadLine());
            var far = ((cel * 9) /  5+32 );
            var result = Math.Round(far, 2);
            Console.WriteLine(result);
        }
    }
}
