using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokFirstPlayer = int.Parse(Console.ReadLine());
            int pokSecondPlayer = int.Parse(Console.ReadLine());
            int maxNumberOfBattles= int.Parse(Console.ReadLine());

       

            for (int i = 1; i <= pokFirstPlayer; i++)
            {
                for (int f = 1; f <= pokSecondPlayer; f++)
                {
                  
                    Console.Write($"({i} <-> {f}) ");
                    
                    maxNumberOfBattles--;
                    if (maxNumberOfBattles == 0)
                    {
                        
                        return;
                    }
                }
                
            }
            
            
        }
    }
}

