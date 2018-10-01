using System;
using System.Linq;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int arraysRows = int.Parse(Console.ReadLine());
            int[][] jagged1 = new int[arraysRows][];
            int[][] jagged2 = new int[arraysRows][];
            for (int i = 0; i < arraysRows; i++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse).ToArray();

                    jagged1[i] = currentRow;

            }
            for (int i = 0; i < arraysRows; i++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse).ToArray();
                jagged2[i] = currentRow;
            }
            ReverseJaggedArray(jagged2);
            //ReadMatrix(jagged1);
            //ReadMatrix(jagged2);

            int elementsCount = 0;
            int rowLenght = jagged1[0].Length + jagged2[0].Length;
            bool isGoodLego = true;
            

            for (int i = 0; i < arraysRows; i++)
            {
                int currentLenght = jagged1[i].Length + jagged2[i].Length;
                if (currentLenght != rowLenght)
                {
                    isGoodLego = false;
                }
                elementsCount += currentLenght;
            }

            if (isGoodLego)
            {
                int[] result = new int[rowLenght];
                for (int i = 0; i < arraysRows; i++)
                {
                    result = jagged1[i].Concat(jagged2[i]).ToArray();
                    Console.WriteLine($"[{String.Join(", ", result)}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {elementsCount}");
            }

          

           // Console.WriteLine(jagged1.Length); ///get rows
           // Console.WriteLine(jagged2.Length);

        }
 
        public static void ReverseJaggedArray(int[][] theArray)
        {
            for (int rowIndex = 0;
              rowIndex <= (theArray.GetUpperBound(0)); rowIndex++)
            {
                for (int colIndex = 0;
                     colIndex <= (theArray[rowIndex].GetUpperBound(0) / 2);
                     colIndex++)
                {
                    int tempHolder = theArray[rowIndex][colIndex];
                    theArray[rowIndex][colIndex] =
                      theArray[rowIndex][theArray[rowIndex].GetUpperBound(0) -
                              colIndex];
                    theArray[rowIndex][theArray[rowIndex].GetUpperBound(0) -
                              colIndex] = tempHolder;
                }
            }
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
        public static void PrintRowsAndColsCount<T>(T[][] array)
        {
            int rank = array.Rank; // Will always be 2 in this case, since it's a 2D array

            int rows = array.GetUpperBound(0) - array.GetLowerBound(0) + 1;
            int cols = array.GetUpperBound(1) - array.GetLowerBound(1) + 1;

            Console.WriteLine("Array is of length [{0},{1}]", rows, cols);
        }
    }
}
