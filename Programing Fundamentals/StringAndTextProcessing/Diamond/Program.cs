using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int leftindex = -1;
            int rightIndex = -1;
            bool isFound = false;
            while ((leftindex = input.IndexOf('<', leftindex +1)) > -1
                && (rightIndex = input.IndexOf('>', leftindex +1)) > -1)
            {
               
                string content = input.Substring(leftindex +1, rightIndex - leftindex -1);
                int carats = FindCarats(content);
                Console.WriteLine($"Found {carats} carat diamond");
                isFound = true;

            }
            if (isFound == false)
            {
                Console.WriteLine("Better luck next time");
            }

        }
        public static int FindCarats(string content)
        {
            int carats = 0;
                foreach (char @char in content)
                {
                    if (char.IsDigit(@char))
                    {
                        carats += int.Parse(@char.ToString());
                    }
                }
            return carats;
        }
    }

}
