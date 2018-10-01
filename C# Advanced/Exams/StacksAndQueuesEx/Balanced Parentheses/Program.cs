using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> leftPar = new Stack<char>();

            char[] input = Console.ReadLine().ToCharArray();
            bool isBalanced = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length % 2 != 0)
                {
                    isBalanced = false;
                    break;
                }
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    leftPar.Push(input[i]);
                }
                if (input[i] == '}')
                {
                    if (!leftPar.Any())
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (leftPar.Pop() != '{')
                    {
                        isBalanced = false;
                        break;
                    }
                }
                if (input[i] == ']')
                {
                    if (!leftPar.Any())
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (leftPar.Pop() != '[')
                    {
                        isBalanced = false;
                        break;
                    }
                }
                if (input[i] == ')')
                {
                    if (!leftPar.Any())
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (leftPar.Pop() != '(')
                    {
                        isBalanced = false;
                        break;
                    }
                }

            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
