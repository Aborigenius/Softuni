using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var max = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine(max);
        }
    }
}
