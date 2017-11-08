using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CharASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            Console.Write("Enter the character: ");
            character = Char.Parse(Console.ReadLine());
            Console.WriteLine("The ASCII value of '" + character + "' using (int)character: " + (int)character);
            byte[] charByte = Encoding.ASCII.GetBytes(character.ToString());
            Console.WriteLine("The ASCII value of '" + character + "' using Encoding.ASCII.GetBytes(): " + charByte[0]);
            Console.ReadLine();
        }
    }
}