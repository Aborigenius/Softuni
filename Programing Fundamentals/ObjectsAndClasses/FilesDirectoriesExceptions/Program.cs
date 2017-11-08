using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDirectoriesExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // write file
            // string text = "Hello there" + Environment.NewLine + "Mara ba Pesho!";
            // File.WriteAllText("output.txt", text);

            StreamWriter writer = new StreamWriter("output.txt");

            writer.WriteLine("Hello there!");
            writer.WriteLine("Pesho is a legend!");

            writer.Close();

            //read file
        //   string text = File.ReadAllText("output.txt");
        //   Console.WriteLine(text);
        //
          using (StreamReader reader = new StreamReader("output.txt"))
          {
              while (!reader.EndOfStream)
              {
                  string line = reader.ReadLine();
                  Console.WriteLine(line);
       
               }
            }

            //FileInfo

            FileInfo fileInfo = new FileInfo("output.txt");

            Console.WriteLine(fileInfo.Length / 1024.0);
            Console.WriteLine(fileInfo.Name);
 
        }
    }
}
