using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y") == true)
            {
                word = word.Remove(word.Length - 1, 1) + "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("s") || 
                word.EndsWith("x") || word.EndsWith("z") ||
                word.EndsWith("ch") || word.EndsWith("sh") == true)
            {
                word = word + "es";
            }
            else
            {
                word = word + "s";
            }
            Console.WriteLine(word);
        }
    }
}
