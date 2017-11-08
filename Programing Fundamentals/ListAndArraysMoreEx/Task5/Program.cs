using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> increasingL = new List<int>();
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            increasingL = input.ToList();
            for (int i = 0; i < N-1; i++)
            {

                for (int k = 0; k < input.Count; k++)
                {
                //    input.Clear();
                    input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                    Console.WriteLine(input[k]);
                    Console.WriteLine(input[k+1]);
                    if (input[k] > input[k + 1] && input[k] > 0) //add after right-most lower by value element in incresingL
                    {
                        increasingL.Add(input[k]);
                    }
                }

  //            else //add after right-most lower by value element and remove all after the element
  //            {
  //
  //            }
            }
            for (int i = 0; i < increasingL.Count; i++)
            {
                Console.WriteLine(increasingL[i]);
            }
        }
    }
}
