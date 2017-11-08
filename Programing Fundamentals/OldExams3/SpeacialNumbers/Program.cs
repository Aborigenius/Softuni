using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeacialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int startN = 1111;
            int endN = 9999;



            for (int i = startN; i <= endN; i++)
            {

                var first = (i / 1000) % 10;
                var second = (i / 100) % 10;
                var third = (i / 10) % 10;
                var fourth = (i / 1) % 10;
                if (first != 0 && second != 0 && third != 0 && fourth != 0)
                {
                    bool special = false;

                    special = (N % first == 0) &&
                    (N % second == 0) &&
                    (N % third == 0) &&
                    (N % fourth == 0);

                    if (special == true)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
           
        }
    }
}
