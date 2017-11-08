using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N1 = double.Parse(Console.ReadLine());
            var N2 = double.Parse(Console.ReadLine());
            var op = char.Parse(Console.ReadLine());
            double result = 0;

            if (op == '+')
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - odd");

                }
            }

            if (op == '-')
            {
                result = (N1 - N2);
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - odd");

                }
            }

            if (op == '*')
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - odd");

                }
            }

            if (op == '/')
            {
                
                if (N1 == 0 || N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    result = N1 / N2;
                    Console.WriteLine($"{N1} / {N2} = {result:F2}");
                }
            }
            if (op == '%')
            {
                
                if (N1 == 0 || N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} % {N2} = {result}");

                }
            }
        }
    }
}
