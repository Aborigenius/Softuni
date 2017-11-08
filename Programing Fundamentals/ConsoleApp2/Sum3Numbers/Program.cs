using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            if (A + B == C)
            {
                Console.WriteLine($"{A} + {B} = {C}");
            }
            else if (A + C == B)
            {
                Console.WriteLine($"{A} + {C} = {B}");
            }
            else if (C + B == A)
            {
                Console.WriteLine($"{C} + {B} = {A}");
            }
            else if (B + C == A)
            {
                Console.WriteLine($"{B} + {C} = {A}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
//A + B = C
//A ≤ B