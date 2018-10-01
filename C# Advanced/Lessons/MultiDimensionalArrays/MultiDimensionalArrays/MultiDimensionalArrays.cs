using System;

namespace MultiDimensionalArrays
{
    class MultiDimensionalArrays
    {
        static void Main(string[] args)
        {
            //Create Empty Matrix
            //two dimensional
            int[,] intMatrix = new int[3, 4]; // int is created by default filled with 0
            float[,] floatMatrix = new float[8, 2]; // int is created by default filled with 0f

            //Three dimensional - string is created by default filled with null
            string[,,] stringCube = new string[5, 5, 5];

            //Initialize multidimensional array with values

            int[,] matrixWithValues =
            {
                {1, 2, 3, 4 }, //row 0 values
                {5, 6, 7, 8 } //row 1 values
            };

            //Get element Value
            int element13 = matrixWithValues[1, 3];
            Console.WriteLine(element13);
            //Set element value
            int[,] intMatrix2 = new int[3, 4];
            for (int row = 0; row < intMatrix2.GetLength(0); row++)
            {
                for (int col = 0; col < intMatrix2.GetLength(1); col++)
                {
                    intMatrix2[row, col] = row + col;
                }
            }
            //Printing Matrix with for loop
            for (int row = 0; row < matrixWithValues.GetLength(0); row++)
            {
                for (int col = 0; col < matrixWithValues.GetLength(1); col++)
                {
                    Console.Write($"{matrixWithValues[row, col]} ");
                }
                Console.WriteLine();
            }
            //Printing with Foreach
            foreach (int element in matrixWithValues)
            {
                Console.WriteLine(element);
            }

        }
    }
}
