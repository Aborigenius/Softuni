using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; multiplier++)
            {
                if (multiplier >= 10)
                {
                    Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
                    break;
                }
                else 
                {
                    Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
                }            
            }
        }
    }
}
