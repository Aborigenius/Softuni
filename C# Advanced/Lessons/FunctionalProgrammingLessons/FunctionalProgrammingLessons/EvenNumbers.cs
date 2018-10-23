using System;
using System.Linq;

namespace FunctionalProgrammingLessons
{
    class EvenNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", Console.ReadLine().Split(',')
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)));
        }
    }
}
