using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValueOfAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();
            int sum = 0;
            if (command == "UPPERCASE")
            {
                char[] up = text.Where(c => char.IsUpper(c)).ToArray();
                byte[] asciiValues = Encoding.ASCII.GetBytes(up);

                foreach (var c in asciiValues)
                {
                    sum += c;
                }
            }
            else if (command == "LOWERCASE")
            {
                char[] low = text.Where(c => char.IsLower(c)).ToArray();
                byte[] asciiValues = Encoding.ASCII.GetBytes(low);
                foreach (var c in asciiValues)
                {
                    sum += c;
                }
            }

            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
