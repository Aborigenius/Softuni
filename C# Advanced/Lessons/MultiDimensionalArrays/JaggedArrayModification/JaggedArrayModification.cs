using System;
using System.Linq;

namespace JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int jaggedRows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[jaggedRows][];
            for (int i = 0; i < jaggedRows; i++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                jagged[i] = currentRow;
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (command[0]?.ToLower() != "end")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                if (row < 0 || row > jagged.Length - 1 ||
                    col < 0 || col > jagged[int.Parse(command[1])].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                switch (command[0]?.ToLower())
                {
                    case "add":
                        jagged[row][col] += int.Parse(command[3]);
                        break;
                    case "subtract":
                        jagged[row][col] -= int.Parse(command[3]);
                        break;
                    default:
                        break;

                }
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
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
