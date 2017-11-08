using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double staidumCapacity = double.Parse(Console.ReadLine());
            double fansNumber = double.Parse(Console.ReadLine());
            double A = 0;
            double B = 0;
            double V = 0;
            double G = 0;
            double fansPercentage = (fansNumber / staidumCapacity) * 100;


            for (int i = 0; i < fansNumber; i++)
            {
                var sector = Console.ReadLine();
                if (sector == "A")
                {
                    A++;
                }
                if (sector == "B")
                {
                    B++;
                }
                if (sector == "V")
                {
                    V++;
                }
                if (sector == "G")
                {
                    G++;
                }
            }

            double Apecentage = A / fansNumber * 100;
            double Bpercentage = B / fansNumber * 100;
            double Vpercentage = V / fansNumber * 100;
            double Gpercentage = G / fansNumber * 100;

            Console.WriteLine($"{Apecentage:f2}%");
            Console.WriteLine($"{Bpercentage:f2}%");
            Console.WriteLine($"{Vpercentage:f2}%");
            Console.WriteLine($"{Gpercentage:f2}%");
            Console.WriteLine($"{fansPercentage:f2}%");
        }
    }
}
