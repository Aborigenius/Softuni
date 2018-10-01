using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stackOpenBracketsIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stackOpenBracketsIndexes.Push(i);
                }
                if (input[i] == ')')
                {
                    var openBracketIndex = stackOpenBracketsIndexes.Pop();
                    var lenght = i - openBracketIndex + 1;
                    Console.WriteLine($"{input.Substring(openBracketIndex,lenght)}");
                }
            }
        }
    }
}
