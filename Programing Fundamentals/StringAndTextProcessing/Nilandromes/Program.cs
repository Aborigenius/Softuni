using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilandromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string nillandrome = Nillandrome(input);
                if (nillandrome != "")
                {
                    Console.WriteLine(nillandrome);
                }
                input = Console.ReadLine();
            }
        }
        public static string Nillandrome(string input)
        {

            int middleIndex = input.Length / 2;
            string border = "";
            int leftIndex = 0;
            for (int i = middleIndex + 1; i < input.Length; i++)
            {
                if (input[leftIndex] == input[i])
                {
                    border += input[i];
                    leftIndex++;
                }
                else
                {
                    border = "";
                    leftIndex = 0;
                    if (input[i] == input[leftIndex])
                    {
                        border += input[i];
                        leftIndex++;
                    }
                }
            }

            if (border != "")
            {
                int leftIndexMiddle = input.IndexOf(border);
                int rightIndexMiddle = input.LastIndexOf(border);

                string middle = input.Substring(leftIndexMiddle + border.Length,
                    rightIndexMiddle - leftIndexMiddle - border.Length);
                if (middle != "")
                {
                    return middle + border + middle;
                }
            }

            return null;
        }
    }
}
