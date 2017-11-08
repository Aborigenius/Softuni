using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int secondNumber = M;
            int numeroUno = N;

            int sum = 0;
            int moves = 0;
            for (int f = 1; f <= numeroUno; f++)
            {
                for (int i = secondNumber; i >= 1; i--)
                {
                    sum += f * 2 + i * 3;
                    moves++;

                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{moves} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        break;

                    }


                }

            }
            if (sum < controlNumber)
            {
                Console.WriteLine($"{moves} moves");
            }
        }
    }
}
