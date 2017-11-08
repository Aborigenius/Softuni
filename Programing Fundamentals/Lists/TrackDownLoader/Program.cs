using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            string blacklist = Console.ReadLine();
            List<string> blacklisted = new List<string>(blacklist.Split(' ')).ToList();
            string filenames = string.Empty;
            List<string> result = new List<string>();
            while (filenames != "end")
            {
                filenames = Console.ReadLine();
                if (blacklisted.Any(filenames.Contains) || filenames == "end")
                {
                    continue;
                }
                else
                {
                    result.Add(filenames);
                }
            }
            result.Sort();
            for (int cnt = 0; cnt < result.Count; cnt++)
            {
                Console.WriteLine(result[cnt]);
            }

        }
    }
}
