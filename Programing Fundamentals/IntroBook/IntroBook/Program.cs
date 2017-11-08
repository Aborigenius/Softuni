using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World!";
            object hw = (hello + " " + world);
            string result = hw as string;
            Console.WriteLine(result);
    }   }
}
