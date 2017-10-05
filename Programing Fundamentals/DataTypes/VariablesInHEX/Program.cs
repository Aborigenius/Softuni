using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesInHEX
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int intValue = Convert.ToInt32(hex, 16);

            Console.WriteLine(intValue);

        }
    }
}
