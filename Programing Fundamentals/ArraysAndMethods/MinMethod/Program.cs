using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GetMin(a, b, c);

        }

        static void GetMin(int a, int b, int c)
        {
            var min = Math.Min(a, b);
            min = Math.Min(min, c);
            Console.WriteLine(min);
            return;
        }
    }
}
