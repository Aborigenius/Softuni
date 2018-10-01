using System;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int inputSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[inputSize, inputSize];
            int primaryDiagSum = 0;
            int secondaryDiagSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }



            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagSum += matrix[i, i];
                secondaryDiagSum += matrix[i, inputSize - i - 1];
            }



            Console.WriteLine(Math.Abs(primaryDiagSum - secondaryDiagSum));
    

            //PrintMatrix(matrix);
        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
