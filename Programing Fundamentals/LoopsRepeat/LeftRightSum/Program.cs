using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var sum1 = 0.0;

            for (int i = 0; i < num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum = sum + n;
            }

            for (int i = 0; i < num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum1 = sum1 + n;
            }
            var sumAbs = Math.Abs(sum - sum1);
            if (sumAbs == 0)
            {
                Console.WriteLine($"Yes, sum {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff {sumAbs}");
            }
        }
    }
}
