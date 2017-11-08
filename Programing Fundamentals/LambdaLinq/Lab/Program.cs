using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputN = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            Console.WriteLine((string.Join(" ", inputN.OrderByDescending(x => x).Take(3))));

        }
    }
}
//Write a program to read n integers and print their sum, min, max, first, last and average values.