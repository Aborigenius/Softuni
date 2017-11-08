using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 2; i <= endNumber; i++)
            {
                if (IsPrime(i) == true)
                {
                    result.Add(i);
                }
                else
                {
                    continue;
                }
            }
            foreach (var n in result)
            {
                Console.Write(n +  " ");
            }
        }

        public static bool IsPrime(int endNumber)
        {
            if (endNumber == 1)
            {
                return false;
            }
            if (endNumber == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(endNumber)); i++)
            {
                if (endNumber % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
