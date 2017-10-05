using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = Console.ReadLine();
            var n2 = Console.ReadLine();

            var smaller = (Math.Max(n1, n2));
        }
    }
}
//byte, ushort, uint, ulong
//byte 0 0 255
//ushort 0 0 65535
//uint 0u 0 4294967295
//ulong 0u 0 18446744073709551615