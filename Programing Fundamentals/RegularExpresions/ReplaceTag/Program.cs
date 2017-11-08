using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string str = "<a";
            string pattern1 = @"(?<furl><a)";
            string pattern2 = @"(?<endurl><\/a>)";

            string replacement1 = "[URL ";
            string relacement2 = "[/URL]";

            Regex regex1 = new Regex(pattern1);
            Regex regex2 = new Regex(pattern2);


            while (input != "end")
            {
                if (input.Contains(str) && input.Contains("</a>"))
                {
                    string result = regex1.Replace(input, replacement1);
                    result = regex2.Replace(result, relacement2);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
