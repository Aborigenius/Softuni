using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = array.Length / 4;

            int[] leftArr = array.Take(k).ToArray();
            int[] midArr = array.Skip(k).Take(k * 2).ToArray();
            int[] rightArr = array.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] sum = new int[midArr.Length];

            for (int i = 0; i < k; i++)
            {
                sum[i] = midArr[i] + leftArr[i];
                sum[i + k] = midArr[i + k] + rightArr[i];
            }

            foreach (var n in sum)
            {
                Console.Write(n + " ");
            }

        }
    }
}
