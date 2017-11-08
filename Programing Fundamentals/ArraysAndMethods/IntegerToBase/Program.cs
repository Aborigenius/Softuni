using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberBaseTen = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            //    IntegerToBase(numberBaseTen, toBase);
            Console.WriteLine(IntegerToBase(numberBaseTen, toBase));
        }

        static string IntegerToBase(int numberBaseTen, int toBase)
        {
            string result = String.Empty;

            while (numberBaseTen > 0)
            {
                int remainder = numberBaseTen % toBase;
                result = result.Insert(0, remainder.ToString());
                numberBaseTen /= toBase;
              
            }
            return result;
        }
    }
}
