using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter1 = char.Parse(Console.ReadLine().ToLower());
            var letter2 = char.Parse(Console.ReadLine().ToLower());
            var disLetter = char.Parse(Console.ReadLine().ToLower());

            for (char i = letter1; i <= letter2; i++)
            {
                for (char k = letter1; k <= letter2; k++)
                {
                    for (char l = letter1; l <= letter2; l++)
                    {
                        if (i != disLetter && k != disLetter && l != disLetter)
                        {
                            Console.Write($"{i}{k}{l}" + " ");
                        }

                    }
                }
            }
        }
    }
}
