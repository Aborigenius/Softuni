using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<long> FiboStack = new Stack<long>();

            FiboStack.Push(0);
            FiboStack.Push(1);

            var inputNum = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < inputNum; i++)
            {
                var fiboNum1 = FiboStack.Pop();
                var fiboNum2 = FiboStack.Peek();

                var next = fiboNum1 + fiboNum2;
                FiboStack.Push(fiboNum1);
                FiboStack.Push(next);
            }
            Console.WriteLine(FiboStack.Pop());
        }
        
    }
}
