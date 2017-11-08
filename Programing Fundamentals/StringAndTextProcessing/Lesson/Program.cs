using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "hello";
            //case sensitive
            int compare = string.Compare(str1, str2, false);
            //case Insensitive
            int compareCI = string.Compare(str1, str2, true);

            //Concatenation
            string concat = string.Concat(str1, str2);
            //or
            string concat2 = str1 + str2;

            Console.WriteLine(compare);
            Console.WriteLine(compareCI);

            Console.WriteLine(concat);
            Console.WriteLine(concat2);

            //find Index
            string email = "pesho@softuni.bg";
            int index = email.IndexOf("@");
            // email.LastIndexOf finds the last repeating index
            Console.WriteLine(index);

            //Substring by index
            string result = email.Substring(5);
            //take certain ammount of symbols after index
            string result2 = email.Substring(5, 7);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            //Splitting String
            // email = email.Split(' ', ',', '!', '@');
            //   Console.WriteLine(email);

            //Replace
            email = email.Replace("softuni", "harduni");
            //Replace All
            email = email.Replace("softuni", "harduni");

            //Remove between indexes
            // email = email.Remove(6, 7);

            //Trim TrimStart TrimEnd
            email = email.Trim();

            Console.WriteLine(email);

            StringBuilder builder = new StringBuilder();
            //      Stopwatch sw = new Stopwatch();
            //      string text = "";
            //      sw.Start();
            //      for (int i = 0; i < 1000; i++)
            //      {
            //          text += "a";
            //      }
            //
            //      //  Console.WriteLine(builder.ToString());
            //
            //      sw.Stop();
            //      Console.WriteLine($" Elapsed Ticks without StringBuilder: {sw.ElapsedTicks}");
            //      sw.Reset();
            //      sw.Start();
            //
            //      for (int i = 0; i < 1000; i++)
            //      {
            //          builder.Append("x");
            //      }
            //      sw.Stop();
            //
            //
            //      Console.WriteLine($" Elapsed Ticks with StringBuilder: {sw.ElapsedTicks}");

            for (int i = 0; i < 100; i++)
            {
                builder.Append('x');
                Console.WriteLine(builder.Length);
                Console.WriteLine(builder.Capacity);
            }



        }
    }
}