using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MiniLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new string[] { " ", ",", ".", "?", "!" }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> orderedText = new SortedSet<string>();
            foreach (var word in text)
            {
                if (IsPalindrome(word))
                {
                    orderedText.Add(word);
                }

            }
            foreach (var word in orderedText)
            {
                if (word != orderedText.Last())
                {
                    Console.Write(word + ", ");
             
                }
                else
                {
                    Console.Write(word);
                }
                
            }

        }

        public static bool IsPalindrome(string text)
        {
            int min = 0;
            int max = text.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = text[min];
                char b = text[max];
                //      if (char.ToLower(a) != char.ToLower(b))
                if (a !=  b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
