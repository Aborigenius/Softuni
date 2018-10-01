using System;
using System.Linq;

namespace Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          int [] numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None ).Select(int.Parse).ToArray();

            var sizes = new int[3];

            foreach (var num in numbers)
            {
                sizes[Math.Abs(num % 3)]++;
            }

            int[][] jaggedArray = new int[3][];
            for (int i = 0; i < sizes.Length; i++)
            {
                jaggedArray[i] = new int[sizes[i]];
            }
            int[] index = new int[3];
            foreach (var num in numbers)
            {
                var remainder = Math.Abs(num % 3);
                jaggedArray[remainder][index[remainder]] = num;
                index[remainder]++;
            }

            for (int rows = 0; rows < jaggedArray.Length; rows++)
            {
                for (int col = 0; col < jaggedArray[rows].Length; col++)
                {
                    Console.Write(jaggedArray[rows][col] + " ");
                }
                Console.WriteLine();
            }
      
        }
    }
}
