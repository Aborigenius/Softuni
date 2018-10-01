using System;
using System.Linq;

namespace SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] inputSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = inputSizes[0];
            int col = inputSizes[1];
            int resultCounter = 0;
            string [,] matrix = new string[row, col];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                string[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                                     
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = currentRow[j];
                    }
                }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if(matrix[i,j] == matrix[i + 1, j] && matrix[i,j] == matrix[i, j + 1] &&
                       matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        resultCounter++;
                    }
                }
            }


            Console.WriteLine(resultCounter);
        }
        public static void PrintMatrix(string[,] matrix)
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
