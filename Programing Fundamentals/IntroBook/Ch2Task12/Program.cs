using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Age: ");
            var age = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Gender(F or M): ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
