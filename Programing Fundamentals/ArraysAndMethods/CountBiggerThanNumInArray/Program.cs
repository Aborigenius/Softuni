using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountBiggerThanNumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = (Console.ReadLine());
            double counter = 0;
            double[] myArray = N.Split(' ').Select(t => Convert.ToDouble(t)).ToArray();

            double checkNumber = double.Parse(Console.ReadLine());

            foreach (var num in myArray)
            {
                if (checkNumber < num)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

        }
    }
}
