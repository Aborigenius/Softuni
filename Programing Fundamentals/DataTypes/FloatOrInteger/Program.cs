using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse( Console.ReadLine());

//            bool isInt = (n == Math.Truncate(n));
//            bool isInt2 = (n == Math.Round(n, 0));

//            Console.WriteLine(isInt);
//            Console.WriteLine(isInt2);
            Console.WriteLine(Math.Round(n));
        }
    }
}
 