using System;

namespace ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var isMature = age >= 18;
            Console.WriteLine(isMature);

            if (age >= 18)
            {
                Console.WriteLine("You can have a beer!");
            }
            else
            {
                Console.WriteLine("Have a juice kiddo!");
            }
        }
    }
}
