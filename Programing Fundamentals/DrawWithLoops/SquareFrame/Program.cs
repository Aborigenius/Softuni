using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            #region FirstLine
            Console.Write("+ ");
            for (int row = 0; row < n -2 ; row++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
            #endregion
            for (int i = 0; i < n -2; i++)
            {


                Console.Write("| ");
                for (int c = 0; c < n - 2; c++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("| ");
            }


            #region LastLine
            Console.Write("+ ");
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
            #endregion
        }
    }
}
