using System;
using System.IO;

namespace Print_Line_Numbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../../Files/text.txt"))
            {
                string line;
                int lineNum = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Line {lineNum}: {line}");
                    lineNum++;
                }
            }
        }
    }
}
