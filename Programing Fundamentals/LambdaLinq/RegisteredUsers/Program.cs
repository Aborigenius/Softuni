using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> users = new Dictionary<string, DateTime>();
            string []input = Console.ReadLine().Split(new char[] { '-', '>', ' ' });

            while (input[0] != "end")
            {
                string name = input[0];
                string dateString = input[1];
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                input = Console.ReadLine().Split(new char[] { '-', '>', ' ' });
            }
        }
    }
}
