using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("..//Files//text.txt"))
            {
               string line;
               var lineNum = 0;
               while ((line = reader.ReadLine()) != null)
                {
                    if (lineNum % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    lineNum++;
                }
            }
        }
    }
}
