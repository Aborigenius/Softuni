using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSomeArrayElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = (Console.ReadLine());
            int counter = 0;
            int[] myArray = N.Split(' ').Select(t => Convert.ToInt32(t)).ToArray();



            //     for (int i = 0; i < myArray.Length; i++)
            //     {
            //         Console.WriteLine("Element[{0}] = {1}", i, myArray[i]);
            //     }

            int checkNumber = int.Parse(Console.ReadLine());

            foreach (var num in myArray)
            {
                if (checkNumber == num)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
