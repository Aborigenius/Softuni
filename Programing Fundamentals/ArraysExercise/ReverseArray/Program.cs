using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string[] reversed = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversed[input.Length - i - 1] = input[i];
            }
            //or use reverse which does pretty much the same, just 
            //needs .ToArray() at the end because reverse use IEnumerable
            string[] reversed2 = input.Reverse().ToArray();

            Console.WriteLine(string.Join(" <=> ", reversed));
            // or we go balistic and do

            Console.WriteLine(String.Join(" ", Console.ReadLine().Split(' ').Reverse().ToArray()));
        }
    }
}
