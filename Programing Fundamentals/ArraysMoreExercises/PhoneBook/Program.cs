using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            Search(names, phoneNumbers);
        }
        static string Search(string[] names, string[] phoneNumbers)
        {
            string commands = String.Empty;
            string result = String.Empty;
            do
            {
                commands = Console.ReadLine();
                foreach (string x in names)
                {
                    if (x.Equals(commands))
                    {
                        int index1 = Array.IndexOf(names, x);
                        result = $"{names[index1]} -> {phoneNumbers[index1]}";
                    }
                    else
                    {
                        continue;
                    }
                }
            } while (commands != "done");
            return result;
        }
    }
}
/*          string search = Console.ReadLine();
            search = Array.FindAll(names, s => s.Equals(search));
            return search;
*/