using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //read matrix size
            int matrixSize = int.Parse(Console.ReadLine());
            //create matrix
            int[,] matrix = new int[matrixSize,matrixSize];

            //read the input - N(matrixsize) lines
            for (int rows = 0; rows < matrixSize; rows++)
            {
                var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None).Select(int.Parse).ToArray();
                //add array values to the matrix
                for (int cols = 0; cols < matrixSize; cols++)
                {
                    matrix[cols, rows] = input[cols];
                }

                //Calculate diagonals
            }
            long leftDiagonal = 0;
            long rightDiagonal = 0;

            for (int cols = 0; cols < matrixSize; cols++)
            {
                leftDiagonal += matrix[cols,cols];
                rightDiagonal += matrix[cols,matrixSize - cols -1];
       //         Console.WriteLine("[{0}, {1}] = {2}", cols, matrixSize-cols-1, matrix[cols][matrixSize - cols - 1]);
            }

            var result = Math.Abs(leftDiagonal - rightDiagonal);
            Console.WriteLine(result);
        }

    }
}
