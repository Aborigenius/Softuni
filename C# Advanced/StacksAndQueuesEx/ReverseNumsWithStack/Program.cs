using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumsWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                var nums = input.Split(' ').Select(int.Parse).ToArray();
                Stack<int> stack = new Stack<int>(nums);

                //for (int i = 0; i < nums.Length; i++)
                //{
                //    stack.Push(nums[i]);
                //}
                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop() + " ");
                }
                Console.WriteLine();
            }
            catch
            {
               
                Console.WriteLine(input);
            }

        }
    }
}
