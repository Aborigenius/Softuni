using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            if (array1.Length == array2.Length)
            {
                if (array1[0] < array2[0])
                {
                    Console.WriteLine(array1);
                    Console.WriteLine(array2);
                }
                else
                {
                    Console.WriteLine(array2);
                    Console.WriteLine(array1);
                }
            }
            else if (array1.Length > array2.Length)
            {
                Console.WriteLine(array2);
                Console.WriteLine(array1);
            }
            else
            {
                Console.WriteLine(array1);
                Console.WriteLine(array2);
            }
        }
    }
}
