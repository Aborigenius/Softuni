using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_berChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Console.WriteLine("It is a number.");
        }
    }
}
