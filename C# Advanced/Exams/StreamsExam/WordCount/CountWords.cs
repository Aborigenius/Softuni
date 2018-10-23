using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> contains = new Dictionary<string, int>();
            using (var readTheWords = new StreamReader("../../../../Files/words.txt"))
            {
                StreamReader sr = new StreamReader("../../../../Files/text.txt");
                string[] text = sr.ReadToEnd().ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries); ;
                string wordsLine;

                while ((wordsLine = readTheWords.ReadLine()) != null)
                {
                    if (!contains.ContainsKey(wordsLine))
                    {
                        contains.Add(wordsLine, 0);
                    }
                }
                foreach (var word in text)
                {
                    if (contains.ContainsKey(word))
                    {
                        contains[word] += 1;
                    }
                }
                using (var writer = new StreamWriter("../../../../Files/result.txt"))
                {

                }
            }
            foreach (var item in contains.OrderByDescending(v => v.Value))
            {
                File.AppendAllText(@"../../../../Files/result.txt", $"{ item.Key} - { item.Value}{Environment.NewLine}");
            }
        }
    }
}