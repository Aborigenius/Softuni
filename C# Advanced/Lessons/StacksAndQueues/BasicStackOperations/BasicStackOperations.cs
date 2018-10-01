using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] NSX = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int N = NSX[0];
            int S = NSX[1];
            int X = NSX[2];

            Stack<int> stack = new Stack<int>();
            int [] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < N; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }
            bool isEmpty = !stack.Any();
            if (isEmpty == true)
            {
                Console.WriteLine("0");
                return;
            }

            foreach (var item in stack)
            {
                if (stack.Contains(X))
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    Console.WriteLine(stack.Min());
                    return;
                }
            }
        }
    }
}
