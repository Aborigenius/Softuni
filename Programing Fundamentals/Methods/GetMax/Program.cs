using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            int result = GetMax(one, two, three);
            Console.WriteLine(result);
        }

        private static int GetMax(int one, int two, int three)
        {
            int r1 = Math.Max(one, two);
            int result = Math.Max(r1, three);
            return result;
        }
    }
}
