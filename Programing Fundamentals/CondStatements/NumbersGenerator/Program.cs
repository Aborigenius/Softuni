using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialN = int.Parse(Console.ReadLine());
            int controlN = int.Parse(Console.ReadLine());

            for (int i = M; i >= 1; i--)
            {
                for (int k = N; k >= 1; k--)
                {
                    for (int j = L; j >= 1; j--)
                    {
                        int MNL = i * 100 + k * 10 + j;
                        if (MNL % 3 == 0)
                        {
                            specialN += 5;
                        }
                        else if (MNL % 5 == 0)
                        {
                            specialN -= 2;
                        }
                        else if (MNL % 2 == 0)
                        {
                            specialN *= 2;
                        }

                        if (specialN >= controlN)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialN}");
                            return;
                        }
                   
                    }
                }
            }
            if (specialN < controlN)
            {
                Console.WriteLine($"No! {specialN} is the last reached special number.");
            }

        }
    }
}
//Console.WriteLine($"{i} {k} {j}");