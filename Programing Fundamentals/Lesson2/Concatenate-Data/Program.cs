using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var fn = Console.ReadLine();
            var ln = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            // Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}. ", fn, ln, age, town);
            Console.WriteLine(($"Hello {fn} {ln}, you are {age} old from {town}"));
        }
    }
}
