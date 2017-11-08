using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> myList = new List<string>(input.Split(' ')).ToList();

            for (int cnt = 1; cnt < myList.Count; cnt += 2)
            {
                Console.Write(myList[cnt]);
            }
            Console.WriteLine();
        }
    }
}
