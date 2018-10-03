using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int queryNum = int.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();
            for (int i = 0; i < queryNum; i++)
            {
                int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int operation = values[0];
           

                switch (operation)
                {
                    case 1:
                        int num = values[1];
                        result.Push(num);
                        break;
                    case 2:
                        result.Pop();
                        break;
                    case 3:
                        Console.WriteLine(result.Max());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
