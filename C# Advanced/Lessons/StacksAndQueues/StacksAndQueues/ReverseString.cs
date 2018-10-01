using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var nums = input.Split().Select(int.Parse).ToArray();
            Stack<int> ReverseMe = new Stack<int>(nums);


            while (ReverseMe.Count > 0)
            {
                Console.Write(ReverseMe.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
