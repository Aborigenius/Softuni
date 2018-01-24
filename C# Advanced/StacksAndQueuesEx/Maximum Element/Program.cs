using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string result = String.Empty;
            int inputN = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputN; i++)
            {
                int[] inputLines = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                switch (inputLines[0])
                {
                    case 1:
                        stack.Push(inputLines[1]);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        result += ($"{stack.Max()}{Environment.NewLine}");
                        break;
                    default:
                        break;
                }
                //if (inputLines[0] == 1)
                //{
                //    stack.Push(inputLines[1]);
                //}
                //if (inputLines[0] == 2)
                //{
                //    stack.Pop();
                //}
                //if (inputLines[0] == 3)
                //{
                //    result.Append($"{stack.Max()}{Environment.NewLine}");
                //}
            }
            Console.WriteLine(result);
        }
    }
}
