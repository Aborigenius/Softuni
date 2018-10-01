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
            var trackMax = new Stack<int>();
            int inputN = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputN; i++)
            {
                int[] inputLines = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                switch (inputLines[0])
                {
                    case 1:
                        stack.Push(inputLines[1]);
                        if (trackMax.Count == 0)
                        {
                            trackMax.Push(inputLines[1]);
                        }
                        else
                        {
                            if (trackMax.Peek() < inputLines[1])
                            {
                                trackMax.Push(inputLines[1]);
                            }
                            else
                            {
                                trackMax.Push(trackMax.Peek());
                            }
                        }
                     
                        break;
                    case 2:
                        stack.Pop();
                        trackMax.Pop();
                        break;
                    case 3:
                        Console.WriteLine(trackMax.Peek());
                        break;
                    default:
                        break;
                }
            }
           // Console.WriteLine(result);
        }
    }
}
