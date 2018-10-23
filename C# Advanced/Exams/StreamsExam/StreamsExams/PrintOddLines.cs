using System;
using System.IO;

namespace StreamsExams
{
    class PrintOddLines
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../../Files/text.txt"))
            {
                string line;
                int lineNum = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNum %2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    lineNum++;
                }
            }
        }
    }
}
