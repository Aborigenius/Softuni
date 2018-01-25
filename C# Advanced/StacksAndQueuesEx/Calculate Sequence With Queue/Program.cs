using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            Queue<long> sequenceQueue = new Queue<long>();
            Queue<long> helpSequence = new Queue<long>();
            Console.Write(N + " ");

            while (helpSequence.Count < 49)
            {
                sequenceQueue.Enqueue(N + 1);
                sequenceQueue.Enqueue((2 * N) + 1);
                sequenceQueue.Enqueue(N + 2);
                N = sequenceQueue.Dequeue();
                helpSequence.Enqueue(N);
   
            }
            PrlongValues(helpSequence);
        }

        public static void PrlongValues(IEnumerable myCollection)
        {
            foreach (var item in myCollection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }

}
