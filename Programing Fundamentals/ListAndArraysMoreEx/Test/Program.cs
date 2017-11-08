using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNumber = int.Parse(Console.ReadLine());

            LinearSearch(inputArray, specialNumber);
            //  bool swapped = false;

            int[] binaryArray = inputArray.ToArray();
            Array.Sort(binaryArray);

            int binres = BinarySearch(binaryArray, specialNumber);
            Console.WriteLine($"Binary search made {binres} iterations");
        }

        static void LinearSearch(int[] arr, int number)
        {
            int iterations = 0;
            bool isNumberFound = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    iterations++;
                    Console.WriteLine("Yes");
                    isNumberFound = true;
                    break;
                }
                else if (arr.Length - 1 != number)
                {
                    isNumberFound = false;
                }
                iterations++;
            }
            if (!isNumberFound)
            {
                Console.WriteLine("No");
            }
            Console.WriteLine($"Linear search made {iterations} iterations");

        }

        static int BinarySearch(int[] binaryArray, int specialNumber)
        {
            int min = 0;
            int max = binaryArray.Length - 1;
            int iterations = 0;
            do
            {
                iterations++;
                int mid = (min + max) / 2;
                if (binaryArray[mid] < specialNumber)
                    min = mid + 1;
                else
                    max = mid - 1;
                if (binaryArray[mid] == specialNumber)
                    return iterations;
            } while (min <= max);
            return iterations;
        }

    }
}