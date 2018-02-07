using System;
using System.IO;

namespace Write_To_File_Reversed
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var reader = new StreamReader("..//Files//text.txt"))
            {
                using (var writer = new StreamWriter("output.txt"))
                {
                    string line;
                    var lineNumber = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                 
                            writer.Write($"Line {lineNumber}: {line}");
                            lineNumber++;
                        
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}
