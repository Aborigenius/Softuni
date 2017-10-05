using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte counter = 0;
            int overflow = 0;
            for (int i = 0; i < n; i++)
            {
                counter++;
                if (counter == 0)
                {
                    overflow++;
                }
            }
            Console.WriteLine(counter);
            if (overflow > 0)
            {
                Console.WriteLine($"Overflowed {overflow} times");
            }
          
        }
    }
}
