using System;
using System.IO;

namespace Streams
{
    class ReadFromFile
    {
        static void Main(string[] args)
        {
            string path = "../../../";
            string fileName = "Streams.cs";

            path = Path.Combine(path, fileName);

            using (StreamReader reader = new StreamReader(path))
            {
                string textLine = reader.ReadLine();
                int counter = 0;
                while (textLine != null)
                {
                    Console.WriteLine($"Line {++counter}: {textLine}");

                    textLine = reader.ReadLine();
                }
            
            }
            
        }
    }
}
