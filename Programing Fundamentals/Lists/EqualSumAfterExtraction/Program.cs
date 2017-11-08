using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string intList1 = Console.ReadLine();
            string intList2 = Console.ReadLine();
            List<int> list1 = intList1.Split(' ').Select(int.Parse).ToList();
            List<int> list2 = intList2.Split(' ').Select(int.Parse).ToList();

            list2 = list2.Except(list1).ToList();

            int sumList1 = list1.Sum();
            int sumList2 = list2.Sum();

            if (sumList1 == sumList2)
            {
                Console.WriteLine($"Yes. Sum: {sumList2}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumList1 -sumList2)}");
            }
        }
    }
}
