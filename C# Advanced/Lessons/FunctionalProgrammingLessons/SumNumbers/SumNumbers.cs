using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse).ToArray();

            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }

       public static Func<string, int> Parse = n => int.Parse(n);
    }
}
