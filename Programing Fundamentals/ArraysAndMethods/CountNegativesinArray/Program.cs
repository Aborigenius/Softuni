using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNegativesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int negativesCounter = 0;
            int[] myArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            foreach (var n in myArray)
            {
                if (n < 0)
                {
                    negativesCounter++;
                }
            }
            Console.WriteLine(negativesCounter);
        }
    }
}
