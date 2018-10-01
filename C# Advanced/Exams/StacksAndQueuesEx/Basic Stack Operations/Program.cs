using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] NSX = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            int N = NSX[0];
            int S = NSX[1];
            int X = NSX[2];
          
            Stack<int> stack = new Stack<int>();

            Console.ReadLine()
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .ToList()
           .ForEach(strNumber => stack.Push(int.Parse(strNumber)));
           
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
        
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

        }
    }
}
