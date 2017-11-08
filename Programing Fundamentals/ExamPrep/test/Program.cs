using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string matched = Console.ReadLine();
            Regex pattern = new Regex(@"[#|$|^|@]{6,10}");
            Match m = pattern.Match(matched);
            if (m.Success)
            {
                matched = m.Groups[1].Value;
                Console.WriteLine(matched);
            }
            else
            {
                Console.WriteLine("Bummer");
            }
        }
    }
}
