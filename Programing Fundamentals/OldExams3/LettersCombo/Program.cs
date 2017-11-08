using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombo
{
    class Program
    {
        static void Main(string[] args)
        {
            var startLetter = char.Parse(Console.ReadLine().ToLower());
            var endLetter = char.Parse(Console.ReadLine().ToLower());
            var magicLetter = char.Parse(Console.ReadLine().ToLower());

            var combo = 0;

            for (char firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
            {
                for (char secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
                {
                    for (char thirdLetter = startLetter; thirdLetter <= endLetter; thirdLetter++)
                    {
                        if (firstLetter != magicLetter && secondLetter != magicLetter && thirdLetter != magicLetter)
                        {

                        
                        Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                        combo++;
                        }
                    }
                }
            }
            Console.WriteLine(combo);
        }
    }
}
