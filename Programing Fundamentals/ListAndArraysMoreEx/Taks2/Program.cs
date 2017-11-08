using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] uniqueInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchElement = int.Parse(Console.ReadLine());

            int linearResult = LinearSearch(uniqueInts, searchElement);

            int[] binaryArray = uniqueInts.ToArray();

            Array.Sort(binaryArray);

            int binaryResult = BinarySearch(binaryArray, searchElement);
            if (linearResult > 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Linear search made {linearResult + 1} iterations");
                Console.WriteLine($"Binary search made {binaryResult} iterations");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Linear search made {uniqueInts.Length} iterations");
                Console.WriteLine($"Binary search made {binaryResult} iterations");
            }


        }

        static int LinearSearch(int[] uniqueInts, int searchElement)
        {
            for (int i = 0; i < uniqueInts.Length; i++)
            {
                if (uniqueInts[i] == searchElement)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int BinarySearch(int[] binaryArray, int searchElement)
        {
            int min = 0;
            int max = binaryArray.Length-1;
            int count = 0;
            do
            {
                count++;
                int mid = (min + max) / 2;
                if (binaryArray[mid] < searchElement)
                    min = mid + 1;
                else
                    max = mid - 1;
                if (binaryArray[mid] == searchElement)
                    return count;
                //if (min > max)
                //   break;
            } while (min <= max);
            return count;
        }
    }
}
