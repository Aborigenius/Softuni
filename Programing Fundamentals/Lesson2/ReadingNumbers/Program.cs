using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a Number: ");
            //var num1 = Convert.ToInt32(Console.ReadLine());
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Type Another Number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            var sum = num1 + num2;
            Console.WriteLine("The result is: " + sum);
        }
    }
}
 