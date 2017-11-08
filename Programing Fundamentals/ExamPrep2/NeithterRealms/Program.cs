using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NeithterRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] inputNames = Console.ReadLine()
                .Split(new string[] { ",", " "}, StringSplitOptions.RemoveEmptyEntries);

          SortedDictionary<string, List<double>> result = new SortedDictionary<string, List<double>>();
            foreach (var n in inputNames)
            {
                string name = n;
                double digitsSumBefore = Regex.Matches(n, @"(?<digits>[-|+]*[0-9.0-9]+)")
                    .Cast<Match>().
                    Select(m => double.Parse(m.Value))
                    .Sum();

                var health = Regex.Matches(n, @"[A-Z]|[a-z]")
                     .Cast<Match>()
                    .Select(c => char.Parse(c.Value))
                    .ToArray();
             byte[] healthASCII = Encoding.ASCII.GetBytes(health);
                int healthResult = 0;
                foreach (var b in healthASCII)
                {
                    healthResult += b;
                }
                var operators = Regex.Matches(n, @"[\*|\/]")
                    .Cast<Match>()
                    .Select(c => char.Parse(c.Value))
                    .ToArray();
                double digitSumResult = digitsSumBefore;

                foreach (var op in operators)
                {
                    if (op == '*')
                    {
                        digitSumResult *= 2;
                    }
                    else if (op == '/')
                    {
                        digitSumResult /= 2;
                    }
                }
                if (!result.ContainsKey(name))
                {
                    result[name] = new List<double>();
                }
                    result[name].Add(healthResult);
                    result[name].Add(digitSumResult);
            }
            foreach (KeyValuePair<string, List<double>> demon in result)
            {
                List<double> demonProps = demon.Value;
                double life = demonProps[0];
                double damage = demonProps[1];
                Console.WriteLine($"{demon.Key} - {life} health, {damage:F2} damage");
            }
        }
    }
}
