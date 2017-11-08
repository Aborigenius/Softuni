using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string numbersInput = Console.ReadLine();

            MatchCollection number = Regex.Matches(numbersInput, pattern);

            foreach (var num in number)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
