using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesLAB
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\temp\file.txt";
     //     if (File.Exists(path))
     //     {
     //         File.Delete(path);
     //     }

            //read file
            //   string text = File.ReadAllText("output.txt");
            //   Console.WriteLine(text);
            //



            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string lines = reader.ReadLine();

                    StreamWriter writer = new StreamWriter("output.txt");

                    writer.WriteLine(lines.Where((line, index) => index % 2 == 1));
                    writer.Close();
                }
            }


        }
    }
}
