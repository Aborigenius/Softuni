using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = 0;

            switch (operators)
            {
                case '-':
                    result = num1 - num2;
                    break;
                case '+':
                    result = num1 + num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            Console.WriteLine($"{num1} {operators} {num2} = {result}");
          
        }
    }
}
