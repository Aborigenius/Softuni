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

            string number = $"{M}{N}{L}";
            int n1 = int.Parse(number);
            for (int i = n1; i >= 111; i--)
            {

                if (specialN <= controlN)
                {
                    if (i % 3 == 0)
                    {
                        specialN += 5;
                    }
                    else if (i % 10 == 5)
                    {
                        specialN -= 2;
                    }
                    else if (i % 2 == 0)
                    {
                        specialN *= 2;
                    }

                }
            }
            if (specialN >= controlN)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialN}.");
            }
            else
            {
                Console.WriteLine($"No! {specialN} is the last reached special number.");    
            }
        }
    }
}
