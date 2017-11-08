using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var a = 0;
            var b = 0;
            var c = 0;
            var d = 0;
            string allLetters = null;
            for (int i = 1; i <= N; i++)
            {
                uint number = uint.Parse(Console.ReadLine());
                string letters = null;

                if (number % 4 == 0)
                {
                    a++;
                    letters = "a";
                }
                if (number % 4 == 1)
                {
                    b++;
                    letters = "b";
                }
                if (number % 4 == 2)
                {
                    c++;
                    letters = "c";
                }
                if (number % 4 == 3)
                {
                    d++;
                    letters = "d";
                }
                allLetters += letters + " ";
            }
            Console.WriteLine(allLetters);
            Console.WriteLine($"Answer A: {a}");
            Console.WriteLine($"Answer B: {b}");
            Console.WriteLine($"Answer C: {c}");
            Console.WriteLine($"Answer D: {d}");
        }
    }
}
