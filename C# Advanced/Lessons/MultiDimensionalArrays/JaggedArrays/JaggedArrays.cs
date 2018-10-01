using System;

namespace JaggedArrays
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {
            //Create
            int[][] jagged = new int[5][];
            //And Fill with data from the console
            for (int row = 0; row < jagged.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split(' ');
                jagged[row] = new int[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(inputNumbers[col]);
                }
            }

            ReadMatrix(jagged);
        }

        public static int [][] ReadMatrix(int [][] jagged)
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
