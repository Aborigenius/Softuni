using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            while(N > 0)
            {
                stack.Push(N % 2);
                N /= 2;

            }
           
            while (stack.Count > 0 )
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
