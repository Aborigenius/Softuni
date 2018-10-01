using System;
using System.Linq;

namespace JaggedArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int rowsCounter = 0; rowsCounter < rows; rowsCounter++)
            {
                jaggedArray[rowsCounter] = Console.ReadLine().Split(new char[] { ',' }).Select(int.Parse).ToArray();
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                var row = jaggedArray[i];
                foreach (var item in row)
                {
                    Console.Write(item);
                }
            }
        }
    }
}
