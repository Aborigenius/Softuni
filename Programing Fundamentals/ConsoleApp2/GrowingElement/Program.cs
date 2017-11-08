using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int lenghtCounter = 0;
            int compare1 = 0;
            int finalCounter = 0;
            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > compare1)
                {
                    lenghtCounter++;
                }
                else
                {
                    if (lenghtCounter > finalCounter)
                    {
                        finalCounter = lenghtCounter;
                    }
                    lenghtCounter = 1;
                }
                compare1 = num;

            }
            if (lenghtCounter > finalCounter)
            {
                finalCounter = lenghtCounter;
            }
            Console.WriteLine(finalCounter);
        }
    }
}
//                Console.WriteLine($" LC:{lenghtCounter} C:{compare1} NUM:{num} FC:{finalCounter}");

