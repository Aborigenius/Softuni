using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = decimal.Parse(Console.ReadLine());
            var numberTwo = decimal.Parse(Console.ReadLine());

            var bigger = Math.Max(numberOne, numberTwo);
            var smaler = Math.Min(numberOne, numberTwo);

            string biggerType = string.Empty;
            string smallerType = string.Empty;

            double overflowCouter = 0;

            if (bigger >= byte.MinValue && bigger <= byte.MaxValue)
            {
                Console.WriteLine("bigger type: byte");
                biggerType = "byte";
            }
            else if (bigger >= ushort.MinValue && bigger <= ushort.MaxValue)
            {
                Console.WriteLine("bigger type: ushort");
                biggerType = "ushort";
            }
            else if (bigger >= uint.MinValue && bigger <= uint.MaxValue)
            {
                Console.WriteLine("bigger type: uint");
                biggerType = "uint";
            }
            else if (bigger >= long.MinValue && bigger <= long.MaxValue)
            {
                Console.WriteLine("bigger type: long");
                biggerType = "long";
            }

            if (smaler >= byte.MinValue && smaler <= byte.MaxValue)
            {
                Console.WriteLine("smaller type: byte");
                smallerType = "byte";
                overflowCouter = Math.Round((double)bigger / byte.MaxValue);
            }
            else if (smaler >= ushort.MinValue && smaler <= ushort.MaxValue)
            {
                Console.WriteLine("smaller type: ushort");
                smallerType = "ushort";
                overflowCouter = (int)bigger / ushort.MaxValue;
            }
            else if (smaler >= uint.MinValue && smaler <= uint.MaxValue)
            {
                Console.WriteLine("smaller type: uint");
                smallerType = "uint";
                overflowCouter = (int)bigger / uint.MaxValue;
            }
            else if (smaler >= long.MinValue && smaler <= long.MaxValue)
            {
                Console.WriteLine("smaller type: long");
                smallerType = "long";
                overflowCouter = (int)bigger / long.MaxValue;
            }

                Console.WriteLine($"{bigger} can overflow {smallerType} {overflowCouter} times");
            }
        }
    }