using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputValues = input.Split();
            var stack = new Stack<string>(inputValues.Reverse());
            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                String op = stack.Pop();
                int second = int.Parse(stack.Pop());
                switch (op)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                }

                //TODO: Add switch for operation (look next slide)
            }
            Console.WriteLine(stack.Pop());

        }
    }
}
