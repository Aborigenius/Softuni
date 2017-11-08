using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int numToAdd = int.Parse(Console.ReadLine());
                numbers.Add(numToAdd);
            }
            int minNum = numbers.Min();
            int maxNum = numbers.Max();
            double averageNum = numbers.Average();

           numbers = numbers.Select(a => a * 2).ToList();


            Console.WriteLine("Sum = " + numbers.Sum());
            Console.WriteLine("Min = "+ numbers.Min());
            Console.WriteLine("Max = "+ numbers.Max());
            Console.WriteLine("Average = "+ numbers.Average());
            Console.WriteLine(string.Join(" ", numbers));

            List<int> newNums = new List<int> { 6, 21, 1, -90, 100 };

            Console.WriteLine(string.Join(",", newNums.OrderBy(x => x).ToList()));
        }
    }
}
