using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                int y = b;
                b = a;
                a =y;
            }
            else
            {
                int y = b;
                b = a;
                a = y;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
