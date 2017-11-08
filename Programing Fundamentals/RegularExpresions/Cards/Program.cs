using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<power>\d+|[JQKA]+)(?<suit>[SHDC])";

            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);

            MatchCollection result = Regex.Matches(input, pattern);
            List<string> fu = new List<string>();
            foreach (Match m in result)
            {
                string power = m.Groups["power"].Value;
                string suit = m.Groups["suit"].Value;
                string powerSuit = power + suit;
                Console.WriteLine(powerSuit);
                fu.Add(powerSuit);
             
            }

            foreach (var item in fu)
            {
                if (item != fu.Last())
                {
                    Console.Write(item + ", ");
                }
                else
                {
                    Console.WriteLine(item);
                }
                
            }

        }
    }
}
