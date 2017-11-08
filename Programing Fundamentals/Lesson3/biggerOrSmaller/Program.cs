using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggerOrSmaller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var numOne = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            var numTwo = int.Parse(Console.ReadLine());

            if (numOne == numTwo)
            {
                Console.WriteLine("The Numbers are Equal");
            }               

            else if (numOne > numTwo)
            {
                Console.WriteLine ($"The Bigger Number is {numOne}");
            }
            else
            {
                Console.WriteLine($"The Bigger Number is {numTwo}");
            }
        }
    }
}
