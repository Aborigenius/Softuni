using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighboursWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoStrike = int.Parse(Console.ReadLine());
            int GoshoStrike = int.Parse(Console.ReadLine());

            int PeshoHealth = 100;
            int GoshoHealth = 100;
            int round = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                round++;
                if (round % 2 == 0)
                {
                    PeshoHealth = PeshoHealth - GoshoStrike;
                    if (PeshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"{"Gosho"} won in {round}th round.");
                        break;
                    }
                    
                }
                else
                {
                    GoshoHealth = GoshoHealth - PeshoStrike;
                    if (GoshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                    }
                    else
                    {

                        Console.WriteLine($"{"Pesho"} won in {round}th round.");
                        break;
                    }
                }
                if (round % 3 == 0)
                {
                    GoshoHealth += 10;
                    PeshoHealth += 10;
                }
 
            }
        }
    }
}

