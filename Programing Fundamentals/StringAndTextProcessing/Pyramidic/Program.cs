using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramidic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> lines = new List<string>();
            for (int i = 0; i < n; i++)
            {
                lines.Add(Console.ReadLine());
            }
            List<string> allPyramids = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                for (int j = 0; j < line.Length; j++)
                {
                    char @char = line[j];
                    string pyramid = FindPyramid(@char, lines, i);
                    allPyramids.Add(pyramid);
                }
            }
            string biggst = allPyramids.OrderByDescending(p => p.Length).First();
            Console.WriteLine(biggst);
        }

        private static string FindPyramid(char @char, List<string> lines, int linenumber)
        {
            int count = 3;
            string pyramid = "" + @char + "\r\n";
            for (int i = linenumber +1; i < lines.Count; i++)
            {
                string toFind = new string(@char, count);

                if (lines[i].Contains(toFind))
                {
                    pyramid += toFind + "\r\n";
                    count += 2;
                }
                else
                {
                    return pyramid;
                }
            }
            return pyramid;
        }
    }
}
