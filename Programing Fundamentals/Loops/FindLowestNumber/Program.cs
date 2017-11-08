using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLowestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialNumber = int.Parse(Console.ReadLine());
            var lowestNumber = double.MaxValue;
            for (int i = 0; i < initialNumber; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber < lowestNumber)
                {
                    lowestNumber = currentNumber;
                }
                
            }
            Console.WriteLine(lowestNumber);
        }
    }
}
