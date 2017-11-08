using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            var max = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine($"Yes Sum, {sum}");
            }
            else
            {
                var diff = Math.Abs(sum - max);
                Console.WriteLine($"No Diff, {diff}");
            }
        }
    }
}