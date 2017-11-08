using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int pipeOneVolume = int.Parse(Console.ReadLine());
            int pipeTwoVolume = int.Parse(Console.ReadLine());
            double hoursMissing = double.Parse(Console.ReadLine());

            double water = (pipeOneVolume + pipeTwoVolume) * hoursMissing;
            double pipeOneTotal = pipeOneVolume * hoursMissing;
            double pipeTwoTotal = pipeTwoVolume * hoursMissing;


            var waterPercent = Math.Truncate(water / poolVolume * 100);
            var pipeOnePercent = Math.Truncate(pipeOneTotal / water * 100);
            var pipeTwoPercent = Math.Truncate(pipeTwoTotal / water * 100);

            if (water <= poolVolume)
            {
                Console.WriteLine($"The pool is {waterPercent}% full. Pipe 1: {pipeOnePercent}%. Pipe 2: {pipeTwoPercent}%.");
            }
            else
            {
                var overflow = Math.Truncate(water - poolVolume);
                Console.WriteLine($"For {hoursMissing} hours the pool overflows with {overflow} liters.");
            }

        }
    }
}
