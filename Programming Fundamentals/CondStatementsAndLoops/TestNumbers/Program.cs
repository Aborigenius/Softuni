using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int boundry = int.Parse(Console.ReadLine());
            int sum = 0;
            int combos = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int g = 1; g <= M; g++)
                {
                    sum += (i * g) * 3;
                    combos++;
                    if (sum >= boundry)
                    {
                        Console.WriteLine($"{combos} combinations");
                        Console.WriteLine($"Sum: {sum} >= {boundry}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combos} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
       
    }
}
