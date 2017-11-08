using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var sum = 0.0;

            for (int i = 0; i < num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum = sum + n;
            }
            Console.WriteLine(sum);
        }
    }
}
