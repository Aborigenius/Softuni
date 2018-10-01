using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int[] inputNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[,] result = new string[inputNumbers[0], inputNumbers[1]];

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        
                        result[row, col] += alphabet[row];
                        result[row, col] += alphabet[row];
                        result[row, col] += alphabet[row];
                    }
                    else
                    {
                        
                        result[row, col] += alphabet[row];
                        result[row, col] += alphabet[row + col];
                        result[row, col] += alphabet[row];
                    }

                }
            }
            PrintMatrix(result);

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
