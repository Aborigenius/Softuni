using System;
using System.Collections.Generic;

namespace ChapterFour
{
    class ChapterFour
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number 1");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a number 2");
            //int num2 = int.Parse(Console.ReadLine());

            //List<int> result = new List<int>();
            //for (int i = num1; i <= num2; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        result.Add(i);
            //    }
            //}

            //Console.WriteLine($"Numbers dividing to 5 are: {string.Join(" ", result)}");
            List<int> result = CreateList(0, 1, 1, 2, 3);
            int num1 = 2;
            int num2 = 3;
            for (int i = 5; i <= 20; i++)
            {
                int temp1 = num1;
                num1 = num2;
                num2 = temp1 + num2;
                result.Add(num2);

            }
            List<T> CreateList<T>(params T[] values)
            {
                return new List<T>(values);
            }
            Console.WriteLine($"Numbers dividing to 5 are: {string.Join(" ", result)}");
        }

    }
}
