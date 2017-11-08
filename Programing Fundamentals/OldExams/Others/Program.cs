using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rochet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outerDashesCount = n / 2;
            int winth = 3 * n;
            int upperLeftDashesCount = (3 * n - 2) / 2;
            int inerSpasesCount = 0;
            int inerStarsCount = winth - 2 - 2 * (n / 2);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', upperLeftDashesCount), new string(' ', inerSpasesCount));
                upperLeftDashesCount--;
                inerSpasesCount += 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', outerDashesCount), new string('*', 2 * n));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine(@"{0}|{1}|{0}", new string('.', n / 2), new string('\\', winth - 2 - 2 * (n / 2)));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', outerDashesCount), new string('*', inerStarsCount));
                outerDashesCount--;
                inerStarsCount += 2;
            }
        }
    }
}