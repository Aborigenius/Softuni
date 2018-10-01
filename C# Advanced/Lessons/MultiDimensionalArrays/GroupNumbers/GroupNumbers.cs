using System;
using System.Linq;

namespace GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] jagged = new int[3][];

            jagged[0] = inputNumbers.Where(x => Math.Abs(x) % 3 == 0).ToArray();
            jagged[1] = inputNumbers.Where(x => Math.Abs(x) % 3 == 1).ToArray();
            jagged[2] = inputNumbers.Where(x => Math.Abs(x) % 3 == 2).ToArray();

            ReadMatrix(jagged);
        }
        public static int[][] ReadMatrix(int[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }
            return jagged;
        }
    }
}
