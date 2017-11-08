using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userCred = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "login")
            {
                string username = input[0];
                string password = input[1];

                userCred[username] = password;
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            int failed = 0;
            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            while (input[0] !="end")
            {

                string username = input[0];
                string password = input[1];
                if (!userCred.ContainsKey(username) || userCred[username] != password)
                {
                    failed++;
                    Console.WriteLine($"{username}: login failed");
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"unsuccessful login attempts: {failed}");
        }
    }
}
