using System;
using System.IO;

namespace Write_To_File_Reversed
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var reader = new StreamReader("Program.cs"))
            {
                using (var writer = new StreamWriter("c:\\Temp\\reversedwrite.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        for (int i = line.Length - 1; i >= 0; i--)
                        {
                            writer.Write(line[i]);
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}
