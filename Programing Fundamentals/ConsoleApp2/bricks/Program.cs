using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            double bricksNumber = double.Parse(Console.ReadLine());
            double workersNumber = double.Parse(Console.ReadLine());
            double cartCapacity = double.Parse(Console.ReadLine());

            var oneGoLoad = Math.Ceiling(bricksNumber /(workersNumber * cartCapacity));
            Console.WriteLine(oneGoLoad);

        }
    }
}
