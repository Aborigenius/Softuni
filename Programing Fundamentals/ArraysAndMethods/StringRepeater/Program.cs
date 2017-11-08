using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            RepeatedString(input, n);
        }

        static string RepeatedString(string input, int n)
        {
            string RepeatedString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                Console.Write(input);
            }
            Console.WriteLine();
            return RepeatedString;
        }
    }
}
