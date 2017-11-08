using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                string zvezdabe = new string('*', i);
                Console.WriteLine(zvezdabe);
                }
        }
    }
}
