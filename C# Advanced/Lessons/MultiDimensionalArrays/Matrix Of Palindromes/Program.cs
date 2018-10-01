using System;
using System.Linq;
using System.Text;

namespace Matrix_Of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None).Select(int.Parse).ToArray();

            var matrix = new string[rowsCols[0], rowsCols[1]];
            var answer = new StringBuilder();
            for (int rowCounter = 0; rowCounter < rowsCols[0]; rowCounter++)
            {
                for (int colCounter = 0; colCounter < rowsCols[1]; colCounter++)
                {

                    var borderChar = (char)('a' + rowCounter);
                    var middleChar = (char)(borderChar + colCounter);
                    answer.Append($"{borderChar}{middleChar}{borderChar} ");


                }

                if (rowCounter != rowsCols[0] - 1)
                {
                    answer.Append(Environment.NewLine);
                }

            }
            Console.WriteLine(answer);
        }

    }
}
