using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicN = int.Parse(Console.ReadLine());

            int sum = 0;
            int combos = 0;
            int N1 = 0;
            int N2 = 0;
            bool success = false;

            for (int i = N; i <= M; i++)
            {
                for (int f = N; f <= M; f++)
                {
                    combos++;
                    sum = i + f;
                    if (sum == magicN)
                    {
                        success = true;
                        N1 = i;
                        N2 = f;

                    }
                }

            }
            if (success == true)
            {
                Console.WriteLine($"Number found! {N1} + {N2} = {magicN}");
            }
            else
            {
                Console.WriteLine($"{combos} combinations - neither equals {magicN}");
            }
        }
    }
}
