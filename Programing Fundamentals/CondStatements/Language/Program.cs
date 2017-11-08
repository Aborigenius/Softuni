using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine().ToLower();

            if (country == "england" || country == "usa")
            {
                Console.WriteLine("English");
            }
            else if (country == "spain" || country == "mexico" || country == "argentina")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
