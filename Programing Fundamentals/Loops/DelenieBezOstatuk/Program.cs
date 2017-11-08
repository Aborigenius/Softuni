using System;

namespace DelenieBezOstatuk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var to2 = 0.00;
            var to3 = 0.00;
            var to4 = 0.00;

            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (currentNum % 2 == 0)
                {
                    to2 ++;
                }
                 if (currentNum % 3 == 0)
                {
                    to3 ++;
                }
                 if (currentNum % 4 == 0)
                {
                    to4 ++;
                }
            }
            double p1 = to2 /n *100;
            double p2 = to3 /n *100;
            double p3 = to4 /n *100;

            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
        }
    }
}
//if (i % 2 == 0)
//

/*using System;

namespace Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sump1 = 0.00;
            var sump2 = 0.00;
            var sump3 = 0.00;
            var sump4 = 0.00;
            var sump5 = 0.00;

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 200)
                {
                    sump1++;
                }
                else if (currentNum < 400)
                {
                    sump2 ++;
                }
                else if (currentNum < 600)
                {
                    sump3++;
                }
                else if (currentNum < 800)
                {
                    sump4++;
                }
                else
                {
                    sump5++;
                }


            }
            double p1 = sump1 * 100 / n;
            double p2 = sump2 * 100 / n;
            double p3 = sump3 * 100 / n;
            double p4 = sump4 * 100 / n;
            double p5 = sump5 * 100 / n;

            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
            Console.WriteLine("{0:F2}%", p4);
            Console.WriteLine("{0:F2}%", p5);
        }
    }
}
*/
