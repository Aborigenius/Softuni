using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] inputArray = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            int sequnceCount = 0;
            int current = 0;
            int next = 1;

            for (int i = 0; i < inputArray.Length-1; i++)
            {
              
                if (inputArray[current] + 1 == inputArray[next])
                {
                    Console.WriteLine($"Current: {inputArray[current]}");
                    Console.WriteLine($"Next: {inputArray[next]}");
                    sequnceCount++;
                    if (!result.Contains(inputArray[current]))
                    {
                        result.Add(inputArray[current]);
                    }
                   
                    result.Add(inputArray[next]);
                }
                else
                {
                    sequnceCount = 0;
                }
                current++;
                next++;
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
