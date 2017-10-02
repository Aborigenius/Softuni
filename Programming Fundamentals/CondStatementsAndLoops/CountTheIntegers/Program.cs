using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int howmany = 0;
            for (int i = 0; i <= 100; i++)
            {
                var input = Console.ReadLine();
                bool success = int.TryParse(input, out n);
                if (success == true)
                {
                    howmany++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(howmany);
        }
    }
}
