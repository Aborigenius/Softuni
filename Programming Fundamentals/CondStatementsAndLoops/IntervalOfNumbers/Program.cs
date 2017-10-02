using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n2 > n1)
            {

                for (int i = n1; i <= n2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = n2; i <= n1; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
