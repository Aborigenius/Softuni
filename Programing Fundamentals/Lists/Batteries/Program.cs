using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] capacities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usage = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            List<double> result = new List<double>();
            int testHours = int.Parse(Console.ReadLine());

            for (int i = 0; i < usage.Length; i++)
            {
                if ((capacities[i] - (testHours * usage[i])) > 0)
                {
                    result.Add(capacities[i] - (testHours * usage[i]));
                }
                else
                {
                    result.Add(-Math.Ceiling((capacities[i]) / usage[i]));
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > 0)
                {
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", i + 1, result[i],
                                                (result[i] / capacities[i]) * 100);
                }
                else
                {
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", i+1, -result[i]);
                }
            }
        }
    }
}