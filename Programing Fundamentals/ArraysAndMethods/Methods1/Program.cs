using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            HelloName(name);
        }

        static void HelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
