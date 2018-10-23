using System;
using System.IO;
using System.Linq;

namespace Streams
{
    class ReadFromFile
    {
        static void Main(string[] args)
        {
            string path = "../../../";
            string inputFileName = "ReadReversed.cs";
            string outputFile = "reverse.txt";

            path = Path.Combine(path, inputFileName);

            using (StreamReader reader = new StreamReader(path))
            {
                string textLine = reader.ReadLine();
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    while (textLine != null)
                    {
                        Console.WriteLine(String.Join("", textLine.Reverse()));
                        writer.WriteLine(String.Join("", textLine.Reverse()));
                        textLine = reader.ReadLine();
                    }
                }

            }

        }
    }
}
