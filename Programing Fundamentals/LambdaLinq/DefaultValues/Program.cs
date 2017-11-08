using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            Dictionary<string, string> values2 = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputTokens = input.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
                string dictKey = inputTokens[0];
                string dictVal = inputTokens[1];

                values[dictKey] = dictVal;

                input = Console.ReadLine();
            }
            string endInput = Console.ReadLine();

            foreach (var record in values)
            {
                if (record.Value == "null")
                {
                    values2[record.Key] = endInput;
                }
            }
            values = values.Where(x => x.Value != "null")
             .OrderByDescending(x => x.Value.Length)
             .ToDictionary(x => x.Key, x => x.Value);
            //   Console.WriteLine(string.Join("<->", values));
            foreach (KeyValuePair<string, string> item in values)
            {
                                 Console.WriteLine("{0} <-> {1}", item.Key, item.Value);
            }

            foreach (KeyValuePair<string, string> item in values2)
            {
                Console.WriteLine("{0} <-> {1}", item.Key, item.Value);
            }
        }
    }
}
