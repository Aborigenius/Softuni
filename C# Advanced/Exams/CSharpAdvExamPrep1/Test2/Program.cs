using System;

namespace KnightGame
{
    class Regeh
    {
        private static void Main(string[] args)
        {
            //Read Input - Board Size
            int boardSize = int.Parse(System.Console.ReadLine());


            //Create a matrix form with input size
            char[,] matrix = new char[boardSize, boardSize];
            if (boardSize < 3)
            {
                Console.WriteLine("0");
                return;
            }
            //Fill the matrix
            for (int i = 0; i < boardSize; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int maxRow = 0;
            int maxColumn = 0;
            int maxAttackedPosition = 0;
            int removedKinghtsCounter = 0;
            do
            {
                //Check the knight and remove it if 
                if (maxAttackedPosition > 0)
                {
                    matrix[maxRow, maxColumn] = '0';
                    maxAttackedPosition = 0;
                    removedKinghtsCounter++;
                }
                int currentAttackPosition = 0;
                for (int row = 0; row < boardSize; row++)
                {
                    for (int col = 0; col < boardSize; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            currentAttackPosition = CalculateAttackPositions(row, col, matrix);
                            if (currentAttackPosition > maxAttackedPosition)
                            {
                                maxAttackedPosition = currentAttackPosition;
                                maxRow = row;
                                maxColumn = col;
                            }
                        }
                    }
                }

            } while (maxAttackedPosition > 0);
            Console.WriteLine(removedKinghtsCounter);


        }
        //  PrintMatrix(matrix);
        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
        public static int CalculateAttackPositions(int row, int col, char[,] matrix)
        {
            var currentAttackPositions = 0;
            if (IsPositionBeignAttacked(row - 2, col - 1, matrix))
            {
                currentAttackPositions++;
            }
            if (IsPositionBeignAttacked(row - 2, col + 1, matrix))
            {
                currentAttackPositions++;
            }
            if (IsPositionBeignAttacked(row - 1, col - 2, matrix))
            {
                currentAttackPositions++;
            }
            if (IsPositionBeignAttacked(row - 1, col + 2, matrix))
            {
                currentAttackPositions++;
            }
            if (IsPositionBeignAttacked(row + 1, col - 2, matrix))
            {
                currentAttackPositions++;
            }
            if (IsPositionBeignAttacked(row + 1, col + 2, matrix))
            {
                currentAttackPositions++;
            }
            if (IsPositionBeignAttacked(row + 2, col - 1, matrix))
            {
                currentAttackPositions++;
            }
            if (IsPositionBeignAttacked(row + 2, col + 1, matrix))
            {
                currentAttackPositions++;
            }
            return currentAttackPositions;
        }
        public static bool IsPositionBeignAttacked(int row, int col, char[,] matrix)
        {
            return IsPositionWhithinBoard(row, col, matrix.GetLength(0)) &&
                matrix[row, col] == 'K';
        }
        public static bool IsPositionWhithinBoard(int row, int col, int boardSize)
        {
            return row >= 0 && row < boardSize && col >= 0 && col < boardSize;
        }
    }
}
