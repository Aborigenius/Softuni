using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = (Console.ReadLine());
            int[] myArray = N.Split(' ').Select(t => Convert.ToInt32(t)).ToArray();
            bool check = false;

            for (int i = 0; i < myArray.Length -1; i++)
            {
                if (myArray[i] > myArray[i+1])
                {
                   
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }


            }
            if (check == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
