using System;
using System.Text.RegularExpressions;


namespace CSharpAdvExamPrep1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\[\w+<(?<num1>\d+)REGEH(?<num2>\d+)>\w+\]";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);
            int index = 0;
            int stringLenght = input.Length;
            string result = String.Empty;

            foreach (Match match in matches)
            {
                int numOne = int.Parse(match.Groups["num1"].Value);
                int numTwo = int.Parse(match.Groups["num2"].Value);

                index += numOne;

                if (index >= stringLenght)
                {
                    int fixedIndex = (index % input.Length) + 1;
                    result += input[fixedIndex];
                }
                else
                {
                    result += input[index];
                }


                index += numTwo;

                if (index >= stringLenght)
                {
                    int fixedIndex = (index % input.Length) + 1;
                    result += input[fixedIndex];
                }
                else
                {
                    result += input[index];
                }

            }

            Console.WriteLine(result);

        }
    }
}
