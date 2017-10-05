using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            double readMe = double.Parse(Console.ReadLine());
            double oneTB = 8796093022208;

            Console.WriteLine(readMe * oneTB);
        }
    }
}
