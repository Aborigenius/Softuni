using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string pattern = @"(\b[A-Z][a-z]+ [A-Z][a-z]+\b)";
            //
            //  string names = Console.ReadLine();
            //
            //  MatchCollection matchedNames = Regex.Matches(names, pattern);
            //
            //  foreach (Match name in matchedNames)
            //  {
            //      Console.Write(name.Value + " ");
            //  }

            string pattern = @"[+359]{4}([-| ])[2]\1[0-9]{3}[-| ][0-9]{4}\b";
            //I hate you Regex

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMatches.Cast<Match>().Select(n => n.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
//\b(?>\p{Lu}\p{M}*)(?>\p{L}\p{M}*)*(?:\s+(?>\p{Lu}\p{M}*)(?>\p{L}\p{M}*)*){0,2}\b