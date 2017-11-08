using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] myArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int max = myArray.Max();
            //         for (int i = 0; i < myArray.Length; i++)
            //         {
            //             Console.WriteLine("Element[{0}] = {1}", i, myArray[i]);
            //         }
            Console.WriteLine(max);
        }
    }
}
