using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordEncounter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] filterInput = Console.ReadLine().ToArray();

            char filterChar = filterInput.First();
            int filterNum = int.Parse(filterInput.Last().ToString());


            string input = Console.ReadLine();
            while (input != "end")
            {


                input = Console.ReadLine();
            }
        }
    }
}
