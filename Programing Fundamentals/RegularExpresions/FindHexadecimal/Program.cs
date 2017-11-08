using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            var input = Console.ReadLine();

            string[] hexNums = Regex.Matches(input, pattern).Cast<Match>().Select(n => n.Value).ToArray(); 

         

            Console.WriteLine(string.Join(" ", hexNums));
        }
    }
}
