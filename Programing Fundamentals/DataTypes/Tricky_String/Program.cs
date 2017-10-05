using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string finalWords = "";
            for (int i = 0; i < n; i++)
            {
                if (i == n -1)
                {
                    string randomWords = Console.ReadLine();
                    finalWords += randomWords;
                }
                else
                {
                    string randomWords = Console.ReadLine();
                    finalWords += randomWords;
                    finalWords += delimeter;

                }

            }
            Console.WriteLine(finalWords);
        }
    }
}
