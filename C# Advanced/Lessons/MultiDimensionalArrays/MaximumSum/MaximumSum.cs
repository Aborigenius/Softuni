using System;
using System.Linq;

namespace MaximumSum
{
    class MaximumSum
    {
        static void Main(string[] args)
        {
            int[] inputSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[inputSizes[0], inputSizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }
            int sum = 0;
            int rowIndex = 0; int colIndex = 0;
            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1) - 2; columns++)
                {
                    var tempSum = matrix[rows, columns] + matrix[rows, columns + 1] + matrix[rows, columns + 2]
                        + matrix[rows + 1, columns] + matrix[rows + 1, columns + 1] + matrix[rows + 1, columns + 2] +
                        matrix[rows + 2, columns] + matrix[rows + 2, columns + 1] + matrix[rows + 2, columns + 2];

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        colIndex = columns;
                        rowIndex = rows;
                    }

                }
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine(matrix[rowIndex, colIndex] + " " + matrix[rowIndex, colIndex + 1] + " " + matrix[rowIndex, colIndex + 2]);
            Console.WriteLine(matrix[rowIndex + 1, colIndex] + " " + matrix[rowIndex + 1, colIndex + 1] + " " + matrix[rowIndex + 1, colIndex + 2]);
            Console.WriteLine(matrix[rowIndex + 2, colIndex] + " " + matrix[rowIndex + 2, colIndex + 1] + " " + matrix[rowIndex + 2, colIndex + 2]);
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
