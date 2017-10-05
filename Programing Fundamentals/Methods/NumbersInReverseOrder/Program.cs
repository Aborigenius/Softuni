using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            ReverseInput(input);
        }

        private static void ReverseInput(decimal input)
        {
            string reversed = new string(input.ToString().Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}
